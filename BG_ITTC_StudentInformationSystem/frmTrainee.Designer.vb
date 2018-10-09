<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTrainee
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
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.message = New System.Windows.Forms.ToolStripStatusLabel()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.txtStudentId = New System.Windows.Forms.TextBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.dtpBirth = New System.Windows.Forms.DateTimePicker()
        Me.txtPlaceOfBirth = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtPhoneNumber = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cboLevelOfEducation = New System.Windows.Forms.ComboBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.picBoxPhoto = New System.Windows.Forms.PictureBox()
        Me.btnBrowsePhoto = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.picBoxDocument = New System.Windows.Forms.PictureBox()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.btnNew = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.txtPosition = New System.Windows.Forms.TextBox()
        Me.btnMoveLast = New System.Windows.Forms.Button()
        Me.btnMoveNext = New System.Windows.Forms.Button()
        Me.btnMovePrevious = New System.Windows.Forms.Button()
        Me.btnMoveFirst = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.cboCourse = New System.Windows.Forms.ComboBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtTrainingBatch = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtRegYear = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.rdbNo = New System.Windows.Forms.RadioButton()
        Me.rdbYes = New System.Windows.Forms.RadioButton()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.cboServicesAt = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtSpiritualCourse = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cboSex = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtTraineeId = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.StatusStrip1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        CType(Me.picBoxPhoto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBoxDocument, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'message
        '
        Me.message.Name = "message"
        Me.message.Size = New System.Drawing.Size(39, 17)
        Me.message.Text = "Ready"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.message})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 536)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1180, 22)
        Me.StatusStrip1.TabIndex = 29
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'txtStudentId
        '
        Me.txtStudentId.Location = New System.Drawing.Point(152, 37)
        Me.txtStudentId.Name = "txtStudentId"
        Me.txtStudentId.Size = New System.Drawing.Size(195, 20)
        Me.txtStudentId.TabIndex = 90
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox2.Location = New System.Drawing.Point(497, 407)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(399, 184)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 85
        Me.PictureBox2.TabStop = False
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(152, 70)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(195, 20)
        Me.TextBox1.TabIndex = 92
        '
        'dtpBirth
        '
        Me.dtpBirth.Location = New System.Drawing.Point(147, 333)
        Me.dtpBirth.Name = "dtpBirth"
        Me.dtpBirth.Size = New System.Drawing.Size(200, 20)
        Me.dtpBirth.TabIndex = 110
        '
        'txtPlaceOfBirth
        '
        Me.txtPlaceOfBirth.Location = New System.Drawing.Point(152, 370)
        Me.txtPlaceOfBirth.Name = "txtPlaceOfBirth"
        Me.txtPlaceOfBirth.Size = New System.Drawing.Size(195, 20)
        Me.txtPlaceOfBirth.TabIndex = 106
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Visual Geez Unicode", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(29, 376)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(77, 14)
        Me.Label8.TabIndex = 105
        Me.Label8.Text = "የትውልድ ቦታ"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Visual Geez Unicode", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(29, 339)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(75, 14)
        Me.Label10.TabIndex = 103
        Me.Label10.Text = "የትውልድ ቀን"
        '
        'txtPhoneNumber
        '
        Me.txtPhoneNumber.Location = New System.Drawing.Point(152, 293)
        Me.txtPhoneNumber.Name = "txtPhoneNumber"
        Me.txtPhoneNumber.Size = New System.Drawing.Size(195, 20)
        Me.txtPhoneNumber.TabIndex = 102
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Visual Geez Unicode", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(33, 296)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(63, 14)
        Me.Label6.TabIndex = 101
        Me.Label6.Text = "ስልክ ቁጥር"
        '
        'txtAddress
        '
        Me.txtAddress.Location = New System.Drawing.Point(152, 225)
        Me.txtAddress.Multiline = True
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(195, 62)
        Me.txtAddress.TabIndex = 100
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Visual Geez Unicode", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(33, 228)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(91, 14)
        Me.Label7.TabIndex = 99
        Me.Label7.Text = "የመኖሪያ አድራሻ"
        '
        'cboLevelOfEducation
        '
        Me.cboLevelOfEducation.FormattingEnabled = True
        Me.cboLevelOfEducation.Items.AddRange(New Object() {"ከ8ኛ በታች", "8ኛ", "9ኛ", "10ኛ", "10ኛ ያጠናቀቀ/ች", "11ኛ", "12ኛ", "12ኛ ያጠናቀቀ/ች", "የዲፕሎማ ተማሪ", "ዲፕሎማ", "የዲግሪ ተማሪ", "ዲግሪ"})
        Me.cboLevelOfEducation.Location = New System.Drawing.Point(152, 182)
        Me.cboLevelOfEducation.Name = "cboLevelOfEducation"
        Me.cboLevelOfEducation.Size = New System.Drawing.Size(195, 21)
        Me.cboLevelOfEducation.TabIndex = 98
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.GroupBox7)
        Me.GroupBox2.Controls.Add(Me.GroupBox6)
        Me.GroupBox2.Controls.Add(Me.GroupBox5)
        Me.GroupBox2.Controls.Add(Me.GroupBox4)
        Me.GroupBox2.Controls.Add(Me.GroupBox3)
        Me.GroupBox2.Controls.Add(Me.GroupBox1)
        Me.GroupBox2.Location = New System.Drawing.Point(24, 25)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1144, 502)
        Me.GroupBox2.TabIndex = 30
        Me.GroupBox2.TabStop = False
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.Button1)
        Me.GroupBox7.Controls.Add(Me.Label17)
        Me.GroupBox7.Controls.Add(Me.picBoxPhoto)
        Me.GroupBox7.Controls.Add(Me.btnBrowsePhoto)
        Me.GroupBox7.Controls.Add(Me.Label9)
        Me.GroupBox7.Controls.Add(Me.picBoxDocument)
        Me.GroupBox7.Location = New System.Drawing.Point(809, 74)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(321, 408)
        Me.GroupBox7.TabIndex = 116
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "የምስል መረጃ"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(209, 375)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(54, 23)
        Me.Button1.TabIndex = 122
        Me.Button1.Text = "ምረጥ ..."
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Visual Geez Unicode", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(12, 25)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(79, 14)
        Me.Label17.TabIndex = 121
        Me.Label17.Text = "ፎቶዎን ያስገቡ"
        '
        'picBoxPhoto
        '
        Me.picBoxPhoto.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.picBoxPhoto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.picBoxPhoto.Location = New System.Drawing.Point(19, 46)
        Me.picBoxPhoto.Name = "picBoxPhoto"
        Me.picBoxPhoto.Size = New System.Drawing.Size(144, 106)
        Me.picBoxPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBoxPhoto.TabIndex = 119
        Me.picBoxPhoto.TabStop = False
        '
        'btnBrowsePhoto
        '
        Me.btnBrowsePhoto.Location = New System.Drawing.Point(209, 129)
        Me.btnBrowsePhoto.Name = "btnBrowsePhoto"
        Me.btnBrowsePhoto.Size = New System.Drawing.Size(54, 23)
        Me.btnBrowsePhoto.TabIndex = 120
        Me.btnBrowsePhoto.Text = "ምረጥ ..."
        Me.btnBrowsePhoto.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Visual Geez Unicode", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(16, 171)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(151, 14)
        Me.Label9.TabIndex = 118
        Me.Label9.Text = "የትምህርት ማስረጃዎን ያስገቡ"
        '
        'picBoxDocument
        '
        Me.picBoxDocument.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.picBoxDocument.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.picBoxDocument.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.picBoxDocument.Location = New System.Drawing.Point(19, 196)
        Me.picBoxDocument.Name = "picBoxDocument"
        Me.picBoxDocument.Size = New System.Drawing.Size(287, 170)
        Me.picBoxDocument.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBoxDocument.TabIndex = 116
        Me.picBoxDocument.TabStop = False
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.btnNew)
        Me.GroupBox6.Controls.Add(Me.btnDelete)
        Me.GroupBox6.Controls.Add(Me.btnUpdate)
        Me.GroupBox6.Controls.Add(Me.btnSave)
        Me.GroupBox6.Location = New System.Drawing.Point(29, 20)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(358, 48)
        Me.GroupBox6.TabIndex = 112
        Me.GroupBox6.TabStop = False
        '
        'btnNew
        '
        Me.btnNew.Location = New System.Drawing.Point(8, 13)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(90, 23)
        Me.btnNew.TabIndex = 15
        Me.btnNew.Text = "አዲስ መመዝገቢያ"
        Me.btnNew.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(284, 13)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(66, 23)
        Me.btnDelete.TabIndex = 18
        Me.btnDelete.Text = "አጥፋ"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(200, 13)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(66, 23)
        Me.btnUpdate.TabIndex = 17
        Me.btnUpdate.Text = "አሻሽል"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Enabled = False
        Me.btnSave.Location = New System.Drawing.Point(116, 13)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(66, 23)
        Me.btnSave.TabIndex = 16
        Me.btnSave.Text = "አስቀምጥ"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.btnRefresh)
        Me.GroupBox5.Controls.Add(Me.txtPosition)
        Me.GroupBox5.Controls.Add(Me.btnMoveLast)
        Me.GroupBox5.Controls.Add(Me.btnMoveNext)
        Me.GroupBox5.Controls.Add(Me.btnMovePrevious)
        Me.GroupBox5.Controls.Add(Me.btnMoveFirst)
        Me.GroupBox5.Location = New System.Drawing.Point(422, 20)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(358, 48)
        Me.GroupBox5.TabIndex = 107
        Me.GroupBox5.TabStop = False
        '
        'btnRefresh
        '
        Me.btnRefresh.Location = New System.Drawing.Point(298, 15)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(52, 23)
        Me.btnRefresh.TabIndex = 106
        Me.btnRefresh.Text = "&Refresh"
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'txtPosition
        '
        Me.txtPosition.Location = New System.Drawing.Point(88, 18)
        Me.txtPosition.Name = "txtPosition"
        Me.txtPosition.Size = New System.Drawing.Size(100, 20)
        Me.txtPosition.TabIndex = 111
        Me.txtPosition.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnMoveLast
        '
        Me.btnMoveLast.Location = New System.Drawing.Point(235, 15)
        Me.btnMoveLast.Name = "btnMoveLast"
        Me.btnMoveLast.Size = New System.Drawing.Size(29, 23)
        Me.btnMoveLast.TabIndex = 110
        Me.btnMoveLast.Text = ">|"
        Me.btnMoveLast.UseVisualStyleBackColor = True
        '
        'btnMoveNext
        '
        Me.btnMoveNext.Location = New System.Drawing.Point(195, 15)
        Me.btnMoveNext.Name = "btnMoveNext"
        Me.btnMoveNext.Size = New System.Drawing.Size(29, 23)
        Me.btnMoveNext.TabIndex = 109
        Me.btnMoveNext.Text = ">"
        Me.btnMoveNext.UseVisualStyleBackColor = True
        '
        'btnMovePrevious
        '
        Me.btnMovePrevious.Location = New System.Drawing.Point(53, 15)
        Me.btnMovePrevious.Name = "btnMovePrevious"
        Me.btnMovePrevious.Size = New System.Drawing.Size(29, 23)
        Me.btnMovePrevious.TabIndex = 108
        Me.btnMovePrevious.Text = "<"
        Me.btnMovePrevious.UseVisualStyleBackColor = True
        '
        'btnMoveFirst
        '
        Me.btnMoveFirst.Location = New System.Drawing.Point(9, 15)
        Me.btnMoveFirst.Name = "btnMoveFirst"
        Me.btnMoveFirst.Size = New System.Drawing.Size(29, 23)
        Me.btnMoveFirst.TabIndex = 107
        Me.btnMoveFirst.Text = "|<"
        Me.btnMoveFirst.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.cboCourse)
        Me.GroupBox4.Controls.Add(Me.Label16)
        Me.GroupBox4.Controls.Add(Me.txtTrainingBatch)
        Me.GroupBox4.Controls.Add(Me.Label13)
        Me.GroupBox4.Controls.Add(Me.txtRegYear)
        Me.GroupBox4.Controls.Add(Me.Label14)
        Me.GroupBox4.Controls.Add(Me.rdbNo)
        Me.GroupBox4.Controls.Add(Me.rdbYes)
        Me.GroupBox4.Controls.Add(Me.Label15)
        Me.GroupBox4.Location = New System.Drawing.Point(404, 219)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(397, 177)
        Me.GroupBox4.TabIndex = 99
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "የሥልጠና መረጃ"
        '
        'cboCourse
        '
        Me.cboCourse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCourse.FormattingEnabled = True
        Me.cboCourse.Items.AddRange(New Object() {"መሠረታዊ የኮምፒውተር ሥልጠና", "የኮምፒውተር ጥገናና ኔትወርኪንግ"})
        Me.cboCourse.Location = New System.Drawing.Point(170, 32)
        Me.cboCourse.Name = "cboCourse"
        Me.cboCourse.Size = New System.Drawing.Size(195, 21)
        Me.cboCourse.TabIndex = 104
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Visual Geez Unicode", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(15, 35)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(139, 14)
        Me.Label16.TabIndex = 103
        Me.Label16.Text = "ለመማር የተመዘገቡት ኮርስ"
        '
        'txtTrainingBatch
        '
        Me.txtTrainingBatch.Location = New System.Drawing.Point(172, 105)
        Me.txtTrainingBatch.Name = "txtTrainingBatch"
        Me.txtTrainingBatch.Size = New System.Drawing.Size(195, 20)
        Me.txtTrainingBatch.TabIndex = 101
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Visual Geez Unicode", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(17, 108)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(76, 14)
        Me.Label13.TabIndex = 100
        Me.Label13.Text = "የሥልጠና ዙር"
        '
        'txtRegYear
        '
        Me.txtRegYear.Location = New System.Drawing.Point(172, 68)
        Me.txtRegYear.Name = "txtRegYear"
        Me.txtRegYear.Size = New System.Drawing.Size(195, 20)
        Me.txtRegYear.TabIndex = 99
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Visual Geez Unicode", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(17, 71)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(101, 14)
        Me.Label14.TabIndex = 98
        Me.Label14.Text = "የሠለጠኑበት ዓመት"
        '
        'rdbNo
        '
        Me.rdbNo.AutoSize = True
        Me.rdbNo.Location = New System.Drawing.Point(277, 142)
        Me.rdbNo.Name = "rdbNo"
        Me.rdbNo.Size = New System.Drawing.Size(38, 17)
        Me.rdbNo.TabIndex = 97
        Me.rdbNo.TabStop = True
        Me.rdbNo.Text = "አይ"
        Me.rdbNo.UseVisualStyleBackColor = True
        '
        'rdbYes
        '
        Me.rdbYes.AutoSize = True
        Me.rdbYes.Location = New System.Drawing.Point(172, 142)
        Me.rdbYes.Name = "rdbYes"
        Me.rdbYes.Size = New System.Drawing.Size(38, 17)
        Me.rdbYes.TabIndex = 96
        Me.rdbYes.TabStop = True
        Me.rdbYes.Text = "አዎ"
        Me.rdbYes.UseVisualStyleBackColor = True
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Visual Geez Unicode", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(17, 142)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(90, 14)
        Me.Label15.TabIndex = 95
        Me.Label15.Text = "ክፍያ ተከፍሉአል"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.cboServicesAt)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.txtSpiritualCourse)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Location = New System.Drawing.Point(404, 89)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(397, 102)
        Me.GroupBox3.TabIndex = 98
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "የሠልጣኙ የሰንበት ት/ቤት መረጃ"
        '
        'cboServicesAt
        '
        Me.cboServicesAt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboServicesAt.FormattingEnabled = True
        Me.cboServicesAt.Items.AddRange(New Object() {"የለኝም", "ህጻናትና ታዳጊ ክፍል", "ትምህርት ክፍል", "ሥነ-ሥርዓት ክፍል", "ወጣት ማስተባበሪያ ክፍል", "ልማት ክፍል", "መዝሙር ክፍል", "ምግባረ ሠናይ ክፍል", "ኦዲዮ ቪዲዮ ክፍል"})
        Me.cboServicesAt.Location = New System.Drawing.Point(170, 63)
        Me.cboServicesAt.Name = "cboServicesAt"
        Me.cboServicesAt.Size = New System.Drawing.Size(195, 21)
        Me.cboServicesAt.TabIndex = 100
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Visual Geez Unicode", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(15, 66)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(113, 14)
        Me.Label11.TabIndex = 99
        Me.Label11.Text = "የሚያገለግሉበት ክፍል"
        '
        'txtSpiritualCourse
        '
        Me.txtSpiritualCourse.Location = New System.Drawing.Point(170, 22)
        Me.txtSpiritualCourse.Name = "txtSpiritualCourse"
        Me.txtSpiritualCourse.Size = New System.Drawing.Size(195, 20)
        Me.txtSpiritualCourse.TabIndex = 98
        '
        'Label12
        '
        Me.Label12.Font = New System.Drawing.Font("Visual Geez Unicode", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(15, 25)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(118, 37)
        Me.Label12.TabIndex = 97
        Me.Label12.Text = "የተማሩበት የመንፈሳዊ ኮርስ ዙር"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dtpBirth)
        Me.GroupBox1.Controls.Add(Me.txtPlaceOfBirth)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.txtPhoneNumber)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtAddress)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.cboLevelOfEducation)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.cboSex)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtLastName)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtFirstName)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtTraineeId)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Location = New System.Drawing.Point(20, 74)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(367, 408)
        Me.GroupBox1.TabIndex = 97
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "የሠልጣኙ የግል መረጃ"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Visual Geez Unicode", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(33, 189)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(87, 14)
        Me.Label5.TabIndex = 97
        Me.Label5.Text = "የትምህርት ደረጃ"
        '
        'cboSex
        '
        Me.cboSex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSex.FormattingEnabled = True
        Me.cboSex.Items.AddRange(New Object() {"ወንድ", "ሴት"})
        Me.cboSex.Location = New System.Drawing.Point(152, 142)
        Me.cboSex.Name = "cboSex"
        Me.cboSex.Size = New System.Drawing.Size(195, 21)
        Me.cboSex.TabIndex = 96
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Visual Geez Unicode", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(33, 149)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(25, 14)
        Me.Label3.TabIndex = 95
        Me.Label3.Text = "ፆታ"
        '
        'txtLastName
        '
        Me.txtLastName.Location = New System.Drawing.Point(152, 107)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(195, 20)
        Me.txtLastName.TabIndex = 94
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Visual Geez Unicode", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(33, 110)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 14)
        Me.Label2.TabIndex = 93
        Me.Label2.Text = "የአባት ስም"
        '
        'txtFirstName
        '
        Me.txtFirstName.Location = New System.Drawing.Point(152, 70)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(195, 20)
        Me.txtFirstName.TabIndex = 92
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Visual Geez Unicode", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(33, 73)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(25, 14)
        Me.Label1.TabIndex = 91
        Me.Label1.Text = "ስም"
        '
        'txtTraineeId
        '
        Me.txtTraineeId.Location = New System.Drawing.Point(152, 37)
        Me.txtTraineeId.Name = "txtTraineeId"
        Me.txtTraineeId.Size = New System.Drawing.Size(195, 20)
        Me.txtTraineeId.TabIndex = 90
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Visual Geez Unicode", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(33, 40)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 14)
        Me.Label4.TabIndex = 89
        Me.Label4.Text = "መለያ ቁጥር"
        '
        'frmTrainee
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1180, 558)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Name = "frmTrainee"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "የሠልጣኞች መረጃ ሲስተም ፡ የሠልጣኙ አጠቃላይ መረጃ"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        CType(Me.picBoxPhoto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBoxDocument, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtDateOfBirth As System.Windows.Forms.TextBox
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents message As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents txtStudentId As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents dtpBirth As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtPlaceOfBirth As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtPhoneNumber As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtAddress As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cboLevelOfEducation As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents picBoxPhoto As System.Windows.Forms.PictureBox
    Friend WithEvents btnBrowsePhoto As System.Windows.Forms.Button
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents picBoxDocument As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents btnNew As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents btnRefresh As System.Windows.Forms.Button
    Friend WithEvents txtPosition As System.Windows.Forms.TextBox
    Friend WithEvents btnMoveLast As System.Windows.Forms.Button
    Friend WithEvents btnMoveNext As System.Windows.Forms.Button
    Friend WithEvents btnMovePrevious As System.Windows.Forms.Button
    Friend WithEvents btnMoveFirst As System.Windows.Forms.Button
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents cboCourse As System.Windows.Forms.ComboBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txtTrainingBatch As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtRegYear As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents rdbNo As System.Windows.Forms.RadioButton
    Friend WithEvents rdbYes As System.Windows.Forms.RadioButton
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents cboServicesAt As System.Windows.Forms.ComboBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtSpiritualCourse As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cboSex As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtLastName As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtFirstName As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtTraineeId As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label

End Class
