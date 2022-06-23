using System;
using System.Collections;
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
    public partial class Frm_M29 : Form
    {
        public Frm_M29()
        {
            InitializeComponent();
        }

        void ShowEmployee()
        {
            labShow.Text = "員工\n";

            for (int i = 0; i < lstEmp.Count; i++)
            {
                labShow.Text += $"姓名: {((Employee)lstEmp[i]).Name}, " +
                    $"年齡: {((Employee)lstEmp[i]).Age}\n"; // unboxing
            }

            labShow.Text += $"---------------\n員工總計: {lstEmp.Count}人";
        }

        ArrayList lstEmp = new ArrayList();
        private void btnAdd_Click(object sender, EventArgs e)
        {
            int age = 0;
            Employee emp;
            emp.Name = txtEmpName.Text;
            //emp.Age = int.Parse(txtEmpAge.Text);
            //bool isNum = int.TryParse(txtEmpAge.Text, out age);
            if(int.TryParse(txtEmpAge.Text, out age))
            {
                emp.Age = age;
                lstEmp.Add(emp);
            }
            else
            {
                MessageBox.Show("請輸入數字");
            }
            
            //lstEmp.Add(emp);
            // object -> boxing

            //labShow.Text = "員工\n";

            //for(int i=0; i<lstEmp.Count; i++)
            //{
            //    labShow.Text += $"姓名: {((Employee)lstEmp[i]).Name}, " +
            //        $"年齡: {((Employee)lstEmp[i]).Age}\n";
            //// unboxing
            //}
            ShowEmployee();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            Employee emp;
            emp.Name = txtEmpName.Text;
            emp.Age = int.Parse(txtEmpAge.Text);

            lstEmp.Insert(0,emp); //此指定插入第一個0

            ShowEmployee();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Employee emp;
            emp.Name = txtEmpName.Text;
            emp.Age = int.Parse(txtEmpAge.Text);

            lstEmp.Clear();

            ShowEmployee();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            Employee emp;
            emp.Name = txtEmpName.Text;
            emp.Age = int.Parse(txtEmpAge.Text);

            lstEmp.RemoveAt(lstEmp.Count-1); //此指定刪去最後一個

            ShowEmployee();
        }
    }
}
