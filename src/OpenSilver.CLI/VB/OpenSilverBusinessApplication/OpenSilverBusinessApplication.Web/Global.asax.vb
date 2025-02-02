﻿Imports System
Imports System.Web

Public Class OpenSilverBusinessApp
    Inherits System.Web.HttpApplication

    Sub Application_Start(sender As Object, e As EventArgs)

        Dim path As String = AppDomain.CurrentDomain.BaseDirectory
        AppDomain.CurrentDomain.SetData("DataDirectory", path)

    End Sub

    Sub Session_Start(sender As Object, e As EventArgs)
    End Sub

    Sub Application_BeginRequest(sender As Object, e As EventArgs)

        HttpContext.Current.Response.AddHeader("Access-Control-Allow-Origin", "https://localhost:54845")
        HttpContext.Current.Response.AddHeader("Access-Control-Allow-Credentials", "true")

        If HttpContext.Current.Request.HttpMethod = "OPTIONS" Then

            ' These headers are handling the "pre-flight" OPTIONS call sent by the browser
            With HttpContext.Current.Response
                .AddHeader("Access-Control-Allow-Methods", "GET, POST, PUT, DELETE")
                .AddHeader("Access-Control-Allow-Headers", "Content-Type, Accept, SOAPAction")
                .AddHeader("Access-Control-Max-Age", "1728000")
                .End()
            End With

        End If

    End Sub

    Sub Application_AuthenticateRequest(sender As Object, e As EventArgs)
    End Sub

    Sub Application_Error(sender As Object, e As EventArgs)
    End Sub

    Sub Session_End(sender As Object, e As EventArgs)
    End Sub

    Sub Application_End(sender As Object, e As EventArgs)
    End Sub

End Class