<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Login))
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        PictureBox1 = New PictureBox()
        UidTb = New TextBox()
        PassTb = New TextBox()
        Button1 = New Button()
        Button2 = New Button()
        Label4 = New Label()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Tekton Pro", 13.7999992F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = Color.DarkCyan
        Label1.Location = New Point(93, 30)
        Label1.Name = "Label1"
        Label1.Size = New Size(310, 28)
        Label1.TabIndex = 1
        Label1.Text = "Employee Management System"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.ForeColor = Color.DarkCyan
        Label2.Location = New Point(150, 104)
        Label2.Name = "Label2"
        Label2.Size = New Size(76, 26)
        Label2.TabIndex = 2
        Label2.Text = "User ID" & vbCrLf
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.ForeColor = Color.DarkCyan
        Label3.Location = New Point(150, 157)
        Label3.Name = "Label3"
        Label3.Size = New Size(94, 26)
        Label3.TabIndex = 3
        Label3.Text = "Password"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(50, 114)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(76, 69)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 4
        PictureBox1.TabStop = False
        ' 
        ' UidTb
        ' 
        UidTb.BackColor = Color.Beige
        UidTb.Font = New Font("Sitka Banner Semibold", 9F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        UidTb.Location = New Point(248, 105)
        UidTb.Name = "UidTb"
        UidTb.Size = New Size(184, 26)
        UidTb.TabIndex = 5
        ' 
        ' PassTb
        ' 
        PassTb.BackColor = Color.Beige
        PassTb.Font = New Font("Sitka Banner Semibold", 9F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        PassTb.Location = New Point(248, 157)
        PassTb.Name = "PassTb"
        PassTb.PasswordChar = "*"c
        PassTb.Size = New Size(184, 26)
        PassTb.TabIndex = 6
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.YellowGreen
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Sitka Display", 10.1999989F, FontStyle.Bold, GraphicsUnit.Point)
        Button1.ForeColor = SystemColors.ActiveCaptionText
        Button1.Location = New Point(164, 207)
        Button1.Name = "Button1"
        Button1.Size = New Size(107, 44)
        Button1.TabIndex = 7
        Button1.Text = "Login"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.Khaki
        Button2.FlatStyle = FlatStyle.Flat
        Button2.Font = New Font("Sitka Display", 10.1999989F, FontStyle.Bold, GraphicsUnit.Point)
        Button2.ForeColor = SystemColors.ActiveCaptionText
        Button2.Location = New Point(296, 207)
        Button2.Name = "Button2"
        Button2.Size = New Size(107, 44)
        Button2.TabIndex = 8
        Button2.Text = "Reset"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.ForeColor = Color.DarkSlateGray
        Label4.Location = New Point(447, 9)
        Label4.Name = "Label4"
        Label4.Size = New Size(23, 26)
        Label4.TabIndex = 9
        Label4.Text = "X"
        ' 
        ' Login
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Beige
        ClientSize = New Size(482, 278)
        Controls.Add(Label4)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(PassTb)
        Controls.Add(UidTb)
        Controls.Add(PictureBox1)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.None
        Name = "Login"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Login"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents UidTb As TextBox
    Friend WithEvents PassTb As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label4 As Label
End Class
