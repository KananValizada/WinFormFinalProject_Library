namespace LibraryFinalWinformProject.Forms
{
    partial class AdminPanel
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
            this.btnAdminCreateUser = new System.Windows.Forms.Button();
            this.btnAdminHesabat = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAdminCreateUser
            // 
            this.btnAdminCreateUser.Location = new System.Drawing.Point(48, 40);
            this.btnAdminCreateUser.Name = "btnAdminCreateUser";
            this.btnAdminCreateUser.Size = new System.Drawing.Size(145, 45);
            this.btnAdminCreateUser.TabIndex = 0;
            this.btnAdminCreateUser.Text = "Create new User ";
            this.btnAdminCreateUser.UseVisualStyleBackColor = true;
            this.btnAdminCreateUser.Click += new System.EventHandler(this.BtnAdminCreateUser_Click);
            // 
            // btnAdminHesabat
            // 
            this.btnAdminHesabat.Location = new System.Drawing.Point(241, 40);
            this.btnAdminHesabat.Name = "btnAdminHesabat";
            this.btnAdminHesabat.Size = new System.Drawing.Size(120, 45);
            this.btnAdminHesabat.TabIndex = 1;
            this.btnAdminHesabat.Text = "Hesabatlar";
            this.btnAdminHesabat.UseVisualStyleBackColor = true;
            this.btnAdminHesabat.Click += new System.EventHandler(this.BtnAdminHesabat_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Black;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(645, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(61, 31);
            this.button3.TabIndex = 2;
            this.button3.Text = "Exit";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // AdminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(718, 397);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnAdminHesabat);
            this.Controls.Add(this.btnAdminCreateUser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminPanel";
            this.Text = "AdminPanel";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAdminCreateUser;
        private System.Windows.Forms.Button btnAdminHesabat;
        private System.Windows.Forms.Button button3;
    }
}