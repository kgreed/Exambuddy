﻿using DevExpress.ExpressApp;
using DevExpress.ExpressApp.SystemModule;
using Exambuddy2.Module.BusinessObjects;
namespace Exambuddy2.Module.Controllers
{
    public class MyController : ViewController
    {
        private NewObjectViewController controller;

        protected override void OnActivated()
        {
            base.OnActivated();
            controller = Frame.GetController<NewObjectViewController>();
            if (controller != null) controller.ObjectCreated += controller_ObjectCreated;
        }

        private void controller_ObjectCreated(object sender, ObjectCreatedEventArgs e)
        {
            var nestedFrame = Frame as NestedFrame;
            if (nestedFrame == null) return;
            var createdItem = e.CreatedObject; // as Item;
            if (createdItem == null) return;
            var parent = e.ObjectSpace.GetObject(((NestedFrame) Frame).ViewItem.CurrentObject); //as Parent;
            if (parent == null) return;
            if (!(createdItem is BasicBo boCreated)) return;
            ((BasicBo) parent).AddChild(createdItem as BasicBo);
            ((BasicBo) createdItem).Parent = parent as BasicBo;
        }

        protected override void OnDeactivated()
        {
            if (controller != null) controller.ObjectCreated -= controller_ObjectCreated;
            base.OnDeactivated();
        }
    }
}