using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Chuong4_Buoi1
{
    public partial class Calculator : Form
    {
        double Toanhang1, Toanhang2;
        string ToanTu="";
        public Calculator()
        {
            InitializeComponent();
        }
        private void Calculator_Load(object sender, EventArgs e)
        {

        }
        private void btn1_Click(object sender, EventArgs e)
        {
            txtResult.Text = txtResult.Text + btn1.Text;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtResult.Text = txtResult.Text + btn2.Text;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtResult.Text = txtResult.Text + btn3.Text;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtResult.Text = txtResult.Text + btn4.Text;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtResult.Text = txtResult.Text + btn5.Text;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtResult.Text = txtResult.Text + btn6.Text;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtResult.Text = txtResult.Text + btn7.Text;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtResult.Text = txtResult.Text + btn8.Text;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtResult.Text = txtResult.Text + btn9.Text;
        }

        private void btn11_Click(object sender, EventArgs e)
        {
            txtResult.Text = txtResult.Text + btn11.Text;
        }

        private void btnCham_Click(object sender, EventArgs e)
        {
            if (txtResult.Text.Contains("."))
            {
                MessageBox.Show("Chi duoc nhap 1 dau cham");
                return;
            }
            else
            {
                txtResult.Text = txtResult.Text + btnCham.Text;
            }
        }

        private void btnTinh_Click(object sender, EventArgs e)
        {           
            Toanhang2 = Convert.ToDouble(txtResult.Text);
            if (ToanTu != "")
            {
                if (ToanTu == "+")
                {
                    txtResult.Text = (Toanhang1 + Toanhang2).ToString();
                    return;
                }
                else
                {
                    if (ToanTu == "-")
                    {
                        txtResult.Text = (Toanhang1 - Toanhang2).ToString();
                    }
                    else
                    {
                        if(ToanTu=="*")
                        {
                            txtResult.Text = (Toanhang1 * Toanhang2).ToString();
                        }
                        else
                        {
                            if(ToanTu=="/")
                                txtResult.Text = (Toanhang1 / Toanhang2).ToString();
                        }
                    }
                }
            }
        }

        private void btnTru_Click(object sender, EventArgs e)
        {
            Toanhang1 = Convert.ToDouble(txtResult.Text);
            ToanTu= "-";
            txtResult.Text = "";
        }

        private void btnNhan_Click(object sender, EventArgs e)
        {
            Toanhang1 = Convert.ToDouble(txtResult.Text);
            ToanTu = "*";
            txtResult.Text = "";
        }

        private void btnChia_Click(object sender, EventArgs e)
        {
            Toanhang1 = Convert.ToDouble(txtResult.Text);
            ToanTu = "/";
            txtResult.Text = "";
        }

        private void btn13_Click(object sender, EventArgs e)
        {
            txtResult.Text = "";
        }

        private void btnCong_Click(object sender, EventArgs e)
        {
         //   txtResult.Text = txtResult.Text + btnCong.Text;
            Toanhang1 = Convert.ToDouble(txtResult.Text);
            ToanTu = "+";           
            txtResult.Text = "";
        }
    }
}
