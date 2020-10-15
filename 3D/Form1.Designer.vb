<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.GlControl1 = New OpenTK.GLControl()
        Me.RightBtn = New System.Windows.Forms.Button()
        Me.LeftBtn = New System.Windows.Forms.Button()
        Me.ForwardBtn = New System.Windows.Forms.Button()
        Me.BackwardBtn = New System.Windows.Forms.Button()
        Me.RotateYPlusBtn = New System.Windows.Forms.Button()
        Me.RotateYMinBtn = New System.Windows.Forms.Button()
        Me.UpBtn = New System.Windows.Forms.Button()
        Me.DownBtn = New System.Windows.Forms.Button()
        Me.RotateXMinBtn = New System.Windows.Forms.Button()
        Me.RotateXPlusBtn = New System.Windows.Forms.Button()
        Me.BackflipBtn = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.FrontflipBtn = New System.Windows.Forms.Button()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'GlControl1
        '
        Me.GlControl1.BackColor = System.Drawing.Color.Black
        Me.GlControl1.Location = New System.Drawing.Point(249, 45)
        Me.GlControl1.Name = "GlControl1"
        Me.GlControl1.Size = New System.Drawing.Size(500, 500)
        Me.GlControl1.TabIndex = 0
        Me.GlControl1.VSync = False
        '
        'RightBtn
        '
        Me.RightBtn.Location = New System.Drawing.Point(775, 348)
        Me.RightBtn.Name = "RightBtn"
        Me.RightBtn.Size = New System.Drawing.Size(75, 23)
        Me.RightBtn.TabIndex = 3
        Me.RightBtn.Text = "Right"
        Me.RightBtn.UseVisualStyleBackColor = True
        '
        'LeftBtn
        '
        Me.LeftBtn.Location = New System.Drawing.Point(139, 348)
        Me.LeftBtn.Name = "LeftBtn"
        Me.LeftBtn.Size = New System.Drawing.Size(75, 23)
        Me.LeftBtn.TabIndex = 4
        Me.LeftBtn.Text = "Left"
        Me.LeftBtn.UseVisualStyleBackColor = True
        '
        'ForwardBtn
        '
        Me.ForwardBtn.Location = New System.Drawing.Point(457, 16)
        Me.ForwardBtn.Name = "ForwardBtn"
        Me.ForwardBtn.Size = New System.Drawing.Size(75, 23)
        Me.ForwardBtn.TabIndex = 5
        Me.ForwardBtn.Text = "Forward"
        Me.ForwardBtn.UseVisualStyleBackColor = True
        '
        'BackwardBtn
        '
        Me.BackwardBtn.Location = New System.Drawing.Point(457, 551)
        Me.BackwardBtn.Name = "BackwardBtn"
        Me.BackwardBtn.Size = New System.Drawing.Size(75, 23)
        Me.BackwardBtn.TabIndex = 6
        Me.BackwardBtn.Text = "Backward"
        Me.BackwardBtn.UseVisualStyleBackColor = True
        '
        'RotateYPlusBtn
        '
        Me.RotateYPlusBtn.Location = New System.Drawing.Point(775, 119)
        Me.RotateYPlusBtn.Name = "RotateYPlusBtn"
        Me.RotateYPlusBtn.Size = New System.Drawing.Size(75, 23)
        Me.RotateYPlusBtn.TabIndex = 7
        Me.RotateYPlusBtn.Text = "Rotate Y+"
        Me.RotateYPlusBtn.UseVisualStyleBackColor = True
        '
        'RotateYMinBtn
        '
        Me.RotateYMinBtn.Location = New System.Drawing.Point(139, 119)
        Me.RotateYMinBtn.Name = "RotateYMinBtn"
        Me.RotateYMinBtn.Size = New System.Drawing.Size(75, 23)
        Me.RotateYMinBtn.TabIndex = 8
        Me.RotateYMinBtn.Text = "Rotate Y-"
        Me.RotateYMinBtn.UseVisualStyleBackColor = True
        '
        'UpBtn
        '
        Me.UpBtn.Location = New System.Drawing.Point(303, 16)
        Me.UpBtn.Name = "UpBtn"
        Me.UpBtn.Size = New System.Drawing.Size(75, 23)
        Me.UpBtn.TabIndex = 9
        Me.UpBtn.Text = "Up"
        Me.UpBtn.UseVisualStyleBackColor = True
        '
        'DownBtn
        '
        Me.DownBtn.Location = New System.Drawing.Point(303, 551)
        Me.DownBtn.Name = "DownBtn"
        Me.DownBtn.Size = New System.Drawing.Size(75, 23)
        Me.DownBtn.TabIndex = 10
        Me.DownBtn.Text = "Down"
        Me.DownBtn.UseVisualStyleBackColor = True
        '
        'RotateXMinBtn
        '
        Me.RotateXMinBtn.Location = New System.Drawing.Point(624, 16)
        Me.RotateXMinBtn.Name = "RotateXMinBtn"
        Me.RotateXMinBtn.Size = New System.Drawing.Size(75, 23)
        Me.RotateXMinBtn.TabIndex = 11
        Me.RotateXMinBtn.Text = "Rotate X-"
        Me.RotateXMinBtn.UseVisualStyleBackColor = True
        '
        'RotateXPlusBtn
        '
        Me.RotateXPlusBtn.Location = New System.Drawing.Point(624, 551)
        Me.RotateXPlusBtn.Name = "RotateXPlusBtn"
        Me.RotateXPlusBtn.Size = New System.Drawing.Size(75, 23)
        Me.RotateXPlusBtn.TabIndex = 12
        Me.RotateXPlusBtn.Text = "Rotate X+"
        Me.RotateXPlusBtn.UseVisualStyleBackColor = True
        '
        'BackflipBtn
        '
        Me.BackflipBtn.Location = New System.Drawing.Point(25, 31)
        Me.BackflipBtn.Name = "BackflipBtn"
        Me.BackflipBtn.Size = New System.Drawing.Size(75, 23)
        Me.BackflipBtn.TabIndex = 13
        Me.BackflipBtn.Text = "Backflip"
        Me.BackflipBtn.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        '
        'FrontflipBtn
        '
        Me.FrontflipBtn.Location = New System.Drawing.Point(106, 31)
        Me.FrontflipBtn.Name = "FrontflipBtn"
        Me.FrontflipBtn.Size = New System.Drawing.Size(75, 23)
        Me.FrontflipBtn.TabIndex = 14
        Me.FrontflipBtn.Text = "Frontflip"
        Me.FrontflipBtn.UseVisualStyleBackColor = True
        '
        'Timer2
        '
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(962, 576)
        Me.Controls.Add(Me.FrontflipBtn)
        Me.Controls.Add(Me.BackflipBtn)
        Me.Controls.Add(Me.RotateXPlusBtn)
        Me.Controls.Add(Me.RotateXMinBtn)
        Me.Controls.Add(Me.DownBtn)
        Me.Controls.Add(Me.UpBtn)
        Me.Controls.Add(Me.RotateYMinBtn)
        Me.Controls.Add(Me.RotateYPlusBtn)
        Me.Controls.Add(Me.BackwardBtn)
        Me.Controls.Add(Me.ForwardBtn)
        Me.Controls.Add(Me.LeftBtn)
        Me.Controls.Add(Me.RightBtn)
        Me.Controls.Add(Me.GlControl1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GlControl1 As OpenTK.GLControl
    Friend WithEvents RightBtn As Button
    Friend WithEvents LeftBtn As Button
    Friend WithEvents ForwardBtn As Button
    Friend WithEvents BackwardBtn As Button
    Friend WithEvents RotateYPlusBtn As Button
    Friend WithEvents RotateYMinBtn As Button
    Friend WithEvents UpBtn As Button
    Friend WithEvents DownBtn As Button
    Friend WithEvents RotateXMinBtn As Button
    Friend WithEvents RotateXPlusBtn As Button
    Friend WithEvents BackflipBtn As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents FrontflipBtn As Button
    Friend WithEvents Timer2 As Timer
End Class
