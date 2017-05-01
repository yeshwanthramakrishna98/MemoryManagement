Public Class Form10
    Dim n As Integer
    Dim p As Integer
    Dim i As Integer = 0
    Dim k As Integer = 0
    Dim par(30) As Integer
    Dim pro(30) As Integer
    Dim j As Integer
    Dim exfrag As Integer = 0
    Dim tot As Integer = 0
    Dim mem(10) As Integer
    Dim done(10) As Integer

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Label2.Text = "enter num of partition"
        Label2.Visible = True
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        n = TextBox1.Text
        Label2.Text = "enter the partions"
        Label2.Visible = True
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If i < n Then
            par(i) = TextBox2.Text
            DataGridView1.Visible = True

            DataGridView1.Columns(0).DefaultCellStyle.BackColor = Color.DarkOrange
            Me.DataGridView1.Rows.Add(TextBox2.Text)
            i += 1
        Else
            Label2.Text = "segments limit exceeded"
            Label2.Visible = True
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Label3.Text = "enter the num of processes"
        Label3.Visible = True
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Label3.Text = "enter the processes"
        p = TextBox3.Text
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If k < p Then
            pro(k) = TextBox4.Text
            k += 1

            DataGridView2.Columns(0).DefaultCellStyle.BackColor = Color.Blue
            DataGridView2.Visible = True
            Me.DataGridView2.Rows.Add(TextBox4.Text)
        Else
            Label3.Text = "limit exceeded"
            Label3.Visible = True
        End If
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        For i = 0 To p - 1
            done(i) = 0
        Next
        For i = 0 To n - 1
            mem(i) = par(i)
            tot += par(i)

        Next
        For i = 0 To p - 1
            Dim min(2) As Integer
            min(0) = 99
            min(1) = -1
            For j = 0 To n - 1
                If mem(j) >= pro(i) And mem(j) - pro(i) < min(0) Then
                    min(0) = mem(j) - pro(i)
                    min(1) = j


                End If
            Next
            If min(1) > -1 Then
                DataGridView3.Visible = True
                DataGridView3.Columns(1).DefaultCellStyle.BackColor = Color.Blue
                DataGridView3.Columns(0).DefaultCellStyle.BackColor = Color.DarkOrange
                Me.DataGridView3.Rows.Add(min(1) + 1, pro(i))
                tot -= pro(i)
                done(i) = 1
                mem(min(1)) = min(0)
            End If
            If done(i) = 0 And tot >= pro(i) Then
                exfrag += pro(i)
                TextBox5.Text = "process" & i + 1 & ":externally fragmented" & tot
                TextBox5.Visible = True
            End If
            If done(i) = 0 Then
                TextBox7.Text = "not enough space for process " & i + 1
                TextBox7.Visible = True
            End If
        Next
        TextBox6.Text = "remaining free space" & tot
        TextBox6.Visible = True
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Form4.Show()
        Me.Hide()
    End Sub
End Class