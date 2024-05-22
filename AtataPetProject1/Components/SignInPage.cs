using Atata;
using AtataPetProjct1.ConfirmationPopups;
using AtataPetProject1.CsvDataSource;
using AtataPetProject1.ValidationMessagesVerification;
using _ = SignInPage;

[Url("signin")]
public class SignInPage : Page<SignInPage>
{
    public TextInput<_> Email { get; private set; }

    public PasswordInput<_> Password { get; private set; }

    public Button<_, _> SignIn { get; private set; }

    public ValidationMessageList<_> ValidationMessages { get; private set; }
}
