namespace MVC4LayerSalesManagementSystemProject
{
    partial class EmployeeLoginandSignUp
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
            this.btnLogin = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtuserName = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.linkLabelSignUp = new System.Windows.Forms.LinkLabel();
            this.label3LoginTitle = new System.Windows.Forms.Label();
            this.lblNameSurname = new System.Windows.Forms.Label();
            this.txtNameSurname = new System.Windows.Forms.TextBox();
            this.btnSign = new System.Windows.Forms.Button();
            this.linkLabelLogin = new System.Windows.Forms.LinkLabel();
            this.label4SignUpTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(77, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "User Name";
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnLogin.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnLogin.FlatAppearance.BorderSize = 2;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(81, 243);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(281, 39);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(77, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            // 
            // txtuserName
            // 
            this.txtuserName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtuserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtuserName.Location = new System.Drawing.Point(219, 140);
            this.txtuserName.MaximumSize = new System.Drawing.Size(180, 50);
            this.txtuserName.MinimumSize = new System.Drawing.Size(100, 25);
            this.txtuserName.Multiline = true;
            this.txtuserName.Name = "txtuserName";
            this.txtuserName.Size = new System.Drawing.Size(170, 28);
            this.txtuserName.TabIndex = 2;
            // 
            // txtPassword
            // 
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtPassword.Location = new System.Drawing.Point(219, 189);
            this.txtPassword.MaximumSize = new System.Drawing.Size(180, 50);
            this.txtPassword.MinimumSize = new System.Drawing.Size(100, 25);
            this.txtPassword.Multiline = true;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(170, 28);
            this.txtPassword.TabIndex = 3;
            // 
            // linkLabelSignUp
            // 
            this.linkLabelSignUp.AutoSize = true;
            this.linkLabelSignUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.linkLabelSignUp.ForeColor = System.Drawing.Color.IndianRed;
            this.linkLabelSignUp.LinkColor = System.Drawing.Color.White;
            this.linkLabelSignUp.Location = new System.Drawing.Point(190, 299);
            this.linkLabelSignUp.Name = "linkLabelSignUp";
            this.linkLabelSignUp.Size = new System.Drawing.Size(68, 20);
            this.linkLabelSignUp.TabIndex = 4;
            this.linkLabelSignUp.TabStop = true;
            this.linkLabelSignUp.Text = "Sign Up";
            this.linkLabelSignUp.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelSignUp_LinkClicked);
            // 
            // label3LoginTitle
            // 
            this.label3LoginTitle.AutoSize = true;
            this.label3LoginTitle.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.label3LoginTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3LoginTitle.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3LoginTitle.Location = new System.Drawing.Point(114, 86);
            this.label3LoginTitle.Name = "label3LoginTitle";
            this.label3LoginTitle.Size = new System.Drawing.Size(214, 22);
            this.label3LoginTitle.TabIndex = 1;
            this.label3LoginTitle.Text = "Employees Login Page";
            // 
            // lblNameSurname
            // 
            this.lblNameSurname.AutoSize = true;
            this.lblNameSurname.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.lblNameSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblNameSurname.ForeColor = System.Drawing.SystemColors.Control;
            this.lblNameSurname.Location = new System.Drawing.Point(77, 90);
            this.lblNameSurname.Name = "lblNameSurname";
            this.lblNameSurname.Size = new System.Drawing.Size(125, 20);
            this.lblNameSurname.TabIndex = 1;
            this.lblNameSurname.Text = "Name Surname";
            this.lblNameSurname.Visible = false;
            // 
            // txtNameSurname
            // 
            this.txtNameSurname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNameSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtNameSurname.Location = new System.Drawing.Point(219, 88);
            this.txtNameSurname.MaximumSize = new System.Drawing.Size(180, 50);
            this.txtNameSurname.MinimumSize = new System.Drawing.Size(100, 25);
            this.txtNameSurname.Multiline = true;
            this.txtNameSurname.Name = "txtNameSurname";
            this.txtNameSurname.Size = new System.Drawing.Size(170, 28);
            this.txtNameSurname.TabIndex = 1;
            this.txtNameSurname.Visible = false;
            // 
            // btnSign
            // 
            this.btnSign.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnSign.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSign.FlatAppearance.BorderSize = 2;
            this.btnSign.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSign.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSign.ForeColor = System.Drawing.Color.White;
            this.btnSign.Location = new System.Drawing.Point(81, 243);
            this.btnSign.Name = "btnSign";
            this.btnSign.Size = new System.Drawing.Size(281, 39);
            this.btnSign.TabIndex = 2;
            this.btnSign.Text = "Sign Up";
            this.btnSign.UseVisualStyleBackColor = false;
            this.btnSign.Visible = false;
            this.btnSign.Click += new System.EventHandler(this.btnSign_Click);
            // 
            // linkLabelLogin
            // 
            this.linkLabelLogin.AutoSize = true;
            this.linkLabelLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.linkLabelLogin.ForeColor = System.Drawing.Color.IndianRed;
            this.linkLabelLogin.LinkColor = System.Drawing.Color.White;
            this.linkLabelLogin.Location = new System.Drawing.Point(198, 299);
            this.linkLabelLogin.Name = "linkLabelLogin";
            this.linkLabelLogin.Size = new System.Drawing.Size(50, 20);
            this.linkLabelLogin.TabIndex = 4;
            this.linkLabelLogin.TabStop = true;
            this.linkLabelLogin.Text = "Login";
            this.linkLabelLogin.Visible = false;
            this.linkLabelLogin.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelLogin_LinkClicked);
            // 
            // label4SignUpTitle
            // 
            this.label4SignUpTitle.AutoSize = true;
            this.label4SignUpTitle.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.label4SignUpTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4SignUpTitle.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4SignUpTitle.Location = new System.Drawing.Point(114, 39);
            this.label4SignUpTitle.Name = "label4SignUpTitle";
            this.label4SignUpTitle.Size = new System.Drawing.Size(236, 22);
            this.label4SignUpTitle.TabIndex = 1;
            this.label4SignUpTitle.Text = "Employees Sign Up Page";
            this.label4SignUpTitle.Visible = false;
            // 
            // EmployeeLoginandSignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(463, 358);
            this.Controls.Add(this.linkLabelLogin);
            this.Controls.Add(this.linkLabelSignUp);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtNameSurname);
            this.Controls.Add(this.txtuserName);
            this.Controls.Add(this.btnSign);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4SignUpTitle);
            this.Controls.Add(this.label3LoginTitle);
            this.Controls.Add(this.lblNameSurname);
            this.Controls.Add(this.label1);
            this.Name = "EmployeeLoginandSignUp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sales Management System";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtuserName;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.LinkLabel linkLabelSignUp;
        private System.Windows.Forms.Label label3LoginTitle;
        private System.Windows.Forms.Label lblNameSurname;
        private System.Windows.Forms.TextBox txtNameSurname;
        private System.Windows.Forms.Button btnSign;
        private System.Windows.Forms.LinkLabel linkLabelLogin;
        private System.Windows.Forms.Label label4SignUpTitle;
    }
}

