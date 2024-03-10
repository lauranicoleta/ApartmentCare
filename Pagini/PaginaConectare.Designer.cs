namespace ApartmentCare.Pagini
{
    partial class PaginaConectare
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btExitConectare = new System.Windows.Forms.Button();
            this.btExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbCheieLicenta = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btConectare = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btAchizitieLicenta = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btExitConectare);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(471, 41);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btAchizitieLicenta);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.btConectare);
            this.panel2.Controls.Add(this.tbCheieLicenta);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 41);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(471, 597);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
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
            this.btExitConectare.Location = new System.Drawing.Point(427, 2);
            this.btExitConectare.Name = "btExitConectare";
            this.btExitConectare.Size = new System.Drawing.Size(41, 32);
            this.btExitConectare.TabIndex = 1;
            this.btExitConectare.Text = "✖";
            this.btExitConectare.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btExitConectare.UseVisualStyleBackColor = true;
            this.btExitConectare.Click += new System.EventHandler(this.btExit_Click);
            // 
            // btExit
            // 
            this.btExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btExit.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btExit.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(130)))), ((int)(((byte)(164)))));
            this.btExit.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btExit.Location = new System.Drawing.Point(427, 2);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(41, 32);
            this.btExit.TabIndex = 1;
            this.btExit.Text = "✖";
            this.btExit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btExit.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(186)))), ((int)(((byte)(234)))));
            this.label1.Location = new System.Drawing.Point(72, 294);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(317, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "Introduceți cheia licenței:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tbCheieLicenta
            // 
            this.tbCheieLicenta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(186)))), ((int)(((byte)(234)))));
            this.tbCheieLicenta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbCheieLicenta.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCheieLicenta.ForeColor = System.Drawing.Color.White;
            this.tbCheieLicenta.Location = new System.Drawing.Point(-1, 370);
            this.tbCheieLicenta.Multiline = true;
            this.tbCheieLicenta.Name = "tbCheieLicenta";
            this.tbCheieLicenta.Size = new System.Drawing.Size(471, 33);
            this.tbCheieLicenta.TabIndex = 2;
            this.tbCheieLicenta.Text = "ex: KYHS77264...";
            this.tbCheieLicenta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbCheieLicenta.TextChanged += new System.EventHandler(this.tbCheieLicenta_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ApartmentCare.Properties.Resources.Logo;
            this.pictureBox1.Location = new System.Drawing.Point(-1, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(471, 265);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(130)))), ((int)(((byte)(164)))));
            this.label2.Location = new System.Drawing.Point(12, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Bun venit!";
            // 
            // btConectare
            // 
            this.btConectare.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btConectare.FlatAppearance.BorderSize = 2;
            this.btConectare.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btConectare.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btConectare.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(130)))), ((int)(((byte)(164)))));
            this.btConectare.Location = new System.Drawing.Point(159, 438);
            this.btConectare.Name = "btConectare";
            this.btConectare.Size = new System.Drawing.Size(141, 50);
            this.btConectare.TabIndex = 3;
            this.btConectare.Text = "Conectare";
            this.btConectare.UseVisualStyleBackColor = true;
            this.btConectare.Click += new System.EventHandler(this.btConectare_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(130)))), ((int)(((byte)(164)))));
            this.label3.Location = new System.Drawing.Point(35, 235);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(405, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Administrare Transparentă, Comunicare Fluidă, Eficiență Garantată!\r\n";
            // 
            // btAchizitieLicenta
            // 
            this.btAchizitieLicenta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btAchizitieLicenta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btAchizitieLicenta.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btAchizitieLicenta.FlatAppearance.BorderSize = 0;
            this.btAchizitieLicenta.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btAchizitieLicenta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btAchizitieLicenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAchizitieLicenta.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAchizitieLicenta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(130)))), ((int)(((byte)(164)))));
            this.btAchizitieLicenta.Location = new System.Drawing.Point(-1, 521);
            this.btAchizitieLicenta.Name = "btAchizitieLicenta";
            this.btAchizitieLicenta.Size = new System.Drawing.Size(471, 50);
            this.btAchizitieLicenta.TabIndex = 5;
            this.btAchizitieLicenta.Text = "Achiziționează cheia de licență acum!";
            this.btAchizitieLicenta.UseVisualStyleBackColor = true;
            // 
            // PaginaConectare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(471, 638);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Name = "PaginaConectare";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PaginaConectare";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.Button btExitConectare;
        private System.Windows.Forms.TextBox tbCheieLicenta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Button btExit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btConectare;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btAchizitieLicenta;
    }
}