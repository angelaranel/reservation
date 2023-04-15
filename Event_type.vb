Imports MySql.Data.MySqlClient

Public Class Event_type
    Private Sub Event_type_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        myconn.ConnectionString = "server=localhost; user id=root;port=3306;password=joana0741;database=reservation_database"

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        myconn.Open()

        sql = "INSERT INTO event_type values (@event_num, @event_name);"


        With mycmd

            .CommandText = "INSERT INTO event_type values (@event_num, @event_name);"

            .CommandType = CommandType.Text
            .Parameters.AddWithValue("@event_num", event_numtxt.Text)
            .Parameters.AddWithValue("@event_name", event_nametxt.Text)



        End With
        mycmd.ExecuteNonQuery()
        MsgBox("Data insert Successfully!")
        myconn.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        myconn.Open()

        mycmd.Connection = myconn

        With mycmd

            .CommandText = "UPDATE event_type SET event_name = @event_name where event_num = @event_num"

            .CommandType = CommandType.Text
            .Parameters.AddWithValue("@event_num", event_numtxt.Text)
            .Parameters.AddWithValue("@event_name", event_nametxt.Text)

        End With

        mycmd.ExecuteNonQuery()
        MsgBox("Data Update Successfully!")
        myconn.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        myconn.Open()

        mycmd.Connection = myconn

        With mycmd

            .CommandText = "DELETE FROM event_type where event_num = @event_num"

            .CommandType = CommandType.Text
            .Parameters.AddWithValue("@event_num", event_numtxt.Text)
            .Parameters.AddWithValue("@event_name", event_nametxt.Text)

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
            sql = "Select * FROM event_type"
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