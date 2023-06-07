using System;
using System.ComponentModel;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Actions;
using DevExpress.Persistent.Base;

namespace CustomActionControl.Module {
    public class CheckableSimpleAction : SimpleAction {
        private bool _Checked = false;
        private void OnCheckedStateChanged() {
            if(CheckedStateChanged != null) {
                CheckedStateChanged(this, EventArgs.Empty);
            }
        }
        public CheckableSimpleAction(IContainer container) : base(container) { }
        public CheckableSimpleAction(Controller owner, string id, PredefinedCategory category) : base(owner, id, category) { }
        public bool Checked {
            get { return _Checked; }
            set {
                if(_Checked != value) {
                    _Checked = value;
                    OnCheckedStateChanged();
                    if(Enabled.ResultValue && Active.ResultValue) {
                        DoExecute();
                    }
                }
            }
        }
        public event EventHandler CheckedStateChanged;
    }
}
