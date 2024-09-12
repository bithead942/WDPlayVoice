Module Module1
    Dim Synthesizer1 As New System.Speech.Synthesis.SpeechSynthesizer
    Dim WavPlay1 As New System.Media.SoundPlayer

    Sub Main(ByVal CmdArgs() As String)

        If CmdArgs.Length > 0 Then
            'Door Opened
            If CmdArgs(0) = "1001" Or CmdArgs(0) = "2007" Or CmdArgs(0) = "2011" Or CmdArgs(0) = "2017" Or CmdArgs(0) = "2037" Then
                WavPlay1.SoundLocation() = "c:\Program Files\Watchdog\Door_Opened.wav"
                WavPlay1.PlaySync()
            End If

            'Door Closed
            If CmdArgs(0) = "1002" Or CmdArgs(0) = "2008" Or CmdArgs(0) = "2012" Or CmdArgs(0) = "2018" Or CmdArgs(0) = "2038" Then
                WavPlay1.SoundLocation() = "c:\Program Files\Watchdog\Door_Closed.wav"
                WavPlay1.PlaySync()
            End If

            'Garage Door Opened
            If CmdArgs(0) = "2001" Then
                WavPlay1.SoundLocation() = "c:\Program Files\Watchdog\GDoor_Up.wav"
                WavPlay1.PlaySync()
            End If

            'Garage Door Closed
            If CmdArgs(0) = "2002" Then
                WavPlay1.SoundLocation() = "c:\Program Files\Watchdog\GDoor_Down.wav"
                WavPlay1.PlaySync()
            End If

            'Door Unlocked
            If CmdArgs(0) = "1003" Or CmdArgs(0) = "2009" Or CmdArgs(0) = "2013" Or CmdArgs(0) = "2019" Or CmdArgs(0) = "2039" Then
                WavPlay1.SoundLocation() = "c:\Program Files\Watchdog\Door_Unlocked.wav"
                WavPlay1.PlaySync()
            End If

            'Door Unlocked
            If CmdArgs(0) = "1004" Or CmdArgs(0) = "2010" Or CmdArgs(0) = "2014" Or CmdArgs(0) = "2020" Or CmdArgs(0) = "2040" Then
                WavPlay1.SoundLocation() = "c:\Program Files\Watchdog\Door_Locked.wav"
                WavPlay1.PlaySync()
            End If

            'Motion Detected
            If CmdArgs(0) = "6002" Then
                WavPlay1.SoundLocation() = "c:\Program Files\Watchdog\Motion_Detected.wav"
                WavPlay1.PlaySync()
            End If

            If CmdArgs(0) = "5001" Then
                Synthesizer1.Speak("Youve got Mail")
            End If
        End If

    End Sub

End Module
