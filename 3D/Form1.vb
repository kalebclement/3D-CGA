Imports OpenTK
Imports OpenTK.Graphics
Imports OpenTK.Graphics.OpenGL

Public Class Form1
    Dim z_position As Double = -50
    Dim x_position As Double = -40
    Dim y_position As Double = 0
    Dim rotateY As Double = 0
    Dim rotateZ As Double = 0
    Dim flipmaxPlus As Integer
    Dim flipmaxMin As Integer
    Private Sub draw()
        Dim x As Integer = 10
        Dim y As Integer = 10
        Dim z As Integer = 10
        Dim r As Double = 1
        Dim g As Double = 0
        Dim b As Double = 0

        GL.Translate(x_position, y_position, z_position)

        For i As Integer = 1 To 9
            Select Case i
                Case 2
                    x = x + 40
                    g = 1
                Case 3
                    x = x + 40
                    b = 1
                Case 4
                    x = 10
                    z = z - 50
                    r = 0
                Case 5
                    x = x + 40
                    g = 0
                Case 6
                    x = x + 40
                    r = 1
                Case 7
                    x = 10
                    z = z - 50
                    r = 0
                    g = 1
                    b = 0
                Case 8
                    x = x + 40
                    r = 1
                    b = 0.5
                Case 9
                    x = x + 40
                    r = 0.5
                    g = 0
                    b = 1
            End Select

            GL.Begin(BeginMode.LineStrip)
            'front
            GL.Color3(r, g, b)
            GL.Vertex3(x, y, z)
            GL.Vertex3(x, y - 20, z)
            GL.Vertex3(x - 20, y - 20, z)
            GL.Vertex3(x - 20, y, z)
            GL.Vertex3(x, y, z)
            GL.End()

            GL.Begin(BeginMode.LineStrip)
            'back
            GL.Color3(r, g, b)
            GL.Vertex3(x, y, z - 20)
            GL.Vertex3(x, y - 20, z - 20)
            GL.Vertex3(x - 20, y - 20, z - 20)
            GL.Vertex3(x - 20, y, z - 20)
            GL.Vertex3(x, y, z - 20)
            GL.End()

            GL.Begin(BeginMode.LineStrip)
            'left
            GL.Color3(r, g, b)
            GL.Vertex3(x, y, z - 20)
            GL.Vertex3(x, y, z)
            GL.Vertex3(x, y - 20, z)
            GL.Vertex3(x, y - 20, z - 20)
            GL.End()

            GL.Begin(BeginMode.LineStrip)
            'right
            GL.Color3(r, g, b)
            GL.Vertex3(x - 20, y - 20, z - 20)
            GL.Vertex3(x - 20, y - 20, z)
            GL.Vertex3(x - 20, y, z)
            GL.Vertex3(x - 20, y, z - 20)
            GL.End()

        Next i

        'Finally...
        GraphicsContext.CurrentContext.VSync = True 'Caps frame rate as to not over run GPU
        GlControl1.SwapBuffers() 'Takes from the 'GL' and puts into control
    End Sub

    Private Sub GlControl1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GlControl1.Load
        'Control is loaded, set back color
        GL.ClearColor(Color.Black)
    End Sub

    Private Sub GlControl1_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles GlControl1.Paint
        'First Clear Buffers
        GL.Clear(ClearBufferMask.ColorBufferBit)
        GL.Clear(ClearBufferMask.DepthBufferBit)


        'Basic Setup for viewing
        GL.Viewport(0, 0, GlControl1.Width, GlControl1.Height) 'Size of window
        Dim perspective As Matrix4 = Matrix4.Perspective(45, 1, 1, 10000) 'Setup Perspective
        GL.MatrixMode(MatrixMode.Projection) 'Load Perspective
        GL.LoadIdentity()
        GL.LoadMatrix(perspective)
        GL.MatrixMode(MatrixMode.Modelview) 'Load Camera
        GL.LoadIdentity()
        'GL.Enable(EnableCap.DepthTest) 'Enable correct Z Drawings
        'GL.DepthFunc(DepthFunction.Less) 'Enable correct Z Drawings

        'Rotating
        GL.Rotate(rotateZ, 1, 0, 0)
        GL.Rotate(rotateY, 0, 1, 0)


        draw()


    End Sub

    Private Sub RightBtn_Click(sender As Object, e As EventArgs) Handles RightBtn.Click
        GlControl1.Invalidate()
        x_position -= 4
    End Sub

    Private Sub LeftBtn_Click(sender As Object, e As EventArgs) Handles LeftBtn.Click
        GlControl1.Invalidate()
        x_position += 4
    End Sub

    Private Sub BackwardBtn_Click(sender As Object, e As EventArgs) Handles BackwardBtn.Click
        GlControl1.Invalidate()
        z_position -= 4
    End Sub

    Private Sub ForwardBtn_Click(sender As Object, e As EventArgs) Handles ForwardBtn.Click
        GlControl1.Invalidate()
        z_position += 4
    End Sub

    Private Sub RotateYPlusBtn_Click(sender As Object, e As EventArgs) Handles RotateYPlusBtn.Click
        GlControl1.Invalidate()
        rotateY += 4
    End Sub

    Private Sub RotateYMinBtn_Click(sender As Object, e As EventArgs) Handles RotateYMinBtn.Click
        GlControl1.Invalidate()
        rotateY -= 4
    End Sub

    Private Sub UpBtn_Click(sender As Object, e As EventArgs) Handles UpBtn.Click
        GlControl1.Invalidate()
        y_position -= 4
    End Sub

    Private Sub DownBtn_Click(sender As Object, e As EventArgs) Handles DownBtn.Click
        GlControl1.Invalidate()
        y_position += 4
    End Sub

    Private Sub RotateXMinBtn_Click(sender As Object, e As EventArgs) Handles RotateXMinBtn.Click
        GlControl1.Invalidate()
        rotateZ -= 4
    End Sub

    Private Sub RotateXPlusBtn_Click(sender As Object, e As EventArgs) Handles RotateXPlusBtn.Click
        GlControl1.Invalidate()
        rotateZ += 4
    End Sub

    Private Sub BackflipBtn_Click(sender As Object, e As EventArgs) Handles BackflipBtn.Click
        flipmaxMin = rotateZ - 360
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timer1.Interval = 10
        GlControl1.Invalidate()
        rotateZ -= 10
        If rotateZ = flipmaxMin Then
            Timer1.Stop()
            rotateZ = flipmaxMin
        End If
    End Sub

    Private Sub FrontflipBtn_Click(sender As Object, e As EventArgs) Handles FrontflipBtn.Click
        flipmaxPlus = rotateZ + 360
        Timer2.Start()
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Timer2.Interval = 10
        GlControl1.Invalidate()
        rotateZ += 10
        If rotateZ = flipmaxPlus Then
            Timer2.Stop()
            rotateZ = flipmaxPlus
        End If
    End Sub
End Class