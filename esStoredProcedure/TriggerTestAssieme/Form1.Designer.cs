
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
            this.dgvStoricoCancellazioni = new System.Windows.Forms.DataGridView();
            this.dgvStoricoAggiornamenti = new System.Windows.Forms.DataGridView();
            this.btnAggDB = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtData = new System.Windows.Forms.TextBox();
            this.dgvSAggProcedure = new System.Windows.Forms.DataGridView();
            this.btnData = new System.Windows.Forms.Button();
            this.dgvSAggCampiProcedure = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDriver)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStoricoCancellazioni)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStoricoAggiornamenti)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSAggProcedure)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSAggCampiProcedure)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDriver
            // 
            this.dgvDriver.AllowUserToAddRows = false;
            this.dgvDriver.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDriver.Location = new System.Drawing.Point(13, 13);
            this.dgvDriver.Name = "dgvDriver";
            this.dgvDriver.Size = new System.Drawing.Size(323, 196);
            this.dgvDriver.TabIndex = 0;
            this.dgvDriver.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.OnDblClickDriver);
            this.dgvDriver.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.OnRowsDeletedDriver);
            // 
            // dgvStoricoCancellazioni
            // 
            this.dgvStoricoCancellazioni.AllowUserToAddRows = false;
            this.dgvStoricoCancellazioni.AllowUserToDeleteRows = false;
            this.dgvStoricoCancellazioni.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStoricoCancellazioni.Location = new System.Drawing.Point(352, 13);
            this.dgvStoricoCancellazioni.Name = "dgvStoricoCancellazioni";
            this.dgvStoricoCancellazioni.RowHeadersVisible = false;
            this.dgvStoricoCancellazioni.Size = new System.Drawing.Size(323, 196);
            this.dgvStoricoCancellazioni.TabIndex = 1;
            // 
            // dgvStoricoAggiornamenti
            // 
            this.dgvStoricoAggiornamenti.AllowUserToAddRows = false;
            this.dgvStoricoAggiornamenti.AllowUserToDeleteRows = false;
            this.dgvStoricoAggiornamenti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStoricoAggiornamenti.Location = new System.Drawing.Point(13, 242);
            this.dgvStoricoAggiornamenti.Name = "dgvStoricoAggiornamenti";
            this.dgvStoricoAggiornamenti.RowHeadersVisible = false;
            this.dgvStoricoAggiornamenti.Size = new System.Drawing.Size(218, 196);
            this.dgvStoricoAggiornamenti.TabIndex = 2;
            // 
            // btnAggDB
            // 
            this.btnAggDB.Location = new System.Drawing.Point(13, 216);
            this.btnAggDB.Name = "btnAggDB";
            this.btnAggDB.Size = new System.Drawing.Size(159, 23);
            this.btnAggDB.TabIndex = 3;
            this.btnAggDB.Text = "Aggiorna Data Base";
            this.btnAggDB.UseVisualStyleBackColor = true;
            this.btnAggDB.Click += new System.EventHandler(this.btnAggDB_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(303, 221);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Data:";
            // 
            // txtData
            // 
            this.txtData.Location = new System.Drawing.Point(352, 218);
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(100, 20);
            this.txtData.TabIndex = 5;
            // 
            // dgvSAggProcedure
            // 
            this.dgvSAggProcedure.AllowUserToAddRows = false;
            this.dgvSAggProcedure.AllowUserToDeleteRows = false;
            this.dgvSAggProcedure.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSAggProcedure.Location = new System.Drawing.Point(284, 242);
            this.dgvSAggProcedure.Name = "dgvSAggProcedure";
            this.dgvSAggProcedure.RowHeadersVisible = false;
            this.dgvSAggProcedure.Size = new System.Drawing.Size(218, 196);
            this.dgvSAggProcedure.TabIndex = 6;
            // 
            // btnData
            // 
            this.btnData.Location = new System.Drawing.Point(477, 215);
            this.btnData.Name = "btnData";
            this.btnData.Size = new System.Drawing.Size(101, 23);
            this.btnData.TabIndex = 7;
            this.btnData.Text = "button1";
            this.btnData.UseVisualStyleBackColor = true;
            this.btnData.Click += new System.EventHandler(this.btnData_Click);
            // 
            // dgvSAggCampiProcedure
            // 
            this.dgvSAggCampiProcedure.AllowUserToAddRows = false;
            this.dgvSAggCampiProcedure.AllowUserToDeleteRows = false;
            this.dgvSAggCampiProcedure.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSAggCampiProcedure.Location = new System.Drawing.Point(555, 244);
            this.dgvSAggCampiProcedure.Name = "dgvSAggCampiProcedure";
            this.dgvSAggCampiProcedure.RowHeadersVisible = false;
            this.dgvSAggCampiProcedure.Size = new System.Drawing.Size(276, 196);
            this.dgvSAggCampiProcedure.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 450);
            this.Controls.Add(this.dgvSAggCampiProcedure);
            this.Controls.Add(this.btnData);
            this.Controls.Add(this.dgvSAggProcedure);
            this.Controls.Add(this.txtData);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAggDB);
            this.Controls.Add(this.dgvStoricoAggiornamenti);
            this.Controls.Add(this.dgvStoricoCancellazioni);
            this.Controls.Add(this.dgvDriver);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDriver)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStoricoCancellazioni)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStoricoAggiornamenti)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSAggProcedure)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSAggCampiProcedure)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDriver;
        private System.Windows.Forms.DataGridView dgvStoricoCancellazioni;
        private System.Windows.Forms.DataGridView dgvStoricoAggiornamenti;
        private System.Windows.Forms.Button btnAggDB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtData;
        private System.Windows.Forms.DataGridView dgvSAggProcedure;
        private System.Windows.Forms.Button btnData;
        private System.Windows.Forms.DataGridView dgvSAggCampiProcedure;
    }
}

