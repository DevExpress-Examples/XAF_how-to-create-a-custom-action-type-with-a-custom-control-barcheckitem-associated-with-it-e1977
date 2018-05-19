Imports System
Imports DevExpress.ExpressApp.Win.Templates.Bars.ActionControls
Imports DevExpress.XtraBars

Namespace CustomActionControl.Module.Win.ActionControls
    Public Class BarCheckItemCheckableSimpleActionControl
        Inherits BarItemActionControl(Of BarCheckItem)

        Private Sub BarItem_ItemClick(ByVal sender As Object, ByVal args As ItemClickEventArgs)
            RaiseExecute()
        End Sub
        Protected Overrides Sub OnEndInit()
            MyBase.OnEndInit()
            AddHandler BarItem.ItemClick, AddressOf BarItem_ItemClick
        End Sub
        Protected Sub RaiseExecute()
            If IsConfirmed() Then
                RaiseEvent Execute(Me, EventArgs.Empty)
            End If
        End Sub
        Public Sub New()
        End Sub
        Public Sub New(ByVal actionId As String, ByVal item As BarCheckItem)
            MyBase.New(actionId, item)
        End Sub
        Public Property Checked() As Boolean
            Get
                Return BarItem.Checked
            End Get
            Set(ByVal value As Boolean)
                BarItem.Checked = value
            End Set
        End Property
        Public Event Execute As EventHandler(Of EventArgs)
    End Class
End Namespace
