namespace LibraryFinalWinformProject.Forms
{
    partial class BookReturn
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
            this.txtSearchCostumerName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvRtrn = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnrtnSrc = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRtrn)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSearchCostumerName
            // 
            this.txtSearchCostumerName.Location = new System.Drawing.Point(161, 46);
            this.txtSearchCostumerName.Name = "txtSearchCostumerName";
            this.txtSearchCostumerName.Size = new System.Drawing.Size(100, 20);
            this.txtSearchCostumerName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(51, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Costumer Name";
            // 
            // dgvRtrn
            // 
            this.dgvRtrn.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRtrn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRtrn.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8});
            this.dgvRtrn.Location = new System.Drawing.Point(28, 87);
            this.dgvRtrn.Name = "dgvRtrn";
            this.dgvRtrn.Size = new System.Drawing.Size(590, 150);
            this.dgvRtrn.TabIndex = 2;
            this.dgvRtrn.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvRtrn_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "I";
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
            this.Column4.HeaderText = "Book Name";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Deadline to return";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Book Prise";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Extra Dept";
            this.Column7.Name = "Column7";
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Return";
            this.Column8.Name = "Column8";
            // 
            // btnrtnSrc
            // 
            this.btnrtnSrc.Location = new System.Drawing.Point(373, 44);
            this.btnrtnSrc.Name = "btnrtnSrc";
            this.btnrtnSrc.Size = new System.Drawing.Size(75, 23);
            this.btnrtnSrc.TabIndex = 3;
            this.btnrtnSrc.Text = "Search";
            this.btnrtnSrc.UseVisualStyleBackColor = true;
            this.btnrtnSrc.Click += new System.EventHandler(this.btnrtnSrc_Click);
            // 
            // BookReturn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LibraryFinalWinformProject.Properties.Resources.bookreturn;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(640, 392);
            this.Controls.Add(this.btnrtnSrc);
            this.Controls.Add(this.dgvRtrn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSearchCostumerName);
            this.Name = "BookReturn";
            this.Text = "BookReturn";
            ((System.ComponentModel.ISupportInitialize)(this.dgvRtrn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSearchCostumerName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvRtrn;
        private System.Windows.Forms.Button btnrtnSrc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewButtonColumn Column8;
    }
}