using System.Collections.Generic;
using DevExpress.Data.Filtering;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Model;
using DevExpress.Persistent.Base;
using DevExpress.Xpo;
namespace Exambuddy2.Module.BusinessObjects
{
    [NavigationItem("Main")]
    public class CourseUnit :BasicBo 
    {
        public CourseUnit()
        {
             Topics = new List<Topic>();
        }

        public override void AddChild(BasicBo child)
        {
            base.AddChild(child);
           // var childBo =  ObjectSpace.FindObject<Topic>(CriteriaOperator.Parse("[Id]=? ", child.Id) );
            Topics.Add(child as Topic );
        }

       
        public string Name { get; set; }

        [Aggregated]
        public virtual IList<Topic> Topics { get; set; }
        
        [EditorAlias("MyHtmlPropertyEditor"), ModelDefault("RowCount", "4")]
        public string Description { get; set; }
        
    }
}