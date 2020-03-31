namespace Lab4
{ 
    partial class NewProduct_F
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
            this.newProd_add = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.newProd_name = new System.Windows.Forms.TextBox();
            this.newProd_price = new System.Windows.Forms.NumericUpDown();
            this.newProd_type = new System.Windows.Forms.ComboBox();
            this.newProd_ingreds = new System.Windows.Forms.ComboBox();
            this.newProd_listAdd = new System.Windows.Forms.Button();
            this.newProd_data = new System.Windows.Forms.DataGridView();
            this.Ingredient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.newProd_ingredCount = new System.Windows.Forms.NumericUpDown();
            this.newProd_drop = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.newProd_price)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.newProd_data)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.newProd_ingredCount)).BeginInit();
            this.SuspendLayout();
            // 
            // newProd_add
            // 
            this.newProd_add.BackColor = System.Drawing.Color.SteelBlue;
            this.newProd_add.FlatAppearance.BorderColor = System.Drawing.Color.DarkBlue;
            this.newProd_add.FlatAppearance.BorderSize = 2;
            this.newProd_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newProd_add.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newProd_add.Location = new System.Drawing.Point(284, 423);
            this.newProd_add.Name = "newProd_add";
            this.newProd_add.Size = new System.Drawing.Size(121, 38);
            this.newProd_add.TabIndex = 0;
            this.newProd_add.Text = "Add";
            this.newProd_add.UseVisualStyleBackColor = false;
            this.newProd_add.Click += new System.EventHandler(this.newProd_add_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 32.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(166, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(341, 45);
            this.label1.TabIndex = 1;
            this.label1.Text = "Add New Product";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(280, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "Price";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(453, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 24);
            this.label5.TabIndex = 5;
            this.label5.Text = "Type";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(31, 167);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(137, 24);
            this.label6.TabIndex = 7;
            this.label6.Text = "Ingredient List";
            // 
            // newProd_name
            // 
            this.newProd_name.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newProd_name.Location = new System.Drawing.Point(92, 82);
            this.newProd_name.Name = "newProd_name";
            this.newProd_name.Size = new System.Drawing.Size(172, 25);
            this.newProd_name.TabIndex = 8;
            // 
            // newProd_price
            // 
            this.newProd_price.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newProd_price.Location = new System.Drawing.Point(338, 81);
            this.newProd_price.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.newProd_price.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.newProd_price.Name = "newProd_price";
            this.newProd_price.Size = new System.Drawing.Size(100, 25);
            this.newProd_price.TabIndex = 9;
            this.newProd_price.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // newProd_type
            // 
            this.newProd_type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.newProd_type.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newProd_type.FormattingEnabled = true;
            this.newProd_type.Location = new System.Drawing.Point(506, 80);
            this.newProd_type.Name = "newProd_type";
            this.newProd_type.Size = new System.Drawing.Size(176, 26);
            this.newProd_type.TabIndex = 11;
            // 
            // newProd_ingreds
            // 
            this.newProd_ingreds.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.newProd_ingreds.FormattingEnabled = true;
            this.newProd_ingreds.Location = new System.Drawing.Point(35, 206);
            this.newProd_ingreds.Name = "newProd_ingreds";
            this.newProd_ingreds.Size = new System.Drawing.Size(209, 21);
            this.newProd_ingreds.Sorted = true;
            this.newProd_ingreds.TabIndex = 12;
            // 
            // newProd_listAdd
            // 
            this.newProd_listAdd.BackColor = System.Drawing.Color.SteelBlue;
            this.newProd_listAdd.FlatAppearance.BorderColor = System.Drawing.Color.DarkBlue;
            this.newProd_listAdd.FlatAppearance.BorderSize = 2;
            this.newProd_listAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newProd_listAdd.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newProd_listAdd.Location = new System.Drawing.Point(260, 197);
            this.newProd_listAdd.Name = "newProd_listAdd";
            this.newProd_listAdd.Size = new System.Drawing.Size(75, 66);
            this.newProd_listAdd.TabIndex = 14;
            this.newProd_listAdd.Text = ">>";
            this.newProd_listAdd.UseVisualStyleBackColor = false;
            this.newProd_listAdd.Click += new System.EventHandler(this.newProd_listAdd_Click);
            // 
            // newProd_data
            // 
            this.newProd_data.AllowUserToAddRows = false;
            this.newProd_data.AllowUserToDeleteRows = false;
            this.newProd_data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.newProd_data.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ingredient,
            this.Count});
            this.newProd_data.Location = new System.Drawing.Point(352, 153);
            this.newProd_data.Name = "newProd_data";
            this.newProd_data.ReadOnly = true;
            this.newProd_data.RowHeadersVisible = false;
            this.newProd_data.Size = new System.Drawing.Size(339, 247);
            this.newProd_data.TabIndex = 15;
            // 
            // Ingredient
            // 
            this.Ingredient.HeaderText = "Ingredient";
            this.Ingredient.Name = "Ingredient";
            this.Ingredient.ReadOnly = true;
            this.Ingredient.Width = 250;
            // 
            // Count
            // 
            this.Count.HeaderText = "Count";
            this.Count.Name = "Count";
            this.Count.ReadOnly = true;
            this.Count.Width = 85;
            // 
            // newProd_ingredCount
            // 
            this.newProd_ingredCount.DecimalPlaces = 3;
            this.newProd_ingredCount.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newProd_ingredCount.Location = new System.Drawing.Point(34, 336);
            this.newProd_ingredCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.newProd_ingredCount.Name = "newProd_ingredCount";
            this.newProd_ingredCount.Size = new System.Drawing.Size(210, 25);
            this.newProd_ingredCount.TabIndex = 16;
            this.newProd_ingredCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            // 
            // newProd_drop
            // 
            this.newProd_drop.BackColor = System.Drawing.Color.SteelBlue;
            this.newProd_drop.FlatAppearance.BorderColor = System.Drawing.Color.DarkBlue;
            this.newProd_drop.FlatAppearance.BorderSize = 2;
            this.newProd_drop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newProd_drop.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newProd_drop.Location = new System.Drawing.Point(260, 295);
            this.newProd_drop.Name = "newProd_drop";
            this.newProd_drop.Size = new System.Drawing.Size(75, 66);
            this.newProd_drop.TabIndex = 17;
            this.newProd_drop.Text = "<<";
            this.newProd_drop.UseVisualStyleBackColor = false;
            this.newProd_drop.Click += new System.EventHandler(this.newProd_drop_Click);
            // 
            // NewProduct_F
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(704, 473);
            this.Controls.Add(this.newProd_drop);
            this.Controls.Add(this.newProd_ingredCount);
            this.Controls.Add(this.newProd_data);
            this.Controls.Add(this.newProd_listAdd);
            this.Controls.Add(this.newProd_ingreds);
            this.Controls.Add(this.newProd_type);
            this.Controls.Add(this.newProd_price);
            this.Controls.Add(this.newProd_name);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.newProd_add);
            this.Name = "NewProduct_F";
            this.Text = "NewProduct_F";
            ((System.ComponentModel.ISupportInitialize)(this.newProd_price)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.newProd_data)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.newProd_ingredCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button newProd_add;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox newProd_name;
        private System.Windows.Forms.NumericUpDown newProd_price;
        private System.Windows.Forms.ComboBox newProd_type;
        private System.Windows.Forms.ComboBox newProd_ingreds;
        private System.Windows.Forms.Button newProd_listAdd;
        private System.Windows.Forms.DataGridView newProd_data;
        private System.Windows.Forms.NumericUpDown newProd_ingredCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ingredient;
        private System.Windows.Forms.DataGridViewTextBoxColumn Count;
        private System.Windows.Forms.Button newProd_drop;
    }
}