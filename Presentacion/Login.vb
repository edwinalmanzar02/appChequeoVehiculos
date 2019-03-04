Imports Datos
Imports Entidades

Public Class Login

    Dim fu As New fUsuario
    Dim eu As New Eusuario

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Application.Exit()
    End Sub

    Private Sub btnMinimizar_Click(sender As Object, e As EventArgs) Handles btnMinimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnacceder_Click(sender As Object, e As EventArgs) Handles btnacceder.Click
        Try
            If txtContrasena.Text <> "" And txtUsuario.Text <> "" Then
                Dim dt As New DataTable

                eu._Usuario = txtUsuario.Text
                eu._Contraseña = txtContrasena.Text
                dt = fu.validarusuario(eu)

                If dt.Rows.Count > 0 Then
                    MenuPrincipal.Show()
                    Me.Hide()


                    Dim nivel As String
                    nivel = dt.Rows(0)("Niveles")
                    If nivel = "Usuario" Then
                        My.Forms.MenuPrincipal.btnChofer.Enabled = False
                        My.Forms.MenuPrincipal.btnVehiculos.Enabled = False
                        My.Forms.MenuPrincipal.btnUsuarios.Enabled = False


                    ElseIf nivel = "administrador" Then
                        My.Forms.MenuPrincipal.btnCkVehiculos.Enabled = True
                        My.Forms.MenuPrincipal.btnChofer.Enabled = True
                        My.Forms.MenuPrincipal.btnVehiculos.Enabled = True
                        My.Forms.MenuPrincipal.btnUsuarios.Enabled = True
                    End If
                Else
                    Static intentos As Integer
                    intentos = intentos + 1
                    MsgBox("Estimado Usuario te quedan " & (3 - intentos) & " intentos")
                    If intentos = 3 Then
                        MsgBox("Cerrando sistema, gracias", MsgBoxStyle.Critical, "SISTEMA")
                        Me.Close()
                    End If


                End If


            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try





    End Sub
End Class
