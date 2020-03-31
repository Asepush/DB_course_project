namespace Lab4
{ 
    partial class NewIngred
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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.newIngred_provider = new System.Windows.Forms.ComboBox();
            this.newIngred_measure = new System.Windows.Forms.ComboBox();
            this.newIngred_add = new System.Windows.Forms.Button();
            this.newIngred_name = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 32.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(104, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(389, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add New Ingredient";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(93, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(306, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "Provider";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(20, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 24);
            this.label5.TabIndex = 4;
            this.label5.Text = "Measure Units";
            // 
            // newIngred_provider
            // 
            this.newIngred_provider.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.newIngred_provider.FormattingEnabled = true;
            this.newIngred_provider.Location = new System.Drawing.Point(395, 161);
            this.newIngred_provider.Name = "newIngred_provider";
            this.newIngred_provider.Size = new System.Drawing.Size(152, 21);
            this.newIngred_provider.TabIndex = 5;
            // 
            // newIngred_measure
            // 
            this.newIngred_measure.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.newIngred_measure.FormattingEnabled = true;
            this.newIngred_measure.Location = new System.Drawing.Point(158, 159);
            this.newIngred_measure.Name = "newIngred_measure";
            this.newIngred_measure.Size = new System.Drawing.Size(129, 21);
            this.newIngred_measure.TabIndex = 6;
            // 
            // newIngred_add
            // 
            this.newIngred_add.BackColor = System.Drawing.Color.SteelBlue;
            this.newIngred_add.FlatAppearance.BorderColor = System.Drawing.Color.DarkBlue;
            this.newIngred_add.FlatAppearance.BorderSize = 2;
            this.newIngred_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newIngred_add.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newIngred_add.Location = new System.Drawing.Point(220, 281);
            this.newIngred_add.Name = "newIngred_add";
            this.newIngred_add.Size = new System.Drawing.Size(150, 43);
            this.newIngred_add.TabIndex = 7;
            this.newIngred_add.Text = "Add";
            this.newIngred_add.UseVisualStyleBackColor = false;
            this.newIngred_add.Click += new System.EventHandler(this.newIngred_add_Click);
            // 
            // newIngred_name
            // 
            this.newIngred_name.Location = new System.Drawing.Point(158, 106);
            this.newIngred_name.Name = "newIngred_name";
            this.newIngred_name.Size = new System.Drawing.Size(389, 20);
            this.newIngred_name.TabIndex = 9;
            // 
            // NewIngred
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(587, 336);
            this.Controls.Add(this.newIngred_name);
            this.Controls.Add(this.newIngred_add);
            this.Controls.Add(this.newIngred_measure);
            this.Controls.Add(this.newIngred_provider);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "NewIngred";
            this.Text = "Add New Ingredient";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox newIngred_provider;
        private System.Windows.Forms.ComboBox newIngred_measure;
        private System.Windows.Forms.Button newIngred_add;
        private System.Windows.Forms.TextBox newIngred_name;
    }
}