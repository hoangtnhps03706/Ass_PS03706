Imports System.Data.SqlClient
Imports System.Data.DataTable
Public Class FrmHoaDon
    Dim data As New DataTable
    Dim chuoiketnoi As String = "workstation id=QLBanHangPS03706.mssql.somee.com;packet size=4096;user id=hoangtnhps03706_SQLLogin_1;pwd=24dyhm7j6u;data source=QLBanHangPS03706.mssql.somee.com;persist security info=False;initial catalog=QLBanHangPS03706"
    Dim connect As SqlConnection = New SqlConnection(chuoiketnoi)
    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles BtnClear.Click
        reset()
    End Sub
    Private Sub LoadData()
        Dim connect As SqlConnection = New SqlConnection(chuoiketnoi)
        connect.Open()
        Dim refesh As SqlDataAdapter = New SqlDataAdapter("select MaHD as 'Mã hóa đơn', NgayLapHD as 'Ngày lập hóa đơn', MaKH as 'Mã khách hàng' from HoaDon", connect)
        data.Clear()
        refesh.Fill(data)
        DgvHoaDon.DataSource = data.DefaultView
        connect.Close()
    End Sub
    Private Sub reset()
        TxtMHD.Text = ""
        TxtNgaylapHD.Text = ""
        TxtMKH.Text = ""
    End Sub
    Private Sub FrmKhachHang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()
    End Sub

    Private Sub BtnThem_Click(sender As Object, e As EventArgs) Handles BtnThem.Click
        If TxtMHD.Text = "" Then
            MessageBox.Show("Chưa nhập mã hóa đơn")
            TxtMHD.Focus()
        ElseIf TxtNgaylapHD.Text = "" Then
            MessageBox.Show("Chưa nhập ngày lập hóa đơn")
            TxtNgaylapHD.Focus()
        ElseIf TxtMKH.Text = "" Then
            MessageBox.Show("Chưa nhập mã khách hàng")
            TxtMKH.Focus()

        Else
            Dim connect As SqlConnection = New SqlConnection(chuoiketnoi)
            Dim query As String = "insert into HoaDon values(@MaHD,@NgayLapHD,@MaKH)"
            Dim save As SqlCommand = New SqlCommand(query, connect)
            connect.Open()
            save.Parameters.AddWithValue("@MaHD", TxtMHD.Text)
            save.Parameters.AddWithValue("@NgayLapHD", TxtNgaylapHD.Text)
            save.Parameters.AddWithValue("@MaKH", TxtMKH.Text)
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
            Dim delquery As String = "delete from HoaDon where MaHD=@MaHD"
            Dim delete As SqlCommand = New SqlCommand(delquery, connect)
            Dim result As DialogResult = MessageBox.Show("Bạn muốn xóa không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result = Windows.Forms.DialogResult.Yes Then
                connect.Open()
                delete.Parameters.AddWithValue("@MaHD", TxtMHD.Text)
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
            Dim query As String = "update HoaDon set MaHD=@MaHD, NgayLapHD=@NgayLapHD, MaKH=@MaKH where MaKH=@MaKH"
            Dim save As SqlCommand = New SqlCommand(query, connect)
            connect.Open()
            save.Parameters.AddWithValue("@MaHD", TxtMHD.Text)
            save.Parameters.AddWithValue("@NgayLapHD", TxtNgaylapHD.Text)
            save.Parameters.AddWithValue("@MaKH", TxtMKH.Text)
            save.ExecuteNonQuery()
            connect.Close()
            MessageBox.Show("Update thành công")
            TxtMKH.ReadOnly = False
            BtnSua.Text = "Sửa"
            LoadData()
        End If
    End Sub

    Private Sub DgvHoaDOn_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvHoaDon.CellContentClick
        Dim chon As Integer = DgvHoaDon.CurrentCell.RowIndex
        TxtMHD.Text = DgvHoaDon.Item(0, chon).Value
        TxtNgaylapHD.Text = DgvHoaDon.Item(1, chon).Value
        TxtMKH.Text = DgvHoaDon.Item(2, chon).Value
    End Sub
End Class