<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Employee
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Employee))
        Panel1 = New Panel()
        EmployeeDGV = New DataGridView()
        Button4 = New Button()
        Button3 = New Button()
        Button2 = New Button()
        Button1 = New Button()
        EmpDOB = New DateTimePicker()
        EmpPhoneTb = New TextBox()
        Label9 = New Label()
        Label7 = New Label()
        EmpEdCb = New ComboBox()
        Label5 = New Label()
        GendCb = New ComboBox()
        Label4 = New Label()
        EmpPos = New ComboBox()
        Label3 = New Label()
        Label1 = New Label()
        EmpAdd = New TextBox()
        Label2 = New Label()
        EmpName = New TextBox()
        PictureBox6 = New PictureBox()
        Label8 = New Label()
        PictureBox1 = New PictureBox()
        Label6 = New Label()
        Label10 = New Label()
        Panel1.SuspendLayout()
        CType(EmployeeDGV, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox6, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Beige
        Panel1.Controls.Add(EmployeeDGV)
        Panel1.Controls.Add(Button4)
        Panel1.Controls.Add(Button3)
        Panel1.Controls.Add(Button2)
        Panel1.Controls.Add(Button1)
        Panel1.Controls.Add(EmpDOB)
        Panel1.Controls.Add(EmpPhoneTb)
        Panel1.Controls.Add(Label9)
        Panel1.Controls.Add(Label7)
        Panel1.Controls.Add(EmpEdCb)
        Panel1.Controls.Add(Label5)
        Panel1.Controls.Add(GendCb)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(EmpPos)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(EmpAdd)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(EmpName)
        Panel1.Location = New Point(2, 58)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(917, 458)
        Panel1.TabIndex = 0
        ' 
        ' EmployeeDGV
        ' 
        EmployeeDGV.BackgroundColor = Color.FromArgb(CByte(255), CByte(255), CByte(192))
        EmployeeDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        EmployeeDGV.GridColor = Color.FromArgb(CByte(255), CByte(255), CByte(192))
        EmployeeDGV.Location = New Point(475, 38)
        EmployeeDGV.Name = "EmployeeDGV"
        EmployeeDGV.RowHeadersWidth = 51
        EmployeeDGV.RowTemplate.Height = 29
        EmployeeDGV.Size = New Size(422, 407)
        EmployeeDGV.TabIndex = 26
        ' 
        ' Button4
        ' 
        Button4.BackColor = Color.FromArgb(CByte(0), CByte(64), CByte(0))
        Button4.Font = New Font("Sitka Banner Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Button4.ForeColor = SystemColors.ButtonHighlight
        Button4.Location = New Point(135, 408)
        Button4.Name = "Button4"
        Button4.Size = New Size(201, 37)
        Button4.TabIndex = 25
        Button4.Text = "Home"
        Button4.UseVisualStyleBackColor = False
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.MidnightBlue
        Button3.Font = New Font("Sitka Banner Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Button3.ForeColor = SystemColors.ButtonHighlight
        Button3.Location = New Point(191, 351)
        Button3.Name = "Button3"
        Button3.Size = New Size(107, 37)
        Button3.TabIndex = 24
        Button3.Text = "Edit"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.FromArgb(CByte(192), CByte(0), CByte(0))
        Button2.Font = New Font("Sitka Banner Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Button2.ForeColor = SystemColors.ButtonHighlight
        Button2.Location = New Point(334, 351)
        Button2.Name = "Button2"
        Button2.Size = New Size(107, 37)
        Button2.TabIndex = 23
        Button2.Text = "Delete"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.DarkOliveGreen
        Button1.Font = New Font("Sitka Banner Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Button1.ForeColor = SystemColors.ButtonHighlight
        Button1.Location = New Point(37, 351)
        Button1.Name = "Button1"
        Button1.Size = New Size(107, 37)
        Button1.TabIndex = 22
        Button1.Text = "Add"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' EmpDOB
        ' 
        EmpDOB.CalendarFont = New Font("Sitka Heading", 10.8F, FontStyle.Italic, GraphicsUnit.Point)
        EmpDOB.CalendarMonthBackground = Color.Beige
        EmpDOB.Font = New Font("Sitka Heading", 10.1999989F, FontStyle.Italic, GraphicsUnit.Point)
        EmpDOB.Location = New Point(135, 296)
        EmpDOB.Name = "EmpDOB"
        EmpDOB.Size = New Size(250, 29)
        EmpDOB.TabIndex = 21
        ' 
        ' EmpPhoneTb
        ' 
        EmpPhoneTb.BackColor = Color.Beige
        EmpPhoneTb.Font = New Font("Sitka Banner Semibold", 9F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        EmpPhoneTb.Location = New Point(37, 216)
        EmpPhoneTb.Name = "EmpPhoneTb"
        EmpPhoneTb.Size = New Size(184, 26)
        EmpPhoneTb.TabIndex = 20
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label9.ForeColor = Color.DarkCyan
        Label9.Location = New Point(37, 185)
        Label9.Name = "Label9"
        Label9.Size = New Size(160, 26)
        Label9.TabIndex = 19
        Label9.Text = "Employee Phone"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label7.ForeColor = Color.DarkCyan
        Label7.Location = New Point(257, 185)
        Label7.Name = "Label7"
        Label7.Size = New Size(196, 26)
        Label7.TabIndex = 17
        Label7.Text = "Employee Education"
        ' 
        ' EmpEdCb
        ' 
        EmpEdCb.BackColor = Color.Beige
        EmpEdCb.FormattingEnabled = True
        EmpEdCb.Items.AddRange(New Object() {"Post Graduate ", "Master ", "Bachelor/Hon Degre ", "Diploma", "ACCA", "Chartert ", "CA", "Advance Level", "Ordinary Level"})
        EmpEdCb.Location = New Point(257, 214)
        EmpEdCb.Name = "EmpEdCb"
        EmpEdCb.Size = New Size(184, 28)
        EmpEdCb.TabIndex = 16
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label5.ForeColor = Color.DarkCyan
        Label5.Location = New Point(37, 111)
        Label5.Name = "Label5"
        Label5.Size = New Size(172, 26)
        Label5.TabIndex = 15
        Label5.Text = "Employee Gender"
        ' 
        ' GendCb
        ' 
        GendCb.BackColor = Color.Beige
        GendCb.FormattingEnabled = True
        GendCb.Items.AddRange(New Object() {"Male", "Female"})
        GendCb.Location = New Point(37, 140)
        GendCb.Name = "GendCb"
        GendCb.Size = New Size(184, 28)
        GendCb.TabIndex = 14
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.ForeColor = Color.DarkCyan
        Label4.Location = New Point(257, 111)
        Label4.Name = "Label4"
        Label4.Size = New Size(177, 26)
        Label4.TabIndex = 13
        Label4.Text = "Employee Position"
        ' 
        ' EmpPos
        ' 
        EmpPos.BackColor = Color.Beige
        EmpPos.FormattingEnabled = True
        EmpPos.Items.AddRange(New Object() {"Directors", "HR Manager", "Accontant", "Admin Manager ", "Marketting Manager", "Marketting Officer", "Accounting Officer", "Store Keeper", "Transport Manager", "Transport Officer", "Addministration Officer", "Internship Student", "Driver", "Cleanind Service Staff", "Security Officer", "Security Helper"})
        EmpPos.Location = New Point(257, 140)
        EmpPos.Name = "EmpPos"
        EmpPos.Size = New Size(184, 28)
        EmpPos.TabIndex = 12
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.ForeColor = Color.DarkCyan
        Label3.Location = New Point(163, 257)
        Label3.Name = "Label3"
        Label3.Size = New Size(191, 26)
        Label3.TabIndex = 11
        Label3.Text = "Employee Birthdate"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.ForeColor = Color.DarkCyan
        Label1.Location = New Point(257, 38)
        Label1.Name = "Label1"
        Label1.Size = New Size(174, 26)
        Label1.TabIndex = 9
        Label1.Text = "Employee Address"
        ' 
        ' EmpAdd
        ' 
        EmpAdd.BackColor = Color.Beige
        EmpAdd.Font = New Font("Sitka Banner Semibold", 9F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        EmpAdd.Location = New Point(257, 67)
        EmpAdd.Name = "EmpAdd"
        EmpAdd.Size = New Size(184, 26)
        EmpAdd.TabIndex = 8
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.ForeColor = Color.DarkCyan
        Label2.Location = New Point(37, 35)
        Label2.Name = "Label2"
        Label2.Size = New Size(158, 26)
        Label2.TabIndex = 7
        Label2.Text = "Employee Name"
        ' 
        ' EmpName
        ' 
        EmpName.BackColor = Color.Beige
        EmpName.Font = New Font("Sitka Banner Semibold", 9F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        EmpName.Location = New Point(37, 64)
        EmpName.Name = "EmpName"
        EmpName.Size = New Size(184, 26)
        EmpName.TabIndex = 6
        ' 
        ' PictureBox6
        ' 
        PictureBox6.Image = CType(resources.GetObject("PictureBox6.Image"), Image)
        PictureBox6.Location = New Point(781, 523)
        PictureBox6.Name = "PictureBox6"
        PictureBox6.Size = New Size(20, 22)
        PictureBox6.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox6.TabIndex = 13
        PictureBox6.TabStop = False
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Trebuchet MS", 7.8F, FontStyle.Regular, GraphicsUnit.Point)
        Label8.ForeColor = Color.Transparent
        Label8.Location = New Point(805, 527)
        Label8.Name = "Label8"
        Label8.Size = New Size(102, 18)
        Label8.TabIndex = 12
        Label8.Text = "HR Department "
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(21, 8)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(40, 44)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 14
        PictureBox1.TabStop = False
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Tekton Pro", 13.7999992F, FontStyle.Bold, GraphicsUnit.Point)
        Label6.ForeColor = Color.Transparent
        Label6.Location = New Point(82, 24)
        Label6.Name = "Label6"
        Label6.Size = New Size(183, 28)
        Label6.TabIndex = 16
        Label6.Text = "Manage Employee "
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label10.ForeColor = Color.Honeydew
        Label10.Location = New Point(884, 9)
        Label10.Name = "Label10"
        Label10.Size = New Size(23, 26)
        Label10.TabIndex = 17
        Label10.Text = "X"
        ' 
        ' Employee
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(0), CByte(64), CByte(0))
        ClientSize = New Size(919, 551)
        ControlBox = False
        Controls.Add(Label10)
        Controls.Add(Label6)
        Controls.Add(PictureBox1)
        Controls.Add(PictureBox6)
        Controls.Add(Label8)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "Employee"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Employee"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(EmployeeDGV, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox6, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents Label8 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label6 As Label
    Friend WithEvents EmpName As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents EmpAdd As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents EmpPos As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents EmpEdCb As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents GendCb As ComboBox
    Friend WithEvents EmpPhoneTb As TextBox
    Friend WithEvents EmpDOB As DateTimePicker
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents EmployeeDGV As DataGridView
    Friend WithEvents Label10 As Label
End Class
