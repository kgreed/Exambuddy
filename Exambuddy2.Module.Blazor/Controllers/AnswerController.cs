using System;
using System.Diagnostics;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Actions;
using DevExpress.ExpressApp.DC;
using DevExpress.Persistent.Base;
using DevExpress.PivotGrid.Internal;
using Exambuddy2.Module.BusinessObjects;
using Exambuddy2.Module.BusinessObjects.NonPersistent;
using Exambuddy2.Module.Functions;
namespace Exambuddy2.Module.Blazor.Controllers
{
    // For more typical usage scenarios, be sure to check out https://documentation.devexpress.com/eXpressAppFramework/clsDevExpressExpressAppViewControllertopic.aspx.
    public class AnswerController : ViewController
    {
        public AnswerController()
        {
            TargetObjectType = typeof(Answer);
            var action = new PopupWindowShowAction(
                this, "Mins",
                PredefinedCategory.RecordEdit)
            {
                SelectionDependencyType = SelectionDependencyType.RequireSingleObject
            };
            action.CustomizePopupWindowParams += Action_CustomizePopupWindowParams;
            action.Execute += (s, e) =>
            {
              
            };
        }

        private   int? GetSecsDuringLastEdit( )
        {
            if (!(View.CurrentObject is Answer ans)) return null;
            var sql = @$"declare @dttime datetime
                select @dttime = [SysStartTime] from answers where id = 14
                declare @dttimeprev datetime
                select @dttimeprev = DATEADD(s, -1, @dttime)
                select   datediff(s, sysstarttime, sysendtime) as Num from answers for SYSTEM_TIME as of @dttimeprev  where id = {ans.Id}";
            return HandyFunctions.RunNumQuery(sql);
            
        }

        private void Action_CustomizePopupWindowParams(object sender, CustomizePopupWindowParamsEventArgs e)
        {
            var note = new MyNote {ObjectSpace = new NonPersistentObjectSpace(new TypesInfo())};
            e.View = Application.CreateDetailView(note);

            var secs = GetSecsDuringLastEdit();
            if (secs == null)
            {
                note.Text = "There is no prior edit"
                return;
            }
            double secsperMin = 60;
            var mins =  Math.Round( (int)secs /secsperMin,2,MidpointRounding.AwayFromZero)  ;
            note.Text = $" Last edit took {mins} mins";
        }

        protected override void OnActivated()
        {
            base.OnActivated();
            // Perform various tasks depending on the target View.
        }

        protected override void OnViewControlsCreated()
        {
            base.OnViewControlsCreated();
            // Access and customize the target View control.
        }

        protected override void OnDeactivated()
        {
            // Unsubscribe from previously subscribed events and release other references and resources.
            base.OnDeactivated();
        }
    }
}