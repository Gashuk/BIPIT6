using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Клиент
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ServiceReference1.Service1Client s = new ServiceReference1.Service1Client("NetTcpBinding_IService1");
            DataSet ds = s.GetData();
            dataGridView1.DataSource = ds.Tables[0];
            dataGridView1.Update();

            DataSet ds1 = s.FillVid_rabot();
            comboBox1.DataSource = ds1.Tables[0];
            comboBox1.DisplayMember = "Vid_rabot";
            comboBox1.ValueMember = "ID_VID_RABOT";

            DataSet ds2 = s.FillOboryd();
            comboBox2.DataSource = ds2.Tables[0];
            comboBox2.DisplayMember = "Model_oboryd";
            comboBox2.ValueMember = "ID_OBORYD";

        }
      

        private void Button_add_Click(object sender, EventArgs e)
        {
            ServiceReference1.Service1Client s = new ServiceReference1.Service1Client("NetTcpBinding_IService1");
            string ID_OBORYD = comboBox1.SelectedValue.ToString();
            string ID_VID_RABOT = comboBox2.SelectedValue.ToString();
            string Data_polychen = dateTimePicker1.Value.ToString("yyyy-MM-dd");
            string Data_vipolnen = dateTimePicker2.Value.ToString("yyyy-MM-dd");

            s.NewRec(ID_OBORYD, ID_VID_RABOT, Data_polychen, Data_vipolnen);
            Form1_Load(sender, e);
        }
    }
}
