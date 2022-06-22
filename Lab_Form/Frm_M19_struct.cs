using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_Form
{
    public partial class Frm_M19_struct : Form
    {
        public Frm_M19_struct()
        {
            InitializeComponent();
        }

        //@Struct
        //struct建立於Utility.cs

        string result = "產品";
        int count = 0;
        decimal total = 0;

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ////Product pro; 
            ////pro.ProductName = txtProductName.Text;
            ////pro.ProductPrice = decimal.Parse(txtProductPrice.Text);
            
            //Product pro = new Product(txtProductName.Text, decimal.Parse(txtProductPrice.Text));
            ////result += "\n名稱: " + pro.ProductName + ", 單價: " + pro.ProductPrice;
            //result += $"\n名稱: {pro.ProductName}, 單價: {pro.ProductPrice:c0}";
            ////count += 1; 
            //count++;
            //total += pro.ProductPrice;
            decimal price = 0;
            bool isNum = decimal.TryParse(txtProductPrice.Text, out price);
            if(isNum)
            {
                Product pro = new Product(txtProductName.Text, price);
                result += $"\n名稱: {pro.ProductName}, 單價: {price:c0}";
                count++;
                total += price;
            }
            else
            {
                MessageBox.Show("請輸入正確數字格式!");
                //txtProductPrice.Text = ""; //將內容清除
                txtProductPrice.Clear(); //將內容清除
                txtProductPrice.Focus(); //將游標停在該TextBox
            }
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            ////labShow.Text = result + "\n--------------\n共計: " + count + "項, 總計: " + total + "元";
            labShow.Text = result + $"\n--------------\n共計: {count}項, 總計: {total:c0}元";
        }
    }
}
