Imports System
Imports System.Windows.Forms
Imports System.Data
Imports DevExpress.Data
Imports DevExpress.XtraGrid

Namespace HideableGroupRowFooters

    Public Partial Class Form1
        Inherits Form

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs)
            myGridControl1.DataSource = CreateTable(30)
            GroupColumns()
            SetSummaryItems()
        End Sub

        Private Function CreateTable(ByVal RowCount As Integer) As DataTable
            Dim tbl As DataTable = New DataTable()
            tbl.Columns.Add("Category", GetType(String))
            tbl.Columns.Add("Vendor", GetType(String))
            tbl.Columns.Add("Model", GetType(String))
            tbl.Columns.Add("HasSmth", GetType(String))
            tbl.Columns.Add("NumOfSmth", GetType(Integer))
            For i As Integer = 0 To RowCount - 1
                Dim r As Integer = New Random(i).Next(0, 10)
                Dim hasSmth As String = If(r <= 5, "Yes", "No")
                r = New Random(i).Next(0, 10)
                Dim cat As String = If(r <= 5, "Cat1", "Cat2")
                r = New Random(i).Next(0, 4)
                tbl.Rows.Add(New Object() {cat, String.Format("Vendor {0}", r), String.Format("Model {0}", i), hasSmth, i})
            Next

            Return tbl
        End Function

        Private Sub GroupColumns()
            myGridView1.Columns("Category").Group()
            myGridView1.Columns("Vendor").Group()
            myGridView1.Columns("HasSmth").Group()
            myGridView1.ExpandAllGroups()
        End Sub

        Private Sub SetSummaryItems()
            Dim item As GridGroupSummaryItem = New GridGroupSummaryItem()
            item.FieldName = "Model"
            item.SummaryType = SummaryItemType.Count
            item.ShowInGroupColumnFooter = myGridView1.Columns("Model")
            myGridView1.GroupSummary.Add(item)
            Dim item1 As GridGroupSummaryItem = New GridGroupSummaryItem()
            item1.FieldName = "NumOfSmth"
            item1.DisplayFormat = "{0:f3}"
            item1.SummaryType = SummaryItemType.Average
            item1.ShowInGroupColumnFooter = myGridView1.Columns("NumOfSmth")
            myGridView1.GroupSummary.Add(item1)
        End Sub

        Private Sub gridViewOverride1_ShowGroupFooter(ByVal sender As Object, ByVal e As ShowGroupFooterEventArgs)
            If e.FooterLevel = spinEdit1.Value AndAlso checkEdit1.Checked Then e.Visible = False
        End Sub

        Private Sub checkEdit1_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            myGridView1.LayoutChanged()
        End Sub

        Private Sub spinEdit1_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            myGridView1.LayoutChanged()
        End Sub

        Private Sub gridViewOverride1_EndGrouping(ByVal sender As Object, ByVal e As EventArgs)
            Dim maxLevel As Integer = 0
            For i As Integer = 0 To myGridView1.GroupedColumns.Count - 1
                If myGridView1.GroupedColumns(i).GroupIndex > maxLevel Then maxLevel = myGridView1.GroupedColumns(i).GroupIndex
            Next

            spinEdit1.Properties.MaxValue = maxLevel + 1
        End Sub
    End Class
End Namespace
