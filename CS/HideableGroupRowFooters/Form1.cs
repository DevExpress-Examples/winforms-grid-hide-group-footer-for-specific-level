using System;
using System.Windows.Forms;
using System.Data;
using DevExpress.Data;
using DevExpress.XtraGrid;

namespace HideableGroupRowFooters
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
            myGridControl1.DataSource = CreateTable(30);
            GroupColumns();
            SetSummaryItems();
		}

        private DataTable CreateTable(int RowCount)
        {
            DataTable tbl = new DataTable();
            tbl.Columns.Add("Category", typeof(string));
            tbl.Columns.Add("Vendor", typeof(string));
            tbl.Columns.Add("Model", typeof(string));
            tbl.Columns.Add("HasSmth", typeof(string));
            tbl.Columns.Add("NumOfSmth", typeof(int));

            for (int i = 0; i < RowCount; i++)
            {
                int r = new Random(i).Next(0, 10);
                string hasSmth = r <= 5 ? "Yes" : "No";

                r = new Random(i).Next(0, 10);
                string cat = r <= 5 ? "Cat1" : "Cat2";

                r = new Random(i).Next(0, 4);
                tbl.Rows.Add(new object[] { cat, String.Format("Vendor {0}", r), String.Format("Model {0}", i), hasSmth, i });
            }

            return tbl;
        }

        private void GroupColumns()
        {
            myGridView1.Columns["Category"].Group();
            myGridView1.Columns["Vendor"].Group();
            myGridView1.Columns["HasSmth"].Group();

            myGridView1.ExpandAllGroups();
        }

        private void SetSummaryItems()
        {
            GridGroupSummaryItem item = new GridGroupSummaryItem();
            item.FieldName = "Model";
            item.SummaryType = DevExpress.Data.SummaryItemType.Count;
            item.ShowInGroupColumnFooter = myGridView1.Columns["Model"];
            myGridView1.GroupSummary.Add(item);

            GridGroupSummaryItem item1 = new GridGroupSummaryItem();
            item1.FieldName = "NumOfSmth";
            item1.DisplayFormat = "{0:f3}";
            item1.SummaryType = DevExpress.Data.SummaryItemType.Average;
            item1.ShowInGroupColumnFooter = myGridView1.Columns["NumOfSmth"];
            myGridView1.GroupSummary.Add(item1);
        }

        private void gridViewOverride1_ShowGroupFooter(object sender, ShowGroupFooterEventArgs e)
		{
			if ( e.FooterLevel == spinEdit1.Value && checkEdit1.Checked )
				e.Visible = false;
		}

		private void checkEdit1_CheckedChanged(object sender, EventArgs e)
		{
			myGridView1.LayoutChanged();
		}

		private void spinEdit1_EditValueChanged(object sender, EventArgs e)
		{
			myGridView1.LayoutChanged();
		}

		private void gridViewOverride1_EndGrouping(object sender, EventArgs e)
		{
			int maxLevel = 0;
			for ( int i = 0; i < myGridView1.GroupedColumns.Count; i++ )
			{
				if ( myGridView1.GroupedColumns[i].GroupIndex > maxLevel )
					maxLevel = myGridView1.GroupedColumns[i].GroupIndex;
			}

			spinEdit1.Properties.MaxValue = maxLevel + 1;
		}
	}
}

