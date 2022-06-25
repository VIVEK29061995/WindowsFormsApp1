namespace WindowsFormsApp1
{
    partial class Form6
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
            this.lblCourseId = new System.Windows.Forms.Label();
            this.lblCourseName = new System.Windows.Forms.Label();
            this.lblCourseLocation = new System.Windows.Forms.Label();
            this.txtCId = new System.Windows.Forms.TextBox();
            this.txtCName = new System.Windows.Forms.TextBox();
            this.txtCLocation = new System.Windows.Forms.TextBox();
            this.btnCreateFolder = new System.Windows.Forms.Button();
            this.btnCreateFile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCourseId
            // 
            this.lblCourseId.AutoSize = true;
            this.lblCourseId.Location = new System.Drawing.Point(278, 75);
            this.lblCourseId.Name = "lblCourseId";
            this.lblCourseId.Size = new System.Drawing.Size(52, 13);
            this.lblCourseId.TabIndex = 0;
            this.lblCourseId.Text = "Course Id";
            // 
            // lblCourseName
            // 
            this.lblCourseName.AutoSize = true;
            this.lblCourseName.Location = new System.Drawing.Point(278, 146);
            this.lblCourseName.Name = "lblCourseName";
            this.lblCourseName.Size = new System.Drawing.Size(71, 13);
            this.lblCourseName.TabIndex = 1;
            this.lblCourseName.Text = "Course Name";
            // 
            // lblCourseLocation
            // 
            this.lblCourseLocation.AutoSize = true;
            this.lblCourseLocation.Location = new System.Drawing.Point(278, 227);
            this.lblCourseLocation.Name = "lblCourseLocation";
            this.lblCourseLocation.Size = new System.Drawing.Size(84, 13);
            this.lblCourseLocation.TabIndex = 2;
            this.lblCourseLocation.Text = "Course Location";
            // 
            // txtCId
            // 
            this.txtCId.Location = new System.Drawing.Point(404, 75);
            this.txtCId.Name = "txtCId";
            this.txtCId.Size = new System.Drawing.Size(100, 20);
            this.txtCId.TabIndex = 3;
            // 
            // txtCName
            // 
            this.txtCName.Location = new System.Drawing.Point(404, 146);
            this.txtCName.Name = "txtCName";
            this.txtCName.Size = new System.Drawing.Size(100, 20);
            this.txtCName.TabIndex = 4;
            // 
            // txtCLocation
            // 
            this.txtCLocation.Location = new System.Drawing.Point(404, 227);
            this.txtCLocation.Name = "txtCLocation";
            this.txtCLocation.Size = new System.Drawing.Size(100, 20);
            this.txtCLocation.TabIndex = 5;
            // 
            // btnCreateFolder
            // 
            this.btnCreateFolder.Location = new System.Drawing.Point(613, 75);
            this.btnCreateFolder.Name = "btnCreateFolder";
            this.btnCreateFolder.Size = new System.Drawing.Size(88, 23);
            this.btnCreateFolder.TabIndex = 6;
            this.btnCreateFolder.Text = "Create Folder";
            this.btnCreateFolder.UseVisualStyleBackColor = true;
            this.btnCreateFolder.Click += new System.EventHandler(this.btnCreateFolder_Click);
            // 
            // btnCreateFile
            // 
            this.btnCreateFile.Location = new System.Drawing.Point(626, 188);
            this.btnCreateFile.Name = "btnCreateFile";
            this.btnCreateFile.Size = new System.Drawing.Size(75, 23);
            this.btnCreateFile.TabIndex = 7;
            this.btnCreateFile.Text = "Create File";
            this.btnCreateFile.UseVisualStyleBackColor = true;
            this.btnCreateFile.Click += new System.EventHandler(this.btnCreateFile_Click);
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCreateFile);
            this.Controls.Add(this.btnCreateFolder);
            this.Controls.Add(this.txtCLocation);
            this.Controls.Add(this.txtCName);
            this.Controls.Add(this.txtCId);
            this.Controls.Add(this.lblCourseLocation);
            this.Controls.Add(this.lblCourseName);
            this.Controls.Add(this.lblCourseId);
            this.Name = "Form6";
            this.Text = "Form6";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCourseId;
        private System.Windows.Forms.Label lblCourseName;
        private System.Windows.Forms.Label lblCourseLocation;
        private System.Windows.Forms.TextBox txtCId;
        private System.Windows.Forms.TextBox txtCName;
        private System.Windows.Forms.TextBox txtCLocation;
        private System.Windows.Forms.Button btnCreateFolder;
        private System.Windows.Forms.Button btnCreateFile;
    }
}