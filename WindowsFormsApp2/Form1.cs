using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        Login login = null;

        public Form1(String userName,Login login)
        {
            InitializeComponent();
            lbl_username.Text = userName;
            this.login = login;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_Name_Click(object sender, EventArgs e)
        {
            Regex rg = new Regex(@"^[0-9]");
            Regex rg2 = new Regex(@"^[a-zA-Z]");

            errorProvider.Clear();

            //Checking if the inputs are given
            if (string.IsNullOrEmpty(txt_objectName.Text))
                errorProvider.SetError(txt_objectName, "The object name must be provided!");

            else if (string.IsNullOrEmpty(txt_IdNum.Text))
                errorProvider.SetError(txt_IdNum, "The number of object must be provided!");

            else if (string.IsNullOrEmpty(txt_count.Text))
                errorProvider.SetError(txt_count, "The count of the object must be provided!");

            else if (string.IsNullOrEmpty(txt_InventoryNum.Text))
                errorProvider.SetError(txt_InventoryNum, "The inventory number of the object must be provided!");

            else if (string.IsNullOrEmpty(txt_price.Text))
                errorProvider.SetError(txt_price, "The price of the object must be provided!");

            //Validating the inputs
            else if (!rg2.IsMatch(txt_objectName.Text))
                errorProvider.SetError(txt_objectName, "The Object name must only be words!");

            else if (!rg.IsMatch(txt_IdNum.Text))
                errorProvider.SetError(txt_IdNum, "The number must be a numeric type!");

            else if (!rg.IsMatch(txt_count.Text))
                errorProvider.SetError(txt_count, "The count must be a numeric type!");

            else if (!rg.IsMatch(txt_InventoryNum.Text))
                errorProvider.SetError(txt_InventoryNum, "The inventory number must be a numeric type!");

            else if (!rg.IsMatch(txt_price.Text))
                errorProvider.SetError(txt_price, "The price must be a numeric type!");
            else
            {
                Product product = new Product
                {
                    count = Convert.ToInt32(txt_count.Text),
                    price = Convert.ToInt32(txt_price.Text),
                    ObjectName = txt_objectName.Text,
                    InvetoryNumber = txt_InventoryNum.Text,
                    Date = dtp_date.Text,
                    ProductID = Convert.ToInt32(txt_IdNum.Text),
                    isAvailable = chk_isAvailable.Checked,
                };

                product.save();
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = Product.GetAllProducts();
                
            }
            String message = "";
            foreach (var item in checkedListBox1.CheckedItems)
            {
                message += item.ToString();
            }

        }

        private void btn_Name_MouseHover(object sender, EventArgs e)
        {
            //btn_Name.Location()
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            txt_count.Text = "";
            txt_IdNum.Text = "";
            txt_InventoryNum.Text = "";
            txt_objectName.Text = "";
            txt_price.Text = "";
            dtp_date.Text = "";
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
           
            this.Close();
        }

        private void txt_InventoryNum_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void chk_isAvailable_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            login.Show();
            this.Hide();
        }
    }
}
