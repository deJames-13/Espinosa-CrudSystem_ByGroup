Imports System.IO

Module FormCRUD

    Public DB_DIR As String = CurDir.Replace("bin\Debug", "Inventories\")
    Public DB_DEFAULT As String = DB_DIR + "InventoryDEFAULT.txt"
    Public DB_FILE As String = DB_DEFAULT

    Public itemPos As Integer
    Public currentItemId As String
    Public SelectedItem As String



    ' CREATE ITEM
    Public Sub CreateItem(item As String)
        If Not String.IsNullOrEmpty(item) Then
            File.AppendAllText(DB_FILE, item)
        End If
    End Sub

    ' READ ITEMS
    Public Function ReadItems() As String()
        Return File.ReadAllLines(DB_FILE)
    End Function

    ' READ ITEM
    Public Function ReadItem(id As String) As String
        If String.IsNullOrEmpty(id) Or Not IsNumeric(id) Then
            Return ""
        End If

        Dim datas As String() = ReadItems()
        Dim i As Integer = 0
        Dim item As String = ""

        While i < datas.Length
            Dim lineId As String = datas(i).Split("=")(0)
            If lineId = id Then
                item = datas(i).Split("=")(1)
                Return item
            End If
            i += 1
        End While
        Return item
    End Function

    ' UPDATE ITEM
    Public Sub UpdateItem(id As String, text As String)
        If String.IsNullOrEmpty(id) Or Not IsNumeric(id) Then
            Return
        End If

        Dim datas As ArrayList = New ArrayList(ReadItems())
        Dim i = 0

        While i < datas.Count
            Dim lineId As String = datas(i).Split("=")(0)
            If lineId = id Then

                datas(i) = text
                Dim new_datas As String() = datas.ToArray(GetType(String))
                File.WriteAllLines(DB_FILE, new_datas)

                Return
            End If
            i += 1
        End While
    End Sub

    ' DELETE ITEM
    Public Sub DeleteItem(id As String)
        If String.IsNullOrEmpty(id) Or Not IsNumeric(id) Then
            Return
        End If

        Dim datas As ArrayList = New ArrayList(ReadItems())
        Dim i = 0

        While i < datas.Count
            Dim lineId As String = datas(i).Split("=")(0)
            If lineId = id Then

                datas.RemoveAt(i)
                Dim new_datas As String() = datas.ToArray(GetType(String))
                File.WriteAllLines(DB_FILE, new_datas)

                Return
            End If
            i += 1
        End While
    End Sub


    ' SEARCH ITEMS
    Public Function SearchItems(keyword As String) As String()
        If String.IsNullOrEmpty(keyword) Then
            Return ReadItems()
        End If
        Dim datas As String() = ReadItems()
        Dim items As ArrayList = New ArrayList()
        For i As Integer = 0 To datas.Length - 1
            Dim item As String = datas(i).Split("=")(1)
            If item.Contains(keyword.Trim) Then
                items.Add(datas(i))
            End If
        Next
        Return items.ToArray(GetType(String))
    End Function

    ' LOAD INVENTORY to GRID
    Public Sub ReloadGrid(ByRef grid As DataGridView)
        Dim datas As String() = ReadItems()
        If Not datas.Length - grid.RowCount = 1 Then
            grid.Rows.Clear()
        End If
        For row As Integer = grid.RowCount To datas.Count - 1
            Dim item As String() = datas(row).Split("=")(1).Split(",")
            grid.Rows.Add(item)
        Next
    End Sub

    Public Function IndexFromGrid(grid As DataGridView, id As Integer) As Integer
        Dim i = 0
        While i < grid.Rows.Count
            If grid.Rows(i).Cells(0).Value = id Then
                Return i
            End If
            i += 1
        End While
        Return -1
    End Function

    ' INPUT MANAGEMENT

    Public Function isUniqueID(id As String) As Boolean
        Dim datas As ArrayList = New ArrayList(ReadItems())
        Dim i = 0

        While i < datas.Count
            Dim lineId As String = datas(i).Split("=")(0)
            If lineId = id Then
                Return False
            End If
            i += 1
        End While
        Return True
    End Function

    Public Function ConcatStrings(str As String()) As String
        Dim result As String = ""
        For Each s In str
            result += s + ","
        Next
        Return result.Remove(result.Length - 1)
    End Function

    Public Function GetInputs(ByRef inputs As TextBox()) As String()
        Dim datas As New ArrayList

        For Each t In inputs
            datas.Add(t.Text)
        Next
        Return datas.ToArray(GetType(String))
    End Function

    Public Sub ClearAll(inputs As TextBox())
        For Each t In inputs
            t.Clear()
        Next
    End Sub

    ' INPUT VALIDATION
    Public Function IsEmptyInputs(ByRef inputs As TextBox()) As Boolean
        For Each t In inputs
            If String.IsNullOrEmpty(t.Text) Then
                Dim msg As String = "Found missing value: " & t.Name.Substring(3)
                MsgBox(msg, MsgBoxStyle.Exclamation, "Please fill all the fields")
                Return True
            End If
        Next
        Return False
    End Function

    Public Function IsValidNumbers(ByRef inputs As TextBox()) As Boolean
        For Each t In inputs
            If Not IsNumeric(t.Text) Then
                Dim msg As String = "Found invalid value: " & t.Name.Substring(3)
                MsgBox(msg, MsgBoxStyle.Exclamation, "Invalid Value")
                t.Focus()
                Return False
            End If
        Next
        Return True
    End Function

    ' CREATES INVENTORY DATA BASE FILE
    Public Sub NewInventory(name As String)
        If String.IsNullOrEmpty(name) Then
            name = DB_DEFAULT
        Else
            name = DB_DIR + name
        End If
        If Not name.EndsWith(".txt") Then
            name += ".txt"
        End If

        If Not File.Exists(name) Then
            File.Create(name).Dispose()
            MsgBox("File Created Successfully", MsgBoxStyle.Information, "Success")
        End If
        DB_FILE = name
    End Sub

End Module
