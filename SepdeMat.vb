Imports System.Data.Odbc
Imports System.Data.OleDb
Imports System.Data.SqlClient

Public Class SepdeMat

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)

    End Sub

    Private Sub SepdeMat_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim toolTip1 As New ToolTip()

        ' Set up the delays for the ToolTip.
        toolTip1.AutoPopDelay = 5000
        toolTip1.InitialDelay = 1000
        toolTip1.ReshowDelay = 500
        ' Force the ToolTip text to be displayed whether or not the form is active.
        toolTip1.ShowAlways = True

        ' Set up the ToolTip text for the Button and Checkbox.
        toolTip1.SetToolTip(Me.Btn_FinalizarSep, "Finalizar a separação")
        toolTip1.SetToolTip(Me.Btn_CortarPedido, "Cortar a separacção sem a quantidade do pedido.")
        toolTip1.SetToolTip(Me.Btn_Separar, "Começar a separar o pedido")

        Txt_NumeroPedido.Text = ""
        Txt_NumeroPedido.Focus()
        Txt_Separador.Text = StrUsuarioLogado
        Txt_Separador.Enabled = False

        Me.LblVerificandoItem.Text = ""
        Me.LblStatus.Text = ""

    End Sub

    Private Sub Txt_NumeroPedido_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Txt_NumeroPedido.GotFocus

    End Sub

    Private Sub Txt_NumeroPedido_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Txt_NumeroPedido.LostFocus


        Dim BuscaConexao As New SqlConnection
        BuscaConexao = New SqlConnection
        Dim StrConexao As String
        Dim strVolta As String = ""
        Dim strQuery As String = ""

        Try
            If Trim(Txt_NumeroPedido.Text) <> "" Then

                StrConexao = "Server= 192.168.0.1; database=sigla_teste;Uid=sa;Password=gin_adm1"
                BuscaConexao.ConnectionString = StrConexao
                BuscaConexao.Open()

                strQuery = ""
                strQuery = "Select "
                strQuery = strQuery & "  est.est_local as Local,         "
                strQuery = strQuery & "  env.env_codmat as Código,       "
                strQuery = strQuery & "  env.env_qtdenr as Quantidade,   "
                strQuery = strQuery & "  mat.mat_nommat  as Descrição    "
                strQuery = strQuery & "From "
                strQuery = strQuery & "  filest est, "
                strQuery = strQuery & "  filenv env, "
                strQuery = strQuery & "  filmat mat  "
                strQuery = strQuery & "Where "
                strQuery = strQuery & "  env.env_codmov = 'PV' and "
                strQuery = strQuery & "  env.env_codalm = '07' and "
                strQuery = strQuery & "  env.env_numdoc = '" & Txt_NumeroPedido.Text & "' and "
                strQuery = strQuery & "  env.env_codmat = est.est_codmat and "
                strQuery = strQuery & "  env.env_codmat = mat.mat_codmat And "
                strQuery = strQuery & "  env.env_codalm = est.est_codalm "

                Dim cmdConexao As New System.Data.SqlClient.SqlCommand(strQuery, BuscaConexao)
                Dim da As SqlDataAdapter = New SqlDataAdapter(cmdConexao)
                Dim dt As DataTable = New DataTable


                da.Fill(dt)
                DGridDadosNota.DataSource = dt

                DGridDadosNota.Columns(3).Width = 210
                Me.Txt_Item.Text = DGridDadosNota.RowCount - 1
                IntQtdeItens = DGridDadosNota.RowCount - 1
                Me.Txt_QuantidadeRestante.Text = DGridDadosNota.CurrentRow.Cells(2).Value
                Me.Txt_Item.Visible = True
                Me.txt_GetProduto.Focus()

                If intQtdeItens > 0 Then
                    intLinha = 0
                    DGridDadosNota.CurrentCell = DGridDadosNota.Rows(0).Cells(0)
                    DGridDadosNota.Rows(intLinha).Selected = True
                End If
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            BuscaConexao.Close()
        End Try

    End Sub

    Private Sub Txt_NumeroPedido_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Txt_NumeroPedido.TextChanged

    End Sub

    Private Sub SepdeMat_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.LostFocus

    End Sub

    Private Sub DGridDadosNota_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGridDadosNota.CellContentClick

    End Sub

    Private Sub Btn_Separar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Separar.Click

    End Sub

    Private Sub txt_GetProduto_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_GetProduto.LostFocus
        Try
            If intLinha < Me.Txt_Item.Text Then
                If Trim(Me.txt_GetProduto.Text) = Trim(DGridDadosNota.CurrentRow.Cells(1).Value) Then
                    Me.LblStatus.Text = "Descricao do item em separacao: " & Trim(DGridDadosNota.CurrentRow.Cells(3).Value)
                    LblVerificandoItem.Text = "Faltam: " & Txt_QuantidadeRestante.Text - Txt_QtdeLida.Text & " para separar."
                    List_Dados_Lidos.Items.Add(txt_GetProduto.Text & " " & Me.Txt_QtdeLida.Text)
                    Txt_QuantidadeRestante.Text = Txt_QuantidadeRestante.Text - Txt_QtdeLida.Text
                    txt_GetProduto.Text = ""
                    Txt_QtdeLida.Text = ""
                    Me.txt_GetProduto.Focus()
                    If Trim(Me.Txt_QuantidadeRestante.Text) = 0 Then
                        MsgBox("Item separado com sucesso!", MsgBoxStyle.Information, Title:="AVISO")
                        DGridDadosNota.CurrentCell = DGridDadosNota.Rows(intLinha).Cells(0)
                        DGridDadosNota.Rows(intLinha).DefaultCellStyle.BackColor = Color.YellowGreen
                        If intLinha <> Me.Txt_Item.Text Then
                            intLinha = intLinha + 1
                            DGridDadosNota.CurrentCell = DGridDadosNota.Rows(intLinha).Cells(0)
                            DGridDadosNota.Rows(intLinha).Selected = True
                            txt_GetProduto.Text = ""
                            Txt_QtdeLida.Text = ""
                            If intLinha = Me.Txt_Item.Text Then
                                Txt_QuantidadeRestante.Text = ""
                            Else
                                Txt_QuantidadeRestante.Text = Trim(DGridDadosNota.CurrentRow.Cells(2).Value)
                            End If
                        End If
                    End If
                End If
            Else
                MsgBox("Leitura de todos os itens realizada com sucesso. ", MsgBoxStyle.OkOnly, Title:="AVISO")
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Title:="ERRO")
        End Try
    End Sub

    Private Sub txt_GetProduto_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_GetProduto.TextChanged
        Try
            If Len(Me.txt_GetProduto.Text) = 8 Then
                If Trim(Me.txt_GetProduto.Text) = Trim(DGridDadosNota.CurrentRow.Cells(1).Value) Then
                    Txt_QtdeLida.Text = 1
                Else
                    MsgBox("Número do item lido não confere com o numero do item da lista", MsgBoxStyle.Critical, Title:="ERRO")
                    txt_GetProduto.Text = ""
                    Txt_QtdeLida.Text = ""
                    Me.txt_GetProduto.Focus()
                End If
            End If
        Catch ex As Exception

            MsgBox(ex.Message, MsgBoxStyle.Critical, Title:="ERRO")
        End Try

    End Sub

    Private Sub Txt_QtdeLida_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Txt_QtdeLida.TextChanged

    End Sub

    Private Sub List_Dados_Lidos_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles List_Dados_Lidos.SelectedIndexChanged

    End Sub

    Private Sub LblVerificandoItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LblVerificandoItem.Click

    End Sub
End Class