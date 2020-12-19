using DevExpress.ExpressApp;
using DevExpress.Persistent.BaseImpl;
using DevExpress.ExpressApp.SystemModule;
namespace Exambuddy2.Module.Controllers
{
    public class MyController : ViewController
    {
        private NewObjectViewController controller;
        protected override void OnActivated()
        {
            base.OnActivated();
            controller = Frame.GetController<NewObjectViewController>();
            if (controller != null)
            {
                controller.ObjectCreated += controller_ObjectCreated;
            }
        }
        void controller_ObjectCreated(object sender, ObjectCreatedEventArgs e)
        {
            //if (e.CreatedObject is Task)
            //{
            //    ((Task)e.CreatedObject).StartDate = DateTime.Now;
            //}

            var nestedFrame = Frame as NestedFrame;
            if (nestedFrame == null) return;
            var createdItem = e.CreatedObject; // as Item;
            if (createdItem == null) return;
            var parent = ((NestedFrame)Frame).ViewItem.CurrentObject; //as Parent;
            if (parent != null)
            {
               // createdItem.Title = parent.DefaultItemTitle;
            }
        }
        protected override void OnDeactivated()
        {
            if (controller != null)
            {
                controller.ObjectCreated -= controller_ObjectCreated;
            }
            base.OnDeactivated();
        }
    }
}
