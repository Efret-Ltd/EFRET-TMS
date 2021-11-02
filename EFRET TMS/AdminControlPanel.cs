using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.Utils.Extensions;

namespace EFRET_TMS
{
    public partial class AdminControlPanel : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        /*
        private CompanyData_UC CDUC = new CompanyData_UC();
        private Roles_UC RolesUC = new Roles_UC();
        private UserManager UMUC = new UserManager();
        private ActiveUsersUC AUUC = new ActiveUsersUC();
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
           /*
                     fluentDesignFormContainer1.Controls.Clear();
                     RolesUC.Dock = DockStyle.Fill;
                     fluentDesignFormContainer1.Controls.Add(RolesUC);
           */
        }


        //User Roles
        private void accordionControlElement10_Click(object sender, EventArgs e)
          {
              /*

                      fluentDesignFormContainer1.Controls.Clear();
                      RolesUC.Dock = DockStyle.Fill;
                      UMUC.TopLevel = false;
              fluentDesignFormContainer1.Controls.Add(RolesUC);

              */


        }

        private void accordionControlElement8_Click(object sender, EventArgs e)
        {
         //   fluentDesignFormContainer1.Controls.Clear();
            //UMUC.Dock = DockStyle.Fill;
        //    UMUC.TopLevel = false;
           /// fluentDesignFormContainer1.AddControl(UMUC);
        }
        //Active Users UC
        private void accordionControlElement14_Click(object sender, EventArgs e)
        {
           // fluentDesignFormContainer1.Controls.Clear();
           // AUUC.Dock = DockStyle.Fill;
           // fluentDesignFormContainer1.AddControl(AUUC);
        }
    }
}
