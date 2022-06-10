namespace MVC4LayerSalesManagementSystemProject
{
    partial class ProductsProcess
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
            this.label3 = new System.Windows.Forms.Label();
            this.btnProdList = new System.Windows.Forms.Button();
            this.btnProdDel = new System.Windows.Forms.Button();
            this.btnProdUpd = new System.Windows.Forms.Button();
            this.btnProdAdd = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtProdName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtProdUnitPrice = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.refToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ordersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comboBoxCatIdandName = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(72, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 25);
            this.label3.TabIndex = 16;
            this.label3.Text = "Products Page";
            // 
            // btnProdList
            // 
            this.btnProdList.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnProdList.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnProdList.FlatAppearance.BorderSize = 2;
            this.btnProdList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProdList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnProdList.ForeColor = System.Drawing.Color.White;
            this.btnProdList.Location = new System.Drawing.Point(77, 348);
            this.btnProdList.Name = "btnProdList";
            this.btnProdList.Size = new System.Drawing.Size(298, 35);
            this.btnProdList.TabIndex = 12;
            this.btnProdList.Text = "Show Products";
            this.btnProdList.UseVisualStyleBackColor = false;
            this.btnProdList.Click += new System.EventHandler(this.btnProdList_Click);
            // 
            // btnProdDel
            // 
            this.btnProdDel.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnProdDel.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnProdDel.FlatAppearance.BorderSize = 2;
            this.btnProdDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProdDel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnProdDel.ForeColor = System.Drawing.Color.White;
            this.btnProdDel.Location = new System.Drawing.Point(283, 299);
            this.btnProdDel.Name = "btnProdDel";
            this.btnProdDel.Size = new System.Drawing.Size(92, 35);
            this.btnProdDel.TabIndex = 13;
            this.btnProdDel.Text = "Delete";
            this.btnProdDel.UseVisualStyleBackColor = false;
            this.btnProdDel.Click += new System.EventHandler(this.btnProdDel_Click);
            // 
            // btnProdUpd
            // 
            this.btnProdUpd.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnProdUpd.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnProdUpd.FlatAppearance.BorderSize = 2;
            this.btnProdUpd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProdUpd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnProdUpd.ForeColor = System.Drawing.Color.White;
            this.btnProdUpd.Location = new System.Drawing.Point(178, 299);
            this.btnProdUpd.Name = "btnProdUpd";
            this.btnProdUpd.Size = new System.Drawing.Size(92, 35);
            this.btnProdUpd.TabIndex = 14;
            this.btnProdUpd.Text = "Update";
            this.btnProdUpd.UseVisualStyleBackColor = false;
            this.btnProdUpd.Click += new System.EventHandler(this.btnProdUpd_Click);
            // 
            // btnProdAdd
            // 
            this.btnProdAdd.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnProdAdd.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnProdAdd.FlatAppearance.BorderSize = 2;
            this.btnProdAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProdAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnProdAdd.ForeColor = System.Drawing.Color.White;
            this.btnProdAdd.Location = new System.Drawing.Point(77, 299);
            this.btnProdAdd.Name = "btnProdAdd";
            this.btnProdAdd.Size = new System.Drawing.Size(92, 35);
            this.btnProdAdd.TabIndex = 15;
            this.btnProdAdd.Text = "Add";
            this.btnProdAdd.UseVisualStyleBackColor = false;
            this.btnProdAdd.Click += new System.EventHandler(this.btnProdAdd_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(413, 88);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(788, 295);
            this.dataGridView1.TabIndex = 11;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // txtProdName
            // 
            this.txtProdName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtProdName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtProdName.Location = new System.Drawing.Point(216, 135);
            this.txtProdName.MaximumSize = new System.Drawing.Size(180, 50);
            this.txtProdName.MinimumSize = new System.Drawing.Size(100, 25);
            this.txtProdName.Multiline = true;
            this.txtProdName.Name = "txtProdName";
            this.txtProdName.Size = new System.Drawing.Size(159, 28);
            this.txtProdName.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(73, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Product Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(73, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Unit Price";
            // 
            // txtProdUnitPrice
            // 
            this.txtProdUnitPrice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtProdUnitPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtProdUnitPrice.Location = new System.Drawing.Point(216, 183);
            this.txtProdUnitPrice.MaximumSize = new System.Drawing.Size(180, 50);
            this.txtProdUnitPrice.MinimumSize = new System.Drawing.Size(100, 25);
            this.txtProdUnitPrice.Multiline = true;
            this.txtProdUnitPrice.Name = "txtProdUnitPrice";
            this.txtProdUnitPrice.Size = new System.Drawing.Size(159, 28);
            this.txtProdUnitPrice.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(73, 231);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Category Name";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Black;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.refToolStripMenuItem,
            this.productToolStripMenuItem,
            this.customerToolStripMenuItem,
            this.categoryToolStripMenuItem,
            this.ordersToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1245, 30);
            this.menuStrip1.TabIndex = 17;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // refToolStripMenuItem
            // 
            this.refToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.refToolStripMenuItem.Name = "refToolStripMenuItem";
            this.refToolStripMenuItem.Size = new System.Drawing.Size(96, 26);
            this.refToolStripMenuItem.Text = "Dashboard";
            this.refToolStripMenuItem.Click += new System.EventHandler(this.refToolStripMenuItem_Click);
            // 
            // productToolStripMenuItem
            // 
            this.productToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.productToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.productToolStripMenuItem.Name = "productToolStripMenuItem";
            this.productToolStripMenuItem.Size = new System.Drawing.Size(80, 26);
            this.productToolStripMenuItem.Text = "Products";
            this.productToolStripMenuItem.Click += new System.EventHandler(this.productToolStripMenuItem_Click);
            // 
            // customerToolStripMenuItem
            // 
            this.customerToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.customerToolStripMenuItem.Name = "customerToolStripMenuItem";
            this.customerToolStripMenuItem.Size = new System.Drawing.Size(92, 26);
            this.customerToolStripMenuItem.Text = "Customers";
            this.customerToolStripMenuItem.Click += new System.EventHandler(this.customerToolStripMenuItem_Click);
            // 
            // categoryToolStripMenuItem
            // 
            this.categoryToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.categoryToolStripMenuItem.Name = "categoryToolStripMenuItem";
            this.categoryToolStripMenuItem.Size = new System.Drawing.Size(94, 26);
            this.categoryToolStripMenuItem.Text = "Categories";
            this.categoryToolStripMenuItem.Click += new System.EventHandler(this.categoryToolStripMenuItem_Click);
            // 
            // ordersToolStripMenuItem
            // 
            this.ordersToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.ordersToolStripMenuItem.Name = "ordersToolStripMenuItem";
            this.ordersToolStripMenuItem.Size = new System.Drawing.Size(67, 26);
            this.ordersToolStripMenuItem.Text = "Orders";
            this.ordersToolStripMenuItem.Click += new System.EventHandler(this.ordersToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(76, 26);
            this.exitToolStripMenuItem.Text = "Log Out";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // comboBoxCatIdandName
            // 
            this.comboBoxCatIdandName.DisplayMember = "Seçiniz";
            this.comboBoxCatIdandName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCatIdandName.FormattingEnabled = true;
            this.comboBoxCatIdandName.Items.AddRange(new object[] {
            "Seçiniz"});
            this.comboBoxCatIdandName.Location = new System.Drawing.Point(216, 231);
            this.comboBoxCatIdandName.Name = "comboBoxCatIdandName";
            this.comboBoxCatIdandName.Size = new System.Drawing.Size(168, 24);
            this.comboBoxCatIdandName.TabIndex = 18;
            this.comboBoxCatIdandName.SelectedIndexChanged += new System.EventHandler(this.comboBoxCatIdandName_SelectedIndexChanged);
            this.comboBoxCatIdandName.Click += new System.EventHandler(this.comboBoxCatIdandName_Click);
            // 
            // ProductsProcess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(1245, 450);
            this.Controls.Add(this.comboBoxCatIdandName);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnProdList);
            this.Controls.Add(this.btnProdDel);
            this.Controls.Add(this.btnProdUpd);
            this.Controls.Add(this.btnProdAdd);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtProdUnitPrice);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtProdName);
            this.Controls.Add(this.label1);
            this.Name = "ProductsProcess";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sales Management System";
            this.Load += new System.EventHandler(this.ProductsProcess_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnProdList;
        private System.Windows.Forms.Button btnProdDel;
        private System.Windows.Forms.Button btnProdUpd;
        private System.Windows.Forms.Button btnProdAdd;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtProdName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtProdUnitPrice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem productToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem categoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ordersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ComboBox comboBoxCatIdandName;
    }
}