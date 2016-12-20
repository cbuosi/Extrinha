<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Main
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: O procedimento a seguir é exigido pelo Windows Form Designer
    'Ele pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Main))
        Me.txtSaida = New System.Windows.Forms.TextBox()
        Me.txtIP = New System.Windows.Forms.TextBox()
        Me.txtPorta = New System.Windows.Forms.TextBox()
        Me.SS = New System.Windows.Forms.StatusStrip()
        Me.lblEstado = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.chkFast = New System.Windows.Forms.CheckBox()
        Me.GrpBox = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cboTipoTerm = New System.Windows.Forms.ComboBox()
        Me.txtLU = New System.Windows.Forms.TextBox()
        Me.txtIPLU = New System.Windows.Forms.TextBox()
        Me.txtPortaLU = New System.Windows.Forms.TextBox()
        Me.rdoLU = New System.Windows.Forms.RadioButton()
        Me.rdoIP = New System.Windows.Forms.RadioButton()
        Me.chkSSL = New System.Windows.Forms.CheckBox()
        Me.chkRefuseTN3270E = New System.Windows.Forms.CheckBox()
        Me.chkRegua = New System.Windows.Forms.CheckBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmdSobre = New System.Windows.Forms.Button()
        Me.btnConecta = New System.Windows.Forms.Button()
        Me.btnDesconecta = New System.Windows.Forms.Button()
        Me.chkAtoEnter = New System.Windows.Forms.CheckBox()
        Me.txtComando = New System.Windows.Forms.TextBox()
        Me.chkAutoRefresh = New System.Windows.Forms.CheckBox()
        Me.tRelogio = New System.Windows.Forms.Timer(Me.components)
        Me.keyEnter = New System.Windows.Forms.Button()
        Me.keyPF12 = New System.Windows.Forms.Button()
        Me.keyPF11 = New System.Windows.Forms.Button()
        Me.keyDireita = New System.Windows.Forms.Button()
        Me.keyDelete = New System.Windows.Forms.Button()
        Me.keyCima = New System.Windows.Forms.Button()
        Me.keyPF7 = New System.Windows.Forms.Button()
        Me.keyBaixo = New System.Windows.Forms.Button()
        Me.keyEraseEOF = New System.Windows.Forms.Button()
        Me.keyPF8 = New System.Windows.Forms.Button()
        Me.keyHome = New System.Windows.Forms.Button()
        Me.keyPF6 = New System.Windows.Forms.Button()
        Me.keyPA2 = New System.Windows.Forms.Button()
        Me.keyPF10 = New System.Windows.Forms.Button()
        Me.keyTAB = New System.Windows.Forms.Button()
        Me.keyPF3 = New System.Windows.Forms.Button()
        Me.keyInsert = New System.Windows.Forms.Button()
        Me.keyPF5 = New System.Windows.Forms.Button()
        Me.keyEsquerda = New System.Windows.Forms.Button()
        Me.keyPA1 = New System.Windows.Forms.Button()
        Me.keyPF9 = New System.Windows.Forms.Button()
        Me.keybackspace = New System.Windows.Forms.Button()
        Me.keyNewLine = New System.Windows.Forms.Button()
        Me.keyPF2 = New System.Windows.Forms.Button()
        Me.keyClear = New System.Windows.Forms.Button()
        Me.keyPF4 = New System.Windows.Forms.Button()
        Me.keyPF1 = New System.Windows.Forms.Button()
        Me.keyRedef = New System.Windows.Forms.Button()
        Me.btnEnviaTexto = New System.Windows.Forms.Button()
        Me.btnAtualizaTela = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtVer = New System.Windows.Forms.TextBox()
        Me.GrpBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtSaida
        '
        Me.txtSaida.BackColor = System.Drawing.Color.Black
        Me.txtSaida.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSaida.ForeColor = System.Drawing.Color.Lime
        Me.txtSaida.Location = New System.Drawing.Point(12, 12)
        Me.txtSaida.Multiline = True
        Me.txtSaida.Name = "txtSaida"
        Me.txtSaida.Size = New System.Drawing.Size(610, 443)
        Me.txtSaida.TabIndex = 1
        '
        'txtIP
        '
        Me.txtIP.Location = New System.Drawing.Point(49, 59)
        Me.txtIP.Name = "txtIP"
        Me.txtIP.Size = New System.Drawing.Size(135, 20)
        Me.txtIP.TabIndex = 2
        '
        'txtPorta
        '
        Me.txtPorta.Location = New System.Drawing.Point(276, 59)
        Me.txtPorta.Name = "txtPorta"
        Me.txtPorta.Size = New System.Drawing.Size(46, 20)
        Me.txtPorta.TabIndex = 2
        '
        'SS
        '
        Me.SS.Location = New System.Drawing.Point(0, 556)
        Me.SS.Name = "SS"
        Me.SS.Size = New System.Drawing.Size(994, 22)
        Me.SS.SizingGrip = False
        Me.SS.TabIndex = 3
        Me.SS.Text = "StatusStrip1"
        '
        'lblEstado
        '
        Me.lblEstado.Name = "lblEstado"
        Me.lblEstado.Size = New System.Drawing.Size(0, 17)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(46, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Host name or IP"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(273, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(26, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Port"
        '
        'chkFast
        '
        Me.chkFast.AutoSize = True
        Me.chkFast.Location = New System.Drawing.Point(76, 153)
        Me.chkFast.Name = "chkFast"
        Me.chkFast.Size = New System.Drawing.Size(75, 17)
        Me.chkFast.TabIndex = 6
        Me.chkFast.Text = "Fast mode"
        Me.chkFast.UseVisualStyleBackColor = True
        '
        'GrpBox
        '
        Me.GrpBox.BackColor = System.Drawing.Color.Gainsboro
        Me.GrpBox.Controls.Add(Me.Label5)
        Me.GrpBox.Controls.Add(Me.cboTipoTerm)
        Me.GrpBox.Controls.Add(Me.txtLU)
        Me.GrpBox.Controls.Add(Me.txtIPLU)
        Me.GrpBox.Controls.Add(Me.txtIP)
        Me.GrpBox.Controls.Add(Me.txtPortaLU)
        Me.GrpBox.Controls.Add(Me.txtPorta)
        Me.GrpBox.Controls.Add(Me.rdoLU)
        Me.GrpBox.Controls.Add(Me.rdoIP)
        Me.GrpBox.Controls.Add(Me.chkSSL)
        Me.GrpBox.Controls.Add(Me.chkRefuseTN3270E)
        Me.GrpBox.Controls.Add(Me.chkFast)
        Me.GrpBox.Controls.Add(Me.chkRegua)
        Me.GrpBox.Controls.Add(Me.Label3)
        Me.GrpBox.Controls.Add(Me.Label2)
        Me.GrpBox.Controls.Add(Me.Label1)
        Me.GrpBox.Controls.Add(Me.cmdSobre)
        Me.GrpBox.Controls.Add(Me.btnConecta)
        Me.GrpBox.Controls.Add(Me.btnDesconecta)
        Me.GrpBox.Location = New System.Drawing.Point(628, 12)
        Me.GrpBox.Name = "GrpBox"
        Me.GrpBox.Size = New System.Drawing.Size(357, 245)
        Me.GrpBox.TabIndex = 7
        Me.GrpBox.TabStop = False
        Me.GrpBox.Text = "Configuration"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(20, 107)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(70, 13)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Terminal type"
        '
        'cboTipoTerm
        '
        Me.cboTipoTerm.FormattingEnabled = True
        Me.cboTipoTerm.Location = New System.Drawing.Point(93, 104)
        Me.cboTipoTerm.Name = "cboTipoTerm"
        Me.cboTipoTerm.Size = New System.Drawing.Size(229, 21)
        Me.cboTipoTerm.TabIndex = 11
        '
        'txtLU
        '
        Me.txtLU.Location = New System.Drawing.Point(187, 38)
        Me.txtLU.Name = "txtLU"
        Me.txtLU.Size = New System.Drawing.Size(87, 20)
        Me.txtLU.TabIndex = 2
        '
        'txtIPLU
        '
        Me.txtIPLU.Location = New System.Drawing.Point(49, 38)
        Me.txtIPLU.Name = "txtIPLU"
        Me.txtIPLU.Size = New System.Drawing.Size(135, 20)
        Me.txtIPLU.TabIndex = 2
        '
        'txtPortaLU
        '
        Me.txtPortaLU.Location = New System.Drawing.Point(276, 38)
        Me.txtPortaLU.Name = "txtPortaLU"
        Me.txtPortaLU.Size = New System.Drawing.Size(46, 20)
        Me.txtPortaLU.TabIndex = 2
        '
        'rdoLU
        '
        Me.rdoLU.AutoSize = True
        Me.rdoLU.Location = New System.Drawing.Point(9, 41)
        Me.rdoLU.Name = "rdoLU"
        Me.rdoLU.Size = New System.Drawing.Size(39, 17)
        Me.rdoLU.TabIndex = 10
        Me.rdoLU.TabStop = True
        Me.rdoLU.Text = "LU"
        Me.rdoLU.UseVisualStyleBackColor = True
        '
        'rdoIP
        '
        Me.rdoIP.AutoSize = True
        Me.rdoIP.Location = New System.Drawing.Point(9, 60)
        Me.rdoIP.Name = "rdoIP"
        Me.rdoIP.Size = New System.Drawing.Size(35, 17)
        Me.rdoIP.TabIndex = 9
        Me.rdoIP.TabStop = True
        Me.rdoIP.Text = "IP"
        Me.rdoIP.UseVisualStyleBackColor = True
        '
        'chkSSL
        '
        Me.chkSSL.AutoSize = True
        Me.chkSSL.Location = New System.Drawing.Point(272, 153)
        Me.chkSSL.Name = "chkSSL"
        Me.chkSSL.Size = New System.Drawing.Size(46, 17)
        Me.chkSSL.TabIndex = 6
        Me.chkSSL.Text = "SSL"
        Me.chkSSL.UseVisualStyleBackColor = True
        '
        'chkRefuseTN3270E
        '
        Me.chkRefuseTN3270E.AutoSize = True
        Me.chkRefuseTN3270E.Location = New System.Drawing.Point(167, 153)
        Me.chkRefuseTN3270E.Name = "chkRefuseTN3270E"
        Me.chkRefuseTN3270E.Size = New System.Drawing.Size(106, 17)
        Me.chkRefuseTN3270E.TabIndex = 6
        Me.chkRefuseTN3270E.Text = "RefuseTN3270E"
        Me.chkRefuseTN3270E.UseVisualStyleBackColor = True
        '
        'chkRegua
        '
        Me.chkRegua.AutoSize = True
        Me.chkRegua.Location = New System.Drawing.Point(12, 153)
        Me.chkRegua.Name = "chkRegua"
        Me.chkRegua.Size = New System.Drawing.Size(51, 17)
        Me.chkRegua.TabIndex = 8
        Me.chkRegua.Text = "Ruler"
        Me.chkRegua.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(184, 19)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(21, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "LU"
        '
        'cmdSobre
        '
        Me.cmdSobre.Image = CType(resources.GetObject("cmdSobre.Image"), System.Drawing.Image)
        Me.cmdSobre.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdSobre.Location = New System.Drawing.Point(272, 194)
        Me.cmdSobre.Name = "cmdSobre"
        Me.cmdSobre.Size = New System.Drawing.Size(79, 40)
        Me.cmdSobre.TabIndex = 0
        Me.cmdSobre.Text = "About"
        Me.cmdSobre.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdSobre.UseVisualStyleBackColor = True
        '
        'btnConecta
        '
        Me.btnConecta.Image = CType(resources.GetObject("btnConecta.Image"), System.Drawing.Image)
        Me.btnConecta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnConecta.Location = New System.Drawing.Point(12, 194)
        Me.btnConecta.Name = "btnConecta"
        Me.btnConecta.Size = New System.Drawing.Size(86, 40)
        Me.btnConecta.TabIndex = 0
        Me.btnConecta.Text = "Conect"
        Me.btnConecta.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnConecta.UseVisualStyleBackColor = True
        '
        'btnDesconecta
        '
        Me.btnDesconecta.Image = CType(resources.GetObject("btnDesconecta.Image"), System.Drawing.Image)
        Me.btnDesconecta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDesconecta.Location = New System.Drawing.Point(140, 194)
        Me.btnDesconecta.Name = "btnDesconecta"
        Me.btnDesconecta.Size = New System.Drawing.Size(106, 40)
        Me.btnDesconecta.TabIndex = 4
        Me.btnDesconecta.Text = "Disconect"
        Me.btnDesconecta.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnDesconecta.UseVisualStyleBackColor = True
        '
        'chkAtoEnter
        '
        Me.chkAtoEnter.AutoSize = True
        Me.chkAtoEnter.BackColor = System.Drawing.Color.Transparent
        Me.chkAtoEnter.Location = New System.Drawing.Point(784, 313)
        Me.chkAtoEnter.Name = "chkAtoEnter"
        Me.chkAtoEnter.Size = New System.Drawing.Size(51, 17)
        Me.chkAtoEnter.TabIndex = 8
        Me.chkAtoEnter.Text = "Enter"
        Me.chkAtoEnter.UseVisualStyleBackColor = False
        '
        'txtComando
        '
        Me.txtComando.Location = New System.Drawing.Point(664, 287)
        Me.txtComando.Name = "txtComando"
        Me.txtComando.Size = New System.Drawing.Size(286, 20)
        Me.txtComando.TabIndex = 10
        '
        'chkAutoRefresh
        '
        Me.chkAutoRefresh.AutoSize = True
        Me.chkAutoRefresh.BackColor = System.Drawing.Color.Transparent
        Me.chkAutoRefresh.Location = New System.Drawing.Point(784, 334)
        Me.chkAutoRefresh.Name = "chkAutoRefresh"
        Me.chkAutoRefresh.Size = New System.Drawing.Size(63, 30)
        Me.chkAutoRefresh.TabIndex = 8
        Me.chkAutoRefresh.Text = "Refresh" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "screen"
        Me.chkAutoRefresh.UseVisualStyleBackColor = False
        '
        'tRelogio
        '
        Me.tRelogio.Interval = 1
        '
        'keyEnter
        '
        Me.keyEnter.BackgroundImage = CType(resources.GetObject("keyEnter.BackgroundImage"), System.Drawing.Image)
        Me.keyEnter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.keyEnter.Cursor = System.Windows.Forms.Cursors.Hand
        Me.keyEnter.FlatAppearance.BorderSize = 0
        Me.keyEnter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.keyEnter.Location = New System.Drawing.Point(562, 506)
        Me.keyEnter.Name = "keyEnter"
        Me.keyEnter.Size = New System.Drawing.Size(104, 39)
        Me.keyEnter.TabIndex = 12
        Me.keyEnter.Text = "ENTER"
        Me.keyEnter.UseVisualStyleBackColor = True
        '
        'keyPF12
        '
        Me.keyPF12.BackgroundImage = CType(resources.GetObject("keyPF12.BackgroundImage"), System.Drawing.Image)
        Me.keyPF12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.keyPF12.Cursor = System.Windows.Forms.Cursors.Hand
        Me.keyPF12.FlatAppearance.BorderSize = 0
        Me.keyPF12.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.keyPF12.Location = New System.Drawing.Point(672, 461)
        Me.keyPF12.Name = "keyPF12"
        Me.keyPF12.Size = New System.Drawing.Size(49, 39)
        Me.keyPF12.TabIndex = 12
        Me.keyPF12.Text = "PF12"
        Me.keyPF12.UseVisualStyleBackColor = True
        '
        'keyPF11
        '
        Me.keyPF11.BackgroundImage = CType(resources.GetObject("keyPF11.BackgroundImage"), System.Drawing.Image)
        Me.keyPF11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.keyPF11.Cursor = System.Windows.Forms.Cursors.Hand
        Me.keyPF11.FlatAppearance.BorderSize = 0
        Me.keyPF11.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.keyPF11.Location = New System.Drawing.Point(617, 461)
        Me.keyPF11.Name = "keyPF11"
        Me.keyPF11.Size = New System.Drawing.Size(49, 39)
        Me.keyPF11.TabIndex = 12
        Me.keyPF11.Text = "PF11"
        Me.keyPF11.UseVisualStyleBackColor = True
        '
        'keyDireita
        '
        Me.keyDireita.BackgroundImage = CType(resources.GetObject("keyDireita.BackgroundImage"), System.Drawing.Image)
        Me.keyDireita.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.keyDireita.Cursor = System.Windows.Forms.Cursors.Hand
        Me.keyDireita.FlatAppearance.BorderSize = 0
        Me.keyDireita.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.keyDireita.Location = New System.Drawing.Point(782, 506)
        Me.keyDireita.Name = "keyDireita"
        Me.keyDireita.Size = New System.Drawing.Size(49, 38)
        Me.keyDireita.TabIndex = 12
        Me.keyDireita.Text = ">"
        Me.keyDireita.UseVisualStyleBackColor = True
        '
        'keyDelete
        '
        Me.keyDelete.BackgroundImage = CType(resources.GetObject("keyDelete.BackgroundImage"), System.Drawing.Image)
        Me.keyDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.keyDelete.Cursor = System.Windows.Forms.Cursors.Hand
        Me.keyDelete.FlatAppearance.BorderSize = 0
        Me.keyDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.keyDelete.Location = New System.Drawing.Point(342, 506)
        Me.keyDelete.Name = "keyDelete"
        Me.keyDelete.Size = New System.Drawing.Size(49, 39)
        Me.keyDelete.TabIndex = 12
        Me.keyDelete.Text = "Delet"
        Me.keyDelete.UseVisualStyleBackColor = True
        '
        'keyCima
        '
        Me.keyCima.BackgroundImage = CType(resources.GetObject("keyCima.BackgroundImage"), System.Drawing.Image)
        Me.keyCima.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.keyCima.Cursor = System.Windows.Forms.Cursors.Hand
        Me.keyCima.FlatAppearance.BorderSize = 0
        Me.keyCima.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.keyCima.Location = New System.Drawing.Point(727, 461)
        Me.keyCima.Name = "keyCima"
        Me.keyCima.Size = New System.Drawing.Size(49, 39)
        Me.keyCima.TabIndex = 12
        Me.keyCima.Text = "˄"
        Me.keyCima.UseVisualStyleBackColor = True
        '
        'keyPF7
        '
        Me.keyPF7.BackgroundImage = CType(resources.GetObject("keyPF7.BackgroundImage"), System.Drawing.Image)
        Me.keyPF7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.keyPF7.Cursor = System.Windows.Forms.Cursors.Hand
        Me.keyPF7.FlatAppearance.BorderSize = 0
        Me.keyPF7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.keyPF7.Location = New System.Drawing.Point(397, 461)
        Me.keyPF7.Name = "keyPF7"
        Me.keyPF7.Size = New System.Drawing.Size(49, 39)
        Me.keyPF7.TabIndex = 12
        Me.keyPF7.Text = "PF7"
        Me.keyPF7.UseVisualStyleBackColor = True
        '
        'keyBaixo
        '
        Me.keyBaixo.BackgroundImage = CType(resources.GetObject("keyBaixo.BackgroundImage"), System.Drawing.Image)
        Me.keyBaixo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.keyBaixo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.keyBaixo.FlatAppearance.BorderSize = 0
        Me.keyBaixo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.keyBaixo.Location = New System.Drawing.Point(727, 506)
        Me.keyBaixo.Name = "keyBaixo"
        Me.keyBaixo.Size = New System.Drawing.Size(49, 38)
        Me.keyBaixo.TabIndex = 12
        Me.keyBaixo.Text = "˅"
        Me.keyBaixo.UseVisualStyleBackColor = True
        '
        'keyEraseEOF
        '
        Me.keyEraseEOF.BackgroundImage = CType(resources.GetObject("keyEraseEOF.BackgroundImage"), System.Drawing.Image)
        Me.keyEraseEOF.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.keyEraseEOF.Cursor = System.Windows.Forms.Cursors.Hand
        Me.keyEraseEOF.FlatAppearance.BorderSize = 0
        Me.keyEraseEOF.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.keyEraseEOF.Location = New System.Drawing.Point(397, 506)
        Me.keyEraseEOF.Name = "keyEraseEOF"
        Me.keyEraseEOF.Size = New System.Drawing.Size(49, 39)
        Me.keyEraseEOF.TabIndex = 12
        Me.keyEraseEOF.Text = "Erase EOF"
        Me.keyEraseEOF.UseVisualStyleBackColor = True
        '
        'keyPF8
        '
        Me.keyPF8.BackgroundImage = CType(resources.GetObject("keyPF8.BackgroundImage"), System.Drawing.Image)
        Me.keyPF8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.keyPF8.Cursor = System.Windows.Forms.Cursors.Hand
        Me.keyPF8.FlatAppearance.BorderSize = 0
        Me.keyPF8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.keyPF8.Location = New System.Drawing.Point(452, 461)
        Me.keyPF8.Name = "keyPF8"
        Me.keyPF8.Size = New System.Drawing.Size(49, 39)
        Me.keyPF8.TabIndex = 12
        Me.keyPF8.Text = "PF8"
        Me.keyPF8.UseVisualStyleBackColor = True
        '
        'keyHome
        '
        Me.keyHome.BackgroundImage = CType(resources.GetObject("keyHome.BackgroundImage"), System.Drawing.Image)
        Me.keyHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.keyHome.Cursor = System.Windows.Forms.Cursors.Hand
        Me.keyHome.FlatAppearance.BorderSize = 0
        Me.keyHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.keyHome.Location = New System.Drawing.Point(287, 506)
        Me.keyHome.Name = "keyHome"
        Me.keyHome.Size = New System.Drawing.Size(49, 39)
        Me.keyHome.TabIndex = 12
        Me.keyHome.Text = "Home"
        Me.keyHome.UseVisualStyleBackColor = True
        '
        'keyPF6
        '
        Me.keyPF6.BackgroundImage = CType(resources.GetObject("keyPF6.BackgroundImage"), System.Drawing.Image)
        Me.keyPF6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.keyPF6.Cursor = System.Windows.Forms.Cursors.Hand
        Me.keyPF6.FlatAppearance.BorderSize = 0
        Me.keyPF6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.keyPF6.Location = New System.Drawing.Point(342, 461)
        Me.keyPF6.Name = "keyPF6"
        Me.keyPF6.Size = New System.Drawing.Size(49, 39)
        Me.keyPF6.TabIndex = 12
        Me.keyPF6.Text = "PF6"
        Me.keyPF6.UseVisualStyleBackColor = True
        '
        'keyPA2
        '
        Me.keyPA2.BackgroundImage = CType(resources.GetObject("keyPA2.BackgroundImage"), System.Drawing.Image)
        Me.keyPA2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.keyPA2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.keyPA2.FlatAppearance.BorderSize = 0
        Me.keyPA2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.keyPA2.Location = New System.Drawing.Point(507, 506)
        Me.keyPA2.Name = "keyPA2"
        Me.keyPA2.Size = New System.Drawing.Size(49, 39)
        Me.keyPA2.TabIndex = 12
        Me.keyPA2.Text = "PA2"
        Me.keyPA2.UseVisualStyleBackColor = True
        '
        'keyPF10
        '
        Me.keyPF10.BackgroundImage = CType(resources.GetObject("keyPF10.BackgroundImage"), System.Drawing.Image)
        Me.keyPF10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.keyPF10.Cursor = System.Windows.Forms.Cursors.Hand
        Me.keyPF10.FlatAppearance.BorderSize = 0
        Me.keyPF10.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.keyPF10.Location = New System.Drawing.Point(562, 461)
        Me.keyPF10.Name = "keyPF10"
        Me.keyPF10.Size = New System.Drawing.Size(49, 39)
        Me.keyPF10.TabIndex = 12
        Me.keyPF10.Text = "PF10"
        Me.keyPF10.UseVisualStyleBackColor = True
        '
        'keyTAB
        '
        Me.keyTAB.BackgroundImage = CType(resources.GetObject("keyTAB.BackgroundImage"), System.Drawing.Image)
        Me.keyTAB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.keyTAB.Cursor = System.Windows.Forms.Cursors.Hand
        Me.keyTAB.FlatAppearance.BorderSize = 0
        Me.keyTAB.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.keyTAB.Location = New System.Drawing.Point(122, 506)
        Me.keyTAB.Name = "keyTAB"
        Me.keyTAB.Size = New System.Drawing.Size(49, 39)
        Me.keyTAB.TabIndex = 12
        Me.keyTAB.Text = "TAB"
        Me.keyTAB.UseVisualStyleBackColor = True
        '
        'keyPF3
        '
        Me.keyPF3.BackgroundImage = CType(resources.GetObject("keyPF3.BackgroundImage"), System.Drawing.Image)
        Me.keyPF3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.keyPF3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.keyPF3.FlatAppearance.BorderSize = 0
        Me.keyPF3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.keyPF3.Location = New System.Drawing.Point(177, 461)
        Me.keyPF3.Name = "keyPF3"
        Me.keyPF3.Size = New System.Drawing.Size(49, 39)
        Me.keyPF3.TabIndex = 12
        Me.keyPF3.Text = "PF3"
        Me.keyPF3.UseVisualStyleBackColor = True
        '
        'keyInsert
        '
        Me.keyInsert.BackgroundImage = CType(resources.GetObject("keyInsert.BackgroundImage"), System.Drawing.Image)
        Me.keyInsert.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.keyInsert.Cursor = System.Windows.Forms.Cursors.Hand
        Me.keyInsert.FlatAppearance.BorderSize = 0
        Me.keyInsert.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.keyInsert.Location = New System.Drawing.Point(232, 506)
        Me.keyInsert.Name = "keyInsert"
        Me.keyInsert.Size = New System.Drawing.Size(49, 39)
        Me.keyInsert.TabIndex = 12
        Me.keyInsert.Text = "Insert"
        Me.keyInsert.UseVisualStyleBackColor = True
        '
        'keyPF5
        '
        Me.keyPF5.BackgroundImage = CType(resources.GetObject("keyPF5.BackgroundImage"), System.Drawing.Image)
        Me.keyPF5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.keyPF5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.keyPF5.FlatAppearance.BorderSize = 0
        Me.keyPF5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.keyPF5.Location = New System.Drawing.Point(287, 461)
        Me.keyPF5.Name = "keyPF5"
        Me.keyPF5.Size = New System.Drawing.Size(49, 39)
        Me.keyPF5.TabIndex = 12
        Me.keyPF5.Text = "PF5"
        Me.keyPF5.UseVisualStyleBackColor = True
        '
        'keyEsquerda
        '
        Me.keyEsquerda.BackgroundImage = CType(resources.GetObject("keyEsquerda.BackgroundImage"), System.Drawing.Image)
        Me.keyEsquerda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.keyEsquerda.Cursor = System.Windows.Forms.Cursors.Hand
        Me.keyEsquerda.FlatAppearance.BorderSize = 0
        Me.keyEsquerda.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.keyEsquerda.Location = New System.Drawing.Point(672, 507)
        Me.keyEsquerda.Name = "keyEsquerda"
        Me.keyEsquerda.Size = New System.Drawing.Size(49, 38)
        Me.keyEsquerda.TabIndex = 12
        Me.keyEsquerda.Text = "<"
        Me.keyEsquerda.UseVisualStyleBackColor = True
        '
        'keyPA1
        '
        Me.keyPA1.BackgroundImage = CType(resources.GetObject("keyPA1.BackgroundImage"), System.Drawing.Image)
        Me.keyPA1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.keyPA1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.keyPA1.FlatAppearance.BorderSize = 0
        Me.keyPA1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.keyPA1.Location = New System.Drawing.Point(452, 506)
        Me.keyPA1.Name = "keyPA1"
        Me.keyPA1.Size = New System.Drawing.Size(49, 39)
        Me.keyPA1.TabIndex = 12
        Me.keyPA1.Text = "PA1"
        Me.keyPA1.UseVisualStyleBackColor = True
        '
        'keyPF9
        '
        Me.keyPF9.BackgroundImage = CType(resources.GetObject("keyPF9.BackgroundImage"), System.Drawing.Image)
        Me.keyPF9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.keyPF9.Cursor = System.Windows.Forms.Cursors.Hand
        Me.keyPF9.FlatAppearance.BorderSize = 0
        Me.keyPF9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.keyPF9.Location = New System.Drawing.Point(507, 461)
        Me.keyPF9.Name = "keyPF9"
        Me.keyPF9.Size = New System.Drawing.Size(49, 39)
        Me.keyPF9.TabIndex = 12
        Me.keyPF9.Text = "PF9"
        Me.keyPF9.UseVisualStyleBackColor = True
        '
        'keybackspace
        '
        Me.keybackspace.BackgroundImage = CType(resources.GetObject("keybackspace.BackgroundImage"), System.Drawing.Image)
        Me.keybackspace.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.keybackspace.Cursor = System.Windows.Forms.Cursors.Hand
        Me.keybackspace.FlatAppearance.BorderSize = 0
        Me.keybackspace.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.keybackspace.Location = New System.Drawing.Point(67, 506)
        Me.keybackspace.Name = "keybackspace"
        Me.keybackspace.Size = New System.Drawing.Size(49, 39)
        Me.keybackspace.TabIndex = 12
        Me.keybackspace.Text = "Backspace"
        Me.keybackspace.UseVisualStyleBackColor = True
        '
        'keyNewLine
        '
        Me.keyNewLine.BackgroundImage = CType(resources.GetObject("keyNewLine.BackgroundImage"), System.Drawing.Image)
        Me.keyNewLine.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.keyNewLine.Cursor = System.Windows.Forms.Cursors.Hand
        Me.keyNewLine.FlatAppearance.BorderSize = 0
        Me.keyNewLine.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.keyNewLine.Location = New System.Drawing.Point(177, 506)
        Me.keyNewLine.Name = "keyNewLine"
        Me.keyNewLine.Size = New System.Drawing.Size(49, 39)
        Me.keyNewLine.TabIndex = 12
        Me.keyNewLine.Text = "New Line"
        Me.keyNewLine.UseVisualStyleBackColor = True
        '
        'keyPF2
        '
        Me.keyPF2.BackgroundImage = CType(resources.GetObject("keyPF2.BackgroundImage"), System.Drawing.Image)
        Me.keyPF2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.keyPF2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.keyPF2.FlatAppearance.BorderSize = 0
        Me.keyPF2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.keyPF2.Location = New System.Drawing.Point(122, 461)
        Me.keyPF2.Name = "keyPF2"
        Me.keyPF2.Size = New System.Drawing.Size(49, 39)
        Me.keyPF2.TabIndex = 12
        Me.keyPF2.Text = "PF2"
        Me.keyPF2.UseVisualStyleBackColor = True
        '
        'keyClear
        '
        Me.keyClear.BackgroundImage = CType(resources.GetObject("keyClear.BackgroundImage"), System.Drawing.Image)
        Me.keyClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.keyClear.Cursor = System.Windows.Forms.Cursors.Hand
        Me.keyClear.FlatAppearance.BorderSize = 0
        Me.keyClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.keyClear.Location = New System.Drawing.Point(12, 506)
        Me.keyClear.Name = "keyClear"
        Me.keyClear.Size = New System.Drawing.Size(49, 39)
        Me.keyClear.TabIndex = 12
        Me.keyClear.Text = "Clear"
        Me.keyClear.UseVisualStyleBackColor = True
        '
        'keyPF4
        '
        Me.keyPF4.BackgroundImage = CType(resources.GetObject("keyPF4.BackgroundImage"), System.Drawing.Image)
        Me.keyPF4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.keyPF4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.keyPF4.FlatAppearance.BorderSize = 0
        Me.keyPF4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.keyPF4.Location = New System.Drawing.Point(232, 461)
        Me.keyPF4.Name = "keyPF4"
        Me.keyPF4.Size = New System.Drawing.Size(49, 39)
        Me.keyPF4.TabIndex = 12
        Me.keyPF4.Text = "PF4"
        Me.keyPF4.UseVisualStyleBackColor = True
        '
        'keyPF1
        '
        Me.keyPF1.BackgroundImage = CType(resources.GetObject("keyPF1.BackgroundImage"), System.Drawing.Image)
        Me.keyPF1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.keyPF1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.keyPF1.FlatAppearance.BorderSize = 0
        Me.keyPF1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.keyPF1.Location = New System.Drawing.Point(67, 461)
        Me.keyPF1.Name = "keyPF1"
        Me.keyPF1.Size = New System.Drawing.Size(49, 39)
        Me.keyPF1.TabIndex = 12
        Me.keyPF1.Text = "PF1"
        Me.keyPF1.UseVisualStyleBackColor = True
        '
        'keyRedef
        '
        Me.keyRedef.BackgroundImage = CType(resources.GetObject("keyRedef.BackgroundImage"), System.Drawing.Image)
        Me.keyRedef.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.keyRedef.Cursor = System.Windows.Forms.Cursors.Hand
        Me.keyRedef.FlatAppearance.BorderSize = 0
        Me.keyRedef.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.keyRedef.Location = New System.Drawing.Point(12, 461)
        Me.keyRedef.Name = "keyRedef"
        Me.keyRedef.Size = New System.Drawing.Size(49, 39)
        Me.keyRedef.TabIndex = 12
        Me.keyRedef.Text = "Redef"
        Me.keyRedef.UseVisualStyleBackColor = True
        '
        'btnEnviaTexto
        '
        Me.btnEnviaTexto.Image = CType(resources.GetObject("btnEnviaTexto.Image"), System.Drawing.Image)
        Me.btnEnviaTexto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEnviaTexto.Location = New System.Drawing.Point(664, 313)
        Me.btnEnviaTexto.Name = "btnEnviaTexto"
        Me.btnEnviaTexto.Size = New System.Drawing.Size(111, 38)
        Me.btnEnviaTexto.TabIndex = 0
        Me.btnEnviaTexto.Text = "Send text"
        Me.btnEnviaTexto.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnEnviaTexto.UseVisualStyleBackColor = True
        '
        'btnAtualizaTela
        '
        Me.btnAtualizaTela.Image = CType(resources.GetObject("btnAtualizaTela.Image"), System.Drawing.Image)
        Me.btnAtualizaTela.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAtualizaTela.Location = New System.Drawing.Point(869, 313)
        Me.btnAtualizaTela.Name = "btnAtualizaTela"
        Me.btnAtualizaTela.Size = New System.Drawing.Size(81, 37)
        Me.btnAtualizaTela.TabIndex = 0
        Me.btnAtualizaTela.Text = "Refresh screen"
        Me.btnAtualizaTela.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAtualizaTela.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(664, 271)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(74, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Command text"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(664, 371)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(64, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "DLL version"
        '
        'txtVer
        '
        Me.txtVer.Enabled = False
        Me.txtVer.Location = New System.Drawing.Point(664, 387)
        Me.txtVer.Name = "txtVer"
        Me.txtVer.Size = New System.Drawing.Size(286, 20)
        Me.txtVer.TabIndex = 10
        '
        'frm_Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(994, 578)
        Me.Controls.Add(Me.chkAutoRefresh)
        Me.Controls.Add(Me.chkAtoEnter)
        Me.Controls.Add(Me.txtVer)
        Me.Controls.Add(Me.txtComando)
        Me.Controls.Add(Me.keyEnter)
        Me.Controls.Add(Me.keyPF12)
        Me.Controls.Add(Me.keyPF11)
        Me.Controls.Add(Me.keyDireita)
        Me.Controls.Add(Me.keyDelete)
        Me.Controls.Add(Me.keyCima)
        Me.Controls.Add(Me.keyPF7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.keyBaixo)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.keyEraseEOF)
        Me.Controls.Add(Me.keyPF8)
        Me.Controls.Add(Me.keyHome)
        Me.Controls.Add(Me.keyPF6)
        Me.Controls.Add(Me.keyPA2)
        Me.Controls.Add(Me.keyPF10)
        Me.Controls.Add(Me.keyTAB)
        Me.Controls.Add(Me.keyPF3)
        Me.Controls.Add(Me.keyInsert)
        Me.Controls.Add(Me.keyPF5)
        Me.Controls.Add(Me.keyEsquerda)
        Me.Controls.Add(Me.keyPA1)
        Me.Controls.Add(Me.keyPF9)
        Me.Controls.Add(Me.keybackspace)
        Me.Controls.Add(Me.keyNewLine)
        Me.Controls.Add(Me.keyPF2)
        Me.Controls.Add(Me.keyClear)
        Me.Controls.Add(Me.keyPF4)
        Me.Controls.Add(Me.keyPF1)
        Me.Controls.Add(Me.keyRedef)
        Me.Controls.Add(Me.GrpBox)
        Me.Controls.Add(Me.btnEnviaTexto)
        Me.Controls.Add(Me.SS)
        Me.Controls.Add(Me.txtSaida)
        Me.Controls.Add(Me.btnAtualizaTela)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frm_Main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Extrinha V.1.7"
        Me.GrpBox.ResumeLayout(False)
        Me.GrpBox.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnConecta As System.Windows.Forms.Button
    Friend WithEvents txtSaida As System.Windows.Forms.TextBox
    Friend WithEvents txtIP As System.Windows.Forms.TextBox
    Friend WithEvents txtPorta As System.Windows.Forms.TextBox
    Friend WithEvents SS As System.Windows.Forms.StatusStrip
    Friend WithEvents btnEnviaTexto As System.Windows.Forms.Button
    Friend WithEvents btnAtualizaTela As System.Windows.Forms.Button
    Friend WithEvents btnDesconecta As System.Windows.Forms.Button
    Friend WithEvents lblEstado As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents chkFast As System.Windows.Forms.CheckBox
    Friend WithEvents GrpBox As System.Windows.Forms.GroupBox
    Friend WithEvents cmdSobre As System.Windows.Forms.Button
    Friend WithEvents chkAtoEnter As System.Windows.Forms.CheckBox
    Friend WithEvents txtComando As System.Windows.Forms.TextBox
    Friend WithEvents chkAutoRefresh As System.Windows.Forms.CheckBox
    Friend WithEvents chkRegua As System.Windows.Forms.CheckBox
    Friend WithEvents tRelogio As System.Windows.Forms.Timer
    Friend WithEvents keyRedef As System.Windows.Forms.Button
    Friend WithEvents keyPF1 As System.Windows.Forms.Button
    Friend WithEvents keyPF2 As System.Windows.Forms.Button
    Friend WithEvents keyPF3 As System.Windows.Forms.Button
    Friend WithEvents keyPF4 As System.Windows.Forms.Button
    Friend WithEvents keyPF5 As System.Windows.Forms.Button
    Friend WithEvents keyPF6 As System.Windows.Forms.Button
    Friend WithEvents keyPF7 As System.Windows.Forms.Button
    Friend WithEvents keyPF9 As System.Windows.Forms.Button
    Friend WithEvents keyPF10 As System.Windows.Forms.Button
    Friend WithEvents keyPF8 As System.Windows.Forms.Button
    Friend WithEvents keyPF11 As System.Windows.Forms.Button
    Friend WithEvents keyPF12 As System.Windows.Forms.Button
    Friend WithEvents keyClear As System.Windows.Forms.Button
    Friend WithEvents keyNewLine As System.Windows.Forms.Button
    Friend WithEvents keybackspace As System.Windows.Forms.Button
    Friend WithEvents keyPA1 As System.Windows.Forms.Button
    Friend WithEvents keyInsert As System.Windows.Forms.Button
    Friend WithEvents keyTAB As System.Windows.Forms.Button
    Friend WithEvents keyPA2 As System.Windows.Forms.Button
    Friend WithEvents keyHome As System.Windows.Forms.Button
    Friend WithEvents keyEraseEOF As System.Windows.Forms.Button
    Friend WithEvents keyDelete As System.Windows.Forms.Button
    Friend WithEvents keyEnter As System.Windows.Forms.Button
    Friend WithEvents keyEsquerda As System.Windows.Forms.Button
    Friend WithEvents keyBaixo As System.Windows.Forms.Button
    Friend WithEvents keyCima As System.Windows.Forms.Button
    Friend WithEvents keyDireita As System.Windows.Forms.Button
    Friend WithEvents rdoLU As System.Windows.Forms.RadioButton
    Friend WithEvents rdoIP As System.Windows.Forms.RadioButton
    Friend WithEvents txtLU As System.Windows.Forms.TextBox
    Friend WithEvents txtIPLU As System.Windows.Forms.TextBox
    Friend WithEvents txtPortaLU As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cboTipoTerm As System.Windows.Forms.ComboBox
    Friend WithEvents chkRefuseTN3270E As System.Windows.Forms.CheckBox
    Friend WithEvents chkSSL As System.Windows.Forms.CheckBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtVer As System.Windows.Forms.TextBox

End Class
