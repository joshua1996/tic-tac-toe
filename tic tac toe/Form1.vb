Public Class Form1

    Dim playerDom As Integer = 1
    Dim playerX As Integer
    Dim playerY As Integer

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        '''''''''''''''''START AT O ERROR!!!

    End Sub

    Private Sub start()

    End Sub

    Private Sub buttonClick(sender As System.Object, e As System.EventArgs) Handles Button1.Click, Button2.Click, Button3.Click, Button4.Click, Button5.Click, Button6.Click, Button7.Click, Button8.Click, Button9.Click
        Dim btn As Button = CType(sender, Button)
        If playerDom Mod 2 = 1 Then
            btn.Text = "X"
            playerX += 1
        ElseIf playerDom Mod 2 = 0 Then
            btn.Text = "O"
            playerY += 1
        End If
        btn.Enabled = False

        If playerX >= 3 Then

            If Button1.Text = "X" And Button2.Text = "X" And Button3.Text = "X" Then '123

                playerWin(True)
            ElseIf Button1.Text = "X" And Button4.Text = "X" And Button7.Text = "X" Then '147
                playerWin(True)
            ElseIf Button7.Text = "X" And Button8.Text = "X" And Button9.Text = "X" Then '789
                playerWin(True)
            ElseIf Button3.Text = "X" And Button6.Text = "X" And Button9.Text = "X" Then '369
                playerWin(True)
            ElseIf Button1.Text = "X" And Button5.Text = "X" And Button9.Text = "X" Then '159
                playerWin(True)
            ElseIf Button3.Text = "X" And Button5.Text = "X" And Button7.Text = "X" Then '357
                playerWin(True)
            ElseIf Button2.Text = "X" And Button5.Text = "X" And Button8.Text = "X" Then '258
                playerWin(True)
            ElseIf Button4.Text = "X" And Button5.Text = "X" And Button6.Text = "X" Then '456
                playerWin(True)
            End If
        End If

        If playerY >= 3 Then
            If Button1.Text = "O" And Button2.Text = "O" And Button3.Text = "O" Then '123

                playerWin(False)
            ElseIf Button1.Text = "O" And Button4.Text = "O" And Button7.Text = "O" Then '147
                playerWin(False)
            ElseIf Button7.Text = "O" And Button8.Text = "O" And Button9.Text = "O" Then '789
                playerWin(False)
            ElseIf Button3.Text = "O" And Button6.Text = "O" And Button9.Text = "O" Then '369
                playerWin(False)
            ElseIf Button1.Text = "O" And Button5.Text = "O" And Button9.Text = "O" Then '159
                playerWin(False)
            ElseIf Button3.Text = "O" And Button5.Text = "O" And Button7.Text = "O" Then '357
                playerWin(False)
            ElseIf Button2.Text = "O" And Button5.Text = "O" And Button8.Text = "O" Then '258
                playerWin(False)
            ElseIf Button4.Text = "O" And Button5.Text = "O" And Button6.Text = "O" Then '456
                playerWin(False)
            End If
        End If
        draw()
       
        playerDom += 1

    End Sub

    Private Function playerWin(ByVal b As Boolean)
        For Each a As Button In Panel1.Controls
            a.Enabled = False

        Next
        If b = True Then
            MsgBox("playerX win!")
            Label3.Text = Val(Label3.Text) + 1
            restart()
        Else
            MsgBox("player Y win!")
            Label4.Text = Val(Label4.Text) + 1
            restart()
        End If

        Return 0
    End Function

    Private Sub restart()
        For Each a As Button In Panel1.Controls
            a.Text = ""
            a.Enabled = True

        Next
        playerX = 0
        playerY = 0
        playerDom = 0

    End Sub

    Private Function draw()
        If playerX + playerY >= 9 Then
            MsgBox("draw")
            Label6.Text = Val(Label6.Text) + 1
            restart()
        End If
        Return 0
    End Function

    
    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        Label7.Text = playerDom
    End Sub
End Class
