using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ApartmanOtomasyon
{
    public partial class Giderler : Form
    {
        public Giderler()
        {
            InitializeComponent();
        }
        SqlHelper sqlHelper = new SqlHelper();
        private void button1_Click(object sender, EventArgs e)
        {
            
            int para = (int)numericUpDown1.Value;
            DateTime yeni = dateTimePicker1.Value;
            string giderler = "";
            foreach (Control i in groupBox1.Controls) {
                if (i is CheckBox && ((CheckBox)i).Checked) {
                    giderler += ", "+ i.Text;
                }
            }
            giderler = giderler.Remove(0, 1);

            SqlParameter p1 = new SqlParameter("Para", para);
            SqlParameter p2 = new SqlParameter("Tarih", yeni);
            SqlParameter p3 = new SqlParameter("Gider", giderler);

            sqlHelper.ExecuteProc("giderlerim", p1, p2, p3);
        }
        private void Giderler_Load(object sender, EventArgs e)
        {
            DataTable veri = sqlHelper.GetTable("SELECT * from Giderler");

            foreach (DataRow dr in veri.Rows)
            {
                listBox1.Items.Add(dr["Gider"]).ToString();
                listBox2.Items.Add(dr["Para"]).ToString();
                listBox3.Items.Add(dr["Tarih"]).ToString();
            }
        }
    }
}
