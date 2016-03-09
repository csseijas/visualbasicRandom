Public Class frm_ClientesAleatorio
    Dim rexClie As struCliente 'structura campos fichero random
    'Compruebo si existe el fichero(sino cierro app) y si tiene algun registro
    Private Sub frm_ClientesAleatorio_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If System.IO.File.Exists(rutClie) = False Then
            MsgBox("El fichero de clientes no existe.", vbCritical, "Error")
            Me.Close()
        ElseIf FileLen(rutClie) = 0 Then
            noRegistros()
        ElseIf RexistrosSinBorrar() = 0 Then
            noRegistros()
        Else
            modoLectura()
            primerRegistro()
        End If
    End Sub
    'Como visualizo la applicacion cuando esta no tiene ningún registro o estan todos borrados
    Private Sub noRegistros()
        txtCódigo.Enabled = False
        txtNIF.Enabled = False
        txtNome.Enabled = False
        txtTelefono.Enabled = False
        txtCódigo.Text = ""
        txtNIF.Text = ""
        txtNome.Text = ""
        txtTelefono.Text = ""
        btnPrimeiro.Enabled = False
        btnAnterior.Enabled = False
        btnUltimo.Enabled = False
        btnSiguiente.Enabled = False
        btnNovo.Enabled = True
        btnBuscar.Enabled = False
        btnBorrar.Enabled = False
        btnEditar.Enabled = False
        btnAceptar.Enabled = False
        btnCancelar.Enabled = False
        Lblrexistros.Text = "Rexistro 0 de 0"
    End Sub
    'como visualizo los registros cuando están en modo lectura
    Private Sub modoLectura()
        If RexistrosSinBorrar() < 2 Then
            btnUltimo.Enabled = False
            btnSiguiente.Enabled = False
            btnPrimeiro.Enabled = False
            btnAnterior.Enabled = False
        Else
            btnUltimo.Enabled = True
            btnSiguiente.Enabled = True
            btnPrimeiro.Enabled = True
            btnAnterior.Enabled = True
        End If
        If RexistrosSinBorrar() < 1 Then
            btnNovo.Enabled = True
            btnBuscar.Enabled = False
            btnBorrar.Enabled = False
            btnEditar.Enabled = False
        Else
            btnNovo.Enabled = True
            btnBuscar.Enabled = True
            btnBorrar.Enabled = True
            btnEditar.Enabled = True
        End If
        btnAceptar.Enabled = False
        btnCancelar.Enabled = False
        txtCódigo.Enabled = False
        txtNIF.Enabled = False
        txtNome.Enabled = False
        txtTelefono.Enabled = False
    End Sub
    'acciones que hago despues de nuevo registro, editar o buscar. Visualizo y guardo indice => código del rexistro que visualizo ahora
    Private Sub VistaRegistros(ByVal proviene As String)
        Dim posicion As Integer = 0
        modoLectura()
        Select Case proviene
            Case "Novo"
                ficClie = FreeFile()
                FileOpen(ficClie, rutClie, OpenMode.Random, OpenAccess.Read, OpenShare.Default, rexLogico)
                FileGet(ficClie, rexClie, CInt(txtCódigo.Text))
                FileClose(ficClie)
                txtCódigo.Text = rexClie.codCliente
                txtNIF.Text = rexClie.dniCliente
                txtNome.Text = rexClie.nomCliente
                txtTelefono.Text = rexClie.tlfCliente
                indice = txtCódigo.Text
                btnUltimo.Enabled = False
                btnSiguiente.Enabled = False
                Lblrexistros.Text = "Rexistro " + CStr(RexistrosSinBorrar()) + " de " + CStr(RexistrosSinBorrar()) + "."
            Case "Buscar"
                Lblrexistros.Text = "Rexistro " + CStr(RexistroActual(txtCódigo.Text)) + " de " + CStr(RexistrosSinBorrar()) + "."
                indice = txtCódigo.Text
            Case "Editar"
                Lblrexistros.Text = "Rexistro " + CStr(RexistroActual(txtCódigo.Text)) + " de " + CStr(RexistrosSinBorrar()) + "."
                indice = txtCódigo.Text
        End Select
        If RexistrosSinBorrar() >= 1 Then
            If CInt(txtCódigo.Text) = codUltimoRex() Then
                btnSiguiente.Enabled = False
                btnUltimo.Enabled = False
            Else
                btnSiguiente.Enabled = True
                btnUltimo.Enabled = True
            End If
            If CInt(txtCódigo.Text) = CodprimerRex() Then
                btnPrimeiro.Enabled = False
                btnAnterior.Enabled = False
            Else
                btnPrimeiro.Enabled = True
                btnAnterior.Enabled = True
            End If
        End If
    End Sub
    'Controla el modo en que visualizo la app cuando pulso sobre buscar, nuevo o editar
    Private Sub deshabilitar(ByVal proviene As String)
        If RexistrosSinBorrar() <> 0 Then
            codPrevio = txtCódigo.Text
        End If
        Select Case proviene
            Case "Novo"
                txtCódigo.Enabled = False
                txtNIF.Enabled = True
                txtNome.Enabled = True
                txtTelefono.Enabled = True
                txtCódigo.Text = ""
                txtNIF.Text = ""
                txtNome.Text = ""
                txtTelefono.Text = ""
            Case "Buscar"
                txtCódigo.Enabled = True
                txtNIF.Enabled = False
                txtNome.Enabled = False
                txtTelefono.Enabled = False
                txtCódigo.Text = ""
                txtNIF.Text = ""
                txtNome.Text = ""
                txtTelefono.Text = ""
            Case "Editar"
                txtCódigo.Enabled = False
                txtNIF.Enabled = True
                txtNome.Enabled = True
                txtTelefono.Enabled = True
                txtNIF.SelectAll()
                txtNIF.Focus()
        End Select
        Lblrexistros.Text = ""
        btnPrimeiro.Enabled = False
        btnAnterior.Enabled = False
        btnUltimo.Enabled = False
        btnSiguiente.Enabled = False
        btnNovo.Enabled = False
        btnBuscar.Enabled = False
        btnBorrar.Enabled = False
        btnEditar.Enabled = False
        btnAceptar.Enabled = True
        btnCancelar.Enabled = True
    End Sub
    'Llamo a la funcion aceptar pasando como parámetro que boton he pulsado antes de aceptar para conocer que accion voy a realizar sobre los registros
    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        aceptar(proviene)
    End Sub
    'acciones a realizar sobre los registros
    Private Sub aceptar(ByVal proviene As String)
        Select Case proviene
            Case "Novo"
                If txtNIF.Text = "" Then
                    MsgBox("Debes completar el campo NIF.", vbExclamation, "error")
                    txtNIF.Focus()
                ElseIf txtNome.Text = "" Then
                    MsgBox("Debes completar el campo Nombre.", vbExclamation, "error")
                    txtNome.Focus()
                ElseIf validarDNI() = False Then
                    MsgBox("NIF incorrecto.", vbExclamation, "Error")
                Else
                    totalRexistros = FileLen(rutClie) \ rexLogico
                    totalRexistros = totalRexistros + 1
                    rexClie.codCliente = txtCódigo.Text
                    rexClie.dniCliente = txtNIF.Text
                    rexClie.nomCliente = txtNome.Text
                    rexClie.tlfCliente = txtTelefono.Text
                    ficClie = FreeFile()
                    FileOpen(ficClie, rutClie, OpenMode.Random, OpenAccess.Write, OpenShare.Default, rexLogico)
                    FilePut(ficClie, rexClie, totalRexistros)
                    FileClose(ficClie)
                    VistaRegistros("Novo")
                End If
            Case "Buscar"
                totalRexistros = FileLen(rutClie) \ rexLogico
                If Not IsNumeric(txtCódigo.Text) Then
                    MsgBox("Introduce un nº.", vbExclamation, "No encontrado")
                    txtCódigo.SelectAll()
                    txtCódigo.Focus()
                ElseIf CInt(txtCódigo.Text) < 1 Or CInt(txtCódigo.Text) > 9999 Then
                    MsgBox("Introduce un nº entre 1 y 9999.", vbExclamation, "No encontrado")
                    txtCódigo.SelectAll()
                    txtCódigo.Focus()
                ElseIf txtCódigo.Text > totalRexistros Then
                    MsgBox("Ese cliente no existe", vbExclamation, "No encontrado")
                    txtCódigo.SelectAll()
                    txtCódigo.Focus()
                ElseIf encontrado() = False Then
                    MsgBox("Ese cliente no existe", vbExclamation, "No encontrado")
                    txtCódigo.SelectAll()
                    txtCódigo.Focus()
                Else
                    ficClie = FreeFile()
                    FileOpen(ficClie, rutClie, OpenMode.Random, OpenAccess.Read, OpenShare.Default, rexLogico)
                    FileGet(ficClie, rexClie, txtCódigo.Text)
                    FileClose(ficClie)
                    txtCódigo.Text = rexClie.codCliente
                    txtNIF.Text = rexClie.dniCliente
                    txtNome.Text = rexClie.nomCliente
                    txtTelefono.Text = rexClie.tlfCliente
                    VistaRegistros("Buscar")
                End If
            Case "Editar"
                If txtNIF.Text = "" Then
                    MsgBox("Debes completar el campo NIF.", vbExclamation, "error")
                    txtNIF.Focus()
                ElseIf Trim(txtNome.Text) = "" Then
                    MsgBox("Debes completar el campo Nombre.", vbExclamation, "error")
                    txtNome.Focus()
                ElseIf validarDNI() = False Then
                    MsgBox("NIF incorrecto.", vbExclamation, "Error")
                Else                    rexClie.codCliente = txtCódigo.Text
                    rexClie.dniCliente = txtNIF.Text
                    rexClie.nomCliente = txtNome.Text
                    rexClie.tlfCliente = txtTelefono.Text
                    ficClie = FreeFile()
                    FileOpen(ficClie, rutClie, OpenMode.Random, OpenAccess.Write, OpenShare.Default, rexLogico)
                    FilePut(ficClie, rexClie, CInt(txtCódigo.Text))
                    FileClose(ficClie)
                    VistaRegistros("Editar")
                End If
        End Select
    End Sub
    'devuelve la posicion que ocupa el registro dentro de todos los que no se han borrado
    Private Function RexistroActual(ByVal codigo As Integer) As Integer
        Dim numero As Integer = 0
        ficClie = FreeFile()
        FileOpen(ficClie, rutClie, OpenMode.Random, OpenAccess.Read, OpenShare.Default, rexLogico)
        While Not EOF(ficClie)
            FileGet(ficClie, rexClie)
            If Not rexClie.codCliente = 0 Then
                numero = numero + 1
                If codigo = rexClie.codCliente Then
                    Exit While
                End If
            End If
        End While
        FileClose(ficClie)
        Return numero
    End Function
    'devuelve si el registro a buscar exite y por tanto no ha sido borrado
    Private Function encontrado() As Boolean
        Dim found As Boolean = False
        ficClie = FreeFile()
        FileOpen(ficClie, rutClie, OpenMode.Random, OpenAccess.Read, OpenShare.Default, rexLogico)
        FileGet(ficClie, rexClie, txtCódigo.Text)
        FileClose(ficClie)
        If Not rexClie.codCliente = 0 Then
            found = True
        Else
            found = False
        End If
        Return found
    End Function
    'devuelve el total de rexistros sin borrar
    Private Function RexistrosSinBorrar() As Integer
        RexistrosSinBorrar = 0
        ficClie = FreeFile()
        FileOpen(ficClie, rutClie, OpenMode.Random, OpenAccess.Read, OpenShare.Default, rexLogico)
        While Not EOF(ficClie)
            FileGet(ficClie, rexClie)
            If Not rexClie.codCliente = 0 Then
                RexistrosSinBorrar = RexistrosSinBorrar + 1
            End If
        End While
        FileClose(ficClie)
        Return RexistrosSinBorrar
    End Function
    'devuelve el codigo del ultimo rexistro sin borrar
    Private Function codUltimoRex() As Integer
        Dim CodClient As Integer = 0
        ficClie = FreeFile()
        FileOpen(ficClie, rutClie, OpenMode.Random, OpenAccess.Read, OpenShare.Default, rexLogico)
        Do While Not EOF(ficClie)
            FileGet(ficClie, rexClie)
            If Not rexClie.codCliente = 0 Then
                CodClient = rexClie.codCliente
            End If
        Loop
        FileClose(ficClie)
        Return CodClient
    End Function
    'devuelve el codigo del primer rexistro sin borrar
    Private Function CodprimerRex() As Integer
        Dim CodClient As Integer = 0
        ficClie = FreeFile()
        FileOpen(ficClie, rutClie, OpenMode.Random, OpenAccess.Read, OpenShare.Default, rexLogico)
        Do While Not EOF(ficClie)
            FileGet(ficClie, rexClie)
            If Not rexClie.codCliente = 0 Then
                CodClient = rexClie.codCliente
                Exit Do
            End If
        Loop
        FileClose(ficClie)
        Return CodClient
    End Function
    'Cuando pulso buscar no hago nada hasta pulsar aceptar, al cual le paso proviene y dependiendo de su valor realiza una accion u otra
    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        deshabilitar("Buscar")
        proviene = "Buscar"
    End Sub
    'Cuando pulso nuevo
    Private Sub btnNovo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNovo.Click
        totalRexistros = FileLen(rutClie) \ rexLogico
        Dim codClie As Integer = 0
        deshabilitar("Novo")
        proviene = "Novo"
        txtCódigo.Text = totalRexistros + 1
        txtNIF.Focus()
    End Sub
    'Cuando pulso borrar, borro el registro y visualizo registro posterior si existe o anterior si existe o rexistro 0 de 0
    Private Sub btnBorrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBorrar.Click
        deshabilitar("Borrar")
        proviene = "Borrar"
        If MsgBox("¿Desea borrar este registro?", vbYesNo, "Borrar") = vbYes Then
            ficClie = FreeFile()
            FileOpen(ficClie, rutClie, OpenMode.Random, OpenAccess.Write, OpenShare.Default, rexLogico)            rexClie.codCliente = 0
            rexClie.dniCliente = ""
            rexClie.nomCliente = ""
            rexClie.tlfCliente = ""
            FilePut(ficClie, rexClie, CInt(txtCódigo.Text))
            FileClose(ficClie)
            Dim codClienteAMostrar As Integer = 0
            Dim encontradoB As Boolean = False
            Dim indiceB As Integer = 0
            Dim indiceE As Integer = 0
            ficClie = FreeFile()
            FileOpen(ficClie, rutClie, OpenMode.Random, OpenAccess.Read, OpenShare.Default, rexLogico)
            While Not EOF(ficClie)
                FileGet(ficClie, rexClie)
                indiceB = indiceB + 1
                If Not rexClie.codCliente = 0 And rexClie.codCliente < CInt(txtCódigo.Text) Then
                    codClienteAMostrar = rexClie.codCliente
                    indiceE = indiceB
                ElseIf Not rexClie.codCliente = 0 And rexClie.codCliente > CInt(txtCódigo.Text) Then
                    codClienteAMostrar = rexClie.codCliente
                    indiceE = indiceB
                    encontradoB = True
                    Exit While
                End If
            End While
            FileClose(ficClie)
            If codClienteAMostrar = 0 Then
                noRegistros()
            Else
                ficClie = FreeFile()
                FileOpen(ficClie, rutClie, OpenMode.Random, OpenAccess.Read, OpenShare.Default, rexLogico)
                FileGet(ficClie, rexClie, indiceE)
                FileClose(ficClie)
                txtCódigo.Text = rexClie.codCliente
                txtNIF.Text = rexClie.dniCliente
                txtNome.Text = rexClie.nomCliente
                txtTelefono.Text = rexClie.tlfCliente
                indice = codClienteAMostrar
                Lblrexistros.Text = "Rexistro " + CStr(RexistroActual(txtCódigo.Text)) + " de " + CStr(RexistrosSinBorrar()) + "."
            End If
        End If
        VistaRegistros("Borrar")
    End Sub
    'Cuando pulso editar no hago nada hasta pulsar aceptar, al cual le paso proviene y dependiendo de su valor realiza una accion u otra
    Private Sub btnEditar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditar.Click
        deshabilitar("Editar")
        proviene = "Editar"
    End Sub
    'Cuando pulso cancelar visualizo el registro donde me encontraba antes de pulsar cualquier operacion (guardé el codigo en codPrevio al pulsar sobre cualquier boton de operacion en la llamada a deshabilitar modo lectura)
    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        If RexistrosSinBorrar() <> 0 Then
            ficClie = FreeFile()
            FileOpen(ficClie, rutClie, OpenMode.Random, OpenAccess.Read, OpenShare.Default, rexLogico)
            FileGet(ficClie, rexClie, codPrevio)
            FileClose(ficClie)
            txtCódigo.Text = rexClie.codCliente
            txtNIF.Text = rexClie.dniCliente
            txtNome.Text = rexClie.nomCliente
            txtTelefono.Text = rexClie.tlfCliente
            Lblrexistros.Text = "Rexistro " + CStr(RexistroActual(codPrevio)) + " de " + CStr(RexistrosSinBorrar()) + " ."
            VistaRegistros("Cancelar")
        Else
            noRegistros()
        End If
    End Sub
    'cuando lo pulso visualizo primer registro sin borrar
    Private Sub btnPrimeiro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrimeiro.Click
        primerRegistro()
    End Sub
    Private Sub primerRegistro()
        indice = CodprimerRex()
        ficClie = FreeFile()
        FileOpen(ficClie, rutClie, OpenMode.Random, OpenAccess.Read, OpenShare.Default, rexLogico)
        FileGet(ficClie, rexClie, indice)
        FileClose(ficClie)
        txtCódigo.Text = rexClie.codCliente
        txtNIF.Text = rexClie.dniCliente
        txtNome.Text = rexClie.nomCliente
        txtTelefono.Text = rexClie.tlfCliente
        Lblrexistros.Text = "Rexistro " + CStr(RexistroActual(CInt(txtCódigo.Text))) + " de " + CStr(RexistrosSinBorrar()) + "."
        btnPrimeiro.Enabled = False
        btnAnterior.Enabled = False
        If RexistrosSinBorrar() < 2 Then
            btnSiguiente.Enabled = False
            btnUltimo.Enabled = False
        Else
            btnSiguiente.Enabled = True
            btnUltimo.Enabled = True
        End If
    End Sub
    'visualizo registro anterior sin borrar si existe
    Private Sub btnAnterior_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAnterior.Click
        If indice > CodprimerRex() Then
            indice = indice - 1
            Dim anterior As Boolean = False
            ficClie = FreeFile()
            FileOpen(ficClie, rutClie, OpenMode.Random, OpenAccess.Read, OpenShare.Default, rexLogico)
            Do
                FileGet(ficClie, rexClie, indice)
                If Not rexClie.codCliente = 0 Then
                    txtCódigo.Text = rexClie.codCliente
                    txtNIF.Text = rexClie.dniCliente
                    txtNome.Text = rexClie.nomCliente
                    txtTelefono.Text = rexClie.tlfCliente
                    anterior = True
                Else
                    indice = indice - 1
                End If
            Loop While (anterior = False)
            FileClose(ficClie)
            btnUltimo.Enabled = True
            btnSiguiente.Enabled = True
            Lblrexistros.Text = "Rexistro " + CStr(RexistroActual(CInt(txtCódigo.Text))) + " de " + CStr(RexistrosSinBorrar()) + "."
        Else
            btnPrimeiro.Enabled = False
            btnAnterior.Enabled = False
        End If
    End Sub
    'visualizo rexistro posterior sin borrar si existe
    Private Sub btnSiguiente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSiguiente.Click
        If indice < codUltimoRex() Then
            indice = indice + 1
            Dim siguiente As Boolean = False
            ficClie = FreeFile()
            FileOpen(ficClie, rutClie, OpenMode.Random, OpenAccess.Read, OpenShare.Default, rexLogico)
            Do
                FileGet(ficClie, rexClie, indice)
                If Not rexClie.codCliente = 0 Then
                    txtCódigo.Text = rexClie.codCliente
                    txtNIF.Text = rexClie.dniCliente
                    txtNome.Text = rexClie.nomCliente
                    txtTelefono.Text = rexClie.tlfCliente
                    siguiente = True
                Else
                    indice = indice + 1
                End If
            Loop While (siguiente = False)
            FileClose(ficClie)
            btnPrimeiro.Enabled = True
            btnAnterior.Enabled = True
            Lblrexistros.Text = "Rexistro " + CStr(RexistroActual(CInt(txtCódigo.Text))) + " de " + CStr(RexistrosSinBorrar()) + "."
        Else
            btnUltimo.Enabled = False
            btnSiguiente.Enabled = False
        End If

    End Sub
    'visualizo ultimo rexistro sin borrar
    Private Sub btnUltimo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUltimo.Click
        indice = codUltimoRex()
        ficClie = FreeFile()
        FileOpen(ficClie, rutClie, OpenMode.Random, OpenAccess.Read, OpenShare.Default, rexLogico)
        FileGet(ficClie, rexClie, indice)
        FileClose(ficClie)
        txtCódigo.Text = rexClie.codCliente
        txtNIF.Text = rexClie.dniCliente
        txtNome.Text = rexClie.nomCliente
        txtTelefono.Text = rexClie.tlfCliente
        Lblrexistros.Text = "Rexistro " + CStr(RexistrosSinBorrar()) + " de " + CStr(RexistrosSinBorrar()) + "."
        btnUltimo.Enabled = False
        btnSiguiente.Enabled = False
        If RexistrosSinBorrar() < 2 Then
            btnPrimeiro.Enabled = False
            btnAnterior.Enabled = False
        Else
            btnPrimeiro.Enabled = True
            btnAnterior.Enabled = True
        End If
    End Sub
    'Control sobre nombre.En nombre solo podrá introducir letras y espacios
    Private Sub txtNome_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNome.KeyPress
        If InStr("qwertyuiopñlkjhgfdsazxcvbnmMNBVCXZASDFGHJKLÑPOIUYTREWQúíóáéüÉÍÓÚÁ " & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = Chr(0)
        End If
    End Sub
    'Control sobre nif.8 numeros y 1 letra al final
    Private Sub txtNIF_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNIF.KeyPress
        Dim letras As String
        letras = "trwagmyfpdxbnjzsqvhlckeTRWAGMYFPDXBNJZSQVHLCKE"
        If Len(txtNIF.Text) < 8 Then
            If InStr("0123456789" & Chr(8), e.KeyChar) = 0 Then
                e.KeyChar = Chr(0)
            End If
        Else
            If Len(txtNIF.Text) < 9 Then
                If InStr(letras & Chr(8), e.KeyChar) = 0 Then
                    e.KeyChar = Chr(0)
                End If
            End If
        End If
    End Sub
    'Devuelve true si Dni es correcto
    Private Function validarDNI() As Boolean
        Dim letras As String
        Dim letra As String
        Dim letra2 As String
        Dim pos As Integer
        letras = "TRWAGMYFPDXBNJZSQVHLCKE"
        pos = Mid(txtNIF.Text, 1, 8) Mod 23
        letra = Mid(letras, pos + 1, 1)
        letra2 = Mid(txtNIF.Text, 9, 1)
        If UCase(letra) = UCase(letra2) Then
            Return True
        Else
            Return False
        End If
        txtNIF.SelectAll()
        txtNIF.Focus()
    End Function

End Class
