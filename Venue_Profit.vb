Imports MySql.Data.MySqlClient

Public Class Venue_Profit


    Private Sub Venue_Profit_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        myconn.ConnectionString = "server=localhost; user id=root;port=3306;password=joana0741;database=reservation_database"

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim SDA As New MySqlDataAdapter
        Dim dbdata As New DataTable
        Dim bSource As New BindingSource

        Try
            myconn.Open()
            sql = "Select * FROM venue_profit"
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