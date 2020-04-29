using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QuanLyKhachSan
{
    public partial class FrmQLPhong : Form
    {
        SqlConnection con = new SqlConnection();
        public FrmQLPhong()
        {
            InitializeComponent();
        }

        private void FrmQLPhong_Load(object sender, EventArgs e)
        {
            string connectionString = "Data Source=DESKTOP-FUFFDKL;Initial Catalog=QuanLyKhachSan;Integrated Security=True";
            con.ConnectionString = connectionString;
            con.Open();
            LoadDataToGridView();
        }
        private void Disconnection()
        {
            if(con.State==ConnectionState.Open)
            {
                con.Close();
                con.Dispose();
            }
        }
        private void LoadDataToGridView()
        {
            string sql = "Select * from Phong";
            SqlDataAdapter adp = new SqlDataAdapter(sql, con);
            DataTable tablePhong = new DataTable();
            adp.Fill(tablePhong);
            dataGridView_Phong.DataSource = tablePhong;
        }

        private void dataGridView_Phong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaPhong.Text = dataGridView_Phong.CurrentRow.Cells["MaPhong"].Value.ToString();
            txtTenPhong.Text = dataGridView_Phong.CurrentRow.Cells["TenPhong"].Value.ToString();
            txtDonGia.Text = dataGridView_Phong.CurrentRow.Cells["DonGia"].Value.ToString();
            txtMaPhong.Enabled = false;
        }

       
        private void btnThem_Click(object sender, EventArgs e)
        {
            txtMaPhong.Text = "";
            txtTenPhong.Text = "";
            txtDonGia.Text = "";
            txtMaPhong.Enabled = true;
        }
        private void btnHuy_Click(object sender, EventArgs e)
        {
           
            txtMaPhong.Text = dataGridView_Phong.CurrentRow.Cells["MaPhong"].Value.ToString();
            txtTenPhong.Text = dataGridView_Phong.CurrentRow.Cells["TenPhong"].Value.ToString();
            txtDonGia.Text = dataGridView_Phong.CurrentRow.Cells["DonGia"].Value.ToString();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtMaPhong.Text == "")
            {
                MessageBox.Show("Bạn cần nhập mã phòng");
                txtMaPhong.Focus();
                return;
            }
            if(txtTenPhong.Text=="")
            {
                MessageBox.Show("Bạn cần nhập tên phòng");
                txtTenPhong.Focus();
                return;
            }
            if(txtDonGia.Text=="")
            {
                MessageBox.Show("Bạn cần nhập vào giá phòng");
                txtDonGia.Focus();
                return;
            }
            else
            {
                string sql = "insert into Phong values ('" + txtMaPhong.Text + "', '" 
                    + txtTenPhong.Text.Trim() + "', " + txtDonGia.Text.Trim()+")";
             /* 
                if (txtTenPhong.Text != "")
                    sql = sql + ", '" + txtTenPhong.Text.Trim() + "'";
                if (txtDonGia.Text != "")
                    sql = sql + "," + txtDonGia.Text.Trim();
                sql = sql + ")";
                MessageBox.Show(sql);
            */
                RunSql(sql);
             /*   try
                {
                    SqlCommand cmd = new SqlCommand(sql, con);
                    cmd.ExecuteNonQuery();
                    LoadDataToGridView();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(e.ToString());
                }

                return;
            */
            }
        }
        private void txtDonGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar >= '0') && (e.KeyChar <= '9')) || (e.KeyChar == '.')||
                (Convert.ToInt32(e.KeyChar) == 8) || (Convert.ToInt32(e.KeyChar) == 13))
            {
                e.Handled = false;
            }
            else
                e.Handled = true;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql;
            if(MessageBox.Show("Bạn có muốn xóa không?","Thông báo"
                ,MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {
                sql = " Delete From Phong Where MaPhong = '" + txtMaPhong.Text + "'";
                RunSql(sql);
            }
            
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            con.Close();
            this.Close();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {

            string sql = "Update Phong set TenPhong = '" + txtTenPhong.Text + 
                "', DonGia = " + txtDonGia.Text + "where MaPhong = '" + txtMaPhong.Text +"'";
            RunSql(sql);
        }
        private void RunSql(string sql)
        {
            
            SqlCommand cmd = new SqlCommand(sql, con);
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            LoadDataToGridView();
        }
    }
}
