namespace LibraryFinalWinformProject.Forms
{
    partial class AddCostumer
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
            this.txtCostumerName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCostumerSName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCostumerPhone = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCostumerMail = new System.Windows.Forms.TextBox();
            this.btnAddCostumer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(37, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // txtCostumerName
            // 
            this.txtCostumerName.Location = new System.Drawing.Point(155, 46);
            this.txtCostumerName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCostumerName.Name = "txtCostumerName";
            this.txtCostumerName.Size = new System.Drawing.Size(116, 22);
            this.txtCostumerName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(37, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Surname";
            // 
            // txtCostumerSName
            // 
            this.txtCostumerSName.Location = new System.Drawing.Point(155, 100);
            this.txtCostumerSName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCostumerSName.Name = "txtCostumerSName";
            this.txtCostumerSName.Size = new System.Drawing.Size(116, 22);
            this.txtCostumerSName.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(37, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Phone Number";
            // 
            // txtCostumerPhone
            // 
            this.txtCostumerPhone.Location = new System.Drawing.Point(155, 143);
            this.txtCostumerPhone.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCostumerPhone.Name = "txtCostumerPhone";
            this.txtCostumerPhone.Size = new System.Drawing.Size(116, 22);
            this.txtCostumerPhone.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(37, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Email";
            // 
            // txtCostumerMail
            // 
            this.txtCostumerMail.Location = new System.Drawing.Point(155, 198);
            this.txtCostumerMail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCostumerMail.Name = "txtCostumerMail";
            this.txtCostumerMail.Size = new System.Drawing.Size(116, 22);
            this.txtCostumerMail.TabIndex = 1;
            // 
            // btnAddCostumer
            // 
            this.btnAddCostumer.Location = new System.Drawing.Point(115, 263);
            this.btnAddCostumer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAddCostumer.Name = "btnAddCostumer";
            this.btnAddCostumer.Size = new System.Drawing.Size(87, 28);
            this.btnAddCostumer.TabIndex = 2;
            this.btnAddCostumer.Text = "Add";
            this.btnAddCostumer.UseVisualStyleBackColor = true;
            this.btnAddCostumer.Click += new System.EventHandler(this.btnAddCostumer_Click);
            // 
            // AddCostumer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LibraryFinalWinformProject.Properties.Resources.wooden_table_36051_46;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(331, 411);
            this.Controls.Add(this.btnAddCostumer);
            this.Controls.Add(this.txtCostumerMail);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCostumerPhone);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCostumerSName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCostumerName);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "AddCostumer";
            this.Text = "AddCostumer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCostumerName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCostumerSName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCostumerPhone;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCostumerMail;
        private System.Windows.Forms.Button btnAddCostumer;
    }
}