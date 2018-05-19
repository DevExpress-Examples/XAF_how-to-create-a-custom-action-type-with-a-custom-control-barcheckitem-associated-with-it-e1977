Imports System
Imports DevExpress.ExpressApp.Templates.ActionControls.Binding

Namespace CustomActionControl.Module.Win.ActionControls
    Public Class CheckableSimpleActionBinding
        Inherits ActionBinding

        Private Sub Action_CheckedStateChanged(ByVal sender As Object, ByVal e As EventArgs)
            ActionControl.Checked = Action.Checked
        End Sub
        Private Sub ActionControl_Execute(ByVal sender As Object, ByVal e As EventArgs)
            Action.Checked = Not Action.Checked
        End Sub
        Public Sub New(ByVal action As CheckableSimpleAction, ByVal actionControl As BarCheckItemCheckableSimpleActionControl)
            MyBase.New(action, actionControl)
            AddHandler Me.ActionControl.Execute, AddressOf ActionControl_Execute
            AddHandler Me.Action.CheckedStateChanged, AddressOf Action_CheckedStateChanged
            Me.ActionControl.Checked = Me.Action.Checked
        End Sub
        Public Overrides Sub Dispose()
            RemoveHandler ActionControl.Execute, AddressOf ActionControl_Execute
            RemoveHandler Action.CheckedStateChanged, AddressOf Action_CheckedStateChanged
            MyBase.Dispose()
        End Sub
        Public Shadows ReadOnly Property Action() As CheckableSimpleAction
            Get
                Return CType(MyBase.Action, CheckableSimpleAction)
            End Get
        End Property
        Public Shadows ReadOnly Property ActionControl() As BarCheckItemCheckableSimpleActionControl
            Get
                Return CType(MyBase.ActionControl, BarCheckItemCheckableSimpleActionControl)
            End Get
        End Property
    End Class
End Namespace
