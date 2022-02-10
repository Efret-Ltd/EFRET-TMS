using System;
using ComponentPro.Excel;
using ComponentPro.Net;
using Telerik.WinControls;
namespace EFRET_TMS
{
    public partial class Whois : Telerik.WinControls.UI.ShapedForm
    {
        public Whois()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            QueryByDomain(textEdit1.Text);
        } 
        private  void QueryByDomain(string domain)
    {
            // Create a WhoisLookup instance
            // Output the response
            WhoIsClient whois = new WhoIsClient();
            whois.Lookup(domain);
            whois.InvokeFromCurrentThreads = true;
    }
  }
   
}
