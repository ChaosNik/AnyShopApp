<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormNarudžbe
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
        Me.DataGridViewTabela = New System.Windows.Forms.DataGridView()
        Me.ButtonPregled = New System.Windows.Forms.Button()
        Me.ButtonOK = New System.Windows.Forms.Button()
        Me.LabelRokIsporuke = New System.Windows.Forms.Label()
        Me.TextBoxRokIsporuke = New System.Windows.Forms.TextBox()
        Me.LabelProdavnica = New System.Windows.Forms.Label()
        Me.ComboBoxProdavnica = New System.Windows.Forms.ComboBox()
        Me.LabelDobavljač = New System.Windows.Forms.Label()
        Me.ComboBoxDobavljač = New System.Windows.Forms.ComboBox()
        Me.ButtonStavke = New System.Windows.Forms.Button()
        Me.LabelKM = New System.Windows.Forms.Label()
        Me.LabelUkupno = New System.Windows.Forms.Label()
        Me.TextBoxUkupno = New System.Windows.Forms.TextBox()
        CType(Me.DataGridViewTabela, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridViewTabela
        '
        Me.DataGridViewTabela.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewTabela.Location = New System.Drawing.Point(16, 170)
        Me.DataGridViewTabela.Name = "DataGridViewTabela"
        Me.DataGridViewTabela.Size = New System.Drawing.Size(956, 379)
        Me.DataGridViewTabela.TabIndex = 0
        '
        'ButtonPregled
        '
        Me.ButtonPregled.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonPregled.Location = New System.Drawing.Point(16, 104)
        Me.ButtonPregled.Name = "ButtonPregled"
        Me.ButtonPregled.Size = New System.Drawing.Size(150, 40)
        Me.ButtonPregled.TabIndex = 13
        Me.ButtonPregled.Text = "Pregled narudžbi"
        Me.ButtonPregled.UseVisualStyleBackColor = True
        '
        'ButtonOK
        '
        Me.ButtonOK.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonOK.Location = New System.Drawing.Point(381, 104)
        Me.ButtonOK.Name = "ButtonOK"
        Me.ButtonOK.Size = New System.Drawing.Size(150, 40)
        Me.ButtonOK.TabIndex = 14
        Me.ButtonOK.Text = "OK"
        Me.ButtonOK.UseVisualStyleBackColor = True
        '
        'LabelRokIsporuke
        '
        Me.LabelRokIsporuke.AutoSize = True
        Me.LabelRokIsporuke.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.LabelRokIsporuke.Location = New System.Drawing.Point(377, 15)
        Me.LabelRokIsporuke.Name = "LabelRokIsporuke"
        Me.LabelRokIsporuke.Size = New System.Drawing.Size(106, 20)
        Me.LabelRokIsporuke.TabIndex = 17
        Me.LabelRokIsporuke.Text = "Rok isporuke"
        '
        'TextBoxRokIsporuke
        '
        Me.TextBoxRokIsporuke.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.TextBoxRokIsporuke.Location = New System.Drawing.Point(383, 48)
        Me.TextBoxRokIsporuke.Name = "TextBoxRokIsporuke"
        Me.TextBoxRokIsporuke.Size = New System.Drawing.Size(100, 26)
        Me.TextBoxRokIsporuke.TabIndex = 18
        Me.TextBoxRokIsporuke.Text = "0"
        '
        'LabelProdavnica
        '
        Me.LabelProdavnica.AutoSize = True
        Me.LabelProdavnica.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelProdavnica.Location = New System.Drawing.Point(193, 15)
        Me.LabelProdavnica.Name = "LabelProdavnica"
        Me.LabelProdavnica.Size = New System.Drawing.Size(87, 20)
        Me.LabelProdavnica.TabIndex = 5
        Me.LabelProdavnica.Text = "Prodavnica"
        '
        'ComboBoxProdavnica
        '
        Me.ComboBoxProdavnica.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBoxProdavnica.FormattingEnabled = True
        Me.ComboBoxProdavnica.Location = New System.Drawing.Point(197, 48)
        Me.ComboBoxProdavnica.Name = "ComboBoxProdavnica"
        Me.ComboBoxProdavnica.Size = New System.Drawing.Size(150, 28)
        Me.ComboBoxProdavnica.TabIndex = 11
        '
        'LabelDobavljač
        '
        Me.LabelDobavljač.AutoSize = True
        Me.LabelDobavljač.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelDobavljač.Location = New System.Drawing.Point(12, 15)
        Me.LabelDobavljač.Name = "LabelDobavljač"
        Me.LabelDobavljač.Size = New System.Drawing.Size(78, 20)
        Me.LabelDobavljač.TabIndex = 4
        Me.LabelDobavljač.Text = "Dobavljač"
        '
        'ComboBoxDobavljač
        '
        Me.ComboBoxDobavljač.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBoxDobavljač.FormattingEnabled = True
        Me.ComboBoxDobavljač.Location = New System.Drawing.Point(16, 48)
        Me.ComboBoxDobavljač.Name = "ComboBoxDobavljač"
        Me.ComboBoxDobavljač.Size = New System.Drawing.Size(150, 28)
        Me.ComboBoxDobavljač.TabIndex = 10
        '
        'ButtonStavke
        '
        Me.ButtonStavke.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonStavke.Location = New System.Drawing.Point(197, 104)
        Me.ButtonStavke.Name = "ButtonStavke"
        Me.ButtonStavke.Size = New System.Drawing.Size(150, 40)
        Me.ButtonStavke.TabIndex = 19
        Me.ButtonStavke.Text = "Stavke"
        Me.ButtonStavke.UseVisualStyleBackColor = True
        '
        'LabelKM
        '
        Me.LabelKM.AutoSize = True
        Me.LabelKM.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.25!)
        Me.LabelKM.Location = New System.Drawing.Point(858, 91)
        Me.LabelKM.Name = "LabelKM"
        Me.LabelKM.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.LabelKM.Size = New System.Drawing.Size(66, 38)
        Me.LabelKM.TabIndex = 22
        Me.LabelKM.Text = "KM"
        Me.LabelKM.Visible = False
        '
        'LabelUkupno
        '
        Me.LabelUkupno.AutoSize = True
        Me.LabelUkupno.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.25!)
        Me.LabelUkupno.Location = New System.Drawing.Point(665, 36)
        Me.LabelUkupno.Name = "LabelUkupno"
        Me.LabelUkupno.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.LabelUkupno.Size = New System.Drawing.Size(130, 38)
        Me.LabelUkupno.TabIndex = 21
        Me.LabelUkupno.Text = "Ukupno"
        Me.LabelUkupno.Visible = False
        '
        'TextBoxUkupno
        '
        Me.TextBoxUkupno.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.25!)
        Me.TextBoxUkupno.Location = New System.Drawing.Point(612, 88)
        Me.TextBoxUkupno.Name = "TextBoxUkupno"
        Me.TextBoxUkupno.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TextBoxUkupno.Size = New System.Drawing.Size(240, 44)
        Me.TextBoxUkupno.TabIndex = 20
        Me.TextBoxUkupno.Visible = False
        '
        'FormNarudžbe
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(984, 561)
        Me.Controls.Add(Me.LabelKM)
        Me.Controls.Add(Me.LabelUkupno)
        Me.Controls.Add(Me.TextBoxUkupno)
        Me.Controls.Add(Me.ButtonStavke)
        Me.Controls.Add(Me.TextBoxRokIsporuke)
        Me.Controls.Add(Me.LabelRokIsporuke)
        Me.Controls.Add(Me.ButtonOK)
        Me.Controls.Add(Me.ButtonPregled)
        Me.Controls.Add(Me.ComboBoxProdavnica)
        Me.Controls.Add(Me.ComboBoxDobavljač)
        Me.Controls.Add(Me.LabelProdavnica)
        Me.Controls.Add(Me.LabelDobavljač)
        Me.Controls.Add(Me.DataGridViewTabela)
        Me.Name = "FormNarudžbe"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormNarudžbe"
        CType(Me.DataGridViewTabela, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridViewTabela As DataGridView
    Friend WithEvents ButtonPregled As Button
    Friend WithEvents ButtonOK As Button
    Friend WithEvents LabelRokIsporuke As Label
    Friend WithEvents TextBoxRokIsporuke As TextBox
    Friend WithEvents LabelProdavnica As Label
    Friend WithEvents ComboBoxProdavnica As ComboBox
    Friend WithEvents LabelDobavljač As Label
    Friend WithEvents ComboBoxDobavljač As ComboBox
    Friend WithEvents ButtonStavke As Button
    Friend WithEvents LabelKM As Label
    Friend WithEvents LabelUkupno As Label
    Friend WithEvents TextBoxUkupno As TextBox
End Class
