using System.ComponentModel;

namespace Jul.Forms;

partial class CreateCustomerForm
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
            this.customerNameTextbox = new System.Windows.Forms.TextBox();
            this.countryCombobox = new System.Windows.Forms.ComboBox();
            this.cityCombobox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.adressTextbox = new System.Windows.Forms.TextBox();
            this.createButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // customerNameTextbox
            // 
            this.customerNameTextbox.Location = new System.Drawing.Point(169, 40);
            this.customerNameTextbox.Name = "customerNameTextbox";
            this.customerNameTextbox.Size = new System.Drawing.Size(150, 27);
            this.customerNameTextbox.TabIndex = 0;
            // 
            // countryCombobox
            // 
            this.countryCombobox.FormattingEnabled = true;
            this.countryCombobox.Location = new System.Drawing.Point(169, 90);
            this.countryCombobox.Name = "countryCombobox";
            this.countryCombobox.Size = new System.Drawing.Size(150, 28);
            this.countryCombobox.TabIndex = 1;
            // 
            // cityCombobox
            // 
            this.cityCombobox.FormattingEnabled = true;
            this.cityCombobox.Location = new System.Drawing.Point(169, 142);
            this.cityCombobox.Name = "cityCombobox";
            this.cityCombobox.Size = new System.Drawing.Size(150, 28);
            this.cityCombobox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Country";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "City";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(64, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Adress";
            // 
            // adressTextbox
            // 
            this.adressTextbox.Location = new System.Drawing.Point(169, 194);
            this.adressTextbox.Name = "adressTextbox";
            this.adressTextbox.Size = new System.Drawing.Size(150, 27);
            this.adressTextbox.TabIndex = 7;
            // 
            // createButton
            // 
            this.createButton.Location = new System.Drawing.Point(226, 258);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(93, 29);
            this.createButton.TabIndex = 8;
            this.createButton.Text = "Create";
            this.createButton.UseVisualStyleBackColor = true;
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(64, 258);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(93, 29);
            this.cancelButton.TabIndex = 9;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click_1);
            // 
            // CreateCustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 315);
            this.ControlBox = false;
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.createButton);
            this.Controls.Add(this.adressTextbox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cityCombobox);
            this.Controls.Add(this.countryCombobox);
            this.Controls.Add(this.customerNameTextbox);
            this.Name = "CreateCustomerForm";
            this.Text = "CreateCustomerForm";
            this.Load += new System.EventHandler(this.CreateCustomerForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private TextBox customerNameTextbox;
    private ComboBox countryCombobox;
    private ComboBox cityCombobox;
    private Label label1;
    private Label label2;
    private Label label3;
    private Label label4;
    private TextBox adressTextbox;
    private Button createButton;
    private Button cancelButton;
}