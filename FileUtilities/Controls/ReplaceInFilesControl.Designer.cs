
namespace FileUtilities.Controls
{
    partial class ReplaceInFilesControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReplaceInFilesControl));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxDirectory = new System.Windows.Forms.TextBox();
            this.tbxFindWhat = new System.Windows.Forms.TextBox();
            this.tbxReplaceWith = new System.Windows.Forms.TextBox();
            this.tbxFilters = new System.Windows.Forms.TextBox();
            this.cbxRecursively = new System.Windows.Forms.CheckBox();
            this.cbxMatchCase = new System.Windows.Forms.CheckBox();
            this.btnFindAll = new System.Windows.Forms.Button();
            this.btnReplaceInFiles = new System.Windows.Forms.Button();
            this.btnDirectory = new System.Windows.Forms.Button();
            this.btnFolderFilter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Directory:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Find what:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Replace with:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "File filters:";
            // 
            // tbxDirectory
            // 
            this.tbxDirectory.Location = new System.Drawing.Point(126, 19);
            this.tbxDirectory.Name = "tbxDirectory";
            this.tbxDirectory.Size = new System.Drawing.Size(666, 20);
            this.tbxDirectory.TabIndex = 4;
            // 
            // tbxFindWhat
            // 
            this.tbxFindWhat.Location = new System.Drawing.Point(126, 48);
            this.tbxFindWhat.Name = "tbxFindWhat";
            this.tbxFindWhat.Size = new System.Drawing.Size(634, 20);
            this.tbxFindWhat.TabIndex = 6;
            // 
            // tbxReplaceWith
            // 
            this.tbxReplaceWith.Location = new System.Drawing.Point(126, 80);
            this.tbxReplaceWith.Name = "tbxReplaceWith";
            this.tbxReplaceWith.Size = new System.Drawing.Size(634, 20);
            this.tbxReplaceWith.TabIndex = 8;
            // 
            // tbxFilters
            // 
            this.tbxFilters.Location = new System.Drawing.Point(126, 110);
            this.tbxFilters.Name = "tbxFilters";
            this.tbxFilters.Size = new System.Drawing.Size(634, 20);
            this.tbxFilters.TabIndex = 10;
            // 
            // cbxRecursively
            // 
            this.cbxRecursively.AutoSize = true;
            this.cbxRecursively.Checked = true;
            this.cbxRecursively.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxRecursively.Location = new System.Drawing.Point(47, 139);
            this.cbxRecursively.Name = "cbxRecursively";
            this.cbxRecursively.Size = new System.Drawing.Size(105, 17);
            this.cbxRecursively.TabIndex = 11;
            this.cbxRecursively.Text = "All subdirectories";
            this.cbxRecursively.UseVisualStyleBackColor = true;
            // 
            // cbxMatchCase
            // 
            this.cbxMatchCase.AutoSize = true;
            this.cbxMatchCase.Location = new System.Drawing.Point(158, 139);
            this.cbxMatchCase.Name = "cbxMatchCase";
            this.cbxMatchCase.Size = new System.Drawing.Size(82, 17);
            this.cbxMatchCase.TabIndex = 12;
            this.cbxMatchCase.Text = "Match case";
            this.cbxMatchCase.UseVisualStyleBackColor = true;
            // 
            // btnFindAll
            // 
            this.btnFindAll.Location = new System.Drawing.Point(766, 48);
            this.btnFindAll.Name = "btnFindAll";
            this.btnFindAll.Size = new System.Drawing.Size(92, 20);
            this.btnFindAll.TabIndex = 7;
            this.btnFindAll.Text = "Find All";
            this.btnFindAll.UseVisualStyleBackColor = true;
            this.btnFindAll.Click += new System.EventHandler(this.btnFindAll_Click);
            // 
            // btnReplaceInFiles
            // 
            this.btnReplaceInFiles.Location = new System.Drawing.Point(766, 80);
            this.btnReplaceInFiles.Name = "btnReplaceInFiles";
            this.btnReplaceInFiles.Size = new System.Drawing.Size(92, 20);
            this.btnReplaceInFiles.TabIndex = 9;
            this.btnReplaceInFiles.Text = "Replace in Files";
            this.btnReplaceInFiles.UseVisualStyleBackColor = true;
            this.btnReplaceInFiles.Click += new System.EventHandler(this.btnReplaceInFiles_Click);
            // 
            // btnDirectory
            // 
            this.btnDirectory.Location = new System.Drawing.Point(798, 19);
            this.btnDirectory.Name = "btnDirectory";
            this.btnDirectory.Size = new System.Drawing.Size(27, 20);
            this.btnDirectory.TabIndex = 5;
            this.btnDirectory.Text = "...";
            this.btnDirectory.UseVisualStyleBackColor = true;
            this.btnDirectory.Click += new System.EventHandler(this.btnDirectory_Click);
            // 
            // btnFolderFilter
            // 
            this.btnFolderFilter.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFolderFilter.BackgroundImage")));
            this.btnFolderFilter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFolderFilter.Location = new System.Drawing.Point(831, 19);
            this.btnFolderFilter.Name = "btnFolderFilter";
            this.btnFolderFilter.Size = new System.Drawing.Size(27, 20);
            this.btnFolderFilter.TabIndex = 13;
            this.btnFolderFilter.UseVisualStyleBackColor = true;
            this.btnFolderFilter.Click += new System.EventHandler(this.btnFolderFilter_Click);
            // 
            // ReplaceInFilesControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnFolderFilter);
            this.Controls.Add(this.btnDirectory);
            this.Controls.Add(this.btnReplaceInFiles);
            this.Controls.Add(this.btnFindAll);
            this.Controls.Add(this.cbxMatchCase);
            this.Controls.Add(this.cbxRecursively);
            this.Controls.Add(this.tbxFilters);
            this.Controls.Add(this.tbxReplaceWith);
            this.Controls.Add(this.tbxFindWhat);
            this.Controls.Add(this.tbxDirectory);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ReplaceInFilesControl";
            this.Size = new System.Drawing.Size(881, 170);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbxDirectory;
        private System.Windows.Forms.TextBox tbxFindWhat;
        private System.Windows.Forms.TextBox tbxReplaceWith;
        private System.Windows.Forms.TextBox tbxFilters;
        private System.Windows.Forms.CheckBox cbxRecursively;
        private System.Windows.Forms.CheckBox cbxMatchCase;
        private System.Windows.Forms.Button btnFindAll;
        private System.Windows.Forms.Button btnReplaceInFiles;
        private System.Windows.Forms.Button btnDirectory;
        private System.Windows.Forms.Button btnFolderFilter;
    }
}
