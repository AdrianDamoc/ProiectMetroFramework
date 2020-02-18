using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand command;
                SqlDataAdapter adapter = new SqlDataAdapter();

                string connetionString;
                SqlConnection cnn;
                connetionString = @"Data Source=82.208.137.149\sqlexpress,8833;Initial Catalog=proba_transare;Persist Security Info=True;User ID=sa;Password=pro";
                cnn = new SqlConnection(connetionString);

                cnn.Open();

                string sql = "Select utilizator,parola from Tabel_Utilizatori where utilizator = '" + utilizatorbox.Text + "' and parola ='" + parolabox.Text + "'";


                command = new SqlCommand(sql, cnn);



                String strResult = String.Empty;
                // int length = strResult.Length;
                strResult = (String)command.ExecuteScalar();

                if (strResult == null)
                {

                    MessageBox.Show("Date incorecte");

                }
                else
                {
                    MessageBox.Show("Te-ai logat");
                    this.Hide();
                    var SelectieAsociatie = new SelectieAsociatie();
                    SelectieAsociatie.Show();


                }


                command.Dispose();




                cnn.Close();
            }
            catch (SqlException)
            {
                MessageBox.Show("Nu ai conexiune la internet");
            }
            

           
            
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var Inregistrare = new Inregistrare();
            Inregistrare.Show();
        }

        private void metroTile2_MouseHover(object sender, EventArgs e)
        {
           
        }
    }
}
