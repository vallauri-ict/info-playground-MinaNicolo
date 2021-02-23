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

        public Form1()
        {
            InitializeComponent();
        }

        private void cmbNazioni_SelectedValueChanged(object sender, EventArgs e)
        {
            dgvDriver.Rows.Clear();
            dgvData(cmbNazioni.Text);
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
            string s = "number;full_name;country;date_birth;team_id;podiums_number";
            settaDGV(1, 6, dgvDriver, s);
        }
        private void dgvData(string nazione)
        {
            string sql = $"SELECT * FROM fNazioni('{nazione}')";

            using (SqlConnection connection =
                    new SqlConnection(CONNECTION_STRING))
            {
                SqlCommand command = new SqlCommand(sql, connection);
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                int i = 0;
                while (reader.Read())
                {
                    dgvDriver.Rows.Add();
                    dgvDriver.Rows[i].Cells[0].Value = reader.GetValue(0).ToString();
                    dgvDriver.Rows[i].Cells[1].Value = reader.GetValue(1).ToString();
                    dgvDriver.Rows[i].Cells[2].Value = reader.GetValue(2).ToString();
                    dgvDriver.Rows[i].Cells[3].Value = reader.GetValue(3).ToString();
                    dgvDriver.Rows[i].Cells[4].Value = reader.GetValue(4).ToString();
                    dgvDriver.Rows[i].Cells[5].Value = reader.GetValue(5).ToString();
                    i++;
                }

                reader.Close();
            }
        }

        private void settaDGV(int r, int c, DataGridView dgv, string s)
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

        private void btnPodiumsNumber_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32(nPodiums.Value);
            string sql = $"SELECT * FROM fPodiumsNumber({num})";
            using (SqlConnection connection =
                    new SqlConnection(CONNECTION_STRING))
            {
                SqlCommand command = new SqlCommand(sql, connection);
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                string output = "";
                while (reader.Read())
                {
                    output+= reader.GetValue(1).ToString()+
                        " -- number podiums: "+ reader.GetValue(5).ToString() + "\n";
                }
                reader.Close();
                MessageBox.Show(output);
            }
        }
    }
}
