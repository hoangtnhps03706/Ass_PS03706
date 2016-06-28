Imports System.Data.SqlClient
Imports System.Data.DataTable
Public Class FrmSanPham
    Dim data As New DataTable
    Dim chuoiketnoi As String = "workstation id=QLBanHangPS03706.mssql.somee.com;packet size=4096;user id=hoangtnhps03706_SQLLogin_1;pwd=24dyhm7j6u;data source=QLBanHangPS03706.mssql.somee.com;persist security info=False;initial catalog=QLBanHangPS03706"
    Dim connect As SqlConnection = New SqlConnection(chuoiketnoi)
    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles BtnClear.Click
        reset()
    End Sub
    Private Sub reset()
        TxtMSP.Text = ""
        TxtTensanpham.Text = ""
        TxtDongia.Text = ""
        TxtDonvitinh.Text = ""
        TxtMaloai.Text = ""
    End Sub
    Private Sub LoadData()
        Dim connect As SqlConnection = New SqlConnection(chuoiketnoi)
        connect.Open()
        Dim refesh As SqlDataAdapter = New SqlDataAdapter("select MaSP as 'Mã sản phẩm', TenSP as 'Tên sản phẩm', DonGia as 'Đơn giá', DonViTinh as 'Đơn vị tính', MaLoai as 'Mã loại' from SanPham", connect)
        data.Clear()
        refesh.Fill(data)
        DgvSanPham.DataSource = data.DefaultView
        connect.Close()
    End Sub

    Private Sub FrmSanPham_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()
    End Sub
    Private Sub BtnThem_Click(sender As Object, e As EventArgs) Handles BtnThem.Click
        If TxtMSP.Text = "" Then
            MessageBox.Show("Chưa nhập mã sản phẩm")
            TxtMSP.Focus()
        ElseIf TxtTensanpham.Text = "" Then
            MessageBox.Show("Chưa nhập tên sản phẩm")
            TxtTensanpham.Focus()
        ElseIf TxtDongia.Text = "" Then
            MessageBox.Show("Chưa nhập đơn giá")
            TxtDongia.Focus()
        ElseIf TxtDonvitinh.Text = "" Then
            MessageBox.Show("CHưa nhập đơn vị tính")
            TxtDonvitinh.Focus()
        ElseIf TxtMaloai.Text = "" Then
            MessageBox.Show("Chưa nhập mã loại")
            TxtMaloai.Focus()
        Else
            Dim connect As SqlConnection = New SqlConnection(chuoiketnoi)
            Dim query As String = "insert into SanPham values(@MaKH,@HoTen,@DiaChi,@SoDienThoai,@Email)"
            Dim save As SqlCommand = New SqlCommand(query, connect)
            connect.Open()
            save.Parameters.AddWithValue("@MaKH", TxtMSP.Text)
            save.Parameters.AddWithValue("@HoTen", TxtTensanpham.Text)
            save.Parameters.AddWithValue("@DiaChi", TxtDongia.Text)
            save.Parameters.AddWithValue("@SoDienThoai", TxtDonvitinh.Text)
            save.Parameters.AddWithValue("@Email", TxtMaloai.Text)
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
            Dim delquery As String = "delete from SanPham where MaSP=@MaSP"
            Dim delete As SqlCommand = New SqlCommand(delquery, connect)
            Dim result As DialogResult = MessageBox.Show("Bạn muốn xóa không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result = Windows.Forms.DialogResult.Yes Then
                connect.Open()
                delete.Parameters.AddWithValue("@MaSP", TxtMSP.Text)
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
            Dim query As String = "update SanPham set MaSP=@MaSP, TenSP=@TenSP, DonGia=@DonGia, DonViTinh=@DonViTinh, MaLoai=@MaLoai where MaSP=@MaSP"
            Dim save As SqlCommand = New SqlCommand(query, connect)
            connect.Open()
            save.Parameters.AddWithValue("@MaSP", TxtMSP.Text)
            save.Parameters.AddWithValue("@TenSP", TxtTensanpham.Text)
            save.Parameters.AddWithValue("@DonGia", TxtDongia.Text)
            save.Parameters.AddWithValue("@DonViTinh", TxtDonvitinh.Text)
            save.Parameters.AddWithValue("@MaLoai", TxtMaloai.Text)
            save.ExecuteNonQuery()
            connect.Close()
            MessageBox.Show("Update thành công")
            TxtMSP.ReadOnly = False
            BtnSua.Text = "Sửa"
            LoadData()
        End If
    End Sub

    Private Sub DgvSanPham_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvSanPham.CellContentClick
        Dim chon As Integer = DgvSanPham.CurrentCell.RowIndex
        TxtMSP.Text = DgvSanPham.Item(0, chon).Value
        TxtTensanpham.Text = DgvSanPham.Item(1, chon).Value
        TxtDongia.Text = DgvSanPham.Item(2, chon).Value
        TxtDonvitinh.Text = DgvSanPham.Item(3, chon).Value
        TxtMaloai.Text = DgvSanPham.Item(4, chon).Value
    End Sub
End Class