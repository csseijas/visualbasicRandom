<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_ClientesAleatorio
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
        Me.PnConfirmacion = New System.Windows.Forms.Panel()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.PnOperacion = New System.Windows.Forms.Panel()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.btnBorrar = New System.Windows.Forms.Button()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.btnNovo = New System.Windows.Forms.Button()
        Me.lblNIF = New System.Windows.Forms.Label()
        Me.lblTelefono = New System.Windows.Forms.Label()
        Me.btnUltimo = New System.Windows.Forms.Button()
        Me.btnSiguiente = New System.Windows.Forms.Button()
        Me.btnAnterior = New System.Windows.Forms.Button()
        Me.btnPrimeiro = New System.Windows.Forms.Button()
        Me.txtCódigo = New System.Windows.Forms.TextBox()
        Me.lblCodigo = New System.Windows.Forms.Label()
        Me.lblNome = New System.Windows.Forms.Label()
        Me.txtNIF = New System.Windows.Forms.TextBox()
        Me.txtNome = New System.Windows.Forms.TextBox()
        Me.txtTelefono = New System.Windows.Forms.TextBox()
        Me.Lblrexistros = New System.Windows.Forms.Label()
        Me.PnConfirmacion.SuspendLayout()
        Me.PnOperacion.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(456, 268)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 12)
        Me.Label1.TabIndex = 51
        Me.Label1.Text = "Confirmación"
        '
        'PnConfirmacion
        '
        Me.PnConfirmacion.BackColor = System.Drawing.Color.BlanchedAlmond
        Me.PnConfirmacion.Controls.Add(Me.btnCancelar)
        Me.PnConfirmacion.Controls.Add(Me.btnAceptar)
        Me.PnConfirmacion.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PnConfirmacion.Location = New System.Drawing.Point(453, 275)
        Me.PnConfirmacion.Name = "PnConfirmacion"
        Me.PnConfirmacion.Size = New System.Drawing.Size(200, 88)
        Me.PnConfirmacion.TabIndex = 50
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(101, 21)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 51)
        Me.btnCancelar.TabIndex = 13
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(19, 21)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(75, 51)
        Me.btnAceptar.TabIndex = 12
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'PnOperacion
        '
        Me.PnOperacion.BackColor = System.Drawing.Color.BlanchedAlmond
        Me.PnOperacion.Controls.Add(Me.btnEditar)
        Me.PnOperacion.Controls.Add(Me.btnBorrar)
        Me.PnOperacion.Controls.Add(Me.btnBuscar)
        Me.PnOperacion.Controls.Add(Me.btnNovo)
        Me.PnOperacion.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PnOperacion.Location = New System.Drawing.Point(453, 33)
        Me.PnOperacion.Name = "PnOperacion"
        Me.PnOperacion.Size = New System.Drawing.Size(156, 213)
        Me.PnOperacion.TabIndex = 49
        '
        'btnEditar
        '
        Me.btnEditar.Location = New System.Drawing.Point(19, 128)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(120, 29)
        Me.btnEditar.TabIndex = 11
        Me.btnEditar.Text = "Editar"
        Me.btnEditar.UseVisualStyleBackColor = True
        '
        'btnBorrar
        '
        Me.btnBorrar.Location = New System.Drawing.Point(19, 89)
        Me.btnBorrar.Name = "btnBorrar"
        Me.btnBorrar.Size = New System.Drawing.Size(120, 30)
        Me.btnBorrar.TabIndex = 10
        Me.btnBorrar.Text = "Borrar"
        Me.btnBorrar.UseVisualStyleBackColor = True
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(19, 49)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(120, 32)
        Me.btnBuscar.TabIndex = 9
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'btnNovo
        '
        Me.btnNovo.Location = New System.Drawing.Point(19, 12)
        Me.btnNovo.Name = "btnNovo"
        Me.btnNovo.Size = New System.Drawing.Size(120, 31)
        Me.btnNovo.TabIndex = 8
        Me.btnNovo.Text = "Novo"
        Me.btnNovo.UseVisualStyleBackColor = True
        '
        'lblNIF
        '
        Me.lblNIF.AutoSize = True
        Me.lblNIF.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNIF.Location = New System.Drawing.Point(87, 122)
        Me.lblNIF.Name = "lblNIF"
        Me.lblNIF.Size = New System.Drawing.Size(24, 12)
        Me.lblNIF.TabIndex = 47
        Me.lblNIF.Text = "NIF"
        '
        'lblTelefono
        '
        Me.lblTelefono.AutoSize = True
        Me.lblTelefono.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTelefono.Location = New System.Drawing.Point(63, 192)
        Me.lblTelefono.Name = "lblTelefono"
        Me.lblTelefono.Size = New System.Drawing.Size(48, 12)
        Me.lblTelefono.TabIndex = 45
        Me.lblTelefono.Text = "Teléfono"
        '
        'btnUltimo
        '
        Me.btnUltimo.Location = New System.Drawing.Point(217, 312)
        Me.btnUltimo.Name = "btnUltimo"
        Me.btnUltimo.Size = New System.Drawing.Size(46, 35)
        Me.btnUltimo.TabIndex = 6
        Me.btnUltimo.Text = ">|"
        Me.btnUltimo.UseVisualStyleBackColor = True
        '
        'btnSiguiente
        '
        Me.btnSiguiente.Location = New System.Drawing.Point(165, 312)
        Me.btnSiguiente.Name = "btnSiguiente"
        Me.btnSiguiente.Size = New System.Drawing.Size(46, 35)
        Me.btnSiguiente.TabIndex = 4
        Me.btnSiguiente.Text = ">"
        Me.btnSiguiente.UseVisualStyleBackColor = True
        '
        'btnAnterior
        '
        Me.btnAnterior.Location = New System.Drawing.Point(113, 312)
        Me.btnAnterior.Name = "btnAnterior"
        Me.btnAnterior.Size = New System.Drawing.Size(46, 35)
        Me.btnAnterior.TabIndex = 5
        Me.btnAnterior.Text = "<"
        Me.btnAnterior.UseVisualStyleBackColor = True
        '
        'btnPrimeiro
        '
        Me.btnPrimeiro.Location = New System.Drawing.Point(61, 312)
        Me.btnPrimeiro.Name = "btnPrimeiro"
        Me.btnPrimeiro.Size = New System.Drawing.Size(46, 35)
        Me.btnPrimeiro.TabIndex = 7
        Me.btnPrimeiro.Text = "|<"
        Me.btnPrimeiro.UseVisualStyleBackColor = True
        '
        'txtCódigo
        '
        Me.txtCódigo.BackColor = System.Drawing.Color.White
        Me.txtCódigo.Enabled = False
        Me.txtCódigo.Location = New System.Drawing.Point(127, 78)
        Me.txtCódigo.MaxLength = 4
        Me.txtCódigo.Name = "txtCódigo"
        Me.txtCódigo.Size = New System.Drawing.Size(78, 20)
        Me.txtCódigo.TabIndex = 28
        Me.txtCódigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblCodigo
        '
        Me.lblCodigo.AutoSize = True
        Me.lblCodigo.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCodigo.Location = New System.Drawing.Point(34, 86)
        Me.lblCodigo.Name = "lblCodigo"
        Me.lblCodigo.Size = New System.Drawing.Size(77, 12)
        Me.lblCodigo.TabIndex = 48
        Me.lblCodigo.Text = "Código cliente"
        '
        'lblNome
        '
        Me.lblNome.AutoSize = True
        Me.lblNome.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNome.Location = New System.Drawing.Point(77, 157)
        Me.lblNome.Name = "lblNome"
        Me.lblNome.Size = New System.Drawing.Size(34, 12)
        Me.lblNome.TabIndex = 46
        Me.lblNome.Text = "Nome"
        '
        'txtNIF
        '
        Me.txtNIF.BackColor = System.Drawing.Color.White
        Me.txtNIF.Enabled = False
        Me.txtNIF.Location = New System.Drawing.Point(127, 114)
        Me.txtNIF.MaxLength = 9
        Me.txtNIF.Name = "txtNIF"
        Me.txtNIF.Size = New System.Drawing.Size(124, 20)
        Me.txtNIF.TabIndex = 1
        '
        'txtNome
        '
        Me.txtNome.BackColor = System.Drawing.Color.White
        Me.txtNome.Enabled = False
        Me.txtNome.Location = New System.Drawing.Point(127, 149)
        Me.txtNome.MaxLength = 50
        Me.txtNome.Name = "txtNome"
        Me.txtNome.Size = New System.Drawing.Size(235, 20)
        Me.txtNome.TabIndex = 2
        '
        'txtTelefono
        '
        Me.txtTelefono.BackColor = System.Drawing.Color.White
        Me.txtTelefono.Enabled = False
        Me.txtTelefono.Location = New System.Drawing.Point(127, 183)
        Me.txtTelefono.MaxLength = 30
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(191, 20)
        Me.txtTelefono.TabIndex = 3
        '
        'Lblrexistros
        '
        Me.Lblrexistros.AutoSize = True
        Me.Lblrexistros.Location = New System.Drawing.Point(284, 333)
        Me.Lblrexistros.Name = "Lblrexistros"
        Me.Lblrexistros.Size = New System.Drawing.Size(0, 13)
        Me.Lblrexistros.TabIndex = 53
        '
        'frm_ClientesAleatorio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(681, 415)
        Me.Controls.Add(Me.Lblrexistros)
        Me.Controls.Add(Me.txtTelefono)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PnConfirmacion)
        Me.Controls.Add(Me.PnOperacion)
        Me.Controls.Add(Me.lblCodigo)
        Me.Controls.Add(Me.lblNIF)
        Me.Controls.Add(Me.lblNome)
        Me.Controls.Add(Me.lblTelefono)
        Me.Controls.Add(Me.btnUltimo)
        Me.Controls.Add(Me.btnSiguiente)
        Me.Controls.Add(Me.btnAnterior)
        Me.Controls.Add(Me.btnPrimeiro)
        Me.Controls.Add(Me.txtNome)
        Me.Controls.Add(Me.txtNIF)
        Me.Controls.Add(Me.txtCódigo)
        Me.Name = "frm_ClientesAleatorio"
        Me.Text = "Clientes"
        Me.PnConfirmacion.ResumeLayout(False)
        Me.PnOperacion.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PnConfirmacion As System.Windows.Forms.Panel
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents PnOperacion As System.Windows.Forms.Panel
    Friend WithEvents btnEditar As System.Windows.Forms.Button
    Friend WithEvents btnBorrar As System.Windows.Forms.Button
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents btnNovo As System.Windows.Forms.Button
    Friend WithEvents lblNIF As System.Windows.Forms.Label
    Friend WithEvents lblTelefono As System.Windows.Forms.Label
    Friend WithEvents btnUltimo As System.Windows.Forms.Button
    Friend WithEvents btnSiguiente As System.Windows.Forms.Button
    Friend WithEvents btnAnterior As System.Windows.Forms.Button
    Friend WithEvents btnPrimeiro As System.Windows.Forms.Button
    Friend WithEvents txtCódigo As System.Windows.Forms.TextBox
    Friend WithEvents lblCodigo As System.Windows.Forms.Label
    Friend WithEvents lblNome As System.Windows.Forms.Label
    Friend WithEvents txtNIF As System.Windows.Forms.TextBox
    Friend WithEvents txtNome As System.Windows.Forms.TextBox
    Friend WithEvents txtTelefono As System.Windows.Forms.TextBox
    Friend WithEvents Lblrexistros As System.Windows.Forms.Label

End Class
