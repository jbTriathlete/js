Imports System
Imports System.Web

Imports System.Data
Imports System.Data.SqlClient

Namespace db


    Public Class cls_dba
        Public ds As New DataSet
        Public z_index As Integer

        Public Function getDataset(ByVal inSql As String) As Boolean
            Dim pgConnection As SqlConnection = New SqlConnection
            Dim pgCommand As SqlCommand = New SqlCommand
            Dim pgConnectionString As String
            Dim sda As SqlDataAdapter

            ds = New DataSet

            pgConnectionString = "Server=localhost;Port=5432;Userid=sa;Database=pw;password=alamo;Protocol=3;SSL=false;Pooling=true;MinPoolSize=1;MaxPoolSize=20;Encoding=UNICODE;Timeout=15;SslMode=Disable"
            pgConnection.ConnectionString = pgConnectionString
            pgConnection.Open()
            pgCommand.Connection = pgConnection
            pgCommand.CommandType = CommandType.Text

            pgCommand.CommandText = inSql

            sda = New SqlDataAdapter(pgCommand)
            sda.Fill(ds)

            If pgConnection.State = ConnectionState.Open Then
                pgConnection.Close()

                Return True
            Else
                Return False
                'context.Response.Write("pgConnection did not open successfully.")
            End If



        End Function

        Public Function Add() As Boolean
            ' ds.Tables(0).NewRow()
            ds.Tables(0).Rows.Add(ds.Tables(0).NewRow())
            z_index = ds.Tables(0).Rows.Count() - 1



        End Function

        Public Function Save() As Boolean



            Return True
        End Function
    End Class


End Namespace