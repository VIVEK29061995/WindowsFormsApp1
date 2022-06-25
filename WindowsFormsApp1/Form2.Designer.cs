namespace WindowsFormsApp1
{
    partial class Form2
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
            this.btnCLEAR = new System.Windows.Forms.Button();
            this.btnSHOW = new System.Windows.Forms.Button();
            this.txtEMPID = new System.Windows.Forms.TextBox();
            this.lblEMPID = new System.Windows.Forms.Label();
            this.txtDEPTNAME = new System.Windows.Forms.TextBox();
            this.lblDEPTNAME = new System.Windows.Forms.Label();
            this.txtEMPNAME = new System.Windows.Forms.TextBox();
            this.lblSALARY = new System.Windows.Forms.Label();
            this.txtSALARY = new System.Windows.Forms.TextBox();
            this.lblEMPNAME = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnCLEAR
            // 
            this.btnCLEAR.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnCLEAR.Location = new System.Drawing.Point(235, 259);
            this.btnCLEAR.Name = "btnCLEAR";
            this.btnCLEAR.Size = new System.Drawing.Size(75, 23);
            this.btnCLEAR.TabIndex = 27;
            this.btnCLEAR.Text = "Clear";
            this.btnCLEAR.UseVisualStyleBackColor = false;
            this.btnCLEAR.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnSHOW
            // 
            this.btnSHOW.BackColor = System.Drawing.Color.Coral;
            this.btnSHOW.Location = new System.Drawing.Point(50, 259);
            this.btnSHOW.Name = "btnSHOW";
            this.btnSHOW.Size = new System.Drawing.Size(75, 23);
            this.btnSHOW.TabIndex = 26;
            this.btnSHOW.Text = "Show";
            this.btnSHOW.UseVisualStyleBackColor = false;
            this.btnSHOW.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtEMPID
            // 
            this.txtEMPID.Location = new System.Drawing.Point(210, 54);
            this.txtEMPID.Name = "txtEMPID";
            this.txtEMPID.Size = new System.Drawing.Size(100, 20);
            this.txtEMPID.TabIndex = 25;
            this.txtEMPID.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // lblEMPID
            // 
            this.lblEMPID.AutoSize = true;
            this.lblEMPID.Location = new System.Drawing.Point(47, 54);
            this.lblEMPID.Name = "lblEMPID";
            this.lblEMPID.Size = new System.Drawing.Size(40, 13);
            this.lblEMPID.TabIndex = 24;
            this.lblEMPID.Text = "Emp Id";
            // 
            // txtDEPTNAME
            // 
            this.txtDEPTNAME.Location = new System.Drawing.Point(210, 191);
            this.txtDEPTNAME.Name = "txtDEPTNAME";
            this.txtDEPTNAME.Size = new System.Drawing.Size(100, 20);
            this.txtDEPTNAME.TabIndex = 23;
            // 
            // lblDEPTNAME
            // 
            this.lblDEPTNAME.AutoSize = true;
            this.lblDEPTNAME.Location = new System.Drawing.Point(47, 191);
            this.lblDEPTNAME.Name = "lblDEPTNAME";
            this.lblDEPTNAME.Size = new System.Drawing.Size(93, 13);
            this.lblDEPTNAME.TabIndex = 22;
            this.lblDEPTNAME.Text = "Department Name";
            // 
            // txtEMPNAME
            // 
            this.txtEMPNAME.Location = new System.Drawing.Point(210, 95);
            this.txtEMPNAME.Name = "txtEMPNAME";
            this.txtEMPNAME.Size = new System.Drawing.Size(100, 20);
            this.txtEMPNAME.TabIndex = 21;
            // 
            // lblSALARY
            // 
            this.lblSALARY.AutoSize = true;
            this.lblSALARY.Location = new System.Drawing.Point(47, 146);
            this.lblSALARY.Name = "lblSALARY";
            this.lblSALARY.Size = new System.Drawing.Size(36, 13);
            this.lblSALARY.TabIndex = 20;
            this.lblSALARY.Text = "Salary";
            // 
            // txtSALARY
            // 
            this.txtSALARY.Location = new System.Drawing.Point(210, 146);
            this.txtSALARY.Name = "txtSALARY";
            this.txtSALARY.Size = new System.Drawing.Size(100, 20);
            this.txtSALARY.TabIndex = 19;
            // 
            // lblEMPNAME
            // 
            this.lblEMPNAME.AutoSize = true;
            this.lblEMPNAME.Location = new System.Drawing.Point(47, 95);
            this.lblEMPNAME.Name = "lblEMPNAME";
            this.lblEMPNAME.Size = new System.Drawing.Size(59, 13);
            this.lblEMPNAME.TabIndex = 18;
            this.lblEMPNAME.Text = "Emp Name";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Yellow;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.Black;
            this.textBox1.Location = new System.Drawing.Point(126, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(106, 20);
            this.textBox1.TabIndex = 28;
            this.textBox1.Text = "REGISTER HERE";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnCLEAR);
            this.Controls.Add(this.btnSHOW);
            this.Controls.Add(this.txtEMPID);
            this.Controls.Add(this.lblEMPID);
            this.Controls.Add(this.txtDEPTNAME);
            this.Controls.Add(this.lblDEPTNAME);
            this.Controls.Add(this.txtEMPNAME);
            this.Controls.Add(this.lblSALARY);
            this.Controls.Add(this.txtSALARY);
            this.Controls.Add(this.lblEMPNAME);
            this.Name = "Form2";
            this.Text = "COMPANY REGISTRATION";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCLEAR;
        private System.Windows.Forms.Button btnSHOW;
        private System.Windows.Forms.TextBox txtEMPID;
        private System.Windows.Forms.Label lblEMPID;
        private System.Windows.Forms.TextBox txtDEPTNAME;
        private System.Windows.Forms.Label lblDEPTNAME;
        private System.Windows.Forms.TextBox txtEMPNAME;
        private System.Windows.Forms.Label lblSALARY;
        private System.Windows.Forms.TextBox txtSALARY;
        private System.Windows.Forms.Label lblEMPNAME;
        private System.Windows.Forms.TextBox textBox1;
    }
}