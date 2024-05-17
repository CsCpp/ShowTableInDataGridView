using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ShowTableInDataGridView
{
    public partial class Form1 : Form
    {
        private SqlConnection sqlConnection= null;
        private SqlDataAdapter adapter = null;
        private DataTable table = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            table.Clear();

            adapter.Fill(table);

            dataGridView1.DataSource = table;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            sqlConnection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\RZA\source\repos\ShowTableInDataGridView\ShowTableInDataGridView\Database1.mdf;Integrated Security=True");
            sqlConnection.Open();

            adapter = new SqlDataAdapter("SELECT * FROM User",sqlConnection);

            table = new DataTable();
            try
            {
                adapter.Fill(table);
            }
            catch (Exception )
            {

               
            }

            try
            {
                dataGridView1.DataSource = table;
            }
            catch (Exception)
            {

              
            }
           

        
        }
    }
}
