<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormUkloniProizvod
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
        Me.ComboBoxNaziv = New System.Windows.Forms.ComboBox()
        Me.ButtonUkloni = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ComboBoxNaziv
        '
        Me.ComboBoxNaziv.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.ComboBoxNaziv.FormattingEnabled = True
        Me.ComboBoxNaziv.Location = New System.Drawing.Point(12, 12)
        Me.ComboBoxNaziv.Name = "ComboBoxNaziv"
        Me.ComboBoxNaziv.Size = New System.Drawing.Size(260, 28)
        Me.ComboBoxNaziv.TabIndex = 0
        '
        'ButtonUkloni
        '
        Me.ButtonUkloni.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.ButtonUkloni.Location = New System.Drawing.Point(68, 58)
        Me.ButtonUkloni.Name = "ButtonUkloni"
        Me.ButtonUkloni.Size = New System.Drawing.Size(150, 40)
        Me.ButtonUkloni.TabIndex = 1
        Me.ButtonUkloni.Text = "Ukloni"
        Me.ButtonUkloni.UseVisualStyleBackColor = True
        '
        'FormUkloniProizvod
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 113)
        Me.Controls.Add(Me.ButtonUkloni)
        Me.Controls.Add(Me.ComboBoxNaziv)
        Me.Name = "FormUkloniProizvod"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ukloni proizvod"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ComboBoxNaziv As ComboBox
    Friend WithEvents ButtonUkloni As Button
End Class
