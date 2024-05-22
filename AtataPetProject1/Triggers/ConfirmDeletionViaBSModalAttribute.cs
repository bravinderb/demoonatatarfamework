using Atata;

namespace AtataPetProject1.Triggers;
public sealed class ConfirmDeletionViaBSModalAttribute : TriggerAttribute
{
    public ConfirmDeletionViaBSModalAttribute(TriggerEvents on, TriggerPriority priority = TriggerPriority.Medium)
        : base(on, priority)
    {
    }

    protected override void Execute<TOwner>(TriggerContext<TOwner> context)
    {
        Go.To<DeletionConfirmationBSModal<TOwner>>(temporarily: true)
          .Delete();
    }
}
