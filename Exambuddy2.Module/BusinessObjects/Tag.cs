using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.Validation;
using DevExpress.Xpo;
namespace Exambuddy2.Module.BusinessObjects
{
    [NavigationItem("Main")]
    public class Tag :BasicBo
    {
        public Tag()
        {
            TagLinks = new HashSet<TagLink>();
        }

        [MaxLength(255)]
        [RuleUniqueValue]
        public string Name { get; set; }

        
         

        [Aggregated]
        public virtual ICollection<TagLink> TagLinks { get; set; }

    }
}