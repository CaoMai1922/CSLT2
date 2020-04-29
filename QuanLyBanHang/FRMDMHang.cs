using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QuanLyBanHang
{
    public partial class FRMDMHang : Form
    {
        SqlConnection con = new SqlConnection();
        public FRMDMHang()
        {
            InitializeComponent();
        }
        private void FRMDMHang_Load(object sender, EventArgs e)
        {
            string connectionString = "Data Source=DESKTOP-FUFFDKL;Initial Catalog=QuanLyBanHang;Integrated Security=True";
            con.ConnectionString = connectionString;
            con.Open();
            LoadDataToGridview();
        }             
        private void dataGridView_DMHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtGiaBan.Text = dataGridView_DMHang.CurrentRow.Cells["GiaBan"].Value.ToString();
            txtGiaNhap.Text = dataGridView_DMHang.CurrentRow.Cells["GiaNhap"].Value.ToString();
            txtMaHang.Text = dataGridView_DMHang.CurrentRow.Cells["MaHang"].Value.ToString();
            txtTenHang.Text = dataGridView_DMHang.CurrentRow.Cells["TenHang"].Value.ToString();
            txtSoLuong.Text = dataGridView_DMHang.CurrentRow.Cells["SoLuong"].Value.ToString();

            //txtMaHang.Visible = true;
            txtMaHang.Enabled = false;  //không cho sửa mã hàng nữa
        }
        private void LoadDataToGridview()
        {
            string sql = "Select * from DMHang";
            
            //SqlDataAdapter adp = new SqlDataAdapter(sql, con);
            //DataTable tableDMHang = new DataTable();
            //adp.Fill(tableDMHang);

            DataTable myTable = DAO.LoadDataToTable(sql);
            dataGridView_DMHang.DataSource = myTable;
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            //Tạo câu lệnh xóa
            string sql = "Delete From DMHang where MaHang='" + txtMaHang.Text + "'";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            LoadDataToGridview();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            txtGiaBan.Text = "";
            txtGiaNhap.Text = "";
            txtMaHang.Text = "";
            txtSoLuong.Text = "";
            txtTenHang.Text = "";
            txtMaHang.Enabled = true;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if(txtMaHang.Text == "")
            {
                MessageBox.Show("Bạn cần nhập mã hàng");
                txtMaHang.Focus();
                return;
            }
            if(txtTenHang.Text == "")
            {
                MessageBox.Show("Bạn cần nhập tên hàng");
                txtTenHang.Focus(); //focus: đưa con trỏ chuột về vị trí tên hàng

            }
            else
            {
                string sql = "insert into DMHang values ('" + txtMaHang.Text + "','" + txtTenHang.Text + "'";
                if (txtGiaNhap.Text != "")
                    sql = sql + "," + txtGiaNhap.Text.Trim();
                if (txtGiaBan.Text != "")
                    sql = sql + "," + txtGiaBan.Text.Trim();
                // Trim: xóa chuỗi rỗng 2 đầu
                if (txtSoLuong.Text != "")
                    sql = sql + "," + txtSoLuong.Text.Trim();
                sql = sql + ")";
                //MessageBox.Show(sql);

                try
                {
                    SqlCommand cmd = new SqlCommand(sql, con);
                    cmd.ExecuteNonQuery();
                    LoadDataToGridview();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(e.ToString());
                }

                return;
               
            }
        }

        private void txtSoLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar >= '0') && (e.KeyChar <= '9')) ||
                (Convert.ToInt32(e.KeyChar) == 8) || (Convert.ToInt32(e.KeyChar) == 13))
            {
                e.Handled = false;
            }
            else
                e.Handled = true;
        }

        private void txtGiaNhap_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar >= '0') && (e.KeyChar <= '9')) ||
                (Convert.ToInt32(e.KeyChar) == 8) || (Convert.ToInt32(e.KeyChar) == 13))
            {
                e.Handled = false;
            }
            else
                e.Handled = true;
        }

        private void txtGiaBan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar >= '0') && (e.KeyChar <= '9')) ||
                (Convert.ToInt32(e.KeyChar) == 8) || (Convert.ToInt32(e.KeyChar) == 13))
            {
                e.Handled = false;
            }
            else
                e.Handled = true;
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            con.Close();
            this.Close();
        }

       
    }
}
