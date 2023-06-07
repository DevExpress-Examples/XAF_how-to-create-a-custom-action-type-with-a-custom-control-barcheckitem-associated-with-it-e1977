using DevExpress.Data.Filtering;
using DevExpress.ExpressApp;
using DevExpress.Persistent.Base;

namespace CustomActionControl.Module.Win.Controllers {
    public class SampleController : ObjectViewController<ListView, Order> {
        public SampleController() {
            CheckableSimpleAction activeFilterAction = new CheckableSimpleAction(this, "ActiveFilterAction", PredefinedCategory.Filters);
            activeFilterAction.Caption = "Active";
            activeFilterAction.Execute += activeFilterAction_Execute;
            CheckableSimpleAction todayFilterAction = new CheckableSimpleAction(this, "TodayFilterAction", PredefinedCategory.Filters);
            todayFilterAction.Caption = "Today";
            todayFilterAction.Execute += todayFilterAction_Execute;
        }
        void activeFilterAction_Execute(object sender, DevExpress.ExpressApp.Actions.SimpleActionExecuteEventArgs e) {
            bool applyFilter = ((CheckableSimpleAction)sender).Checked;
            if (applyFilter){
                View.CollectionSource.Criteria["IsActive"] = new OperandProperty("Active");
            } else {
                View.CollectionSource.Criteria.Remove("IsActive");
            }
        }
        void todayFilterAction_Execute(object sender, DevExpress.ExpressApp.Actions.SimpleActionExecuteEventArgs e) {
            bool applyFilter = ((CheckableSimpleAction)sender).Checked;
            if (applyFilter) {
                View.CollectionSource.Criteria["IsToday"] = new FunctionOperator(FunctionOperatorType.IsOutlookIntervalToday, new OperandProperty("Date"));
            } else {
                View.CollectionSource.Criteria.Remove("IsToday");
            }
        }
    }
}
