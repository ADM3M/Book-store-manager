using System.Windows.Forms;

namespace Jul.Forms;

public partial class CreateBookForm : Form
{
    public CreateBookForm(ListView source)
    {
        InitializeComponent();
    }

    private void CreateBookForm_Load(object sender, EventArgs e)
    {
        authorCombobox.AutoCompleteSource = AutoCompleteSource.CustomSource;
        authorCombobox.AutoCompleteMode = AutoCompleteMode.Suggest;
        authorCombobox.AutoCompleteCustomSource = new AutoCompleteStringCollection()
        {
            "aaaaaa",
            "bbbbbb",
            "cccccc",
            "111111",
            "222222",
            "333333",
            "444444",
            "555555",
            "666666",
            "777777",
            "888888",
            "999999",
        };

        authorCombobox.Items.AddRange(new[]
        {
            "aaaaaa",
            "bbbbbb",
            "cccccc",
            "111111",
            "222222",
            "333333",
            "444444",
            "555555",
            "666666",
            "777777",
            "888888",
            "999999",
        });
    }

    private void button1_Click(object sender, EventArgs e)
    {
        MessageBox.Show(authorCombobox.Text);
    }
}