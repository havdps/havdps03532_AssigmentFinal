<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmQLSP
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
        Me.components = New System.ComponentModel.Container()
        Me.txtSdt = New System.Windows.Forms.Label()
        Me.lbldiachi = New System.Windows.Forms.Label()
        Me.lblmasp = New System.Windows.Forms.Label()
        Me.dgvxemsp = New System.Windows.Forms.DataGridView()
        Me.txtsoluong = New System.Windows.Forms.TextBox()
        Me.txttensp = New System.Windows.Forms.TextBox()
        Me.txtmasp = New System.Windows.Forms.TextBox()
        Me.btnxoa = New System.Windows.Forms.Button()
        Me.btnxem = New System.Windows.Forms.Button()
        Me.txtmota = New System.Windows.Forms.TextBox()
        Me.txtmaloaisp = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnthem = New System.Windows.Forms.Button()
        Me.btnsua = New System.Windows.Forms.Button()
        Me.bs = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.dgvxemsp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bs, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtSdt
        '
        Me.txtSdt.AutoSize = True
        Me.txtSdt.Location = New System.Drawing.Point(6, 117)
        Me.txtSdt.Name = "txtSdt"
        Me.txtSdt.Size = New System.Drawing.Size(53, 13)
        Me.txtSdt.TabIndex = 19
        Me.txtSdt.Text = "Số Lượng"
        '
        'lbldiachi
        '
        Me.lbldiachi.AutoSize = True
        Me.lbldiachi.Location = New System.Drawing.Point(6, 73)
        Me.lbldiachi.Name = "lbldiachi"
        Me.lbldiachi.Size = New System.Drawing.Size(78, 13)
        Me.lbldiachi.TabIndex = 20
        Me.lbldiachi.Text = "Tên Sản Phẩm"
        '
        'lblmasp
        '
        Me.lblmasp.AutoSize = True
        Me.lblmasp.Location = New System.Drawing.Point(6, 31)
        Me.lblmasp.Name = "lblmasp"
        Me.lblmasp.Size = New System.Drawing.Size(74, 13)
        Me.lblmasp.TabIndex = 21
        Me.lblmasp.Text = "Mã Sản Phẩm"
        '
        'dgvxemsp
        '
        Me.dgvxemsp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvxemsp.Location = New System.Drawing.Point(12, 227)
        Me.dgvxemsp.Name = "dgvxemsp"
        Me.dgvxemsp.Size = New System.Drawing.Size(612, 215)
        Me.dgvxemsp.TabIndex = 22
        '
        'txtsoluong
        '
        Me.txtsoluong.Location = New System.Drawing.Point(109, 114)
        Me.txtsoluong.Name = "txtsoluong"
        Me.txtsoluong.Size = New System.Drawing.Size(184, 20)
        Me.txtsoluong.TabIndex = 16
        '
        'txttensp
        '
        Me.txttensp.Location = New System.Drawing.Point(109, 70)
        Me.txttensp.Name = "txttensp"
        Me.txttensp.Size = New System.Drawing.Size(184, 20)
        Me.txttensp.TabIndex = 17
        '
        'txtmasp
        '
        Me.txtmasp.Location = New System.Drawing.Point(109, 28)
        Me.txtmasp.Name = "txtmasp"
        Me.txtmasp.Size = New System.Drawing.Size(184, 20)
        Me.txtmasp.TabIndex = 18
        '
        'btnxoa
        '
        Me.btnxoa.Location = New System.Drawing.Point(450, 28)
        Me.btnxoa.Name = "btnxoa"
        Me.btnxoa.Size = New System.Drawing.Size(75, 23)
        Me.btnxoa.TabIndex = 14
        Me.btnxoa.Text = "Xóa"
        Me.btnxoa.UseVisualStyleBackColor = True
        '
        'btnxem
        '
        Me.btnxem.Location = New System.Drawing.Point(330, 28)
        Me.btnxem.Name = "btnxem"
        Me.btnxem.Size = New System.Drawing.Size(75, 23)
        Me.btnxem.TabIndex = 15
        Me.btnxem.Text = "Xem"
        Me.btnxem.UseVisualStyleBackColor = True
        '
        'txtmota
        '
        Me.txtmota.Location = New System.Drawing.Point(109, 151)
        Me.txtmota.Name = "txtmota"
        Me.txtmota.Size = New System.Drawing.Size(184, 20)
        Me.txtmota.TabIndex = 16
        '
        'txtmaloaisp
        '
        Me.txtmaloaisp.Location = New System.Drawing.Point(109, 186)
        Me.txtmaloaisp.Name = "txtmaloaisp"
        Me.txtmaloaisp.Size = New System.Drawing.Size(184, 20)
        Me.txtmaloaisp.TabIndex = 16
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 158)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Mô Tả"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 193)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(97, 13)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Mã Loại Sản Phẩm"
        '
        'btnthem
        '
        Me.btnthem.Location = New System.Drawing.Point(329, 118)
        Me.btnthem.Name = "btnthem"
        Me.btnthem.Size = New System.Drawing.Size(75, 23)
        Me.btnthem.TabIndex = 15
        Me.btnthem.Text = "Thêm"
        Me.btnthem.UseVisualStyleBackColor = True
        '
        'btnsua
        '
        Me.btnsua.Location = New System.Drawing.Point(450, 118)
        Me.btnsua.Name = "btnsua"
        Me.btnsua.Size = New System.Drawing.Size(75, 23)
        Me.btnsua.TabIndex = 15
        Me.btnsua.Text = "Sửa"
        Me.btnsua.UseVisualStyleBackColor = True
        '
        'FrmQLSP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(636, 454)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtSdt)
        Me.Controls.Add(Me.lbldiachi)
        Me.Controls.Add(Me.lblmasp)
        Me.Controls.Add(Me.dgvxemsp)
        Me.Controls.Add(Me.txtmaloaisp)
        Me.Controls.Add(Me.txtmota)
        Me.Controls.Add(Me.txtsoluong)
        Me.Controls.Add(Me.txttensp)
        Me.Controls.Add(Me.txtmasp)
        Me.Controls.Add(Me.btnxoa)
        Me.Controls.Add(Me.btnsua)
        Me.Controls.Add(Me.btnthem)
        Me.Controls.Add(Me.btnxem)
        Me.Name = "FrmQLSP"
        Me.Text = "FrmQLSP"
        CType(Me.dgvxemsp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bs, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtSdt As System.Windows.Forms.Label
    Friend WithEvents lbldiachi As System.Windows.Forms.Label
    Friend WithEvents lblmasp As System.Windows.Forms.Label
    Friend WithEvents dgvxemsp As System.Windows.Forms.DataGridView
    Friend WithEvents txtsoluong As System.Windows.Forms.TextBox
    Friend WithEvents txttensp As System.Windows.Forms.TextBox
    Friend WithEvents txtmasp As System.Windows.Forms.TextBox
    Friend WithEvents btnxoa As System.Windows.Forms.Button
    Friend WithEvents btnxem As System.Windows.Forms.Button
    Friend WithEvents txtmota As System.Windows.Forms.TextBox
    Friend WithEvents txtmaloaisp As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnthem As System.Windows.Forms.Button
    Friend WithEvents btnsua As System.Windows.Forms.Button
    Friend WithEvents bs As System.Windows.Forms.BindingSource
End Class
