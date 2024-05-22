using AtataPetProjct1.ConfirmationPopups;
using AtataPetProject1.CsvDataSource;

namespace AtataPetProject1;

public class ProductTests : UITestFixture
{
    [Test]
    public void DeleteUsingBSModal() =>
        Go.To<ProductsPage>()
           
            .Products.Rows[x => x.Name == "Armchair"].DeleteUsingBSModal()
                .Delete() // Delete and verify that item is deleted.
            .Products.Rows[x => x.Name == "Armchair"].Should.Not.BePresent()
          .Products.Rows.Count.Should.Equal(4)
            .Products.Rows.Select(row => Convert.ToInt32(row.Amount.Value)).ToList().Sum().Equals(245)
          ;

    [Test]
    public void Validation_Required() =>
         Go.To<UsersPage>().productMenu.ClickAndGo<ProductsPage>()
            .AggregateAssert(x => x
                .PageTitle.Should.Contain("Atata")
                .Header.Should.Contain("Products"))
        .Products.Rows[x => x.Amount == 50].Should.BePresent()
        .Products.Rows[x => x.Amount == 120].Should.BePresent()
        .Products.Rows[x => x.Amount == 70].Should.BePresent()
        .Products.Rows[x => x.Amount == 5].Should.BePresent()

        .Products.Rows[x => x.Price == 125].Should.BePresent()
        .Products.Rows[x => x.Price == 35].Should.BePresent()
        .Products.Rows[x => x.Price == 130].Should.BePresent()
        .Products.Rows[x => x.Price == 280].Should.BePresent();

}
