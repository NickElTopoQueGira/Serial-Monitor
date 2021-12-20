Imports System.IO.Ports
Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbPorte.Items.AddRange(IO.Ports.SerialPort.GetPortNames())
    End Sub

    Private Sub Ricarica_Click(sender As Object, e As EventArgs) Handles Ricarica.Click
        cmbPorte.Items.Clear()
        cmbPorte.Items.AddRange(IO.Ports.SerialPort.GetPortNames())
    End Sub

    Private Sub Connetti_Click(sender As Object, e As EventArgs) Handles Connetti.Click
        If cmbPorte.Text <> "" Then
            Try
                SerialPort1.Encoding = System.Text.Encoding.Default
                SerialPort1.PortName = cmbPorte.Text
                SerialPort1.Open()
                Connessione.Text = "Connesso"
                Connessione.ForeColor = Color.Green
                Connetti.Enabled = False
                Ricarica.Enabled = False
                Comandi.Enabled = True
                Invia.Enabled = True
                Timer1.Start()
                Output.Clear()
                Comandi.Clear()
            Catch ex As Exception
                MsgBox("Errore" & ex.Message, MsgBoxStyle.Critical)
            End Try
        End If
    End Sub

    Private Sub ChiudiSessione_Click(sender As Object, e As EventArgs) Handles ChiudiSessione.Click
        SerialPort1.Close()
        Connessione.Text = "Disconnesso"
        Connessione.ForeColor = Color.Red
        ChiudiSessione.Enabled = False
        Invia.Enabled = False
        Comandi.Enabled = False
        Timer1.Stop()
        Connetti.Enabled = True
        Ricarica.Enabled = True
    End Sub

    Private Sub Comandi_TextChanged(sender As Object, e As EventArgs) Handles Comandi.TextChanged
        SerialPort1.Write(Comandi.Text)
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim str As String
        str = RiceviDati()
        Output.Text += str
    End Sub

    Function RiceviDati() As String
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

    Private Sub Output_TextChanged(sender As Object, e As EventArgs) Handles Output.TextChanged
        Output.Select(Output.TextLength, 0)
        Output.ScrollToCaret()
    End Sub
End Class
