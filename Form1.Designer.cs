namespace Jul;

partial class Form1
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "",
            "T1",
            "T2",
            "T3",
            "T4",
            "T5",
            "T6",
            ""}, -1);
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem(new string[] {
            "",
            ""}, -1);
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.appTabs = new System.Windows.Forms.TabControl();
            this.booksTab = new System.Windows.Forms.TabPage();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.booksSearchBar = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.removeBookButton = new System.Windows.Forms.ToolStripButton();
            this.customersTab = new System.Windows.Forms.TabPage();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.customersSearchbox = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.addCustomerButton = new System.Windows.Forms.ToolStripButton();
            this.removeCustomersButton = new System.Windows.Forms.ToolStripButton();
            this.customerReceiptsButton = new System.Windows.Forms.ToolStripButton();
            this.listView2 = new System.Windows.Forms.ListView();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader7 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader8 = new System.Windows.Forms.ColumnHeader();
            this.appTabs.SuspendLayout();
            this.booksTab.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.customersTab.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listView1.FullRowSelect = true;
            this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2});
            this.listView1.Location = new System.Drawing.Point(0, 33);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1035, 620);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.listView1_ColumnClick);
            // 
            // appTabs
            // 
            this.appTabs.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.appTabs.Controls.Add(this.booksTab);
            this.appTabs.Controls.Add(this.customersTab);
            this.appTabs.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.appTabs.ItemSize = new System.Drawing.Size(90, 180);
            this.appTabs.Location = new System.Drawing.Point(0, -1);
            this.appTabs.Multiline = true;
            this.appTabs.Name = "appTabs";
            this.appTabs.SelectedIndex = 0;
            this.appTabs.Size = new System.Drawing.Size(1223, 657);
            this.appTabs.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.appTabs.TabIndex = 2;
            // 
            // booksTab
            // 
            this.booksTab.Controls.Add(this.toolStrip1);
            this.booksTab.Controls.Add(this.listView1);
            this.booksTab.Location = new System.Drawing.Point(184, 4);
            this.booksTab.Name = "booksTab";
            this.booksTab.Padding = new System.Windows.Forms.Padding(3);
            this.booksTab.Size = new System.Drawing.Size(1035, 649);
            this.booksTab.TabIndex = 0;
            this.booksTab.Text = "Books";
            this.booksTab.UseVisualStyleBackColor = true;
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.booksSearchBar,
            this.toolStripLabel1,
            this.toolStripSeparator1,
            this.toolStripButton1,
            this.toolStripButton2,
            this.removeBookButton});
            this.toolStrip1.Location = new System.Drawing.Point(3, 3);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1029, 27);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // booksSearchBar
            // 
            this.booksSearchBar.AutoSize = false;
            this.booksSearchBar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.booksSearchBar.Name = "booksSearchBar";
            this.booksSearchBar.Size = new System.Drawing.Size(130, 27);
            this.booksSearchBar.ToolTipText = "Book title";
            this.booksSearchBar.TextChanged += new System.EventHandler(this.toolStripTextBox1_TextChanged);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(91, 24);
            this.toolStripLabel1.Text = "Search book";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(29, 24);
            this.toolStripButton1.Text = "Add a book";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.MergeAction = System.Windows.Forms.MergeAction.Insert;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(29, 24);
            this.toolStripButton2.Text = "toolStripButton2";
            this.toolStripButton2.ToolTipText = "Sell selected books";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // removeBookButton
            // 
            this.removeBookButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.removeBookButton.Image = ((System.Drawing.Image)(resources.GetObject("removeBookButton.Image")));
            this.removeBookButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.removeBookButton.Name = "removeBookButton";
            this.removeBookButton.Size = new System.Drawing.Size(29, 24);
            this.removeBookButton.Text = "toolStripButton6";
            this.removeBookButton.ToolTipText = "Remove books";
            this.removeBookButton.Click += new System.EventHandler(this.removeBookButton_Click);
            // 
            // customersTab
            // 
            this.customersTab.Controls.Add(this.toolStrip2);
            this.customersTab.Controls.Add(this.listView2);
            this.customersTab.Location = new System.Drawing.Point(184, 4);
            this.customersTab.Name = "customersTab";
            this.customersTab.Padding = new System.Windows.Forms.Padding(3);
            this.customersTab.Size = new System.Drawing.Size(1035, 649);
            this.customersTab.TabIndex = 1;
            this.customersTab.Text = "Customers";
            this.customersTab.UseVisualStyleBackColor = true;
            // 
            // toolStrip2
            // 
            this.toolStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.customersSearchbox,
            this.toolStripLabel2,
            this.toolStripSeparator2,
            this.addCustomerButton,
            this.removeCustomersButton,
            this.customerReceiptsButton});
            this.toolStrip2.Location = new System.Drawing.Point(3, 3);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(1029, 27);
            this.toolStrip2.TabIndex = 2;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // customersSearchbox
            // 
            this.customersSearchbox.AutoSize = false;
            this.customersSearchbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.customersSearchbox.Name = "customersSearchbox";
            this.customersSearchbox.Size = new System.Drawing.Size(130, 27);
            this.customersSearchbox.ToolTipText = "Book title";
            this.customersSearchbox.TextChanged += new System.EventHandler(this.customersSearchbox_TextChanged);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(118, 24);
            this.toolStripLabel2.Text = "Search customer";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // addCustomerButton
            // 
            this.addCustomerButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.addCustomerButton.Image = ((System.Drawing.Image)(resources.GetObject("addCustomerButton.Image")));
            this.addCustomerButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.addCustomerButton.Name = "addCustomerButton";
            this.addCustomerButton.Size = new System.Drawing.Size(29, 24);
            this.addCustomerButton.Text = "Add a book";
            this.addCustomerButton.ToolTipText = "Add a customer";
            this.addCustomerButton.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // removeCustomersButton
            // 
            this.removeCustomersButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.removeCustomersButton.Image = ((System.Drawing.Image)(resources.GetObject("removeCustomersButton.Image")));
            this.removeCustomersButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.removeCustomersButton.MergeAction = System.Windows.Forms.MergeAction.Insert;
            this.removeCustomersButton.Name = "removeCustomersButton";
            this.removeCustomersButton.Size = new System.Drawing.Size(29, 24);
            this.removeCustomersButton.Text = "toolStripButton2";
            this.removeCustomersButton.ToolTipText = "Remove selected customers";
            this.removeCustomersButton.Click += new System.EventHandler(this.removeCustomersButton_Click);
            // 
            // customerReceiptsButton
            // 
            this.customerReceiptsButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.customerReceiptsButton.Image = ((System.Drawing.Image)(resources.GetObject("customerReceiptsButton.Image")));
            this.customerReceiptsButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.customerReceiptsButton.Name = "customerReceiptsButton";
            this.customerReceiptsButton.Size = new System.Drawing.Size(29, 24);
            this.customerReceiptsButton.Text = "toolStripButton5";
            this.customerReceiptsButton.ToolTipText = "Show customer receipts";
            this.customerReceiptsButton.Click += new System.EventHandler(this.toolStripButton5_Click);
            // 
            // listView2
            // 
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
            this.listView2.FullRowSelect = true;
            this.listView2.GridLines = true;
            this.listView2.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem3});
            this.listView2.Location = new System.Drawing.Point(0, 33);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(1035, 620);
            this.listView2.TabIndex = 1;
            this.listView2.UseCompatibleStateImageBehavior = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1223, 694);
            this.Controls.Add(this.appTabs);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.appTabs.ResumeLayout(false);
            this.booksTab.ResumeLayout(false);
            this.booksTab.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.customersTab.ResumeLayout(false);
            this.customersTab.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.ResumeLayout(false);

    }

    #endregion

    private ListView listView1;
    private TabControl appTabs;
    private TabPage booksTab;
    private TabPage customersTab;
    private ToolStrip toolStrip1;
    private ColumnHeader columnHeader1;
    private ColumnHeader columnHeader2;
    private ColumnHeader columnHeader3;
    private ColumnHeader columnHeader4;
    private ToolStripTextBox booksSearchBar;
    private ToolStripLabel toolStripLabel1;
    private ToolStripSeparator toolStripSeparator1;
    private ToolStripButton toolStripButton1;
    private ToolStripButton toolStripButton2;
    private ToolStrip toolStrip2;
    private ToolStripTextBox customersSearchbox;
    private ToolStripLabel toolStripLabel2;
    private ToolStripSeparator toolStripSeparator2;
    private ToolStripButton addCustomerButton;
    private ToolStripButton removeCustomersButton;
    private ListView listView2;
    private ColumnHeader columnHeader5;
    private ColumnHeader columnHeader6;
    private ColumnHeader columnHeader7;
    private ColumnHeader columnHeader8;
    private ToolStripButton customerReceiptsButton;
    private ToolStripButton removeBookButton;
}
