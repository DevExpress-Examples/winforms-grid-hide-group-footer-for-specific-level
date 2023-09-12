Imports System

Namespace HideableGroupRowFooters

    Public Delegate Sub ShowGroupFooterEventHandler(ByVal sender As Object, ByVal e As ShowGroupFooterEventArgs)

    Public Class ShowGroupFooterEventArgs
        Inherits EventArgs

        Private footerLevelField As Integer

        Private footerVisible As Boolean

        Public Sub New(ByVal aFooterLevel As Integer)
            MyBase.New()
            footerVisible = True
            footerLevelField = aFooterLevel
        End Sub

        Public ReadOnly Property FooterLevel As Integer
            Get
                Return footerLevelField
            End Get
        End Property

        Public Property Visible As Boolean
            Get
                Return footerVisible
            End Get

            Set(ByVal value As Boolean)
                footerVisible = value
            End Set
        End Property
    End Class
End Namespace
