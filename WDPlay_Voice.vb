Module Module1
    Dim Synthesizer1 As New System.Speech.Synthesis.SpeechSynthesizer

    Sub Main(ByVal CmdArgs() As String)
        Dim i As Integer
        Dim strVoice As String

        strVoice = ""
        If CmdArgs.Length > 0 Then
            For i = 0 To (CmdArgs.Length - 1)
                strVoice = strVoice & " " & CmdArgs(i)
            Next i
            Try
                Synthesizer1.Speak(strVoice)
            Catch ex As System.Exception
                Exit Sub
            End Try
        End If

    End Sub

End Module
