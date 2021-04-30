<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    '   <System.Diagnostics.DebuggerNonUserCode()> _
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
    ' <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ForceItemsIntoToolBox1 = New MfgControl.AdvancedHMI.Drivers.ForceItemsIntoToolbox()
        Me.ModbusTCPCom1 = New AdvancedHMIDrivers.ModbusTCPCom(Me.components)
        Me.BasicLabel2 = New AdvancedHMIControls.BasicLabel()
        Me.PilotLight1 = New AdvancedHMIControls.PilotLight()
        Me.Meter1 = New AdvancedHMIControls.Meter()
        Me.DigitalPanelMeter1 = New AdvancedHMIControls.DigitalPanelMeter()
        Me.BasicLabel3 = New AdvancedHMIControls.BasicLabel()
        Me.PilotLight2 = New AdvancedHMIControls.PilotLight()
        Me.BasicLabel1 = New AdvancedHMIControls.BasicLabel()
        Me.EthernetIPforCLXCom1 = New AdvancedHMIDrivers.EthernetIPforCLXCom(Me.components)
        CType(Me.ModbusTCPCom1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EthernetIPforCLXCom1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(6, 769)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(194, 32)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "For Development Source Code Visit" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "http://www.advancedhmi.com"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'ModbusTCPCom1
        '
        Me.ModbusTCPCom1.DisableSubscriptions = False
        Me.ModbusTCPCom1.IniFileName = ""
        Me.ModbusTCPCom1.IniFileSection = Nothing
        Me.ModbusTCPCom1.IPAddress = "10.0.0.23"
        Me.ModbusTCPCom1.MaxReadGroupSize = 20
        Me.ModbusTCPCom1.PollRateOverride = 500
        Me.ModbusTCPCom1.SwapBytes = True
        Me.ModbusTCPCom1.SwapWords = False
        Me.ModbusTCPCom1.TcpipPort = CType(502US, UShort)
        Me.ModbusTCPCom1.TimeOut = 3000
        Me.ModbusTCPCom1.UnitId = CType(1, Byte)
        '
        'BasicLabel2
        '
        Me.BasicLabel2.AutoSize = True
        Me.BasicLabel2.BackColor = System.Drawing.Color.Black
        Me.BasicLabel2.BooleanDisplay = AdvancedHMIControls.BasicLabel.BooleanDisplayOption.TrueFalse
        Me.BasicLabel2.ComComponent = Me.ModbusTCPCom1
        Me.BasicLabel2.DisplayAsTime = False
        Me.BasicLabel2.ForeColor = System.Drawing.Color.White
        Me.BasicLabel2.Highlight = False
        Me.BasicLabel2.HighlightColor = System.Drawing.Color.Red
        Me.BasicLabel2.HighlightForeColor = System.Drawing.Color.White
        Me.BasicLabel2.HighlightKeyCharacter = "!"
        Me.BasicLabel2.InterpretValueAsBCD = False
        Me.BasicLabel2.KeypadAlphaNumeric = False
        Me.BasicLabel2.KeypadFont = New System.Drawing.Font("Arial", 10.0!)
        Me.BasicLabel2.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.BasicLabel2.KeypadMaxValue = 0R
        Me.BasicLabel2.KeypadMinValue = 0R
        Me.BasicLabel2.KeypadScaleFactor = 1.0R
        Me.BasicLabel2.KeypadShowCurrentValue = False
        Me.BasicLabel2.KeypadText = Nothing
        Me.BasicLabel2.KeypadWidth = 300
        Me.BasicLabel2.Location = New System.Drawing.Point(744, 356)
        Me.BasicLabel2.Name = "BasicLabel2"
        Me.BasicLabel2.NumericFormat = Nothing
        Me.BasicLabel2.PLCAddressKeypad = ""
        Me.BasicLabel2.PollRate = 0
        Me.BasicLabel2.Size = New System.Drawing.Size(43, 18)
        Me.BasicLabel2.TabIndex = 73
        Me.BasicLabel2.Text = "RPM"
        Me.BasicLabel2.Value = "RPM"
        Me.BasicLabel2.ValueLeftPadCharacter = Global.Microsoft.VisualBasic.ChrW(32)
        Me.BasicLabel2.ValueLeftPadLength = 0
        Me.BasicLabel2.ValuePrefix = Nothing
        Me.BasicLabel2.ValueScaleFactor = 1.0R
        Me.BasicLabel2.ValueSuffix = Nothing
        Me.BasicLabel2.ValueToSubtractFrom = 0!
        '
        'PilotLight1
        '
        Me.PilotLight1.Blink = False
        Me.PilotLight1.ComComponent = Me.ModbusTCPCom1
        Me.PilotLight1.LegendPlate = MfgControl.AdvancedHMI.Controls.PilotLight.LegendPlates.Large
        Me.PilotLight1.LightColor = MfgControl.AdvancedHMI.Controls.PilotLight.LightColors.Green
        Me.PilotLight1.LightColorOff = MfgControl.AdvancedHMI.Controls.PilotLight.LightColors.Red
        Me.PilotLight1.Location = New System.Drawing.Point(694, 27)
        Me.PilotLight1.Name = "PilotLight1"
        Me.PilotLight1.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.Toggle
        Me.PilotLight1.PLCAddressClick = "00002"
        Me.PilotLight1.PLCAddressText = ""
        Me.PilotLight1.PLCAddressValue = "00002"
        Me.PilotLight1.PLCAddressVisible = ""
        Me.PilotLight1.Size = New System.Drawing.Size(141, 206)
        Me.PilotLight1.TabIndex = 74
        Me.PilotLight1.Text = "Safety Controls"
        Me.PilotLight1.Value = False
        Me.PilotLight1.ValueToWrite = 0
        '
        'Meter1
        '
        Me.Meter1.ComComponent = Me.ModbusTCPCom1
        Me.Meter1.HighlightColor = System.Drawing.Color.Red
        Me.Meter1.Location = New System.Drawing.Point(626, 393)
        Me.Meter1.MaxValue = New Decimal(New Integer() {14000, 0, 0, 0})
        Me.Meter1.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.Meter1.Name = "Meter1"
        Me.Meter1.NumericFormat = Nothing
        Me.Meter1.PLCAddressText = ""
        Me.Meter1.PLCAddressValue = "40002"
        Me.Meter1.PLCAddressVisible = ""
        Me.Meter1.Size = New System.Drawing.Size(277, 237)
        Me.Meter1.TabIndex = 75
        Me.Meter1.Value = 0R
        Me.Meter1.ValueScaleFactor = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'DigitalPanelMeter1
        '
        Me.DigitalPanelMeter1.BackColor = System.Drawing.Color.Transparent
        Me.DigitalPanelMeter1.ComComponent = Me.ModbusTCPCom1
        Me.DigitalPanelMeter1.DecimalPosition = 0
        Me.DigitalPanelMeter1.ForeColor = System.Drawing.Color.LightGray
        Me.DigitalPanelMeter1.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.DigitalPanelMeter1.KeypadMaxValue = 0R
        Me.DigitalPanelMeter1.KeypadMinValue = 0R
        Me.DigitalPanelMeter1.KeypadScaleFactor = 1.0R
        Me.DigitalPanelMeter1.KeypadText = Nothing
        Me.DigitalPanelMeter1.KeypadWidth = 300
        Me.DigitalPanelMeter1.Location = New System.Drawing.Point(253, 432)
        Me.DigitalPanelMeter1.Name = "DigitalPanelMeter1"
        Me.DigitalPanelMeter1.NumberOfDigits = 5
        Me.DigitalPanelMeter1.PLCAddressKeypad = ""
        Me.DigitalPanelMeter1.PLCAddressValue = "40001"
        Me.DigitalPanelMeter1.Resolution = New Decimal(New Integer() {1, 0, 0, 0})
        Me.DigitalPanelMeter1.Size = New System.Drawing.Size(230, 100)
        Me.DigitalPanelMeter1.TabIndex = 76
        Me.DigitalPanelMeter1.Value = 0R
        Me.DigitalPanelMeter1.ValueScaleFactor = New Decimal(New Integer() {1, 0, 0, 0})
        Me.DigitalPanelMeter1.ValueScaleOffset = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'BasicLabel3
        '
        Me.BasicLabel3.AutoSize = True
        Me.BasicLabel3.BackColor = System.Drawing.Color.Black
        Me.BasicLabel3.BooleanDisplay = AdvancedHMIControls.BasicLabel.BooleanDisplayOption.TrueFalse
        Me.BasicLabel3.ComComponent = Me.ModbusTCPCom1
        Me.BasicLabel3.DisplayAsTime = False
        Me.BasicLabel3.ForeColor = System.Drawing.Color.White
        Me.BasicLabel3.Highlight = False
        Me.BasicLabel3.HighlightColor = System.Drawing.Color.Red
        Me.BasicLabel3.HighlightForeColor = System.Drawing.Color.White
        Me.BasicLabel3.HighlightKeyCharacter = "!"
        Me.BasicLabel3.InterpretValueAsBCD = False
        Me.BasicLabel3.KeypadAlphaNumeric = False
        Me.BasicLabel3.KeypadFont = New System.Drawing.Font("Arial", 10.0!)
        Me.BasicLabel3.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.BasicLabel3.KeypadMaxValue = 0R
        Me.BasicLabel3.KeypadMinValue = 0R
        Me.BasicLabel3.KeypadScaleFactor = 1.0R
        Me.BasicLabel3.KeypadShowCurrentValue = False
        Me.BasicLabel3.KeypadText = Nothing
        Me.BasicLabel3.KeypadWidth = 300
        Me.BasicLabel3.Location = New System.Drawing.Point(340, 393)
        Me.BasicLabel3.Name = "BasicLabel3"
        Me.BasicLabel3.NumericFormat = Nothing
        Me.BasicLabel3.PLCAddressKeypad = ""
        Me.BasicLabel3.PollRate = 0
        Me.BasicLabel3.Size = New System.Drawing.Size(61, 18)
        Me.BasicLabel3.TabIndex = 77
        Me.BasicLabel3.Text = "Voltage"
        Me.BasicLabel3.Value = "Voltage"
        Me.BasicLabel3.ValueLeftPadCharacter = Global.Microsoft.VisualBasic.ChrW(32)
        Me.BasicLabel3.ValueLeftPadLength = 0
        Me.BasicLabel3.ValuePrefix = Nothing
        Me.BasicLabel3.ValueScaleFactor = 1.0R
        Me.BasicLabel3.ValueSuffix = Nothing
        Me.BasicLabel3.ValueToSubtractFrom = 0!
        '
        'PilotLight2
        '
        Me.PilotLight2.Blink = False
        Me.PilotLight2.ComComponent = Me.ModbusTCPCom1
        Me.PilotLight2.LegendPlate = MfgControl.AdvancedHMI.Controls.PilotLight.LegendPlates.Large
        Me.PilotLight2.LightColor = MfgControl.AdvancedHMI.Controls.PilotLight.LightColors.Green
        Me.PilotLight2.LightColorOff = MfgControl.AdvancedHMI.Controls.PilotLight.LightColors.Red
        Me.PilotLight2.Location = New System.Drawing.Point(272, 27)
        Me.PilotLight2.Name = "PilotLight2"
        Me.PilotLight2.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.Toggle
        Me.PilotLight2.PLCAddressClick = "00001"
        Me.PilotLight2.PLCAddressText = ""
        Me.PilotLight2.PLCAddressValue = "00001"
        Me.PilotLight2.PLCAddressVisible = ""
        Me.PilotLight2.Size = New System.Drawing.Size(141, 206)
        Me.PilotLight2.TabIndex = 78
        Me.PilotLight2.Text = "I/O"
        Me.PilotLight2.Value = False
        Me.PilotLight2.ValueToWrite = 0
        '
        'BasicLabel1
        '
        Me.BasicLabel1.AutoSize = True
        Me.BasicLabel1.BackColor = System.Drawing.Color.Black
        Me.BasicLabel1.BooleanDisplay = AdvancedHMIControls.BasicLabel.BooleanDisplayOption.TrueFalse
        Me.BasicLabel1.ComComponent = Me.ModbusTCPCom1
        Me.BasicLabel1.DisplayAsTime = False
        Me.BasicLabel1.ForeColor = System.Drawing.Color.White
        Me.BasicLabel1.Highlight = False
        Me.BasicLabel1.HighlightColor = System.Drawing.Color.Red
        Me.BasicLabel1.HighlightForeColor = System.Drawing.Color.White
        Me.BasicLabel1.HighlightKeyCharacter = "!"
        Me.BasicLabel1.InterpretValueAsBCD = False
        Me.BasicLabel1.KeypadAlphaNumeric = False
        Me.BasicLabel1.KeypadFont = New System.Drawing.Font("Arial", 10.0!)
        Me.BasicLabel1.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.BasicLabel1.KeypadMaxValue = 0R
        Me.BasicLabel1.KeypadMinValue = 0R
        Me.BasicLabel1.KeypadScaleFactor = 1.0R
        Me.BasicLabel1.KeypadShowCurrentValue = False
        Me.BasicLabel1.KeypadText = Nothing
        Me.BasicLabel1.KeypadWidth = 300
        Me.BasicLabel1.Location = New System.Drawing.Point(312, 82)
        Me.BasicLabel1.Name = "BasicLabel1"
        Me.BasicLabel1.NumericFormat = Nothing
        Me.BasicLabel1.PLCAddressKeypad = ""
        Me.BasicLabel1.PLCAddressValue = "40003"
        Me.BasicLabel1.PollRate = 0
        Me.BasicLabel1.Size = New System.Drawing.Size(0, 18)
        Me.BasicLabel1.TabIndex = 79
        Me.BasicLabel1.Value = ""
        Me.BasicLabel1.ValueLeftPadCharacter = Global.Microsoft.VisualBasic.ChrW(32)
        Me.BasicLabel1.ValueLeftPadLength = 0
        Me.BasicLabel1.ValuePrefix = Nothing
        Me.BasicLabel1.ValueScaleFactor = 1.0R
        Me.BasicLabel1.ValueSuffix = Nothing
        Me.BasicLabel1.ValueToSubtractFrom = 0!
        '
        'EthernetIPforCLXCom1
        '
        Me.EthernetIPforCLXCom1.CIPConnectionSize = 508
        Me.EthernetIPforCLXCom1.DisableMultiServiceRequest = False
        Me.EthernetIPforCLXCom1.DisableSubscriptions = False
        Me.EthernetIPforCLXCom1.IniFileName = ""
        Me.EthernetIPforCLXCom1.IniFileSection = Nothing
        Me.EthernetIPforCLXCom1.IPAddress = "192.168.0.10"
        Me.EthernetIPforCLXCom1.PollRateOverride = 500
        Me.EthernetIPforCLXCom1.Port = 44818
        Me.EthernetIPforCLXCom1.ProcessorSlot = 0
        Me.EthernetIPforCLXCom1.RoutePath = Nothing
        Me.EthernetIPforCLXCom1.Timeout = 4000
        '
        'MainForm
        '
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(1096, 668)
        Me.Controls.Add(Me.BasicLabel1)
        Me.Controls.Add(Me.PilotLight2)
        Me.Controls.Add(Me.BasicLabel3)
        Me.Controls.Add(Me.DigitalPanelMeter1)
        Me.Controls.Add(Me.Meter1)
        Me.Controls.Add(Me.PilotLight1)
        Me.Controls.Add(Me.BasicLabel2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.ForeColor = System.Drawing.Color.Black
        Me.KeyPreview = True
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "AdvancedHMI v3.99x"
        CType(Me.ModbusTCPCom1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EthernetIPforCLXCom1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DF1ComWF1 As AdvancedHMIDrivers.SerialDF1forSLCMicroCom
    Friend WithEvents ForceItemsIntoToolBox1 As MfgControl.AdvancedHMI.Drivers.ForceItemsIntoToolbox
    Friend WithEvents ModbusTCPCom1 As AdvancedHMIDrivers.ModbusTCPCom
    Friend WithEvents BasicLabel2 As AdvancedHMIControls.BasicLabel
    Friend WithEvents PilotLight1 As AdvancedHMIControls.PilotLight
    Friend WithEvents Meter1 As AdvancedHMIControls.Meter
    Friend WithEvents DigitalPanelMeter1 As AdvancedHMIControls.DigitalPanelMeter
    Friend WithEvents BasicLabel3 As AdvancedHMIControls.BasicLabel
    Friend WithEvents PilotLight2 As AdvancedHMIControls.PilotLight
    Friend WithEvents BasicLabel1 As AdvancedHMIControls.BasicLabel
    Friend WithEvents EthernetIPforCLXCom1 As AdvancedHMIDrivers.EthernetIPforCLXCom
End Class
