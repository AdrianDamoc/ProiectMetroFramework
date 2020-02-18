namespace WindowsFormsApp2
{
    partial class Inregistrare
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.utilizatorboxinreg = new MetroFramework.Controls.MetroTextBox();
            this.parolaboxinreg = new MetroFramework.Controls.MetroTextBox();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // utilizatorboxinreg
            // 
            this.utilizatorboxinreg.CustomBackground = true;
            this.utilizatorboxinreg.CustomForeColor = true;
            this.utilizatorboxinreg.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.utilizatorboxinreg.Location = new System.Drawing.Point(168, 77);
            this.utilizatorboxinreg.Name = "utilizatorboxinreg";
            this.utilizatorboxinreg.PromptText = "Utilizator";
            this.utilizatorboxinreg.Size = new System.Drawing.Size(452, 50);
            this.utilizatorboxinreg.Style = MetroFramework.MetroColorStyle.Blue;
            this.utilizatorboxinreg.TabIndex = 3;
            this.utilizatorboxinreg.Theme = MetroFramework.MetroThemeStyle.Light;
            this.utilizatorboxinreg.UseStyleColors = true;
            // 
            // parolaboxinreg
            // 
            this.parolaboxinreg.CustomBackground = true;
            this.parolaboxinreg.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.parolaboxinreg.Location = new System.Drawing.Point(168, 197);
            this.parolaboxinreg.Name = "parolaboxinreg";
            this.parolaboxinreg.PasswordChar = '*';
            this.parolaboxinreg.PromptText = "Parola";
            this.parolaboxinreg.Size = new System.Drawing.Size(452, 50);
            this.parolaboxinreg.Style = MetroFramework.MetroColorStyle.Blue;
            this.parolaboxinreg.TabIndex = 4;
            this.parolaboxinreg.Theme = MetroFramework.MetroThemeStyle.Light;
            this.parolaboxinreg.UseStyleColors = true;
            // 
            // metroTile1
            // 
            this.metroTile1.Location = new System.Drawing.Point(309, 306);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(163, 54);
            this.metroTile1.TabIndex = 5;
            this.metroTile1.Text = "Register";
            this.metroTile1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile1.Click += new System.EventHandler(this.metroTile1_Click);
            // 
            // Inregistrare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.metroTile1);
            this.Controls.Add(this.parolaboxinreg);
            this.Controls.Add(this.utilizatorboxinreg);
            this.Name = "Inregistrare";
            this.Text = "Inregistrare";
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox utilizatorboxinreg;
        private MetroFramework.Controls.MetroTextBox parolaboxinreg;
        private MetroFramework.Controls.MetroTile metroTile1;
    }
}