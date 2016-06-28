Imports System.Data.SqlClient
Imports System.Data.DataTable
Public Class FrmKhachHang
    Dim data As New DataTable
    Dim chuoiketnoi As String = "workstation id=QLBanHangPS03706.mssql.somee.com;packet size=4096;user id=hoangtnhps03706_SQLLogin_1;pwd=24dyhm7j6u;data source=QLBanHangPS03706.mssql.somee.com;persist security info=False;initial catalog=QLBanHangPS03706"
    Dim connect As SqlConnection = New SqlConnection(chuoiketnoi)
    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles BtnClear.Click
        reset()
    End Sub
    Private Sub LoadData()
        Dim connect As SqlConnection = New SqlConnection(chuoiketnoi)
        connect.Open()
        Dim refesh As SqlDataAdapter = New SqlDataAdapter("select MaKH as 'Mã khách hàng', HoTen as 'Họ tên', DiaChi as 'Địa chỉ', SoDienThoai as 'Số điện thoại', Email as 'Email' from KhachHang", connect)
        data.Clear()
        refesh.Fill(data)
        DgvKhachHang.DataSource = data.DefaultView
        connect.Close()
    End Sub
    Private Sub reset()
        TxtMKH.Text = ""
        TxtHoten.Text = ""
        TxtDiachi.Text = ""
        TxtSDT.Text = ""
        TxtEmail.Text = ""
    End Sub
    Private Sub FrmKhachHang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()
    End Sub

    Private Sub BtnThem_Click(sender As Object, e As EventArgs)
        If TxtMKH.Text = "" Then
            MessageBox.Show("Chưa nhập mã khách hàng")
            TxtMKH.Focus()
        ElseIf TxtHoten.Text = "" Then
            MessageBox.Show("Chưa nhập họ tên")
            TxtHoten.Focus()
        ElseIf TxtDiachi.Text = "" Then
            MessageBox.Show("Chưa nhập địa chỉ")
            TxtDiachi.Focus()
        ElseIf TxtSDT.Text = "" Then
            MessageBox.Show("CHưa nhập số điện thoại")
            TxtSDT.Focus()
        ElseIf TxtEmail.Text = "" Then
            MessageBox.Show("Chưa nhập Email")
            TxtEmail.Focus()
        Else
            Dim connect As SqlConnection = New SqlConnection(chuoiketnoi)
            Dim query As String = "insert into KhachHang values(@MaKH,@HoTen,@DiaChi,@SoDienThoai,@Email)"
            Dim save As SqlCommand = New SqlCommand(query, connect)
            connect.Open()
            save.Parameters.AddWithValue("@MaKH", TxtMKH.Text)
            save.Parameters.AddWithValue("@HoTen", TxtHoten.Text)
            save.Parameters.AddWithValue("@DiaChi", TxtDiachi.Text)
            save.Parameters.AddWithValue("@SoDienThoai", TxtSDT.Text)
            save.Parameters.AddWithValue("@Email", TxtEmail.Text)
            save.ExecuteNonQuery()
            connect.Close()
            MessageBox.Show("Thêm thành công")
            LoadData()
        End If
    End Sub

    Private Sub BtnXoa_Click(sender As Object, e As EventArgs) Handles BtnXoa.Click
        If TxtMKH.Text = "" Then
            MessageBox.Show("Nhập mã khách hàng cần xóa")
            TxtMKH.Focus()
        Else
            Dim delquery As String = "delete from KhachHang where MaKH=@MaKH"
            Dim delete As SqlCommand = New SqlCommand(delquery, connect)
            Dim result As DialogResult = MessageBox.Show("Bạn muốn xóa không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result = Windows.Forms.DialogResult.Yes Then
                connect.Open()
                delete.Parameters.AddWithValue("@MaKH", TxtMKH.Text)
                delete.ExecuteNonQuery()
                connect.Close()
                MessageBox.Show("Xóa thành công")
                LoadData()
            End If
        End If
    End Sub

    Private Sub BtnSua_Click(sender As Object, e As EventArgs) Handles BtnSua.Click
        If BtnSua.Text = "Sửa" Then
            TxtMKH.ReadOnly = True
            BtnSua.Text = "Update"
            TxtMKH.Focus()
        ElseIf BtnSua.Text = "Update" Then
            Dim connect As SqlConnection = New SqlConnection(chuoiketnoi)
            Dim query As String = "update KhachHang set MaKH=@MaKH, HoTen=@HoTen, DiaChi=@DiaChi, SoDienThoai=@SoDienThoai, Email=@Email where MaKH=@MaKH"
            Dim save As SqlCommand = New SqlCommand(query, connect)
            connect.Open()
            save.Parameters.AddWithValue("@MaKH", TxtMKH.Text)
            save.Parameters.AddWithValue("@HoTen", TxtHoten.Text)
            save.Parameters.AddWithValue("@DiaChi", TxtDiachi.Text)
            save.Parameters.AddWithValue("@SoDienThoai", TxtSDT.Text)
            save.Parameters.AddWithValue("@Email", TxtEmail.Text)
            save.ExecuteNonQuery()
            connect.Close()
            MessageBox.Show("Update thành công")
            TxtMKH.ReadOnly = False
            BtnSua.Text = "Sửa"
            LoadData()
        End If
    End Sub

    Private Sub DgvKhachHang_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvKhachHang.CellContentClick
        Dim chon As Integer = DgvKhachHang.CurrentCell.RowIndex
        TxtMKH.Text = DgvKhachHang.Item(0, chon).Value
        TxtHoten.Text = DgvKhachHang.Item(1, chon).Value
        TxtDiachi.Text = DgvKhachHang.Item(2, chon).Value
        TxtSDT.Text = DgvKhachHang.Item(3, chon).Value
        TxtEmail.Text = DgvKhachHang.Item(4, chon).Value
    End Sub

    Private Sub BtnAdd_Click_1(sender As Object, e As EventArgs) Handles BtnAdd.Click
        If TxtMKH.Text = "" Then
            MessageBox.Show("Chưa nhập mã khách hàng")
            TxtMKH.Focus()
        ElseIf TxtHoten.Text = "" Then
            MessageBox.Show("Chưa nhập họ tên")
            TxtHoten.Focus()
        ElseIf TxtDiachi.Text = "" Then
            MessageBox.Show("Chưa nhập địa chỉ")
            TxtDiachi.Focus()
        ElseIf TxtSDT.Text = "" Then
            MessageBox.Show("CHưa nhập số điện thoại")
            TxtSDT.Focus()
        ElseIf TxtEmail.Text = "" Then
            MessageBox.Show("Chưa nhập Email")
            TxtEmail.Focus()
        Else
            Dim connect As SqlConnection = New SqlConnection(chuoiketnoi)
            Dim query As String = "insert into KhachHang values(@MaKH,@HoTen,@DiaChi,@SoDienThoai,@Email)"
            Dim save As SqlCommand = New SqlCommand(query, connect)
            connect.Open()
            save.Parameters.AddWithValue("@MaKH", TxtMKH.Text)
            save.Parameters.AddWithValue("@HoTen", TxtHoten.Text)
            save.Parameters.AddWithValue("@DiaChi", TxtDiachi.Text)
            save.Parameters.AddWithValue("@SoDienThoai", TxtSDT.Text)
            save.Parameters.AddWithValue("@Email", TxtEmail.Text)
            save.ExecuteNonQuery()
            connect.Close()
            MessageBox.Show("Thêm thành công")
            LoadData()
        End If
    End Sub
End Class