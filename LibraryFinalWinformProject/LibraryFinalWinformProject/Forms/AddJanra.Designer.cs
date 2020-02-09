namespace LibraryFinalWinformProject.Forms
{
    partial class AddJanra
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
            this.lblJanraName = new System.Windows.Forms.Label();
            this.txtJanra = new System.Windows.Forms.TextBox();
            this.btnJanraAdd = new System.Windows.Forms.Button();
            this.dgvJanras = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJanras)).BeginInit();
            this.SuspendLayout();
            // 
            // lblJanraName
            // 
            this.lblJanraName.AutoSize = true;
            this.lblJanraName.BackColor = System.Drawing.Color.Transparent;
            this.lblJanraName.Location = new System.Drawing.Point(43, 62);
            this.lblJanraName.Name = "lblJanraName";
            this.lblJanraName.Size = new System.Drawing.Size(42, 16);
            this.lblJanraName.TabIndex = 0;
            this.lblJanraName.Text = "Name";
            // 
            // txtJanra
            // 
            this.txtJanra.Location = new System.Drawing.Point(128, 58);
            this.txtJanra.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtJanra.Name = "txtJanra";
            this.txtJanra.Size = new System.Drawing.Size(116, 22);
            this.txtJanra.TabIndex = 1;
            // 
            // btnJanraAdd
            // 
            this.btnJanraAdd.Location = new System.Drawing.Point(235, 146);
            this.btnJanraAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnJanraAdd.Name = "btnJanraAdd";
            this.btnJanraAdd.Size = new System.Drawing.Size(87, 28);
            this.btnJanraAdd.TabIndex = 2;
            this.btnJanraAdd.Text = "Add";
            this.btnJanraAdd.UseVisualStyleBackColor = true;
            this.btnJanraAdd.Click += new System.EventHandler(this.btnJanraAdd_Click);
            // 
            // dgvJanras
            // 
            this.dgvJanras.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvJanras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvJanras.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dgvJanras.Location = new System.Drawing.Point(12, 146);
            this.dgvJanras.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvJanras.Name = "dgvJanras";
            this.dgvJanras.Size = new System.Drawing.Size(190, 185);
            this.dgvJanras.TabIndex = 3;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(9, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Movcud Janrlar";
            // 
            // AddJanra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LibraryFinalWinformProject.Properties.Resources.istockphoto_499198960_612x612;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(334, 393);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvJanras);
            this.Controls.Add(this.btnJanraAdd);
            this.Controls.Add(this.txtJanra);
            this.Controls.Add(this.lblJanraName);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "AddJanra";
            this.Text = "AddJanra";
            ((System.ComponentModel.ISupportInitialize)(this.dgvJanras)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblJanraName;
        private System.Windows.Forms.TextBox txtJanra;
        private System.Windows.Forms.Button btnJanraAdd;
        private System.Windows.Forms.DataGridView dgvJanras;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.Label label1;
    }
}