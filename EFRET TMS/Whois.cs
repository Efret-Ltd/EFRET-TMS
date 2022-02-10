using System;
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

    }
  }
   
}
