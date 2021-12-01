
namespace FileUtilities.Controls
{
    partial class ConfigGeneratorControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfigGeneratorControl));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxDefaultDirectory = new System.Windows.Forms.TextBox();
            this.tbxEIFile = new System.Windows.Forms.TextBox();
            this.tbxOutputDirectory = new System.Windows.Forms.TextBox();
            this.btnDefaultDirectory = new System.Windows.Forms.Button();
            this.cbxAssumeOutput = new System.Windows.Forms.CheckBox();
            this.btnEIFile = new System.Windows.Forms.Button();
            this.btnEditEIs = new System.Windows.Forms.Button();
            this.btnOutputDirectory = new System.Windows.Forms.Button();
            this.cbxOverwrite = new System.Windows.Forms.CheckBox();
            this.btnGenerateConfigs = new System.Windows.Forms.Button();
            this.bgWorker = new System.ComponentModel.BackgroundWorker();
            this.pgBar = new System.Windows.Forms.ProgressBar();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Default Config Directory:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Equipment Instance Names File:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Output Directory:";
            // 
            // tbxDefaultDirectory
            // 
            this.tbxDefaultDirectory.Location = new System.Drawing.Point(210, 23);
            this.tbxDefaultDirectory.Name = "tbxDefaultDirectory";
            this.tbxDefaultDirectory.Size = new System.Drawing.Size(487, 20);
            this.tbxDefaultDirectory.TabIndex = 3;
            // 
            // tbxEIFile
            // 
            this.tbxEIFile.Location = new System.Drawing.Point(210, 59);
            this.tbxEIFile.Name = "tbxEIFile";
            this.tbxEIFile.Size = new System.Drawing.Size(596, 20);
            this.tbxEIFile.TabIndex = 6;
            // 
            // tbxOutputDirectory
            // 
            this.tbxOutputDirectory.Location = new System.Drawing.Point(210, 91);
            this.tbxOutputDirectory.Name = "tbxOutputDirectory";
            this.tbxOutputDirectory.Size = new System.Drawing.Size(629, 20);
            this.tbxOutputDirectory.TabIndex = 9;
            // 
            // btnDefaultDirectory
            // 
            this.btnDefaultDirectory.Location = new System.Drawing.Point(703, 23);
            this.btnDefaultDirectory.Name = "btnDefaultDirectory";
            this.btnDefaultDirectory.Size = new System.Drawing.Size(24, 20);
            this.btnDefaultDirectory.TabIndex = 4;
            this.btnDefaultDirectory.Text = "...";
            this.btnDefaultDirectory.UseVisualStyleBackColor = true;
            this.btnDefaultDirectory.Click += new System.EventHandler(this.btnDefaultDirectory_Click);
            // 
            // cbxAssumeOutput
            // 
            this.cbxAssumeOutput.AutoSize = true;
            this.cbxAssumeOutput.Location = new System.Drawing.Point(733, 26);
            this.cbxAssumeOutput.Name = "cbxAssumeOutput";
            this.cbxAssumeOutput.Size = new System.Drawing.Size(139, 17);
            this.cbxAssumeOutput.TabIndex = 5;
            this.cbxAssumeOutput.Text = "Assume output directory";
            this.cbxAssumeOutput.UseVisualStyleBackColor = true;
            this.cbxAssumeOutput.CheckedChanged += new System.EventHandler(this.cbxAssumeOutput_CheckedChanged);
            // 
            // btnEIFile
            // 
            this.btnEIFile.Location = new System.Drawing.Point(812, 59);
            this.btnEIFile.Name = "btnEIFile";
            this.btnEIFile.Size = new System.Drawing.Size(27, 20);
            this.btnEIFile.TabIndex = 7;
            this.btnEIFile.Text = "...";
            this.btnEIFile.UseVisualStyleBackColor = true;
            this.btnEIFile.Click += new System.EventHandler(this.btnEIFile_Click);
            // 
            // btnEditEIs
            // 
            this.btnEditEIs.BackColor = System.Drawing.SystemColors.Control;
            this.btnEditEIs.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEditEIs.BackgroundImage")));
            this.btnEditEIs.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEditEIs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditEIs.Location = new System.Drawing.Point(845, 59);
            this.btnEditEIs.Name = "btnEditEIs";
            this.btnEditEIs.Size = new System.Drawing.Size(27, 20);
            this.btnEditEIs.TabIndex = 8;
            this.btnEditEIs.UseVisualStyleBackColor = false;
            this.btnEditEIs.Click += new System.EventHandler(this.btnEditEIs_Click);
            // 
            // btnOutputDirectory
            // 
            this.btnOutputDirectory.Location = new System.Drawing.Point(845, 90);
            this.btnOutputDirectory.Name = "btnOutputDirectory";
            this.btnOutputDirectory.Size = new System.Drawing.Size(27, 20);
            this.btnOutputDirectory.TabIndex = 10;
            this.btnOutputDirectory.Text = "...";
            this.btnOutputDirectory.UseVisualStyleBackColor = true;
            // 
            // cbxOverwrite
            // 
            this.cbxOverwrite.AutoSize = true;
            this.cbxOverwrite.Location = new System.Drawing.Point(635, 121);
            this.cbxOverwrite.Name = "cbxOverwrite";
            this.cbxOverwrite.Size = new System.Drawing.Size(92, 17);
            this.cbxOverwrite.TabIndex = 11;
            this.cbxOverwrite.Text = "Overwrite files";
            this.cbxOverwrite.UseVisualStyleBackColor = true;
            // 
            // btnGenerateConfigs
            // 
            this.btnGenerateConfigs.Location = new System.Drawing.Point(733, 117);
            this.btnGenerateConfigs.Name = "btnGenerateConfigs";
            this.btnGenerateConfigs.Size = new System.Drawing.Size(139, 23);
            this.btnGenerateConfigs.TabIndex = 12;
            this.btnGenerateConfigs.Text = "Generate config folders";
            this.btnGenerateConfigs.UseVisualStyleBackColor = true;
            this.btnGenerateConfigs.EnabledChanged += new System.EventHandler(this.btnGenerateConfigs_EnabledChanged);
            this.btnGenerateConfigs.Click += new System.EventHandler(this.btnGenerateConfigs_Click);
            // 
            // bgWorker
            // 
            this.bgWorker.WorkerReportsProgress = true;
            this.bgWorker.WorkerSupportsCancellation = true;
            // 
            // pgBar
            // 
            this.pgBar.Location = new System.Drawing.Point(0, 147);
            this.pgBar.Margin = new System.Windows.Forms.Padding(0);
            this.pgBar.Name = "pgBar";
            this.pgBar.Size = new System.Drawing.Size(855, 23);
            this.pgBar.Step = 1;
            this.pgBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pgBar.TabIndex = 13;
            // 
            // btnCancel
            // 
            this.btnCancel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCancel.BackgroundImage")));
            this.btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCancel.Location = new System.Drawing.Point(855, 146);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(26, 26);
            this.btnCancel.TabIndex = 14;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Visible = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // ConfigGeneratorControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.pgBar);
            this.Controls.Add(this.btnGenerateConfigs);
            this.Controls.Add(this.cbxOverwrite);
            this.Controls.Add(this.btnOutputDirectory);
            this.Controls.Add(this.btnEditEIs);
            this.Controls.Add(this.btnEIFile);
            this.Controls.Add(this.cbxAssumeOutput);
            this.Controls.Add(this.btnDefaultDirectory);
            this.Controls.Add(this.tbxOutputDirectory);
            this.Controls.Add(this.tbxEIFile);
            this.Controls.Add(this.tbxDefaultDirectory);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ConfigGeneratorControl";
            this.Size = new System.Drawing.Size(881, 170);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxDefaultDirectory;
        private System.Windows.Forms.TextBox tbxEIFile;
        private System.Windows.Forms.TextBox tbxOutputDirectory;
        private System.Windows.Forms.Button btnDefaultDirectory;
        private System.Windows.Forms.CheckBox cbxAssumeOutput;
        private System.Windows.Forms.Button btnEIFile;
        private System.Windows.Forms.Button btnEditEIs;
        private System.Windows.Forms.Button btnOutputDirectory;
        private System.Windows.Forms.CheckBox cbxOverwrite;
        private System.Windows.Forms.Button btnGenerateConfigs;
        private System.ComponentModel.BackgroundWorker bgWorker;
        private System.Windows.Forms.ProgressBar pgBar;
        private System.Windows.Forms.Button btnCancel;
    }
}
