Imports System.CodeDom
Imports System.IO
Imports MySql.Data.MySqlClient
Public Class CustomerForm


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        myconn.Open()

        mycmd.Connection = myconn

        With mycmd
            .CommandText = "INSERT INTO customer values (@cusnum, @name, @address, @contact_number);"

            .CommandType = CommandType.Text
            .Parameters.AddWithValue("@cusnum", cusnumtxt.Text)
            .Parameters.AddWithValue("@name", cusnametxt.Text)
            .Parameters.AddWithValue("@address", addresstxt.Text)
            .Parameters.AddWithValue("@contact_number", numbertxt.Text)

        End With
        mycmd.ExecuteNonQuery()
        MsgBox("Data insert Successfully!")
        myconn.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        myconn.Open()

        mycmd.Connection = myconn

        With mycmd

            .CommandText = "UPDATE customer SET name = @name, address = @address, contact_number = @contact_number where cusnum = @cusnum"

            .CommandType = CommandType.Text
            .Parameters.AddWithValue("@cusnum", cusnumtxt.Text)
            .Parameters.AddWithValue("@name", cusnametxt.Text)
            .Parameters.AddWithValue("@address", addresstxt.Text)
            .Parameters.AddWithValue("@contact_number", numbertxt.Text)


        End With

        mycmd.ExecuteNonQuery()

        MsgBox("Data Update Successfully!")

        myconn.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        myconn.Open()

        mycmd.Connection = myconn

        With mycmd

            .CommandText = "DELETE FROM customer where cusnum = @cusnum"

            .CommandType = CommandType.Text
            .Parameters.AddWithValue("@cusnum", cusnumtxt.Text)
            .Parameters.AddWithValue("@name", cusnametxt.Text)
            .Parameters.AddWithValue("@address", addresstxt.Text)
            .Parameters.AddWithValue("@contact_number", numbertxt.Text)


        End With

        mycmd.ExecuteNonQuery()
        MsgBox("Data Delete Successfully!")
        myconn.Close()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim SDA As New MySqlDataAdapter
        Dim dbdata As New DataTable
        Dim bSource As New BindingSource

        Try
            myconn.Open()
            sql = "Select * FROM customer"
            mycmd = New MySqlCommand(sql, myconn)
            SDA.SelectCommand = mycmd
            SDA.Fill(dbdata)
            bSource.DataSource = dbdata
            customergrid.DataSource = bSource
            SDA.Update(dbdata)


            myconn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            myconn.Dispose()
        End Try
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

        Me.Hide()
        Form1.Show()

    End Sub
  


End Class