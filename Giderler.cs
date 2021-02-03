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
    public partial class Giderler : Form
    {
        public Giderler()
        {
            InitializeComponent();
        }
        new SqlHelper Helper = new SqlHelper();
        private void Giderler_Load(object sender, EventArgs e)
        {
           DataTable dataTable = Helper.GetDataTable("select ExpenditureType,Cost,ExpenditureDate from tbl_expenditure");
            
            foreach (DataRow dataRow in dataTable.Rows)
            {
                listBox1.Items.Add("Type : " + dataRow[0]);
                listBox2.Items.Add("Cost : " + dataRow[1]);
                listBox3.Items.Add("Date : " + dataRow[2]);
            }

        }

        private void btn_add_cost_Click(object sender, EventArgs e)
        {
            int Cost = Convert.ToInt32(numericUpDown1.Value);
            DateTime Date = dateTimePicker1.Value;
            string ExpenditureType = "";

            foreach (Control item in groupBox1.Controls)
            {
                if (item is CheckBox && ((CheckBox)item).Checked)
                {
                    ExpenditureType += ","+item.Text;
                }
            }

            ExpenditureType = ExpenditureType.Remove(0, 1);

            SqlParameter parameter1 = new SqlParameter("Cost", Cost);
            SqlParameter parameter2 = new SqlParameter("ExpenditureDate", Date);
            SqlParameter parameter3 = new SqlParameter("ExpenditureType", ExpenditureType);


            Helper.ExecuteProcedure("expenditure", parameter1, parameter2, parameter3);
           
            MessageBox.Show("Ekleme Başarılı", "Successfull", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
