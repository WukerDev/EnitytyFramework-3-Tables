namespace Zadanie3tabele
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
            this.components = new System.ComponentModel.Container();
            this.dataGridViewTabele = new System.Windows.Forms.DataGridView();
            this.comboBoxWychowca = new System.Windows.Forms.ComboBox();
            this.textBoxImie = new System.Windows.Forms.TextBox();
            this.textBoxNazwisko = new System.Windows.Forms.TextBox();
            this.comboBoxKlasa = new System.Windows.Forms.ComboBox();
            this.buttonZapis = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTabele)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewTabele
            // 
            this.dataGridViewTabele.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTabele.Location = new System.Drawing.Point(191, 12);
            this.dataGridViewTabele.Name = "dataGridViewTabele";
            this.dataGridViewTabele.Size = new System.Drawing.Size(597, 426);
            this.dataGridViewTabele.TabIndex = 0;
            // 
            // comboBoxWychowca
            // 
            this.comboBoxWychowca.FormattingEnabled = true;
            this.comboBoxWychowca.Location = new System.Drawing.Point(12, 65);
            this.comboBoxWychowca.Name = "comboBoxWychowca";
            this.comboBoxWychowca.Size = new System.Drawing.Size(157, 21);
            this.comboBoxWychowca.TabIndex = 1;
            this.comboBoxWychowca.SelectedIndexChanged += new System.EventHandler(this.comboBoxWychowca_SelectedIndexChanged);
            // 
            // textBoxImie
            // 
            this.textBoxImie.Location = new System.Drawing.Point(12, 13);
            this.textBoxImie.Name = "textBoxImie";
            this.textBoxImie.Size = new System.Drawing.Size(157, 20);
            this.textBoxImie.TabIndex = 2;
            // 
            // textBoxNazwisko
            // 
            this.textBoxNazwisko.Location = new System.Drawing.Point(12, 39);
            this.textBoxNazwisko.Name = "textBoxNazwisko";
            this.textBoxNazwisko.Size = new System.Drawing.Size(157, 20);
            this.textBoxNazwisko.TabIndex = 3;
            // 
            // comboBoxKlasa
            // 
            this.comboBoxKlasa.FormattingEnabled = true;
            this.comboBoxKlasa.Location = new System.Drawing.Point(12, 92);
            this.comboBoxKlasa.Name = "comboBoxKlasa";
            this.comboBoxKlasa.Size = new System.Drawing.Size(157, 21);
            this.comboBoxKlasa.TabIndex = 5;
            this.comboBoxKlasa.SelectedIndexChanged += new System.EventHandler(this.comboBoxKlasa_SelectedIndexChanged);
            // 
            // buttonZapis
            // 
            this.buttonZapis.Location = new System.Drawing.Point(12, 119);
            this.buttonZapis.Name = "buttonZapis";
            this.buttonZapis.Size = new System.Drawing.Size(157, 23);
            this.buttonZapis.TabIndex = 6;
            this.buttonZapis.Text = "Zapisz!";
            this.buttonZapis.UseVisualStyleBackColor = true;
            this.buttonZapis.Click += new System.EventHandler(this.buttonZapis_Click);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonZapis);
            this.Controls.Add(this.comboBoxKlasa);
            this.Controls.Add(this.textBoxNazwisko);
            this.Controls.Add(this.textBoxImie);
            this.Controls.Add(this.comboBoxWychowca);
            this.Controls.Add(this.dataGridViewTabele);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTabele)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewTabele;
        private System.Windows.Forms.ComboBox comboBoxWychowca;
        private System.Windows.Forms.TextBox textBoxImie;
        private System.Windows.Forms.TextBox textBoxNazwisko;
        private System.Windows.Forms.ComboBox comboBoxKlasa;
        private System.Windows.Forms.Button buttonZapis;
        private System.Windows.Forms.ImageList imageList1;
    }
}

