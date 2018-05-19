using DevExpress.ExpressApp.Win.Templates;
using DevExpress.XtraBars;

namespace CustomActionControl.Module.Win.ActionItems {
    public class CustomBarActionItemsFactoryProvider : IBarActionItemsFactoryProvider {
        public BarActionItemsFactory CreateBarActionItemsFactory(BarManager barManager) {
            return new CustomBarActionItemsFactory(barManager);
        }
    }
}
