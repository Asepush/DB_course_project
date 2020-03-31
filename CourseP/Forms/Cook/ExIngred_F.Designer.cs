namespace Lab4
{
    
    partial class ExIngred_F
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
            this.ExIngred_name = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ExIngred_count = new System.Windows.Forms.NumericUpDown();
            this.ExIngred_add = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ExIngred_count)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 32.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(124, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(299, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add Ingredient";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            // 
            // ExIngred_name
            // 
            this.ExIngred_name.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ExIngred_name.FormattingEnabled = true;
            this.ExIngred_name.Location = new System.Drawing.Point(79, 102);
            this.ExIngred_name.Name = "ExIngred_name";
            this.ExIngred_name.Size = new System.Drawing.Size(205, 21);
            this.ExIngred_name.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(317, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "Count";
            // 
            // ExIngred_count
            // 
            this.ExIngred_count.DecimalPlaces = 3;
            this.ExIngred_count.Location = new System.Drawing.Point(381, 102);
            this.ExIngred_count.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.ExIngred_count.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.ExIngred_count.Name = "ExIngred_count";
            this.ExIngred_count.Size = new System.Drawing.Size(127, 20);
            this.ExIngred_count.TabIndex = 4;
            this.ExIngred_count.Value = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            // 
            // ExIngred_add
            // 
            this.ExIngred_add.BackColor = System.Drawing.Color.SteelBlue;
            this.ExIngred_add.FlatAppearance.BorderColor = System.Drawing.Color.DarkBlue;
            this.ExIngred_add.FlatAppearance.BorderSize = 2;
            this.ExIngred_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExIngred_add.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExIngred_add.Location = new System.Drawing.Point(201, 231);
            this.ExIngred_add.Name = "ExIngred_add";
            this.ExIngred_add.Size = new System.Drawing.Size(134, 36);
            this.ExIngred_add.TabIndex = 5;
            this.ExIngred_add.Text = "Add";
            this.ExIngred_add.UseVisualStyleBackColor = false;
            this.ExIngred_add.Click += new System.EventHandler(this.ExIngred_add_Click);
            // 
            // ExIngred_F
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(538, 279);
            this.Controls.Add(this.ExIngred_add);
            this.Controls.Add(this.ExIngred_count);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ExIngred_name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ExIngred_F";
            this.Text = "ExIngred";
            ((System.ComponentModel.ISupportInitialize)(this.ExIngred_count)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox ExIngred_name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown ExIngred_count;
        private System.Windows.Forms.Button ExIngred_add;
    }
}