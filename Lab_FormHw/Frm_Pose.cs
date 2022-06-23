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

namespace Lab_FormHw
{
    public partial class Frm_Pose : Form
    {
        public Frm_Pose()
        {
            InitializeComponent();
        }


        //PoseProduct lstProduct = new PoseProduct();

        //void ShowList()
        //{
        //    for (int i = 0; i < lstProduct.; i++)
        //    {
        //        labList.Text += $"{lstProduct.ProductName} x {lstProduct.ProductCount} = " +
        //            $"{lstProduct.ProductPrice* lstProduct.ProductCount:c0}\n"; // unboxing
        //    }            
        //}

        int countBeer = 0;        
        int priceBeer = 0;
        int countTequila = 0;
        int priceTequila = 0;
        int countWhisky = 0;
        int priceWhisky = 0;
        int countWine = 0;
        int priceWine = 0;
        int totalPrice = 0;

        private void btnProduct1_Click(object sender, EventArgs e)
        {
            //labList.Text = "";
            countBeer += 1;
            priceBeer = 120 * countBeer;
            //labList.Text += $"啤酒 Beer x { countBeer}, 共{ priceBeer}元\n";
            //lstShow();

            ShowTotal();
        }

        private void btnProduct2_Click(object sender, EventArgs e)
        {
            //labList.Text = "";
            countTequila += 1;
            priceTequila = 180 * countTequila;
            //labList.Text += $"龍舌蘭 Tequila x { countTequila}, 共{ priceTequila}元\n";
            //lstShow();

            ShowTotal();
        }

        private void btnProduct3_Click(object sender, EventArgs e)
        {
            countWhisky += 1;
            priceWhisky = 350 * countWhisky;

            ShowTotal();
        }

        private void btnProduct4_Click(object sender, EventArgs e)
        {
            countWine += 1;
            priceWine = 320 * countWine;

            ShowTotal();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            labList.Text = "尚未點餐";
            labTotal.Text = "NT$ 0";
        }

        void ShowTotal()
        {
            totalPrice = priceBeer + priceTequila + priceWhisky + priceWine;
            labTotal.Text = $"{totalPrice:c0}";
        }              

        private void btnCash_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"總金額: {totalPrice:c0}");
        }

        private void btnCredit_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"總金額: {totalPrice:c0}\n" +
                $"折扣後金額: {totalPrice*0.9:c0}");
        }
    }
}
