Public Class FrmMain

    Private Sub BtnKhachhang_Click(sender As Object, e As EventArgs) Handles BtnKhachhang.Click
        FrmKhachHang.Show()
    End Sub

    Private Sub BtnSanpham_Click(sender As Object, e As EventArgs) Handles BtnSanpham.Click
        FrmSanPham.Show()
    End Sub

    Private Sub BtnHoadon_Click(sender As Object, e As EventArgs) Handles BtnHoadon.Click
        FrmHoaDon.Show()
    End Sub

    Private Sub LoaiSảnPhẩmToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoaiSảnPhẩmToolStripMenuItem.Click
        FrmLoaiSanPham.Show()
    End Sub

    Private Sub ThôngTinSảnPhẩmToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ThôngTinSảnPhẩmToolStripMenuItem.Click
        FrmSanPham.Show()
    End Sub

    Private Sub HóaĐơnToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles HóaĐơnToolStripMenuItem1.Click
        FrmHoaDon.Show()
    End Sub

    Private Sub ChiTiếtHóaĐơnToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ChiTiếtHóaĐơnToolStripMenuItem.Click
        FrmChitietHoaDon.Show()
    End Sub

    Private Sub ThôngTinKháchHàngToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ThôngTinKháchHàngToolStripMenuItem.Click
        FrmKhachHang.Show()
    End Sub

    Private Sub XemThôngTinToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles XemThôngTinToolStripMenuItem.Click
        FrmXemKH.Show()
    End Sub

    Private Sub XemSảnPhẩmToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles XemSảnPhẩmToolStripMenuItem.Click
        FrmXemSP.Show()
    End Sub

    Private Sub BtnXemmothoadon_Click(sender As Object, e As EventArgs) Handles BtnXemmothoadon.Click
        FrmThongTinMotHoaDon.Show()
    End Sub

    Private Sub ThôngTinNgườiViếtChươngTrìnhToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ThôngTinNgườiViếtChươngTrìnhToolStripMenuItem.Click
        FrmInfo.Show()
    End Sub
End Class
