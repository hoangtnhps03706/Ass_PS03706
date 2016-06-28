Imports System.Data.SqlClient
Imports System.Data.DataTable
Public Class Class1
    Public Function Loadkhachang() As DataSet
        Dim chuoiketnoi As String = "workstation id=QLBanHangPS03706.mssql.somee.com;packet size=4096;user id=hoangtnhps03706_SQLLogin_1;pwd=24dyhm7j6u;data source=QLBanHangPS03706.mssql.somee.com;persist security info=False;initial catalog=QLBanHangPS03706"
        Dim connect As SqlConnection = New SqlConnection(chuoiketnoi)
        Dim LoadKH As New SqlDataAdapter("select MaKH as 'Mã khách hàng', HoTen as 'Họ tên', DiaChi as 'Địa chỉ', SoDienThoai as 'Số điện thoại, Email as 'Email' from KhachHang", connect)
        Dim data As New DataSet
        connect.Open()
        LoadKH.Fill(data)
        connect.Close()
        Return data
    End Function
    Public Function Loadsanpham() As DataSet
        Dim chuoiketnoi As String = "workstation id=QLBanHangPS03706.mssql.somee.com;packet size=4096;user id=hoangtnhps03706_SQLLogin_1;pwd=24dyhm7j6u;data source=QLBanHangPS03706.mssql.somee.com;persist security info=False;initial catalog=QLBanHangPS03706"
        Dim connect As SqlConnection = New SqlConnection(chuoiketnoi)
        Dim LoadSP As New SqlDataAdapter("select SanPham.MASP as 'Mã sản phẩm',SanPham.TenSP as 'Tên sản phẩm', LOAISANPHAM.MaLoai as 'Mã Loại', LOAISANPHAM.TenLoaiSP as 'Tên Loại' from SanPham inner join LoaiSP on SanPham.MaLoai = LoaiSP.MaLoai", connect)
        Dim data As New DataSet
        connect.Open()
        LoadSP.Fill(data)
        connect.Close()
        Return data
    End Function
End Class
