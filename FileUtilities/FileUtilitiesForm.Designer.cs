
namespace FileUtilities
{
    partial class FileUtilitiesForm
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
            this.components = new System.ComponentModel.Container();
            FileUtilities.StringSearch.StringSearcher stringSearcher1 = new FileUtilities.StringSearch.StringSearcher();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FileUtilitiesForm));
            System.Diagnostics.Stopwatch stopwatch1 = new System.Diagnostics.Stopwatch();
            FileUtilities.StringSearch.StringSearcher stringSearcher2 = new FileUtilities.StringSearch.StringSearcher();
            System.Diagnostics.Stopwatch stopwatch2 = new System.Diagnostics.Stopwatch();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.replaceInFiles = new FileUtilities.Controls.ReplaceInFilesControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.changeConfigControl1 = new FileUtilities.Controls.ChangeConfigControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.configGenerator = new FileUtilities.Controls.ConfigGeneratorControl();
            this.imgList = new System.Windows.Forms.ImageList(this.components);
            this.rtbInfo = new System.Windows.Forms.RichTextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage3);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.ImageList = this.imgList;
            this.tabControl.Location = new System.Drawing.Point(13, 13);
            this.tabControl.Name = "tabControl";
            this.tabControl.Padding = new System.Drawing.Point(10, 6);
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(901, 209);
            this.tabControl.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.replaceInFiles);
            this.tabPage1.ImageIndex = 0;
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(0);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(893, 176);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Replace in Files";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // replaceInFiles
            // 
            this.replaceInFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.replaceInFiles.Location = new System.Drawing.Point(0, 0);
            this.replaceInFiles.Name = "replaceInFiles";
            this.replaceInFiles.Size = new System.Drawing.Size(893, 176);
            stringSearcher1.AllFilesCount = 0;
            stringSearcher1.FilteredFilesCount = 0;
            stringSearcher1.Filters = ((System.Collections.Generic.List<string>)(resources.GetObject("stringSearcher1.Filters")));
            stringSearcher1.FoundFilesCount = 0;
            stringSearcher1.Stopwatch = stopwatch1;
            stringSearcher1.XmlDocument = null;
            this.replaceInFiles.StringSearcher = stringSearcher1;
            this.replaceInFiles.TabIndex = 1;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.changeConfigControl1);
            this.tabPage3.ImageIndex = 3;
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(893, 176);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Replace in XML";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // changeConfigControl1
            // 
            this.changeConfigControl1.Location = new System.Drawing.Point(9, 3);
            this.changeConfigControl1.Name = "changeConfigControl1";
            this.changeConfigControl1.Size = new System.Drawing.Size(881, 170);
            stringSearcher2.AllFilesCount = 0;
            stringSearcher2.FilteredFilesCount = 0;
            stringSearcher2.Filters = ((System.Collections.Generic.List<string>)(resources.GetObject("stringSearcher2.Filters")));
            stringSearcher2.FoundFilesCount = 0;
            stringSearcher2.Stopwatch = stopwatch2;
            stringSearcher2.XmlDocument = null;
            this.changeConfigControl1.StringSearcher = stringSearcher2;
            this.changeConfigControl1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.configGenerator);
            this.tabPage2.ImageIndex = 1;
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(893, 176);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Config Generator";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // configGenerator
            // 
            this.configGenerator.ConfigFiles = ((System.Collections.Generic.List<string>)(resources.GetObject("configGenerator.ConfigFiles")));
            this.configGenerator.Dock = System.Windows.Forms.DockStyle.Fill;
            this.configGenerator.EINames = ((System.Collections.Generic.List<string>)(resources.GetObject("configGenerator.EINames")));
            this.configGenerator.Location = new System.Drawing.Point(0, 0);
            this.configGenerator.Margin = new System.Windows.Forms.Padding(0);
            this.configGenerator.Name = "configGenerator";
            this.configGenerator.Size = new System.Drawing.Size(893, 176);
            this.configGenerator.TabIndex = 0;
            // 
            // imgList
            // 
            this.imgList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgList.ImageStream")));
            this.imgList.TransparentColor = System.Drawing.Color.Transparent;
            this.imgList.Images.SetKeyName(0, "replace.png");
            this.imgList.Images.SetKeyName(1, "systemconfiguration_plugins_config.png");
            this.imgList.Images.SetKeyName(2, "clear.png");
            this.imgList.Images.SetKeyName(3, "xml.png");
            // 
            // rtbInfo
            // 
            this.rtbInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtbInfo.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbInfo.Location = new System.Drawing.Point(13, 224);
            this.rtbInfo.Name = "rtbInfo";
            this.rtbInfo.ReadOnly = true;
            this.rtbInfo.Size = new System.Drawing.Size(897, 203);
            this.rtbInfo.TabIndex = 1;
            this.rtbInfo.TabStop = false;
            this.rtbInfo.Text = "";
            // 
            // btnClear
            // 
            this.btnClear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClear.ImageIndex = 2;
            this.btnClear.ImageList = this.imgList;
            this.btnClear.Location = new System.Drawing.Point(12, 433);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(56, 23);
            this.btnClear.TabIndex = 2;
            this.btnClear.Text = "Clear";
            this.btnClear.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // FileUtilitiesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(926, 468);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.rtbInfo);
            this.Controls.Add(this.tabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FileUtilitiesForm";
            this.Text = "File Utilities";
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ImageList imgList;
        private System.Windows.Forms.RichTextBox rtbInfo;
        private System.Windows.Forms.Button btnClear;
        private Controls.ConfigGeneratorControl configGenerator;
        private Controls.ReplaceInFilesControl replaceInFiles;
        private System.Windows.Forms.TabPage tabPage3;
        private Controls.ChangeConfigControl changeConfigControl1;
    }
}

