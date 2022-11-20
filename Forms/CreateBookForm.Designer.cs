using System.ComponentModel;

namespace Jul.Forms;

partial class CreateBookForm
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
            this.titleTextbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.yearTextbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.genreCombobox = new System.Windows.Forms.ComboBox();
            this.publisherCombobox = new System.Windows.Forms.ComboBox();
            this.authorCombobox = new System.Windows.Forms.ComboBox();
            this.addButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.countTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // titleTextbox
            // 
            this.titleTextbox.Location = new System.Drawing.Point(232, 48);
            this.titleTextbox.Name = "titleTextbox";
            this.titleTextbox.Size = new System.Drawing.Size(183, 27);
            this.titleTextbox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Title";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(76, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Author";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(76, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Genre";
            // 
            // yearTextbox
            // 
            this.yearTextbox.Location = new System.Drawing.Point(232, 147);
            this.yearTextbox.Name = "yearTextbox";
            this.yearTextbox.Size = new System.Drawing.Size(183, 27);
            this.yearTextbox.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(76, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Year";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(76, 183);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "Publisher";
            // 
            // priceTextBox
            // 
            this.priceTextBox.Location = new System.Drawing.Point(232, 213);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(183, 27);
            this.priceTextBox.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(76, 216);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 20);
            this.label6.TabIndex = 1;
            this.label6.Text = "Price";
            // 
            // genreCombobox
            // 
            this.genreCombobox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.genreCombobox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.genreCombobox.FormattingEnabled = true;
            this.genreCombobox.ImeMode = System.Windows.Forms.ImeMode.On;
            this.genreCombobox.Location = new System.Drawing.Point(232, 113);
            this.genreCombobox.Name = "genreCombobox";
            this.genreCombobox.Size = new System.Drawing.Size(183, 28);
            this.genreCombobox.TabIndex = 2;
            // 
            // publisherCombobox
            // 
            this.publisherCombobox.FormattingEnabled = true;
            this.publisherCombobox.Location = new System.Drawing.Point(232, 179);
            this.publisherCombobox.Name = "publisherCombobox";
            this.publisherCombobox.Size = new System.Drawing.Size(183, 28);
            this.publisherCombobox.TabIndex = 2;
            // 
            // authorCombobox
            // 
            this.authorCombobox.FormattingEnabled = true;
            this.authorCombobox.Location = new System.Drawing.Point(232, 79);
            this.authorCombobox.Name = "authorCombobox";
            this.authorCombobox.Size = new System.Drawing.Size(183, 28);
            this.authorCombobox.TabIndex = 3;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(271, 312);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(103, 30);
            this.addButton.TabIndex = 4;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(116, 312);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(96, 30);
            this.cancelButton.TabIndex = 4;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // countTextBox
            // 
            this.countTextBox.Location = new System.Drawing.Point(232, 246);
            this.countTextBox.Name = "countTextBox";
            this.countTextBox.Size = new System.Drawing.Size(183, 27);
            this.countTextBox.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(76, 249);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 20);
            this.label7.TabIndex = 1;
            this.label7.Text = "Count";
            // 
            // CreateBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 354);
            this.ControlBox = false;
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.authorCombobox);
            this.Controls.Add(this.publisherCombobox);
            this.Controls.Add(this.genreCombobox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.countTextBox);
            this.Controls.Add(this.priceTextBox);
            this.Controls.Add(this.yearTextbox);
            this.Controls.Add(this.titleTextbox);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CreateBookForm";
            this.Text = "CreateBookForm";
            this.Load += new System.EventHandler(this.CreateBookForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private TextBox titleTextbox;
    private Label label1;
    private Label label2;
    private Label label3;
    private TextBox yearTextbox;
    private Label label4;
    private Label label5;
    private TextBox priceTextBox;
    private Label label6;
    private ComboBox genreCombobox;
    private ComboBox publisherCombobox;
    private ComboBox authorCombobox;
    private Button addButton;
    private Button cancelButton;
    private TextBox countTextBox;
    private Label label7;
}