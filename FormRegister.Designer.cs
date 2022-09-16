namespace QQSM
{
    partial class FormRegister
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRegister));
            this.btnSalirR = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnReturnLogin = new System.Windows.Forms.Button();
            this.btnReg = new System.Windows.Forms.Button();
            this.txtPassR1 = new System.Windows.Forms.TextBox();
            this.txtUserR = new System.Windows.Forms.TextBox();
            this.lblPassR = new System.Windows.Forms.Label();
            this.lblUserR = new System.Windows.Forms.Label();
            this.txtPassR2 = new System.Windows.Forms.TextBox();
            this.lblPassR2 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalirR
            // 
            this.btnSalirR.BackColor = System.Drawing.Color.Red;
            this.btnSalirR.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalirR.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSalirR.Location = new System.Drawing.Point(609, 6);
            this.btnSalirR.Name = "btnSalirR";
            this.btnSalirR.Size = new System.Drawing.Size(27, 23);
            this.btnSalirR.TabIndex = 2;
            this.btnSalirR.Text = "X";
            this.btnSalirR.UseVisualStyleBackColor = false;
            this.btnSalirR.Click += new System.EventHandler(this.btnSalirR_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::QQSM.Properties.Resources.millonario;
            this.pictureBox1.Location = new System.Drawing.Point(92, 40);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(464, 505);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // btnReturnLogin
            // 
            this.btnReturnLogin.BackColor = System.Drawing.Color.DarkOrange;
            this.btnReturnLogin.Font = new System.Drawing.Font("AvantGarde Bk BT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturnLogin.Location = new System.Drawing.Point(489, 759);
            this.btnReturnLogin.Name = "btnReturnLogin";
            this.btnReturnLogin.Size = new System.Drawing.Size(140, 26);
            this.btnReturnLogin.TabIndex = 13;
            this.btnReturnLogin.Text = "INICIAR SESIÓN";
            this.btnReturnLogin.UseVisualStyleBackColor = false;
            this.btnReturnLogin.Click += new System.EventHandler(this.btnReturnLogin_Click);
            // 
            // btnReg
            // 
            this.btnReg.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnReg.Font = new System.Drawing.Font("AvantGarde Bk BT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReg.Location = new System.Drawing.Point(367, 708);
            this.btnReg.Name = "btnReg";
            this.btnReg.Size = new System.Drawing.Size(189, 30);
            this.btnReg.TabIndex = 12;
            this.btnReg.Text = "REGISTRARSE";
            this.btnReg.UseVisualStyleBackColor = false;
            this.btnReg.Click += new System.EventHandler(this.btnReg_Click);
            // 
            // txtPassR1
            // 
            this.txtPassR1.Font = new System.Drawing.Font("AvantGarde Bk BT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassR1.Location = new System.Drawing.Point(121, 657);
            this.txtPassR1.Name = "txtPassR1";
            this.txtPassR1.PasswordChar = '•';
            this.txtPassR1.Size = new System.Drawing.Size(189, 25);
            this.txtPassR1.TabIndex = 11;
            this.txtPassR1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtUserR
            // 
            this.txtUserR.Font = new System.Drawing.Font("AvantGarde Bk BT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserR.Location = new System.Drawing.Point(121, 601);
            this.txtUserR.Name = "txtUserR";
            this.txtUserR.Size = new System.Drawing.Size(189, 25);
            this.txtUserR.TabIndex = 10;
            this.txtUserR.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblPassR
            // 
            this.lblPassR.AutoSize = true;
            this.lblPassR.BackColor = System.Drawing.Color.Transparent;
            this.lblPassR.Font = new System.Drawing.Font("AvantGarde Bk BT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassR.ForeColor = System.Drawing.Color.Transparent;
            this.lblPassR.Location = new System.Drawing.Point(162, 635);
            this.lblPassR.Name = "lblPassR";
            this.lblPassR.Size = new System.Drawing.Size(108, 19);
            this.lblPassR.TabIndex = 9;
            this.lblPassR.Text = "CONTRASEÑA";
            // 
            // lblUserR
            // 
            this.lblUserR.AutoSize = true;
            this.lblUserR.BackColor = System.Drawing.Color.Transparent;
            this.lblUserR.Font = new System.Drawing.Font("AvantGarde Bk BT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserR.ForeColor = System.Drawing.Color.Transparent;
            this.lblUserR.Location = new System.Drawing.Point(182, 577);
            this.lblUserR.Name = "lblUserR";
            this.lblUserR.Size = new System.Drawing.Size(71, 19);
            this.lblUserR.TabIndex = 8;
            this.lblUserR.Text = "USUARIO";
            // 
            // txtPassR2
            // 
            this.txtPassR2.Font = new System.Drawing.Font("AvantGarde Bk BT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassR2.Location = new System.Drawing.Point(121, 713);
            this.txtPassR2.Name = "txtPassR2";
            this.txtPassR2.PasswordChar = '•';
            this.txtPassR2.Size = new System.Drawing.Size(189, 25);
            this.txtPassR2.TabIndex = 15;
            this.txtPassR2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblPassR2
            // 
            this.lblPassR2.AutoSize = true;
            this.lblPassR2.BackColor = System.Drawing.Color.Transparent;
            this.lblPassR2.Font = new System.Drawing.Font("AvantGarde Bk BT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassR2.ForeColor = System.Drawing.Color.Transparent;
            this.lblPassR2.Location = new System.Drawing.Point(114, 691);
            this.lblPassR2.Name = "lblPassR2";
            this.lblPassR2.Size = new System.Drawing.Size(203, 19);
            this.lblPassR2.TabIndex = 14;
            this.lblPassR2.Text = "CONFIRMAR CONTRASEÑA";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("AvantGarde Bk BT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(367, 657);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(189, 25);
            this.txtName.TabIndex = 19;
            this.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.Font = new System.Drawing.Font("AvantGarde Bk BT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.Transparent;
            this.lblName.Location = new System.Drawing.Point(425, 634);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(72, 19);
            this.lblName.TabIndex = 18;
            this.lblName.Text = "NOMBRE";
            this.lblName.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("AvantGarde Bk BT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(367, 601);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(189, 25);
            this.txtEmail.TabIndex = 17;
            this.txtEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.BackColor = System.Drawing.Color.Transparent;
            this.lblEmail.Font = new System.Drawing.Font("AvantGarde Bk BT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.Color.Transparent;
            this.lblEmail.Location = new System.Drawing.Point(434, 577);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(52, 19);
            this.lblEmail.TabIndex = 16;
            this.lblEmail.Text = "EMAIL";
            // 
            // FormRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QQSM.Properties.Resources.patron;
            this.ClientSize = new System.Drawing.Size(641, 797);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtPassR2);
            this.Controls.Add(this.lblPassR2);
            this.Controls.Add(this.btnReturnLogin);
            this.Controls.Add(this.btnReg);
            this.Controls.Add(this.txtPassR1);
            this.Controls.Add(this.txtUserR);
            this.Controls.Add(this.lblPassR);
            this.Controls.Add(this.lblUserR);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnSalirR);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormRegister";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalirR;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnReturnLogin;
        private System.Windows.Forms.Button btnReg;
        private System.Windows.Forms.TextBox txtPassR1;
        private System.Windows.Forms.TextBox txtUserR;
        private System.Windows.Forms.Label lblPassR;
        private System.Windows.Forms.Label lblUserR;
        private System.Windows.Forms.TextBox txtPassR2;
        private System.Windows.Forms.Label lblPassR2;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
    }
}