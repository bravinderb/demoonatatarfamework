using AtataPetProject1;
using AtataPetProject1.Triggers;
using AtataPetProject1.ValidationMessagesVerification;
using System.Globalization;

namespace AtataPetProjct1.ConfirmationPopups;

using _ = ProductsPage;

[WaitForLoadingIndicator]
[Url("products")]
[VerifyTitle("Products - Atata Sample App")]
public class ProductsPage : Page<ProductsPage>
{

    public Text<_> Title { get; set; }

    public H1<_> Header { get; private set; }


    public Table<ProductTableRow, _> Products { get; private set; }

    public ValidationMessageList<_> ValidationMessages { get; private set; }

    [FindByCss(".amount-with-currency")] // Adjust selector as needed
    public Currency<_> AmountWithCurrency { get; private set; }

    public class ProductTableRow : TableRow<_>
    {
        public Text<_> Name { get; private set; }
     
       public Currency<_> Price { get; private set; }

        public Number<_> Amount { get; private set; }

        [CloseConfirmBox]
        public ButtonDelegate<_> DeleteUsingJSConfirm { get; private set; }

        [WaitForLoadingIndicator(TriggerEvents.AfterClick)]
        [FindByContent("Delete Using BS Modal")]
        public ButtonDelegate<DeletionConfirmationBSModal<_>, _> DeleteUsingBSModal { get; private set; }


    }
  
}
