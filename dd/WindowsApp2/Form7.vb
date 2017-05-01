Public Class Form7
    Private Structure first
        Public Variables
        Dim size As Integer
        Dim inter As Integer
        Dim Process As Integer
        Dim place As Integer
        Dim id As Integer
    End Structure
    Dim objfir(20) As first
    Dim n As Integer
    Dim i As Integer = 0
    Dim x As Integer
    Dim intersum As Integer = 0
    Dim freespace As Integer = 0
    Dim exter As Integer = 0
    Dim l As Integer = 0

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Label2.Text = "enter num of segments"
        Label2.Visible = True
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim word As String
        n = TextBox1.Text
        word = "enter segment values"
        Label3.Text = word
        Label3.Visible = True
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If i < n Then


            objfir(i).size = TextBox2.Text
            objfir(i).id = i
            objfir(i).Process = 0
            DataGridView1.Columns(0).DefaultCellStyle.BackColor = Color.DarkOrange
            DataGridView1.Visible = True
            Me.DataGridView1.Rows.Add(TextBox2.Text, "  ")
            i += 1
        End If

        If i >= n Then
            Label4.Text = " limited reached"
            Label4.Visible = True
            i += 1
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Label4.Text = " enter the num of process"
        Label4.Visible = True
        Dim temp As first
        Dim j As Integer
        For i = 0 To n - 1
            For j = 0 To n - i - 2
                If objfir(j).size > objfir(j + 1).size Then
                    temp = objfir(j)
                    objfir(j) = objfir(j + 1)
                    objfir(j + 1) = temp

                End If


            Next
        Next


    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        x = TextBox7.Text
        If x <= n Then
            Label4.Text = " Proceed
   Enter the processes"
            Label4.Visible = True

        End If
        If x > n Then
            Label4.Text = "num of process is more than segment"
            Label4.Visible = True

        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If l < x And l < n Then
            intersum = 0
            exter = 0
            freespace = 0
            Dim p As Integer
            p = TextBox9.Text
            For i = 0 To n - 1
                If objfir(i).Process <= 0 And p <= objfir(i).size And p > 0 Then
                    objfir(i).Process = p
                    objfir(i).inter = objfir(i).size - p
                    intersum += objfir(i).inter
                    p = 0
                    TextBox3.Text = "process allocated to segment  " & objfir(i).id + 1
                    TextBox3.Visible = True
                    DataGridView1.Columns(0).DefaultCellStyle.BackColor = Color.DarkOrange
                    DataGridView1.Columns(1).DefaultCellStyle.BackColor = Color.DarkOliveGreen
                    DataGridView1.Visible = True
                    Me.DataGridView1.Rows.Insert(objfir(i).id, objfir(i).size, TextBox9.Text)
                    Me.DataGridView1.Rows.RemoveAt(objfir(i).id + 1)

                End If
            Next
            For i = 0 To n - 1
                If objfir(i).Process = 0 Then
                    freespace += objfir(i).size
                    exter += objfir(i).size
                Else
                    freespace += objfir(i).inter

                End If
            Next
            Dim z As Integer = -1
            For i = 0 To n - 1
                If p > objfir(i).size And p < exter Then
                    z += 1
                End If

            Next
            Dim z1 As Integer = 0
            For i = 0 To n - 1
                If p > objfir(i).size And p > exter Then
                    z1 += 1
                End If
            Next
            If z >= 0 Then
                TextBox3.Text = "cant allocate process exter=" & exter
                TextBox4.Text = "freespace=" & freespace
                TextBox4.Visible = True
                TextBox3.Visible = True
                TextBox5.Visible = False


            Else
                TextBox5.Text = "internal=" & intersum
                TextBox4.Text = "freespace=" & freespace
                TextBox4.Visible = True
                TextBox5.Visible = True
            End If
            If z1 > 0 Then
                TextBox3.Text = "cant allocate process "
                TextBox3.Visible = True
                TextBox4.Visible = False
                TextBox5.Visible = False
                TextBox6.Visible = False
            End If

            l += 1
            If l >= n Then

                TextBox6.Text = "limit reached"
                TextBox6.Visible = True
            End If










        End If
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Form3.Show()
        Me.Hide()
    End Sub
End Class