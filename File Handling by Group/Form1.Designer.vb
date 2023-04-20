<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtQuantity = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtclear = New System.Windows.Forms.Button()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnread = New System.Windows.Forms.Button()
        Me.btncreate = New System.Windows.Forms.Button()
        Me.btndel = New System.Windows.Forms.Button()
        Me.btnupdate = New System.Windows.Forms.Button()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.dgrid1 = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.totals = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.prices = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnNewInvent = New System.Windows.Forms.Button()
        Me.openFile = New System.Windows.Forms.OpenFileDialog()
        Me.inventName = New System.Windows.Forms.Label()
        Me.btnsearch = New System.Windows.Forms.Button()
        Me.txtSeach = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.GroupBox1.Controls.Add(Me.txtPrice)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtQuantity)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtclear)
        Me.GroupBox1.Controls.Add(Me.txtTotal)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.btnread)
        Me.GroupBox1.Controls.Add(Me.btncreate)
        Me.GroupBox1.Controls.Add(Me.btndel)
        Me.GroupBox1.Controls.Add(Me.btnupdate)
        Me.GroupBox1.Controls.Add(Me.txtName)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtID)
        Me.GroupBox1.Location = New System.Drawing.Point(23, 41)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Size = New System.Drawing.Size(401, 388)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'txtPrice
        '
        Me.txtPrice.Font = New System.Drawing.Font("Garamond", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txtPrice.Location = New System.Drawing.Point(247, 120)
        Me.txtPrice.Margin = New System.Windows.Forms.Padding(2)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(127, 25)
        Me.txtPrice.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Garamond", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label5.Location = New System.Drawing.Point(27, 123)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(146, 18)
        Me.Label5.TabIndex = 20
        Me.Label5.Text = "PRODUCT PRICE:"
        '
        'txtQuantity
        '
        Me.txtQuantity.Font = New System.Drawing.Font("Garamond", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txtQuantity.Location = New System.Drawing.Point(246, 162)
        Me.txtQuantity.Margin = New System.Windows.Forms.Padding(2)
        Me.txtQuantity.Name = "txtQuantity"
        Me.txtQuantity.Size = New System.Drawing.Size(127, 25)
        Me.txtQuantity.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Garamond", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(28, 165)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(186, 18)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "PRODUCT QUANTITY:"
        '
        'txtclear
        '
        Me.txtclear.Font = New System.Drawing.Font("Garamond", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txtclear.Location = New System.Drawing.Point(283, 306)
        Me.txtclear.Margin = New System.Windows.Forms.Padding(2)
        Me.txtclear.Name = "txtclear"
        Me.txtclear.Size = New System.Drawing.Size(90, 30)
        Me.txtclear.TabIndex = 11
        Me.txtclear.Text = "CLEAR"
        Me.txtclear.UseVisualStyleBackColor = True
        '
        'txtTotal
        '
        Me.txtTotal.Enabled = False
        Me.txtTotal.Font = New System.Drawing.Font("Garamond", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txtTotal.Location = New System.Drawing.Point(246, 202)
        Me.txtTotal.Margin = New System.Windows.Forms.Padding(2)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.ReadOnly = True
        Me.txtTotal.Size = New System.Drawing.Size(127, 25)
        Me.txtTotal.TabIndex = 5
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Garamond", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label7.Location = New System.Drawing.Point(28, 205)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(68, 18)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "TOTAL:"
        '
        'btnread
        '
        Me.btnread.Font = New System.Drawing.Font("Garamond", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnread.Location = New System.Drawing.Point(158, 250)
        Me.btnread.Margin = New System.Windows.Forms.Padding(2)
        Me.btnread.Name = "btnread"
        Me.btnread.Size = New System.Drawing.Size(90, 30)
        Me.btnread.TabIndex = 7
        Me.btnread.Text = "READ"
        Me.btnread.UseVisualStyleBackColor = True
        '
        'btncreate
        '
        Me.btncreate.Font = New System.Drawing.Font("Garamond", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btncreate.Location = New System.Drawing.Point(31, 250)
        Me.btncreate.Margin = New System.Windows.Forms.Padding(2)
        Me.btncreate.Name = "btncreate"
        Me.btncreate.Size = New System.Drawing.Size(90, 30)
        Me.btncreate.TabIndex = 6
        Me.btncreate.Text = "CREATE"
        Me.btncreate.UseVisualStyleBackColor = True
        '
        'btndel
        '
        Me.btndel.Font = New System.Drawing.Font("Garamond", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btndel.Location = New System.Drawing.Point(158, 306)
        Me.btndel.Margin = New System.Windows.Forms.Padding(2)
        Me.btndel.Name = "btndel"
        Me.btndel.Size = New System.Drawing.Size(90, 30)
        Me.btndel.TabIndex = 9
        Me.btndel.Text = "DELETE"
        Me.btndel.UseVisualStyleBackColor = True
        '
        'btnupdate
        '
        Me.btnupdate.Font = New System.Drawing.Font("Garamond", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnupdate.Location = New System.Drawing.Point(31, 306)
        Me.btnupdate.Margin = New System.Windows.Forms.Padding(2)
        Me.btnupdate.Name = "btnupdate"
        Me.btnupdate.Size = New System.Drawing.Size(90, 30)
        Me.btnupdate.TabIndex = 8
        Me.btnupdate.Text = "UPDATE"
        Me.btnupdate.UseVisualStyleBackColor = True
        '
        'txtName
        '
        Me.txtName.Font = New System.Drawing.Font("Garamond", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txtName.Location = New System.Drawing.Point(246, 78)
        Me.txtName.Margin = New System.Windows.Forms.Padding(2)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(127, 25)
        Me.txtName.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Garamond", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label6.Location = New System.Drawing.Point(28, 81)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(63, 18)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "NAME:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(15, 64)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(0, 13)
        Me.Label3.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Garamond", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(28, 39)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(116, 18)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "PRODUCT ID:"
        '
        'txtID
        '
        Me.txtID.Font = New System.Drawing.Font("Garamond", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txtID.Location = New System.Drawing.Point(246, 36)
        Me.txtID.Margin = New System.Windows.Forms.Padding(2)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(127, 25)
        Me.txtID.TabIndex = 0
        '
        'dgrid1
        '
        Me.dgrid1.AllowUserToAddRows = False
        Me.dgrid1.AllowUserToDeleteRows = False
        Me.dgrid1.AllowUserToResizeColumns = False
        Me.dgrid1.AllowUserToResizeRows = False
        Me.dgrid1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgrid1.BackgroundColor = System.Drawing.Color.MediumSeaGreen
        Me.dgrid1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
        Me.dgrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgrid1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.totals, Me.prices, Me.Column3})
        Me.dgrid1.Location = New System.Drawing.Point(443, 77)
        Me.dgrid1.Margin = New System.Windows.Forms.Padding(2)
        Me.dgrid1.Name = "dgrid1"
        Me.dgrid1.ReadOnly = True
        Me.dgrid1.RowHeadersWidth = 51
        Me.dgrid1.RowTemplate.Height = 24
        Me.dgrid1.Size = New System.Drawing.Size(483, 352)
        Me.dgrid1.TabIndex = 12
        '
        'Column1
        '
        Me.Column1.HeaderText = "ID"
        Me.Column1.MinimumWidth = 6
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.HeaderText = "NAME"
        Me.Column2.MinimumWidth = 6
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'totals
        '
        Me.totals.HeaderText = "PRICE"
        Me.totals.MinimumWidth = 6
        Me.totals.Name = "totals"
        Me.totals.ReadOnly = True
        '
        'prices
        '
        Me.prices.HeaderText = "QUANTITY"
        Me.prices.MinimumWidth = 6
        Me.prices.Name = "prices"
        Me.prices.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.HeaderText = "TOTAL"
        Me.Column3.MinimumWidth = 6
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'btnNewInvent
        '
        Me.btnNewInvent.Font = New System.Drawing.Font("Garamond", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnNewInvent.Location = New System.Drawing.Point(751, 42)
        Me.btnNewInvent.Margin = New System.Windows.Forms.Padding(2)
        Me.btnNewInvent.Name = "btnNewInvent"
        Me.btnNewInvent.Size = New System.Drawing.Size(175, 30)
        Me.btnNewInvent.TabIndex = 13
        Me.btnNewInvent.Text = "New Inventory"
        Me.btnNewInvent.UseVisualStyleBackColor = True
        '
        'openFile
        '
        Me.openFile.FileName = "OpenFileDialog1"
        '
        'inventName
        '
        Me.inventName.AutoSize = True
        Me.inventName.Font = New System.Drawing.Font("Garamond", 12.0!, System.Drawing.FontStyle.Bold)
        Me.inventName.Location = New System.Drawing.Point(22, 21)
        Me.inventName.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.inventName.Name = "inventName"
        Me.inventName.Size = New System.Drawing.Size(82, 18)
        Me.inventName.TabIndex = 22
        Me.inventName.Text = "Inventory: "
        '
        'btnsearch
        '
        Me.btnsearch.Font = New System.Drawing.Font("Garamond", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnsearch.Location = New System.Drawing.Point(443, 43)
        Me.btnsearch.Margin = New System.Windows.Forms.Padding(2)
        Me.btnsearch.Name = "btnsearch"
        Me.btnsearch.Size = New System.Drawing.Size(90, 30)
        Me.btnsearch.TabIndex = 10
        Me.btnsearch.Text = "SEARCH"
        Me.btnsearch.UseVisualStyleBackColor = True
        '
        'txtSeach
        '
        Me.txtSeach.Font = New System.Drawing.Font("Garamond", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txtSeach.Location = New System.Drawing.Point(537, 47)
        Me.txtSeach.Margin = New System.Windows.Forms.Padding(2)
        Me.txtSeach.Name = "txtSeach"
        Me.txtSeach.Size = New System.Drawing.Size(192, 25)
        Me.txtSeach.TabIndex = 21
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Garamond", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Label4.Location = New System.Drawing.Point(610, 431)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(316, 31)
        Me.Label4.TabIndex = 23
        Me.Label4.Text = "* Select a Row or Enter a valid ID to READ, UPDATE, DELETE, AND SEARCH QUERY"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.ClientSize = New System.Drawing.Size(948, 471)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtSeach)
        Me.Controls.Add(Me.inventName)
        Me.Controls.Add(Me.btnNewInvent)
        Me.Controls.Add(Me.dgrid1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnsearch)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Form1"
        Me.Text = "Espinosa & Esquivel - Basic inventory System"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtID As TextBox
    Friend WithEvents dgrid1 As DataGridView
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtPrice As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtQuantity As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents totals As DataGridViewTextBoxColumn
    Friend WithEvents prices As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents btnNewInvent As Button
    Friend WithEvents openFile As OpenFileDialog
    Friend WithEvents inventName As Label
    Friend WithEvents txtclear As Button
    Friend WithEvents btnread As Button
    Friend WithEvents btncreate As Button
    Friend WithEvents btndel As Button
    Friend WithEvents btnupdate As Button
    Friend WithEvents btnsearch As Button
    Friend WithEvents txtSeach As TextBox
    Friend WithEvents Label4 As Label
End Class
