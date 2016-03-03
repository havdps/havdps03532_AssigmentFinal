<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmQLKH
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
        Me.lbltenkh = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgvxemkh = New System.Windows.Forms.DataGridView()
        Me.txttenkh = New System.Windows.Forms.TextBox()
        Me.txtma_kh = New System.Windows.Forms.TextBox()
        Me.btnxoa = New System.Windows.Forms.Button()
        Me.btnsua = New System.Windows.Forms.Button()
        Me.btnthem = New System.Windows.Forms.Button()
        Me.btnxem = New System.Windows.Forms.Button()
        Me.txtDiachi = New System.Windows.Forms.TextBox()
        Me.txtSdt = New System.Windows.Forms.TextBox()
        Me.lbldiachi = New System.Windows.Forms.Label()
        Me.lblsdt = New System.Windows.Forms.Label()
        CType(Me.dgvxemkh, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbltenkh
        '
        Me.lbltenkh.AutoSize = True
        Me.lbltenkh.Location = New System.Drawing.Point(56, 71)
        Me.lbltenkh.Name = "lbltenkh"
        Me.lbltenkh.Size = New System.Drawing.Size(44, 13)
        Me.lbltenkh.TabIndex = 11
        Me.lbltenkh.Text = "Tên KH"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(56, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Mã KH"
        '
        'dgvxemkh
        '
        Me.dgvxemkh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvxemkh.Location = New System.Drawing.Point(68, 201)
        Me.dgvxemkh.Name = "dgvxemkh"
        Me.dgvxemkh.Size = New System.Drawing.Size(524, 138)
        Me.dgvxemkh.TabIndex = 13
        '
        'txttenkh
        '
        Me.txttenkh.Location = New System.Drawing.Point(116, 64)
        Me.txttenkh.Name = "txttenkh"
        Me.txttenkh.Size = New System.Drawing.Size(184, 20)
        Me.txttenkh.TabIndex = 9
        '
        'txtma_kh
        '
        Me.txtma_kh.Location = New System.Drawing.Point(116, 26)
        Me.txtma_kh.Name = "txtma_kh"
        Me.txtma_kh.Size = New System.Drawing.Size(184, 20)
        Me.txtma_kh.TabIndex = 10
        '
        'btnxoa
        '
        Me.btnxoa.Location = New System.Drawing.Point(482, 71)
        Me.btnxoa.Name = "btnxoa"
        Me.btnxoa.Size = New System.Drawing.Size(75, 23)
        Me.btnxoa.TabIndex = 5
        Me.btnxoa.Text = "Xóa"
        Me.btnxoa.UseVisualStyleBackColor = True
        '
        'btnsua
        '
        Me.btnsua.Location = New System.Drawing.Point(482, 23)
        Me.btnsua.Name = "btnsua"
        Me.btnsua.Size = New System.Drawing.Size(75, 23)
        Me.btnsua.TabIndex = 6
        Me.btnsua.Text = "Sửa"
        Me.btnsua.UseVisualStyleBackColor = True
        '
        'btnthem
        '
        Me.btnthem.Location = New System.Drawing.Point(359, 71)
        Me.btnthem.Name = "btnthem"
        Me.btnthem.Size = New System.Drawing.Size(75, 23)
        Me.btnthem.TabIndex = 7
        Me.btnthem.Text = "Thêm"
        Me.btnthem.UseVisualStyleBackColor = True
        '
        'btnxem
        '
        Me.btnxem.Location = New System.Drawing.Point(359, 19)
        Me.btnxem.Name = "btnxem"
        Me.btnxem.Size = New System.Drawing.Size(75, 23)
        Me.btnxem.TabIndex = 8
        Me.btnxem.Text = "Xem"
        Me.btnxem.UseVisualStyleBackColor = True
        '
        'txtDiachi
        '
        Me.txtDiachi.Location = New System.Drawing.Point(116, 109)
        Me.txtDiachi.Name = "txtDiachi"
        Me.txtDiachi.Size = New System.Drawing.Size(184, 20)
        Me.txtDiachi.TabIndex = 9
        '
        'txtSdt
        '
        Me.txtSdt.Location = New System.Drawing.Point(116, 153)
        Me.txtSdt.Name = "txtSdt"
        Me.txtSdt.Size = New System.Drawing.Size(184, 20)
        Me.txtSdt.TabIndex = 9
        '
        'lbldiachi
        '
        Me.lbldiachi.AutoSize = True
        Me.lbldiachi.Location = New System.Drawing.Point(56, 116)
        Me.lbldiachi.Name = "lbldiachi"
        Me.lbldiachi.Size = New System.Drawing.Size(41, 13)
        Me.lbldiachi.TabIndex = 11
        Me.lbldiachi.Text = "Địa Chỉ"
        '
        'lblsdt
        '
        Me.lblsdt.AutoSize = True
        Me.lblsdt.Location = New System.Drawing.Point(35, 160)
        Me.lblsdt.Name = "lblsdt"
        Me.lblsdt.Size = New System.Drawing.Size(75, 13)
        Me.lblsdt.TabIndex = 11
        Me.lblsdt.Text = "Số Điện Thoại"
        '
        'FrmQLKH
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(649, 359)
        Me.Controls.Add(Me.lblsdt)
        Me.Controls.Add(Me.lbldiachi)
        Me.Controls.Add(Me.lbltenkh)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgvxemkh)
        Me.Controls.Add(Me.txtSdt)
        Me.Controls.Add(Me.txtDiachi)
        Me.Controls.Add(Me.txttenkh)
        Me.Controls.Add(Me.txtma_kh)
        Me.Controls.Add(Me.btnxoa)
        Me.Controls.Add(Me.btnsua)
        Me.Controls.Add(Me.btnthem)
        Me.Controls.Add(Me.btnxem)
        Me.Name = "FrmQLKH"
        Me.Text = "FrmQLKH"
        CType(Me.dgvxemkh, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbltenkh As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dgvxemkh As System.Windows.Forms.DataGridView
    Friend WithEvents txttenkh As System.Windows.Forms.TextBox
    Friend WithEvents txtma_kh As System.Windows.Forms.TextBox
    Friend WithEvents btnxoa As System.Windows.Forms.Button
    Friend WithEvents btnsua As System.Windows.Forms.Button
    Friend WithEvents btnthem As System.Windows.Forms.Button
    Friend WithEvents btnxem As System.Windows.Forms.Button
    Friend WithEvents txtDiachi As System.Windows.Forms.TextBox
    Friend WithEvents txtSdt As System.Windows.Forms.TextBox
    Friend WithEvents lbldiachi As System.Windows.Forms.Label
    Friend WithEvents lblsdt As System.Windows.Forms.Label
End Class
