Imports System
Imports System.ComponentModel
Imports DevExpress.ExpressApp
Imports DevExpress.ExpressApp.Actions
Imports DevExpress.Persistent.Base

Namespace CustomActionControl.Module
    Public Class CheckableSimpleAction
        Inherits SimpleAction

        Private _Checked As Boolean = False
        Private Sub OnCheckedStateChanged()
            RaiseEvent CheckedStateChanged(Me, EventArgs.Empty)
        End Sub
        Public Sub New(ByVal container As IContainer)
            MyBase.New(container)
        End Sub
        Public Sub New(ByVal owner As Controller, ByVal id As String, ByVal category As PredefinedCategory)
            MyBase.New(owner, id, category)
        End Sub
        Public Property Checked() As Boolean
            Get
                Return _Checked
            End Get
            Set(ByVal value As Boolean)
                If _Checked <> value Then
                    _Checked = value
                    OnCheckedStateChanged()
                    If Enabled.ResultValue AndAlso Active.ResultValue Then
                        DoExecute()
                    End If
                End If
            End Set
        End Property
        Public Event CheckedStateChanged As EventHandler
    End Class
End Namespace
