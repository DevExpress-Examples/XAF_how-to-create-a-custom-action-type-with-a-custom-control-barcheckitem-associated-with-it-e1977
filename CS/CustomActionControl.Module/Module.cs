using System;
using System.Collections.Generic;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Updating;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Data.Filtering;

namespace CustomActionControl.Module {
    public sealed partial class CustomActionControlModule : ModuleBase {
        public CustomActionControlModule() {
            InitializeComponent();
            BaseObject.OidInitializationMode = OidInitializationMode.AfterConstruction;
        }
        public override IEnumerable<ModuleUpdater> GetModuleUpdaters(IObjectSpace objectSpace, Version versionFromDB) {
            ModuleUpdater updater = new Updater(objectSpace, versionFromDB);
            return new ModuleUpdater[] { updater };
        }
    }
    public class Updater : ModuleUpdater {
        public Updater(IObjectSpace objectSpace, Version currentDBVersion) : base(objectSpace, currentDBVersion) { }
        public override void UpdateDatabaseAfterUpdateSchema() {
            base.UpdateDatabaseAfterUpdateSchema();
            CreateOrder("0001", true, DateTime.Now);
            CreateOrder("0002", true, DateTime.Now.AddDays(-1));
            CreateOrder("0003", false, DateTime.Now.AddDays(-2));
            CreateOrder("0004", false, DateTime.Now);
            CreateOrder("0005", true, DateTime.Now.AddDays(-3));
        }
        private void CreateOrder(string orderNo, bool isActive, DateTime date) {
            Order order = ObjectSpace.FindObject<Order>(new BinaryOperator("OrderNo", orderNo));
            if (order == null) {
                order = ObjectSpace.CreateObject<Order>();
                order.OrderNo = orderNo;
                order.Active = isActive;
                order.Date = date;
            }
        }
    }
}
