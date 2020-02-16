namespace LibraryFinalWinformProject.Forms
{
    partial class Create_Order
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
            this.txtFindCost = new System.Windows.Forms.TextBox();
            this.dgvFindCtm = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Find = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFindCtm)).BeginInit();
            this.SuspendLayout();
            // 
            // txtFindCost
            // 
            this.txtFindCost.Location = new System.Drawing.Point(225, 88);
            this.txtFindCost.Name = "txtFindCost";
            this.txtFindCost.Size = new System.Drawing.Size(100, 20);
            this.txtFindCost.TabIndex = 0;
            this.txtFindCost.TextChanged += new System.EventHandler(this.txtFindCost_TextChanged);
            // 
            // dgvFindCtm
            // 
            this.dgvFindCtm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFindCtm.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.dgvFindCtm.Location = new System.Drawing.Point(0, 148);
            this.dgvFindCtm.Name = "dgvFindCtm";
            this.dgvFindCtm.Size = new System.Drawing.Size(646, 181);
            this.dgvFindCtm.TabIndex = 1;
            this.dgvFindCtm.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFindCtm_CellContentClick);
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
            // Column7
            // 
            this.Column7.HeaderText = "Give Book";
            this.Column7.Name = "Column7";
            // 
            // Find
            // 
            this.Find.AutoSize = true;
            this.Find.Location = new System.Drawing.Point(30, 91);
            this.Find.Name = "Find";
            this.Find.Size = new System.Drawing.Size(162, 13);
            this.Find.TabIndex = 2;
            this.Find.Text = "Find Costumer by Phone Number";
            // 
            // Create_Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 398);
            this.Controls.Add(this.Find);
            this.Controls.Add(this.dgvFindCtm);
            this.Controls.Add(this.txtFindCost);
            this.Name = "Create_Order";
            this.Text = "Find Customer";
            ((System.ComponentModel.ISupportInitialize)(this.dgvFindCtm)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFindCost;
        private System.Windows.Forms.DataGridView dgvFindCtm;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.Label Find;
        private System.Windows.Forms.DataGridViewButtonColumn Column7;
    }
}