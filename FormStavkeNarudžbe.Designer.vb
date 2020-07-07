<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormStavkeNarudžbe
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
        Me.DataGridViewTabela = New System.Windows.Forms.DataGridView()
        Me.ComboBoxNazivProizvoda = New System.Windows.Forms.ComboBox()
        Me.LabelNazivProizvoda = New System.Windows.Forms.Label()
        Me.LabelKoličina = New System.Windows.Forms.Label()
        Me.TextBoxKoličina = New System.Windows.Forms.TextBox()
        Me.ButtonDodaj = New System.Windows.Forms.Button()
        Me.ButtonCancel = New System.Windows.Forms.Button()
        CType(Me.DataGridViewTabela, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridViewTabela
        '
        Me.DataGridViewTabela.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewTabela.Location = New System.Drawing.Point(16, 170)
        Me.DataGridViewTabela.Name = "DataGridViewTabela"
        Me.DataGridViewTabela.Size = New System.Drawing.Size(956, 379)
        Me.DataGridViewTabela.TabIndex = 1
        '
        'ComboBoxNazivProizvoda
        '
        Me.ComboBoxNazivProizvoda.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.ComboBoxNazivProizvoda.FormattingEnabled = True
        Me.ComboBoxNazivProizvoda.Location = New System.Drawing.Point(31, 55)
        Me.ComboBoxNazivProizvoda.Name = "ComboBoxNazivProizvoda"
        Me.ComboBoxNazivProizvoda.Size = New System.Drawing.Size(350, 28)
        Me.ComboBoxNazivProizvoda.TabIndex = 2
        '
        'LabelNazivProizvoda
        '
        Me.LabelNazivProizvoda.AutoSize = True
        Me.LabelNazivProizvoda.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.LabelNazivProizvoda.Location = New System.Drawing.Point(27, 18)
        Me.LabelNazivProizvoda.Name = "LabelNazivProizvoda"
        Me.LabelNazivProizvoda.Size = New System.Drawing.Size(128, 20)
        Me.LabelNazivProizvoda.TabIndex = 3
        Me.LabelNazivProizvoda.Text = "Naziv proizvoda"
        '
        'LabelKoličina
        '
        Me.LabelKoličina.AutoSize = True
        Me.LabelKoličina.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.LabelKoličina.Location = New System.Drawing.Point(383, 18)
        Me.LabelKoličina.Name = "LabelKoličina"
        Me.LabelKoličina.Size = New System.Drawing.Size(68, 20)
        Me.LabelKoličina.TabIndex = 4
        Me.LabelKoličina.Text = "Količina"
        '
        'TextBoxKoličina
        '
        Me.TextBoxKoličina.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.TextBoxKoličina.Location = New System.Drawing.Point(387, 55)
        Me.TextBoxKoličina.Name = "TextBoxKoličina"
        Me.TextBoxKoličina.Size = New System.Drawing.Size(100, 26)
        Me.TextBoxKoličina.TabIndex = 5
        Me.TextBoxKoličina.Text = "0"
        '
        'ButtonDodaj
        '
        Me.ButtonDodaj.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonDodaj.Location = New System.Drawing.Point(337, 106)
        Me.ButtonDodaj.Name = "ButtonDodaj"
        Me.ButtonDodaj.Size = New System.Drawing.Size(150, 40)
        Me.ButtonDodaj.TabIndex = 16
        Me.ButtonDodaj.Text = "OK"
        Me.ButtonDodaj.UseVisualStyleBackColor = True
        '
        'ButtonCancel
        '
        Me.ButtonCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonCancel.Location = New System.Drawing.Point(31, 106)
        Me.ButtonCancel.Name = "ButtonCancel"
        Me.ButtonCancel.Size = New System.Drawing.Size(150, 40)
        Me.ButtonCancel.TabIndex = 15
        Me.ButtonCancel.Text = "Cancel"
        Me.ButtonCancel.UseVisualStyleBackColor = True
        '
        'FormStavkeNarudžbe
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(984, 561)
        Me.Controls.Add(Me.ButtonDodaj)
        Me.Controls.Add(Me.ButtonCancel)
        Me.Controls.Add(Me.TextBoxKoličina)
        Me.Controls.Add(Me.LabelKoličina)
        Me.Controls.Add(Me.LabelNazivProizvoda)
        Me.Controls.Add(Me.ComboBoxNazivProizvoda)
        Me.Controls.Add(Me.DataGridViewTabela)
        Me.Name = "FormStavkeNarudžbe"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "StavkeNarudžbe"
        CType(Me.DataGridViewTabela, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridViewTabela As DataGridView
    Friend WithEvents ComboBoxNazivProizvoda As ComboBox
    Friend WithEvents LabelNazivProizvoda As Label
    Friend WithEvents LabelKoličina As Label
    Friend WithEvents TextBoxKoličina As TextBox
    Friend WithEvents ButtonDodaj As Button
    Friend WithEvents ButtonCancel As Button
End Class
