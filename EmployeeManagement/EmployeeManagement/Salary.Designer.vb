<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Salary
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Salary))
        Panel1 = New Panel()
        SalaryTb = New RichTextBox()
        Button3 = New Button()
        WorkingTb = New TextBox()
        EmpPoslbl = New Label()
        EmpNamelbl = New Label()
        Button2 = New Button()
        EmpId = New TextBox()
        Label9 = New Label()
        Button4 = New Button()
        Button1 = New Button()
        Label5 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label6 = New Label()
        PictureBox1 = New PictureBox()
        PictureBox6 = New PictureBox()
        Label1 = New Label()
        PrintDocument1 = New Printing.PrintDocument()
        PrintPreviewDialog1 = New PrintPreviewDialog()
        Label4 = New Label()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox6, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Cornsilk
        Panel1.Controls.Add(SalaryTb)
        Panel1.Controls.Add(Button3)
        Panel1.Controls.Add(WorkingTb)
        Panel1.Controls.Add(EmpPoslbl)
        Panel1.Controls.Add(EmpNamelbl)
        Panel1.Controls.Add(Button2)
        Panel1.Controls.Add(EmpId)
        Panel1.Controls.Add(Label9)
        Panel1.Controls.Add(Button4)
        Panel1.Controls.Add(Button1)
        Panel1.Controls.Add(Label5)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(Label2)
        Panel1.Location = New Point(-1, 54)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(886, 430)
        Panel1.TabIndex = 2
        ' 
        ' SalaryTb
        ' 
        SalaryTb.Font = New Font("Tekton Pro", 12F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        SalaryTb.Location = New Point(396, 42)
        SalaryTb.Name = "SalaryTb"
        SalaryTb.Size = New Size(461, 323)
        SalaryTb.TabIndex = 36
        SalaryTb.Text = ""
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.Teal
        Button3.FlatStyle = FlatStyle.Flat
        Button3.Font = New Font("Sitka Display", 10.1999989F, FontStyle.Bold, GraphicsUnit.Point)
        Button3.ForeColor = Color.Azure
        Button3.Location = New Point(602, 375)
        Button3.Name = "Button3"
        Button3.Size = New Size(102, 35)
        Button3.TabIndex = 35
        Button3.Text = "Print"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' WorkingTb
        ' 
        WorkingTb.BackColor = Color.Beige
        WorkingTb.Font = New Font("Sitka Banner Semibold", 9F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        WorkingTb.Location = New Point(54, 284)
        WorkingTb.Name = "WorkingTb"
        WorkingTb.Size = New Size(152, 26)
        WorkingTb.TabIndex = 34
        ' 
        ' EmpPoslbl
        ' 
        EmpPoslbl.AutoSize = True
        EmpPoslbl.Font = New Font("Trebuchet MS", 10.2F, FontStyle.Italic, GraphicsUnit.Point)
        EmpPoslbl.ForeColor = Color.FromArgb(CByte(192), CByte(0), CByte(0))
        EmpPoslbl.Location = New Point(54, 220)
        EmpPoslbl.Name = "EmpPoslbl"
        EmpPoslbl.Size = New Size(0, 23)
        EmpPoslbl.TabIndex = 32
        ' 
        ' EmpNamelbl
        ' 
        EmpNamelbl.AutoSize = True
        EmpNamelbl.Font = New Font("Trebuchet MS", 10.2F, FontStyle.Italic, GraphicsUnit.Point)
        EmpNamelbl.ForeColor = Color.FromArgb(CByte(192), CByte(0), CByte(0))
        EmpNamelbl.Location = New Point(54, 151)
        EmpNamelbl.Name = "EmpNamelbl"
        EmpNamelbl.Size = New Size(0, 23)
        EmpNamelbl.TabIndex = 27
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.FromArgb(CByte(0), CByte(0), CByte(192))
        Button2.FlatStyle = FlatStyle.Flat
        Button2.Font = New Font("Sitka Display", 10.1999989F, FontStyle.Bold, GraphicsUnit.Point)
        Button2.ForeColor = Color.Azure
        Button2.Location = New Point(256, 70)
        Button2.Name = "Button2"
        Button2.Size = New Size(102, 35)
        Button2.TabIndex = 26
        Button2.Text = "Fatch Data"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' EmpId
        ' 
        EmpId.BackColor = Color.Beige
        EmpId.Font = New Font("Sitka Banner Semibold", 9F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        EmpId.Location = New Point(54, 70)
        EmpId.Name = "EmpId"
        EmpId.Size = New Size(184, 26)
        EmpId.TabIndex = 25
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Trebuchet MS", 10.2F, FontStyle.Italic, GraphicsUnit.Point)
        Label9.ForeColor = Color.DarkCyan
        Label9.Location = New Point(54, 42)
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
        Button4.Location = New Point(198, 330)
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
        Button1.Location = New Point(54, 330)
        Button1.Name = "Button1"
        Button1.Size = New Size(102, 35)
        Button1.TabIndex = 20
        Button1.Text = "View"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Trebuchet MS", 10.2F, FontStyle.Italic, GraphicsUnit.Point)
        Label5.ForeColor = Color.DarkCyan
        Label5.Location = New Point(54, 188)
        Label5.Name = "Label5"
        Label5.Size = New Size(152, 23)
        Label5.TabIndex = 15
        Label5.Text = "Employee Position "
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Trebuchet MS", 10.2F, FontStyle.Italic, GraphicsUnit.Point)
        Label3.ForeColor = Color.DarkCyan
        Label3.Location = New Point(54, 258)
        Label3.Name = "Label3"
        Label3.Size = New Size(90, 23)
        Label3.TabIndex = 11
        Label3.Text = "Work Days"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Trebuchet MS", 10.2F, FontStyle.Italic, GraphicsUnit.Point)
        Label2.ForeColor = Color.DarkCyan
        Label2.Location = New Point(54, 121)
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
        Label6.Location = New Point(53, 19)
        Label6.Name = "Label6"
        Label6.Size = New Size(74, 28)
        Label6.TabIndex = 18
        Label6.Text = "Salary"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(7, 3)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(40, 44)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 17
        PictureBox1.TabStop = False
        ' 
        ' PictureBox6
        ' 
        PictureBox6.Image = CType(resources.GetObject("PictureBox6.Image"), Image)
        PictureBox6.Location = New Point(749, 495)
        PictureBox6.Name = "PictureBox6"
        PictureBox6.Size = New Size(20, 22)
        PictureBox6.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox6.TabIndex = 20
        PictureBox6.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Trebuchet MS", 7.8F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.ForeColor = Color.Transparent
        Label1.Location = New Point(773, 499)
        Label1.Name = "Label1"
        Label1.Size = New Size(102, 18)
        Label1.TabIndex = 19
        Label1.Text = "HR Department "
        ' 
        ' PrintPreviewDialog1
        ' 
        PrintPreviewDialog1.AutoScrollMargin = New Size(0, 0)
        PrintPreviewDialog1.AutoScrollMinSize = New Size(0, 0)
        PrintPreviewDialog1.ClientSize = New Size(400, 300)
        PrintPreviewDialog1.Document = PrintDocument1
        PrintPreviewDialog1.Enabled = True
        PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), Icon)
        PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        PrintPreviewDialog1.Visible = False
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Trebuchet MS", 10.2F, FontStyle.Italic, GraphicsUnit.Point)
        Label4.ForeColor = Color.MintCream
        Label4.Location = New Point(856, 23)
        Label4.Name = "Label4"
        Label4.Size = New Size(19, 23)
        Label4.TabIndex = 21
        Label4.Text = "X"
        ' 
        ' Salary
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(0), CByte(64), CByte(0))
        ClientSize = New Size(886, 521)
        Controls.Add(Label4)
        Controls.Add(PictureBox6)
        Controls.Add(Label1)
        Controls.Add(Label6)
        Controls.Add(PictureBox1)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "Salary"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Salary"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox6, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents EmpPoslbl As Label
    Friend WithEvents EmpNamelbl As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents EmpId As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Button4 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button3 As Button
    Friend WithEvents WorkingTb As TextBox
    Friend WithEvents SalaryTb As RichTextBox
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents Label4 As Label
End Class
