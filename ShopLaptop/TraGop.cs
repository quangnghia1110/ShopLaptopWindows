using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopLaptop
{
    public partial class TraGop : Form
    {
        MyConnect myconn = new MyConnect();
        public TraGop()
        {
            InitializeComponent();
        }
        private void LoadData()
        {
            myconn.openConnection();
            DataTable dataTable = new DataTable();
            SqlCommand cmd = new SqlCommand("SELECT * FROM TraGop", myconn.getConnection);
            dataTable.Load(cmd.ExecuteReader());
            dgv_TraGop.DataSource = dataTable;
            myconn.closeConnection();
        }
        private void btn_Show_TraGop_Click(object sender, EventArgs e)
        {
            LoadData();
        }
        private void Reset()
        {
            txt_MaHD.ResetText();
            txt_MaKH_HD.ResetText();
            txt_LaiSuatHangThang.ResetText();
            txt_TienTraTruoc_HD.ResetText();
            txt_TienConLai_TG.ResetText();
            txt_ThoiGianTraGop.ResetText();
            Date_NgayBatDau.ResetText();
            date_NgayDaoHan.ResetText();
        }
        private void dgv_TraGop_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_MaHD.Text = dgv_TraGop.CurrentRow.Cells[0].Value.ToString();
            txt_MaKH_HD.Text = dgv_TraGop.CurrentRow.Cells[1].Value.ToString();
            txt_LaiSuatHangThang.Text = dgv_TraGop.CurrentRow.Cells[2].Value.ToString();
            txt_TienTraTruoc_HD.Text = dgv_TraGop.CurrentRow.Cells[3].Value.ToString();
            txt_TienConLai_TG.Text = dgv_TraGop.CurrentRow.Cells[4].Value.ToString();
            txt_ThoiGianTraGop.Text = dgv_TraGop.CurrentRow.Cells[5].Value.ToString();
            Date_NgayBatDau.Text = dgv_TraGop.CurrentRow.Cells[6].Value.ToString();
            date_NgayDaoHan.Text = dgv_TraGop.CurrentRow.Cells[7].Value.ToString();
        }
        private void btn_Them_TraGop_Click(object sender, EventArgs e)
        {
            myconn.openConnection();
            SqlCommand cmd = new SqlCommand($"EXEC sp_ReviseTraGop '{txt_MaHD.Text}', '{txt_MaKH_HD.Text}', '{txt_LaiSuatHangThang.Text}', '{txt_TienTraTruoc_HD.Text}', '{txt_TienConLai_TG.Text}', '{txt_ThoiGianTraGop.Text}', '{Date_NgayBatDau.Value}', '{date_NgayDaoHan.Value}','Insert' ", myconn.getConnection);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Thêm thông tin trả góp thành công!");
            myconn.closeConnection();
            Reset();
            LoadData();
        }

        private void btn_Sua_TraGop_Click(object sender, EventArgs e)
        {
            myconn.openConnection();
            SqlCommand cmd = new SqlCommand($"EXEC sp_ReviseTraGop '{txt_MaHD.Text}', '{txt_MaKH_HD.Text}', '{txt_LaiSuatHangThang.Text}', '{txt_TienTraTruoc_HD}', '{txt_TienConLai_TG.Text}', '{txt_ThoiGianTraGop.Text}', '{Date_NgayBatDau.Value}', '{date_NgayDaoHan.Value}','Update' ", myconn.getConnection);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Xóa thông tin trả góp thành công!");
            myconn.closeConnection();
            Reset();
            LoadData();
        }


        private void btn_Xoa_TraGop_Click(object sender, EventArgs e)
        {
            myconn.openConnection();
            SqlCommand cmd = new SqlCommand($"EXEC sp_ReviseTraGop '{txt_MaHD.Text}', '{txt_MaKH_HD.Text}', '{txt_LaiSuatHangThang.Text}', '{txt_TienTraTruoc_HD.Text}', '{txt_TienConLai_TG.Text}', '{txt_ThoiGianTraGop.Text}', '{Date_NgayBatDau.Value}', '{date_NgayDaoHan.Value}','Delete' ", myconn.getConnection);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Xóa thông tin trả góp thành công!");
            myconn.closeConnection();
            Reset();
            LoadData();
        }

        
    }
}
