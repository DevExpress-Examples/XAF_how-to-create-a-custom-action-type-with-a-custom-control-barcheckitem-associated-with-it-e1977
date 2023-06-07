using System;
using DevExpress.ExpressApp.Templates.ActionControls.Binding;

namespace CustomActionControl.Module.Win.ActionControls {
    public class CheckableSimpleActionBinding : ActionBinding {
        private void Action_CheckedStateChanged(object sender, EventArgs e) {
            ActionControl.Checked = Action.Checked;
        }
        private void ActionControl_Execute(object sender, EventArgs e) {
            Action.Checked = !Action.Checked;
        }
        public CheckableSimpleActionBinding(CheckableSimpleAction action, BarCheckItemCheckableSimpleActionControl actionControl)
            : base(action, actionControl) {
            ActionControl.Execute += new EventHandler<EventArgs>(ActionControl_Execute);
            Action.CheckedStateChanged += new EventHandler(Action_CheckedStateChanged);
            ActionControl.Checked = Action.Checked;
        }
        public override void Dispose() {
            ActionControl.Execute -= new EventHandler<EventArgs>(ActionControl_Execute);
            Action.CheckedStateChanged -= new EventHandler(Action_CheckedStateChanged);
            base.Dispose();
        }
        public new CheckableSimpleAction Action {
            get { return (CheckableSimpleAction)base.Action; }
        }
        public new BarCheckItemCheckableSimpleActionControl ActionControl {
            get { return (BarCheckItemCheckableSimpleActionControl)base.ActionControl; }
        }
    }
}
