using Atata;
using Atata.Bootstrap;

namespace AtataPetProject1.Triggers;
[Name("Deletion Confirmation")]
[WindowTitle("Confirmation")]
public class DeletionConfirmationBSModal<TNavigateTo> : BSModal<DeletionConfirmationBSModal<TNavigateTo>>
    where TNavigateTo : PageObject<TNavigateTo>
{
    public ButtonDelegate<TNavigateTo, DeletionConfirmationBSModal<TNavigateTo>> Delete { get; private set; }

    public ButtonDelegate<TNavigateTo, DeletionConfirmationBSModal<TNavigateTo>> Cancel { get; private set; }
}
