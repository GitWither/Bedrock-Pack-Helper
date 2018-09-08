﻿using System;
using System.IO;
using System.IO.Compression;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace BedrockRpHelper
{
    public partial class BedrockPackHelper : Form
    {
        public BedrockPackHelper()
        {
            InitializeComponent();
            packType.SelectedIndex = 0;
            exportAs.SelectedIndex = 1;
        }

        private void SelectIcon_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog
            {
                Title = "Select Icon",
                Filter = "Image Files (*.png;)| *.png"
            };
            if (fileDialog.ShowDialog() == DialogResult.OK)
                iconPath.Text = fileDialog.FileName;
        }

        private void selectOutputPath_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog browserDialog = new FolderBrowserDialog();
            if(browserDialog.ShowDialog() == DialogResult.OK)
                outputPath.Text = browserDialog.SelectedPath;
        }

        private void Generate_Click(object sender, EventArgs e)
        {
            MainJson json = new MainJson();
            json.modules = new Modules[1];
            json.header.version = new int[3];
            json.modules[0].version = new int[3];

            json.formatVersion = 1;

            json.header.name = packName.Text;
            if(packType.SelectedIndex != 2)
            json.header.description = packDescription.Text;
            json.header.uuid = Guid.NewGuid().ToString();
            json.header.version[0] = Convert.ToInt32(packVersionMajor.Text);
            json.header.version[1] = Convert.ToInt32(packVersionMinor.Text);
            json.header.version[2] = Convert.ToInt32(packVersionPatch.Text);

            switch (packType.SelectedIndex)
            {
                case 0:
                    json.modules[0].type = "data";
                    break;
                case 1:
                    json.modules[0].type = "resources";
                    break;
                case 2:
                    json.modules[0].type = "skin_pack";
                    break;
                default:
                    json.modules[0].type = "resources";
                    break;
            }
            json.modules[0].uuid = Guid.NewGuid().ToString();
            json.modules[0].version[0] = Convert.ToInt32(packVersionMajor.Text);
            json.modules[0].version[1] = Convert.ToInt32(packVersionMinor.Text);
            json.modules[0].version[2] = Convert.ToInt32(packVersionPatch.Text);

            string result = JsonConvert.SerializeObject(json, Formatting.Indented);
            string output = outputPath.Text;
            string icon = iconPath.Text;
            GenerateFiles(result, output, icon);

        }

        private void GenerateFiles(string jsonResult, string output, string icon)
        {
            if (outputPath.Text != "")
            {
                string uuid = Guid.NewGuid().ToString();
                try
                {
                    Directory.CreateDirectory($"{output}/ResourcePack_{uuid}");

                    File.WriteAllText($"{output}/ResourcePack_{uuid}/manifest.json", jsonResult);
                    if (iconPath.Text != "")
                        File.Copy(icon, $"{output}/ResourcePack_{uuid}/pack_icon.png");
                    if (exportAs.SelectedIndex == 0)
                        ZipFile.CreateFromDirectory($"{output}/ResourcePack_{uuid}/", $"{output}/{packName.Text}.zip");
                    else
                        ZipFile.CreateFromDirectory($"{output}/ResourcePack_{uuid}/", $"{output}/{packName.Text}.mcpack");

                    Directory.Delete($"{output}/ResourcePack_{uuid}", true);
                }
                catch (IOException e)
                {
                    MessageBox.Show(e.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
                MessageBox.Show("You must specify an output path!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void packType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (packType.SelectedIndex == 2)
                packDescription.Enabled = false;
            else
                packDescription.Enabled = true;
        }

        private void TextboxKeyDown(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}