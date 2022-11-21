using Jul.Entities;
using Jul.Services;
using Microsoft.EntityFrameworkCore;

namespace Jul.Forms;

public partial class CreateCustomerForm : Form
{
    private readonly ListView _listView;
    private readonly Dictionary<int, Customers> _customersMap;
    private readonly UnitOfWork _uow;

    public CreateCustomerForm(ListView listView, Dictionary<int, Customers> customersMap, UnitOfWork uow)
    {
        InitializeComponent();
        _listView = listView;
        _customersMap = customersMap;
        _uow = uow;
    }

    private void CreateCustomerForm_Load(object sender, EventArgs e)
    {
        var countriesName = _uow.DbContext.Countries
            .Select(e => e.CountryName)
            .ToArray();

        var citiesName = _uow.DbContext.Cities
            .Select(e => e.CityName)
            .ToArray();
        
        SetupComboBox(cityCombobox, citiesName);
        SetupComboBox(countryCombobox, countriesName);
    }

    private void SetupComboBox(ComboBox comboBox, string[] collection)
    {
        comboBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
        comboBox.AutoCompleteMode = AutoCompleteMode.Suggest;

        comboBox.AutoCompleteCustomSource.AddRange(collection);
        comboBox.Items.AddRange(collection);
    }

    private async void createButton_Click(object sender, EventArgs e)
    {
        var cityName = cityCombobox.SelectedItem as string;
        cityName ??= cityCombobox.Text;
        var countryName = countryCombobox.SelectedItem as string;
        countryName ??= countryCombobox.Text;
        var adress = adressTextbox.Text;
        var customerName = customerNameTextbox.Text;

        var allFieldsCorrect = cityName != null
                               && countryName != null
                               && adress != null
                               && customerName != null;

        if (!allFieldsCorrect)
        {
            MessageBox.Show("Fill all field correct!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            return;
        }

        var city = await _uow.DbContext.Cities.SingleOrDefaultAsync(e => e.CityName == cityName);
        var country = await _uow.DbContext.Countries.SingleOrDefaultAsync(e => e.CountryName == countryName);

        if (city is null || country is null)
        {
            MessageBox.Show("City or country you entered doesn't exist", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            return;
        }

        var customer = new Customers
        {
            Name = customerName,
            City = city,
            Country = country,
            Adress = adress
        };

        try
        {
            _uow.DbContext.Customers.Add(customer);
            await _uow.DbContext.SaveChangesAsync();

            _customersMap.Add(customer.Id, customer);
            _listView.Items.Add(
                new ListViewItem(
                    new[]
                    {
                        customer.Id.ToString(),
                        customerName,
                        countryName,
                        cityName
                    }
                ));
        }
        catch (Exception exception)
        {
            MessageBox.Show("Error while adding a customer!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }
        finally
        {
            Close();
        }
    }

    private void cancelButton_Click_1(object sender, EventArgs e)
    {
        Close();
    }
}