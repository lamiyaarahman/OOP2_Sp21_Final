
namespace SuperShop
{
    partial class Deleteinfo
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
            this.eDelete = new System.Windows.Forms.TextBox();
            this.eIdDelete = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.dtgvInfo = new System.Windows.Forms.DataGridView();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // eDelete
            // 
            this.eDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eDelete.Location = new System.Drawing.Point(202, 68);
            this.eDelete.Name = "eDelete";
            this.eDelete.Size = new System.Drawing.Size(232, 30);
            this.eDelete.TabIndex = 13;
            // 
            // eIdDelete
            // 
            this.eIdDelete.AutoSize = true;
            this.eIdDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eIdDelete.Location = new System.Drawing.Point(46, 71);
            this.eIdDelete.Name = "eIdDelete";
            this.eIdDelete.Size = new System.Drawing.Size(138, 25);
            this.eIdDelete.TabIndex = 14;
            this.eIdDelete.Text = "Employee Id:";
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(463, 69);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(91, 33);
            this.btnDelete.TabIndex = 20;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // dtgvInfo
            // 
            this.dtgvInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvInfo.Location = new System.Drawing.Point(69, 281);
            this.dtgvInfo.Name = "dtgvInfo";
            this.dtgvInfo.RowHeadersWidth = 51;
            this.dtgvInfo.RowTemplate.Height = 24;
            this.dtgvInfo.Size = new System.Drawing.Size(685, 277);
            this.dtgvInfo.TabIndex = 21;
            // 
            // btnLoad
            // 
            this.btnLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoad.Location = new System.Drawing.Point(805, 387);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(91, 33);
            this.btnLoad.TabIndex = 22;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Location = new System.Drawing.Point(805, 460);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(91, 33);
            this.btnLogin.TabIndex = 23;
            this.btnLogin.Text = "Logout";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // Deleteinfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(980, 646);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.dtgvInfo);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.eIdDelete);
            this.Controls.Add(this.eDelete);
            this.Name = "Deleteinfo";
            this.Text = "Deleteinfo";
            this.Load += new System.EventHandler(this.Deleteinfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox eDelete;
        private System.Windows.Forms.Label eIdDelete;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView dtgvInfo;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnLogin;
    }
}