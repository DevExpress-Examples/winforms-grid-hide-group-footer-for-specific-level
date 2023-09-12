Imports System.Drawing
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo

Namespace HideableGroupRowFooters

    Public Class MyGridViewInfo
        Inherits GridViewInfo

        Public Sub New(ByVal gridView As MyGridView)
            MyBase.New(gridView)
        End Sub

        Protected Overrides Sub CalcRowFooterInfo(ByVal ri As GridRowInfo, ByVal row As GridRow, ByVal nextRow As GridRow)
            Dim height As Integer = ri.RowFooters.RowFootersHeight
            If height = 0 Then Return
            Dim isShowCurrentFooter As Boolean = IsShowCurrentRowFooter(ri)
            Dim startLevel As Integer = ri.Level
            Dim footerRowHandle As Integer = ri.RowHandle
            If Not ri.IsGroupRow OrElse Not isShowCurrentFooter Then footerRowHandle = View.GetParentRowHandle(footerRowHandle)
            If Not isShowCurrentFooter Then
                startLevel -= 1
            End If

            Dim top As Integer = ri.TotalBounds.Bottom - height - ri.RowSeparatorBounds.Height
            Dim left As Integer = ri.IndentRect.Right - If(Not isShowCurrentFooter, LevelIndent, 0)
            ri.RowFooters.Bounds = New Rectangle(left, top, ri.DataBounds.Right - left, height)
            For n As Integer = 0 To ri.RowFooters.RowFooterCount - 1
                Dim args As ShowGroupFooterEventArgs = New ShowGroupFooterEventArgs(startLevel)
                RaiseShowGroupFooter(args)
                If Not args.Visible Then
                    startLevel -= 1
                    left -= LevelIndent
                    ri.RowFooters.RowFooterCount += 1
                    footerRowHandle = View.GetParentRowHandle(footerRowHandle)
                    Continue For
                End If

                Dim fi As GridRowFooterInfo = New GridRowFooterInfo()
                ri.RowFooters.Add(fi)
                fi.RowHandle = footerRowHandle
                fi.Bounds = ri.Bounds
                fi.Level = startLevel
                fi.Bounds.Y = top
                fi.Bounds.X = left
                fi.Bounds.Width = ri.DataBounds.Right - fi.Bounds.Left
                fi.Bounds.Height = GroupFooterHeight
                top += fi.Bounds.Height
                If Not ri.IndicatorRect.IsEmpty Then
                    fi.IndicatorRect = ri.IndicatorRect
                    fi.IndicatorRect.Y = fi.Bounds.Y
                    fi.IndicatorRect.Height = fi.Bounds.Height
                End If

                If View.OptionsView.ShowHorzLines Then
                    ri.AddLineInfo(Nothing, fi.Bounds.Left, fi.Bounds.Bottom - 1, fi.Bounds.Width, 1, PaintAppearance.HorzLine)
                    fi.Bounds.Height -= 1
                End If

                CalcRowCellsFooterInfo(fi, ri)
                footerRowHandle = View.GetParentRowHandle(footerRowHandle)
                startLevel -= 1
                left -= LevelIndent
            Next
        End Sub

        Public Overrides Function GetRowFooterCount(ByVal rowHandle As Integer, ByVal rowVisibleIndex As Integer, ByVal isExpanded As Boolean) As Integer
            Dim initialVisibleFootersCount As Integer = MyBase.GetRowFooterCount(rowHandle, rowVisibleIndex, isExpanded)
            Dim visibleFootersCount As Integer = initialVisibleFootersCount
            Dim footerRowHandle As Integer = rowHandle
            For i As Integer = 0 To initialVisibleFootersCount - 1
                Dim args As ShowGroupFooterEventArgs = New ShowGroupFooterEventArgs(View.GetRowLevel(footerRowHandle))
                RaiseShowGroupFooter(args)
                If Not args.Visible Then visibleFootersCount -= 1
                footerRowHandle = View.GetParentRowHandle(footerRowHandle)
            Next

            Return visibleFootersCount
        End Function

        Private Sub RaiseShowGroupFooter(ByVal args As ShowGroupFooterEventArgs)
            Dim view As MyGridView = TryCast(Me.View, MyGridView)
            If view IsNot Nothing Then view.RaiseViewInfoShowGroupFooter(view, args)
        End Sub
    End Class
End Namespace
