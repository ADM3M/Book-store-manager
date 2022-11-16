using Jul.Data;
using Jul.Entities;

namespace Jul;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
        var context = new DataContext();
        var authorsRepo = context.Authors;

        var hasData = authorsRepo.Any();
        
        if (!hasData)
        {
            var author = new Authors { AuthorName = "ADM" };
            authorsRepo.Add(author);
            context.SaveChanges();
        }

        label1.Text = hasData ? "Authors table contains data"
            : "Authors table has no data";
    }
}
