using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
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

        // Query github.com
        var response = whois.Lookup(textEdit1.Text);

        // Output the response
        RadMessageBox.Show(response.Content);


    }
    }
   
}
