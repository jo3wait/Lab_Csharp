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
    public partial class Frm_M18_enum : Form
    {
        public Frm_M18_enum()
        {
            InitializeComponent();
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            // button 屬性-Enabled 改為 false
            MessageBox.Show("Product");
        }

        private void btnCertify_Click(object sender, EventArgs e)
        {
            //Admin => 0
            //User => 1
            //int Role = 0;
            //if(Role == 0)
            //{
            //    btnProduct.Enabled = true;
            //}
            //else
            //{
            //    btnProduct.Enabled = false;
            //}
            int Admin = 0, User = 1; //設為變數，改變規則時才不用一個個改
            int Role = 0;

            //if (Role == Admin)
            //{
            //    btnProduct.Enabled = true;
            //}
            //else
            //{
            //    btnProduct.Enabled = false;
            //}
            btnProduct.Enabled = Role == Admin; //btnProduct.Enabled = Role == Admin? true:false;
        }

        private void btnConst_Click(object sender, EventArgs e)
        {
            //Admin => 0
            //User => 2
            int Role = 0;
            const int Admin = 0, User = 2; //設為常數才不會不小心被修改
            //Admin = 1;  //設常數不會被變更
            if (Role == Admin)
            {
                btnProduct.Enabled = true;
            }
            else
            {
                btnProduct.Enabled = false;
            }
        }

        private void btnEnum_Click(object sender, EventArgs e)
        {
            //Admin => 0
            //User => 2
            //int Role = 0;
            //if (Role == (int)UserRole.Admin) //雙等號兩側要相同資料型態才能比較 //轉為int
            //{
            //    btnProduct.Enabled = true;
            //}
            //else
            //{
            //    btnProduct.Enabled = false;
            //}

            UserRole Role = UserRole.Admin;
            if(Role == UserRole.Admin) //直接將Role定義為enum
            {
                btnProduct.Enabled = true;
            }
            else
            {
                btnProduct.Enabled = false;
            }
        }

        private void btnEnumCase_Click(object sender, EventArgs e)
        {
            UserRole Role = UserRole.Admin;
            //UserRole Role = UserRole.User2; //則下面都不執行
            switch (Role)
            {
                case UserRole.Admin:
                    btnProduct.Enabled = true;
                    break;
                case UserRole.User:
                    btnProduct.Enabled = false;
                    break;
            }
        }
    }
}
