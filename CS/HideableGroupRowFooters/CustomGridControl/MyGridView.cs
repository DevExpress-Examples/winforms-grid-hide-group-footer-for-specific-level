using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;

namespace HideableGroupRowFooters
{
	public class MyGridView : GridView
	{
		public MyGridView(GridControl ownerGrid)
			: base(ownerGrid)
		{
		}
		public MyGridView()
			: base()
		{
		}

		internal void RaiseViewInfoShowGroupFooter(object sender, ShowGroupFooterEventArgs e)
		{
			if ( ShowGroupFooter != null )
				ShowGroupFooter(sender, e);
		}

		protected override string ViewName
		{
			get
			{
				return "MyGridView";
			}
		}

		public event ShowGroupFooterEventHandler ShowGroupFooter;
	}
}