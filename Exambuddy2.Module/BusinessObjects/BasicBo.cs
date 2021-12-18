using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using DevExpress.ExpressApp;
using DevExpress.Persistent.BaseImpl.EF.PermissionPolicy;
using Exambuddy2.Module.Annotations;
namespace Exambuddy2.Module.BusinessObjects
{
    public abstract class BasicBo : IXafEntityObject, IObjectSpaceLink
    {
        [Browsable(false)] public int Id { get; set; }
        [NotMapped] [CanBeNull] public virtual BasicBo Parent { get; set; }
        [Browsable(false)] [NotMapped] public IObjectSpace ObjectSpace { get; set; }

        public int CreatedOrModifiedByUserId { get; set; }
        public void OnCreated()
        {
            CreatedOrModifiedByUserId =  (int) SecuritySystem.CurrentUserId;
        }

        public void OnSaving()
        {
            //if (Id > 0)
            //{
                CreatedOrModifiedByUserId = (int)SecuritySystem.CurrentUserId;
            //}
        }

        public void OnLoaded()
        {
        }


        public virtual void AddChild(BasicBo child)
        {
        }
    }
}