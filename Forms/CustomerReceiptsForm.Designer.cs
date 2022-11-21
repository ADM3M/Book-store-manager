using System.ComponentModel;

namespace Jul.Forms;

partial class CustomerReceiptsForm
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private IContainer components = null;

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
            this.button1 = new System.Windows.Forms.Button();
            this.booksListView = new System.Windows.Forms.ListView();
            this.customerNameLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(197, 391);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 29);
            this.button1.TabIndex = 0;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // booksListView
            // 
            this.booksListView.FullRowSelect = true;
            this.booksListView.GridLines = true;
            this.booksListView.Location = new System.Drawing.Point(12, 92);
            this.booksListView.Name = "booksListView";
            this.booksListView.Size = new System.Drawing.Size(470, 293);
            this.booksListView.TabIndex = 1;
            this.booksListView.UseCompatibleStateImageBehavior = false;
            this.booksListView.View = System.Windows.Forms.View.Details;
            // 
            // customerNameLabel
            // 
            this.customerNameLabel.AutoSize = true;
            this.customerNameLabel.Location = new System.Drawing.Point(12, 45);
            this.customerNameLabel.Name = "customerNameLabel";
            this.customerNameLabel.Size = new System.Drawing.Size(79, 20);
            this.customerNameLabel.TabIndex = 2;
            this.customerNameLabel.Text = "Customer: ";
            // 
            // CustomerReceiptsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 432);
            this.ControlBox = false;
            this.Controls.Add(this.customerNameLabel);
            this.Controls.Add(this.booksListView);
            this.Controls.Add(this.button1);
            this.Name = "CustomerReceiptsForm";
            this.Text = "CustomerReceiptsForm";
            this.Load += new System.EventHandler(this.CustomerReceiptsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private Button button1;
    private ListView booksListView;
    private Label customerNameLabel;
}