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
    public class AnswerEditController : ViewController
    {
        public AnswerEditController()
        {
            TargetObjectType = typeof(Answer);
            var actionShowLastEditMins = new PopupWindowShowAction(
                this, "Mins",
                PredefinedCategory.RecordEdit)
            {
                SelectionDependencyType = SelectionDependencyType.RequireSingleObject
            };
            actionShowLastEditMins.CustomizePopupWindowParams += Action_CustomizeMinsPopupWindowParams;
            actionShowLastEditMins.Execute += (s, e) => { };
        }

        private void Action_CustomizeMinsPopupWindowParams(object sender, CustomizePopupWindowParamsEventArgs e)
        {
            var note = new InfoNote {ObjectSpace = new NonPersistentObjectSpace(new TypesInfo())};
            e.View = Application.CreateDetailView(note);
            var secs = GetSecsDuringLastEdit();
            if (secs == null)
            {
                note.Text = "There is no prior edit";
                return;
            }

            double secsperMin = 60;
            var mins = Math.Round((int) secs / secsperMin, 2, MidpointRounding.AwayFromZero);
            note.Text = $" Last edit took {mins} mins";
        }

        private int? GetSecsDuringLastEdit()
        {
            // look for history record up to a  second before the current record
            if (!(View.CurrentObject is Answer ans)) return null;
            var sql = @$"declare @dttime datetime
                select @dttime = [SysStartTime] from answers where id = {ans.Id}
                declare @dttimeprev datetime
                select @dttimeprev = DATEADD(s, -1, @dttime)
                select datediff(s, sysstarttime, sysendtime) as Num from answers for SYSTEM_TIME as of @dttimeprev  where id = {ans.Id}";
            return HandyFunctions.RunNumQuery(sql);
        }
    }
}