<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmShirtMakerForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmShirtMakerForm))
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblRoom = New System.Windows.Forms.Label()
        Me.lblShirtType = New System.Windows.Forms.Label()
        Me.lblShirtSize = New System.Windows.Forms.Label()
        Me.lblPartyDate = New System.Windows.Forms.Label()
        Me.dtpPartyDate = New System.Windows.Forms.DateTimePicker()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtRoom = New System.Windows.Forms.TextBox()
        Me.cmbShirtType = New System.Windows.Forms.ComboBox()
        Me.cmbShirtSize = New System.Windows.Forms.ComboBox()
        Me.btnReset = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnSubmit
        '
        Me.btnSubmit.Location = New System.Drawing.Point(256, 298)
        Me.btnSubmit.Margin = New System.Windows.Forms.Padding(2)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(107, 40)
        Me.btnSubmit.TabIndex = 0
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(360, 85)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(15, 123)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(38, 13)
        Me.lblName.TabIndex = 2
        Me.lblName.Text = "Name:"
        '
        'lblRoom
        '
        Me.lblRoom.AutoSize = True
        Me.lblRoom.Location = New System.Drawing.Point(15, 153)
        Me.lblRoom.Name = "lblRoom"
        Me.lblRoom.Size = New System.Drawing.Size(45, 13)
        Me.lblRoom.TabIndex = 3
        Me.lblRoom.Text = "Room#:"
        '
        'lblShirtType
        '
        Me.lblShirtType.AutoSize = True
        Me.lblShirtType.Location = New System.Drawing.Point(15, 179)
        Me.lblShirtType.Name = "lblShirtType"
        Me.lblShirtType.Size = New System.Drawing.Size(58, 13)
        Me.lblShirtType.TabIndex = 4
        Me.lblShirtType.Text = "Shirt Type:"
        '
        'lblShirtSize
        '
        Me.lblShirtSize.AutoSize = True
        Me.lblShirtSize.Location = New System.Drawing.Point(15, 210)
        Me.lblShirtSize.Name = "lblShirtSize"
        Me.lblShirtSize.Size = New System.Drawing.Size(51, 13)
        Me.lblShirtSize.TabIndex = 5
        Me.lblShirtSize.Text = "Shirt Size"
        '
        'lblPartyDate
        '
        Me.lblPartyDate.AutoSize = True
        Me.lblPartyDate.Location = New System.Drawing.Point(15, 243)
        Me.lblPartyDate.Name = "lblPartyDate"
        Me.lblPartyDate.Size = New System.Drawing.Size(60, 13)
        Me.lblPartyDate.TabIndex = 6
        Me.lblPartyDate.Text = "Party Date:"
        '
        'dtpPartyDate
        '
        Me.dtpPartyDate.Location = New System.Drawing.Point(81, 237)
        Me.dtpPartyDate.Name = "dtpPartyDate"
        Me.dtpPartyDate.Size = New System.Drawing.Size(200, 20)
        Me.dtpPartyDate.TabIndex = 7
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(79, 120)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(200, 20)
        Me.txtName.TabIndex = 8
        '
        'txtRoom
        '
        Me.txtRoom.Location = New System.Drawing.Point(79, 150)
        Me.txtRoom.Name = "txtRoom"
        Me.txtRoom.Size = New System.Drawing.Size(200, 20)
        Me.txtRoom.TabIndex = 9
        '
        'cmbShirtType
        '
        Me.cmbShirtType.FormattingEnabled = True
        Me.cmbShirtType.Location = New System.Drawing.Point(79, 176)
        Me.cmbShirtType.Name = "cmbShirtType"
        Me.cmbShirtType.Size = New System.Drawing.Size(200, 21)
        Me.cmbShirtType.TabIndex = 10
        '
        'cmbShirtSize
        '
        Me.cmbShirtSize.FormattingEnabled = True
        Me.cmbShirtSize.Location = New System.Drawing.Point(81, 207)
        Me.cmbShirtSize.Name = "cmbShirtSize"
        Me.cmbShirtSize.Size = New System.Drawing.Size(200, 21)
        Me.cmbShirtSize.TabIndex = 11
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(18, 298)
        Me.btnReset.Margin = New System.Windows.Forms.Padding(2)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(107, 40)
        Me.btnReset.TabIndex = 12
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'frmShirtMakerForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(384, 363)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.cmbShirtSize)
        Me.Controls.Add(Me.cmbShirtType)
        Me.Controls.Add(Me.txtRoom)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.dtpPartyDate)
        Me.Controls.Add(Me.lblPartyDate)
        Me.Controls.Add(Me.lblShirtSize)
        Me.Controls.Add(Me.lblShirtType)
        Me.Controls.Add(Me.lblRoom)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnSubmit)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "frmShirtMakerForm"
        Me.Text = "Shirt Maker Form"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnSubmit As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblName As Label
    Friend WithEvents lblRoom As Label
    Friend WithEvents lblShirtType As Label
    Friend WithEvents lblShirtSize As Label
    Friend WithEvents lblPartyDate As Label
    Friend WithEvents dtpPartyDate As DateTimePicker
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtRoom As TextBox
    Friend WithEvents cmbShirtType As ComboBox
    Friend WithEvents cmbShirtSize As ComboBox
    Friend WithEvents btnReset As Button
End Class
