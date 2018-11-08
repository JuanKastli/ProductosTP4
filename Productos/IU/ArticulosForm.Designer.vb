<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ArticulosForm
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.idLabel = New System.Windows.Forms.Label()
        Me.idTextBox = New System.Windows.Forms.TextBox()
        Me.DescLabel = New System.Windows.Forms.Label()
        Me.rubroLabel = New System.Windows.Forms.Label()
        Me.descTextBox = New System.Windows.Forms.TextBox()
        Me.rubroComboBox = New System.Windows.Forms.ComboBox()
        Me.CancelarButton = New System.Windows.Forms.Button()
        Me.AceptarButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'idLabel
        '
        Me.idLabel.AutoSize = True
        Me.idLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.idLabel.Location = New System.Drawing.Point(70, 65)
        Me.idLabel.Name = "idLabel"
        Me.idLabel.Size = New System.Drawing.Size(23, 18)
        Me.idLabel.TabIndex = 0
        Me.idLabel.Text = "Id:"
        '
        'idTextBox
        '
        Me.idTextBox.Enabled = False
        Me.idTextBox.Location = New System.Drawing.Point(99, 66)
        Me.idTextBox.Name = "idTextBox"
        Me.idTextBox.Size = New System.Drawing.Size(107, 20)
        Me.idTextBox.TabIndex = 1
        '
        'DescLabel
        '
        Me.DescLabel.AutoSize = True
        Me.DescLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DescLabel.Location = New System.Drawing.Point(2, 92)
        Me.DescLabel.Name = "DescLabel"
        Me.DescLabel.Size = New System.Drawing.Size(91, 18)
        Me.DescLabel.TabIndex = 2
        Me.DescLabel.Text = "Descripcion:"
        '
        'rubroLabel
        '
        Me.rubroLabel.AutoSize = True
        Me.rubroLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rubroLabel.Location = New System.Drawing.Point(40, 119)
        Me.rubroLabel.Name = "rubroLabel"
        Me.rubroLabel.Size = New System.Drawing.Size(53, 18)
        Me.rubroLabel.TabIndex = 3
        Me.rubroLabel.Text = "Rubro:"
        '
        'descTextBox
        '
        Me.descTextBox.Location = New System.Drawing.Point(99, 93)
        Me.descTextBox.Name = "descTextBox"
        Me.descTextBox.Size = New System.Drawing.Size(258, 20)
        Me.descTextBox.TabIndex = 4
        '
        'rubroComboBox
        '
        Me.rubroComboBox.FormattingEnabled = True
        Me.rubroComboBox.Location = New System.Drawing.Point(99, 120)
        Me.rubroComboBox.Name = "rubroComboBox"
        Me.rubroComboBox.Size = New System.Drawing.Size(258, 21)
        Me.rubroComboBox.TabIndex = 5
        '
        'CancelarButton
        '
        Me.CancelarButton.Location = New System.Drawing.Point(282, 159)
        Me.CancelarButton.Name = "CancelarButton"
        Me.CancelarButton.Size = New System.Drawing.Size(75, 23)
        Me.CancelarButton.TabIndex = 6
        Me.CancelarButton.Text = "Cancelar"
        Me.CancelarButton.UseVisualStyleBackColor = True
        '
        'AceptarButton
        '
        Me.AceptarButton.Location = New System.Drawing.Point(201, 159)
        Me.AceptarButton.Name = "AceptarButton"
        Me.AceptarButton.Size = New System.Drawing.Size(75, 23)
        Me.AceptarButton.TabIndex = 7
        Me.AceptarButton.Text = "Aceptar"
        Me.AceptarButton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(109, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 19)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Label1"
        '
        'ArticulosForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ClientSize = New System.Drawing.Size(369, 199)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.AceptarButton)
        Me.Controls.Add(Me.CancelarButton)
        Me.Controls.Add(Me.rubroComboBox)
        Me.Controls.Add(Me.descTextBox)
        Me.Controls.Add(Me.rubroLabel)
        Me.Controls.Add(Me.DescLabel)
        Me.Controls.Add(Me.idTextBox)
        Me.Controls.Add(Me.idLabel)
        Me.Name = "ArticulosForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ArticulosForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents idLabel As Label
    Friend WithEvents idTextBox As TextBox
    Friend WithEvents DescLabel As Label
    Friend WithEvents rubroLabel As Label
    Friend WithEvents descTextBox As TextBox
    Friend WithEvents rubroComboBox As ComboBox
    Friend WithEvents CancelarButton As Button
    Friend WithEvents AceptarButton As Button
    Friend WithEvents Label1 As Label
End Class
