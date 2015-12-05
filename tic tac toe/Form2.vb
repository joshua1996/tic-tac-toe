Public Class Form2

    Dim playerRoundB As Boolean
    Dim playerTurn As Integer
    Dim buttonList As New List(Of Button)
    Dim playerOorX As String
    Dim aiOorX As String
    Dim aiButtonRandom As New List(Of Button)
    Dim r As New Random

    Private Sub Form2_Activated(sender As Object, e As System.EventArgs) Handles Me.Activated
        
    End Sub

    Private Sub Form2_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        starting()
     
    End Sub

    Private Sub starting()
        ' Dim r As New Random()
        playerRoundB = False
        Dim n As Integer = r.Next(2)

        buttonList.Add(Button1)
        buttonList.Add(Button2)
        buttonList.Add(Button3)
        buttonList.Add(Button4)
        buttonList.Add(Button5)
        buttonList.Add(Button6)
        buttonList.Add(Button7)
        buttonList.Add(Button8)
        buttonList.Add(Button9)
        playerTurn = n

      

        If n = 0 Then 'player 1st
            playerOorX = "X"
            aiOorX = "O"
        ElseIf n = 1 Then 'ai 1st
            playerOorX = "O"
            aiOorX = "X"
        End If
        whoFirst(n)
    End Sub

    Private Function whoFirst(ByVal a As Integer)
        If a Mod 2 = 0 Then '0 2 4
            playerRoundB = True

        ElseIf a Mod 2 = 1 Then '1 3 5
            '  playerRoundB = False

            aiRound()
        End If
        Return 0
    End Function

    Private Sub playerRound(sender As System.Object, e As System.EventArgs) Handles Button1.Click, Button2.Click, Button3.Click, Button4.Click, Button5.Click, Button6.Click, Button7.Click, Button8.Click, Button9.Click
        If playerRoundB = True Then

            Dim btn As Button = CType(sender, Button)
            buttonList.Remove(btn)
            btn.Text = playerOorX
            btn.Enabled = False
            playerRoundB = False
            playerTurn += 1
            win()
            draw()

            whoFirst(playerTurn)
        End If
    End Sub

    Private Sub aiRound()

        If playerRoundB = False And buttonList.Count > 0 Then
            If aiOorX = "X" And playerTurn = 1 Then
                ' Dim r As New Random
                Dim buttonListCout As Integer = buttonList.Count - 1
                Dim aiButtonClick As Integer = r.Next(0, buttonListCout)
                Dim getButton = buttonList(aiButtonClick)

                If getButton.Enabled = True Then
                    getButton.Text = aiOorX
                    getButton.Enabled = False
                    buttonList.RemoveAt(aiButtonClick)
                End If
                ' ElseIf aiOorX = "X" Or aiOorX = "O" And playerTurn > 1 Then

            Else
                If aiOorX = "X" Then

                    aiButtonRandom.Clear()
                    'Threading.Thread.Sleep(500)
                    'If Button1.Text = "o" Then
                    '    If buttonList.Contains(Button3) Then
                    '        aiButtonRandom.Add(Button3)
                    '    End If
                    '    If buttonList.Contains(Button7) Then
                    '        aiButtonRandom.Add(Button7)
                    '    End If
                    '    If buttonList.Contains(Button5) Then
                    '        aiButtonRandom.Add(Button5)
                    '    End If

                    '    Dim a As Integer = r.Next(0, aiButtonRandom.Count - 1)
                    '    aiButtonRandom.Item(a).Enabled = False
                    '    aiButtonRandom.Item(a).Text = "x"
                    '    buttonList.Remove(aiButtonRandom.Item(a))
                    'End If

                    If Button1.Text = playerOorX And Button2.Text = playerOorX And Button3.Enabled = True Then '12
                        Button3.Enabled = False
                        Button3.Text = aiOorX
                        buttonList.Remove(Button3)
                    ElseIf Button2.Text = playerOorX And Button3.Text = playerOorX And Button1.Enabled = True Then '23
                        Button1.Enabled = False
                        Button1.Text = aiOorX
                        buttonList.Remove(Button1)
                    ElseIf Button1.Text = playerOorX And Button3.Text = playerOorX And Button2.Enabled = True Then '13
                        Button2.Enabled = False
                        Button2.Text = aiOorX
                        buttonList.Remove(Button2)
                    ElseIf Button1.Text = playerOorX And Button4.Text = playerOorX And Button7.Enabled = True Then '14
                        Button7.Enabled = False
                        Button7.Text = aiOorX
                        buttonList.Remove(Button7)
                    ElseIf Button4.Text = playerOorX And Button7.Text = playerOorX And Button1.Enabled = True Then '47
                        Button1.Enabled = False
                        Button1.Text = aiOorX
                        buttonList.Remove(Button1)
                    ElseIf Button1.Text = playerOorX And Button7.Text = playerOorX And Button4.Enabled = True Then '17
                        Button4.Enabled = False
                        Button4.Text = aiOorX
                        buttonList.Remove(Button4)
                    ElseIf Button3.Text = playerOorX And Button6.Text = playerOorX And Button9.Enabled = True Then '36
                        Button9.Enabled = False
                        Button9.Text = aiOorX
                        buttonList.Remove(Button9)
                    ElseIf Button6.Text = playerOorX And Button9.Text = playerOorX And Button4.Enabled = True Then '69
                        Button3.Enabled = False
                        Button3.Text = aiOorX
                        buttonList.Remove(Button4)
                    ElseIf Button3.Text = playerOorX And Button9.Text = playerOorX And Button6.Enabled = True Then '39
                        Button6.Enabled = False
                        Button6.Text = aiOorX
                        buttonList.Remove(Button6)
                    ElseIf Button7.Text = playerOorX And Button8.Text = playerOorX And Button9.Enabled = True Then '78
                        Button9.Enabled = False
                        Button9.Text = aiOorX
                        buttonList.Remove(Button9)
                    ElseIf Button8.Text = playerOorX And Button9.Text = playerOorX And Button7.Enabled = True Then '89
                        Button7.Enabled = False
                        Button7.Text = aiOorX
                        buttonList.Remove(Button7)
                    ElseIf Button1.Text = playerOorX And Button7.Text = playerOorX And Button8.Enabled = True Then '79
                        Button8.Enabled = False
                        Button8.Text = aiOorX
                        buttonList.Remove(Button8)
                    ElseIf Button2.Text = playerOorX And Button5.Text = playerOorX And Button8.Enabled = True Then '25
                        Button8.Enabled = False
                        Button8.Text = aiOorX
                        buttonList.Remove(Button8)
                    ElseIf Button5.Text = playerOorX And Button8.Text = playerOorX And Button2.Enabled = True Then '58
                        Button2.Enabled = False
                        Button2.Text = aiOorX
                        buttonList.Remove(Button2)
                    ElseIf Button2.Text = playerOorX And Button8.Text = playerOorX And Button5.Enabled = True Then '28
                        Button5.Enabled = False
                        Button5.Text = aiOorX
                        buttonList.Remove(Button5)
                    ElseIf Button1.Text = playerOorX And Button5.Text = playerOorX And Button9.Enabled = True Then '15
                        Button9.Enabled = False
                        Button9.Text = aiOorX
                        buttonList.Remove(Button9)
                    ElseIf Button5.Text = playerOorX And Button9.Text = playerOorX And Button1.Enabled = True Then '59
                        Button1.Enabled = False
                        Button1.Text = aiOorX
                        buttonList.Remove(Button1)
                    ElseIf Button1.Text = playerOorX And Button9.Text = playerOorX And Button5.Enabled = True Then '19
                        Button5.Enabled = False
                        Button5.Text = aiOorX
                        buttonList.Remove(Button5)
                    ElseIf Button3.Text = playerOorX And Button5.Text = playerOorX And Button7.Enabled = True Then '35
                        Button7.Enabled = False
                        Button7.Text = aiOorX
                        buttonList.Remove(Button7)
                    ElseIf Button5.Text = playerOorX And Button7.Text = playerOorX And Button3.Enabled = True Then '57
                        Button3.Enabled = False
                        Button3.Text = aiOorX
                        buttonList.Remove(Button3)
                    ElseIf Button3.Text = playerOorX And Button7.Text = playerOorX And Button5.Enabled = True Then '37
                        Button5.Enabled = False
                        Button5.Text = aiOorX
                        buttonList.Remove(Button5)
                    ElseIf Button4.Text = playerOorX And Button5.Text = playerOorX And Button6.Enabled = True Then '45
                        Button6.Enabled = False
                        Button6.Text = aiOorX
                        buttonList.Remove(Button6)
                    ElseIf Button5.Text = playerOorX And Button6.Text = playerOorX And Button4.Enabled = True Then '56
                        Button4.Enabled = False
                        Button4.Text = aiOorX
                        buttonList.Remove(Button4)
                    ElseIf Button4.Text = playerOorX And Button6.Text = playerOorX And Button5.Enabled = True Then '46
                        Button5.Enabled = False
                        Button5.Text = aiOorX
                        buttonList.Remove(Button5)
                    Else

                        Dim a As Integer = r.Next(0, buttonList.Count - 1)
                        buttonList.Item(a).Enabled = False
                        buttonList.Item(a).Text = aiOorX
                        buttonList.RemoveAt(a)
                        'MsgBox(True)
                    End If

                ElseIf aiOorX = "O" Then
                    aiButtonRandom.Clear()
                    ' Threading.Thread.Sleep(500)
                    'If Button1.Text = "X" Then
                    '    If buttonList.Contains(Button3) Then
                    '        aiButtonRandom.Add(Button3)
                    '    End If
                    '    If buttonList.Contains(Button7) Then
                    '        aiButtonRandom.Add(Button7)
                    '    End If
                    '    If buttonList.Contains(Button5) Then
                    '        aiButtonRandom.Add(Button5)
                    '    End If

                    '    Dim a As Integer = r.Next(0, aiButtonRandom.Count - 1)
                    '    aiButtonRandom.Item(a).Enabled = False
                    '    aiButtonRandom.Item(a).Text = "O"
                    '    buttonList.Remove(aiButtonRandom.Item(a))
                    'End If
                    If Button1.Text = playerOorX And Button2.Text = playerOorX And Button3.Enabled = True Then '12
                        Button3.Enabled = False
                        Button3.Text = aiOorX
                        buttonList.Remove(Button3)
                    ElseIf Button2.Text = playerOorX And Button3.Text = playerOorX And Button1.Enabled = True Then '23
                        Button1.Enabled = False
                        Button1.Text = aiOorX
                        buttonList.Remove(Button1)
                    ElseIf Button1.Text = playerOorX And Button3.Text = playerOorX And Button2.Enabled = True Then '13
                        Button2.Enabled = False
                        Button2.Text = aiOorX
                        buttonList.Remove(Button2)
                    ElseIf Button1.Text = playerOorX And Button4.Text = playerOorX And Button7.Enabled = True Then '14
                        Button7.Enabled = False
                        Button7.Text = aiOorX
                        buttonList.Remove(Button7)
                    ElseIf Button4.Text = playerOorX And Button7.Text = playerOorX And Button1.Enabled = True Then '47
                        Button1.Enabled = False
                        Button1.Text = aiOorX
                        buttonList.Remove(Button1)
                    ElseIf Button1.Text = playerOorX And Button7.Text = playerOorX And Button4.Enabled = True Then '17
                        Button4.Enabled = False
                        Button4.Text = aiOorX
                        buttonList.Remove(Button4)
                    ElseIf Button3.Text = playerOorX And Button6.Text = playerOorX And Button9.Enabled = True Then '36
                        Button9.Enabled = False
                        Button9.Text = aiOorX
                        buttonList.Remove(Button9)
                    ElseIf Button6.Text = playerOorX And Button9.Text = playerOorX And Button4.Enabled = True Then '69
                        Button3.Enabled = False
                        Button3.Text = aiOorX
                        buttonList.Remove(Button4)
                    ElseIf Button3.Text = playerOorX And Button9.Text = playerOorX And Button6.Enabled = True Then '39
                        Button6.Enabled = False
                        Button6.Text = aiOorX
                        buttonList.Remove(Button6)
                    ElseIf Button7.Text = playerOorX And Button8.Text = playerOorX And Button9.Enabled = True Then '78
                        Button9.Enabled = False
                        Button9.Text = aiOorX
                        buttonList.Remove(Button9)
                    ElseIf Button8.Text = playerOorX And Button9.Text = playerOorX And Button7.Enabled = True Then '89
                        Button7.Enabled = False
                        Button7.Text = aiOorX
                        buttonList.Remove(Button7)
                    ElseIf Button1.Text = playerOorX And Button7.Text = playerOorX And Button8.Enabled = True Then '79
                        Button8.Enabled = False
                        Button8.Text = aiOorX
                        buttonList.Remove(Button8)
                    ElseIf Button2.Text = playerOorX And Button5.Text = playerOorX And Button8.Enabled = True Then '25
                        Button8.Enabled = False
                        Button8.Text = aiOorX
                        buttonList.Remove(Button8)
                    ElseIf Button5.Text = playerOorX And Button8.Text = playerOorX And Button2.Enabled = True Then '58
                        Button2.Enabled = False
                        Button2.Text = aiOorX
                        buttonList.Remove(Button2)
                    ElseIf Button2.Text = playerOorX And Button8.Text = playerOorX And Button5.Enabled = True Then '28
                        Button5.Enabled = False
                        Button5.Text = aiOorX
                        buttonList.Remove(Button5)
                    ElseIf Button1.Text = playerOorX And Button5.Text = playerOorX And Button9.Enabled = True Then '15
                        Button9.Enabled = False
                        Button9.Text = aiOorX
                        buttonList.Remove(Button9)
                    ElseIf Button5.Text = playerOorX And Button9.Text = playerOorX And Button1.Enabled = True Then '59
                        Button1.Enabled = False
                        Button1.Text = aiOorX
                        buttonList.Remove(Button1)
                    ElseIf Button1.Text = playerOorX And Button9.Text = playerOorX And Button5.Enabled = True Then '19
                        Button5.Enabled = False
                        Button5.Text = aiOorX
                        buttonList.Remove(Button5)
                    ElseIf Button3.Text = playerOorX And Button5.Text = playerOorX And Button7.Enabled = True Then '35
                        Button7.Enabled = False
                        Button7.Text = aiOorX
                        buttonList.Remove(Button7)
                    ElseIf Button5.Text = playerOorX And Button7.Text = playerOorX And Button3.Enabled = True Then '57
                        Button3.Enabled = False
                        Button3.Text = aiOorX
                        buttonList.Remove(Button3)
                    ElseIf Button3.Text = playerOorX And Button7.Text = playerOorX And Button5.Enabled = True Then '37
                        Button5.Enabled = False
                        Button5.Text = aiOorX
                        buttonList.Remove(Button5)
                    ElseIf Button4.Text = playerOorX And Button5.Text = playerOorX And Button6.Enabled = True Then '45
                        Button6.Enabled = False
                        Button6.Text = aiOorX
                        buttonList.Remove(Button6)
                    ElseIf Button5.Text = playerOorX And Button6.Text = playerOorX And Button4.Enabled = True Then '56
                        Button4.Enabled = False
                        Button4.Text = aiOorX
                        buttonList.Remove(Button4)
                    ElseIf Button4.Text = playerOorX And Button6.Text = playerOorX And Button5.Enabled = True Then '46
                        Button5.Enabled = False
                        Button5.Text = aiOorX
                        buttonList.Remove(Button5)
                    Else

                        Dim a As Integer = r.Next(0, buttonList.Count - 1)
                        buttonList.Item(a).Enabled = False
                        buttonList.Item(a).Text = aiOorX
                        buttonList.RemoveAt(a)
                        '  MsgBox(True)
                    End If


                End If
                
            End If


            playerRoundB = True
            playerTurn += 1
            win()
            draw()
            
            whoFirst(playerTurn)
        End If

    End Sub

 
    Private Sub win()
        If Button1.Text = "X" And Button2.Text = "X" And Button3.Text = "X" Then '123
            Xwin()
        ElseIf Button1.Text = "X" And Button4.Text = "X" And Button7.Text = "X" Then '147
            Xwin()
        ElseIf Button7.Text = "X" And Button8.Text = "X" And Button9.Text = "X" Then '789
            Xwin()
        ElseIf Button3.Text = "X" And Button6.Text = "X" And Button9.Text = "X" Then '369
            Xwin()
        ElseIf Button1.Text = "X" And Button5.Text = "X" And Button9.Text = "X" Then '159
            Xwin()
        ElseIf Button3.Text = "X" And Button5.Text = "X" And Button7.Text = "X" Then '357
            Xwin()
        ElseIf Button2.Text = "X" And Button5.Text = "X" And Button8.Text = "X" Then '258
            Xwin()
        ElseIf Button4.Text = "X" And Button5.Text = "X" And Button6.Text = "X" Then '456
            Xwin()
        End If

        If Button1.Text = "O" And Button2.Text = "O" And Button3.Text = "O" Then '123

            Owin()
        ElseIf Button1.Text = "O" And Button4.Text = "O" And Button7.Text = "O" Then '147
            Owin()
        ElseIf Button7.Text = "O" And Button8.Text = "O" And Button9.Text = "O" Then '789
            Owin()
        ElseIf Button3.Text = "O" And Button6.Text = "O" And Button9.Text = "O" Then '369
            Owin()
        ElseIf Button1.Text = "O" And Button5.Text = "O" And Button9.Text = "O" Then '159
            Owin()
        ElseIf Button3.Text = "O" And Button5.Text = "O" And Button7.Text = "O" Then '357
            Owin()
        ElseIf Button2.Text = "O" And Button5.Text = "O" And Button8.Text = "O" Then '258
            Owin()
        ElseIf Button4.Text = "O" And Button5.Text = "O" And Button6.Text = "O" Then '456
            Owin()
        End If
    End Sub

    Private Sub Xwin()
        If playerOorX = "X" Then
            MsgBox("player Win")
            Label3.Text = Val(Label3.Text) + 1
        ElseIf aiOorX = "X" Then
            MsgBox("ai win")
            Label4.Text = Val(Label4.Text) + 1
        End If
        reset()
    End Sub

    Private Sub Owin()
        If playerOorX = "O" Then
            MsgBox("player win")
            Label3.Text = Val(Label3.Text) + 1
        ElseIf aiOorX = "O" Then
            MsgBox("ai win")
            Label4.Text = Val(Label4.Text) + 1
        End If
        reset()
    End Sub

    Private Sub reset()
        buttonList.Clear()
        
        For Each buttonclear As Button In Panel1.Controls
            buttonclear.Text = ""
            buttonclear.Enabled = True

        Next
        starting()
    End Sub

    Private Sub draw()
        Dim cout As Integer
        For Each a As Button In Panel1.Controls
            If a.Enabled = False Then
                cout += 1
            End If
        Next
        If cout >= 9 Then
            MsgBox("draw")
            Label6.Text = Val(Label6.Text) + 1
            reset()

        End If
    End Sub

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
       Label7.Text = playerRoundB
        Label8.Text = playerTurn
    End Sub
End Class