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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.booksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuAddBook = new System.Windows.Forms.ToolStripMenuItem();
            this.bookJanrasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAddJanra = new System.Windows.Forms.ToolStripMenuItem();
            this.bookAuthorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAddAuthor = new System.Windows.Forms.ToolStripMenuItem();
            this.bookListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.orToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCreateAnOrder = new System.Windows.Forms.ToolStripMenuItem();
            this.listOfOrdersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deadlineTodayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deadlineTomorrowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.overdueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.costumersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAddNewCostumer = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCostumerList = new System.Windows.Forms.ToolStripMenuItem();
            this.btnExit = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.booksToolStripMenuItem,
            this.orToolStripMenuItem,
            this.costumersToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.TabStop = true;
            this.menuStrip1.Text = "menuStrip1";
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
            this.MenuAddBook.Size = new System.Drawing.Size(150, 22);
            this.MenuAddBook.Text = "Add Book";
            this.MenuAddBook.Click += new System.EventHandler(this.MenuAddBook_Click);
            // 
            // bookJanrasToolStripMenuItem
            // 
            this.bookJanrasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuAddJanra});
            this.bookJanrasToolStripMenuItem.Name = "bookJanrasToolStripMenuItem";
            this.bookJanrasToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
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
            this.bookAuthorsToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
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
            this.bookListToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.bookListToolStripMenuItem.Text = "BookList";
            this.bookListToolStripMenuItem.Click += new System.EventHandler(this.bookListToolStripMenuItem_Click);
            // 
            // orToolStripMenuItem
            // 
            this.orToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuCreateAnOrder,
            this.listOfOrdersToolStripMenuItem});
            this.orToolStripMenuItem.Name = "orToolStripMenuItem";
            this.orToolStripMenuItem.Size = new System.Drawing.Size(61, 21);
            this.orToolStripMenuItem.Text = "Orders";
            // 
            // menuCreateAnOrder
            // 
            this.menuCreateAnOrder.Name = "menuCreateAnOrder";
            this.menuCreateAnOrder.Size = new System.Drawing.Size(171, 22);
            this.menuCreateAnOrder.Text = "Create an Order";
            this.menuCreateAnOrder.Click += new System.EventHandler(this.menuCreateAnOrder_Click);
            // 
            // listOfOrdersToolStripMenuItem
            // 
            this.listOfOrdersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deadlineTodayToolStripMenuItem,
            this.deadlineTomorrowToolStripMenuItem,
            this.overdueToolStripMenuItem});
            this.listOfOrdersToolStripMenuItem.Name = "listOfOrdersToolStripMenuItem";
            this.listOfOrdersToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.listOfOrdersToolStripMenuItem.Text = "List of Orders";
            // 
            // deadlineTodayToolStripMenuItem
            // 
            this.deadlineTodayToolStripMenuItem.Name = "deadlineTodayToolStripMenuItem";
            this.deadlineTodayToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.deadlineTodayToolStripMenuItem.Text = "Deadline Today";
            // 
            // deadlineTomorrowToolStripMenuItem
            // 
            this.deadlineTomorrowToolStripMenuItem.Name = "deadlineTomorrowToolStripMenuItem";
            this.deadlineTomorrowToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.deadlineTomorrowToolStripMenuItem.Text = "Deadline Tomorrow";
            // 
            // overdueToolStripMenuItem
            // 
            this.overdueToolStripMenuItem.Name = "overdueToolStripMenuItem";
            this.overdueToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.overdueToolStripMenuItem.Text = "Overdue";
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
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.White;
            this.btnExit.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(730, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(58, 25);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LibraryFinalWinformProject.Properties.Resources._888655_download_free_library_background_images_1920x1200;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem booksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MenuAddBook;
        private System.Windows.Forms.ToolStripMenuItem bookJanrasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuAddJanra;
        private System.Windows.Forms.ToolStripMenuItem bookAuthorsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuAddAuthor;
        private System.Windows.Forms.ToolStripMenuItem bookListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem orToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuCreateAnOrder;
        private System.Windows.Forms.ToolStripMenuItem listOfOrdersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deadlineTodayToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deadlineTomorrowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem overdueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem costumersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuAddNewCostumer;
        private System.Windows.Forms.ToolStripMenuItem menuCostumerList;
        private System.Windows.Forms.Button btnExit;
    }
}