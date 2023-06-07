using System;
using CustomActionControl.Module.Win.ActionControls;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.SystemModule;
using DevExpress.ExpressApp.Templates.ActionControls;
using DevExpress.ExpressApp.Templates.ActionControls.Binding;
using DevExpress.ExpressApp.Win.Templates.Bars.ActionControls;
using DevExpress.ExpressApp.Win.Templates.Ribbon.ActionControls;
using DevExpress.XtraBars;

namespace CustomActionControl.Module.Win.Controllers {
    public class CustomActionControlController : Controller {
        private void actionControlsSiteController_CustomAddActionControlToContainer(object sender, CustomAddActionControlEventArgs e) {
            if(e.Action is CheckableSimpleAction) {
                if(e.Container is BarLinkActionControlContainer) {
                    BarLinkActionControlContainer container = (BarLinkActionControlContainer)e.Container;
                    IActionControl actionControl = CreateActionControl(e.Action.Id, container.BarContainerItem);
                    container.AddActionControl(actionControl);
                    e.Handled = true;
                }
                if(e.Container is RibbonGroupActionControlContainer) {
                    RibbonGroupActionControlContainer container = (RibbonGroupActionControlContainer)e.Container;
                    IActionControl actionControl = CreateActionControl(e.Action.Id, container.RibbonGroup.ItemLinks);
                    container.AddActionControl(actionControl);
                    e.Handled = true;
                }
            }
        }
        private BarCheckItemCheckableSimpleActionControl CreateActionControl(string id, BarLinksHolder barLinksHolder) {
            BarCheckItem barCheckItem = new BarCheckItem(barLinksHolder.Manager);
            barCheckItem.CausesValidation = true;
            barLinksHolder.AddItem(barCheckItem);
            return new BarCheckItemCheckableSimpleActionControl(id, barCheckItem);
        }
        private void actionControlsSiteController_CustomBindActionControlToAction(object sender, CustomBindEventArgs e) {
            if(e.Action is CheckableSimpleAction && e.ActionControl is BarCheckItemCheckableSimpleActionControl) {
                e.Binding = new CheckableSimpleActionBinding((CheckableSimpleAction)e.Action, (BarCheckItemCheckableSimpleActionControl)e.ActionControl);
            }
        }
        protected override void OnActivated() {
            base.OnActivated();
            ActionControlsSiteController actionControlsSiteController = Frame.GetController<ActionControlsSiteController>();
            if (actionControlsSiteController != null) {
                actionControlsSiteController.CustomAddActionControlToContainer += new EventHandler<CustomAddActionControlEventArgs>(actionControlsSiteController_CustomAddActionControlToContainer);
                actionControlsSiteController.CustomBindActionControlToAction += new EventHandler<CustomBindEventArgs>(actionControlsSiteController_CustomBindActionControlToAction);
            }
        }
        protected override void OnDeactivated() {
            ActionControlsSiteController actionControlsSiteController = Frame.GetController<ActionControlsSiteController>();
            if (actionControlsSiteController != null) {
                actionControlsSiteController.CustomAddActionControlToContainer -= new EventHandler<CustomAddActionControlEventArgs>(actionControlsSiteController_CustomAddActionControlToContainer);
                actionControlsSiteController.CustomBindActionControlToAction -= new EventHandler<CustomBindEventArgs>(actionControlsSiteController_CustomBindActionControlToAction);
            }            
            base.OnDeactivated();
        }
    }
}
