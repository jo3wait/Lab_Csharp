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

        // Generic
        void GenericSwap<Tt>(ref Tt A, ref Tt B)
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
            //todo 未完成
            Member a = new Member();
            Member b = new Member();
            a.Name = "Joyce";
            b.Name = "Martin";
            Swap(ref a, ref b);
            MessageBox.Show($"a: {a.Name}, b: {b.Name}");
        }

        private void btnGenericSwap_Click(object sender, EventArgs e)
        {
            int a = 100, b = 200;
            GenericSwap<int>(ref a, ref b);
            MessageBox.Show($"a: {a}, b: {b}");

            string s1 = "AAA", s2 = "BBB";
            GenericSwap<string>(ref s1, ref s2);
            MessageBox.Show($"a: {s1}, b: {s2}");
        }

        
    }
}
