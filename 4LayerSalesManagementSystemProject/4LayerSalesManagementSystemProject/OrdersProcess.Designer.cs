namespace MVC4LayerSalesManagementSystemProject
{
    partial class OrdersProcess
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
            this.maskedTextBoxDeliveryDate = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnOrderList = new System.Windows.Forms.Button();
            this.btnOrderDel = new System.Windows.Forms.Button();
            this.btnOrderUpd = new System.Windows.Forms.Button();
            this.btnOrderAdd = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.txtTotalPrice = new System.Windows.Forms.TextBox();
            this.comboBoxDeliveryStatus = new System.Windows.Forms.ComboBox();
            this.lblEmployeeName = new System.Windows.Forms.Label();
            this.maskedTextBoxOrderDate = new System.Windows.Forms.MaskedTextBox();
            this.refToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ordersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comboBoxProdNameandId = new System.Windows.Forms.ComboBox();
            this.comboBoxCustomerNameandId = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // maskedTextBoxDeliveryDate
            // 
            this.maskedTextBoxDeliveryDate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.maskedTextBoxDeliveryDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.maskedTextBoxDeliveryDate.Location = new System.Drawing.Point(327, 230);
            this.maskedTextBoxDeliveryDate.Mask = "00/00/0000";
            this.maskedTextBoxDeliveryDate.MaximumSize = new System.Drawing.Size(180, 50);
            this.maskedTextBoxDeliveryDate.MinimumSize = new System.Drawing.Size(100, 28);
            this.maskedTextBoxDeliveryDate.Name = "maskedTextBoxDeliveryDate";
            this.maskedTextBoxDeliveryDate.Size = new System.Drawing.Size(180, 23);
            this.maskedTextBoxDeliveryDate.TabIndex = 4;
            this.maskedTextBoxDeliveryDate.ValidatingType = typeof(System.DateTime);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(86, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 25);
            this.label3.TabIndex = 42;
            this.label3.Text = "Orders Page";
            // 
            // btnOrderList
            // 
            this.btnOrderList.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnOrderList.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnOrderList.FlatAppearance.BorderSize = 2;
            this.btnOrderList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrderList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOrderList.ForeColor = System.Drawing.Color.White;
            this.btnOrderList.Location = new System.Drawing.Point(389, 344);
            this.btnOrderList.Name = "btnOrderList";
            this.btnOrderList.Size = new System.Drawing.Size(412, 37);
            this.btnOrderList.TabIndex = 12;
            this.btnOrderList.Text = "Show Products";
            this.btnOrderList.UseVisualStyleBackColor = false;
            this.btnOrderList.Click += new System.EventHandler(this.btnOrderList_Click);
            // 
            // btnOrderDel
            // 
            this.btnOrderDel.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnOrderDel.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnOrderDel.FlatAppearance.BorderSize = 2;
            this.btnOrderDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrderDel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOrderDel.ForeColor = System.Drawing.Color.White;
            this.btnOrderDel.Location = new System.Drawing.Point(674, 295);
            this.btnOrderDel.Name = "btnOrderDel";
            this.btnOrderDel.Size = new System.Drawing.Size(127, 37);
            this.btnOrderDel.TabIndex = 11;
            this.btnOrderDel.Text = "Delete";
            this.btnOrderDel.UseVisualStyleBackColor = false;
            this.btnOrderDel.Click += new System.EventHandler(this.btnOrderDel_Click);
            // 
            // btnOrderUpd
            // 
            this.btnOrderUpd.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnOrderUpd.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnOrderUpd.FlatAppearance.BorderSize = 2;
            this.btnOrderUpd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrderUpd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOrderUpd.ForeColor = System.Drawing.Color.White;
            this.btnOrderUpd.Location = new System.Drawing.Point(531, 295);
            this.btnOrderUpd.Name = "btnOrderUpd";
            this.btnOrderUpd.Size = new System.Drawing.Size(127, 37);
            this.btnOrderUpd.TabIndex = 10;
            this.btnOrderUpd.Text = "Update";
            this.btnOrderUpd.UseVisualStyleBackColor = false;
            this.btnOrderUpd.Click += new System.EventHandler(this.btnOrderUpd_Click);
            // 
            // btnOrderAdd
            // 
            this.btnOrderAdd.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnOrderAdd.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnOrderAdd.FlatAppearance.BorderSize = 2;
            this.btnOrderAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrderAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOrderAdd.ForeColor = System.Drawing.Color.White;
            this.btnOrderAdd.Location = new System.Drawing.Point(389, 295);
            this.btnOrderAdd.Name = "btnOrderAdd";
            this.btnOrderAdd.Size = new System.Drawing.Size(127, 37);
            this.btnOrderAdd.TabIndex = 9;
            this.btnOrderAdd.Text = "Add";
            this.btnOrderAdd.UseVisualStyleBackColor = false;
            this.btnOrderAdd.Click += new System.EventHandler(this.btnOrderAdd_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 409);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1268, 476);
            this.dataGridView1.TabIndex = 37;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(87, 230);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 20);
            this.label5.TabIndex = 30;
            this.label5.Text = "Delivery Date";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(87, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 20);
            this.label4.TabIndex = 31;
            this.label4.Text = "Order Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(87, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 20);
            this.label2.TabIndex = 32;
            this.label2.Text = "Customer Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(87, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 20);
            this.label1.TabIndex = 33;
            this.label1.Text = "Product Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(618, 101);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 20);
            this.label6.TabIndex = 30;
            this.label6.Text = "Quantity";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(618, 141);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 20);
            this.label7.TabIndex = 30;
            this.label7.Text = "Total Price";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.SystemColors.Control;
            this.label8.Location = new System.Drawing.Point(618, 182);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(123, 20);
            this.label8.TabIndex = 30;
            this.label8.Text = "Delivery Status";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.ForeColor = System.Drawing.SystemColors.Control;
            this.label9.Location = new System.Drawing.Point(618, 226);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(131, 20);
            this.label9.TabIndex = 30;
            this.label9.Text = "Employee Name";
            // 
            // txtQuantity
            // 
            this.txtQuantity.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtQuantity.Location = new System.Drawing.Point(858, 101);
            this.txtQuantity.MaximumSize = new System.Drawing.Size(180, 50);
            this.txtQuantity.MinimumSize = new System.Drawing.Size(100, 25);
            this.txtQuantity.Multiline = true;
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(180, 28);
            this.txtQuantity.TabIndex = 5;
            // 
            // txtTotalPrice
            // 
            this.txtTotalPrice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTotalPrice.Location = new System.Drawing.Point(858, 141);
            this.txtTotalPrice.MaximumSize = new System.Drawing.Size(180, 50);
            this.txtTotalPrice.MinimumSize = new System.Drawing.Size(100, 25);
            this.txtTotalPrice.Multiline = true;
            this.txtTotalPrice.Name = "txtTotalPrice";
            this.txtTotalPrice.Size = new System.Drawing.Size(180, 28);
            this.txtTotalPrice.TabIndex = 6;
            // 
            // comboBoxDeliveryStatus
            // 
            this.comboBoxDeliveryStatus.DisplayMember = "Seç";
            this.comboBoxDeliveryStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDeliveryStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxDeliveryStatus.FormattingEnabled = true;
            this.comboBoxDeliveryStatus.IntegralHeight = false;
            this.comboBoxDeliveryStatus.Items.AddRange(new object[] {
            "Sipariş Hazırlanıyor",
            "Kargoda",
            "Teslim Edildi",
            "İptal Edildi",
            "İade Edildi",
            "Müşteri Evde Yoktu"});
            this.comboBoxDeliveryStatus.Location = new System.Drawing.Point(855, 185);
            this.comboBoxDeliveryStatus.MaximumSize = new System.Drawing.Size(180, 0);
            this.comboBoxDeliveryStatus.MinimumSize = new System.Drawing.Size(180, 0);
            this.comboBoxDeliveryStatus.Name = "comboBoxDeliveryStatus";
            this.comboBoxDeliveryStatus.Size = new System.Drawing.Size(180, 24);
            this.comboBoxDeliveryStatus.TabIndex = 7;
            // 
            // lblEmployeeName
            // 
            this.lblEmployeeName.AutoSize = true;
            this.lblEmployeeName.BackColor = System.Drawing.Color.White;
            this.lblEmployeeName.Location = new System.Drawing.Point(855, 230);
            this.lblEmployeeName.MaximumSize = new System.Drawing.Size(180, 50);
            this.lblEmployeeName.MinimumSize = new System.Drawing.Size(180, 28);
            this.lblEmployeeName.Name = "lblEmployeeName";
            this.lblEmployeeName.Size = new System.Drawing.Size(180, 28);
            this.lblEmployeeName.TabIndex = 8;
            // 
            // maskedTextBoxOrderDate
            // 
            this.maskedTextBoxOrderDate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.maskedTextBoxOrderDate.Enabled = false;
            this.maskedTextBoxOrderDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.maskedTextBoxOrderDate.Location = new System.Drawing.Point(327, 185);
            this.maskedTextBoxOrderDate.Mask = "00/00/0000";
            this.maskedTextBoxOrderDate.MaximumSize = new System.Drawing.Size(180, 50);
            this.maskedTextBoxOrderDate.MinimumSize = new System.Drawing.Size(100, 28);
            this.maskedTextBoxOrderDate.Name = "maskedTextBoxOrderDate";
            this.maskedTextBoxOrderDate.Size = new System.Drawing.Size(180, 23);
            this.maskedTextBoxOrderDate.TabIndex = 3;
            this.maskedTextBoxOrderDate.ValidatingType = typeof(System.DateTime);
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
            this.menuStrip1.Size = new System.Drawing.Size(1293, 28);
            this.menuStrip1.TabIndex = 43;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(76, 24);
            this.exitToolStripMenuItem.Text = "Log Out";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // comboBoxProdNameandId
            // 
            this.comboBoxProdNameandId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxProdNameandId.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxProdNameandId.FormattingEnabled = true;
            this.comboBoxProdNameandId.IntegralHeight = false;
            this.comboBoxProdNameandId.Location = new System.Drawing.Point(327, 93);
            this.comboBoxProdNameandId.MaximumSize = new System.Drawing.Size(180, 0);
            this.comboBoxProdNameandId.MinimumSize = new System.Drawing.Size(180, 0);
            this.comboBoxProdNameandId.Name = "comboBoxProdNameandId";
            this.comboBoxProdNameandId.Size = new System.Drawing.Size(180, 24);
            this.comboBoxProdNameandId.TabIndex = 7;
            // 
            // comboBoxCustomerNameandId
            // 
            this.comboBoxCustomerNameandId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCustomerNameandId.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxCustomerNameandId.FormattingEnabled = true;
            this.comboBoxCustomerNameandId.IntegralHeight = false;
            this.comboBoxCustomerNameandId.Items.AddRange(new object[] {
            "fbgdf",
            "fdg",
            "fgd",
            "asa",
            "dfd"});
            this.comboBoxCustomerNameandId.Location = new System.Drawing.Point(327, 137);
            this.comboBoxCustomerNameandId.MaximumSize = new System.Drawing.Size(180, 0);
            this.comboBoxCustomerNameandId.MinimumSize = new System.Drawing.Size(180, 0);
            this.comboBoxCustomerNameandId.Name = "comboBoxCustomerNameandId";
            this.comboBoxCustomerNameandId.Size = new System.Drawing.Size(180, 24);
            this.comboBoxCustomerNameandId.TabIndex = 7;
            // 
            // OrdersProcess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(1293, 953);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.lblEmployeeName);
            this.Controls.Add(this.comboBoxCustomerNameandId);
            this.Controls.Add(this.comboBoxProdNameandId);
            this.Controls.Add(this.comboBoxDeliveryStatus);
            this.Controls.Add(this.maskedTextBoxOrderDate);
            this.Controls.Add(this.maskedTextBoxDeliveryDate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnOrderList);
            this.Controls.Add(this.btnOrderDel);
            this.Controls.Add(this.btnOrderUpd);
            this.Controls.Add(this.btnOrderAdd);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtTotalPrice);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "OrdersProcess";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sales Management System";
            this.Load += new System.EventHandler(this.OrdersProcess_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox maskedTextBoxDeliveryDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnOrderList;
        private System.Windows.Forms.Button btnOrderDel;
        private System.Windows.Forms.Button btnOrderUpd;
        private System.Windows.Forms.Button btnOrderAdd;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.TextBox txtTotalPrice;
        private System.Windows.Forms.ComboBox comboBoxDeliveryStatus;
        private System.Windows.Forms.Label lblEmployeeName;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxOrderDate;
        private System.Windows.Forms.ToolStripMenuItem refToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem categoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ordersToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ComboBox comboBoxProdNameandId;
        private System.Windows.Forms.ComboBox comboBoxCustomerNameandId;
    }
}