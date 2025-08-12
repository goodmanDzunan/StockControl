namespace StockControl_2
{
    partial class CfrmRegister
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
            this.btnBackRegister = new System.Windows.Forms.Button();
            this.btnRegister = new System.Windows.Forms.Button();
            this.chckPassword = new System.Windows.Forms.CheckBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblCloseRegister = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBackRegister
            // 
            this.btnBackRegister.Location = new System.Drawing.Point(448, 490);
            this.btnBackRegister.Name = "btnBackRegister";
            this.btnBackRegister.Size = new System.Drawing.Size(100, 34);
            this.btnBackRegister.TabIndex = 17;
            this.btnBackRegister.Text = "&Back";
            this.btnBackRegister.UseVisualStyleBackColor = true;
            this.btnBackRegister.Click += new System.EventHandler(this.btnBackRegister_Click);
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnRegister.Location = new System.Drawing.Point(310, 490);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(100, 34);
            this.btnRegister.TabIndex = 16;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // chckPassword
            // 
            this.chckPassword.AutoSize = true;
            this.chckPassword.Location = new System.Drawing.Point(310, 431);
            this.chckPassword.Name = "chckPassword";
            this.chckPassword.Size = new System.Drawing.Size(124, 20);
            this.chckPassword.TabIndex = 15;
            this.chckPassword.Text = "Show password";
            this.chckPassword.UseVisualStyleBackColor = true;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(310, 403);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(238, 22);
            this.txtPassword.TabIndex = 14;
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(310, 366);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(238, 22);
            this.txtUsername.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(211, 403);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(211, 366);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "Username";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(325, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Register your account";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(310, 332);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(238, 22);
            this.textBox1.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(211, 332);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 16);
            this.label4.TabIndex = 18;
            this.label4.Text = "Email address";
            // 
            // lblCloseRegister
            // 
            this.lblCloseRegister.AutoSize = true;
            this.lblCloseRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCloseRegister.Location = new System.Drawing.Point(763, 9);
            this.lblCloseRegister.Name = "lblCloseRegister";
            this.lblCloseRegister.Size = new System.Drawing.Size(25, 24);
            this.lblCloseRegister.TabIndex = 20;
            this.lblCloseRegister.Text = "X";
            this.lblCloseRegister.Click += new System.EventHandler(this.lblCloseRegister_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::StockControl_2.Properties.Resources.add_user;
            this.pictureBox1.Location = new System.Drawing.Point(289, 94);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(302, 194);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // CfrmRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 538);
            this.ControlBox = false;
            this.Controls.Add(this.lblCloseRegister);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnBackRegister);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.chckPassword);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Name = "CfrmRegister";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "REGISTER ACCOUNT";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBackRegister;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.CheckBox chckPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblCloseRegister;
    }
}