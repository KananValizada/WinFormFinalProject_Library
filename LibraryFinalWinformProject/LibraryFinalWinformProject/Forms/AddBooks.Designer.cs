namespace LibraryFinalWinformProject.Forms
{
    partial class AddBooks
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
            this.txtNameBook = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbAuthorBook = new System.Windows.Forms.ComboBox();
            this.cmbJanraBook = new System.Windows.Forms.ComboBox();
            this.dtpDateBook = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.txtQuantityBook = new System.Windows.Forms.NumericUpDown();
            this.btnAddBook = new System.Windows.Forms.Button();
            this.txtPriceBook = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuantityBook)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPriceBook)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(27, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Book name";
            // 
            // txtNameBook
            // 
            this.txtNameBook.Location = new System.Drawing.Point(141, 35);
            this.txtNameBook.Name = "txtNameBook";
            this.txtNameBook.Size = new System.Drawing.Size(163, 20);
            this.txtNameBook.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(27, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Author";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(27, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Janra";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(27, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Purchase Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(27, 225);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Price";
            // 
            // cmbAuthorBook
            // 
            this.cmbAuthorBook.FormattingEnabled = true;
            this.cmbAuthorBook.Location = new System.Drawing.Point(141, 81);
            this.cmbAuthorBook.Name = "cmbAuthorBook";
            this.cmbAuthorBook.Size = new System.Drawing.Size(163, 21);
            this.cmbAuthorBook.TabIndex = 2;
            // 
            // cmbJanraBook
            // 
            this.cmbJanraBook.FormattingEnabled = true;
            this.cmbJanraBook.Location = new System.Drawing.Point(141, 124);
            this.cmbJanraBook.Name = "cmbJanraBook";
            this.cmbJanraBook.Size = new System.Drawing.Size(163, 21);
            this.cmbJanraBook.TabIndex = 2;
            // 
            // dtpDateBook
            // 
            this.dtpDateBook.Location = new System.Drawing.Point(141, 180);
            this.dtpDateBook.Name = "dtpDateBook";
            this.dtpDateBook.Size = new System.Drawing.Size(163, 20);
            this.dtpDateBook.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(27, 265);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "Quantity";
            // 
            // txtQuantityBook
            // 
            this.txtQuantityBook.Location = new System.Drawing.Point(141, 265);
            this.txtQuantityBook.Name = "txtQuantityBook";
            this.txtQuantityBook.Size = new System.Drawing.Size(163, 20);
            this.txtQuantityBook.TabIndex = 4;
            // 
            // btnAddBook
            // 
            this.btnAddBook.Location = new System.Drawing.Point(111, 326);
            this.btnAddBook.Name = "btnAddBook";
            this.btnAddBook.Size = new System.Drawing.Size(106, 34);
            this.btnAddBook.TabIndex = 5;
            this.btnAddBook.Text = "Add";
            this.btnAddBook.UseVisualStyleBackColor = true;
            this.btnAddBook.Click += new System.EventHandler(this.btnAddBook_Click);
            // 
            // txtPriceBook
            // 
            this.txtPriceBook.Location = new System.Drawing.Point(141, 225);
            this.txtPriceBook.Name = "txtPriceBook";
            this.txtPriceBook.Size = new System.Drawing.Size(163, 20);
            this.txtPriceBook.TabIndex = 4;
            // 
            // AddBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackgroundImage = global::LibraryFinalWinformProject.Properties.Resources.wooden_table_36051_46;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(356, 391);
            this.Controls.Add(this.btnAddBook);
            this.Controls.Add(this.txtPriceBook);
            this.Controls.Add(this.txtQuantityBook);
            this.Controls.Add(this.dtpDateBook);
            this.Controls.Add(this.cmbJanraBook);
            this.Controls.Add(this.cmbAuthorBook);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtNameBook);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddBooks";
            this.Text = "AddBooks";
            ((System.ComponentModel.ISupportInitialize)(this.txtQuantityBook)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPriceBook)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNameBook;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbAuthorBook;
        private System.Windows.Forms.ComboBox cmbJanraBook;
        private System.Windows.Forms.DateTimePicker dtpDateBook;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown txtQuantityBook;
        private System.Windows.Forms.Button btnAddBook;
        private System.Windows.Forms.NumericUpDown txtPriceBook;
    }
}