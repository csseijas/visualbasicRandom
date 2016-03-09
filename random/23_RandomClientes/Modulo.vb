Module Modulo

    Structure struCliente  ' estructura que contiene los campos del fichero random
        Dim codCliente As Integer
        <VBFixedString(9)> Dim dniCliente As String
        <VBFixedString(50)> Dim nomCliente As String
        <VBFixedString(30)> Dim tlfCliente As String
    End Structure
    Public rutClie As String = "..\..\..\Datos\clientes.dat" 'ruta del fichero clientes
    Public ficClie As Integer = 0   'donde guardo freefile() del fichero cliented
    Public proviene As String    'donde guardo de que operacion proviene antes de pulsar aceptar.Para tras pulsar aceptar realizar la operacion pertinente
    Public indice As Integer = 0    ' donde guardo codigo del rexistro actual
    Public totalRexistros As Integer = 0  ' donde guardo el numero total de registros tanto sin borrar como borrados
    Public codPrevio As Integer = 1    'donde guardo el codigo del rexistro donde estaba antes de pulsar sobre cualquier operación
    Public Const rexLogico = 93    ' donde guardo longitud de cada registro en bytes del fichero random clientes
    

End Module
