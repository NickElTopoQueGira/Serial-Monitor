<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form esegue l'override del metodo Dispose per pulire l'elenco dei componenti.
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

    'Richiesto da Progettazione Windows Form
    Private components As System.ComponentModel.IContainer

    'NOTA: la procedura che segue è richiesta da Progettazione Windows Form
    'Può essere modificata in Progettazione Windows Form.  
    'Non modificarla mediante l'editor del codice.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Comandi = New System.Windows.Forms.TextBox()
        Me.Invia = New System.Windows.Forms.Button()
        Me.Output = New System.Windows.Forms.TextBox()
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.cmbPorte = New System.Windows.Forms.ComboBox()
        Me.Connetti = New System.Windows.Forms.Button()
        Me.Ricarica = New System.Windows.Forms.Button()
        Me.ChiudiSessione = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Connessione = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(34, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Input:"
        '
        'Comandi
        '
        Me.Comandi.Enabled = False
        Me.Comandi.Location = New System.Drawing.Point(53, 8)
        Me.Comandi.Name = "Comandi"
        Me.Comandi.Size = New System.Drawing.Size(389, 20)
        Me.Comandi.TabIndex = 1
        '
        'Invia
        '
        Me.Invia.Enabled = False
        Me.Invia.Location = New System.Drawing.Point(448, 8)
        Me.Invia.Name = "Invia"
        Me.Invia.Size = New System.Drawing.Size(75, 23)
        Me.Invia.TabIndex = 2
        Me.Invia.Text = "Invia"
        Me.Invia.UseVisualStyleBackColor = True
        '
        'Output
        '
        Me.Output.Location = New System.Drawing.Point(16, 39)
        Me.Output.Multiline = True
        Me.Output.Name = "Output"
        Me.Output.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Output.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.Output.Size = New System.Drawing.Size(507, 394)
        Me.Output.TabIndex = 3
        '
        'Timer1
        '
        Me.Timer1.Interval = 500
        '
        'cmbPorte
        '
        Me.cmbPorte.FormattingEnabled = True
        Me.cmbPorte.Location = New System.Drawing.Point(529, 10)
        Me.cmbPorte.Name = "cmbPorte"
        Me.cmbPorte.Size = New System.Drawing.Size(121, 21)
        Me.cmbPorte.TabIndex = 4
        '
        'Connetti
        '
        Me.Connetti.Location = New System.Drawing.Point(656, 10)
        Me.Connetti.Name = "Connetti"
        Me.Connetti.Size = New System.Drawing.Size(75, 23)
        Me.Connetti.TabIndex = 5
        Me.Connetti.Text = "Connetti"
        Me.Connetti.UseVisualStyleBackColor = True
        '
        'Ricarica
        '
        Me.Ricarica.Location = New System.Drawing.Point(737, 10)
        Me.Ricarica.Name = "Ricarica"
        Me.Ricarica.Size = New System.Drawing.Size(75, 23)
        Me.Ricarica.TabIndex = 6
        Me.Ricarica.Text = "Ricarica"
        Me.Ricarica.UseVisualStyleBackColor = True
        '
        'ChiudiSessione
        '
        Me.ChiudiSessione.Location = New System.Drawing.Point(529, 39)
        Me.ChiudiSessione.Name = "ChiudiSessione"
        Me.ChiudiSessione.Size = New System.Drawing.Size(283, 23)
        Me.ChiudiSessione.TabIndex = 7
        Me.ChiudiSessione.Text = "Chiudi Sessione"
        Me.ChiudiSessione.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(548, 163)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 25)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Stato"
        '
        'Connessione
        '
        Me.Connessione.AutoSize = True
        Me.Connessione.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Connessione.ForeColor = System.Drawing.Color.Red
        Me.Connessione.Location = New System.Drawing.Point(545, 209)
        Me.Connessione.Name = "Connessione"
        Me.Connessione.Size = New System.Drawing.Size(251, 46)
        Me.Connessione.TabIndex = 9
        Me.Connessione.Text = "Disconnesso"
        Me.Connessione.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(827, 450)
        Me.Controls.Add(Me.Connessione)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ChiudiSessione)
        Me.Controls.Add(Me.Ricarica)
        Me.Controls.Add(Me.Connetti)
        Me.Controls.Add(Me.cmbPorte)
        Me.Controls.Add(Me.Output)
        Me.Controls.Add(Me.Invia)
        Me.Controls.Add(Me.Comandi)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "Monitor Seriale"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Comandi As TextBox
    Friend WithEvents Invia As Button
    Friend WithEvents Output As TextBox
    Friend WithEvents SerialPort1 As IO.Ports.SerialPort
    Friend WithEvents Timer1 As Timer
    Friend WithEvents cmbPorte As ComboBox
    Friend WithEvents Connetti As Button
    Friend WithEvents Ricarica As Button
    Friend WithEvents ChiudiSessione As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Connessione As Label
End Class
