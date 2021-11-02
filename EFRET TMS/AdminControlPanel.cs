using System;
using System.Windows.Forms;
using DevExpress.Utils.Extensions;

namespace EFRET_TMS
{
    public partial class AdminControlPanel : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        /*
        private CompanyData_UC CDUC = new CompanyData_UC();
        
        private UserManager UMUC = new UserManager();
        */

        public AdminControlPanel()
        {
            InitializeComponent();
        }

        private void accordionControlElement3_Click(object sender, EventArgs e)
        {
            
        }

        private void AdminControlPanel_Load(object sender, EventArgs e)
        {

        }

        private void accordionControlElement15_Click(object sender, EventArgs e)
        {
            /*
           fluentDesignFormContainer1.Controls.Clear();
           CDUC.Dock = DockStyle.Fill;
           fluentDesignFormContainer1.Controls.Add(CDUC);
            */
       }

       private void accordionControlElement16_Click(object sender, EventArgs e)
       {

       }

       private void accordionControlElement19_Click(object sender, EventArgs e)
       {

       }


       //User Groups
       private void accordionControlElement9_Click(object sender, EventArgs e)
       {
           //TODO: Update user Groups UserControl
            fluentDesignFormContainer1.Controls.Clear();

        }


        //User Roles
        private void accordionControlElement10_Click(object sender, EventArgs e)
          {
            //TODO: Update Roles UserControl
            fluentDesignFormContainer1.Controls.Clear();
        }

        private void accordionControlElement8_Click(object sender, EventArgs e)
        {

        }
        //Active Users UC
        //TODO: Update Active Users UserControl
        private void accordionControlElement14_Click(object sender, EventArgs e)
        {
           fluentDesignFormContainer1.Controls.Clear();
        }
    }
}
