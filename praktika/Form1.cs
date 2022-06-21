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

namespace praktika
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using(TitanEntities db = new TitanEntities())
            {
                chart1.DataSource = db.Mashinis.ToList();
                chart1.Series["Mashini"].XValueMember = "Aktivnost";
                chart1.Series["Mashini"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Auto;
                chart1.Series["Mashini"].YValueMembers = "Sostoyanie";
                chart1.Series["Mashini"].YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Auto;

               

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            ;
        }
    }
}
