using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using DevExpress.ExpressApp.Model;
using DevExpress.Persistent.Base;
using DevExpress.Xpo;
namespace Exambuddy2.Module.BusinessObjects
{
    [NavigationItem("Main")]
    //[FileAttachment(nameof(Files))]
    [DefaultClassOptions, ImageName("BO_Resume")]
    public class Question : BasicBo 
    {
        public Question() {
            this.Files = new List<RelatedFile>();
        }
        

        public int Id { get; set; }
        public string Name { get; set; }

        [Browsable(false)]
        public int TopicId { get; set; }
        [ForeignKey("TopicId")]
        public virtual Topic Topic { get; set; }
        [ModelDefault("RowCount", "10")]
        [EditorAlias("MyHtmlPropertyEditor"), ModelDefault("RowCount", "10")]
        public string QuestionText { get; set; }
        
        [Size(-1)]
        [Delayed(true)]

        [ImageEditor]
        public byte[] Photo { get; set; }

        [Aggregated]
        public virtual ICollection<RelatedFile> Files  { get; set; }

     
    }
     
}