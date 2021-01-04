using System;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Actions;
using DevExpress.ExpressApp.DC;
using DevExpress.Persistent.Base;
using Exambuddy2.Module.BusinessObjects;
using Exambuddy2.Module.BusinessObjects.NonPersistent;
using Exambuddy2.Module.Functions;
namespace Exambuddy2.Module.Blazor.Controllers
{
    public class AnswerStartController : ViewController
    {
        public AnswerStartController()
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
        }

        private void Action_CustomizeStartEditPopupWindowParams(object sender, CustomizePopupWindowParamsEventArgs e)
        {
            var note = new InfoNote {ObjectSpace = new NonPersistentObjectSpace(new TypesInfo())};
            e.View = Application.CreateDetailView(note);
            var startTimeUtc = RecordCurrentStartUtc();
            if (startTimeUtc == null)
            {
                note.Text = "Unexpected result";
            }
            else
            {
                var startTime = ((DateTime)startTimeUtc).ToLocalTime();
                note.Text = $"Started at {startTime}";
            }
          
        }

        private DateTime? RecordCurrentStartUtc()
        {
            // look for history record up to a millisecond before the current record
            if (!(View.CurrentObject is Answer ans)) return null;
            var sql = @$"declare @dttime datetime
                select @dttime = getutcdate()
                update answers set answertext = answertext from answers where id = {ans.Id}
                select @dttime as Dt ";
            return HandyFunctions.RunDateQuery(sql);
        }
    }
}