using Microsoft.AspNetCore.Components.Forms;

namespace BlazorTrainingGD_238276.Pages.modul5
{
    public class BootstrapFixFieldCssClassProvider : FieldCssClassProvider
    {
        public override string GetFieldCssClass(EditContext editContext, in FieldIdentifier fieldIdentifier)
        {
            bool IsValid=!editContext.GetValidationMessages(fieldIdentifier).Any();

            return IsValid ? "is-valid" : "is-invalid";
        }
    }
}
