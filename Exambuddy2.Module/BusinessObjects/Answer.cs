﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using DevExpress.Data.Filtering;
using DevExpress.ExpressApp.DC;
using DevExpress.ExpressApp.Model;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl.EF;
using DevExpress.Persistent.BaseImpl.EF.PermissionPolicy;
using DevExpress.Persistent.Validation;
//using DevExpress.Xpo;
namespace Exambuddy2.Module.BusinessObjects
{
    [NavigationItem("Main")]

    [FileAttachment(nameof(DataFile))]
    [DefaultClassOptions, ImageName("BO_Resume")]
    public class Answer :BasicBo
    {
        public Answer()
        {
            
            Comments = new List<AnswerComment>();
        }
        public override BasicBo Parent
        {
            get => Question;
            set
            {
                var bo = value;
                Question = bo.ObjectSpace.FindObject<Question>(CriteriaOperator.Parse("[Id]=? ", bo.Id));
            }
        }
        

        [Browsable(false)]
        public int QuestionId { get; set; }
        [ForeignKey("QuestionId")]
        [RuleRequiredField(DefaultContexts.Save)]
        public virtual Question Question { get; set; }


        [EditorAlias("MyHtmlPropertyEditor"), ModelDefault("RowCount", "4")]
        public string AnswerText { get; set; }

        [Browsable(false)]
        public int? FileId { get; set; }
        [ForeignKey("FileId")]
         
        [Aggregated, ExpandObjectMembers(ExpandObjectMembers.Never)]
        [VisibleInListView(false)]
        public virtual AnswerFileData DataFile { get; set; }


        //[Size(-1)]
        //[Delayed(true)]
        [NotMapped]
        [ImageEditor]
       // [VisibleInListView(false)]
        public byte[] Photo
        {
            get => DataFile?.Content;
            set
            {
                var df = ObjectSpace.FindObject<AnswerFileData>(CriteriaOperator.Parse("[Id]=? ", FileId));
                if (df == null) DataFile ??= new AnswerFileData();
                if (DataFile == null) throw new Exception("DataFile is null even though it exists");
                DataFile.Content = value;
            }
        }


        [DevExpress.ExpressApp.DC.Aggregated] public virtual IList<AnswerComment> Comments { get; set; }

        public override void AddChild(BasicBo child)
        {
            base.AddChild(child);
            switch (child)
            {
                 
                case AnswerComment ac:
                    Comments.Add(ac);
                    break;
            }
        }
    }
}