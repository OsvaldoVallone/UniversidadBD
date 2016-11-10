Imports Oracle.DataAccess.Client
Public Class Coneccion
    Protected Conexion As New OracleConnection()
    Protected Comando As New OracleCommand()
    Protected Almacenamiento As New DataSet()
    Protected Fila As DataRow
    Protected Columna As DataColumn
    Protected Tabla As DataTable
    Sub New()
        Conexion.ConnectionString = "Data Source=localhost;" + "User Id=TPBD;" + "Password=balditofc42;"
    End Sub
    'COMANDOS
    Protected Sub InsertarSQL(Tabla As String)
        Dim Adaptador = New OracleDataAdapter("Select * From " & Tabla, Conexion)
        Almacenamiento.Tables.Clear()
        Adaptador.Fill(Almacenamiento, Tabla)
        Fila = Almacenamiento.Tables(Tabla).NewRow()
    End Sub
    Protected Sub CargarFilaSQL(Tabla As String, Columna As String, Combo As ComboBox)
        Dim Adaptador = New OracleDataAdapter("Select * From " & Tabla, Conexion)
        Almacenamiento.Tables.Clear()
        Adaptador.Fill(Almacenamiento, Tabla)
        Combo.DataSource = Almacenamiento.Tables(Tabla)
        Combo.DisplayMember = Columna
        Combo.ValueMember = "ID_" & Tabla
    End Sub
    Protected Sub ActualizarSQL(Tabla As String)
        Dim Adaptador = New OracleDataAdapter()
        Adaptador.InsertCommand = Comando
        Adaptador.Update(Almacenamiento, Tabla)
    End Sub
    Protected Sub Insert(Tabla As String)
        Almacenamiento.Tables(Tabla).Rows.Add(Fila)
        Comando.Connection = Conexion
    End Sub
End Class
