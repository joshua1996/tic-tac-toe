Imports MySql.Data.MySqlClient
Imports System.Net.Mail

Public Class Form3

    Private Sub Form3_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        '    Dim connection As String = "server=sql6.freemysqlhosting.net;user=sql696966;database=sql696966;port=3306;password=lP4%hX2%;"
        '    Dim connect As New MySqlConnection(connection)
        '    Dim adp As New MySqlDataAdapter("select * from helloworld", connect)
        '    Dim dt As New DataTable
        '    adp.Fill(dt)
        '    Try
        '        connect.Open()
        '        ' MsgBox(True)
        '        DataGridView1.DataSource = dt
        '    Catch ex As Exception
        '        Throw ex
        '    Finally
        '        connect.Close()
        '    End Try
        Try
            Dim SmtpServer As New SmtpClient()
            Dim mail As New MailMessage()
            SmtpServer.Credentials = New  _
  Net.NetworkCredential("username@gmail.com", "password")
            SmtpServer.Port = 587
            SmtpServer.Host = "smtp.gmail.com"
            mail = New MailMessage()
            mail.From = New MailAddress("YOURusername@gmail.com")
            mail.To.Add("TOADDRESS")
            mail.Subject = "Test Mail"
            mail.Body = "This is for testing SMTP mail from GMAIL"
            SmtpServer.Send(mail)
            MsgBox("mail send")
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
End Class