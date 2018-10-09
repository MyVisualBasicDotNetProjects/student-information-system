Imports System.Configuration
Imports System.Data
Imports System.Data.SqlClient

Public Class frmTrainee

    Dim connectionString As String = String.Empty
    Dim objDataAdapter As New SqlDataAdapter
    Dim objDataSet As DataSet
    Dim objDataView As DataView
    Dim objCurrencyManager As CurrencyManager

    Public Shared newFile As String

    Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.connectionString = ConfigurationManager.ConnectionStrings("connectionString").ConnectionString

        newFile = "Nothing"

        frmTrainee_Load(Nothing, Nothing)

    End Sub

    Private Sub FillDataSetAndView()

        objDataAdapter = New SqlDataAdapter("SELECT * FROM tblTrainee", connectionString)   'ORDER BY trainee_id
        ' Initialize a new instance of the DataSet object...
        objDataSet = New DataSet()
        ' Fill the DataSet object with data...
        objDataAdapter.Fill(objDataSet, "trainee")
        ' Set the DataView object to the DataSet object...
        objDataView = New DataView(objDataSet.Tables("trainee"))
        ' Set our CurrencyManager object to the DataView object...
        objCurrencyManager = CType(Me.BindingContext(objDataView), CurrencyManager)

    End Sub

    Private Sub Clear()

        ' Clear any previous bindings...
        txtTraineeId.DataBindings.Clear()
        txtFirstName.DataBindings.Clear()
        txtLastName.DataBindings.Clear()
        cboSex.DataBindings.Clear()
        cboLevelOfEducation.DataBindings.Clear()
        txtAddress.DataBindings.Clear()
        txtPhoneNumber.DataBindings.Clear()
        txtPlaceOfBirth.DataBindings.Clear()
        txtSpiritualCourse.DataBindings.Clear()
        cboServicesAt.DataBindings.Clear()
        cboCourse.DataBindings.Clear()
        txtRegYear.DataBindings.Clear()
        txtTrainingBatch.DataBindings.Clear()

        picBoxPhoto.DataBindings.Clear()
        picBoxDocument.DataBindings.Clear()

    End Sub

    Private Sub BindFields()

        Clear()

        ' Add new bindings to the DataView object...
        txtTraineeId.DataBindings.Add("Text", objDataView, "trainee_id")
        txtFirstName.DataBindings.Add("Text", objDataView, "trainee_fname")
        txtLastName.DataBindings.Add("Text", objDataView, "trainee_lname")

        ''''''''''' Needs Correction
        cboSex.DataBindings.Add("SelectedItem", objDataView, "trainee_sex")

        cboLevelOfEducation.DataBindings.Add("SelectedItem", objDataView, "trainee_level_of_education")
        txtAddress.DataBindings.Add("Text", objDataView, "trainee_address")
        txtPhoneNumber.DataBindings.Add("Text", objDataView, "trainee_phone_no")

        txtPlaceOfBirth.DataBindings.Add("Text", objDataView, "trainee_place_of_birth")
        txtSpiritualCourse.DataBindings.Add("Text", objDataView, "trainee_AB_course")

        cboServicesAt.DataBindings.Add("SelectedItem", objDataView, "trainee_committee")

        '' To be filled from tblcourse
        'cboCourse.DataBindings.Add("SelectedItem", objDataView, "trainee_")

        txtRegYear.DataBindings.Add("Text", objDataView, "trainee_year_of_graduation")
        txtTrainingBatch.DataBindings.Add("Text", objDataView, "trainee_batch")

        picBoxPhoto.DataBindings.Add("ImageLocation", objDataView, "trainee_photo")
        If picBoxPhoto.ImageLocation = Nothing Then
            newFile = "Nothing"
        Else
            newFile = picBoxPhoto.ImageLocation.ToString
        End If

        picBoxDocument.DataBindings.Add("ImageLocation", objDataView, "trainee_document")
        If picBoxDocument.ImageLocation = Nothing Then
            newFile = "Nothing"
        Else
            newFile = picBoxDocument.ImageLocation.ToString
        End If


    End Sub

    Private Sub ShowPosition()

        ' Display the current position and the number of records
        txtPosition.Text = objCurrencyManager.Position + 1 & " of " & objCurrencyManager.Count()

    End Sub

    Private Sub frmTrainee_Load(ByVal sender As System.Object, ByVal e As System.EventArgs)

        'If user = True Then
        '    btnNew.Enabled = False
        '    btnDelete.Enabled = False
        '    btnSave.Enabled = False
        '    btnUpdate.Enabled = False
        'End If

        cboSex.SelectedIndex = 0
        cboLevelOfEducation.SelectedIndex = 0
        cboServicesAt.SelectedIndex = 0
        cboCourse.SelectedIndex = 0

        ' Fill the DataSet and bind the fields...
        FillDataSetAndView()
        BindFields()

        ' Show the current record position...
        ShowPosition()
        'mover()

        'mover()


        If txtTraineeId.Text.Equals(String.Empty) Then
            btnNew_Click(Nothing, Nothing)
        End If

    End Sub

    Private Sub Save(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Using myConnection As SqlConnection = New SqlConnection(Me.connectionString)

            myConnection.Open()

            Using cmd As SqlCommand = myConnection.CreateCommand

                cmd.CommandType = CommandType.Text
                cmd.CommandText = "INSERT INTO tblTrainee ([trainee_id],[trainee_fname],[trainee_lname],[trainee_sex],[trainee_level_of_education],[trainee_address],[trainee_phone_no],[trainee_date_of_birth],[trainee_place_of_birth],[trainee_year_of_graduation],[trainee_batch],[trainee_AB_course],[trainee_committee],[trainee_paid],[trainee_photo],[trainee_document])" & _
                                  "VALUES (@trainee_id,@trainee_fname,@trainee_lname,@trainee_sex,@trainee_level_of_education,@trainee_address,@trainee_phone_no,@trainee_date_of_birth,@trainee_place_of_birth,@trainee_year_of_graduation,@trainee_batch,@trainee_AB_course,@trainee_committee,@trainee_paid,@trainee_photo,@trainee_document)"

                cmd.Parameters.Add(New SqlParameter("@trainee_id", txtTraineeId.Text))
                cmd.Parameters.Add(New SqlParameter("@trainee_fname", txtFirstName.Text))
                cmd.Parameters.Add(New SqlParameter("@trainee_lname", txtLastName.Text))

                If cboSex.SelectedIndex = 1 Then
                    cmd.Parameters.Add(New SqlParameter("@trainee_sex", 1))
                Else
                    cmd.Parameters.Add(New SqlParameter("@trainee_sex", 0))
                End If

                cmd.Parameters.Add(New SqlParameter("@trainee_level_of_education", cboLevelOfEducation.Text))
                cmd.Parameters.Add(New SqlParameter("@trainee_address", txtAddress.Text))
                cmd.Parameters.Add(New SqlParameter("@trainee_phone_no", txtPhoneNumber.Text))
                cmd.Parameters.Add(New SqlParameter("@trainee_date_of_birth", dtpBirth.Value.Date))
                cmd.Parameters.Add(New SqlParameter("@trainee_place_of_birth", txtPlaceOfBirth.Text))
                cmd.Parameters.Add(New SqlParameter("@trainee_year_of_graduation", txtRegYear.Text))
                cmd.Parameters.Add(New SqlParameter("@trainee_batch", txtTrainingBatch.Text))
                cmd.Parameters.Add(New SqlParameter("@trainee_AB_course", txtSpiritualCourse.Text))
                cmd.Parameters.Add(New SqlParameter("@trainee_committee", cboServicesAt.Text))

                If rdbYes.Checked Then
                    cmd.Parameters.Add(New SqlParameter("@trainee_paid", 1))
                ElseIf rdbNo.Checked Then
                    cmd.Parameters.Add(New SqlParameter("@trainee_paid", 0))
                End If

                If picBoxPhoto.ImageLocation.Equals("Nothing") = False Then
                    cmd.Parameters.Add(New SqlParameter("@trainee_photo", picBoxPhoto.ImageLocation.ToString))
                End If
                If picBoxDocument.ImageLocation.Equals("Nothing") = False Then
                    cmd.Parameters.Add(New SqlParameter("@trainee_document", picBoxDocument.ImageLocation.ToString))
                End If

                Try
                    cmd.ExecuteNonQuery()
                    message.Text = "The data is Inserted Successfully."
                Catch ex As SqlException
                    MessageBox.Show(ex.Message)
                End Try

            End Using

        End Using

        frmTrainee_Load(Nothing, Nothing)

    End Sub

    Private Sub UpdateForm(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Using myConnection As SqlConnection = New SqlConnection(Me.connectionString)

            myConnection.Open()

            Using cmd As SqlCommand = myConnection.CreateCommand

                cmd.CommandType = CommandType.Text
                cmd.CommandText = "UPDATE tblTrainee SET (trainee_fname = @trainee_fname,trainee_lname = @trainee_lname, " & _
                                  "trainee_sex = @trainee_sex,trainee_level_of_education = @trainee_level_of_education,trainee_address = @trainee_address, " & _
                                  "trainee_phone_no = @trainee_phone_no,trainee_date_of_birth = @[trainee_date_of_birth,trainee_place_of_birth = @trainee_place_of_birth, " & _
                                  "trainee_year_of_graduation = @trainee_year_of_graduation,trainee_batch = @[trainee_batch,trainee_AB_course = @trainee_AB_course, " & _
                                  "trainee_committee = @trainee_committee,trainee_paid = @trainee_paid,trainee_photo = @trainee_photo, " & _
                                  "trainee_document = @trainee_document)" & _
                                  "WHERE trainee_id = @trainee_id"

                cmd.Parameters.Add(New SqlParameter("@trainee_id", txtTraineeId.Text))
                cmd.Parameters.Add(New SqlParameter("@trainee_fname", txtFirstName.Text))
                cmd.Parameters.Add(New SqlParameter("@trainee_lname", txtLastName.Text))
                cmd.Parameters.Add(New SqlParameter("@trainee_sex", cboSex.Text))
                cmd.Parameters.Add(New SqlParameter("@trainee_level_of_education", cboLevelOfEducation.Text))
                cmd.Parameters.Add(New SqlParameter("@trainee_address", txtAddress.Text))
                cmd.Parameters.Add(New SqlParameter("@trainee_phone_no", txtPhoneNumber.Text))
                cmd.Parameters.Add(New SqlParameter("@trainee_date_of_birth", dtpBirth.Value.Date))
                cmd.Parameters.Add(New SqlParameter("@trainee_place_of_birth", txtPlaceOfBirth.Text))
                cmd.Parameters.Add(New SqlParameter("@trainee_year_of_graduation", txtRegYear.Text))
                cmd.Parameters.Add(New SqlParameter("@trainee_batch", txtTrainingBatch.Text))
                cmd.Parameters.Add(New SqlParameter("@trainee_AB_course", txtSpiritualCourse.Text))

                If rdbYes.Checked Then
                    cmd.Parameters.Add(New SqlParameter("@trainee_paid", 1))
                ElseIf rdbNo.Checked Then
                    cmd.Parameters.Add(New SqlParameter("@trainee_paid", 0))
                End If

                If picBoxPhoto.ImageLocation.Equals("Nothing") = False Then
                    cmd.Parameters.Add(New SqlParameter("@trainee_photo", picBoxPhoto.ImageLocation.ToString))
                End If
                If picBoxPhoto.ImageLocation.Equals("Nothing") = False Then
                    cmd.Parameters.Add(New SqlParameter("@trainee_document", picBoxDocument.ImageLocation.ToString))
                End If

                Try
                    cmd.ExecuteNonQuery()
                    message.Text = "The data is Updated Successfully."
                Catch ex As SqlException
                    MessageBox.Show(ex.Message)
                End Try

            End Using

        End Using

        Call frmTrainee_Load(Nothing, Nothing)
        btnUpdate.Enabled = True
    End Sub

    Private Sub Delete(ByVal deleteId As Integer)

        Using myConnection As SqlConnection = New SqlConnection(Me.connectionString)

            myConnection.Open()

            Using cmd As SqlCommand = myConnection.CreateCommand

                cmd.CommandType = CommandType.Text
                cmd.CommandText = "DELETE FROM tblTrainee " & _
                                  "WHERE trainee_Id = '" & deleteId & "'"

                Try
                    cmd.ExecuteScalar()
                    message.Text = "The data is Deleted Successfully."
                Catch ex As SqlException
                    MessageBox.Show(ex.Message)
                End Try

            End Using

        End Using

    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        validatation(0)

    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        If (MessageBox.Show("Are you sure you want to delete this data?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes) = True Then

            If txtTraineeId.Text = "" Then
                MessageBox.Show("Can not delete an empty data.", "Deletion Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                Dim selectedId As Integer = txtTraineeId.Text
                Delete(selectedId)
            End If

        End If

        frmTrainee_Load(sender, e)

    End Sub

    Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        ' Clear any previous bindings...
        Clear()

        btnSave.Enabled = True
        btnUpdate.Enabled = False

        txtTraineeId.Text = String.Empty
        txtFirstName.Text = String.Empty
        txtLastName.Text = String.Empty
        cboSex.SelectedIndex = 0
        cboLevelOfEducation.SelectedIndex = 0
        txtAddress.Text = String.Empty
        txtPhoneNumber.Text = String.Empty
        txtPlaceOfBirth.Text = String.Empty
        txtSpiritualCourse.Text = String.Empty
        cboServicesAt.SelectedIndex = 0
        cboCourse.SelectedIndex = 0
        txtRegYear.Text = String.Empty
        txtTrainingBatch.Text = String.Empty

        picBoxPhoto.DataBindings.Clear()
        picBoxDocument.DataBindings.Clear()

        message.Text = "Ready."

        picBoxPhoto.ImageLocation = Nothing
        picBoxDocument.ImageLocation = Nothing
        newFile = "Nothing"

    End Sub

    Private Sub btnMoveFirst_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        ' Set the record position to the first record...
        objCurrencyManager.Position = 0
        ' Show the current record position...
        ShowPosition()
        BindFields()
    End Sub

    Private Sub btnMovePrevious_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        ' Move to the previous record...
        objCurrencyManager.Position -= 1
        ' Show the current record position...
        ShowPosition()
        BindFields()
    End Sub

    Private Sub btnMoveNext_Click(ByVal sender As Object, ByVal e As System.EventArgs)

        ' Move to the next record...
        objCurrencyManager.Position += 1
        ' Show the current record position...
        ShowPosition()
        BindFields()
    End Sub

    Private Sub btnMoveLast_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        ' Set the record position to the last record...
        objCurrencyManager.Position = objCurrencyManager.Count - 1
        ' Show the current record position...
        ShowPosition()
        BindFields()
    End Sub
    Public Sub validatation(ByVal i As Integer)

        If txtTraineeId.Text = String.Empty Or
            txtFirstName.Text = String.Empty Or
            txtLastName.Text = String.Empty Or
            cboSex.Text = String.Empty Or
            cboLevelOfEducation.Text = String.Empty Or
            txtAddress.Text = String.Empty Or
            txtPhoneNumber.Text = String.Empty Or
            txtPlaceOfBirth.Text = String.Empty Or
            txtSpiritualCourse.Text = String.Empty Or
            cboServicesAt.Text = String.Empty Or
            cboCourse.Text = String.Empty Or
            txtRegYear.Text = String.Empty Or
            txtTrainingBatch.Text = String.Empty Then

            MessageBox.Show("Please fill all the required fields.", "Fill Blank Fields", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        ElseIf IsNumeric(txtFirstName.Text) Or IsNumeric(txtLastName.Text) Or IsNumeric(txtPlaceOfBirth.Text) Then
            MessageBox.Show("First name, Last name, and Place of Birth can not be numeric.", "String Expected", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            If i = 1 Then   ' Call Update Method
                Call UpdateForm(Nothing, Nothing)

            Else            ' Call Save Method
                Call Save(Nothing, Nothing)
                btnSave.Enabled = False
                btnUpdate.Enabled = True
            End If
        End If

    End Sub

    Private Sub btnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmTrainee_Load(sender, e)
        btnSave.Enabled = False
        btnUpdate.Enabled = True
    End Sub

    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        validatation(1)
    End Sub

    Private Sub btnBrowsePhoto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Dim myPicture As String = String.Empty

        With OpenFileDialog1
            .Filter = "JPEG (*.jpg,*.jpeg)|*.jpg;*.jpeg|PNG (*.png)|*.png|Monochrome bitmap (*.bmp)|*.jpg|All files (*.*)| *.*"
            .FilterIndex = 1
            .Title = "Open a picture"
            .FileName = String.Empty
        End With
        '192.168.80.139
        'Show the open dialog and if the user clicks the open button load the file

        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then

            Dim sourceName As String

            Try
                'Save the file name
                myPicture = OpenFileDialog1.FileName

                sourceName = OpenFileDialog1.SafeFileName

                Dim file As New IO.FileInfo(myPicture)

                newFile = "C:\Pictures\" & sourceName

                IO.Directory.CreateDirectory("C:\Pictures\")
                file.CopyTo(newFile, False)

                picBoxPhoto.ImageLocation = myPicture

            Catch ex As Exception
                MessageBox.Show("Please select a picture file or a different file name.", "ITTC", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If

    End Sub

    Private Sub btnBrowseDocument_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Dim myPicture As String = String.Empty

        With OpenFileDialog1
            .Filter = "JPEG (*.jpg,*.jpeg)|*.jpg;*.jpeg|PNG (*.png)|*.png|Monochrome bitmap (*.bmp)|*.jpg|All files (*.*)| *.*"
            .FilterIndex = 1
            .Title = "Open a picture"
            .FileName = String.Empty
        End With
        '192.168.80.139
        'Show the open dialog and if the user clicks the open button load the file

        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then

            Dim sourceName As String

            Try
                'Save the file name
                myPicture = OpenFileDialog1.FileName

                sourceName = OpenFileDialog1.SafeFileName

                Dim file As New IO.FileInfo(myPicture)

                newFile = "C:\Pictures\" & sourceName

                IO.Directory.CreateDirectory("C:\Pictures\")
                file.CopyTo(newFile, False)

                picBoxDocument.ImageLocation = myPicture

            Catch ex As Exception
                MessageBox.Show("Please select a picture file or a different file name.", "ITTC", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If

    End Sub


    'Public Sub mover()
    '    ' Set the record position to the first record...
    '    objCurrencyManager.Position = position
    '    ' Show the current record position...
    '    ShowPosition()
    '    BindFields()
    'End Sub



End Class
