#Region "Legal"
'************************************************************************************************************************
' Copyright (c) 2013, Todos direitos reservados, Buosi.org - http://www.buosi.org/
'
' Autor........: Carlos Buosi (cbuosi@gmail.com)
' Arquivo......: frm_About.vb
' Tipo.........: Formulario
' Versao.......: 2.02+
' Propósito....: Tela de "About" do sistema
' Uso..........: Não se aplica
' Produto......: xxxxxxx
'
' Legal........: Este código é de propriedade de Carlos Buosi, sua cópia
'                e/ou distribuição é proibida.
'
' GUID.........: {4CDBC0B8-71C5-43D1-A128-CC408BEBD250}
' Observações..: Mostra qual é a versao do sistema.
'
'************************************************************************************************************************
#End Region
Option Explicit On
Option Strict On

Imports System.Drawing.Graphics
Imports System.Drawing.Color
Imports System.Drawing.Brush
Imports System.Drawing.Point

Public Class frm_About

    Dim Egg As Boolean = False

    Protected m_vertices(8) As Point3D
    Protected m_faces(6, 4) As Integer
    Protected m_colors(6) As Color
    Protected m_brushes(6) As Brush
    Protected m_angleX As Integer
    Protected m_angleY As Integer

    Dim iDeslocX As Double = 0
    Dim iDeslocY As Double = 0
    Dim iDeslocZ As Double = 0 '1 a 10

    Public Sub New()
        MyBase.New()
        Try
            Me.DoubleBuffered = True
            Me.SetStyle(ControlStyles.AllPaintingInWmPaint, True)
            Me.SetStyle(ControlStyles.OptimizedDoubleBuffer, True)
            InitializeComponent()
        Catch ex As Exception
        End Try
    End Sub

    Dim sinalX As Double = 1
    Dim sinalY As Double = 1
    Dim sinalZ As Double = 1

    Private Sub frm_About_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        iDeslocX = 0
        iDeslocY = 0
        iDeslocZ = 0 '1 a 10

        Try

            'vSqlite = New SQLite
            lblPrograma.Text = "Extrinha v" & Application.ProductVersion.ToString

            info.Text = "Version: " & Application.ProductVersion.ToString & _
                         "" & vbNewLine & _
                         "Developed in:" & vbNewLine & vbNewLine & _
                         " - VB.NET - Visual Studio 2010 - SP1" & vbNewLine & _
                         vbNewLine & vbNewLine & _
                         "By:" & vbNewLine & _
                         "" & vbNewLine & _
                         " Carlos Buosi - cbuosi@gmail.com "

            'Somente mostra as viadagens se entrar na tela com o Control apertado
            'OvoDePascoa = My.Computer.Keyboard.CtrlKeyDown
            Egg = True

            If (Egg) Then
                InitCube()
                tReloginhoCB.Enabled = True
            Else
                tReloginhoCB.Enabled = False
            End If

        Catch ex As Exception
            '
        Finally
            'vSqlite.Dispose()
            'vSqlite = Nothing
        End Try

    End Sub

    Private Sub PictureBox1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs)
        'SAUC_MsgBox(strDeveloper, vbOKOnly, , , vbExclamation)
    End Sub


    Private Sub Pinta(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint

        If (Egg) Then

            Dim t(8) As Point3D
            Dim f(4) As Integer
            Dim v As Point3D
            Dim avgZ(6) As Double
            Dim order(6) As Integer
            Dim tmp As Double
            Dim iMax As Integer

            ' Clear the window
            'e.Graphics.Clear(Color.LightBlue)

            ' Transform all the points and store them on the "t" array.
            For i = 0 To 7
                Dim b As Brush = New SolidBrush(Color.White)
                v = m_vertices(i)
                t(i) = v.RotateX(m_angleX).RotateY(m_angleY).RotateZ(Me.m_angleX)
                'original t(i) = CType(t(i).Project(Me.ClientSize.Width + iDeslocX, Me.ClientSize.Height + iDeslocY, 256, 12 + iDeslocZ), Point3D)
                t(i) = CType(t(i).Project(iDeslocX, iDeslocY, 256, 8 + iDeslocZ), Point3D)
            Next

            ' Compute the average Z value of each face.
            For i = 0 To 5
                avgZ(i) = (t(m_faces(i, 0)).Z + t(m_faces(i, 1)).Z + t(m_faces(i, 2)).Z + t(m_faces(i, 3)).Z) / 4.0
                order(i) = i
            Next

            ' Next we sort the faces in descending order based on the Z value.
            ' The objective is to draw distant faces first. This is called 
            ' the PAINTERS ALGORITHM. So, the visible faces will hide the invisible ones.
            ' The sorting algorithm used is the SELECTION SORT.
            For i = 0 To 4
                iMax = i
                For j = i + 1 To 5
                    If avgZ(j) > avgZ(iMax) Then
                        iMax = j
                    End If
                Next
                If iMax <> i Then
                    tmp = avgZ(i)
                    avgZ(i) = avgZ(iMax)
                    avgZ(iMax) = tmp

                    tmp = order(i)
                    order(i) = order(iMax)
                    order(iMax) = CInt(tmp)
                End If
            Next

            ' Draw the faces using the PAINTERS ALGORITHM (distant faces first, closer faces last).
            For i = 0 To 5
                Dim points() As Point
                Dim index As Integer = order(i)
                points = New Point() {
                    New Point(CInt(t(m_faces(index, 0)).X), CInt(t(m_faces(index, 0)).Y)),
                    New Point(CInt(t(m_faces(index, 1)).X), CInt(t(m_faces(index, 1)).Y)),
                    New Point(CInt(t(m_faces(index, 2)).X), CInt(t(m_faces(index, 2)).Y)),
                    New Point(CInt(t(m_faces(index, 3)).X), CInt(t(m_faces(index, 3)).Y))
                }
                e.Graphics.FillPolygon(m_brushes(index), points)
            Next
        End If

    End Sub

    Private Sub AnimationLoop()
        ' Forces the Paint event to be called.
        Me.Invalidate()
        ' Update the variable after each frame.
        m_angleX += 2
        m_angleY += 1
    End Sub

    Private Sub InitCube()
        ' Create the cube vertices.
        m_vertices = New Point3D() {
                     New Point3D(-1.0, 1.0, -1.0),
                     New Point3D(1.0, 1.0, -1.0),
                     New Point3D(1.0, -1.0, -1.0),
                     New Point3D(-1.0, -1.0, -1.0),
                     New Point3D(-1.0, 1.0, 1.0),
                     New Point3D(1.0, 1.0, 1.0),
                     New Point3D(1.0, -1.0, 1.0),
                     New Point3D(-1.0, -1.0, 1.0)}

        ' Create an array representing the 6 faces of a cube. Each face is composed by indices to the vertex array
        ' above.
        m_faces = New Integer(,) {{0, 1, 2, 3},
                                  {1, 5, 6, 2},
                                  {5, 4, 7, 6},
                                  {4, 0, 3, 7},
                                  {0, 4, 5, 1},
                                  {3, 2, 6, 7}}

        'Branco      - 
        'Azul        -
        'Verde       -
        'Laranja     -
        'Amarelo     -
        'Vermelho    -


        ' Define the colors of each face.
        m_colors = New Color() {Color.White,
                                Color.Blue,
                                Color.Green,
                                Color.Orange,
                                Color.Yellow,
                                Color.Red}

        ' Create the brushes to draw each face. Brushes are used to draw filled polygons.
        For i = 0 To 5
            m_brushes(i) = New SolidBrush(m_colors(i))
        Next

    End Sub


    Private Sub tReloginhoCB_Tick(sender As System.Object, e As System.EventArgs) Handles tReloginhoCB.Tick

        AnimationLoop()

        iDeslocX += (4 * sinalX)
        iDeslocY += (7.8 * sinalY)
        iDeslocZ += (0.1 * sinalZ)

        'Debug.Print(iDeslocX & " - " & iDeslocY & " - " & iDeslocZ)
        '380; 474


        If iDeslocZ > 30 And sinalZ = 1 Then
            sinalZ = -1
        End If

        If iDeslocZ < 0 And sinalZ = -1 Then
            sinalZ = 1
        End If

        If iDeslocX > 650 And sinalX = 1 Then
            sinalX = -1
        End If

        If iDeslocX < 0 And sinalX = -1 Then
            sinalX = 1
        End If

        If iDeslocY > 700 And sinalY = 1 Then
            sinalY = -1
        End If
        If iDeslocY < 0 And sinalY = -1 Then
            sinalY = 1
        End If

    End Sub

    Private Sub btnVoltar_Click(sender As System.Object, e As System.EventArgs) Handles btnVoltar.Click
        Me.Close()
    End Sub
End Class

Public Class Point3D
    Protected m_x As Double, m_y As Double, m_z As Double

    Public Sub New(ByVal x As Double, ByVal y As Double, ByVal z As Double)
        Me.X = x
        Me.Y = y
        Me.Z = z
    End Sub

    Public Property X() As Double
        Get
            Return m_x
        End Get
        Set(ByVal value As Double)
            m_x = value
        End Set
    End Property

    Public Property Y() As Double
        Get
            Return m_y
        End Get
        Set(ByVal value As Double)
            m_y = value
        End Set
    End Property

    Public Property Z() As Double
        Get
            Return m_z
        End Get
        Set(ByVal value As Double)
            m_z = value
        End Set
    End Property

    Public Function RotateX(ByVal angle As Integer) As Point3D
        Dim rad As Double, cosa As Double, sina As Double, yn As Double, zn As Double

        rad = angle * Math.PI / 180
        cosa = Math.Cos(rad)
        sina = Math.Sin(rad)
        yn = Me.Y * cosa - Me.Z * sina
        zn = Me.Y * sina + Me.Z * cosa

        Return New Point3D(Me.X, yn, zn)
    End Function

    Public Function RotateY(ByVal angle As Integer) As Point3D
        Dim rad As Double, cosa As Double, sina As Double, Xn As Double, Zn As Double

        rad = angle * Math.PI / 180
        cosa = Math.Cos(rad)
        sina = Math.Sin(rad)
        Zn = Me.Z * cosa - Me.X * sina
        Xn = Me.Z * sina + Me.X * cosa

        Return New Point3D(Xn, Me.Y, Zn)
    End Function

    Public Function RotateZ(ByVal angle As Integer) As Point3D
        Dim rad As Double, cosa As Double, sina As Double, Xn As Double, Yn As Double

        rad = angle * Math.PI / 180
        cosa = Math.Cos(rad)
        sina = Math.Sin(rad)
        Xn = Me.X * cosa - Me.Y * sina
        Yn = Me.X * sina + Me.Y * cosa
        Return New Point3D(Xn, Yn, Me.Z)
    End Function

    Public Function Project(ByVal viewWidth As Double,
                            ByVal viewHeight As Double,
                            ByVal fov As Double,
                            ByVal viewDistance As Double) As Object

        Dim factor As Double, Xn As Double, Yn As Double
        factor = fov / (viewDistance + Me.Z)
        Xn = Me.X * factor + viewWidth / 2
        Yn = Me.Y * factor + viewHeight / 2
        Return New Point3D(Xn, Yn, Me.Z)
    End Function
End Class
