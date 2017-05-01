Public Class Form5
    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Label2.Text = "Memory management is the functionality
of an operating system which handles or 
manages primary memory and moves 
processes back and forth between 
main memory and disk during execution.
Memory management keeps track of each
and every memory location, regardless
of either it is allocated to some process
or it is free."
        Label2.Visible = True
        PictureBox2.Visible = False
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Panel4_Paint(sender As Object, e As PaintEventArgs) Handles Panel4.Paint

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        Label2.Text = "In fixed scheme at the time of installation 
OS will be partitioned into fixed sized
blocks for e.g.  let us consider that each
block is of size 4KBand there are total 4 
partitions. so the  processeswhose memory 
requirement is equals to or less than 
4KB, can only get the memory"
        Button5.Visible = True
        Button7.Visible = True
        Button6.Visible = True
        PictureBox2.Visible = False
        Label2.Visible = True

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Label2.Text = "Advantages: At the time of compilation only 
the address of each word can be given.
Or we can bind address at the
compile time."
        Label2.Visible = True
        PictureBox2.Visible = False
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Label2.Text = "Disadvantages: Degree of multiprogramming 
is rigid its is not flexible because
we cannot change the no. of blocks. 
memory wastage is caused 
due to fragmentation.
Fragmentation:
1)Internal: Partial or Incomplete usage of a
block of memory
2)External: Entire block of available 
memory cannot be used.
"
        Label2.Visible = True
        PictureBox2.Visible = False
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Label2.Text = "Advantages: In this scheme there is no internal
fragmentation.This method is more
flexible as variable size process
can be given memory. there is no
size limitation.
"
        Label2.Visible = True
        PictureBox2.Visible = False
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Label2.Text = "Disadvantages: It also suffers from external
fragmentation. In this scheme compile
time address binding is not possible.
"
        Label2.Visible = True
        PictureBox2.Visible = False
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        Label2.Text = "In variable partitioning  scheme at the 
beginning there are no partitions.
There is only the OS areaand the
rest of the available RAM. The memory
is given to the processes as they arrive.
"
        Label2.Visible = True
        PictureBox2.Visible = False
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs)
        Me.Hide()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Label2.Text = "First fit: There may be many holes
In the memory, so the operating system,
to reduce the amount of time it spends
analyzing the available spaces, begins
at the start of primary memory And allocates
memory from the first hole it encounters
large enough to satisfy the request."
        PictureBox2.Visible = False
        Label2.Visible = True
    End Sub

    Private Sub Button5_Click_1(sender As Object, e As EventArgs) Handles Button5.Click
        Label2.Text = "Best fit: The allocator places a process
in the smallest block of unallocated 
memory in which it will fit."
        PictureBox2.Visible = False
        Label2.Visible = True
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Label2.Text = "Worst fit: The memory manager places
a process in the largest block 
of unallocated memory available."
        PictureBox2.Visible = False
        Label2.Visible = True

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click
        PictureBox2.Visible = True
        Label2.Visible = False

    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) 

        Label2.Text = "asdfasldfja"
        Label2.Visible = True
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Form1.Show()
        Me.Hide()
    End Sub
End Class