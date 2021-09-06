namespace TouchpadServer
{
    partial class Form2
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
            this.wstecz = new MetroFramework.Controls.MetroButton();
            this.oAplikacjiVal = new MetroFramework.Controls.MetroLabel();
            this.oAplikacjiLbl = new MetroFramework.Controls.MetroLabel();
            this.oAutorzeVal = new MetroFramework.Controls.MetroLabel();
            this.oAutorzeLbl = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // wstecz
            // 
            this.wstecz.Location = new System.Drawing.Point(142, 263);
            this.wstecz.Name = "wstecz";
            this.wstecz.Size = new System.Drawing.Size(75, 23);
            this.wstecz.TabIndex = 12;
            this.wstecz.Text = "Zamknij";
            this.wstecz.UseSelectable = true;
            this.wstecz.Click += new System.EventHandler(this.wstecz_Click);
            // 
            // oAplikacjiVal
            // 
            this.oAplikacjiVal.AutoSize = true;
            this.oAplikacjiVal.Location = new System.Drawing.Point(9, 184);
            this.oAplikacjiVal.Name = "oAplikacjiVal";
            this.oAplikacjiVal.Size = new System.Drawing.Size(310, 76);
            this.oAplikacjiVal.TabIndex = 11;
            this.oAplikacjiVal.Text = "Apliakcja jest praca inżynierską.\r\nAplikacja Touchpad Server odbiera dane z telef" +
    "onu,\r\npotrzebne do sterowania kursorem.\r\n";
            // 
            // oAplikacjiLbl
            // 
            this.oAplikacjiLbl.AutoSize = true;
            this.oAplikacjiLbl.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.oAplikacjiLbl.Location = new System.Drawing.Point(142, 159);
            this.oAplikacjiLbl.Name = "oAplikacjiLbl";
            this.oAplikacjiLbl.Size = new System.Drawing.Size(91, 25);
            this.oAplikacjiLbl.TabIndex = 10;
            this.oAplikacjiLbl.Text = "O aplikacji";
            // 
            // oAutorzeVal
            // 
            this.oAutorzeVal.AutoSize = true;
            this.oAutorzeVal.Location = new System.Drawing.Point(9, 83);
            this.oAutorzeVal.Name = "oAutorzeVal";
            this.oAutorzeVal.Size = new System.Drawing.Size(354, 76);
            this.oAutorzeVal.TabIndex = 9;
            this.oAutorzeVal.Text = "Grzegorz Dziugieł\r\nWydział Informatyki\r\nZachodnipomorski Uniwersytet Technologicz" +
    "ny w Szczecinie\r\n";
            // 
            // oAutorzeLbl
            // 
            this.oAutorzeLbl.AutoSize = true;
            this.oAutorzeLbl.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.oAutorzeLbl.Location = new System.Drawing.Point(153, 60);
            this.oAutorzeLbl.Name = "oAutorzeLbl";
            this.oAutorzeLbl.Size = new System.Drawing.Size(54, 25);
            this.oAutorzeLbl.TabIndex = 8;
            this.oAutorzeLbl.Text = "Autor";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 336);
            this.Controls.Add(this.wstecz);
            this.Controls.Add(this.oAplikacjiVal);
            this.Controls.Add(this.oAplikacjiLbl);
            this.Controls.Add(this.oAutorzeVal);
            this.Controls.Add(this.oAutorzeLbl);
            this.Name = "Form2";
            this.Text = "Touchpad Server";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton wstecz;
        private MetroFramework.Controls.MetroLabel oAplikacjiVal;
        private MetroFramework.Controls.MetroLabel oAplikacjiLbl;
        private MetroFramework.Controls.MetroLabel oAutorzeVal;
        private MetroFramework.Controls.MetroLabel oAutorzeLbl;
    }
}