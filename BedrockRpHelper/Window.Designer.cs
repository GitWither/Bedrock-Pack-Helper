namespace BedrockRpHelper
{
    partial class BedrockPackHelper
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.packName = new System.Windows.Forms.TextBox();
            this.title = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Generate = new System.Windows.Forms.Button();
            this.packDescription = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.packType = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.packVersionMajor = new System.Windows.Forms.TextBox();
            this.packVersionMinor = new System.Windows.Forms.TextBox();
            this.packVersionPatch = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.iconPath = new System.Windows.Forms.TextBox();
            this.SelectIcon = new System.Windows.Forms.Button();
            this.selectOutputPath = new System.Windows.Forms.Button();
            this.outputPath = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.exportAs = new System.Windows.Forms.ComboBox();
            this.minEngineVersionPatch = new System.Windows.Forms.TextBox();
            this.minEngineVersionMinor = new System.Windows.Forms.TextBox();
            this.minEngineVersionMajor = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // packName
            // 
            this.packName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.packName.Location = new System.Drawing.Point(16, 65);
            this.packName.Name = "packName";
            this.packName.Size = new System.Drawing.Size(325, 20);
            this.packName.TabIndex = 0;
            this.packName.Text = "My Pack";
            // 
            // title
            // 
            this.title.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.title.Location = new System.Drawing.Point(79, 9);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(214, 25);
            this.title.TabIndex = 1;
            this.title.Text = "Bedrock Pack Helper";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Pack Name:";
            // 
            // Generate
            // 
            this.Generate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Generate.Location = new System.Drawing.Point(16, 417);
            this.Generate.Name = "Generate";
            this.Generate.Size = new System.Drawing.Size(325, 23);
            this.Generate.TabIndex = 11;
            this.Generate.Text = "Generate";
            this.Generate.UseVisualStyleBackColor = true;
            this.Generate.Click += new System.EventHandler(this.Generate_Click);
            // 
            // packDescription
            // 
            this.packDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.packDescription.Location = new System.Drawing.Point(15, 104);
            this.packDescription.Multiline = true;
            this.packDescription.Name = "packDescription";
            this.packDescription.Size = new System.Drawing.Size(326, 61);
            this.packDescription.TabIndex = 1;
            this.packDescription.Text = "My Description";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Pack Description:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Pack Type:";
            // 
            // packType
            // 
            this.packType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.packType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.packType.FormattingEnabled = true;
            this.packType.Items.AddRange(new object[] {
            "Behavior Pack",
            "Resource Pack",
            "Skin Pack"});
            this.packType.Location = new System.Drawing.Point(16, 184);
            this.packType.Name = "packType";
            this.packType.Size = new System.Drawing.Size(325, 21);
            this.packType.TabIndex = 2;
            this.packType.SelectedIndexChanged += new System.EventHandler(this.packType_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Pack Version:";
            // 
            // packVersionMajor
            // 
            this.packVersionMajor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.packVersionMajor.Location = new System.Drawing.Point(16, 224);
            this.packVersionMajor.Name = "packVersionMajor";
            this.packVersionMajor.Size = new System.Drawing.Size(62, 20);
            this.packVersionMajor.TabIndex = 3;
            this.packVersionMajor.Text = "1";
            this.packVersionMajor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextboxKeyDown);
            // 
            // packVersionMinor
            // 
            this.packVersionMinor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.packVersionMinor.Location = new System.Drawing.Point(84, 224);
            this.packVersionMinor.Name = "packVersionMinor";
            this.packVersionMinor.Size = new System.Drawing.Size(62, 20);
            this.packVersionMinor.TabIndex = 4;
            this.packVersionMinor.Text = "0";
            this.packVersionMinor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextboxKeyDown);
            // 
            // packVersionPatch
            // 
            this.packVersionPatch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.packVersionPatch.Location = new System.Drawing.Point(152, 224);
            this.packVersionPatch.Name = "packVersionPatch";
            this.packVersionPatch.Size = new System.Drawing.Size(62, 20);
            this.packVersionPatch.TabIndex = 5;
            this.packVersionPatch.Text = "0";
            this.packVersionPatch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextboxKeyDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(76, 231);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(10, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = ".";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(144, 231);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(10, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = ".";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 290);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Pack Icon:";
            // 
            // iconPath
            // 
            this.iconPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.iconPath.Location = new System.Drawing.Point(16, 309);
            this.iconPath.Name = "iconPath";
            this.iconPath.Size = new System.Drawing.Size(292, 20);
            this.iconPath.TabIndex = 6;
            // 
            // SelectIcon
            // 
            this.SelectIcon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SelectIcon.Location = new System.Drawing.Point(314, 307);
            this.SelectIcon.Name = "SelectIcon";
            this.SelectIcon.Size = new System.Drawing.Size(27, 23);
            this.SelectIcon.TabIndex = 7;
            this.SelectIcon.Text = "...";
            this.SelectIcon.UseVisualStyleBackColor = true;
            this.SelectIcon.Click += new System.EventHandler(this.SelectIcon_Click);
            // 
            // selectOutputPath
            // 
            this.selectOutputPath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.selectOutputPath.Location = new System.Drawing.Point(314, 347);
            this.selectOutputPath.Name = "selectOutputPath";
            this.selectOutputPath.Size = new System.Drawing.Size(27, 23);
            this.selectOutputPath.TabIndex = 9;
            this.selectOutputPath.Text = "...";
            this.selectOutputPath.UseVisualStyleBackColor = true;
            this.selectOutputPath.Click += new System.EventHandler(this.selectOutputPath_Click);
            // 
            // outputPath
            // 
            this.outputPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.outputPath.Location = new System.Drawing.Point(16, 348);
            this.outputPath.Name = "outputPath";
            this.outputPath.Size = new System.Drawing.Size(292, 20);
            this.outputPath.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 332);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Output Directory:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 371);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Export As:";
            // 
            // exportAs
            // 
            this.exportAs.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.exportAs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.exportAs.FormattingEnabled = true;
            this.exportAs.Items.AddRange(new object[] {
            "Archive",
            "Minecraft Pack"});
            this.exportAs.Location = new System.Drawing.Point(15, 387);
            this.exportAs.Name = "exportAs";
            this.exportAs.Size = new System.Drawing.Size(325, 21);
            this.exportAs.TabIndex = 10;
            // 
            // minEngineVersionPatch
            // 
            this.minEngineVersionPatch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.minEngineVersionPatch.Location = new System.Drawing.Point(152, 265);
            this.minEngineVersionPatch.Name = "minEngineVersionPatch";
            this.minEngineVersionPatch.Size = new System.Drawing.Size(62, 20);
            this.minEngineVersionPatch.TabIndex = 21;
            this.minEngineVersionPatch.Text = "0";
            // 
            // minEngineVersionMinor
            // 
            this.minEngineVersionMinor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.minEngineVersionMinor.Location = new System.Drawing.Point(84, 265);
            this.minEngineVersionMinor.Name = "minEngineVersionMinor";
            this.minEngineVersionMinor.Size = new System.Drawing.Size(62, 20);
            this.minEngineVersionMinor.TabIndex = 20;
            this.minEngineVersionMinor.Text = "8";
            // 
            // minEngineVersionMajor
            // 
            this.minEngineVersionMajor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.minEngineVersionMajor.Location = new System.Drawing.Point(16, 265);
            this.minEngineVersionMajor.Name = "minEngineVersionMajor";
            this.minEngineVersionMajor.Size = new System.Drawing.Size(62, 20);
            this.minEngineVersionMajor.TabIndex = 19;
            this.minEngineVersionMajor.Text = "1";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(13, 249);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(125, 13);
            this.label10.TabIndex = 22;
            this.label10.Text = "Minimum Engine Version:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(76, 272);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(10, 13);
            this.label11.TabIndex = 23;
            this.label11.Text = ".";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(144, 272);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(10, 13);
            this.label12.TabIndex = 24;
            this.label12.Text = ".";
            // 
            // BedrockPackHelper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 444);
            this.Controls.Add(this.minEngineVersionPatch);
            this.Controls.Add(this.minEngineVersionMinor);
            this.Controls.Add(this.minEngineVersionMajor);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.exportAs);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.selectOutputPath);
            this.Controls.Add(this.outputPath);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.SelectIcon);
            this.Controls.Add(this.iconPath);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.packVersionPatch);
            this.Controls.Add(this.packVersionMinor);
            this.Controls.Add(this.packVersionMajor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.packType);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.packDescription);
            this.Controls.Add(this.Generate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.title);
            this.Controls.Add(this.packName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "BedrockPackHelper";
            this.Text = "Bedrock Pack Helper";
            this.Load += new System.EventHandler(this.BedrockPackHelper_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox packName;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Generate;
        private System.Windows.Forms.TextBox packDescription;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox packType;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox packVersionMajor;
        private System.Windows.Forms.TextBox packVersionMinor;
        private System.Windows.Forms.TextBox packVersionPatch;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox iconPath;
        private System.Windows.Forms.Button SelectIcon;
        private System.Windows.Forms.Button selectOutputPath;
        private System.Windows.Forms.TextBox outputPath;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox exportAs;
        private System.Windows.Forms.TextBox minEngineVersionPatch;
        private System.Windows.Forms.TextBox minEngineVersionMinor;
        private System.Windows.Forms.TextBox minEngineVersionMajor;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
    }
}

