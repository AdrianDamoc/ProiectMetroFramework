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
    public partial class SelectieAsociatie : Form
    {
        public SelectieAsociatie()
        {
            InitializeComponent();
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var DupaLogare = new DupaLogare();
            DupaLogare.Show();
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            MetroFramework.Controls.MetroTile newmetroTile = new MetroFramework.Controls.MetroTile();
            newmetroTile.Name = "Asociatie2";
            newmetroTile.Text = "Asociatie2";
            newmetroTile.Size = new Size(345, 263);
            newmetroTile.TextAlign = ContentAlignment.MiddleCenter;
            newmetroTile.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            newmetroTile.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            AsociatieLayoutPanel.Controls.Add(newmetroTile);
            


        }
    }
}
