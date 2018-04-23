using System;

namespace HideableGroupRowFooters
{
	public delegate void ShowGroupFooterEventHandler(object sender, ShowGroupFooterEventArgs e);

	public class ShowGroupFooterEventArgs : EventArgs
	{
		private int footerLevel;
        private bool footerVisible;

		public ShowGroupFooterEventArgs(int aFooterLevel)
			: base()
		{
			footerVisible = true;
			footerLevel = aFooterLevel;
		}

		public int FooterLevel
		{
			get
			{
				return footerLevel;
			}
		}

        public bool Visible
        {
            get
            {
                return footerVisible;
            }
            set
            {
                footerVisible = value;
            }
        }
	}
}
