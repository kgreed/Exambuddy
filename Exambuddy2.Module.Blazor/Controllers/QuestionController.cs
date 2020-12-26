//using System;
//using DevExpress.ExpressApp;
//using DevExpress.ExpressApp.Actions;
//using DevExpress.Persistent.Base;
//using Exambuddy2.Module.BusinessObjects;
//namespace Exambuddy2.Module.Blazor.Controllers
//{
//    // For more typical usage scenarios, be sure to check out https://documentation.devexpress.com/eXpressAppFramework/clsDevExpressExpressAppViewControllertopic.aspx.
//    public partial class QuestionController : ViewController
//    {
//        public QuestionController()
//        {
//            //InitializeComponent();
//            TargetObjectType = typeof(Question);
//            var markStartAction = new SimpleAction(
//                this, "MarkStart2",
//                PredefinedCategory.RecordEdit)
//            {
//                SelectionDependencyType = SelectionDependencyType.RequireSingleObject
//            };
//            markStartAction.Execute += (s, e) =>
//            {
//                //foreach (Answer ans in e.SelectedObjects)
//                //{
//                //    ans.uncStartTime = DateTime.Now.ToUniversalTime();
//                //    View.ObjectSpace.SetModified(ans);
//                //}

//                View.ObjectSpace.CommitChanges();
//                View.ObjectSpace.Refresh();
//            };
//        }

//        protected override void OnActivated()
//        {
//            base.OnActivated();
//            // Perform various tasks depending on the target View.
//        }

//        protected override void OnViewControlsCreated()
//        {
//            base.OnViewControlsCreated();
//            // Access and customize the target View control.
//        }

//        protected override void OnDeactivated()
//        {
//            // Unsubscribe from previously subscribed events and release other references and resources.
//            base.OnDeactivated();
//        }
//    }
//}