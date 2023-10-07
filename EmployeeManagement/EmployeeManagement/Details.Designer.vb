<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Details
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Details))
        Panel1 = New Panel()
        EmpEdulbl = New Label()
        EmpPoslbl = New Label()
        EmpAdd = New Label()
        EmpDOBlbl = New Label()
        EmpGender = New Label()
        EmpPhone = New Label()
        EmpNamelbl = New Label()
        Button2 = New Button()
        EmpId = New TextBox()
        Label9 = New Label()
        Button4 = New Button()
        Button1 = New Button()
        Label8 = New Label()
        Label7 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label1 = New Label()
        Label2 = New Label()
        Label6 = New Label()
        PictureBox1 = New PictureBox()
        PictureBox6 = New PictureBox()
        Label17 = New Label()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox6, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Cornsilk
        Panel1.Controls.Add(EmpEdulbl)
        Panel1.Controls.Add(EmpPoslbl)
        Panel1.Controls.Add(EmpAdd)
        Panel1.Controls.Add(EmpDOBlbl)
        Panel1.Controls.Add(EmpGender)
        Panel1.Controls.Add(EmpPhone)
        Panel1.Controls.Add(EmpNamelbl)
        Panel1.Controls.Add(Button2)
        Panel1.Controls.Add(EmpId)
        Panel1.Controls.Add(Label9)
        Panel1.Controls.Add(Button4)
        Panel1.Controls.Add(Button1)
        Panel1.Controls.Add(Label8)
        Panel1.Controls.Add(Label7)
        Panel1.Controls.Add(Label5)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(Label2)
        Panel1.Location = New Point(0, 47)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(863, 422)
        Panel1.TabIndex = 1
        ' 
        ' EmpEdulbl
        ' 
        EmpEdulbl.AutoSize = True
        EmpEdulbl.Font = New Font("Trebuchet MS", 10.2F, FontStyle.Italic, GraphicsUnit.Point)
        EmpEdulbl.ForeColor = Color.FromArgb(CByte(192), CByte(0), CByte(0))
        EmpEdulbl.Location = New Point(648, 227)
        EmpEdulbl.Name = "EmpEdulbl"
        EmpEdulbl.Size = New Size(167, 23)
        EmpEdulbl.TabIndex = 33
        EmpEdulbl.Text = "Employee Education "
        EmpEdulbl.Visible = False
        ' 
        ' EmpPoslbl
        ' 
        EmpPoslbl.AutoSize = True
        EmpPoslbl.Font = New Font("Trebuchet MS", 10.2F, FontStyle.Italic, GraphicsUnit.Point)
        EmpPoslbl.ForeColor = Color.FromArgb(CByte(192), CByte(0), CByte(0))
        EmpPoslbl.Location = New Point(648, 174)
        EmpPoslbl.Name = "EmpPoslbl"
        EmpPoslbl.Size = New Size(152, 23)
        EmpPoslbl.TabIndex = 32
        EmpPoslbl.Text = "Employee Position "
        EmpPoslbl.Visible = False
        ' 
        ' EmpAdd
        ' 
        EmpAdd.AutoSize = True
        EmpAdd.Font = New Font("Trebuchet MS", 10.2F, FontStyle.Italic, GraphicsUnit.Point)
        EmpAdd.ForeColor = Color.FromArgb(CByte(192), CByte(0), CByte(0))
        EmpAdd.Location = New Point(648, 126)
        EmpAdd.Name = "EmpAdd"
        EmpAdd.Size = New Size(144, 23)
        EmpAdd.TabIndex = 31
        EmpAdd.Text = "Employee Address"
        EmpAdd.Visible = False
        ' 
        ' EmpDOBlbl
        ' 
        EmpDOBlbl.AutoSize = True
        EmpDOBlbl.Font = New Font("Trebuchet MS", 10.2F, FontStyle.Italic, GraphicsUnit.Point)
        EmpDOBlbl.ForeColor = Color.FromArgb(CByte(192), CByte(0), CByte(0))
        EmpDOBlbl.Location = New Point(433, 277)
        EmpDOBlbl.Name = "EmpDOBlbl"
        EmpDOBlbl.Size = New Size(157, 23)
        EmpDOBlbl.TabIndex = 30
        EmpDOBlbl.Text = "Employee Birthday "
        EmpDOBlbl.Visible = False
        ' 
        ' EmpGender
        ' 
        EmpGender.AutoSize = True
        EmpGender.Font = New Font("Trebuchet MS", 10.2F, FontStyle.Italic, GraphicsUnit.Point)
        EmpGender.ForeColor = Color.FromArgb(CByte(192), CByte(0), CByte(0))
        EmpGender.Location = New Point(228, 174)
        EmpGender.Name = "EmpGender"
        EmpGender.Size = New Size(142, 23)
        EmpGender.TabIndex = 29
        EmpGender.Text = "Employee Gender"
        EmpGender.Visible = False
        ' 
        ' EmpPhone
        ' 
        EmpPhone.AutoSize = True
        EmpPhone.Font = New Font("Trebuchet MS", 10.2F, FontStyle.Italic, GraphicsUnit.Point)
        EmpPhone.ForeColor = Color.FromArgb(CByte(192), CByte(0), CByte(0))
        EmpPhone.Location = New Point(228, 227)
        EmpPhone.Name = "EmpPhone"
        EmpPhone.Size = New Size(132, 23)
        EmpPhone.TabIndex = 28
        EmpPhone.Text = "Employee Phone"
        EmpPhone.Visible = False
        ' 
        ' EmpNamelbl
        ' 
        EmpNamelbl.AutoSize = True
        EmpNamelbl.Font = New Font("Trebuchet MS", 10.2F, FontStyle.Italic, GraphicsUnit.Point)
        EmpNamelbl.ForeColor = Color.FromArgb(CByte(192), CByte(0), CByte(0))
        EmpNamelbl.Location = New Point(228, 126)
        EmpNamelbl.Name = "EmpNamelbl"
        EmpNamelbl.Size = New Size(131, 23)
        EmpNamelbl.TabIndex = 27
        EmpNamelbl.Text = "Employee Name"
        EmpNamelbl.Visible = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.FromArgb(CByte(64), CByte(0), CByte(0))
        Button2.FlatStyle = FlatStyle.Flat
        Button2.Font = New Font("Sitka Display", 10.1999989F, FontStyle.Bold, GraphicsUnit.Point)
        Button2.ForeColor = Color.Azure
        Button2.Location = New Point(557, 43)
        Button2.Name = "Button2"
        Button2.Size = New Size(102, 35)
        Button2.TabIndex = 26
        Button2.Text = "Fetch Data"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' EmpId
        ' 
        EmpId.BackColor = Color.Beige
        EmpId.Font = New Font("Sitka Banner Semibold", 9F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        EmpId.Location = New Point(356, 47)
        EmpId.Name = "EmpId"
        EmpId.Size = New Size(184, 26)
        EmpId.TabIndex = 25
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Trebuchet MS", 10.2F, FontStyle.Italic, GraphicsUnit.Point)
        Label9.ForeColor = Color.DarkCyan
        Label9.Location = New Point(238, 50)
        Label9.Name = "Label9"
        Label9.Size = New Size(102, 23)
        Label9.TabIndex = 24
        Label9.Text = "Employee ID"
        ' 
        ' Button4
        ' 
        Button4.BackColor = Color.FromArgb(CByte(0), CByte(64), CByte(0))
        Button4.FlatStyle = FlatStyle.Flat
        Button4.Font = New Font("Sitka Display", 10.1999989F, FontStyle.Bold, GraphicsUnit.Point)
        Button4.ForeColor = Color.Azure
        Button4.Location = New Point(456, 354)
        Button4.Name = "Button4"
        Button4.Size = New Size(103, 35)
        Button4.TabIndex = 23
        Button4.Text = "Home"
        Button4.UseVisualStyleBackColor = False
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Teal
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Sitka Display", 10.1999989F, FontStyle.Bold, GraphicsUnit.Point)
        Button1.ForeColor = Color.Azure
        Button1.Location = New Point(291, 354)
        Button1.Name = "Button1"
        Button1.Size = New Size(102, 35)
        Button1.TabIndex = 20
        Button1.Text = "Print"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Trebuchet MS", 10.2F, FontStyle.Italic, GraphicsUnit.Point)
        Label8.ForeColor = Color.DarkCyan
        Label8.Location = New Point(279, 277)
        Label8.Name = "Label8"
        Label8.Size = New Size(157, 23)
        Label8.TabIndex = 18
        Label8.Text = "Employee Birthday "
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Trebuchet MS", 10.2F, FontStyle.Italic, GraphicsUnit.Point)
        Label7.ForeColor = Color.DarkCyan
        Label7.Location = New Point(483, 227)
        Label7.Name = "Label7"
        Label7.Size = New Size(167, 23)
        Label7.TabIndex = 17
        Label7.Text = "Employee Education "
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Trebuchet MS", 10.2F, FontStyle.Italic, GraphicsUnit.Point)
        Label5.ForeColor = Color.DarkCyan
        Label5.Location = New Point(483, 174)
        Label5.Name = "Label5"
        Label5.Size = New Size(152, 23)
        Label5.TabIndex = 15
        Label5.Text = "Employee Position "
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Trebuchet MS", 10.2F, FontStyle.Italic, GraphicsUnit.Point)
        Label4.ForeColor = Color.DarkCyan
        Label4.Location = New Point(74, 174)
        Label4.Name = "Label4"
        Label4.Size = New Size(142, 23)
        Label4.TabIndex = 13
        Label4.Text = "Employee Gender"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Trebuchet MS", 10.2F, FontStyle.Italic, GraphicsUnit.Point)
        Label3.ForeColor = Color.DarkCyan
        Label3.Location = New Point(74, 227)
        Label3.Name = "Label3"
        Label3.Size = New Size(132, 23)
        Label3.TabIndex = 11
        Label3.Text = "Employee Phone"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Trebuchet MS", 10.2F, FontStyle.Italic, GraphicsUnit.Point)
        Label1.ForeColor = Color.DarkCyan
        Label1.Location = New Point(483, 126)
        Label1.Name = "Label1"
        Label1.Size = New Size(144, 23)
        Label1.TabIndex = 9
        Label1.Text = "Employee Address"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Trebuchet MS", 10.2F, FontStyle.Italic, GraphicsUnit.Point)
        Label2.ForeColor = Color.DarkCyan
        Label2.Location = New Point(74, 126)
        Label2.Name = "Label2"
        Label2.Size = New Size(131, 23)
        Label2.TabIndex = 7
        Label2.Text = "Employee Name"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Tekton Pro", 13.7999992F, FontStyle.Bold, GraphicsUnit.Point)
        Label6.ForeColor = Color.MintCream
        Label6.Location = New Point(59, 18)
        Label6.Name = "Label6"
        Label6.Size = New Size(179, 28)
        Label6.TabIndex = 18
        Label6.Text = "Employee Details "
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(13, 2)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(40, 44)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 17
        PictureBox1.TabStop = False
        ' 
        ' PictureBox6
        ' 
        PictureBox6.Image = CType(resources.GetObject("PictureBox6.Image"), Image)
        PictureBox6.Location = New Point(726, 483)
        PictureBox6.Name = "PictureBox6"
        PictureBox6.Size = New Size(20, 22)
        PictureBox6.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox6.TabIndex = 20
        PictureBox6.TabStop = False
        ' 
        ' Label17
        ' 
        Label17.AutoSize = True
        Label17.Font = New Font("Trebuchet MS", 7.8F, FontStyle.Regular, GraphicsUnit.Point)
        Label17.ForeColor = Color.Transparent
        Label17.Location = New Point(750, 487)
        Label17.Name = "Label17"
        Label17.Size = New Size(102, 18)
        Label17.TabIndex = 19
        Label17.Text = "HR Department "
        ' 
        ' Details
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(0), CByte(64), CByte(0))
        ClientSize = New Size(864, 516)
        Controls.Add(PictureBox6)
        Controls.Add(Label17)
        Controls.Add(Label6)
        Controls.Add(PictureBox1)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "Details"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Details"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox6, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button4 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label9 As Label
    Friend WithEvents EmpEdulbl As Label
    Friend WithEvents EmpPoslbl As Label
    Friend WithEvents EmpAdd As Label
    Friend WithEvents EmpDOBlbl As Label
    Friend WithEvents EmpGender As Label
    Friend WithEvents EmpPhone As Label
    Friend WithEvents EmpNamelbl As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents EmpId As TextBox
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents Label17 As Label
End Class
