<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormZaposleni
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
        Me.ButtonUkloniZaposlenog = New System.Windows.Forms.Button()
        Me.ButtonDodajZaposlenog = New System.Windows.Forms.Button()
        Me.DataGridViewTabela = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        CType(Me.DataGridViewTabela, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtonUkloniZaposlenog
        '
        Me.ButtonUkloniZaposlenog.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonUkloniZaposlenog.Location = New System.Drawing.Point(170, 12)
        Me.ButtonUkloniZaposlenog.Name = "ButtonUkloniZaposlenog"
        Me.ButtonUkloniZaposlenog.Size = New System.Drawing.Size(150, 40)
        Me.ButtonUkloniZaposlenog.TabIndex = 23
        Me.ButtonUkloniZaposlenog.Text = "Ukloni zaposlenog"
        Me.ButtonUkloniZaposlenog.UseVisualStyleBackColor = True
        '
        'ButtonDodajZaposlenog
        '
        Me.ButtonDodajZaposlenog.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonDodajZaposlenog.Location = New System.Drawing.Point(14, 12)
        Me.ButtonDodajZaposlenog.Name = "ButtonDodajZaposlenog"
        Me.ButtonDodajZaposlenog.Size = New System.Drawing.Size(150, 40)
        Me.ButtonDodajZaposlenog.TabIndex = 22
        Me.ButtonDodajZaposlenog.Text = "Dodaj zaposlenog"
        Me.ButtonDodajZaposlenog.UseVisualStyleBackColor = True
        '
        'DataGridViewTabela
        '
        Me.DataGridViewTabela.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewTabela.Location = New System.Drawing.Point(12, 58)
        Me.DataGridViewTabela.Name = "DataGridViewTabela"
        Me.DataGridViewTabela.Size = New System.Drawing.Size(956, 379)
        Me.DataGridViewTabela.TabIndex = 17
        '
        'Button1
        '
        Me.Button1.Enabled = False
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(326, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(150, 40)
        Me.Button1.TabIndex = 24
        Me.Button1.Text = "Prodavnice"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Enabled = False
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(482, 12)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(150, 40)
        Me.Button2.TabIndex = 25
        Me.Button2.Text = "Skladišta"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Enabled = False
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(638, 12)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(150, 40)
        Me.Button3.TabIndex = 26
        Me.Button3.Text = "Administratori"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'FormZaposleni
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(984, 446)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ButtonUkloniZaposlenog)
        Me.Controls.Add(Me.ButtonDodajZaposlenog)
        Me.Controls.Add(Me.DataGridViewTabela)
        Me.Name = "FormZaposleni"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormZaposleni"
        CType(Me.DataGridViewTabela, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ButtonUkloniZaposlenog As Button
    Friend WithEvents ButtonDodajZaposlenog As Button
    Friend WithEvents DataGridViewTabela As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
End Class
