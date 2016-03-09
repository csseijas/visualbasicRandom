Public Class frmExportar
    Dim ficClieTemp As Integer = 0
    Dim rutClieTemp As String = "..\..\..\Datos\clientesTemp.dat"
    Dim ficClieText As Integer = 0
    Dim rutClieText As String = "..\..\..\Datos\clientesTxt.dat"

    Dim rexClie As struCliente

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click

        ordenar()
        pasarTxt()


    End Sub

    Private Sub ordenar()
        Dim ordenado As Boolean = False
        Dim nomClie1 As String
        Dim nomClie2 As String
        Dim codClie1 As Integer
        Dim codClie2 As Integer
        Dim nifClie1 As String
        Dim nifClie2 As String
        Dim tlfnClie1 As String
        Dim tlfnClie2 As String
        Dim pos As Integer = 0

        While ordenado = False
            ordenado = True
            ficClie = FreeFile()
            FileOpen(ficClie, rutClie, OpenMode.Random, OpenAccess.Read, , rexLogico)
            ficClieTemp = FreeFile()
            FileOpen(ficClieTemp, rutClieTemp, OpenMode.Random, OpenAccess.Write, , rexLogico)
            FileGet(ficClie, rexClie, 1)
            codClie1 = rexClie.codCliente
            nomClie1 = rexClie.nomCliente
            nifClie1 = rexClie.dniCliente
            tlfnClie1 = rexClie.tlfCliente

            While Not EOF(ficClie)
                pos = pos + 1
                FileGet(ficClie, rexClie)
                codClie2 = rexClie.codCliente
                nomClie2 = rexClie.nomCliente
                nifClie2 = rexClie.dniCliente
                tlfnClie2 = rexClie.tlfCliente
                If UCase(nomClie1) > UCase(nomClie2) Then
                    ordenado = False
                    rexClie.codCliente = pos
                    rexClie.dniCliente = nifClie2
                    rexClie.nomCliente = nomClie2
                    rexClie.tlfCliente = tlfnClie2
                    FilePut(ficClieTemp, rexClie, pos)
                Else
                    rexClie.codCliente = pos
                    rexClie.dniCliente = nifClie1
                    rexClie.nomCliente = nomClie1
                    rexClie.tlfCliente = tlfnClie1
                    FilePut(ficClieTemp, rexClie, pos)
                    codClie1 = codClie2
                    nomClie1 = nomClie2
                    nifClie1 = nifClie2
                    tlfnClie1 = tlfnClie2
                End If
            End While
            pos = pos + 1
            rexClie.codCliente = pos
            rexClie.dniCliente = nifClie1
            rexClie.nomCliente = nomClie1
            rexClie.tlfCliente = tlfnClie1
            FilePut(ficClieTemp, rexClie, pos)
            FileClose(ficClie)
            FileClose(ficClieTemp)
            Kill(rutClie)
            Rename(rutClieTemp, rutClie)
            pos = 0

        End While
        FileClose(ficClie)
        FileClose(ficClieTemp)


    End Sub

    Private Sub pasarTxt()
        ficClie = FreeFile()
        FileOpen(ficClie, rutClie, OpenMode.Random, OpenAccess.Read, , rexLogico)
        ficClieText = FreeFile()
        FileOpen(ficClieText, rutClieText, OpenMode.Output)
        While Not EOF(ficClie)
            FileGet(ficClie, rexClie)
            WriteLine(ficClieText, CStr(rexClie.codCliente), SPC(5), CStr(rexClie.dniCliente), SPC(5), CStr(rexClie.nomCliente), SPC(5), CStr(rexClie.tlfCliente))
        End While
        FileClose(ficClie)
        FileClose(ficClieText)

    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub
End Class