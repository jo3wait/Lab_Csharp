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
    public partial class Frm_M26_array : Form
    {
        public Frm_M26_array()
        {
            InitializeComponent();
        }

        private void btnArray_Click(object sender, EventArgs e)
        {
            //int[] arr = new int[3];
            //arr[0] = 1;
            //arr[1] = 2;
            //arr[2] = 3;
            ////arr[3] = 4; //Error: out of range

            //int[] arr = new int[3] { 1, 2, 3 };
            //int[] arr = { 1, 2, 3 };

            //MessageBox.Show(arr[2].ToString());

            int[] arr = new int[3];
            string result = "";
            for (int i = 0; i <3; i++)
            {
                arr[i] = 1+i;
                result += arr[i]+", ";            
            }
            MessageBox.Show(result);
        }

        private void btnMultiArray_Click(object sender, EventArgs e)
        {
            //int[,] arr = new int[3,2];
            //arr[0, 0] = 1;
            //arr[0, 1] = 2;
            //arr[1, 0] = 3;
            //arr[1, 1] = 4;
            //arr[2, 0] = 5;
            //arr[2, 1] = 6;

            //int[,] arr = new int[3, 2]
            //{
            //    { 1, 2},
            //    { 3, 4},
            //    { 5, 6}
            //};

            int[,] arr =
            {
                { 1, 2},
                { 3, 4},
                { 5, 6}
            };


            string result = "";
            
            for (int i = 0; i < arr.GetLength(0) ; i++)
            {
                for(int j = 0; j < arr.GetLength(1); j++)
                {
                    result += $"[{i}, {j}] -> {arr[i, j]}\n";
                }                
            }
            MessageBox.Show(result);
        }

        private void btnCreateArray_Click(object sender, EventArgs e)
        {
            int[] intArr = CreateIntArray(20);

            string result = "";
            //for (int i = 0; i < intArr.Length; i++)
            //{
            //   result += intArr[i] + ", ";
            //}

            foreach (int item in intArr)
            {
                result += item + "\n";
            }

            MessageBox.Show(result);
        }

        int[] CreateIntArray(int Length)
        {
            int[] arr = new int[Length];
            for (int i = 0; i<arr.Length; i++)
            {
                arr[i] = i + 1;
            }
            return arr;
        }

        private void btnMemberArray_Click(object sender, EventArgs e)
        {
            //todo 未完成
            //Member[] arrMember = new Member[2];
            //
            //arrMember[0].Name = "Joyce";


            Member mem1 = new Member() { Name = "Joyce", Age = 20 };
            Member mem2 = new Member() { Name = "Martin", Age = 21 };
            Member[] arrMember = new Member[2] { mem1, mem2 };

            //Member[] arrMember =
            //{
            //    new Member() { Name = "Joyce", Age = 20 },
            //    new Member() { Name = "Martin", Age = 21 }
            //};

            //MessageBox.Show($"Name: {arrMember[0].Name}, Age:{arrMember[0].Age}");

            string result = "";
            //for (int i = 0; i < arrMember.Length; i++)
            //{
            //    result += $"Name: {arrMember[i].Name}, Age:{arrMember[i].Age}\n";
            //}

            foreach (Member item in arrMember)
            {
                result += $"Name: {item.Name}, Age:{item.Age}\n";
            }

            MessageBox.Show(result);
        }

        //int[] arr = { 4, 8, 2, 10, 6, 10 };
        //int a = Array.LastIndexOf(arr, 10));


    }
}
