using AtataPetProject1.CsvDataSource;
using AtataPetProject1.ValidationMessagesVerification;
using _ = SignInPage;

[Url("signin")]
public class SignInPage : Page<SignInPage>
{
    [WaitFor]
    public TextInput<_> Email { get; private set; }

    [WaitFor]
    public PasswordInput<_> Password { get; private set; }

  [WaitFor]

    public Button<UsersPage, _> SignIn { get; private set; }

    public ValidationMessageList<_> ValidationMessages { get; private set; }


    public void SignInTo() =>
         Go.To<SignInPage>()
             .Email.Set("admin@mail.com")
             .Password.Set("abc123")
             .SignIn.ClickAndGo<UsersPage>();
        
}
