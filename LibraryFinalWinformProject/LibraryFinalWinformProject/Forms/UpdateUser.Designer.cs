namespace LibraryFinalWinformProject.Forms
{
    partial class UpdateUser
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
            this.Find = new System.Windows.Forms.Label();
            this.txtFindUs = new System.Windows.Forms.TextBox();
            this.gvUsUp = new System.Windows.Forms.DataGridView();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtFullNam = new System.Windows.Forms.TextBox();
            this.txtUsarNam = new System.Windows.Forms.TextBox();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.cmbLaval = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnUsUp = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gvUsUp)).BeginInit();
            this.SuspendLayout();
            // 
            // Find
            // 
            this.Find.AutoSize = true;
            this.Find.BackColor = System.Drawing.Color.Transparent;
            this.Find.Location = new System.Drawing.Point(24, 62);
            this.Find.Name = "Find";
            this.Find.Size = new System.Drawing.Size(111, 15);
            this.Find.TabIndex = 4;
            this.Find.Text = "Find User by Email";
            // 
            // txtFindUs
            // 
            this.txtFindUs.Location = new System.Drawing.Point(176, 59);
            this.txtFindUs.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtFindUs.Name = "txtFindUs";
            this.txtFindUs.Size = new System.Drawing.Size(116, 21);
            this.txtFindUs.TabIndex = 3;
            this.txtFindUs.TextChanged += new System.EventHandler(this.txtFindCost_TextChanged);
            // 
            // gvUsUp
            // 
            this.gvUsUp.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvUsUp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvUsUp.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2,
            this.Column1,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.gvUsUp.Enabled = false;
            this.gvUsUp.Location = new System.Drawing.Point(28, 114);
            this.gvUsUp.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gvUsUp.Name = "gvUsUp";
            this.gvUsUp.Size = new System.Drawing.Size(457, 173);
            this.gvUsUp.TabIndex = 5;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Id";
            this.Column2.Name = "Column2";
            this.Column2.Visible = false;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Fulname";
            this.Column1.Name = "Column1";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Username";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Email";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Status";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Level";
            this.Column6.Name = "Column6";
            // 
            // txtFullNam
            // 
            this.txtFullNam.Location = new System.Drawing.Point(176, 309);
            this.txtFullNam.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtFullNam.Name = "txtFullNam";
            this.txtFullNam.Size = new System.Drawing.Size(116, 21);
            this.txtFullNam.TabIndex = 3;
            this.txtFullNam.TextChanged += new System.EventHandler(this.txtFindCost_TextChanged);
            // 
            // txtUsarNam
            // 
            this.txtUsarNam.Location = new System.Drawing.Point(176, 339);
            this.txtUsarNam.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtUsarNam.Name = "txtUsarNam";
            this.txtUsarNam.Size = new System.Drawing.Size(116, 21);
            this.txtUsarNam.TabIndex = 3;
            this.txtUsarNam.TextChanged += new System.EventHandler(this.txtFindCost_TextChanged);
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(176, 369);
            this.txtMail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(116, 21);
            this.txtMail.TabIndex = 3;
            this.txtMail.TextChanged += new System.EventHandler(this.txtFindCost_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(59, 309);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Fullname";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(59, 339);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Username";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(59, 369);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Email";
            // 
            // cmbStatus
            // 
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Items.AddRange(new object[] {
            "active",
            "passive"});
            this.cmbStatus.Location = new System.Drawing.Point(176, 400);
            this.cmbStatus.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(140, 23);
            this.cmbStatus.TabIndex = 7;
            this.cmbStatus.KeyUp += new System.Windows.Forms.KeyEventHandler(this.cmbStatus_KeyUp);
            // 
            // cmbLaval
            // 
            this.cmbLaval.FormattingEnabled = true;
            this.cmbLaval.Items.AddRange(new object[] {
            "admin",
            "moderator"});
            this.cmbLaval.Location = new System.Drawing.Point(176, 431);
            this.cmbLaval.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbLaval.Name = "cmbLaval";
            this.cmbLaval.Size = new System.Drawing.Size(140, 23);
            this.cmbLaval.TabIndex = 7;
            this.cmbLaval.KeyUp += new System.Windows.Forms.KeyEventHandler(this.cmbLaval_KeyUp);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(59, 400);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Status";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(59, 431);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 15);
            this.label5.TabIndex = 6;
            this.label5.Text = "Level";
            // 
            // btnUsUp
            // 
            this.btnUsUp.Location = new System.Drawing.Point(377, 309);
            this.btnUsUp.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnUsUp.Name = "btnUsUp";
            this.btnUsUp.Size = new System.Drawing.Size(87, 26);
            this.btnUsUp.TabIndex = 8;
            this.btnUsUp.Text = "Update";
            this.btnUsUp.UseVisualStyleBackColor = true;
            this.btnUsUp.Click += new System.EventHandler(this.btnUsUp_Click);
            // 
            // UpdateUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LibraryFinalWinformProject.Properties.Resources.istockphoto_499198960_612x612;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(492, 486);
            this.Controls.Add(this.btnUsUp);
            this.Controls.Add(this.cmbLaval);
            this.Controls.Add(this.cmbStatus);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gvUsUp);
            this.Controls.Add(this.Find);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.txtUsarNam);
            this.Controls.Add(this.txtFullNam);
            this.Controls.Add(this.txtFindUs);
            this.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "UpdateUser";
            this.Text = "UpdateUser";
            ((System.ComponentModel.ISupportInitialize)(this.gvUsUp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Find;
        private System.Windows.Forms.TextBox txtFindUs;
        private System.Windows.Forms.DataGridView gvUsUp;
        private System.Windows.Forms.TextBox txtFullNam;
        private System.Windows.Forms.TextBox txtUsarNam;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.ComboBox cmbLaval;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnUsUp;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
    }
}