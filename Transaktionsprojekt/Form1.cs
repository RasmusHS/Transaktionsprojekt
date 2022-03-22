using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using System.Text.Json;

namespace Transaktionsprojekt
{
    public partial class Form1 : Form
    {
        //string myConnectString = @"Data Source=RASMUS-LAPTOP; Initial Catalog=TransactionTest; Integrated Security=True; TrustServerCertificate=True";
        SqlConnection SqlConn = new SqlConnection(@"Data Source=RASMUS-LAPTOP; Initial Catalog=TransactionTest; Integrated Security=True; TrustServerCertificate=True");
        SqlDataReader dr;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SqlConn.Open();
            BindData();
        }

        public void BindData()
        {
            SqlCommand cmd = new SqlCommand("SELECT flightNo FROM FlightSeats2", SqlConn);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cmbBoxPickFlightNo.Items.Add(dr[0].ToString());
            }
            dr.Close();
        }

        private void btnReadUncommited_Click(object sender, EventArgs e)
        {
            string ReadUncommited = "READ UNCOMMITTED";
            String sqlString = "\nSET TRANSACTION ISOLATION LEVEL " + ReadUncommited;
            SqlCommand cmd = new SqlCommand(sqlString, SqlConn); 
            cmd.ExecuteNonQuery();

            sqlString = "BEGIN TRANSACTION";
            cmd = new SqlCommand(sqlString, SqlConn); 
            cmd.ExecuteNonQuery();

            sqlString = "SELECT seatsFree FROM FlightSeats2 WHERE flightNo =" + cmbBoxPickFlightNo.SelectedItem.ToString();

            cmd = new SqlCommand(sqlString, SqlConn);
            SqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            txtBoxFreeSeats.Text = "" + reader.GetInt32(0);
            reader.Close();
        }

        private void btnSerilazable_Click(object sender, EventArgs e)
        {
            string Serilazable = "SERIALIZABLE";
            String sqlString = "\nSET TRANSACTION ISOLATION LEVEL " + Serilazable;
            SqlCommand cmd = new SqlCommand(sqlString, SqlConn);
            cmd.ExecuteNonQuery();

            sqlString = "BEGIN TRANSACTION";
            cmd = new SqlCommand(sqlString, SqlConn);
            cmd.ExecuteNonQuery();

            sqlString = "SELECT seatsFree FROM FlightSeats2 WHERE flightNo =" + cmbBoxPickFlightNo.SelectedItem.ToString();

            cmd = new SqlCommand(sqlString, SqlConn);
            SqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            txtBoxFreeSeats.Text = "" + reader.GetInt32(0);
            reader.Close();

        }

        private void btnReserveSeats_Click(object sender, EventArgs e)
        {

        }
    }
}
