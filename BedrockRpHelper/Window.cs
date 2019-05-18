using Newtonsoft.Json;
using System;
using System.IO;
using System.IO.Compression;
using System.Windows.Forms;

namespace BedrockRpHelper
{
    public partial class BedrockPackHelper : Form
    {
        private static string[] behaviorPaths = { "entities", "loot_tables", "trading", "scripts" };
        private static string[] resourcePaths = { "models", "sounds", "texts", "textures", "ui" };
        private static string[] skinPaths = { "texts" };

        public BedrockPackHelper()
        {
            InitializeComponent();
        }

        private void SelectIcon_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog
            {
                Title = "Select Icon",
                Filter = "Image Files (*.png;)| *.png"
            };
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                iconPath.Text = fileDialog.FileName;
            }
        }

        private void selectOutputPath_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog browserDialog = new FolderBrowserDialog();
            if (browserDialog.ShowDialog() == DialogResult.OK)
            {
                outputPath.Text = browserDialog.SelectedPath;
            }
        }

        private void Generate_Click(object sender, EventArgs e)
        {
            MainJson json = new MainJson
            {
                modules = new Modules[1]
            };
            json.header.version = new int[3];
            json.header.minEngineVersion = new int[3];
            json.modules[0].version = new int[3];

            json.formatVersion = 1;

            json.header.name = packName.Text;
            if (packType.SelectedIndex != 2)
                json.header.description = packDescription.Text;
            json.header.uuid = Guid.NewGuid().ToString();
            json.header.version[0] = Convert.ToInt32(packVersionMajor.Text);
            json.header.version[1] = Convert.ToInt32(packVersionMinor.Text);
            json.header.version[2] = Convert.ToInt32(packVersionPatch.Text);

            json.header.minEngineVersion[0] = Convert.ToInt32(minEngineVersionMajor.Text);
            json.header.minEngineVersion[1] = Convert.ToInt32(minEngineVersionMinor.Text);
            json.header.minEngineVersion[2] = Convert.ToInt32(minEngineVersionPatch.Text);

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
                case 3:
                    json.modules[0].type = "world_template";
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
            if (outputPath.Text != string.Empty)
            {
                string uuid = Guid.NewGuid().ToString();
                try
                {
                    Directory.CreateDirectory($"{output}/ResourcePack_{uuid}");

                    switch (packType.SelectedIndex)
                    {
                        case 0:
                            GenerateFolders(behaviorPaths, output, uuid);
                            break;
                        case 1:
                            GenerateFolders(resourcePaths, output, uuid);
                            break;
                        case 2:
                            GenerateFolders(skinPaths, output, uuid);
                            break;
                    }

                    File.WriteAllText($"{output}/ResourcePack_{uuid}/manifest.json", jsonResult);

                    if (iconPath.Text != string.Empty)
                    {
                        File.Copy(icon, $"{output}/ResourcePack_{uuid}/pack_icon.png");
                    }

                    if (exportAs.SelectedIndex == 0)
                    {
                        ZipFile.CreateFromDirectory($"{output}/ResourcePack_{uuid}/", $"{output}/{packName.Text}.zip");
                        Directory.Delete($"{output}/ResourcePack_{uuid}", true);
                    }
                    else if (exportAs.SelectedIndex == 1)
                    {
                        ZipFile.CreateFromDirectory($"{output}/ResourcePack_{uuid}/", $"{output}/{packName.Text}.mcpack");
                        Directory.Delete($"{output}/ResourcePack_{uuid}", true);
                    }
                    else
                    {
                        Directory.Move($"{output}/ResourcePack_{uuid}", $"{output}/{packName.Text}");
                    }
                    MessageBox.Show("Template pack generated succesfully!", "Success!", MessageBoxButtons.OK);
                }
                catch (IOException e)
                {
                    MessageBox.Show(e.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("You must specify an output path!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GenerateFolders(string[] template, string output, string uuid)
        {
            for (int i = 0; i < template.Length; i++)
            {
                Directory.CreateDirectory($"{output}/ResourcePack_{uuid}/{template[i]}");
            }
        }

        private void packType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (packType.SelectedIndex == 2)
            {
                packDescription.Enabled = false;
            }
            else
            {
                packDescription.Enabled = true;
            }
        }

        private void TextboxKeyDown(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void BedrockPackHelper_Load(object sender, EventArgs e)
        {
            packType.SelectedIndex = 0;
            exportAs.SelectedIndex = 1;
            outputPath.Text = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Packages\\Microsoft.MinecraftUWP_8wekyb3d8bbwe\\LocalState\\games\\com.mojang\\development_resource_packs");
        }
    }
}