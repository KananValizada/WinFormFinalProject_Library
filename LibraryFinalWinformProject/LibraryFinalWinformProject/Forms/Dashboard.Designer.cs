namespace LibraryFinalWinformProject.Forms
{
    partial class Dashboard
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
            this.menuReturnBook = new System.Windows.Forms.MenuStrip();
            this.booksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuAddBook = new System.Windows.Forms.ToolStripMenuItem();
            this.bookJanrasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAddJanra = new System.Windows.Forms.ToolStripMenuItem();
            this.bookAuthorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAddAuthor = new System.Windows.Forms.ToolStripMenuItem();
            this.bookListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.orToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCreateAnOrder = new System.Windows.Forms.ToolStripMenuItem();
            this.menuListOfOrders = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDeadlineToday = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDeadlineTomorrow = new System.Windows.Forms.ToolStripMenuItem();
            this.menuOverdue = new System.Windows.Forms.ToolStripMenuItem();
            this.costumersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAddNewCostumer = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCostumerList = new System.Windows.Forms.ToolStripMenuItem();
            this.returnBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblUserName = new System.Windows.Forms.Label();
            this.menuReturnBook.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuReturnBook
            // 
            this.menuReturnBook.BackColor = System.Drawing.Color.White;
            this.menuReturnBook.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuReturnBook.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.booksToolStripMenuItem,
            this.orToolStripMenuItem,
            this.costumersToolStripMenuItem,
            this.returnBookToolStripMenuItem});
            this.menuReturnBook.Location = new System.Drawing.Point(0, 0);
            this.menuReturnBook.Name = "menuReturnBook";
            this.menuReturnBook.Size = new System.Drawing.Size(800, 25);
            this.menuReturnBook.TabIndex = 0;
            this.menuReturnBook.TabStop = true;
            this.menuReturnBook.Text = "menuStrip1";
            // 
            // booksToolStripMenuItem
            // 
            this.booksToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuAddBook,
            this.bookJanrasToolStripMenuItem,
            this.bookAuthorsToolStripMenuItem,
            this.bookListToolStripMenuItem});
            this.booksToolStripMenuItem.Name = "booksToolStripMenuItem";
            this.booksToolStripMenuItem.Size = new System.Drawing.Size(55, 21);
            this.booksToolStripMenuItem.Text = "Books";
            // 
            // MenuAddBook
            // 
            this.MenuAddBook.Name = "MenuAddBook";
            this.MenuAddBook.Size = new System.Drawing.Size(180, 22);
            this.MenuAddBook.Text = "Add Book";
            this.MenuAddBook.Click += new System.EventHandler(this.MenuAddBook_Click);
            // 
            // bookJanrasToolStripMenuItem
            // 
            this.bookJanrasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuAddJanra});
            this.bookJanrasToolStripMenuItem.Name = "bookJanrasToolStripMenuItem";
            this.bookJanrasToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.bookJanrasToolStripMenuItem.Text = "BookJanras";
            // 
            // menuAddJanra
            // 
            this.menuAddJanra.Name = "menuAddJanra";
            this.menuAddJanra.Size = new System.Drawing.Size(135, 22);
            this.menuAddJanra.Text = "Add Janra";
            this.menuAddJanra.Click += new System.EventHandler(this.menuAddJanra_Click);
            // 
            // bookAuthorsToolStripMenuItem
            // 
            this.bookAuthorsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuAddAuthor});
            this.bookAuthorsToolStripMenuItem.Name = "bookAuthorsToolStripMenuItem";
            this.bookAuthorsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.bookAuthorsToolStripMenuItem.Text = "BookAuthors";
            // 
            // menuAddAuthor
            // 
            this.menuAddAuthor.Name = "menuAddAuthor";
            this.menuAddAuthor.Size = new System.Drawing.Size(143, 22);
            this.menuAddAuthor.Text = "Add Author";
            this.menuAddAuthor.Click += new System.EventHandler(this.menuAddAuthor_Click);
            // 
            // bookListToolStripMenuItem
            // 
            this.bookListToolStripMenuItem.Name = "bookListToolStripMenuItem";
            this.bookListToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.bookListToolStripMenuItem.Text = "BookList";
            this.bookListToolStripMenuItem.Click += new System.EventHandler(this.bookListToolStripMenuItem_Click);
            // 
            // orToolStripMenuItem
            // 
            this.orToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuCreateAnOrder,
            this.menuListOfOrders});
            this.orToolStripMenuItem.Name = "orToolStripMenuItem";
            this.orToolStripMenuItem.Size = new System.Drawing.Size(61, 21);
            this.orToolStripMenuItem.Text = "Orders";
            // 
            // menuCreateAnOrder
            // 
            this.menuCreateAnOrder.Name = "menuCreateAnOrder";
            this.menuCreateAnOrder.Size = new System.Drawing.Size(180, 22);
            this.menuCreateAnOrder.Text = "Create an Order";
            this.menuCreateAnOrder.Click += new System.EventHandler(this.menuCreateAnOrder_Click);
            // 
            // menuListOfOrders
            // 
            this.menuListOfOrders.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuDeadlineToday,
            this.menuDeadlineTomorrow,
            this.menuOverdue});
            this.menuListOfOrders.Name = "menuListOfOrders";
            this.menuListOfOrders.Size = new System.Drawing.Size(180, 22);
            this.menuListOfOrders.Text = "List of Orders";
            // 
            // menuDeadlineToday
            // 
            this.menuDeadlineToday.Name = "menuDeadlineToday";
            this.menuDeadlineToday.Size = new System.Drawing.Size(191, 22);
            this.menuDeadlineToday.Text = "Deadline Today";
            this.menuDeadlineToday.Click += new System.EventHandler(this.menuDeadlineToday_Click);
            // 
            // menuDeadlineTomorrow
            // 
            this.menuDeadlineTomorrow.Name = "menuDeadlineTomorrow";
            this.menuDeadlineTomorrow.Size = new System.Drawing.Size(191, 22);
            this.menuDeadlineTomorrow.Text = "Deadline Tomorrow";
            this.menuDeadlineTomorrow.Click += new System.EventHandler(this.menuDeadlineTomorrow_Click);
            // 
            // menuOverdue
            // 
            this.menuOverdue.Name = "menuOverdue";
            this.menuOverdue.Size = new System.Drawing.Size(191, 22);
            this.menuOverdue.Text = "Overdue";
            this.menuOverdue.Click += new System.EventHandler(this.menuOverdue_Click);
            // 
            // costumersToolStripMenuItem
            // 
            this.costumersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuAddNewCostumer,
            this.menuCostumerList});
            this.costumersToolStripMenuItem.Name = "costumersToolStripMenuItem";
            this.costumersToolStripMenuItem.Size = new System.Drawing.Size(82, 21);
            this.costumersToolStripMenuItem.Text = "Costumers";
            // 
            // menuAddNewCostumer
            // 
            this.menuAddNewCostumer.Name = "menuAddNewCostumer";
            this.menuAddNewCostumer.Size = new System.Drawing.Size(190, 22);
            this.menuAddNewCostumer.Text = "Add New Costumer";
            this.menuAddNewCostumer.Click += new System.EventHandler(this.menuAddNewCostumer_Click);
            // 
            // menuCostumerList
            // 
            this.menuCostumerList.Name = "menuCostumerList";
            this.menuCostumerList.Size = new System.Drawing.Size(190, 22);
            this.menuCostumerList.Text = "Costumer List";
            this.menuCostumerList.Click += new System.EventHandler(this.menuCostumerList_Click);
            // 
            // returnBookToolStripMenuItem
            // 
            this.returnBookToolStripMenuItem.Name = "returnBookToolStripMenuItem";
            this.returnBookToolStripMenuItem.Size = new System.Drawing.Size(91, 21);
            this.returnBookToolStripMenuItem.Text = "Return Book";
            this.returnBookToolStripMenuItem.Click += new System.EventHandler(this.returnBookToolStripMenuItem_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.White;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(730, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(58, 25);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.BackColor = System.Drawing.Color.Transparent;
            this.lblUserName.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.ForeColor = System.Drawing.Color.White;
            this.lblUserName.Location = new System.Drawing.Point(570, 3);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(50, 18);
            this.lblUserName.TabIndex = 2;
            this.lblUserName.Text = "label1";
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LibraryFinalWinformProject.Properties.Resources._888655_download_free_library_background_images_1920x1200;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.menuReturnBook);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuReturnBook;
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.menuReturnBook.ResumeLayout(false);
            this.menuReturnBook.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuReturnBook;
        private System.Windows.Forms.ToolStripMenuItem booksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MenuAddBook;
        private System.Windows.Forms.ToolStripMenuItem bookJanrasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuAddJanra;
        private System.Windows.Forms.ToolStripMenuItem bookAuthorsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuAddAuthor;
        private System.Windows.Forms.ToolStripMenuItem bookListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem orToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuCreateAnOrder;
        private System.Windows.Forms.ToolStripMenuItem menuListOfOrders;
        private System.Windows.Forms.ToolStripMenuItem menuDeadlineToday;
        private System.Windows.Forms.ToolStripMenuItem menuDeadlineTomorrow;
        private System.Windows.Forms.ToolStripMenuItem menuOverdue;
        private System.Windows.Forms.ToolStripMenuItem costumersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuAddNewCostumer;
        private System.Windows.Forms.ToolStripMenuItem menuCostumerList;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ToolStripMenuItem returnBookToolStripMenuItem;
        private System.Windows.Forms.Label lblUserName;
    }
}