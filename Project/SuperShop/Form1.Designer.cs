
namespace SuperShop
{
    partial class Form1
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
            this.label4 = new System.Windows.Forms.Label();
            this.eName = new System.Windows.Forms.TextBox();
            this.eAddress = new System.Windows.Forms.TextBox();
            this.ePhone = new System.Windows.Forms.TextBox();
            this.eSalary = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dtgvInfo = new System.Windows.Forms.DataGridView();
            this.infoData = new System.Windows.Forms.Button();
            this.eId = new System.Windows.Forms.Label();
            this.eSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.sUpdate = new System.Windows.Forms.Label();
            this.eUpdate = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.enUpdate = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Employee Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(103, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Address:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(121, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Phone:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(121, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Salary:";
            // 
            // eName
            // 
            this.eName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eName.Location = new System.Drawing.Point(208, 15);
            this.eName.Name = "eName";
            this.eName.Size = new System.Drawing.Size(232, 30);
            this.eName.TabIndex = 4;
            // 
            // eAddress
            // 
            this.eAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eAddress.Location = new System.Drawing.Point(208, 59);
            this.eAddress.Name = "eAddress";
            this.eAddress.Size = new System.Drawing.Size(232, 30);
            this.eAddress.TabIndex = 5;
            // 
            // ePhone
            // 
            this.ePhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ePhone.Location = new System.Drawing.Point(208, 96);
            this.ePhone.Name = "ePhone";
            this.ePhone.Size = new System.Drawing.Size(232, 30);
            this.ePhone.TabIndex = 6;
            // 
            // eSalary
            // 
            this.eSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eSalary.Location = new System.Drawing.Point(208, 138);
            this.eSalary.Name = "eSalary";
            this.eSalary.Size = new System.Drawing.Size(232, 30);
            this.eSalary.TabIndex = 7;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(149, 210);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(91, 33);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dtgvInfo
            // 
            this.dtgvInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvInfo.Location = new System.Drawing.Point(257, 274);
            this.dtgvInfo.Name = "dtgvInfo";
            this.dtgvInfo.RowHeadersWidth = 51;
            this.dtgvInfo.RowTemplate.Height = 24;
            this.dtgvInfo.Size = new System.Drawing.Size(685, 277);
            this.dtgvInfo.TabIndex = 9;
            // 
            // infoData
            // 
            this.infoData.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoData.Location = new System.Drawing.Point(268, 210);
            this.infoData.Name = "infoData";
            this.infoData.Size = new System.Drawing.Size(93, 41);
            this.infoData.TabIndex = 10;
            this.infoData.Text = "Info";
            this.infoData.UseVisualStyleBackColor = true;
            this.infoData.Click += new System.EventHandler(this.infoData_Click);
            // 
            // eId
            // 
            this.eId.AutoSize = true;
            this.eId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eId.Location = new System.Drawing.Point(590, 18);
            this.eId.Name = "eId";
            this.eId.Size = new System.Drawing.Size(138, 25);
            this.eId.TabIndex = 11;
            this.eId.Text = "Employee Id:";
            // 
            // eSearch
            // 
            this.eSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eSearch.Location = new System.Drawing.Point(734, 18);
            this.eSearch.Name = "eSearch";
            this.eSearch.Size = new System.Drawing.Size(232, 30);
            this.eSearch.TabIndex = 12;
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(982, 16);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(91, 33);
            this.btnSearch.TabIndex = 13;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // sUpdate
            // 
            this.sUpdate.AutoSize = true;
            this.sUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sUpdate.Location = new System.Drawing.Point(638, 143);
            this.sUpdate.Name = "sUpdate";
            this.sUpdate.Size = new System.Drawing.Size(81, 25);
            this.sUpdate.TabIndex = 14;
            this.sUpdate.Text = "Salary:";
            // 
            // eUpdate
            // 
            this.eUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eUpdate.Location = new System.Drawing.Point(734, 138);
            this.eUpdate.Name = "eUpdate";
            this.eUpdate.Size = new System.Drawing.Size(232, 30);
            this.eUpdate.TabIndex = 15;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(800, 191);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(91, 33);
            this.btnUpdate.TabIndex = 16;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(543, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(176, 25);
            this.label5.TabIndex = 17;
            this.label5.Text = "Employee Name:";
            // 
            // enUpdate
            // 
            this.enUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enUpdate.Location = new System.Drawing.Point(734, 91);
            this.enUpdate.Name = "enUpdate";
            this.enUpdate.Size = new System.Drawing.Size(232, 30);
            this.enUpdate.TabIndex = 18;
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(982, 472);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(91, 33);
            this.btnDelete.TabIndex = 19;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Location = new System.Drawing.Point(31, 518);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(91, 33);
            this.btnLogin.TabIndex = 20;
            this.btnLogin.Text = "Logout";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(1194, 653);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.enUpdate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.eUpdate);
            this.Controls.Add(this.sUpdate);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.eSearch);
            this.Controls.Add(this.eId);
            this.Controls.Add(this.infoData);
            this.Controls.Add(this.dtgvInfo);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.eSalary);
            this.Controls.Add(this.ePhone);
            this.Controls.Add(this.eAddress);
            this.Controls.Add(this.eName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox eName;
        private System.Windows.Forms.TextBox eAddress;
        private System.Windows.Forms.TextBox ePhone;
        private System.Windows.Forms.TextBox eSalary;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dtgvInfo;
        private System.Windows.Forms.Button infoData;
        private System.Windows.Forms.Label eId;
        private System.Windows.Forms.TextBox eSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label sUpdate;
        private System.Windows.Forms.TextBox eUpdate;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox enUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnLogin;
    }
}

