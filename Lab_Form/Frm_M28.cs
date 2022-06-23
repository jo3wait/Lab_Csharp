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
    public partial class Frm_M28 : Form
    {
        public Frm_M28()
        {
            InitializeComponent();
        }

        // Overload 同名方法
        void Swap(ref int A, ref int B)
        {
            int T = A;
            A = B;
            B = T;
        }

        void Swap(ref string A, ref string B)
        {
            string T = A;
            A = B;
            B = T;
        }

        void Swap(ref Member A, ref Member B)
        {
            Member T = A;
            A = B;
            B = T;
        }

        void Swap(ref Product A, ref Product B)
        {
            Product T = A;
            A = B;
            B = T;
        }

        void Swap(ref Point A, ref Point B)
        {
            Point T = A;
            A = B;
            B = T;
        }

        // Generic 泛用方法
        //方法相同只是參數型態不同時
        void GenericSwap<Tt>(ref Tt A, ref Tt B)
        {
            Tt T = A;
            A = B;
            B = T;
        }

        void GenericSwap<Tt, Y>(ref Tt A, ref Tt B) //可以放入多個泛用型態
        {
            Tt T = A;
            A = B;
            B = T;
        }

        private void btnSwapInt_Click(object sender, EventArgs e)
        {
            int a = 100, b = 200;
            MessageBox.Show($"a: {a}, b: {b}");

            Swap(ref a, ref b);
            MessageBox.Show($"a: {a}, b: {b}");
        }

        private void btnSwapString_Click(object sender, EventArgs e)
        {
            string a = "AAA", b = "BBB";
            MessageBox.Show($"a: {a}, b: {b}");

            Swap(ref a, ref b);
            MessageBox.Show($"a: {a}, b: {b}");
        }

        private void btnSwapMember_Click(object sender, EventArgs e)
        {
            Member a = new Member() { Name = "Joyce", Age = 20 }, 
                b = new Member() { Name = "Martin", Age = 21 };

            MessageBox.Show($"a: {a.Name} , b:{b.Name}");

            Swap(ref a, ref b);

            MessageBox.Show($"a: {a.Name}, b: {b.Name}");
        }

        private void btnSwapStruct_Click(object sender, EventArgs e)
        {
            Product a = new Product("AAA", 100), b = new Product("BBB", 1000);

            MessageBox.Show($"a: {a.ProductName} , b:{b.ProductName}");

            Swap(ref a, ref b);

            MessageBox.Show($"a: {a.ProductName}, b: {b.ProductName}");
        }
        
        private void btnSwapPoint_Click(object sender, EventArgs e)
        {
            Point a = new Point(100, 100), b = new Point(200, 200);

            MessageBox.Show($"a: {a} , b:{b}");

            Swap(ref a, ref b);

            MessageBox.Show($"a: {a} , b:{b}");
        }

        // Generic
        private void btnGenericSwap_Click(object sender, EventArgs e)
        {
            int a = 100, b = 200;
            GenericSwap<int>(ref a, ref b);
            MessageBox.Show($"a: {a}, b: {b}");

            string s1 = "AAA", s2 = "BBB";
            GenericSwap<string>(ref s1, ref s2);
            MessageBox.Show($"a: {s1}, b: {s2}");

            Member m1 = new Member() { Name = "Joyce", Age = 20 },
               m2 = new Member() { Name = "Martin", Age = 21 };
            GenericSwap<Member>(ref m1, ref m2);
            MessageBox.Show($"a: {m1.Name}, b: {m2.Name}");

            Product p1 = new Product("AAA", 100), p2 = new Product("BBB", 1000);
            GenericSwap<Product>(ref p1, ref p2);
            MessageBox.Show($"a: {p1.ProductName}, b: {p2.ProductName}");
        
            Point point1 = new Point(100, 100), point2 = new Point(200, 200);
            MessageBox.Show($"a: {point1} , b:{point2}");
        }
    }
}
