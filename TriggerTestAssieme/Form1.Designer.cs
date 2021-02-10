
namespace TriggerTestAssieme
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvDriver = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbNazioni = new System.Windows.Forms.ComboBox();
            this.lblPodiums = new System.Windows.Forms.Label();
            this.btnPodiumsNumber = new System.Windows.Forms.Button();
            this.nPodiums = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDriver)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nPodiums)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDriver
            // 
            this.dgvDriver.AllowUserToAddRows = false;
            this.dgvDriver.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDriver.Location = new System.Drawing.Point(13, 13);
            this.dgvDriver.Name = "dgvDriver";
            this.dgvDriver.Size = new System.Drawing.Size(457, 145);
            this.dgvDriver.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(490, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nazione:";
            // 
            // cmbNazioni
            // 
            this.cmbNazioni.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNazioni.FormattingEnabled = true;
            this.cmbNazioni.Items.AddRange(new object[] {
            "GB",
            "IT",
            "FI",
            "NL",
            "MC",
            "MX",
            "DE",
            "ES",
            "FR"});
            this.cmbNazioni.Location = new System.Drawing.Point(545, 47);
            this.cmbNazioni.Name = "cmbNazioni";
            this.cmbNazioni.Size = new System.Drawing.Size(121, 21);
            this.cmbNazioni.TabIndex = 2;
            this.cmbNazioni.SelectedValueChanged += new System.EventHandler(this.cmbNazioni_SelectedValueChanged);
            // 
            // lblPodiums
            // 
            this.lblPodiums.AutoSize = true;
            this.lblPodiums.Location = new System.Drawing.Point(490, 87);
            this.lblPodiums.Name = "lblPodiums";
            this.lblPodiums.Size = new System.Drawing.Size(88, 13);
            this.lblPodiums.TabIndex = 3;
            this.lblPodiums.Text = "Podiums number:";
            // 
            // btnPodiumsNumber
            // 
            this.btnPodiumsNumber.Location = new System.Drawing.Point(533, 130);
            this.btnPodiumsNumber.Name = "btnPodiumsNumber";
            this.btnPodiumsNumber.Size = new System.Drawing.Size(98, 23);
            this.btnPodiumsNumber.TabIndex = 5;
            this.btnPodiumsNumber.Text = "Podiums number";
            this.btnPodiumsNumber.UseVisualStyleBackColor = true;
            this.btnPodiumsNumber.Click += new System.EventHandler(this.btnPodiumsNumber_Click);
            // 
            // nPodiums
            // 
            this.nPodiums.Location = new System.Drawing.Point(584, 85);
            this.nPodiums.Name = "nPodiums";
            this.nPodiums.Size = new System.Drawing.Size(61, 20);
            this.nPodiums.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 262);
            this.Controls.Add(this.nPodiums);
            this.Controls.Add(this.btnPodiumsNumber);
            this.Controls.Add(this.lblPodiums);
            this.Controls.Add(this.cmbNazioni);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvDriver);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDriver)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nPodiums)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDriver;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbNazioni;
        private System.Windows.Forms.Label lblPodiums;
        private System.Windows.Forms.Button btnPodiumsNumber;
        private System.Windows.Forms.NumericUpDown nPodiums;
    }
}

