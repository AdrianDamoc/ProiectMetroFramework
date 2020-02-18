namespace WindowsFormsApp2
{
    partial class DupaLogare
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
            this.components = new System.ComponentModel.Container();
            this.ProprietariTile = new MetroFramework.Controls.MetroTile();
            this.PanelRibbon1 = new System.Windows.Forms.TableLayoutPanel();
            this.MaimulteRibbon = new MetroFramework.Controls.MetroTile();
            this.PanelContainerRibbon1 = new System.Windows.Forms.Panel();
            this.PanelRibbon2 = new System.Windows.Forms.TableLayoutPanel();
            this.metroTile6 = new MetroFramework.Controls.MetroTile();
            this.metroTile7 = new MetroFramework.Controls.MetroTile();
            this.metroTile8 = new MetroFramework.Controls.MetroTile();
            this.PanelProprietari = new System.Windows.Forms.Panel();
            this.Proprietari = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.utilizatorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.parolaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabelUtilizatoriBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.proba_transareDataSet = new WindowsFormsApp2.proba_transareDataSet();
            this.PanelLateralPropr = new System.Windows.Forms.Panel();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.tabel_UtilizatoriTableAdapter = new WindowsFormsApp2.proba_transareDataSetTableAdapters.Tabel_UtilizatoriTableAdapter();
            this.proba_transareDataSet1 = new WindowsFormsApp2.proba_transareDataSet1();
            this.tIPURIBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tIPURITableAdapter = new WindowsFormsApp2.proba_transareDataSet1TableAdapters.TIPURITableAdapter();
            this.proba_transareDataSet2 = new WindowsFormsApp2.proba_transareDataSet2();
            this.andarticoleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.and_articoleTableAdapter = new WindowsFormsApp2.proba_transareDataSet2TableAdapters.and_articoleTableAdapter();
            this.PanelRibbon1.SuspendLayout();
            this.PanelContainerRibbon1.SuspendLayout();
            this.PanelRibbon2.SuspendLayout();
            this.PanelProprietari.SuspendLayout();
            this.Proprietari.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabelUtilizatoriBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proba_transareDataSet)).BeginInit();
            this.PanelLateralPropr.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.proba_transareDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tIPURIBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proba_transareDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.andarticoleBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ProprietariTile
            // 
            this.ProprietariTile.Location = new System.Drawing.Point(3, 2);
            this.ProprietariTile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ProprietariTile.Name = "ProprietariTile";
            this.ProprietariTile.Size = new System.Drawing.Size(146, 113);
            this.ProprietariTile.TabIndex = 1;
            this.ProprietariTile.Text = "Proprietari";
            this.ProprietariTile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ProprietariTile.Click += new System.EventHandler(this.metroTile1_Click);
            // 
            // PanelRibbon1
            // 
            this.PanelRibbon1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelRibbon1.ColumnCount = 5;
            this.PanelRibbon1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.PanelRibbon1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.PanelRibbon1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.PanelRibbon1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.PanelRibbon1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.PanelRibbon1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.PanelRibbon1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.PanelRibbon1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.PanelRibbon1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.PanelRibbon1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.PanelRibbon1.Controls.Add(this.ProprietariTile, 0, 0);
            this.PanelRibbon1.Controls.Add(this.MaimulteRibbon, 4, 0);
            this.PanelRibbon1.Location = new System.Drawing.Point(4, 4);
            this.PanelRibbon1.Margin = new System.Windows.Forms.Padding(4);
            this.PanelRibbon1.Name = "PanelRibbon1";
            this.PanelRibbon1.RowCount = 1;
            this.PanelRibbon1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.PanelRibbon1.Size = new System.Drawing.Size(1529, 118);
            this.PanelRibbon1.TabIndex = 4;
            // 
            // MaimulteRibbon
            // 
            this.MaimulteRibbon.Location = new System.Drawing.Point(1223, 2);
            this.MaimulteRibbon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaimulteRibbon.Name = "MaimulteRibbon";
            this.MaimulteRibbon.Size = new System.Drawing.Size(146, 113);
            this.MaimulteRibbon.TabIndex = 8;
            this.MaimulteRibbon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.MaimulteRibbon.TileImage = global::WindowsFormsApp2.Properties.Resources.sageata_65;
            this.MaimulteRibbon.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.MaimulteRibbon.UseTileImage = true;
            this.MaimulteRibbon.Click += new System.EventHandler(this.MaimulteRibbon_Click);
            // 
            // PanelContainerRibbon1
            // 
            this.PanelContainerRibbon1.Controls.Add(this.PanelRibbon1);
            this.PanelContainerRibbon1.Location = new System.Drawing.Point(16, 15);
            this.PanelContainerRibbon1.Margin = new System.Windows.Forms.Padding(4);
            this.PanelContainerRibbon1.Name = "PanelContainerRibbon1";
            this.PanelContainerRibbon1.Size = new System.Drawing.Size(1531, 123);
            this.PanelContainerRibbon1.TabIndex = 4;
            // 
            // PanelRibbon2
            // 
            this.PanelRibbon2.ColumnCount = 10;
            this.PanelRibbon2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.PanelRibbon2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.PanelRibbon2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.PanelRibbon2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.PanelRibbon2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.PanelRibbon2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.PanelRibbon2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.PanelRibbon2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.PanelRibbon2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.PanelRibbon2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.PanelRibbon2.Controls.Add(this.metroTile6, 3, 0);
            this.PanelRibbon2.Controls.Add(this.metroTile7, 2, 0);
            this.PanelRibbon2.Controls.Add(this.metroTile8, 0, 0);
            this.PanelRibbon2.Location = new System.Drawing.Point(17, 15);
            this.PanelRibbon2.Margin = new System.Windows.Forms.Padding(4);
            this.PanelRibbon2.Name = "PanelRibbon2";
            this.PanelRibbon2.RowCount = 1;
            this.PanelRibbon2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.PanelRibbon2.Size = new System.Drawing.Size(1507, 119);
            this.PanelRibbon2.TabIndex = 7;
            // 
            // metroTile6
            // 
            this.metroTile6.Location = new System.Drawing.Point(453, 2);
            this.metroTile6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.metroTile6.Name = "metroTile6";
            this.metroTile6.Size = new System.Drawing.Size(144, 113);
            this.metroTile6.TabIndex = 7;
            this.metroTile6.Text = "Lista intretinere";
            this.metroTile6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // metroTile7
            // 
            this.metroTile7.Location = new System.Drawing.Point(303, 2);
            this.metroTile7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.metroTile7.Name = "metroTile7";
            this.metroTile7.Size = new System.Drawing.Size(144, 113);
            this.metroTile7.TabIndex = 6;
            this.metroTile7.Text = "Introd Chelt";
            this.metroTile7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // metroTile8
            // 
            this.metroTile8.Location = new System.Drawing.Point(3, 2);
            this.metroTile8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.metroTile8.Name = "metroTile8";
            this.metroTile8.Size = new System.Drawing.Size(144, 113);
            this.metroTile8.TabIndex = 5;
            this.metroTile8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile8.TileImage = global::WindowsFormsApp2.Properties.Resources.sag_stanga;
            this.metroTile8.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile8.UseTileImage = true;
            this.metroTile8.Click += new System.EventHandler(this.metroTile8_Click);
            // 
            // PanelProprietari
            // 
            this.PanelProprietari.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelProprietari.Controls.Add(this.Proprietari);
            this.PanelProprietari.Location = new System.Drawing.Point(320, 166);
            this.PanelProprietari.Name = "PanelProprietari";
            this.PanelProprietari.Size = new System.Drawing.Size(1208, 668);
            this.PanelProprietari.TabIndex = 8;
            // 
            // Proprietari
            // 
            this.Proprietari.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Proprietari.Controls.Add(this.metroTabPage1);
            this.Proprietari.Location = new System.Drawing.Point(3, 3);
            this.Proprietari.Name = "Proprietari";
            this.Proprietari.SelectedIndex = 0;
            this.Proprietari.Size = new System.Drawing.Size(1202, 662);
            this.Proprietari.TabIndex = 0;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.dataGridView1);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 39);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(1194, 619);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "Proprietari";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.utilizatorDataGridViewTextBoxColumn,
            this.parolaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tabelUtilizatoriBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(2, 15);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1189, 601);
            this.dataGridView1.TabIndex = 2;
            // 
            // utilizatorDataGridViewTextBoxColumn
            // 
            this.utilizatorDataGridViewTextBoxColumn.DataPropertyName = "utilizator";
            this.utilizatorDataGridViewTextBoxColumn.HeaderText = "utilizator";
            this.utilizatorDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.utilizatorDataGridViewTextBoxColumn.Name = "utilizatorDataGridViewTextBoxColumn";
            this.utilizatorDataGridViewTextBoxColumn.Width = 125;
            // 
            // parolaDataGridViewTextBoxColumn
            // 
            this.parolaDataGridViewTextBoxColumn.DataPropertyName = "parola";
            this.parolaDataGridViewTextBoxColumn.HeaderText = "parola";
            this.parolaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.parolaDataGridViewTextBoxColumn.Name = "parolaDataGridViewTextBoxColumn";
            this.parolaDataGridViewTextBoxColumn.Width = 125;
            // 
            // tabelUtilizatoriBindingSource
            // 
            this.tabelUtilizatoriBindingSource.DataMember = "Tabel_Utilizatori";
            this.tabelUtilizatoriBindingSource.DataSource = this.proba_transareDataSet;
            // 
            // proba_transareDataSet
            // 
            this.proba_transareDataSet.DataSetName = "proba_transareDataSet";
            this.proba_transareDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // PanelLateralPropr
            // 
            this.PanelLateralPropr.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.PanelLateralPropr.BackColor = System.Drawing.Color.Gray;
            this.PanelLateralPropr.Controls.Add(this.metroTile1);
            this.PanelLateralPropr.Controls.Add(this.checkBox1);
            this.PanelLateralPropr.Location = new System.Drawing.Point(11, 166);
            this.PanelLateralPropr.Name = "PanelLateralPropr";
            this.PanelLateralPropr.Size = new System.Drawing.Size(303, 665);
            this.PanelLateralPropr.TabIndex = 9;
            // 
            // metroTile1
            // 
            this.metroTile1.Location = new System.Drawing.Point(43, 196);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(146, 64);
            this.metroTile1.TabIndex = 3;
            this.metroTile1.Text = "metroTile1";
            this.metroTile1.Click += new System.EventHandler(this.metroTile1_Click_1);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(67, 42);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(98, 21);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // tabel_UtilizatoriTableAdapter
            // 
            this.tabel_UtilizatoriTableAdapter.ClearBeforeFill = true;
            // 
            // proba_transareDataSet1
            // 
            this.proba_transareDataSet1.DataSetName = "proba_transareDataSet1";
            this.proba_transareDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tIPURIBindingSource
            // 
            this.tIPURIBindingSource.DataMember = "TIPURI";
            this.tIPURIBindingSource.DataSource = this.proba_transareDataSet1;
            // 
            // tIPURITableAdapter
            // 
            this.tIPURITableAdapter.ClearBeforeFill = true;
            // 
            // proba_transareDataSet2
            // 
            this.proba_transareDataSet2.DataSetName = "proba_transareDataSet2";
            this.proba_transareDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // andarticoleBindingSource
            // 
            this.andarticoleBindingSource.DataMember = "and_articole";
            this.andarticoleBindingSource.DataSource = this.proba_transareDataSet2;
            // 
            // and_articoleTableAdapter
            // 
            this.and_articoleTableAdapter.ClearBeforeFill = true;
            // 
            // DupaLogare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1540, 846);
            this.Controls.Add(this.PanelLateralPropr);
            this.Controls.Add(this.PanelProprietari);
            this.Controls.Add(this.PanelContainerRibbon1);
            this.Controls.Add(this.PanelRibbon2);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "DupaLogare";
            this.Text = "DupaLogare";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.DupaLogare_Load);
            this.PanelRibbon1.ResumeLayout(false);
            this.PanelContainerRibbon1.ResumeLayout(false);
            this.PanelRibbon2.ResumeLayout(false);
            this.PanelProprietari.ResumeLayout(false);
            this.Proprietari.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabelUtilizatoriBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proba_transareDataSet)).EndInit();
            this.PanelLateralPropr.ResumeLayout(false);
            this.PanelLateralPropr.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.proba_transareDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tIPURIBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proba_transareDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.andarticoleBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroTile ProprietariTile;
        private System.Windows.Forms.TableLayoutPanel PanelRibbon1;
        private MetroFramework.Controls.MetroTile MaimulteRibbon;
        private System.Windows.Forms.Panel PanelContainerRibbon1;
        private System.Windows.Forms.TableLayoutPanel PanelRibbon2;
        private MetroFramework.Controls.MetroTile metroTile6;
        private MetroFramework.Controls.MetroTile metroTile7;
        private MetroFramework.Controls.MetroTile metroTile8;
        private System.Windows.Forms.Panel PanelProprietari;
        private MetroFramework.Controls.MetroTabControl Proprietari;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel PanelLateralPropr;
        private proba_transareDataSet proba_transareDataSet;
        private System.Windows.Forms.BindingSource tabelUtilizatoriBindingSource;
        private proba_transareDataSetTableAdapters.Tabel_UtilizatoriTableAdapter tabel_UtilizatoriTableAdapter;
        private System.Windows.Forms.CheckBox checkBox1;
        private proba_transareDataSet1 proba_transareDataSet1;
        private System.Windows.Forms.BindingSource tIPURIBindingSource;
        private proba_transareDataSet1TableAdapters.TIPURITableAdapter tIPURITableAdapter;
        private proba_transareDataSet2 proba_transareDataSet2;
        private System.Windows.Forms.BindingSource andarticoleBindingSource;
        private proba_transareDataSet2TableAdapters.and_articoleTableAdapter and_articoleTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn utilizatorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn parolaDataGridViewTextBoxColumn;
        private MetroFramework.Controls.MetroTile metroTile1;
    }
}