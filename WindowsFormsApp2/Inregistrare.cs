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
    public partial class Inregistrare : Form
    {
        public Inregistrare()
        {
            InitializeComponent();
        }

        private void metroTile1_Click(object sender, EventArgs e)
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
                string sql = "Insert into Tabel_Utilizatori (utilizator,parola) values" + " ('" + utilizatorboxinreg.Text + "','" + parolaboxinreg.Text + "')";

                command = new SqlCommand(sql, cnn);
                adapter.InsertCommand = new SqlCommand(sql, cnn);
                adapter.InsertCommand.ExecuteNonQuery();





                command.Dispose();
                cnn.Close();
                MessageBox.Show("Te-ai inregistrat!");
                this.Hide();
                var MainForm = new Form1();
                MainForm.Show();
            }
            catch (SqlException)
            {
                MessageBox.Show("Nu ai conexiune la internet");
            }
        }
    
    }
}

