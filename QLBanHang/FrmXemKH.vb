Imports System.Data.SqlClient
Imports System.Data.DataTable
Public Class FrmXemKH
    Dim data As New DataTable
    Dim chuoiketnoi As String = "workstation id=QLBanHangPS03706.mssql.somee.com;packet size=4096;user id=hoangtnhps03706_SQLLogin_1;pwd=24dyhm7j6u;data source=QLBanHangPS03706.mssql.somee.com;persist security info=False;initial catalog=QLBanHangPS03706"
    Dim connect As SqlConnection = New SqlConnection(chuoiketnoi)

    Private Databaseaccess As New DataBaseAccess

    Private Sub LoadData()
        Dim connect As SqlConnection = New SqlConnection(chuoiketnoi)
        connect.Open()
        Dim refesh As SqlDataAdapter = New SqlDataAdapter("select MaKH as 'Mã khách hàng', HoTen as 'Họ tên', DiaChi as 'Địa chỉ', SoDienThoai as 'Số điện thoại', Email as 'Email' from KhachHang", connect)
        Data.Clear()
        refesh.Fill(Data)
        DgvSearch.DataSource = data.DefaultView
        connect.Close()
    End Sub

    Private Sub FrmXem_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()
    End Sub
    Private Sub SearchKhachHang(value As String)
        Dim sqlQuery As String = String.Format("select MaKH , HoTen , DiaChi , SoDienThoai , Email  from KhachHang")
        If CmbDulieu.SelectedIndex = 0 Then
            sqlQuery += String.Format(" where MaKH like '{0}%'", value)
        ElseIf CmbDulieu.SelectedIndex = 1 Then
            sqlQuery += String.Format(" where HoTen LIKE N'{0}%'", value)
        End If
        Dim data As DataTable = Databaseaccess.GetDataTable(sqlQuery)
        DgvSearch.DataSource = data
        With DgvSearch
            .Columns(0).HeaderText = "Mã khách hàng"
            .Columns(1).HeaderText = "Họ tên"
            .Columns(2).HeaderText = "Địa chỉ"
            .Columns(3).HeaderText = "Số điện thoại"
            .Columns(4).HeaderText = "Email"
            .Columns(4).Width = 250
        End With
    End Sub

    Private Sub TxtSearch_TextChanged(sender As Object, e As EventArgs) Handles TxtSearch.TextChanged
        SearchKhachHang(TxtSearch.Text)
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Close()
    End Sub

    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles BtnClear.Click
        TxtSearch.Text = ""
    End Sub
End Class