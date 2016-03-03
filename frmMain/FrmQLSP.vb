
Public Class FrmQLSP
   

    Private Sub btnxem_Click(sender As Object, e As EventArgs) Handles btnxem.Click

    End Sub

    Private Sub dgvxemsp_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvxemsp.CellContentClick
        Try
            Dim RowView As DataRowView = bs.Current
            Dim Row As DataRow = RowView.Row

            txtmasp.Text = Row("MASP")
            txttensp.Text = Row("TENSP")
            txtsoluong.Text = Row("SOLUONG")
            txtsoluong.Text = Row("DIACHI")
            txtmota.Text = Row("MASP")
            txtmaloaisp.Text = Row("MALOAISP")
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnthem_Click(sender As Object, e As EventArgs) Handles btnthem.Click
        Dim Sql As String =
            <sql>
                        INSERT INTO LOAISP (MALOAI, TENLOAI)
                        VALUES (N'{0}', N'{1}')
                    </sql>
        Sql = String.Format(Sql, txtmaloaisp.Text, txtmaloaisp.Text)

        ExecuteNonQuery(Sql)

        Dim Sql1 As String =
                   <sql>
                        INSERT INTO sanpham (Masp, Tensp, Soluong, Mota,Maloaisp)
                        VALUES (N'{0}', N'{1}', N'{2}', N'{3}', N'{4}')
                    </sql>
        Sql1 = String.Format(Sql1, txtmasp.Text, txttensp.Text, txtsoluong.Text, txtmota.Text, txtmaloaisp.Text)

        ExecuteNonQuery(Sql1)

        Fillsanpham()
    End Sub

    Private Sub FrmQLSP_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Fillsanpham()
    End Sub
    Private Sub Fillsanpham()
        Dim Sql As String =
            <sql>
                SELECT * FROM sanpham
            </sql>
        Fill(Sql, "sanpham")
        bs.DataSource = ds.Tables("sanpham")
        dgvxemsp.DataSource = bs()
        bs.ResetBindings(False)
    End Sub

    Private Sub txtmota_TextChanged(sender As Object, e As EventArgs) Handles txtmota.TextChanged

    End Sub

    Private Sub btnsua_Click(sender As Object, e As EventArgs) Handles btnsua.Click
        Dim Sql As String =
            <sql>
                        UPDATE sanpham
                        SET Tensp = N'{0}',  = Ten'{1}', Soluong = '{2}', Mota = '{3}', Maloaisp = '{4}
                        WHERE Masp = N'{5}'
                    </sql>
        Sql = String.Format(Sql, txtmasp.Text, txttensp.Text, txtsoluong.Text, txtmota.Text, txtmaloaisp.Text)

        ExecuteNonQuery(Sql)

        Fillsanpham()
    End Sub

    Private Sub btnxoa_Click(sender As Object, e As EventArgs) Handles btnxoa.Click
        Dim Sql As String = <SQL>
            DELETE FROM SANPHAM  
                WHERE        (maloai = N'{0}')
        </SQL>
        Sql = String.Format(Sql, txtmaloaisp.Text)

        ExecuteNonQuery(Sql)

        Fillsanpham()
    End Sub

   
End Class
