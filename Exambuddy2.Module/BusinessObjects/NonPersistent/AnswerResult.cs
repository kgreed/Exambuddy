using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevExpress.ExpressApp.DC;
using DevExpress.Persistent.Base;
using Exambuddy2.Module.Functions;
using Microsoft.EntityFrameworkCore;
namespace Exambuddy2.Module.BusinessObjects.NonPersistent
{
    [DomainComponent]
    [VisibleInReports(true)]
    class AnswerResult : IReportResult
    {
        public DateTime Started { get; set; }
        public DateTime Finished { get; set; }
        public string Question { get; set; }
        public string Answer { get; set; }
        public string Source { get; set; }
        public object DataSource(object[] paramObjects)
        {
            using var connect = HandyFunctions.MakeContext();
            var fromDate = (DateTime)paramObjects[0];
            var toDate = (DateTime)paramObjects[1];
            //var searchFor = (String)paramObjects[2];
            //searchFor = $"%{searchFor}%";
            //var sql = "select ";
            //var results = HandyFunctions.RunQuery(connect,sql, x => new AnswerResult { Num = (int)x[0] }, p1)
           //     connect.Database.ExecuteSqlRaw().SqlQuery<AnswerResult>("exec jtTaskSelectSQMOrderedReport @p0,@p1,@p2", fromDate, toDate, searchFor);
            var results = new  List<AnswerResult>();
            var output = results.ToArray();
            return output.ToList();
        }
    }
}
