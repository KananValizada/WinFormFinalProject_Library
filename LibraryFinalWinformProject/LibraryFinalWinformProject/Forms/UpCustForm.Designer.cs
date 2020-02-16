namespace LibraryFinalWinformProject.Forms
{
    partial class UpCustForm
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
            this.btnBookUp = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Find = new System.Windows.Forms.Label();
            this.txtFindCust = new System.Windows.Forms.TextBox();
            this.dgvFindCtm = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtMail = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFindCtm)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBookUp
            // 
            this.btnBookUp.Location = new System.Drawing.Point(304, 296);
            this.btnBookUp.Name = "btnBookUp";
            this.btnBookUp.Size = new System.Drawing.Size(75, 23);
            this.btnBookUp.TabIndex = 30;
            this.btnBookUp.Text = "Update";
            this.btnBookUp.UseVisualStyleBackColor = true;
            this.btnBookUp.Click += new System.EventHandler(this.btnBookUp_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(32, 330);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "Email";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(32, 296);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 29;
            this.label1.Text = "Phone";
            // 
            // Find
            // 
            this.Find.AutoSize = true;
            this.Find.BackColor = System.Drawing.Color.Transparent;
            this.Find.ForeColor = System.Drawing.Color.White;
            this.Find.Location = new System.Drawing.Point(32, 62);
            this.Find.Name = "Find";
            this.Find.Size = new System.Drawing.Size(99, 13);
            this.Find.TabIndex = 26;
            this.Find.Text = "Find Cust by Phone";
            // 
            // txtFindCust
            // 
            this.txtFindCust.Location = new System.Drawing.Point(162, 59);
            this.txtFindCust.Name = "txtFindCust";
            this.txtFindCust.Size = new System.Drawing.Size(100, 20);
            this.txtFindCust.TabIndex = 25;
            this.txtFindCust.TextChanged += new System.EventHandler(this.txtFindCust_TextChanged);
            // 
            // dgvFindCtm
            // 
            this.dgvFindCtm.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFindCtm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFindCtm.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dgvFindCtm.Location = new System.Drawing.Point(12, 89);
            this.dgvFindCtm.Name = "dgvFindCtm";
            this.dgvFindCtm.Size = new System.Drawing.Size(429, 181);
            this.dgvFindCtm.TabIndex = 33;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Id";
            this.Column1.Name = "Column1";
            this.Column1.Visible = false;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Name";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Surname";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Phone";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Mail";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Books Have";
            this.Column6.Name = "Column6";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(125, 293);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(100, 20);
            this.txtPhone.TabIndex = 34;
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(125, 327);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(100, 20);
            this.txtMail.TabIndex = 34;
            // 
            // UpCustForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(453, 421);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.dgvFindCtm);
            this.Controls.Add(this.btnBookUp);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Find);
            this.Controls.Add(this.txtFindCust);
            this.Name = "UpCustForm";
            this.Text = "UpCustForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvFindCtm)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnBookUp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Find;
        private System.Windows.Forms.TextBox txtFindCust;
        private System.Windows.Forms.DataGridView dgvFindCtm;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtMail;
    }
}