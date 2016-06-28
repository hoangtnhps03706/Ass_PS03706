Imports System.Data.SqlClient
Imports System.Data.DataTable
Public Class FrmChitietHoaDon
    Dim data As New DataTable
    Dim chuoiketnoi As String = "workstation id=QLBanHangPS03706.mssql.somee.com;packet size=4096;user id=hoangtnhps03706_SQLLogin_1;pwd=24dyhm7j6u;data source=QLBanHangPS03706.mssql.somee.com;persist security info=False;initial catalog=QLBanHangPS03706"
    Dim connect As SqlConnection = New SqlConnection(chuoiketnoi)
    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles BtnClear.Click
        reset()
    End Sub
    Private Sub LoadData()
        Dim connect As SqlConnection = New SqlConnection(chuoiketnoi)
        connect.Open()
        Dim refesh As SqlDataAdapter = New SqlDataAdapter("select MaSP as 'Mã sản phẩm', MaHD as 'Mã hóa đơn', SoLuong as 'Số lượng' from HoaDonCT", connect)
        data.Clear()
        refesh.Fill(data)
        DgvChiTietHoaDon.DataSource = data.DefaultView
        connect.Close()
    End Sub
    Private Sub reset()
        TxtMSP.Text = ""
        TxtMHD.Text = ""
        TxtSoluong.Text = ""
    End Sub
    Private Sub FrmKhachHang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()
    End Sub

    Private Sub BtnThem_Click(sender As Object, e As EventArgs) Handles BtnThem.Click
        If TxtMSP.Text = "" Then
            MessageBox.Show("Chưa nhập mã sản phẩm")
            TxtMSP.Focus()
        ElseIf TxtMHD.Text = "" Then
            MessageBox.Show("Chưa nhập mã hóa đơn")
            TxtMHD.Focus()
        ElseIf TxtSoluong.Text = "" Then
            MessageBox.Show("Chưa nhập số lượng")
            TxtSoluong.Focus()

        Else
            Dim connect As SqlConnection = New SqlConnection(chuoiketnoi)
            Dim query As String = "insert into HoaDonCT values(@MaSP,@MaHD,@SoLuong)"
            Dim save As SqlCommand = New SqlCommand(query, connect)
            connect.Open()
            save.Parameters.AddWithValue("@MaSP", TxtMSP.Text)
            save.Parameters.AddWithValue("@MaHD", TxtMHD.Text)
            save.Parameters.AddWithValue("@SoLuong", TxtSoluong.Text)
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
            Dim delquery As String = "delete from HoaDOnCT where MaSP=@MaSP"
            Dim delete As SqlCommand = New SqlCommand(delquery, connect)
            Dim result As DialogResult = MessageBox.Show("Bạn muốn xóa không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result = Windows.Forms.DialogResult.Yes Then
                connect.Open()
                delete.Parameters.AddWithValue("@MaSP", TxtMHD.Text)
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
            Dim query As String = "update HoaDonCT set MaHD=@MaHD, NgayLapHD=@NgayLapHD, MaKH=@MaKH where MaKH=@MaKH"
            Dim save As SqlCommand = New SqlCommand(query, connect)
            connect.Open()
            save.Parameters.AddWithValue("@MaSP", TxtMSP.Text)
            save.Parameters.AddWithValue("@MaHD", TxtMHD.Text)
            save.Parameters.AddWithValue("@SoLuong", TxtSoluong.Text)
            save.ExecuteNonQuery()
            connect.Close()
            MessageBox.Show("Update thành công")
            TxtMSP.ReadOnly = False
            BtnSua.Text = "Sửa"
            LoadData()
        End If
    End Sub

    Private Sub DgvChiTietHoaDOn_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvChiTietHoaDon.CellContentClick
        Dim chon As Integer = DgvChiTietHoaDon.CurrentCell.RowIndex
        TxtMSP.Text = DgvChiTietHoaDon.Item(0, chon).Value
        TxtMSP.Text = DgvChiTietHoaDon.Item(1, chon).Value
        TxtSoluong.Text = DgvChiTietHoaDon.Item(2, chon).Value
    End Sub
End Class