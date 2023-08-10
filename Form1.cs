using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Dayli_platform
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        MySqlConnection road = new MySqlConnection("Server=localhost; Database=platform_database; uid=root; pwd=Ali@2006");

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                road.Open();
                MySqlDataAdapter adp = new MySqlDataAdapter("select * from dayli_platform", road);
                DataTable dt = new DataTable();
                adp.Fill(dt);
                dataGridView1.DataSource = dt;
                road.Close();
            }
            catch(Exception error) {
                MessageBox.Show(error.Message);
            }
            
        }
    }
}
