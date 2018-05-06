<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPrintBooks
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
        Me.lstPrintBooks = New System.Windows.Forms.ListBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnClosePrint = New System.Windows.Forms.Button()
        Me.btnAddPrintBook = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lstPrintBooks
        '
        Me.lstPrintBooks.FormattingEnabled = True
        Me.lstPrintBooks.Items.AddRange(New Object() {"I Did it Your Way (Print)", "The History of Scotland (Print)", "Learn Calculus in One Day (Print)", "Feel the Stress (Print)"})
        Me.lstPrintBooks.Location = New System.Drawing.Point(47, 45)
        Me.lstPrintBooks.Name = "lstPrintBooks"
        Me.lstPrintBooks.Size = New System.Drawing.Size(286, 82)
        Me.lstPrintBooks.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnClosePrint)
        Me.GroupBox1.Controls.Add(Me.btnAddPrintBook)
        Me.GroupBox1.Controls.Add(Me.lstPrintBooks)
        Me.GroupBox1.Location = New System.Drawing.Point(126, 61)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(460, 252)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Select a Print Book"
        '
        'btnClosePrint
        '
        Me.btnClosePrint.Location = New System.Drawing.Point(241, 169)
        Me.btnClosePrint.Name = "btnClosePrint"
        Me.btnClosePrint.Size = New System.Drawing.Size(101, 42)
        Me.btnClosePrint.TabIndex = 2
        Me.btnClosePrint.Text = "Close"
        Me.btnClosePrint.UseVisualStyleBackColor = True
        '
        'btnAddPrintBook
        '
        Me.btnAddPrintBook.Location = New System.Drawing.Point(64, 169)
        Me.btnAddPrintBook.Name = "btnAddPrintBook"
        Me.btnAddPrintBook.Size = New System.Drawing.Size(135, 42)
        Me.btnAddPrintBook.TabIndex = 1
        Me.btnAddPrintBook.Text = "Add Book to Cart"
        Me.btnAddPrintBook.UseVisualStyleBackColor = True
        '
        'frmPrintBooks
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(746, 392)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmPrintBooks"
        Me.Text = "Print_Books"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lstPrintBooks As ListBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnClosePrint As Button
    Friend WithEvents btnAddPrintBook As Button
End Class
