using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using QLKho.Models;
namespace QLKho.Controller
{
    public class Issue
    {
        //Nghiep vu load phieu xuat
        public static List<PhieuXuat> LoadPhieuXuat()
        {
            string query = "select * from PHIEUXUAT";
            DataTable data = new DataTable();
            data = SqlConnect.Instance.ExecuteQuery(query);
            if (data!=null && data.Rows.Count > 0) //nếu datatable hợp lệ va co gia trị
            {
                List<PhieuXuat> lstPhieuXuat = new List<PhieuXuat>();
                for (int i = 0; i < data.Rows.Count; i++)
                {
                    PhieuXuat phieuxuat = new PhieuXuat();
                    phieuxuat.SoPX = data.Rows[i]["SoPX"].ToString();
                    phieuxuat.NgayXuat = Convert.ToDateTime(data.Rows[i]["NgayXuat"]);
                    phieuxuat.TenKH = data.Rows[i]["TenKH"].ToString();
                    //add phieu xuat vao list phieu xuat
                    lstPhieuXuat.Add(phieuxuat);
                }
                return lstPhieuXuat;
            }
            return null;
        }
        public static List<HangHoa> LoadHangHoaCBX()
        {
            string query = "select * from HANGHOA";
            DataTable data = new DataTable();
            data = SqlConnect.Instance.ExecuteQuery(query);
            if (data != null && data.Rows.Count > 0) //nếu datatable hợp lệ va co gia trị
            {
                List<HangHoa> lstHangHoa = new List<HangHoa>();
                for (int i = 0; i < data.Rows.Count; i++)
                {
                    HangHoa hanghoa = new HangHoa();
                    hanghoa.MaHH = data.Rows[i]["MAHH"].ToString();
                    hanghoa.TenHH = data.Rows[i]["TENHH"].ToString();
                    hanghoa.DVTinh = data.Rows[i]["DVTINH"].ToString();
                    hanghoa.DonGia = data.Rows[i]["DONGIA"].ToString();
                    //add phieu xuat vao list phieu xuat
                    lstHangHoa.Add(hanghoa);
                }
                return lstHangHoa;
            }
            return null;
        }
        public static bool ThemPhieuXuat(PhieuXuat px,List<CT_PhieuXuat> lstCT_PhieuXuat)
        {
            try
            {
                //thêm 1 phiếu xuất
                string query2 = "";

                foreach (var item in lstCT_PhieuXuat)
                {
                    query2 = query2 + "(@maPX," + "N'" + item.MaHH + "'," + item.SLXuat + "," + item.DonGiaXuat + "),";
                }
                string query = "INSERT INTO PHIEUXUAT( SOPX, NGAYXUAT, TENKH ) VALUES  ( @maPX,GETDATE(),@tenKH)" +
                   " INSERT INTO CTPHIEUXUAT(SOPX, MAHH, SLXUAT, DONGIAXUAT)VALUES" + query2.Substring(0, query2.Length - 1);
                using (SqlConnection connection = new SqlConnection(SqlConnect.connectionString))
                {
                    connection.Open();
                    SqlCommand sqlCommand = new SqlCommand();
                    sqlCommand.CommandType = CommandType.Text;
                    sqlCommand.CommandText = query;
                    sqlCommand.Connection = connection;
                    sqlCommand.Parameters.Add("@maPX", SqlDbType.NVarChar).Value = px.SoPX;
                    sqlCommand.Parameters.Add("@tenKH", SqlDbType.NVarChar).Value = px.TenKH;
                    int data = sqlCommand.ExecuteNonQuery();
                    if (data > 0) return true;
                    else return false;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public static DataTable LayChiTietPhieuXuat(string mapx)
        {
            string query = "SELECT ct.MAHH,hh.TENHH, ct.SLXUAT,ct.DONGIAXUAT  FROM dbo.CTPHIEUXUAT ct INNER JOIN dbo.HANGHOA hh ON ct.MAHH=hh.MAHH WHERE ct.SOPX = " + "'"+mapx+"'";
            DataTable data = new DataTable();
            data = SqlConnect.Instance.ExecuteQuery(query);
            return data;
        }
        public static bool CapNhatPhieuXuat(PhieuXuat px, CT_PhieuXuat ctpx)
        {
            string query = "UPDATE PHIEUXUAT SET TENKH=@tenKH WHERE SOPX=@soPX"+
                " UPDATE dbo.CTPHIEUXUAT SET SLXUAT=@slXuat, DONGIAXUAT=@donGiaXuat WHERE MAHH=@maHH";
            using (SqlConnection connection = new SqlConnection(SqlConnect.connectionString))
            {
                connection.Open();
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.CommandType = CommandType.Text;
                sqlCommand.CommandText = query;
                sqlCommand.Connection = connection;
                sqlCommand.Parameters.Add("@soPX", SqlDbType.NVarChar).Value = px.SoPX;
                sqlCommand.Parameters.Add("@tenKH", SqlDbType.NVarChar).Value = px.TenKH;
                sqlCommand.Parameters.Add("@slXuat", SqlDbType.Int).Value = ctpx.SLXuat;
                sqlCommand.Parameters.Add("@donGiaXuat", SqlDbType.Money).Value = ctpx.DonGiaXuat;
                sqlCommand.Parameters.Add("@maHH", SqlDbType.NVarChar).Value = ctpx.MaHH;
                int data = sqlCommand.ExecuteNonQuery();
                if (data > 0) return true;
                else return false;
            }
        }
        public static bool XoaPhieuXuat( string sopx)
        {
                string query = "DELETE FROM dbo.CTPHIEUXUAT WHERE SOPX=@soPX" +
                               " DELETE FROM dbo.PHIEUXUAT WHERE SOPX = @soPX";
                using (SqlConnection connection = new SqlConnection(SqlConnect.connectionString))
                {
                    connection.Open();
                    SqlCommand sqlCommand = new SqlCommand();
                    sqlCommand.CommandType = CommandType.Text;
                    sqlCommand.CommandText = query;
                    sqlCommand.Connection = connection;
                    sqlCommand.Parameters.Add("@soPX", SqlDbType.NVarChar).Value = sopx;
                    int data = sqlCommand.ExecuteNonQuery();
                    if (data > 0) return true;
                    else return false;
                }
        }
        public static DataTable LayThongTinHangHoa(string maHH)
        {
            string query = "select TENHH from HANGHOA where MAHH='" + maHH + "'";
            DataTable data = new DataTable();
            data = SqlConnect.Instance.ExecuteQuery(query);
            return data;
        }
    }
}
