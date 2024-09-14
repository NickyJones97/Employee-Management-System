<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.lblEmpID = New System.Windows.Forms.Label()
        Me.lblFirstName = New System.Windows.Forms.Label()
        Me.lblDepartment = New System.Windows.Forms.Label()
        Me.lblGender = New System.Windows.Forms.Label()
        Me.lblDOB = New System.Windows.Forms.Label()
        Me.lblTel = New System.Windows.Forms.Label()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.lblCountry = New System.Windows.Forms.Label()
        Me.lblHomeTown = New System.Windows.Forms.Label()
        Me.lblHomeAddress = New System.Windows.Forms.Label()
        Me.lblSsnitNo = New System.Windows.Forms.Label()
        Me.lblLastName = New System.Windows.Forms.Label()
        Me.txtEmpID = New System.Windows.Forms.TextBox()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.txtTel = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtHomeTown = New System.Windows.Forms.TextBox()
        Me.txtHomeAddress = New System.Windows.Forms.TextBox()
        Me.txtSsnitNo = New System.Windows.Forms.TextBox()
        Me.cmbGender = New System.Windows.Forms.ComboBox()
        Me.dtpDateofbirth = New System.Windows.Forms.DateTimePicker()
        Me.cmbDepartment = New System.Windows.Forms.ComboBox()
        Me.btnNew = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnViewdata = New System.Windows.Forms.Button()
        Me.cmbCountry = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'lblEmpID
        '
        Me.lblEmpID.AutoSize = True
        Me.lblEmpID.Font = New System.Drawing.Font("Mongolian Baiti", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmpID.Location = New System.Drawing.Point(26, 49)
        Me.lblEmpID.Name = "lblEmpID"
        Me.lblEmpID.Size = New System.Drawing.Size(60, 16)
        Me.lblEmpID.TabIndex = 0
        Me.lblEmpID.Text = "EmpID"
        '
        'lblFirstName
        '
        Me.lblFirstName.AutoSize = True
        Me.lblFirstName.Font = New System.Drawing.Font("Mongolian Baiti", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFirstName.Location = New System.Drawing.Point(26, 86)
        Me.lblFirstName.Name = "lblFirstName"
        Me.lblFirstName.Size = New System.Drawing.Size(88, 16)
        Me.lblFirstName.TabIndex = 1
        Me.lblFirstName.Text = "First Name"
        '
        'lblDepartment
        '
        Me.lblDepartment.AutoSize = True
        Me.lblDepartment.Font = New System.Drawing.Font("Mongolian Baiti", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDepartment.Location = New System.Drawing.Point(435, 128)
        Me.lblDepartment.Name = "lblDepartment"
        Me.lblDepartment.Size = New System.Drawing.Size(92, 16)
        Me.lblDepartment.TabIndex = 2
        Me.lblDepartment.Text = "Department"
        '
        'lblGender
        '
        Me.lblGender.AutoSize = True
        Me.lblGender.Font = New System.Drawing.Font("Mongolian Baiti", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGender.Location = New System.Drawing.Point(26, 164)
        Me.lblGender.Name = "lblGender"
        Me.lblGender.Size = New System.Drawing.Size(61, 16)
        Me.lblGender.TabIndex = 3
        Me.lblGender.Text = "Gender"
        '
        'lblDOB
        '
        Me.lblDOB.AutoSize = True
        Me.lblDOB.Font = New System.Drawing.Font("Mongolian Baiti", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDOB.Location = New System.Drawing.Point(27, 201)
        Me.lblDOB.Name = "lblDOB"
        Me.lblDOB.Size = New System.Drawing.Size(46, 16)
        Me.lblDOB.TabIndex = 4
        Me.lblDOB.Text = "DOB"
        '
        'lblTel
        '
        Me.lblTel.AutoSize = True
        Me.lblTel.Font = New System.Drawing.Font("Mongolian Baiti", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTel.Location = New System.Drawing.Point(27, 242)
        Me.lblTel.Name = "lblTel"
        Me.lblTel.Size = New System.Drawing.Size(32, 16)
        Me.lblTel.TabIndex = 5
        Me.lblTel.Text = "Tel"
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Font = New System.Drawing.Font("Mongolian Baiti", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmail.Location = New System.Drawing.Point(27, 282)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(50, 16)
        Me.lblEmail.TabIndex = 6
        Me.lblEmail.Text = "Email"
        '
        'lblCountry
        '
        Me.lblCountry.AutoSize = True
        Me.lblCountry.Font = New System.Drawing.Font("Mongolian Baiti", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCountry.Location = New System.Drawing.Point(28, 320)
        Me.lblCountry.Name = "lblCountry"
        Me.lblCountry.Size = New System.Drawing.Size(67, 16)
        Me.lblCountry.TabIndex = 7
        Me.lblCountry.Text = "Country"
        '
        'lblHomeTown
        '
        Me.lblHomeTown.AutoSize = True
        Me.lblHomeTown.Font = New System.Drawing.Font("Mongolian Baiti", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHomeTown.Location = New System.Drawing.Point(18, 357)
        Me.lblHomeTown.Name = "lblHomeTown"
        Me.lblHomeTown.Size = New System.Drawing.Size(98, 16)
        Me.lblHomeTown.TabIndex = 8
        Me.lblHomeTown.Text = "Home Town"
        '
        'lblHomeAddress
        '
        Me.lblHomeAddress.AutoSize = True
        Me.lblHomeAddress.Font = New System.Drawing.Font("Mongolian Baiti", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHomeAddress.Location = New System.Drawing.Point(428, 45)
        Me.lblHomeAddress.Name = "lblHomeAddress"
        Me.lblHomeAddress.Size = New System.Drawing.Size(115, 16)
        Me.lblHomeAddress.TabIndex = 9
        Me.lblHomeAddress.Text = "Home Address"
        '
        'lblSsnitNo
        '
        Me.lblSsnitNo.AutoSize = True
        Me.lblSsnitNo.Font = New System.Drawing.Font("Mongolian Baiti", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSsnitNo.Location = New System.Drawing.Point(452, 83)
        Me.lblSsnitNo.Name = "lblSsnitNo"
        Me.lblSsnitNo.Size = New System.Drawing.Size(75, 16)
        Me.lblSsnitNo.TabIndex = 11
        Me.lblSsnitNo.Text = "Ssnit_No"
        '
        'lblLastName
        '
        Me.lblLastName.AutoSize = True
        Me.lblLastName.Font = New System.Drawing.Font("Mongolian Baiti", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLastName.Location = New System.Drawing.Point(26, 122)
        Me.lblLastName.Name = "lblLastName"
        Me.lblLastName.Size = New System.Drawing.Size(86, 16)
        Me.lblLastName.TabIndex = 12
        Me.lblLastName.Text = "Last Name"
        '
        'txtEmpID
        '
        Me.txtEmpID.Enabled = False
        Me.txtEmpID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmpID.Location = New System.Drawing.Point(153, 36)
        Me.txtEmpID.Name = "txtEmpID"
        Me.txtEmpID.Size = New System.Drawing.Size(219, 26)
        Me.txtEmpID.TabIndex = 13
        '
        'txtFirstName
        '
        Me.txtFirstName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFirstName.Location = New System.Drawing.Point(153, 73)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(219, 26)
        Me.txtFirstName.TabIndex = 14
        '
        'txtLastName
        '
        Me.txtLastName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLastName.Location = New System.Drawing.Point(153, 109)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(219, 26)
        Me.txtLastName.TabIndex = 15
        '
        'txtTel
        '
        Me.txtTel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTel.Location = New System.Drawing.Point(153, 229)
        Me.txtTel.Name = "txtTel"
        Me.txtTel.Size = New System.Drawing.Size(219, 26)
        Me.txtTel.TabIndex = 18
        '
        'txtEmail
        '
        Me.txtEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail.Location = New System.Drawing.Point(153, 269)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(219, 26)
        Me.txtEmail.TabIndex = 19
        '
        'txtHomeTown
        '
        Me.txtHomeTown.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHomeTown.Location = New System.Drawing.Point(153, 344)
        Me.txtHomeTown.Name = "txtHomeTown"
        Me.txtHomeTown.Size = New System.Drawing.Size(219, 26)
        Me.txtHomeTown.TabIndex = 21
        '
        'txtHomeAddress
        '
        Me.txtHomeAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHomeAddress.Location = New System.Drawing.Point(569, 32)
        Me.txtHomeAddress.Name = "txtHomeAddress"
        Me.txtHomeAddress.Size = New System.Drawing.Size(219, 26)
        Me.txtHomeAddress.TabIndex = 22
        '
        'txtSsnitNo
        '
        Me.txtSsnitNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSsnitNo.Location = New System.Drawing.Point(569, 76)
        Me.txtSsnitNo.Name = "txtSsnitNo"
        Me.txtSsnitNo.Size = New System.Drawing.Size(219, 26)
        Me.txtSsnitNo.TabIndex = 24
        '
        'cmbGender
        '
        Me.cmbGender.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbGender.FormattingEnabled = True
        Me.cmbGender.Items.AddRange(New Object() {"Male", "Female"})
        Me.cmbGender.Location = New System.Drawing.Point(153, 149)
        Me.cmbGender.Name = "cmbGender"
        Me.cmbGender.Size = New System.Drawing.Size(219, 28)
        Me.cmbGender.TabIndex = 26
        '
        'dtpDateofbirth
        '
        Me.dtpDateofbirth.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDateofbirth.Location = New System.Drawing.Point(153, 188)
        Me.dtpDateofbirth.Name = "dtpDateofbirth"
        Me.dtpDateofbirth.Size = New System.Drawing.Size(219, 26)
        Me.dtpDateofbirth.TabIndex = 27
        '
        'cmbDepartment
        '
        Me.cmbDepartment.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbDepartment.FormattingEnabled = True
        Me.cmbDepartment.Items.AddRange(New Object() {"Marketing", "Ushering", "IT", "Operations"})
        Me.cmbDepartment.Location = New System.Drawing.Point(569, 116)
        Me.cmbDepartment.Name = "cmbDepartment"
        Me.cmbDepartment.Size = New System.Drawing.Size(219, 28)
        Me.cmbDepartment.TabIndex = 28
        '
        'btnNew
        '
        Me.btnNew.BackColor = System.Drawing.Color.Red
        Me.btnNew.Font = New System.Drawing.Font("Mongolian Baiti", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNew.ForeColor = System.Drawing.Color.White
        Me.btnNew.Location = New System.Drawing.Point(431, 189)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(96, 63)
        Me.btnNew.TabIndex = 29
        Me.btnNew.Text = "New"
        Me.btnNew.UseVisualStyleBackColor = False
        '
        'btnEdit
        '
        Me.btnEdit.BackColor = System.Drawing.Color.Yellow
        Me.btnEdit.Font = New System.Drawing.Font("Mongolian Baiti", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEdit.Location = New System.Drawing.Point(544, 189)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(87, 63)
        Me.btnEdit.TabIndex = 30
        Me.btnEdit.Text = "Edit"
        Me.btnEdit.UseVisualStyleBackColor = False
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnSave.Font = New System.Drawing.Font("Mongolian Baiti", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(651, 189)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(90, 63)
        Me.btnSave.TabIndex = 31
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'btnUpdate
        '
        Me.btnUpdate.BackColor = System.Drawing.SystemColors.WindowText
        Me.btnUpdate.Font = New System.Drawing.Font("Mongolian Baiti", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.ForeColor = System.Drawing.Color.White
        Me.btnUpdate.Location = New System.Drawing.Point(431, 259)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(96, 63)
        Me.btnUpdate.TabIndex = 32
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = False
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnDelete.Font = New System.Drawing.Font("Mongolian Baiti", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.ForeColor = System.Drawing.Color.White
        Me.btnDelete.Location = New System.Drawing.Point(544, 258)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(87, 63)
        Me.btnDelete.TabIndex = 33
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'btnViewdata
        '
        Me.btnViewdata.BackColor = System.Drawing.Color.DarkMagenta
        Me.btnViewdata.Font = New System.Drawing.Font("Mongolian Baiti", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnViewdata.ForeColor = System.Drawing.Color.White
        Me.btnViewdata.Location = New System.Drawing.Point(651, 259)
        Me.btnViewdata.Name = "btnViewdata"
        Me.btnViewdata.Size = New System.Drawing.Size(90, 63)
        Me.btnViewdata.TabIndex = 34
        Me.btnViewdata.Text = "View Data"
        Me.btnViewdata.UseVisualStyleBackColor = False
        '
        'cmbCountry
        '
        Me.cmbCountry.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbCountry.FormattingEnabled = True
        Me.cmbCountry.Items.AddRange(New Object() {"Ghana", "Togo", "Nigeria", "Senegal", "Mali", "Benin", "Egypt", "Qatar"})
        Me.cmbCountry.Location = New System.Drawing.Point(153, 308)
        Me.cmbCountry.Name = "cmbCountry"
        Me.cmbCountry.Size = New System.Drawing.Size(219, 28)
        Me.cmbCountry.TabIndex = 35
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.cmbCountry)
        Me.Controls.Add(Me.btnViewdata)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.btnNew)
        Me.Controls.Add(Me.cmbDepartment)
        Me.Controls.Add(Me.dtpDateofbirth)
        Me.Controls.Add(Me.cmbGender)
        Me.Controls.Add(Me.txtSsnitNo)
        Me.Controls.Add(Me.txtHomeAddress)
        Me.Controls.Add(Me.txtHomeTown)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.txtTel)
        Me.Controls.Add(Me.txtLastName)
        Me.Controls.Add(Me.txtFirstName)
        Me.Controls.Add(Me.txtEmpID)
        Me.Controls.Add(Me.lblLastName)
        Me.Controls.Add(Me.lblSsnitNo)
        Me.Controls.Add(Me.lblHomeAddress)
        Me.Controls.Add(Me.lblHomeTown)
        Me.Controls.Add(Me.lblCountry)
        Me.Controls.Add(Me.lblEmail)
        Me.Controls.Add(Me.lblTel)
        Me.Controls.Add(Me.lblDOB)
        Me.Controls.Add(Me.lblGender)
        Me.Controls.Add(Me.lblDepartment)
        Me.Controls.Add(Me.lblFirstName)
        Me.Controls.Add(Me.lblEmpID)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblEmpID As Label
    Friend WithEvents lblFirstName As Label
    Friend WithEvents lblDepartment As Label
    Friend WithEvents lblGender As Label
    Friend WithEvents lblDOB As Label
    Friend WithEvents lblTel As Label
    Friend WithEvents lblEmail As Label
    Friend WithEvents lblCountry As Label
    Friend WithEvents lblHomeTown As Label
    Friend WithEvents lblHomeAddress As Label
    Friend WithEvents lblSsnitNo As Label
    Friend WithEvents lblLastName As Label
    Friend WithEvents txtEmpID As TextBox
    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents txtTel As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtHomeTown As TextBox
    Friend WithEvents txtHomeAddress As TextBox
    Friend WithEvents txtSsnitNo As TextBox
    Friend WithEvents cmbGender As ComboBox
    Friend WithEvents dtpDateofbirth As DateTimePicker
    Friend WithEvents cmbDepartment As ComboBox
    Friend WithEvents btnNew As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnViewdata As Button
    Friend WithEvents cmbCountry As ComboBox
End Class
