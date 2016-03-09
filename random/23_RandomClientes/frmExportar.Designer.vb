<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmExportar
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.rbAcendente = New System.Windows.Forms.RadioButton()
        Me.rbDescendente = New System.Windows.Forms.RadioButton()
        Me.rbTxt = New System.Windows.Forms.RadioButton()
        Me.rbCSV = New System.Windows.Forms.RadioButton()
        Me.pnlExportar = New System.Windows.Forms.Panel()
        Me.lblExportar = New System.Windows.Forms.Label()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.pnlExportar.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(61, 182)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(189, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Ordenar por nombre de cliente:"
        '
        'rbAcendente
        '
        Me.rbAcendente.AutoSize = True
        Me.rbAcendente.Checked = True
        Me.rbAcendente.Location = New System.Drawing.Point(82, 221)
        Me.rbAcendente.Name = "rbAcendente"
        Me.rbAcendente.Size = New System.Drawing.Size(82, 17)
        Me.rbAcendente.TabIndex = 1
        Me.rbAcendente.TabStop = True
        Me.rbAcendente.Text = "Ascendente"
        Me.rbAcendente.UseVisualStyleBackColor = True
        '
        'rbDescendente
        '
        Me.rbDescendente.AutoSize = True
        Me.rbDescendente.Location = New System.Drawing.Point(82, 261)
        Me.rbDescendente.Name = "rbDescendente"
        Me.rbDescendente.Size = New System.Drawing.Size(89, 17)
        Me.rbDescendente.TabIndex = 2
        Me.rbDescendente.Text = "Descendente"
        Me.rbDescendente.UseVisualStyleBackColor = True
        '
        'rbTxt
        '
        Me.rbTxt.AutoSize = True
        Me.rbTxt.Checked = True
        Me.rbTxt.Location = New System.Drawing.Point(34, 21)
        Me.rbTxt.Name = "rbTxt"
        Me.rbTxt.Size = New System.Drawing.Size(46, 17)
        Me.rbTxt.TabIndex = 3
        Me.rbTxt.TabStop = True
        Me.rbTxt.Text = "TXT"
        Me.rbTxt.UseVisualStyleBackColor = True
        '
        'rbCSV
        '
        Me.rbCSV.AutoSize = True
        Me.rbCSV.Location = New System.Drawing.Point(34, 59)
        Me.rbCSV.Name = "rbCSV"
        Me.rbCSV.Size = New System.Drawing.Size(46, 17)
        Me.rbCSV.TabIndex = 4
        Me.rbCSV.Text = "CSV"
        Me.rbCSV.UseVisualStyleBackColor = True
        '
        'pnlExportar
        '
        Me.pnlExportar.BackColor = System.Drawing.Color.Salmon
        Me.pnlExportar.Controls.Add(Me.rbTxt)
        Me.pnlExportar.Controls.Add(Me.rbCSV)
        Me.pnlExportar.Location = New System.Drawing.Point(47, 72)
        Me.pnlExportar.Name = "pnlExportar"
        Me.pnlExportar.Size = New System.Drawing.Size(164, 85)
        Me.pnlExportar.TabIndex = 5
        '
        'lblExportar
        '
        Me.lblExportar.AutoSize = True
        Me.lblExportar.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblExportar.Location = New System.Drawing.Point(64, 37)
        Me.lblExportar.Name = "lblExportar"
        Me.lblExportar.Size = New System.Drawing.Size(61, 13)
        Me.lblExportar.TabIndex = 6
        Me.lblExportar.Text = "Exportar:"
        '
        'btnAceptar
        '
        Me.btnAceptar.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAceptar.Location = New System.Drawing.Point(52, 324)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(159, 39)
        Me.btnAceptar.TabIndex = 7
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.Location = New System.Drawing.Point(234, 323)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(71, 39)
        Me.btnCancelar.TabIndex = 8
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'frmExportar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(336, 388)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.lblExportar)
        Me.Controls.Add(Me.pnlExportar)
        Me.Controls.Add(Me.rbDescendente)
        Me.Controls.Add(Me.rbAcendente)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmExportar"
        Me.Text = "frmExportar"
        Me.pnlExportar.ResumeLayout(False)
        Me.pnlExportar.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents rbAcendente As System.Windows.Forms.RadioButton
    Friend WithEvents rbDescendente As System.Windows.Forms.RadioButton
    Friend WithEvents rbTxt As System.Windows.Forms.RadioButton
    Friend WithEvents rbCSV As System.Windows.Forms.RadioButton
    Friend WithEvents pnlExportar As System.Windows.Forms.Panel
    Friend WithEvents lblExportar As System.Windows.Forms.Label
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
End Class
