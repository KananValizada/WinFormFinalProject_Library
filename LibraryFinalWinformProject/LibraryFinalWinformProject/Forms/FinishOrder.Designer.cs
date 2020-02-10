namespace LibraryFinalWinformProject.Forms
{
    partial class FinishOrder
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
            this.gvBookSrc = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBookSrc = new System.Windows.Forms.TextBox();
            this.Name = new System.Windows.Forms.Label();
            this.txtFoFullName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFoBookName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFoWhoCreated = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtFoOrderDate = new System.Windows.Forms.DateTimePicker();
            this.txtFoDeadline = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.gvBookSrc)).BeginInit();
            this.SuspendLayout();
            // 
            // gvBookSrc
            // 
            this.gvBookSrc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvBookSrc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.gvBookSrc.Location = new System.Drawing.Point(94, 45);
            this.gvBookSrc.Name = "gvBookSrc";
            this.gvBookSrc.Size = new System.Drawing.Size(648, 150);
            this.gvBookSrc.TabIndex = 0;
            this.gvBookSrc.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvBookSrc_CellContentClick);
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
            this.Column3.HeaderText = "Janra Id ";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Author ID";
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
            // Column7
            // 
            this.Column7.HeaderText = "Availible Quantity";
            this.Column7.Name = "Column7";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(121, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Kitab Secin";
            // 
            // txtBookSrc
            // 
            this.txtBookSrc.Location = new System.Drawing.Point(219, 6);
            this.txtBookSrc.Name = "txtBookSrc";
            this.txtBookSrc.Size = new System.Drawing.Size(100, 20);
            this.txtBookSrc.TabIndex = 3;
            this.txtBookSrc.TextChanged += new System.EventHandler(this.txtBookSrc_TextChanged);
            // 
            // Name
            // 
            this.Name.AutoSize = true;
            this.Name.Location = new System.Drawing.Point(112, 217);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(51, 13);
            this.Name.TabIndex = 4;
            this.Name.Text = "FullName";
            // 
            // txtFoFullName
            // 
            this.txtFoFullName.Enabled = false;
            this.txtFoFullName.Location = new System.Drawing.Point(242, 214);
            this.txtFoFullName.Name = "txtFoFullName";
            this.txtFoFullName.Size = new System.Drawing.Size(170, 20);
            this.txtFoFullName.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(112, 259);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "BookName";
            // 
            // txtFoBookName
            // 
            this.txtFoBookName.Enabled = false;
            this.txtFoBookName.Location = new System.Drawing.Point(242, 256);
            this.txtFoBookName.Name = "txtFoBookName";
            this.txtFoBookName.Size = new System.Drawing.Size(170, 20);
            this.txtFoBookName.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(112, 303);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "OrderDate";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(112, 341);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Who Created";
            // 
            // txtFoWhoCreated
            // 
            this.txtFoWhoCreated.Enabled = false;
            this.txtFoWhoCreated.Location = new System.Drawing.Point(242, 338);
            this.txtFoWhoCreated.Name = "txtFoWhoCreated";
            this.txtFoWhoCreated.Size = new System.Drawing.Size(170, 20);
            this.txtFoWhoCreated.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(112, 376);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Deadline";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(451, 256);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 53);
            this.button1.TabIndex = 6;
            this.button1.Text = "Create";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // txtFoOrderDate
            // 
            this.txtFoOrderDate.Enabled = false;
            this.txtFoOrderDate.Location = new System.Drawing.Point(242, 295);
            this.txtFoOrderDate.Name = "txtFoOrderDate";
            this.txtFoOrderDate.Size = new System.Drawing.Size(170, 20);
            this.txtFoOrderDate.TabIndex = 7;
            // 
            // txtFoDeadline
            // 
            this.txtFoDeadline.Location = new System.Drawing.Point(242, 376);
            this.txtFoDeadline.Name = "txtFoDeadline";
            this.txtFoDeadline.Size = new System.Drawing.Size(170, 20);
            this.txtFoDeadline.TabIndex = 8;
            // 
            // FinishOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtFoDeadline);
            this.Controls.Add(this.txtFoOrderDate);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtFoWhoCreated);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtFoBookName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFoFullName);
            this.Controls.Add(this.Name);
            this.Controls.Add(this.txtBookSrc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gvBookSrc);
            this.Text = "FinishOrder";
            ((System.ComponentModel.ISupportInitialize)(this.gvBookSrc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gvBookSrc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBookSrc;
        private System.Windows.Forms.Label Name;
        private System.Windows.Forms.TextBox txtFoFullName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFoBookName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtFoWhoCreated;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker txtFoOrderDate;
        private System.Windows.Forms.DateTimePicker txtFoDeadline;
    }
}