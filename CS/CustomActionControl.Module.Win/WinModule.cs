using System;
using System.Collections.Generic;
using System.ComponentModel;
using CustomActionControl.Module.Win.ActionItems;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Updating;
using DevExpress.ExpressApp.Win.Templates;

namespace CustomActionControl.Module.Win {
    [ToolboxItemFilter("Xaf.Platform.Win")]
    public sealed partial class CustomActionControlWindowsFormsModule : ModuleBase {
        public CustomActionControlWindowsFormsModule() {
            InitializeComponent();
            BarActionItemsFactoryProvider.Instance = new CustomBarActionItemsFactoryProvider();
        }
        public override IEnumerable<ModuleUpdater> GetModuleUpdaters(IObjectSpace objectSpace, Version versionFromDB) {
            return ModuleUpdater.EmptyModuleUpdaters;
        }
    }
}
