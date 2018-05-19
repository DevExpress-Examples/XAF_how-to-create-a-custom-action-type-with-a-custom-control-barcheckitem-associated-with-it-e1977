using System;
using DevExpress.ExpressApp.Actions;
using DevExpress.ExpressApp.Win.Templates.ActionContainers.Items;
using DevExpress.XtraBars;

namespace CustomActionControl.Module.Win.ActionItems {
    public class CheckableSimpleActionItem : BarActionBaseItem {
        private void Action_CheckedStateChanged(object sender, EventArgs e) {
            Control.Checked = Action.Checked;
        }
        protected override BarItem CreateControlCore() {
            return new BarCheckItem();
        }
        protected override void SynchronizeWithActionCore() {
            base.SynchronizeWithActionCore();
            Control.Checked = Action.Checked;
            Action.CheckedStateChanged += new EventHandler(Action_CheckedStateChanged);
        }
        protected override void ItemClicked(BarItemLink barItemLink) {
            base.ItemClicked(barItemLink);
            if(IsItemClickEnable && IsConfirmed()) {
                Action.Checked = !Action.Checked;
            }
        }
        public CheckableSimpleActionItem(ActionBase action, BarManager manager) : base(action, manager) { }
        public new BarCheckItem Control {
            get { return (BarCheckItem)base.Control; }
        }
        public new CheckableSimpleAction Action {
            get { return (CheckableSimpleAction)base.Action; }
        }
    }
}
