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

            var actionStartEdit = new PopupWindowShowAction(
                this, "Start",
                PredefinedCategory.RecordEdit)
            {
                SelectionDependencyType = SelectionDependencyType.RequireSingleObject
            };
            
           actionStartEdit.CustomizePopupWindowParams += Action_CustomizeStartEditPopupWindowParams;
            actionStartEdit.Execute += (s, e) => { };


            var actionShowLastEditMins = new PopupWindowShowAction(
                this, "Mins",
                PredefinedCategory.RecordEdit)
            {
                SelectionDependencyType = SelectionDependencyType.RequireSingleObject
            };
            actionShowLastEditMins.CustomizePopupWindowParams += Action_CustomizeMinsPopupWindowParams;
            actionShowLastEditMins.Execute += (s, e) => { };

        }

        private   int? GetSecsDuringLastEdit(  )
        {
            // look for history record up to a millisecond before the current record
            if (!(View.CurrentObject is Answer ans)) return null;
            var sql = @$"declare @dttime datetime
                select @dttime = [SysStartTime] from answers where id = {ans.Id}
                declare @dttimeprev datetime
                select @dttimeprev = DATEADD(ms, -1, @dttime)
                select   datediff(s, sysstarttime, sysendtime) as Num from answers for SYSTEM_TIME as of @dttimeprev  where id = {ans.Id}";
            return HandyFunctions.RunNumQuery(sql);
            
        }

        private DateTime? RecordCurrentStart()
        {
            // look for history record up to a millisecond before the current record
            if (!(View.CurrentObject is Answer ans)) return null;
            var sql = @$"declare @dttime datetime
                select @dttime = getdate()
                update answers set answertext = answertext from answers where id = {ans.Id}
[               select @dttime as Dt ";
            return HandyFunctions.RunDateQuery(sql);

        }
        private void Action_CustomizeStartEditPopupWindowParams(object sender, CustomizePopupWindowParamsEventArgs e)
        {
            var note = new MyNote { ObjectSpace = new NonPersistentObjectSpace(new TypesInfo()) };
            e.View = Application.CreateDetailView(note);
            var startTime = RecordCurrentStart(); 
            
            note.Text = $"Started at {startTime}";
        }
        private void Action_CustomizeMinsPopupWindowParams(object sender, CustomizePopupWindowParamsEventArgs e)
        {
            var note = new MyNote {ObjectSpace = new NonPersistentObjectSpace(new TypesInfo())};
            e.View = Application.CreateDetailView(note);

            var secs = GetSecsDuringLastEdit();
            if (secs == null)
            {
                note.Text = "There is no prior edit";
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