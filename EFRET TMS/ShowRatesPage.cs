using DevExpress.XtraEditors;
using System;
using System.Windows.Forms;

namespace EFRET_TMS
{
    public partial class ShowRatesPage : XtraForm
    {
        public ShowRatesPage()
        {
            InitializeComponent();

            var url =
                "https://www.netdania.com/Products/FullQuote/FullQuote.aspx?symbol=GBPEUR&provider=netdania_fxa&ext=false&d=netdania_forex_lf";
            this.webBrowser1.Navigate(url);
            ScrollToElement("chartText");

        }

        private void ScrollToElement(String elemName)
        {
            if (webBrowser1.Document != null)
            {
                HtmlDocument doc = webBrowser1.Document;
                HtmlElementCollection elems = doc.All.GetElementsByName(elemName);
                if (elems != null && elems.Count > 0)
                {
                    HtmlElement elem = elems[0];

                    elem.ScrollIntoView(true);
                }
            }
        }
        void windowsUIButtonPanel_ButtonClick(object sender, DevExpress.XtraBars.Docking2010.ButtonEventArgs e)
        {
            if (e.Button.Properties.Caption == "Print")
            {
            }
        }


    }
}
