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

namespace Apartment_automation
{
    public partial class Gelirler : Form
    {
        public Gelirler()
        {
            InitializeComponent();
        }
        SqlHelper Helper = new SqlHelper();
        private void btn_add_income_Click(object sender, EventArgs e)
        {
            int No = Convert.ToInt32(comboBox1.SelectedItem);
            int Payment =Convert.ToInt32( numericUpDown1.Value );
            DateTime PaymentDate = dateTimePicker1.Value;

            SqlParameter parameter1 = new SqlParameter("ApartmentNo",No);
            SqlParameter parameter2 = new SqlParameter("Payment", Payment);
            SqlParameter parameter3 = new SqlParameter("PaymentDate", PaymentDate);

            Helper.ExecuteProcedure("get_payment", parameter1, parameter2, parameter3);

            MessageBox.Show("Ekleme Başarılı", "Successfull", MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void Gelirler_Load(object sender, EventArgs e)
        {
            DataTable data = Helper.GetDataTable("select ApartmenNo,Payment,PaymentDate from tbl_income");
            
            foreach (DataRow row in data.Rows)
            {
                listBox1.Items.Add("No : "+row[0]);
                listBox2.Items.Add("Payment : "+row[1]);
                listBox3.Items.Add("Date : "+row[2]);

            }
        }
    }
}
