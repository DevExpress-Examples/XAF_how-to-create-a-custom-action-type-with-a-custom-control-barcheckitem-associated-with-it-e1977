Imports DevExpress.ExpressApp.Win.Templates
Imports DevExpress.XtraBars

Namespace CustomActionControl.Module.Win.ActionItems
    Public Class CustomBarActionItemsFactoryProvider
        Implements IBarActionItemsFactoryProvider

        Public Function CreateBarActionItemsFactory(barManager As BarManager) As BarActionItemsFactory Implements IBarActionItemsFactoryProvider.CreateBarActionItemsFactory
            Return New CustomBarActionItemsFactory(barManager)
        End Function
    End Class
End Namespace
