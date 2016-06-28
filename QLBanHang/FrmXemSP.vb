Imports System.Data.SqlClient
Imports System.Data.DataTable
Public Class FrmXemSP
    Dim data As New DataTable
    Dim chuoiketnoi As String = "workstation id=QLBanHangPS03706.mssql.somee.com;packet size=4096;user id=hoangtnhps03706_SQLLogin_1;pwd=24dyhm7j6u;data source=QLBanHangPS03706.mssql.somee.com;persist security info=False;initial catalog=QLBanHangPS03706"
    Dim connect As SqlConnection = New SqlConnection(chuoiketnoi)

    Private Databaseaccess As New DataBaseAccess

    Private Sub LoadData()
        Dim connect As SqlConnection = New SqlConnection(chuoiketnoi)
        connect.Open()
        Dim refesh As SqlDataAdapter = New SqlDataAdapter("select MaSP as 'Mã sản phẩm', TenSP as 'Tên sản phẩm', DonGia as 'Đơn giá', DonViTinh as 'Đơn vị tính', MaLoai as 'Mã loại' from SanPham", connect)
        data.Clear()
        refesh.Fill(data)
        DgvSearch.DataSource = data.DefaultView
        connect.Close()
    End Sub

    Private Sub FrmXem_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()
    End Sub
    Private Sub SearchSanPham(value As String)
        Dim sqlQuery As String = String.Format("select MaSP , TenSP , DonGia , DonViTinh , MaLoai  from SanPham")
        If CmbDulieu.SelectedIndex = 0 Then
            sqlQuery += String.Format(" where MaSP like '{0}%'", value)
        ElseIf CmbDulieu.SelectedIndex = 1 Then
            sqlQuery += String.Format(" where TenSP LIKE N'{0}%'", value)
        End If
        Dim data As DataTable = Databaseaccess.GetDataTable(sqlQuery)
        DgvSearch.DataSource = data
        With DgvSearch
            .Columns(0).HeaderText = "Mã sản phẩm"
            .Columns(1).HeaderText = "Tên sản phẩm"
            .Columns(2).HeaderText = "Đơn giá"
            .Columns(3).HeaderText = "Đơn vị tính"
            .Columns(4).HeaderText = "Mã loại"
            .Columns(4).Width = 250
        End With
    End Sub

    Private Sub TxtSearch_TextChanged(sender As Object, e As EventArgs) Handles TxtSearch.TextChanged
        SearchSanPham(TxtSearch.Text)
    End Sub

    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles BtnClear.Click
        TxtSearch.Text = ""
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnBack.Click
        Close()
    End Sub
End Class