Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Views.Grid

Namespace HideableGroupRowFooters

    Public Class MyGridView
        Inherits GridView

        Public Sub New(ByVal ownerGrid As GridControl)
            MyBase.New(ownerGrid)
        End Sub

        Public Sub New()
            MyBase.New()
        End Sub

        Friend Sub RaiseViewInfoShowGroupFooter(ByVal sender As Object, ByVal e As ShowGroupFooterEventArgs)
            RaiseEvent ShowGroupFooter(sender, e)
        End Sub

        Protected Overrides ReadOnly Property ViewName As String
            Get
                Return "MyGridView"
            End Get
        End Property

        Public Event ShowGroupFooter As ShowGroupFooterEventHandler
    End Class
End Namespace
