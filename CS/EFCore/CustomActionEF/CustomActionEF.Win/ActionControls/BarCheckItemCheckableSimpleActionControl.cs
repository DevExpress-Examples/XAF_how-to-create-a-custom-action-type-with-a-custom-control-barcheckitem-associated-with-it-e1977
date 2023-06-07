using System;
using DevExpress.ExpressApp.Win.Templates.Bars.ActionControls;
using DevExpress.XtraBars;

namespace CustomActionControl.Module.Win.ActionControls {
    public class BarCheckItemCheckableSimpleActionControl : BarItemActionControl<BarCheckItem> {
        private void BarItem_ItemClick(object sender, ItemClickEventArgs args) {
            RaiseExecute();
        }
        protected override void OnEndInit() {
            base.OnEndInit();
            BarItem.ItemClick += BarItem_ItemClick;
        }
        protected void RaiseExecute() {
            if(IsConfirmed() && Execute != null) {
                Execute(this, EventArgs.Empty);
            }
        }
        public BarCheckItemCheckableSimpleActionControl() { }
        public BarCheckItemCheckableSimpleActionControl(string actionId, BarCheckItem item) : base(actionId, item) { }
        public bool Checked {
            get { return BarItem.Checked; }
            set { BarItem.Checked = value; }
        }
        public event EventHandler<EventArgs> Execute;
    }
}
