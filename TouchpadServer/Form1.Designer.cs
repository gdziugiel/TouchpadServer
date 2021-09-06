namespace TouchpadServer
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.przelacznik = new MetroFramework.Controls.MetroToggle();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.akcjaVal = new MetroFramework.Controls.MetroLabel();
            this.pozycjaVal = new MetroFramework.Controls.MetroLabel();
            this.rozdzielczoscVal = new MetroFramework.Controls.MetroLabel();
            this.ipVal = new MetroFramework.Controls.MetroLabel();
            this.akcjaLbl = new MetroFramework.Controls.MetroLabel();
            this.pozycjaLbl = new MetroFramework.Controls.MetroLabel();
            this.rozdzielczoscLbl = new MetroFramework.Controls.MetroLabel();
            this.ipLbl = new MetroFramework.Controls.MetroLabel();
            this.portLbl = new MetroFramework.Controls.MetroLabel();
            this.portVal = new MetroFramework.Controls.MetroTextBox();
            this.info = new MetroFramework.Controls.MetroButton();
            this.nazwaLbl = new MetroFramework.Controls.MetroLabel();
            this.nazwaVal = new MetroFramework.Controls.MetroLabel();
            this.metroTabControl1.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // przelacznik
            // 
            this.przelacznik.AutoSize = true;
            this.przelacznik.Location = new System.Drawing.Point(23, 63);
            this.przelacznik.Name = "przelacznik";
            this.przelacznik.Size = new System.Drawing.Size(80, 17);
            this.przelacznik.TabIndex = 0;
            this.przelacznik.Text = "Off";
            this.przelacznik.UseSelectable = true;
            this.przelacznik.CheckedChanged += new System.EventHandler(this.metroToggle1_CheckedChanged);
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.metroTabPage1);
            this.metroTabControl1.Location = new System.Drawing.Point(23, 86);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Size = new System.Drawing.Size(322, 239);
            this.metroTabControl1.TabIndex = 1;
            this.metroTabControl1.UseSelectable = true;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.nazwaVal);
            this.metroTabPage1.Controls.Add(this.nazwaLbl);
            this.metroTabPage1.Controls.Add(this.akcjaVal);
            this.metroTabPage1.Controls.Add(this.pozycjaVal);
            this.metroTabPage1.Controls.Add(this.rozdzielczoscVal);
            this.metroTabPage1.Controls.Add(this.ipVal);
            this.metroTabPage1.Controls.Add(this.akcjaLbl);
            this.metroTabPage1.Controls.Add(this.pozycjaLbl);
            this.metroTabPage1.Controls.Add(this.rozdzielczoscLbl);
            this.metroTabPage1.Controls.Add(this.ipLbl);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 10;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(314, 197);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "Infomacje";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 10;
            // 
            // akcjaVal
            // 
            this.akcjaVal.AutoSize = true;
            this.akcjaVal.Location = new System.Drawing.Point(163, 171);
            this.akcjaVal.Name = "akcjaVal";
            this.akcjaVal.Size = new System.Drawing.Size(73, 19);
            this.akcjaVal.TabIndex = 9;
            this.akcjaVal.Text = "Wyłączono";
            // 
            // pozycjaVal
            // 
            this.pozycjaVal.AutoSize = true;
            this.pozycjaVal.Location = new System.Drawing.Point(163, 133);
            this.pozycjaVal.Name = "pozycjaVal";
            this.pozycjaVal.Size = new System.Drawing.Size(60, 19);
            this.pozycjaVal.TabIndex = 8;
            this.pozycjaVal.Text = "x: 0 | y: 0";
            // 
            // rozdzielczoscVal
            // 
            this.rozdzielczoscVal.AutoSize = true;
            this.rozdzielczoscVal.Location = new System.Drawing.Point(163, 95);
            this.rozdzielczoscVal.Name = "rozdzielczoscVal";
            this.rozdzielczoscVal.Size = new System.Drawing.Size(37, 19);
            this.rozdzielczoscVal.TabIndex = 7;
            this.rozdzielczoscVal.Text = "0 x 0";
            // 
            // ipVal
            // 
            this.ipVal.AutoSize = true;
            this.ipVal.Location = new System.Drawing.Point(163, 57);
            this.ipVal.Name = "ipVal";
            this.ipVal.Size = new System.Drawing.Size(46, 19);
            this.ipVal.TabIndex = 6;
            this.ipVal.Text = "0.0.0.0";
            // 
            // akcjaLbl
            // 
            this.akcjaLbl.AutoSize = true;
            this.akcjaLbl.Location = new System.Drawing.Point(-4, 171);
            this.akcjaLbl.Name = "akcjaLbl";
            this.akcjaLbl.Size = new System.Drawing.Size(40, 19);
            this.akcjaLbl.TabIndex = 5;
            this.akcjaLbl.Text = "Akcja";
            // 
            // pozycjaLbl
            // 
            this.pozycjaLbl.AutoSize = true;
            this.pozycjaLbl.Location = new System.Drawing.Point(-4, 133);
            this.pozycjaLbl.Name = "pozycjaLbl";
            this.pozycjaLbl.Size = new System.Drawing.Size(99, 19);
            this.pozycjaLbl.TabIndex = 4;
            this.pozycjaLbl.Text = "Pozycja kursora";
            // 
            // rozdzielczoscLbl
            // 
            this.rozdzielczoscLbl.AutoSize = true;
            this.rozdzielczoscLbl.Location = new System.Drawing.Point(-4, 95);
            this.rozdzielczoscLbl.Name = "rozdzielczoscLbl";
            this.rozdzielczoscLbl.Size = new System.Drawing.Size(132, 19);
            this.rozdzielczoscLbl.TabIndex = 3;
            this.rozdzielczoscLbl.Text = "Rozdzielczość ekranu";
            // 
            // ipLbl
            // 
            this.ipLbl.AutoSize = true;
            this.ipLbl.Location = new System.Drawing.Point(-4, 57);
            this.ipLbl.Name = "ipLbl";
            this.ipLbl.Size = new System.Drawing.Size(108, 19);
            this.ipLbl.TabIndex = 2;
            this.ipLbl.Text = "Adres IP serwera";
            // 
            // portLbl
            // 
            this.portLbl.AutoSize = true;
            this.portLbl.Location = new System.Drawing.Point(109, 60);
            this.portLbl.Name = "portLbl";
            this.portLbl.Size = new System.Drawing.Size(84, 19);
            this.portLbl.TabIndex = 2;
            this.portLbl.Text = "Port serwera";
            // 
            // portVal
            // 
            // 
            // 
            // 
            this.portVal.CustomButton.Image = null;
            this.portVal.CustomButton.Location = new System.Drawing.Point(28, 1);
            this.portVal.CustomButton.Name = "";
            this.portVal.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.portVal.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.portVal.CustomButton.TabIndex = 1;
            this.portVal.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.portVal.CustomButton.UseSelectable = true;
            this.portVal.CustomButton.Visible = false;
            this.portVal.Lines = new string[] {
        "49152"};
            this.portVal.Location = new System.Drawing.Point(199, 60);
            this.portVal.MaxLength = 32767;
            this.portVal.Name = "portVal";
            this.portVal.PasswordChar = '\0';
            this.portVal.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.portVal.SelectedText = "";
            this.portVal.SelectionLength = 0;
            this.portVal.SelectionStart = 0;
            this.portVal.ShortcutsEnabled = true;
            this.portVal.Size = new System.Drawing.Size(50, 23);
            this.portVal.TabIndex = 3;
            this.portVal.Text = "49152";
            this.portVal.UseSelectable = true;
            this.portVal.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.portVal.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.portVal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.portVal_KeyPress);
            // 
            // info
            // 
            this.info.Location = new System.Drawing.Point(266, 60);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(75, 23);
            this.info.TabIndex = 4;
            this.info.Text = "O aplikacji";
            this.info.UseSelectable = true;
            this.info.Click += new System.EventHandler(this.info_Click);
            // 
            // nazwaLbl
            // 
            this.nazwaLbl.AutoSize = true;
            this.nazwaLbl.Location = new System.Drawing.Point(-5, 19);
            this.nazwaLbl.Name = "nazwaLbl";
            this.nazwaLbl.Size = new System.Drawing.Size(98, 19);
            this.nazwaLbl.TabIndex = 10;
            this.nazwaLbl.Text = "Nazwa serwera";
            // 
            // nazwaVal
            // 
            this.nazwaVal.AutoSize = true;
            this.nazwaVal.Location = new System.Drawing.Point(163, 19);
            this.nazwaVal.Name = "nazwaVal";
            this.nazwaVal.Size = new System.Drawing.Size(0, 0);
            this.nazwaVal.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 336);
            this.Controls.Add(this.info);
            this.Controls.Add(this.portVal);
            this.Controls.Add(this.portLbl);
            this.Controls.Add(this.metroTabControl1);
            this.Controls.Add(this.przelacznik);
            this.Name = "Form1";
            this.Text = "Touchpad Server";
            this.metroTabControl1.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            this.metroTabPage1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroToggle przelacznik;
        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private MetroFramework.Controls.MetroLabel akcjaVal;
        private MetroFramework.Controls.MetroLabel pozycjaVal;
        private MetroFramework.Controls.MetroLabel rozdzielczoscVal;
        private MetroFramework.Controls.MetroLabel ipVal;
        private MetroFramework.Controls.MetroLabel akcjaLbl;
        private MetroFramework.Controls.MetroLabel pozycjaLbl;
        private MetroFramework.Controls.MetroLabel rozdzielczoscLbl;
        private MetroFramework.Controls.MetroLabel ipLbl;
        private MetroFramework.Controls.MetroLabel portLbl;
        private MetroFramework.Controls.MetroTextBox portVal;
        private MetroFramework.Controls.MetroButton info;
        private MetroFramework.Controls.MetroLabel nazwaVal;
        private MetroFramework.Controls.MetroLabel nazwaLbl;
    }
}

