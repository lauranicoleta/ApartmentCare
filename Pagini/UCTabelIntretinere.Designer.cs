namespace ApartmentCare.Pagini
{
    partial class UCTabelIntretinere
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tbLunaIntretinereAn = new System.Windows.Forms.TextBox();
            this.dgListIntretinere = new System.Windows.Forms.DataGridView();
            this.NrApartament = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumePrenume = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SuprafataTotala = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SuprafataUtila = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CotaParte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NrCamere = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NrPersoane = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btRefreshLista = new System.Windows.Forms.Button();
            this.btPrinteazaLista = new System.Windows.Forms.Button();
            this.btStergeApt = new System.Windows.Forms.Button();
            this.btEditeazaColoane = new System.Windows.Forms.Button();
            this.btAdaugaApartament = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgListIntretinere)).BeginInit();
            this.SuspendLayout();
            // 
            // tbLunaIntretinereAn
            // 
            this.tbLunaIntretinereAn.BackColor = System.Drawing.Color.White;
            this.tbLunaIntretinereAn.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbLunaIntretinereAn.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbLunaIntretinereAn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(130)))), ((int)(((byte)(164)))));
            this.tbLunaIntretinereAn.Location = new System.Drawing.Point(13, 14);
            this.tbLunaIntretinereAn.Name = "tbLunaIntretinereAn";
            this.tbLunaIntretinereAn.Size = new System.Drawing.Size(446, 24);
            this.tbLunaIntretinereAn.TabIndex = 0;
            this.tbLunaIntretinereAn.Text = "Ianuarie 2024";
            // 
            // dgListIntretinere
            // 
            this.dgListIntretinere.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgListIntretinere.BackgroundColor = System.Drawing.Color.White;
            this.dgListIntretinere.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgListIntretinere.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgListIntretinere.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgListIntretinere.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NrApartament,
            this.NumePrenume,
            this.SuprafataTotala,
            this.SuprafataUtila,
            this.CotaParte,
            this.NrCamere,
            this.NrPersoane});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgListIntretinere.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgListIntretinere.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgListIntretinere.Location = new System.Drawing.Point(0, 47);
            this.dgListIntretinere.Name = "dgListIntretinere";
            this.dgListIntretinere.RowHeadersWidth = 30;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.dgListIntretinere.RowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dgListIntretinere.Size = new System.Drawing.Size(1095, 681);
            this.dgListIntretinere.TabIndex = 3;
            this.dgListIntretinere.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgListIntretinere_CellContentClick);
            // 
            // NrApartament
            // 
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NrApartament.DefaultCellStyle = dataGridViewCellStyle7;
            this.NrApartament.HeaderText = "Nr. Apartament";
            this.NrApartament.Name = "NrApartament";
            this.NrApartament.ReadOnly = true;
            // 
            // NumePrenume
            // 
            this.NumePrenume.HeaderText = "Nume și Prenume";
            this.NumePrenume.Name = "NumePrenume";
            this.NumePrenume.ReadOnly = true;
            // 
            // SuprafataTotala
            // 
            this.SuprafataTotala.HeaderText = "Suprafață Totală";
            this.SuprafataTotala.Name = "SuprafataTotala";
            this.SuprafataTotala.ReadOnly = true;
            // 
            // SuprafataUtila
            // 
            this.SuprafataUtila.HeaderText = "Suprafață Utilă";
            this.SuprafataUtila.Name = "SuprafataUtila";
            this.SuprafataUtila.ReadOnly = true;
            // 
            // CotaParte
            // 
            this.CotaParte.HeaderText = "Cotă Parte";
            this.CotaParte.Name = "CotaParte";
            this.CotaParte.ReadOnly = true;
            // 
            // NrCamere
            // 
            this.NrCamere.HeaderText = "Nr. Camere";
            this.NrCamere.Name = "NrCamere";
            this.NrCamere.ReadOnly = true;
            // 
            // NrPersoane
            // 
            this.NrPersoane.HeaderText = "Nr. Persoane";
            this.NrPersoane.Name = "NrPersoane";
            this.NrPersoane.ReadOnly = true;
            // 
            // btRefreshLista
            // 
            this.btRefreshLista.BackColor = System.Drawing.Color.White;
            this.btRefreshLista.BackgroundImage = global::ApartmentCare.Properties.Resources.refreshLista;
            this.btRefreshLista.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btRefreshLista.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btRefreshLista.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btRefreshLista.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btRefreshLista.Font = new System.Drawing.Font("Century Gothic", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRefreshLista.Location = new System.Drawing.Point(708, 6);
            this.btRefreshLista.Name = "btRefreshLista";
            this.btRefreshLista.Size = new System.Drawing.Size(35, 35);
            this.btRefreshLista.TabIndex = 7;
            this.btRefreshLista.UseVisualStyleBackColor = false;
            // 
            // btPrinteazaLista
            // 
            this.btPrinteazaLista.BackColor = System.Drawing.Color.White;
            this.btPrinteazaLista.BackgroundImage = global::ApartmentCare.Properties.Resources.printeazaLista;
            this.btPrinteazaLista.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btPrinteazaLista.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btPrinteazaLista.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btPrinteazaLista.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btPrinteazaLista.Font = new System.Drawing.Font("Century Gothic", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPrinteazaLista.Location = new System.Drawing.Point(656, 6);
            this.btPrinteazaLista.Name = "btPrinteazaLista";
            this.btPrinteazaLista.Size = new System.Drawing.Size(35, 35);
            this.btPrinteazaLista.TabIndex = 6;
            this.btPrinteazaLista.UseVisualStyleBackColor = false;
            // 
            // btStergeApt
            // 
            this.btStergeApt.BackColor = System.Drawing.Color.White;
            this.btStergeApt.BackgroundImage = global::ApartmentCare.Properties.Resources.stergeApt;
            this.btStergeApt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btStergeApt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btStergeApt.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btStergeApt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btStergeApt.Font = new System.Drawing.Font("Century Gothic", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btStergeApt.Location = new System.Drawing.Point(759, 6);
            this.btStergeApt.Name = "btStergeApt";
            this.btStergeApt.Size = new System.Drawing.Size(35, 35);
            this.btStergeApt.TabIndex = 5;
            this.btStergeApt.UseVisualStyleBackColor = false;
            // 
            // btEditeazaColoane
            // 
            this.btEditeazaColoane.BackColor = System.Drawing.Color.White;
            this.btEditeazaColoane.BackgroundImage = global::ApartmentCare.Properties.Resources.editeazaApart;
            this.btEditeazaColoane.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btEditeazaColoane.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btEditeazaColoane.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btEditeazaColoane.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btEditeazaColoane.Font = new System.Drawing.Font("Century Gothic", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEditeazaColoane.Location = new System.Drawing.Point(606, 6);
            this.btEditeazaColoane.Name = "btEditeazaColoane";
            this.btEditeazaColoane.Size = new System.Drawing.Size(35, 35);
            this.btEditeazaColoane.TabIndex = 4;
            this.btEditeazaColoane.UseVisualStyleBackColor = false;
            // 
            // btAdaugaApartament
            // 
            this.btAdaugaApartament.BackColor = System.Drawing.Color.White;
            this.btAdaugaApartament.BackgroundImage = global::ApartmentCare.Properties.Resources.adaugaApartament;
            this.btAdaugaApartament.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btAdaugaApartament.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btAdaugaApartament.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btAdaugaApartament.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAdaugaApartament.Font = new System.Drawing.Font("Century Gothic", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAdaugaApartament.Location = new System.Drawing.Point(555, 6);
            this.btAdaugaApartament.Name = "btAdaugaApartament";
            this.btAdaugaApartament.Size = new System.Drawing.Size(35, 35);
            this.btAdaugaApartament.TabIndex = 2;
            this.btAdaugaApartament.UseVisualStyleBackColor = false;
            // 
            // UCTabelIntretinere
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Controls.Add(this.btRefreshLista);
            this.Controls.Add(this.btPrinteazaLista);
            this.Controls.Add(this.btStergeApt);
            this.Controls.Add(this.btEditeazaColoane);
            this.Controls.Add(this.dgListIntretinere);
            this.Controls.Add(this.btAdaugaApartament);
            this.Controls.Add(this.tbLunaIntretinereAn);
            this.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "UCTabelIntretinere";
            this.Size = new System.Drawing.Size(1095, 742);
            ((System.ComponentModel.ISupportInitialize)(this.dgListIntretinere)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbLunaIntretinereAn;
        private System.Windows.Forms.Button btAdaugaApartament;
        private System.Windows.Forms.DataGridView dgListIntretinere;
        private System.Windows.Forms.DataGridViewTextBoxColumn NrApartament;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumePrenume;
        private System.Windows.Forms.DataGridViewTextBoxColumn SuprafataTotala;
        private System.Windows.Forms.DataGridViewTextBoxColumn SuprafataUtila;
        private System.Windows.Forms.DataGridViewTextBoxColumn CotaParte;
        private System.Windows.Forms.DataGridViewTextBoxColumn NrCamere;
        private System.Windows.Forms.DataGridViewTextBoxColumn NrPersoane;
        private System.Windows.Forms.Button btEditeazaColoane;
        private System.Windows.Forms.Button btStergeApt;
        private System.Windows.Forms.Button btPrinteazaLista;
        private System.Windows.Forms.Button btRefreshLista;
    }
}
