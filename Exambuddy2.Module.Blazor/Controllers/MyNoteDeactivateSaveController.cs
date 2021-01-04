using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Actions;
using DevExpress.ExpressApp.SystemModule;
using Exambuddy2.Module.BusinessObjects.NonPersistent;
namespace Exambuddy2.Module.Blazor.Controllers
{
    public class MyNoteDeactivateSaveController : ObjectViewController<DetailView, InfoNote>
    {
        public MyNoteDeactivateSaveController()
        {
           // InitializeComponent();
        }

        private const string Key = "Deactivation in code";
        private DialogController dialogController;
        protected override void OnActivated()
        {
            base.OnActivated();
            dialogController = Frame.GetController<DialogController>();
            dialogController.CanCloseWindow = true;
             
            if (dialogController != null)
            {
                //dialogController.Active[Key] = false;
                dialogController.CancelAction.Active[Key] = false;
            }

        }

        protected override void OnDeactivated()
        {
            if (dialogController != null)
            {
                dialogController.Active.RemoveItem(Key);
                dialogController = null;
            }
            base.OnDeactivated();
        }
    }
}