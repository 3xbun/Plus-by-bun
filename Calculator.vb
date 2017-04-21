Public Class form1

#Region "Close Program"
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
#End Region

#Region "Move Form"

    Private IsFormBeingDragged As Boolean = False
    Private MouseDownX As Integer
    Private MouseDownY As Integer

    Private Sub Form1_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs) Handles MyBase.MouseDown

        If e.Button = MouseButtons.Left Then
            IsFormBeingDragged = True
            MouseDownX = e.X
            MouseDownY = e.Y
        End If
    End Sub

    Private Sub Form1_MouseUp(ByVal sender As Object, ByVal e As MouseEventArgs) Handles MyBase.MouseUp

        If e.Button = MouseButtons.Left Then
            IsFormBeingDragged = False
        End If
    End Sub

    Private Sub Form1_MouseMove(ByVal sender As Object, ByVal e As MouseEventArgs) Handles MyBase.MouseMove

        If IsFormBeingDragged Then
            Dim temp As Point = New Point()

            temp.X = Me.Location.X + (e.X - MouseDownX)
            temp.Y = Me.Location.Y + (e.Y - MouseDownY)
            Me.Location = temp
            temp = Nothing
        End If
    End Sub



#End Region

#Region "Calculate Form"
    Dim one As Double
    Dim two As Double
    Dim result As Double

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        one = Val(TextBox1.Text)
        two = Val(TextBox2.Text)
        result = one + two
        TextBox3.Text = result
    End Sub

#End Region

End Class
