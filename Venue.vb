Imports MySql.Data.MySqlClient

Public Class Venue
    Private Sub Venue_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        myconn.ConnectionString = "server=localhost; user id=root;port=3306;password=joana0741;database=reservation_database"

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        myconn.Open()


        mycmd.Connection = myconn
          

        With mycmd


            .CommandText = "INSERT INTO venue_type values (@venue_num, @venue_name,@venue_priceperday);"


            .CommandType = CommandType.Text
            .Parameters.AddWithValue("@venue_num", venue_numtxt.Text)
            .Parameters.AddWithValue("@venue_name", venue_nametxt.Text)
            .Parameters.AddWithValue("@venue_priceperday", pricetxt.Text)


        End With
        mycmd.ExecuteNonQuery()
        MsgBox("Data insert Successfully!")
        myconn.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        myconn.Open()

        mycmd.Connection = myconn

        With mycmd

            .CommandText = "UPDATE venue_type SET venue_name = @venue_name, venue_priceperday = @venue_priceperday where venue_num = @venue_num"

            .CommandType = CommandType.Text
            .Parameters.AddWithValue("@venue_num", venue_numtxt.Text)
            .Parameters.AddWithValue("@venue_name", venue_nametxt.Text)
            .Parameters.AddWithValue("@venue_priceperday", pricetxt.Text)



        End With

        mycmd.ExecuteNonQuery()
        MsgBox("Data Update Successfully!")
        myconn.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        myconn.Open()

        mycmd.Connection = myconn

        With mycmd

            .CommandText = "DELETE FROM venue_type where venue_num = @venue_num"

            .CommandType = CommandType.Text
            .Parameters.AddWithValue("@venue_num", venue_numtxt.Text)
            .Parameters.AddWithValue("@venue_name", venue_nametxt.Text)
            .Parameters.AddWithValue("@venue_priceperday", pricetxt.Text)


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
            sql = "Select * FROM venue_type"
            mycmd = New MySqlCommand(sql, myconn)
            SDA.SelectCommand = mycmd
            SDA.Fill(dbdata)
            bSource.DataSource = dbdata
            eventgrid.DataSource = bSource
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