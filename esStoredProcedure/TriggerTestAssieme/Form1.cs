using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TriggerTestAssieme
{
    public partial class Form1 : Form
    {
        public static readonly string workingDirectory = Environment.CurrentDirectory;
        public static readonly string projectDirectory = Directory.GetParent(workingDirectory).Parent.Parent.FullName;
        public static readonly string CONNECTION_STRING = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + projectDirectory + @"\DriverDB.mdf;Integrated Security=True;Connect Timeout=30";

        private BindingSource bsDriver = new BindingSource();
        private BindingSource bsStoricoCancellazioni = new BindingSource();
        private BindingSource bsStoricoAggiornamenti = new BindingSource();
        private DataTable dtDriver, dtStoricoCancellazioni, dtStoricoAggiornamenti;
        private SqlDataAdapter daDriver, daStoricoCancellazioni, daStoricoAggiornamenti;


        public Form1()
        {
            InitializeComponent();
        }

        private void OnDblClickDriver(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void OnRowsDeletedDriver(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            daDriver.Update(dtDriver);
            PopulateDgv(2);
        }

        private void btnAggDB_Click(object sender, EventArgs e)
        {
            daDriver.Update(dtDriver);
            PopulateDgv(0);
        }

        private void btnData_Click(object sender, EventArgs e)
        {
            dgvSAggProcedure.Rows.Clear();
            dgvSAggCampiProcedure.Rows.Clear();
            using (SqlConnection con = new SqlConnection(CONNECTION_STRING))
            {
                string sql = "Procedure1";
                con.Open();
                SqlCommand cmd = new SqlCommand(sql, con);
                SqlParameter data = new SqlParameter();
                data.ParameterName = "data";
                data.Direction = ParameterDirection.Input;
                data.DbType = DbType.DateTime;
                data.Size = 50;
                data.Value = Convert.ToDateTime(txtData.Text);
                cmd.Parameters.Add(data);

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.CommandText = "Procedure1";

                SqlDataReader reader1 = cmd.ExecuteReader();

                int i = 0;
                while (reader1.Read())
                {
                    dgvSAggProcedure.Rows.Add();
                    dgvSAggProcedure.Rows[i].Cells[0].Value = reader1.GetValue(0).ToString();
                    dgvSAggProcedure.Rows[i].Cells[1].Value = reader1.GetValue(1).ToString();
                    i++;
                }

                reader1.Close();

                i = 0;
                cmd.CommandText = "Procedure2";  // Ritorna una tabella

                SqlDataReader reader2 = cmd.ExecuteReader();

                while (reader2.Read())
                {
                    dgvSAggCampiProcedure.Rows.Add();
                    dgvSAggCampiProcedure.Rows[i].Cells[0].Value = reader2.GetValue(0).ToString();
                    dgvSAggCampiProcedure.Rows[i].Cells[1].Value = reader2.GetValue(1).ToString();
                    dgvSAggCampiProcedure.Rows[i].Cells[2].Value = reader2.GetValue(2).ToString();
                    dgvSAggCampiProcedure.Rows[i].Cells[3].Value = reader2.GetValue(3).ToString();
                    dgvSAggCampiProcedure.Rows[i].Cells[4].Value = reader2.GetValue(4).ToString();
                    dgvSAggCampiProcedure.Rows[i].Cells[5].Value = reader2.GetValue(5).ToString();
                    dgvSAggCampiProcedure.Rows[i].Cells[6].Value = reader2.GetValue(6).ToString();
                    dgvSAggCampiProcedure.Rows[i].Cells[7].Value = reader2.GetValue(7).ToString();
                    dgvSAggCampiProcedure.Rows[i].Cells[8].Value = reader2.GetValue(14).ToString();
                }
                reader2.Close();
            }
        }

        public static void settaDGV(int r, int c, DataGridView dgv, string s)
        {
            string[] v = new string[c];
            v = s.Split(';');
            dgv.RowCount = r;
            dgv.ColumnCount = c;
            for (int i = 0; i < c; i++)
                dgv.Columns[i].HeaderText = v[i];
            dgv.RowHeadersVisible = false;
            dgv.AutoResizeColumns();
            dgv.ClearSelection();
        }

        private void Query(string selectCommand, out SqlDataAdapter da)
        {
            da = null;
            try
            {
                // Crea un nuovo data adapter basato su selectCommand
                da = new SqlDataAdapter(selectCommand, CONNECTION_STRING);

                // Creo un command builder per generare un comando SQL update, insert, delete
                SqlCommandBuilder commandBuilder = new SqlCommandBuilder(da);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PopulateDgv(0);
            string s1 = "id;data";
            settaDGV(1, 2, dgvSAggProcedure, s1);
            string s2 = "id;idSAgg;num;fullName;country;dateBirth;teamId;podiumsNumber;data";
            settaDGV(1, 9, dgvSAggCampiProcedure, s2);
        }

        private void PopulateDgv(int tables)
        {
            switch (tables)
            {
                case 0:
                    dgvDriver.DataSource = bsDriver;
                    Query("SELECT * FROM Driver", out daDriver);
                    if (daDriver != null)
                    {
                        dtDriver = new DataTable();
                        daDriver.Fill(dtDriver);
                        bsDriver.DataSource = dtDriver;
                    }
                    dgvDriver.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);
                    
                    dgvStoricoCancellazioni.DataSource = bsStoricoCancellazioni;
                    Query("SELECT * FROM StoricoCancellazioni", out daStoricoCancellazioni);
                    if (daStoricoCancellazioni != null)
                    {
                        dtStoricoCancellazioni = new DataTable();
                        daStoricoCancellazioni.Fill(dtStoricoCancellazioni);
                        bsStoricoCancellazioni.DataSource = dtStoricoCancellazioni;
                    }

                    dgvStoricoCancellazioni.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);
                    
                    dgvStoricoAggiornamenti.DataSource = bsStoricoAggiornamenti;
                    Query("SELECT * FROM StoricoAggiornamenti", out daStoricoAggiornamenti);
                    if (daStoricoAggiornamenti != null)
                    {
                        dtStoricoAggiornamenti = new DataTable();
                        daStoricoAggiornamenti.Fill(dtStoricoAggiornamenti);
                        bsStoricoAggiornamenti.DataSource = dtStoricoAggiornamenti;
                    }

                    dgvDriver.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);
                    break;
                case 1:
                    dgvDriver.DataSource = bsDriver;
                    Query("SELECT * FROM Driver", out daDriver);
                    if (daDriver != null)
                    {
                        dtDriver = new DataTable();
                        daDriver.Fill(dtDriver);
                        bsDriver.DataSource = dtDriver;
                    }
                    dgvDriver.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);
                    break;
                case 2:
                    dgvStoricoCancellazioni.DataSource = bsStoricoCancellazioni;
                    Query("SELECT * FROM StoricoCancellazioni", out daStoricoCancellazioni);
                    if (daStoricoCancellazioni != null)
                    {
                        dtStoricoCancellazioni = new DataTable();
                        daStoricoCancellazioni.Fill(dtStoricoCancellazioni);
                        bsStoricoCancellazioni.DataSource = dtStoricoCancellazioni;
                    }

                    dgvStoricoCancellazioni.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);
                    break;
                case 3:
                    dgvStoricoAggiornamenti.DataSource = bsStoricoAggiornamenti;
                    Query("SELECT * FROM StoricoAggiornamenti", out daStoricoAggiornamenti);
                    if (daStoricoAggiornamenti != null)
                    {
                        dtStoricoAggiornamenti = new DataTable();
                        daStoricoAggiornamenti.Fill(dtStoricoAggiornamenti);
                        bsStoricoAggiornamenti.DataSource = dtStoricoAggiornamenti;
                    }

                    dgvDriver.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);
                    break;
            }
        }
    }
}
