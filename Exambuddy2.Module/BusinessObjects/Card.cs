using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using DevExpress.Data.Filtering;
using DevExpress.ExpressApp.DC;
using DevExpress.ExpressApp.Model;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.Validation;
using Exambuddy2.Module.Annotations;
namespace Exambuddy2.Module.BusinessObjects
{
    [NavigationItem("Main")]
    [FileAttachment(nameof(DataFile))]
    [DefaultClassOptions]
    [ImageName("BO_Resume")]
    [DefaultProperty("Subject")]
    public class Card : BasicBo //, INotifyPropertyChanged// contains IObjectSpaceLink
    {
        public Card()
        {
        }
        [Browsable(false)] public int? FileId { get; set; }
        [ForeignKey("FileId")]
        [Aggregated]
        [ExpandObjectMembers(ExpandObjectMembers.Never)]
        [VisibleInListView(false)]
        public virtual CardFileData DataFile { get; set; }
        [Browsable(false)] public int? ParentId { get; set; }
        //[RuleRequiredField(DefaultContexts.Save)]
        [ForeignKey("ParentId")]
        [CanBeNull]
        public virtual Card ParentCard { get; set; }
        [CanBeNull]
        public override BasicBo Parent
        {
            get => ParentCard;
            set
            {
                var bo = value;
                ParentCard = bo.ObjectSpace.FindObject<Card>(CriteriaOperator.Parse("[Id]=? ", bo.Id));
            }
        }

        public int Week { get; set; }
        [MaxLength(400)]
        [ModelDefault("RowCount", "2")]
        public string Subject { get; set; }

        [ModelDefault("RowCount", "5")]
        public string Text { get; set; }
        [NotMapped]
        [ImageEditor]
        // [VisibleInListView(false)]
        public byte[] Photo
        {
            get => DataFile?.Content;
            set
            {
                var df = ObjectSpace.FindObject<CardFileData>(CriteriaOperator.Parse("[Id]=? ", FileId));
                if (df == null) DataFile ??= new CardFileData();
                if (DataFile == null) throw new Exception("DataFile is null even though it exists");
                DataFile.Content = value;
            }
        }
    }
}