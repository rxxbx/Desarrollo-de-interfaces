Imports System.Diagnostics.Eventing.Reader
Imports Microsoft.Data.SqlClient


Public Class Form1
    Private Sub btnRegistrar_Click(sender As Object, e As EventArgs) Handles btnRegistrar.Click
        'Cadena de conexion
        Dim conexion As String
        conexion = "Data Source=REBE;Initial Catalog=Alumnos;Integrated Security=True;Trust Server Certificate=True"
        Dim cn As New SqlConnection
        cn.ConnectionString = conexion

        'Ingresar datos
        Dim adaptador As New SqlCommand("insert into Datos values(" & txtIdR.Text & ", '" & txtNombreR.Text & "','" & txtApellidosR.Text & "','" & txtEmailR.Text & "','" & txtTelefonoR.Text & "')", cn)
        cn.Open() 'abirmos la conexion
        adaptador.ExecuteNonQuery()
        MsgBox("Los datos se registraron correctamente")

        txtIdR.Clear()
        txtNombreR.Clear()
        txtApellidosR.Clear()
        txtEmailR.Clear()
        txtTelefonoR.Clear()
    End Sub

    Private Sub bntBuscarA_Click(sender As Object, e As EventArgs) Handles btnBuscarA.Click
        'cadena de conexion
        Dim conexion As String
        conexion = "Data Source=REBE;Initial Catalog=Alumnos;Integrated Security=True;Trust Server Certificate=True"
        Dim cn As New SqlConnection
        cn.ConnectionString = conexion

        'Recuperación de datos
        Dim adaptador As New SqlDataAdapter("select*from Datos where ID=" & txtIdA.Text & "", cn)
        Dim ds As New DataSet
        adaptador.Fill(ds, "datos")
        If ds.Tables("datos").Rows.Count > 0 Then
            txtNombreA.Text = ds.Tables("datos").Rows(0).Item(1).ToString
            txtApellidosA.Text = ds.Tables("datos").Rows(0).Item(2).ToString
            txtEmailA.Text = ds.Tables("datos").Rows(0).Item(3).ToString
            txtTelefonoA.Text = ds.Tables("datos").Rows(0).Item(4).ToString

        Else
            MsgBox("No existe el usuario")

        End If
    End Sub

    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        'Cadena de conexión
        Dim conexion As String
        conexion = "Data Source=REBE;Initial Catalog=Alumnos;Integrated Security=True;Trust Server Certificate=True"
        Dim cn As New SqlConnection
        cn.ConnectionString = conexion

        'Código que permite actualizar los datos
        Dim adaptador As New SqlCommand("update Datos set NOMBRE = '" & txtNombreA.Text & "', APELLIDOS = '" & txtApellidosA.Text & "', EMAIL = '" & txtEmailA.Text & "', TELEFONO = '" & txtTelefonoA.Text & "' where ID = " & txtIdA.Text & " ", cn)
        cn.Open()
        adaptador.ExecuteNonQuery()
        MsgBox("Los datos se actualizaron correctamente")

        txtIdA.Clear()
        txtNombreA.Clear()
        txtApellidosA.Clear()
        txtEmailA.Clear()
        txtTelefonoA.Clear()
    End Sub
    Private Sub btnBuscarE_Click(sender As Object, e As EventArgs) Handles btnBuscarE.Click
        ' Cadena de conexión
        Dim conexion As String
        conexion = "Data Source=REBE;Initial Catalog=Alumnos;Integrated Security=True;Trust Server Certificate=True"
        Dim cn As New SqlConnection
        cn.ConnectionString = conexion

        'Recuperación de datos

        Dim adaptador As New SqlDataAdapter("select*from Datos where ID=" & txtIdE.Text & "", cn)
        Dim ds As New DataSet
        adaptador.Fill(ds, "datos")
        If ds.Tables("datos").Rows.Count > 0 Then
            txtNombreE.Text = ds.Tables("datos").Rows(0).Item(1).ToString
            txtApellidosE.Text = ds.Tables("datos").Rows(0).Item(2).ToString
            txtEmailE.Text = ds.Tables("datos").Rows(0).Item(3).ToString
            txtTelefonoE.Text = ds.Tables("datos").Rows(0).Item(4).ToString

        Else
            MsgBox("No existe el usuario")

        End If
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        ' Cadena de conexión
        Dim conexion As String
        conexion = "Data Source=REBE;Initial Catalog=Alumnos;Integrated Security=True;Trust Server Certificate=True"
        Dim cn As New SqlConnection
        cn.ConnectionString = conexion

        cn.Open()
        ' Código para eliminar los registro con ese código
        Dim comando As New SqlCommand("delete from Datos where ID=" & txtIdE.Text & " ", cn)
        comando.ExecuteNonQuery()
        MsgBox("Se eliminó correctamente")
        cn.Close()

        txtIdE.Clear()
        txtNombreE.Clear()
        txtApellidosE.Clear()
        txtEmailE.Clear()
        txtTelefonoE.Clear()
    End Sub



    Private Sub btnActualizarD_Click(sender As Object, e As EventArgs) Handles btnActualizarD.Click
        ' Cadena de conexión
        Dim conexion As String
        conexion = "Data Source=REBE;Initial Catalog=Alumnos;Integrated Security=True;Trust Server Certificate=True"
        Dim cn As New SqlConnection
        cn.ConnectionString = conexion

        cn.Open()
        Dim sqll As String
        sqll = "select*from datos"
        Dim adapt As New Microsoft.Data.SqlClient.SqlDataAdapter(sqll, cn)

        Dim obtenerdatos As New DataSet
        adapt.Fill(obtenerdatos, "ID")
        DataGridView1.DataSource = obtenerdatos
        DataGridView1.DataMember = "ID"
        cn.Close()
    End Sub

End Class
