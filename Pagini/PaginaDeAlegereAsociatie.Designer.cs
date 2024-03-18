namespace ApartmentCare.Pagini
{
    partial class PaginaDeAlegereAsociatie
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PaginaDeAlegereAsociatie));
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "123445",
            "Asociatia de Prop. Bloc 18"}, -1);
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelAfisaj = new System.Windows.Forms.Panel();
            this.btExitConectare = new System.Windows.Forms.Button();
            this.lbApp = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.infoFunctieDrepturi = new System.Windows.Forms.ToolTip(this.components);
            this.tbFunctieDrepturi = new System.Windows.Forms.TextBox();
            this.tbNumeUtilizator = new System.Windows.Forms.TextBox();
            this.btConectare = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lvAlegereAsociatie = new System.Windows.Forms.ListView();
            this.coloanaCUIAscocAlegere = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.coloanaDenumireAsociatieAlegere = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1.SuspendLayout();
            this.panelAfisaj.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panelAfisaj);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(461, 41);
            this.panel1.TabIndex = 0;
            // 
            // panelAfisaj
            // 
            this.panelAfisaj.BackColor = System.Drawing.Color.White;
            this.panelAfisaj.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panelAfisaj.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelAfisaj.CausesValidation = false;
            this.panelAfisaj.Controls.Add(this.btExitConectare);
            this.panelAfisaj.Controls.Add(this.lbApp);
            this.panelAfisaj.Controls.Add(this.pictureBox1);
            this.panelAfisaj.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelAfisaj.Location = new System.Drawing.Point(0, 0);
            this.panelAfisaj.Name = "panelAfisaj";
            this.panelAfisaj.Padding = new System.Windows.Forms.Padding(1);
            this.panelAfisaj.Size = new System.Drawing.Size(461, 41);
            this.panelAfisaj.TabIndex = 5;
            this.panelAfisaj.TabStop = true;
            this.panelAfisaj.Paint += new System.Windows.Forms.PaintEventHandler(this.panelAfisaj_Paint);
            // 
            // btExitConectare
            // 
            this.btExitConectare.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btExitConectare.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btExitConectare.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btExitConectare.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btExitConectare.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btExitConectare.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(130)))), ((int)(((byte)(164)))));
            this.btExitConectare.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btExitConectare.Location = new System.Drawing.Point(416, 4);
            this.btExitConectare.Name = "btExitConectare";
            this.btExitConectare.Size = new System.Drawing.Size(41, 32);
            this.btExitConectare.TabIndex = 5;
            this.btExitConectare.Text = "✖";
            this.btExitConectare.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btExitConectare.UseVisualStyleBackColor = true;
            this.btExitConectare.Click += new System.EventHandler(this.btExitConectare_Click_1);
            // 
            // lbApp
            // 
            this.lbApp.AutoSize = true;
            this.lbApp.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbApp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(130)))), ((int)(((byte)(164)))));
            this.lbApp.Location = new System.Drawing.Point(63, 9);
            this.lbApp.Name = "lbApp";
            this.lbApp.Size = new System.Drawing.Size(133, 20);
            this.lbApp.TabIndex = 3;
            this.lbApp.Text = "APARTMENTCARE";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(45, 41);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(186)))), ((int)(((byte)(234)))));
            this.label1.Location = new System.Drawing.Point(82, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(274, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Te-ai conectat cu succes!";
            // 
            // infoFunctieDrepturi
            // 
            this.infoFunctieDrepturi.AutomaticDelay = 200;
            this.infoFunctieDrepturi.ShowAlways = true;
            this.infoFunctieDrepturi.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.infoFunctieDrepturi.Popup += new System.Windows.Forms.PopupEventHandler(this.toolTip1_Popup);
            // 
            // tbFunctieDrepturi
            // 
            this.tbFunctieDrepturi.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.tbFunctieDrepturi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbFunctieDrepturi.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbFunctieDrepturi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(130)))), ((int)(((byte)(164)))));
            this.tbFunctieDrepturi.Location = new System.Drawing.Point(86, 160);
            this.tbFunctieDrepturi.Multiline = true;
            this.tbFunctieDrepturi.Name = "tbFunctieDrepturi";
            this.tbFunctieDrepturi.Size = new System.Drawing.Size(270, 36);
            this.tbFunctieDrepturi.TabIndex = 4;
            this.tbFunctieDrepturi.Text = "Administrator";
            this.tbFunctieDrepturi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbFunctieDrepturi.TextChanged += new System.EventHandler(this.tbFunctieDrepturi_TextChanged);
            // 
            // tbNumeUtilizator
            // 
            this.tbNumeUtilizator.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbNumeUtilizator.Font = new System.Drawing.Font("Century Gothic", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNumeUtilizator.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(186)))), ((int)(((byte)(234)))));
            this.tbNumeUtilizator.Location = new System.Drawing.Point(86, 58);
            this.tbNumeUtilizator.Multiline = true;
            this.tbNumeUtilizator.Name = "tbNumeUtilizator";
            this.tbNumeUtilizator.Size = new System.Drawing.Size(270, 36);
            this.tbNumeUtilizator.TabIndex = 3;
            this.tbNumeUtilizator.Text = "Nume Prenume";
            this.tbNumeUtilizator.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btConectare
            // 
            this.btConectare.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btConectare.FlatAppearance.BorderSize = 2;
            this.btConectare.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btConectare.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btConectare.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(130)))), ((int)(((byte)(164)))));
            this.btConectare.Location = new System.Drawing.Point(148, 513);
            this.btConectare.Name = "btConectare";
            this.btConectare.Size = new System.Drawing.Size(141, 50);
            this.btConectare.TabIndex = 6;
            this.btConectare.Text = "OK";
            this.btConectare.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(10, 224);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(267, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Alege asociația pe care dorești să o lucrezi:";
            // 
            // lvAlegereAsociatie
            // 
            this.lvAlegereAsociatie.BackColor = System.Drawing.Color.White;
            this.lvAlegereAsociatie.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvAlegereAsociatie.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.coloanaCUIAscocAlegere,
            this.coloanaDenumireAsociatieAlegere});
            this.lvAlegereAsociatie.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lvAlegereAsociatie.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvAlegereAsociatie.FullRowSelect = true;
            this.lvAlegereAsociatie.HideSelection = false;
            listViewItem1.Tag = "";
            this.lvAlegereAsociatie.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.lvAlegereAsociatie.Location = new System.Drawing.Point(13, 253);
            this.lvAlegereAsociatie.Name = "lvAlegereAsociatie";
            this.lvAlegereAsociatie.Size = new System.Drawing.Size(436, 239);
            this.lvAlegereAsociatie.TabIndex = 8;
            this.lvAlegereAsociatie.UseCompatibleStateImageBehavior = false;
            this.lvAlegereAsociatie.View = System.Windows.Forms.View.Details;
            // 
            // coloanaCUIAscocAlegere
            // 
            this.coloanaCUIAscocAlegere.Text = "CUI";
            this.coloanaCUIAscocAlegere.Width = 102;
            // 
            // coloanaDenumireAsociatieAlegere
            // 
            this.coloanaDenumireAsociatieAlegere.Text = "Denumire Asociație";
            this.coloanaDenumireAsociatieAlegere.Width = 298;
            // 
            // PaginaDeAlegereAsociatie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.btExitConectare;
            this.ClientSize = new System.Drawing.Size(461, 593);
            this.Controls.Add(this.lvAlegereAsociatie);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btConectare);
            this.Controls.Add(this.tbFunctieDrepturi);
            this.Controls.Add(this.tbNumeUtilizator);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PaginaDeAlegereAsociatie";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PaginaDeAlegereAsociatie";
            this.panel1.ResumeLayout(false);
            this.panelAfisaj.ResumeLayout(false);
            this.panelAfisaj.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolTip infoFunctieDrepturi;
        private System.Windows.Forms.TextBox tbNumeUtilizator;
        private System.Windows.Forms.TextBox tbFunctieDrepturi;
        private System.Windows.Forms.Panel panelAfisaj;
        private System.Windows.Forms.Label lbApp;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Button btExitConectare;
        private System.Windows.Forms.Button btConectare;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView lvAlegereAsociatie;
        private System.Windows.Forms.ColumnHeader coloanaCUIAscocAlegere;
        private System.Windows.Forms.ColumnHeader coloanaDenumireAsociatieAlegere;
    }
}