<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormProizvodi
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
        Me.ButtonDodaj = New System.Windows.Forms.Button()
        Me.ButtonUkloni = New System.Windows.Forms.Button()
        Me.DataGridViewTabela = New System.Windows.Forms.DataGridView()
        CType(Me.DataGridViewTabela, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtonDodaj
        '
        Me.ButtonDodaj.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.ButtonDodaj.Location = New System.Drawing.Point(12, 12)
        Me.ButtonDodaj.Name = "ButtonDodaj"
        Me.ButtonDodaj.Size = New System.Drawing.Size(150, 40)
        Me.ButtonDodaj.TabIndex = 0
        Me.ButtonDodaj.Text = "Dodaj"
        Me.ButtonDodaj.UseVisualStyleBackColor = True
        '
        'ButtonUkloni
        '
        Me.ButtonUkloni.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.ButtonUkloni.Location = New System.Drawing.Point(168, 12)
        Me.ButtonUkloni.Name = "ButtonUkloni"
        Me.ButtonUkloni.Size = New System.Drawing.Size(150, 40)
        Me.ButtonUkloni.TabIndex = 1
        Me.ButtonUkloni.Text = "Ukloni"
        Me.ButtonUkloni.UseVisualStyleBackColor = True
        '
        'DataGridViewTabela
        '
        Me.DataGridViewTabela.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewTabela.Location = New System.Drawing.Point(12, 58)
        Me.DataGridViewTabela.Name = "DataGridViewTabela"
        Me.DataGridViewTabela.Size = New System.Drawing.Size(666, 373)
        Me.DataGridViewTabela.TabIndex = 18
        '
        'FormProizvodi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(690, 443)
        Me.Controls.Add(Me.DataGridViewTabela)
        Me.Controls.Add(Me.ButtonUkloni)
        Me.Controls.Add(Me.ButtonDodaj)
        Me.Name = "FormProizvodi"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Proizvodi"
        CType(Me.DataGridViewTabela, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ButtonDodaj As Button
    Friend WithEvents ButtonUkloni As Button
    Friend WithEvents DataGridViewTabela As DataGridView
End Class
