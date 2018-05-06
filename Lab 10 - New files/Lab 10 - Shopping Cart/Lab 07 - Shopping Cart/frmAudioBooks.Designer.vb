<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAudio_Books
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
        Me.btnAddAudioBook = New System.Windows.Forms.Button()
        Me.btnCloseAudio = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lstAudioBooks = New System.Windows.Forms.ListBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnAddAudioBook
        '
        Me.btnAddAudioBook.Location = New System.Drawing.Point(110, 221)
        Me.btnAddAudioBook.Name = "btnAddAudioBook"
        Me.btnAddAudioBook.Size = New System.Drawing.Size(101, 36)
        Me.btnAddAudioBook.TabIndex = 0
        Me.btnAddAudioBook.Text = "Add Book to Cart"
        Me.btnAddAudioBook.UseVisualStyleBackColor = True
        '
        'btnCloseAudio
        '
        Me.btnCloseAudio.Location = New System.Drawing.Point(300, 221)
        Me.btnCloseAudio.Name = "btnCloseAudio"
        Me.btnCloseAudio.Size = New System.Drawing.Size(89, 36)
        Me.btnCloseAudio.TabIndex = 1
        Me.btnCloseAudio.Text = "Close"
        Me.btnCloseAudio.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lstAudioBooks)
        Me.GroupBox1.Controls.Add(Me.btnCloseAudio)
        Me.GroupBox1.Controls.Add(Me.btnAddAudioBook)
        Me.GroupBox1.Location = New System.Drawing.Point(137, 68)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(550, 284)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Select an Audio Book"
        '
        'lstAudioBooks
        '
        Me.lstAudioBooks.FormattingEnabled = True
        Me.lstAudioBooks.Items.AddRange(New Object() {"Learn Calculus in One Day (Audio)", "Relaxation Techniques (Audio)", "The History of Scotland (Audio)", "The Science of Body Language (Audio)", ""})
        Me.lstAudioBooks.Location = New System.Drawing.Point(85, 46)
        Me.lstAudioBooks.Name = "lstAudioBooks"
        Me.lstAudioBooks.Size = New System.Drawing.Size(226, 95)
        Me.lstAudioBooks.TabIndex = 0
        '
        'frmAudio_Books
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmAudio_Books"
        Me.Text = "Audio_Books"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnAddAudioBook As Button
    Friend WithEvents btnCloseAudio As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lstAudioBooks As ListBox
End Class
