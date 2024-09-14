<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblHomeTown = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtHomeTown = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.lblDepartment = New System.Windows.Forms.Label()
        Me.cmbDepartment = New System.Windows.Forms.ComboBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Mongolian Baiti", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.Location = New System.Drawing.Point(85, 41)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(50, 16)
        Me.lblName.TabIndex = 0
        Me.lblName.Text = "Name"
        '
        'lblHomeTown
        '
        Me.lblHomeTown.AutoSize = True
        Me.lblHomeTown.Font = New System.Drawing.Font("Mongolian Baiti", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHomeTown.Location = New System.Drawing.Point(356, 41)
        Me.lblHomeTown.Name = "lblHomeTown"
        Me.lblHomeTown.Size = New System.Drawing.Size(98, 16)
        Me.lblHomeTown.TabIndex = 1
        Me.lblHomeTown.Text = "Home Town"
        '
        'txtName
        '
        Me.txtName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.Location = New System.Drawing.Point(29, 77)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(197, 26)
        Me.txtName.TabIndex = 3
        '
        'txtHomeTown
        '
        Me.txtHomeTown.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHomeTown.Location = New System.Drawing.Point(322, 77)
        Me.txtHomeTown.Name = "txtHomeTown"
        Me.txtHomeTown.Size = New System.Drawing.Size(190, 26)
        Me.txtHomeTown.TabIndex = 4
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(1, 163)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(798, 257)
        Me.DataGridView1.TabIndex = 6
        '
        'lblDepartment
        '
        Me.lblDepartment.AutoSize = True
        Me.lblDepartment.Font = New System.Drawing.Font("Mongolian Baiti", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDepartment.Location = New System.Drawing.Point(641, 41)
        Me.lblDepartment.Name = "lblDepartment"
        Me.lblDepartment.Size = New System.Drawing.Size(92, 16)
        Me.lblDepartment.TabIndex = 7
        Me.lblDepartment.Text = "Department"
        '
        'cmbDepartment
        '
        Me.cmbDepartment.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbDepartment.FormattingEnabled = True
        Me.cmbDepartment.Items.AddRange(New Object() {"Marketing", "Ushering", "IT", "Operations"})
        Me.cmbDepartment.Location = New System.Drawing.Point(593, 75)
        Me.cmbDepartment.Name = "cmbDepartment"
        Me.cmbDepartment.Size = New System.Drawing.Size(178, 28)
        Me.cmbDepartment.TabIndex = 8
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.cmbDepartment)
        Me.Controls.Add(Me.lblDepartment)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.txtHomeTown)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.lblHomeTown)
        Me.Controls.Add(Me.lblName)
        Me.Name = "Form2"
        Me.Text = "Form2"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblName As Label
    Friend WithEvents lblHomeTown As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtHomeTown As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents lblDepartment As Label
    Friend WithEvents cmbDepartment As ComboBox
End Class
