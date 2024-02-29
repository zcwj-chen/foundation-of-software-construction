using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //将文本框内的两个运算数分别转为double类型参与计算，并捕获输入不为数字的异常
            double n1 = 0, n2 = 0;
            try
            {
                n1 = double.Parse(num1.Text);
                n2 = double.Parse(num2.Text);
            }catch(Exception ex)
            {
                result.Text = ex.Message;
                return;
            }           

            decimal d = 0m;      //确保小数计算的精确度，避免误差
            //运算符菜单：+-*/%  下标从0开始计算
            switch (opComBox.SelectedIndex)
            {
                case 0:
                    d = (decimal)(n1 + n2);
                    break;
                case 1:
                    d = (decimal)(n1 - n2);
                    break;
                case 2:
                    d = (decimal)(n1 * n2);
                    break;
                case 3:
                    try
                    {
                        d = (decimal)(n1 / n2);
                    }catch(Exception divEX)
                    {
                        result.Text=divEX.Message;
                        return;
                    }
                    break;
                case 4:
                    d = (decimal)(n1 % n2);
                    break;
                default:
                    result.Text = "请选择运算符！";
                    return;
            }
            result.Text = d.ToString();
        }

    }
}
