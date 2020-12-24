using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using DevExpress.ExpressApp;
namespace Exambuddy2.Module.BusinessObjects
{
    public abstract class BasicBo : IXafEntityObject, IObjectSpaceLink
    {
        [Browsable(false)] public int Id { get; set; }
        [NotMapped] public virtual BasicBo Parent { get; set; }
        [Browsable(false)] [NotMapped] public IObjectSpace ObjectSpace { get; set; }


        public void OnCreated()
        {
        }

        public void OnSaving()
        {
        }

        public void OnLoaded()
        {
        }


        public virtual void AddChild(BasicBo child)
        {
        }
    }
}