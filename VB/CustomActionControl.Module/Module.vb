Imports System
Imports System.Collections.Generic
Imports DevExpress.ExpressApp
Imports DevExpress.ExpressApp.Updating
Imports DevExpress.Persistent.BaseImpl
Imports DevExpress.Data.Filtering

Namespace CustomActionControl.Module
    Public NotInheritable Partial Class CustomActionControlModule
        Inherits ModuleBase

        Public Sub New()
            InitializeComponent()
            BaseObject.OidInitializationMode = OidInitializationMode.AfterConstruction
        End Sub
        Public Overrides Function GetModuleUpdaters(ByVal objectSpace As IObjectSpace, ByVal versionFromDB As Version) As IEnumerable(Of ModuleUpdater)
            Dim updater As ModuleUpdater = New Updater(objectSpace, versionFromDB)
            Return New ModuleUpdater() { updater }
        End Function
    End Class
    Public Class Updater
        Inherits ModuleUpdater

        Public Sub New(ByVal objectSpace As IObjectSpace, ByVal currentDBVersion As Version)
            MyBase.New(objectSpace, currentDBVersion)
        End Sub
        Public Overrides Sub UpdateDatabaseAfterUpdateSchema()
            MyBase.UpdateDatabaseAfterUpdateSchema()
            CreateOrder("0001", True, Date.Now)
            CreateOrder("0002", True, Date.Now.AddDays(-1))
            CreateOrder("0003", False, Date.Now.AddDays(-2))
            CreateOrder("0004", False, Date.Now)
            CreateOrder("0005", True, Date.Now.AddDays(-3))
        End Sub
        Private Sub CreateOrder(ByVal orderNo As String, ByVal isActive As Boolean, ByVal [date] As Date)
            Dim order As Order = ObjectSpace.FindObject(Of Order)(New BinaryOperator("OrderNo", orderNo))
            If order Is Nothing Then
                order = ObjectSpace.CreateObject(Of Order)()
                order.OrderNo = orderNo
                order.Active = isActive
                order.Date = [date]
            End If
        End Sub
    End Class
End Namespace
