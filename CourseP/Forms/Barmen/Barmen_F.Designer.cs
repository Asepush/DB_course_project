namespace Lab4
{
    partial class Barmen_F
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
            this.barmen_create = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.barmen_add = new System.Windows.Forms.Button();
            this.barmen_product = new System.Windows.Forms.ComboBox();
            this.barmen_count = new System.Windows.Forms.NumericUpDown();
            this.barmen_compos = new System.Windows.Forms.DataGridView();
            this.Product = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CountPr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.barmen_workers = new System.Windows.Forms.ComboBox();
            this.barmen_drop = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.barmen_count)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barmen_compos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 32.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Make Order";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Choose Product";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(34, 220);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Choose Count";
            // 
            // barmen_create
            // 
            this.barmen_create.BackColor = System.Drawing.Color.SteelBlue;
            this.barmen_create.FlatAppearance.BorderColor = System.Drawing.Color.DarkBlue;
            this.barmen_create.FlatAppearance.BorderSize = 2;
            this.barmen_create.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.barmen_create.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barmen_create.Location = new System.Drawing.Point(676, 312);
            this.barmen_create.Name = "barmen_create";
            this.barmen_create.Size = new System.Drawing.Size(101, 34);
            this.barmen_create.TabIndex = 3;
            this.barmen_create.Text = "Create Order";
            this.barmen_create.UseVisualStyleBackColor = false;
            this.barmen_create.Click += new System.EventHandler(this.barmen_create_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(470, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 24);
            this.label4.TabIndex = 5;
            this.label4.Text = "Composition";
            // 
            // barmen_add
            // 
            this.barmen_add.BackColor = System.Drawing.Color.SteelBlue;
            this.barmen_add.FlatAppearance.BorderColor = System.Drawing.Color.DarkBlue;
            this.barmen_add.FlatAppearance.BorderSize = 2;
            this.barmen_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.barmen_add.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barmen_add.Location = new System.Drawing.Point(397, 143);
            this.barmen_add.Name = "barmen_add";
            this.barmen_add.Size = new System.Drawing.Size(60, 46);
            this.barmen_add.TabIndex = 6;
            this.barmen_add.Text = ">>";
            this.barmen_add.UseVisualStyleBackColor = false;
            this.barmen_add.Click += new System.EventHandler(this.barmen_add_Click);
            // 
            // barmen_product
            // 
            this.barmen_product.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.barmen_product.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barmen_product.FormattingEnabled = true;
            this.barmen_product.Location = new System.Drawing.Point(160, 128);
            this.barmen_product.Name = "barmen_product";
            this.barmen_product.Size = new System.Drawing.Size(213, 26);
            this.barmen_product.TabIndex = 7;
            // 
            // barmen_count
            // 
            this.barmen_count.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barmen_count.Location = new System.Drawing.Point(160, 216);
            this.barmen_count.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.barmen_count.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.barmen_count.Name = "barmen_count";
            this.barmen_count.Size = new System.Drawing.Size(213, 28);
            this.barmen_count.TabIndex = 8;
            this.barmen_count.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // barmen_compos
            // 
            this.barmen_compos.AllowUserToAddRows = false;
            this.barmen_compos.AllowUserToDeleteRows = false;
            this.barmen_compos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.barmen_compos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Product,
            this.CountPr,
            this.Price});
            this.barmen_compos.Location = new System.Drawing.Point(474, 68);
            this.barmen_compos.Name = "barmen_compos";
            this.barmen_compos.ReadOnly = true;
            this.barmen_compos.RowHeadersVisible = false;
            this.barmen_compos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.barmen_compos.Size = new System.Drawing.Size(303, 238);
            this.barmen_compos.TabIndex = 9;
            // 
            // Product
            // 
            this.Product.HeaderText = "Product";
            this.Product.Name = "Product";
            this.Product.ReadOnly = true;
            // 
            // CountPr
            // 
            this.CountPr.HeaderText = "Count";
            this.CountPr.Name = "CountPr";
            this.CountPr.ReadOnly = true;
            // 
            // Price
            // 
            this.Price.HeaderText = "Price";
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            // 
            // barmen_workers
            // 
            this.barmen_workers.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barmen_workers.FormattingEnabled = true;
            this.barmen_workers.Location = new System.Drawing.Point(474, 313);
            this.barmen_workers.Name = "barmen_workers";
            this.barmen_workers.Size = new System.Drawing.Size(196, 32);
            this.barmen_workers.TabIndex = 10;
            // 
            // barmen_drop
            // 
            this.barmen_drop.BackColor = System.Drawing.Color.SteelBlue;
            this.barmen_drop.FlatAppearance.BorderColor = System.Drawing.Color.DarkBlue;
            this.barmen_drop.FlatAppearance.BorderSize = 2;
            this.barmen_drop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.barmen_drop.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barmen_drop.Location = new System.Drawing.Point(397, 207);
            this.barmen_drop.Name = "barmen_drop";
            this.barmen_drop.Size = new System.Drawing.Size(60, 46);
            this.barmen_drop.TabIndex = 11;
            this.barmen_drop.Text = "<<";
            this.barmen_drop.UseVisualStyleBackColor = false;
            this.barmen_drop.Click += new System.EventHandler(this.barmen_drop_Click);
            // 
            // Barmen_F
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(785, 363);
            this.Controls.Add(this.barmen_drop);
            this.Controls.Add(this.barmen_workers);
            this.Controls.Add(this.barmen_compos);
            this.Controls.Add(this.barmen_count);
            this.Controls.Add(this.barmen_product);
            this.Controls.Add(this.barmen_add);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.barmen_create);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Barmen_F";
            this.Text = "Barmen_F";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Barmen_F_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.barmen_count)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barmen_compos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button barmen_create;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button barmen_add;
        private System.Windows.Forms.ComboBox barmen_product;
        private System.Windows.Forms.NumericUpDown barmen_count;
        private System.Windows.Forms.DataGridView barmen_compos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product;
        private System.Windows.Forms.DataGridViewTextBoxColumn CountPr;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.ComboBox barmen_workers;
        private System.Windows.Forms.Button barmen_drop;
    }
}