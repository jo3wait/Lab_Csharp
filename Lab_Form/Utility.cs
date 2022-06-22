using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_Form
{
    //@ Partial Class
    //Partial Class 跨檔案共同編輯類別MyFirstClass
    //注意要在同一個namespace: Lab_Form底下
    partial class MyFirstClass
    {
        public void Method06()
        { 
            MessageBox.Show("Method Partial Class");
        }
            
    }

    //@建立類別
    public class Member 
    {
        public string Name; //欄位
        public int Age;
    }

    public class UseStatic
    {
        public int InstanceCount;
        public static int StaticCount;
    }

    //@製作列舉enum
    public enum UserRole
    {
        Admin ,
        User = 2,
        User2,        //最後一個","可加可不加
    }

    //Struct
    public struct Product
    {
        public string ProductName { get; set;}
        public decimal ProductPrice { get; set; }

        public Product(string Name, decimal Price)
        {
            ProductName = Name;
            ProductPrice = Price;
        }


    }
}
