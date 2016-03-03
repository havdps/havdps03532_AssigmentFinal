Imports System.Data.SqlClient
Imports System.Data.DataTable
Imports System.Data
Public Class FrmQLKH
    Dim chuoiketnoi As String = "workstation id=havdps03532.mssql.somee.com;packet size=4096;user id=havdps03532_SQLLogin_1;pwd=nu41rkxi7z;data source=havdps03532.mssql.somee.com;persist security info=False;initial catalog=havdps03532"
    Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
    Dim db As New DataTable
    Dim hienthi As New class1
    Public Class class1
        Dim chuoiketnoi As String = "workstation id=havdps03532.mssql.somee.com;packet size=4096;user id=havdps03532_SQLLogin_1;pwd=nu41rkxi7z;data source=havdps03532.mssql.somee.com;persist security info=False;initial catalog=havdps03532"
        Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
        Dim db As New DataTable
        Public Function dulieu() As DataSet

            Dim load As New SqlDataAdapter("SELECT Makh As 'ma kh',Tenkh AS 'ten kh',Diachi As 'dia chi', Sodt As 'so dt' From khachhang", conn)
            Dim db As New DataSet
            conn.Open()
            load.Fill(db)
            conn.Close()
            Return db
        End Function
    End Class

    Private Sub dgvxemkh_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvxemkh.CellContentClick
        Dim Dobble As Integer = dgvxemkh.CurrentCell.RowIndex
        txtma_kh.Text = dgvxemkh.Item(0, Dobble).Value
        txttenkh.Text = dgvxemkh.Item(1, Dobble).Value
        txtDiachi.Text = dgvxemkh.Item(2, Dobble).Value
        txtSdt.Text = dgvxemkh.Item(3, Dobble).Value
    End Sub

    Private Sub btnthem_Click(sender As Object, e As EventArgs) Handles btnthem.Click
        Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
        Dim InsertData As String = "INSERT INTO khachhang Values(@Makh,@Tenkh,@Diachi,@Sdt)"
        Dim Save As SqlCommand = New SqlCommand(InsertData, conn)
        conn.Open()
        Try
            txtma_kh.Focus()
            If txtma_kh.Text = "" Then
                MessageBox.Show("Bạn chưa nhập mã khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                txttenkh.Focus()
                If txttenkh.Text = "" Then
                    MessageBox.Show("Bạn chưa nhập tên khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    txtDiachi.Focus()
                    If txtDiachi.Text = "" Then
                        MessageBox.Show("Bạn chưa nhập địa chỉ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        txtSdt.Focus()
                        If txtSdt.Text = "" Then
                            MessageBox.Show("Bạn chưa nhập số điện thoại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Else
                            Save.Parameters.AddWithValue("@Makh", txtma_kh.Text)
                            Save.Parameters.AddWithValue("@Tenkh", txttenkh.Text)
                            Save.Parameters.AddWithValue("@Diachi", txtDiachi.Text)
                            Save.Parameters.AddWithValue("@Sodt", lblsdt.Text)
                            Save.ExecuteNonQuery()
                            MessageBox.Show("Lưu thành công")
                            txtma_kh.Text = Nothing
                            txttenkh.Text = Nothing
                            txtDiachi.Text = Nothing
                            txtSdt.Text = Nothing
                            MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        End If
                    End If
                End If
            End If
        Catch ex As Exception
            ' MessageBox.Show("Mã khách hàng đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
        Dim Refresh As SqlDataAdapter = New SqlDataAdapter("SELECT Makh As 'ma khach hang',Tenkh AS 'ten khach hang',Diachi As 'Dia Chi',Sodt As 'So dien thoai' From khachhang", conn)
        db.Clear()
        Refresh.Fill(db)
        dgvxemkh.DataSource = db.DefaultView
    End Sub

    Private Sub btnxem_Click(sender As Object, e As EventArgs) Handles btnxem.Click
        dgvxemkh.DataSource = hienthi.dulieu.Tables(0)
    End Sub

    Private Sub btnsua_Click(sender As Object, e As EventArgs) Handles btnsua.Click
        Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
        Dim CapNhat As String = "Update khachhang SET Makh=@Makh, Tenkh=@Tenkh, Diachi=@Diachi, Sodt=@Sodt Where Makh=@Makh"
        Dim ADDDATA As SqlCommand = New SqlCommand(CapNhat, conn)
        conn.Open()
        Try
            If txtma_kh.Text = "" Then
                MessageBox.Show("Bạn chưa nhập mã khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                txttenkh.Focus()
                If txttenkh.Text = "" Then
                    MessageBox.Show("Bạn chưa nhập tên khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    txtDiachi.Focus()
                    If txtDiachi.Text = "" Then
                        MessageBox.Show("Bạn chưa nhập địa chỉ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        txtSdt.Focus()
                        If txtSdt.Text = "" Then
                            MessageBox.Show("Bạn chưa nhập số điện thoại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        End If
                    End If
                    ADDDATA.Parameters.AddWithValue("@Makh", txtma_kh.Text)
                    ADDDATA.Parameters.AddWithValue("@Tenkh", txttenkh.Text)
                    ADDDATA.Parameters.AddWithValue("@Diachi", txtDiachi.Text)
                    ADDDATA.Parameters.AddWithValue("@Sodt", txtSdt.Text)
                    ADDDATA.ExecuteNonQuery()
                    conn.Close()
                    MessageBox.Show("Cập nhật thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Cập nhật thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try

        db.Clear()
        dgvxemkh.DataSource = db
        dgvxemkh.DataSource = Nothing
        LoadData()
    End Sub
    Private Sub LoadData()
        Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
        Dim TRUYVAN As SqlDataAdapter = New SqlDataAdapter("SELECT Makh AS 'ma kh' ,Tenkh AS 'ten khach hang',Diachi As 'Dia chi',Sodt As 'so dien thoai' FROM khachhang", conn)
        conn.Open()
        TRUYVAN.Fill(db)
        dgvxemkh.DataSource = db.DefaultView
    End Sub

    Private Sub btnxoa_Click(sender As Object, e As EventArgs) Handles btnxoa.Click
        Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
        Dim Delete As String = ("DELETE KHACHHANG WHERE MaKH = @MaKH") 'Truy van xoa
        Dim CONNECT As SqlCommand = New SqlCommand(Delete, conn)
        conn.Open() 'Mo ket noi CSDL
        Try
            txtma_kh.Focus()
            If txtma_kh.Text = "" Then
                MessageBox.Show("Bạn chưa nhập mã khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                CONNECT.Parameters.AddWithValue("@MaKH", txtma_kh.Text)
                CONNECT.ExecuteNonQuery()
                conn.Close() 'Dong ket noi CSDL
                MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch EX As Exception
            'Thong bao xoa that bai
            MessageBox.Show("Xóa thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
        'Lam moi lai CSDL
        db.Clear()
        dgvxemkh.DataSource = db
        dgvxemkh.DataSource = Nothing
        LoadData()
    End Sub

    Private Sub lbltenkh_Click(sender As Object, e As EventArgs) Handles lbltenkh.Click, lbldiachi.Click, lblsdt.Click

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles txtSdt.TextChanged

    End Sub

    Private Sub FrmQLKH_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
