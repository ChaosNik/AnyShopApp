<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormDodajProizvod
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
        Me.TextBoxNaziv = New System.Windows.Forms.TextBox()
        Me.ComboBoxVrsta = New System.Windows.Forms.ComboBox()
        Me.ComboBoxMotiv = New System.Windows.Forms.ComboBox()
        Me.TextBoxCijena = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ButtonDodaj = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TextBoxNaziv
        '
        Me.TextBoxNaziv.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.TextBoxNaziv.Location = New System.Drawing.Point(94, 22)
        Me.TextBoxNaziv.Name = "TextBoxNaziv"
        Me.TextBoxNaziv.Size = New System.Drawing.Size(178, 26)
        Me.TextBoxNaziv.TabIndex = 0
        '
        'ComboBoxVrsta
        '
        Me.ComboBoxVrsta.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.ComboBoxVrsta.FormattingEnabled = True
        Me.ComboBoxVrsta.Location = New System.Drawing.Point(94, 64)
        Me.ComboBoxVrsta.Name = "ComboBoxVrsta"
        Me.ComboBoxVrsta.Size = New System.Drawing.Size(178, 28)
        Me.ComboBoxVrsta.TabIndex = 1
        '
        'ComboBoxMotiv
        '
        Me.ComboBoxMotiv.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.ComboBoxMotiv.FormattingEnabled = True
        Me.ComboBoxMotiv.Location = New System.Drawing.Point(94, 108)
        Me.ComboBoxMotiv.Name = "ComboBoxMotiv"
        Me.ComboBoxMotiv.Size = New System.Drawing.Size(178, 28)
        Me.ComboBoxMotiv.TabIndex = 2
        '
        'TextBoxCijena
        '
        Me.TextBoxCijena.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.TextBoxCijena.Location = New System.Drawing.Point(94, 152)
        Me.TextBoxCijena.Name = "TextBoxCijena"
        Me.TextBoxCijena.Size = New System.Drawing.Size(178, 26)
        Me.TextBoxCijena.TabIndex = 3
        Me.TextBoxCijena.Text = "0"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.Label1.Location = New System.Drawing.Point(12, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 20)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Naziv"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.Label2.Location = New System.Drawing.Point(12, 69)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 20)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Vrsta"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.Label3.Location = New System.Drawing.Point(12, 112)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 20)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Motiv"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.Label4.Location = New System.Drawing.Point(12, 155)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 20)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Cijena"
        '
        'ButtonDodaj
        '
        Me.ButtonDodaj.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.ButtonDodaj.Location = New System.Drawing.Point(67, 197)
        Me.ButtonDodaj.Name = "ButtonDodaj"
        Me.ButtonDodaj.Size = New System.Drawing.Size(150, 40)
        Me.ButtonDodaj.TabIndex = 8
        Me.ButtonDodaj.Text = "Dodaj"
        Me.ButtonDodaj.UseVisualStyleBackColor = True
        '
        'FormDodajProizvod
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 243)
        Me.Controls.Add(Me.ButtonDodaj)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBoxCijena)
        Me.Controls.Add(Me.ComboBoxMotiv)
        Me.Controls.Add(Me.ComboBoxVrsta)
        Me.Controls.Add(Me.TextBoxNaziv)
        Me.Name = "FormDodajProizvod"
        Me.Text = "FormDodajProizvod"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBoxNaziv As TextBox
    Friend WithEvents ComboBoxVrsta As ComboBox
    Friend WithEvents ComboBoxMotiv As ComboBox
    Friend WithEvents TextBoxCijena As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents ButtonDodaj As Button
End Class
