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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //MessageBox.Show("Hello World ");

        }

        private void bntTinhLuong_Click(object sender, EventArgs e)
        {
            if (txtHeSoLuong.Text == "")
            {
                MessageBox.Show("Ban chua nhap he so luong");
                txtHeSoLuong.Focus();
            }
            else
            {
                if (txtLuongCoBan.Text == "")
                {
                    MessageBox.Show("Ban chua nhap luong co ban");
                    txtLuongCoBan.Focus();
                }
                else
                {
                    double heSoLuong = Convert.ToDouble(txtHeSoLuong.Text);
                    double luongCoBan = Convert.ToDouble(txtLuongCoBan.Text);
                    double luong = heSoLuong * luongCoBan;
                    txtLuong.Text = luong.ToString();
                }
            }

            
        }

        private void txtHeSoLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar >= '0') && (e.KeyChar <= '9')) || (e.KeyChar == '.') ||
                (Convert.ToInt32(e.KeyChar) == 8) || (Convert.ToInt32(e.KeyChar) == 13))
            {
                e.Handled = false;
            }
            else
                e.Handled = true;
        }

        private void txtLuongCoBan_KeyPress(object sender, KeyPressEventArgs e)
        {
            /*Convert.ToInt32(e.KeyChar) == 8 tương đương với phím backspace
             * Convert.ToInt32(e.KeyChar) == 13 tương đương phím enter
             */
            if (((e.KeyChar >= '0') && (e.KeyChar <= '9')) || (e.KeyChar == '.') || (e.KeyChar=='-')||
                (Convert.ToInt32(e.KeyChar) == 8) || (Convert.ToInt32(e.KeyChar) == 13))
            {
                e.Handled = false;
            }
            else
                e.Handled = true;
        }

        
    }
}
