namespace Lab4
{
    partial class Cook_F
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.cook_ready = new System.Windows.Forms.Button();
            this.cook_exIngred = new System.Windows.Forms.Button();
            this.cook_newIngred = new System.Windows.Forms.Button();
            this.cook_newProduct = new System.Windows.Forms.Button();
            this.cook_list = new System.Windows.Forms.DataGridView();
            this.order_num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodNameCnt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.cook_list)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Product List";
            // 
            // cook_ready
            // 
            this.cook_ready.BackColor = System.Drawing.Color.SteelBlue;
            this.cook_ready.FlatAppearance.BorderColor = System.Drawing.Color.DarkBlue;
            this.cook_ready.FlatAppearance.BorderSize = 2;
            this.cook_ready.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cook_ready.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cook_ready.Location = new System.Drawing.Point(180, 406);
            this.cook_ready.Name = "cook_ready";
            this.cook_ready.Size = new System.Drawing.Size(99, 39);
            this.cook_ready.TabIndex = 1;
            this.cook_ready.Text = "Ready";
            this.cook_ready.UseVisualStyleBackColor = false;
            this.cook_ready.Click += new System.EventHandler(this.cook_ready_Click);
            // 
            // cook_exIngred
            // 
            this.cook_exIngred.BackColor = System.Drawing.Color.SteelBlue;
            this.cook_exIngred.FlatAppearance.BorderColor = System.Drawing.Color.DarkBlue;
            this.cook_exIngred.FlatAppearance.BorderSize = 2;
            this.cook_exIngred.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cook_exIngred.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cook_exIngred.Location = new System.Drawing.Point(493, 36);
            this.cook_exIngred.Name = "cook_exIngred";
            this.cook_exIngred.Size = new System.Drawing.Size(275, 75);
            this.cook_exIngred.TabIndex = 2;
            this.cook_exIngred.Text = "Add Existing Ingredient";
            this.cook_exIngred.UseVisualStyleBackColor = false;
            this.cook_exIngred.Click += new System.EventHandler(this.cook_exIngred_Click);
            // 
            // cook_newIngred
            // 
            this.cook_newIngred.BackColor = System.Drawing.Color.SteelBlue;
            this.cook_newIngred.FlatAppearance.BorderColor = System.Drawing.Color.DarkBlue;
            this.cook_newIngred.FlatAppearance.BorderSize = 2;
            this.cook_newIngred.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cook_newIngred.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cook_newIngred.Location = new System.Drawing.Point(493, 176);
            this.cook_newIngred.Name = "cook_newIngred";
            this.cook_newIngred.Size = new System.Drawing.Size(275, 75);
            this.cook_newIngred.TabIndex = 3;
            this.cook_newIngred.Text = "Add New Ingredient";
            this.cook_newIngred.UseVisualStyleBackColor = false;
            this.cook_newIngred.Click += new System.EventHandler(this.cook_newIngred_Click);
            // 
            // cook_newProduct
            // 
            this.cook_newProduct.BackColor = System.Drawing.Color.SteelBlue;
            this.cook_newProduct.FlatAppearance.BorderColor = System.Drawing.Color.DarkBlue;
            this.cook_newProduct.FlatAppearance.BorderSize = 2;
            this.cook_newProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cook_newProduct.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cook_newProduct.Location = new System.Drawing.Point(493, 325);
            this.cook_newProduct.Name = "cook_newProduct";
            this.cook_newProduct.Size = new System.Drawing.Size(275, 75);
            this.cook_newProduct.TabIndex = 5;
            this.cook_newProduct.Text = "Add New Product";
            this.cook_newProduct.UseVisualStyleBackColor = false;
            this.cook_newProduct.Click += new System.EventHandler(this.cook_newProduct_Click);
            // 
            // cook_list
            // 
            this.cook_list.AllowDrop = true;
            this.cook_list.AllowUserToAddRows = false;
            this.cook_list.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.cook_list.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.cook_list.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cook_list.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.order_num,
            this.prodNameCnt,
            this.OrderTime});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.cook_list.DefaultCellStyle = dataGridViewCellStyle2;
            this.cook_list.Location = new System.Drawing.Point(12, 36);
            this.cook_list.MultiSelect = false;
            this.cook_list.Name = "cook_list";
            this.cook_list.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.cook_list.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.cook_list.RowHeadersVisible = false;
            this.cook_list.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.cook_list.Size = new System.Drawing.Size(453, 364);
            this.cook_list.TabIndex = 6;
            // 
            // order_num
            // 
            this.order_num.HeaderText = "Order №";
            this.order_num.Name = "order_num";
            this.order_num.ReadOnly = true;
            this.order_num.Width = 50;
            // 
            // prodNameCnt
            // 
            this.prodNameCnt.HeaderText = "Product and Count";
            this.prodNameCnt.Name = "prodNameCnt";
            this.prodNameCnt.ReadOnly = true;
            this.prodNameCnt.Width = 300;
            // 
            // OrderTime
            // 
            this.OrderTime.HeaderText = "Order Time";
            this.OrderTime.Name = "OrderTime";
            this.OrderTime.ReadOnly = true;
            // 
            // Cook_F
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(790, 460);
            this.Controls.Add(this.cook_list);
            this.Controls.Add(this.cook_newProduct);
            this.Controls.Add(this.cook_newIngred);
            this.Controls.Add(this.cook_exIngred);
            this.Controls.Add(this.cook_ready);
            this.Controls.Add(this.label1);
            this.Name = "Cook_F";
            this.Text = "Cook";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Cook_F_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.cook_list)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cook_ready;
        private System.Windows.Forms.Button cook_exIngred;
        private System.Windows.Forms.Button cook_newIngred;
        private System.Windows.Forms.Button cook_newProduct;
        private System.Windows.Forms.DataGridView cook_list;
        private System.Windows.Forms.DataGridViewTextBoxColumn order_num;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodNameCnt;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderTime;
    }
}