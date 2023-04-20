# Basic Inventory CRUD System

A VB.NET Project that features the basic CREATE, READ, UPDATE, and DELETE operations used in file handling and data management

## Clone and Run

*Step 1. Clone this repository* 
![image](https://user-images.githubusercontent.com/109223910/233275604-96bdd522-0720-4135-a7f2-0818894b0a3d.png)

*Step 2. Paste [Link](https://github.com/deJames-13/Espinosa-CrudSystem_ByGroup)*
![image](https://user-images.githubusercontent.com/109223910/233275886-e86387b3-ae53-4e1e-9b10-a3baac513965.png)

*Step 3. Run*
![image](https://user-images.githubusercontent.com/109223910/233276054-7791a210-8fb8-4b07-8200-9e9bbd1f8d9c.png)

## Code Modules
### FormCRUD.vb

Handles the CRUD methods and Form Interactions 

***VARIABLES***

```vbnet
' DIRECTORIES and PATH for Database File
    Public DB_DIR As String = CurDir.Replace("bin\Debug", "Inventories\")
    Public DB_DEFAULT As String = DB_DIR + "InventoryDEFAULT.txt"
    Public DB_FILE As String = DB_DEFAULT

' Item Selecting and Locating
    Public itemPos As Integer
    Public currentItemId As String
    Public SelectedItem As String
```

***CREATE Method***

- A public function that is used to create a new Item by Appending to the text file
- It takes a concatenated values separated by commas

```vbnet
' CREATE ITEM
    Public Sub CreateItem(item As String)
        If Not String.IsNullOrEmpty(item) Then
            File.AppendAllText(DB_FILE, item)
        End If
    End Sub
```

***READ Methods***

1. *Read All method* - A public function that opens a file and reads all of its content per line, then closes it and returns an array of String().

2. *Read Item method* - A public function that takes a parameter of an ID and searches for possible match in the text file through iterating the result of ReadItems() method.

```vbnet
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

```

***UPDATE Methods***
- A public function that takes a parameter of ID and searches for possible match in the text file through iterating the result of ReadItems() method. 
- It updates the item by taking the modified user input and replacing the matched item based from the ID.

```vbnet
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
```

***DELETE Method***
- A public function that takes a parameter of ID and searches for possible match in the text file through iterating the result of ReadItems() method. 
- It deletes the item by removing the matched item based from the ID.

```vbnet
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
```

***SEARCH Method***
- Searches for an specific keyword in the file.
```vbnet
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
```


***LOAD to Data Grid View and Item Index Locator***

- This renders the value from the text file to the Data Grid View by iterating the contents of the file per line then adding an item as a row.
```vbnet
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
    
    ' Returns the position of an item in the grid
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
```

***MORE***
- Contains input managements such as clearing of textboxes ```ClearAll()```, combining string inputs ```ConcatStrings()```, and getting inputs from textboxes ```GetInputs()```.

- Contains input validators ```IsValidNumbers()``` and ```IsEmptyInputs()``` to check if the inputs are filled and if the numeric values are valid.

- Also contains ```isUniqueID()``` to check if an ID already exists.

```vbnet

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

```

