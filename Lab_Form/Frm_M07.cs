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
    public partial class Frm_M07 : Form
    {
        public Frm_M07()
        {
            InitializeComponent();
        }

        private void btn_M07_member_Click(object sender, EventArgs e)
        {
            //@物件初始化1_建立實體後再給予內容值
            Member mem1 = new Member(); //類別實作
            mem1.Name = "Joyce"; //存入資料(等號左邊)
            mem1.Age = 20;

            //string name = mem1.Name; //存取資料(等號右邊)
            //int age = mem1.Age;

            //MessageBox.Show("姓名: " + name + "，年齡: " + age);

            MessageBox.Show("姓名: " + mem1.Name + "，年齡: " + mem1.Age);

            //@物件初始化2_建立實體同時給予內容值
            Member mem2 = new Member()
            {
                Name = "Martin",
                Age = 20
            };
            MessageBox.Show("姓名: " + mem2.Name + "，年齡: " + mem2.Age);
        }

        //@製作註冊事件
        //按下btn01後btn02才被註冊才能使用
        private void btnRegister_Click(object sender, EventArgs e)
        {
            //自建
            //this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            //Designer.cs檔裡有，EventHandler為delegate委派(定義方法的格式)
            btnRegister01.Click += new EventHandler(btnRegister01_Click);

            //自動產生
            //+=無空格直接打按tab自動產生
            btnRegister02.Click += BtnRegister02_Click;            
        }

        //自動產生方法
        private void BtnRegister02_Click(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            MessageBox.Show("Register02");
        }

        //自建方法btnRegister01_Click
        private void btnRegister01_Click(object sender, EventArgs e)
        {
            //throw new NotImplementedException();  //自動產生可以刪去
            MessageBox.Show("Register01");
        }

        //@解除註冊
        private void btnDis_Click(object sender, EventArgs e)
        {
            btnRegister01.Click -= new EventHandler(btnRegister01_Click);
        }

        //@delegate
        private void btnDiscount_Click(object sender, EventArgs e)
        {
            Payment pay;
            MyFirstClass mc = new MyFirstClass();
            if(cmbDiscount.Text == "50%off")
            {
                pay = mc.Discount50off;
            }
            else
            {
                pay = mc.Discount20off;
            }

            double price = double.Parse(txtPrice.Text);
            double result = pay(price);
            MessageBox.Show(result.ToString());
        }
        
        // delegate委派 指向多個方法(前置作業)
        //delegate double Payment(double Price);
        //double Discount50off(double Price)
        //{
        //    return Price * 0.5;
        //}
        //double Discount20off(double Price)
        //{
        //    return Price * 0.8;
        //}

        private void SetProperty_Click(object sender, EventArgs e)
        {
            //按下按鈕變更視窗標題文字
            //this可略，指此類別本身，教義閱讀及自動選取.屬性
            this.Text = "Set Property";
        }

        private void btnMsgBox_Click(object sender, EventArgs e)
        {
            //DialogResult 是自定義result變數的型態
            DialogResult result = MessageBox.Show("請問今天是星期二嗎?", "問你喔~",
                MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if(result == DialogResult.Yes)
            {
                MessageBox.Show("不是喔! 今天是" + DateTime.Now.DayOfWeek);
            }
            else if(result == DialogResult.No)
            {
                MessageBox.Show("沒錯! 今天是" + DateTime.Now.DayOfWeek);
            }
            else
            {
                MessageBox.Show("Bye~");
            }
        }

        private void btnDiaRes_Click(object sender, EventArgs e)
        {
            Frm_M02_HelloForm frmHello = new Frm_M02_HelloForm();
            DialogResult result = frmHello.ShowDialog();
            if(result == DialogResult.OK)
            {
                MessageBox.Show("OK");
            }
        }
    }
}
