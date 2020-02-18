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

        private void metroTile1_Click_1(object sender, EventArgs e)
        {
            // sablon creare butoane meniu principal
            // adaugare  id tag
            PanelRibbon1.ColumnCount +=1;
            MetroFramework.Controls.MetroTile Altadenumire;
            Altadenumire = new MetroFramework.Controls.MetroTile();
            // ProprietariTile
            // 
           // Altadenumire.Location = new System.Drawing.Point(3, 2);
            Altadenumire.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            Altadenumire.Size = new System.Drawing.Size(146, 113);
            Altadenumire.TabIndex =2;
            Altadenumire.Name = "Altadenumire" + Altadenumire.TabIndex;
            Altadenumire.Text = Altadenumire.Name;
            Altadenumire.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            PanelRibbon1.Controls.Add(Altadenumire, 0, 0);
            //Altadenumire.Click += new System.EventHandler(DupaLogare_ClickPrincipal() );
            // 
           // Altadenumire.Location = new System.Drawing.Point(3, 2);
            Altadenumire.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            Altadenumire.Size = new System.Drawing.Size(146, 113);
            Altadenumire.TabIndex += 1;
            Altadenumire.Name = "Altadenumire" + Altadenumire.TabIndex;
            Altadenumire.Text = Altadenumire.Name;
            Altadenumire.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            PanelRibbon1.Controls.Add(Altadenumire, 0, 0);
           // Altadenumire.Click += new System.EventHandler(DupaLogare_ClickPrincipal());
        }

        private EventHandler DupaLogare_ClickPrincipal()
        {
            MessageBox.Show("M-ai apasat");
           throw new NotImplementedException();
        }
    }
}
