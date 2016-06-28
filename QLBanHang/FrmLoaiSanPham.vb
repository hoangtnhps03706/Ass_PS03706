Imports System.Data.SqlClient
Imports System.Data.DataTable
Public Class FrmLoaiSanPham
    Dim data As New DataTable
    Dim chuoiketnoi As String = "workstation id=QLBanHangPS03706.mssql.somee.com;packet size=4096;user id=hoangtnhps03706_SQLLogin_1;pwd=24dyhm7j6u;data source=QLBanHangPS03706.mssql.somee.com;persist security info=False;initial catalog=QLBanHangPS03706"
    Dim connect As SqlConnection = New SqlConnection(chuoiketnoi)
    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles BtnClear.Click
        reset()
    End Sub
    Private Sub LoadData()
        Dim connect As SqlConnection = New SqlConnection(chuoiketnoi)
        connect.Open()
        Dim refesh As SqlDataAdapter = New SqlDataAdapter("select MaLoai as 'Mã loại', TenLoaiSP as 'Tên loại sản phẩm' from LoaiSP", connect)
        data.Clear()
        refesh.Fill(data)
        DgvLoaiSP.DataSource = data.DefaultView
        connect.Close()
    End Sub
    Private Sub reset()
        TxtMSP.Text = ""
        TxtLoaiSP.Text = ""
    End Sub
    Private Sub FrmLoaiSanPham_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()
    End Sub

    Private Sub BtnThem_Click(sender As Object, e As EventArgs) Handles BtnThem.Click
        If TxtMSP.Text = "" Then
            MessageBox.Show("Chưa nhập mã sản phẩm")
            TxtMSP.Focus()
        ElseIf TxtLoaiSP.Text = "" Then
            MessageBox.Show("Chưa nhập loại sản phẩm")
            TxtLoaiSP.Focus()
        Else
            Dim connect As SqlConnection = New SqlConnection(chuoiketnoi)
            Dim query As String = "insert into LoaiSP values(@MaLoai,@TenLoaiSP)"
            Dim save As SqlCommand = New SqlCommand(query, connect)
            connect.Open()
            save.Parameters.AddWithValue("@MaLoai", TxtMSP.Text)
            save.Parameters.AddWithValue("@TenLoaiSP", TxtLoaiSP.Text)
            save.ExecuteNonQuery()
            connect.Close()
            MessageBox.Show("Thêm thành công")
            LoadData()
        End If
    End Sub

    Private Sub BtnXoa_Click(sender As Object, e As EventArgs) Handles BtnXoa.Click
        If TxtMSP.Text = "" Then
            MessageBox.Show("Nhập mã sản phẩm cần xóa")
            TxtMSP.Focus()
        Else
            Dim delquery As String = "delete from HoaDon where MaHD=@MaHD"
            Dim delete As SqlCommand = New SqlCommand(delquery, connect)
            Dim result As DialogResult = MessageBox.Show("Bạn muốn xóa không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result = Windows.Forms.DialogResult.Yes Then
                connect.Open()
                delete.Parameters.AddWithValue("@MaLoai", TxtMSP.Text)
                delete.ExecuteNonQuery()
                connect.Close()
                MessageBox.Show("Xóa thành công")
                LoadData()
            End If
        End If
    End Sub

    Private Sub BtnSua_Click(sender As Object, e As EventArgs) Handles BtnSua.Click
        If BtnSua.Text = "Sửa" Then
            TxtMSP.ReadOnly = True
            BtnSua.Text = "Update"
            TxtMSP.Focus()
        ElseIf BtnSua.Text = "Update" Then
            Dim connect As SqlConnection = New SqlConnection(chuoiketnoi)
            Dim query As String = "update LoaiSP set MaLoai=@MaLoai, TenLoaiSP=@TenLoaiSP where MaLoai=@MaLoai"
            Dim save As SqlCommand = New SqlCommand(query, connect)
            connect.Open()
            save.Parameters.AddWithValue("@MaLoai", TxtMSP.Text)
            save.Parameters.AddWithValue("@TenLoaiSP", TxtLoaiSP.Text)
            save.ExecuteNonQuery()
            connect.Close()
            MessageBox.Show("Update thành công")
            TxtMSP.ReadOnly = False
            BtnSua.Text = "Sửa"
            LoadData()
        End If
    End Sub

    Private Sub DgvHoaDOn_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvLoaiSP.CellContentClick
        Dim chon As Integer = DgvLoaiSP.CurrentCell.RowIndex
        TxtMSP.Text = DgvLoaiSP.Item(0, chon).Value
        TxtLoaiSP.Text = DgvLoaiSP.Item(1, chon).Value
    End Sub
End Class