using System.ComponentModel;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.DC;
namespace Exambuddy2.Module.BusinessObjects.NonPersistent
{
    [DomainComponent]
    public class InfoNote :IObjectSpaceLink
    {
        public string Note => Text;
        [Browsable(false)]
        public string Text { get; set; }
        [Browsable(false)]
        public IObjectSpace ObjectSpace { get; set; }
    }
}