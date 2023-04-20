Public Class Form1
    ' FORM LOAD
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        NewInventory("")
        ReloadGrid(dgrid1)
        inventName.Text = "Inventory Name: " & DB_FILE.Split("\").Last
    End Sub

    ' CREATE ITEM REQUEST
    Private Sub btncreate_Click(sender As Object, e As EventArgs) Handles btncreate.Click
        Dim inputs As String = FormInputs()
        If inputs IsNot Nothing Then
            CreateItem(inputs + vbCrLf)
            ReloadGrid(dgrid1)
        End If
    End Sub

    ' READ ITEM REQUEST
    Private Sub btnread_Click(sender As Object, e As EventArgs) Handles btnread.Click
        If Not SelectItem() Then
            Return
        End If

        Dim item As String() = SelectedItem.Split(",")
        ShowData(item, {txtID, txtName, txtPrice, txtQuantity, txtTotal})
    End Sub

    ' UPDATE ITEM REQUEST
    Private Sub btnupdate_Click(sender As Object, e As EventArgs) Handles btnupdate.Click
        If Not SelectItem() Then
            Return
        End If

        Dim inputs As String = FormInputs()
        If inputs Is Nothing Then
            Return
        End If
        UpdateItem(currentItemId, inputs)
        dgrid1.Rows.RemoveAt(itemPos)
        dgrid1.Rows.Insert(itemPos, inputs.Split("=")(1).Split(","))
    End Sub

    ' DELETE ITEM REQUEST
    Private Sub btndel_Click(sender As Object, e As EventArgs) Handles btndel.Click

        Dim id As String
        Dim pos As Integer

        If dgrid1.SelectedRows.Count > 0 Then
            id = dgrid1.SelectedRows(0).Cells(0).Value
            pos = dgrid1.SelectedRows(0).Index
        Else
            id = InputBox("Enter Item ID", "Delete Item")
            If String.IsNullOrEmpty(id) Then
                Return
            End If
            pos = IndexFromGrid(dgrid1, id)
            If pos < 0 Then
                MsgBox("Item Not Found", MsgBoxStyle.Critical, "Error")
                Return
            End If
        End If

        ' Confirm Delete
        Dim m As Integer = MsgBox("Are you sure you want to delete this item?", MsgBoxStyle.YesNo, "Confirm Delete")
        If m = MsgBoxResult.No Then
            Return
        End If

        DeleteItem(id)
        dgrid1.Rows.RemoveAt(pos)
        ClearAll({txtID, txtName, txtPrice, txtQuantity, txtTotal})
    End Sub

    ' SEARCH ITEM
    Private Sub btnsearch_Click(sender As Object, e As EventArgs) Handles btnsearch.Click, txtSeach.TextChanged
        Dim datas As String() = SearchItems(txtSeach.Text)
        dgrid1.Rows.Clear()
        For row As Integer = dgrid1.RowCount To datas.Count - 1
            Dim item As String() = datas(row).Split("=")(1).Split(",")
            dgrid1.Rows.Add(item)
        Next
    End Sub

    ' NEW INVENTORY
    Private Sub btnNewInvent_Click(sender As Object, e As EventArgs) Handles btnNewInvent.Click
        openFile.InitialDirectory = DB_DIR
        Dim name As String

        Dim choose As Integer = MsgBox("Do you want to open an existing inventory?", MsgBoxStyle.YesNoCancel, "New Inventory")

        If choose = MsgBoxResult.Yes Then
            If openFile.ShowDialog = DialogResult.OK Then
                name = openFile.SafeFileName
            Else
                Return
            End If
        ElseIf choose = MsgBoxResult.No Then
            name = InputBox("Enter Inventory Name", "New Inventory")
        Else
            Return
        End If

        NewInventory(name)
        dgrid1.Rows.Clear()
        ReloadGrid(dgrid1)
        inventName.Text = "Inventory Name: " & DB_FILE.Split("\").Last
    End Sub

    ' CLEAR INPUTS
    Private Sub txtclear_Click(sender As Object, e As EventArgs) Handles txtclear.Click
        ClearAll({txtID, txtName, txtPrice, txtQuantity, txtTotal})
    End Sub

    ' GET INPUTS FROM THIS FORM
    Public Function FormInputs()
        Dim item As String
        If IsEmptyInputs({txtID, txtName, txtPrice, txtQuantity}) Or Not IsValidNumbers({txtPrice, txtQuantity}) Then
            Return Nothing
        End If
        If Not isUniqueID(txtID.Text.Trim) Then
            MsgBox("Item ID already exists", MsgBoxStyle.Critical, "Error")
            Return Nothing
        End If
        txtTotal.Text = (CDec(txtPrice.Text) * CDec(txtQuantity.Text)).ToString("f2")
        Dim datas As String() = GetInputs({txtID, txtName, txtPrice, txtQuantity, txtTotal})

        item = txtID.Text + "=" + ConcatStrings(datas)
        Return item
    End Function

    ' SELECT ITEM
    Public Function SelectItem() As Boolean

        Dim id As String

        If dgrid1.SelectedRows.Count > 0 Then
            id = dgrid1.SelectedRows(0).Cells(0).Value
        Else
            id = InputBox("Enter Item ID", "Get Item")
            If String.IsNullOrEmpty(id) Then
                Return 0
            End If
        End If
        itemPos = IndexFromGrid(dgrid1, id)
        If itemPos < 0 Then
            MsgBox("Item Not Found", MsgBoxStyle.Critical, "Error")
            Return 0
        End If
        currentItemId = id


        SelectedItem = ReadItem(currentItemId)
        Return 1
    End Function

    ' TRANSFER DATA FROM GRID TO INPUT TEXTBOXES
    Public Sub ShowData(data As String(), texts As TextBox())
        For i As Integer = 0 To texts.Length - 1
            texts(i).Text = data(i)
        Next
    End Sub
    ' HANDLE ROW SELECTION
    Private Sub dgrid1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgrid1.CellClick
        If dgrid1.SelectedCells.Count >= 0 Then
            Dim row = dgrid1.Rows(dgrid1.SelectedCells(0).RowIndex)
            row.Selected = True
            row.DefaultCellStyle.SelectionBackColor = Color.LightSeaGreen

            SelectItem()
        End If
    End Sub


End Class
