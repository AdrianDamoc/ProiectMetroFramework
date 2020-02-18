namespace WindowsFormsApp2
{
    partial class Form1
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
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.metroTile2 = new MetroFramework.Controls.MetroTile();
            this.utilizatorbox = new MetroFramework.Controls.MetroTextBox();
            this.parolabox = new MetroFramework.Controls.MetroTextBox();
            this.SuspendLayout();
            // 
            // metroTile1
            // 
            this.metroTile1.Location = new System.Drawing.Point(471, 302);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(163, 54);
            this.metroTile1.TabIndex = 0;
            this.metroTile1.Text = "Register";
            this.metroTile1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile1.Click += new System.EventHandler(this.metroTile1_Click);
            // 
            // metroTile2
            // 
            this.metroTile2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.metroTile2.Location = new System.Drawing.Point(182, 302);
            this.metroTile2.Name = "metroTile2";
            this.metroTile2.Size = new System.Drawing.Size(163, 54);
            this.metroTile2.TabIndex = 1;
            this.metroTile2.Text = "Login";
            this.metroTile2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile2.UseTileImage = true;
            this.metroTile2.Click += new System.EventHandler(this.metroTile2_Click);
            this.metroTile2.MouseHover += new System.EventHandler(this.metroTile2_MouseHover);
            // 
            // utilizatorbox
            // 
            this.utilizatorbox.CustomBackground = true;
            this.utilizatorbox.CustomForeColor = true;
            this.utilizatorbox.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.utilizatorbox.Location = new System.Drawing.Point(182, 89);
            this.utilizatorbox.Name = "utilizatorbox";
            this.utilizatorbox.PromptText = "Utilizator";
            this.utilizatorbox.Size = new System.Drawing.Size(452, 50);
            this.utilizatorbox.Style = MetroFramework.MetroColorStyle.Blue;
            this.utilizatorbox.TabIndex = 2;
            this.utilizatorbox.Theme = MetroFramework.MetroThemeStyle.Light;
            this.utilizatorbox.UseStyleColors = true;
            // 
            // parolabox
            // 
            this.parolabox.CustomBackground = true;
            this.parolabox.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.parolabox.Location = new System.Drawing.Point(182, 199);
            this.parolabox.Name = "parolabox";
            this.parolabox.PasswordChar = '*';
            this.parolabox.PromptText = "Parola";
            this.parolabox.Size = new System.Drawing.Size(452, 50);
            this.parolabox.Style = MetroFramework.MetroColorStyle.Blue;
            this.parolabox.TabIndex = 3;
            this.parolabox.Theme = MetroFramework.MetroThemeStyle.Light;
            this.parolabox.UseStyleColors = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.parolabox);
            this.Controls.Add(this.utilizatorbox);
            this.Controls.Add(this.metroTile2);
            this.Controls.Add(this.metroTile1);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile metroTile1;
        private MetroFramework.Controls.MetroTile metroTile2;
        private MetroFramework.Controls.MetroTextBox utilizatorbox;
        private MetroFramework.Controls.MetroTextBox parolabox;
    }
}

