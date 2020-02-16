namespace LibraryFinalWinformProject.Forms
{
    partial class UpdateBook
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
            this.gvBookUp = new System.Windows.Forms.DataGridView();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Find = new System.Windows.Forms.Label();
            this.txtFindBook = new System.Windows.Forms.TextBox();
            this.nmbCount = new System.Windows.Forms.NumericUpDown();
            this.nmbPric = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.gvBookUp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmbCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmbPric)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBookUp
            // 
            this.btnBookUp.Location = new System.Drawing.Point(328, 251);
            this.btnBookUp.Name = "btnBookUp";
            this.btnBookUp.Size = new System.Drawing.Size(75, 23);
            this.btnBookUp.TabIndex = 22;
            this.btnBookUp.Text = "Update";
            this.btnBookUp.UseVisualStyleBackColor = true;
            this.btnBookUp.Click += new System.EventHandler(this.btnBookUp_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(56, 285);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Quantity";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(56, 251);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Price";
            // 
            // gvBookUp
            // 
            this.gvBookUp.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvBookUp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvBookUp.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2,
            this.Column1,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.gvBookUp.Location = new System.Drawing.Point(29, 82);
            this.gvBookUp.Name = "gvBookUp";
            this.gvBookUp.Size = new System.Drawing.Size(392, 150);
            this.gvBookUp.TabIndex = 14;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Id";
            this.Column2.Name = "Column2";
            this.Column2.Visible = false;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Name";
            this.Column1.Name = "Column1";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Janra";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Author";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Price";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Quantity";
            this.Column6.Name = "Column6";
            // 
            // Find
            // 
            this.Find.AutoSize = true;
            this.Find.BackColor = System.Drawing.Color.Transparent;
            this.Find.ForeColor = System.Drawing.Color.White;
            this.Find.Location = new System.Drawing.Point(26, 37);
            this.Find.Name = "Find";
            this.Find.Size = new System.Drawing.Size(100, 13);
            this.Find.TabIndex = 13;
            this.Find.Text = "Find Book by Name";
            // 
            // txtFindBook
            // 
            this.txtFindBook.Location = new System.Drawing.Point(156, 34);
            this.txtFindBook.Name = "txtFindBook";
            this.txtFindBook.Size = new System.Drawing.Size(100, 20);
            this.txtFindBook.TabIndex = 12;
            this.txtFindBook.TextChanged += new System.EventHandler(this.txtFindBook_TextChanged);
            // 
            // nmbCount
            // 
            this.nmbCount.Location = new System.Drawing.Point(156, 285);
            this.nmbCount.Name = "nmbCount";
            this.nmbCount.Size = new System.Drawing.Size(100, 20);
            this.nmbCount.TabIndex = 23;
            // 
            // nmbPric
            // 
            this.nmbPric.DecimalPlaces = 2;
            this.nmbPric.Location = new System.Drawing.Point(156, 251);
            this.nmbPric.Name = "nmbPric";
            this.nmbPric.Size = new System.Drawing.Size(100, 20);
            this.nmbPric.TabIndex = 24;
            // 
            // UpdateBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LibraryFinalWinformProject.Properties.Resources.wooden_table_36051_46;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(477, 398);
            this.Controls.Add(this.nmbPric);
            this.Controls.Add(this.nmbCount);
            this.Controls.Add(this.btnBookUp);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gvBookUp);
            this.Controls.Add(this.Find);
            this.Controls.Add(this.txtFindBook);
            this.Name = "UpdateBook";
            this.Text = "UpdateBook";
            ((System.ComponentModel.ISupportInitialize)(this.gvBookUp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmbCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmbPric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBookUp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView gvBookUp;
        private System.Windows.Forms.Label Find;
        private System.Windows.Forms.TextBox txtFindBook;
        private System.Windows.Forms.NumericUpDown nmbCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.NumericUpDown nmbPric;
    }
}