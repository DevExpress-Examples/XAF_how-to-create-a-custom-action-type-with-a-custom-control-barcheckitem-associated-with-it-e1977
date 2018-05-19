Imports System
Imports CustomActionControl.Module.Win.ActionControls
Imports DevExpress.ExpressApp
Imports DevExpress.ExpressApp.SystemModule
Imports DevExpress.ExpressApp.Templates.ActionControls
Imports DevExpress.ExpressApp.Templates.ActionControls.Binding
Imports DevExpress.ExpressApp.Win.Templates.Bars.ActionControls
Imports DevExpress.ExpressApp.Win.Templates.Ribbon.ActionControls
Imports DevExpress.XtraBars

Namespace CustomActionControl.Module.Win.Controllers
    Public Class CustomActionControlController
        Inherits WindowController

        Private Sub actionControlsSiteController_CustomAddActionControlToContainer(ByVal sender As Object, ByVal e As CustomAddActionControlEventArgs)
            If TypeOf e.Action Is CheckableSimpleAction Then
                If TypeOf e.Container Is BarLinkActionControlContainer Then
                    Dim container As BarLinkActionControlContainer = CType(e.Container, BarLinkActionControlContainer)
                    Dim actionControl As IActionControl = CreateActionControl(e.Action.Id, container.BarContainerItem)
                    container.AddActionControl(actionControl)
                    e.Handled = True
                End If
                If TypeOf e.Container Is RibbonGroupActionControlContainer Then
                    Dim container As RibbonGroupActionControlContainer = CType(e.Container, RibbonGroupActionControlContainer)
                    Dim actionControl As IActionControl = CreateActionControl(e.Action.Id, container.RibbonGroup.ItemLinks)
                    container.AddActionControl(actionControl)
                    e.Handled = True
                End If
            End If
        End Sub
        Private Function CreateActionControl(ByVal id As String, ByVal barLinksHolder As BarLinksHolder) As BarCheckItemCheckableSimpleActionControl
            Dim barCheckItem As New BarCheckItem(barLinksHolder.Manager)
            barCheckItem.CausesValidation = True
            barLinksHolder.AddItem(barCheckItem)
            Return New BarCheckItemCheckableSimpleActionControl(id, barCheckItem)
        End Function
        Private Sub actionControlsSiteController_CustomBindActionControlToAction(ByVal sender As Object, ByVal e As CustomBindEventArgs)
            If TypeOf e.Action Is CheckableSimpleAction AndAlso TypeOf e.ActionControl Is BarCheckItemCheckableSimpleActionControl Then
                e.Binding = New CheckableSimpleActionBinding(CType(e.Action, CheckableSimpleAction), CType(e.ActionControl, BarCheckItemCheckableSimpleActionControl))
            End If
        End Sub
        Protected Overrides Sub OnActivated()
            MyBase.OnActivated()
            Dim actionControlsSiteController As ActionControlsSiteController = Frame.GetController(Of ActionControlsSiteController)()
            If actionControlsSiteController IsNot Nothing Then
                AddHandler actionControlsSiteController.CustomAddActionControlToContainer, AddressOf actionControlsSiteController_CustomAddActionControlToContainer
                AddHandler actionControlsSiteController.CustomBindActionControlToAction, AddressOf actionControlsSiteController_CustomBindActionControlToAction
            End If
        End Sub
        Protected Overrides Sub OnDeactivated()
            Dim actionControlsSiteController As ActionControlsSiteController = Frame.GetController(Of ActionControlsSiteController)()
            If actionControlsSiteController IsNot Nothing Then
                RemoveHandler actionControlsSiteController.CustomAddActionControlToContainer, AddressOf actionControlsSiteController_CustomAddActionControlToContainer
                RemoveHandler actionControlsSiteController.CustomBindActionControlToAction, AddressOf actionControlsSiteController_CustomBindActionControlToAction
            End If
            MyBase.OnDeactivated()
        End Sub
    End Class
End Namespace
