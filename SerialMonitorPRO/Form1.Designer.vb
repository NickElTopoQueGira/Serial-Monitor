<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.cmbPort = New System.Windows.Forms.ComboBox()
        Me.portTxt = New System.Windows.Forms.Label()
        Me.statusTxt = New System.Windows.Forms.Label()
        Me.statusDimTxt = New System.Windows.Forms.Label()
        Me.reloadBtn = New System.Windows.Forms.Button()
        Me.connectBtn = New System.Windows.Forms.Button()
        Me.closeConBtn = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.baudRateTxt = New System.Windows.Forms.Label()
        Me.cmbBaudRate = New System.Windows.Forms.ComboBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.sendBtn = New System.Windows.Forms.Button()
        Me.commandTxt = New System.Windows.Forms.TextBox()
        Me.dataToSendTxt = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.saveLogBtn = New System.Windows.Forms.Button()
        Me.clearOutputBtn = New System.Windows.Forms.Button()
        Me.outputTxt = New System.Windows.Forms.TextBox()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Timer1
        '
        '
        'cmbPort
        '
        Me.cmbPort.FormattingEnabled = True
        Me.cmbPort.Location = New System.Drawing.Point(135, 29)
        Me.cmbPort.Name = "cmbPort"
        Me.cmbPort.Size = New System.Drawing.Size(121, 21)
        Me.cmbPort.TabIndex = 0
        '
        'portTxt
        '
        Me.portTxt.AutoSize = True
        Me.portTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.portTxt.Location = New System.Drawing.Point(11, 30)
        Me.portTxt.Name = "portTxt"
        Me.portTxt.Size = New System.Drawing.Size(81, 17)
        Me.portTxt.TabIndex = 1
        Me.portTxt.Text = " COM Port: "
        '
        'statusTxt
        '
        Me.statusTxt.AutoSize = True
        Me.statusTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.statusTxt.Location = New System.Drawing.Point(11, 177)
        Me.statusTxt.Name = "statusTxt"
        Me.statusTxt.Size = New System.Drawing.Size(56, 17)
        Me.statusTxt.TabIndex = 2
        Me.statusTxt.Text = "Status: "
        '
        'statusDimTxt
        '
        Me.statusDimTxt.AutoSize = True
        Me.statusDimTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.statusDimTxt.ForeColor = System.Drawing.Color.Red
        Me.statusDimTxt.Location = New System.Drawing.Point(116, 177)
        Me.statusDimTxt.Name = "statusDimTxt"
        Me.statusDimTxt.Size = New System.Drawing.Size(78, 17)
        Me.statusDimTxt.TabIndex = 3
        Me.statusDimTxt.Text = "Disconnect"
        '
        'reloadBtn
        '
        Me.reloadBtn.Location = New System.Drawing.Point(135, 112)
        Me.reloadBtn.Name = "reloadBtn"
        Me.reloadBtn.Size = New System.Drawing.Size(121, 23)
        Me.reloadBtn.TabIndex = 4
        Me.reloadBtn.Text = "Reload Port"
        Me.reloadBtn.UseVisualStyleBackColor = True
        '
        'connectBtn
        '
        Me.connectBtn.Location = New System.Drawing.Point(11, 111)
        Me.connectBtn.Name = "connectBtn"
        Me.connectBtn.Size = New System.Drawing.Size(121, 23)
        Me.connectBtn.TabIndex = 5
        Me.connectBtn.Text = "Connect"
        Me.connectBtn.UseVisualStyleBackColor = True
        '
        'closeConBtn
        '
        Me.closeConBtn.Enabled = False
        Me.closeConBtn.Location = New System.Drawing.Point(11, 141)
        Me.closeConBtn.Name = "closeConBtn"
        Me.closeConBtn.Size = New System.Drawing.Size(248, 23)
        Me.closeConBtn.TabIndex = 6
        Me.closeConBtn.Text = "Close connection"
        Me.closeConBtn.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox1.Controls.Add(Me.statusDimTxt)
        Me.GroupBox1.Controls.Add(Me.closeConBtn)
        Me.GroupBox1.Controls.Add(Me.statusTxt)
        Me.GroupBox1.Controls.Add(Me.baudRateTxt)
        Me.GroupBox1.Controls.Add(Me.reloadBtn)
        Me.GroupBox1.Controls.Add(Me.portTxt)
        Me.GroupBox1.Controls.Add(Me.connectBtn)
        Me.GroupBox1.Controls.Add(Me.cmbPort)
        Me.GroupBox1.Controls.Add(Me.cmbBaudRate)
        Me.GroupBox1.Location = New System.Drawing.Point(9, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(268, 227)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Serial port connection"
        '
        'baudRateTxt
        '
        Me.baudRateTxt.AutoSize = True
        Me.baudRateTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.baudRateTxt.Location = New System.Drawing.Point(11, 71)
        Me.baudRateTxt.Name = "baudRateTxt"
        Me.baudRateTxt.Size = New System.Drawing.Size(79, 17)
        Me.baudRateTxt.TabIndex = 7
        Me.baudRateTxt.Text = "Baud Rate:"
        '
        'cmbBaudRate
        '
        Me.cmbBaudRate.FormattingEnabled = True
        Me.cmbBaudRate.Items.AddRange(New Object() {"300", "1200", "2400", "4800", "9600", "19200", "38400", "57600", "74880", "115200", "230400", "250000", "500000", "1000000", "2000000"})
        Me.cmbBaudRate.Location = New System.Drawing.Point(135, 70)
        Me.cmbBaudRate.Name = "cmbBaudRate"
        Me.cmbBaudRate.Size = New System.Drawing.Size(121, 21)
        Me.cmbBaudRate.TabIndex = 8
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.sendBtn)
        Me.GroupBox2.Controls.Add(Me.commandTxt)
        Me.GroupBox2.Controls.Add(Me.dataToSendTxt)
        Me.GroupBox2.Location = New System.Drawing.Point(299, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(699, 69)
        Me.GroupBox2.TabIndex = 8
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Send data"
        '
        'sendBtn
        '
        Me.sendBtn.Enabled = False
        Me.sendBtn.Location = New System.Drawing.Point(618, 30)
        Me.sendBtn.Name = "sendBtn"
        Me.sendBtn.Size = New System.Drawing.Size(75, 23)
        Me.sendBtn.TabIndex = 2
        Me.sendBtn.Text = "Send"
        Me.sendBtn.UseVisualStyleBackColor = True
        '
        'commandTxt
        '
        Me.commandTxt.Enabled = False
        Me.commandTxt.Location = New System.Drawing.Point(123, 31)
        Me.commandTxt.Name = "commandTxt"
        Me.commandTxt.Size = New System.Drawing.Size(485, 20)
        Me.commandTxt.TabIndex = 1
        '
        'dataToSendTxt
        '
        Me.dataToSendTxt.AutoSize = True
        Me.dataToSendTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dataToSendTxt.Location = New System.Drawing.Point(20, 33)
        Me.dataToSendTxt.Name = "dataToSendTxt"
        Me.dataToSendTxt.Size = New System.Drawing.Size(97, 17)
        Me.dataToSendTxt.TabIndex = 0
        Me.dataToSendTxt.Text = "Data to send: "
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.saveLogBtn)
        Me.GroupBox3.Controls.Add(Me.clearOutputBtn)
        Me.GroupBox3.Controls.Add(Me.outputTxt)
        Me.GroupBox3.Location = New System.Drawing.Point(298, 88)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(700, 434)
        Me.GroupBox3.TabIndex = 9
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Recived data"
        '
        'saveLogBtn
        '
        Me.saveLogBtn.Location = New System.Drawing.Point(87, 411)
        Me.saveLogBtn.Name = "saveLogBtn"
        Me.saveLogBtn.Size = New System.Drawing.Size(75, 23)
        Me.saveLogBtn.TabIndex = 2
        Me.saveLogBtn.Text = "Save Log"
        Me.saveLogBtn.UseVisualStyleBackColor = True
        '
        'clearOutputBtn
        '
        Me.clearOutputBtn.Location = New System.Drawing.Point(6, 411)
        Me.clearOutputBtn.Name = "clearOutputBtn"
        Me.clearOutputBtn.Size = New System.Drawing.Size(75, 23)
        Me.clearOutputBtn.TabIndex = 1
        Me.clearOutputBtn.Text = "Clear output"
        Me.clearOutputBtn.UseVisualStyleBackColor = True
        '
        'outputTxt
        '
        Me.outputTxt.Location = New System.Drawing.Point(6, 19)
        Me.outputTxt.Multiline = True
        Me.outputTxt.Name = "outputTxt"
        Me.outputTxt.ReadOnly = True
        Me.outputTxt.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.outputTxt.Size = New System.Drawing.Size(687, 387)
        Me.outputTxt.TabIndex = 0
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(1010, 534)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show
        Me.Text = "Serial Monitor PRO"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SerialPort1 As IO.Ports.SerialPort
    Friend WithEvents Timer1 As Timer
    Friend WithEvents cmbPort As ComboBox
    Friend WithEvents portTxt As Label
    Friend WithEvents statusTxt As Label
    Friend WithEvents statusDimTxt As Label
    Friend WithEvents reloadBtn As Button
    Friend WithEvents connectBtn As Button
    Friend WithEvents closeConBtn As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents baudRateTxt As Label
    Friend WithEvents cmbBaudRate As ComboBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents sendBtn As Button
    Friend WithEvents commandTxt As TextBox
    Friend WithEvents dataToSendTxt As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents outputTxt As TextBox
    Friend WithEvents clearOutputBtn As Button
    Friend WithEvents saveLogBtn As Button
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
End Class
