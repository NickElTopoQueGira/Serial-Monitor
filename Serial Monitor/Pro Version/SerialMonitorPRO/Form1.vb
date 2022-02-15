' @author: NickElTopoQueGira

' Note del tizio che scrive il programma(Ovvero io): 
' La fase di ricerca delle porte all'inizio del programma la si puo' automatizzare con un timer
' in questo caso non e' stato fatto, e' l'utente che deve cliccare sul pulsante per ricaricare l'elenco


'importazione delle librerie
Imports System.IO.Ports
Imports System.Windows.Forms


Public Class Form1

    'Caricamento del Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'caricamento delle porte disponibili
        cmbPort.Items.AddRange(IO.Ports.SerialPort.GetPortNames())
        'opzione di default della porta seriale
        cmbBaudRate.Text = "9600"
    End Sub

    'Ricarico delle porse seriali
    Private Sub reloadBtn_Click(sender As Object, e As EventArgs) Handles reloadBtn.Click
        'ricarico delle porte
        cmbPort.Items.Clear()
        cmbPort.Items.AddRange(IO.Ports.SerialPort.GetPortNames())
    End Sub

    'Connessione
    Private Sub connectBtn_Click(sender As Object, e As EventArgs) Handles connectBtn.Click

        'Banda della connessione
        Dim var As Integer
        Dim baudRate As Integer = 0

        var = Integer.Parse(cmbBaudRate.SelectedIndex)

        Select Case var
            Case 0
                Debug.WriteLine("300")
                baudRate = 300
            Case 1
                Debug.WriteLine("1200")
                baudRate = 1200
            Case 2
                Debug.WriteLine("2400")
                baudRate = 2400
            Case 3
                Debug.WriteLine("4800")
                baudRate = 4800
            Case 4
                Debug.WriteLine("9600")
                baudRate = 9600
            Case 5
                Debug.WriteLine("19200")
                baudRate = 19200
            Case 6
                Debug.WriteLine("38400")
                baudRate = 38400
            Case 7
                Debug.WriteLine("57600")
                baudRate = 57600
            Case 8
                Debug.WriteLine("74880")
                baudRate = 74880
            Case 9
                Debug.WriteLine("115200")
                baudRate = 115200
            Case 10
                Debug.WriteLine("230400")
                baudRate = 230400
            Case 11
                Debug.WriteLine("250000")
                baudRate = 250000
            Case 12
                Debug.WriteLine("500000")
                baudRate = 500000
            Case 13
                Debug.WriteLine("1000000")
                baudRate = 1000000
            Case 14
                Debug.WriteLine("2000000")
                baudRate = 2000000
        End Select

        'Connessione
        If cmbPort.Text <> "" Then
            Try
                'inizio della connessione
                SerialPort1.Encoding = System.Text.Encoding.Default
                SerialPort1.PortName = cmbPort.Text
                SerialPort1.BaudRate = baudRate
                SerialPort1.Open()

                'cambio dell'indicatore di stato
                statusDimTxt.Text = "Connected"
                statusDimTxt.ForeColor = Color.Green

                'disattivazione dei pulsanti di connessione e di ricarica
                connectBtn.Enabled = False
                reloadBtn.Enabled = False

                'attivazione del pulsante della disconnessione
                closeConBtn.Enabled = True

                'abilitazione degli strumenti per il trattamentro dei dati
                commandTxt.Enabled = True
                sendBtn.Enabled = True
                Timer1.Start()
                outputTxt.Clear()
                commandTxt.Clear()
            Catch ex As Exception
                MsgBox("Error" & ex.Message, MsgBoxStyle.Critical)
            End Try

        Else
            MsgBox("Please select a serial port", MsgBoxStyle.Critical)
        End If

    End Sub

    'Chiusura della connessione
    Private Sub closeConBtn_Click(sender As Object, e As EventArgs) Handles closeConBtn.Click
        'Chiusura della comunicazione
        SerialPort1.Close()

        'Spegnimento del timer
        Timer1.Stop()

        'Cambiamento degli stati
        statusDimTxt.Text = "Disconnect"
        statusDimTxt.ForeColor = Color.Red

        'disattivazione dei pulsanti
        closeConBtn.Enabled = False

        'attivazione dei pulsanti
        reloadBtn.Enabled = True
        connectBtn.Enabled = True

    End Sub

    'invio dei comandi
    Private Sub commandTxt_TextChanged(sender As Object, e As EventArgs) Handles commandTxt.TextChanged
        SerialPort1.Write(commandTxt.Text)
    End Sub
    Private Sub sendBtn_Click(sender As Object, e As EventArgs) Handles sendBtn.Click
        SerialPort1.Write(commandTxt.Text)
    End Sub

    'Configurazione del timer per la recezione dei file
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim str As String
        str = riceviDati()
        outputTxt.Text += str
    End Sub

    'visualizzazione dei dati
    Private Sub outputTxt_TextChanged(sender As Object, e As EventArgs) Handles outputTxt.TextChanged
        'outputTxt.TextAlign = newLineCHB.AutoCheck()
        outputTxt.Select(outputTxt.TextLength, 0)
        outputTxt.ScrollToCaret()
    End Sub

    'Pulizia dei dati visualizzati
    Private Sub clearOutputBtn_Click(sender As Object, e As EventArgs) Handles clearOutputBtn.Click
        outputTxt.Clear()
    End Sub

    'Ricevimento dei dati
    Function riceviDati() As String
        Dim DatiRicevuti As String
        Try
            DatiRicevuti = SerialPort1.ReadExisting
            If DatiRicevuti <> "" Then
                Return DatiRicevuti
            End If
        Catch ex As Exception
            Return "Errore: " & ex.Message
        End Try
    End Function

    'salvataggio dei dati 
    Private Sub saveLogBtn_Click(sender As Object, e As EventArgs) Handles saveLogBtn.Click

        If outputTxt.Text.Length > 0 Then
            'SaveFileDialog1.DefaultExt = ".txt"
            SaveFileDialog1.ShowDialog()
            System.IO.File.WriteAllText(SaveFileDialog1.FileName, outputTxt.Text)
        End If

    End Sub


End Class
