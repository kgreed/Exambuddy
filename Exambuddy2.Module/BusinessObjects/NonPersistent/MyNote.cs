using System.ComponentModel;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.DC;
namespace Exambuddy2.Module.BusinessObjects.NonPersistent
{
    [DomainComponent]
    public class MyNote :IObjectSpaceLink{
        public string Text { get; set; }
        [Browsable(false)]
        public IObjectSpace ObjectSpace { get; set; }
    }
}