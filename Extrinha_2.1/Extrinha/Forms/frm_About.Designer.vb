<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_About
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_About))
        Me.tReloginhoCB = New System.Windows.Forms.Timer(Me.components)
        Me.lblPrograma = New System.Windows.Forms.Label()
        Me.btnVoltar = New System.Windows.Forms.Button()
        Me.info = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tReloginhoCB
        '
        Me.tReloginhoCB.Interval = 10
        '
        'lblPrograma
        '
        Me.lblPrograma.BackColor = System.Drawing.Color.Transparent
        Me.lblPrograma.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrograma.Location = New System.Drawing.Point(65, 14)
        Me.lblPrograma.Name = "lblPrograma"
        Me.lblPrograma.Size = New System.Drawing.Size(254, 42)
        Me.lblPrograma.TabIndex = 13
        Me.lblPrograma.Text = "Estra v1.o"
        Me.lblPrograma.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnVoltar
        '
        Me.btnVoltar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVoltar.Location = New System.Drawing.Point(81, 286)
        Me.btnVoltar.Name = "btnVoltar"
        Me.btnVoltar.Size = New System.Drawing.Size(168, 43)
        Me.btnVoltar.TabIndex = 14
        Me.btnVoltar.Text = "OK"
        Me.btnVoltar.UseVisualStyleBackColor = True
        '
        'info
        '
        Me.info.BackColor = System.Drawing.Color.Transparent
        Me.info.Location = New System.Drawing.Point(12, 66)
        Me.info.Name = "info"
        Me.info.Size = New System.Drawing.Size(307, 214)
        Me.info.TabIndex = 12
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(5, Byte), Integer))
        Me.PictureBox1.Image = Global.My.Resources.Resources.question
        Me.PictureBox1.Location = New System.Drawing.Point(27, 18)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 15
        Me.PictureBox1.TabStop = False
        '
        'frm_About
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(331, 341)
        Me.ControlBox = False
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.info)
        Me.Controls.Add(Me.btnVoltar)
        Me.Controls.Add(Me.lblPrograma)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_About"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = ".: About :."
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tReloginhoCB As System.Windows.Forms.Timer
    Friend WithEvents lblPrograma As System.Windows.Forms.Label
    Friend WithEvents btnVoltar As System.Windows.Forms.Button
    Friend WithEvents info As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox

End Class
