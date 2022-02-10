using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using Telerik.WinControls.UI;
using Telerik.WinControls.UI.TaskBoard;
namespace EFRET_TMS
{
    public partial class TasksBoard : RadForm
    {
        private RadTaskCardElement card = new RadTaskCardElement();
        private RadTaskBoardColumnElement c1 = new RadTaskBoardColumnElement();
        private RadTaskBoardColumnElement c2 = new RadTaskBoardColumnElement();
        private RadTaskBoardColumnElement c3 = new RadTaskBoardColumnElement();
        public TasksBoard()
        {
            InitializeComponent();
            boardInit();
        }

        public void createCards(string NewCO, string IdContractHolder)
        {
            card.TitleText = NewCO; //NewCO.NewCO
            card.DescriptionText = IdContractHolder; //NewCO.Company
            card.AccentSettings.Color = Color.Red;
        }

        public void boardInit()
        {
            c1.Title = "Booked Orders";
            c1.Subtitle = "CO's awaiting shipment.";
            c2.Title = "In Transit";
            c2.Subtitle = "CO's with Movement";
            c3.Title = "Transit Complete";
            c3.Subtitle = "CO's with Complete Movement";

            this.radTaskBoard1.Columns.Add(c1);
            this.radTaskBoard1.Columns.Add(c2);
            this.radTaskBoard1.Columns.Add(c3);

            string connectionString = @"Server=EFRET-APP-01\EFRET;Database=axs;Trusted_Connection=True;";
            SqlConnection conn = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("SELECT TOP (10) * FROM NEWCO", conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                var NewCO = dr["NewCO"].ToString();
                var ContractHolder = dr["IdContractHolder"].ToString();
                var UserOwner = dr["UserOwner"].ToString();
                createCards(NewCO,ContractHolder);
                foreach (DataRow record in dt.Rows)
                {
                    c1.TaskCardCollection.Add(card);
                }
            }

            conn.Close();

        }

    }
}