using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class DupaLogare : Form
    {
        public DupaLogare()
        {
            InitializeComponent();
            PanelProprietari.Visible = false;
            PanelRibbon2.Visible = false;
            PanelLateralPropr.Visible = false;
            
            
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            if (PanelProprietari.Visible == false)
            {
               
                PanelProprietari.Visible = true;
                PanelLateralPropr.Visible = true;
            }
            else
            {
                PanelProprietari.Visible = false;
                PanelLateralPropr.Visible = false;

            }


        }
        
        private void DupaLogare_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'proba_transareDataSet2.and_articole' table. You can move, or remove it, as needed.
            this.and_articoleTableAdapter.Fill(this.proba_transareDataSet2.and_articole);
            // TODO: This line of code loads data into the 'proba_transareDataSet1.TIPURI' table. You can move, or remove it, as needed.
            this.tIPURITableAdapter.Fill(this.proba_transareDataSet1.TIPURI);
            // TODO: This line of code loads data into the 'proba_transareDataSet.Tabel_Utilizatori' table. You can move, or remove it, as needed.
            this.tabel_UtilizatoriTableAdapter.Fill(this.proba_transareDataSet.Tabel_Utilizatori);

        }

        private void MaimulteRibbon_Click(object sender, EventArgs e)
        {
            PanelContainerRibbon1.Visible = false;
            PanelRibbon2.Visible = true;

        }

        private void metroTile8_Click(object sender, EventArgs e)
        {
            
            PanelRibbon2.Visible = false;
            PanelContainerRibbon1.Visible = true;
            
        }

        private void metroTile3_Click(object sender, EventArgs e)
        {

        }

        private void SalvareInBaza_Click(object sender, EventArgs e)
        {
           try
            {
                tabelUtilizatoriBindingSource.EndEdit();
                tabel_UtilizatoriTableAdapter.Update(this.proba_transareDataSet);
                while (BaraProgresSalvare.Value < 100)
                {
                   // BaraProgresSalvare.Step = 10;
                    BaraProgresSalvare.Increment(10);
                }
                if (BaraProgresSalvare.Maximum == 100)
                {
                    MessageBox.Show("Ai inserat in baza de date");
                }

            }

            catch(Exception)
            {
                while (BaraProgresSalvare.Value < 100)
                {
                   // BaraProgresSalvare.Step = 10;
                    BaraProgresSalvare.Increment(10);
                }
                if (BaraProgresSalvare.Value == 100)
                {
                    MessageBox.Show("Eroare conexiune internet");
                   
                }
                
            }
        }
    }
}
