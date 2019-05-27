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
        public static bool ThemPhieuXuat(PhieuXuat px)
        {
            try
            {
                //thêm 1 phiếu xuất
                string query = "INSERT INTO PHIEUXUAT VALUES (@maPX,GETDATE(),@tenKH)";
                using (SqlConnection connection = new SqlConnection(SqlConnect.connectionString))
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Connection = connection;
                    cmd.Parameters.Add("@maPX", SqlDbType.NVarChar).Value = px.SoPX;
                    cmd.Parameters.Add("@tenKH", SqlDbType.NVarChar).Value = px.TenKH;
                    int data = cmd.ExecuteNonQuery();
                    connection.Close();
                    if (data > 0) return true;
                    else return false;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public static DataTable LayChiTietPhieuXuat(string sopx)
        {
            string query = "SELECT * FROM dbo.CTPHIEUXUAT WHERE SOPX='" +sopx+"'";
            DataTable data = new DataTable();
            data = SqlConnect.Instance.ExecuteQuery(query);
            return data;
        }
        public static bool CapNhatPhieuXuat(PhieuXuat px)
        {
            string query = "UPDATE PHIEUXUAT SET TENKH=@tenKH WHERE SOPX=@soPX";
            using (SqlConnection connection = new SqlConnection(SqlConnect.connectionString))
            {
                connection.Open();
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.CommandType = CommandType.Text;
                sqlCommand.CommandText = query;
                sqlCommand.Connection = connection;
                sqlCommand.Parameters.Add("@soPX", SqlDbType.NVarChar).Value = px.SoPX;
                sqlCommand.Parameters.Add("@tenKH", SqlDbType.NVarChar).Value = px.TenKH;
                int data = sqlCommand.ExecuteNonQuery();
                connection.Close();
                if (data > 0) return true;
                else return false;
            }
        }
        public static bool XoaPhieuXuat( string sopx)
        {
            string query = "DELETE FROM dbo.PHIEUXUAT WHERE SOPX = @soPX";
                using (SqlConnection connection = new SqlConnection(SqlConnect.connectionString))
                {
                    connection.Open();
                    SqlCommand sqlCommand = new SqlCommand();
                    sqlCommand.CommandType = CommandType.Text;
                    sqlCommand.CommandText = query;
                    sqlCommand.Connection = connection;
                    sqlCommand.Parameters.Add("@soPX", SqlDbType.NVarChar).Value = sopx;
                    int data = sqlCommand.ExecuteNonQuery();
                    connection.Close();
                    if (data > 0) return true;
                    else return false;
                }
        }
        public static DataTable TimKiemPX(string sopx, DateTime ngayxuatfrom, DateTime ngatxuatto)
        {
            string sqlTimKiem = @"SELECT * FROM PHIEUXUAT WHERE ";
            if ((sopx == "") && (ngayxuatfrom.ToString() != "")) sqlTimKiem += "NGAYXUAT BETWEEN CAST('" + ngayxuatfrom.ToString("yyyy-MM-dd") + "' AS DATE) " +
                    "AND CAST('" + ngatxuatto.ToString("yyyy-MM-dd") + "' AS DATE)";
            else sqlTimKiem += "SOPX like '%" + sopx + "%' AND NGAYXUAT BETWEEN CAST('" + ngayxuatfrom.ToString("yyyy-MM-dd") + "' AS DATE) " +
                   "AND CAST('" + ngatxuatto.ToString("yyyy-MM-dd") + "' AS DATE)"; 
            
            DataTable dt = new DataTable();
            dt = SqlConnect.Instance.ExecuteQuery(sqlTimKiem);
            return dt;
        }
        public static DataTable LayThongTinHangHoa(string maHH)
        {
            string query = "select TENHH from HANGHOA where MAHH='" + maHH + "'";
            DataTable data = new DataTable();
            data = SqlConnect.Instance.ExecuteQuery(query);
            return data;
        }
        public static bool ThemCTPhieuXuat(string sopx, CT_PhieuXuat ctpx)
        {
            try
            {
                //thêm 1 phiếu xuất
                string query = "INSERT INTO CTPHIEUXUAT VALUES(@soPX, @maHH, @soLuongXuat,@donGiaXuat)";
                using (SqlConnection connection = new SqlConnection(SqlConnect.connectionString))
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Connection = connection;
                    cmd.Parameters.Add("@soPX", SqlDbType.NVarChar).Value = sopx;
                    cmd.Parameters.Add("@maHH", SqlDbType.NVarChar).Value = ctpx.MaHH;
                    cmd.Parameters.Add("@soLuongXuat", SqlDbType.Int).Value = ctpx.SLXuat;
                    cmd.Parameters.Add("@donGiaXuat", SqlDbType.Money).Value = ctpx.DonGiaXuat;
                    int data = cmd.ExecuteNonQuery();
                    connection.Close();
                    if (data > 0) return true;
                    else return false;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public static bool SuaCTPhieuXuat(string sopx, CT_PhieuXuat ctpx)
        {
            string query = "UPDATE CTPHIEUXUAT SET MAHH=@maHH, SLXUAT=@slXuat, DONGIAXUAT=@donGiaXuat WHERE SOPX=@soPX AND MAHH=@maHH";
            using (SqlConnection connection = new SqlConnection(SqlConnect.connectionString))
            {
                connection.Open();
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.CommandType = CommandType.Text;
                sqlCommand.CommandText = query;
                sqlCommand.Connection = connection;
                sqlCommand.Parameters.Add("@soPX", SqlDbType.NVarChar).Value = sopx;
                sqlCommand.Parameters.Add("@maHH", SqlDbType.NVarChar).Value = ctpx.MaHH;
                sqlCommand.Parameters.Add("@slXuat", SqlDbType.Int).Value = ctpx.SLXuat;
                sqlCommand.Parameters.Add("@donGiaXuat", SqlDbType.Money).Value = ctpx.DonGiaXuat;

                int data = sqlCommand.ExecuteNonQuery();
                connection.Close();
                if (data > 0) return true;
                else return false;
            }
        }
        public static bool XoaCTPhieuXuat(string sopx, string maHH)
        {
            string query = "DELETE FROM CTPHIEUXUAT WHERE SOPX = @soPX and MAHH=@maHH";
            using (SqlConnection connection = new SqlConnection(SqlConnect.connectionString))
            {
                connection.Open();
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.CommandType = CommandType.Text;
                sqlCommand.CommandText = query;
                sqlCommand.Connection = connection;
                sqlCommand.Parameters.Add("@soPX", SqlDbType.NVarChar).Value = sopx;
                sqlCommand.Parameters.Add("@maHH", SqlDbType.NVarChar).Value = maHH;
                int data = sqlCommand.ExecuteNonQuery();
                connection.Close();
                if (data > 0) return true;
                else return false;
            }
        }
    }
}
