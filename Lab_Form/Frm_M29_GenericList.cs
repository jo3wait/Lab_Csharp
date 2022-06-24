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
    public partial class Frm_M29_GenericList : Form
    {
        public Frm_M29_GenericList()
        {
            InitializeComponent();
        }

        List<Employee> lstEmp = new List<Employee>();

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int age = 0;
            Employee emp;
            emp.Name = txtEmpName.Text;
            
            if (int.TryParse(txtEmpAge.Text, out age))
            {
                emp.Age = age;
                lstEmp.Add(emp);
            }
            else
            {
                MessageBox.Show("請輸入數字");
            }

            ShowEmployee();
        }

        void ShowEmployee()
        {
            labShow.Text = "員工\n";

            //for (int i = 0; i < lstEmp.Count; i++)
            //{
            //    labShow.Text += $"姓名: {lstEmp[i].Name}, " +
            //        $"年齡: {lstEmp[i].Age}\n"; 
            //}

            foreach (Employee item in lstEmp)
                labShow.Text += $"姓名: {item.Name}, " + $"年齡: {item.Age}\n";

            labShow.Text += $"---------------\n員工總計: {lstEmp.Count}人";
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            Employee emp;
            emp.Name = txtEmpName.Text;
            emp.Age = int.Parse(txtEmpAge.Text);

            lstEmp.Insert(0, emp); //此指定插入第一個(索引0)

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

            lstEmp.RemoveAt(lstEmp.Count - 1); //此指定刪去最後一個

            ShowEmployee();
        }

        private void btnAddDif_Click(object sender, EventArgs e)
        {
            //lstEmp.Add(100);
            //lstEmp.Add("strng");  //有設定型態，出現錯誤不能加入

            ShowEmployee();
        }
    }
}
