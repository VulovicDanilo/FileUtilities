
namespace FileUtilities.Controls
{
    partial class ChangeConfigControl
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbxDirectory = new System.Windows.Forms.TextBox();
            this.btnDirectory = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxNodeName = new System.Windows.Forms.TextBox();
            this.btnFindAll = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxReplaceWith = new System.Windows.Forms.TextBox();
            this.btnChangeValueTo = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxFilters = new System.Windows.Forms.TextBox();
            this.cbxRecursively = new System.Windows.Forms.CheckBox();
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
            // tbxDirectory
            // 
            this.tbxDirectory.Location = new System.Drawing.Point(138, 19);
            this.tbxDirectory.Name = "tbxDirectory";
            this.tbxDirectory.Size = new System.Drawing.Size(692, 20);
            this.tbxDirectory.TabIndex = 1;
            // 
            // btnDirectory
            // 
            this.btnDirectory.Location = new System.Drawing.Point(836, 19);
            this.btnDirectory.Name = "btnDirectory";
            this.btnDirectory.Size = new System.Drawing.Size(25, 20);
            this.btnDirectory.TabIndex = 2;
            this.btnDirectory.Text = "...";
            this.btnDirectory.UseVisualStyleBackColor = true;
            this.btnDirectory.Click += new System.EventHandler(this.btnDirectory_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Node name:";
            // 
            // tbxNodeName
            // 
            this.tbxNodeName.Location = new System.Drawing.Point(138, 52);
            this.tbxNodeName.Name = "tbxNodeName";
            this.tbxNodeName.Size = new System.Drawing.Size(618, 20);
            this.tbxNodeName.TabIndex = 4;
            // 
            // btnFindAll
            // 
            this.btnFindAll.Location = new System.Drawing.Point(762, 52);
            this.btnFindAll.Name = "btnFindAll";
            this.btnFindAll.Size = new System.Drawing.Size(99, 20);
            this.btnFindAll.TabIndex = 7;
            this.btnFindAll.Text = "Find All";
            this.btnFindAll.UseVisualStyleBackColor = true;
            this.btnFindAll.Click += new System.EventHandler(this.btnFindAll_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Change value to:";
            // 
            // tbxReplaceWith
            // 
            this.tbxReplaceWith.Location = new System.Drawing.Point(138, 86);
            this.tbxReplaceWith.Name = "tbxReplaceWith";
            this.tbxReplaceWith.Size = new System.Drawing.Size(618, 20);
            this.tbxReplaceWith.TabIndex = 9;
            // 
            // btnChangeValueTo
            // 
            this.btnChangeValueTo.Location = new System.Drawing.Point(762, 86);
            this.btnChangeValueTo.Name = "btnChangeValueTo";
            this.btnChangeValueTo.Size = new System.Drawing.Size(99, 20);
            this.btnChangeValueTo.TabIndex = 10;
            this.btnChangeValueTo.Text = "Change value to";
            this.btnChangeValueTo.UseVisualStyleBackColor = true;
            this.btnChangeValueTo.Click += new System.EventHandler(this.btnReplaceWith_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "File filters:";
            // 
            // tbxFilters
            // 
            this.tbxFilters.Location = new System.Drawing.Point(138, 120);
            this.tbxFilters.Name = "tbxFilters";
            this.tbxFilters.Size = new System.Drawing.Size(618, 20);
            this.tbxFilters.TabIndex = 12;
            // 
            // cbxRecursively
            // 
            this.cbxRecursively.AutoSize = true;
            this.cbxRecursively.Location = new System.Drawing.Point(47, 150);
            this.cbxRecursively.Name = "cbxRecursively";
            this.cbxRecursively.Size = new System.Drawing.Size(105, 17);
            this.cbxRecursively.TabIndex = 13;
            this.cbxRecursively.Text = "All subdirectories";
            this.cbxRecursively.UseVisualStyleBackColor = true;
            // 
            // ChangeConfigControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cbxRecursively);
            this.Controls.Add(this.tbxFilters);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnChangeValueTo);
            this.Controls.Add(this.tbxReplaceWith);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnFindAll);
            this.Controls.Add(this.tbxNodeName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnDirectory);
            this.Controls.Add(this.tbxDirectory);
            this.Controls.Add(this.label1);
            this.Name = "ChangeConfigControl";
            this.Size = new System.Drawing.Size(881, 170);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxDirectory;
        private System.Windows.Forms.Button btnDirectory;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxNodeName;
        private System.Windows.Forms.Button btnFindAll;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxReplaceWith;
        private System.Windows.Forms.Button btnChangeValueTo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbxFilters;
        private System.Windows.Forms.CheckBox cbxRecursively;
    }
}
