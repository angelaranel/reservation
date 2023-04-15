Imports MySql.Data.MySqlClient

Public Class Reservation
    Private Sub Reservation_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        myconn.ConnectionString = "server=localhost; user id=root;port=3306;password=joana0741;database=reservation_database"

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        myconn.Open()

        mycmd.Connection = myconn

        With mycmd

            .CommandText = "INSERT INTO reservation values (@reserve_num, @date_start, @date_end, @total_day, @venue_reserve, @venue_id, @event_id, @cus_id);"

            .CommandType = CommandType.Text
            .Parameters.AddWithValue("@reserve_num", numtxt.Text)
            .Parameters.AddWithValue("@date_start", starttxt.Text)
            .Parameters.AddWithValue("@date_end", endtxt.Text)
            .Parameters.AddWithValue("@total_day", daytxt.Text)
            .Parameters.AddWithValue("@venue_reserve", venue_reservetxt.Text)
            .Parameters.AddWithValue("@venue_id", venue_idtxt.Text)
            .Parameters.AddWithValue("@event_id", event_idtxt.Text)
            .Parameters.AddWithValue("@cus_id", cus_idtxt.Text)

        End With
        mycmd.ExecuteNonQuery()
        MsgBox("Data insert Successfully!")
        myconn.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        myconn.Open()

        mycmd.Connection = myconn

        With mycmd

            .CommandText = "UPDATE reservation SET date_start = @date_start, date_end = @date_end, total_day = @total_day, venue_reserve = @venue_reserve, venue_id = @venue_id, event_id =@event_id, cus_id = @cus_id where reserve_num = @reserve_num"

            .CommandType = CommandType.Text
            .Parameters.AddWithValue("@reserve_num", numtxt.Text)
            .Parameters.AddWithValue("@date_start", starttxt.Text)
            .Parameters.AddWithValue("@date_end", endtxt.Text)
            .Parameters.AddWithValue("@total_day", daytxt.Text)
            .Parameters.AddWithValue("@venue_reserve", venue_reservetxt.Text)
            .Parameters.AddWithValue("@venue_id", venue_idtxt.Text)
            .Parameters.AddWithValue("@event_id", event_idtxt.Text)
            .Parameters.AddWithValue("@cus_id", cus_idtxt.Text)


        End With

        mycmd.ExecuteNonQuery()
        MsgBox("Data Update Successfully!")
        myconn.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        myconn.Open()

        mycmd.Connection = myconn

        With mycmd

            .CommandText = "DELETE FROM reservation where reserve_num = @reserve_num"


            .CommandType = CommandType.Text
            .Parameters.AddWithValue("@reserve_num", numtxt.Text)
            .Parameters.AddWithValue("@date_start", starttxt.Text)
            .Parameters.AddWithValue("@date_end", endtxt.Text)
            .Parameters.AddWithValue("@total_day", daytxt.Text)
            .Parameters.AddWithValue("@venue_reserve", venue_reservetxt.Text)
            .Parameters.AddWithValue("@venue_id", venue_idtxt.Text)
            .Parameters.AddWithValue("@event_id", event_idtxt.Text)
            .Parameters.AddWithValue("@cus_id", cus_idtxt.Text)


        End With

        mycmd.ExecuteNonQuery()
        MsgBox("Data Delete Successfully!")
        myconn.Close()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim SDA As New MySqlDataAdapter
        Dim dbdata As New DataTable
        Dim bSource As New BindingSource

        Try
            myconn.Open()
            sql = "Select * FROM reservation"
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
End Class