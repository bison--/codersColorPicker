namespace colorPicker
{
    partial class frmColorPicker
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmColorPicker));
            this.spltContainer = new System.Windows.Forms.SplitContainer();
            this.picMain = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSelectedFile = new System.Windows.Forms.TextBox();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFormat = new System.Windows.Forms.TextBox();
            this.cmdFolder = new System.Windows.Forms.Button();
            this.ofdImage = new System.Windows.Forms.OpenFileDialog();
            this.label3 = new System.Windows.Forms.Label();
            this.picLastColor = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.picMouseColor = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.spltContainer)).BeginInit();
            this.spltContainer.Panel1.SuspendLayout();
            this.spltContainer.Panel2.SuspendLayout();
            this.spltContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLastColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMouseColor)).BeginInit();
            this.SuspendLayout();
            // 
            // spltContainer
            // 
            this.spltContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.spltContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spltContainer.Location = new System.Drawing.Point(0, 0);
            this.spltContainer.Name = "spltContainer";
            // 
            // spltContainer.Panel1
            // 
            this.spltContainer.Panel1.Controls.Add(this.cmdFolder);
            this.spltContainer.Panel1.Controls.Add(this.txtSelectedFile);
            this.spltContainer.Panel1.Controls.Add(this.label1);
            this.spltContainer.Panel1.Controls.Add(this.picMain);
            // 
            // spltContainer.Panel2
            // 
            this.spltContainer.Panel2.Controls.Add(this.picMouseColor);
            this.spltContainer.Panel2.Controls.Add(this.label4);
            this.spltContainer.Panel2.Controls.Add(this.picLastColor);
            this.spltContainer.Panel2.Controls.Add(this.label3);
            this.spltContainer.Panel2.Controls.Add(this.txtFormat);
            this.spltContainer.Panel2.Controls.Add(this.label2);
            this.spltContainer.Panel2.Controls.Add(this.txtOutput);
            this.spltContainer.Size = new System.Drawing.Size(589, 372);
            this.spltContainer.SplitterDistance = 355;
            this.spltContainer.TabIndex = 0;
            // 
            // picMain
            // 
            this.picMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picMain.Location = new System.Drawing.Point(12, 45);
            this.picMain.Name = "picMain";
            this.picMain.Size = new System.Drawing.Size(338, 313);
            this.picMain.TabIndex = 0;
            this.picMain.TabStop = false;
            this.picMain.Click += new System.EventHandler(this.picMain_Click);
            this.picMain.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picMain_MouseMove);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "File:";
            // 
            // txtSelectedFile
            // 
            this.txtSelectedFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSelectedFile.Location = new System.Drawing.Point(44, 12);
            this.txtSelectedFile.Name = "txtSelectedFile";
            this.txtSelectedFile.ReadOnly = true;
            this.txtSelectedFile.Size = new System.Drawing.Size(271, 20);
            this.txtSelectedFile.TabIndex = 2;
            // 
            // txtOutput
            // 
            this.txtOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOutput.Location = new System.Drawing.Point(3, 138);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.Size = new System.Drawing.Size(222, 229);
            this.txtOutput.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Format:";
            // 
            // txtFormat
            // 
            this.txtFormat.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFormat.Location = new System.Drawing.Point(3, 112);
            this.txtFormat.Name = "txtFormat";
            this.txtFormat.Size = new System.Drawing.Size(219, 20);
            this.txtFormat.TabIndex = 2;
            this.txtFormat.Text = "_{0} = \'{0}\', _(\'{0}\')";
            // 
            // cmdFolder
            // 
            this.cmdFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdFolder.Image = global::colorPicker.Properties.Resources.folder;
            this.cmdFolder.Location = new System.Drawing.Point(321, 7);
            this.cmdFolder.Name = "cmdFolder";
            this.cmdFolder.Size = new System.Drawing.Size(29, 29);
            this.cmdFolder.TabIndex = 3;
            this.cmdFolder.UseVisualStyleBackColor = true;
            this.cmdFolder.Click += new System.EventHandler(this.cmdFolder_Click);
            // 
            // ofdImage
            // 
            this.ofdImage.Filter = "Images|*.png;*.jpg;*.jpeg;*.bmp|ALL FILES|*.*";
            this.ofdImage.FileOk += new System.ComponentModel.CancelEventHandler(this.ofdImage_FileOk);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "last color:";
            // 
            // picLastColor
            // 
            this.picLastColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picLastColor.Location = new System.Drawing.Point(61, 73);
            this.picLastColor.Name = "picLastColor";
            this.picLastColor.Size = new System.Drawing.Size(25, 13);
            this.picLastColor.TabIndex = 4;
            this.picLastColor.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(92, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "color under mouse:";
            // 
            // picMouseColor
            // 
            this.picMouseColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picMouseColor.Location = new System.Drawing.Point(195, 73);
            this.picMouseColor.Name = "picMouseColor";
            this.picMouseColor.Size = new System.Drawing.Size(25, 13);
            this.picMouseColor.TabIndex = 6;
            this.picMouseColor.TabStop = false;
            // 
            // frmColorPicker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 372);
            this.Controls.Add(this.spltContainer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmColorPicker";
            this.Text = "Color Picker";
            this.Load += new System.EventHandler(this.frmColorPicker_Load);
            this.spltContainer.Panel1.ResumeLayout(false);
            this.spltContainer.Panel1.PerformLayout();
            this.spltContainer.Panel2.ResumeLayout(false);
            this.spltContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spltContainer)).EndInit();
            this.spltContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLastColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMouseColor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer spltContainer;
        private System.Windows.Forms.Button cmdFolder;
        private System.Windows.Forms.TextBox txtSelectedFile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picMain;
        private System.Windows.Forms.TextBox txtFormat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.OpenFileDialog ofdImage;
        private System.Windows.Forms.PictureBox picLastColor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox picMouseColor;
        private System.Windows.Forms.Label label4;
    }
}

