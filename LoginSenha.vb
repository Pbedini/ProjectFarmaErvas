Public Class LoginSenha
    Private Sub Btn_Entrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Entrar.Click
        If CmbUsuario.SelectedIndex <> -1 Then
            StrUsuarioLogado = CmbUsuario.SelectedItem.ToString
            If CmbUsuario.SelectedItem.ToString = "Coletor 1" And Trim(Txt_Senha.Text) = "" Then
                MdiSepMat.Show()
                Me.Visible = False
            ElseIf CmbUsuario.SelectedItem.ToString = "Coletor 2" And Trim(Txt_Senha.Text) = "" Then
                MdiSepMat.Show()
                Me.Visible = False
            ElseIf CmbUsuario.SelectedItem.ToString = "Coletor 3" And Trim(Txt_Senha.Text) = "" Then
                MdiSepMat.Show()
                Me.Visible = False
            ElseIf CmbUsuario.SelectedItem.ToString = "Administrador" And Trim(Txt_Senha.Text) = "Adm" Then
                MdiSepMat.Show()
                Me.Visible = False
            Else
                MsgBox("Login ou senha incorreta", MsgBoxStyle.Critical, Title:="ERRO")
                CmbUsuario.Select()
            End If
        Else
            MsgBox("É necessario selecionar pelo menos 1 usuário.", MsgBoxStyle.Critical, Title:="ERRO")
        End If
    End Sub

    Private Sub Btn_Sair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Sair.Click
        End
    End Sub

    Private Sub LoginSenha_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.ResizeRedraw = False
    End Sub
End Class
