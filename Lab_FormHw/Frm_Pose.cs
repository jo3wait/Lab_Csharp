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

        int countBeer, countTequila, countWhisky, countWine;
        int priceBeer, priceTequila, priceWhisky, priceWine, totalPrice;
        int pricePerBeer = 120, pricePerTequila = 180, 
            pricePerWhisky = 350, pricePerWine = 320;
        string showBeer, showTequila, showWhisky, showWine;

        private void btnProduct1_Click(object sender, EventArgs e)
        {
            countBeer += 1;
            priceBeer = pricePerBeer * countBeer;
            if (countBeer >= 1)
            {
                showBeer = $"啤酒 Beer x { countBeer}, 共{ priceBeer}元\n";
            }
           
            Total();
        }

        private void btnProduct2_Click(object sender, EventArgs e)
        {
            countTequila += 1;
            priceTequila = pricePerTequila * countTequila;
            if (countTequila >= 1)
            {
                showTequila = $"龍舌蘭 Tequila x { countTequila}, 共{ priceTequila}元\n";
            }

            Total();
        }

        private void btnProduct3_Click(object sender, EventArgs e)
        {
            countWhisky += 1;            
            priceWhisky = pricePerWhisky * countWhisky;
            if (countWhisky >= 1)
            {
                showWhisky = $"威士忌 Whisky x { countWhisky}, 共{ priceWhisky}元\n";
            }
            Total();
        }

        private void btnProduct4_Click(object sender, EventArgs e)
        {
            countWine += 1;
            priceWine = pricePerWine * countWine;
            if (countWine >= 1)
            {
                showWine = $"紅酒 Wine x { countWine}, 共{ priceWine}元\n";
            }
            Total();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            labList.Text = "尚未點餐";
            showBeer = ""; showTequila = ""; showWhisky = "";showWine = "";
            countBeer = countTequila = countWhisky = countWine = 0;
            labTotal.Text = "NT$ 0";
        }

        void Total()
        {
            totalPrice = priceBeer + priceTequila + priceWhisky + priceWine;
            labTotal.Text = $"{totalPrice:c0}";
            labList.Text = (showBeer + showTequila + showWhisky + showWine);
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
