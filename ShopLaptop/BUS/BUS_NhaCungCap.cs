using ShopLaptop.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopLaptop.BUS
{
    public class BUS_NhaCungCap
    {
        //string MaNCC, string TenNCC, string Email, string DiaChi, string SDT, string TrangThaiHopTac
        DAL_NhaCungCap dAL_NhaCungCap = new DAL_NhaCungCap();
        public DataTable LoadNhaCungCaps()
        {
            return dAL_NhaCungCap.LoadNhaCungCaps();
        }
        public bool InsertNhaCungCap(string MaNCC, string TenNCC, string Email, string DiaChi, string SDT, string TrangThaiHopTac)
        {
            NhaCungCap nhaCungCap = new NhaCungCap();
            nhaCungCap.MaNCC = MaNCC;
            nhaCungCap.TenNCC = TenNCC;
            nhaCungCap.Email = Email;
            nhaCungCap.DiaChi = DiaChi;
            nhaCungCap.SDT = SDT;
            nhaCungCap.TrangThaiHopTac = TrangThaiHopTac;
            return dAL_NhaCungCap.InsertNhaCungCap(nhaCungCap);
        }
        public bool UpdateNhaCungCap(string MaNCC, string TenNCC, string Email, string DiaChi, string SDT, string TrangThaiHopTac)
        {
            NhaCungCap nhaCungCap = new NhaCungCap();
            nhaCungCap.MaNCC = MaNCC;
            nhaCungCap.TenNCC = TenNCC;
            nhaCungCap.Email = Email;
            nhaCungCap.DiaChi = DiaChi;
            nhaCungCap.SDT = SDT;
            nhaCungCap.TrangThaiHopTac = TrangThaiHopTac;
            return dAL_NhaCungCap.UpdateNhaCungCap(nhaCungCap);
        }
        public bool DeleteNhaCungCap(string MaNCC, string TenNCC, string Email, string DiaChi, string SDT, string TrangThaiHopTac)
        {
            NhaCungCap nhaCungCap = new NhaCungCap();
            nhaCungCap.MaNCC = MaNCC;
            nhaCungCap.TenNCC = TenNCC;
            nhaCungCap.Email = Email;
            nhaCungCap.DiaChi = DiaChi;
            nhaCungCap.SDT = SDT;
            nhaCungCap.TrangThaiHopTac = TrangThaiHopTac;
            return dAL_NhaCungCap.DeleteNhaCungCap(nhaCungCap);
        }
        public DataTable FindNhaCungCap(string maNCC)
        {
            NhaCungCap nhaCungCap = new NhaCungCap() { MaNCC = maNCC };
            return this.dAL_NhaCungCap.FindNhaCungCap(nhaCungCap) as DataTable;
        }

    }
}
