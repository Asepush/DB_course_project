namespace Lab4
{
    partial class Login_F
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.login_enter = new System.Windows.Forms.Button();
            this.login_login = new System.Windows.Forms.TextBox();
            this.login_pass = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 32.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(98, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(263, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter the acc";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(65, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Login";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(50, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Password";
            // 
            // login_enter
            // 
            this.login_enter.BackColor = System.Drawing.Color.SteelBlue;
            this.login_enter.FlatAppearance.BorderColor = System.Drawing.Color.DarkBlue;
            this.login_enter.FlatAppearance.BorderSize = 2;
            this.login_enter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.login_enter.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_enter.Location = new System.Drawing.Point(187, 219);
            this.login_enter.Name = "login_enter";
            this.login_enter.Size = new System.Drawing.Size(95, 37);
            this.login_enter.TabIndex = 3;
            this.login_enter.Text = "Enter";
            this.login_enter.UseVisualStyleBackColor = false;
            this.login_enter.Click += new System.EventHandler(this.login_enter_Click);
            // 
            // login_login
            // 
            this.login_login.Location = new System.Drawing.Point(149, 115);
            this.login_login.Name = "login_login";
            this.login_login.Size = new System.Drawing.Size(251, 20);
            this.login_login.TabIndex = 4;
            // 
            // login_pass
            // 
            this.login_pass.Location = new System.Drawing.Point(149, 158);
            this.login_pass.Name = "login_pass";
            this.login_pass.PasswordChar = '*';
            this.login_pass.Size = new System.Drawing.Size(251, 20);
            this.login_pass.TabIndex = 5;
            this.login_pass.UseSystemPasswordChar = true;
            // 
            // Login_F
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(456, 270);
            this.Controls.Add(this.login_pass);
            this.Controls.Add(this.login_login);
            this.Controls.Add(this.login_enter);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(472, 309);
            this.MinimumSize = new System.Drawing.Size(472, 309);
            this.Name = "Login_F";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button login_enter;
        private System.Windows.Forms.TextBox login_login;
        private System.Windows.Forms.TextBox login_pass;
    }
}