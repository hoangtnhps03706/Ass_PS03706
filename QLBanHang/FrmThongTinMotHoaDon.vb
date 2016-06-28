Imports System.Data.SqlClient
Imports System.Data.DataTable
Public Class FrmThongTinMotHoaDon
    Dim data As New DataTable
    Dim chuoiketnoi As String = "workstation id=QLBanHangPS03706.mssql.somee.com;packet size=4096;user id=hoangtnhps03706_SQLLogin_1;pwd=24dyhm7j6u;data source=QLBanHangPS03706.mssql.somee.com;persist security info=False;initial catalog=QLBanHangPS03706"
    Dim connect As SqlConnection = New SqlConnection(chuoiketnoi)
    Private Databaseaccess As New DataBaseAccess

    Private Sub LoadData()
        Dim connect As SqlConnection = New SqlConnection(chuoiketnoi)
        connect.Open()
        Dim refesh As SqlDataAdapter = New SqlDataAdapter("SELECT HoaDon.MaHD AS N'Mã hóa đơn',HoaDon.MaKH AS N'Mã khách hàng',SanPham.MaSP AS N'Mã sản phẩm',LoaiSP.MaLoai AS N'Mã loại',HoaDon.NgayLapHD AS N'Ngày lập hóa đơn',HoaDonCT.SoLuong AS N'Số lượng',SanPham.DonGia AS N'Đơn giá',Cast (SoLuong * DonGia AS nvarchar)+  ' ' + SanPham.DonViTinh AS N'Tổng tiền' From LoaiSP JOIN SanPham ON SanPham.MaLoai = LoaiSP.MaLoai JOIN HoaDonCT ON SanPham.MaSP = HoaDonCT.MaSP JOIN HoaDon ON HoaDonCT.MaHD = HoaDon.MaHD", connect)
        data.Clear()
        refesh.Fill(data)
        DgvSearch.DataSource = data.DefaultView
        connect.Close()
    End Sub

    Private Sub FrmXem_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()
    End Sub
    Private Sub SearchSanPham(value As String)
        Dim sqlQuery As String = String.Format("SELECT HoaDon.MaHD AS N'Mã hóa đơn',HoaDon.MaKH AS N'Mã khách hàng',SanPham.MaSP AS N'Mã sản phẩm',LoaiSP.MaLoai AS N'Mã loại',HoaDon.NgayLapHD AS N'Ngày lập hóa đơn',HoaDonCT.SoLuong AS N'Số lượng',SanPham.DonGia AS N'Đơn giá',Cast (SoLuong * DonGia AS nvarchar)+  ' ' + SanPham.DonViTinh AS N'Tổng tiền' From LoaiSP JOIN SanPham ON SanPham.MaLoai = LoaiSP.MaLoai JOIN HoaDonCT ON SanPham.MaSP = HoaDonCT.MaSP JOIN HoaDon ON HoaDonCT.MaHD = HoaDon.MaHD")
        If CmbDulieu.SelectedIndex = 0 Then
            sqlQuery += String.Format(" where HoaDon.MaHD like '{0}%'", value)
        ElseIf CmbDulieu.SelectedIndex = 1 Then
            sqlQuery += String.Format(" where HoaDon.MaKH LIKE N'{0}%'", value)
        End If
        Dim data As DataTable = Databaseaccess.GetDataTable(sqlQuery)
        DgvSearch.DataSource = data
        With DgvSearch
            .Columns(0).HeaderText = "Mã hóa đơn"
            .Columns(1).HeaderText = "Mã khách hàng"
            .Columns(2).HeaderText = "Mã sản phẩm"
            .Columns(3).HeaderText = "Mã loại"
            .Columns(4).HeaderText = "Ngày lập hóa đơn"
            .Columns(5).HeaderText = "Số lượng"
            .Columns(6).HeaderText = "Đơn giá"
        End With
    End Sub

    Private Sub TxtSearch_TextChanged(sender As Object, e As EventArgs) Handles TxtSearch.TextChanged
        SearchSanPham(TxtSearch.Text)
    End Sub
    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles BtnClear.Click
        TxtSearch.Text = ""
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Close()
    End Sub
End Class