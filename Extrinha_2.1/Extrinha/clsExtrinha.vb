Option Explicit On
Option Strict On

Imports Open3270
Imports System.Text
Imports System.IO
Imports System.Reflection

Public Class clsExtrinha
    Inherits TNEmulator

    Public Sub New()
        Try
            Me.Config.FastScreenMode = True
            Me.Config.DefaultTimeout = 2000
            Me.Debug = True
            Me.Config.TermType = "IBM-3278-2-E" '"IBM-3278-2-E" 'IBM-3278-2
            Me.Config.RefuseTN3270E = True '????
            Me.Config.ThrowExceptionOnLockedScreen = False
        Catch ex As Exception
            MsgBox("Error in " & MethodName(Me) & " : " & ex.Message)
        End Try
    End Sub

    Public Sub New(ByVal _TermType As String,
                   ByVal _FastScreenMode As Boolean,
                   ByVal _RefuseTN3270E As Boolean,
                   ByVal _UseSSL As Boolean)

        Try

            Me.Config.FastScreenMode = _FastScreenMode
            Me.Config.DefaultTimeout = 3000
#If DEBUG Then
            Me.Debug = True
#Else
            Me.Debug = false
#End If
            Me.Config.TermType = _TermType
            Me.Config.RefuseTN3270E = _RefuseTN3270E '???
            Me.Config.ThrowExceptionOnLockedScreen = False
            Me.UseSSL = _UseSSL

        Catch ex As Exception
            MsgBox("Error in " & MethodName(Me) & " : " & ex.Message)
        End Try


    End Sub

    Public Function Conected() As Boolean
        Return Me.IsConnected
    End Function

    Sub ConnectTo(ByVal strServer As String, ByVal iPort As Integer)
        Try
            If Me.Conected = True Then
                Me.Disconnect()
            End If
            Me.Connect(strServer, iPort, Nothing)
        Catch ex As Exception
            MsgBox("Error in " & MethodName(Me) & " : " & ex.Message)
        End Try
    End Sub

    Sub ConnectTo(ByVal strServer As String, ByVal iPort As Integer, ByVal strLu As String)
        Try
            If Me.Conected = True Then
                Me.Disconnect()
            End If
            Me.Connect(strServer, iPort, strLu)
        Catch ex As Exception
            MsgBox("Error in " & MethodName(Me) & " : " & ex.Message)
        End Try
    End Sub

    Sub Update()
        Me.Refresh()
    End Sub

    Function WaitFor(ByVal X As Integer, _
                     ByVal Y As Integer, _
                     ByVal strText As String, _
                     Optional ByVal Timeout As Integer = 20000) As Boolean
        Try

            If Me.Conected = True Then
                Return Me.WaitForText(X, Y, strText, Timeout)
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox("Error in " & MethodName(Me) & " : " & ex.Message)
            Return False
        End Try
    End Function

    Public Function SendTxt(ByVal strTexto As String) As Boolean
        Try
            If Me.Conected = True Then
                Me.SendText(strTexto)
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox("Error in " & MethodName(Me) & " : " & ex.Message)
            Return False
        End Try

    End Function

    Public Sub Disconnect()
        Try
            If Me.Conected = True Then
                Me.Close()
            End If
        Catch ex As Exception
            MsgBox("Error in " & MethodName(Me) & " : " & ex.Message)
        End Try
    End Sub


    Function GetFormatedScreen(Optional ByVal bRuler As Boolean = False) As String

        Try


            Dim vScreen() As String
            Dim txtOutput As String = ""

            If Me.Conected() = False Then
                Return ""
            End If


            Me.Update()

            Dim tot As Integer = 0

            vScreen = Me.CurrentScreenXML.GetUnformatedStrings()

            For i = 0 To 23 Step 1
                If vScreen(i).ToString.Length > 80 Then
                    vScreen(i) = vScreen(i).Substring(0, 80)
                End If
            Next i

            ReDim Preserve vScreen(23)

            If Me.CursorY <= 23 Then
                If Trim(vScreen(Me.CursorY)) = "" Then
                    vScreen(Me.CursorY) = "                                                                                "
                End If
                vScreen(Me.CursorY) = ChangeChar(vScreen(Me.CursorY), CChar("█"), Me.CursorX)
            End If


            If bRuler = True Then
                txtOutput += "++12345678901234567890123456789012345678901234567890123456789012345678901234567890++" & vbNewLine
            End If


            For Each strScreenLine As String In vScreen

                tot += 1

                If strScreenLine = "" Then
                    txtOutput += IIf(bRuler, tot.ToString("d2"), "").ToString() & "                                                                                " & IIf(bRuler, tot.ToString("d2"), "").ToString() & vbNewLine
                Else
                    txtOutput += IIf(bRuler, tot.ToString("d2"), "").ToString() & strScreenLine & IIf(bRuler, tot.ToString("d2"), "").ToString() & vbNewLine
                End If

            Next strScreenLine

            If bRuler = True Then
                txtOutput += "++12345678901234567890123456789012345678901234567890123456789012345678901234567890++" & vbNewLine
            End If

            Return txtOutput

        Catch ex As Exception
            MsgBox("Error in " & MethodName(Me) & " : " & ex.Message)
            Return "Error in " & MethodName(Me) & " : " & ex.Message
        End Try

    End Function

    Private Function ChangeChar(ByVal s As String, ByVal replaceWith As Char, idx As Integer) As String
        Try
            Dim sb As New StringBuilder(s)
            'now do some replacing
            sb(idx) = replaceWith
            Return sb.ToString()
        Catch ex As Exception
            MsgBox("Error in " & MethodName(Me) & " : " & ex.Message)
            Return "Error in " & MethodName(Me) & " : " & ex.Message
        End Try
    End Function

    Public Function PositionCursor(ByVal X As Integer, ByVal Y As Integer) As Boolean
        Try

            If Me.Conected = True Then
                Me.SetCursor(X, Y)
                Return True
            Else
                Return False
            End If

        Catch ex As Exception
            MsgBox("Error in " & MethodName(Me) & " : " & ex.Message)
            Return False
        End Try

    End Function

    Public Function TeclaEnter(Optional ByVal EsperaAtualizarTela As Boolean = True) As Boolean
        If Me.Conected = True Then
            Me.SendKeyFromText(EsperaAtualizarTela, "Enter")
            Return True
        Else
            Return False
        End If
    End Function

    Public Function TeclaDireita(Optional ByVal AtualizaTela As Boolean = False) As Boolean
        If Me.Conected() = False Then
            Return False
        Else
            Me.SendKeyFromText(AtualizaTela, "Right")
            Return True
        End If
    End Function

    Public Function TeclaEsquerda(Optional ByVal AtualizaTela As Boolean = False) As Boolean
        If Me.Conected() = False Then
            Return False
        Else
            Me.SendKeyFromText(AtualizaTela, "Left")
            Return True
        End If
    End Function

    Public Function TeclaCima(Optional ByVal AtualizaTela As Boolean = False) As Boolean
        'Private Sub keyEsquerda_Click(sender As System.Object, e As System.EventArgs) Handles keyEsquerda.Click
        If Me.Conected() = False Then
            Return False
        Else
            Me.SendKeyFromText(AtualizaTela, "Up")
            Return True
        End If
    End Function

    Public Function TeclaBaixo(Optional ByVal AtualizaTela As Boolean = False) As Boolean
        'Private Sub keyEsquerda_Click(sender As System.Object, e As System.EventArgs) Handles keyEsquerda.Click
        If Me.Conected() = False Then
            Return False
        Else
            Me.SendKeyFromText(AtualizaTela, "Down")
            Return True
        End If
    End Function

    Public Function TeclaPF1(Optional ByVal EsperaAtualizarTela As Boolean = False) As Boolean
        If Me.Conected = True Then
            Me.SendKeyFromText(EsperaAtualizarTela, "PF01")
            Return True
        Else
            Return False
        End If
    End Function

    Public Function TeclaPF2(Optional ByVal EsperaAtualizarTela As Boolean = False) As Boolean
        If Me.Conected = True Then
            Me.SendKeyFromText(EsperaAtualizarTela, "PF02")
            Return True
        Else
            Return False
        End If
    End Function

    Public Function TeclaPF3(Optional ByVal EsperaAtualizarTela As Boolean = False) As Boolean
        If Me.Conected = True Then
            Me.SendKeyFromText(EsperaAtualizarTela, "PF03")
            Return True
        Else
            Return False
        End If
    End Function

    Public Function TeclaPF4(Optional ByVal EsperaAtualizarTela As Boolean = False) As Boolean
        If Me.Conected = True Then
            Me.SendKeyFromText(EsperaAtualizarTela, "PF04")
            Return True
        Else
            Return False
        End If
    End Function

    Public Function TeclaPF5(Optional ByVal EsperaAtualizarTela As Boolean = False) As Boolean
        If Me.Conected = True Then
            Me.SendKeyFromText(EsperaAtualizarTela, "PF05")
            Return True
        Else
            Return False
        End If
    End Function

    Public Function TeclaPF6(Optional ByVal EsperaAtualizarTela As Boolean = False) As Boolean
        If Me.Conected = True Then
            Me.SendKeyFromText(EsperaAtualizarTela, "PF06")
            Return True
        Else
            Return False
        End If
    End Function

    Public Function TeclaPF7(Optional ByVal EsperaAtualizarTela As Boolean = False) As Boolean
        If Me.Conected = True Then
            Me.SendKeyFromText(EsperaAtualizarTela, "PF07")
            Return True
        Else
            Return False
        End If
    End Function

    Public Function TeclaPF8(Optional ByVal EsperaAtualizarTela As Boolean = False) As Boolean
        If Me.Conected = True Then
            Me.SendKeyFromText(EsperaAtualizarTela, "PF08")
            Return True
        Else
            Return False
        End If
    End Function

    Public Function TeclaPF9(Optional ByVal EsperaAtualizarTela As Boolean = False) As Boolean
        If Me.Conected = True Then
            Me.SendKeyFromText(EsperaAtualizarTela, "PF09")
            Return True
        Else
            Return False
        End If
    End Function

    Public Function TeclaPF10(Optional ByVal EsperaAtualizarTela As Boolean = False) As Boolean
        If Me.Conected = True Then
            Me.SendKeyFromText(EsperaAtualizarTela, "PF10")
            Return True
        Else
            Return False
        End If
    End Function

    Public Function TeclaPF11(Optional ByVal EsperaAtualizarTela As Boolean = False) As Boolean
        If Me.Conected = True Then
            Me.SendKeyFromText(EsperaAtualizarTela, "PF11")
            Return True
        Else
            Return False
        End If
    End Function

    Public Function TeclaPF12(Optional ByVal EsperaAtualizarTela As Boolean = False) As Boolean
        If Me.Conected = True Then
            Me.SendKeyFromText(EsperaAtualizarTela, "PF12")
            Return True
        Else
            Return False
        End If
    End Function

    Public Function TeclaReset(Optional ByVal EsperaAtualizarTela As Boolean = False) As Boolean
        If Me.Conected = True Then
            Me.SendKeyFromText(EsperaAtualizarTela, "Reset")
            Return True
        Else
            Return False
        End If
    End Function

    Public Function TeclaClear(Optional ByVal EsperaAtualizarTela As Boolean = False) As Boolean
        If Me.Conected = True Then
            Me.SendKeyFromText(EsperaAtualizarTela, "clear")
            Return True
        Else
            Return False
        End If
    End Function


    Public Function TeclaBackspace(Optional ByVal EsperaAtualizarTela As Boolean = False) As Boolean
        If Me.Conected = True Then
            Me.SendKeyFromText(EsperaAtualizarTela, "backspace")
            Return True
        Else
            Return False
        End If
    End Function


    Public Function TeclaNewLine(Optional ByVal EsperaAtualizarTela As Boolean = False) As Boolean
        If Me.Conected = True Then
            Me.SendKeyFromText(EsperaAtualizarTela, "Newline")
            Return True
        Else
            Return False
        End If
    End Function

    Public Function TeclaInsert(Optional ByVal EsperaAtualizarTela As Boolean = False) As Boolean
        If Me.Conected = True Then
            Me.SendKeyFromText(EsperaAtualizarTela, "insert")
            Return True
        Else
            Return False
        End If
    End Function

    Public Function TeclaHome(Optional ByVal EsperaAtualizarTela As Boolean = False) As Boolean
        If Me.Conected = True Then
            Me.SendKeyFromText(EsperaAtualizarTela, "home")
            Return True
        Else
            Return False
        End If
    End Function


    Public Function TeclaDelete(Optional ByVal EsperaAtualizarTela As Boolean = False) As Boolean
        If Me.Conected = True Then
            Me.SendKeyFromText(EsperaAtualizarTela, "delete")
            Return True
        Else
            Return False
        End If
    End Function


    Public Function TeclaEraseEOF(Optional ByVal EsperaAtualizarTela As Boolean = False) As Boolean
        If Me.Conected = True Then
            Me.SendKeyFromText(EsperaAtualizarTela, "eraseeof")
            Return True
        Else
            Return False
        End If
    End Function

    Public Function TeclaPA2(Optional ByVal EsperaAtualizarTela As Boolean = False) As Boolean
        If Me.Conected = True Then
            Me.SendKeyFromText(EsperaAtualizarTela, "PA2")
            Return True
        Else
            Return False
        End If
    End Function


    Public Function TeclaPA1(Optional ByVal EsperaAtualizarTela As Boolean = False) As Boolean
        If Me.Conected = True Then
            Me.SendKeyFromText(EsperaAtualizarTela, "PA1")
            Return True
        Else
            Return False
        End If
    End Function

    Public Function TeclaTAB(Optional ByVal EsperaAtualizarTela As Boolean = False) As Boolean
        If Me.Conected = True Then
            Me.SendKeyFromText(EsperaAtualizarTela, "TAB")
            Return True
        Else
            Return False
        End If
    End Function

    Shared Function GetVersion() As String
        Try
            Return TNEmulator.GetBuildName()
        Catch ex As Exception
            Return "NO VERSION, PLEASE VERIFY"
        End Try
    End Function

    Public Function MethodName(ByVal oObject As Object) As String

        Dim stackTrace As StackTrace
        Dim stackFrame As StackFrame
        Dim methodBase As MethodBase

        Try

            stackTrace = New StackTrace()
            stackFrame = stackTrace.GetFrame(1)
            methodBase = stackFrame.GetMethod()

            Return oObject.GetType().Name & "::" & methodBase.Name

        Catch ex As Exception
            Return "Error in MethodName: " & ex.Message
        End Try

    End Function

End Class
