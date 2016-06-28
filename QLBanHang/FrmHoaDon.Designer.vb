<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmHoaDon
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmHoaDon))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtMKH = New System.Windows.Forms.TextBox()
        Me.TxtNgaylapHD = New System.Windows.Forms.TextBox()
        Me.TxtMHD = New System.Windows.Forms.TextBox()
        Me.BtnClear = New System.Windows.Forms.Button()
        Me.BtnSua = New System.Windows.Forms.Button()
        Me.BtnXoa = New System.Windows.Forms.Button()
        Me.BtnThem = New System.Windows.Forms.Button()
        Me.DgvHoaDon = New System.Windows.Forms.DataGridView()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.DgvHoaDon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 144)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(160, 24)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Ngày lập hóa đơn"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 181)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(140, 24)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Mã khách hàng"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 107)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(112, 24)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Mã hóa đơn"
        '
        'TxtMKH
        '
        Me.TxtMKH.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.TxtMKH.Location = New System.Drawing.Point(187, 178)
        Me.TxtMKH.Name = "TxtMKH"
        Me.TxtMKH.Size = New System.Drawing.Size(283, 26)
        Me.TxtMKH.TabIndex = 9
        '
        'TxtNgaylapHD
        '
        Me.TxtNgaylapHD.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.TxtNgaylapHD.Location = New System.Drawing.Point(187, 141)
        Me.TxtNgaylapHD.Name = "TxtNgaylapHD"
        Me.TxtNgaylapHD.Size = New System.Drawing.Size(283, 26)
        Me.TxtNgaylapHD.TabIndex = 10
        '
        'TxtMHD
        '
        Me.TxtMHD.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.TxtMHD.Location = New System.Drawing.Point(187, 104)
        Me.TxtMHD.Name = "TxtMHD"
        Me.TxtMHD.Size = New System.Drawing.Size(283, 26)
        Me.TxtMHD.TabIndex = 11
        '
        'BtnClear
        '
        Me.BtnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.BtnClear.Image = Global.QLBanHang.My.Resources.Resources.edit_clear
        Me.BtnClear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnClear.Location = New System.Drawing.Point(339, 279)
        Me.BtnClear.Name = "BtnClear"
        Me.BtnClear.Size = New System.Drawing.Size(131, 31)
        Me.BtnClear.TabIndex = 3
        Me.BtnClear.Text = "Clear"
        Me.BtnClear.UseVisualStyleBackColor = True
        '
        'BtnSua
        '
        Me.BtnSua.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.BtnSua.Image = Global.QLBanHang.My.Resources.Resources.writing
        Me.BtnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnSua.Location = New System.Drawing.Point(187, 279)
        Me.BtnSua.Name = "BtnSua"
        Me.BtnSua.Size = New System.Drawing.Size(131, 31)
        Me.BtnSua.TabIndex = 4
        Me.BtnSua.Text = "Sửa"
        Me.BtnSua.UseVisualStyleBackColor = True
        '
        'BtnXoa
        '
        Me.BtnXoa.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.BtnXoa.Image = Global.QLBanHang.My.Resources.Resources.delete
        Me.BtnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnXoa.Location = New System.Drawing.Point(339, 234)
        Me.BtnXoa.Name = "BtnXoa"
        Me.BtnXoa.Size = New System.Drawing.Size(131, 31)
        Me.BtnXoa.TabIndex = 5
        Me.BtnXoa.Text = "Xóa"
        Me.BtnXoa.UseVisualStyleBackColor = True
        '
        'BtnThem
        '
        Me.BtnThem.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.BtnThem.Image = Global.QLBanHang.My.Resources.Resources.plus_orange__1_
        Me.BtnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnThem.Location = New System.Drawing.Point(187, 234)
        Me.BtnThem.Name = "BtnThem"
        Me.BtnThem.Size = New System.Drawing.Size(131, 31)
        Me.BtnThem.TabIndex = 6
        Me.BtnThem.Text = "Thêm"
        Me.BtnThem.UseVisualStyleBackColor = True
        '
        'DgvHoaDon
        '
        Me.DgvHoaDon.AllowUserToDeleteRows = False
        Me.DgvHoaDon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvHoaDon.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvHoaDon.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DgvHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvHoaDon.Location = New System.Drawing.Point(500, 104)
        Me.DgvHoaDon.Name = "DgvHoaDon"
        Me.DgvHoaDon.ReadOnly = True
        Me.DgvHoaDon.RowHeadersVisible = False
        Me.DgvHoaDon.Size = New System.Drawing.Size(328, 206)
        Me.DgvHoaDon.TabIndex = 17
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 39.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Label4.Location = New System.Drawing.Point(62, 20)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(196, 61)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Invoice"
        '
        'FrmHoaDon
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(850, 336)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.DgvHoaDon)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtMKH)
        Me.Controls.Add(Me.TxtNgaylapHD)
        Me.Controls.Add(Me.TxtMHD)
        Me.Controls.Add(Me.BtnClear)
        Me.Controls.Add(Me.BtnSua)
        Me.Controls.Add(Me.BtnXoa)
        Me.Controls.Add(Me.BtnThem)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmHoaDon"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Hóa đơn"
        CType(Me.DgvHoaDon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TxtMKH As System.Windows.Forms.TextBox
    Friend WithEvents TxtNgaylapHD As System.Windows.Forms.TextBox
    Friend WithEvents TxtMHD As System.Windows.Forms.TextBox
    Friend WithEvents BtnClear As System.Windows.Forms.Button
    Friend WithEvents BtnSua As System.Windows.Forms.Button
    Friend WithEvents BtnXoa As System.Windows.Forms.Button
    Friend WithEvents BtnThem As System.Windows.Forms.Button
    Friend WithEvents DgvHoaDon As System.Windows.Forms.DataGridView
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class
