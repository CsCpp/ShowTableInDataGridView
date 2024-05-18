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
        private DataTable dataTable = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            dataTable.Clear();


      adapter.Fill(dataTable);

          dataGridView1.DataSource = dataTable;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            sqlConnection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\RZA\source\repos\ShowTableInDataGridView\ShowTableInDataGridView\Database1.mdf;Integrated Security=True");
            sqlConnection.Open();

            adapter = new SqlDataAdapter("SELECT * FROM [User]", sqlConnection);

            dataTable = new DataTable();
            adapter.Fill(dataTable);

            dataGridView1.DataSource = dataTable;

            // DataSet ds = new DataSet();
            //adapter.Fill(ds);
            //dataGridView1.DataSource = ds.Tables[0];






        }
    }
}
