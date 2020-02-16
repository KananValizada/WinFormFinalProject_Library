namespace LibraryFinalWinformProject
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.txtLgnUserName = new System.Windows.Forms.TextBox();
            this.pnlLoginName = new System.Windows.Forms.Panel();
            this.txtLgnPassword = new System.Windows.Forms.TextBox();
            this.pnlLoginPassword = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.IconPassword = new System.Windows.Forms.PictureBox();
            this.IconName = new System.Windows.Forms.PictureBox();
            this.IconPlane = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.IconPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IconName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IconPlane)).BeginInit();
            this.SuspendLayout();
            // 
            // txtLgnUserName
            // 
            this.txtLgnUserName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.txtLgnUserName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLgnUserName.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLgnUserName.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtLgnUserName.Location = new System.Drawing.Point(77, 183);
            this.txtLgnUserName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtLgnUserName.Name = "txtLgnUserName";
            this.txtLgnUserName.Size = new System.Drawing.Size(224, 18);
            this.txtLgnUserName.TabIndex = 2;
            this.txtLgnUserName.Text = "Username";
            this.txtLgnUserName.Click += new System.EventHandler(this.txtLgnUserName_Click);
            this.txtLgnUserName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // pnlLoginName
            // 
            this.pnlLoginName.BackColor = System.Drawing.Color.White;
            this.pnlLoginName.Location = new System.Drawing.Point(35, 213);
            this.pnlLoginName.Name = "pnlLoginName";
            this.pnlLoginName.Size = new System.Drawing.Size(292, 1);
            this.pnlLoginName.TabIndex = 3;
            // 
            // txtLgnPassword
            // 
            this.txtLgnPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.txtLgnPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLgnPassword.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLgnPassword.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtLgnPassword.Location = new System.Drawing.Point(77, 255);
            this.txtLgnPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtLgnPassword.Name = "txtLgnPassword";
            this.txtLgnPassword.Size = new System.Drawing.Size(224, 18);
            this.txtLgnPassword.TabIndex = 2;
            this.txtLgnPassword.Text = "Password";
            this.txtLgnPassword.Click += new System.EventHandler(this.txtLgnPassword_Click);
            this.txtLgnPassword.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // pnlLoginPassword
            // 
            this.pnlLoginPassword.BackColor = System.Drawing.Color.White;
            this.pnlLoginPassword.Location = new System.Drawing.Point(35, 284);
            this.pnlLoginPassword.Name = "pnlLoginPassword";
            this.pnlLoginPassword.Size = new System.Drawing.Size(292, 1);
            this.pnlLoginPassword.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(150)))), ((int)(((byte)(206)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.button1.Location = new System.Drawing.Point(35, 339);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(292, 36);
            this.button1.TabIndex = 4;
            this.button1.Text = "Sign In";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // IconPassword
            // 
            this.IconPassword.BackgroundImage = global::LibraryFinalWinformProject.Properties.Resources.makefgsadsada;
            this.IconPassword.Image = global::LibraryFinalWinformProject.Properties.Resources.makefg;
            this.IconPassword.Location = new System.Drawing.Point(35, 248);
            this.IconPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.IconPassword.Name = "IconPassword";
            this.IconPassword.Size = new System.Drawing.Size(27, 27);
            this.IconPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.IconPassword.TabIndex = 1;
            this.IconPassword.TabStop = false;
            // 
            // IconName
            // 
            this.IconName.BackgroundImage = global::LibraryFinalWinformProject.Properties.Resources.makefgsadsada;
            this.IconName.Image = global::LibraryFinalWinformProject.Properties.Resources.man1;
            this.IconName.Location = new System.Drawing.Point(35, 177);
            this.IconName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.IconName.Name = "IconName";
            this.IconName.Size = new System.Drawing.Size(27, 27);
            this.IconName.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.IconName.TabIndex = 1;
            this.IconName.TabStop = false;
            // 
            // IconPlane
            // 
            this.IconPlane.Image = ((System.Drawing.Image)(resources.GetObject("IconPlane.Image")));
            this.IconPlane.Location = new System.Drawing.Point(134, 36);
            this.IconPlane.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.IconPlane.Name = "IconPlane";
            this.IconPlane.Size = new System.Drawing.Size(75, 79);
            this.IconPlane.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.IconPlane.TabIndex = 0;
            this.IconPlane.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(359, 472);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pnlLoginPassword);
            this.Controls.Add(this.pnlLoginName);
            this.Controls.Add(this.txtLgnPassword);
            this.Controls.Add(this.txtLgnUserName);
            this.Controls.Add(this.IconPassword);
            this.Controls.Add(this.IconName);
            this.Controls.Add(this.IconPlane);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.IconPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IconName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IconPlane)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox IconPlane;
        private System.Windows.Forms.PictureBox IconName;
        private System.Windows.Forms.TextBox txtLgnUserName;
        private System.Windows.Forms.Panel pnlLoginName;
        private System.Windows.Forms.PictureBox IconPassword;
        private System.Windows.Forms.TextBox txtLgnPassword;
        private System.Windows.Forms.Panel pnlLoginPassword;
        private System.Windows.Forms.Button button1;
    }
}

