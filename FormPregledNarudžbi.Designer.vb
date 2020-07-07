<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPregledNarudžbi
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
        Me.ButtonPrikaži = New System.Windows.Forms.Button()
        Me.LabelID = New System.Windows.Forms.Label()
        Me.DataGridViewTabela = New System.Windows.Forms.DataGridView()
        Me.LabelNaručeno = New System.Windows.Forms.Label()
        Me.TextBoxNaručeno = New System.Windows.Forms.TextBox()
        Me.LabelRok = New System.Windows.Forms.Label()
        Me.TextBoxRok = New System.Windows.Forms.TextBox()
        Me.ComboBoxId = New System.Windows.Forms.ComboBox()
        CType(Me.DataGridViewTabela, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtonPrikaži
        '
        Me.ButtonPrikaži.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonPrikaži.Location = New System.Drawing.Point(21, 96)
        Me.ButtonPrikaži.Name = "ButtonPrikaži"
        Me.ButtonPrikaži.Size = New System.Drawing.Size(150, 40)
        Me.ButtonPrikaži.TabIndex = 22
        Me.ButtonPrikaži.Text = "Prikaži"
        Me.ButtonPrikaži.UseVisualStyleBackColor = True
        '
        'LabelID
        '
        Me.LabelID.AutoSize = True
        Me.LabelID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.LabelID.Location = New System.Drawing.Point(17, 9)
        Me.LabelID.Name = "LabelID"
        Me.LabelID.Size = New System.Drawing.Size(100, 20)
        Me.LabelID.TabIndex = 19
        Me.LabelID.Text = "ID narudžbe"
        '
        'DataGridViewTabela
        '
        Me.DataGridViewTabela.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewTabela.Location = New System.Drawing.Point(6, 160)
        Me.DataGridViewTabela.Name = "DataGridViewTabela"
        Me.DataGridViewTabela.Size = New System.Drawing.Size(956, 379)
        Me.DataGridViewTabela.TabIndex = 17
        '
        'LabelNaručeno
        '
        Me.LabelNaručeno.AutoSize = True
        Me.LabelNaručeno.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.LabelNaručeno.Location = New System.Drawing.Point(123, 9)
        Me.LabelNaručeno.Name = "LabelNaručeno"
        Me.LabelNaručeno.Size = New System.Drawing.Size(81, 20)
        Me.LabelNaručeno.TabIndex = 24
        Me.LabelNaručeno.Text = "Naručeno"
        '
        'TextBoxNaručeno
        '
        Me.TextBoxNaručeno.Enabled = False
        Me.TextBoxNaručeno.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.TextBoxNaručeno.Location = New System.Drawing.Point(127, 44)
        Me.TextBoxNaručeno.Name = "TextBoxNaručeno"
        Me.TextBoxNaručeno.Size = New System.Drawing.Size(96, 26)
        Me.TextBoxNaručeno.TabIndex = 25
        '
        'LabelRok
        '
        Me.LabelRok.AutoSize = True
        Me.LabelRok.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.LabelRok.Location = New System.Drawing.Point(228, 9)
        Me.LabelRok.Name = "LabelRok"
        Me.LabelRok.Size = New System.Drawing.Size(101, 20)
        Me.LabelRok.TabIndex = 28
        Me.LabelRok.Text = "Rok dostave"
        '
        'TextBoxRok
        '
        Me.TextBoxRok.Enabled = False
        Me.TextBoxRok.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.TextBoxRok.Location = New System.Drawing.Point(233, 44)
        Me.TextBoxRok.Name = "TextBoxRok"
        Me.TextBoxRok.Size = New System.Drawing.Size(96, 26)
        Me.TextBoxRok.TabIndex = 29
        '
        'ComboBoxId
        '
        Me.ComboBoxId.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.ComboBoxId.FormattingEnabled = True
        Me.ComboBoxId.Location = New System.Drawing.Point(21, 44)
        Me.ComboBoxId.Name = "ComboBoxId"
        Me.ComboBoxId.Size = New System.Drawing.Size(96, 28)
        Me.ComboBoxId.TabIndex = 30
        '
        'FormPregledNarudžbi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(984, 561)
        Me.Controls.Add(Me.ComboBoxId)
        Me.Controls.Add(Me.TextBoxRok)
        Me.Controls.Add(Me.LabelRok)
        Me.Controls.Add(Me.TextBoxNaručeno)
        Me.Controls.Add(Me.LabelNaručeno)
        Me.Controls.Add(Me.ButtonPrikaži)
        Me.Controls.Add(Me.LabelID)
        Me.Controls.Add(Me.DataGridViewTabela)
        Me.Name = "FormPregledNarudžbi"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormPregledNarudžbi"
        CType(Me.DataGridViewTabela, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ButtonPrikaži As Button
    Friend WithEvents LabelID As Label
    Friend WithEvents DataGridViewTabela As DataGridView
    Friend WithEvents LabelNaručeno As Label
    Friend WithEvents TextBoxNaručeno As TextBox
    Friend WithEvents LabelRok As Label
    Friend WithEvents TextBoxRok As TextBox
    Friend WithEvents ComboBoxId As ComboBox
End Class
