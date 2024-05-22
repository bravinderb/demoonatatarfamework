using Atata;
using AtataPetProjct1.ConfirmationPopups;

namespace AtataPetProject1.CsvDataSource;

using _ = UsersPage;

public class UsersPage : Page<_>
{
    public Button<NewUserWindow, _> New { get; private set; }

    public Table<UserTableRow, _> Users { get; private set; }

    [FindByXPath("//a[@href='/products']")]
    public Link<ProductsPage,_> productMenu { get; private set; }

    public class UserTableRow : TableRow<_>
    {
        public Text<_> FirstName { get; private set; }

        public Text<_> LastName { get; private set; }

        public Text<_> Email { get; private set; }

    
        [CloseConfirmBox]
        public Button<_> Delete { get; private set; }
    }
}
