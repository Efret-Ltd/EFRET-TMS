using System;
using Telerik.WinControls;
using Whois;
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
            QueryByDomain();
        } 
        private  void QueryByDomain()
    {
        // Create a WhoisLookup instance
        var whois = new WhoisLookup();
        var response = whois.Lookup(textEdit1.Text);
        // Output the response
        RadMessageBox.Show(response.Content);

    }
  }
   
}
