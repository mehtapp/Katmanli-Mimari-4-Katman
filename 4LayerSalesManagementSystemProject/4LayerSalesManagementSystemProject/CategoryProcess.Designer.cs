namespace MVC4LayerSalesManagementSystemProject
{
    partial class CategoryProcess
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
            this.txtCategoryName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnCatAdd = new System.Windows.Forms.Button();
            this.btnCatUpd = new System.Windows.Forms.Button();
            this.btnCatDel = new System.Windows.Forms.Button();
            this.btnCatList = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.refToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ordersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtCategoryName
            // 
            this.txtCategoryName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCategoryName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtCategoryName.Location = new System.Drawing.Point(202, 140);
            this.txtCategoryName.MaximumSize = new System.Drawing.Size(180, 50);
            this.txtCategoryName.MinimumSize = new System.Drawing.Size(100, 25);
            this.txtCategoryName.Name = "txtCategoryName";
            this.txtCategoryName.Size = new System.Drawing.Size(159, 23);
            this.txtCategoryName.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(59, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Category Name";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(415, 78);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(343, 275);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // btnCatAdd
            // 
            this.btnCatAdd.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnCatAdd.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCatAdd.FlatAppearance.BorderSize = 2;
            this.btnCatAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCatAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCatAdd.ForeColor = System.Drawing.Color.White;
            this.btnCatAdd.Location = new System.Drawing.Point(63, 223);
            this.btnCatAdd.Name = "btnCatAdd";
            this.btnCatAdd.Size = new System.Drawing.Size(92, 35);
            this.btnCatAdd.TabIndex = 7;
            this.btnCatAdd.Text = "Add";
            this.btnCatAdd.UseVisualStyleBackColor = false;
            this.btnCatAdd.Click += new System.EventHandler(this.btnCatAdd_Click);
            // 
            // btnCatUpd
            // 
            this.btnCatUpd.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnCatUpd.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCatUpd.FlatAppearance.BorderSize = 2;
            this.btnCatUpd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCatUpd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCatUpd.ForeColor = System.Drawing.Color.White;
            this.btnCatUpd.Location = new System.Drawing.Point(164, 223);
            this.btnCatUpd.Name = "btnCatUpd";
            this.btnCatUpd.Size = new System.Drawing.Size(92, 35);
            this.btnCatUpd.TabIndex = 7;
            this.btnCatUpd.Text = "Update";
            this.btnCatUpd.UseVisualStyleBackColor = false;
            this.btnCatUpd.Click += new System.EventHandler(this.btnCatUpd_Click);
            // 
            // btnCatDel
            // 
            this.btnCatDel.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnCatDel.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCatDel.FlatAppearance.BorderSize = 2;
            this.btnCatDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCatDel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCatDel.ForeColor = System.Drawing.Color.White;
            this.btnCatDel.Location = new System.Drawing.Point(269, 223);
            this.btnCatDel.Name = "btnCatDel";
            this.btnCatDel.Size = new System.Drawing.Size(92, 35);
            this.btnCatDel.TabIndex = 7;
            this.btnCatDel.Text = "Delete";
            this.btnCatDel.UseVisualStyleBackColor = false;
            this.btnCatDel.Click += new System.EventHandler(this.btnCatDel_Click);
            // 
            // btnCatList
            // 
            this.btnCatList.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnCatList.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCatList.FlatAppearance.BorderSize = 2;
            this.btnCatList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCatList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCatList.ForeColor = System.Drawing.Color.White;
            this.btnCatList.Location = new System.Drawing.Point(63, 264);
            this.btnCatList.Name = "btnCatList";
            this.btnCatList.Size = new System.Drawing.Size(298, 35);
            this.btnCatList.TabIndex = 7;
            this.btnCatList.Text = "Show Categories";
            this.btnCatList.UseVisualStyleBackColor = false;
            this.btnCatList.Click += new System.EventHandler(this.btnCatList_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(58, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(173, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "Categories Page";
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
            this.menuStrip1.Size = new System.Drawing.Size(782, 28);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // refToolStripMenuItem
            // 
            this.refToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.refToolStripMenuItem.Name = "refToolStripMenuItem";
            this.refToolStripMenuItem.Size = new System.Drawing.Size(96, 24);
            this.refToolStripMenuItem.Text = "Dashboard";
            this.refToolStripMenuItem.Click += new System.EventHandler(this.refToolStripMenuItem_Click);
            // 
            // productToolStripMenuItem
            // 
            this.productToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.productToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.productToolStripMenuItem.Name = "productToolStripMenuItem";
            this.productToolStripMenuItem.Size = new System.Drawing.Size(80, 24);
            this.productToolStripMenuItem.Text = "Products";
            this.productToolStripMenuItem.Click += new System.EventHandler(this.productToolStripMenuItem_Click);
            // 
            // customerToolStripMenuItem
            // 
            this.customerToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.customerToolStripMenuItem.Name = "customerToolStripMenuItem";
            this.customerToolStripMenuItem.Size = new System.Drawing.Size(92, 24);
            this.customerToolStripMenuItem.Text = "Customers";
            this.customerToolStripMenuItem.Click += new System.EventHandler(this.customerToolStripMenuItem_Click);
            // 
            // categoryToolStripMenuItem
            // 
            this.categoryToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.categoryToolStripMenuItem.Name = "categoryToolStripMenuItem";
            this.categoryToolStripMenuItem.Size = new System.Drawing.Size(94, 24);
            this.categoryToolStripMenuItem.Text = "Categories";
            this.categoryToolStripMenuItem.Click += new System.EventHandler(this.categoryToolStripMenuItem_Click);
            // 
            // ordersToolStripMenuItem
            // 
            this.ordersToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.ordersToolStripMenuItem.Name = "ordersToolStripMenuItem";
            this.ordersToolStripMenuItem.Size = new System.Drawing.Size(67, 24);
            this.ordersToolStripMenuItem.Text = "Orders";
            this.ordersToolStripMenuItem.Click += new System.EventHandler(this.ordersToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(76, 24);
            this.exitToolStripMenuItem.Text = "Log Out";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // CategoryProcess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(782, 415);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnCatList);
            this.Controls.Add(this.btnCatDel);
            this.Controls.Add(this.btnCatUpd);
            this.Controls.Add(this.btnCatAdd);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtCategoryName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "CategoryProcess";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sales Management System";
            this.Load += new System.EventHandler(this.CategoryProcess_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCategoryName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnCatAdd;
        private System.Windows.Forms.Button btnCatUpd;
        private System.Windows.Forms.Button btnCatDel;
        private System.Windows.Forms.Button btnCatList;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem productToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem categoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ordersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}