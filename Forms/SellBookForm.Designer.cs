using System.ComponentModel;

namespace Jul.Forms;

partial class SellBookForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.customerComboBox = new System.Windows.Forms.ComboBox();
            this.booksListView = new System.Windows.Forms.ListView();
            this.sellButton = new System.Windows.Forms.Button();
            this.totalPriceLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(121, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer";
            // 
            // customerComboBox
            // 
            this.customerComboBox.FormattingEnabled = true;
            this.customerComboBox.Location = new System.Drawing.Point(236, 46);
            this.customerComboBox.Name = "customerComboBox";
            this.customerComboBox.Size = new System.Drawing.Size(150, 28);
            this.customerComboBox.TabIndex = 1;
            // 
            // booksListView
            // 
            this.booksListView.GridLines = true;
            this.booksListView.Location = new System.Drawing.Point(12, 126);
            this.booksListView.Name = "booksListView";
            this.booksListView.Size = new System.Drawing.Size(442, 199);
            this.booksListView.TabIndex = 2;
            this.booksListView.UseCompatibleStateImageBehavior = false;
            this.booksListView.View = System.Windows.Forms.View.Details;
            // 
            // sellButton
            // 
            this.sellButton.Location = new System.Drawing.Point(177, 364);
            this.sellButton.Name = "sellButton";
            this.sellButton.Size = new System.Drawing.Size(104, 34);
            this.sellButton.TabIndex = 3;
            this.sellButton.Text = "Sell";
            this.sellButton.UseVisualStyleBackColor = true;
            this.sellButton.Click += new System.EventHandler(this.sellButton_Click);
            // 
            // totalPriceLabel
            // 
            this.totalPriceLabel.AutoSize = true;
            this.totalPriceLabel.Location = new System.Drawing.Point(337, 103);
            this.totalPriceLabel.Name = "totalPriceLabel";
            this.totalPriceLabel.Size = new System.Drawing.Size(49, 20);
            this.totalPriceLabel.TabIndex = 4;
            this.totalPriceLabel.Text = "Total: ";
            // 
            // SellBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 423);
            this.Controls.Add(this.totalPriceLabel);
            this.Controls.Add(this.sellButton);
            this.Controls.Add(this.booksListView);
            this.Controls.Add(this.customerComboBox);
            this.Controls.Add(this.label1);
            this.Name = "SellBookForm";
            this.Text = "SellBookForm";
            this.Load += new System.EventHandler(this.SellBookForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private Label label1;
    private ComboBox customerComboBox;
    private ListView booksListView;
    private Button sellButton;
    private Label totalPriceLabel;
}