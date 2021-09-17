namespace ProviderPatternLogTest
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
            this.btnDefaultProvider = new System.Windows.Forms.Button();
            this.btnTotalProvider = new System.Windows.Forms.Button();
            this.btnGetAllDetail = new System.Windows.Forms.Button();
            this.btnDefaultDetail = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDefaultFilePath = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbLogType = new System.Windows.Forms.ComboBox();
            this.btnStAdd = new System.Windows.Forms.Button();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDefaultProvider
            // 
            this.btnDefaultProvider.Location = new System.Drawing.Point(26, 19);
            this.btnDefaultProvider.Name = "btnDefaultProvider";
            this.btnDefaultProvider.Size = new System.Drawing.Size(170, 23);
            this.btnDefaultProvider.TabIndex = 0;
            this.btnDefaultProvider.Text = "Default Provider";
            this.btnDefaultProvider.UseVisualStyleBackColor = true;
            this.btnDefaultProvider.Click += new System.EventHandler(this.btnDefaultProvider_Click);
            // 
            // btnTotalProvider
            // 
            this.btnTotalProvider.Location = new System.Drawing.Point(202, 19);
            this.btnTotalProvider.Name = "btnTotalProvider";
            this.btnTotalProvider.Size = new System.Drawing.Size(112, 23);
            this.btnTotalProvider.TabIndex = 1;
            this.btnTotalProvider.Text = "Total Provider";
            this.btnTotalProvider.UseVisualStyleBackColor = true;
            this.btnTotalProvider.Click += new System.EventHandler(this.btnTotalProvider_Click);
            // 
            // btnGetAllDetail
            // 
            this.btnGetAllDetail.Location = new System.Drawing.Point(202, 48);
            this.btnGetAllDetail.Name = "btnGetAllDetail";
            this.btnGetAllDetail.Size = new System.Drawing.Size(112, 23);
            this.btnGetAllDetail.TabIndex = 2;
            this.btnGetAllDetail.Text = "Get All Detail";
            this.btnGetAllDetail.UseVisualStyleBackColor = true;
            this.btnGetAllDetail.Click += new System.EventHandler(this.btnGetAllDetail_Click);
            // 
            // btnDefaultDetail
            // 
            this.btnDefaultDetail.Location = new System.Drawing.Point(26, 48);
            this.btnDefaultDetail.Name = "btnDefaultDetail";
            this.btnDefaultDetail.Size = new System.Drawing.Size(170, 23);
            this.btnDefaultDetail.TabIndex = 3;
            this.btnDefaultDetail.Text = "Get Default Detail";
            this.btnDefaultDetail.UseVisualStyleBackColor = true;
            this.btnDefaultDetail.Click += new System.EventHandler(this.btnDefaultDetail_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDefaultFilePath);
            this.groupBox1.Controls.Add(this.btnDefaultProvider);
            this.groupBox1.Controls.Add(this.btnDefaultDetail);
            this.groupBox1.Controls.Add(this.btnTotalProvider);
            this.groupBox1.Controls.Add(this.btnGetAllDetail);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(349, 136);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // btnDefaultFilePath
            // 
            this.btnDefaultFilePath.Location = new System.Drawing.Point(26, 77);
            this.btnDefaultFilePath.Name = "btnDefaultFilePath";
            this.btnDefaultFilePath.Size = new System.Drawing.Size(170, 23);
            this.btnDefaultFilePath.TabIndex = 4;
            this.btnDefaultFilePath.Text = "Get Default File Path\r\n";
            this.btnDefaultFilePath.UseVisualStyleBackColor = true;
            this.btnDefaultFilePath.Click += new System.EventHandler(this.btnDefaultFilePath_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmbLogType);
            this.groupBox2.Controls.Add(this.btnStAdd);
            this.groupBox2.Controls.Add(this.txtMessage);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(395, 11);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(408, 136);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // cmbLogType
            // 
            this.cmbLogType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLogType.FormattingEnabled = true;
            this.cmbLogType.Items.AddRange(new object[] {
            "Information",
            "Warning",
            "Error"});
            this.cmbLogType.Location = new System.Drawing.Point(129, 20);
            this.cmbLogType.Name = "cmbLogType";
            this.cmbLogType.Size = new System.Drawing.Size(235, 21);
            this.cmbLogType.TabIndex = 7;
            // 
            // btnStAdd
            // 
            this.btnStAdd.Location = new System.Drawing.Point(252, 101);
            this.btnStAdd.Name = "btnStAdd";
            this.btnStAdd.Size = new System.Drawing.Size(112, 23);
            this.btnStAdd.TabIndex = 6;
            this.btnStAdd.Text = "Add";
            this.btnStAdd.UseVisualStyleBackColor = true;
            this.btnStAdd.Click += new System.EventHandler(this.btnStAdd_Click);
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(129, 49);
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(235, 20);
            this.txtMessage.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Message";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Log Type:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 392);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDefaultProvider;
        private System.Windows.Forms.Button btnTotalProvider;
        private System.Windows.Forms.Button btnGetAllDetail;
        private System.Windows.Forms.Button btnDefaultDetail;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnDefaultFilePath;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnStAdd;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbLogType;
    }
}

