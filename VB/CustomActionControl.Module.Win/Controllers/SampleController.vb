Imports DevExpress.Data.Filtering
Imports DevExpress.ExpressApp
Imports DevExpress.Persistent.Base

Namespace CustomActionControl.Module.Win.Controllers
    Public Class SampleController
        Inherits ObjectViewController(Of ListView, Order)

        Public Sub New()
            Dim activeFilterAction As New CheckableSimpleAction(Me, "ActiveFilterAction", PredefinedCategory.Filters)
            activeFilterAction.Caption = "Active"
            AddHandler activeFilterAction.Execute, AddressOf activeFilterAction_Execute
            Dim todayFilterAction As New CheckableSimpleAction(Me, "TodayFilterAction", PredefinedCategory.Filters)
            todayFilterAction.Caption = "Today"
            AddHandler todayFilterAction.Execute, AddressOf todayFilterAction_Execute
        End Sub
        Private Sub activeFilterAction_Execute(ByVal sender As Object, ByVal e As DevExpress.ExpressApp.Actions.SimpleActionExecuteEventArgs)
            Dim applyFilter As Boolean = DirectCast(sender, CheckableSimpleAction).Checked
            If applyFilter Then
                View.CollectionSource.Criteria("IsActive") = New OperandProperty("Active")
            Else
                View.CollectionSource.Criteria.Remove("IsActive")
            End If
        End Sub
        Private Sub todayFilterAction_Execute(ByVal sender As Object, ByVal e As DevExpress.ExpressApp.Actions.SimpleActionExecuteEventArgs)
            Dim applyFilter As Boolean = DirectCast(sender, CheckableSimpleAction).Checked
            If applyFilter Then
                View.CollectionSource.Criteria("IsToday") = New FunctionOperator(FunctionOperatorType.IsOutlookIntervalToday, New OperandProperty("Date"))
            Else
                View.CollectionSource.Criteria.Remove("IsToday")
            End If
        End Sub
    End Class
End Namespace
