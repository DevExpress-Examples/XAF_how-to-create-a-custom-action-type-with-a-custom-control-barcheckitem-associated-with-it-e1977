Imports System
Imports System.Linq
Imports System.Text
Imports DevExpress.Xpo
Imports DevExpress.ExpressApp
Imports System.ComponentModel
Imports DevExpress.ExpressApp.DC
Imports DevExpress.Data.Filtering
Imports DevExpress.Persistent.Base
Imports System.Collections.Generic
Imports DevExpress.ExpressApp.Model
Imports DevExpress.Persistent.BaseImpl
Imports DevExpress.Persistent.Validation

Namespace CustomActionControl.Module
    <DefaultClassOptions> _
    Public Class Order
        Inherits BaseObject

        Public Sub New(ByVal session As Session)
            MyBase.New(session)
        End Sub
        Private _OrderNo As String
        Public Property OrderNo() As String
            Get
                Return _OrderNo
            End Get
            Set(ByVal value As String)
                SetPropertyValue("OrderNo", _OrderNo, value)
            End Set
        End Property
        Private _Active As Boolean
        Public Property Active() As Boolean
            Get
                Return _Active
            End Get
            Set(ByVal value As Boolean)
                SetPropertyValue("Active", _Active, value)
            End Set
        End Property
        Private _Date As Date
        Public Property [Date]() As Date
            Get
                Return _Date
            End Get
            Set(ByVal value As Date)
                SetPropertyValue("Date", _Date, value)
            End Set
        End Property
    End Class
End Namespace
