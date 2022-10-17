// See https://aka.ms/new-console-template for more information
using CSVValidator;
using System.Data;


Console.WriteLine("Demo, CSV/Excel Data Validator!");
string location = "E:\\SourceCode\\ExcelHeaderValidation";
TestData TestData = new TestData();
TestData.tempdatatable(location);
class TestData
{
    public void tempdatatable(string location) 
    {
        DataTable dataTable = new DataTable();
        foreach (var item in validateHeaders())
        {
            dataTable.Columns.Add(item);
        }

        string csv= dataTable.ToCSV();

        // Here you will pass your DT CSV file location and app settings file location
        var errors = new Validator().testValidator(csv, location + "\\headersetting.json");
        foreach (var error in errors)
        {
            foreach (var err in error.Errors)
            {
                Console.WriteLine(err.Message);
            }
        }
        Console.ReadLine();
    }
    public List<string> validateHeaders()
    {
        return new List<string>
            {
                "OrderKey",
                "SKU",
                "Product Name",
                "Quantity",
                "Shipping Service",
                "shipper_account_number",
                "Ship To Name",
                "Ship To Company",
                "Ship to Address 1",
                "Ship To Address 2",
                "Ship To Address 3",
                "Ship To City",
                "Ship To State",
                "Ship To Postal Code",
                "Ship To Country",
                "Ship To Telephone",
                "User Email",
                "PO Number",
                "Project name",
                "custom_02"
            };
    }
}