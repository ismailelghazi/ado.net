using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP
{
    public partial class Form1 : Form
    {
        string connectionString = @"data source=localhost; initial catalog=tp12; integrated security=true";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            getVilles();
            getClient();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int ligne = e.RowIndex;
            int posCl = e.ColumnIndex;
            if(posCl == 5)
            {
                if(dataGridView1.CurrentRow != null)
                {
                    int id = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                    string nom = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                    string prenom = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                    string datenaiss = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                    int idVille = int.Parse(dataGridView1.CurrentRow.Cells[4].Value.ToString());
                    modification(id, nom, prenom, datenaiss, idVille);
                    getClient();
                    dataGridView1.Rows[ligne].DefaultCellStyle.BackColor = Color.LightGreen;
                    txtLabel.Text = string.Format("Modification success du client {0}....", nom);
                }
            }
        }
        void modification(int id , string nom , string prenom , string datenaiss , int idVille)
        {
            using (SqlConnection cn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("update client set nom = @nom , prenom = @prenom , datenaiss = @datenaiss , idVille  = @idVille where id = @id", cn);
                cmd.Parameters.AddWithValue("@nom", nom);
                cmd.Parameters.AddWithValue("@prenom", prenom);
                cmd.Parameters.AddWithValue("@datenaiss", datenaiss);
                cmd.Parameters.AddWithValue("@idVille", idVille);
                cmd.Parameters.AddWithValue("@id", id);
                cn.Open();
                cmd.ExecuteNonQuery();
            }
        }
        private void getClient()
        {
            using(SqlConnection cn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("select client.* , 'Modifier' as Modifier from client", cn);
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                dataGridView1.DataSource = dt;

            }
        }
        private void getVilles()
        {
            using (SqlConnection cn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("select * from ville", cn);
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                DataRow r = dt.NewRow();
                r[0] = 0;
                r[1] = "choisir ...";
                dt.Rows.InsertAt(r, 0);
                dataGridView1.DataSource = dt;
                nomVille.DataSource = dt;
                nomVille.DisplayMember = "nomV";
                nomVille.ValueMember = "id";
                comboBoxVille.DataSource = dt;
                comboBoxVille.DisplayMember = "nomV";
                comboBoxVille.ValueMember = "id";
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if(dataGridView1.CurrentRow != null)
            {
                dataGridView1.CurrentCell.Style.BackColor = Color.Cyan;
            }
        }

        private void btnAfficher_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow r in dataGridView1.Rows)
            {
                
                    r.DefaultCellStyle.BackColor = Color.White;
                
            }
            foreach (DataGridViewRow r in dataGridView1.Rows)
            {
                if(r.Cells[4].Value.ToString() == comboBoxVille.SelectedValue.ToString())
                { 
                    r.DefaultCellStyle.BackColor = Color.Red;
                }
            }
        }
    }
}
