Imports System.Data
Imports System.Data.SqlClient
Module CONEXION
    'mi casa
    Public cn As New SqlConnection("data source= USUARIO-54C687A;initial catalog=venta ; user id=;password=")
    Public cm As New SqlCommand
    'cabinas y otros
    'Public cn As New SqlConnection("data source=FAMILIA ;initial catalog=VENTA ; user id=;password=")
    'Public cm As New SqlCommand

End Module
