using Atata;
using AtataPetProjct1.ConfirmationPopups;
using AtataPetProject1.CsvDataSource;
using DocumentFormat.OpenXml.Bibliography;
using DocumentFormat.OpenXml.Presentation;
using DocumentFormat.OpenXml.Spreadsheet;
using OpenQA.Selenium.Support.UI;
using System.Globalization;

namespace AtataPetProject1;

public class ProductTests : UITestFixture
{
    [Test]
    public void TestA() =>
        Go.To<ProductsPage>()

            .Products.Rows[x => x.Name == "Armchair"].DeleteUsingBSModal()
                .Delete() // Delete and verify that item is deleted.
            .Products.Rows[x => x.Name == "Armchair"].Should.Not.BePresent()
          .Products.Rows.Count.Should.Equal(4)
     .AggregateAssert(x => x.Products.Rows
                    .SelectData(row => row.Price.Get())
                    .ToArray()
                    .Sum()
                    .ToSutSubject()
                    .Should.Equal(570))

                .AggregateAssert(x => x.Products.Rows
                    .SelectData(row => row.Amount.Get())
                    .ToArray()
                    .Sum()
                    .ToSutSubject()
                    .Should.Equal(245));

    [Test]
    public void TestB() =>

        Go.To<SignInPage>() // Navigate to the login page.
             .Email.Set("admin@mail.com")
           .Password.Set("abc123").SignIn.ClickAndGo<UsersPage>().Products.ClickAndGo<ProductsPage>()

    .Products.Rows.ForEach(row =>
    {
        decimal priceValue = (decimal)row.Price.Value;
        string actualPrice = priceValue.ToString("C2", new CultureInfo("en-US"));
        Assert.That(actualPrice.Contains("$")); // Adjust expected value as needed
    })

      .AggregateAssert(x => x
                .PageTitle.Should.Contain("Atata")
                .Header.Should.Contain("Products"))
        .Products.Rows[x => x.Price == 125].Should.BePresent()
        .Products.Rows[x => x.Price == 35].Should.BePresent()
        .Products.Rows[x => x.Price == 130].Should.BePresent()
        .Products.Rows[x => x.Price == 280].Should.BePresent();

}
