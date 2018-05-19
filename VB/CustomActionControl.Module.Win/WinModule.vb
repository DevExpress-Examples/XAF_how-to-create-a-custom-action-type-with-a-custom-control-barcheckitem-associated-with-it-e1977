Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports CustomActionControl.Module.Win.ActionItems
Imports DevExpress.ExpressApp
Imports DevExpress.ExpressApp.Updating
Imports DevExpress.ExpressApp.Win.Templates

Namespace CustomActionControl.Module.Win
    <ToolboxItemFilter("Xaf.Platform.Win")> _
    Public NotInheritable Partial Class CustomActionControlWindowsFormsModule
        Inherits ModuleBase

        Public Sub New()
            InitializeComponent()
            BarActionItemsFactoryProvider.Instance = New CustomBarActionItemsFactoryProvider()
        End Sub
        Public Overrides Function GetModuleUpdaters(ByVal objectSpace As IObjectSpace, ByVal versionFromDB As Version) As IEnumerable(Of ModuleUpdater)
            Return ModuleUpdater.EmptyModuleUpdaters
        End Function
    End Class
End Namespace
