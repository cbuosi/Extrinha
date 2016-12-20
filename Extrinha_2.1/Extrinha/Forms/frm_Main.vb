Option Explicit On
Option Strict On

Imports System.Text

Public Class frm_Main

    Public oExtrinha As New clsExtrinha()
    Dim cancelClose As Boolean = True

    Public Enum RadioChk
        IP = 1
        LU
    End Enum

    Private Sub btnConecta_Click(sender As System.Object, e As System.EventArgs) Handles btnConecta.Click

        Dim tTipo As String

        Try

            tTipo = CStr(cboTipoTerm.Items(cboTipoTerm.SelectedIndex))


            If Not oExtrinha Is Nothing Then
                If oExtrinha.Conected = True Then
                    lblEstado.Text = "Already connected..."
                    SS.Refresh()
                    Return
                End If
            End If

            oExtrinha = New clsExtrinha(tTipo,
                                        chkFast.Checked,
                                        chkRefuseTN3270E.Checked,
                                        chkSSL.Checked)

            If rdoLU.Checked = True Then
                oExtrinha.ConnectTo(txtIPLU.Text, CInt(txtPortaLU.Text), txtLU.Text)
            Else
                oExtrinha.ConnectTo(txtIP.Text, CInt(txtPorta.Text))
            End If

            oExtrinha.Update()

#If False Then
            If (oExtrinha.EsperarPor(4, 10, "SISTEMAS") = False) Then
                Console.WriteLine("Erro, tratar...")
                lblEstado.Text = "Erro ao conectar..."
                Return
            End If
#End If

            lblEstado.Text = "Connected!"
            SS.Refresh()

            btnAtualizaTela.PerformClick()

        Catch ex As Exception
            MsgBox("Erro: " & ex.Message)
            Console.WriteLine("Error in frm_principal::btnConecta: " & ex.Message)
        End Try


    End Sub

    Private Sub btnEnviaTexto_Click(sender As System.Object, e As System.EventArgs) Handles btnEnviaTexto.Click
        Try

            If oExtrinha.Conected() = False Then
                Return
            End If

            lblEstado.Text = "Sending text (Size: " & txtComando.Text.Length.ToString() & ")..."
            SS.Refresh()

            oExtrinha.SendTxt(txtComando.Text)

            If chkAtoEnter.Checked = True Then
                oExtrinha.TeclaEnter()

            End If

            If chkAutoRefresh.Checked = True Then
                btnAtualizaTela.PerformClick()
            Else
                lblEstado.Text += "OK"
                SS.Refresh()
            End If

        Catch ex As Exception
            Console.WriteLine("Error in frm_principal::btnEnviaTexto: " & ex.Message)
        End Try

    End Sub

    Private Sub btnAtualizaTela_Click(sender As System.Object, e As System.EventArgs) Handles btnAtualizaTela.Click

        Try

            txtSaida.Text = oExtrinha.GetFormatedScreen(chkRegua.Checked)

            lblEstado.Text += "OK"
            SS.Refresh()

        Catch ex As Exception
            Console.WriteLine("Error in frm_principal::btnAtualizaTela: " & ex.Message)
        End Try

    End Sub

    Private Sub btnDesconecta_Click(sender As System.Object, e As System.EventArgs) Handles btnDesconecta.Click
        Try

            If oExtrinha.Conected() = False Then
                Return
            End If


            txtSaida.Clear()

            lblEstado.Text = "Disconnecting..."
            SS.Refresh()

            oExtrinha.Disconnect()
            oExtrinha = Nothing

            lblEstado.Text += "OK"
            SS.Refresh()

        Catch ex As Exception
            Console.WriteLine("Error in frm_principal::btnDesconecta: " & ex.Message)
        End Try

    End Sub

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        Try

            Me.Text = "Extrinha v. " & Application.ProductVersion.ToString
            Me.AllowTransparency = True

            'rdoLU.Checked = True
            rdoIP.Checked = True

            txtIP.Text = "1.20.208.10"
            txtPorta.Text = "23"

            txtIPLU.Text = "deptop.sna.xxxx"
            txtLU.Text = "LUNAME"
            txtPortaLU.Text = "12345"

            txtComando.Text = "IMS12"
            chkFast.Checked = True
            chkAtoEnter.Checked = True
            chkAutoRefresh.Checked = True
            txtSaida.Clear()
            'lstComandosMacro.Items.Clear()

            cboTipoTerm.Items.Clear()
            cboTipoTerm.DropDownStyle = ComboBoxStyle.DropDownList
            cboTipoTerm.Items.Add("IBM-3278-2-E")
            cboTipoTerm.Items.Add("IBM-3278-2")
            'cboTipoTerm.Items.Add("IBM-2379-2") 'IBM-3278-2-E
            cboTipoTerm.Items.Add("IBM-3279-2") 'IBM-3278-2-E
            cboTipoTerm.SelectedIndex = 0

            txtVer.Text = clsExtrinha.GetVersion()

        Catch ex As Exception
            Console.WriteLine("Error in frm_principal::Form1_Load: " & ex.Message)
        End Try

    End Sub

    Private Sub cmdSobre_Click(sender As System.Object, e As System.EventArgs) Handles cmdSobre.Click
        Try
            frm_About.ShowDialog()
        Catch ex As Exception
            Console.WriteLine("Error in frm_principal::cmdSobre_Click: " & ex.Message)
        End Try
    End Sub

    Private Sub tRelogio_Tick(sender As System.Object, e As System.EventArgs) Handles tRelogio.Tick
        Me.Opacity -= 0.03
        If Me.Opacity <= 0 Then
            cancelClose = False
            Me.Close()
        End If
    End Sub

    Private Sub frm_Principal_FormClosing(sender As System.Object, e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        If tRelogio.Enabled = False Then
            tRelogio.Enabled = True
        End If
        e.Cancel = cancelClose
    End Sub

    Private Sub keyEsquerda_Click(sender As System.Object, e As System.EventArgs) Handles keyEsquerda.Click
        oExtrinha.TeclaEsquerda()
        If chkAutoRefresh.Checked = True Then
            btnAtualizaTela.PerformClick()
        End If
    End Sub

    Private Sub keyEnter_Click(sender As System.Object, e As System.EventArgs) Handles keyEnter.Click
        oExtrinha.TeclaEnter()
        If chkAutoRefresh.Checked = True Then
            btnAtualizaTela.PerformClick()
        End If
    End Sub

    Private Sub keyCima_Click(sender As System.Object, e As System.EventArgs) Handles keyCima.Click
        oExtrinha.TeclaCima()

        If chkAutoRefresh.Checked = True Then
            btnAtualizaTela.PerformClick()
        End If
    End Sub

    Private Sub keyDireita_Click(sender As System.Object, e As System.EventArgs) Handles keyDireita.Click
        oExtrinha.TeclaDireita()

        If chkAutoRefresh.Checked = True Then
            btnAtualizaTela.PerformClick()
        End If
    End Sub

    Private Sub keyBaixo_Click(sender As System.Object, e As System.EventArgs) Handles keyBaixo.Click
        oExtrinha.TeclaBaixo()

        If chkAutoRefresh.Checked = True Then
            btnAtualizaTela.PerformClick()
        End If
    End Sub

    Private Sub keyPF1_Click(sender As System.Object, e As System.EventArgs) Handles keyPF1.Click
        oExtrinha.TeclaPF1()
        If chkAutoRefresh.Checked = True Then
            btnAtualizaTela.PerformClick()
        End If
    End Sub

    Private Sub keyPF2_Click(sender As System.Object, e As System.EventArgs) Handles keyPF2.Click

        oExtrinha.TeclaPF2()

        If chkAutoRefresh.Checked = True Then
            btnAtualizaTela.PerformClick()
        End If
    End Sub

    Private Sub keyPF3_Click(sender As System.Object, e As System.EventArgs) Handles keyPF3.Click
        oExtrinha.TeclaPF3()
        If chkAutoRefresh.Checked = True Then
            btnAtualizaTela.PerformClick()
        End If
    End Sub


    Private Sub keyPF4_Click(sender As System.Object, e As System.EventArgs) Handles keyPF4.Click
        oExtrinha.TeclaPF4()

        If chkAutoRefresh.Checked = True Then
            btnAtualizaTela.PerformClick()
        End If
    End Sub

    Private Sub keyPF5_Click(sender As System.Object, e As System.EventArgs) Handles keyPF5.Click

        oExtrinha.TeclaPF5()

        If chkAutoRefresh.Checked = True Then
            btnAtualizaTela.PerformClick()
        End If
    End Sub

    Private Sub keyPF6_Click(sender As System.Object, e As System.EventArgs) Handles keyPF6.Click
        oExtrinha.TeclaPF6()
        If chkAutoRefresh.Checked = True Then
            btnAtualizaTela.PerformClick()
        End If
    End Sub

    Private Sub keyPF7_Click(sender As System.Object, e As System.EventArgs) Handles keyPF7.Click
        oExtrinha.TeclaPF7()

        If chkAutoRefresh.Checked = True Then
            btnAtualizaTela.PerformClick()
        End If
    End Sub

    Private Sub keyPF8_Click(sender As System.Object, e As System.EventArgs) Handles keyPF8.Click
        oExtrinha.TeclaPF8()

        If chkAutoRefresh.Checked = True Then
            btnAtualizaTela.PerformClick()
        End If
    End Sub

    Private Sub keyPF9_Click(sender As System.Object, e As System.EventArgs) Handles keyPF9.Click

        oExtrinha.TeclaPF9()


        If chkAutoRefresh.Checked = True Then
            btnAtualizaTela.PerformClick()
        End If
    End Sub

    Private Sub keyPF10_Click(sender As System.Object, e As System.EventArgs) Handles keyPF10.Click
        oExtrinha.TeclaPF10()

        If chkAutoRefresh.Checked = True Then
            btnAtualizaTela.PerformClick()
        End If
    End Sub

    Private Sub keyPF11_Click(sender As System.Object, e As System.EventArgs) Handles keyPF11.Click
        oExtrinha.TeclaPF11()

        If chkAutoRefresh.Checked = True Then
            btnAtualizaTela.PerformClick()
        End If
    End Sub

    Private Sub keyPF12_Click(sender As System.Object, e As System.EventArgs) Handles keyPF12.Click
        oExtrinha.TeclaPF12()

        If chkAutoRefresh.Checked = True Then
            btnAtualizaTela.PerformClick()
        End If
    End Sub

    Private Sub keyTAB_Click(sender As System.Object, e As System.EventArgs) Handles keyTAB.Click
        oExtrinha.TeclaTAB()

        If chkAutoRefresh.Checked = True Then
            btnAtualizaTela.PerformClick()
        End If

    End Sub

    Private Sub keyPA1_Click(sender As System.Object, e As System.EventArgs) Handles keyPA1.Click
        oExtrinha.TeclaPA1()

        If chkAutoRefresh.Checked = True Then
            btnAtualizaTela.PerformClick()
        End If
    End Sub

    Private Sub keyPA2_Click(sender As System.Object, e As System.EventArgs) Handles keyPA2.Click
        oExtrinha.TeclaPA2()

        If chkAutoRefresh.Checked = True Then
            btnAtualizaTela.PerformClick()
        End If
    End Sub

    Private Sub keyEraseEOF_Click(sender As System.Object, e As System.EventArgs) Handles keyEraseEOF.Click
        oExtrinha.TeclaEraseEOF()
        If chkAutoRefresh.Checked = True Then
            btnAtualizaTela.PerformClick()
        End If
    End Sub

    Private Sub keyDelete_Click(sender As System.Object, e As System.EventArgs) Handles keyDelete.Click
        oExtrinha.TeclaDelete()
        If chkAutoRefresh.Checked = True Then
            btnAtualizaTela.PerformClick()
        End If
    End Sub

    Private Sub keyHome_Click(sender As System.Object, e As System.EventArgs) Handles keyHome.Click
        oExtrinha.TeclaHome()
        If chkAutoRefresh.Checked = True Then
            btnAtualizaTela.PerformClick()
        End If
    End Sub

    Private Sub keyInsert_Click(sender As System.Object, e As System.EventArgs) Handles keyInsert.Click
        oExtrinha.TeclaInsert()
        If chkAutoRefresh.Checked = True Then
            btnAtualizaTela.PerformClick()
        End If
    End Sub

    Private Sub keyNewLine_Click(sender As System.Object, e As System.EventArgs) Handles keyNewLine.Click
        oExtrinha.TeclaNewLine()
        If chkAutoRefresh.Checked = True Then
            btnAtualizaTela.PerformClick()
        End If

    End Sub

    Private Sub keybackspace_Click(sender As System.Object, e As System.EventArgs) Handles keybackspace.Click
        oExtrinha.TeclaBackspace()
        If chkAutoRefresh.Checked = True Then
            btnAtualizaTela.PerformClick()
        End If
    End Sub

    Private Sub keyClear_Click(sender As System.Object, e As System.EventArgs) Handles keyClear.Click
        oExtrinha.TeclaClear()
        If chkAutoRefresh.Checked = True Then
            btnAtualizaTela.PerformClick()
        End If
    End Sub

    Private Sub keyRedef_Click(sender As System.Object, e As System.EventArgs) Handles keyRedef.Click
        oExtrinha.TeclaReset()
        If chkAutoRefresh.Checked = True Then
            btnAtualizaTela.PerformClick()
        End If
    End Sub


    Private Sub rdoLU_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles rdoLU.CheckedChanged
        HabilitaX(RadioChk.LU)
    End Sub

    Private Sub HabilitaX(ByVal radioChk As RadioChk)

        Dim LigaLU As Boolean
        Dim LigaIP As Boolean


        Select Case radioChk
            Case frm_Main.RadioChk.IP
                LigaLU = False
                LigaIP = True
            Case frm_Main.RadioChk.LU
                LigaLU = True
                LigaIP = False
            Case Else
                '????
        End Select

        txtIPLU.Enabled = LigaLU
        txtLU.Enabled = LigaLU
        txtPortaLU.Enabled = LigaLU

        txtIP.Enabled = LigaIP
        txtPorta.Enabled = LigaIP

    End Sub

    Private Sub rdoIP_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles rdoIP.CheckedChanged
        HabilitaX(RadioChk.IP)
    End Sub

End Class
