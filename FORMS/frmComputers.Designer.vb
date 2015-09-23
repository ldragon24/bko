<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmComputers
    Inherits System.Windows.Forms.Form

    'Форма переопределяет dispose для очистки списка компонентов.
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

    'Является обязательной для конструктора форм Windows Forms
    Private components As System.ComponentModel.IContainer

    'Примечание: следующая процедура является обязательной для конструктора форм Windows Forms
    'Для ее изменения используйте конструктор форм Windows Form.  
    'Не изменяйте ее в редакторе исходного кода.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
Me.components = New System.ComponentModel.Container()
Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmComputers))
Me.spCont = New System.Windows.Forms.SplitContainer()
Me.TableLayoutPanel65 = New System.Windows.Forms.TableLayoutPanel()
Me.gbTree = New System.Windows.Forms.GroupBox()
Me.TableLayoutPanel64 = New System.Windows.Forms.TableLayoutPanel()
Me.lstGroups = New System.Windows.Forms.TreeView()
Me.txtSearch = New System.Windows.Forms.TextBox()
Me.treebranche = New System.Windows.Forms.ComboBox()
Me.chkVisibleSTR = New System.Windows.Forms.CheckBox()
Me.ToolStrip7 = New System.Windows.Forms.ToolStrip()
Me.btnSearch = New System.Windows.Forms.ToolStripButton()
Me.sSTAB3 = New System.Windows.Forms.TabControl()
Me.TabPage11 = New System.Windows.Forms.TabPage()
Me.TableLayoutPanel22 = New System.Windows.Forms.TableLayoutPanel()
Me.txtOTHmemo = New System.Windows.Forms.TextBox()
Me.Label9 = New System.Windows.Forms.Label()
Me.cmbOTHFil = New System.Windows.Forms.ComboBox()
Me.Label8 = New System.Windows.Forms.Label()
Me.cmbOTHDepart = New System.Windows.Forms.ComboBox()
Me.Label7 = New System.Windows.Forms.Label()
Me.cmbOTHOffice = New System.Windows.Forms.ComboBox()
Me.Label6 = New System.Windows.Forms.Label()
Me.cmbOTHotv = New System.Windows.Forms.ComboBox()
Me.Label5 = New System.Windows.Forms.Label()
Me.txtOTHphone = New System.Windows.Forms.TextBox()
Me.lblTipOther = New System.Windows.Forms.Label()
Me.cmbOTHConnect = New System.Windows.Forms.ComboBox()
Me.Label10 = New System.Windows.Forms.Label()
Me.txtOTHinnumber = New System.Windows.Forms.TextBox()
Me.lblOTPCL = New System.Windows.Forms.Label()
Me.cmbOTHPCL = New System.Windows.Forms.ComboBox()
Me.lblOtIp = New System.Windows.Forms.Label()
Me.lblOTMac = New System.Windows.Forms.Label()
Me.txtOTHIP = New System.Windows.Forms.TextBox()
Me.txtOTHMAC = New System.Windows.Forms.TextBox()
Me.Label3 = New System.Windows.Forms.Label()
Me.gbSNMP = New System.Windows.Forms.GroupBox()
Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
Me.Label90 = New System.Windows.Forms.Label()
Me.Label91 = New System.Windows.Forms.Label()
Me.Label92 = New System.Windows.Forms.Label()
Me.Label93 = New System.Windows.Forms.Label()
Me.Label94 = New System.Windows.Forms.Label()
Me.Label95 = New System.Windows.Forms.Label()
Me.Label96 = New System.Windows.Forms.Label()
Me.Label97 = New System.Windows.Forms.Label()
Me.Label98 = New System.Windows.Forms.Label()
Me.Label99 = New System.Windows.Forms.Label()
Me.Label100 = New System.Windows.Forms.Label()
Me.Label101 = New System.Windows.Forms.Label()
Me.Label102 = New System.Windows.Forms.Label()
Me.Label103 = New System.Windows.Forms.Label()
Me.Label104 = New System.Windows.Forms.Label()
Me.Label105 = New System.Windows.Forms.Label()
Me.Label106 = New System.Windows.Forms.Label()
Me.Label107 = New System.Windows.Forms.Label()
Me.Label108 = New System.Windows.Forms.Label()
Me.Label109 = New System.Windows.Forms.Label()
Me.Label110 = New System.Windows.Forms.Label()
Me.Label111 = New System.Windows.Forms.Label()
Me.Label112 = New System.Windows.Forms.Label()
Me.Label113 = New System.Windows.Forms.Label()
Me.Label87 = New System.Windows.Forms.Label()
Me.lblSNMP_Ping = New System.Windows.Forms.Label()
Me.lblsIDOTH = New System.Windows.Forms.Label()
Me.chkSNMP = New System.Windows.Forms.CheckBox()
Me.lblSNMP = New System.Windows.Forms.Label()
Me.txtSNMP = New System.Windows.Forms.TextBox()
Me.gbOTh = New System.Windows.Forms.GroupBox()
Me.TableLayoutPanel7 = New System.Windows.Forms.TableLayoutPanel()
Me.PROiZV39 = New System.Windows.Forms.ComboBox()
Me.cmbOTH = New System.Windows.Forms.ComboBox()
Me.txtMonDum = New System.Windows.Forms.TextBox()
Me.txtOTHSN = New System.Windows.Forms.TextBox()
Me.TabPage22 = New System.Windows.Forms.TabPage()
Me.lvMovementOTH = New System.Windows.Forms.ListView()
Me.TabPage12 = New System.Windows.Forms.TabPage()
Me.TableLayoutPanel17 = New System.Windows.Forms.TableLayoutPanel()
Me.gbOTHRemont = New System.Windows.Forms.GroupBox()
Me.lvRepairOTH = New System.Windows.Forms.ListView()
Me.gbOTHNotes = New System.Windows.Forms.GroupBox()
Me.TableLayoutPanel18 = New System.Windows.Forms.TableLayoutPanel()
Me.ToolStrip6 = New System.Windows.Forms.ToolStrip()
Me.btnOTHAdd = New System.Windows.Forms.ToolStripButton()
Me.ToolStripSeparator17 = New System.Windows.Forms.ToolStripSeparator()
Me.btnOTHNotesDel = New System.Windows.Forms.ToolStripButton()
Me.ToolStripSeparator18 = New System.Windows.Forms.ToolStripSeparator()
Me.btnOTHNotesCancel = New System.Windows.Forms.ToolStripButton()
Me.ToolStripSeparator19 = New System.Windows.Forms.ToolStripSeparator()
Me.lvNotesOTH = New System.Windows.Forms.ListView()
Me.txtNotesOTH = New System.Windows.Forms.TextBox()
Me.cmbNotesOTHMaster = New System.Windows.Forms.ComboBox()
Me.NotesOTHdate = New System.Windows.Forms.DateTimePicker()
Me.TabPage18 = New System.Windows.Forms.TabPage()
Me.TableLayoutPanel70 = New System.Windows.Forms.TableLayoutPanel()
Me.gbPostOTH = New System.Windows.Forms.GroupBox()
Me.TableLayoutPanel56 = New System.Windows.Forms.TableLayoutPanel()
Me.dtGOTHok = New System.Windows.Forms.DateTimePicker()
Me.Label42 = New System.Windows.Forms.Label()
Me.Label40 = New System.Windows.Forms.Label()
Me.cmbOTHPostav = New System.Windows.Forms.ComboBox()
Me.dtGOTHPr = New System.Windows.Forms.DateTimePicker()
Me.Label41 = New System.Windows.Forms.Label()
Me.gbSaleOTH = New System.Windows.Forms.GroupBox()
Me.TableLayoutPanel54 = New System.Windows.Forms.TableLayoutPanel()
Me.chkOTHNNb = New System.Windows.Forms.CheckBox()
Me.txtOTHSumm = New System.Windows.Forms.NumericUpDown()
Me.dtOTHdataVvoda = New System.Windows.Forms.DateTimePicker()
Me.Label66 = New System.Windows.Forms.Label()
Me.txtOTHZay = New System.Windows.Forms.TextBox()
Me.Label61 = New System.Windows.Forms.Label()
Me.dtOTHSFdate = New System.Windows.Forms.DateTimePicker()
Me.Label65 = New System.Windows.Forms.Label()
Me.txtOTHcash = New System.Windows.Forms.NumericUpDown()
Me.Label62 = New System.Windows.Forms.Label()
Me.Label64 = New System.Windows.Forms.Label()
Me.txtOTHSfN = New System.Windows.Forms.TextBox()
Me.Label63 = New System.Windows.Forms.Label()
Me.chkOTHspis = New System.Windows.Forms.CheckBox()
Me.dtOTHSpisanie = New System.Windows.Forms.DateTimePicker()
Me.sSTAB1 = New System.Windows.Forms.TabControl()
Me.TabPage6 = New System.Windows.Forms.TabPage()
Me.TableLayoutPanel20 = New System.Windows.Forms.TableLayoutPanel()
Me.gbMovement = New System.Windows.Forms.GroupBox()
Me.lvMovement = New System.Windows.Forms.ListView()
Me.lblPseudonym = New System.Windows.Forms.Label()
Me.txtSNAME = New System.Windows.Forms.TextBox()
Me.lblNetName = New System.Windows.Forms.Label()
Me.txtPSEUDONIM = New System.Windows.Forms.TextBox()
Me.lblBranch = New System.Windows.Forms.Label()
Me.cmbBranch = New System.Windows.Forms.ComboBox()
Me.lblResponsible = New System.Windows.Forms.Label()
Me.cmbResponsible = New System.Windows.Forms.ComboBox()
Me.lblDepartment = New System.Windows.Forms.Label()
Me.cmbDepartment = New System.Windows.Forms.ComboBox()
Me.lblPhone = New System.Windows.Forms.Label()
Me.txtPHONE = New System.Windows.Forms.TextBox()
Me.lblOffice = New System.Windows.Forms.Label()
Me.cmbOffice = New System.Windows.Forms.ComboBox()
Me.lblAppointment = New System.Windows.Forms.Label()
Me.cmbAppointment = New System.Windows.Forms.ComboBox()
Me.gbInNumber = New System.Windows.Forms.GroupBox()
Me.TableLayoutPanel47 = New System.Windows.Forms.TableLayoutPanel()
Me.IN_PRN = New System.Windows.Forms.TextBox()
Me.Label16 = New System.Windows.Forms.Label()
Me.IN_IBP = New System.Windows.Forms.TextBox()
Me.Label19 = New System.Windows.Forms.Label()
Me.txtMSN = New System.Windows.Forms.TextBox()
Me.Label17 = New System.Windows.Forms.Label()
Me.txtSBSN = New System.Windows.Forms.TextBox()
Me.Label18 = New System.Windows.Forms.Label()
Me.Label89 = New System.Windows.Forms.Label()
Me.lblNumberNET = New System.Windows.Forms.Label()
Me.Label84 = New System.Windows.Forms.Label()
Me.lblsID = New System.Windows.Forms.Label()
Me.Label88 = New System.Windows.Forms.Label()
Me.cmbPCLK = New System.Windows.Forms.ComboBox()
Me.TabPage1 = New System.Windows.Forms.TabPage()
Me.TableLayoutPanel63 = New System.Windows.Forms.TableLayoutPanel()
Me.gbcpu = New System.Windows.Forms.GroupBox()
Me.TableLayoutPanel24 = New System.Windows.Forms.TableLayoutPanel()
Me.PROizV4 = New System.Windows.Forms.ComboBox()
Me.PROizV2 = New System.Windows.Forms.ComboBox()
Me.PROizV3 = New System.Windows.Forms.ComboBox()
Me.cmbCPU1 = New System.Windows.Forms.ComboBox()
Me.txtSoc4 = New System.Windows.Forms.TextBox()
Me.cmbCPU2 = New System.Windows.Forms.ComboBox()
Me.PROizV1 = New System.Windows.Forms.ComboBox()
Me.cmbCPU3 = New System.Windows.Forms.ComboBox()
Me.txtSoc3 = New System.Windows.Forms.TextBox()
Me.txtMHZ4 = New System.Windows.Forms.TextBox()
Me.cmbCPU4 = New System.Windows.Forms.ComboBox()
Me.txtSoc2 = New System.Windows.Forms.TextBox()
Me.txtMHZ1 = New System.Windows.Forms.TextBox()
Me.txtSoc1 = New System.Windows.Forms.TextBox()
Me.txtMHZ2 = New System.Windows.Forms.TextBox()
Me.txtMHZ3 = New System.Windows.Forms.TextBox()
Me.ToolStrip8 = New System.Windows.Forms.ToolStrip()
Me.bCPUPlus = New System.Windows.Forms.ToolStripButton()
Me.gbSOUND = New System.Windows.Forms.GroupBox()
Me.TableLayoutPanel28 = New System.Windows.Forms.TableLayoutPanel()
Me.PROizV16 = New System.Windows.Forms.ComboBox()
Me.txtSoundS = New System.Windows.Forms.TextBox()
Me.cmbSound = New System.Windows.Forms.ComboBox()
Me.txtSoundB = New System.Windows.Forms.TextBox()
Me.gbMB = New System.Windows.Forms.GroupBox()
Me.TableLayoutPanel29 = New System.Windows.Forms.TableLayoutPanel()
Me.lblMBsn = New System.Windows.Forms.Label()
Me.txtSN_MB = New System.Windows.Forms.TextBox()
Me.txtChip = New System.Windows.Forms.TextBox()
Me.PROizV5 = New System.Windows.Forms.ComboBox()
Me.cmbMB = New System.Windows.Forms.ComboBox()
Me.gbSVGA = New System.Windows.Forms.GroupBox()
Me.TableLayoutPanel27 = New System.Windows.Forms.TableLayoutPanel()
Me.PROizV15 = New System.Windows.Forms.ComboBox()
Me.txtSVGAs2 = New System.Windows.Forms.TextBox()
Me.PROizV14 = New System.Windows.Forms.ComboBox()
Me.cmbSVGA1 = New System.Windows.Forms.ComboBox()
Me.cmbSVGA2 = New System.Windows.Forms.ComboBox()
Me.txtSVGAs1 = New System.Windows.Forms.TextBox()
Me.txtSVGAr2 = New System.Windows.Forms.TextBox()
Me.txtSVGAr1 = New System.Windows.Forms.TextBox()
Me.ToolStrip11 = New System.Windows.Forms.ToolStrip()
Me.bSVGAPlus = New System.Windows.Forms.ToolStripButton()
Me.gbRAM = New System.Windows.Forms.GroupBox()
Me.TableLayoutPanel25 = New System.Windows.Forms.TableLayoutPanel()
Me.PROizV9 = New System.Windows.Forms.ComboBox()
Me.txtRamSN4 = New System.Windows.Forms.TextBox()
Me.PROizV8 = New System.Windows.Forms.ComboBox()
Me.cmbRAM1 = New System.Windows.Forms.ComboBox()
Me.PROizV7 = New System.Windows.Forms.ComboBox()
Me.cmbRAM2 = New System.Windows.Forms.ComboBox()
Me.PROizV6 = New System.Windows.Forms.ComboBox()
Me.txtRamSN3 = New System.Windows.Forms.TextBox()
Me.txtRamS4 = New System.Windows.Forms.TextBox()
Me.cmbRAM3 = New System.Windows.Forms.ComboBox()
Me.txtRamSN2 = New System.Windows.Forms.TextBox()
Me.cmbRAM4 = New System.Windows.Forms.ComboBox()
Me.txtRamS1 = New System.Windows.Forms.TextBox()
Me.txtRamSN1 = New System.Windows.Forms.TextBox()
Me.txtRamS3 = New System.Windows.Forms.TextBox()
Me.txtRamS2 = New System.Windows.Forms.TextBox()
Me.ToolStrip9 = New System.Windows.Forms.ToolStrip()
Me.bRamPlus = New System.Windows.Forms.ToolStripButton()
Me.cmbRAM5 = New System.Windows.Forms.ComboBox()
Me.cmbRAM6 = New System.Windows.Forms.ComboBox()
Me.txtRamS5 = New System.Windows.Forms.TextBox()
Me.txtRamS6 = New System.Windows.Forms.TextBox()
Me.txtRamSN5 = New System.Windows.Forms.TextBox()
Me.txtRamSN6 = New System.Windows.Forms.TextBox()
Me.PROizV44 = New System.Windows.Forms.ComboBox()
Me.PROizV45 = New System.Windows.Forms.ComboBox()
Me.cmbRAM7 = New System.Windows.Forms.ComboBox()
Me.cmbRAM8 = New System.Windows.Forms.ComboBox()
Me.txtRamS7 = New System.Windows.Forms.TextBox()
Me.txtRamS8 = New System.Windows.Forms.TextBox()
Me.txtRamSN7 = New System.Windows.Forms.TextBox()
Me.txtRamSN8 = New System.Windows.Forms.TextBox()
Me.PROizV46 = New System.Windows.Forms.ComboBox()
Me.PROizV47 = New System.Windows.Forms.ComboBox()
Me.gbHDD = New System.Windows.Forms.GroupBox()
Me.TableLayoutPanel26 = New System.Windows.Forms.TableLayoutPanel()
Me.PROizV13 = New System.Windows.Forms.ComboBox()
Me.txtHDDsN4 = New System.Windows.Forms.TextBox()
Me.PROizV12 = New System.Windows.Forms.ComboBox()
Me.cmbHDD1 = New System.Windows.Forms.ComboBox()
Me.PROizV11 = New System.Windows.Forms.ComboBox()
Me.cmbHDD2 = New System.Windows.Forms.ComboBox()
Me.PROizV10 = New System.Windows.Forms.ComboBox()
Me.txtHDDsN3 = New System.Windows.Forms.TextBox()
Me.txtHDDo4 = New System.Windows.Forms.TextBox()
Me.cmbHDD3 = New System.Windows.Forms.ComboBox()
Me.cmbHDD4 = New System.Windows.Forms.ComboBox()
Me.txtHDDo1 = New System.Windows.Forms.TextBox()
Me.txtHDDsN1 = New System.Windows.Forms.TextBox()
Me.txtHDDo3 = New System.Windows.Forms.TextBox()
Me.txtHDDo2 = New System.Windows.Forms.TextBox()
Me.txtHDDsN2 = New System.Windows.Forms.TextBox()
Me.ToolStrip10 = New System.Windows.Forms.ToolStrip()
Me.bHddPlus = New System.Windows.Forms.ToolStripButton()
Me.cmbHDD5 = New System.Windows.Forms.ComboBox()
Me.cmbHDD6 = New System.Windows.Forms.ComboBox()
Me.cmbHDD7 = New System.Windows.Forms.ComboBox()
Me.cmbHDD8 = New System.Windows.Forms.ComboBox()
Me.PROizV48 = New System.Windows.Forms.ComboBox()
Me.PROizV49 = New System.Windows.Forms.ComboBox()
Me.PROizV50 = New System.Windows.Forms.ComboBox()
Me.PROizV51 = New System.Windows.Forms.ComboBox()
Me.txtHDDo5 = New System.Windows.Forms.TextBox()
Me.txtHDDsN5 = New System.Windows.Forms.TextBox()
Me.txtHDDo6 = New System.Windows.Forms.TextBox()
Me.txtHDDsN6 = New System.Windows.Forms.TextBox()
Me.txtHDDo7 = New System.Windows.Forms.TextBox()
Me.txtHDDsN7 = New System.Windows.Forms.TextBox()
Me.txtHDDo8 = New System.Windows.Forms.TextBox()
Me.txtHDDsN8 = New System.Windows.Forms.TextBox()
Me.gbOptical = New System.Windows.Forms.GroupBox()
Me.TableLayoutPanel30 = New System.Windows.Forms.TableLayoutPanel()
Me.PROizV19 = New System.Windows.Forms.ComboBox()
Me.txtOPTICsn3 = New System.Windows.Forms.TextBox()
Me.PROizV18 = New System.Windows.Forms.ComboBox()
Me.cmbOPTIC1 = New System.Windows.Forms.ComboBox()
Me.PROizV17 = New System.Windows.Forms.ComboBox()
Me.cmbOPTIC2 = New System.Windows.Forms.ComboBox()
Me.txtOPTICsn2 = New System.Windows.Forms.TextBox()
Me.txtOPTICs3 = New System.Windows.Forms.TextBox()
Me.cmbOPTIC3 = New System.Windows.Forms.ComboBox()
Me.txtOPTICsn1 = New System.Windows.Forms.TextBox()
Me.txtOPTICs1 = New System.Windows.Forms.TextBox()
Me.txtOPTICs2 = New System.Windows.Forms.TextBox()
Me.ToolStrip12 = New System.Windows.Forms.ToolStrip()
Me.bOpticalPlus = New System.Windows.Forms.ToolStripButton()
Me.gbNetwork = New System.Windows.Forms.GroupBox()
Me.TableLayoutPanel31 = New System.Windows.Forms.TableLayoutPanel()
Me.PROizV21 = New System.Windows.Forms.ComboBox()
Me.txtNETmac2 = New System.Windows.Forms.TextBox()
Me.PROizV20 = New System.Windows.Forms.ComboBox()
Me.cmbNET1 = New System.Windows.Forms.ComboBox()
Me.cmbNET2 = New System.Windows.Forms.ComboBox()
Me.txtNETmac1 = New System.Windows.Forms.TextBox()
Me.txtNETip2 = New System.Windows.Forms.TextBox()
Me.txtNETip1 = New System.Windows.Forms.TextBox()
Me.ToolStrip13 = New System.Windows.Forms.ToolStrip()
Me.bNetPlus = New System.Windows.Forms.ToolStripButton()
Me.gbFDD = New System.Windows.Forms.GroupBox()
Me.TableLayoutPanel32 = New System.Windows.Forms.TableLayoutPanel()
Me.PROizV22 = New System.Windows.Forms.ComboBox()
Me.cmbFDD = New System.Windows.Forms.ComboBox()
Me.txtSN = New System.Windows.Forms.TextBox()
Me.gbCreader = New System.Windows.Forms.GroupBox()
Me.TableLayoutPanel33 = New System.Windows.Forms.TableLayoutPanel()
Me.PROizV23 = New System.Windows.Forms.ComboBox()
Me.cmbCreader = New System.Windows.Forms.ComboBox()
Me.txtCreader1 = New System.Windows.Forms.TextBox()
Me.gbModem = New System.Windows.Forms.GroupBox()
Me.TableLayoutPanel34 = New System.Windows.Forms.TableLayoutPanel()
Me.PROizV24 = New System.Windows.Forms.ComboBox()
Me.cmbModem = New System.Windows.Forms.ComboBox()
Me.txtModemSN = New System.Windows.Forms.TextBox()
Me.gbCase = New System.Windows.Forms.GroupBox()
Me.TableLayoutPanel35 = New System.Windows.Forms.TableLayoutPanel()
Me.cmbCase = New System.Windows.Forms.ComboBox()
Me.txtCase1 = New System.Windows.Forms.TextBox()
Me.PROizV25 = New System.Windows.Forms.ComboBox()
Me.gbBP = New System.Windows.Forms.GroupBox()
Me.TableLayoutPanel36 = New System.Windows.Forms.TableLayoutPanel()
Me.cmbBP = New System.Windows.Forms.ComboBox()
Me.txtBP1 = New System.Windows.Forms.TextBox()
Me.PROizV26 = New System.Windows.Forms.ComboBox()
Me.gbUSB = New System.Windows.Forms.GroupBox()
Me.TableLayoutPanel37 = New System.Windows.Forms.TableLayoutPanel()
Me.cmbUSB = New System.Windows.Forms.ComboBox()
Me.txtUSBSN = New System.Windows.Forms.TextBox()
Me.PROizV41 = New System.Windows.Forms.ComboBox()
Me.gbPCI = New System.Windows.Forms.GroupBox()
Me.TableLayoutPanel38 = New System.Windows.Forms.TableLayoutPanel()
Me.cmbPCI = New System.Windows.Forms.ComboBox()
Me.txtSNPCI = New System.Windows.Forms.TextBox()
Me.PROizV42 = New System.Windows.Forms.ComboBox()
Me.gbSBP = New System.Windows.Forms.GroupBox()
Me.TableLayoutPanel39 = New System.Windows.Forms.TableLayoutPanel()
Me.txtModSB = New System.Windows.Forms.TextBox()
Me.txtSNSB = New System.Windows.Forms.TextBox()
Me.PROizV27 = New System.Windows.Forms.ComboBox()
Me.TabPage3 = New System.Windows.Forms.TabPage()
Me.TableLayoutPanel61 = New System.Windows.Forms.TableLayoutPanel()
Me.gbMonitor = New System.Windows.Forms.GroupBox()
Me.TableLayoutPanel40 = New System.Windows.Forms.TableLayoutPanel()
Me.PROizV29 = New System.Windows.Forms.ComboBox()
Me.txtMon2SN = New System.Windows.Forms.TextBox()
Me.PROizV28 = New System.Windows.Forms.ComboBox()
Me.cmbMon1 = New System.Windows.Forms.ComboBox()
Me.cmbMon2 = New System.Windows.Forms.ComboBox()
Me.txtMon1SN = New System.Windows.Forms.TextBox()
Me.txtMon2Dum = New System.Windows.Forms.TextBox()
Me.txtMon1Dum = New System.Windows.Forms.TextBox()
Me.ToolStrip14 = New System.Windows.Forms.ToolStrip()
Me.bMonitorPlus = New System.Windows.Forms.ToolStripButton()
Me.gbPrinters = New System.Windows.Forms.GroupBox()
Me.TableLayoutPanel41 = New System.Windows.Forms.TableLayoutPanel()
Me.cmbPrinters1 = New System.Windows.Forms.ComboBox()
Me.PROizV36 = New System.Windows.Forms.ComboBox()
Me.txtPrint3Port = New System.Windows.Forms.TextBox()
Me.PROizV35 = New System.Windows.Forms.ComboBox()
Me.cmbPrinters2 = New System.Windows.Forms.ComboBox()
Me.PROizV34 = New System.Windows.Forms.ComboBox()
Me.cmbPrinters3 = New System.Windows.Forms.ComboBox()
Me.txtPrint2Port = New System.Windows.Forms.TextBox()
Me.txtPrint3SN = New System.Windows.Forms.TextBox()
Me.txtPrint1SN = New System.Windows.Forms.TextBox()
Me.txtPrint1Port = New System.Windows.Forms.TextBox()
Me.txtPrint2SN = New System.Windows.Forms.TextBox()
Me.ToolStrip15 = New System.Windows.Forms.ToolStrip()
Me.bPrinterPlus = New System.Windows.Forms.ToolStripButton()
Me.gbIBP = New System.Windows.Forms.GroupBox()
Me.TableLayoutPanel46 = New System.Windows.Forms.TableLayoutPanel()
Me.PROizV43 = New System.Windows.Forms.ComboBox()
Me.cmbIBP = New System.Windows.Forms.ComboBox()
Me.txtSNIBP = New System.Windows.Forms.TextBox()
Me.gbKeyboard = New System.Windows.Forms.GroupBox()
Me.TableLayoutPanel42 = New System.Windows.Forms.TableLayoutPanel()
Me.PROizV30 = New System.Windows.Forms.ComboBox()
Me.cmbKeyb = New System.Windows.Forms.ComboBox()
Me.txtKeybSN = New System.Windows.Forms.TextBox()
Me.gbMouse = New System.Windows.Forms.GroupBox()
Me.TableLayoutPanel43 = New System.Windows.Forms.TableLayoutPanel()
Me.cmbMouse = New System.Windows.Forms.ComboBox()
Me.PROizV31 = New System.Windows.Forms.ComboBox()
Me.txtMouseSN = New System.Windows.Forms.TextBox()
Me.gbFilter = New System.Windows.Forms.GroupBox()
Me.TableLayoutPanel45 = New System.Windows.Forms.TableLayoutPanel()
Me.PROizV33 = New System.Windows.Forms.ComboBox()
Me.cmbFilter = New System.Windows.Forms.ComboBox()
Me.txtFilterSN = New System.Windows.Forms.TextBox()
Me.gbAsystem = New System.Windows.Forms.GroupBox()
Me.TableLayoutPanel44 = New System.Windows.Forms.TableLayoutPanel()
Me.PROizV32 = New System.Windows.Forms.ComboBox()
Me.cmbAsist = New System.Windows.Forms.ComboBox()
Me.txtAsistSN = New System.Windows.Forms.TextBox()
Me.TabPage4 = New System.Windows.Forms.TabPage()
Me.TableLayoutPanel10 = New System.Windows.Forms.TableLayoutPanel()
Me.lstSoftware = New System.Windows.Forms.ListView()
Me.gbSoftEd = New System.Windows.Forms.GroupBox()
Me.TableLayoutPanel13 = New System.Windows.Forms.TableLayoutPanel()
Me.cmbSoftware = New System.Windows.Forms.ComboBox()
Me.CheckBox1 = New System.Windows.Forms.CheckBox()
Me.Label114 = New System.Windows.Forms.Label()
Me.cmbTipLicense = New System.Windows.Forms.ComboBox()
Me.Label115 = New System.Windows.Forms.Label()
Me.cmbTipPo = New System.Windows.Forms.ComboBox()
Me.Label116 = New System.Windows.Forms.Label()
Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
Me.txtLicKey = New System.Windows.Forms.TextBox()
Me.DTInstall = New System.Windows.Forms.DateTimePicker()
Me.Label117 = New System.Windows.Forms.Label()
Me.Label118 = New System.Windows.Forms.Label()
Me.cmbSoftPr = New System.Windows.Forms.ComboBox()
Me.Label119 = New System.Windows.Forms.Label()
Me.ToolStrip16 = New System.Windows.Forms.ToolStrip()
Me.btnAdd = New System.Windows.Forms.ToolStripButton()
Me.ToolStripSeparator20 = New System.Windows.Forms.ToolStripSeparator()
Me.btnDelete = New System.Windows.Forms.ToolStripButton()
Me.ToolStripSeparator21 = New System.Windows.Forms.ToolStripSeparator()
Me.btnCancel = New System.Windows.Forms.ToolStripButton()
Me.ToolStripSeparator22 = New System.Windows.Forms.ToolStripSeparator()
Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
Me.ToolStripSeparator23 = New System.Windows.Forms.ToolStripSeparator()
Me.CheckBox2 = New System.Windows.Forms.CheckBox()
Me.TabPage5 = New System.Windows.Forms.TabPage()
Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
Me.cmdUserAdd = New System.Windows.Forms.ToolStripButton()
Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
Me.cmdUserDel = New System.Windows.Forms.ToolStripButton()
Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
Me.cmdUserPassEncript = New System.Windows.Forms.ToolStripButton()
Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
Me.btnUserCancel = New System.Windows.Forms.ToolStripButton()
Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
Me.txtUMEMO = New System.Windows.Forms.TextBox()
Me.Label36 = New System.Windows.Forms.Label()
Me.txtUserEmailPwd = New System.Windows.Forms.TextBox()
Me.lblEmailPass = New System.Windows.Forms.Label()
Me.txtUserEmail = New System.Windows.Forms.TextBox()
Me.lblEMAIL = New System.Windows.Forms.Label()
Me.txtUserJab = New System.Windows.Forms.TextBox()
Me.lblJabber = New System.Windows.Forms.Label()
Me.txtUserIcq = New System.Windows.Forms.TextBox()
Me.lblICQ = New System.Windows.Forms.Label()
Me.lblSurname = New System.Windows.Forms.Label()
Me.txtUserPass = New System.Windows.Forms.TextBox()
Me.lbluserPassword = New System.Windows.Forms.Label()
Me.lblUsername = New System.Windows.Forms.Label()
Me.ChkPDC = New System.Windows.Forms.CheckBox()
Me.txtUserName = New System.Windows.Forms.ComboBox()
Me.txtUserFIO = New System.Windows.Forms.ComboBox()
Me.lstUsers = New System.Windows.Forms.ListView()
Me.TabPage7 = New System.Windows.Forms.TabPage()
Me.TableLayoutPanel5 = New System.Windows.Forms.TableLayoutPanel()
Me.gbRepair = New System.Windows.Forms.GroupBox()
Me.lvRepair = New System.Windows.Forms.ListView()
Me.gbNotes = New System.Windows.Forms.GroupBox()
Me.TableLayoutPanel6 = New System.Windows.Forms.TableLayoutPanel()
Me.ToolStrip2 = New System.Windows.Forms.ToolStrip()
Me.btnNotesAdd = New System.Windows.Forms.ToolStripButton()
Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
Me.btnNotesDel = New System.Windows.Forms.ToolStripButton()
Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
Me.btnNotesCancel = New System.Windows.Forms.ToolStripButton()
Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator()
Me.lvNotes = New System.Windows.Forms.ListView()
Me.txtNotes = New System.Windows.Forms.TextBox()
Me.cmbNotesMaster = New System.Windows.Forms.ComboBox()
Me.dtDateNotes = New System.Windows.Forms.DateTimePicker()
Me.TabPage8 = New System.Windows.Forms.TabPage()
Me.TableLayoutPanel66 = New System.Windows.Forms.TableLayoutPanel()
Me.gbGuarantee = New System.Windows.Forms.GroupBox()
Me.TableLayoutPanel59 = New System.Windows.Forms.TableLayoutPanel()
Me.gbSeller = New System.Windows.Forms.GroupBox()
Me.TableLayoutPanel60 = New System.Windows.Forms.TableLayoutPanel()
Me.dtGok = New System.Windows.Forms.DateTimePicker()
Me.Label20 = New System.Windows.Forms.Label()
Me.Label21 = New System.Windows.Forms.Label()
Me.Label22 = New System.Windows.Forms.Label()
Me.cmbPostav = New System.Windows.Forms.ComboBox()
Me.dtGPr = New System.Windows.Forms.DateTimePicker()
Me.rbKompl = New System.Windows.Forms.RadioButton()
Me.rbSist = New System.Windows.Forms.RadioButton()
Me.gbSale = New System.Windows.Forms.GroupBox()
Me.TableLayoutPanel23 = New System.Windows.Forms.TableLayoutPanel()
Me.txtPCSumm = New System.Windows.Forms.NumericUpDown()
Me.dtPCdataVvoda = New System.Windows.Forms.DateTimePicker()
Me.Label43 = New System.Windows.Forms.Label()
Me.Label48 = New System.Windows.Forms.Label()
Me.txtPCSfN = New System.Windows.Forms.TextBox()
Me.txtPCcash = New System.Windows.Forms.NumericUpDown()
Me.Label46 = New System.Windows.Forms.Label()
Me.txtPCZay = New System.Windows.Forms.TextBox()
Me.Label45 = New System.Windows.Forms.Label()
Me.dtPCSFdate = New System.Windows.Forms.DateTimePicker()
Me.Label47 = New System.Windows.Forms.Label()
Me.Label44 = New System.Windows.Forms.Label()
Me.chkPCspis = New System.Windows.Forms.CheckBox()
Me.dtSpisanie = New System.Windows.Forms.DateTimePicker()
Me.chkPCNNb = New System.Windows.Forms.CheckBox()
Me.sSTAB5 = New System.Windows.Forms.TabControl()
Me.TabPage19 = New System.Windows.Forms.TabPage()
Me.TableLayoutPanel71 = New System.Windows.Forms.TableLayoutPanel()
Me.Label70 = New System.Windows.Forms.Label()
Me.txtBRMemo = New System.Windows.Forms.TextBox()
Me.txtBRAddress = New System.Windows.Forms.TextBox()
Me.Label67 = New System.Windows.Forms.Label()
Me.Label69 = New System.Windows.Forms.Label()
Me.txtBRPhone = New System.Windows.Forms.TextBox()
Me.txtBRBoss = New System.Windows.Forms.TextBox()
Me.Label68 = New System.Windows.Forms.Label()
Me.TabPage20 = New System.Windows.Forms.TabPage()
Me.TableLayoutPanel8 = New System.Windows.Forms.TableLayoutPanel()
Me.gbBRRemont = New System.Windows.Forms.GroupBox()
Me.lvRepairBR = New System.Windows.Forms.ListView()
Me.gbBRNotes = New System.Windows.Forms.GroupBox()
Me.TableLayoutPanel9 = New System.Windows.Forms.TableLayoutPanel()
Me.ToolStrip3 = New System.Windows.Forms.ToolStrip()
Me.btnBRNotesAdd = New System.Windows.Forms.ToolStripButton()
Me.ToolStripSeparator8 = New System.Windows.Forms.ToolStripSeparator()
Me.btnBRNotesDel = New System.Windows.Forms.ToolStripButton()
Me.ToolStripSeparator9 = New System.Windows.Forms.ToolStripSeparator()
Me.btnBRNotesCancel = New System.Windows.Forms.ToolStripButton()
Me.ToolStripSeparator10 = New System.Windows.Forms.ToolStripSeparator()
Me.lvNotesBR = New System.Windows.Forms.ListView()
Me.Notesbrtxt = New System.Windows.Forms.TextBox()
Me.cmbBRMaster = New System.Windows.Forms.ComboBox()
Me.Notesbrdate = New System.Windows.Forms.DateTimePicker()
Me.TabPage21 = New System.Windows.Forms.TabPage()
Me.TableLayoutPanel73 = New System.Windows.Forms.TableLayoutPanel()
Me.Label82 = New System.Windows.Forms.Label()
Me.btnOfficeSend = New System.Windows.Forms.Button()
Me.txtspplo = New System.Windows.Forms.TextBox()
Me.txtSpMebel = New System.Windows.Forms.TextBox()
Me.Label81 = New System.Windows.Forms.Label()
Me.Label71 = New System.Windows.Forms.Label()
Me.txtspvis = New System.Windows.Forms.TextBox()
Me.txtSpWall = New System.Windows.Forms.TextBox()
Me.Label80 = New System.Windows.Forms.Label()
Me.Label72 = New System.Windows.Forms.Label()
Me.txtspPloOneEVM = New System.Windows.Forms.TextBox()
Me.cmbSpKanal = New System.Windows.Forms.ComboBox()
Me.Label79 = New System.Windows.Forms.Label()
Me.Label73 = New System.Windows.Forms.Label()
Me.txtspObOneEVM = New System.Windows.Forms.TextBox()
Me.cmbSpWater = New System.Windows.Forms.ComboBox()
Me.cmbSpTeplo = New System.Windows.Forms.ComboBox()
Me.Label75 = New System.Windows.Forms.Label()
Me.Label78 = New System.Windows.Forms.Label()
Me.Label74 = New System.Windows.Forms.Label()
Me.cmbSpRemEVM = New System.Windows.Forms.ComboBox()
Me.Label77 = New System.Windows.Forms.Label()
Me.Label76 = New System.Windows.Forms.Label()
Me.cmbSpVent = New System.Windows.Forms.ComboBox()
Me.sSTAB2 = New System.Windows.Forms.TabControl()
Me.TabPage9 = New System.Windows.Forms.TabPage()
Me.TableLayoutPanel21 = New System.Windows.Forms.TableLayoutPanel()
Me.gbPRNCartr = New System.Windows.Forms.GroupBox()
Me.lvPRNCartr = New System.Windows.Forms.ListView()
Me.txtPrnIP = New System.Windows.Forms.TextBox()
Me.lblPrnIP = New System.Windows.Forms.Label()
Me.cmbPRNotv = New System.Windows.Forms.ComboBox()
Me.lblPRNotv = New System.Windows.Forms.Label()
Me.lblPRNPage = New System.Windows.Forms.Label()
Me.lblPRNprintPage = New System.Windows.Forms.Label()
Me.cmbPRNOffice = New System.Windows.Forms.ComboBox()
Me.lblPRNOffice = New System.Windows.Forms.Label()
Me.cmbModCartr = New System.Windows.Forms.ComboBox()
Me.lblModCartr = New System.Windows.Forms.Label()
Me.cmbPRNDepart = New System.Windows.Forms.ComboBox()
Me.lblPRNDepart = New System.Windows.Forms.Label()
Me.cmbTIPCartridg = New System.Windows.Forms.ComboBox()
Me.lblTIPCartridg = New System.Windows.Forms.Label()
Me.cmbPRNFil = New System.Windows.Forms.ComboBox()
Me.lblPRNFil = New System.Windows.Forms.Label()
Me.txtPRNinnumber = New System.Windows.Forms.TextBox()
Me.lblInNumber = New System.Windows.Forms.Label()
Me.cmbFormat = New System.Windows.Forms.ComboBox()
Me.gbPRN = New System.Windows.Forms.GroupBox()
Me.TableLayoutPanel55 = New System.Windows.Forms.TableLayoutPanel()
Me.PROiZV38 = New System.Windows.Forms.ComboBox()
Me.cmbPRN = New System.Windows.Forms.ComboBox()
Me.txtPRNSN = New System.Windows.Forms.TextBox()
Me.lblFormat = New System.Windows.Forms.Label()
Me.lblPRNphone = New System.Windows.Forms.Label()
Me.txtPRNphone = New System.Windows.Forms.TextBox()
Me.lblPrnMAC = New System.Windows.Forms.Label()
Me.txtPRNMAC = New System.Windows.Forms.TextBox()
Me.cmbPRNConnect = New System.Windows.Forms.ComboBox()
Me.lblPRNConnect = New System.Windows.Forms.Label()
Me.Label83 = New System.Windows.Forms.Label()
Me.cmbPCL = New System.Windows.Forms.ComboBox()
Me.Label85 = New System.Windows.Forms.Label()
Me.lblSidPRN = New System.Windows.Forms.Label()
Me.gbPRN_USTR = New System.Windows.Forms.GroupBox()
Me.lvUSTR_PRINT = New System.Windows.Forms.ListView()
Me.TabPage23 = New System.Windows.Forms.TabPage()
Me.lvMovementPRN = New System.Windows.Forms.ListView()
Me.TabPage10 = New System.Windows.Forms.TabPage()
Me.TableLayoutPanel11 = New System.Windows.Forms.TableLayoutPanel()
Me.gbPRNRemont = New System.Windows.Forms.GroupBox()
Me.lvRepairPRN = New System.Windows.Forms.ListView()
Me.gbPRNNotes = New System.Windows.Forms.GroupBox()
Me.TableLayoutPanel12 = New System.Windows.Forms.TableLayoutPanel()
Me.ToolStrip4 = New System.Windows.Forms.ToolStrip()
Me.btnPRNNotesAdd = New System.Windows.Forms.ToolStripButton()
Me.ToolStripSeparator11 = New System.Windows.Forms.ToolStripSeparator()
Me.btnPRNNotesDel = New System.Windows.Forms.ToolStripButton()
Me.ToolStripSeparator12 = New System.Windows.Forms.ToolStripSeparator()
Me.btnPRNNotesCancel = New System.Windows.Forms.ToolStripButton()
Me.ToolStripSeparator13 = New System.Windows.Forms.ToolStripSeparator()
Me.lvNotesPRN = New System.Windows.Forms.ListView()
Me.NotesPRNtxt = New System.Windows.Forms.TextBox()
Me.cmbNotesPRNMaster = New System.Windows.Forms.ComboBox()
Me.NotesPRNdate = New System.Windows.Forms.DateTimePicker()
Me.TabPage16 = New System.Windows.Forms.TabPage()
Me.TableLayoutPanel67 = New System.Windows.Forms.TableLayoutPanel()
Me.gbPostPRN = New System.Windows.Forms.GroupBox()
Me.TableLayoutPanel57 = New System.Windows.Forms.TableLayoutPanel()
Me.dtGPRNok = New System.Windows.Forms.DateTimePicker()
Me.Label4 = New System.Windows.Forms.Label()
Me.Label1 = New System.Windows.Forms.Label()
Me.Label2 = New System.Windows.Forms.Label()
Me.dtGPRNPr = New System.Windows.Forms.DateTimePicker()
Me.cmbPRNPostav = New System.Windows.Forms.ComboBox()
Me.gbSalePRN = New System.Windows.Forms.GroupBox()
Me.TableLayoutPanel52 = New System.Windows.Forms.TableLayoutPanel()
Me.chkPRNNNb = New System.Windows.Forms.CheckBox()
Me.txtPRNSumm = New System.Windows.Forms.NumericUpDown()
Me.dtPRNdataVvoda = New System.Windows.Forms.DateTimePicker()
Me.Label54 = New System.Windows.Forms.Label()
Me.txtPRNZay = New System.Windows.Forms.TextBox()
Me.Label49 = New System.Windows.Forms.Label()
Me.Label53 = New System.Windows.Forms.Label()
Me.txtPRNcash = New System.Windows.Forms.NumericUpDown()
Me.Label50 = New System.Windows.Forms.Label()
Me.Label52 = New System.Windows.Forms.Label()
Me.txtPRNSfN = New System.Windows.Forms.TextBox()
Me.Label51 = New System.Windows.Forms.Label()
Me.dtPRNSFdate = New System.Windows.Forms.DateTimePicker()
Me.chkPRNspis = New System.Windows.Forms.CheckBox()
Me.dtPRNSpisanie = New System.Windows.Forms.DateTimePicker()
Me.sSTAB4 = New System.Windows.Forms.TabControl()
Me.TabPage13 = New System.Windows.Forms.TabPage()
Me.TableLayoutPanel69 = New System.Windows.Forms.TableLayoutPanel()
Me.TableLayoutPanel49 = New System.Windows.Forms.TableLayoutPanel()
Me.cmbNETotv = New System.Windows.Forms.ComboBox()
Me.txtNETphone = New System.Windows.Forms.TextBox()
Me.Label32 = New System.Windows.Forms.Label()
Me.Label28 = New System.Windows.Forms.Label()
Me.Label29 = New System.Windows.Forms.Label()
Me.Label31 = New System.Windows.Forms.Label()
Me.Label30 = New System.Windows.Forms.Label()
Me.cmbNETBranch = New System.Windows.Forms.ComboBox()
Me.cmbNETOffice = New System.Windows.Forms.ComboBox()
Me.cmbNetDepart = New System.Windows.Forms.ComboBox()
Me.Label86 = New System.Windows.Forms.Label()
Me.lblSidNET = New System.Windows.Forms.Label()
Me.lblPCLNET = New System.Windows.Forms.Label()
Me.cmbCNTNet = New System.Windows.Forms.ComboBox()
Me.gbNet = New System.Windows.Forms.GroupBox()
Me.TableLayoutPanel51 = New System.Windows.Forms.TableLayoutPanel()
Me.PROiZV40 = New System.Windows.Forms.ComboBox()
Me.cmbDevNet = New System.Windows.Forms.ComboBox()
Me.cmbNetDev = New System.Windows.Forms.ComboBox()
Me.gbExNet = New System.Windows.Forms.GroupBox()
Me.TableLayoutPanel48 = New System.Windows.Forms.TableLayoutPanel()
Me.cmbNetCable = New System.Windows.Forms.ComboBox()
Me.txtNetSN = New System.Windows.Forms.TextBox()
Me.Label14 = New System.Windows.Forms.Label()
Me.Label27 = New System.Windows.Forms.Label()
Me.txtNetIsp = New System.Windows.Forms.TextBox()
Me.Label11 = New System.Windows.Forms.Label()
Me.Label24 = New System.Windows.Forms.Label()
Me.txtNetIP = New System.Windows.Forms.TextBox()
Me.cmbNetVkl = New System.Windows.Forms.ComboBox()
Me.Label23 = New System.Windows.Forms.Label()
Me.txtNetNumberPorts = New System.Windows.Forms.TextBox()
Me.Label12 = New System.Windows.Forms.Label()
Me.Label15 = New System.Windows.Forms.Label()
Me.txtNetINN = New System.Windows.Forms.TextBox()
Me.txtNetCableCat = New System.Windows.Forms.TextBox()
Me.Label13 = New System.Windows.Forms.Label()
Me.txtNetPort = New System.Windows.Forms.TextBox()
Me.Label26 = New System.Windows.Forms.Label()
Me.Label25 = New System.Windows.Forms.Label()
Me.txtNetMac = New System.Windows.Forms.TextBox()
Me.TabPage14 = New System.Windows.Forms.TabPage()
Me.gbNetPortMapping = New System.Windows.Forms.GroupBox()
Me.TableLayoutPanel50 = New System.Windows.Forms.TableLayoutPanel()
Me.lvNetPort = New System.Windows.Forms.ListView()
Me.Label35 = New System.Windows.Forms.Label()
Me.txtNetPortMapping = New System.Windows.Forms.TextBox()
Me.Label33 = New System.Windows.Forms.Label()
Me.txtNetnumberPort = New System.Windows.Forms.TextBox()
Me.Label34 = New System.Windows.Forms.Label()
Me.txtNetPortMac = New System.Windows.Forms.TextBox()
Me.btnNetPortAdd = New System.Windows.Forms.Button()
Me.TabPage24 = New System.Windows.Forms.TabPage()
Me.lvMovementNET = New System.Windows.Forms.ListView()
Me.TabPage15 = New System.Windows.Forms.TabPage()
Me.TableLayoutPanel14 = New System.Windows.Forms.TableLayoutPanel()
Me.gbNETRemont = New System.Windows.Forms.GroupBox()
Me.lvRepairNET = New System.Windows.Forms.ListView()
Me.gbNETNotes = New System.Windows.Forms.GroupBox()
Me.TableLayoutPanel15 = New System.Windows.Forms.TableLayoutPanel()
Me.ToolStrip5 = New System.Windows.Forms.ToolStrip()
Me.btnNETAdd = New System.Windows.Forms.ToolStripButton()
Me.ToolStripSeparator14 = New System.Windows.Forms.ToolStripSeparator()
Me.btnNETNotesDel = New System.Windows.Forms.ToolStripButton()
Me.ToolStripSeparator15 = New System.Windows.Forms.ToolStripSeparator()
Me.btnNETNotesCancel = New System.Windows.Forms.ToolStripButton()
Me.ToolStripSeparator16 = New System.Windows.Forms.ToolStripSeparator()
Me.lvNotesNET = New System.Windows.Forms.ListView()
Me.cmbNotesNETMaster = New System.Windows.Forms.ComboBox()
Me.NotesNETdate = New System.Windows.Forms.DateTimePicker()
Me.NotesNETtxt = New System.Windows.Forms.TextBox()
Me.TabPage17 = New System.Windows.Forms.TabPage()
Me.TableLayoutPanel68 = New System.Windows.Forms.TableLayoutPanel()
Me.gbPostNET = New System.Windows.Forms.GroupBox()
Me.TableLayoutPanel58 = New System.Windows.Forms.TableLayoutPanel()
Me.dtGNETok = New System.Windows.Forms.DateTimePicker()
Me.Label39 = New System.Windows.Forms.Label()
Me.Label37 = New System.Windows.Forms.Label()
Me.cmbNETPostav = New System.Windows.Forms.ComboBox()
Me.dtGNETPr = New System.Windows.Forms.DateTimePicker()
Me.Label38 = New System.Windows.Forms.Label()
Me.gbSaleNet = New System.Windows.Forms.GroupBox()
Me.TableLayoutPanel53 = New System.Windows.Forms.TableLayoutPanel()
Me.chkNETNNb = New System.Windows.Forms.CheckBox()
Me.txtNETSumm = New System.Windows.Forms.NumericUpDown()
Me.dtNETdataVvoda = New System.Windows.Forms.DateTimePicker()
Me.Label60 = New System.Windows.Forms.Label()
Me.txtNETZay = New System.Windows.Forms.TextBox()
Me.Label55 = New System.Windows.Forms.Label()
Me.dtNETSFdate = New System.Windows.Forms.DateTimePicker()
Me.Label59 = New System.Windows.Forms.Label()
Me.txtNETcash = New System.Windows.Forms.NumericUpDown()
Me.Label56 = New System.Windows.Forms.Label()
Me.Label58 = New System.Windows.Forms.Label()
Me.txtNETSfN = New System.Windows.Forms.TextBox()
Me.Label57 = New System.Windows.Forms.Label()
Me.chkNETspis = New System.Windows.Forms.CheckBox()
Me.dtNETSpisanie = New System.Windows.Forms.DateTimePicker()
Me.cmMENU = New System.Windows.Forms.ContextMenuStrip(Me.components)
Me.addRemToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
Me.CartrAddToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
Me.CopyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
Me.UpdateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
Me.DeleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
Me.ОтделитьПринтерыИМониторыToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
Me.ВернутьПерефериюToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
Me.СостояниеУстройстваToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
Me.mnuSostOn = New System.Windows.Forms.ToolStripMenuItem()
Me.mnuSostOff = New System.Windows.Forms.ToolStripMenuItem()
Me.ППРToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
Me.ТО1ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
Me.ТО2ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
Me.ТО3ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
Me.ТО4ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
Me.ТО5ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
Me.ТО6ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
Me.PingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
Me.cmBmenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
Me.mnuDeltoBranch = New System.Windows.Forms.ToolStripMenuItem()
Me.addFoldertoBranch = New System.Windows.Forms.ToolStripMenuItem()
Me.DeleteBranche = New System.Windows.Forms.ToolStripMenuItem()
Me.RepAddBrToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
Me.SoftInstallToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
Me.ПаспортКомпьютераToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
Me.MassRazdelPerf = New System.Windows.Forms.ToolStripMenuItem()
Me.MassObedPerf = New System.Windows.Forms.ToolStripMenuItem()
Me.MassUpdatetoINI = New System.Windows.Forms.ToolStripMenuItem()
Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
Me.Button1 = New System.Windows.Forms.Button()
Me.Button2 = New System.Windows.Forms.Button()
Me.Button3 = New System.Windows.Forms.Button()
Me.cmDvig = New System.Windows.Forms.ContextMenuStrip(Me.components)
Me.DELTEdVIGToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
Me.CMServices = New System.Windows.Forms.ContextMenuStrip(Me.components)
Me.EditService = New System.Windows.Forms.ToolStripMenuItem()
Me.DeleteService = New System.Windows.Forms.ToolStripMenuItem()
Me.MnuSendEmail = New System.Windows.Forms.ToolStripMenuItem()
Me.addServiseWork = New System.Windows.Forms.ToolStripMenuItem()
Me.ПечатьToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
Me.mnu_Z_to_Office = New System.Windows.Forms.ToolStripMenuItem()
Me.РаспискаToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
Me.НарядToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
Me.МатериальныйПропускToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
Me.БланкToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
Me.ilsCommands = New System.Windows.Forms.ImageList(Me.components)
CType(Me.spCont,System.ComponentModel.ISupportInitialize).BeginInit
Me.spCont.Panel1.SuspendLayout
Me.spCont.Panel2.SuspendLayout
Me.spCont.SuspendLayout
Me.TableLayoutPanel65.SuspendLayout
Me.gbTree.SuspendLayout
Me.TableLayoutPanel64.SuspendLayout
Me.ToolStrip7.SuspendLayout
Me.sSTAB3.SuspendLayout
Me.TabPage11.SuspendLayout
Me.TableLayoutPanel22.SuspendLayout
Me.gbSNMP.SuspendLayout
Me.TableLayoutPanel3.SuspendLayout
Me.gbOTh.SuspendLayout
Me.TableLayoutPanel7.SuspendLayout
Me.TabPage22.SuspendLayout
Me.TabPage12.SuspendLayout
Me.TableLayoutPanel17.SuspendLayout
Me.gbOTHRemont.SuspendLayout
Me.gbOTHNotes.SuspendLayout
Me.TableLayoutPanel18.SuspendLayout
Me.ToolStrip6.SuspendLayout
Me.TabPage18.SuspendLayout
Me.TableLayoutPanel70.SuspendLayout
Me.gbPostOTH.SuspendLayout
Me.TableLayoutPanel56.SuspendLayout
Me.gbSaleOTH.SuspendLayout
Me.TableLayoutPanel54.SuspendLayout
CType(Me.txtOTHSumm,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.txtOTHcash,System.ComponentModel.ISupportInitialize).BeginInit
Me.sSTAB1.SuspendLayout
Me.TabPage6.SuspendLayout
Me.TableLayoutPanel20.SuspendLayout
Me.gbMovement.SuspendLayout
Me.gbInNumber.SuspendLayout
Me.TableLayoutPanel47.SuspendLayout
Me.TabPage1.SuspendLayout
Me.TableLayoutPanel63.SuspendLayout
Me.gbcpu.SuspendLayout
Me.TableLayoutPanel24.SuspendLayout
Me.ToolStrip8.SuspendLayout
Me.gbSOUND.SuspendLayout
Me.TableLayoutPanel28.SuspendLayout
Me.gbMB.SuspendLayout
Me.TableLayoutPanel29.SuspendLayout
Me.gbSVGA.SuspendLayout
Me.TableLayoutPanel27.SuspendLayout
Me.ToolStrip11.SuspendLayout
Me.gbRAM.SuspendLayout
Me.TableLayoutPanel25.SuspendLayout
Me.ToolStrip9.SuspendLayout
Me.gbHDD.SuspendLayout
Me.TableLayoutPanel26.SuspendLayout
Me.ToolStrip10.SuspendLayout
Me.gbOptical.SuspendLayout
Me.TableLayoutPanel30.SuspendLayout
Me.ToolStrip12.SuspendLayout
Me.gbNetwork.SuspendLayout
Me.TableLayoutPanel31.SuspendLayout
Me.ToolStrip13.SuspendLayout
Me.gbFDD.SuspendLayout
Me.TableLayoutPanel32.SuspendLayout
Me.gbCreader.SuspendLayout
Me.TableLayoutPanel33.SuspendLayout
Me.gbModem.SuspendLayout
Me.TableLayoutPanel34.SuspendLayout
Me.gbCase.SuspendLayout
Me.TableLayoutPanel35.SuspendLayout
Me.gbBP.SuspendLayout
Me.TableLayoutPanel36.SuspendLayout
Me.gbUSB.SuspendLayout
Me.TableLayoutPanel37.SuspendLayout
Me.gbPCI.SuspendLayout
Me.TableLayoutPanel38.SuspendLayout
Me.gbSBP.SuspendLayout
Me.TableLayoutPanel39.SuspendLayout
Me.TabPage3.SuspendLayout
Me.TableLayoutPanel61.SuspendLayout
Me.gbMonitor.SuspendLayout
Me.TableLayoutPanel40.SuspendLayout
Me.ToolStrip14.SuspendLayout
Me.gbPrinters.SuspendLayout
Me.TableLayoutPanel41.SuspendLayout
Me.ToolStrip15.SuspendLayout
Me.gbIBP.SuspendLayout
Me.TableLayoutPanel46.SuspendLayout
Me.gbKeyboard.SuspendLayout
Me.TableLayoutPanel42.SuspendLayout
Me.gbMouse.SuspendLayout
Me.TableLayoutPanel43.SuspendLayout
Me.gbFilter.SuspendLayout
Me.TableLayoutPanel45.SuspendLayout
Me.gbAsystem.SuspendLayout
Me.TableLayoutPanel44.SuspendLayout
Me.TabPage4.SuspendLayout
Me.TableLayoutPanel10.SuspendLayout
Me.gbSoftEd.SuspendLayout
Me.TableLayoutPanel13.SuspendLayout
Me.ToolStrip16.SuspendLayout
Me.TabPage5.SuspendLayout
Me.TableLayoutPanel1.SuspendLayout
Me.TableLayoutPanel4.SuspendLayout
Me.ToolStrip1.SuspendLayout
Me.TabPage7.SuspendLayout
Me.TableLayoutPanel5.SuspendLayout
Me.gbRepair.SuspendLayout
Me.gbNotes.SuspendLayout
Me.TableLayoutPanel6.SuspendLayout
Me.ToolStrip2.SuspendLayout
Me.TabPage8.SuspendLayout
Me.TableLayoutPanel66.SuspendLayout
Me.gbGuarantee.SuspendLayout
Me.TableLayoutPanel59.SuspendLayout
Me.gbSeller.SuspendLayout
Me.TableLayoutPanel60.SuspendLayout
Me.gbSale.SuspendLayout
Me.TableLayoutPanel23.SuspendLayout
CType(Me.txtPCSumm,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.txtPCcash,System.ComponentModel.ISupportInitialize).BeginInit
Me.sSTAB5.SuspendLayout
Me.TabPage19.SuspendLayout
Me.TableLayoutPanel71.SuspendLayout
Me.TabPage20.SuspendLayout
Me.TableLayoutPanel8.SuspendLayout
Me.gbBRRemont.SuspendLayout
Me.gbBRNotes.SuspendLayout
Me.TableLayoutPanel9.SuspendLayout
Me.ToolStrip3.SuspendLayout
Me.TabPage21.SuspendLayout
Me.TableLayoutPanel73.SuspendLayout
Me.sSTAB2.SuspendLayout
Me.TabPage9.SuspendLayout
Me.TableLayoutPanel21.SuspendLayout
Me.gbPRNCartr.SuspendLayout
Me.gbPRN.SuspendLayout
Me.TableLayoutPanel55.SuspendLayout
Me.gbPRN_USTR.SuspendLayout
Me.TabPage23.SuspendLayout
Me.TabPage10.SuspendLayout
Me.TableLayoutPanel11.SuspendLayout
Me.gbPRNRemont.SuspendLayout
Me.gbPRNNotes.SuspendLayout
Me.TableLayoutPanel12.SuspendLayout
Me.ToolStrip4.SuspendLayout
Me.TabPage16.SuspendLayout
Me.TableLayoutPanel67.SuspendLayout
Me.gbPostPRN.SuspendLayout
Me.TableLayoutPanel57.SuspendLayout
Me.gbSalePRN.SuspendLayout
Me.TableLayoutPanel52.SuspendLayout
CType(Me.txtPRNSumm,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.txtPRNcash,System.ComponentModel.ISupportInitialize).BeginInit
Me.sSTAB4.SuspendLayout
Me.TabPage13.SuspendLayout
Me.TableLayoutPanel69.SuspendLayout
Me.TableLayoutPanel49.SuspendLayout
Me.gbNet.SuspendLayout
Me.TableLayoutPanel51.SuspendLayout
Me.gbExNet.SuspendLayout
Me.TableLayoutPanel48.SuspendLayout
Me.TabPage14.SuspendLayout
Me.gbNetPortMapping.SuspendLayout
Me.TableLayoutPanel50.SuspendLayout
Me.TabPage24.SuspendLayout
Me.TabPage15.SuspendLayout
Me.TableLayoutPanel14.SuspendLayout
Me.gbNETRemont.SuspendLayout
Me.gbNETNotes.SuspendLayout
Me.TableLayoutPanel15.SuspendLayout
Me.ToolStrip5.SuspendLayout
Me.TabPage17.SuspendLayout
Me.TableLayoutPanel68.SuspendLayout
Me.gbPostNET.SuspendLayout
Me.TableLayoutPanel58.SuspendLayout
Me.gbSaleNet.SuspendLayout
Me.TableLayoutPanel53.SuspendLayout
CType(Me.txtNETSumm,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.txtNETcash,System.ComponentModel.ISupportInitialize).BeginInit
Me.cmMENU.SuspendLayout
Me.cmBmenu.SuspendLayout
Me.TableLayoutPanel2.SuspendLayout
Me.cmDvig.SuspendLayout
Me.CMServices.SuspendLayout
Me.SuspendLayout
'
'spCont
'
Me.spCont.Dock = System.Windows.Forms.DockStyle.Fill
Me.spCont.Location = New System.Drawing.Point(0, 0)
Me.spCont.Name = "spCont"
'
'spCont.Panel1
'
Me.spCont.Panel1.Controls.Add(Me.TableLayoutPanel65)
'
'spCont.Panel2
'
Me.spCont.Panel2.Controls.Add(Me.sSTAB3)
Me.spCont.Panel2.Controls.Add(Me.sSTAB1)
Me.spCont.Panel2.Controls.Add(Me.sSTAB5)
Me.spCont.Panel2.Controls.Add(Me.sSTAB2)
Me.spCont.Panel2.Controls.Add(Me.sSTAB4)
Me.spCont.Size = New System.Drawing.Size(957, 646)
Me.spCont.SplitterDistance = 286
Me.spCont.TabIndex = 0
'
'TableLayoutPanel65
'
Me.TableLayoutPanel65.ColumnCount = 1
Me.TableLayoutPanel65.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100!))
Me.TableLayoutPanel65.Controls.Add(Me.gbTree, 0, 0)
Me.TableLayoutPanel65.Dock = System.Windows.Forms.DockStyle.Fill
Me.TableLayoutPanel65.Location = New System.Drawing.Point(0, 0)
Me.TableLayoutPanel65.Name = "TableLayoutPanel65"
Me.TableLayoutPanel65.RowCount = 2
Me.TableLayoutPanel65.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100!))
Me.TableLayoutPanel65.RowStyles.Add(New System.Windows.Forms.RowStyle())
Me.TableLayoutPanel65.Size = New System.Drawing.Size(286, 646)
Me.TableLayoutPanel65.TabIndex = 9
'
'gbTree
'
Me.gbTree.Controls.Add(Me.TableLayoutPanel64)
Me.gbTree.Dock = System.Windows.Forms.DockStyle.Fill
Me.gbTree.Location = New System.Drawing.Point(3, 3)
Me.gbTree.Name = "gbTree"
Me.gbTree.Size = New System.Drawing.Size(280, 640)
Me.gbTree.TabIndex = 7
Me.gbTree.TabStop = false
Me.gbTree.Text = "Дерево"
'
'TableLayoutPanel64
'
Me.TableLayoutPanel64.ColumnCount = 2
Me.TableLayoutPanel64.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100!))
Me.TableLayoutPanel64.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
Me.TableLayoutPanel64.Controls.Add(Me.lstGroups, 0, 3)
Me.TableLayoutPanel64.Controls.Add(Me.txtSearch, 0, 0)
Me.TableLayoutPanel64.Controls.Add(Me.treebranche, 0, 2)
Me.TableLayoutPanel64.Controls.Add(Me.chkVisibleSTR, 0, 1)
Me.TableLayoutPanel64.Controls.Add(Me.ToolStrip7, 1, 0)
Me.TableLayoutPanel64.Dock = System.Windows.Forms.DockStyle.Fill
Me.TableLayoutPanel64.Location = New System.Drawing.Point(3, 16)
Me.TableLayoutPanel64.Name = "TableLayoutPanel64"
Me.TableLayoutPanel64.RowCount = 4
Me.TableLayoutPanel64.RowStyles.Add(New System.Windows.Forms.RowStyle())
Me.TableLayoutPanel64.RowStyles.Add(New System.Windows.Forms.RowStyle())
Me.TableLayoutPanel64.RowStyles.Add(New System.Windows.Forms.RowStyle())
Me.TableLayoutPanel64.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100!))
Me.TableLayoutPanel64.Size = New System.Drawing.Size(274, 621)
Me.TableLayoutPanel64.TabIndex = 5
'
'lstGroups
'
Me.lstGroups.AllowDrop = true
Me.TableLayoutPanel64.SetColumnSpan(Me.lstGroups, 2)
Me.lstGroups.Dock = System.Windows.Forms.DockStyle.Fill
Me.lstGroups.FullRowSelect = true
Me.lstGroups.HotTracking = true
Me.lstGroups.Location = New System.Drawing.Point(3, 79)
Me.lstGroups.Name = "lstGroups"
Me.lstGroups.ShowNodeToolTips = true
Me.lstGroups.Size = New System.Drawing.Size(268, 539)
Me.lstGroups.TabIndex = 9
'
'txtSearch
'
Me.txtSearch.Dock = System.Windows.Forms.DockStyle.Fill
Me.txtSearch.Location = New System.Drawing.Point(3, 3)
Me.txtSearch.Name = "txtSearch"
Me.txtSearch.Size = New System.Drawing.Size(242, 20)
Me.txtSearch.TabIndex = 0
'
'treebranche
'
Me.TableLayoutPanel64.SetColumnSpan(Me.treebranche, 2)
Me.treebranche.Dock = System.Windows.Forms.DockStyle.Fill
Me.treebranche.FormattingEnabled = true
Me.treebranche.Location = New System.Drawing.Point(3, 52)
Me.treebranche.Name = "treebranche"
Me.treebranche.Size = New System.Drawing.Size(268, 21)
Me.treebranche.TabIndex = 5
'
'chkVisibleSTR
'
Me.chkVisibleSTR.AutoSize = true
Me.chkVisibleSTR.Location = New System.Drawing.Point(3, 29)
Me.chkVisibleSTR.Name = "chkVisibleSTR"
Me.chkVisibleSTR.Size = New System.Drawing.Size(96, 17)
Me.chkVisibleSTR.TabIndex = 6
Me.chkVisibleSTR.Text = "Показать всё"
Me.chkVisibleSTR.UseVisualStyleBackColor = true
'
'ToolStrip7
'
Me.ToolStrip7.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
Me.ToolStrip7.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnSearch})
Me.ToolStrip7.Location = New System.Drawing.Point(248, 0)
Me.ToolStrip7.Name = "ToolStrip7"
Me.ToolStrip7.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
Me.ToolStrip7.Size = New System.Drawing.Size(26, 25)
Me.ToolStrip7.TabIndex = 10
Me.ToolStrip7.Text = "ToolStrip7"
'
'btnSearch
'
Me.btnSearch.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
Me.btnSearch.Image = CType(resources.GetObject("btnSearch.Image"),System.Drawing.Image)
Me.btnSearch.ImageTransparentColor = System.Drawing.Color.Magenta
Me.btnSearch.Name = "btnSearch"
Me.btnSearch.Size = New System.Drawing.Size(23, 22)
Me.btnSearch.Text = "Обновить дерево, удалить результат поиска"
'
'sSTAB3
'
Me.sSTAB3.Controls.Add(Me.TabPage11)
Me.sSTAB3.Controls.Add(Me.TabPage22)
Me.sSTAB3.Controls.Add(Me.TabPage12)
Me.sSTAB3.Controls.Add(Me.TabPage18)
Me.sSTAB3.Dock = System.Windows.Forms.DockStyle.Fill
Me.sSTAB3.Location = New System.Drawing.Point(0, 0)
Me.sSTAB3.Name = "sSTAB3"
Me.sSTAB3.SelectedIndex = 0
Me.sSTAB3.Size = New System.Drawing.Size(667, 646)
Me.sSTAB3.TabIndex = 9
Me.sSTAB3.Visible = false
'
'TabPage11
'
Me.TabPage11.Controls.Add(Me.TableLayoutPanel22)
Me.TabPage11.Location = New System.Drawing.Point(4, 22)
Me.TabPage11.Name = "TabPage11"
Me.TabPage11.Padding = New System.Windows.Forms.Padding(3)
Me.TabPage11.Size = New System.Drawing.Size(659, 620)
Me.TabPage11.TabIndex = 0
Me.TabPage11.Text = "Информация"
Me.TabPage11.UseVisualStyleBackColor = true
'
'TableLayoutPanel22
'
Me.TableLayoutPanel22.ColumnCount = 4
Me.TableLayoutPanel22.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
Me.TableLayoutPanel22.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50!))
Me.TableLayoutPanel22.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 128!))
Me.TableLayoutPanel22.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50!))
Me.TableLayoutPanel22.Controls.Add(Me.txtOTHmemo, 1, 1)
Me.TableLayoutPanel22.Controls.Add(Me.Label9, 0, 3)
Me.TableLayoutPanel22.Controls.Add(Me.cmbOTHFil, 1, 3)
Me.TableLayoutPanel22.Controls.Add(Me.Label8, 0, 4)
Me.TableLayoutPanel22.Controls.Add(Me.cmbOTHDepart, 1, 4)
Me.TableLayoutPanel22.Controls.Add(Me.Label7, 0, 5)
Me.TableLayoutPanel22.Controls.Add(Me.cmbOTHOffice, 1, 5)
Me.TableLayoutPanel22.Controls.Add(Me.Label6, 0, 6)
Me.TableLayoutPanel22.Controls.Add(Me.cmbOTHotv, 1, 6)
Me.TableLayoutPanel22.Controls.Add(Me.Label5, 0, 7)
Me.TableLayoutPanel22.Controls.Add(Me.txtOTHphone, 1, 7)
Me.TableLayoutPanel22.Controls.Add(Me.lblTipOther, 0, 8)
Me.TableLayoutPanel22.Controls.Add(Me.cmbOTHConnect, 1, 8)
Me.TableLayoutPanel22.Controls.Add(Me.Label10, 2, 3)
Me.TableLayoutPanel22.Controls.Add(Me.txtOTHinnumber, 3, 3)
Me.TableLayoutPanel22.Controls.Add(Me.lblOTPCL, 2, 4)
Me.TableLayoutPanel22.Controls.Add(Me.cmbOTHPCL, 3, 4)
Me.TableLayoutPanel22.Controls.Add(Me.lblOtIp, 2, 5)
Me.TableLayoutPanel22.Controls.Add(Me.lblOTMac, 2, 6)
Me.TableLayoutPanel22.Controls.Add(Me.txtOTHIP, 3, 5)
Me.TableLayoutPanel22.Controls.Add(Me.txtOTHMAC, 3, 6)
Me.TableLayoutPanel22.Controls.Add(Me.Label3, 0, 2)
Me.TableLayoutPanel22.Controls.Add(Me.gbSNMP, 0, 10)
Me.TableLayoutPanel22.Controls.Add(Me.Label87, 0, 9)
Me.TableLayoutPanel22.Controls.Add(Me.lblSNMP_Ping, 3, 7)
Me.TableLayoutPanel22.Controls.Add(Me.lblsIDOTH, 1, 9)
Me.TableLayoutPanel22.Controls.Add(Me.chkSNMP, 2, 7)
Me.TableLayoutPanel22.Controls.Add(Me.lblSNMP, 2, 8)
Me.TableLayoutPanel22.Controls.Add(Me.txtSNMP, 3, 8)
Me.TableLayoutPanel22.Controls.Add(Me.gbOTh, 0, 0)
Me.TableLayoutPanel22.Dock = System.Windows.Forms.DockStyle.Fill
Me.TableLayoutPanel22.Location = New System.Drawing.Point(3, 3)
Me.TableLayoutPanel22.Name = "TableLayoutPanel22"
Me.TableLayoutPanel22.RowCount = 11
Me.TableLayoutPanel22.RowStyles.Add(New System.Windows.Forms.RowStyle())
Me.TableLayoutPanel22.RowStyles.Add(New System.Windows.Forms.RowStyle())
Me.TableLayoutPanel22.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 171!))
Me.TableLayoutPanel22.RowStyles.Add(New System.Windows.Forms.RowStyle())
Me.TableLayoutPanel22.RowStyles.Add(New System.Windows.Forms.RowStyle())
Me.TableLayoutPanel22.RowStyles.Add(New System.Windows.Forms.RowStyle())
Me.TableLayoutPanel22.RowStyles.Add(New System.Windows.Forms.RowStyle())
Me.TableLayoutPanel22.RowStyles.Add(New System.Windows.Forms.RowStyle())
Me.TableLayoutPanel22.RowStyles.Add(New System.Windows.Forms.RowStyle())
Me.TableLayoutPanel22.RowStyles.Add(New System.Windows.Forms.RowStyle())
Me.TableLayoutPanel22.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20!))
Me.TableLayoutPanel22.Size = New System.Drawing.Size(653, 614)
Me.TableLayoutPanel22.TabIndex = 45
'
'txtOTHmemo
'
Me.TableLayoutPanel22.SetColumnSpan(Me.txtOTHmemo, 3)
Me.txtOTHmemo.Dock = System.Windows.Forms.DockStyle.Fill
Me.txtOTHmemo.Location = New System.Drawing.Point(112, 55)
Me.txtOTHmemo.Multiline = true
Me.txtOTHmemo.Name = "txtOTHmemo"
Me.TableLayoutPanel22.SetRowSpan(Me.txtOTHmemo, 2)
Me.txtOTHmemo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
Me.txtOTHmemo.Size = New System.Drawing.Size(538, 165)
Me.txtOTHmemo.TabIndex = 54
'
'Label9
'
Me.Label9.Anchor = System.Windows.Forms.AnchorStyles.Left
Me.Label9.AutoSize = true
Me.Label9.Location = New System.Drawing.Point(3, 230)
Me.Label9.Name = "Label9"
Me.Label9.Size = New System.Drawing.Size(57, 13)
Me.Label9.TabIndex = 55
Me.Label9.Text = "Филилал:"
'
'cmbOTHFil
'
Me.cmbOTHFil.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
Me.cmbOTHFil.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
Me.cmbOTHFil.Dock = System.Windows.Forms.DockStyle.Fill
Me.cmbOTHFil.FormattingEnabled = true
Me.cmbOTHFil.Location = New System.Drawing.Point(112, 226)
Me.cmbOTHFil.Name = "cmbOTHFil"
Me.cmbOTHFil.Size = New System.Drawing.Size(202, 21)
Me.cmbOTHFil.TabIndex = 56
'
'Label8
'
Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.Left
Me.Label8.AutoSize = true
Me.Label8.Location = New System.Drawing.Point(3, 257)
Me.Label8.Name = "Label8"
Me.Label8.Size = New System.Drawing.Size(41, 13)
Me.Label8.TabIndex = 57
Me.Label8.Text = "Отдел:"
'
'cmbOTHDepart
'
Me.cmbOTHDepart.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
Me.cmbOTHDepart.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
Me.cmbOTHDepart.Dock = System.Windows.Forms.DockStyle.Fill
Me.cmbOTHDepart.FormattingEnabled = true
Me.cmbOTHDepart.Location = New System.Drawing.Point(112, 253)
Me.cmbOTHDepart.Name = "cmbOTHDepart"
Me.cmbOTHDepart.Size = New System.Drawing.Size(202, 21)
Me.cmbOTHDepart.TabIndex = 58
'
'Label7
'
Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.Left
Me.Label7.AutoSize = true
Me.Label7.Location = New System.Drawing.Point(3, 284)
Me.Label7.Name = "Label7"
Me.Label7.Size = New System.Drawing.Size(52, 13)
Me.Label7.TabIndex = 59
Me.Label7.Text = "Кабинет:"
'
'cmbOTHOffice
'
Me.cmbOTHOffice.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
Me.cmbOTHOffice.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
Me.cmbOTHOffice.Dock = System.Windows.Forms.DockStyle.Fill
Me.cmbOTHOffice.FormattingEnabled = true
Me.cmbOTHOffice.Location = New System.Drawing.Point(112, 280)
Me.cmbOTHOffice.Name = "cmbOTHOffice"
Me.cmbOTHOffice.Size = New System.Drawing.Size(202, 21)
Me.cmbOTHOffice.TabIndex = 60
'
'Label6
'
Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.Left
Me.Label6.AutoSize = true
Me.Label6.Location = New System.Drawing.Point(3, 311)
Me.Label6.Name = "Label6"
Me.Label6.Size = New System.Drawing.Size(89, 13)
Me.Label6.TabIndex = 61
Me.Label6.Text = "Ответственный:"
'
'cmbOTHotv
'
Me.cmbOTHotv.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
Me.cmbOTHotv.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
Me.cmbOTHotv.Dock = System.Windows.Forms.DockStyle.Fill
Me.cmbOTHotv.FormattingEnabled = true
Me.cmbOTHotv.Location = New System.Drawing.Point(112, 307)
Me.cmbOTHotv.Name = "cmbOTHotv"
Me.cmbOTHotv.Size = New System.Drawing.Size(202, 21)
Me.cmbOTHotv.TabIndex = 62
'
'Label5
'
Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.Left
Me.Label5.AutoSize = true
Me.Label5.Location = New System.Drawing.Point(3, 337)
Me.Label5.Name = "Label5"
Me.Label5.Size = New System.Drawing.Size(55, 13)
Me.Label5.TabIndex = 63
Me.Label5.Text = "Телефон:"
'
'txtOTHphone
'
Me.txtOTHphone.Dock = System.Windows.Forms.DockStyle.Fill
Me.txtOTHphone.Location = New System.Drawing.Point(112, 334)
Me.txtOTHphone.Name = "txtOTHphone"
Me.txtOTHphone.Size = New System.Drawing.Size(202, 20)
Me.txtOTHphone.TabIndex = 64
'
'lblTipOther
'
Me.lblTipOther.Anchor = System.Windows.Forms.AnchorStyles.Left
Me.lblTipOther.AutoSize = true
Me.lblTipOther.Location = New System.Drawing.Point(3, 364)
Me.lblTipOther.Name = "lblTipOther"
Me.lblTipOther.Size = New System.Drawing.Size(89, 13)
Me.lblTipOther.TabIndex = 65
Me.lblTipOther.Text = "Тип устройства:"
'
'cmbOTHConnect
'
Me.cmbOTHConnect.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
Me.cmbOTHConnect.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
Me.cmbOTHConnect.Dock = System.Windows.Forms.DockStyle.Fill
Me.cmbOTHConnect.FormattingEnabled = true
Me.cmbOTHConnect.Location = New System.Drawing.Point(112, 360)
Me.cmbOTHConnect.Name = "cmbOTHConnect"
Me.cmbOTHConnect.Size = New System.Drawing.Size(202, 21)
Me.cmbOTHConnect.TabIndex = 66
'
'Label10
'
Me.Label10.Anchor = System.Windows.Forms.AnchorStyles.Left
Me.Label10.AutoSize = true
Me.Label10.Location = New System.Drawing.Point(320, 230)
Me.Label10.Name = "Label10"
Me.Label10.Size = New System.Drawing.Size(111, 13)
Me.Label10.TabIndex = 67
Me.Label10.Text = "Инвентарный номер"
'
'txtOTHinnumber
'
Me.txtOTHinnumber.Dock = System.Windows.Forms.DockStyle.Fill
Me.txtOTHinnumber.Location = New System.Drawing.Point(448, 226)
Me.txtOTHinnumber.Name = "txtOTHinnumber"
Me.txtOTHinnumber.Size = New System.Drawing.Size(202, 20)
Me.txtOTHinnumber.TabIndex = 68
'
'lblOTPCL
'
Me.lblOTPCL.Anchor = System.Windows.Forms.AnchorStyles.Left
Me.lblOTPCL.AutoSize = true
Me.lblOTPCL.Location = New System.Drawing.Point(320, 257)
Me.lblOTPCL.Name = "lblOTPCL"
Me.lblOTPCL.Size = New System.Drawing.Size(121, 13)
Me.lblOTPCL.TabIndex = 69
Me.lblOTPCL.Text = "В составе устройства:"
'
'cmbOTHPCL
'
Me.cmbOTHPCL.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
Me.cmbOTHPCL.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
Me.cmbOTHPCL.Dock = System.Windows.Forms.DockStyle.Fill
Me.cmbOTHPCL.FormattingEnabled = true
Me.cmbOTHPCL.Location = New System.Drawing.Point(448, 253)
Me.cmbOTHPCL.Name = "cmbOTHPCL"
Me.cmbOTHPCL.Size = New System.Drawing.Size(202, 21)
Me.cmbOTHPCL.TabIndex = 70
'
'lblOtIp
'
Me.lblOtIp.Anchor = System.Windows.Forms.AnchorStyles.Left
Me.lblOtIp.AutoSize = true
Me.lblOtIp.Location = New System.Drawing.Point(320, 284)
Me.lblOtIp.Name = "lblOtIp"
Me.lblOtIp.Size = New System.Drawing.Size(20, 13)
Me.lblOtIp.TabIndex = 71
Me.lblOtIp.Text = "IP:"
'
'lblOTMac
'
Me.lblOTMac.Anchor = System.Windows.Forms.AnchorStyles.Left
Me.lblOTMac.AutoSize = true
Me.lblOTMac.Location = New System.Drawing.Point(320, 311)
Me.lblOTMac.Name = "lblOTMac"
Me.lblOTMac.Size = New System.Drawing.Size(33, 13)
Me.lblOTMac.TabIndex = 72
Me.lblOTMac.Text = "MAC:"
'
'txtOTHIP
'
Me.txtOTHIP.Dock = System.Windows.Forms.DockStyle.Fill
Me.txtOTHIP.Location = New System.Drawing.Point(448, 280)
Me.txtOTHIP.Name = "txtOTHIP"
Me.txtOTHIP.Size = New System.Drawing.Size(202, 20)
Me.txtOTHIP.TabIndex = 73
'
'txtOTHMAC
'
Me.txtOTHMAC.Dock = System.Windows.Forms.DockStyle.Fill
Me.txtOTHMAC.Location = New System.Drawing.Point(448, 307)
Me.txtOTHMAC.Name = "txtOTHMAC"
Me.txtOTHMAC.Size = New System.Drawing.Size(202, 20)
Me.txtOTHMAC.TabIndex = 74
'
'Label3
'
Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Left
Me.Label3.AutoSize = true
Me.Label3.Location = New System.Drawing.Point(3, 131)
Me.Label3.Name = "Label3"
Me.Label3.Size = New System.Drawing.Size(103, 13)
Me.Label3.TabIndex = 53
Me.Label3.Text = "Краткое описание:"
'
'gbSNMP
'
Me.TableLayoutPanel22.SetColumnSpan(Me.gbSNMP, 4)
Me.gbSNMP.Controls.Add(Me.TableLayoutPanel3)
Me.gbSNMP.Dock = System.Windows.Forms.DockStyle.Fill
Me.gbSNMP.Location = New System.Drawing.Point(3, 403)
Me.gbSNMP.Name = "gbSNMP"
Me.gbSNMP.Size = New System.Drawing.Size(647, 208)
Me.gbSNMP.TabIndex = 80
Me.gbSNMP.TabStop = false
Me.gbSNMP.Text = "SNMP "
Me.gbSNMP.Visible = false
'
'TableLayoutPanel3
'
Me.TableLayoutPanel3.ColumnCount = 4
Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25!))
Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25!))
Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25!))
Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25!))
Me.TableLayoutPanel3.Controls.Add(Me.Label90, 0, 0)
Me.TableLayoutPanel3.Controls.Add(Me.Label91, 0, 1)
Me.TableLayoutPanel3.Controls.Add(Me.Label92, 0, 2)
Me.TableLayoutPanel3.Controls.Add(Me.Label93, 0, 3)
Me.TableLayoutPanel3.Controls.Add(Me.Label94, 1, 0)
Me.TableLayoutPanel3.Controls.Add(Me.Label95, 1, 1)
Me.TableLayoutPanel3.Controls.Add(Me.Label96, 1, 2)
Me.TableLayoutPanel3.Controls.Add(Me.Label97, 1, 3)
Me.TableLayoutPanel3.Controls.Add(Me.Label98, 2, 0)
Me.TableLayoutPanel3.Controls.Add(Me.Label99, 2, 1)
Me.TableLayoutPanel3.Controls.Add(Me.Label100, 2, 2)
Me.TableLayoutPanel3.Controls.Add(Me.Label101, 2, 3)
Me.TableLayoutPanel3.Controls.Add(Me.Label102, 3, 0)
Me.TableLayoutPanel3.Controls.Add(Me.Label103, 3, 1)
Me.TableLayoutPanel3.Controls.Add(Me.Label104, 3, 2)
Me.TableLayoutPanel3.Controls.Add(Me.Label105, 3, 3)
Me.TableLayoutPanel3.Controls.Add(Me.Label106, 0, 4)
Me.TableLayoutPanel3.Controls.Add(Me.Label107, 0, 5)
Me.TableLayoutPanel3.Controls.Add(Me.Label108, 0, 6)
Me.TableLayoutPanel3.Controls.Add(Me.Label109, 0, 7)
Me.TableLayoutPanel3.Controls.Add(Me.Label110, 1, 4)
Me.TableLayoutPanel3.Controls.Add(Me.Label111, 1, 5)
Me.TableLayoutPanel3.Controls.Add(Me.Label112, 1, 6)
Me.TableLayoutPanel3.Controls.Add(Me.Label113, 1, 7)
Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
Me.TableLayoutPanel3.Location = New System.Drawing.Point(3, 16)
Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
Me.TableLayoutPanel3.RowCount = 8
Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20!))
Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20!))
Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20!))
Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20!))
Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20!))
Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20!))
Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20!))
Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20!))
Me.TableLayoutPanel3.Size = New System.Drawing.Size(641, 189)
Me.TableLayoutPanel3.TabIndex = 0
'
'Label90
'
Me.Label90.AutoSize = true
Me.Label90.Location = New System.Drawing.Point(3, 0)
Me.Label90.Name = "Label90"
Me.Label90.Size = New System.Drawing.Size(34, 13)
Me.Label90.TabIndex = 0
Me.Label90.Text = "Тест:"
'
'Label91
'
Me.Label91.AutoSize = true
Me.Label91.Location = New System.Drawing.Point(3, 20)
Me.Label91.Name = "Label91"
Me.Label91.Size = New System.Drawing.Size(67, 13)
Me.Label91.TabIndex = 1
Me.Label91.Text = "Дата теста:"
'
'Label92
'
Me.Label92.AutoSize = true
Me.Label92.Location = New System.Drawing.Point(3, 40)
Me.Label92.Name = "Label92"
Me.Label92.Size = New System.Drawing.Size(77, 13)
Me.Label92.TabIndex = 2
Me.Label92.Text = "Температура:"
'
'Label93
'
Me.Label93.AutoSize = true
Me.Label93.Location = New System.Drawing.Point(3, 60)
Me.Label93.Name = "Label93"
Me.Label93.Size = New System.Drawing.Size(148, 13)
Me.Label93.TabIndex = 3
Me.Label93.Text = "Температура в помещении:"
'
'Label94
'
Me.Label94.AutoSize = true
Me.Label94.Location = New System.Drawing.Point(163, 0)
Me.Label94.Name = "Label94"
Me.Label94.Size = New System.Drawing.Size(10, 13)
Me.Label94.TabIndex = 4
Me.Label94.Text = "-"
'
'Label95
'
Me.Label95.AutoSize = true
Me.Label95.Location = New System.Drawing.Point(163, 20)
Me.Label95.Name = "Label95"
Me.Label95.Size = New System.Drawing.Size(10, 13)
Me.Label95.TabIndex = 5
Me.Label95.Text = "-"
'
'Label96
'
Me.Label96.AutoSize = true
Me.Label96.Location = New System.Drawing.Point(163, 40)
Me.Label96.Name = "Label96"
Me.Label96.Size = New System.Drawing.Size(10, 13)
Me.Label96.TabIndex = 6
Me.Label96.Text = "-"
'
'Label97
'
Me.Label97.AutoSize = true
Me.Label97.Location = New System.Drawing.Point(163, 60)
Me.Label97.Name = "Label97"
Me.Label97.Size = New System.Drawing.Size(10, 13)
Me.Label97.TabIndex = 7
Me.Label97.Text = "-"
'
'Label98
'
Me.Label98.AutoSize = true
Me.Label98.Location = New System.Drawing.Point(323, 0)
Me.Label98.Name = "Label98"
Me.Label98.Size = New System.Drawing.Size(141, 13)
Me.Label98.TabIndex = 8
Me.Label98.Text = "Время работы от батареи:"
'
'Label99
'
Me.Label99.AutoSize = true
Me.Label99.Location = New System.Drawing.Point(323, 20)
Me.Label99.Name = "Label99"
Me.Label99.Size = New System.Drawing.Size(85, 13)
Me.Label99.TabIndex = 9
Me.Label99.Text = "Заряд батареи:"
'
'Label100
'
Me.Label100.AutoSize = true
Me.Label100.Location = New System.Drawing.Point(323, 40)
Me.Label100.Name = "Label100"
Me.Label100.Size = New System.Drawing.Size(93, 13)
Me.Label100.TabIndex = 10
Me.Label100.Text = "Замена батареи:"
'
'Label101
'
Me.Label101.AutoSize = true
Me.Label101.Location = New System.Drawing.Point(323, 60)
Me.Label101.Name = "Label101"
Me.Label101.Size = New System.Drawing.Size(55, 13)
Me.Label101.TabIndex = 11
Me.Label101.Text = "В работе:"
'
'Label102
'
Me.Label102.AutoSize = true
Me.Label102.Location = New System.Drawing.Point(483, 0)
Me.Label102.Name = "Label102"
Me.Label102.Size = New System.Drawing.Size(10, 13)
Me.Label102.TabIndex = 12
Me.Label102.Text = "-"
'
'Label103
'
Me.Label103.AutoSize = true
Me.Label103.Location = New System.Drawing.Point(483, 20)
Me.Label103.Name = "Label103"
Me.Label103.Size = New System.Drawing.Size(10, 13)
Me.Label103.TabIndex = 13
Me.Label103.Text = "-"
'
'Label104
'
Me.Label104.AutoSize = true
Me.Label104.Location = New System.Drawing.Point(483, 40)
Me.Label104.Name = "Label104"
Me.Label104.Size = New System.Drawing.Size(10, 13)
Me.Label104.TabIndex = 14
Me.Label104.Text = "-"
'
'Label105
'
Me.Label105.AutoSize = true
Me.Label105.Location = New System.Drawing.Point(483, 60)
Me.Label105.Name = "Label105"
Me.Label105.Size = New System.Drawing.Size(10, 13)
Me.Label105.TabIndex = 15
Me.Label105.Text = "-"
'
'Label106
'
Me.Label106.AutoSize = true
Me.Label106.Location = New System.Drawing.Point(3, 80)
Me.Label106.Name = "Label106"
Me.Label106.Size = New System.Drawing.Size(117, 13)
Me.Label106.TabIndex = 16
Me.Label106.Text = "Входное напряжение:"
'
'Label107
'
Me.Label107.AutoSize = true
Me.Label107.Location = New System.Drawing.Point(3, 100)
Me.Label107.Name = "Label107"
Me.Label107.Size = New System.Drawing.Size(125, 13)
Me.Label107.TabIndex = 17
Me.Label107.Text = "Выходное напряжение:"
'
'Label108
'
Me.Label108.AutoSize = true
Me.Label108.Location = New System.Drawing.Point(3, 120)
Me.Label108.Name = "Label108"
Me.Label108.Size = New System.Drawing.Size(58, 13)
Me.Label108.TabIndex = 18
Me.Label108.Text = "Нагрузка:"
'
'Label109
'
Me.Label109.AutoSize = true
Me.Label109.Location = New System.Drawing.Point(3, 140)
Me.Label109.Name = "Label109"
Me.Label109.Size = New System.Drawing.Size(44, 13)
Me.Label109.TabIndex = 19
Me.Label109.Text = "Статус:"
'
'Label110
'
Me.Label110.AutoSize = true
Me.Label110.Location = New System.Drawing.Point(163, 80)
Me.Label110.Name = "Label110"
Me.Label110.Size = New System.Drawing.Size(10, 13)
Me.Label110.TabIndex = 20
Me.Label110.Text = "-"
'
'Label111
'
Me.Label111.AutoSize = true
Me.Label111.Location = New System.Drawing.Point(163, 100)
Me.Label111.Name = "Label111"
Me.Label111.Size = New System.Drawing.Size(10, 13)
Me.Label111.TabIndex = 21
Me.Label111.Text = "-"
'
'Label112
'
Me.Label112.AutoSize = true
Me.Label112.Location = New System.Drawing.Point(163, 120)
Me.Label112.Name = "Label112"
Me.Label112.Size = New System.Drawing.Size(10, 13)
Me.Label112.TabIndex = 22
Me.Label112.Text = "-"
'
'Label113
'
Me.Label113.AutoSize = true
Me.Label113.Location = New System.Drawing.Point(163, 140)
Me.Label113.Name = "Label113"
Me.Label113.Size = New System.Drawing.Size(10, 13)
Me.Label113.TabIndex = 23
Me.Label113.Text = "-"
'
'Label87
'
Me.Label87.Anchor = System.Windows.Forms.AnchorStyles.Left
Me.Label87.AutoSize = true
Me.Label87.Location = New System.Drawing.Point(3, 385)
Me.Label87.Name = "Label87"
Me.Label87.Size = New System.Drawing.Size(54, 13)
Me.Label87.TabIndex = 75
Me.Label87.Text = "№ в базе"
'
'lblSNMP_Ping
'
Me.lblSNMP_Ping.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
Me.lblSNMP_Ping.AutoSize = true
Me.lblSNMP_Ping.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
Me.lblSNMP_Ping.Location = New System.Drawing.Point(448, 336)
Me.lblSNMP_Ping.Name = "lblSNMP_Ping"
Me.lblSNMP_Ping.Size = New System.Drawing.Size(202, 16)
Me.lblSNMP_Ping.TabIndex = 81
Me.lblSNMP_Ping.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
Me.lblSNMP_Ping.Visible = false
'
'lblsIDOTH
'
Me.lblsIDOTH.AutoSize = true
Me.lblsIDOTH.Dock = System.Windows.Forms.DockStyle.Fill
Me.lblsIDOTH.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
Me.lblsIDOTH.Location = New System.Drawing.Point(112, 384)
Me.lblsIDOTH.Name = "lblsIDOTH"
Me.lblsIDOTH.Size = New System.Drawing.Size(202, 16)
Me.lblsIDOTH.TabIndex = 76
'
'chkSNMP
'
Me.chkSNMP.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
Me.chkSNMP.AutoSize = true
Me.chkSNMP.Location = New System.Drawing.Point(320, 335)
Me.chkSNMP.Name = "chkSNMP"
Me.chkSNMP.Size = New System.Drawing.Size(122, 17)
Me.chkSNMP.TabIndex = 77
Me.chkSNMP.Text = "SNMP"
Me.chkSNMP.UseVisualStyleBackColor = true
'
'lblSNMP
'
Me.lblSNMP.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
Me.lblSNMP.AutoSize = true
Me.lblSNMP.Location = New System.Drawing.Point(320, 364)
Me.lblSNMP.Name = "lblSNMP"
Me.lblSNMP.Size = New System.Drawing.Size(122, 13)
Me.lblSNMP.TabIndex = 78
Me.lblSNMP.Text = "SNMP Community:"
Me.lblSNMP.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
Me.lblSNMP.Visible = false
'
'txtSNMP
'
Me.txtSNMP.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
Me.txtSNMP.Location = New System.Drawing.Point(448, 360)
Me.txtSNMP.Name = "txtSNMP"
Me.txtSNMP.Size = New System.Drawing.Size(202, 20)
Me.txtSNMP.TabIndex = 79
Me.txtSNMP.Visible = false
'
'gbOTh
'
Me.gbOTh.AutoSize = true
Me.TableLayoutPanel22.SetColumnSpan(Me.gbOTh, 4)
Me.gbOTh.Controls.Add(Me.TableLayoutPanel7)
Me.gbOTh.Dock = System.Windows.Forms.DockStyle.Fill
Me.gbOTh.Location = New System.Drawing.Point(3, 3)
Me.gbOTh.Name = "gbOTh"
Me.gbOTh.Size = New System.Drawing.Size(647, 46)
Me.gbOTh.TabIndex = 35
Me.gbOTh.TabStop = false
Me.gbOTh.Text = "Информация"
'
'TableLayoutPanel7
'
Me.TableLayoutPanel7.AutoSize = true
Me.TableLayoutPanel7.ColumnCount = 4
Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 54.54546!))
Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45.45454!))
Me.TableLayoutPanel7.Controls.Add(Me.PROiZV39, 3, 0)
Me.TableLayoutPanel7.Controls.Add(Me.cmbOTH, 0, 0)
Me.TableLayoutPanel7.Controls.Add(Me.txtMonDum, 1, 0)
Me.TableLayoutPanel7.Controls.Add(Me.txtOTHSN, 2, 0)
Me.TableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill
Me.TableLayoutPanel7.Location = New System.Drawing.Point(3, 16)
Me.TableLayoutPanel7.Name = "TableLayoutPanel7"
Me.TableLayoutPanel7.RowCount = 1
Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100!))
Me.TableLayoutPanel7.Size = New System.Drawing.Size(641, 27)
Me.TableLayoutPanel7.TabIndex = 4
'
'PROiZV39
'
Me.PROiZV39.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
Me.PROiZV39.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
Me.PROiZV39.Dock = System.Windows.Forms.DockStyle.Fill
Me.PROiZV39.FormattingEnabled = true
Me.PROiZV39.Location = New System.Drawing.Point(482, 3)
Me.PROiZV39.Name = "PROiZV39"
Me.PROiZV39.Size = New System.Drawing.Size(156, 21)
Me.PROiZV39.TabIndex = 3
'
'cmbOTH
'
Me.cmbOTH.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
Me.cmbOTH.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
Me.cmbOTH.Dock = System.Windows.Forms.DockStyle.Fill
Me.cmbOTH.FormattingEnabled = true
Me.cmbOTH.Location = New System.Drawing.Point(3, 3)
Me.cmbOTH.Name = "cmbOTH"
Me.cmbOTH.Size = New System.Drawing.Size(188, 21)
Me.cmbOTH.TabIndex = 0
'
'txtMonDum
'
Me.txtMonDum.Dock = System.Windows.Forms.DockStyle.Fill
Me.txtMonDum.Location = New System.Drawing.Point(197, 3)
Me.txtMonDum.Name = "txtMonDum"
Me.txtMonDum.Size = New System.Drawing.Size(121, 20)
Me.txtMonDum.TabIndex = 1
Me.txtMonDum.Visible = false
'
'txtOTHSN
'
Me.txtOTHSN.Dock = System.Windows.Forms.DockStyle.Fill
Me.txtOTHSN.Location = New System.Drawing.Point(324, 3)
Me.txtOTHSN.Name = "txtOTHSN"
Me.txtOTHSN.Size = New System.Drawing.Size(152, 20)
Me.txtOTHSN.TabIndex = 2
'
'TabPage22
'
Me.TabPage22.Controls.Add(Me.lvMovementOTH)
Me.TabPage22.Location = New System.Drawing.Point(4, 22)
Me.TabPage22.Name = "TabPage22"
Me.TabPage22.Size = New System.Drawing.Size(659, 620)
Me.TabPage22.TabIndex = 3
Me.TabPage22.Text = "Движение"
Me.TabPage22.UseVisualStyleBackColor = true
'
'lvMovementOTH
'
Me.lvMovementOTH.Dock = System.Windows.Forms.DockStyle.Fill
Me.lvMovementOTH.FullRowSelect = true
Me.lvMovementOTH.GridLines = true
Me.lvMovementOTH.Location = New System.Drawing.Point(0, 0)
Me.lvMovementOTH.MultiSelect = false
Me.lvMovementOTH.Name = "lvMovementOTH"
Me.lvMovementOTH.Size = New System.Drawing.Size(659, 620)
Me.lvMovementOTH.TabIndex = 1
Me.lvMovementOTH.UseCompatibleStateImageBehavior = false
Me.lvMovementOTH.View = System.Windows.Forms.View.Details
'
'TabPage12
'
Me.TabPage12.Controls.Add(Me.TableLayoutPanel17)
Me.TabPage12.Location = New System.Drawing.Point(4, 22)
Me.TabPage12.Name = "TabPage12"
Me.TabPage12.Padding = New System.Windows.Forms.Padding(3)
Me.TabPage12.Size = New System.Drawing.Size(659, 620)
Me.TabPage12.TabIndex = 1
Me.TabPage12.Text = "Сервис"
Me.TabPage12.UseVisualStyleBackColor = true
'
'TableLayoutPanel17
'
Me.TableLayoutPanel17.ColumnCount = 1
Me.TableLayoutPanel17.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100!))
Me.TableLayoutPanel17.Controls.Add(Me.gbOTHRemont, 0, 1)
Me.TableLayoutPanel17.Controls.Add(Me.gbOTHNotes, 0, 0)
Me.TableLayoutPanel17.Dock = System.Windows.Forms.DockStyle.Fill
Me.TableLayoutPanel17.Location = New System.Drawing.Point(3, 3)
Me.TableLayoutPanel17.Name = "TableLayoutPanel17"
Me.TableLayoutPanel17.RowCount = 2
Me.TableLayoutPanel17.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40!))
Me.TableLayoutPanel17.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60!))
Me.TableLayoutPanel17.Size = New System.Drawing.Size(653, 614)
Me.TableLayoutPanel17.TabIndex = 7
'
'gbOTHRemont
'
Me.gbOTHRemont.AutoSize = true
Me.gbOTHRemont.Controls.Add(Me.lvRepairOTH)
Me.gbOTHRemont.Dock = System.Windows.Forms.DockStyle.Fill
Me.gbOTHRemont.Location = New System.Drawing.Point(3, 248)
Me.gbOTHRemont.Name = "gbOTHRemont"
Me.gbOTHRemont.Size = New System.Drawing.Size(647, 363)
Me.gbOTHRemont.TabIndex = 4
Me.gbOTHRemont.TabStop = false
Me.gbOTHRemont.Text = "Ремонты"
'
'lvRepairOTH
'
Me.lvRepairOTH.Dock = System.Windows.Forms.DockStyle.Fill
Me.lvRepairOTH.FullRowSelect = true
Me.lvRepairOTH.GridLines = true
Me.lvRepairOTH.Location = New System.Drawing.Point(3, 16)
Me.lvRepairOTH.MultiSelect = false
Me.lvRepairOTH.Name = "lvRepairOTH"
Me.lvRepairOTH.ShowItemToolTips = true
Me.lvRepairOTH.Size = New System.Drawing.Size(641, 344)
Me.lvRepairOTH.TabIndex = 4
Me.lvRepairOTH.UseCompatibleStateImageBehavior = false
Me.lvRepairOTH.View = System.Windows.Forms.View.Details
'
'gbOTHNotes
'
Me.gbOTHNotes.Controls.Add(Me.TableLayoutPanel18)
Me.gbOTHNotes.Dock = System.Windows.Forms.DockStyle.Fill
Me.gbOTHNotes.Location = New System.Drawing.Point(3, 3)
Me.gbOTHNotes.Name = "gbOTHNotes"
Me.gbOTHNotes.Size = New System.Drawing.Size(647, 239)
Me.gbOTHNotes.TabIndex = 3
Me.gbOTHNotes.TabStop = false
Me.gbOTHNotes.Text = "Заметки"
'
'TableLayoutPanel18
'
Me.TableLayoutPanel18.ColumnCount = 3
Me.TableLayoutPanel18.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 126!))
Me.TableLayoutPanel18.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100!))
Me.TableLayoutPanel18.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120!))
Me.TableLayoutPanel18.Controls.Add(Me.ToolStrip6, 2, 0)
Me.TableLayoutPanel18.Controls.Add(Me.lvNotesOTH, 0, 2)
Me.TableLayoutPanel18.Controls.Add(Me.txtNotesOTH, 0, 1)
Me.TableLayoutPanel18.Controls.Add(Me.cmbNotesOTHMaster, 1, 0)
Me.TableLayoutPanel18.Controls.Add(Me.NotesOTHdate, 0, 0)
Me.TableLayoutPanel18.Dock = System.Windows.Forms.DockStyle.Fill
Me.TableLayoutPanel18.Location = New System.Drawing.Point(3, 16)
Me.TableLayoutPanel18.Name = "TableLayoutPanel18"
Me.TableLayoutPanel18.RowCount = 3
Me.TableLayoutPanel18.RowStyles.Add(New System.Windows.Forms.RowStyle())
Me.TableLayoutPanel18.RowStyles.Add(New System.Windows.Forms.RowStyle())
Me.TableLayoutPanel18.RowStyles.Add(New System.Windows.Forms.RowStyle())
Me.TableLayoutPanel18.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20!))
Me.TableLayoutPanel18.Size = New System.Drawing.Size(641, 220)
Me.TableLayoutPanel18.TabIndex = 1
'
'ToolStrip6
'
Me.ToolStrip6.Dock = System.Windows.Forms.DockStyle.Fill
Me.ToolStrip6.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
Me.ToolStrip6.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnOTHAdd, Me.ToolStripSeparator17, Me.btnOTHNotesDel, Me.ToolStripSeparator18, Me.btnOTHNotesCancel, Me.ToolStripSeparator19})
Me.ToolStrip6.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow
Me.ToolStrip6.Location = New System.Drawing.Point(521, 0)
Me.ToolStrip6.Name = "ToolStrip6"
Me.TableLayoutPanel18.SetRowSpan(Me.ToolStrip6, 2)
Me.ToolStrip6.Size = New System.Drawing.Size(120, 107)
Me.ToolStrip6.TabIndex = 10
Me.ToolStrip6.Text = "ToolStrip6"
'
'btnOTHAdd
'
Me.btnOTHAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
Me.btnOTHAdd.Image = CType(resources.GetObject("btnOTHAdd.Image"),System.Drawing.Image)
Me.btnOTHAdd.ImageTransparentColor = System.Drawing.Color.Magenta
Me.btnOTHAdd.Name = "btnOTHAdd"
Me.btnOTHAdd.Size = New System.Drawing.Size(118, 19)
Me.btnOTHAdd.Text = "Добавить"
'
'ToolStripSeparator17
'
Me.ToolStripSeparator17.Name = "ToolStripSeparator17"
Me.ToolStripSeparator17.Size = New System.Drawing.Size(118, 6)
'
'btnOTHNotesDel
'
Me.btnOTHNotesDel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
Me.btnOTHNotesDel.Image = CType(resources.GetObject("btnOTHNotesDel.Image"),System.Drawing.Image)
Me.btnOTHNotesDel.ImageTransparentColor = System.Drawing.Color.Magenta
Me.btnOTHNotesDel.Name = "btnOTHNotesDel"
Me.btnOTHNotesDel.Size = New System.Drawing.Size(118, 19)
Me.btnOTHNotesDel.Text = "Удалить"
'
'ToolStripSeparator18
'
Me.ToolStripSeparator18.Name = "ToolStripSeparator18"
Me.ToolStripSeparator18.Size = New System.Drawing.Size(118, 6)
'
'btnOTHNotesCancel
'
Me.btnOTHNotesCancel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
Me.btnOTHNotesCancel.Image = CType(resources.GetObject("btnOTHNotesCancel.Image"),System.Drawing.Image)
Me.btnOTHNotesCancel.ImageTransparentColor = System.Drawing.Color.Magenta
Me.btnOTHNotesCancel.Name = "btnOTHNotesCancel"
Me.btnOTHNotesCancel.Size = New System.Drawing.Size(118, 19)
Me.btnOTHNotesCancel.Text = "Отмена"
'
'ToolStripSeparator19
'
Me.ToolStripSeparator19.Name = "ToolStripSeparator19"
Me.ToolStripSeparator19.Size = New System.Drawing.Size(118, 6)
'
'lvNotesOTH
'
Me.TableLayoutPanel18.SetColumnSpan(Me.lvNotesOTH, 3)
Me.lvNotesOTH.Dock = System.Windows.Forms.DockStyle.Fill
Me.lvNotesOTH.FullRowSelect = true
Me.lvNotesOTH.GridLines = true
Me.lvNotesOTH.Location = New System.Drawing.Point(3, 110)
Me.lvNotesOTH.Name = "lvNotesOTH"
Me.lvNotesOTH.Size = New System.Drawing.Size(635, 107)
Me.lvNotesOTH.TabIndex = 4
Me.lvNotesOTH.UseCompatibleStateImageBehavior = false
Me.lvNotesOTH.View = System.Windows.Forms.View.Details
'
'txtNotesOTH
'
Me.TableLayoutPanel18.SetColumnSpan(Me.txtNotesOTH, 2)
Me.txtNotesOTH.Dock = System.Windows.Forms.DockStyle.Fill
Me.txtNotesOTH.Location = New System.Drawing.Point(3, 30)
Me.txtNotesOTH.Multiline = true
Me.txtNotesOTH.Name = "txtNotesOTH"
Me.txtNotesOTH.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
Me.txtNotesOTH.Size = New System.Drawing.Size(515, 74)
Me.txtNotesOTH.TabIndex = 3
'
'cmbNotesOTHMaster
'
Me.cmbNotesOTHMaster.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
Me.cmbNotesOTHMaster.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
Me.cmbNotesOTHMaster.Dock = System.Windows.Forms.DockStyle.Fill
Me.cmbNotesOTHMaster.FormattingEnabled = true
Me.cmbNotesOTHMaster.Location = New System.Drawing.Point(129, 3)
Me.cmbNotesOTHMaster.Name = "cmbNotesOTHMaster"
Me.cmbNotesOTHMaster.Size = New System.Drawing.Size(389, 21)
Me.cmbNotesOTHMaster.TabIndex = 2
'
'NotesOTHdate
'
Me.NotesOTHdate.Dock = System.Windows.Forms.DockStyle.Fill
Me.NotesOTHdate.Location = New System.Drawing.Point(3, 3)
Me.NotesOTHdate.Name = "NotesOTHdate"
Me.NotesOTHdate.Size = New System.Drawing.Size(120, 20)
Me.NotesOTHdate.TabIndex = 1
Me.NotesOTHdate.Value = New Date(2011, 6, 23, 0, 0, 0, 0)
'
'TabPage18
'
Me.TabPage18.Controls.Add(Me.TableLayoutPanel70)
Me.TabPage18.Location = New System.Drawing.Point(4, 22)
Me.TabPage18.Name = "TabPage18"
Me.TabPage18.Size = New System.Drawing.Size(659, 620)
Me.TabPage18.TabIndex = 2
Me.TabPage18.Text = "Гарантия"
Me.TabPage18.UseVisualStyleBackColor = true
'
'TableLayoutPanel70
'
Me.TableLayoutPanel70.ColumnCount = 1
Me.TableLayoutPanel70.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100!))
Me.TableLayoutPanel70.Controls.Add(Me.gbPostOTH, 0, 0)
Me.TableLayoutPanel70.Controls.Add(Me.gbSaleOTH, 0, 1)
Me.TableLayoutPanel70.Dock = System.Windows.Forms.DockStyle.Fill
Me.TableLayoutPanel70.Location = New System.Drawing.Point(0, 0)
Me.TableLayoutPanel70.Name = "TableLayoutPanel70"
Me.TableLayoutPanel70.RowCount = 3
Me.TableLayoutPanel70.RowStyles.Add(New System.Windows.Forms.RowStyle())
Me.TableLayoutPanel70.RowStyles.Add(New System.Windows.Forms.RowStyle())
Me.TableLayoutPanel70.RowStyles.Add(New System.Windows.Forms.RowStyle())
Me.TableLayoutPanel70.Size = New System.Drawing.Size(659, 620)
Me.TableLayoutPanel70.TabIndex = 6
'
'gbPostOTH
'
Me.gbPostOTH.Controls.Add(Me.TableLayoutPanel56)
Me.gbPostOTH.Dock = System.Windows.Forms.DockStyle.Fill
Me.gbPostOTH.Location = New System.Drawing.Point(3, 3)
Me.gbPostOTH.Name = "gbPostOTH"
Me.gbPostOTH.Size = New System.Drawing.Size(653, 91)
Me.gbPostOTH.TabIndex = 4
Me.gbPostOTH.TabStop = false
Me.gbPostOTH.Text = "Поставщик"
'
'TableLayoutPanel56
'
Me.TableLayoutPanel56.ColumnCount = 4
Me.TableLayoutPanel56.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 97!))
Me.TableLayoutPanel56.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50!))
Me.TableLayoutPanel56.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90!))
Me.TableLayoutPanel56.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50!))
Me.TableLayoutPanel56.Controls.Add(Me.dtGOTHok, 3, 1)
Me.TableLayoutPanel56.Controls.Add(Me.Label42, 0, 0)
Me.TableLayoutPanel56.Controls.Add(Me.Label40, 2, 1)
Me.TableLayoutPanel56.Controls.Add(Me.cmbOTHPostav, 1, 0)
Me.TableLayoutPanel56.Controls.Add(Me.dtGOTHPr, 1, 1)
Me.TableLayoutPanel56.Controls.Add(Me.Label41, 0, 1)
Me.TableLayoutPanel56.Dock = System.Windows.Forms.DockStyle.Fill
Me.TableLayoutPanel56.Location = New System.Drawing.Point(3, 16)
Me.TableLayoutPanel56.Name = "TableLayoutPanel56"
Me.TableLayoutPanel56.RowCount = 2
Me.TableLayoutPanel56.RowStyles.Add(New System.Windows.Forms.RowStyle())
Me.TableLayoutPanel56.RowStyles.Add(New System.Windows.Forms.RowStyle())
Me.TableLayoutPanel56.Size = New System.Drawing.Size(647, 72)
Me.TableLayoutPanel56.TabIndex = 3
'
'dtGOTHok
'
Me.dtGOTHok.Anchor = System.Windows.Forms.AnchorStyles.Left
Me.dtGOTHok.Location = New System.Drawing.Point(420, 39)
Me.dtGOTHok.Name = "dtGOTHok"
Me.dtGOTHok.Size = New System.Drawing.Size(134, 20)
Me.dtGOTHok.TabIndex = 9
Me.dtGOTHok.Value = New Date(2013, 10, 25, 0, 0, 0, 0)
'
'Label42
'
Me.Label42.Anchor = System.Windows.Forms.AnchorStyles.Left
Me.Label42.AutoSize = true
Me.Label42.Location = New System.Drawing.Point(3, 7)
Me.Label42.Name = "Label42"
Me.Label42.Size = New System.Drawing.Size(57, 13)
Me.Label42.TabIndex = 5
Me.Label42.Text = "Продавец"
'
'Label40
'
Me.Label40.Anchor = System.Windows.Forms.AnchorStyles.Left
Me.Label40.AutoSize = true
Me.Label40.Location = New System.Drawing.Point(330, 43)
Me.Label40.Name = "Label40"
Me.Label40.Size = New System.Drawing.Size(65, 13)
Me.Label40.TabIndex = 10
Me.Label40.Text = "Окончание:"
'
'cmbOTHPostav
'
Me.cmbOTHPostav.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
Me.cmbOTHPostav.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
Me.TableLayoutPanel56.SetColumnSpan(Me.cmbOTHPostav, 3)
Me.cmbOTHPostav.Dock = System.Windows.Forms.DockStyle.Fill
Me.cmbOTHPostav.FormattingEnabled = true
Me.cmbOTHPostav.Location = New System.Drawing.Point(100, 3)
Me.cmbOTHPostav.Name = "cmbOTHPostav"
Me.cmbOTHPostav.Size = New System.Drawing.Size(544, 21)
Me.cmbOTHPostav.TabIndex = 6
'
'dtGOTHPr
'
Me.dtGOTHPr.Anchor = System.Windows.Forms.AnchorStyles.Left
Me.dtGOTHPr.Location = New System.Drawing.Point(100, 39)
Me.dtGOTHPr.Name = "dtGOTHPr"
Me.dtGOTHPr.Size = New System.Drawing.Size(134, 20)
Me.dtGOTHPr.TabIndex = 8
Me.dtGOTHPr.Value = New Date(2013, 10, 25, 0, 0, 0, 0)
'
'Label41
'
Me.Label41.Anchor = System.Windows.Forms.AnchorStyles.Left
Me.Label41.AutoSize = true
Me.Label41.Location = New System.Drawing.Point(3, 43)
Me.Label41.Name = "Label41"
Me.Label41.Size = New System.Drawing.Size(77, 13)
Me.Label41.TabIndex = 7
Me.Label41.Text = "Приобретено:"
'
'gbSaleOTH
'
Me.gbSaleOTH.AutoSize = true
Me.gbSaleOTH.Controls.Add(Me.TableLayoutPanel54)
Me.gbSaleOTH.Dock = System.Windows.Forms.DockStyle.Fill
Me.gbSaleOTH.Location = New System.Drawing.Point(3, 100)
Me.gbSaleOTH.Name = "gbSaleOTH"
Me.gbSaleOTH.Size = New System.Drawing.Size(653, 123)
Me.gbSaleOTH.TabIndex = 5
Me.gbSaleOTH.TabStop = false
Me.gbSaleOTH.Text = "Данные о приобретении"
'
'TableLayoutPanel54
'
Me.TableLayoutPanel54.AutoSize = true
Me.TableLayoutPanel54.ColumnCount = 4
Me.TableLayoutPanel54.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100!))
Me.TableLayoutPanel54.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50!))
Me.TableLayoutPanel54.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80!))
Me.TableLayoutPanel54.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50!))
Me.TableLayoutPanel54.Controls.Add(Me.chkOTHNNb, 3, 3)
Me.TableLayoutPanel54.Controls.Add(Me.txtOTHSumm, 1, 2)
Me.TableLayoutPanel54.Controls.Add(Me.dtOTHdataVvoda, 3, 2)
Me.TableLayoutPanel54.Controls.Add(Me.Label66, 0, 0)
Me.TableLayoutPanel54.Controls.Add(Me.txtOTHZay, 3, 1)
Me.TableLayoutPanel54.Controls.Add(Me.Label61, 2, 2)
Me.TableLayoutPanel54.Controls.Add(Me.dtOTHSFdate, 3, 0)
Me.TableLayoutPanel54.Controls.Add(Me.Label65, 0, 1)
Me.TableLayoutPanel54.Controls.Add(Me.txtOTHcash, 1, 1)
Me.TableLayoutPanel54.Controls.Add(Me.Label62, 2, 1)
Me.TableLayoutPanel54.Controls.Add(Me.Label64, 0, 2)
Me.TableLayoutPanel54.Controls.Add(Me.txtOTHSfN, 1, 0)
Me.TableLayoutPanel54.Controls.Add(Me.Label63, 2, 0)
Me.TableLayoutPanel54.Controls.Add(Me.chkOTHspis, 0, 3)
Me.TableLayoutPanel54.Controls.Add(Me.dtOTHSpisanie, 1, 3)
Me.TableLayoutPanel54.Dock = System.Windows.Forms.DockStyle.Fill
Me.TableLayoutPanel54.Location = New System.Drawing.Point(3, 16)
Me.TableLayoutPanel54.Name = "TableLayoutPanel54"
Me.TableLayoutPanel54.RowCount = 4
Me.TableLayoutPanel54.RowStyles.Add(New System.Windows.Forms.RowStyle())
Me.TableLayoutPanel54.RowStyles.Add(New System.Windows.Forms.RowStyle())
Me.TableLayoutPanel54.RowStyles.Add(New System.Windows.Forms.RowStyle())
Me.TableLayoutPanel54.RowStyles.Add(New System.Windows.Forms.RowStyle())
Me.TableLayoutPanel54.Size = New System.Drawing.Size(647, 104)
Me.TableLayoutPanel54.TabIndex = 3
'
'chkOTHNNb
'
Me.chkOTHNNb.Anchor = System.Windows.Forms.AnchorStyles.Left
Me.chkOTHNNb.AutoSize = true
Me.chkOTHNNb.Location = New System.Drawing.Point(416, 82)
Me.chkOTHNNb.Name = "chkOTHNNb"
Me.chkOTHNNb.Size = New System.Drawing.Size(100, 17)
Me.chkOTHNNb.TabIndex = 23
Me.chkOTHNNb.Text = "Не на балансе"
Me.chkOTHNNb.UseVisualStyleBackColor = true
'
'txtOTHSumm
'
Me.txtOTHSumm.Dock = System.Windows.Forms.DockStyle.Fill
Me.txtOTHSumm.Location = New System.Drawing.Point(103, 55)
Me.txtOTHSumm.Maximum = New Decimal(New Integer() {1000000, 0, 0, 0})
Me.txtOTHSumm.Name = "txtOTHSumm"
Me.txtOTHSumm.Size = New System.Drawing.Size(227, 20)
Me.txtOTHSumm.TabIndex = 21
'
'dtOTHdataVvoda
'
Me.dtOTHdataVvoda.Dock = System.Windows.Forms.DockStyle.Fill
Me.dtOTHdataVvoda.Location = New System.Drawing.Point(416, 55)
Me.dtOTHdataVvoda.Name = "dtOTHdataVvoda"
Me.dtOTHdataVvoda.Size = New System.Drawing.Size(228, 20)
Me.dtOTHdataVvoda.TabIndex = 19
Me.dtOTHdataVvoda.Value = New Date(2013, 10, 25, 0, 0, 0, 0)
'
'Label66
'
Me.Label66.Anchor = System.Windows.Forms.AnchorStyles.Left
Me.Label66.AutoSize = true
Me.Label66.Location = New System.Drawing.Point(3, 6)
Me.Label66.Name = "Label66"
Me.Label66.Size = New System.Drawing.Size(89, 13)
Me.Label66.TabIndex = 12
Me.Label66.Text = "Счёт фактура №"
'
'txtOTHZay
'
Me.txtOTHZay.Dock = System.Windows.Forms.DockStyle.Fill
Me.txtOTHZay.Location = New System.Drawing.Point(416, 29)
Me.txtOTHZay.Name = "txtOTHZay"
Me.txtOTHZay.Size = New System.Drawing.Size(228, 20)
Me.txtOTHZay.TabIndex = 17
'
'Label61
'
Me.Label61.Anchor = System.Windows.Forms.AnchorStyles.Left
Me.Label61.AutoSize = true
Me.Label61.Location = New System.Drawing.Point(336, 58)
Me.Label61.Name = "Label61"
Me.Label61.Size = New System.Drawing.Size(66, 13)
Me.Label61.TabIndex = 25
Me.Label61.Text = "Дата ввода"
'
'dtOTHSFdate
'
Me.dtOTHSFdate.Dock = System.Windows.Forms.DockStyle.Fill
Me.dtOTHSFdate.Location = New System.Drawing.Point(416, 3)
Me.dtOTHSFdate.Name = "dtOTHSFdate"
Me.dtOTHSFdate.Size = New System.Drawing.Size(228, 20)
Me.dtOTHSFdate.TabIndex = 16
Me.dtOTHSFdate.Value = New Date(2013, 10, 25, 0, 0, 0, 0)
'
'Label65
'
Me.Label65.Anchor = System.Windows.Forms.AnchorStyles.Left
Me.Label65.AutoSize = true
Me.Label65.Location = New System.Drawing.Point(3, 32)
Me.Label65.Name = "Label65"
Me.Label65.Size = New System.Drawing.Size(33, 13)
Me.Label65.TabIndex = 14
Me.Label65.Text = "Цена"
'
'txtOTHcash
'
Me.txtOTHcash.Dock = System.Windows.Forms.DockStyle.Fill
Me.txtOTHcash.Location = New System.Drawing.Point(103, 29)
Me.txtOTHcash.Maximum = New Decimal(New Integer() {1000000, 0, 0, 0})
Me.txtOTHcash.Name = "txtOTHcash"
Me.txtOTHcash.Size = New System.Drawing.Size(227, 20)
Me.txtOTHcash.TabIndex = 18
'
'Label62
'
Me.Label62.Anchor = System.Windows.Forms.AnchorStyles.Left
Me.Label62.AutoSize = true
Me.Label62.Location = New System.Drawing.Point(336, 32)
Me.Label62.Name = "Label62"
Me.Label62.Size = New System.Drawing.Size(44, 13)
Me.Label62.TabIndex = 24
Me.Label62.Text = "Заявка"
'
'Label64
'
Me.Label64.Anchor = System.Windows.Forms.AnchorStyles.Left
Me.Label64.AutoSize = true
Me.Label64.Location = New System.Drawing.Point(3, 58)
Me.Label64.Name = "Label64"
Me.Label64.Size = New System.Drawing.Size(41, 13)
Me.Label64.TabIndex = 15
Me.Label64.Text = "Сумма"
'
'txtOTHSfN
'
Me.txtOTHSfN.Dock = System.Windows.Forms.DockStyle.Fill
Me.txtOTHSfN.Location = New System.Drawing.Point(103, 3)
Me.txtOTHSfN.Name = "txtOTHSfN"
Me.txtOTHSfN.Size = New System.Drawing.Size(227, 20)
Me.txtOTHSfN.TabIndex = 13
'
'Label63
'
Me.Label63.Anchor = System.Windows.Forms.AnchorStyles.Left
Me.Label63.AutoSize = true
Me.Label63.Location = New System.Drawing.Point(336, 6)
Me.Label63.Name = "Label63"
Me.Label63.Size = New System.Drawing.Size(18, 13)
Me.Label63.TabIndex = 22
Me.Label63.Text = "от"
'
'chkOTHspis
'
Me.chkOTHspis.Anchor = System.Windows.Forms.AnchorStyles.Left
Me.chkOTHspis.AutoSize = true
Me.chkOTHspis.Location = New System.Drawing.Point(3, 82)
Me.chkOTHspis.Name = "chkOTHspis"
Me.chkOTHspis.Size = New System.Drawing.Size(69, 17)
Me.chkOTHspis.TabIndex = 20
Me.chkOTHspis.Text = "Списано"
Me.chkOTHspis.UseVisualStyleBackColor = true
'
'dtOTHSpisanie
'
Me.dtOTHSpisanie.Dock = System.Windows.Forms.DockStyle.Fill
Me.dtOTHSpisanie.Location = New System.Drawing.Point(103, 81)
Me.dtOTHSpisanie.Name = "dtOTHSpisanie"
Me.dtOTHSpisanie.Size = New System.Drawing.Size(227, 20)
Me.dtOTHSpisanie.TabIndex = 26
Me.dtOTHSpisanie.Value = New Date(2013, 7, 2, 0, 0, 0, 0)
Me.dtOTHSpisanie.Visible = false
'
'sSTAB1
'
Me.sSTAB1.Controls.Add(Me.TabPage6)
Me.sSTAB1.Controls.Add(Me.TabPage1)
Me.sSTAB1.Controls.Add(Me.TabPage3)
Me.sSTAB1.Controls.Add(Me.TabPage4)
Me.sSTAB1.Controls.Add(Me.TabPage5)
Me.sSTAB1.Controls.Add(Me.TabPage7)
Me.sSTAB1.Controls.Add(Me.TabPage8)
Me.sSTAB1.Dock = System.Windows.Forms.DockStyle.Fill
Me.sSTAB1.Location = New System.Drawing.Point(0, 0)
Me.sSTAB1.Multiline = true
Me.sSTAB1.Name = "sSTAB1"
Me.sSTAB1.SelectedIndex = 0
Me.sSTAB1.Size = New System.Drawing.Size(667, 646)
Me.sSTAB1.TabIndex = 8
Me.sSTAB1.Visible = false
'
'TabPage6
'
Me.TabPage6.Controls.Add(Me.TableLayoutPanel20)
Me.TabPage6.Location = New System.Drawing.Point(4, 22)
Me.TabPage6.Name = "TabPage6"
Me.TabPage6.Size = New System.Drawing.Size(659, 620)
Me.TabPage6.TabIndex = 5
Me.TabPage6.Text = "Информация"
Me.TabPage6.UseVisualStyleBackColor = true
'
'TableLayoutPanel20
'
Me.TableLayoutPanel20.ColumnCount = 4
Me.TableLayoutPanel20.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 85!))
Me.TableLayoutPanel20.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50!))
Me.TableLayoutPanel20.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 110!))
Me.TableLayoutPanel20.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50!))
Me.TableLayoutPanel20.Controls.Add(Me.gbMovement, 0, 6)
Me.TableLayoutPanel20.Controls.Add(Me.lblPseudonym, 2, 0)
Me.TableLayoutPanel20.Controls.Add(Me.txtSNAME, 1, 0)
Me.TableLayoutPanel20.Controls.Add(Me.lblNetName, 0, 0)
Me.TableLayoutPanel20.Controls.Add(Me.txtPSEUDONIM, 3, 0)
Me.TableLayoutPanel20.Controls.Add(Me.lblBranch, 0, 1)
Me.TableLayoutPanel20.Controls.Add(Me.cmbBranch, 1, 1)
Me.TableLayoutPanel20.Controls.Add(Me.lblResponsible, 2, 1)
Me.TableLayoutPanel20.Controls.Add(Me.cmbResponsible, 3, 1)
Me.TableLayoutPanel20.Controls.Add(Me.lblDepartment, 0, 2)
Me.TableLayoutPanel20.Controls.Add(Me.cmbDepartment, 1, 2)
Me.TableLayoutPanel20.Controls.Add(Me.lblPhone, 2, 2)
Me.TableLayoutPanel20.Controls.Add(Me.txtPHONE, 3, 2)
Me.TableLayoutPanel20.Controls.Add(Me.lblOffice, 0, 3)
Me.TableLayoutPanel20.Controls.Add(Me.cmbOffice, 1, 3)
Me.TableLayoutPanel20.Controls.Add(Me.lblAppointment, 2, 3)
Me.TableLayoutPanel20.Controls.Add(Me.cmbAppointment, 3, 3)
Me.TableLayoutPanel20.Controls.Add(Me.gbInNumber, 0, 4)
Me.TableLayoutPanel20.Controls.Add(Me.Label84, 0, 5)
Me.TableLayoutPanel20.Controls.Add(Me.lblsID, 1, 5)
Me.TableLayoutPanel20.Controls.Add(Me.Label88, 2, 5)
Me.TableLayoutPanel20.Controls.Add(Me.cmbPCLK, 3, 5)
Me.TableLayoutPanel20.Dock = System.Windows.Forms.DockStyle.Fill
Me.TableLayoutPanel20.Location = New System.Drawing.Point(0, 0)
Me.TableLayoutPanel20.Name = "TableLayoutPanel20"
Me.TableLayoutPanel20.RowCount = 7
Me.TableLayoutPanel20.RowStyles.Add(New System.Windows.Forms.RowStyle())
Me.TableLayoutPanel20.RowStyles.Add(New System.Windows.Forms.RowStyle())
Me.TableLayoutPanel20.RowStyles.Add(New System.Windows.Forms.RowStyle())
Me.TableLayoutPanel20.RowStyles.Add(New System.Windows.Forms.RowStyle())
Me.TableLayoutPanel20.RowStyles.Add(New System.Windows.Forms.RowStyle())
Me.TableLayoutPanel20.RowStyles.Add(New System.Windows.Forms.RowStyle())
Me.TableLayoutPanel20.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100!))
Me.TableLayoutPanel20.Size = New System.Drawing.Size(659, 620)
Me.TableLayoutPanel20.TabIndex = 45
'
'gbMovement
'
Me.gbMovement.AutoSize = true
Me.TableLayoutPanel20.SetColumnSpan(Me.gbMovement, 4)
Me.gbMovement.Controls.Add(Me.lvMovement)
Me.gbMovement.Dock = System.Windows.Forms.DockStyle.Fill
Me.gbMovement.Location = New System.Drawing.Point(3, 286)
Me.gbMovement.Name = "gbMovement"
Me.gbMovement.Size = New System.Drawing.Size(653, 331)
Me.gbMovement.TabIndex = 45
Me.gbMovement.TabStop = false
Me.gbMovement.Text = "Движение"
'
'lvMovement
'
Me.lvMovement.Dock = System.Windows.Forms.DockStyle.Fill
Me.lvMovement.FullRowSelect = true
Me.lvMovement.GridLines = true
Me.lvMovement.Location = New System.Drawing.Point(3, 16)
Me.lvMovement.MultiSelect = false
Me.lvMovement.Name = "lvMovement"
Me.lvMovement.Size = New System.Drawing.Size(647, 312)
Me.lvMovement.TabIndex = 0
Me.lvMovement.UseCompatibleStateImageBehavior = false
Me.lvMovement.View = System.Windows.Forms.View.Details
'
'lblPseudonym
'
Me.lblPseudonym.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
Me.lblPseudonym.AutoSize = true
Me.lblPseudonym.Location = New System.Drawing.Point(320, 6)
Me.lblPseudonym.Name = "lblPseudonym"
Me.lblPseudonym.Size = New System.Drawing.Size(104, 13)
Me.lblPseudonym.TabIndex = 26
Me.lblPseudonym.Text = "Псевдоним"
'
'txtSNAME
'
Me.txtSNAME.Dock = System.Windows.Forms.DockStyle.Fill
Me.txtSNAME.Location = New System.Drawing.Point(88, 3)
Me.txtSNAME.Name = "txtSNAME"
Me.txtSNAME.Size = New System.Drawing.Size(226, 20)
Me.txtSNAME.TabIndex = 24
'
'lblNetName
'
Me.lblNetName.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
Me.lblNetName.AutoSize = true
Me.lblNetName.Location = New System.Drawing.Point(3, 6)
Me.lblNetName.Name = "lblNetName"
Me.lblNetName.Size = New System.Drawing.Size(79, 13)
Me.lblNetName.TabIndex = 23
Me.lblNetName.Text = "Имя в сети"
'
'txtPSEUDONIM
'
Me.txtPSEUDONIM.Dock = System.Windows.Forms.DockStyle.Fill
Me.txtPSEUDONIM.Location = New System.Drawing.Point(430, 3)
Me.txtPSEUDONIM.Name = "txtPSEUDONIM"
Me.txtPSEUDONIM.Size = New System.Drawing.Size(226, 20)
Me.txtPSEUDONIM.TabIndex = 27
'
'lblBranch
'
Me.lblBranch.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
Me.lblBranch.AutoSize = true
Me.lblBranch.Location = New System.Drawing.Point(3, 33)
Me.lblBranch.Name = "lblBranch"
Me.lblBranch.Size = New System.Drawing.Size(79, 13)
Me.lblBranch.TabIndex = 30
Me.lblBranch.Text = "Филиал"
'
'cmbBranch
'
Me.cmbBranch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
Me.cmbBranch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
Me.cmbBranch.Dock = System.Windows.Forms.DockStyle.Fill
Me.cmbBranch.FormattingEnabled = true
Me.cmbBranch.Location = New System.Drawing.Point(88, 29)
Me.cmbBranch.Name = "cmbBranch"
Me.cmbBranch.Size = New System.Drawing.Size(226, 21)
Me.cmbBranch.TabIndex = 31
'
'lblResponsible
'
Me.lblResponsible.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
Me.lblResponsible.AutoSize = true
Me.lblResponsible.Location = New System.Drawing.Point(320, 33)
Me.lblResponsible.Name = "lblResponsible"
Me.lblResponsible.Size = New System.Drawing.Size(104, 13)
Me.lblResponsible.TabIndex = 34
Me.lblResponsible.Text = "Ответственный"
'
'cmbResponsible
'
Me.cmbResponsible.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
Me.cmbResponsible.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
Me.cmbResponsible.Dock = System.Windows.Forms.DockStyle.Fill
Me.cmbResponsible.FormattingEnabled = true
Me.cmbResponsible.Location = New System.Drawing.Point(430, 29)
Me.cmbResponsible.Name = "cmbResponsible"
Me.cmbResponsible.Size = New System.Drawing.Size(226, 21)
Me.cmbResponsible.TabIndex = 35
'
'lblDepartment
'
Me.lblDepartment.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
Me.lblDepartment.AutoSize = true
Me.lblDepartment.Location = New System.Drawing.Point(3, 60)
Me.lblDepartment.Name = "lblDepartment"
Me.lblDepartment.Size = New System.Drawing.Size(79, 13)
Me.lblDepartment.TabIndex = 36
Me.lblDepartment.Text = "Отдел"
'
'cmbDepartment
'
Me.cmbDepartment.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
Me.cmbDepartment.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
Me.cmbDepartment.Dock = System.Windows.Forms.DockStyle.Fill
Me.cmbDepartment.FormattingEnabled = true
Me.cmbDepartment.Location = New System.Drawing.Point(88, 56)
Me.cmbDepartment.Name = "cmbDepartment"
Me.cmbDepartment.Size = New System.Drawing.Size(226, 21)
Me.cmbDepartment.TabIndex = 37
'
'lblPhone
'
Me.lblPhone.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
Me.lblPhone.AutoSize = true
Me.lblPhone.Location = New System.Drawing.Point(320, 60)
Me.lblPhone.Name = "lblPhone"
Me.lblPhone.Size = New System.Drawing.Size(104, 13)
Me.lblPhone.TabIndex = 38
Me.lblPhone.Text = "Телефон"
'
'txtPHONE
'
Me.txtPHONE.Dock = System.Windows.Forms.DockStyle.Fill
Me.txtPHONE.Location = New System.Drawing.Point(430, 56)
Me.txtPHONE.Name = "txtPHONE"
Me.txtPHONE.Size = New System.Drawing.Size(226, 20)
Me.txtPHONE.TabIndex = 39
'
'lblOffice
'
Me.lblOffice.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
Me.lblOffice.AutoSize = true
Me.lblOffice.Location = New System.Drawing.Point(3, 87)
Me.lblOffice.Name = "lblOffice"
Me.lblOffice.Size = New System.Drawing.Size(79, 13)
Me.lblOffice.TabIndex = 40
Me.lblOffice.Text = "Кабинет"
'
'cmbOffice
'
Me.cmbOffice.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
Me.cmbOffice.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
Me.cmbOffice.Dock = System.Windows.Forms.DockStyle.Fill
Me.cmbOffice.FormattingEnabled = true
Me.cmbOffice.Location = New System.Drawing.Point(88, 83)
Me.cmbOffice.Name = "cmbOffice"
Me.cmbOffice.Size = New System.Drawing.Size(226, 21)
Me.cmbOffice.TabIndex = 41
'
'lblAppointment
'
Me.lblAppointment.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
Me.lblAppointment.AutoSize = true
Me.lblAppointment.Location = New System.Drawing.Point(320, 87)
Me.lblAppointment.Name = "lblAppointment"
Me.lblAppointment.Size = New System.Drawing.Size(104, 13)
Me.lblAppointment.TabIndex = 42
Me.lblAppointment.Text = "Назначение"
'
'cmbAppointment
'
Me.cmbAppointment.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
Me.cmbAppointment.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
Me.cmbAppointment.Dock = System.Windows.Forms.DockStyle.Fill
Me.cmbAppointment.FormattingEnabled = true
Me.cmbAppointment.Location = New System.Drawing.Point(430, 83)
Me.cmbAppointment.Name = "cmbAppointment"
Me.cmbAppointment.Size = New System.Drawing.Size(226, 21)
Me.cmbAppointment.TabIndex = 43
'
'gbInNumber
'
Me.gbInNumber.AutoSize = true
Me.TableLayoutPanel20.SetColumnSpan(Me.gbInNumber, 4)
Me.gbInNumber.Controls.Add(Me.TableLayoutPanel47)
Me.gbInNumber.Dock = System.Windows.Forms.DockStyle.Fill
Me.gbInNumber.Location = New System.Drawing.Point(3, 110)
Me.gbInNumber.Name = "gbInNumber"
Me.gbInNumber.Size = New System.Drawing.Size(653, 143)
Me.gbInNumber.TabIndex = 44
Me.gbInNumber.TabStop = false
Me.gbInNumber.Text = "Инвентарные номера"
'
'TableLayoutPanel47
'
Me.TableLayoutPanel47.AutoSize = true
Me.TableLayoutPanel47.ColumnCount = 2
Me.TableLayoutPanel47.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 215!))
Me.TableLayoutPanel47.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100!))
Me.TableLayoutPanel47.Controls.Add(Me.IN_PRN, 1, 3)
Me.TableLayoutPanel47.Controls.Add(Me.Label16, 0, 0)
Me.TableLayoutPanel47.Controls.Add(Me.IN_IBP, 1, 2)
Me.TableLayoutPanel47.Controls.Add(Me.Label19, 0, 3)
Me.TableLayoutPanel47.Controls.Add(Me.txtMSN, 1, 1)
Me.TableLayoutPanel47.Controls.Add(Me.Label17, 0, 1)
Me.TableLayoutPanel47.Controls.Add(Me.txtSBSN, 1, 0)
Me.TableLayoutPanel47.Controls.Add(Me.Label18, 0, 2)
Me.TableLayoutPanel47.Controls.Add(Me.Label89, 0, 4)
Me.TableLayoutPanel47.Controls.Add(Me.lblNumberNET, 1, 4)
Me.TableLayoutPanel47.Dock = System.Windows.Forms.DockStyle.Fill
Me.TableLayoutPanel47.Location = New System.Drawing.Point(3, 16)
Me.TableLayoutPanel47.Name = "TableLayoutPanel47"
Me.TableLayoutPanel47.RowCount = 5
Me.TableLayoutPanel47.RowStyles.Add(New System.Windows.Forms.RowStyle())
Me.TableLayoutPanel47.RowStyles.Add(New System.Windows.Forms.RowStyle())
Me.TableLayoutPanel47.RowStyles.Add(New System.Windows.Forms.RowStyle())
Me.TableLayoutPanel47.RowStyles.Add(New System.Windows.Forms.RowStyle())
Me.TableLayoutPanel47.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20!))
Me.TableLayoutPanel47.Size = New System.Drawing.Size(647, 124)
Me.TableLayoutPanel47.TabIndex = 3
'
'IN_PRN
'
Me.IN_PRN.Dock = System.Windows.Forms.DockStyle.Fill
Me.IN_PRN.Location = New System.Drawing.Point(218, 81)
Me.IN_PRN.Name = "IN_PRN"
Me.IN_PRN.Size = New System.Drawing.Size(426, 20)
Me.IN_PRN.TabIndex = 14
'
'Label16
'
Me.Label16.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
Me.Label16.AutoSize = true
Me.Label16.Location = New System.Drawing.Point(3, 6)
Me.Label16.Name = "Label16"
Me.Label16.Size = New System.Drawing.Size(209, 13)
Me.Label16.TabIndex = 15
Me.Label16.Text = "Инвентарный номер системного блока"
'
'IN_IBP
'
Me.IN_IBP.Dock = System.Windows.Forms.DockStyle.Fill
Me.IN_IBP.Location = New System.Drawing.Point(218, 55)
Me.IN_IBP.Name = "IN_IBP"
Me.IN_IBP.Size = New System.Drawing.Size(426, 20)
Me.IN_IBP.TabIndex = 13
'
'Label19
'
Me.Label19.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
Me.Label19.AutoSize = true
Me.Label19.Location = New System.Drawing.Point(3, 84)
Me.Label19.Name = "Label19"
Me.Label19.Size = New System.Drawing.Size(209, 13)
Me.Label19.TabIndex = 18
Me.Label19.Text = "Инвентарный номер принтера"
'
'txtMSN
'
Me.txtMSN.Dock = System.Windows.Forms.DockStyle.Fill
Me.txtMSN.Location = New System.Drawing.Point(218, 29)
Me.txtMSN.Name = "txtMSN"
Me.txtMSN.Size = New System.Drawing.Size(426, 20)
Me.txtMSN.TabIndex = 12
'
'Label17
'
Me.Label17.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
Me.Label17.AutoSize = true
Me.Label17.Location = New System.Drawing.Point(3, 32)
Me.Label17.Name = "Label17"
Me.Label17.Size = New System.Drawing.Size(209, 13)
Me.Label17.TabIndex = 16
Me.Label17.Text = "Инвентарный номер монитора"
'
'txtSBSN
'
Me.txtSBSN.Dock = System.Windows.Forms.DockStyle.Fill
Me.txtSBSN.Location = New System.Drawing.Point(218, 3)
Me.txtSBSN.Name = "txtSBSN"
Me.txtSBSN.Size = New System.Drawing.Size(426, 20)
Me.txtSBSN.TabIndex = 11
'
'Label18
'
Me.Label18.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
Me.Label18.AutoSize = true
Me.Label18.Location = New System.Drawing.Point(3, 58)
Me.Label18.Name = "Label18"
Me.Label18.Size = New System.Drawing.Size(209, 13)
Me.Label18.TabIndex = 17
Me.Label18.Text = "Инвентарный номер ИБП"
'
'Label89
'
Me.Label89.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
Me.Label89.AutoSize = true
Me.Label89.Location = New System.Drawing.Point(3, 107)
Me.Label89.Name = "Label89"
Me.Label89.Size = New System.Drawing.Size(209, 13)
Me.Label89.TabIndex = 19
Me.Label89.Text = "Номер розетки:"
'
'lblNumberNET
'
Me.lblNumberNET.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
Me.lblNumberNET.AutoSize = true
Me.lblNumberNET.Location = New System.Drawing.Point(218, 107)
Me.lblNumberNET.Name = "lblNumberNET"
Me.lblNumberNET.Size = New System.Drawing.Size(426, 13)
Me.lblNumberNET.TabIndex = 20
Me.lblNumberNET.Text = "#"
'
'Label84
'
Me.Label84.Anchor = System.Windows.Forms.AnchorStyles.Left
Me.Label84.AutoSize = true
Me.Label84.Location = New System.Drawing.Point(3, 263)
Me.Label84.Name = "Label84"
Me.Label84.Size = New System.Drawing.Size(54, 13)
Me.Label84.TabIndex = 46
Me.Label84.Text = "№ в базе"
'
'lblsID
'
Me.lblsID.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
Me.lblsID.AutoSize = true
Me.lblsID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
Me.lblsID.Location = New System.Drawing.Point(88, 261)
Me.lblsID.Name = "lblsID"
Me.lblsID.Size = New System.Drawing.Size(226, 16)
Me.lblsID.TabIndex = 47
'
'Label88
'
Me.Label88.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
Me.Label88.AutoSize = true
Me.Label88.Location = New System.Drawing.Point(320, 263)
Me.Label88.Name = "Label88"
Me.Label88.Size = New System.Drawing.Size(104, 13)
Me.Label88.TabIndex = 48
Me.Label88.Text = "В контейнере"
Me.Label88.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
Me.Label88.Visible = false
'
'cmbPCLK
'
Me.cmbPCLK.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
Me.cmbPCLK.FormattingEnabled = true
Me.cmbPCLK.Location = New System.Drawing.Point(430, 259)
Me.cmbPCLK.Name = "cmbPCLK"
Me.cmbPCLK.Size = New System.Drawing.Size(226, 21)
Me.cmbPCLK.TabIndex = 49
Me.cmbPCLK.Visible = false
'
'TabPage1
'
Me.TabPage1.AutoScroll = true
Me.TabPage1.BackColor = System.Drawing.Color.Transparent
Me.TabPage1.Controls.Add(Me.TableLayoutPanel63)
Me.TabPage1.Location = New System.Drawing.Point(4, 22)
Me.TabPage1.Name = "TabPage1"
Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
Me.TabPage1.Size = New System.Drawing.Size(659, 620)
Me.TabPage1.TabIndex = 0
Me.TabPage1.Text = "Системный блок"
Me.TabPage1.UseVisualStyleBackColor = true
'
'TableLayoutPanel63
'
Me.TableLayoutPanel63.AutoScroll = true
Me.TableLayoutPanel63.ColumnCount = 1
Me.TableLayoutPanel63.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100!))
Me.TableLayoutPanel63.Controls.Add(Me.gbcpu, 0, 0)
Me.TableLayoutPanel63.Controls.Add(Me.gbSOUND, 0, 5)
Me.TableLayoutPanel63.Controls.Add(Me.gbMB, 0, 1)
Me.TableLayoutPanel63.Controls.Add(Me.gbSVGA, 0, 4)
Me.TableLayoutPanel63.Controls.Add(Me.gbRAM, 0, 2)
Me.TableLayoutPanel63.Controls.Add(Me.gbHDD, 0, 3)
Me.TableLayoutPanel63.Controls.Add(Me.gbOptical, 0, 6)
Me.TableLayoutPanel63.Controls.Add(Me.gbNetwork, 0, 7)
Me.TableLayoutPanel63.Controls.Add(Me.gbFDD, 0, 8)
Me.TableLayoutPanel63.Controls.Add(Me.gbCreader, 0, 9)
Me.TableLayoutPanel63.Controls.Add(Me.gbModem, 0, 10)
Me.TableLayoutPanel63.Controls.Add(Me.gbCase, 0, 11)
Me.TableLayoutPanel63.Controls.Add(Me.gbBP, 0, 12)
Me.TableLayoutPanel63.Controls.Add(Me.gbUSB, 0, 13)
Me.TableLayoutPanel63.Controls.Add(Me.gbPCI, 0, 14)
Me.TableLayoutPanel63.Controls.Add(Me.gbSBP, 0, 15)
Me.TableLayoutPanel63.Dock = System.Windows.Forms.DockStyle.Fill
Me.TableLayoutPanel63.Location = New System.Drawing.Point(3, 3)
Me.TableLayoutPanel63.Name = "TableLayoutPanel63"
Me.TableLayoutPanel63.RowCount = 18
Me.TableLayoutPanel63.RowStyles.Add(New System.Windows.Forms.RowStyle())
Me.TableLayoutPanel63.RowStyles.Add(New System.Windows.Forms.RowStyle())
Me.TableLayoutPanel63.RowStyles.Add(New System.Windows.Forms.RowStyle())
Me.TableLayoutPanel63.RowStyles.Add(New System.Windows.Forms.RowStyle())
Me.TableLayoutPanel63.RowStyles.Add(New System.Windows.Forms.RowStyle())
Me.TableLayoutPanel63.RowStyles.Add(New System.Windows.Forms.RowStyle())
Me.TableLayoutPanel63.RowStyles.Add(New System.Windows.Forms.RowStyle())
Me.TableLayoutPanel63.RowStyles.Add(New System.Windows.Forms.RowStyle())
Me.TableLayoutPanel63.RowStyles.Add(New System.Windows.Forms.RowStyle())
Me.TableLayoutPanel63.RowStyles.Add(New System.Windows.Forms.RowStyle())
Me.TableLayoutPanel63.RowStyles.Add(New System.Windows.Forms.RowStyle())
Me.TableLayoutPanel63.RowStyles.Add(New System.Windows.Forms.RowStyle())
Me.TableLayoutPanel63.RowStyles.Add(New System.Windows.Forms.RowStyle())
Me.TableLayoutPanel63.RowStyles.Add(New System.Windows.Forms.RowStyle())
Me.TableLayoutPanel63.RowStyles.Add(New System.Windows.Forms.RowStyle())
Me.TableLayoutPanel63.RowStyles.Add(New System.Windows.Forms.RowStyle())
Me.TableLayoutPanel63.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20!))
Me.TableLayoutPanel63.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20!))
Me.TableLayoutPanel63.Size = New System.Drawing.Size(653, 614)
Me.TableLayoutPanel63.TabIndex = 6
'
'gbcpu
'
Me.gbcpu.AutoSize = true
Me.gbcpu.Controls.Add(Me.TableLayoutPanel24)
Me.gbcpu.Cursor = System.Windows.Forms.Cursors.Hand
Me.gbcpu.Dock = System.Windows.Forms.DockStyle.Fill
Me.gbcpu.Location = New System.Drawing.Point(3, 3)
Me.gbcpu.Name = "gbcpu"
Me.gbcpu.Size = New System.Drawing.Size(647, 127)
Me.gbcpu.TabIndex = 0
Me.gbcpu.TabStop = false
Me.gbcpu.Text = "Процессор"
'
'TableLayoutPanel24
'
Me.TableLayoutPanel24.AutoSize = true
Me.TableLayoutPanel24.ColumnCount = 5
Me.TableLayoutPanel24.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70!))
Me.TableLayoutPanel24.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
Me.TableLayoutPanel24.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
Me.TableLayoutPanel24.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30!))
Me.TableLayoutPanel24.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 51!))
Me.TableLayoutPanel24.Controls.Add(Me.PROizV4, 3, 3)
Me.TableLayoutPanel24.Controls.Add(Me.PROizV2, 3, 1)
Me.TableLayoutPanel24.Controls.Add(Me.PROizV3, 3, 2)
Me.TableLayoutPanel24.Controls.Add(Me.cmbCPU1, 0, 0)
Me.TableLayoutPanel24.Controls.Add(Me.txtSoc4, 2, 3)
Me.TableLayoutPanel24.Controls.Add(Me.cmbCPU2, 0, 1)
Me.TableLayoutPanel24.Controls.Add(Me.PROizV1, 3, 0)
Me.TableLayoutPanel24.Controls.Add(Me.cmbCPU3, 0, 2)
Me.TableLayoutPanel24.Controls.Add(Me.txtSoc3, 2, 2)
Me.TableLayoutPanel24.Controls.Add(Me.txtMHZ4, 1, 3)
Me.TableLayoutPanel24.Controls.Add(Me.cmbCPU4, 0, 3)
Me.TableLayoutPanel24.Controls.Add(Me.txtSoc2, 2, 1)
Me.TableLayoutPanel24.Controls.Add(Me.txtMHZ1, 1, 0)
Me.TableLayoutPanel24.Controls.Add(Me.txtSoc1, 2, 0)
Me.TableLayoutPanel24.Controls.Add(Me.txtMHZ2, 1, 1)
Me.TableLayoutPanel24.Controls.Add(Me.txtMHZ3, 1, 2)
Me.TableLayoutPanel24.Controls.Add(Me.ToolStrip8, 4, 0)
Me.TableLayoutPanel24.Dock = System.Windows.Forms.DockStyle.Fill
Me.TableLayoutPanel24.Location = New System.Drawing.Point(3, 16)
Me.TableLayoutPanel24.Name = "TableLayoutPanel24"
Me.TableLayoutPanel24.RowCount = 4
Me.TableLayoutPanel24.RowStyles.Add(New System.Windows.Forms.RowStyle())
Me.TableLayoutPanel24.RowStyles.Add(New System.Windows.Forms.RowStyle())
Me.TableLayoutPanel24.RowStyles.Add(New System.Windows.Forms.RowStyle())
Me.TableLayoutPanel24.RowStyles.Add(New System.Windows.Forms.RowStyle())
Me.TableLayoutPanel24.Size = New System.Drawing.Size(641, 108)
Me.TableLayoutPanel24.TabIndex = 1
'
'PROizV4
'
Me.PROizV4.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
Me.PROizV4.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
Me.TableLayoutPanel24.SetColumnSpan(Me.PROizV4, 2)
Me.PROizV4.Cursor = System.Windows.Forms.Cursors.WaitCursor
Me.PROizV4.Dock = System.Windows.Forms.DockStyle.Fill
Me.PROizV4.FormattingEnabled = true
Me.PROizV4.Location = New System.Drawing.Point(476, 84)
Me.PROizV4.Name = "PROizV4"
Me.PROizV4.Size = New System.Drawing.Size(162, 21)
Me.PROizV4.TabIndex = 16
'
'PROizV2
'
Me.PROizV2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
Me.PROizV2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
Me.PROizV2.BackColor = System.Drawing.SystemColors.Window
Me.TableLayoutPanel24.SetColumnSpan(Me.PROizV2, 2)
Me.PROizV2.Cursor = System.Windows.Forms.Cursors.WaitCursor
Me.PROizV2.Dock = System.Windows.Forms.DockStyle.Fill
Me.PROizV2.ForeColor = System.Drawing.SystemColors.WindowText
Me.PROizV2.Location = New System.Drawing.Point(476, 30)
Me.PROizV2.Name = "PROizV2"
Me.PROizV2.Size = New System.Drawing.Size(162, 21)
Me.PROizV2.Sorted = true
Me.PROizV2.TabIndex = 8
'
'PROizV3
'
Me.PROizV3.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
Me.PROizV3.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
Me.TableLayoutPanel24.SetColumnSpan(Me.PROizV3, 2)
Me.PROizV3.Cursor = System.Windows.Forms.Cursors.WaitCursor
Me.PROizV3.Dock = System.Windows.Forms.DockStyle.Fill
Me.PROizV3.FormattingEnabled = true
Me.PROizV3.Location = New System.Drawing.Point(476, 57)
Me.PROizV3.Name = "PROizV3"
Me.PROizV3.Size = New System.Drawing.Size(162, 21)
Me.PROizV3.TabIndex = 12
'
'cmbCPU1
'
Me.cmbCPU1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
Me.cmbCPU1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
Me.cmbCPU1.Cursor = System.Windows.Forms.Cursors.WaitCursor
Me.cmbCPU1.Dock = System.Windows.Forms.DockStyle.Fill
Me.cmbCPU1.FormattingEnabled = true
Me.cmbCPU1.Location = New System.Drawing.Point(3, 3)
Me.cmbCPU1.Name = "cmbCPU1"
Me.cmbCPU1.Size = New System.Drawing.Size(267, 21)
Me.cmbCPU1.TabIndex = 1
'
'txtSoc4
'
Me.txtSoc4.Location = New System.Drawing.Point(376, 84)
Me.txtSoc4.Name = "txtSoc4"
Me.txtSoc4.Size = New System.Drawing.Size(94, 20)
Me.txtSoc4.TabIndex = 15
Me.txtSoc4.Tag = ""
'
'cmbCPU2
'
Me.cmbCPU2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
Me.cmbCPU2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
Me.cmbCPU2.Cursor = System.Windows.Forms.Cursors.WaitCursor
Me.cmbCPU2.Dock = System.Windows.Forms.DockStyle.Fill
Me.cmbCPU2.FormattingEnabled = true
Me.cmbCPU2.Location = New System.Drawing.Point(3, 30)
Me.cmbCPU2.Name = "cmbCPU2"
Me.cmbCPU2.Size = New System.Drawing.Size(267, 21)
Me.cmbCPU2.TabIndex = 5
'
'PROizV1
'
Me.PROizV1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
Me.PROizV1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
Me.PROizV1.Cursor = System.Windows.Forms.Cursors.WaitCursor
Me.PROizV1.Dock = System.Windows.Forms.DockStyle.Fill
Me.PROizV1.FormattingEnabled = true
Me.PROizV1.Location = New System.Drawing.Point(476, 3)
Me.PROizV1.Name = "PROizV1"
Me.PROizV1.Size = New System.Drawing.Size(111, 21)
Me.PROizV1.TabIndex = 4
'
'cmbCPU3
'
Me.cmbCPU3.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
Me.cmbCPU3.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
Me.cmbCPU3.Cursor = System.Windows.Forms.Cursors.WaitCursor
Me.cmbCPU3.Dock = System.Windows.Forms.DockStyle.Fill
Me.cmbCPU3.FormattingEnabled = true
Me.cmbCPU3.Location = New System.Drawing.Point(3, 57)
Me.cmbCPU3.Name = "cmbCPU3"
Me.cmbCPU3.Size = New System.Drawing.Size(267, 21)
Me.cmbCPU3.TabIndex = 9
'
'txtSoc3
'
Me.txtSoc3.Location = New System.Drawing.Point(376, 57)
Me.txtSoc3.Name = "txtSoc3"
Me.txtSoc3.Size = New System.Drawing.Size(94, 20)
Me.txtSoc3.TabIndex = 11
Me.txtSoc3.Tag = ""
'
'txtMHZ4
'
Me.txtMHZ4.Location = New System.Drawing.Point(276, 84)
Me.txtMHZ4.Name = "txtMHZ4"
Me.txtMHZ4.Size = New System.Drawing.Size(94, 20)
Me.txtMHZ4.TabIndex = 14
Me.txtMHZ4.Tag = ""
'
'cmbCPU4
'
Me.cmbCPU4.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
Me.cmbCPU4.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
Me.cmbCPU4.Cursor = System.Windows.Forms.Cursors.WaitCursor
Me.cmbCPU4.Dock = System.Windows.Forms.DockStyle.Fill
Me.cmbCPU4.FormattingEnabled = true
Me.cmbCPU4.Location = New System.Drawing.Point(3, 84)
Me.cmbCPU4.Name = "cmbCPU4"
Me.cmbCPU4.Size = New System.Drawing.Size(267, 21)
Me.cmbCPU4.TabIndex = 13
'
'txtSoc2
'
Me.txtSoc2.Location = New System.Drawing.Point(376, 30)
Me.txtSoc2.Name = "txtSoc2"
Me.txtSoc2.Size = New System.Drawing.Size(94, 20)
Me.txtSoc2.TabIndex = 7
Me.txtSoc2.Tag = ""
'
'txtMHZ1
'
Me.txtMHZ1.Location = New System.Drawing.Point(276, 3)
Me.txtMHZ1.Name = "txtMHZ1"
Me.txtMHZ1.Size = New System.Drawing.Size(94, 20)
Me.txtMHZ1.TabIndex = 2
Me.txtMHZ1.Tag = ""
'
'txtSoc1
'
Me.txtSoc1.Location = New System.Drawing.Point(376, 3)
Me.txtSoc1.Name = "txtSoc1"
Me.txtSoc1.Size = New System.Drawing.Size(94, 20)
Me.txtSoc1.TabIndex = 3
Me.txtSoc1.Tag = ""
'
'txtMHZ2
'
Me.txtMHZ2.Location = New System.Drawing.Point(276, 30)
Me.txtMHZ2.Name = "txtMHZ2"
Me.txtMHZ2.Size = New System.Drawing.Size(94, 20)
Me.txtMHZ2.TabIndex = 6
Me.txtMHZ2.Tag = ""
'
'txtMHZ3
'
Me.txtMHZ3.Location = New System.Drawing.Point(276, 57)
Me.txtMHZ3.Name = "txtMHZ3"
Me.txtMHZ3.Size = New System.Drawing.Size(94, 20)
Me.txtMHZ3.TabIndex = 10
Me.txtMHZ3.Tag = ""
'
'ToolStrip8
'
Me.ToolStrip8.BackColor = System.Drawing.Color.Transparent
Me.ToolStrip8.Dock = System.Windows.Forms.DockStyle.None
Me.ToolStrip8.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
Me.ToolStrip8.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.bCPUPlus})
Me.ToolStrip8.Location = New System.Drawing.Point(590, 0)
Me.ToolStrip8.Name = "ToolStrip8"
Me.ToolStrip8.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
Me.ToolStrip8.Size = New System.Drawing.Size(26, 25)
Me.ToolStrip8.TabIndex = 17
Me.ToolStrip8.Text = "ToolStrip8"
'
'bCPUPlus
'
Me.bCPUPlus.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
Me.bCPUPlus.ImageTransparentColor = System.Drawing.Color.Magenta
Me.bCPUPlus.Name = "bCPUPlus"
Me.bCPUPlus.Size = New System.Drawing.Size(23, 22)
Me.bCPUPlus.Text = "+"
'
'gbSOUND
'
Me.gbSOUND.AutoSize = true
Me.gbSOUND.Controls.Add(Me.TableLayoutPanel28)
Me.gbSOUND.Cursor = System.Windows.Forms.Cursors.WaitCursor
Me.gbSOUND.Dock = System.Windows.Forms.DockStyle.Fill
Me.gbSOUND.Location = New System.Drawing.Point(3, 775)
Me.gbSOUND.Name = "gbSOUND"
Me.gbSOUND.Size = New System.Drawing.Size(647, 46)
Me.gbSOUND.TabIndex = 5
Me.gbSOUND.TabStop = false
Me.gbSOUND.Text = "Звуковая карта"
'
'TableLayoutPanel28
'
Me.TableLayoutPanel28.AutoSize = true
Me.TableLayoutPanel28.ColumnCount = 5
Me.TableLayoutPanel28.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70!))
Me.TableLayoutPanel28.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100!))
Me.TableLayoutPanel28.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100!))
Me.TableLayoutPanel28.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30!))
Me.TableLayoutPanel28.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 51!))
Me.TableLayoutPanel28.Controls.Add(Me.PROizV16, 3, 0)
Me.TableLayoutPanel28.Controls.Add(Me.txtSoundS, 2, 0)
Me.TableLayoutPanel28.Controls.Add(Me.cmbSound, 0, 0)
Me.TableLayoutPanel28.Controls.Add(Me.txtSoundB, 1, 0)
Me.TableLayoutPanel28.Dock = System.Windows.Forms.DockStyle.Fill
Me.TableLayoutPanel28.Location = New System.Drawing.Point(3, 16)
Me.TableLayoutPanel28.Name = "TableLayoutPanel28"
Me.TableLayoutPanel28.RowCount = 1
Me.TableLayoutPanel28.RowStyles.Add(New System.Windows.Forms.RowStyle())
Me.TableLayoutPanel28.Size = New System.Drawing.Size(641, 27)
Me.TableLayoutPanel28.TabIndex = 1
'
'PROizV16
'
Me.PROizV16.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
Me.PROizV16.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
Me.TableLayoutPanel28.SetColumnSpan(Me.PROizV16, 2)
Me.PROizV16.Cursor = System.Windows.Forms.Cursors.WaitCursor
Me.PROizV16.Dock = System.Windows.Forms.DockStyle.Fill
Me.PROizV16.FormattingEnabled = true
Me.PROizV16.Location = New System.Drawing.Point(476, 3)
Me.PROizV16.Name = "PROizV16"
Me.PROizV16.Size = New System.Drawing.Size(162, 21)
Me.PROizV16.TabIndex = 7
'
'txtSoundS
'
Me.txtSoundS.Location = New System.Drawing.Point(376, 3)
Me.txtSoundS.Name = "txtSoundS"
Me.txtSoundS.Size = New System.Drawing.Size(94, 20)
Me.txtSoundS.TabIndex = 6
'
'cmbSound
'
Me.cmbSound.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
Me.cmbSound.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
Me.cmbSound.Dock = System.Windows.Forms.DockStyle.Fill
Me.cmbSound.FormattingEnabled = true
Me.cmbSound.Location = New System.Drawing.Point(3, 3)
Me.cmbSound.Name = "cmbSound"
Me.cmbSound.Size = New System.Drawing.Size(267, 21)
Me.cmbSound.TabIndex = 4
'
'txtSoundB
'
Me.txtSoundB.Location = New System.Drawing.Point(276, 3)
Me.txtSoundB.Name = "txtSoundB"
Me.txtSoundB.Size = New System.Drawing.Size(94, 20)
Me.txtSoundB.TabIndex = 5
'
'gbMB
'
Me.gbMB.AutoSize = true
Me.gbMB.Controls.Add(Me.TableLayoutPanel29)
Me.gbMB.Cursor = System.Windows.Forms.Cursors.Hand
Me.gbMB.Dock = System.Windows.Forms.DockStyle.Fill
Me.gbMB.Location = New System.Drawing.Point(3, 136)
Me.gbMB.Name = "gbMB"
Me.gbMB.Size = New System.Drawing.Size(647, 72)
Me.gbMB.TabIndex = 1
Me.gbMB.TabStop = false
Me.gbMB.Text = "Материнская плата"
'
'TableLayoutPanel29
'
Me.TableLayoutPanel29.AutoSize = true
Me.TableLayoutPanel29.ColumnCount = 4
Me.TableLayoutPanel29.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 37!))
Me.TableLayoutPanel29.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 62.00466!))
Me.TableLayoutPanel29.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
Me.TableLayoutPanel29.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.99534!))
Me.TableLayoutPanel29.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20!))
Me.TableLayoutPanel29.Controls.Add(Me.lblMBsn, 0, 1)
Me.TableLayoutPanel29.Controls.Add(Me.txtSN_MB, 1, 1)
Me.TableLayoutPanel29.Controls.Add(Me.txtChip, 2, 0)
Me.TableLayoutPanel29.Controls.Add(Me.PROizV5, 3, 0)
Me.TableLayoutPanel29.Controls.Add(Me.cmbMB, 0, 0)
Me.TableLayoutPanel29.Dock = System.Windows.Forms.DockStyle.Fill
Me.TableLayoutPanel29.Location = New System.Drawing.Point(3, 16)
Me.TableLayoutPanel29.Name = "TableLayoutPanel29"
Me.TableLayoutPanel29.RowCount = 2
Me.TableLayoutPanel29.RowStyles.Add(New System.Windows.Forms.RowStyle())
Me.TableLayoutPanel29.RowStyles.Add(New System.Windows.Forms.RowStyle())
Me.TableLayoutPanel29.Size = New System.Drawing.Size(641, 53)
Me.TableLayoutPanel29.TabIndex = 1
'
'lblMBsn
'
Me.lblMBsn.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
Me.lblMBsn.AutoSize = true
Me.lblMBsn.Location = New System.Drawing.Point(3, 33)
Me.lblMBsn.Name = "lblMBsn"
Me.lblMBsn.Size = New System.Drawing.Size(31, 13)
Me.lblMBsn.TabIndex = 12
Me.lblMBsn.Text = "SN:"
'
'txtSN_MB
'
Me.TableLayoutPanel29.SetColumnSpan(Me.txtSN_MB, 3)
Me.txtSN_MB.Dock = System.Windows.Forms.DockStyle.Fill
Me.txtSN_MB.Location = New System.Drawing.Point(40, 30)
Me.txtSN_MB.Name = "txtSN_MB"
Me.txtSN_MB.Size = New System.Drawing.Size(598, 20)
Me.txtSN_MB.TabIndex = 11
'
'txtChip
'
Me.txtChip.Dock = System.Windows.Forms.DockStyle.Fill
Me.txtChip.Location = New System.Drawing.Point(289, 3)
Me.txtChip.Name = "txtChip"
Me.txtChip.Size = New System.Drawing.Size(195, 20)
Me.txtChip.TabIndex = 9
'
'PROizV5
'
Me.PROizV5.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
Me.PROizV5.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
Me.PROizV5.Cursor = System.Windows.Forms.Cursors.WaitCursor
Me.PROizV5.Dock = System.Windows.Forms.DockStyle.Fill
Me.PROizV5.FormattingEnabled = true
Me.PROizV5.Location = New System.Drawing.Point(490, 3)
Me.PROizV5.Name = "PROizV5"
Me.PROizV5.Size = New System.Drawing.Size(148, 21)
Me.PROizV5.TabIndex = 10
'
'cmbMB
'
Me.cmbMB.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
Me.cmbMB.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
Me.TableLayoutPanel29.SetColumnSpan(Me.cmbMB, 2)
Me.cmbMB.Dock = System.Windows.Forms.DockStyle.Fill
Me.cmbMB.FormattingEnabled = true
Me.cmbMB.Location = New System.Drawing.Point(3, 3)
Me.cmbMB.Name = "cmbMB"
Me.cmbMB.Size = New System.Drawing.Size(280, 21)
Me.cmbMB.TabIndex = 8
'
'gbSVGA
'
Me.gbSVGA.AutoSize = true
Me.gbSVGA.Controls.Add(Me.TableLayoutPanel27)
Me.gbSVGA.Cursor = System.Windows.Forms.Cursors.WaitCursor
Me.gbSVGA.Dock = System.Windows.Forms.DockStyle.Fill
Me.gbSVGA.Location = New System.Drawing.Point(3, 696)
Me.gbSVGA.Name = "gbSVGA"
Me.gbSVGA.Size = New System.Drawing.Size(647, 73)
Me.gbSVGA.TabIndex = 4
Me.gbSVGA.TabStop = false
Me.gbSVGA.Text = "Видеокарта"
'
'TableLayoutPanel27
'
Me.TableLayoutPanel27.AutoSize = true
Me.TableLayoutPanel27.ColumnCount = 5
Me.TableLayoutPanel27.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70!))
Me.TableLayoutPanel27.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100!))
Me.TableLayoutPanel27.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100!))
Me.TableLayoutPanel27.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30!))
Me.TableLayoutPanel27.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 51!))
Me.TableLayoutPanel27.Controls.Add(Me.PROizV15, 3, 1)
Me.TableLayoutPanel27.Controls.Add(Me.txtSVGAs2, 2, 1)
Me.TableLayoutPanel27.Controls.Add(Me.PROizV14, 3, 0)
Me.TableLayoutPanel27.Controls.Add(Me.cmbSVGA1, 0, 0)
Me.TableLayoutPanel27.Controls.Add(Me.cmbSVGA2, 0, 1)
Me.TableLayoutPanel27.Controls.Add(Me.txtSVGAs1, 2, 0)
Me.TableLayoutPanel27.Controls.Add(Me.txtSVGAr2, 1, 1)
Me.TableLayoutPanel27.Controls.Add(Me.txtSVGAr1, 1, 0)
Me.TableLayoutPanel27.Controls.Add(Me.ToolStrip11, 4, 0)
Me.TableLayoutPanel27.Dock = System.Windows.Forms.DockStyle.Fill
Me.TableLayoutPanel27.Location = New System.Drawing.Point(3, 16)
Me.TableLayoutPanel27.Name = "TableLayoutPanel27"
Me.TableLayoutPanel27.RowCount = 2
Me.TableLayoutPanel27.RowStyles.Add(New System.Windows.Forms.RowStyle())
Me.TableLayoutPanel27.RowStyles.Add(New System.Windows.Forms.RowStyle())
Me.TableLayoutPanel27.Size = New System.Drawing.Size(641, 54)
Me.TableLayoutPanel27.TabIndex = 1
'
'PROizV15
'
Me.PROizV15.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
Me.PROizV15.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
Me.TableLayoutPanel27.SetColumnSpan(Me.PROizV15, 2)
Me.PROizV15.Cursor = System.Windows.Forms.Cursors.WaitCursor
Me.PROizV15.Dock = System.Windows.Forms.DockStyle.Fill
Me.PROizV15.FormattingEnabled = true
Me.PROizV15.Location = New System.Drawing.Point(476, 30)
Me.PROizV15.Name = "PROizV15"
Me.PROizV15.Size = New System.Drawing.Size(162, 21)
Me.PROizV15.TabIndex = 15
'
'txtSVGAs2
'
Me.txtSVGAs2.Location = New System.Drawing.Point(376, 30)
Me.txtSVGAs2.Name = "txtSVGAs2"
Me.txtSVGAs2.Size = New System.Drawing.Size(94, 20)
Me.txtSVGAs2.TabIndex = 14
'
'PROizV14
'
Me.PROizV14.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
Me.PROizV14.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
Me.PROizV14.Cursor = System.Windows.Forms.Cursors.WaitCursor
Me.PROizV14.Dock = System.Windows.Forms.DockStyle.Fill
Me.PROizV14.FormattingEnabled = true
Me.PROizV14.Location = New System.Drawing.Point(476, 3)
Me.PROizV14.Name = "PROizV14"
Me.PROizV14.Size = New System.Drawing.Size(111, 21)
Me.PROizV14.TabIndex = 11
'
'cmbSVGA1
'
Me.cmbSVGA1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
Me.cmbSVGA1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
Me.cmbSVGA1.Dock = System.Windows.Forms.DockStyle.Fill
Me.cmbSVGA1.FormattingEnabled = true
Me.cmbSVGA1.Location = New System.Drawing.Point(3, 3)
Me.cmbSVGA1.Name = "cmbSVGA1"
Me.cmbSVGA1.Size = New System.Drawing.Size(267, 21)
Me.cmbSVGA1.TabIndex = 8
'
'cmbSVGA2
'
Me.cmbSVGA2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
Me.cmbSVGA2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
Me.cmbSVGA2.Dock = System.Windows.Forms.DockStyle.Fill
Me.cmbSVGA2.FormattingEnabled = true
Me.cmbSVGA2.Location = New System.Drawing.Point(3, 30)
Me.cmbSVGA2.Name = "cmbSVGA2"
Me.cmbSVGA2.Size = New System.Drawing.Size(267, 21)
Me.cmbSVGA2.TabIndex = 12
'
'txtSVGAs1
'
Me.txtSVGAs1.Location = New System.Drawing.Point(376, 3)
Me.txtSVGAs1.Name = "txtSVGAs1"
Me.txtSVGAs1.Size = New System.Drawing.Size(94, 20)
Me.txtSVGAs1.TabIndex = 10
'
'txtSVGAr2
'
Me.txtSVGAr2.Location = New System.Drawing.Point(276, 30)
Me.txtSVGAr2.Name = "txtSVGAr2"
Me.txtSVGAr2.Size = New System.Drawing.Size(94, 20)
Me.txtSVGAr2.TabIndex = 13
'
'txtSVGAr1
'
Me.txtSVGAr1.Location = New System.Drawing.Point(276, 3)
Me.txtSVGAr1.Name = "txtSVGAr1"
Me.txtSVGAr1.Size = New System.Drawing.Size(94, 20)
Me.txtSVGAr1.TabIndex = 9
'
'ToolStrip11
'
Me.ToolStrip11.BackColor = System.Drawing.Color.Transparent
Me.ToolStrip11.Dock = System.Windows.Forms.DockStyle.None
Me.ToolStrip11.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
Me.ToolStrip11.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.bSVGAPlus})
Me.ToolStrip11.Location = New System.Drawing.Point(590, 0)
Me.ToolStrip11.Name = "ToolStrip11"
Me.ToolStrip11.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
Me.ToolStrip11.Size = New System.Drawing.Size(26, 25)
Me.ToolStrip11.TabIndex = 16
Me.ToolStrip11.Text = "ToolStrip11"
'
'bSVGAPlus
'
Me.bSVGAPlus.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
Me.bSVGAPlus.Image = CType(resources.GetObject("bSVGAPlus.Image"),System.Drawing.Image)
Me.bSVGAPlus.ImageTransparentColor = System.Drawing.Color.Magenta
Me.bSVGAPlus.Name = "bSVGAPlus"
Me.bSVGAPlus.Size = New System.Drawing.Size(23, 22)
Me.bSVGAPlus.Text = "+"
'
'gbRAM
'
Me.gbRAM.AutoSize = true
Me.gbRAM.Controls.Add(Me.TableLayoutPanel25)
Me.gbRAM.Cursor = System.Windows.Forms.Cursors.Hand
Me.gbRAM.Dock = System.Windows.Forms.DockStyle.Fill
Me.gbRAM.Location = New System.Drawing.Point(3, 214)
Me.gbRAM.Name = "gbRAM"
Me.gbRAM.Size = New System.Drawing.Size(647, 235)
Me.gbRAM.TabIndex = 2
Me.gbRAM.TabStop = false
Me.gbRAM.Text = "Память"
'
'TableLayoutPanel25
'
Me.TableLayoutPanel25.AutoSize = true
Me.TableLayoutPanel25.ColumnCount = 5
Me.TableLayoutPanel25.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70!))
Me.TableLayoutPanel25.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 102!))
Me.TableLayoutPanel25.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 98!))
Me.TableLayoutPanel25.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30!))
Me.TableLayoutPanel25.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 51!))
Me.TableLayoutPanel25.Controls.Add(Me.PROizV9, 3, 3)
Me.TableLayoutPanel25.Controls.Add(Me.txtRamSN4, 2, 3)
Me.TableLayoutPanel25.Controls.Add(Me.PROizV8, 3, 2)
Me.TableLayoutPanel25.Controls.Add(Me.cmbRAM1, 0, 0)
Me.TableLayoutPanel25.Controls.Add(Me.PROizV7, 3, 1)
Me.TableLayoutPanel25.Controls.Add(Me.cmbRAM2, 0, 1)
Me.TableLayoutPanel25.Controls.Add(Me.PROizV6, 3, 0)
Me.TableLayoutPanel25.Controls.Add(Me.txtRamSN3, 2, 2)
Me.TableLayoutPanel25.Controls.Add(Me.txtRamS4, 1, 3)
Me.TableLayoutPanel25.Controls.Add(Me.cmbRAM3, 0, 2)
Me.TableLayoutPanel25.Controls.Add(Me.txtRamSN2, 2, 1)
Me.TableLayoutPanel25.Controls.Add(Me.cmbRAM4, 0, 3)
Me.TableLayoutPanel25.Controls.Add(Me.txtRamS1, 1, 0)
Me.TableLayoutPanel25.Controls.Add(Me.txtRamSN1, 2, 0)
Me.TableLayoutPanel25.Controls.Add(Me.txtRamS3, 1, 2)
Me.TableLayoutPanel25.Controls.Add(Me.txtRamS2, 1, 1)
Me.TableLayoutPanel25.Controls.Add(Me.ToolStrip9, 4, 0)
Me.TableLayoutPanel25.Controls.Add(Me.cmbRAM5, 0, 4)
Me.TableLayoutPanel25.Controls.Add(Me.cmbRAM6, 0, 5)
Me.TableLayoutPanel25.Controls.Add(Me.txtRamS5, 1, 4)
Me.TableLayoutPanel25.Controls.Add(Me.txtRamS6, 1, 5)
Me.TableLayoutPanel25.Controls.Add(Me.txtRamSN5, 2, 4)
Me.TableLayoutPanel25.Controls.Add(Me.txtRamSN6, 2, 5)
Me.TableLayoutPanel25.Controls.Add(Me.PROizV44, 3, 4)
Me.TableLayoutPanel25.Controls.Add(Me.PROizV45, 3, 5)
Me.TableLayoutPanel25.Controls.Add(Me.cmbRAM7, 0, 6)
Me.TableLayoutPanel25.Controls.Add(Me.cmbRAM8, 0, 7)
Me.TableLayoutPanel25.Controls.Add(Me.txtRamS7, 1, 6)
Me.TableLayoutPanel25.Controls.Add(Me.txtRamS8, 1, 7)
Me.TableLayoutPanel25.Controls.Add(Me.txtRamSN7, 2, 6)
Me.TableLayoutPanel25.Controls.Add(Me.txtRamSN8, 2, 7)
Me.TableLayoutPanel25.Controls.Add(Me.PROizV46, 3, 6)
Me.TableLayoutPanel25.Controls.Add(Me.PROizV47, 3, 7)
Me.TableLayoutPanel25.Dock = System.Windows.Forms.DockStyle.Fill
Me.TableLayoutPanel25.Location = New System.Drawing.Point(3, 16)
Me.TableLayoutPanel25.Name = "TableLayoutPanel25"
Me.TableLayoutPanel25.RowCount = 8
Me.TableLayoutPanel25.RowStyles.Add(New System.Windows.Forms.RowStyle())
Me.TableLayoutPanel25.RowStyles.Add(New System.Windows.Forms.RowStyle())
Me.TableLayoutPanel25.RowStyles.Add(New System.Windows.Forms.RowStyle())
Me.TableLayoutPanel25.RowStyles.Add(New System.Windows.Forms.RowStyle())
Me.TableLayoutPanel25.RowStyles.Add(New System.Windows.Forms.RowStyle())
Me.TableLayoutPanel25.RowStyles.Add(New System.Windows.Forms.RowStyle())
Me.TableLayoutPanel25.RowStyles.Add(New System.Windows.Forms.RowStyle())
Me.TableLayoutPanel25.RowStyles.Add(New System.Windows.Forms.RowStyle())
Me.TableLayoutPanel25.Size = New System.Drawing.Size(641, 216)
Me.TableLayoutPanel25.TabIndex = 1
'
'PROizV9
'
Me.PROizV9.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
Me.PROizV9.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
Me.TableLayoutPanel25.SetColumnSpan(Me.PROizV9, 2)
Me.PROizV9.Cursor = System.Windows.Forms.Cursors.WaitCursor
Me.PROizV9.Dock = System.Windows.Forms.DockStyle.Fill
Me.PROizV9.FormattingEnabled = true
Me.PROizV9.Location = New System.Drawing.Point(476, 84)
Me.PROizV9.Name = "PROizV9"
Me.PROizV9.Size = New System.Drawing.Size(162, 21)
Me.PROizV9.TabIndex = 31
'
'txtRamSN4
'
Me.txtRamSN4.Location = New System.Drawing.Point(378, 84)
Me.txtRamSN4.Name = "txtRamSN4"
Me.txtRamSN4.Size = New System.Drawing.Size(92, 20)
Me.txtRamSN4.TabIndex = 30
'
'PROizV8
'
Me.PROizV8.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
Me.PROizV8.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
Me.TableLayoutPanel25.SetColumnSpan(Me.PROizV8, 2)
Me.PROizV8.Cursor = System.Windows.Forms.Cursors.WaitCursor
Me.PROizV8.Dock = System.Windows.Forms.DockStyle.Fill
Me.PROizV8.FormattingEnabled = true
Me.PROizV8.Location = New System.Drawing.Point(476, 57)
Me.PROizV8.Name = "PROizV8"
Me.PROizV8.Size = New System.Drawing.Size(162, 21)
Me.PROizV8.TabIndex = 27
'
'cmbRAM1
'
Me.cmbRAM1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
Me.cmbRAM1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
Me.cmbRAM1.Cursor = System.Windows.Forms.Cursors.WaitCursor
Me.cmbRAM1.Dock = System.Windows.Forms.DockStyle.Fill
Me.cmbRAM1.FormattingEnabled = true
Me.cmbRAM1.Location = New System.Drawing.Point(3, 3)
Me.cmbRAM1.Name = "cmbRAM1"
Me.cmbRAM1.Size = New System.Drawing.Size(267, 21)
Me.cmbRAM1.TabIndex = 16
'
'PROizV7
'
Me.PROizV7.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
Me.PROizV7.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
Me.TableLayoutPanel25.SetColumnSpan(Me.PROizV7, 2)
Me.PROizV7.Cursor = System.Windows.Forms.Cursors.WaitCursor
Me.PROizV7.Dock = System.Windows.Forms.DockStyle.Fill
Me.PROizV7.FormattingEnabled = true
Me.PROizV7.Location = New System.Drawing.Point(476, 30)
Me.PROizV7.Name = "PROizV7"
Me.PROizV7.Size = New System.Drawing.Size(162, 21)
Me.PROizV7.TabIndex = 23
'
'cmbRAM2
'
Me.cmbRAM2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
Me.cmbRAM2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
Me.cmbRAM2.Cursor = System.Windows.Forms.Cursors.WaitCursor
Me.cmbRAM2.Dock = System.Windows.Forms.DockStyle.Fill
Me.cmbRAM2.FormattingEnabled = true
Me.cmbRAM2.Location = New System.Drawing.Point(3, 30)
Me.cmbRAM2.Name = "cmbRAM2"
Me.cmbRAM2.Size = New System.Drawing.Size(267, 21)
Me.cmbRAM2.TabIndex = 20
'
'PROizV6
'
Me.PROizV6.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
Me.PROizV6.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
Me.PROizV6.Cursor = System.Windows.Forms.Cursors.WaitCursor
Me.PROizV6.Dock = System.Windows.Forms.DockStyle.Fill
Me.PROizV6.FormattingEnabled = true
Me.PROizV6.Location = New System.Drawing.Point(476, 3)
Me.PROizV6.Name = "PROizV6"
Me.PROizV6.Size = New System.Drawing.Size(111, 21)
Me.PROizV6.TabIndex = 19
'
'txtRamSN3
'
Me.txtRamSN3.Location = New System.Drawing.Point(378, 57)
Me.txtRamSN3.Name = "txtRamSN3"
Me.txtRamSN3.Size = New System.Drawing.Size(92, 20)
Me.txtRamSN3.TabIndex = 26
'
'txtRamS4
'
Me.txtRamS4.Location = New System.Drawing.Point(276, 84)
Me.txtRamS4.Name = "txtRamS4"
Me.txtRamS4.Size = New System.Drawing.Size(94, 20)
Me.txtRamS4.TabIndex = 29
'
'cmbRAM3
'
Me.cmbRAM3.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
Me.cmbRAM3.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
Me.cmbRAM3.Cursor = System.Windows.Forms.Cursors.WaitCursor
Me.cmbRAM3.Dock = System.Windows.Forms.DockStyle.Fill
Me.cmbRAM3.FormattingEnabled = true
Me.cmbRAM3.Location = New System.Drawing.Point(3, 57)
Me.cmbRAM3.Name = "cmbRAM3"
Me.cmbRAM3.Size = New System.Drawing.Size(267, 21)
Me.cmbRAM3.TabIndex = 24
'
'txtRamSN2
'
Me.txtRamSN2.Location = New System.Drawing.Point(378, 30)
Me.txtRamSN2.Name = "txtRamSN2"
Me.txtRamSN2.Size = New System.Drawing.Size(92, 20)
Me.txtRamSN2.TabIndex = 22
'
'cmbRAM4
'
Me.cmbRAM4.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
Me.cmbRAM4.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
Me.cmbRAM4.Cursor = System.Windows.Forms.Cursors.WaitCursor
Me.cmbRAM4.Dock = System.Windows.Forms.DockStyle.Fill
Me.cmbRAM4.FormattingEnabled = true
Me.cmbRAM4.Location = New System.Drawing.Point(3, 84)
Me.cmbRAM4.Name = "cmbRAM4"
Me.cmbRAM4.Size = New System.Drawing.Size(267, 21)
Me.cmbRAM4.TabIndex = 28
'
'txtRamS1
'
Me.txtRamS1.Location = New System.Drawing.Point(276, 3)
Me.txtRamS1.Name = "txtRamS1"
Me.txtRamS1.Size = New System.Drawing.Size(94, 20)
Me.txtRamS1.TabIndex = 17
'
'txtRamSN1
'
Me.txtRamSN1.Location = New System.Drawing.Point(378, 3)
Me.txtRamSN1.Name = "txtRamSN1"
Me.txtRamSN1.Size = New System.Drawing.Size(92, 20)
Me.txtRamSN1.TabIndex = 18
'
'txtRamS3
'
Me.txtRamS3.Location = New System.Drawing.Point(276, 57)
Me.txtRamS3.Name = "txtRamS3"
Me.txtRamS3.Size = New System.Drawing.Size(94, 20)
Me.txtRamS3.TabIndex = 25
'
'txtRamS2
'
Me.txtRamS2.Location = New System.Drawing.Point(276, 30)
Me.txtRamS2.Name = "txtRamS2"
Me.txtRamS2.Size = New System.Drawing.Size(94, 20)
Me.txtRamS2.TabIndex = 21
'
'ToolStrip9
'
Me.ToolStrip9.BackColor = System.Drawing.Color.Transparent
Me.ToolStrip9.Dock = System.Windows.Forms.DockStyle.None
Me.ToolStrip9.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
Me.ToolStrip9.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.bRamPlus})
Me.ToolStrip9.Location = New System.Drawing.Point(590, 0)
Me.ToolStrip9.Name = "ToolStrip9"
Me.ToolStrip9.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
Me.ToolStrip9.Size = New System.Drawing.Size(26, 25)
Me.ToolStrip9.TabIndex = 32
Me.ToolStrip9.Text = "ToolStrip9"
'
'bRamPlus
'
Me.bRamPlus.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
Me.bRamPlus.ImageTransparentColor = System.Drawing.Color.Magenta
Me.bRamPlus.Name = "bRamPlus"
Me.bRamPlus.Size = New System.Drawing.Size(23, 22)
Me.bRamPlus.Text = "+"
'
'cmbRAM5
'
Me.cmbRAM5.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
Me.cmbRAM5.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
Me.cmbRAM5.Dock = System.Windows.Forms.DockStyle.Fill
Me.cmbRAM5.FormattingEnabled = true
Me.cmbRAM5.Location = New System.Drawing.Point(3, 111)
Me.cmbRAM5.Name = "cmbRAM5"
Me.cmbRAM5.Size = New System.Drawing.Size(267, 21)
Me.cmbRAM5.TabIndex = 33
'
'cmbRAM6
'
Me.cmbRAM6.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
Me.cmbRAM6.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
Me.cmbRAM6.Dock = System.Windows.Forms.DockStyle.Fill
Me.cmbRAM6.FormattingEnabled = true
Me.cmbRAM6.Location = New System.Drawing.Point(3, 138)
Me.cmbRAM6.Name = "cmbRAM6"
Me.cmbRAM6.Size = New System.Drawing.Size(267, 21)
Me.cmbRAM6.TabIndex = 34
'
'txtRamS5
'
Me.txtRamS5.Dock = System.Windows.Forms.DockStyle.Fill
Me.txtRamS5.Location = New System.Drawing.Point(276, 111)
Me.txtRamS5.Name = "txtRamS5"
Me.txtRamS5.Size = New System.Drawing.Size(96, 20)
Me.txtRamS5.TabIndex = 35
'
'txtRamS6
'
Me.txtRamS6.Dock = System.Windows.Forms.DockStyle.Fill
Me.txtRamS6.Location = New System.Drawing.Point(276, 138)
Me.txtRamS6.Name = "txtRamS6"
Me.txtRamS6.Size = New System.Drawing.Size(96, 20)
Me.txtRamS6.TabIndex = 36
'
'txtRamSN5
'
Me.txtRamSN5.Dock = System.Windows.Forms.DockStyle.Fill
Me.txtRamSN5.Location = New System.Drawing.Point(378, 111)
Me.txtRamSN5.Name = "txtRamSN5"
Me.txtRamSN5.Size = New System.Drawing.Size(92, 20)
Me.txtRamSN5.TabIndex = 37
'
'txtRamSN6
'
Me.txtRamSN6.Dock = System.Windows.Forms.DockStyle.Fill
Me.txtRamSN6.Location = New System.Drawing.Point(378, 138)
Me.txtRamSN6.Name = "txtRamSN6"
Me.txtRamSN6.Size = New System.Drawing.Size(92, 20)
Me.txtRamSN6.TabIndex = 38
'
'PROizV44
'
Me.PROizV44.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
Me.PROizV44.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
Me.TableLayoutPanel25.SetColumnSpan(Me.PROizV44, 2)
Me.PROizV44.Dock = System.Windows.Forms.DockStyle.Fill
Me.PROizV44.FormattingEnabled = true
Me.PROizV44.Location = New System.Drawing.Point(476, 111)
Me.PROizV44.Name = "PROizV44"
Me.PROizV44.Size = New System.Drawing.Size(162, 21)
Me.PROizV44.TabIndex = 39
'
'PROizV45
'
Me.PROizV45.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
Me.PROizV45.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
Me.TableLayoutPanel25.SetColumnSpan(Me.PROizV45, 2)
Me.PROizV45.Dock = System.Windows.Forms.DockStyle.Fill
Me.PROizV45.FormattingEnabled = true
Me.PROizV45.Location = New System.Drawing.Point(476, 138)
Me.PROizV45.Name = "PROizV45"
Me.PROizV45.Size = New System.Drawing.Size(162, 21)
Me.PROizV45.TabIndex = 40
'
'cmbRAM7
'
Me.cmbRAM7.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
Me.cmbRAM7.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
Me.cmbRAM7.Dock = System.Windows.Forms.DockStyle.Fill
Me.cmbRAM7.FormattingEnabled = true
Me.cmbRAM7.Location = New System.Drawing.Point(3, 165)
Me.cmbRAM7.Name = "cmbRAM7"
Me.cmbRAM7.Size = New System.Drawing.Size(267, 21)
Me.cmbRAM7.TabIndex = 41
'
'cmbRAM8
'
Me.cmbRAM8.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
Me.cmbRAM8.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
Me.cmbRAM8.Dock = System.Windows.Forms.DockStyle.Fill
Me.cmbRAM8.FormattingEnabled = true
Me.cmbRAM8.Location = New System.Drawing.Point(3, 192)
Me.cmbRAM8.Name = "cmbRAM8"
Me.cmbRAM8.Size = New System.Drawing.Size(267, 21)
Me.cmbRAM8.TabIndex = 42
'
'txtRamS7
'
Me.txtRamS7.Dock = System.Windows.Forms.DockStyle.Fill
Me.txtRamS7.Location = New System.Drawing.Point(276, 165)
Me.txtRamS7.Name = "txtRamS7"
Me.txtRamS7.Size = New System.Drawing.Size(96, 20)
Me.txtRamS7.TabIndex = 43
'
'txtRamS8
'
Me.txtRamS8.Dock = System.Windows.Forms.DockStyle.Fill
Me.txtRamS8.Location = New System.Drawing.Point(276, 192)
Me.txtRamS8.Name = "txtRamS8"
Me.txtRamS8.Size = New System.Drawing.Size(96, 20)
Me.txtRamS8.TabIndex = 44
'
'txtRamSN7
'
Me.txtRamSN7.Dock = System.Windows.Forms.DockStyle.Fill
Me.txtRamSN7.Location = New System.Drawing.Point(378, 165)
Me.txtRamSN7.Name = "txtRamSN7"
Me.txtRamSN7.Size = New System.Drawing.Size(92, 20)
Me.txtRamSN7.TabIndex = 45
'
'txtRamSN8
'
Me.txtRamSN8.Dock = System.Windows.Forms.DockStyle.Fill
Me.txtRamSN8.Location = New System.Drawing.Point(378, 192)
Me.txtRamSN8.Name = "txtRamSN8"
Me.txtRamSN8.Size = New System.Drawing.Size(92, 20)
Me.txtRamSN8.TabIndex = 46
'
'PROizV46
'
Me.PROizV46.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
Me.PROizV46.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
Me.TableLayoutPanel25.SetColumnSpan(Me.PROizV46, 2)
Me.PROizV46.Dock = System.Windows.Forms.DockStyle.Fill
Me.PROizV46.FormattingEnabled = true
Me.PROizV46.Location = New System.Drawing.Point(476, 165)
Me.PROizV46.Name = "PROizV46"
Me.PROizV46.Size = New System.Drawing.Size(162, 21)
Me.PROizV46.TabIndex = 47
'
'PROizV47
'
Me.PROizV47.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
Me.PROizV47.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
Me.TableLayoutPanel25.SetColumnSpan(Me.PROizV47, 2)
Me.PROizV47.Dock = System.Windows.Forms.DockStyle.Fill
Me.PROizV47.FormattingEnabled = true
Me.PROizV47.Location = New System.Drawing.Point(476, 192)
Me.PROizV47.Name = "PROizV47"
Me.PROizV47.Size = New System.Drawing.Size(162, 21)
Me.PROizV47.TabIndex = 48
'
'gbHDD
'
Me.gbHDD.AutoSize = true
Me.gbHDD.Controls.Add(Me.TableLayoutPanel26)
Me.gbHDD.Cursor = System.Windows.Forms.Cursors.Hand
Me.gbHDD.Dock = System.Windows.Forms.DockStyle.Fill
Me.gbHDD.Location = New System.Drawing.Point(3, 455)
Me.gbHDD.Name = "gbHDD"
Me.gbHDD.Size = New System.Drawing.Size(647, 235)
Me.gbHDD.TabIndex = 3
Me.gbHDD.TabStop = false
Me.gbHDD.Text = "Жесткий диск"
'
'TableLayoutPanel26
'
Me.TableLayoutPanel26.AutoSize = true
Me.TableLayoutPanel26.ColumnCount = 5
Me.TableLayoutPanel26.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70!))
Me.TableLayoutPanel26.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100!))
Me.TableLayoutPanel26.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100!))
Me.TableLayoutPanel26.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30!))
Me.TableLayoutPanel26.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 51!))
Me.TableLayoutPanel26.Controls.Add(Me.PROizV13, 3, 3)
Me.TableLayoutPanel26.Controls.Add(Me.txtHDDsN4, 2, 3)
Me.TableLayoutPanel26.Controls.Add(Me.PROizV12, 3, 2)
Me.TableLayoutPanel26.Controls.Add(Me.cmbHDD1, 0, 0)
Me.TableLayoutPanel26.Controls.Add(Me.PROizV11, 3, 1)
Me.TableLayoutPanel26.Controls.Add(Me.cmbHDD2, 0, 1)
Me.TableLayoutPanel26.Controls.Add(Me.PROizV10, 3, 0)
Me.TableLayoutPanel26.Controls.Add(Me.txtHDDsN3, 2, 2)
Me.TableLayoutPanel26.Controls.Add(Me.txtHDDo4, 1, 3)
Me.TableLayoutPanel26.Controls.Add(Me.cmbHDD3, 0, 2)
Me.TableLayoutPanel26.Controls.Add(Me.cmbHDD4, 0, 3)
Me.TableLayoutPanel26.Controls.Add(Me.txtHDDo1, 1, 0)
Me.TableLayoutPanel26.Controls.Add(Me.txtHDDsN1, 2, 0)
Me.TableLayoutPanel26.Controls.Add(Me.txtHDDo3, 1, 2)
Me.TableLayoutPanel26.Controls.Add(Me.txtHDDo2, 1, 1)
Me.TableLayoutPanel26.Controls.Add(Me.txtHDDsN2, 2, 1)
Me.TableLayoutPanel26.Controls.Add(Me.ToolStrip10, 4, 0)
Me.TableLayoutPanel26.Controls.Add(Me.cmbHDD5, 0, 4)
Me.TableLayoutPanel26.Controls.Add(Me.cmbHDD6, 0, 5)
Me.TableLayoutPanel26.Controls.Add(Me.cmbHDD7, 0, 6)
Me.TableLayoutPanel26.Controls.Add(Me.cmbHDD8, 0, 7)
Me.TableLayoutPanel26.Controls.Add(Me.PROizV48, 3, 4)
Me.TableLayoutPanel26.Controls.Add(Me.PROizV49, 3, 5)
Me.TableLayoutPanel26.Controls.Add(Me.PROizV50, 3, 6)
Me.TableLayoutPanel26.Controls.Add(Me.PROizV51, 3, 7)
Me.TableLayoutPanel26.Controls.Add(Me.txtHDDo5, 1, 4)
Me.TableLayoutPanel26.Controls.Add(Me.txtHDDsN5, 2, 4)
Me.TableLayoutPanel26.Controls.Add(Me.txtHDDo6, 1, 5)
Me.TableLayoutPanel26.Controls.Add(Me.txtHDDsN6, 2, 5)
Me.TableLayoutPanel26.Controls.Add(Me.txtHDDo7, 1, 6)
Me.TableLayoutPanel26.Controls.Add(Me.txtHDDsN7, 2, 6)
Me.TableLayoutPanel26.Controls.Add(Me.txtHDDo8, 1, 7)
Me.TableLayoutPanel26.Controls.Add(Me.txtHDDsN8, 2, 7)
Me.TableLayoutPanel26.Dock = System.Windows.Forms.DockStyle.Fill
Me.TableLayoutPanel26.Location = New System.Drawing.Point(3, 16)
Me.TableLayoutPanel26.Name = "TableLayoutPanel26"
Me.TableLayoutPanel26.RowCount = 8
Me.TableLayoutPanel26.RowStyles.Add(New System.Windows.Forms.RowStyle())
Me.TableLayoutPanel26.RowStyles.Add(New System.Windows.Forms.RowStyle())
Me.TableLayoutPanel26.RowStyles.Add(New System.Windows.Forms.RowStyle())
Me.TableLayoutPanel26.RowStyles.Add(New System.Windows.Forms.RowStyle())
Me.TableLayoutPanel26.RowStyles.Add(New System.Windows.Forms.RowStyle())
Me.TableLayoutPanel26.RowStyles.Add(New System.Windows.Forms.RowStyle())
Me.TableLayoutPanel26.RowStyles.Add(New System.Windows.Forms.RowStyle())
Me.TableLayoutPanel26.RowStyles.Add(New System.Windows.Forms.RowStyle())
Me.TableLayoutPanel26.Size = New System.Drawing.Size(641, 216)
Me.TableLayoutPanel26.TabIndex = 1
'
'PROizV13
'
Me.PROizV13.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
Me.PROizV13.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
Me.TableLayoutPanel26.SetColumnSpan(Me.PROizV13, 2)
Me.PROizV13.Cursor = System.Windows.Forms.Cursors.WaitCursor
Me.PROizV13.Dock = System.Windows.Forms.DockStyle.Fill
Me.PROizV13.FormattingEnabled = true
Me.PROizV13.Location = New System.Drawing.Point(476, 84)
Me.PROizV13.Name = "PROizV13"
Me.PROizV13.Size = New System.Drawing.Size(162, 21)
Me.PROizV13.TabIndex = 31
'
'txtHDDsN4
'
Me.txtHDDsN4.Location = New System.Drawing.Point(376, 84)
Me.txtHDDsN4.Name = "txtHDDsN4"
Me.txtHDDsN4.Size = New System.Drawing.Size(94, 20)
Me.txtHDDsN4.TabIndex = 30
'
'PROizV12
'
Me.PROizV12.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
Me.PROizV12.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
Me.TableLayoutPanel26.SetColumnSpan(Me.PROizV12, 2)
Me.PROizV12.Cursor = System.Windows.Forms.Cursors.WaitCursor
Me.PROizV12.Dock = System.Windows.Forms.DockStyle.Fill
Me.PROizV12.FormattingEnabled = true
Me.PROizV12.Location = New System.Drawing.Point(476, 57)
Me.PROizV12.Name = "PROizV12"
Me.PROizV12.Size = New System.Drawing.Size(162, 21)
Me.PROizV12.TabIndex = 27
'
'cmbHDD1
'
Me.cmbHDD1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
Me.cmbHDD1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
Me.cmbHDD1.Cursor = System.Windows.Forms.Cursors.WaitCursor
Me.cmbHDD1.Dock = System.Windows.Forms.DockStyle.Fill
Me.cmbHDD1.FormattingEnabled = true
Me.cmbHDD1.Location = New System.Drawing.Point(3, 3)
Me.cmbHDD1.Name = "cmbHDD1"
Me.cmbHDD1.Size = New System.Drawing.Size(267, 21)
Me.cmbHDD1.TabIndex = 16
'
'PROizV11
'
Me.PROizV11.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
Me.PROizV11.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
Me.TableLayoutPanel26.SetColumnSpan(Me.PROizV11, 2)
Me.PROizV11.Cursor = System.Windows.Forms.Cursors.WaitCursor
Me.PROizV11.Dock = System.Windows.Forms.DockStyle.Fill
Me.PROizV11.FormattingEnabled = true
Me.PROizV11.Location = New System.Drawing.Point(476, 30)
Me.PROizV11.Name = "PROizV11"
Me.PROizV11.Size = New System.Drawing.Size(162, 21)
Me.PROizV11.TabIndex = 23
'
'cmbHDD2
'
Me.cmbHDD2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
Me.cmbHDD2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
Me.cmbHDD2.Cursor = System.Windows.Forms.Cursors.WaitCursor
Me.cmbHDD2.Dock = System.Windows.Forms.DockStyle.Fill
Me.cmbHDD2.FormattingEnabled = true
Me.cmbHDD2.Location = New System.Drawing.Point(3, 30)
Me.cmbHDD2.Name = "cmbHDD2"
Me.cmbHDD2.Size = New System.Drawing.Size(267, 21)
Me.cmbHDD2.TabIndex = 20
'
'PROizV10
'
Me.PROizV10.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
Me.PROizV10.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
Me.PROizV10.Cursor = System.Windows.Forms.Cursors.WaitCursor
Me.PROizV10.Dock = System.Windows.Forms.DockStyle.Fill
Me.PROizV10.FormattingEnabled = true
Me.PROizV10.Location = New System.Drawing.Point(476, 3)
Me.PROizV10.Name = "PROizV10"
Me.PROizV10.Size = New System.Drawing.Size(111, 21)
Me.PROizV10.TabIndex = 19
'
'txtHDDsN3
'
Me.txtHDDsN3.Location = New System.Drawing.Point(376, 57)
Me.txtHDDsN3.Name = "txtHDDsN3"
Me.txtHDDsN3.Size = New System.Drawing.Size(94, 20)
Me.txtHDDsN3.TabIndex = 26
'
'txtHDDo4
'
Me.txtHDDo4.Location = New System.Drawing.Point(276, 84)
Me.txtHDDo4.Name = "txtHDDo4"
Me.txtHDDo4.Size = New System.Drawing.Size(94, 20)
Me.txtHDDo4.TabIndex = 29
'
'cmbHDD3
'
Me.cmbHDD3.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
Me.cmbHDD3.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
Me.cmbHDD3.Cursor = System.Windows.Forms.Cursors.WaitCursor
Me.cmbHDD3.Dock = System.Windows.Forms.DockStyle.Fill
Me.cmbHDD3.FormattingEnabled = true
Me.cmbHDD3.Location = New System.Drawing.Point(3, 57)
Me.cmbHDD3.Name = "cmbHDD3"
Me.cmbHDD3.Size = New System.Drawing.Size(267, 21)
Me.cmbHDD3.TabIndex = 24
'
'cmbHDD4
'
Me.cmbHDD4.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
Me.cmbHDD4.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
Me.cmbHDD4.Cursor = System.Windows.Forms.Cursors.WaitCursor
Me.cmbHDD4.Dock = System.Windows.Forms.DockStyle.Fill
Me.cmbHDD4.FormattingEnabled = true
Me.cmbHDD4.Location = New System.Drawing.Point(3, 84)
Me.cmbHDD4.Name = "cmbHDD4"
Me.cmbHDD4.Size = New System.Drawing.Size(267, 21)
Me.cmbHDD4.TabIndex = 28
'
'txtHDDo1
'
Me.txtHDDo1.Location = New System.Drawing.Point(276, 3)
Me.txtHDDo1.Name = "txtHDDo1"
Me.txtHDDo1.Size = New System.Drawing.Size(94, 20)
Me.txtHDDo1.TabIndex = 17
'
'txtHDDsN1
'
Me.txtHDDsN1.Location = New System.Drawing.Point(376, 3)
Me.txtHDDsN1.Name = "txtHDDsN1"
Me.txtHDDsN1.Size = New System.Drawing.Size(94, 20)
Me.txtHDDsN1.TabIndex = 18
'
'txtHDDo3
'
Me.txtHDDo3.Location = New System.Drawing.Point(276, 57)
Me.txtHDDo3.Name = "txtHDDo3"
Me.txtHDDo3.Size = New System.Drawing.Size(94, 20)
Me.txtHDDo3.TabIndex = 25
'
'txtHDDo2
'
Me.txtHDDo2.Location = New System.Drawing.Point(276, 30)
Me.txtHDDo2.Name = "txtHDDo2"
Me.txtHDDo2.Size = New System.Drawing.Size(94, 20)
Me.txtHDDo2.TabIndex = 21
'
'txtHDDsN2
'
Me.txtHDDsN2.Location = New System.Drawing.Point(376, 30)
Me.txtHDDsN2.Name = "txtHDDsN2"
Me.txtHDDsN2.Size = New System.Drawing.Size(94, 20)
Me.txtHDDsN2.TabIndex = 22
'
'ToolStrip10
'
Me.ToolStrip10.BackColor = System.Drawing.Color.Transparent
Me.ToolStrip10.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
Me.ToolStrip10.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.bHddPlus})
Me.ToolStrip10.Location = New System.Drawing.Point(590, 0)
Me.ToolStrip10.Name = "ToolStrip10"
Me.ToolStrip10.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
Me.ToolStrip10.Size = New System.Drawing.Size(51, 25)
Me.ToolStrip10.TabIndex = 32
Me.ToolStrip10.Text = "ToolStrip10"
'
'bHddPlus
'
Me.bHddPlus.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
Me.bHddPlus.ImageTransparentColor = System.Drawing.Color.Magenta
Me.bHddPlus.Name = "bHddPlus"
Me.bHddPlus.Size = New System.Drawing.Size(23, 22)
Me.bHddPlus.Text = "+"
'
'cmbHDD5
'
Me.cmbHDD5.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
Me.cmbHDD5.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
Me.cmbHDD5.Dock = System.Windows.Forms.DockStyle.Fill
Me.cmbHDD5.FormattingEnabled = true
Me.cmbHDD5.Location = New System.Drawing.Point(3, 111)
Me.cmbHDD5.Name = "cmbHDD5"
Me.cmbHDD5.Size = New System.Drawing.Size(267, 21)
Me.cmbHDD5.TabIndex = 33
'
'cmbHDD6
'
Me.cmbHDD6.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
Me.cmbHDD6.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
Me.cmbHDD6.Dock = System.Windows.Forms.DockStyle.Fill
Me.cmbHDD6.FormattingEnabled = true
Me.cmbHDD6.Location = New System.Drawing.Point(3, 138)
Me.cmbHDD6.Name = "cmbHDD6"
Me.cmbHDD6.Size = New System.Drawing.Size(267, 21)
Me.cmbHDD6.TabIndex = 34
'
'cmbHDD7
'
Me.cmbHDD7.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
Me.cmbHDD7.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
Me.cmbHDD7.Dock = System.Windows.Forms.DockStyle.Fill
Me.cmbHDD7.FormattingEnabled = true
Me.cmbHDD7.Location = New System.Drawing.Point(3, 165)
Me.cmbHDD7.Name = "cmbHDD7"
Me.cmbHDD7.Size = New System.Drawing.Size(267, 21)
Me.cmbHDD7.TabIndex = 35
'
'cmbHDD8
'
Me.cmbHDD8.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
Me.cmbHDD8.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
Me.cmbHDD8.Dock = System.Windows.Forms.DockStyle.Fill
Me.cmbHDD8.FormattingEnabled = true
Me.cmbHDD8.Location = New System.Drawing.Point(3, 192)
Me.cmbHDD8.Name = "cmbHDD8"
Me.cmbHDD8.Size = New System.Drawing.Size(267, 21)
Me.cmbHDD8.TabIndex = 36
'
'PROizV48
'
Me.PROizV48.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
Me.PROizV48.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
Me.TableLayoutPanel26.SetColumnSpan(Me.PROizV48, 2)
Me.PROizV48.Dock = System.Windows.Forms.DockStyle.Fill
Me.PROizV48.FormattingEnabled = true
Me.PROizV48.Location = New System.Drawing.Point(476, 111)
Me.PROizV48.Name = "PROizV48"
Me.PROizV48.Size = New System.Drawing.Size(162, 21)
Me.PROizV48.TabIndex = 37
'
'PROizV49
'
Me.PROizV49.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
Me.PROizV49.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
Me.TableLayoutPanel26.SetColumnSpan(Me.PROizV49, 2)
Me.PROizV49.Dock = System.Windows.Forms.DockStyle.Fill
Me.PROizV49.FormattingEnabled = true
Me.PROizV49.Location = New System.Drawing.Point(476, 138)
Me.PROizV49.Name = "PROizV49"
Me.PROizV49.Size = New System.Drawing.Size(162, 21)
Me.PROizV49.TabIndex = 38
'
'PROizV50
'
Me.PROizV50.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
Me.PROizV50.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
Me.TableLayoutPanel26.SetColumnSpan(Me.PROizV50, 2)
Me.PROizV50.Dock = System.Windows.Forms.DockStyle.Fill
Me.PROizV50.FormattingEnabled = true
Me.PROizV50.Location = New System.Drawing.Point(476, 165)
Me.PROizV50.Name = "PROizV50"
Me.PROizV50.Size = New System.Drawing.Size(162, 21)
Me.PROizV50.TabIndex = 39
'
'PROizV51
'
Me.PROizV51.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
Me.PROizV51.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
Me.TableLayoutPanel26.SetColumnSpan(Me.PROizV51, 2)
Me.PROizV51.Dock = System.Windows.Forms.DockStyle.Fill
Me.PROizV51.FormattingEnabled = true
Me.PROizV51.Location = New System.Drawing.Point(476, 192)
Me.PROizV51.Name = "PROizV51"
Me.PROizV51.Size = New System.Drawing.Size(162, 21)
Me.PROizV51.TabIndex = 40
'
'txtHDDo5
'
Me.txtHDDo5.Dock = System.Windows.Forms.DockStyle.Fill
Me.txtHDDo5.Location = New System.Drawing.Point(276, 111)
Me.txtHDDo5.Name = "txtHDDo5"
Me.txtHDDo5.Size = New System.Drawing.Size(94, 20)
Me.txtHDDo5.TabIndex = 41
'
'txtHDDsN5
'
Me.txtHDDsN5.Dock = System.Windows.Forms.DockStyle.Fill
Me.txtHDDsN5.Location = New System.Drawing.Point(376, 111)
Me.txtHDDsN5.Name = "txtHDDsN5"
Me.txtHDDsN5.Size = New System.Drawing.Size(94, 20)
Me.txtHDDsN5.TabIndex = 42
'
'txtHDDo6
'
Me.txtHDDo6.Dock = System.Windows.Forms.DockStyle.Fill
Me.txtHDDo6.Location = New System.Drawing.Point(276, 138)
Me.txtHDDo6.Name = "txtHDDo6"
Me.txtHDDo6.Size = New System.Drawing.Size(94, 20)
Me.txtHDDo6.TabIndex = 43
'
'txtHDDsN6
'
Me.txtHDDsN6.Dock = System.Windows.Forms.DockStyle.Fill
Me.txtHDDsN6.Location = New System.Drawing.Point(376, 138)
Me.txtHDDsN6.Name = "txtHDDsN6"
Me.txtHDDsN6.Size = New System.Drawing.Size(94, 20)
Me.txtHDDsN6.TabIndex = 44
'
'txtHDDo7
'
Me.txtHDDo7.Dock = System.Windows.Forms.DockStyle.Fill
Me.txtHDDo7.Location = New System.Drawing.Point(276, 165)
Me.txtHDDo7.Name = "txtHDDo7"
Me.txtHDDo7.Size = New System.Drawing.Size(94, 20)
Me.txtHDDo7.TabIndex = 45
'
'txtHDDsN7
'
Me.txtHDDsN7.Dock = System.Windows.Forms.DockStyle.Fill
Me.txtHDDsN7.Location = New System.Drawing.Point(376, 165)
Me.txtHDDsN7.Name = "txtHDDsN7"
Me.txtHDDsN7.Size = New System.Drawing.Size(94, 20)
Me.txtHDDsN7.TabIndex = 46
'
'txtHDDo8
'
Me.txtHDDo8.Dock = System.Windows.Forms.DockStyle.Fill
Me.txtHDDo8.Location = New System.Drawing.Point(276, 192)
Me.txtHDDo8.Name = "txtHDDo8"
Me.txtHDDo8.Size = New System.Drawing.Size(94, 20)
Me.txtHDDo8.TabIndex = 47
'
'txtHDDsN8
'
Me.txtHDDsN8.Dock = System.Windows.Forms.DockStyle.Fill
Me.txtHDDsN8.Location = New System.Drawing.Point(376, 192)
Me.txtHDDsN8.Name = "txtHDDsN8"
Me.txtHDDsN8.Size = New System.Drawing.Size(94, 20)
Me.txtHDDsN8.TabIndex = 48
'
'gbOptical
'
Me.gbOptical.AutoSize = true
Me.gbOptical.Controls.Add(Me.TableLayoutPanel30)
Me.gbOptical.Cursor = System.Windows.Forms.Cursors.WaitCursor
Me.gbOptical.Dock = System.Windows.Forms.DockStyle.Fill
Me.gbOptical.Location = New System.Drawing.Point(3, 827)
Me.gbOptical.Name = "gbOptical"
Me.gbOptical.Size = New System.Drawing.Size(647, 100)
Me.gbOptical.TabIndex = 6
Me.gbOptical.TabStop = false
Me.gbOptical.Text = "Оптические накопители"
'
'TableLayoutPanel30
'
Me.TableLayoutPanel30.AutoSize = true
Me.TableLayoutPanel30.ColumnCount = 5
Me.TableLayoutPanel30.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70!))
Me.TableLayoutPanel30.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100!))
Me.TableLayoutPanel30.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100!))
Me.TableLayoutPanel30.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30!))
Me.TableLayoutPanel30.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 51!))
Me.TableLayoutPanel30.Controls.Add(Me.PROizV19, 3, 2)
Me.TableLayoutPanel30.Controls.Add(Me.txtOPTICsn3, 2, 2)
Me.TableLayoutPanel30.Controls.Add(Me.PROizV18, 3, 1)
Me.TableLayoutPanel30.Controls.Add(Me.cmbOPTIC1, 0, 0)
Me.TableLayoutPanel30.Controls.Add(Me.PROizV17, 3, 0)
Me.TableLayoutPanel30.Controls.Add(Me.cmbOPTIC2, 0, 1)
Me.TableLayoutPanel30.Controls.Add(Me.txtOPTICsn2, 2, 1)
Me.TableLayoutPanel30.Controls.Add(Me.txtOPTICs3, 1, 2)
Me.TableLayoutPanel30.Controls.Add(Me.cmbOPTIC3, 0, 2)
Me.TableLayoutPanel30.Controls.Add(Me.txtOPTICsn1, 2, 0)
Me.TableLayoutPanel30.Controls.Add(Me.txtOPTICs1, 1, 0)
Me.TableLayoutPanel30.Controls.Add(Me.txtOPTICs2, 1, 1)
Me.TableLayoutPanel30.Controls.Add(Me.ToolStrip12, 4, 0)
Me.TableLayoutPanel30.Dock = System.Windows.Forms.DockStyle.Fill
Me.TableLayoutPanel30.Location = New System.Drawing.Point(3, 16)
Me.TableLayoutPanel30.Name = "TableLayoutPanel30"
Me.TableLayoutPanel30.RowCount = 3
Me.TableLayoutPanel30.RowStyles.Add(New System.Windows.Forms.RowStyle())
Me.TableLayoutPanel30.RowStyles.Add(New System.Windows.Forms.RowStyle())
Me.TableLayoutPanel30.RowStyles.Add(New System.Windows.Forms.RowStyle())
Me.TableLayoutPanel30.Size = New System.Drawing.Size(641, 81)
Me.TableLayoutPanel30.TabIndex = 3
'
'PROizV19
'
Me.PROizV19.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
Me.PROizV19.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
Me.TableLayoutPanel30.SetColumnSpan(Me.PROizV19, 2)
Me.PROizV19.Dock = System.Windows.Forms.DockStyle.Fill
Me.PROizV19.FormattingEnabled = true
Me.PROizV19.Location = New System.Drawing.Point(476, 57)
Me.PROizV19.Name = "PROizV19"
Me.PROizV19.Size = New System.Drawing.Size(162, 21)
Me.PROizV19.TabIndex = 23
'
'txtOPTICsn3
'
Me.txtOPTICsn3.Location = New System.Drawing.Point(376, 57)
Me.txtOPTICsn3.Name = "txtOPTICsn3"
Me.txtOPTICsn3.Size = New System.Drawing.Size(94, 20)
Me.txtOPTICsn3.TabIndex = 22
'
'PROizV18
'
Me.PROizV18.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
Me.PROizV18.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
Me.TableLayoutPanel30.SetColumnSpan(Me.PROizV18, 2)
Me.PROizV18.Dock = System.Windows.Forms.DockStyle.Fill
Me.PROizV18.FormattingEnabled = true
Me.PROizV18.Location = New System.Drawing.Point(476, 30)
Me.PROizV18.Name = "PROizV18"
Me.PROizV18.Size = New System.Drawing.Size(162, 21)
Me.PROizV18.TabIndex = 19
'
'cmbOPTIC1
'
Me.cmbOPTIC1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
Me.cmbOPTIC1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
Me.cmbOPTIC1.Dock = System.Windows.Forms.DockStyle.Fill
Me.cmbOPTIC1.FormattingEnabled = true
Me.cmbOPTIC1.Location = New System.Drawing.Point(3, 3)
Me.cmbOPTIC1.Name = "cmbOPTIC1"
Me.cmbOPTIC1.Size = New System.Drawing.Size(267, 21)
Me.cmbOPTIC1.TabIndex = 12
'
'PROizV17
'
Me.PROizV17.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
Me.PROizV17.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
Me.PROizV17.Dock = System.Windows.Forms.DockStyle.Fill
Me.PROizV17.FormattingEnabled = true
Me.PROizV17.Location = New System.Drawing.Point(476, 3)
Me.PROizV17.Name = "PROizV17"
Me.PROizV17.Size = New System.Drawing.Size(111, 21)
Me.PROizV17.TabIndex = 15
'
'cmbOPTIC2
'
Me.cmbOPTIC2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
Me.cmbOPTIC2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
Me.cmbOPTIC2.Dock = System.Windows.Forms.DockStyle.Fill
Me.cmbOPTIC2.FormattingEnabled = true
Me.cmbOPTIC2.Location = New System.Drawing.Point(3, 30)
Me.cmbOPTIC2.Name = "cmbOPTIC2"
Me.cmbOPTIC2.Size = New System.Drawing.Size(267, 21)
Me.cmbOPTIC2.TabIndex = 16
'
'txtOPTICsn2
'
Me.txtOPTICsn2.Location = New System.Drawing.Point(376, 30)
Me.txtOPTICsn2.Name = "txtOPTICsn2"
Me.txtOPTICsn2.Size = New System.Drawing.Size(94, 20)
Me.txtOPTICsn2.TabIndex = 18
'
'txtOPTICs3
'
Me.txtOPTICs3.Location = New System.Drawing.Point(276, 57)
Me.txtOPTICs3.Name = "txtOPTICs3"
Me.txtOPTICs3.Size = New System.Drawing.Size(94, 20)
Me.txtOPTICs3.TabIndex = 21
'
'cmbOPTIC3
'
Me.cmbOPTIC3.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
Me.cmbOPTIC3.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
Me.cmbOPTIC3.Dock = System.Windows.Forms.DockStyle.Fill
Me.cmbOPTIC3.FormattingEnabled = true
Me.cmbOPTIC3.Location = New System.Drawing.Point(3, 57)
Me.cmbOPTIC3.Name = "cmbOPTIC3"
Me.cmbOPTIC3.Size = New System.Drawing.Size(267, 21)
Me.cmbOPTIC3.TabIndex = 20
'
'txtOPTICsn1
'
Me.txtOPTICsn1.Location = New System.Drawing.Point(376, 3)
Me.txtOPTICsn1.Name = "txtOPTICsn1"
Me.txtOPTICsn1.Size = New System.Drawing.Size(94, 20)
Me.txtOPTICsn1.TabIndex = 14
'
'txtOPTICs1
'
Me.txtOPTICs1.Location = New System.Drawing.Point(276, 3)
Me.txtOPTICs1.Name = "txtOPTICs1"
Me.txtOPTICs1.Size = New System.Drawing.Size(94, 20)
Me.txtOPTICs1.TabIndex = 13
'
'txtOPTICs2
'
Me.txtOPTICs2.Location = New System.Drawing.Point(276, 30)
Me.txtOPTICs2.Name = "txtOPTICs2"
Me.txtOPTICs2.Size = New System.Drawing.Size(94, 20)
Me.txtOPTICs2.TabIndex = 17
'
'ToolStrip12
'
Me.ToolStrip12.BackColor = System.Drawing.Color.Transparent
Me.ToolStrip12.Dock = System.Windows.Forms.DockStyle.None
Me.ToolStrip12.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
Me.ToolStrip12.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.bOpticalPlus})
Me.ToolStrip12.Location = New System.Drawing.Point(590, 0)
Me.ToolStrip12.Name = "ToolStrip12"
Me.ToolStrip12.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
Me.ToolStrip12.Size = New System.Drawing.Size(26, 25)
Me.ToolStrip12.TabIndex = 24
Me.ToolStrip12.Text = "ToolStrip12"
'
'bOpticalPlus
'
Me.bOpticalPlus.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
Me.bOpticalPlus.Image = CType(resources.GetObject("bOpticalPlus.Image"),System.Drawing.Image)
Me.bOpticalPlus.ImageTransparentColor = System.Drawing.Color.Magenta
Me.bOpticalPlus.Name = "bOpticalPlus"
Me.bOpticalPlus.Size = New System.Drawing.Size(23, 22)
Me.bOpticalPlus.Text = "+"
'
'gbNetwork
'
Me.gbNetwork.AutoSize = true
Me.gbNetwork.Controls.Add(Me.TableLayoutPanel31)
Me.gbNetwork.Cursor = System.Windows.Forms.Cursors.WaitCursor
Me.gbNetwork.Dock = System.Windows.Forms.DockStyle.Fill
Me.gbNetwork.Location = New System.Drawing.Point(3, 933)
Me.gbNetwork.Name = "gbNetwork"
Me.gbNetwork.Size = New System.Drawing.Size(647, 73)
Me.gbNetwork.TabIndex = 7
Me.gbNetwork.TabStop = false
Me.gbNetwork.Text = "Сетевые карты"
'
'TableLayoutPanel31
'
Me.TableLayoutPanel31.AutoSize = true
Me.TableLayoutPanel31.ColumnCount = 5
Me.TableLayoutPanel31.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70!))
Me.TableLayoutPanel31.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100!))
Me.TableLayoutPanel31.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100!))
Me.TableLayoutPanel31.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30!))
Me.TableLayoutPanel31.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 51!))
Me.TableLayoutPanel31.Controls.Add(Me.PROizV21, 3, 1)
Me.TableLayoutPanel31.Controls.Add(Me.txtNETmac2, 2, 1)
Me.TableLayoutPanel31.Controls.Add(Me.PROizV20, 3, 0)
Me.TableLayoutPanel31.Controls.Add(Me.cmbNET1, 0, 0)
Me.TableLayoutPanel31.Controls.Add(Me.cmbNET2, 0, 1)
Me.TableLayoutPanel31.Controls.Add(Me.txtNETmac1, 2, 0)
Me.TableLayoutPanel31.Controls.Add(Me.txtNETip2, 1, 1)
Me.TableLayoutPanel31.Controls.Add(Me.txtNETip1, 1, 0)
Me.TableLayoutPanel31.Controls.Add(Me.ToolStrip13, 4, 0)
Me.TableLayoutPanel31.Dock = System.Windows.Forms.DockStyle.Fill
Me.TableLayoutPanel31.Location = New System.Drawing.Point(3, 16)
Me.TableLayoutPanel31.Name = "TableLayoutPanel31"
Me.TableLayoutPanel31.RowCount = 2
Me.TableLayoutPanel31.RowStyles.Add(New System.Windows.Forms.RowStyle())
Me.TableLayoutPanel31.RowStyles.Add(New System.Windows.Forms.RowStyle())
Me.TableLayoutPanel31.Size = New System.Drawing.Size(641, 54)
Me.TableLayoutPanel31.TabIndex = 3
'
'PROizV21
'
Me.PROizV21.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
Me.PROizV21.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
Me.TableLayoutPanel31.SetColumnSpan(Me.PROizV21, 2)
Me.PROizV21.Dock = System.Windows.Forms.DockStyle.Fill
Me.PROizV21.FormattingEnabled = true
Me.PROizV21.Location = New System.Drawing.Point(476, 30)
Me.PROizV21.Name = "PROizV21"
Me.PROizV21.Size = New System.Drawing.Size(162, 21)
Me.PROizV21.TabIndex = 15
'
'txtNETmac2
'
Me.txtNETmac2.Location = New System.Drawing.Point(376, 30)
Me.txtNETmac2.Name = "txtNETmac2"
Me.txtNETmac2.Size = New System.Drawing.Size(94, 20)
Me.txtNETmac2.TabIndex = 14
'
'PROizV20
'
Me.PROizV20.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
Me.PROizV20.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
Me.PROizV20.Dock = System.Windows.Forms.DockStyle.Fill
Me.PROizV20.FormattingEnabled = true
Me.PROizV20.Location = New System.Drawing.Point(476, 3)
Me.PROizV20.Name = "PROizV20"
Me.PROizV20.Size = New System.Drawing.Size(111, 21)
Me.PROizV20.TabIndex = 11
'
'cmbNET1
'
Me.cmbNET1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
Me.cmbNET1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
Me.cmbNET1.Dock = System.Windows.Forms.DockStyle.Fill
Me.cmbNET1.FormattingEnabled = true
Me.cmbNET1.Location = New System.Drawing.Point(3, 3)
Me.cmbNET1.Name = "cmbNET1"
Me.cmbNET1.Size = New System.Drawing.Size(267, 21)
Me.cmbNET1.TabIndex = 8
'
'cmbNET2
'
Me.cmbNET2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
Me.cmbNET2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
Me.cmbNET2.Dock = System.Windows.Forms.DockStyle.Fill
Me.cmbNET2.FormattingEnabled = true
Me.cmbNET2.Location = New System.Drawing.Point(3, 30)
Me.cmbNET2.Name = "cmbNET2"
Me.cmbNET2.Size = New System.Drawing.Size(267, 21)
Me.cmbNET2.TabIndex = 12
'
'txtNETmac1
'
Me.txtNETmac1.Location = New System.Drawing.Point(376, 3)
Me.txtNETmac1.Name = "txtNETmac1"
Me.txtNETmac1.Size = New System.Drawing.Size(94, 20)
Me.txtNETmac1.TabIndex = 10
'
'txtNETip2
'
Me.txtNETip2.Location = New System.Drawing.Point(276, 30)
Me.txtNETip2.Name = "txtNETip2"
Me.txtNETip2.Size = New System.Drawing.Size(94, 20)
Me.txtNETip2.TabIndex = 13
'
'txtNETip1
'
Me.txtNETip1.Location = New System.Drawing.Point(276, 3)
Me.txtNETip1.Name = "txtNETip1"
Me.txtNETip1.Size = New System.Drawing.Size(94, 20)
Me.txtNETip1.TabIndex = 9
'
'ToolStrip13
'
Me.ToolStrip13.BackColor = System.Drawing.Color.Transparent
Me.ToolStrip13.Dock = System.Windows.Forms.DockStyle.None
Me.ToolStrip13.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
Me.ToolStrip13.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.bNetPlus})
Me.ToolStrip13.Location = New System.Drawing.Point(590, 0)
Me.ToolStrip13.Name = "ToolStrip13"
Me.ToolStrip13.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
Me.ToolStrip13.Size = New System.Drawing.Size(26, 25)
Me.ToolStrip13.TabIndex = 16
Me.ToolStrip13.Text = "ToolStrip13"
'
'bNetPlus
'
Me.bNetPlus.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
Me.bNetPlus.Image = CType(resources.GetObject("bNetPlus.Image"),System.Drawing.Image)
Me.bNetPlus.ImageTransparentColor = System.Drawing.Color.Magenta
Me.bNetPlus.Name = "bNetPlus"
Me.bNetPlus.Size = New System.Drawing.Size(23, 22)
Me.bNetPlus.Text = "+"
'
'gbFDD
'
Me.gbFDD.AutoSize = true
Me.gbFDD.Controls.Add(Me.TableLayoutPanel32)
Me.gbFDD.Cursor = System.Windows.Forms.Cursors.WaitCursor
Me.gbFDD.Dock = System.Windows.Forms.DockStyle.Fill
Me.gbFDD.Location = New System.Drawing.Point(3, 1012)
Me.gbFDD.Name = "gbFDD"
Me.gbFDD.Size = New System.Drawing.Size(647, 46)
Me.gbFDD.TabIndex = 8
Me.gbFDD.TabStop = false
Me.gbFDD.Text = "Дисковод"
'
'TableLayoutPanel32
'
Me.TableLayoutPanel32.AutoSize = true
Me.TableLayoutPanel32.ColumnCount = 5
Me.TableLayoutPanel32.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70!))
Me.TableLayoutPanel32.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100!))
Me.TableLayoutPanel32.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100!))
Me.TableLayoutPanel32.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30!))
Me.TableLayoutPanel32.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 51!))
Me.TableLayoutPanel32.Controls.Add(Me.PROizV22, 3, 0)
Me.TableLayoutPanel32.Controls.Add(Me.cmbFDD, 0, 0)
Me.TableLayoutPanel32.Controls.Add(Me.txtSN, 1, 0)
Me.TableLayoutPanel32.Dock = System.Windows.Forms.DockStyle.Fill
Me.TableLayoutPanel32.Location = New System.Drawing.Point(3, 16)
Me.TableLayoutPanel32.Name = "TableLayoutPanel32"
Me.TableLayoutPanel32.RowCount = 1
Me.TableLayoutPanel32.RowStyles.Add(New System.Windows.Forms.RowStyle())
Me.TableLayoutPanel32.Size = New System.Drawing.Size(641, 27)
Me.TableLayoutPanel32.TabIndex = 3
'
'PROizV22
'
Me.PROizV22.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
Me.PROizV22.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
Me.TableLayoutPanel32.SetColumnSpan(Me.PROizV22, 2)
Me.PROizV22.Dock = System.Windows.Forms.DockStyle.Fill
Me.PROizV22.FormattingEnabled = true
Me.PROizV22.Location = New System.Drawing.Point(476, 3)
Me.PROizV22.Name = "PROizV22"
Me.PROizV22.Size = New System.Drawing.Size(162, 21)
Me.PROizV22.TabIndex = 6
'
'cmbFDD
'
Me.cmbFDD.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
Me.cmbFDD.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
Me.cmbFDD.Dock = System.Windows.Forms.DockStyle.Fill
Me.cmbFDD.FormattingEnabled = true
Me.cmbFDD.Location = New System.Drawing.Point(3, 3)
Me.cmbFDD.Name = "cmbFDD"
Me.cmbFDD.Size = New System.Drawing.Size(267, 21)
Me.cmbFDD.TabIndex = 4
'
'txtSN
'
Me.TableLayoutPanel32.SetColumnSpan(Me.txtSN, 2)
Me.txtSN.Location = New System.Drawing.Point(276, 3)
Me.txtSN.Name = "txtSN"
Me.txtSN.Size = New System.Drawing.Size(194, 20)
Me.txtSN.TabIndex = 5
'
'gbCreader
'
Me.gbCreader.AutoSize = true
Me.gbCreader.Controls.Add(Me.TableLayoutPanel33)
Me.gbCreader.Cursor = System.Windows.Forms.Cursors.WaitCursor
Me.gbCreader.Dock = System.Windows.Forms.DockStyle.Fill
Me.gbCreader.Location = New System.Drawing.Point(3, 1064)
Me.gbCreader.Name = "gbCreader"
Me.gbCreader.Size = New System.Drawing.Size(647, 46)
Me.gbCreader.TabIndex = 9
Me.gbCreader.TabStop = false
Me.gbCreader.Text = "КардРидер"
'
'TableLayoutPanel33
'
Me.TableLayoutPanel33.AutoSize = true
Me.TableLayoutPanel33.ColumnCount = 5
Me.TableLayoutPanel33.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70!))
Me.TableLayoutPanel33.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100!))
Me.TableLayoutPanel33.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100!))
Me.TableLayoutPanel33.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30!))
Me.TableLayoutPanel33.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 51!))
Me.TableLayoutPanel33.Controls.Add(Me.PROizV23, 3, 0)
Me.TableLayoutPanel33.Controls.Add(Me.cmbCreader, 0, 0)
Me.TableLayoutPanel33.Controls.Add(Me.txtCreader1, 1, 0)
Me.TableLayoutPanel33.Dock = System.Windows.Forms.DockStyle.Fill
Me.TableLayoutPanel33.Location = New System.Drawing.Point(3, 16)
Me.TableLayoutPanel33.Name = "TableLayoutPanel33"
Me.TableLayoutPanel33.RowCount = 1
Me.TableLayoutPanel33.RowStyles.Add(New System.Windows.Forms.RowStyle())
Me.TableLayoutPanel33.Size = New System.Drawing.Size(641, 27)
Me.TableLayoutPanel33.TabIndex = 3
'
'PROizV23
'
Me.PROizV23.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
Me.PROizV23.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
Me.TableLayoutPanel33.SetColumnSpan(Me.PROizV23, 2)
Me.PROizV23.Dock = System.Windows.Forms.DockStyle.Fill
Me.PROizV23.FormattingEnabled = true
Me.PROizV23.Location = New System.Drawing.Point(476, 3)
Me.PROizV23.Name = "PROizV23"
Me.PROizV23.Size = New System.Drawing.Size(162, 21)
Me.PROizV23.TabIndex = 6
'
'cmbCreader
'
Me.cmbCreader.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
Me.cmbCreader.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
Me.cmbCreader.Dock = System.Windows.Forms.DockStyle.Fill
Me.cmbCreader.FormattingEnabled = true
Me.cmbCreader.Location = New System.Drawing.Point(3, 3)
Me.cmbCreader.Name = "cmbCreader"
Me.cmbCreader.Size = New System.Drawing.Size(267, 21)
Me.cmbCreader.TabIndex = 4
'
'txtCreader1
'
Me.TableLayoutPanel33.SetColumnSpan(Me.txtCreader1, 2)
Me.txtCreader1.Location = New System.Drawing.Point(276, 3)
Me.txtCreader1.Name = "txtCreader1"
Me.txtCreader1.Size = New System.Drawing.Size(194, 20)
Me.txtCreader1.TabIndex = 5
'
'gbModem
'
Me.gbModem.AutoSize = true
Me.gbModem.Controls.Add(Me.TableLayoutPanel34)
Me.gbModem.Cursor = System.Windows.Forms.Cursors.WaitCursor
Me.gbModem.Dock = System.Windows.Forms.DockStyle.Fill
Me.gbModem.Location = New System.Drawing.Point(3, 1116)
Me.gbModem.Name = "gbModem"
Me.gbModem.Size = New System.Drawing.Size(647, 46)
Me.gbModem.TabIndex = 10
Me.gbModem.TabStop = false
Me.gbModem.Text = "Модем"
'
'TableLayoutPanel34
'
Me.TableLayoutPanel34.AutoSize = true
Me.TableLayoutPanel34.ColumnCount = 5
Me.TableLayoutPanel34.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70!))
Me.TableLayoutPanel34.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100!))
Me.TableLayoutPanel34.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100!))
Me.TableLayoutPanel34.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30!))
Me.TableLayoutPanel34.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 51!))
Me.TableLayoutPanel34.Controls.Add(Me.PROizV24, 3, 0)
Me.TableLayoutPanel34.Controls.Add(Me.cmbModem, 0, 0)
Me.TableLayoutPanel34.Controls.Add(Me.txtModemSN, 1, 0)
Me.TableLayoutPanel34.Dock = System.Windows.Forms.DockStyle.Fill
Me.TableLayoutPanel34.Location = New System.Drawing.Point(3, 16)
Me.TableLayoutPanel34.Name = "TableLayoutPanel34"
Me.TableLayoutPanel34.RowCount = 1
Me.TableLayoutPanel34.RowStyles.Add(New System.Windows.Forms.RowStyle())
Me.TableLayoutPanel34.Size = New System.Drawing.Size(641, 27)
Me.TableLayoutPanel34.TabIndex = 3
'
'PROizV24
'
Me.PROizV24.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
Me.PROizV24.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
Me.TableLayoutPanel34.SetColumnSpan(Me.PROizV24, 2)
Me.PROizV24.Dock = System.Windows.Forms.DockStyle.Fill
Me.PROizV24.FormattingEnabled = true
Me.PROizV24.Location = New System.Drawing.Point(476, 3)
Me.PROizV24.Name = "PROizV24"
Me.PROizV24.Size = New System.Drawing.Size(162, 21)
Me.PROizV24.TabIndex = 6
'
'cmbModem
'
Me.cmbModem.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
Me.cmbModem.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
Me.cmbModem.Dock = System.Windows.Forms.DockStyle.Fill
Me.cmbModem.FormattingEnabled = true
Me.cmbModem.Location = New System.Drawing.Point(3, 3)
Me.cmbModem.Name = "cmbModem"
Me.cmbModem.Size = New System.Drawing.Size(267, 21)
Me.cmbModem.TabIndex = 4
'
'txtModemSN
'
Me.TableLayoutPanel34.SetColumnSpan(Me.txtModemSN, 2)
Me.txtModemSN.Location = New System.Drawing.Point(276, 3)
Me.txtModemSN.Name = "txtModemSN"
Me.txtModemSN.Size = New System.Drawing.Size(194, 20)
Me.txtModemSN.TabIndex = 5
'
'gbCase
'
Me.gbCase.AutoSize = true
Me.gbCase.Controls.Add(Me.TableLayoutPanel35)
Me.gbCase.Cursor = System.Windows.Forms.Cursors.WaitCursor
Me.gbCase.Dock = System.Windows.Forms.DockStyle.Fill
Me.gbCase.Location = New System.Drawing.Point(3, 1168)
Me.gbCase.Name = "gbCase"
Me.gbCase.Size = New System.Drawing.Size(647, 46)
Me.gbCase.TabIndex = 11
Me.gbCase.TabStop = false
Me.gbCase.Text = "Корпус"
'
'TableLayoutPanel35
'
Me.TableLayoutPanel35.AutoSize = true
Me.TableLayoutPanel35.ColumnCount = 5
Me.TableLayoutPanel35.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70!))
Me.TableLayoutPanel35.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100!))
Me.TableLayoutPanel35.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100!))
Me.TableLayoutPanel35.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30!))
Me.TableLayoutPanel35.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 51!))
Me.TableLayoutPanel35.Controls.Add(Me.cmbCase, 0, 0)
Me.TableLayoutPanel35.Controls.Add(Me.txtCase1, 1, 0)
Me.TableLayoutPanel35.Controls.Add(Me.PROizV25, 3, 0)
Me.TableLayoutPanel35.Dock = System.Windows.Forms.DockStyle.Fill
Me.TableLayoutPanel35.Location = New System.Drawing.Point(3, 16)
Me.TableLayoutPanel35.Name = "TableLayoutPanel35"
Me.TableLayoutPanel35.RowCount = 1
Me.TableLayoutPanel35.RowStyles.Add(New System.Windows.Forms.RowStyle())
Me.TableLayoutPanel35.Size = New System.Drawing.Size(641, 27)
Me.TableLayoutPanel35.TabIndex = 3
'
'cmbCase
'
Me.cmbCase.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
Me.cmbCase.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
Me.cmbCase.Dock = System.Windows.Forms.DockStyle.Fill
Me.cmbCase.FormattingEnabled = true
Me.cmbCase.Location = New System.Drawing.Point(3, 3)
Me.cmbCase.Name = "cmbCase"
Me.cmbCase.Size = New System.Drawing.Size(267, 21)
Me.cmbCase.TabIndex = 4
'
'txtCase1
'
Me.TableLayoutPanel35.SetColumnSpan(Me.txtCase1, 2)
Me.txtCase1.Location = New System.Drawing.Point(276, 3)
Me.txtCase1.Name = "txtCase1"
Me.txtCase1.Size = New System.Drawing.Size(194, 20)
Me.txtCase1.TabIndex = 5
'
'PROizV25
'
Me.PROizV25.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
Me.PROizV25.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
Me.TableLayoutPanel35.SetColumnSpan(Me.PROizV25, 2)
Me.PROizV25.Dock = System.Windows.Forms.DockStyle.Fill
Me.PROizV25.FormattingEnabled = true
Me.PROizV25.Location = New System.Drawing.Point(476, 3)
Me.PROizV25.Name = "PROizV25"
Me.PROizV25.Size = New System.Drawing.Size(162, 21)
Me.PROizV25.TabIndex = 6
'
'gbBP
'
Me.gbBP.AutoSize = true
Me.gbBP.Controls.Add(Me.TableLayoutPanel36)
Me.gbBP.Cursor = System.Windows.Forms.Cursors.WaitCursor
Me.gbBP.Dock = System.Windows.Forms.DockStyle.Fill
Me.gbBP.Location = New System.Drawing.Point(3, 1220)
Me.gbBP.Name = "gbBP"
Me.gbBP.Size = New System.Drawing.Size(647, 46)
Me.gbBP.TabIndex = 12
Me.gbBP.TabStop = false
Me.gbBP.Text = "Блок питания"
'
'TableLayoutPanel36
'
Me.TableLayoutPanel36.AutoSize = true
Me.TableLayoutPanel36.ColumnCount = 5
Me.TableLayoutPanel36.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70!))
Me.TableLayoutPanel36.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100!))
Me.TableLayoutPanel36.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100!))
Me.TableLayoutPanel36.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30!))
Me.TableLayoutPanel36.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 51!))
Me.TableLayoutPanel36.Controls.Add(Me.cmbBP, 0, 0)
Me.TableLayoutPanel36.Controls.Add(Me.txtBP1, 1, 0)
Me.TableLayoutPanel36.Controls.Add(Me.PROizV26, 3, 0)
Me.TableLayoutPanel36.Dock = System.Windows.Forms.DockStyle.Fill
Me.TableLayoutPanel36.Location = New System.Drawing.Point(3, 16)
Me.TableLayoutPanel36.Name = "TableLayoutPanel36"
Me.TableLayoutPanel36.RowCount = 1
Me.TableLayoutPanel36.RowStyles.Add(New System.Windows.Forms.RowStyle())
Me.TableLayoutPanel36.Size = New System.Drawing.Size(641, 27)
Me.TableLayoutPanel36.TabIndex = 3
'
'cmbBP
'
Me.cmbBP.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
Me.cmbBP.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
Me.cmbBP.Dock = System.Windows.Forms.DockStyle.Fill
Me.cmbBP.FormattingEnabled = true
Me.cmbBP.Location = New System.Drawing.Point(3, 3)
Me.cmbBP.Name = "cmbBP"
Me.cmbBP.Size = New System.Drawing.Size(267, 21)
Me.cmbBP.TabIndex = 4
'
'txtBP1
'
Me.TableLayoutPanel36.SetColumnSpan(Me.txtBP1, 2)
Me.txtBP1.Location = New System.Drawing.Point(276, 3)
Me.txtBP1.Name = "txtBP1"
Me.txtBP1.Size = New System.Drawing.Size(194, 20)
Me.txtBP1.TabIndex = 5
'
'PROizV26
'
Me.PROizV26.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
Me.PROizV26.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
Me.TableLayoutPanel36.SetColumnSpan(Me.PROizV26, 2)
Me.PROizV26.Dock = System.Windows.Forms.DockStyle.Fill
Me.PROizV26.FormattingEnabled = true
Me.PROizV26.Location = New System.Drawing.Point(476, 3)
Me.PROizV26.Name = "PROizV26"
Me.PROizV26.Size = New System.Drawing.Size(162, 21)
Me.PROizV26.TabIndex = 6
'
'gbUSB
'
Me.gbUSB.AutoSize = true
Me.gbUSB.Controls.Add(Me.TableLayoutPanel37)
Me.gbUSB.Dock = System.Windows.Forms.DockStyle.Fill
Me.gbUSB.Location = New System.Drawing.Point(3, 1272)
Me.gbUSB.Name = "gbUSB"
Me.gbUSB.Size = New System.Drawing.Size(647, 46)
Me.gbUSB.TabIndex = 13
Me.gbUSB.TabStop = false
Me.gbUSB.Text = "USB Устройства"
'
'TableLayoutPanel37
'
Me.TableLayoutPanel37.AutoSize = true
Me.TableLayoutPanel37.ColumnCount = 5
Me.TableLayoutPanel37.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70!))
Me.TableLayoutPanel37.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100!))
Me.TableLayoutPanel37.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100!))
Me.TableLayoutPanel37.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30!))
Me.TableLayoutPanel37.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 51!))
Me.TableLayoutPanel37.Controls.Add(Me.cmbUSB, 0, 0)
Me.TableLayoutPanel37.Controls.Add(Me.txtUSBSN, 1, 0)
Me.TableLayoutPanel37.Controls.Add(Me.PROizV41, 3, 0)
Me.TableLayoutPanel37.Dock = System.Windows.Forms.DockStyle.Fill
Me.TableLayoutPanel37.Location = New System.Drawing.Point(3, 16)
Me.TableLayoutPanel37.Name = "TableLayoutPanel37"
Me.TableLayoutPanel37.RowCount = 1
Me.TableLayoutPanel37.RowStyles.Add(New System.Windows.Forms.RowStyle())
Me.TableLayoutPanel37.Size = New System.Drawing.Size(641, 27)
Me.TableLayoutPanel37.TabIndex = 3
'
'cmbUSB
'
Me.cmbUSB.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
Me.cmbUSB.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
Me.cmbUSB.Dock = System.Windows.Forms.DockStyle.Fill
Me.cmbUSB.FormattingEnabled = true
Me.cmbUSB.Location = New System.Drawing.Point(3, 3)
Me.cmbUSB.Name = "cmbUSB"
Me.cmbUSB.Size = New System.Drawing.Size(267, 21)
Me.cmbUSB.TabIndex = 3
'
'txtUSBSN
'
Me.TableLayoutPanel37.SetColumnSpan(Me.txtUSBSN, 2)
Me.txtUSBSN.Location = New System.Drawing.Point(276, 3)
Me.txtUSBSN.Name = "txtUSBSN"
Me.txtUSBSN.Size = New System.Drawing.Size(194, 20)
Me.txtUSBSN.TabIndex = 4
'
'PROizV41
'
Me.PROizV41.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
Me.PROizV41.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
Me.TableLayoutPanel37.SetColumnSpan(Me.PROizV41, 2)
Me.PROizV41.Dock = System.Windows.Forms.DockStyle.Fill
Me.PROizV41.FormattingEnabled = true
Me.PROizV41.Location = New System.Drawing.Point(476, 3)
Me.PROizV41.Name = "PROizV41"
Me.PROizV41.Size = New System.Drawing.Size(162, 21)
Me.PROizV41.TabIndex = 5
'
'gbPCI
'
Me.gbPCI.AutoSize = true
Me.gbPCI.Controls.Add(Me.TableLayoutPanel38)
Me.gbPCI.Cursor = System.Windows.Forms.Cursors.WaitCursor
Me.gbPCI.Dock = System.Windows.Forms.DockStyle.Fill
Me.gbPCI.Location = New System.Drawing.Point(3, 1324)
Me.gbPCI.Name = "gbPCI"
Me.gbPCI.Size = New System.Drawing.Size(647, 46)
Me.gbPCI.TabIndex = 14
Me.gbPCI.TabStop = false
Me.gbPCI.Text = "PCI Устройства"
'
'TableLayoutPanel38
'
Me.TableLayoutPanel38.AutoSize = true
Me.TableLayoutPanel38.ColumnCount = 5
Me.TableLayoutPanel38.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70!))
Me.TableLayoutPanel38.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100!))
Me.TableLayoutPanel38.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100!))
Me.TableLayoutPanel38.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30!))
Me.TableLayoutPanel38.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 51!))
Me.TableLayoutPanel38.Controls.Add(Me.cmbPCI, 0, 0)
Me.TableLayoutPanel38.Controls.Add(Me.txtSNPCI, 1, 0)
Me.TableLayoutPanel38.Controls.Add(Me.PROizV42, 3, 0)
Me.TableLayoutPanel38.Dock = System.Windows.Forms.DockStyle.Fill
Me.TableLayoutPanel38.Location = New System.Drawing.Point(3, 16)
Me.TableLayoutPanel38.Name = "TableLayoutPanel38"
Me.TableLayoutPanel38.RowCount = 1
Me.TableLayoutPanel38.RowStyles.Add(New System.Windows.Forms.RowStyle())
Me.TableLayoutPanel38.Size = New System.Drawing.Size(641, 27)
Me.TableLayoutPanel38.TabIndex = 3
'
'cmbPCI
'
Me.cmbPCI.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
Me.cmbPCI.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
Me.cmbPCI.Dock = System.Windows.Forms.DockStyle.Fill
Me.cmbPCI.FormattingEnabled = true
Me.cmbPCI.Location = New System.Drawing.Point(3, 3)
Me.cmbPCI.Name = "cmbPCI"
Me.cmbPCI.Size = New System.Drawing.Size(267, 21)
Me.cmbPCI.TabIndex = 3
'
'txtSNPCI
'
Me.TableLayoutPanel38.SetColumnSpan(Me.txtSNPCI, 2)
Me.txtSNPCI.Location = New System.Drawing.Point(276, 3)
Me.txtSNPCI.Name = "txtSNPCI"
Me.txtSNPCI.Size = New System.Drawing.Size(194, 20)
Me.txtSNPCI.TabIndex = 4
'
'PROizV42
'
Me.PROizV42.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
Me.PROizV42.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
Me.TableLayoutPanel38.SetColumnSpan(Me.PROizV42, 2)
Me.PROizV42.Dock = System.Windows.Forms.DockStyle.Fill
Me.PROizV42.FormattingEnabled = true
Me.PROizV42.Location = New System.Drawing.Point(476, 3)
Me.PROizV42.Name = "PROizV42"
Me.PROizV42.Size = New System.Drawing.Size(162, 21)
Me.PROizV42.TabIndex = 5
'
'gbSBP
'
Me.gbSBP.AutoSize = true
Me.gbSBP.Controls.Add(Me.TableLayoutPanel39)
Me.gbSBP.Dock = System.Windows.Forms.DockStyle.Fill
Me.gbSBP.Location = New System.Drawing.Point(3, 1376)
Me.gbSBP.Name = "gbSBP"
Me.gbSBP.Size = New System.Drawing.Size(647, 46)
Me.gbSBP.TabIndex = 15
Me.gbSBP.TabStop = false
Me.gbSBP.Text = "Модель, серийный номер, производитель системного блока"
'
'TableLayoutPanel39
'
Me.TableLayoutPanel39.AutoSize = true
Me.TableLayoutPanel39.ColumnCount = 5
Me.TableLayoutPanel39.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70!))
Me.TableLayoutPanel39.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100!))
Me.TableLayoutPanel39.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100!))
Me.TableLayoutPanel39.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30!))
Me.TableLayoutPanel39.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 51!))
Me.TableLayoutPanel39.Controls.Add(Me.txtModSB, 0, 0)
Me.TableLayoutPanel39.Controls.Add(Me.txtSNSB, 1, 0)
Me.TableLayoutPanel39.Controls.Add(Me.PROizV27, 3, 0)
Me.TableLayoutPanel39.Dock = System.Windows.Forms.DockStyle.Fill
Me.TableLayoutPanel39.Location = New System.Drawing.Point(3, 16)
Me.TableLayoutPanel39.Name = "TableLayoutPanel39"
Me.TableLayoutPanel39.RowCount = 1
Me.TableLayoutPanel39.RowStyles.Add(New System.Windows.Forms.RowStyle())
Me.TableLayoutPanel39.Size = New System.Drawing.Size(641, 27)
Me.TableLayoutPanel39.TabIndex = 3
'
'txtModSB
'
Me.txtModSB.Dock = System.Windows.Forms.DockStyle.Fill
Me.txtModSB.Location = New System.Drawing.Point(3, 3)
Me.txtModSB.Name = "txtModSB"
Me.txtModSB.Size = New System.Drawing.Size(267, 20)
Me.txtModSB.TabIndex = 3
'
'txtSNSB
'
Me.TableLayoutPanel39.SetColumnSpan(Me.txtSNSB, 2)
Me.txtSNSB.Location = New System.Drawing.Point(276, 3)
Me.txtSNSB.Name = "txtSNSB"
Me.txtSNSB.Size = New System.Drawing.Size(194, 20)
Me.txtSNSB.TabIndex = 4
'
'PROizV27
'
Me.PROizV27.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
Me.PROizV27.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
Me.TableLayoutPanel39.SetColumnSpan(Me.PROizV27, 2)
Me.PROizV27.Dock = System.Windows.Forms.DockStyle.Fill
Me.PROizV27.FormattingEnabled = true
Me.PROizV27.Location = New System.Drawing.Point(476, 3)
Me.PROizV27.Name = "PROizV27"
Me.PROizV27.Size = New System.Drawing.Size(162, 21)
Me.PROizV27.TabIndex = 5
'
'TabPage3
'
Me.TabPage3.AutoScroll = true
Me.TabPage3.BackColor = System.Drawing.Color.Transparent
Me.TabPage3.Controls.Add(Me.TableLayoutPanel61)
Me.TabPage3.Location = New System.Drawing.Point(4, 22)
Me.TabPage3.Name = "TabPage3"
Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
Me.TabPage3.Size = New System.Drawing.Size(659, 620)
Me.TabPage3.TabIndex = 2
Me.TabPage3.Text = "Периферия"
Me.TabPage3.UseVisualStyleBackColor = true
'
'TableLayoutPanel61
'
Me.TableLayoutPanel61.BackColor = System.Drawing.Color.Transparent
Me.TableLayoutPanel61.ColumnCount = 1
Me.TableLayoutPanel61.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100!))
Me.TableLayoutPanel61.Controls.Add(Me.gbMonitor, 0, 0)
Me.TableLayoutPanel61.Controls.Add(Me.gbPrinters, 0, 6)
Me.TableLayoutPanel61.Controls.Add(Me.gbIBP, 0, 5)
Me.TableLayoutPanel61.Controls.Add(Me.gbKeyboard, 0, 1)
Me.TableLayoutPanel61.Controls.Add(Me.gbMouse, 0, 2)
Me.TableLayoutPanel61.Controls.Add(Me.gbFilter, 0, 4)
Me.TableLayoutPanel61.Controls.Add(Me.gbAsystem, 0, 3)
Me.TableLayoutPanel61.Dock = System.Windows.Forms.DockStyle.Fill
Me.TableLayoutPanel61.Location = New System.Drawing.Point(3, 3)
Me.TableLayoutPanel61.Name = "TableLayoutPanel61"
Me.TableLayoutPanel61.RowCount = 8
Me.TableLayoutPanel61.RowStyles.Add(New System.Windows.Forms.RowStyle())
Me.TableLayoutPanel61.RowStyles.Add(New System.Windows.Forms.RowStyle())
Me.TableLayoutPanel61.RowStyles.Add(New System.Windows.Forms.RowStyle())
Me.TableLayoutPanel61.RowStyles.Add(New System.Windows.Forms.RowStyle())
Me.TableLayoutPanel61.RowStyles.Add(New System.Windows.Forms.RowStyle())
Me.TableLayoutPanel61.RowStyles.Add(New System.Windows.Forms.RowStyle())
Me.TableLayoutPanel61.RowStyles.Add(New System.Windows.Forms.RowStyle())
Me.TableLayoutPanel61.RowStyles.Add(New System.Windows.Forms.RowStyle())
Me.TableLayoutPanel61.Size = New System.Drawing.Size(653, 614)
Me.TableLayoutPanel61.TabIndex = 7
'
'gbMonitor
'
Me.gbMonitor.AutoSize = true
Me.gbMonitor.Controls.Add(Me.TableLayoutPanel40)
Me.gbMonitor.Dock = System.Windows.Forms.DockStyle.Fill
Me.gbMonitor.Location = New System.Drawing.Point(3, 3)
Me.gbMonitor.Name = "gbMonitor"
Me.gbMonitor.Size = New System.Drawing.Size(647, 73)
Me.gbMonitor.TabIndex = 0
Me.gbMonitor.TabStop = false
Me.gbMonitor.Text = "Монитор"
'
'TableLayoutPanel40
'
Me.TableLayoutPanel40.AutoSize = true
Me.TableLayoutPanel40.ColumnCount = 5
Me.TableLayoutPanel40.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70!))
Me.TableLayoutPanel40.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100!))
Me.TableLayoutPanel40.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100!))
Me.TableLayoutPanel40.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30!))
Me.TableLayoutPanel40.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 51!))
Me.TableLayoutPanel40.Controls.Add(Me.PROizV29, 3, 1)
Me.TableLayoutPanel40.Controls.Add(Me.txtMon2SN, 2, 1)
Me.TableLayoutPanel40.Controls.Add(Me.PROizV28, 3, 0)
Me.TableLayoutPanel40.Controls.Add(Me.cmbMon1, 0, 0)
Me.TableLayoutPanel40.Controls.Add(Me.cmbMon2, 0, 1)
Me.TableLayoutPanel40.Controls.Add(Me.txtMon1SN, 2, 0)
Me.TableLayoutPanel40.Controls.Add(Me.txtMon2Dum, 1, 1)
Me.TableLayoutPanel40.Controls.Add(Me.txtMon1Dum, 1, 0)
Me.TableLayoutPanel40.Controls.Add(Me.ToolStrip14, 4, 0)
Me.TableLayoutPanel40.Dock = System.Windows.Forms.DockStyle.Fill
Me.TableLayoutPanel40.Location = New System.Drawing.Point(3, 16)
Me.TableLayoutPanel40.Name = "TableLayoutPanel40"
Me.TableLayoutPanel40.RowCount = 2
Me.TableLayoutPanel40.RowStyles.Add(New System.Windows.Forms.RowStyle())
Me.TableLayoutPanel40.RowStyles.Add(New System.Windows.Forms.RowStyle())
Me.TableLayoutPanel40.Size = New System.Drawing.Size(641, 54)
Me.TableLayoutPanel40.TabIndex = 3
'
'PROizV29
'
Me.PROizV29.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
Me.PROizV29.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
Me.TableLayoutPanel40.SetColumnSpan(Me.PROizV29, 2)
Me.PROizV29.Dock = System.Windows.Forms.DockStyle.Fill
Me.PROizV29.FormattingEnabled = true
Me.PROizV29.Location = New System.Drawing.Point(476, 30)
Me.PROizV29.Name = "PROizV29"
Me.PROizV29.Size = New System.Drawing.Size(162, 21)
Me.PROizV29.TabIndex = 15
'
'txtMon2SN
'
Me.txtMon2SN.Location = New System.Drawing.Point(376, 30)
Me.txtMon2SN.Name = "txtMon2SN"
Me.txtMon2SN.Size = New System.Drawing.Size(94, 20)
Me.txtMon2SN.TabIndex = 14
'
'PROizV28
'
Me.PROizV28.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
Me.PROizV28.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
Me.PROizV28.Dock = System.Windows.Forms.DockStyle.Fill
Me.PROizV28.FormattingEnabled = true
Me.PROizV28.Location = New System.Drawing.Point(476, 3)
Me.PROizV28.Name = "PROizV28"
Me.PROizV28.Size = New System.Drawing.Size(111, 21)
Me.PROizV28.TabIndex = 11
'
'cmbMon1
'
Me.cmbMon1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
Me.cmbMon1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
Me.cmbMon1.Dock = System.Windows.Forms.DockStyle.Fill
Me.cmbMon1.FormattingEnabled = true
Me.cmbMon1.Location = New System.Drawing.Point(3, 3)
Me.cmbMon1.Name = "cmbMon1"
Me.cmbMon1.Size = New System.Drawing.Size(267, 21)
Me.cmbMon1.TabIndex = 8
'
'cmbMon2
'
Me.cmbMon2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
Me.cmbMon2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
Me.cmbMon2.Dock = System.Windows.Forms.DockStyle.Fill
Me.cmbMon2.FormattingEnabled = true
Me.cmbMon2.Location = New System.Drawing.Point(3, 30)
Me.cmbMon2.Name = "cmbMon2"
Me.cmbMon2.Size = New System.Drawing.Size(267, 21)
Me.cmbMon2.TabIndex = 12
'
'txtMon1SN
'
Me.txtMon1SN.Location = New System.Drawing.Point(376, 3)
Me.txtMon1SN.Name = "txtMon1SN"
Me.txtMon1SN.Size = New System.Drawing.Size(94, 20)
Me.txtMon1SN.TabIndex = 10
'
'txtMon2Dum
'
Me.txtMon2Dum.Location = New System.Drawing.Point(276, 30)
Me.txtMon2Dum.Name = "txtMon2Dum"
Me.txtMon2Dum.Size = New System.Drawing.Size(94, 20)
Me.txtMon2Dum.TabIndex = 13
'
'txtMon1Dum
'
Me.txtMon1Dum.Location = New System.Drawing.Point(276, 3)
Me.txtMon1Dum.Name = "txtMon1Dum"
Me.txtMon1Dum.Size = New System.Drawing.Size(94, 20)
Me.txtMon1Dum.TabIndex = 9
'
'ToolStrip14
'
Me.ToolStrip14.BackColor = System.Drawing.Color.Transparent
Me.ToolStrip14.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
Me.ToolStrip14.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.bMonitorPlus})
Me.ToolStrip14.Location = New System.Drawing.Point(590, 0)
Me.ToolStrip14.Name = "ToolStrip14"
Me.ToolStrip14.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
Me.ToolStrip14.Size = New System.Drawing.Size(51, 25)
Me.ToolStrip14.TabIndex = 16
Me.ToolStrip14.Text = "ToolStrip14"
'
'bMonitorPlus
'
Me.bMonitorPlus.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
Me.bMonitorPlus.Image = CType(resources.GetObject("bMonitorPlus.Image"),System.Drawing.Image)
Me.bMonitorPlus.ImageTransparentColor = System.Drawing.Color.Magenta
Me.bMonitorPlus.Name = "bMonitorPlus"
Me.bMonitorPlus.Size = New System.Drawing.Size(23, 22)
Me.bMonitorPlus.Text = "ToolStripButton1"
'
'gbPrinters
'
Me.gbPrinters.AutoSize = true
Me.gbPrinters.Controls.Add(Me.TableLayoutPanel41)
Me.gbPrinters.Dock = System.Windows.Forms.DockStyle.Fill
Me.gbPrinters.Location = New System.Drawing.Point(3, 342)
Me.gbPrinters.Name = "gbPrinters"
Me.gbPrinters.Size = New System.Drawing.Size(647, 100)
Me.gbPrinters.TabIndex = 6
Me.gbPrinters.TabStop = false
Me.gbPrinters.Text = "Подключенные принтеры"
'
'TableLayoutPanel41
'
Me.TableLayoutPanel41.AutoSize = true
Me.TableLayoutPanel41.ColumnCount = 5
Me.TableLayoutPanel41.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70!))
Me.TableLayoutPanel41.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100!))
Me.TableLayoutPanel41.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100!))
Me.TableLayoutPanel41.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30!))
Me.TableLayoutPanel41.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 51!))
Me.TableLayoutPanel41.Controls.Add(Me.cmbPrinters1, 0, 0)
Me.TableLayoutPanel41.Controls.Add(Me.PROizV36, 3, 2)
Me.TableLayoutPanel41.Controls.Add(Me.txtPrint3Port, 2, 2)
Me.TableLayoutPanel41.Controls.Add(Me.PROizV35, 3, 1)
Me.TableLayoutPanel41.Controls.Add(Me.cmbPrinters2, 0, 1)
Me.TableLayoutPanel41.Controls.Add(Me.PROizV34, 3, 0)
Me.TableLayoutPanel41.Controls.Add(Me.cmbPrinters3, 0, 2)
Me.TableLayoutPanel41.Controls.Add(Me.txtPrint2Port, 2, 1)
Me.TableLayoutPanel41.Controls.Add(Me.txtPrint3SN, 1, 2)
Me.TableLayoutPanel41.Controls.Add(Me.txtPrint1SN, 1, 0)
Me.TableLayoutPanel41.Controls.Add(Me.txtPrint1Port, 2, 0)
Me.TableLayoutPanel41.Controls.Add(Me.txtPrint2SN, 1, 1)
Me.TableLayoutPanel41.Controls.Add(Me.ToolStrip15, 4, 0)
Me.TableLayoutPanel41.Dock = System.Windows.Forms.DockStyle.Fill
Me.TableLayoutPanel41.Location = New System.Drawing.Point(3, 16)
Me.TableLayoutPanel41.Name = "TableLayoutPanel41"
Me.TableLayoutPanel41.RowCount = 3
Me.TableLayoutPanel41.RowStyles.Add(New System.Windows.Forms.RowStyle())
Me.TableLayoutPanel41.RowStyles.Add(New System.Windows.Forms.RowStyle())
Me.TableLayoutPanel41.RowStyles.Add(New System.Windows.Forms.RowStyle())
Me.TableLayoutPanel41.Size = New System.Drawing.Size(641, 81)
Me.TableLayoutPanel41.TabIndex = 3
'
'cmbPrinters1
'
Me.cmbPrinters1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
Me.cmbPrinters1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
Me.cmbPrinters1.Dock = System.Windows.Forms.DockStyle.Fill
Me.cmbPrinters1.FormattingEnabled = true
Me.cmbPrinters1.Location = New System.Drawing.Point(3, 3)
Me.cmbPrinters1.Name = "cmbPrinters1"
Me.cmbPrinters1.Size = New System.Drawing.Size(267, 21)
Me.cmbPrinters1.TabIndex = 12
'
'PROizV36
'
Me.PROizV36.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
Me.PROizV36.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
Me.TableLayoutPanel41.SetColumnSpan(Me.PROizV36, 2)
Me.PROizV36.Dock = System.Windows.Forms.DockStyle.Fill
Me.PROizV36.FormattingEnabled = true
Me.PROizV36.Location = New System.Drawing.Point(476, 57)
Me.PROizV36.Name = "PROizV36"
Me.PROizV36.Size = New System.Drawing.Size(162, 21)
Me.PROizV36.TabIndex = 23
'
'txtPrint3Port
'
Me.txtPrint3Port.Location = New System.Drawing.Point(376, 57)
Me.txtPrint3Port.Name = "txtPrint3Port"
Me.txtPrint3Port.Size = New System.Drawing.Size(94, 20)
Me.txtPrint3Port.TabIndex = 22
'
'PROizV35
'
Me.PROizV35.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
Me.PROizV35.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
Me.TableLayoutPanel41.SetColumnSpan(Me.PROizV35, 2)
Me.PROizV35.Dock = System.Windows.Forms.DockStyle.Fill
Me.PROizV35.FormattingEnabled = true
Me.PROizV35.Location = New System.Drawing.Point(476, 30)
Me.PROizV35.Name = "PROizV35"
Me.PROizV35.Size = New System.Drawing.Size(162, 21)
Me.PROizV35.TabIndex = 19
'
'cmbPrinters2
'
Me.cmbPrinters2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
Me.cmbPrinters2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
Me.cmbPrinters2.Dock = System.Windows.Forms.DockStyle.Fill
Me.cmbPrinters2.FormattingEnabled = true
Me.cmbPrinters2.Location = New System.Drawing.Point(3, 30)
Me.cmbPrinters2.Name = "cmbPrinters2"
Me.cmbPrinters2.Size = New System.Drawing.Size(267, 21)
Me.cmbPrinters2.TabIndex = 16
'
'PROizV34
'
Me.PROizV34.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
Me.PROizV34.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
Me.PROizV34.Dock = System.Windows.Forms.DockStyle.Fill
Me.PROizV34.FormattingEnabled = true
Me.PROizV34.Location = New System.Drawing.Point(476, 3)
Me.PROizV34.Name = "PROizV34"
Me.PROizV34.Size = New System.Drawing.Size(111, 21)
Me.PROizV34.TabIndex = 15
'
'cmbPrinters3
'
Me.cmbPrinters3.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
Me.cmbPrinters3.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
Me.cmbPrinters3.Dock = System.Windows.Forms.DockStyle.Fill
Me.cmbPrinters3.FormattingEnabled = true
Me.cmbPrinters3.Location = New System.Drawing.Point(3, 57)
Me.cmbPrinters3.Name = "cmbPrinters3"
Me.cmbPrinters3.Size = New System.Drawing.Size(267, 21)
Me.cmbPrinters3.TabIndex = 20
'
'txtPrint2Port
'
Me.txtPrint2Port.Location = New System.Drawing.Point(376, 30)
Me.txtPrint2Port.Name = "txtPrint2Port"
Me.txtPrint2Port.Size = New System.Drawing.Size(94, 20)
Me.txtPrint2Port.TabIndex = 18
'
'txtPrint3SN
'
Me.txtPrint3SN.Location = New System.Drawing.Point(276, 57)
Me.txtPrint3SN.Name = "txtPrint3SN"
Me.txtPrint3SN.Size = New System.Drawing.Size(94, 20)
Me.txtPrint3SN.TabIndex = 21
'
'txtPrint1SN
'
Me.txtPrint1SN.Location = New System.Drawing.Point(276, 3)
Me.txtPrint1SN.Name = "txtPrint1SN"
Me.txtPrint1SN.Size = New System.Drawing.Size(94, 20)
Me.txtPrint1SN.TabIndex = 13
'
'txtPrint1Port
'
Me.txtPrint1Port.Location = New System.Drawing.Point(376, 3)
Me.txtPrint1Port.Name = "txtPrint1Port"
Me.txtPrint1Port.Size = New System.Drawing.Size(94, 20)
Me.txtPrint1Port.TabIndex = 14
'
'txtPrint2SN
'
Me.txtPrint2SN.Location = New System.Drawing.Point(276, 30)
Me.txtPrint2SN.Name = "txtPrint2SN"
Me.txtPrint2SN.Size = New System.Drawing.Size(94, 20)
Me.txtPrint2SN.TabIndex = 17
'
'ToolStrip15
'
Me.ToolStrip15.BackColor = System.Drawing.Color.Transparent
Me.ToolStrip15.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
Me.ToolStrip15.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.bPrinterPlus})
Me.ToolStrip15.Location = New System.Drawing.Point(590, 0)
Me.ToolStrip15.Name = "ToolStrip15"
Me.ToolStrip15.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
Me.ToolStrip15.Size = New System.Drawing.Size(51, 25)
Me.ToolStrip15.TabIndex = 24
Me.ToolStrip15.Text = "ToolStrip15"
'
'bPrinterPlus
'
Me.bPrinterPlus.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
Me.bPrinterPlus.Image = CType(resources.GetObject("bPrinterPlus.Image"),System.Drawing.Image)
Me.bPrinterPlus.ImageTransparentColor = System.Drawing.Color.Magenta
Me.bPrinterPlus.Name = "bPrinterPlus"
Me.bPrinterPlus.Size = New System.Drawing.Size(23, 22)
Me.bPrinterPlus.Text = "ToolStripButton1"
'
'gbIBP
'
Me.gbIBP.AutoSize = true
Me.gbIBP.Controls.Add(Me.TableLayoutPanel46)
Me.gbIBP.Dock = System.Windows.Forms.DockStyle.Fill
Me.gbIBP.Location = New System.Drawing.Point(3, 290)
Me.gbIBP.Name = "gbIBP"
Me.gbIBP.Size = New System.Drawing.Size(647, 46)
Me.gbIBP.TabIndex = 5
Me.gbIBP.TabStop = false
Me.gbIBP.Text = "Источник бесперебойного питания"
'
'TableLayoutPanel46
'
Me.TableLayoutPanel46.AutoSize = true
Me.TableLayoutPanel46.ColumnCount = 5
Me.TableLayoutPanel46.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70!))
Me.TableLayoutPanel46.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100!))
Me.TableLayoutPanel46.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100!))
Me.TableLayoutPanel46.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30!))
Me.TableLayoutPanel46.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 51!))
Me.TableLayoutPanel46.Controls.Add(Me.PROizV43, 3, 0)
Me.TableLayoutPanel46.Controls.Add(Me.cmbIBP, 0, 0)
Me.TableLayoutPanel46.Controls.Add(Me.txtSNIBP, 1, 0)
Me.TableLayoutPanel46.Dock = System.Windows.Forms.DockStyle.Fill
Me.TableLayoutPanel46.Location = New System.Drawing.Point(3, 16)
Me.TableLayoutPanel46.Name = "TableLayoutPanel46"
Me.TableLayoutPanel46.RowCount = 1
Me.TableLayoutPanel46.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100!))
Me.TableLayoutPanel46.Size = New System.Drawing.Size(641, 27)
Me.TableLayoutPanel46.TabIndex = 3
'
'PROizV43
'
Me.PROizV43.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
Me.PROizV43.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
Me.TableLayoutPanel46.SetColumnSpan(Me.PROizV43, 2)
Me.PROizV43.Dock = System.Windows.Forms.DockStyle.Fill
Me.PROizV43.FormattingEnabled = true
Me.PROizV43.Location = New System.Drawing.Point(476, 3)
Me.PROizV43.Name = "PROizV43"
Me.PROizV43.Size = New System.Drawing.Size(162, 21)
Me.PROizV43.TabIndex = 6
'
'cmbIBP
'
Me.cmbIBP.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
Me.cmbIBP.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
Me.cmbIBP.Dock = System.Windows.Forms.DockStyle.Fill
Me.cmbIBP.FormattingEnabled = true
Me.cmbIBP.Location = New System.Drawing.Point(3, 3)
Me.cmbIBP.Name = "cmbIBP"
Me.cmbIBP.Size = New System.Drawing.Size(267, 21)
Me.cmbIBP.TabIndex = 4
'
'txtSNIBP
'
Me.TableLayoutPanel46.SetColumnSpan(Me.txtSNIBP, 2)
Me.txtSNIBP.Location = New System.Drawing.Point(276, 3)
Me.txtSNIBP.Name = "txtSNIBP"
Me.txtSNIBP.Size = New System.Drawing.Size(194, 20)
Me.txtSNIBP.TabIndex = 5
'
'gbKeyboard
'
Me.gbKeyboard.AutoSize = true
Me.gbKeyboard.Controls.Add(Me.TableLayoutPanel42)
Me.gbKeyboard.Dock = System.Windows.Forms.DockStyle.Fill
Me.gbKeyboard.Location = New System.Drawing.Point(3, 82)
Me.gbKeyboard.Name = "gbKeyboard"
Me.gbKeyboard.Size = New System.Drawing.Size(647, 46)
Me.gbKeyboard.TabIndex = 1
Me.gbKeyboard.TabStop = false
Me.gbKeyboard.Text = "Клавиатура"
'
'TableLayoutPanel42
'
Me.TableLayoutPanel42.AutoSize = true
Me.TableLayoutPanel42.ColumnCount = 5
Me.TableLayoutPanel42.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70!))
Me.TableLayoutPanel42.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100!))
Me.TableLayoutPanel42.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100!))
Me.TableLayoutPanel42.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30!))
Me.TableLayoutPanel42.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 51!))
Me.TableLayoutPanel42.Controls.Add(Me.PROizV30, 3, 0)
Me.TableLayoutPanel42.Controls.Add(Me.cmbKeyb, 0, 0)
Me.TableLayoutPanel42.Controls.Add(Me.txtKeybSN, 1, 0)
Me.TableLayoutPanel42.Dock = System.Windows.Forms.DockStyle.Fill
Me.TableLayoutPanel42.Location = New System.Drawing.Point(3, 16)
Me.TableLayoutPanel42.Name = "TableLayoutPanel42"
Me.TableLayoutPanel42.RowCount = 1
Me.TableLayoutPanel42.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100!))
Me.TableLayoutPanel42.Size = New System.Drawing.Size(641, 27)
Me.TableLayoutPanel42.TabIndex = 3
'
'PROizV30
'
Me.PROizV30.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
Me.PROizV30.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
Me.TableLayoutPanel42.SetColumnSpan(Me.PROizV30, 2)
Me.PROizV30.Dock = System.Windows.Forms.DockStyle.Fill
Me.PROizV30.FormattingEnabled = true
Me.PROizV30.Location = New System.Drawing.Point(476, 3)
Me.PROizV30.Name = "PROizV30"
Me.PROizV30.Size = New System.Drawing.Size(162, 21)
Me.PROizV30.TabIndex = 6
'
'cmbKeyb
'
Me.cmbKeyb.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
Me.cmbKeyb.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
Me.cmbKeyb.Dock = System.Windows.Forms.DockStyle.Fill
Me.cmbKeyb.FormattingEnabled = true
Me.cmbKeyb.Location = New System.Drawing.Point(3, 3)
Me.cmbKeyb.Name = "cmbKeyb"
Me.cmbKeyb.Size = New System.Drawing.Size(267, 21)
Me.cmbKeyb.TabIndex = 4
'
'txtKeybSN
'
Me.TableLayoutPanel42.SetColumnSpan(Me.txtKeybSN, 2)
Me.txtKeybSN.Location = New System.Drawing.Point(276, 3)
Me.txtKeybSN.Name = "txtKeybSN"
Me.txtKeybSN.Size = New System.Drawing.Size(194, 20)
Me.txtKeybSN.TabIndex = 5
'
'gbMouse
'
Me.gbMouse.AutoSize = true
Me.gbMouse.Controls.Add(Me.TableLayoutPanel43)
Me.gbMouse.Dock = System.Windows.Forms.DockStyle.Fill
Me.gbMouse.Location = New System.Drawing.Point(3, 134)
Me.gbMouse.Name = "gbMouse"
Me.gbMouse.Size = New System.Drawing.Size(647, 46)
Me.gbMouse.TabIndex = 2
Me.gbMouse.TabStop = false
Me.gbMouse.Text = "Мышь"
'
'TableLayoutPanel43
'
Me.TableLayoutPanel43.AutoSize = true
Me.TableLayoutPanel43.ColumnCount = 5
Me.TableLayoutPanel43.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70!))
Me.TableLayoutPanel43.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100!))
Me.TableLayoutPanel43.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100!))
Me.TableLayoutPanel43.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30!))
Me.TableLayoutPanel43.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 51!))
Me.TableLayoutPanel43.Controls.Add(Me.cmbMouse, 0, 0)
Me.TableLayoutPanel43.Controls.Add(Me.PROizV31, 3, 0)
Me.TableLayoutPanel43.Controls.Add(Me.txtMouseSN, 1, 0)
Me.TableLayoutPanel43.Dock = System.Windows.Forms.DockStyle.Fill
Me.TableLayoutPanel43.Location = New System.Drawing.Point(3, 16)
Me.TableLayoutPanel43.Name = "TableLayoutPanel43"
Me.TableLayoutPanel43.RowCount = 1
Me.TableLayoutPanel43.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100!))
Me.TableLayoutPanel43.Size = New System.Drawing.Size(641, 27)
Me.TableLayoutPanel43.TabIndex = 3
'
'cmbMouse
'
Me.cmbMouse.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
Me.cmbMouse.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
Me.cmbMouse.Dock = System.Windows.Forms.DockStyle.Fill
Me.cmbMouse.FormattingEnabled = true
Me.cmbMouse.Location = New System.Drawing.Point(3, 3)
Me.cmbMouse.Name = "cmbMouse"
Me.cmbMouse.Size = New System.Drawing.Size(267, 21)
Me.cmbMouse.TabIndex = 4
'
'PROizV31
'
Me.PROizV31.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
Me.PROizV31.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
Me.TableLayoutPanel43.SetColumnSpan(Me.PROizV31, 2)
Me.PROizV31.Dock = System.Windows.Forms.DockStyle.Fill
Me.PROizV31.FormattingEnabled = true
Me.PROizV31.Location = New System.Drawing.Point(476, 3)
Me.PROizV31.Name = "PROizV31"
Me.PROizV31.Size = New System.Drawing.Size(162, 21)
Me.PROizV31.TabIndex = 6
'
'txtMouseSN
'
Me.TableLayoutPanel43.SetColumnSpan(Me.txtMouseSN, 2)
Me.txtMouseSN.Location = New System.Drawing.Point(276, 3)
Me.txtMouseSN.Name = "txtMouseSN"
Me.txtMouseSN.Size = New System.Drawing.Size(194, 20)
Me.txtMouseSN.TabIndex = 5
'
'gbFilter
'
Me.gbFilter.AutoSize = true
Me.gbFilter.Controls.Add(Me.TableLayoutPanel45)
Me.gbFilter.Dock = System.Windows.Forms.DockStyle.Fill
Me.gbFilter.Location = New System.Drawing.Point(3, 238)
Me.gbFilter.Name = "gbFilter"
Me.gbFilter.Size = New System.Drawing.Size(647, 46)
Me.gbFilter.TabIndex = 4
Me.gbFilter.TabStop = false
Me.gbFilter.Text = "Сетевой фильтр"
'
'TableLayoutPanel45
'
Me.TableLayoutPanel45.AutoSize = true
Me.TableLayoutPanel45.ColumnCount = 5
Me.TableLayoutPanel45.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70!))
Me.TableLayoutPanel45.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100!))
Me.TableLayoutPanel45.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100!))
Me.TableLayoutPanel45.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30!))
Me.TableLayoutPanel45.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 51!))
Me.TableLayoutPanel45.Controls.Add(Me.PROizV33, 3, 0)
Me.TableLayoutPanel45.Controls.Add(Me.cmbFilter, 0, 0)
Me.TableLayoutPanel45.Controls.Add(Me.txtFilterSN, 1, 0)
Me.TableLayoutPanel45.Dock = System.Windows.Forms.DockStyle.Fill
Me.TableLayoutPanel45.Location = New System.Drawing.Point(3, 16)
Me.TableLayoutPanel45.Name = "TableLayoutPanel45"
Me.TableLayoutPanel45.RowCount = 1
Me.TableLayoutPanel45.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100!))
Me.TableLayoutPanel45.Size = New System.Drawing.Size(641, 27)
Me.TableLayoutPanel45.TabIndex = 3
'
'PROizV33
'
Me.PROizV33.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
Me.PROizV33.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
Me.TableLayoutPanel45.SetColumnSpan(Me.PROizV33, 2)
Me.PROizV33.Dock = System.Windows.Forms.DockStyle.Fill
Me.PROizV33.FormattingEnabled = true
Me.PROizV33.Location = New System.Drawing.Point(476, 3)
Me.PROizV33.Name = "PROizV33"
Me.PROizV33.Size = New System.Drawing.Size(162, 21)
Me.PROizV33.TabIndex = 6
'
'cmbFilter
'
Me.cmbFilter.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
Me.cmbFilter.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
Me.cmbFilter.Dock = System.Windows.Forms.DockStyle.Fill
Me.cmbFilter.FormattingEnabled = true
Me.cmbFilter.Location = New System.Drawing.Point(3, 3)
Me.cmbFilter.Name = "cmbFilter"
Me.cmbFilter.Size = New System.Drawing.Size(267, 21)
Me.cmbFilter.TabIndex = 4
'
'txtFilterSN
'
Me.TableLayoutPanel45.SetColumnSpan(Me.txtFilterSN, 2)
Me.txtFilterSN.Location = New System.Drawing.Point(276, 3)
Me.txtFilterSN.Name = "txtFilterSN"
Me.txtFilterSN.Size = New System.Drawing.Size(194, 20)
Me.txtFilterSN.TabIndex = 5
'
'gbAsystem
'
Me.gbAsystem.AutoSize = true
Me.gbAsystem.Controls.Add(Me.TableLayoutPanel44)
Me.gbAsystem.Dock = System.Windows.Forms.DockStyle.Fill
Me.gbAsystem.Location = New System.Drawing.Point(3, 186)
Me.gbAsystem.Name = "gbAsystem"
Me.gbAsystem.Size = New System.Drawing.Size(647, 46)
Me.gbAsystem.TabIndex = 3
Me.gbAsystem.TabStop = false
Me.gbAsystem.Text = "Аккустические системы"
'
'TableLayoutPanel44
'
Me.TableLayoutPanel44.AutoSize = true
Me.TableLayoutPanel44.ColumnCount = 5
Me.TableLayoutPanel44.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70!))
Me.TableLayoutPanel44.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100!))
Me.TableLayoutPanel44.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100!))
Me.TableLayoutPanel44.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30!))
Me.TableLayoutPanel44.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 51!))
Me.TableLayoutPanel44.Controls.Add(Me.PROizV32, 3, 0)
Me.TableLayoutPanel44.Controls.Add(Me.cmbAsist, 0, 0)
Me.TableLayoutPanel44.Controls.Add(Me.txtAsistSN, 1, 0)
Me.TableLayoutPanel44.Dock = System.Windows.Forms.DockStyle.Fill
Me.TableLayoutPanel44.Location = New System.Drawing.Point(3, 16)
Me.TableLayoutPanel44.Name = "TableLayoutPanel44"
Me.TableLayoutPanel44.RowCount = 1
Me.TableLayoutPanel44.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100!))
Me.TableLayoutPanel44.Size = New System.Drawing.Size(641, 27)
Me.TableLayoutPanel44.TabIndex = 3
'
'PROizV32
'
Me.PROizV32.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
Me.PROizV32.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
Me.TableLayoutPanel44.SetColumnSpan(Me.PROizV32, 2)
Me.PROizV32.Dock = System.Windows.Forms.DockStyle.Fill
Me.PROizV32.FormattingEnabled = true
Me.PROizV32.Location = New System.Drawing.Point(476, 3)
Me.PROizV32.Name = "PROizV32"
Me.PROizV32.Size = New System.Drawing.Size(162, 21)
Me.PROizV32.TabIndex = 7
'
'cmbAsist
'
Me.cmbAsist.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
Me.cmbAsist.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
Me.cmbAsist.Dock = System.Windows.Forms.DockStyle.Fill
Me.cmbAsist.FormattingEnabled = true
Me.cmbAsist.Location = New System.Drawing.Point(3, 3)
Me.cmbAsist.Name = "cmbAsist"
Me.cmbAsist.Size = New System.Drawing.Size(267, 21)
Me.cmbAsist.TabIndex = 4
'
'txtAsistSN
'
Me.TableLayoutPanel44.SetColumnSpan(Me.txtAsistSN, 2)
Me.txtAsistSN.Dock = System.Windows.Forms.DockStyle.Fill
Me.txtAsistSN.Location = New System.Drawing.Point(276, 3)
Me.txtAsistSN.Name = "txtAsistSN"
Me.txtAsistSN.Size = New System.Drawing.Size(194, 20)
Me.txtAsistSN.TabIndex = 5
'
'TabPage4
'
Me.TabPage4.Controls.Add(Me.TableLayoutPanel10)
Me.TabPage4.Location = New System.Drawing.Point(4, 22)
Me.TabPage4.Name = "TabPage4"
Me.TabPage4.Size = New System.Drawing.Size(659, 620)
Me.TabPage4.TabIndex = 3
Me.TabPage4.Text = "Програмное обеспечение"
Me.TabPage4.UseVisualStyleBackColor = true
'
'TableLayoutPanel10
'
Me.TableLayoutPanel10.ColumnCount = 1
Me.TableLayoutPanel10.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100!))
Me.TableLayoutPanel10.Controls.Add(Me.lstSoftware, 0, 1)
Me.TableLayoutPanel10.Controls.Add(Me.gbSoftEd, 0, 0)
Me.TableLayoutPanel10.Dock = System.Windows.Forms.DockStyle.Fill
Me.TableLayoutPanel10.Location = New System.Drawing.Point(0, 0)
Me.TableLayoutPanel10.Name = "TableLayoutPanel10"
Me.TableLayoutPanel10.RowCount = 2
Me.TableLayoutPanel10.RowStyles.Add(New System.Windows.Forms.RowStyle())
Me.TableLayoutPanel10.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100!))
Me.TableLayoutPanel10.Size = New System.Drawing.Size(659, 620)
Me.TableLayoutPanel10.TabIndex = 1
'
'lstSoftware
'
Me.lstSoftware.Dock = System.Windows.Forms.DockStyle.Fill
Me.lstSoftware.FullRowSelect = true
Me.lstSoftware.GridLines = true
Me.lstSoftware.HideSelection = false
Me.lstSoftware.Location = New System.Drawing.Point(3, 186)
Me.lstSoftware.MultiSelect = false
Me.lstSoftware.Name = "lstSoftware"
Me.lstSoftware.Size = New System.Drawing.Size(653, 431)
Me.lstSoftware.TabIndex = 0
Me.lstSoftware.UseCompatibleStateImageBehavior = false
Me.lstSoftware.View = System.Windows.Forms.View.Details
'
'gbSoftEd
'
Me.gbSoftEd.Controls.Add(Me.TableLayoutPanel13)
Me.gbSoftEd.Dock = System.Windows.Forms.DockStyle.Fill
Me.gbSoftEd.Location = New System.Drawing.Point(3, 3)
Me.gbSoftEd.Name = "gbSoftEd"
Me.gbSoftEd.Size = New System.Drawing.Size(653, 177)
Me.gbSoftEd.TabIndex = 1
Me.gbSoftEd.TabStop = false
Me.gbSoftEd.Text = "Редактировать ПО"
Me.gbSoftEd.Visible = false
'
'TableLayoutPanel13
'
Me.TableLayoutPanel13.ColumnCount = 4
Me.TableLayoutPanel13.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
Me.TableLayoutPanel13.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
Me.TableLayoutPanel13.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
Me.TableLayoutPanel13.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
Me.TableLayoutPanel13.Controls.Add(Me.cmbSoftware, 0, 0)
Me.TableLayoutPanel13.Controls.Add(Me.CheckBox1, 3, 5)
Me.TableLayoutPanel13.Controls.Add(Me.Label114, 0, 1)
Me.TableLayoutPanel13.Controls.Add(Me.cmbTipLicense, 1, 1)
Me.TableLayoutPanel13.Controls.Add(Me.Label115, 2, 1)
Me.TableLayoutPanel13.Controls.Add(Me.cmbTipPo, 3, 1)
Me.TableLayoutPanel13.Controls.Add(Me.Label116, 0, 2)
Me.TableLayoutPanel13.Controls.Add(Me.DateTimePicker1, 2, 5)
Me.TableLayoutPanel13.Controls.Add(Me.txtLicKey, 0, 3)
Me.TableLayoutPanel13.Controls.Add(Me.DTInstall, 0, 5)
Me.TableLayoutPanel13.Controls.Add(Me.Label117, 2, 2)
Me.TableLayoutPanel13.Controls.Add(Me.Label118, 2, 4)
Me.TableLayoutPanel13.Controls.Add(Me.cmbSoftPr, 2, 3)
Me.TableLayoutPanel13.Controls.Add(Me.Label119, 0, 4)
Me.TableLayoutPanel13.Controls.Add(Me.ToolStrip16, 0, 6)
Me.TableLayoutPanel13.Controls.Add(Me.CheckBox2, 2, 6)
Me.TableLayoutPanel13.Dock = System.Windows.Forms.DockStyle.Fill
Me.TableLayoutPanel13.Location = New System.Drawing.Point(3, 16)
Me.TableLayoutPanel13.Name = "TableLayoutPanel13"
Me.TableLayoutPanel13.RowCount = 7
Me.TableLayoutPanel13.RowStyles.Add(New System.Windows.Forms.RowStyle())
Me.TableLayoutPanel13.RowStyles.Add(New System.Windows.Forms.RowStyle())
Me.TableLayoutPanel13.RowStyles.Add(New System.Windows.Forms.RowStyle())
Me.TableLayoutPanel13.RowStyles.Add(New System.Windows.Forms.RowStyle())
Me.TableLayoutPanel13.RowStyles.Add(New System.Windows.Forms.RowStyle())
Me.TableLayoutPanel13.RowStyles.Add(New System.Windows.Forms.RowStyle())
Me.TableLayoutPanel13.RowStyles.Add(New System.Windows.Forms.RowStyle())
Me.TableLayoutPanel13.Size = New System.Drawing.Size(647, 158)
Me.TableLayoutPanel13.TabIndex = 20
'
'cmbSoftware
'
Me.cmbSoftware.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
Me.cmbSoftware.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
Me.TableLayoutPanel13.SetColumnSpan(Me.cmbSoftware, 4)
Me.cmbSoftware.Dock = System.Windows.Forms.DockStyle.Fill
Me.cmbSoftware.FormattingEnabled = true
Me.cmbSoftware.Location = New System.Drawing.Point(3, 3)
Me.cmbSoftware.Name = "cmbSoftware"
Me.cmbSoftware.Size = New System.Drawing.Size(642, 21)
Me.cmbSoftware.TabIndex = 1
'
'CheckBox1
'
Me.CheckBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
Me.CheckBox1.AutoSize = true
Me.CheckBox1.Location = New System.Drawing.Point(492, 111)
Me.CheckBox1.Name = "CheckBox1"
Me.CheckBox1.Size = New System.Drawing.Size(153, 17)
Me.CheckBox1.TabIndex = 18
Me.CheckBox1.Text = "Беcсрочно"
Me.CheckBox1.UseVisualStyleBackColor = true
'
'Label114
'
Me.Label114.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
Me.Label114.AutoSize = true
Me.Label114.Location = New System.Drawing.Point(3, 34)
Me.Label114.Name = "Label114"
Me.Label114.Size = New System.Drawing.Size(171, 13)
Me.Label114.TabIndex = 2
Me.Label114.Text = "Тип лицензии:"
'
'cmbTipLicense
'
Me.cmbTipLicense.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
Me.cmbTipLicense.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
Me.cmbTipLicense.Dock = System.Windows.Forms.DockStyle.Fill
Me.cmbTipLicense.FormattingEnabled = true
Me.cmbTipLicense.Location = New System.Drawing.Point(180, 30)
Me.cmbTipLicense.Name = "cmbTipLicense"
Me.cmbTipLicense.Size = New System.Drawing.Size(157, 21)
Me.cmbTipLicense.TabIndex = 3
'
'Label115
'
Me.Label115.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
Me.Label115.AutoSize = true
Me.Label115.Location = New System.Drawing.Point(343, 34)
Me.Label115.Name = "Label115"
Me.Label115.Size = New System.Drawing.Size(143, 13)
Me.Label115.TabIndex = 4
Me.Label115.Text = "Тип П.О.:"
'
'cmbTipPo
'
Me.cmbTipPo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
Me.cmbTipPo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
Me.cmbTipPo.Dock = System.Windows.Forms.DockStyle.Fill
Me.cmbTipPo.FormattingEnabled = true
Me.cmbTipPo.Location = New System.Drawing.Point(492, 30)
Me.cmbTipPo.Name = "cmbTipPo"
Me.cmbTipPo.Size = New System.Drawing.Size(153, 21)
Me.cmbTipPo.TabIndex = 5
'
'Label116
'
Me.Label116.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
Me.Label116.AutoSize = true
Me.Label116.Location = New System.Drawing.Point(3, 54)
Me.Label116.Name = "Label116"
Me.Label116.Size = New System.Drawing.Size(171, 13)
Me.Label116.TabIndex = 6
Me.Label116.Text = "Лицензионный номер:"
'
'DateTimePicker1
'
Me.DateTimePicker1.Location = New System.Drawing.Point(343, 110)
Me.DateTimePicker1.Name = "DateTimePicker1"
Me.DateTimePicker1.Size = New System.Drawing.Size(140, 20)
Me.DateTimePicker1.TabIndex = 13
'
'txtLicKey
'
Me.TableLayoutPanel13.SetColumnSpan(Me.txtLicKey, 2)
Me.txtLicKey.Dock = System.Windows.Forms.DockStyle.Fill
Me.txtLicKey.Location = New System.Drawing.Point(3, 70)
Me.txtLicKey.Name = "txtLicKey"
Me.txtLicKey.Size = New System.Drawing.Size(334, 20)
Me.txtLicKey.TabIndex = 7
'
'DTInstall
'
Me.DTInstall.Location = New System.Drawing.Point(3, 110)
Me.DTInstall.Name = "DTInstall"
Me.DTInstall.Size = New System.Drawing.Size(168, 20)
Me.DTInstall.TabIndex = 12
'
'Label117
'
Me.Label117.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
Me.Label117.AutoSize = true
Me.Label117.Location = New System.Drawing.Point(343, 54)
Me.Label117.Name = "Label117"
Me.Label117.Size = New System.Drawing.Size(143, 13)
Me.Label117.TabIndex = 8
Me.Label117.Text = "Производитель:"
'
'Label118
'
Me.Label118.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
Me.Label118.AutoSize = true
Me.Label118.Location = New System.Drawing.Point(343, 94)
Me.Label118.Name = "Label118"
Me.Label118.Size = New System.Drawing.Size(143, 13)
Me.Label118.TabIndex = 11
Me.Label118.Text = "Дата окончания лицензии:"
'
'cmbSoftPr
'
Me.cmbSoftPr.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
Me.cmbSoftPr.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
Me.TableLayoutPanel13.SetColumnSpan(Me.cmbSoftPr, 2)
Me.cmbSoftPr.Dock = System.Windows.Forms.DockStyle.Fill
Me.cmbSoftPr.FormattingEnabled = true
Me.cmbSoftPr.Location = New System.Drawing.Point(343, 70)
Me.cmbSoftPr.Name = "cmbSoftPr"
Me.cmbSoftPr.Size = New System.Drawing.Size(302, 21)
Me.cmbSoftPr.TabIndex = 9
'
'Label119
'
Me.Label119.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
Me.Label119.AutoSize = true
Me.Label119.Location = New System.Drawing.Point(3, 94)
Me.Label119.Name = "Label119"
Me.Label119.Size = New System.Drawing.Size(171, 13)
Me.Label119.TabIndex = 10
Me.Label119.Text = "Дата приобретения (установки):"
'
'ToolStrip16
'
Me.ToolStrip16.BackColor = System.Drawing.Color.Transparent
Me.TableLayoutPanel13.SetColumnSpan(Me.ToolStrip16, 2)
Me.ToolStrip16.Dock = System.Windows.Forms.DockStyle.Fill
Me.ToolStrip16.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
Me.ToolStrip16.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnAdd, Me.ToolStripSeparator20, Me.btnDelete, Me.ToolStripSeparator21, Me.btnCancel, Me.ToolStripSeparator22, Me.ToolStripButton1, Me.ToolStripSeparator23})
Me.ToolStrip16.Location = New System.Drawing.Point(0, 133)
Me.ToolStrip16.Name = "ToolStrip16"
Me.ToolStrip16.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
Me.ToolStrip16.Size = New System.Drawing.Size(340, 25)
Me.ToolStrip16.TabIndex = 20
Me.ToolStrip16.Text = "ToolStrip16"
'
'btnAdd
'
Me.btnAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
Me.btnAdd.Image = CType(resources.GetObject("btnAdd.Image"),System.Drawing.Image)
Me.btnAdd.ImageTransparentColor = System.Drawing.Color.Magenta
Me.btnAdd.Name = "btnAdd"
Me.btnAdd.Size = New System.Drawing.Size(63, 22)
Me.btnAdd.Text = "Добавить"
'
'ToolStripSeparator20
'
Me.ToolStripSeparator20.Name = "ToolStripSeparator20"
Me.ToolStripSeparator20.Size = New System.Drawing.Size(6, 25)
'
'btnDelete
'
Me.btnDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
Me.btnDelete.Image = CType(resources.GetObject("btnDelete.Image"),System.Drawing.Image)
Me.btnDelete.ImageTransparentColor = System.Drawing.Color.Magenta
Me.btnDelete.Name = "btnDelete"
Me.btnDelete.Size = New System.Drawing.Size(55, 22)
Me.btnDelete.Text = "Удалить"
'
'ToolStripSeparator21
'
Me.ToolStripSeparator21.Name = "ToolStripSeparator21"
Me.ToolStripSeparator21.Size = New System.Drawing.Size(6, 25)
'
'btnCancel
'
Me.btnCancel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
Me.btnCancel.Image = CType(resources.GetObject("btnCancel.Image"),System.Drawing.Image)
Me.btnCancel.ImageTransparentColor = System.Drawing.Color.Magenta
Me.btnCancel.Name = "btnCancel"
Me.btnCancel.Size = New System.Drawing.Size(53, 22)
Me.btnCancel.Text = "Отмена"
'
'ToolStripSeparator22
'
Me.ToolStripSeparator22.Name = "ToolStripSeparator22"
Me.ToolStripSeparator22.Size = New System.Drawing.Size(6, 25)
'
'ToolStripButton1
'
Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"),System.Drawing.Image)
Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
Me.ToolStripButton1.Name = "ToolStripButton1"
Me.ToolStripButton1.Size = New System.Drawing.Size(86, 22)
Me.ToolStripButton1.Text = "Обновить ПО"
'
'ToolStripSeparator23
'
Me.ToolStripSeparator23.Name = "ToolStripSeparator23"
Me.ToolStripSeparator23.Size = New System.Drawing.Size(6, 25)
'
'CheckBox2
'
Me.CheckBox2.AutoSize = true
Me.CheckBox2.Location = New System.Drawing.Point(343, 136)
Me.CheckBox2.Name = "CheckBox2"
Me.CheckBox2.Size = New System.Drawing.Size(127, 17)
Me.CheckBox2.TabIndex = 19
Me.CheckBox2.Text = "Массовое удаление"
Me.CheckBox2.UseVisualStyleBackColor = true
'
'TabPage5
'
Me.TabPage5.Controls.Add(Me.TableLayoutPanel1)
Me.TabPage5.Location = New System.Drawing.Point(4, 22)
Me.TabPage5.Name = "TabPage5"
Me.TabPage5.Size = New System.Drawing.Size(659, 620)
Me.TabPage5.TabIndex = 4
Me.TabPage5.Text = "Пользователи"
Me.TabPage5.UseVisualStyleBackColor = true
'
'TableLayoutPanel1
'
Me.TableLayoutPanel1.ColumnCount = 1
Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100!))
Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel4, 0, 0)
Me.TableLayoutPanel1.Controls.Add(Me.lstUsers, 0, 1)
Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
Me.TableLayoutPanel1.RowCount = 2
Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100!))
Me.TableLayoutPanel1.Size = New System.Drawing.Size(659, 620)
Me.TableLayoutPanel1.TabIndex = 0
'
'TableLayoutPanel4
'
Me.TableLayoutPanel4.AutoSize = true
Me.TableLayoutPanel4.ColumnCount = 5
Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50!))
Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50!))
Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
Me.TableLayoutPanel4.Controls.Add(Me.ToolStrip1, 4, 0)
Me.TableLayoutPanel4.Controls.Add(Me.txtUMEMO, 0, 5)
Me.TableLayoutPanel4.Controls.Add(Me.Label36, 0, 4)
Me.TableLayoutPanel4.Controls.Add(Me.txtUserEmailPwd, 3, 3)
Me.TableLayoutPanel4.Controls.Add(Me.lblEmailPass, 2, 3)
Me.TableLayoutPanel4.Controls.Add(Me.txtUserEmail, 1, 3)
Me.TableLayoutPanel4.Controls.Add(Me.lblEMAIL, 0, 3)
Me.TableLayoutPanel4.Controls.Add(Me.txtUserJab, 3, 2)
Me.TableLayoutPanel4.Controls.Add(Me.lblJabber, 2, 2)
Me.TableLayoutPanel4.Controls.Add(Me.txtUserIcq, 1, 2)
Me.TableLayoutPanel4.Controls.Add(Me.lblICQ, 0, 2)
Me.TableLayoutPanel4.Controls.Add(Me.lblSurname, 0, 1)
Me.TableLayoutPanel4.Controls.Add(Me.txtUserPass, 3, 0)
Me.TableLayoutPanel4.Controls.Add(Me.lbluserPassword, 2, 0)
Me.TableLayoutPanel4.Controls.Add(Me.lblUsername, 0, 0)
Me.TableLayoutPanel4.Controls.Add(Me.ChkPDC, 3, 4)
Me.TableLayoutPanel4.Controls.Add(Me.txtUserName, 1, 0)
Me.TableLayoutPanel4.Controls.Add(Me.txtUserFIO, 1, 1)
Me.TableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill
Me.TableLayoutPanel4.Location = New System.Drawing.Point(3, 3)
Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
Me.TableLayoutPanel4.RowCount = 6
Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25!))
Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25!))
Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25!))
Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25!))
Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25!))
Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100!))
Me.TableLayoutPanel4.Size = New System.Drawing.Size(653, 274)
Me.TableLayoutPanel4.TabIndex = 43
'
'ToolStrip1
'
Me.ToolStrip1.BackColor = System.Drawing.Color.Transparent
Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.Fill
Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdUserAdd, Me.ToolStripSeparator1, Me.cmdUserDel, Me.ToolStripSeparator2, Me.cmdUserPassEncript, Me.ToolStripSeparator3, Me.btnUserCancel, Me.ToolStripSeparator4})
Me.ToolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow
Me.ToolStrip1.Location = New System.Drawing.Point(557, 0)
Me.ToolStrip1.Name = "ToolStrip1"
Me.TableLayoutPanel4.SetRowSpan(Me.ToolStrip1, 5)
Me.ToolStrip1.Size = New System.Drawing.Size(96, 125)
Me.ToolStrip1.TabIndex = 44
Me.ToolStrip1.Text = "ToolStrip1"
'
'cmdUserAdd
'
Me.cmdUserAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
Me.cmdUserAdd.Image = CType(resources.GetObject("cmdUserAdd.Image"),System.Drawing.Image)
Me.cmdUserAdd.ImageTransparentColor = System.Drawing.Color.Magenta
Me.cmdUserAdd.Name = "cmdUserAdd"
Me.cmdUserAdd.Size = New System.Drawing.Size(94, 19)
Me.cmdUserAdd.Text = "Добавить"
'
'ToolStripSeparator1
'
Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
Me.ToolStripSeparator1.Size = New System.Drawing.Size(94, 6)
'
'cmdUserDel
'
Me.cmdUserDel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
Me.cmdUserDel.Image = CType(resources.GetObject("cmdUserDel.Image"),System.Drawing.Image)
Me.cmdUserDel.ImageTransparentColor = System.Drawing.Color.Magenta
Me.cmdUserDel.Name = "cmdUserDel"
Me.cmdUserDel.Size = New System.Drawing.Size(94, 19)
Me.cmdUserDel.Text = "Удалить"
'
'ToolStripSeparator2
'
Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
Me.ToolStripSeparator2.Size = New System.Drawing.Size(94, 6)
'
'cmdUserPassEncript
'
Me.cmdUserPassEncript.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
Me.cmdUserPassEncript.Image = CType(resources.GetObject("cmdUserPassEncript.Image"),System.Drawing.Image)
Me.cmdUserPassEncript.ImageTransparentColor = System.Drawing.Color.Magenta
Me.cmdUserPassEncript.Name = "cmdUserPassEncript"
Me.cmdUserPassEncript.Size = New System.Drawing.Size(94, 19)
Me.cmdUserPassEncript.Text = "Расшифровать"
'
'ToolStripSeparator3
'
Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
Me.ToolStripSeparator3.Size = New System.Drawing.Size(94, 6)
'
'btnUserCancel
'
Me.btnUserCancel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
Me.btnUserCancel.Image = CType(resources.GetObject("btnUserCancel.Image"),System.Drawing.Image)
Me.btnUserCancel.ImageTransparentColor = System.Drawing.Color.Magenta
Me.btnUserCancel.Name = "btnUserCancel"
Me.btnUserCancel.Size = New System.Drawing.Size(94, 19)
Me.btnUserCancel.Text = "Отмена"
'
'ToolStripSeparator4
'
Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
Me.ToolStripSeparator4.Size = New System.Drawing.Size(94, 6)
'
'txtUMEMO
'
Me.TableLayoutPanel4.SetColumnSpan(Me.txtUMEMO, 5)
Me.txtUMEMO.Dock = System.Windows.Forms.DockStyle.Fill
Me.txtUMEMO.Location = New System.Drawing.Point(3, 128)
Me.txtUMEMO.Multiline = true
Me.txtUMEMO.Name = "txtUMEMO"
Me.txtUMEMO.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
Me.txtUMEMO.Size = New System.Drawing.Size(647, 143)
Me.txtUMEMO.TabIndex = 46
'
'Label36
'
Me.Label36.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
Me.Label36.AutoSize = true
Me.Label36.Location = New System.Drawing.Point(3, 106)
Me.Label36.Name = "Label36"
Me.Label36.Size = New System.Drawing.Size(103, 13)
Me.Label36.TabIndex = 45
Me.Label36.Text = "Примечание:"
'
'txtUserEmailPwd
'
Me.txtUserEmailPwd.Dock = System.Windows.Forms.DockStyle.Fill
Me.txtUserEmailPwd.Location = New System.Drawing.Point(412, 78)
Me.txtUserEmailPwd.Name = "txtUserEmailPwd"
Me.txtUserEmailPwd.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
Me.txtUserEmailPwd.Size = New System.Drawing.Size(142, 20)
Me.txtUserEmailPwd.TabIndex = 44
'
'lblEmailPass
'
Me.lblEmailPass.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
Me.lblEmailPass.AutoSize = true
Me.lblEmailPass.Location = New System.Drawing.Point(260, 81)
Me.lblEmailPass.Name = "lblEmailPass"
Me.lblEmailPass.Size = New System.Drawing.Size(146, 13)
Me.lblEmailPass.TabIndex = 43
Me.lblEmailPass.Text = "Пароль электронной почты"
'
'txtUserEmail
'
Me.txtUserEmail.Dock = System.Windows.Forms.DockStyle.Fill
Me.txtUserEmail.Location = New System.Drawing.Point(112, 78)
Me.txtUserEmail.Name = "txtUserEmail"
Me.txtUserEmail.Size = New System.Drawing.Size(142, 20)
Me.txtUserEmail.TabIndex = 42
'
'lblEMAIL
'
Me.lblEMAIL.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
Me.lblEMAIL.AutoSize = true
Me.lblEMAIL.Location = New System.Drawing.Point(3, 81)
Me.lblEMAIL.Name = "lblEMAIL"
Me.lblEMAIL.Size = New System.Drawing.Size(103, 13)
Me.lblEMAIL.TabIndex = 41
Me.lblEMAIL.Text = "Email"
'
'txtUserJab
'
Me.txtUserJab.Dock = System.Windows.Forms.DockStyle.Fill
Me.txtUserJab.Location = New System.Drawing.Point(412, 53)
Me.txtUserJab.Name = "txtUserJab"
Me.txtUserJab.Size = New System.Drawing.Size(142, 20)
Me.txtUserJab.TabIndex = 40
'
'lblJabber
'
Me.lblJabber.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
Me.lblJabber.AutoSize = true
Me.lblJabber.Location = New System.Drawing.Point(260, 56)
Me.lblJabber.Name = "lblJabber"
Me.lblJabber.Size = New System.Drawing.Size(146, 13)
Me.lblJabber.TabIndex = 39
Me.lblJabber.Text = "Jabber"
'
'txtUserIcq
'
Me.txtUserIcq.Dock = System.Windows.Forms.DockStyle.Fill
Me.txtUserIcq.Location = New System.Drawing.Point(112, 53)
Me.txtUserIcq.Name = "txtUserIcq"
Me.txtUserIcq.Size = New System.Drawing.Size(142, 20)
Me.txtUserIcq.TabIndex = 31
'
'lblICQ
'
Me.lblICQ.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
Me.lblICQ.AutoSize = true
Me.lblICQ.Location = New System.Drawing.Point(3, 56)
Me.lblICQ.Name = "lblICQ"
Me.lblICQ.Size = New System.Drawing.Size(103, 13)
Me.lblICQ.TabIndex = 30
Me.lblICQ.Text = "#ICQ"
'
'lblSurname
'
Me.lblSurname.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
Me.lblSurname.AutoSize = true
Me.lblSurname.Location = New System.Drawing.Point(3, 31)
Me.lblSurname.Name = "lblSurname"
Me.lblSurname.Size = New System.Drawing.Size(103, 13)
Me.lblSurname.TabIndex = 28
Me.lblSurname.Text = "ФИО"
'
'txtUserPass
'
Me.txtUserPass.Dock = System.Windows.Forms.DockStyle.Fill
Me.txtUserPass.Location = New System.Drawing.Point(412, 3)
Me.txtUserPass.Name = "txtUserPass"
Me.txtUserPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
Me.txtUserPass.Size = New System.Drawing.Size(142, 20)
Me.txtUserPass.TabIndex = 25
'
'lbluserPassword
'
Me.lbluserPassword.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
Me.lbluserPassword.AutoSize = true
Me.lbluserPassword.Location = New System.Drawing.Point(260, 6)
Me.lbluserPassword.Name = "lbluserPassword"
Me.lbluserPassword.Size = New System.Drawing.Size(146, 13)
Me.lbluserPassword.TabIndex = 24
Me.lbluserPassword.Text = "Пароль"
'
'lblUsername
'
Me.lblUsername.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
Me.lblUsername.AutoSize = true
Me.lblUsername.Location = New System.Drawing.Point(3, 6)
Me.lblUsername.Name = "lblUsername"
Me.lblUsername.Size = New System.Drawing.Size(103, 13)
Me.lblUsername.TabIndex = 22
Me.lblUsername.Text = "Имя пользователя"
'
'ChkPDC
'
Me.ChkPDC.AutoSize = true
Me.ChkPDC.Location = New System.Drawing.Point(412, 103)
Me.ChkPDC.Name = "ChkPDC"
Me.ChkPDC.Size = New System.Drawing.Size(142, 17)
Me.ChkPDC.TabIndex = 47
Me.ChkPDC.Text = "User AD (Samba, LDAP)"
Me.ChkPDC.UseVisualStyleBackColor = true
'
'txtUserName
'
Me.txtUserName.Dock = System.Windows.Forms.DockStyle.Fill
Me.txtUserName.FormattingEnabled = true
Me.txtUserName.Location = New System.Drawing.Point(112, 3)
Me.txtUserName.Name = "txtUserName"
Me.txtUserName.Size = New System.Drawing.Size(142, 21)
Me.txtUserName.TabIndex = 48
'
'txtUserFIO
'
Me.TableLayoutPanel4.SetColumnSpan(Me.txtUserFIO, 3)
Me.txtUserFIO.Dock = System.Windows.Forms.DockStyle.Fill
Me.txtUserFIO.FormattingEnabled = true
Me.txtUserFIO.Location = New System.Drawing.Point(112, 28)
Me.txtUserFIO.Name = "txtUserFIO"
Me.txtUserFIO.Size = New System.Drawing.Size(442, 21)
Me.txtUserFIO.TabIndex = 49
'
'lstUsers
'
Me.lstUsers.Dock = System.Windows.Forms.DockStyle.Fill
Me.lstUsers.FullRowSelect = true
Me.lstUsers.GridLines = true
Me.lstUsers.Location = New System.Drawing.Point(3, 283)
Me.lstUsers.MultiSelect = false
Me.lstUsers.Name = "lstUsers"
Me.lstUsers.ShowItemToolTips = true
Me.lstUsers.Size = New System.Drawing.Size(653, 334)
Me.lstUsers.TabIndex = 38
Me.lstUsers.UseCompatibleStateImageBehavior = false
Me.lstUsers.View = System.Windows.Forms.View.Details
'
'TabPage7
'
Me.TabPage7.Controls.Add(Me.TableLayoutPanel5)
Me.TabPage7.Location = New System.Drawing.Point(4, 22)
Me.TabPage7.Name = "TabPage7"
Me.TabPage7.Size = New System.Drawing.Size(659, 620)
Me.TabPage7.TabIndex = 6
Me.TabPage7.Text = "Сервис"
Me.TabPage7.UseVisualStyleBackColor = true
'
'TableLayoutPanel5
'
Me.TableLayoutPanel5.AutoSize = true
Me.TableLayoutPanel5.ColumnCount = 1
Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100!))
Me.TableLayoutPanel5.Controls.Add(Me.gbRepair, 0, 1)
Me.TableLayoutPanel5.Controls.Add(Me.gbNotes, 0, 0)
Me.TableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill
Me.TableLayoutPanel5.Location = New System.Drawing.Point(0, 0)
Me.TableLayoutPanel5.Name = "TableLayoutPanel5"
Me.TableLayoutPanel5.RowCount = 2
Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 39.35484!))
Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60.64516!))
Me.TableLayoutPanel5.Size = New System.Drawing.Size(659, 620)
Me.TableLayoutPanel5.TabIndex = 5
'
'gbRepair
'
Me.gbRepair.AutoSize = true
Me.gbRepair.Controls.Add(Me.lvRepair)
Me.gbRepair.Dock = System.Windows.Forms.DockStyle.Fill
Me.gbRepair.Location = New System.Drawing.Point(3, 247)
Me.gbRepair.Name = "gbRepair"
Me.gbRepair.Size = New System.Drawing.Size(653, 370)
Me.gbRepair.TabIndex = 4
Me.gbRepair.TabStop = false
Me.gbRepair.Text = "Ремонты"
'
'lvRepair
'
Me.lvRepair.Dock = System.Windows.Forms.DockStyle.Fill
Me.lvRepair.FullRowSelect = true
Me.lvRepair.GridLines = true
Me.lvRepair.Location = New System.Drawing.Point(3, 16)
Me.lvRepair.MultiSelect = false
Me.lvRepair.Name = "lvRepair"
Me.lvRepair.ShowItemToolTips = true
Me.lvRepair.Size = New System.Drawing.Size(647, 351)
Me.lvRepair.TabIndex = 4
Me.lvRepair.UseCompatibleStateImageBehavior = false
Me.lvRepair.View = System.Windows.Forms.View.Details
'
'gbNotes
'
Me.gbNotes.Controls.Add(Me.TableLayoutPanel6)
Me.gbNotes.Dock = System.Windows.Forms.DockStyle.Fill
Me.gbNotes.Location = New System.Drawing.Point(3, 3)
Me.gbNotes.Name = "gbNotes"
Me.gbNotes.Size = New System.Drawing.Size(653, 238)
Me.gbNotes.TabIndex = 3
Me.gbNotes.TabStop = false
Me.gbNotes.Text = "Заметки"
'
'TableLayoutPanel6
'
Me.TableLayoutPanel6.AutoSize = true
Me.TableLayoutPanel6.ColumnCount = 3
Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 126!))
Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100!))
Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120!))
Me.TableLayoutPanel6.Controls.Add(Me.ToolStrip2, 2, 0)
Me.TableLayoutPanel6.Controls.Add(Me.lvNotes, 0, 2)
Me.TableLayoutPanel6.Controls.Add(Me.txtNotes, 0, 1)
Me.TableLayoutPanel6.Controls.Add(Me.cmbNotesMaster, 1, 0)
Me.TableLayoutPanel6.Controls.Add(Me.dtDateNotes, 0, 0)
Me.TableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill
Me.TableLayoutPanel6.Location = New System.Drawing.Point(3, 16)
Me.TableLayoutPanel6.Name = "TableLayoutPanel6"
Me.TableLayoutPanel6.RowCount = 3
Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25!))
Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80!))
Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle())
Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20!))
Me.TableLayoutPanel6.Size = New System.Drawing.Size(647, 219)
Me.TableLayoutPanel6.TabIndex = 1
'
'ToolStrip2
'
Me.ToolStrip2.BackColor = System.Drawing.Color.Transparent
Me.ToolStrip2.Dock = System.Windows.Forms.DockStyle.Fill
Me.ToolStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnNotesAdd, Me.ToolStripSeparator5, Me.btnNotesDel, Me.ToolStripSeparator6, Me.btnNotesCancel, Me.ToolStripSeparator7})
Me.ToolStrip2.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow
Me.ToolStrip2.Location = New System.Drawing.Point(527, 0)
Me.ToolStrip2.Name = "ToolStrip2"
Me.TableLayoutPanel6.SetRowSpan(Me.ToolStrip2, 2)
Me.ToolStrip2.Size = New System.Drawing.Size(120, 105)
Me.ToolStrip2.TabIndex = 8
Me.ToolStrip2.Text = "ToolStrip2"
'
'btnNotesAdd
'
Me.btnNotesAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
Me.btnNotesAdd.Image = CType(resources.GetObject("btnNotesAdd.Image"),System.Drawing.Image)
Me.btnNotesAdd.ImageTransparentColor = System.Drawing.Color.Magenta
Me.btnNotesAdd.Name = "btnNotesAdd"
Me.btnNotesAdd.Size = New System.Drawing.Size(118, 19)
Me.btnNotesAdd.Text = "Добавить"
'
'ToolStripSeparator5
'
Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
Me.ToolStripSeparator5.Size = New System.Drawing.Size(118, 6)
'
'btnNotesDel
'
Me.btnNotesDel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
Me.btnNotesDel.Image = CType(resources.GetObject("btnNotesDel.Image"),System.Drawing.Image)
Me.btnNotesDel.ImageTransparentColor = System.Drawing.Color.Magenta
Me.btnNotesDel.Name = "btnNotesDel"
Me.btnNotesDel.Size = New System.Drawing.Size(118, 19)
Me.btnNotesDel.Text = "Удалить"
'
'ToolStripSeparator6
'
Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
Me.ToolStripSeparator6.Size = New System.Drawing.Size(118, 6)
'
'btnNotesCancel
'
Me.btnNotesCancel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
Me.btnNotesCancel.Image = CType(resources.GetObject("btnNotesCancel.Image"),System.Drawing.Image)
Me.btnNotesCancel.ImageTransparentColor = System.Drawing.Color.Magenta
Me.btnNotesCancel.Name = "btnNotesCancel"
Me.btnNotesCancel.Size = New System.Drawing.Size(118, 19)
Me.btnNotesCancel.Text = "Отмена"
'
'ToolStripSeparator7
'
Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
Me.ToolStripSeparator7.Size = New System.Drawing.Size(118, 6)
'
'lvNotes
'
Me.TableLayoutPanel6.SetColumnSpan(Me.lvNotes, 3)
Me.lvNotes.Dock = System.Windows.Forms.DockStyle.Fill
Me.lvNotes.FullRowSelect = true
Me.lvNotes.GridLines = true
Me.lvNotes.Location = New System.Drawing.Point(3, 108)
Me.lvNotes.Name = "lvNotes"
Me.lvNotes.Size = New System.Drawing.Size(641, 108)
Me.lvNotes.TabIndex = 4
Me.lvNotes.UseCompatibleStateImageBehavior = false
Me.lvNotes.View = System.Windows.Forms.View.Details
'
'txtNotes
'
Me.TableLayoutPanel6.SetColumnSpan(Me.txtNotes, 2)
Me.txtNotes.Dock = System.Windows.Forms.DockStyle.Fill
Me.txtNotes.Location = New System.Drawing.Point(3, 28)
Me.txtNotes.Multiline = true
Me.txtNotes.Name = "txtNotes"
Me.txtNotes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
Me.txtNotes.Size = New System.Drawing.Size(521, 74)
Me.txtNotes.TabIndex = 3
'
'cmbNotesMaster
'
Me.cmbNotesMaster.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
Me.cmbNotesMaster.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
Me.cmbNotesMaster.Dock = System.Windows.Forms.DockStyle.Fill
Me.cmbNotesMaster.FormattingEnabled = true
Me.cmbNotesMaster.Location = New System.Drawing.Point(129, 3)
Me.cmbNotesMaster.Name = "cmbNotesMaster"
Me.cmbNotesMaster.Size = New System.Drawing.Size(395, 21)
Me.cmbNotesMaster.TabIndex = 2
'
'dtDateNotes
'
Me.dtDateNotes.Dock = System.Windows.Forms.DockStyle.Fill
Me.dtDateNotes.Location = New System.Drawing.Point(3, 3)
Me.dtDateNotes.Name = "dtDateNotes"
Me.dtDateNotes.Size = New System.Drawing.Size(120, 20)
Me.dtDateNotes.TabIndex = 1
'
'TabPage8
'
Me.TabPage8.Controls.Add(Me.TableLayoutPanel66)
Me.TabPage8.Location = New System.Drawing.Point(4, 22)
Me.TabPage8.Name = "TabPage8"
Me.TabPage8.Size = New System.Drawing.Size(659, 620)
Me.TabPage8.TabIndex = 7
Me.TabPage8.Text = "Гарантия"
Me.TabPage8.UseVisualStyleBackColor = true
'
'TableLayoutPanel66
'
Me.TableLayoutPanel66.AutoSize = true
Me.TableLayoutPanel66.ColumnCount = 1
Me.TableLayoutPanel66.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100!))
Me.TableLayoutPanel66.Controls.Add(Me.gbGuarantee, 0, 0)
Me.TableLayoutPanel66.Controls.Add(Me.gbSale, 0, 1)
Me.TableLayoutPanel66.Dock = System.Windows.Forms.DockStyle.Fill
Me.TableLayoutPanel66.Location = New System.Drawing.Point(0, 0)
Me.TableLayoutPanel66.Name = "TableLayoutPanel66"
Me.TableLayoutPanel66.RowCount = 3
Me.TableLayoutPanel66.RowStyles.Add(New System.Windows.Forms.RowStyle())
Me.TableLayoutPanel66.RowStyles.Add(New System.Windows.Forms.RowStyle())
Me.TableLayoutPanel66.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100!))
Me.TableLayoutPanel66.Size = New System.Drawing.Size(659, 620)
Me.TableLayoutPanel66.TabIndex = 3
'
'gbGuarantee
'
Me.gbGuarantee.Controls.Add(Me.TableLayoutPanel59)
Me.gbGuarantee.Dock = System.Windows.Forms.DockStyle.Fill
Me.gbGuarantee.Location = New System.Drawing.Point(3, 3)
Me.gbGuarantee.Name = "gbGuarantee"
Me.gbGuarantee.Size = New System.Drawing.Size(653, 107)
Me.gbGuarantee.TabIndex = 0
Me.gbGuarantee.TabStop = false
Me.gbGuarantee.Text = "Гарантия"
'
'TableLayoutPanel59
'
Me.TableLayoutPanel59.AutoSize = true
Me.TableLayoutPanel59.ColumnCount = 2
Me.TableLayoutPanel59.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
Me.TableLayoutPanel59.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100!))
Me.TableLayoutPanel59.Controls.Add(Me.gbSeller, 1, 0)
Me.TableLayoutPanel59.Controls.Add(Me.rbKompl, 0, 0)
Me.TableLayoutPanel59.Controls.Add(Me.rbSist, 0, 1)
Me.TableLayoutPanel59.Dock = System.Windows.Forms.DockStyle.Fill
Me.TableLayoutPanel59.Location = New System.Drawing.Point(3, 16)
Me.TableLayoutPanel59.Name = "TableLayoutPanel59"
Me.TableLayoutPanel59.RowCount = 2
Me.TableLayoutPanel59.RowStyles.Add(New System.Windows.Forms.RowStyle())
Me.TableLayoutPanel59.RowStyles.Add(New System.Windows.Forms.RowStyle())
Me.TableLayoutPanel59.Size = New System.Drawing.Size(647, 88)
Me.TableLayoutPanel59.TabIndex = 3
'
'gbSeller
'
Me.gbSeller.Controls.Add(Me.TableLayoutPanel60)
Me.gbSeller.Dock = System.Windows.Forms.DockStyle.Fill
Me.gbSeller.Location = New System.Drawing.Point(177, 3)
Me.gbSeller.Name = "gbSeller"
Me.TableLayoutPanel59.SetRowSpan(Me.gbSeller, 2)
Me.gbSeller.Size = New System.Drawing.Size(467, 84)
Me.gbSeller.TabIndex = 4
Me.gbSeller.TabStop = false
Me.gbSeller.Text = "Поставщик"
'
'TableLayoutPanel60
'
Me.TableLayoutPanel60.ColumnCount = 4
Me.TableLayoutPanel60.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
Me.TableLayoutPanel60.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50!))
Me.TableLayoutPanel60.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
Me.TableLayoutPanel60.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50!))
Me.TableLayoutPanel60.Controls.Add(Me.dtGok, 3, 1)
Me.TableLayoutPanel60.Controls.Add(Me.Label20, 0, 0)
Me.TableLayoutPanel60.Controls.Add(Me.Label21, 2, 1)
Me.TableLayoutPanel60.Controls.Add(Me.Label22, 0, 1)
Me.TableLayoutPanel60.Controls.Add(Me.cmbPostav, 1, 0)
Me.TableLayoutPanel60.Controls.Add(Me.dtGPr, 1, 1)
Me.TableLayoutPanel60.Dock = System.Windows.Forms.DockStyle.Fill
Me.TableLayoutPanel60.Location = New System.Drawing.Point(3, 16)
Me.TableLayoutPanel60.Name = "TableLayoutPanel60"
Me.TableLayoutPanel60.RowCount = 2
Me.TableLayoutPanel60.RowStyles.Add(New System.Windows.Forms.RowStyle())
Me.TableLayoutPanel60.RowStyles.Add(New System.Windows.Forms.RowStyle())
Me.TableLayoutPanel60.Size = New System.Drawing.Size(461, 65)
Me.TableLayoutPanel60.TabIndex = 3
'
'dtGok
'
Me.dtGok.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
Me.dtGok.Location = New System.Drawing.Point(310, 36)
Me.dtGok.Name = "dtGok"
Me.dtGok.Size = New System.Drawing.Size(148, 20)
Me.dtGok.TabIndex = 8
Me.dtGok.Value = New Date(2013, 10, 19, 0, 0, 0, 0)
'
'Label20
'
Me.Label20.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
Me.Label20.AutoSize = true
Me.Label20.Location = New System.Drawing.Point(3, 7)
Me.Label20.Name = "Label20"
Me.Label20.Size = New System.Drawing.Size(77, 13)
Me.Label20.TabIndex = 6
Me.Label20.Text = "Продавец"
'
'Label21
'
Me.Label21.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
Me.Label21.AutoSize = true
Me.Label21.Location = New System.Drawing.Point(239, 39)
Me.Label21.Name = "Label21"
Me.Label21.Size = New System.Drawing.Size(65, 13)
Me.Label21.TabIndex = 10
Me.Label21.Text = "Окончание:"
'
'Label22
'
Me.Label22.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
Me.Label22.AutoSize = true
Me.Label22.Location = New System.Drawing.Point(3, 39)
Me.Label22.Name = "Label22"
Me.Label22.Size = New System.Drawing.Size(77, 13)
Me.Label22.TabIndex = 9
Me.Label22.Text = "Приобретено:"
'
'cmbPostav
'
Me.cmbPostav.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
Me.cmbPostav.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
Me.TableLayoutPanel60.SetColumnSpan(Me.cmbPostav, 3)
Me.cmbPostav.Dock = System.Windows.Forms.DockStyle.Fill
Me.cmbPostav.FormattingEnabled = true
Me.cmbPostav.Location = New System.Drawing.Point(86, 3)
Me.cmbPostav.Name = "cmbPostav"
Me.cmbPostav.Size = New System.Drawing.Size(372, 21)
Me.cmbPostav.TabIndex = 5
'
'dtGPr
'
Me.dtGPr.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
Me.dtGPr.Location = New System.Drawing.Point(86, 36)
Me.dtGPr.Name = "dtGPr"
Me.dtGPr.Size = New System.Drawing.Size(147, 20)
Me.dtGPr.TabIndex = 7
Me.dtGPr.Value = New Date(2013, 10, 19, 0, 0, 0, 0)
'
'rbKompl
'
Me.rbKompl.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
Me.rbKompl.AutoSize = true
Me.rbKompl.Location = New System.Drawing.Point(3, 3)
Me.rbKompl.Name = "rbKompl"
Me.rbKompl.Size = New System.Drawing.Size(168, 17)
Me.rbKompl.TabIndex = 3
Me.rbKompl.TabStop = true
Me.rbKompl.Text = "Отдельные комплектующие"
Me.rbKompl.UseVisualStyleBackColor = true
'
'rbSist
'
Me.rbSist.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
Me.rbSist.AutoSize = true
Me.rbSist.Location = New System.Drawing.Point(3, 48)
Me.rbSist.Name = "rbSist"
Me.rbSist.Size = New System.Drawing.Size(168, 17)
Me.rbSist.TabIndex = 5
Me.rbSist.TabStop = true
Me.rbSist.Text = "Компьютер целиком"
Me.rbSist.UseVisualStyleBackColor = true
'
'gbSale
'
Me.gbSale.AutoSize = true
Me.gbSale.Controls.Add(Me.TableLayoutPanel23)
Me.gbSale.Dock = System.Windows.Forms.DockStyle.Fill
Me.gbSale.Location = New System.Drawing.Point(3, 116)
Me.gbSale.Name = "gbSale"
Me.gbSale.Size = New System.Drawing.Size(653, 123)
Me.gbSale.TabIndex = 2
Me.gbSale.TabStop = false
Me.gbSale.Text = "Данные о приобретении"
'
'TableLayoutPanel23
'
Me.TableLayoutPanel23.AutoSize = true
Me.TableLayoutPanel23.ColumnCount = 4
Me.TableLayoutPanel23.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
Me.TableLayoutPanel23.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50!))
Me.TableLayoutPanel23.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
Me.TableLayoutPanel23.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50!))
Me.TableLayoutPanel23.Controls.Add(Me.txtPCSumm, 1, 2)
Me.TableLayoutPanel23.Controls.Add(Me.dtPCdataVvoda, 3, 2)
Me.TableLayoutPanel23.Controls.Add(Me.Label43, 0, 0)
Me.TableLayoutPanel23.Controls.Add(Me.Label48, 2, 2)
Me.TableLayoutPanel23.Controls.Add(Me.txtPCSfN, 1, 0)
Me.TableLayoutPanel23.Controls.Add(Me.txtPCcash, 1, 1)
Me.TableLayoutPanel23.Controls.Add(Me.Label46, 2, 0)
Me.TableLayoutPanel23.Controls.Add(Me.txtPCZay, 3, 1)
Me.TableLayoutPanel23.Controls.Add(Me.Label45, 0, 2)
Me.TableLayoutPanel23.Controls.Add(Me.dtPCSFdate, 3, 0)
Me.TableLayoutPanel23.Controls.Add(Me.Label47, 2, 1)
Me.TableLayoutPanel23.Controls.Add(Me.Label44, 0, 1)
Me.TableLayoutPanel23.Controls.Add(Me.chkPCspis, 0, 3)
Me.TableLayoutPanel23.Controls.Add(Me.dtSpisanie, 1, 3)
Me.TableLayoutPanel23.Controls.Add(Me.chkPCNNb, 3, 3)
Me.TableLayoutPanel23.Dock = System.Windows.Forms.DockStyle.Fill
Me.TableLayoutPanel23.Location = New System.Drawing.Point(3, 16)
Me.TableLayoutPanel23.Name = "TableLayoutPanel23"
Me.TableLayoutPanel23.RowCount = 4
Me.TableLayoutPanel23.RowStyles.Add(New System.Windows.Forms.RowStyle())
Me.TableLayoutPanel23.RowStyles.Add(New System.Windows.Forms.RowStyle())
Me.TableLayoutPanel23.RowStyles.Add(New System.Windows.Forms.RowStyle())
Me.TableLayoutPanel23.RowStyles.Add(New System.Windows.Forms.RowStyle())
Me.TableLayoutPanel23.Size = New System.Drawing.Size(647, 104)
Me.TableLayoutPanel23.TabIndex = 1
'
'txtPCSumm
'
Me.txtPCSumm.Dock = System.Windows.Forms.DockStyle.Fill
Me.txtPCSumm.Location = New System.Drawing.Point(127, 55)
Me.txtPCSumm.Maximum = New Decimal(New Integer() {1000000, 0, 0, 0})
Me.txtPCSumm.Name = "txtPCSumm"
Me.txtPCSumm.Size = New System.Drawing.Size(219, 20)
Me.txtPCSumm.TabIndex = 18
'
'dtPCdataVvoda
'
Me.dtPCdataVvoda.Dock = System.Windows.Forms.DockStyle.Fill
Me.dtPCdataVvoda.Location = New System.Drawing.Point(424, 55)
Me.dtPCdataVvoda.Name = "dtPCdataVvoda"
Me.dtPCdataVvoda.Size = New System.Drawing.Size(220, 20)
Me.dtPCdataVvoda.TabIndex = 20
Me.dtPCdataVvoda.Value = New Date(2013, 10, 19, 0, 0, 0, 0)
'
'Label43
'
Me.Label43.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
Me.Label43.AutoSize = true
Me.Label43.Location = New System.Drawing.Point(3, 6)
Me.Label43.Name = "Label43"
Me.Label43.Size = New System.Drawing.Size(118, 13)
Me.Label43.TabIndex = 13
Me.Label43.Text = "Счёт фактура №"
'
'Label48
'
Me.Label48.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
Me.Label48.AutoSize = true
Me.Label48.Location = New System.Drawing.Point(352, 58)
Me.Label48.Name = "Label48"
Me.Label48.Size = New System.Drawing.Size(66, 13)
Me.Label48.TabIndex = 25
Me.Label48.Text = "Дата ввода"
'
'txtPCSfN
'
Me.txtPCSfN.Dock = System.Windows.Forms.DockStyle.Fill
Me.txtPCSfN.Location = New System.Drawing.Point(127, 3)
Me.txtPCSfN.Name = "txtPCSfN"
Me.txtPCSfN.Size = New System.Drawing.Size(219, 20)
Me.txtPCSfN.TabIndex = 12
'
'txtPCcash
'
Me.txtPCcash.Dock = System.Windows.Forms.DockStyle.Fill
Me.txtPCcash.Location = New System.Drawing.Point(127, 29)
Me.txtPCcash.Maximum = New Decimal(New Integer() {1000000, 0, 0, 0})
Me.txtPCcash.Name = "txtPCcash"
Me.txtPCcash.Size = New System.Drawing.Size(219, 20)
Me.txtPCcash.TabIndex = 17
'
'Label46
'
Me.Label46.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
Me.Label46.AutoSize = true
Me.Label46.Location = New System.Drawing.Point(352, 6)
Me.Label46.Name = "Label46"
Me.Label46.Size = New System.Drawing.Size(66, 13)
Me.Label46.TabIndex = 22
Me.Label46.Text = "от"
'
'txtPCZay
'
Me.txtPCZay.Dock = System.Windows.Forms.DockStyle.Fill
Me.txtPCZay.Location = New System.Drawing.Point(424, 29)
Me.txtPCZay.Name = "txtPCZay"
Me.txtPCZay.Size = New System.Drawing.Size(220, 20)
Me.txtPCZay.TabIndex = 19
'
'Label45
'
Me.Label45.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
Me.Label45.AutoSize = true
Me.Label45.Location = New System.Drawing.Point(3, 58)
Me.Label45.Name = "Label45"
Me.Label45.Size = New System.Drawing.Size(118, 13)
Me.Label45.TabIndex = 15
Me.Label45.Text = "Сумма"
'
'dtPCSFdate
'
Me.dtPCSFdate.Dock = System.Windows.Forms.DockStyle.Fill
Me.dtPCSFdate.Location = New System.Drawing.Point(424, 3)
Me.dtPCSFdate.Name = "dtPCSFdate"
Me.dtPCSFdate.Size = New System.Drawing.Size(220, 20)
Me.dtPCSFdate.TabIndex = 16
Me.dtPCSFdate.Value = New Date(2013, 10, 19, 0, 0, 0, 0)
'
'Label47
'
Me.Label47.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
Me.Label47.AutoSize = true
Me.Label47.Location = New System.Drawing.Point(352, 32)
Me.Label47.Name = "Label47"
Me.Label47.Size = New System.Drawing.Size(66, 13)
Me.Label47.TabIndex = 24
Me.Label47.Text = "Заявка"
'
'Label44
'
Me.Label44.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
Me.Label44.AutoSize = true
Me.Label44.Location = New System.Drawing.Point(3, 32)
Me.Label44.Name = "Label44"
Me.Label44.Size = New System.Drawing.Size(118, 13)
Me.Label44.TabIndex = 14
Me.Label44.Text = "Цена"
'
'chkPCspis
'
Me.chkPCspis.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
Me.chkPCspis.Location = New System.Drawing.Point(3, 83)
Me.chkPCspis.Name = "chkPCspis"
Me.chkPCspis.Size = New System.Drawing.Size(118, 15)
Me.chkPCspis.TabIndex = 21
Me.chkPCspis.Text = "Списано"
Me.chkPCspis.UseVisualStyleBackColor = true
'
'dtSpisanie
'
Me.dtSpisanie.Dock = System.Windows.Forms.DockStyle.Fill
Me.dtSpisanie.Location = New System.Drawing.Point(127, 81)
Me.dtSpisanie.Name = "dtSpisanie"
Me.dtSpisanie.Size = New System.Drawing.Size(219, 20)
Me.dtSpisanie.TabIndex = 26
Me.dtSpisanie.Value = New Date(2013, 7, 2, 0, 0, 0, 0)
'
'chkPCNNb
'
Me.chkPCNNb.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
Me.chkPCNNb.Location = New System.Drawing.Point(424, 83)
Me.chkPCNNb.Name = "chkPCNNb"
Me.chkPCNNb.Size = New System.Drawing.Size(220, 15)
Me.chkPCNNb.TabIndex = 23
Me.chkPCNNb.Text = "Не на балансе"
Me.chkPCNNb.UseVisualStyleBackColor = true
'
'sSTAB5
'
Me.sSTAB5.Controls.Add(Me.TabPage19)
Me.sSTAB5.Controls.Add(Me.TabPage20)
Me.sSTAB5.Controls.Add(Me.TabPage21)
Me.sSTAB5.Dock = System.Windows.Forms.DockStyle.Fill
Me.sSTAB5.Location = New System.Drawing.Point(0, 0)
Me.sSTAB5.Name = "sSTAB5"
Me.sSTAB5.SelectedIndex = 0
Me.sSTAB5.Size = New System.Drawing.Size(667, 646)
Me.sSTAB5.TabIndex = 11
Me.sSTAB5.Visible = false
'
'TabPage19
'
Me.TabPage19.Controls.Add(Me.TableLayoutPanel71)
Me.TabPage19.Location = New System.Drawing.Point(4, 22)
Me.TabPage19.Name = "TabPage19"
Me.TabPage19.Padding = New System.Windows.Forms.Padding(3)
Me.TabPage19.Size = New System.Drawing.Size(659, 620)
Me.TabPage19.TabIndex = 0
Me.TabPage19.Text = "Информация"
Me.TabPage19.UseVisualStyleBackColor = true
'
'TableLayoutPanel71
'
Me.TableLayoutPanel71.ColumnCount = 3
Me.TableLayoutPanel71.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
Me.TableLayoutPanel71.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20!))
Me.TableLayoutPanel71.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100!))
Me.TableLayoutPanel71.Controls.Add(Me.Label70, 0, 0)
Me.TableLayoutPanel71.Controls.Add(Me.txtBRMemo, 1, 3)
Me.TableLayoutPanel71.Controls.Add(Me.txtBRAddress, 1, 0)
Me.TableLayoutPanel71.Controls.Add(Me.Label67, 0, 3)
Me.TableLayoutPanel71.Controls.Add(Me.Label69, 0, 1)
Me.TableLayoutPanel71.Controls.Add(Me.txtBRPhone, 1, 2)
Me.TableLayoutPanel71.Controls.Add(Me.txtBRBoss, 1, 1)
Me.TableLayoutPanel71.Controls.Add(Me.Label68, 0, 2)
Me.TableLayoutPanel71.Dock = System.Windows.Forms.DockStyle.Fill
Me.TableLayoutPanel71.Location = New System.Drawing.Point(3, 3)
Me.TableLayoutPanel71.Name = "TableLayoutPanel71"
Me.TableLayoutPanel71.RowCount = 5
Me.TableLayoutPanel71.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 191!))
Me.TableLayoutPanel71.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26!))
Me.TableLayoutPanel71.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25!))
Me.TableLayoutPanel71.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 94!))
Me.TableLayoutPanel71.RowStyles.Add(New System.Windows.Forms.RowStyle())
Me.TableLayoutPanel71.Size = New System.Drawing.Size(653, 614)
Me.TableLayoutPanel71.TabIndex = 8
'
'Label70
'
Me.Label70.Anchor = System.Windows.Forms.AnchorStyles.Left
Me.Label70.AutoSize = true
Me.Label70.Location = New System.Drawing.Point(3, 89)
Me.Label70.Name = "Label70"
Me.Label70.Size = New System.Drawing.Size(41, 13)
Me.Label70.TabIndex = 0
Me.Label70.Text = "Адрес:"
'
'txtBRMemo
'
Me.TableLayoutPanel71.SetColumnSpan(Me.txtBRMemo, 2)
Me.txtBRMemo.Dock = System.Windows.Forms.DockStyle.Fill
Me.txtBRMemo.Location = New System.Drawing.Point(162, 245)
Me.txtBRMemo.Multiline = true
Me.txtBRMemo.Name = "txtBRMemo"
Me.txtBRMemo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
Me.txtBRMemo.Size = New System.Drawing.Size(488, 88)
Me.txtBRMemo.TabIndex = 4
'
'txtBRAddress
'
Me.TableLayoutPanel71.SetColumnSpan(Me.txtBRAddress, 2)
Me.txtBRAddress.Dock = System.Windows.Forms.DockStyle.Fill
Me.txtBRAddress.Location = New System.Drawing.Point(162, 3)
Me.txtBRAddress.Multiline = true
Me.txtBRAddress.Name = "txtBRAddress"
Me.txtBRAddress.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
Me.txtBRAddress.Size = New System.Drawing.Size(488, 185)
Me.txtBRAddress.TabIndex = 1
'
'Label67
'
Me.Label67.Anchor = System.Windows.Forms.AnchorStyles.Left
Me.Label67.AutoSize = true
Me.Label67.Location = New System.Drawing.Point(3, 282)
Me.Label67.Name = "Label67"
Me.Label67.Size = New System.Drawing.Size(60, 13)
Me.Label67.TabIndex = 7
Me.Label67.Text = "Описание:"
'
'Label69
'
Me.Label69.Anchor = System.Windows.Forms.AnchorStyles.Left
Me.Label69.AutoSize = true
Me.Label69.Location = New System.Drawing.Point(3, 197)
Me.Label69.Name = "Label69"
Me.Label69.Size = New System.Drawing.Size(153, 13)
Me.Label69.TabIndex = 2
Me.Label69.Text = "Ответственный (Начальник):"
'
'txtBRPhone
'
Me.TableLayoutPanel71.SetColumnSpan(Me.txtBRPhone, 2)
Me.txtBRPhone.Dock = System.Windows.Forms.DockStyle.Fill
Me.txtBRPhone.Location = New System.Drawing.Point(162, 220)
Me.txtBRPhone.Name = "txtBRPhone"
Me.txtBRPhone.Size = New System.Drawing.Size(488, 20)
Me.txtBRPhone.TabIndex = 3
'
'txtBRBoss
'
Me.TableLayoutPanel71.SetColumnSpan(Me.txtBRBoss, 2)
Me.txtBRBoss.Dock = System.Windows.Forms.DockStyle.Fill
Me.txtBRBoss.Location = New System.Drawing.Point(162, 194)
Me.txtBRBoss.Name = "txtBRBoss"
Me.txtBRBoss.Size = New System.Drawing.Size(488, 20)
Me.txtBRBoss.TabIndex = 2
'
'Label68
'
Me.Label68.Anchor = System.Windows.Forms.AnchorStyles.Left
Me.Label68.AutoSize = true
Me.Label68.Location = New System.Drawing.Point(3, 223)
Me.Label68.Name = "Label68"
Me.Label68.Size = New System.Drawing.Size(55, 13)
Me.Label68.TabIndex = 4
Me.Label68.Text = "Телефон:"
'
'TabPage20
'
Me.TabPage20.Controls.Add(Me.TableLayoutPanel8)
Me.TabPage20.Location = New System.Drawing.Point(4, 22)
Me.TabPage20.Name = "TabPage20"
Me.TabPage20.Padding = New System.Windows.Forms.Padding(3)
Me.TabPage20.Size = New System.Drawing.Size(659, 620)
Me.TabPage20.TabIndex = 1
Me.TabPage20.Text = "Сервис"
Me.TabPage20.UseVisualStyleBackColor = true
'
'TableLayoutPanel8
'
Me.TableLayoutPanel8.ColumnCount = 1
Me.TableLayoutPanel8.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100!))
Me.TableLayoutPanel8.Controls.Add(Me.gbBRRemont, 0, 1)
Me.TableLayoutPanel8.Controls.Add(Me.gbBRNotes, 0, 0)
Me.TableLayoutPanel8.Dock = System.Windows.Forms.DockStyle.Fill
Me.TableLayoutPanel8.Location = New System.Drawing.Point(3, 3)
Me.TableLayoutPanel8.Name = "TableLayoutPanel8"
Me.TableLayoutPanel8.RowCount = 2
Me.TableLayoutPanel8.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40!))
Me.TableLayoutPanel8.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60!))
Me.TableLayoutPanel8.Size = New System.Drawing.Size(653, 614)
Me.TableLayoutPanel8.TabIndex = 7
'
'gbBRRemont
'
Me.gbBRRemont.Controls.Add(Me.lvRepairBR)
Me.gbBRRemont.Dock = System.Windows.Forms.DockStyle.Fill
Me.gbBRRemont.Location = New System.Drawing.Point(3, 248)
Me.gbBRRemont.Name = "gbBRRemont"
Me.gbBRRemont.Size = New System.Drawing.Size(647, 363)
Me.gbBRRemont.TabIndex = 4
Me.gbBRRemont.TabStop = false
Me.gbBRRemont.Text = "Ремонты"
'
'lvRepairBR
'
Me.lvRepairBR.Dock = System.Windows.Forms.DockStyle.Fill
Me.lvRepairBR.FullRowSelect = true
Me.lvRepairBR.GridLines = true
Me.lvRepairBR.Location = New System.Drawing.Point(3, 16)
Me.lvRepairBR.MultiSelect = false
Me.lvRepairBR.Name = "lvRepairBR"
Me.lvRepairBR.ShowItemToolTips = true
Me.lvRepairBR.Size = New System.Drawing.Size(641, 344)
Me.lvRepairBR.TabIndex = 4
Me.lvRepairBR.UseCompatibleStateImageBehavior = false
Me.lvRepairBR.View = System.Windows.Forms.View.Details
'
'gbBRNotes
'
Me.gbBRNotes.Controls.Add(Me.TableLayoutPanel9)
Me.gbBRNotes.Dock = System.Windows.Forms.DockStyle.Fill
Me.gbBRNotes.Location = New System.Drawing.Point(3, 3)
Me.gbBRNotes.Name = "gbBRNotes"
Me.gbBRNotes.Size = New System.Drawing.Size(647, 239)
Me.gbBRNotes.TabIndex = 3
Me.gbBRNotes.TabStop = false
Me.gbBRNotes.Text = "Заметки"
'
'TableLayoutPanel9
'
Me.TableLayoutPanel9.ColumnCount = 3
Me.TableLayoutPanel9.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 126!))
Me.TableLayoutPanel9.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100!))
Me.TableLayoutPanel9.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120!))
Me.TableLayoutPanel9.Controls.Add(Me.ToolStrip3, 2, 0)
Me.TableLayoutPanel9.Controls.Add(Me.lvNotesBR, 0, 2)
Me.TableLayoutPanel9.Controls.Add(Me.Notesbrtxt, 0, 1)
Me.TableLayoutPanel9.Controls.Add(Me.cmbBRMaster, 1, 0)
Me.TableLayoutPanel9.Controls.Add(Me.Notesbrdate, 0, 0)
Me.TableLayoutPanel9.Dock = System.Windows.Forms.DockStyle.Fill
Me.TableLayoutPanel9.Location = New System.Drawing.Point(3, 16)
Me.TableLayoutPanel9.Name = "TableLayoutPanel9"
Me.TableLayoutPanel9.RowCount = 3
Me.TableLayoutPanel9.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25!))
Me.TableLayoutPanel9.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80!))
Me.TableLayoutPanel9.RowStyles.Add(New System.Windows.Forms.RowStyle())
Me.TableLayoutPanel9.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20!))
Me.TableLayoutPanel9.Size = New System.Drawing.Size(641, 220)
Me.TableLayoutPanel9.TabIndex = 1
'
'ToolStrip3
'
Me.ToolStrip3.Dock = System.Windows.Forms.DockStyle.Fill
Me.ToolStrip3.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
Me.ToolStrip3.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnBRNotesAdd, Me.ToolStripSeparator8, Me.btnBRNotesDel, Me.ToolStripSeparator9, Me.btnBRNotesCancel, Me.ToolStripSeparator10})
Me.ToolStrip3.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow
Me.ToolStrip3.Location = New System.Drawing.Point(521, 0)
Me.ToolStrip3.Name = "ToolStrip3"
Me.TableLayoutPanel9.SetRowSpan(Me.ToolStrip3, 2)
Me.ToolStrip3.Size = New System.Drawing.Size(120, 105)
Me.ToolStrip3.TabIndex = 10
Me.ToolStrip3.Text = "ToolStrip3"
'
'btnBRNotesAdd
'
Me.btnBRNotesAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
Me.btnBRNotesAdd.Image = CType(resources.GetObject("btnBRNotesAdd.Image"),System.Drawing.Image)
Me.btnBRNotesAdd.ImageTransparentColor = System.Drawing.Color.Magenta
Me.btnBRNotesAdd.Name = "btnBRNotesAdd"
Me.btnBRNotesAdd.Size = New System.Drawing.Size(118, 19)
Me.btnBRNotesAdd.Text = "Добавить"
'
'ToolStripSeparator8
'
Me.ToolStripSeparator8.Name = "ToolStripSeparator8"
Me.ToolStripSeparator8.Size = New System.Drawing.Size(118, 6)
'
'btnBRNotesDel
'
Me.btnBRNotesDel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
Me.btnBRNotesDel.Image = CType(resources.GetObject("btnBRNotesDel.Image"),System.Drawing.Image)
Me.btnBRNotesDel.ImageTransparentColor = System.Drawing.Color.Magenta
Me.btnBRNotesDel.Name = "btnBRNotesDel"
Me.btnBRNotesDel.Size = New System.Drawing.Size(118, 19)
Me.btnBRNotesDel.Text = "Удалить"
'
'ToolStripSeparator9
'
Me.ToolStripSeparator9.Name = "ToolStripSeparator9"
Me.ToolStripSeparator9.Size = New System.Drawing.Size(118, 6)
'
'btnBRNotesCancel
'
Me.btnBRNotesCancel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
Me.btnBRNotesCancel.Image = CType(resources.GetObject("btnBRNotesCancel.Image"),System.Drawing.Image)
Me.btnBRNotesCancel.ImageTransparentColor = System.Drawing.Color.Magenta
Me.btnBRNotesCancel.Name = "btnBRNotesCancel"
Me.btnBRNotesCancel.Size = New System.Drawing.Size(118, 19)
Me.btnBRNotesCancel.Text = "Отмена"
'
'ToolStripSeparator10
'
Me.ToolStripSeparator10.Name = "ToolStripSeparator10"
Me.ToolStripSeparator10.Size = New System.Drawing.Size(118, 6)
'
'lvNotesBR
'
Me.TableLayoutPanel9.SetColumnSpan(Me.lvNotesBR, 3)
Me.lvNotesBR.Dock = System.Windows.Forms.DockStyle.Fill
Me.lvNotesBR.FullRowSelect = true
Me.lvNotesBR.GridLines = true
Me.lvNotesBR.Location = New System.Drawing.Point(3, 108)
Me.lvNotesBR.Name = "lvNotesBR"
Me.lvNotesBR.Size = New System.Drawing.Size(635, 112)
Me.lvNotesBR.TabIndex = 4
Me.lvNotesBR.UseCompatibleStateImageBehavior = false
Me.lvNotesBR.View = System.Windows.Forms.View.Details
'
'Notesbrtxt
'
Me.TableLayoutPanel9.SetColumnSpan(Me.Notesbrtxt, 2)
Me.Notesbrtxt.Dock = System.Windows.Forms.DockStyle.Fill
Me.Notesbrtxt.Location = New System.Drawing.Point(3, 28)
Me.Notesbrtxt.Multiline = true
Me.Notesbrtxt.Name = "Notesbrtxt"
Me.Notesbrtxt.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
Me.Notesbrtxt.Size = New System.Drawing.Size(515, 74)
Me.Notesbrtxt.TabIndex = 3
'
'cmbBRMaster
'
Me.cmbBRMaster.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
Me.cmbBRMaster.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
Me.cmbBRMaster.Dock = System.Windows.Forms.DockStyle.Fill
Me.cmbBRMaster.FormattingEnabled = true
Me.cmbBRMaster.Location = New System.Drawing.Point(129, 3)
Me.cmbBRMaster.Name = "cmbBRMaster"
Me.cmbBRMaster.Size = New System.Drawing.Size(389, 21)
Me.cmbBRMaster.TabIndex = 2
'
'Notesbrdate
'
Me.Notesbrdate.Dock = System.Windows.Forms.DockStyle.Fill
Me.Notesbrdate.Location = New System.Drawing.Point(3, 3)
Me.Notesbrdate.Name = "Notesbrdate"
Me.Notesbrdate.Size = New System.Drawing.Size(120, 20)
Me.Notesbrdate.TabIndex = 1
'
'TabPage21
'
Me.TabPage21.Controls.Add(Me.TableLayoutPanel73)
Me.TabPage21.Location = New System.Drawing.Point(4, 22)
Me.TabPage21.Name = "TabPage21"
Me.TabPage21.Size = New System.Drawing.Size(659, 620)
Me.TabPage21.TabIndex = 2
Me.TabPage21.Text = "Санитарный паспорт"
Me.TabPage21.UseVisualStyleBackColor = true
'
'TableLayoutPanel73
'
Me.TableLayoutPanel73.ColumnCount = 4
Me.TableLayoutPanel73.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
Me.TableLayoutPanel73.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
Me.TableLayoutPanel73.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
Me.TableLayoutPanel73.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
Me.TableLayoutPanel73.Controls.Add(Me.Label82, 0, 0)
Me.TableLayoutPanel73.Controls.Add(Me.btnOfficeSend, 0, 11)
Me.TableLayoutPanel73.Controls.Add(Me.txtspplo, 1, 0)
Me.TableLayoutPanel73.Controls.Add(Me.txtSpMebel, 0, 10)
Me.TableLayoutPanel73.Controls.Add(Me.Label81, 2, 0)
Me.TableLayoutPanel73.Controls.Add(Me.Label71, 0, 9)
Me.TableLayoutPanel73.Controls.Add(Me.txtspvis, 3, 0)
Me.TableLayoutPanel73.Controls.Add(Me.txtSpWall, 0, 8)
Me.TableLayoutPanel73.Controls.Add(Me.Label80, 1, 1)
Me.TableLayoutPanel73.Controls.Add(Me.Label72, 0, 7)
Me.TableLayoutPanel73.Controls.Add(Me.txtspPloOneEVM, 2, 1)
Me.TableLayoutPanel73.Controls.Add(Me.cmbSpKanal, 3, 6)
Me.TableLayoutPanel73.Controls.Add(Me.Label79, 1, 2)
Me.TableLayoutPanel73.Controls.Add(Me.Label73, 2, 6)
Me.TableLayoutPanel73.Controls.Add(Me.txtspObOneEVM, 2, 2)
Me.TableLayoutPanel73.Controls.Add(Me.cmbSpWater, 1, 6)
Me.TableLayoutPanel73.Controls.Add(Me.cmbSpTeplo, 3, 5)
Me.TableLayoutPanel73.Controls.Add(Me.Label75, 0, 6)
Me.TableLayoutPanel73.Controls.Add(Me.Label78, 1, 3)
Me.TableLayoutPanel73.Controls.Add(Me.Label74, 2, 5)
Me.TableLayoutPanel73.Controls.Add(Me.cmbSpRemEVM, 2, 3)
Me.TableLayoutPanel73.Controls.Add(Me.Label77, 0, 4)
Me.TableLayoutPanel73.Controls.Add(Me.Label76, 0, 5)
Me.TableLayoutPanel73.Controls.Add(Me.cmbSpVent, 1, 5)
Me.TableLayoutPanel73.Dock = System.Windows.Forms.DockStyle.Fill
Me.TableLayoutPanel73.Location = New System.Drawing.Point(0, 0)
Me.TableLayoutPanel73.Name = "TableLayoutPanel73"
Me.TableLayoutPanel73.RowCount = 13
Me.TableLayoutPanel73.RowStyles.Add(New System.Windows.Forms.RowStyle())
Me.TableLayoutPanel73.RowStyles.Add(New System.Windows.Forms.RowStyle())
Me.TableLayoutPanel73.RowStyles.Add(New System.Windows.Forms.RowStyle())
Me.TableLayoutPanel73.RowStyles.Add(New System.Windows.Forms.RowStyle())
Me.TableLayoutPanel73.RowStyles.Add(New System.Windows.Forms.RowStyle())
Me.TableLayoutPanel73.RowStyles.Add(New System.Windows.Forms.RowStyle())
Me.TableLayoutPanel73.RowStyles.Add(New System.Windows.Forms.RowStyle())
Me.TableLayoutPanel73.RowStyles.Add(New System.Windows.Forms.RowStyle())
Me.TableLayoutPanel73.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100!))
Me.TableLayoutPanel73.RowStyles.Add(New System.Windows.Forms.RowStyle())
Me.TableLayoutPanel73.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100!))
Me.TableLayoutPanel73.RowStyles.Add(New System.Windows.Forms.RowStyle())
Me.TableLayoutPanel73.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100!))
Me.TableLayoutPanel73.Size = New System.Drawing.Size(659, 620)
Me.TableLayoutPanel73.TabIndex = 22
'
'Label82
'
Me.Label82.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
Me.Label82.AutoSize = true
Me.Label82.Location = New System.Drawing.Point(3, 6)
Me.Label82.Name = "Label82"
Me.Label82.Size = New System.Drawing.Size(119, 13)
Me.Label82.TabIndex = 0
Me.Label82.Text = "Площадь помещения:"
'
'btnOfficeSend
'
Me.btnOfficeSend.Location = New System.Drawing.Point(3, 401)
Me.btnOfficeSend.Name = "btnOfficeSend"
Me.btnOfficeSend.Size = New System.Drawing.Size(75, 23)
Me.btnOfficeSend.TabIndex = 12
Me.btnOfficeSend.Text = "В Офис"
Me.btnOfficeSend.UseVisualStyleBackColor = true
'
'txtspplo
'
Me.txtspplo.Dock = System.Windows.Forms.DockStyle.Fill
Me.txtspplo.Location = New System.Drawing.Point(128, 3)
Me.txtspplo.Name = "txtspplo"
Me.txtspplo.Size = New System.Drawing.Size(216, 20)
Me.txtspplo.TabIndex = 1
'
'txtSpMebel
'
Me.TableLayoutPanel73.SetColumnSpan(Me.txtSpMebel, 4)
Me.txtSpMebel.Dock = System.Windows.Forms.DockStyle.Fill
Me.txtSpMebel.Location = New System.Drawing.Point(3, 301)
Me.txtSpMebel.Multiline = true
Me.txtSpMebel.Name = "txtSpMebel"
Me.txtSpMebel.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
Me.txtSpMebel.Size = New System.Drawing.Size(653, 94)
Me.txtSpMebel.TabIndex = 11
'
'Label81
'
Me.Label81.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
Me.Label81.AutoSize = true
Me.Label81.Location = New System.Drawing.Point(350, 6)
Me.Label81.Name = "Label81"
Me.Label81.Size = New System.Drawing.Size(125, 13)
Me.Label81.TabIndex = 2
Me.Label81.Text = "Высота:"
'
'Label71
'
Me.Label71.AutoSize = true
Me.TableLayoutPanel73.SetColumnSpan(Me.Label71, 4)
Me.Label71.Location = New System.Drawing.Point(3, 285)
Me.Label71.Name = "Label71"
Me.Label71.Size = New System.Drawing.Size(529, 13)
Me.Label71.TabIndex = 21
Me.Label71.Text = "Оборудование рабочих мест мебелью соответствующей (не соответствующей) требования"& _ 
    "м САНПиН:"
'
'txtspvis
'
Me.txtspvis.Dock = System.Windows.Forms.DockStyle.Fill
Me.txtspvis.Location = New System.Drawing.Point(481, 3)
Me.txtspvis.Name = "txtspvis"
Me.txtspvis.Size = New System.Drawing.Size(175, 20)
Me.txtspvis.TabIndex = 2
'
'txtSpWall
'
Me.TableLayoutPanel73.SetColumnSpan(Me.txtSpWall, 4)
Me.txtSpWall.Dock = System.Windows.Forms.DockStyle.Fill
Me.txtSpWall.Location = New System.Drawing.Point(3, 188)
Me.txtSpWall.Multiline = true
Me.txtSpWall.Name = "txtSpWall"
Me.txtSpWall.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
Me.txtSpWall.Size = New System.Drawing.Size(653, 94)
Me.txtSpWall.TabIndex = 10
'
'Label80
'
Me.Label80.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
Me.Label80.AutoEllipsis = true
Me.Label80.AutoSize = true
Me.Label80.Location = New System.Drawing.Point(128, 32)
Me.Label80.Name = "Label80"
Me.Label80.Size = New System.Drawing.Size(216, 13)
Me.Label80.TabIndex = 4
Me.Label80.Text = "Площадь на одно рабочее место ПЭВМ:"
'
'Label72
'
Me.Label72.AutoSize = true
Me.TableLayoutPanel73.SetColumnSpan(Me.Label72, 4)
Me.Label72.Location = New System.Drawing.Point(3, 172)
Me.Label72.Name = "Label72"
Me.Label72.Size = New System.Drawing.Size(290, 13)
Me.Label72.TabIndex = 19
Me.Label72.Text = "Внутренняя отделка помещений (стен, потолков, пола):"
'
'txtspPloOneEVM
'
Me.txtspPloOneEVM.Dock = System.Windows.Forms.DockStyle.Fill
Me.txtspPloOneEVM.Location = New System.Drawing.Point(350, 29)
Me.txtspPloOneEVM.Name = "txtspPloOneEVM"
Me.txtspPloOneEVM.Size = New System.Drawing.Size(125, 20)
Me.txtspPloOneEVM.TabIndex = 3
'
'cmbSpKanal
'
Me.cmbSpKanal.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
Me.cmbSpKanal.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
Me.cmbSpKanal.Dock = System.Windows.Forms.DockStyle.Fill
Me.cmbSpKanal.FormattingEnabled = true
Me.cmbSpKanal.Items.AddRange(New Object() {"Да", "Нет"})
Me.cmbSpKanal.Location = New System.Drawing.Point(481, 148)
Me.cmbSpKanal.Name = "cmbSpKanal"
Me.cmbSpKanal.Size = New System.Drawing.Size(175, 21)
Me.cmbSpKanal.TabIndex = 9
'
'Label79
'
Me.Label79.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
Me.Label79.AutoEllipsis = true
Me.Label79.AutoSize = true
Me.Label79.Location = New System.Drawing.Point(128, 58)
Me.Label79.Name = "Label79"
Me.Label79.Size = New System.Drawing.Size(216, 13)
Me.Label79.TabIndex = 6
Me.Label79.Text = "Объем на одно рабочее место ПЭВМ:"
'
'Label73
'
Me.Label73.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
Me.Label73.AutoSize = true
Me.Label73.Location = New System.Drawing.Point(350, 152)
Me.Label73.Name = "Label73"
Me.Label73.Size = New System.Drawing.Size(125, 13)
Me.Label73.TabIndex = 17
Me.Label73.Text = "Канализация:"
'
'txtspObOneEVM
'
Me.txtspObOneEVM.Dock = System.Windows.Forms.DockStyle.Fill
Me.txtspObOneEVM.Location = New System.Drawing.Point(350, 55)
Me.txtspObOneEVM.Name = "txtspObOneEVM"
Me.txtspObOneEVM.Size = New System.Drawing.Size(125, 20)
Me.txtspObOneEVM.TabIndex = 4
'
'cmbSpWater
'
Me.cmbSpWater.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
Me.cmbSpWater.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
Me.cmbSpWater.Dock = System.Windows.Forms.DockStyle.Fill
Me.cmbSpWater.FormattingEnabled = true
Me.cmbSpWater.Items.AddRange(New Object() {"Да", "Нет"})
Me.cmbSpWater.Location = New System.Drawing.Point(128, 148)
Me.cmbSpWater.Name = "cmbSpWater"
Me.cmbSpWater.Size = New System.Drawing.Size(216, 21)
Me.cmbSpWater.TabIndex = 7
'
'cmbSpTeplo
'
Me.cmbSpTeplo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
Me.cmbSpTeplo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
Me.cmbSpTeplo.Dock = System.Windows.Forms.DockStyle.Fill
Me.cmbSpTeplo.FormattingEnabled = true
Me.cmbSpTeplo.Items.AddRange(New Object() {"Да", "Нет"})
Me.cmbSpTeplo.Location = New System.Drawing.Point(481, 121)
Me.cmbSpTeplo.Name = "cmbSpTeplo"
Me.cmbSpTeplo.Size = New System.Drawing.Size(175, 21)
Me.cmbSpTeplo.TabIndex = 8
'
'Label75
'
Me.Label75.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
Me.Label75.AutoSize = true
Me.Label75.Location = New System.Drawing.Point(3, 152)
Me.Label75.Name = "Label75"
Me.Label75.Size = New System.Drawing.Size(119, 13)
Me.Label75.TabIndex = 13
Me.Label75.Text = "Водоснабжение:"
'
'Label78
'
Me.Label78.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
Me.Label78.AutoEllipsis = true
Me.Label78.AutoSize = true
Me.Label78.Location = New System.Drawing.Point(128, 85)
Me.Label78.Name = "Label78"
Me.Label78.Size = New System.Drawing.Size(216, 13)
Me.Label78.TabIndex = 8
Me.Label78.Text = "Наличие помещений для ремонта ПЭВМ:"
'
'Label74
'
Me.Label74.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
Me.Label74.AutoSize = true
Me.Label74.Location = New System.Drawing.Point(350, 125)
Me.Label74.Name = "Label74"
Me.Label74.Size = New System.Drawing.Size(125, 13)
Me.Label74.TabIndex = 15
Me.Label74.Text = "Теплоснабжение:"
'
'cmbSpRemEVM
'
Me.cmbSpRemEVM.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
Me.cmbSpRemEVM.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
Me.cmbSpRemEVM.Dock = System.Windows.Forms.DockStyle.Fill
Me.cmbSpRemEVM.FormattingEnabled = true
Me.cmbSpRemEVM.Items.AddRange(New Object() {"Да", "Нет"})
Me.cmbSpRemEVM.Location = New System.Drawing.Point(350, 81)
Me.cmbSpRemEVM.Name = "cmbSpRemEVM"
Me.cmbSpRemEVM.Size = New System.Drawing.Size(125, 21)
Me.cmbSpRemEVM.TabIndex = 5
'
'Label77
'
Me.Label77.AutoSize = true
Me.TableLayoutPanel73.SetColumnSpan(Me.Label77, 4)
Me.Label77.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic),System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(204,Byte))
Me.Label77.Location = New System.Drawing.Point(3, 105)
Me.Label77.Name = "Label77"
Me.Label77.Size = New System.Drawing.Size(311, 13)
Me.Label77.TabIndex = 10
Me.Label77.Text = "Санитарно-техническое оборудование помещения:"
'
'Label76
'
Me.Label76.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
Me.Label76.AutoSize = true
Me.Label76.Location = New System.Drawing.Point(3, 125)
Me.Label76.Name = "Label76"
Me.Label76.Size = New System.Drawing.Size(119, 13)
Me.Label76.TabIndex = 11
Me.Label76.Text = "Вентиляция:"
'
'cmbSpVent
'
Me.cmbSpVent.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
Me.cmbSpVent.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
Me.cmbSpVent.Dock = System.Windows.Forms.DockStyle.Fill
Me.cmbSpVent.FormattingEnabled = true
Me.cmbSpVent.Items.AddRange(New Object() {"Да", "Нет"})
Me.cmbSpVent.Location = New System.Drawing.Point(128, 121)
Me.cmbSpVent.Name = "cmbSpVent"
Me.cmbSpVent.Size = New System.Drawing.Size(216, 21)
Me.cmbSpVent.TabIndex = 6
'
'sSTAB2
'
Me.sSTAB2.Controls.Add(Me.TabPage9)
Me.sSTAB2.Controls.Add(Me.TabPage23)
Me.sSTAB2.Controls.Add(Me.TabPage10)
Me.sSTAB2.Controls.Add(Me.TabPage16)
Me.sSTAB2.Dock = System.Windows.Forms.DockStyle.Fill
Me.sSTAB2.Location = New System.Drawing.Point(0, 0)
Me.sSTAB2.Name = "sSTAB2"
Me.sSTAB2.SelectedIndex = 0
Me.sSTAB2.Size = New System.Drawing.Size(667, 646)
Me.sSTAB2.TabIndex = 7
Me.sSTAB2.Visible = false
'
'TabPage9
'
Me.TabPage9.Controls.Add(Me.TableLayoutPanel21)
Me.TabPage9.Location = New System.Drawing.Point(4, 22)
Me.TabPage9.Name = "TabPage9"
Me.TabPage9.Padding = New System.Windows.Forms.Padding(3)
Me.TabPage9.Size = New System.Drawing.Size(659, 620)
Me.TabPage9.TabIndex = 0
Me.TabPage9.Text = "Информация"
Me.TabPage9.UseVisualStyleBackColor = true
'
'TableLayoutPanel21
'
Me.TableLayoutPanel21.ColumnCount = 4
Me.TableLayoutPanel21.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 128!))
Me.TableLayoutPanel21.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50!))
Me.TableLayoutPanel21.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 128!))
Me.TableLayoutPanel21.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50!))
Me.TableLayoutPanel21.Controls.Add(Me.gbPRNCartr, 0, 9)
Me.TableLayoutPanel21.Controls.Add(Me.txtPrnIP, 3, 5)
Me.TableLayoutPanel21.Controls.Add(Me.lblPrnIP, 2, 5)
Me.TableLayoutPanel21.Controls.Add(Me.cmbPRNotv, 1, 5)
Me.TableLayoutPanel21.Controls.Add(Me.lblPRNotv, 0, 5)
Me.TableLayoutPanel21.Controls.Add(Me.lblPRNPage, 3, 4)
Me.TableLayoutPanel21.Controls.Add(Me.lblPRNprintPage, 2, 4)
Me.TableLayoutPanel21.Controls.Add(Me.cmbPRNOffice, 1, 4)
Me.TableLayoutPanel21.Controls.Add(Me.lblPRNOffice, 0, 4)
Me.TableLayoutPanel21.Controls.Add(Me.cmbModCartr, 3, 3)
Me.TableLayoutPanel21.Controls.Add(Me.lblModCartr, 2, 3)
Me.TableLayoutPanel21.Controls.Add(Me.cmbPRNDepart, 1, 3)
Me.TableLayoutPanel21.Controls.Add(Me.lblPRNDepart, 0, 3)
Me.TableLayoutPanel21.Controls.Add(Me.cmbTIPCartridg, 3, 2)
Me.TableLayoutPanel21.Controls.Add(Me.lblTIPCartridg, 2, 2)
Me.TableLayoutPanel21.Controls.Add(Me.cmbPRNFil, 1, 2)
Me.TableLayoutPanel21.Controls.Add(Me.lblPRNFil, 0, 2)
Me.TableLayoutPanel21.Controls.Add(Me.txtPRNinnumber, 3, 1)
Me.TableLayoutPanel21.Controls.Add(Me.lblInNumber, 2, 1)
Me.TableLayoutPanel21.Controls.Add(Me.cmbFormat, 1, 1)
Me.TableLayoutPanel21.Controls.Add(Me.gbPRN, 0, 0)
Me.TableLayoutPanel21.Controls.Add(Me.lblFormat, 0, 1)
Me.TableLayoutPanel21.Controls.Add(Me.lblPRNphone, 0, 6)
Me.TableLayoutPanel21.Controls.Add(Me.txtPRNphone, 1, 6)
Me.TableLayoutPanel21.Controls.Add(Me.lblPrnMAC, 2, 6)
Me.TableLayoutPanel21.Controls.Add(Me.txtPRNMAC, 3, 6)
Me.TableLayoutPanel21.Controls.Add(Me.cmbPRNConnect, 1, 7)
Me.TableLayoutPanel21.Controls.Add(Me.lblPRNConnect, 0, 7)
Me.TableLayoutPanel21.Controls.Add(Me.Label83, 2, 7)
Me.TableLayoutPanel21.Controls.Add(Me.cmbPCL, 3, 7)
Me.TableLayoutPanel21.Controls.Add(Me.Label85, 0, 8)
Me.TableLayoutPanel21.Controls.Add(Me.lblSidPRN, 1, 8)
Me.TableLayoutPanel21.Controls.Add(Me.gbPRN_USTR, 0, 10)
Me.TableLayoutPanel21.Dock = System.Windows.Forms.DockStyle.Fill
Me.TableLayoutPanel21.Location = New System.Drawing.Point(3, 3)
Me.TableLayoutPanel21.Name = "TableLayoutPanel21"
Me.TableLayoutPanel21.RowCount = 11
Me.TableLayoutPanel21.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50!))
Me.TableLayoutPanel21.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26!))
Me.TableLayoutPanel21.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26!))
Me.TableLayoutPanel21.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26!))
Me.TableLayoutPanel21.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26!))
Me.TableLayoutPanel21.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26!))
Me.TableLayoutPanel21.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26!))
Me.TableLayoutPanel21.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26!))
Me.TableLayoutPanel21.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26!))
Me.TableLayoutPanel21.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100!))
Me.TableLayoutPanel21.RowStyles.Add(New System.Windows.Forms.RowStyle())
Me.TableLayoutPanel21.Size = New System.Drawing.Size(653, 614)
Me.TableLayoutPanel21.TabIndex = 45
'
'gbPRNCartr
'
Me.TableLayoutPanel21.SetColumnSpan(Me.gbPRNCartr, 4)
Me.gbPRNCartr.Controls.Add(Me.lvPRNCartr)
Me.gbPRNCartr.Dock = System.Windows.Forms.DockStyle.Fill
Me.gbPRNCartr.Location = New System.Drawing.Point(3, 261)
Me.gbPRNCartr.Name = "gbPRNCartr"
Me.gbPRNCartr.Size = New System.Drawing.Size(647, 179)
Me.gbPRNCartr.TabIndex = 72
Me.gbPRNCartr.TabStop = false
Me.gbPRNCartr.Text = "Обнаруженные картриджи"
'
'lvPRNCartr
'
Me.lvPRNCartr.Dock = System.Windows.Forms.DockStyle.Fill
Me.lvPRNCartr.FullRowSelect = true
Me.lvPRNCartr.GridLines = true
Me.lvPRNCartr.HideSelection = false
Me.lvPRNCartr.Location = New System.Drawing.Point(3, 16)
Me.lvPRNCartr.MultiSelect = false
Me.lvPRNCartr.Name = "lvPRNCartr"
Me.lvPRNCartr.Size = New System.Drawing.Size(641, 160)
Me.lvPRNCartr.TabIndex = 0
Me.lvPRNCartr.UseCompatibleStateImageBehavior = false
Me.lvPRNCartr.View = System.Windows.Forms.View.Details
'
'txtPrnIP
'
Me.txtPrnIP.Dock = System.Windows.Forms.DockStyle.Fill
Me.txtPrnIP.Location = New System.Drawing.Point(457, 157)
Me.txtPrnIP.Name = "txtPrnIP"
Me.txtPrnIP.Size = New System.Drawing.Size(193, 20)
Me.txtPrnIP.TabIndex = 63
'
'lblPrnIP
'
Me.lblPrnIP.Anchor = System.Windows.Forms.AnchorStyles.Left
Me.lblPrnIP.AutoSize = true
Me.lblPrnIP.Location = New System.Drawing.Point(329, 160)
Me.lblPrnIP.Name = "lblPrnIP"
Me.lblPrnIP.Size = New System.Drawing.Size(20, 13)
Me.lblPrnIP.TabIndex = 62
Me.lblPrnIP.Text = "IP:"
'
'cmbPRNotv
'
Me.cmbPRNotv.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
Me.cmbPRNotv.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
Me.cmbPRNotv.Dock = System.Windows.Forms.DockStyle.Fill
Me.cmbPRNotv.FormattingEnabled = true
Me.cmbPRNotv.Location = New System.Drawing.Point(131, 157)
Me.cmbPRNotv.Name = "cmbPRNotv"
Me.cmbPRNotv.Size = New System.Drawing.Size(192, 21)
Me.cmbPRNotv.TabIndex = 61
'
'lblPRNotv
'
Me.lblPRNotv.Anchor = System.Windows.Forms.AnchorStyles.Left
Me.lblPRNotv.AutoSize = true
Me.lblPRNotv.Location = New System.Drawing.Point(3, 160)
Me.lblPRNotv.Name = "lblPRNotv"
Me.lblPRNotv.Size = New System.Drawing.Size(89, 13)
Me.lblPRNotv.TabIndex = 60
Me.lblPRNotv.Text = "Ответственный:"
'
'lblPRNPage
'
Me.lblPRNPage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
Me.lblPRNPage.Dock = System.Windows.Forms.DockStyle.Fill
Me.lblPRNPage.Location = New System.Drawing.Point(457, 128)
Me.lblPRNPage.Name = "lblPRNPage"
Me.lblPRNPage.Size = New System.Drawing.Size(193, 26)
Me.lblPRNPage.TabIndex = 59
'
'lblPRNprintPage
'
Me.lblPRNprintPage.Anchor = System.Windows.Forms.AnchorStyles.Left
Me.lblPRNprintPage.AutoSize = true
Me.lblPRNprintPage.Location = New System.Drawing.Point(329, 134)
Me.lblPRNprintPage.Name = "lblPRNprintPage"
Me.lblPRNprintPage.Size = New System.Drawing.Size(113, 13)
Me.lblPRNprintPage.TabIndex = 58
Me.lblPRNprintPage.Text = "Отпечатано страниц:"
'
'cmbPRNOffice
'
Me.cmbPRNOffice.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
Me.cmbPRNOffice.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
Me.cmbPRNOffice.Dock = System.Windows.Forms.DockStyle.Fill
Me.cmbPRNOffice.FormattingEnabled = true
Me.cmbPRNOffice.Location = New System.Drawing.Point(131, 131)
Me.cmbPRNOffice.Name = "cmbPRNOffice"
Me.cmbPRNOffice.Size = New System.Drawing.Size(192, 21)
Me.cmbPRNOffice.TabIndex = 57
'
'lblPRNOffice
'
Me.lblPRNOffice.Anchor = System.Windows.Forms.AnchorStyles.Left
Me.lblPRNOffice.AutoSize = true
Me.lblPRNOffice.Location = New System.Drawing.Point(3, 134)
Me.lblPRNOffice.Name = "lblPRNOffice"
Me.lblPRNOffice.Size = New System.Drawing.Size(52, 13)
Me.lblPRNOffice.TabIndex = 56
Me.lblPRNOffice.Text = "Кабинет:"
'
'cmbModCartr
'
Me.cmbModCartr.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
Me.cmbModCartr.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
Me.cmbModCartr.Dock = System.Windows.Forms.DockStyle.Fill
Me.cmbModCartr.FormattingEnabled = true
Me.cmbModCartr.Location = New System.Drawing.Point(457, 105)
Me.cmbModCartr.Name = "cmbModCartr"
Me.cmbModCartr.Size = New System.Drawing.Size(193, 21)
Me.cmbModCartr.TabIndex = 55
'
'lblModCartr
'
Me.lblModCartr.Anchor = System.Windows.Forms.AnchorStyles.Left
Me.lblModCartr.AutoSize = true
Me.lblModCartr.Location = New System.Drawing.Point(329, 108)
Me.lblModCartr.Name = "lblModCartr"
Me.lblModCartr.Size = New System.Drawing.Size(104, 13)
Me.lblModCartr.TabIndex = 54
Me.lblModCartr.Text = "Модель картриджа"
'
'cmbPRNDepart
'
Me.cmbPRNDepart.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
Me.cmbPRNDepart.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
Me.cmbPRNDepart.Dock = System.Windows.Forms.DockStyle.Fill
Me.cmbPRNDepart.FormattingEnabled = true
Me.cmbPRNDepart.Location = New System.Drawing.Point(131, 105)
Me.cmbPRNDepart.Name = "cmbPRNDepart"
Me.cmbPRNDepart.Size = New System.Drawing.Size(192, 21)
Me.cmbPRNDepart.TabIndex = 53
'
'lblPRNDepart
'
Me.lblPRNDepart.Anchor = System.Windows.Forms.AnchorStyles.Left
Me.lblPRNDepart.AutoSize = true
Me.lblPRNDepart.Location = New System.Drawing.Point(3, 108)
Me.lblPRNDepart.Name = "lblPRNDepart"
Me.lblPRNDepart.Size = New System.Drawing.Size(41, 13)
Me.lblPRNDepart.TabIndex = 52
Me.lblPRNDepart.Text = "Отдел:"
'
'cmbTIPCartridg
'
Me.cmbTIPCartridg.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
Me.cmbTIPCartridg.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
Me.cmbTIPCartridg.Dock = System.Windows.Forms.DockStyle.Fill
Me.cmbTIPCartridg.FormattingEnabled = true
Me.cmbTIPCartridg.Location = New System.Drawing.Point(457, 79)
Me.cmbTIPCartridg.Name = "cmbTIPCartridg"
Me.cmbTIPCartridg.Size = New System.Drawing.Size(193, 21)
Me.cmbTIPCartridg.TabIndex = 51
'
'lblTIPCartridg
'
Me.lblTIPCartridg.Anchor = System.Windows.Forms.AnchorStyles.Left
Me.lblTIPCartridg.AutoSize = true
Me.lblTIPCartridg.Location = New System.Drawing.Point(329, 82)
Me.lblTIPCartridg.Name = "lblTIPCartridg"
Me.lblTIPCartridg.Size = New System.Drawing.Size(87, 13)
Me.lblTIPCartridg.TabIndex = 50
Me.lblTIPCartridg.Text = "Тип картриджа:"
'
'cmbPRNFil
'
Me.cmbPRNFil.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
Me.cmbPRNFil.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
Me.cmbPRNFil.Dock = System.Windows.Forms.DockStyle.Fill
Me.cmbPRNFil.FormattingEnabled = true
Me.cmbPRNFil.Location = New System.Drawing.Point(131, 79)
Me.cmbPRNFil.Name = "cmbPRNFil"
Me.cmbPRNFil.Size = New System.Drawing.Size(192, 21)
Me.cmbPRNFil.TabIndex = 49
'
'lblPRNFil
'
Me.lblPRNFil.Anchor = System.Windows.Forms.AnchorStyles.Left
Me.lblPRNFil.AutoSize = true
Me.lblPRNFil.Location = New System.Drawing.Point(3, 82)
Me.lblPRNFil.Name = "lblPRNFil"
Me.lblPRNFil.Size = New System.Drawing.Size(57, 13)
Me.lblPRNFil.TabIndex = 48
Me.lblPRNFil.Text = "Филилал:"
'
'txtPRNinnumber
'
Me.txtPRNinnumber.Dock = System.Windows.Forms.DockStyle.Fill
Me.txtPRNinnumber.Location = New System.Drawing.Point(457, 53)
Me.txtPRNinnumber.Name = "txtPRNinnumber"
Me.txtPRNinnumber.Size = New System.Drawing.Size(193, 20)
Me.txtPRNinnumber.TabIndex = 47
'
'lblInNumber
'
Me.lblInNumber.Anchor = System.Windows.Forms.AnchorStyles.Left
Me.lblInNumber.AutoSize = true
Me.lblInNumber.Location = New System.Drawing.Point(329, 56)
Me.lblInNumber.Name = "lblInNumber"
Me.lblInNumber.Size = New System.Drawing.Size(111, 13)
Me.lblInNumber.TabIndex = 46
Me.lblInNumber.Text = "Инвентарный номер"
'
'cmbFormat
'
Me.cmbFormat.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
Me.cmbFormat.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
Me.cmbFormat.Dock = System.Windows.Forms.DockStyle.Fill
Me.cmbFormat.FormattingEnabled = true
Me.cmbFormat.Items.AddRange(New Object() {"A1", "A2", "A3", "A4"})
Me.cmbFormat.Location = New System.Drawing.Point(131, 53)
Me.cmbFormat.Name = "cmbFormat"
Me.cmbFormat.Size = New System.Drawing.Size(192, 21)
Me.cmbFormat.TabIndex = 45
'
'gbPRN
'
Me.TableLayoutPanel21.SetColumnSpan(Me.gbPRN, 4)
Me.gbPRN.Controls.Add(Me.TableLayoutPanel55)
Me.gbPRN.Dock = System.Windows.Forms.DockStyle.Fill
Me.gbPRN.Location = New System.Drawing.Point(3, 3)
Me.gbPRN.Name = "gbPRN"
Me.gbPRN.Size = New System.Drawing.Size(647, 44)
Me.gbPRN.TabIndex = 29
Me.gbPRN.TabStop = false
Me.gbPRN.Text = "Информация"
'
'TableLayoutPanel55
'
Me.TableLayoutPanel55.ColumnCount = 4
Me.TableLayoutPanel55.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70!))
Me.TableLayoutPanel55.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100!))
Me.TableLayoutPanel55.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100!))
Me.TableLayoutPanel55.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30!))
Me.TableLayoutPanel55.Controls.Add(Me.PROiZV38, 3, 0)
Me.TableLayoutPanel55.Controls.Add(Me.cmbPRN, 0, 0)
Me.TableLayoutPanel55.Controls.Add(Me.txtPRNSN, 1, 0)
Me.TableLayoutPanel55.Dock = System.Windows.Forms.DockStyle.Fill
Me.TableLayoutPanel55.Location = New System.Drawing.Point(3, 16)
Me.TableLayoutPanel55.Name = "TableLayoutPanel55"
Me.TableLayoutPanel55.RowCount = 1
Me.TableLayoutPanel55.RowStyles.Add(New System.Windows.Forms.RowStyle())
Me.TableLayoutPanel55.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27!))
Me.TableLayoutPanel55.Size = New System.Drawing.Size(641, 25)
Me.TableLayoutPanel55.TabIndex = 5
'
'PROiZV38
'
Me.PROiZV38.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
Me.PROiZV38.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
Me.PROiZV38.Dock = System.Windows.Forms.DockStyle.Fill
Me.PROiZV38.FormattingEnabled = true
Me.PROiZV38.Location = New System.Drawing.Point(511, 3)
Me.PROiZV38.Name = "PROiZV38"
Me.PROiZV38.Size = New System.Drawing.Size(127, 21)
Me.PROiZV38.TabIndex = 7
'
'cmbPRN
'
Me.cmbPRN.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
Me.cmbPRN.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
Me.cmbPRN.Dock = System.Windows.Forms.DockStyle.Fill
Me.cmbPRN.FormattingEnabled = true
Me.cmbPRN.Location = New System.Drawing.Point(3, 3)
Me.cmbPRN.Name = "cmbPRN"
Me.cmbPRN.Size = New System.Drawing.Size(302, 21)
Me.cmbPRN.TabIndex = 5
'
'txtPRNSN
'
Me.TableLayoutPanel55.SetColumnSpan(Me.txtPRNSN, 2)
Me.txtPRNSN.Dock = System.Windows.Forms.DockStyle.Fill
Me.txtPRNSN.Location = New System.Drawing.Point(311, 3)
Me.txtPRNSN.Name = "txtPRNSN"
Me.txtPRNSN.Size = New System.Drawing.Size(194, 20)
Me.txtPRNSN.TabIndex = 6
'
'lblFormat
'
Me.lblFormat.Anchor = System.Windows.Forms.AnchorStyles.Left
Me.lblFormat.AutoSize = true
Me.lblFormat.Location = New System.Drawing.Point(3, 56)
Me.lblFormat.Name = "lblFormat"
Me.lblFormat.Size = New System.Drawing.Size(52, 13)
Me.lblFormat.TabIndex = 31
Me.lblFormat.Text = "Формат:"
'
'lblPRNphone
'
Me.lblPRNphone.Anchor = System.Windows.Forms.AnchorStyles.Left
Me.lblPRNphone.AutoSize = true
Me.lblPRNphone.Location = New System.Drawing.Point(3, 186)
Me.lblPRNphone.Name = "lblPRNphone"
Me.lblPRNphone.Size = New System.Drawing.Size(55, 13)
Me.lblPRNphone.TabIndex = 64
Me.lblPRNphone.Text = "Телефон:"
'
'txtPRNphone
'
Me.txtPRNphone.Dock = System.Windows.Forms.DockStyle.Fill
Me.txtPRNphone.Location = New System.Drawing.Point(131, 183)
Me.txtPRNphone.Name = "txtPRNphone"
Me.txtPRNphone.Size = New System.Drawing.Size(192, 20)
Me.txtPRNphone.TabIndex = 65
'
'lblPrnMAC
'
Me.lblPrnMAC.Anchor = System.Windows.Forms.AnchorStyles.Left
Me.lblPrnMAC.AutoSize = true
Me.lblPrnMAC.Location = New System.Drawing.Point(329, 186)
Me.lblPrnMAC.Name = "lblPrnMAC"
Me.lblPrnMAC.Size = New System.Drawing.Size(33, 13)
Me.lblPrnMAC.TabIndex = 66
Me.lblPrnMAC.Text = "MAC:"
'
'txtPRNMAC
'
Me.txtPRNMAC.Dock = System.Windows.Forms.DockStyle.Fill
Me.txtPRNMAC.Location = New System.Drawing.Point(457, 183)
Me.txtPRNMAC.Name = "txtPRNMAC"
Me.txtPRNMAC.Size = New System.Drawing.Size(193, 20)
Me.txtPRNMAC.TabIndex = 67
'
'cmbPRNConnect
'
Me.cmbPRNConnect.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
Me.cmbPRNConnect.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
Me.cmbPRNConnect.Dock = System.Windows.Forms.DockStyle.Fill
Me.cmbPRNConnect.FormattingEnabled = true
Me.cmbPRNConnect.Location = New System.Drawing.Point(131, 209)
Me.cmbPRNConnect.Name = "cmbPRNConnect"
Me.cmbPRNConnect.Size = New System.Drawing.Size(192, 21)
Me.cmbPRNConnect.TabIndex = 69
'
'lblPRNConnect
'
Me.lblPRNConnect.Anchor = System.Windows.Forms.AnchorStyles.Left
Me.lblPRNConnect.AutoSize = true
Me.lblPRNConnect.Location = New System.Drawing.Point(3, 212)
Me.lblPRNConnect.Name = "lblPRNConnect"
Me.lblPRNConnect.Size = New System.Drawing.Size(79, 13)
Me.lblPRNConnect.TabIndex = 68
Me.lblPRNConnect.Text = "Подключение:"
'
'Label83
'
Me.Label83.Anchor = System.Windows.Forms.AnchorStyles.Left
Me.Label83.AutoSize = true
Me.Label83.Location = New System.Drawing.Point(329, 212)
Me.Label83.Name = "Label83"
Me.Label83.Size = New System.Drawing.Size(121, 13)
Me.Label83.TabIndex = 70
Me.Label83.Text = "В составе устройства:"
'
'cmbPCL
'
Me.cmbPCL.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
Me.cmbPCL.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
Me.cmbPCL.Dock = System.Windows.Forms.DockStyle.Fill
Me.cmbPCL.FormattingEnabled = true
Me.cmbPCL.Location = New System.Drawing.Point(457, 209)
Me.cmbPCL.Name = "cmbPCL"
Me.cmbPCL.Size = New System.Drawing.Size(193, 21)
Me.cmbPCL.TabIndex = 71
'
'Label85
'
Me.Label85.Anchor = System.Windows.Forms.AnchorStyles.Left
Me.Label85.AutoSize = true
Me.Label85.Location = New System.Drawing.Point(3, 238)
Me.Label85.Name = "Label85"
Me.Label85.Size = New System.Drawing.Size(54, 13)
Me.Label85.TabIndex = 73
Me.Label85.Text = "№ в базе"
'
'lblSidPRN
'
Me.lblSidPRN.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
Me.lblSidPRN.AutoSize = true
Me.lblSidPRN.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
Me.lblSidPRN.Location = New System.Drawing.Point(131, 237)
Me.lblSidPRN.Name = "lblSidPRN"
Me.lblSidPRN.Size = New System.Drawing.Size(192, 16)
Me.lblSidPRN.TabIndex = 74
'
'gbPRN_USTR
'
Me.TableLayoutPanel21.SetColumnSpan(Me.gbPRN_USTR, 4)
Me.gbPRN_USTR.Controls.Add(Me.lvUSTR_PRINT)
Me.gbPRN_USTR.Dock = System.Windows.Forms.DockStyle.Fill
Me.gbPRN_USTR.Location = New System.Drawing.Point(3, 446)
Me.gbPRN_USTR.Name = "gbPRN_USTR"
Me.gbPRN_USTR.Size = New System.Drawing.Size(647, 165)
Me.gbPRN_USTR.TabIndex = 75
Me.gbPRN_USTR.TabStop = false
Me.gbPRN_USTR.Text = "Устройства использующие данный ресурс "
'
'lvUSTR_PRINT
'
Me.lvUSTR_PRINT.Dock = System.Windows.Forms.DockStyle.Fill
Me.lvUSTR_PRINT.FullRowSelect = true
Me.lvUSTR_PRINT.GridLines = true
Me.lvUSTR_PRINT.HideSelection = false
Me.lvUSTR_PRINT.Location = New System.Drawing.Point(3, 16)
Me.lvUSTR_PRINT.MultiSelect = false
Me.lvUSTR_PRINT.Name = "lvUSTR_PRINT"
Me.lvUSTR_PRINT.Size = New System.Drawing.Size(641, 146)
Me.lvUSTR_PRINT.TabIndex = 1
Me.lvUSTR_PRINT.UseCompatibleStateImageBehavior = false
Me.lvUSTR_PRINT.View = System.Windows.Forms.View.Details
'
'TabPage23
'
Me.TabPage23.Controls.Add(Me.lvMovementPRN)
Me.TabPage23.Location = New System.Drawing.Point(4, 22)
Me.TabPage23.Name = "TabPage23"
Me.TabPage23.Size = New System.Drawing.Size(659, 620)
Me.TabPage23.TabIndex = 3
Me.TabPage23.Text = "Движение"
Me.TabPage23.UseVisualStyleBackColor = true
'
'lvMovementPRN
'
Me.lvMovementPRN.Dock = System.Windows.Forms.DockStyle.Fill
Me.lvMovementPRN.FullRowSelect = true
Me.lvMovementPRN.GridLines = true
Me.lvMovementPRN.Location = New System.Drawing.Point(0, 0)
Me.lvMovementPRN.MultiSelect = false
Me.lvMovementPRN.Name = "lvMovementPRN"
Me.lvMovementPRN.Size = New System.Drawing.Size(659, 620)
Me.lvMovementPRN.TabIndex = 1
Me.lvMovementPRN.UseCompatibleStateImageBehavior = false
Me.lvMovementPRN.View = System.Windows.Forms.View.Details
'
'TabPage10
'
Me.TabPage10.Controls.Add(Me.TableLayoutPanel11)
Me.TabPage10.Location = New System.Drawing.Point(4, 22)
Me.TabPage10.Name = "TabPage10"
Me.TabPage10.Padding = New System.Windows.Forms.Padding(3)
Me.TabPage10.Size = New System.Drawing.Size(659, 620)
Me.TabPage10.TabIndex = 1
Me.TabPage10.Text = "Сервис"
Me.TabPage10.UseVisualStyleBackColor = true
'
'TableLayoutPanel11
'
Me.TableLayoutPanel11.ColumnCount = 1
Me.TableLayoutPanel11.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100!))
Me.TableLayoutPanel11.Controls.Add(Me.gbPRNRemont, 0, 1)
Me.TableLayoutPanel11.Controls.Add(Me.gbPRNNotes, 0, 0)
Me.TableLayoutPanel11.Dock = System.Windows.Forms.DockStyle.Fill
Me.TableLayoutPanel11.Location = New System.Drawing.Point(3, 3)
Me.TableLayoutPanel11.Name = "TableLayoutPanel11"
Me.TableLayoutPanel11.RowCount = 2
Me.TableLayoutPanel11.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40!))
Me.TableLayoutPanel11.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60!))
Me.TableLayoutPanel11.Size = New System.Drawing.Size(653, 614)
Me.TableLayoutPanel11.TabIndex = 7
'
'gbPRNRemont
'
Me.gbPRNRemont.Controls.Add(Me.lvRepairPRN)
Me.gbPRNRemont.Dock = System.Windows.Forms.DockStyle.Fill
Me.gbPRNRemont.Location = New System.Drawing.Point(3, 248)
Me.gbPRNRemont.Name = "gbPRNRemont"
Me.gbPRNRemont.Size = New System.Drawing.Size(647, 363)
Me.gbPRNRemont.TabIndex = 4
Me.gbPRNRemont.TabStop = false
Me.gbPRNRemont.Text = "Ремонты"
'
'lvRepairPRN
'
Me.lvRepairPRN.Dock = System.Windows.Forms.DockStyle.Fill
Me.lvRepairPRN.FullRowSelect = true
Me.lvRepairPRN.GridLines = true
Me.lvRepairPRN.Location = New System.Drawing.Point(3, 16)
Me.lvRepairPRN.MultiSelect = false
Me.lvRepairPRN.Name = "lvRepairPRN"
Me.lvRepairPRN.ShowItemToolTips = true
Me.lvRepairPRN.Size = New System.Drawing.Size(641, 344)
Me.lvRepairPRN.TabIndex = 4
Me.lvRepairPRN.UseCompatibleStateImageBehavior = false
Me.lvRepairPRN.View = System.Windows.Forms.View.Details
'
'gbPRNNotes
'
Me.gbPRNNotes.Controls.Add(Me.TableLayoutPanel12)
Me.gbPRNNotes.Dock = System.Windows.Forms.DockStyle.Fill
Me.gbPRNNotes.Location = New System.Drawing.Point(3, 3)
Me.gbPRNNotes.Name = "gbPRNNotes"
Me.gbPRNNotes.Size = New System.Drawing.Size(647, 239)
Me.gbPRNNotes.TabIndex = 3
Me.gbPRNNotes.TabStop = false
Me.gbPRNNotes.Text = "Заметки"
'
'TableLayoutPanel12
'
Me.TableLayoutPanel12.ColumnCount = 3
Me.TableLayoutPanel12.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 126!))
Me.TableLayoutPanel12.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100!))
Me.TableLayoutPanel12.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120!))
Me.TableLayoutPanel12.Controls.Add(Me.ToolStrip4, 2, 0)
Me.TableLayoutPanel12.Controls.Add(Me.lvNotesPRN, 0, 2)
Me.TableLayoutPanel12.Controls.Add(Me.NotesPRNtxt, 0, 1)
Me.TableLayoutPanel12.Controls.Add(Me.cmbNotesPRNMaster, 1, 0)
Me.TableLayoutPanel12.Controls.Add(Me.NotesPRNdate, 0, 0)
Me.TableLayoutPanel12.Dock = System.Windows.Forms.DockStyle.Fill
Me.TableLayoutPanel12.Location = New System.Drawing.Point(3, 16)
Me.TableLayoutPanel12.Name = "TableLayoutPanel12"
Me.TableLayoutPanel12.RowCount = 3
Me.TableLayoutPanel12.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25!))
Me.TableLayoutPanel12.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80!))
Me.TableLayoutPanel12.RowStyles.Add(New System.Windows.Forms.RowStyle())
Me.TableLayoutPanel12.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20!))
Me.TableLayoutPanel12.Size = New System.Drawing.Size(641, 220)
Me.TableLayoutPanel12.TabIndex = 1
'
'ToolStrip4
'
Me.ToolStrip4.Dock = System.Windows.Forms.DockStyle.Fill
Me.ToolStrip4.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
Me.ToolStrip4.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnPRNNotesAdd, Me.ToolStripSeparator11, Me.btnPRNNotesDel, Me.ToolStripSeparator12, Me.btnPRNNotesCancel, Me.ToolStripSeparator13})
Me.ToolStrip4.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow
Me.ToolStrip4.Location = New System.Drawing.Point(521, 0)
Me.ToolStrip4.Name = "ToolStrip4"
Me.TableLayoutPanel12.SetRowSpan(Me.ToolStrip4, 2)
Me.ToolStrip4.Size = New System.Drawing.Size(120, 105)
Me.ToolStrip4.TabIndex = 12
Me.ToolStrip4.Text = "ToolStrip4"
'
'btnPRNNotesAdd
'
Me.btnPRNNotesAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
Me.btnPRNNotesAdd.Image = CType(resources.GetObject("btnPRNNotesAdd.Image"),System.Drawing.Image)
Me.btnPRNNotesAdd.ImageTransparentColor = System.Drawing.Color.Magenta
Me.btnPRNNotesAdd.Name = "btnPRNNotesAdd"
Me.btnPRNNotesAdd.Size = New System.Drawing.Size(118, 19)
Me.btnPRNNotesAdd.Text = "Добавить"
'
'ToolStripSeparator11
'
Me.ToolStripSeparator11.Name = "ToolStripSeparator11"
Me.ToolStripSeparator11.Size = New System.Drawing.Size(118, 6)
'
'btnPRNNotesDel
'
Me.btnPRNNotesDel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
Me.btnPRNNotesDel.Image = CType(resources.GetObject("btnPRNNotesDel.Image"),System.Drawing.Image)
Me.btnPRNNotesDel.ImageTransparentColor = System.Drawing.Color.Magenta
Me.btnPRNNotesDel.Name = "btnPRNNotesDel"
Me.btnPRNNotesDel.Size = New System.Drawing.Size(118, 19)
Me.btnPRNNotesDel.Text = "Удалить"
'
'ToolStripSeparator12
'
Me.ToolStripSeparator12.Name = "ToolStripSeparator12"
Me.ToolStripSeparator12.Size = New System.Drawing.Size(118, 6)
'
'btnPRNNotesCancel
'
Me.btnPRNNotesCancel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
Me.btnPRNNotesCancel.Image = CType(resources.GetObject("btnPRNNotesCancel.Image"),System.Drawing.Image)
Me.btnPRNNotesCancel.ImageTransparentColor = System.Drawing.Color.Magenta
Me.btnPRNNotesCancel.Name = "btnPRNNotesCancel"
Me.btnPRNNotesCancel.Size = New System.Drawing.Size(118, 19)
Me.btnPRNNotesCancel.Text = "Отмена"
'
'ToolStripSeparator13
'
Me.ToolStripSeparator13.Name = "ToolStripSeparator13"
Me.ToolStripSeparator13.Size = New System.Drawing.Size(118, 6)
'
'lvNotesPRN
'
Me.TableLayoutPanel12.SetColumnSpan(Me.lvNotesPRN, 3)
Me.lvNotesPRN.Dock = System.Windows.Forms.DockStyle.Fill
Me.lvNotesPRN.FullRowSelect = true
Me.lvNotesPRN.GridLines = true
Me.lvNotesPRN.Location = New System.Drawing.Point(3, 108)
Me.lvNotesPRN.Name = "lvNotesPRN"
Me.lvNotesPRN.Size = New System.Drawing.Size(635, 109)
Me.lvNotesPRN.TabIndex = 4
Me.lvNotesPRN.UseCompatibleStateImageBehavior = false
Me.lvNotesPRN.View = System.Windows.Forms.View.Details
'
'NotesPRNtxt
'
Me.TableLayoutPanel12.SetColumnSpan(Me.NotesPRNtxt, 2)
Me.NotesPRNtxt.Dock = System.Windows.Forms.DockStyle.Fill
Me.NotesPRNtxt.Location = New System.Drawing.Point(3, 28)
Me.NotesPRNtxt.Multiline = true
Me.NotesPRNtxt.Name = "NotesPRNtxt"
Me.NotesPRNtxt.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
Me.NotesPRNtxt.Size = New System.Drawing.Size(515, 74)
Me.NotesPRNtxt.TabIndex = 3
'
'cmbNotesPRNMaster
'
Me.cmbNotesPRNMaster.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
Me.cmbNotesPRNMaster.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
Me.cmbNotesPRNMaster.Dock = System.Windows.Forms.DockStyle.Fill
Me.cmbNotesPRNMaster.FormattingEnabled = true
Me.cmbNotesPRNMaster.Location = New System.Drawing.Point(129, 3)
Me.cmbNotesPRNMaster.Name = "cmbNotesPRNMaster"
Me.cmbNotesPRNMaster.Size = New System.Drawing.Size(389, 21)
Me.cmbNotesPRNMaster.TabIndex = 2
'
'NotesPRNdate
'
Me.NotesPRNdate.Dock = System.Windows.Forms.DockStyle.Fill
Me.NotesPRNdate.Location = New System.Drawing.Point(3, 3)
Me.NotesPRNdate.Name = "NotesPRNdate"
Me.NotesPRNdate.Size = New System.Drawing.Size(120, 20)
Me.NotesPRNdate.TabIndex = 1
'
'TabPage16
'
Me.TabPage16.Controls.Add(Me.TableLayoutPanel67)
Me.TabPage16.Location = New System.Drawing.Point(4, 22)
Me.TabPage16.Name = "TabPage16"
Me.TabPage16.Size = New System.Drawing.Size(659, 620)
Me.TabPage16.TabIndex = 2
Me.TabPage16.Text = "Гарантия"
Me.TabPage16.UseVisualStyleBackColor = true
'
'TableLayoutPanel67
'
Me.TableLayoutPanel67.ColumnCount = 1
Me.TableLayoutPanel67.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100!))
Me.TableLayoutPanel67.Controls.Add(Me.gbPostPRN, 0, 0)
Me.TableLayoutPanel67.Controls.Add(Me.gbSalePRN, 0, 1)
Me.TableLayoutPanel67.Dock = System.Windows.Forms.DockStyle.Fill
Me.TableLayoutPanel67.Location = New System.Drawing.Point(0, 0)
Me.TableLayoutPanel67.Name = "TableLayoutPanel67"
Me.TableLayoutPanel67.RowCount = 3
Me.TableLayoutPanel67.RowStyles.Add(New System.Windows.Forms.RowStyle())
Me.TableLayoutPanel67.RowStyles.Add(New System.Windows.Forms.RowStyle())
Me.TableLayoutPanel67.RowStyles.Add(New System.Windows.Forms.RowStyle())
Me.TableLayoutPanel67.Size = New System.Drawing.Size(659, 620)
Me.TableLayoutPanel67.TabIndex = 2
'
'gbPostPRN
'
Me.gbPostPRN.Controls.Add(Me.TableLayoutPanel57)
Me.gbPostPRN.Dock = System.Windows.Forms.DockStyle.Fill
Me.gbPostPRN.Location = New System.Drawing.Point(3, 3)
Me.gbPostPRN.Name = "gbPostPRN"
Me.gbPostPRN.Size = New System.Drawing.Size(653, 91)
Me.gbPostPRN.TabIndex = 0
Me.gbPostPRN.TabStop = false
Me.gbPostPRN.Text = "Поставщик"
'
'TableLayoutPanel57
'
Me.TableLayoutPanel57.ColumnCount = 4
Me.TableLayoutPanel57.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100!))
Me.TableLayoutPanel57.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50!))
Me.TableLayoutPanel57.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80!))
Me.TableLayoutPanel57.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50!))
Me.TableLayoutPanel57.Controls.Add(Me.dtGPRNok, 3, 1)
Me.TableLayoutPanel57.Controls.Add(Me.Label4, 0, 0)
Me.TableLayoutPanel57.Controls.Add(Me.Label1, 2, 1)
Me.TableLayoutPanel57.Controls.Add(Me.Label2, 0, 1)
Me.TableLayoutPanel57.Controls.Add(Me.dtGPRNPr, 1, 1)
Me.TableLayoutPanel57.Controls.Add(Me.cmbPRNPostav, 1, 0)
Me.TableLayoutPanel57.Dock = System.Windows.Forms.DockStyle.Fill
Me.TableLayoutPanel57.Location = New System.Drawing.Point(3, 16)
Me.TableLayoutPanel57.Name = "TableLayoutPanel57"
Me.TableLayoutPanel57.RowCount = 2
Me.TableLayoutPanel57.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30!))
Me.TableLayoutPanel57.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30!))
Me.TableLayoutPanel57.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20!))
Me.TableLayoutPanel57.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20!))
Me.TableLayoutPanel57.Size = New System.Drawing.Size(647, 72)
Me.TableLayoutPanel57.TabIndex = 3
'
'dtGPRNok
'
Me.dtGPRNok.Anchor = System.Windows.Forms.AnchorStyles.Left
Me.dtGPRNok.Location = New System.Drawing.Point(416, 41)
Me.dtGPRNok.Name = "dtGPRNok"
Me.dtGPRNok.Size = New System.Drawing.Size(134, 20)
Me.dtGPRNok.TabIndex = 8
Me.dtGPRNok.Value = New Date(2013, 10, 25, 0, 0, 0, 0)
'
'Label4
'
Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.Left
Me.Label4.AutoSize = true
Me.Label4.Location = New System.Drawing.Point(3, 8)
Me.Label4.Name = "Label4"
Me.Label4.Size = New System.Drawing.Size(57, 13)
Me.Label4.TabIndex = 6
Me.Label4.Text = "Продавец"
'
'Label1
'
Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Left
Me.Label1.AutoSize = true
Me.Label1.Location = New System.Drawing.Point(336, 44)
Me.Label1.Name = "Label1"
Me.Label1.Size = New System.Drawing.Size(65, 13)
Me.Label1.TabIndex = 10
Me.Label1.Text = "Окончание:"
'
'Label2
'
Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Left
Me.Label2.AutoSize = true
Me.Label2.Location = New System.Drawing.Point(3, 44)
Me.Label2.Name = "Label2"
Me.Label2.Size = New System.Drawing.Size(77, 13)
Me.Label2.TabIndex = 9
Me.Label2.Text = "Приобретено:"
'
'dtGPRNPr
'
Me.dtGPRNPr.Anchor = System.Windows.Forms.AnchorStyles.Left
Me.dtGPRNPr.Location = New System.Drawing.Point(103, 41)
Me.dtGPRNPr.Name = "dtGPRNPr"
Me.dtGPRNPr.Size = New System.Drawing.Size(134, 20)
Me.dtGPRNPr.TabIndex = 7
Me.dtGPRNPr.Value = New Date(2010, 4, 15, 0, 0, 0, 0)
'
'cmbPRNPostav
'
Me.cmbPRNPostav.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
Me.cmbPRNPostav.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
Me.TableLayoutPanel57.SetColumnSpan(Me.cmbPRNPostav, 3)
Me.cmbPRNPostav.Dock = System.Windows.Forms.DockStyle.Fill
Me.cmbPRNPostav.FormattingEnabled = true
Me.cmbPRNPostav.Location = New System.Drawing.Point(103, 3)
Me.cmbPRNPostav.Name = "cmbPRNPostav"
Me.cmbPRNPostav.Size = New System.Drawing.Size(541, 21)
Me.cmbPRNPostav.TabIndex = 5
'
'gbSalePRN
'
Me.gbSalePRN.Controls.Add(Me.TableLayoutPanel52)
Me.gbSalePRN.Dock = System.Windows.Forms.DockStyle.Fill
Me.gbSalePRN.Location = New System.Drawing.Point(3, 100)
Me.gbSalePRN.Name = "gbSalePRN"
Me.gbSalePRN.Size = New System.Drawing.Size(653, 139)
Me.gbSalePRN.TabIndex = 1
Me.gbSalePRN.TabStop = false
Me.gbSalePRN.Text = "Данные о приобретении"
'
'TableLayoutPanel52
'
Me.TableLayoutPanel52.ColumnCount = 4
Me.TableLayoutPanel52.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100!))
Me.TableLayoutPanel52.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50!))
Me.TableLayoutPanel52.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80!))
Me.TableLayoutPanel52.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50!))
Me.TableLayoutPanel52.Controls.Add(Me.chkPRNNNb, 3, 3)
Me.TableLayoutPanel52.Controls.Add(Me.txtPRNSumm, 1, 2)
Me.TableLayoutPanel52.Controls.Add(Me.dtPRNdataVvoda, 3, 2)
Me.TableLayoutPanel52.Controls.Add(Me.Label54, 0, 0)
Me.TableLayoutPanel52.Controls.Add(Me.txtPRNZay, 3, 1)
Me.TableLayoutPanel52.Controls.Add(Me.Label49, 2, 2)
Me.TableLayoutPanel52.Controls.Add(Me.Label53, 0, 1)
Me.TableLayoutPanel52.Controls.Add(Me.txtPRNcash, 1, 1)
Me.TableLayoutPanel52.Controls.Add(Me.Label50, 2, 1)
Me.TableLayoutPanel52.Controls.Add(Me.Label52, 0, 2)
Me.TableLayoutPanel52.Controls.Add(Me.txtPRNSfN, 1, 0)
Me.TableLayoutPanel52.Controls.Add(Me.Label51, 2, 0)
Me.TableLayoutPanel52.Controls.Add(Me.dtPRNSFdate, 3, 0)
Me.TableLayoutPanel52.Controls.Add(Me.chkPRNspis, 0, 3)
Me.TableLayoutPanel52.Controls.Add(Me.dtPRNSpisanie, 1, 3)
Me.TableLayoutPanel52.Dock = System.Windows.Forms.DockStyle.Fill
Me.TableLayoutPanel52.Location = New System.Drawing.Point(3, 16)
Me.TableLayoutPanel52.Name = "TableLayoutPanel52"
Me.TableLayoutPanel52.RowCount = 4
Me.TableLayoutPanel52.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30!))
Me.TableLayoutPanel52.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30!))
Me.TableLayoutPanel52.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30!))
Me.TableLayoutPanel52.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30!))
Me.TableLayoutPanel52.Size = New System.Drawing.Size(647, 120)
Me.TableLayoutPanel52.TabIndex = 3
'
'chkPRNNNb
'
Me.chkPRNNNb.Anchor = System.Windows.Forms.AnchorStyles.Left
Me.chkPRNNNb.AutoSize = true
Me.chkPRNNNb.Location = New System.Drawing.Point(416, 96)
Me.chkPRNNNb.Name = "chkPRNNNb"
Me.chkPRNNNb.Size = New System.Drawing.Size(100, 17)
Me.chkPRNNNb.TabIndex = 23
Me.chkPRNNNb.Text = "Не на балансе"
Me.chkPRNNNb.UseVisualStyleBackColor = true
'
'txtPRNSumm
'
Me.txtPRNSumm.Dock = System.Windows.Forms.DockStyle.Fill
Me.txtPRNSumm.Location = New System.Drawing.Point(103, 63)
Me.txtPRNSumm.Maximum = New Decimal(New Integer() {1000000, 0, 0, 0})
Me.txtPRNSumm.Name = "txtPRNSumm"
Me.txtPRNSumm.Size = New System.Drawing.Size(227, 20)
Me.txtPRNSumm.TabIndex = 18
'
'dtPRNdataVvoda
'
Me.dtPRNdataVvoda.Dock = System.Windows.Forms.DockStyle.Fill
Me.dtPRNdataVvoda.Location = New System.Drawing.Point(416, 63)
Me.dtPRNdataVvoda.Name = "dtPRNdataVvoda"
Me.dtPRNdataVvoda.Size = New System.Drawing.Size(228, 20)
Me.dtPRNdataVvoda.TabIndex = 20
Me.dtPRNdataVvoda.Value = New Date(2010, 4, 15, 0, 0, 0, 0)
'
'Label54
'
Me.Label54.Anchor = System.Windows.Forms.AnchorStyles.Left
Me.Label54.AutoSize = true
Me.Label54.Location = New System.Drawing.Point(3, 8)
Me.Label54.Name = "Label54"
Me.Label54.Size = New System.Drawing.Size(89, 13)
Me.Label54.TabIndex = 13
Me.Label54.Text = "Счёт фактура №"
'
'txtPRNZay
'
Me.txtPRNZay.Dock = System.Windows.Forms.DockStyle.Fill
Me.txtPRNZay.Location = New System.Drawing.Point(416, 33)
Me.txtPRNZay.Name = "txtPRNZay"
Me.txtPRNZay.Size = New System.Drawing.Size(228, 20)
Me.txtPRNZay.TabIndex = 19
'
'Label49
'
Me.Label49.Anchor = System.Windows.Forms.AnchorStyles.Left
Me.Label49.AutoSize = true
Me.Label49.Location = New System.Drawing.Point(336, 68)
Me.Label49.Name = "Label49"
Me.Label49.Size = New System.Drawing.Size(66, 13)
Me.Label49.TabIndex = 25
Me.Label49.Text = "Дата ввода"
'
'Label53
'
Me.Label53.Anchor = System.Windows.Forms.AnchorStyles.Left
Me.Label53.AutoSize = true
Me.Label53.Location = New System.Drawing.Point(3, 38)
Me.Label53.Name = "Label53"
Me.Label53.Size = New System.Drawing.Size(33, 13)
Me.Label53.TabIndex = 14
Me.Label53.Text = "Цена"
'
'txtPRNcash
'
Me.txtPRNcash.Dock = System.Windows.Forms.DockStyle.Fill
Me.txtPRNcash.Location = New System.Drawing.Point(103, 33)
Me.txtPRNcash.Maximum = New Decimal(New Integer() {1000000, 0, 0, 0})
Me.txtPRNcash.Name = "txtPRNcash"
Me.txtPRNcash.Size = New System.Drawing.Size(227, 20)
Me.txtPRNcash.TabIndex = 16
'
'Label50
'
Me.Label50.Anchor = System.Windows.Forms.AnchorStyles.Left
Me.Label50.AutoSize = true
Me.Label50.Location = New System.Drawing.Point(336, 38)
Me.Label50.Name = "Label50"
Me.Label50.Size = New System.Drawing.Size(44, 13)
Me.Label50.TabIndex = 24
Me.Label50.Text = "Заявка"
'
'Label52
'
Me.Label52.Anchor = System.Windows.Forms.AnchorStyles.Left
Me.Label52.AutoSize = true
Me.Label52.Location = New System.Drawing.Point(3, 68)
Me.Label52.Name = "Label52"
Me.Label52.Size = New System.Drawing.Size(41, 13)
Me.Label52.TabIndex = 15
Me.Label52.Text = "Сумма"
'
'txtPRNSfN
'
Me.txtPRNSfN.Dock = System.Windows.Forms.DockStyle.Fill
Me.txtPRNSfN.Location = New System.Drawing.Point(103, 3)
Me.txtPRNSfN.Name = "txtPRNSfN"
Me.txtPRNSfN.Size = New System.Drawing.Size(227, 20)
Me.txtPRNSfN.TabIndex = 12
'
'Label51
'
Me.Label51.Anchor = System.Windows.Forms.AnchorStyles.Left
Me.Label51.AutoSize = true
Me.Label51.Location = New System.Drawing.Point(336, 8)
Me.Label51.Name = "Label51"
Me.Label51.Size = New System.Drawing.Size(18, 13)
Me.Label51.TabIndex = 22
Me.Label51.Text = "от"
'
'dtPRNSFdate
'
Me.dtPRNSFdate.Dock = System.Windows.Forms.DockStyle.Fill
Me.dtPRNSFdate.Location = New System.Drawing.Point(416, 3)
Me.dtPRNSFdate.Name = "dtPRNSFdate"
Me.dtPRNSFdate.Size = New System.Drawing.Size(228, 20)
Me.dtPRNSFdate.TabIndex = 17
Me.dtPRNSFdate.Value = New Date(2010, 4, 15, 0, 0, 0, 0)
'
'chkPRNspis
'
Me.chkPRNspis.Anchor = System.Windows.Forms.AnchorStyles.Left
Me.chkPRNspis.AutoSize = true
Me.chkPRNspis.Location = New System.Drawing.Point(3, 96)
Me.chkPRNspis.Name = "chkPRNspis"
Me.chkPRNspis.Size = New System.Drawing.Size(69, 17)
Me.chkPRNspis.TabIndex = 21
Me.chkPRNspis.Text = "Списано"
Me.chkPRNspis.UseVisualStyleBackColor = true
'
'dtPRNSpisanie
'
Me.dtPRNSpisanie.Dock = System.Windows.Forms.DockStyle.Fill
Me.dtPRNSpisanie.Location = New System.Drawing.Point(103, 93)
Me.dtPRNSpisanie.Name = "dtPRNSpisanie"
Me.dtPRNSpisanie.Size = New System.Drawing.Size(227, 20)
Me.dtPRNSpisanie.TabIndex = 26
Me.dtPRNSpisanie.Value = New Date(2013, 7, 2, 0, 0, 0, 0)
'
'sSTAB4
'
Me.sSTAB4.Controls.Add(Me.TabPage13)
Me.sSTAB4.Controls.Add(Me.TabPage14)
Me.sSTAB4.Controls.Add(Me.TabPage24)
Me.sSTAB4.Controls.Add(Me.TabPage15)
Me.sSTAB4.Controls.Add(Me.TabPage17)
Me.sSTAB4.Dock = System.Windows.Forms.DockStyle.Fill
Me.sSTAB4.Location = New System.Drawing.Point(0, 0)
Me.sSTAB4.Name = "sSTAB4"
Me.sSTAB4.SelectedIndex = 0
Me.sSTAB4.Size = New System.Drawing.Size(667, 646)
Me.sSTAB4.TabIndex = 10
Me.sSTAB4.Visible = false
'
'TabPage13
'
Me.TabPage13.Controls.Add(Me.TableLayoutPanel69)
Me.TabPage13.Location = New System.Drawing.Point(4, 22)
Me.TabPage13.Name = "TabPage13"
Me.TabPage13.Padding = New System.Windows.Forms.Padding(3)
Me.TabPage13.Size = New System.Drawing.Size(659, 620)
Me.TabPage13.TabIndex = 0
Me.TabPage13.Text = "Информация"
Me.TabPage13.UseVisualStyleBackColor = true
'
'TableLayoutPanel69
'
Me.TableLayoutPanel69.ColumnCount = 1
Me.TableLayoutPanel69.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100!))
Me.TableLayoutPanel69.Controls.Add(Me.TableLayoutPanel49, 0, 3)
Me.TableLayoutPanel69.Controls.Add(Me.gbNet, 0, 0)
Me.TableLayoutPanel69.Controls.Add(Me.gbExNet, 0, 1)
Me.TableLayoutPanel69.Dock = System.Windows.Forms.DockStyle.Fill
Me.TableLayoutPanel69.Location = New System.Drawing.Point(3, 3)
Me.TableLayoutPanel69.Name = "TableLayoutPanel69"
Me.TableLayoutPanel69.RowCount = 4
Me.TableLayoutPanel69.RowStyles.Add(New System.Windows.Forms.RowStyle())
Me.TableLayoutPanel69.RowStyles.Add(New System.Windows.Forms.RowStyle())
Me.TableLayoutPanel69.RowStyles.Add(New System.Windows.Forms.RowStyle())
Me.TableLayoutPanel69.RowStyles.Add(New System.Windows.Forms.RowStyle())
Me.TableLayoutPanel69.Size = New System.Drawing.Size(653, 614)
Me.TableLayoutPanel69.TabIndex = 5
'
'TableLayoutPanel49
'
Me.TableLayoutPanel49.ColumnCount = 4
Me.TableLayoutPanel49.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 82!))
Me.TableLayoutPanel49.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50!))
Me.TableLayoutPanel49.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 103!))
Me.TableLayoutPanel49.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50!))
Me.TableLayoutPanel49.Controls.Add(Me.cmbNETotv, 3, 1)
Me.TableLayoutPanel49.Controls.Add(Me.txtNETphone, 3, 0)
Me.TableLayoutPanel49.Controls.Add(Me.Label32, 0, 0)
Me.TableLayoutPanel49.Controls.Add(Me.Label28, 2, 0)
Me.TableLayoutPanel49.Controls.Add(Me.Label29, 2, 1)
Me.TableLayoutPanel49.Controls.Add(Me.Label31, 0, 1)
Me.TableLayoutPanel49.Controls.Add(Me.Label30, 0, 2)
Me.TableLayoutPanel49.Controls.Add(Me.cmbNETBranch, 1, 0)
Me.TableLayoutPanel49.Controls.Add(Me.cmbNETOffice, 1, 2)
Me.TableLayoutPanel49.Controls.Add(Me.cmbNetDepart, 1, 1)
Me.TableLayoutPanel49.Controls.Add(Me.Label86, 2, 2)
Me.TableLayoutPanel49.Controls.Add(Me.lblSidNET, 3, 2)
Me.TableLayoutPanel49.Controls.Add(Me.lblPCLNET, 2, 3)
Me.TableLayoutPanel49.Controls.Add(Me.cmbCNTNet, 3, 3)
Me.TableLayoutPanel49.Dock = System.Windows.Forms.DockStyle.Fill
Me.TableLayoutPanel49.Location = New System.Drawing.Point(3, 210)
Me.TableLayoutPanel49.Name = "TableLayoutPanel49"
Me.TableLayoutPanel49.RowCount = 5
Me.TableLayoutPanel49.RowStyles.Add(New System.Windows.Forms.RowStyle())
Me.TableLayoutPanel49.RowStyles.Add(New System.Windows.Forms.RowStyle())
Me.TableLayoutPanel49.RowStyles.Add(New System.Windows.Forms.RowStyle())
Me.TableLayoutPanel49.RowStyles.Add(New System.Windows.Forms.RowStyle())
Me.TableLayoutPanel49.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20!))
Me.TableLayoutPanel49.Size = New System.Drawing.Size(647, 473)
Me.TableLayoutPanel49.TabIndex = 6
'
'cmbNETotv
'
Me.cmbNETotv.Anchor = System.Windows.Forms.AnchorStyles.Left
Me.cmbNETotv.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
Me.cmbNETotv.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
Me.cmbNETotv.FormattingEnabled = true
Me.cmbNETotv.Location = New System.Drawing.Point(419, 30)
Me.cmbNETotv.Name = "cmbNETotv"
Me.cmbNETotv.Size = New System.Drawing.Size(225, 21)
Me.cmbNETotv.TabIndex = 22
'
'txtNETphone
'
Me.txtNETphone.Anchor = System.Windows.Forms.AnchorStyles.Left
Me.txtNETphone.Location = New System.Drawing.Point(419, 3)
Me.txtNETphone.Name = "txtNETphone"
Me.txtNETphone.Size = New System.Drawing.Size(225, 20)
Me.txtNETphone.TabIndex = 21
'
'Label32
'
Me.Label32.Anchor = System.Windows.Forms.AnchorStyles.Left
Me.Label32.AutoSize = true
Me.Label32.Location = New System.Drawing.Point(3, 7)
Me.Label32.Name = "Label32"
Me.Label32.Size = New System.Drawing.Size(51, 13)
Me.Label32.TabIndex = 23
Me.Label32.Text = "Филиал:"
'
'Label28
'
Me.Label28.Anchor = System.Windows.Forms.AnchorStyles.Left
Me.Label28.AutoSize = true
Me.Label28.Location = New System.Drawing.Point(316, 7)
Me.Label28.Name = "Label28"
Me.Label28.Size = New System.Drawing.Size(55, 13)
Me.Label28.TabIndex = 27
Me.Label28.Text = "Телефон:"
'
'Label29
'
Me.Label29.Anchor = System.Windows.Forms.AnchorStyles.Left
Me.Label29.AutoSize = true
Me.Label29.Location = New System.Drawing.Point(316, 34)
Me.Label29.Name = "Label29"
Me.Label29.Size = New System.Drawing.Size(89, 13)
Me.Label29.TabIndex = 26
Me.Label29.Text = "Ответственный:"
'
'Label31
'
Me.Label31.Anchor = System.Windows.Forms.AnchorStyles.Left
Me.Label31.AutoSize = true
Me.Label31.Location = New System.Drawing.Point(3, 34)
Me.Label31.Name = "Label31"
Me.Label31.Size = New System.Drawing.Size(41, 13)
Me.Label31.TabIndex = 24
Me.Label31.Text = "Отдел:"
'
'Label30
'
Me.Label30.Anchor = System.Windows.Forms.AnchorStyles.Left
Me.Label30.AutoSize = true
Me.Label30.Location = New System.Drawing.Point(3, 61)
Me.Label30.Name = "Label30"
Me.Label30.Size = New System.Drawing.Size(52, 13)
Me.Label30.TabIndex = 25
Me.Label30.Text = "Кабинет:"
'
'cmbNETBranch
'
Me.cmbNETBranch.Anchor = System.Windows.Forms.AnchorStyles.Left
Me.cmbNETBranch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
Me.cmbNETBranch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
Me.cmbNETBranch.FormattingEnabled = true
Me.cmbNETBranch.Location = New System.Drawing.Point(85, 3)
Me.cmbNETBranch.Name = "cmbNETBranch"
Me.cmbNETBranch.Size = New System.Drawing.Size(225, 21)
Me.cmbNETBranch.TabIndex = 18
'
'cmbNETOffice
'
Me.cmbNETOffice.Anchor = System.Windows.Forms.AnchorStyles.Left
Me.cmbNETOffice.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
Me.cmbNETOffice.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
Me.cmbNETOffice.FormattingEnabled = true
Me.cmbNETOffice.Location = New System.Drawing.Point(85, 57)
Me.cmbNETOffice.Name = "cmbNETOffice"
Me.cmbNETOffice.Size = New System.Drawing.Size(225, 21)
Me.cmbNETOffice.TabIndex = 20
'
'cmbNetDepart
'
Me.cmbNetDepart.Anchor = System.Windows.Forms.AnchorStyles.Left
Me.cmbNetDepart.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
Me.cmbNetDepart.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
Me.cmbNetDepart.FormattingEnabled = true
Me.cmbNetDepart.Location = New System.Drawing.Point(85, 30)
Me.cmbNetDepart.Name = "cmbNetDepart"
Me.cmbNetDepart.Size = New System.Drawing.Size(225, 21)
Me.cmbNetDepart.TabIndex = 19
'
'Label86
'
Me.Label86.Anchor = System.Windows.Forms.AnchorStyles.Left
Me.Label86.AutoSize = true
Me.Label86.Location = New System.Drawing.Point(316, 61)
Me.Label86.Name = "Label86"
Me.Label86.Size = New System.Drawing.Size(54, 13)
Me.Label86.TabIndex = 28
Me.Label86.Text = "№ в базе"
'
'lblSidNET
'
Me.lblSidNET.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
Me.lblSidNET.AutoSize = true
Me.lblSidNET.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
Me.lblSidNET.Location = New System.Drawing.Point(419, 59)
Me.lblSidNET.Name = "lblSidNET"
Me.lblSidNET.Size = New System.Drawing.Size(225, 16)
Me.lblSidNET.TabIndex = 29
'
'lblPCLNET
'
Me.lblPCLNET.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
Me.lblPCLNET.AutoSize = true
Me.lblPCLNET.Location = New System.Drawing.Point(316, 88)
Me.lblPCLNET.Name = "lblPCLNET"
Me.lblPCLNET.Size = New System.Drawing.Size(97, 13)
Me.lblPCLNET.TabIndex = 30
Me.lblPCLNET.Text = "В контейнере"
'
'cmbCNTNet
'
Me.cmbCNTNet.Dock = System.Windows.Forms.DockStyle.Fill
Me.cmbCNTNet.FormattingEnabled = true
Me.cmbCNTNet.Location = New System.Drawing.Point(419, 84)
Me.cmbCNTNet.Name = "cmbCNTNet"
Me.cmbCNTNet.Size = New System.Drawing.Size(225, 21)
Me.cmbCNTNet.TabIndex = 31
'
'gbNet
'
Me.gbNet.Controls.Add(Me.TableLayoutPanel51)
Me.gbNet.Dock = System.Windows.Forms.DockStyle.Fill
Me.gbNet.Location = New System.Drawing.Point(3, 3)
Me.gbNet.Name = "gbNet"
Me.gbNet.Size = New System.Drawing.Size(647, 46)
Me.gbNet.TabIndex = 0
Me.gbNet.TabStop = false
Me.gbNet.Text = "Тип сетевого оборудования, наименование, производитель"
'
'TableLayoutPanel51
'
Me.TableLayoutPanel51.ColumnCount = 3
Me.TableLayoutPanel51.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 180!))
Me.TableLayoutPanel51.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 69.28327!))
Me.TableLayoutPanel51.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.71673!))
Me.TableLayoutPanel51.Controls.Add(Me.PROiZV40, 2, 0)
Me.TableLayoutPanel51.Controls.Add(Me.cmbDevNet, 1, 0)
Me.TableLayoutPanel51.Controls.Add(Me.cmbNetDev, 0, 0)
Me.TableLayoutPanel51.Dock = System.Windows.Forms.DockStyle.Fill
Me.TableLayoutPanel51.Location = New System.Drawing.Point(3, 16)
Me.TableLayoutPanel51.Name = "TableLayoutPanel51"
Me.TableLayoutPanel51.RowCount = 1
Me.TableLayoutPanel51.RowStyles.Add(New System.Windows.Forms.RowStyle())
Me.TableLayoutPanel51.Size = New System.Drawing.Size(641, 27)
Me.TableLayoutPanel51.TabIndex = 4
'
'PROiZV40
'
Me.PROiZV40.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
Me.PROiZV40.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
Me.PROiZV40.Dock = System.Windows.Forms.DockStyle.Fill
Me.PROiZV40.FormattingEnabled = true
Me.PROiZV40.Location = New System.Drawing.Point(502, 3)
Me.PROiZV40.Name = "PROiZV40"
Me.PROiZV40.Size = New System.Drawing.Size(136, 21)
Me.PROiZV40.TabIndex = 6
'
'cmbDevNet
'
Me.cmbDevNet.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
Me.cmbDevNet.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
Me.cmbDevNet.Dock = System.Windows.Forms.DockStyle.Fill
Me.cmbDevNet.FormattingEnabled = true
Me.cmbDevNet.Location = New System.Drawing.Point(183, 3)
Me.cmbDevNet.Name = "cmbDevNet"
Me.cmbDevNet.Size = New System.Drawing.Size(313, 21)
Me.cmbDevNet.TabIndex = 5
'
'cmbNetDev
'
Me.cmbNetDev.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
Me.cmbNetDev.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
Me.cmbNetDev.Dock = System.Windows.Forms.DockStyle.Fill
Me.cmbNetDev.FormattingEnabled = true
Me.cmbNetDev.Location = New System.Drawing.Point(3, 3)
Me.cmbNetDev.Name = "cmbNetDev"
Me.cmbNetDev.Size = New System.Drawing.Size(174, 21)
Me.cmbNetDev.TabIndex = 4
'
'gbExNet
'
Me.gbExNet.Controls.Add(Me.TableLayoutPanel48)
Me.gbExNet.Dock = System.Windows.Forms.DockStyle.Fill
Me.gbExNet.Location = New System.Drawing.Point(3, 55)
Me.gbExNet.Name = "gbExNet"
Me.gbExNet.Size = New System.Drawing.Size(647, 149)
Me.gbExNet.TabIndex = 1
Me.gbExNet.TabStop = false
Me.gbExNet.Text = "Расширенная информация"
'
'TableLayoutPanel48
'
Me.TableLayoutPanel48.ColumnCount = 4
Me.TableLayoutPanel48.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.946!))
Me.TableLayoutPanel48.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.946!))
Me.TableLayoutPanel48.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.80561!))
Me.TableLayoutPanel48.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.30238!))
Me.TableLayoutPanel48.Controls.Add(Me.cmbNetCable, 3, 3)
Me.TableLayoutPanel48.Controls.Add(Me.txtNetSN, 2, 5)
Me.TableLayoutPanel48.Controls.Add(Me.Label14, 3, 2)
Me.TableLayoutPanel48.Controls.Add(Me.Label27, 0, 0)
Me.TableLayoutPanel48.Controls.Add(Me.txtNetIsp, 3, 1)
Me.TableLayoutPanel48.Controls.Add(Me.Label11, 2, 4)
Me.TableLayoutPanel48.Controls.Add(Me.Label24, 3, 0)
Me.TableLayoutPanel48.Controls.Add(Me.txtNetIP, 0, 1)
Me.TableLayoutPanel48.Controls.Add(Me.cmbNetVkl, 1, 5)
Me.TableLayoutPanel48.Controls.Add(Me.Label23, 0, 2)
Me.TableLayoutPanel48.Controls.Add(Me.txtNetNumberPorts, 2, 3)
Me.TableLayoutPanel48.Controls.Add(Me.Label12, 1, 4)
Me.TableLayoutPanel48.Controls.Add(Me.Label15, 2, 2)
Me.TableLayoutPanel48.Controls.Add(Me.txtNetINN, 0, 3)
Me.TableLayoutPanel48.Controls.Add(Me.txtNetCableCat, 0, 5)
Me.TableLayoutPanel48.Controls.Add(Me.Label13, 0, 4)
Me.TableLayoutPanel48.Controls.Add(Me.txtNetPort, 2, 1)
Me.TableLayoutPanel48.Controls.Add(Me.Label26, 1, 0)
Me.TableLayoutPanel48.Controls.Add(Me.Label25, 2, 0)
Me.TableLayoutPanel48.Controls.Add(Me.txtNetMac, 1, 1)
Me.TableLayoutPanel48.Dock = System.Windows.Forms.DockStyle.Fill
Me.TableLayoutPanel48.Location = New System.Drawing.Point(3, 16)
Me.TableLayoutPanel48.Name = "TableLayoutPanel48"
Me.TableLayoutPanel48.RowCount = 6
Me.TableLayoutPanel48.RowStyles.Add(New System.Windows.Forms.RowStyle())
Me.TableLayoutPanel48.RowStyles.Add(New System.Windows.Forms.RowStyle())
Me.TableLayoutPanel48.RowStyles.Add(New System.Windows.Forms.RowStyle())
Me.TableLayoutPanel48.RowStyles.Add(New System.Windows.Forms.RowStyle())
Me.TableLayoutPanel48.RowStyles.Add(New System.Windows.Forms.RowStyle())
Me.TableLayoutPanel48.RowStyles.Add(New System.Windows.Forms.RowStyle())
Me.TableLayoutPanel48.Size = New System.Drawing.Size(641, 130)
Me.TableLayoutPanel48.TabIndex = 4
'
'cmbNetCable
'
Me.cmbNetCable.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
Me.cmbNetCable.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
Me.cmbNetCable.Dock = System.Windows.Forms.DockStyle.Fill
Me.cmbNetCable.FormattingEnabled = true
Me.cmbNetCable.Location = New System.Drawing.Point(512, 55)
Me.cmbNetCable.Name = "cmbNetCable"
Me.cmbNetCable.Size = New System.Drawing.Size(126, 21)
Me.cmbNetCable.TabIndex = 7
'
'txtNetSN
'
Me.TableLayoutPanel48.SetColumnSpan(Me.txtNetSN, 2)
Me.txtNetSN.Dock = System.Windows.Forms.DockStyle.Fill
Me.txtNetSN.Location = New System.Drawing.Point(321, 95)
Me.txtNetSN.Name = "txtNetSN"
Me.txtNetSN.Size = New System.Drawing.Size(317, 20)
Me.txtNetSN.TabIndex = 10
'
'Label14
'
Me.Label14.AutoSize = true
Me.Label14.Location = New System.Drawing.Point(512, 39)
Me.Label14.Name = "Label14"
Me.Label14.Size = New System.Drawing.Size(68, 13)
Me.Label14.TabIndex = 44
Me.Label14.Text = "Тип кабеля:"
'
'Label27
'
Me.Label27.AutoSize = true
Me.Label27.Location = New System.Drawing.Point(3, 0)
Me.Label27.Name = "Label27"
Me.Label27.Size = New System.Drawing.Size(20, 13)
Me.Label27.TabIndex = 32
Me.Label27.Text = "IP:"
'
'txtNetIsp
'
Me.txtNetIsp.Dock = System.Windows.Forms.DockStyle.Fill
Me.txtNetIsp.Location = New System.Drawing.Point(512, 16)
Me.txtNetIsp.Name = "txtNetIsp"
Me.txtNetIsp.Size = New System.Drawing.Size(126, 20)
Me.txtNetIsp.TabIndex = 4
'
'Label11
'
Me.Label11.AutoSize = true
Me.Label11.Location = New System.Drawing.Point(321, 79)
Me.Label11.Name = "Label11"
Me.Label11.Size = New System.Drawing.Size(96, 13)
Me.Label11.TabIndex = 50
Me.Label11.Text = "Серийный номер:"
'
'Label24
'
Me.Label24.AutoSize = true
Me.Label24.Location = New System.Drawing.Point(512, 0)
Me.Label24.Name = "Label24"
Me.Label24.Size = New System.Drawing.Size(72, 13)
Me.Label24.TabIndex = 38
Me.Label24.Text = "Исполнение:"
'
'txtNetIP
'
Me.txtNetIP.Dock = System.Windows.Forms.DockStyle.Fill
Me.txtNetIP.Location = New System.Drawing.Point(3, 16)
Me.txtNetIP.Name = "txtNetIP"
Me.txtNetIP.Size = New System.Drawing.Size(153, 20)
Me.txtNetIP.TabIndex = 1
'
'cmbNetVkl
'
Me.cmbNetVkl.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
Me.cmbNetVkl.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
Me.cmbNetVkl.Dock = System.Windows.Forms.DockStyle.Fill
Me.cmbNetVkl.FormattingEnabled = true
Me.cmbNetVkl.Items.AddRange(New Object() {"On", "Off", "Defective"})
Me.cmbNetVkl.Location = New System.Drawing.Point(162, 95)
Me.cmbNetVkl.Name = "cmbNetVkl"
Me.cmbNetVkl.Size = New System.Drawing.Size(153, 21)
Me.cmbNetVkl.TabIndex = 9
'
'Label23
'
Me.Label23.AutoSize = true
Me.Label23.Location = New System.Drawing.Point(3, 39)
Me.Label23.Name = "Label23"
Me.Label23.Size = New System.Drawing.Size(114, 13)
Me.Label23.TabIndex = 40
Me.Label23.Text = "Инвентарный номер:"
'
'txtNetNumberPorts
'
Me.txtNetNumberPorts.Dock = System.Windows.Forms.DockStyle.Fill
Me.txtNetNumberPorts.Location = New System.Drawing.Point(321, 55)
Me.txtNetNumberPorts.Name = "txtNetNumberPorts"
Me.txtNetNumberPorts.Size = New System.Drawing.Size(185, 20)
Me.txtNetNumberPorts.TabIndex = 6
'
'Label12
'
Me.Label12.AutoSize = true
Me.Label12.Location = New System.Drawing.Point(162, 79)
Me.Label12.Name = "Label12"
Me.Label12.Size = New System.Drawing.Size(64, 13)
Me.Label12.TabIndex = 48
Me.Label12.Text = "Состояние:"
'
'Label15
'
Me.Label15.AutoSize = true
Me.Label15.Location = New System.Drawing.Point(321, 39)
Me.Label15.Name = "Label15"
Me.Label15.Size = New System.Drawing.Size(76, 13)
Me.Label15.TabIndex = 42
Me.Label15.Text = "Номер порта:"
'
'txtNetINN
'
Me.TableLayoutPanel48.SetColumnSpan(Me.txtNetINN, 2)
Me.txtNetINN.Dock = System.Windows.Forms.DockStyle.Fill
Me.txtNetINN.Location = New System.Drawing.Point(3, 55)
Me.txtNetINN.Name = "txtNetINN"
Me.txtNetINN.Size = New System.Drawing.Size(312, 20)
Me.txtNetINN.TabIndex = 5
'
'txtNetCableCat
'
Me.txtNetCableCat.Dock = System.Windows.Forms.DockStyle.Fill
Me.txtNetCableCat.Location = New System.Drawing.Point(3, 95)
Me.txtNetCableCat.Name = "txtNetCableCat"
Me.txtNetCableCat.Size = New System.Drawing.Size(153, 20)
Me.txtNetCableCat.TabIndex = 8
'
'Label13
'
Me.Label13.AutoSize = true
Me.Label13.Location = New System.Drawing.Point(3, 79)
Me.Label13.Name = "Label13"
Me.Label13.Size = New System.Drawing.Size(102, 13)
Me.Label13.TabIndex = 46
Me.Label13.Text = "Категория кабеля:"
'
'txtNetPort
'
Me.txtNetPort.Dock = System.Windows.Forms.DockStyle.Fill
Me.txtNetPort.Location = New System.Drawing.Point(321, 16)
Me.txtNetPort.Name = "txtNetPort"
Me.txtNetPort.Size = New System.Drawing.Size(185, 20)
Me.txtNetPort.TabIndex = 3
'
'Label26
'
Me.Label26.AutoSize = true
Me.Label26.Location = New System.Drawing.Point(162, 0)
Me.Label26.Name = "Label26"
Me.Label26.Size = New System.Drawing.Size(33, 13)
Me.Label26.TabIndex = 33
Me.Label26.Text = "MAC:"
'
'Label25
'
Me.Label25.AutoSize = true
Me.Label25.Location = New System.Drawing.Point(321, 0)
Me.Label25.Name = "Label25"
Me.Label25.Size = New System.Drawing.Size(113, 13)
Me.Label25.TabIndex = 36
Me.Label25.Text = "Колличество портов:"
'
'txtNetMac
'
Me.txtNetMac.Dock = System.Windows.Forms.DockStyle.Fill
Me.txtNetMac.Location = New System.Drawing.Point(162, 16)
Me.txtNetMac.Name = "txtNetMac"
Me.txtNetMac.Size = New System.Drawing.Size(153, 20)
Me.txtNetMac.TabIndex = 2
'
'TabPage14
'
Me.TabPage14.Controls.Add(Me.gbNetPortMapping)
Me.TabPage14.Location = New System.Drawing.Point(4, 22)
Me.TabPage14.Name = "TabPage14"
Me.TabPage14.Size = New System.Drawing.Size(659, 620)
Me.TabPage14.TabIndex = 2
Me.TabPage14.Text = "Порты"
Me.TabPage14.UseVisualStyleBackColor = true
'
'gbNetPortMapping
'
Me.gbNetPortMapping.Controls.Add(Me.TableLayoutPanel50)
Me.gbNetPortMapping.Dock = System.Windows.Forms.DockStyle.Fill
Me.gbNetPortMapping.Location = New System.Drawing.Point(0, 0)
Me.gbNetPortMapping.Name = "gbNetPortMapping"
Me.gbNetPortMapping.Size = New System.Drawing.Size(659, 620)
Me.gbNetPortMapping.TabIndex = 0
Me.gbNetPortMapping.TabStop = false
Me.gbNetPortMapping.Text = "Распределение портов"
'
'TableLayoutPanel50
'
Me.TableLayoutPanel50.ColumnCount = 4
Me.TableLayoutPanel50.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 141!))
Me.TableLayoutPanel50.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100!))
Me.TableLayoutPanel50.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 158!))
Me.TableLayoutPanel50.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50!))
Me.TableLayoutPanel50.Controls.Add(Me.lvNetPort, 0, 2)
Me.TableLayoutPanel50.Controls.Add(Me.Label35, 0, 0)
Me.TableLayoutPanel50.Controls.Add(Me.txtNetPortMapping, 1, 1)
Me.TableLayoutPanel50.Controls.Add(Me.Label33, 2, 0)
Me.TableLayoutPanel50.Controls.Add(Me.txtNetnumberPort, 0, 1)
Me.TableLayoutPanel50.Controls.Add(Me.Label34, 1, 0)
Me.TableLayoutPanel50.Controls.Add(Me.txtNetPortMac, 2, 1)
Me.TableLayoutPanel50.Controls.Add(Me.btnNetPortAdd, 3, 1)
Me.TableLayoutPanel50.Dock = System.Windows.Forms.DockStyle.Fill
Me.TableLayoutPanel50.Location = New System.Drawing.Point(3, 16)
Me.TableLayoutPanel50.Name = "TableLayoutPanel50"
Me.TableLayoutPanel50.RowCount = 3
Me.TableLayoutPanel50.RowStyles.Add(New System.Windows.Forms.RowStyle())
Me.TableLayoutPanel50.RowStyles.Add(New System.Windows.Forms.RowStyle())
Me.TableLayoutPanel50.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100!))
Me.TableLayoutPanel50.Size = New System.Drawing.Size(653, 601)
Me.TableLayoutPanel50.TabIndex = 4
'
'lvNetPort
'
Me.TableLayoutPanel50.SetColumnSpan(Me.lvNetPort, 4)
Me.lvNetPort.Dock = System.Windows.Forms.DockStyle.Fill
Me.lvNetPort.FullRowSelect = true
Me.lvNetPort.GridLines = true
Me.lvNetPort.Location = New System.Drawing.Point(3, 45)
Me.lvNetPort.Name = "lvNetPort"
Me.lvNetPort.Size = New System.Drawing.Size(647, 553)
Me.lvNetPort.TabIndex = 47
Me.lvNetPort.UseCompatibleStateImageBehavior = false
Me.lvNetPort.View = System.Windows.Forms.View.Details
'
'Label35
'
Me.Label35.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left),System.Windows.Forms.AnchorStyles)
Me.Label35.AutoSize = true
Me.Label35.Location = New System.Drawing.Point(3, 0)
Me.Label35.Name = "Label35"
Me.Label35.Size = New System.Drawing.Size(76, 13)
Me.Label35.TabIndex = 48
Me.Label35.Text = "Номер порта:"
Me.Label35.Visible = false
'
'txtNetPortMapping
'
Me.txtNetPortMapping.Dock = System.Windows.Forms.DockStyle.Fill
Me.txtNetPortMapping.Location = New System.Drawing.Point(144, 16)
Me.txtNetPortMapping.Name = "txtNetPortMapping"
Me.txtNetPortMapping.Size = New System.Drawing.Size(298, 20)
Me.txtNetPortMapping.TabIndex = 44
Me.txtNetPortMapping.Visible = false
'
'Label33
'
Me.Label33.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left),System.Windows.Forms.AnchorStyles)
Me.Label33.AutoSize = true
Me.Label33.Location = New System.Drawing.Point(448, 0)
Me.Label33.Name = "Label33"
Me.Label33.Size = New System.Drawing.Size(33, 13)
Me.Label33.TabIndex = 50
Me.Label33.Text = "MAC:"
Me.Label33.Visible = false
'
'txtNetnumberPort
'
Me.txtNetnumberPort.Dock = System.Windows.Forms.DockStyle.Fill
Me.txtNetnumberPort.Location = New System.Drawing.Point(3, 16)
Me.txtNetnumberPort.Name = "txtNetnumberPort"
Me.txtNetnumberPort.Size = New System.Drawing.Size(135, 20)
Me.txtNetnumberPort.TabIndex = 43
Me.txtNetnumberPort.Visible = false
'
'Label34
'
Me.Label34.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left),System.Windows.Forms.AnchorStyles)
Me.Label34.AutoSize = true
Me.Label34.Location = New System.Drawing.Point(144, 0)
Me.Label34.Name = "Label34"
Me.Label34.Size = New System.Drawing.Size(78, 13)
Me.Label34.TabIndex = 49
Me.Label34.Text = "Направление:"
Me.Label34.Visible = false
'
'txtNetPortMac
'
Me.txtNetPortMac.Dock = System.Windows.Forms.DockStyle.Fill
Me.txtNetPortMac.Location = New System.Drawing.Point(448, 16)
Me.txtNetPortMac.Name = "txtNetPortMac"
Me.txtNetPortMac.Size = New System.Drawing.Size(152, 20)
Me.txtNetPortMac.TabIndex = 45
Me.txtNetPortMac.Visible = false
'
'btnNetPortAdd
'
Me.btnNetPortAdd.Location = New System.Drawing.Point(606, 16)
Me.btnNetPortAdd.Name = "btnNetPortAdd"
Me.btnNetPortAdd.Size = New System.Drawing.Size(39, 23)
Me.btnNetPortAdd.TabIndex = 46
Me.btnNetPortAdd.Text = "+"
Me.btnNetPortAdd.UseVisualStyleBackColor = true
Me.btnNetPortAdd.Visible = false
'
'TabPage24
'
Me.TabPage24.Controls.Add(Me.lvMovementNET)
Me.TabPage24.Location = New System.Drawing.Point(4, 22)
Me.TabPage24.Name = "TabPage24"
Me.TabPage24.Size = New System.Drawing.Size(659, 620)
Me.TabPage24.TabIndex = 4
Me.TabPage24.Text = "Движение"
Me.TabPage24.UseVisualStyleBackColor = true
'
'lvMovementNET
'
Me.lvMovementNET.Dock = System.Windows.Forms.DockStyle.Fill
Me.lvMovementNET.FullRowSelect = true
Me.lvMovementNET.GridLines = true
Me.lvMovementNET.Location = New System.Drawing.Point(0, 0)
Me.lvMovementNET.MultiSelect = false
Me.lvMovementNET.Name = "lvMovementNET"
Me.lvMovementNET.Size = New System.Drawing.Size(659, 620)
Me.lvMovementNET.TabIndex = 1
Me.lvMovementNET.UseCompatibleStateImageBehavior = false
Me.lvMovementNET.View = System.Windows.Forms.View.Details
'
'TabPage15
'
Me.TabPage15.Controls.Add(Me.TableLayoutPanel14)
Me.TabPage15.Location = New System.Drawing.Point(4, 22)
Me.TabPage15.Name = "TabPage15"
Me.TabPage15.Padding = New System.Windows.Forms.Padding(3)
Me.TabPage15.Size = New System.Drawing.Size(659, 620)
Me.TabPage15.TabIndex = 1
Me.TabPage15.Text = "Сервис"
Me.TabPage15.UseVisualStyleBackColor = true
'
'TableLayoutPanel14
'
Me.TableLayoutPanel14.ColumnCount = 1
Me.TableLayoutPanel14.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100!))
Me.TableLayoutPanel14.Controls.Add(Me.gbNETRemont, 0, 1)
Me.TableLayoutPanel14.Controls.Add(Me.gbNETNotes, 0, 0)
Me.TableLayoutPanel14.Dock = System.Windows.Forms.DockStyle.Fill
Me.TableLayoutPanel14.Location = New System.Drawing.Point(3, 3)
Me.TableLayoutPanel14.Name = "TableLayoutPanel14"
Me.TableLayoutPanel14.RowCount = 2
Me.TableLayoutPanel14.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40!))
Me.TableLayoutPanel14.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60!))
Me.TableLayoutPanel14.Size = New System.Drawing.Size(653, 614)
Me.TableLayoutPanel14.TabIndex = 7
'
'gbNETRemont
'
Me.gbNETRemont.Controls.Add(Me.lvRepairNET)
Me.gbNETRemont.Dock = System.Windows.Forms.DockStyle.Fill
Me.gbNETRemont.Location = New System.Drawing.Point(3, 248)
Me.gbNETRemont.Name = "gbNETRemont"
Me.gbNETRemont.Size = New System.Drawing.Size(647, 363)
Me.gbNETRemont.TabIndex = 4
Me.gbNETRemont.TabStop = false
Me.gbNETRemont.Text = "Ремонты"
'
'lvRepairNET
'
Me.lvRepairNET.Dock = System.Windows.Forms.DockStyle.Fill
Me.lvRepairNET.FullRowSelect = true
Me.lvRepairNET.GridLines = true
Me.lvRepairNET.Location = New System.Drawing.Point(3, 16)
Me.lvRepairNET.MultiSelect = false
Me.lvRepairNET.Name = "lvRepairNET"
Me.lvRepairNET.ShowItemToolTips = true
Me.lvRepairNET.Size = New System.Drawing.Size(641, 344)
Me.lvRepairNET.TabIndex = 4
Me.lvRepairNET.UseCompatibleStateImageBehavior = false
Me.lvRepairNET.View = System.Windows.Forms.View.Details
'
'gbNETNotes
'
Me.gbNETNotes.Controls.Add(Me.TableLayoutPanel15)
Me.gbNETNotes.Dock = System.Windows.Forms.DockStyle.Fill
Me.gbNETNotes.Location = New System.Drawing.Point(3, 3)
Me.gbNETNotes.Name = "gbNETNotes"
Me.gbNETNotes.Size = New System.Drawing.Size(647, 239)
Me.gbNETNotes.TabIndex = 3
Me.gbNETNotes.TabStop = false
Me.gbNETNotes.Text = "Заметки"
'
'TableLayoutPanel15
'
Me.TableLayoutPanel15.ColumnCount = 3
Me.TableLayoutPanel15.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 126!))
Me.TableLayoutPanel15.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100!))
Me.TableLayoutPanel15.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120!))
Me.TableLayoutPanel15.Controls.Add(Me.ToolStrip5, 2, 0)
Me.TableLayoutPanel15.Controls.Add(Me.lvNotesNET, 0, 2)
Me.TableLayoutPanel15.Controls.Add(Me.cmbNotesNETMaster, 1, 0)
Me.TableLayoutPanel15.Controls.Add(Me.NotesNETdate, 0, 0)
Me.TableLayoutPanel15.Controls.Add(Me.NotesNETtxt, 0, 1)
Me.TableLayoutPanel15.Dock = System.Windows.Forms.DockStyle.Fill
Me.TableLayoutPanel15.Location = New System.Drawing.Point(3, 16)
Me.TableLayoutPanel15.Name = "TableLayoutPanel15"
Me.TableLayoutPanel15.RowCount = 4
Me.TableLayoutPanel15.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25!))
Me.TableLayoutPanel15.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80!))
Me.TableLayoutPanel15.RowStyles.Add(New System.Windows.Forms.RowStyle())
Me.TableLayoutPanel15.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20!))
Me.TableLayoutPanel15.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20!))
Me.TableLayoutPanel15.Size = New System.Drawing.Size(641, 220)
Me.TableLayoutPanel15.TabIndex = 1
'
'ToolStrip5
'
Me.ToolStrip5.Dock = System.Windows.Forms.DockStyle.Fill
Me.ToolStrip5.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
Me.ToolStrip5.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnNETAdd, Me.ToolStripSeparator14, Me.btnNETNotesDel, Me.ToolStripSeparator15, Me.btnNETNotesCancel, Me.ToolStripSeparator16})
Me.ToolStrip5.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow
Me.ToolStrip5.Location = New System.Drawing.Point(521, 0)
Me.ToolStrip5.Name = "ToolStrip5"
Me.TableLayoutPanel15.SetRowSpan(Me.ToolStrip5, 2)
Me.ToolStrip5.Size = New System.Drawing.Size(120, 105)
Me.ToolStrip5.TabIndex = 14
Me.ToolStrip5.Text = "ToolStrip5"
'
'btnNETAdd
'
Me.btnNETAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
Me.btnNETAdd.Image = CType(resources.GetObject("btnNETAdd.Image"),System.Drawing.Image)
Me.btnNETAdd.ImageTransparentColor = System.Drawing.Color.Magenta
Me.btnNETAdd.Name = "btnNETAdd"
Me.btnNETAdd.Size = New System.Drawing.Size(118, 19)
Me.btnNETAdd.Text = "Добавить"
'
'ToolStripSeparator14
'
Me.ToolStripSeparator14.Name = "ToolStripSeparator14"
Me.ToolStripSeparator14.Size = New System.Drawing.Size(118, 6)
'
'btnNETNotesDel
'
Me.btnNETNotesDel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
Me.btnNETNotesDel.Image = CType(resources.GetObject("btnNETNotesDel.Image"),System.Drawing.Image)
Me.btnNETNotesDel.ImageTransparentColor = System.Drawing.Color.Magenta
Me.btnNETNotesDel.Name = "btnNETNotesDel"
Me.btnNETNotesDel.Size = New System.Drawing.Size(118, 19)
Me.btnNETNotesDel.Text = "Удалить"
'
'ToolStripSeparator15
'
Me.ToolStripSeparator15.Name = "ToolStripSeparator15"
Me.ToolStripSeparator15.Size = New System.Drawing.Size(118, 6)
'
'btnNETNotesCancel
'
Me.btnNETNotesCancel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
Me.btnNETNotesCancel.Image = CType(resources.GetObject("btnNETNotesCancel.Image"),System.Drawing.Image)
Me.btnNETNotesCancel.ImageTransparentColor = System.Drawing.Color.Magenta
Me.btnNETNotesCancel.Name = "btnNETNotesCancel"
Me.btnNETNotesCancel.Size = New System.Drawing.Size(118, 19)
Me.btnNETNotesCancel.Text = "Отмена"
'
'ToolStripSeparator16
'
Me.ToolStripSeparator16.Name = "ToolStripSeparator16"
Me.ToolStripSeparator16.Size = New System.Drawing.Size(118, 6)
'
'lvNotesNET
'
Me.TableLayoutPanel15.SetColumnSpan(Me.lvNotesNET, 3)
Me.lvNotesNET.Dock = System.Windows.Forms.DockStyle.Fill
Me.lvNotesNET.FullRowSelect = true
Me.lvNotesNET.GridLines = true
Me.lvNotesNET.Location = New System.Drawing.Point(3, 108)
Me.lvNotesNET.Name = "lvNotesNET"
Me.lvNotesNET.Size = New System.Drawing.Size(635, 109)
Me.lvNotesNET.TabIndex = 4
Me.lvNotesNET.UseCompatibleStateImageBehavior = false
Me.lvNotesNET.View = System.Windows.Forms.View.Details
'
'cmbNotesNETMaster
'
Me.cmbNotesNETMaster.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
Me.cmbNotesNETMaster.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
Me.cmbNotesNETMaster.Dock = System.Windows.Forms.DockStyle.Fill
Me.cmbNotesNETMaster.FormattingEnabled = true
Me.cmbNotesNETMaster.Location = New System.Drawing.Point(129, 3)
Me.cmbNotesNETMaster.Name = "cmbNotesNETMaster"
Me.cmbNotesNETMaster.Size = New System.Drawing.Size(389, 21)
Me.cmbNotesNETMaster.TabIndex = 2
'
'NotesNETdate
'
Me.NotesNETdate.Dock = System.Windows.Forms.DockStyle.Fill
Me.NotesNETdate.Location = New System.Drawing.Point(3, 3)
Me.NotesNETdate.Name = "NotesNETdate"
Me.NotesNETdate.Size = New System.Drawing.Size(120, 20)
Me.NotesNETdate.TabIndex = 1
'
'NotesNETtxt
'
Me.TableLayoutPanel15.SetColumnSpan(Me.NotesNETtxt, 2)
Me.NotesNETtxt.Dock = System.Windows.Forms.DockStyle.Fill
Me.NotesNETtxt.Location = New System.Drawing.Point(3, 28)
Me.NotesNETtxt.Multiline = true
Me.NotesNETtxt.Name = "NotesNETtxt"
Me.TableLayoutPanel15.SetRowSpan(Me.NotesNETtxt, 2)
Me.NotesNETtxt.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
Me.NotesNETtxt.Size = New System.Drawing.Size(515, 74)
Me.NotesNETtxt.TabIndex = 3
'
'TabPage17
'
Me.TabPage17.Controls.Add(Me.TableLayoutPanel68)
Me.TabPage17.Location = New System.Drawing.Point(4, 22)
Me.TabPage17.Name = "TabPage17"
Me.TabPage17.Size = New System.Drawing.Size(659, 620)
Me.TabPage17.TabIndex = 3
Me.TabPage17.Text = "Гарантия"
Me.TabPage17.UseVisualStyleBackColor = true
'
'TableLayoutPanel68
'
Me.TableLayoutPanel68.ColumnCount = 1
Me.TableLayoutPanel68.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100!))
Me.TableLayoutPanel68.Controls.Add(Me.gbPostNET, 0, 0)
Me.TableLayoutPanel68.Controls.Add(Me.gbSaleNet, 0, 1)
Me.TableLayoutPanel68.Dock = System.Windows.Forms.DockStyle.Fill
Me.TableLayoutPanel68.Location = New System.Drawing.Point(0, 0)
Me.TableLayoutPanel68.Name = "TableLayoutPanel68"
Me.TableLayoutPanel68.RowCount = 3
Me.TableLayoutPanel68.RowStyles.Add(New System.Windows.Forms.RowStyle())
Me.TableLayoutPanel68.RowStyles.Add(New System.Windows.Forms.RowStyle())
Me.TableLayoutPanel68.RowStyles.Add(New System.Windows.Forms.RowStyle())
Me.TableLayoutPanel68.Size = New System.Drawing.Size(659, 620)
Me.TableLayoutPanel68.TabIndex = 2
'
'gbPostNET
'
Me.gbPostNET.Controls.Add(Me.TableLayoutPanel58)
Me.gbPostNET.Dock = System.Windows.Forms.DockStyle.Fill
Me.gbPostNET.Location = New System.Drawing.Point(3, 3)
Me.gbPostNET.Name = "gbPostNET"
Me.gbPostNET.Size = New System.Drawing.Size(653, 91)
Me.gbPostNET.TabIndex = 0
Me.gbPostNET.TabStop = false
Me.gbPostNET.Text = "Поставщик"
'
'TableLayoutPanel58
'
Me.TableLayoutPanel58.ColumnCount = 4
Me.TableLayoutPanel58.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100!))
Me.TableLayoutPanel58.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50!))
Me.TableLayoutPanel58.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80!))
Me.TableLayoutPanel58.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50!))
Me.TableLayoutPanel58.Controls.Add(Me.dtGNETok, 3, 1)
Me.TableLayoutPanel58.Controls.Add(Me.Label39, 0, 0)
Me.TableLayoutPanel58.Controls.Add(Me.Label37, 2, 1)
Me.TableLayoutPanel58.Controls.Add(Me.cmbNETPostav, 1, 0)
Me.TableLayoutPanel58.Controls.Add(Me.dtGNETPr, 1, 1)
Me.TableLayoutPanel58.Controls.Add(Me.Label38, 0, 1)
Me.TableLayoutPanel58.Dock = System.Windows.Forms.DockStyle.Fill
Me.TableLayoutPanel58.Location = New System.Drawing.Point(3, 16)
Me.TableLayoutPanel58.Name = "TableLayoutPanel58"
Me.TableLayoutPanel58.RowCount = 2
Me.TableLayoutPanel58.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30!))
Me.TableLayoutPanel58.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30!))
Me.TableLayoutPanel58.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20!))
Me.TableLayoutPanel58.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20!))
Me.TableLayoutPanel58.Size = New System.Drawing.Size(647, 72)
Me.TableLayoutPanel58.TabIndex = 3
'
'dtGNETok
'
Me.dtGNETok.Anchor = System.Windows.Forms.AnchorStyles.Left
Me.dtGNETok.Location = New System.Drawing.Point(416, 41)
Me.dtGNETok.Name = "dtGNETok"
Me.dtGNETok.Size = New System.Drawing.Size(134, 20)
Me.dtGNETok.TabIndex = 9
Me.dtGNETok.Value = New Date(2013, 10, 25, 0, 0, 0, 0)
'
'Label39
'
Me.Label39.Anchor = System.Windows.Forms.AnchorStyles.Left
Me.Label39.AutoSize = true
Me.Label39.Location = New System.Drawing.Point(3, 8)
Me.Label39.Name = "Label39"
Me.Label39.Size = New System.Drawing.Size(57, 13)
Me.Label39.TabIndex = 5
Me.Label39.Text = "Продавец"
'
'Label37
'
Me.Label37.Anchor = System.Windows.Forms.AnchorStyles.Left
Me.Label37.AutoSize = true
Me.Label37.Location = New System.Drawing.Point(336, 44)
Me.Label37.Name = "Label37"
Me.Label37.Size = New System.Drawing.Size(65, 13)
Me.Label37.TabIndex = 10
Me.Label37.Text = "Окончание:"
'
'cmbNETPostav
'
Me.cmbNETPostav.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
Me.cmbNETPostav.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
Me.TableLayoutPanel58.SetColumnSpan(Me.cmbNETPostav, 3)
Me.cmbNETPostav.Dock = System.Windows.Forms.DockStyle.Fill
Me.cmbNETPostav.FormattingEnabled = true
Me.cmbNETPostav.Location = New System.Drawing.Point(103, 3)
Me.cmbNETPostav.Name = "cmbNETPostav"
Me.cmbNETPostav.Size = New System.Drawing.Size(541, 21)
Me.cmbNETPostav.TabIndex = 6
'
'dtGNETPr
'
Me.dtGNETPr.Anchor = System.Windows.Forms.AnchorStyles.Left
Me.dtGNETPr.Location = New System.Drawing.Point(103, 41)
Me.dtGNETPr.Name = "dtGNETPr"
Me.dtGNETPr.Size = New System.Drawing.Size(134, 20)
Me.dtGNETPr.TabIndex = 8
Me.dtGNETPr.Value = New Date(2013, 10, 25, 0, 0, 0, 0)
'
'Label38
'
Me.Label38.Anchor = System.Windows.Forms.AnchorStyles.Left
Me.Label38.AutoSize = true
Me.Label38.Location = New System.Drawing.Point(3, 44)
Me.Label38.Name = "Label38"
Me.Label38.Size = New System.Drawing.Size(77, 13)
Me.Label38.TabIndex = 7
Me.Label38.Text = "Приобретено:"
'
'gbSaleNet
'
Me.gbSaleNet.Controls.Add(Me.TableLayoutPanel53)
Me.gbSaleNet.Dock = System.Windows.Forms.DockStyle.Fill
Me.gbSaleNet.Location = New System.Drawing.Point(3, 100)
Me.gbSaleNet.Name = "gbSaleNet"
Me.gbSaleNet.Size = New System.Drawing.Size(653, 139)
Me.gbSaleNet.TabIndex = 1
Me.gbSaleNet.TabStop = false
Me.gbSaleNet.Text = "Данные о приобретении"
'
'TableLayoutPanel53
'
Me.TableLayoutPanel53.ColumnCount = 4
Me.TableLayoutPanel53.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100!))
Me.TableLayoutPanel53.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50!))
Me.TableLayoutPanel53.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80!))
Me.TableLayoutPanel53.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50!))
Me.TableLayoutPanel53.Controls.Add(Me.chkNETNNb, 3, 3)
Me.TableLayoutPanel53.Controls.Add(Me.txtNETSumm, 1, 2)
Me.TableLayoutPanel53.Controls.Add(Me.dtNETdataVvoda, 3, 2)
Me.TableLayoutPanel53.Controls.Add(Me.Label60, 0, 0)
Me.TableLayoutPanel53.Controls.Add(Me.txtNETZay, 3, 1)
Me.TableLayoutPanel53.Controls.Add(Me.Label55, 2, 2)
Me.TableLayoutPanel53.Controls.Add(Me.dtNETSFdate, 3, 0)
Me.TableLayoutPanel53.Controls.Add(Me.Label59, 0, 1)
Me.TableLayoutPanel53.Controls.Add(Me.txtNETcash, 1, 1)
Me.TableLayoutPanel53.Controls.Add(Me.Label56, 2, 1)
Me.TableLayoutPanel53.Controls.Add(Me.Label58, 0, 2)
Me.TableLayoutPanel53.Controls.Add(Me.txtNETSfN, 1, 0)
Me.TableLayoutPanel53.Controls.Add(Me.Label57, 2, 0)
Me.TableLayoutPanel53.Controls.Add(Me.chkNETspis, 0, 3)
Me.TableLayoutPanel53.Controls.Add(Me.dtNETSpisanie, 1, 3)
Me.TableLayoutPanel53.Dock = System.Windows.Forms.DockStyle.Fill
Me.TableLayoutPanel53.Location = New System.Drawing.Point(3, 16)
Me.TableLayoutPanel53.Name = "TableLayoutPanel53"
Me.TableLayoutPanel53.RowCount = 4
Me.TableLayoutPanel53.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30!))
Me.TableLayoutPanel53.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30!))
Me.TableLayoutPanel53.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30!))
Me.TableLayoutPanel53.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30!))
Me.TableLayoutPanel53.Size = New System.Drawing.Size(647, 120)
Me.TableLayoutPanel53.TabIndex = 3
'
'chkNETNNb
'
Me.chkNETNNb.Anchor = System.Windows.Forms.AnchorStyles.Left
Me.chkNETNNb.AutoSize = true
Me.chkNETNNb.Location = New System.Drawing.Point(416, 96)
Me.chkNETNNb.Name = "chkNETNNb"
Me.chkNETNNb.Size = New System.Drawing.Size(100, 17)
Me.chkNETNNb.TabIndex = 23
Me.chkNETNNb.Text = "Не на балансе"
Me.chkNETNNb.UseVisualStyleBackColor = true
'
'txtNETSumm
'
Me.txtNETSumm.Dock = System.Windows.Forms.DockStyle.Fill
Me.txtNETSumm.Location = New System.Drawing.Point(103, 63)
Me.txtNETSumm.Maximum = New Decimal(New Integer() {1000000, 0, 0, 0})
Me.txtNETSumm.Name = "txtNETSumm"
Me.txtNETSumm.Size = New System.Drawing.Size(227, 20)
Me.txtNETSumm.TabIndex = 17
'
'dtNETdataVvoda
'
Me.dtNETdataVvoda.Anchor = System.Windows.Forms.AnchorStyles.Left
Me.dtNETdataVvoda.Location = New System.Drawing.Point(416, 65)
Me.dtNETdataVvoda.Name = "dtNETdataVvoda"
Me.dtNETdataVvoda.Size = New System.Drawing.Size(228, 20)
Me.dtNETdataVvoda.TabIndex = 20
Me.dtNETdataVvoda.Value = New Date(2013, 10, 25, 0, 0, 0, 0)
'
'Label60
'
Me.Label60.Anchor = System.Windows.Forms.AnchorStyles.Left
Me.Label60.AutoSize = true
Me.Label60.Location = New System.Drawing.Point(3, 8)
Me.Label60.Name = "Label60"
Me.Label60.Size = New System.Drawing.Size(89, 13)
Me.Label60.TabIndex = 12
Me.Label60.Text = "Счёт фактура №"
'
'txtNETZay
'
Me.txtNETZay.Anchor = System.Windows.Forms.AnchorStyles.Left
Me.txtNETZay.Location = New System.Drawing.Point(416, 35)
Me.txtNETZay.Name = "txtNETZay"
Me.txtNETZay.Size = New System.Drawing.Size(228, 20)
Me.txtNETZay.TabIndex = 19
'
'Label55
'
Me.Label55.Anchor = System.Windows.Forms.AnchorStyles.Left
Me.Label55.AutoSize = true
Me.Label55.Location = New System.Drawing.Point(336, 68)
Me.Label55.Name = "Label55"
Me.Label55.Size = New System.Drawing.Size(66, 13)
Me.Label55.TabIndex = 25
Me.Label55.Text = "Дата ввода"
'
'dtNETSFdate
'
Me.dtNETSFdate.Anchor = System.Windows.Forms.AnchorStyles.Left
Me.dtNETSFdate.Location = New System.Drawing.Point(416, 5)
Me.dtNETSFdate.Name = "dtNETSFdate"
Me.dtNETSFdate.Size = New System.Drawing.Size(228, 20)
Me.dtNETSFdate.TabIndex = 18
Me.dtNETSFdate.Value = New Date(2013, 10, 25, 0, 0, 0, 0)
'
'Label59
'
Me.Label59.Anchor = System.Windows.Forms.AnchorStyles.Left
Me.Label59.AutoSize = true
Me.Label59.Location = New System.Drawing.Point(3, 38)
Me.Label59.Name = "Label59"
Me.Label59.Size = New System.Drawing.Size(33, 13)
Me.Label59.TabIndex = 14
Me.Label59.Text = "Цена"
'
'txtNETcash
'
Me.txtNETcash.Dock = System.Windows.Forms.DockStyle.Fill
Me.txtNETcash.Location = New System.Drawing.Point(103, 33)
Me.txtNETcash.Maximum = New Decimal(New Integer() {1000000, 0, 0, 0})
Me.txtNETcash.Name = "txtNETcash"
Me.txtNETcash.Size = New System.Drawing.Size(227, 20)
Me.txtNETcash.TabIndex = 16
'
'Label56
'
Me.Label56.Anchor = System.Windows.Forms.AnchorStyles.Left
Me.Label56.AutoSize = true
Me.Label56.Location = New System.Drawing.Point(336, 38)
Me.Label56.Name = "Label56"
Me.Label56.Size = New System.Drawing.Size(44, 13)
Me.Label56.TabIndex = 24
Me.Label56.Text = "Заявка"
'
'Label58
'
Me.Label58.Anchor = System.Windows.Forms.AnchorStyles.Left
Me.Label58.AutoSize = true
Me.Label58.Location = New System.Drawing.Point(3, 68)
Me.Label58.Name = "Label58"
Me.Label58.Size = New System.Drawing.Size(41, 13)
Me.Label58.TabIndex = 15
Me.Label58.Text = "Сумма"
'
'txtNETSfN
'
Me.txtNETSfN.Dock = System.Windows.Forms.DockStyle.Fill
Me.txtNETSfN.Location = New System.Drawing.Point(103, 3)
Me.txtNETSfN.Name = "txtNETSfN"
Me.txtNETSfN.Size = New System.Drawing.Size(227, 20)
Me.txtNETSfN.TabIndex = 13
'
'Label57
'
Me.Label57.Anchor = System.Windows.Forms.AnchorStyles.Left
Me.Label57.AutoSize = true
Me.Label57.Location = New System.Drawing.Point(336, 8)
Me.Label57.Name = "Label57"
Me.Label57.Size = New System.Drawing.Size(18, 13)
Me.Label57.TabIndex = 22
Me.Label57.Text = "от"
'
'chkNETspis
'
Me.chkNETspis.Anchor = System.Windows.Forms.AnchorStyles.Left
Me.chkNETspis.AutoSize = true
Me.chkNETspis.Location = New System.Drawing.Point(3, 96)
Me.chkNETspis.Name = "chkNETspis"
Me.chkNETspis.Size = New System.Drawing.Size(69, 17)
Me.chkNETspis.TabIndex = 21
Me.chkNETspis.Text = "Списано"
Me.chkNETspis.UseVisualStyleBackColor = true
'
'dtNETSpisanie
'
Me.dtNETSpisanie.Dock = System.Windows.Forms.DockStyle.Fill
Me.dtNETSpisanie.Location = New System.Drawing.Point(103, 93)
Me.dtNETSpisanie.Name = "dtNETSpisanie"
Me.dtNETSpisanie.Size = New System.Drawing.Size(227, 20)
Me.dtNETSpisanie.TabIndex = 26
Me.dtNETSpisanie.Value = New Date(2013, 7, 2, 0, 0, 0, 0)
'
'cmMENU
'
Me.cmMENU.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.addRemToolStripMenuItem, Me.CartrAddToolStripMenuItem, Me.CopyToolStripMenuItem, Me.UpdateToolStripMenuItem, Me.DeleteToolStripMenuItem, Me.ОтделитьПринтерыИМониторыToolStripMenuItem, Me.ВернутьПерефериюToolStripMenuItem, Me.СостояниеУстройстваToolStripMenuItem, Me.ППРToolStripMenuItem, Me.PingToolStripMenuItem})
Me.cmMENU.Name = "cmMENU"
Me.cmMENU.Size = New System.Drawing.Size(255, 224)
'
'addRemToolStripMenuItem
'
Me.addRemToolStripMenuItem.Name = "addRemToolStripMenuItem"
Me.addRemToolStripMenuItem.Size = New System.Drawing.Size(254, 22)
Me.addRemToolStripMenuItem.Text = "Добавить Заявку"
'
'CartrAddToolStripMenuItem
'
Me.CartrAddToolStripMenuItem.Name = "CartrAddToolStripMenuItem"
Me.CartrAddToolStripMenuItem.Size = New System.Drawing.Size(254, 22)
Me.CartrAddToolStripMenuItem.Text = "Добавить картридж"
'
'CopyToolStripMenuItem
'
Me.CopyToolStripMenuItem.Name = "CopyToolStripMenuItem"
Me.CopyToolStripMenuItem.Size = New System.Drawing.Size(254, 22)
Me.CopyToolStripMenuItem.Text = "Скопировать"
'
'UpdateToolStripMenuItem
'
Me.UpdateToolStripMenuItem.Name = "UpdateToolStripMenuItem"
Me.UpdateToolStripMenuItem.Size = New System.Drawing.Size(254, 22)
Me.UpdateToolStripMenuItem.Text = "Обновить"
'
'DeleteToolStripMenuItem
'
Me.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem"
Me.DeleteToolStripMenuItem.Size = New System.Drawing.Size(254, 22)
Me.DeleteToolStripMenuItem.Text = "Удалить"
'
'ОтделитьПринтерыИМониторыToolStripMenuItem
'
Me.ОтделитьПринтерыИМониторыToolStripMenuItem.Name = "ОтделитьПринтерыИМониторыToolStripMenuItem"
Me.ОтделитьПринтерыИМониторыToolStripMenuItem.Size = New System.Drawing.Size(254, 22)
Me.ОтделитьПринтерыИМониторыToolStripMenuItem.Text = "Отделить принтеры и мониторы"
'
'ВернутьПерефериюToolStripMenuItem
'
Me.ВернутьПерефериюToolStripMenuItem.Name = "ВернутьПерефериюToolStripMenuItem"
Me.ВернутьПерефериюToolStripMenuItem.Size = New System.Drawing.Size(254, 22)
Me.ВернутьПерефериюToolStripMenuItem.Text = "Вернуть переферию"
'
'СостояниеУстройстваToolStripMenuItem
'
Me.СостояниеУстройстваToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuSostOn, Me.mnuSostOff})
Me.СостояниеУстройстваToolStripMenuItem.Name = "СостояниеУстройстваToolStripMenuItem"
Me.СостояниеУстройстваToolStripMenuItem.Size = New System.Drawing.Size(254, 22)
Me.СостояниеУстройстваToolStripMenuItem.Text = "Состояние устройства"
Me.СостояниеУстройстваToolStripMenuItem.Visible = false
'
'mnuSostOn
'
Me.mnuSostOn.Name = "mnuSostOn"
Me.mnuSostOn.Size = New System.Drawing.Size(139, 22)
Me.mnuSostOn.Text = "В работе"
'
'mnuSostOff
'
Me.mnuSostOff.Name = "mnuSostOff"
Me.mnuSostOff.Size = New System.Drawing.Size(139, 22)
Me.mnuSostOff.Text = "Не в работе"
'
'ППРToolStripMenuItem
'
Me.ППРToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ТО1ToolStripMenuItem, Me.ТО2ToolStripMenuItem, Me.ТО3ToolStripMenuItem, Me.ТО4ToolStripMenuItem, Me.ТО5ToolStripMenuItem, Me.ТО6ToolStripMenuItem})
Me.ППРToolStripMenuItem.Name = "ППРToolStripMenuItem"
Me.ППРToolStripMenuItem.Size = New System.Drawing.Size(254, 22)
Me.ППРToolStripMenuItem.Text = "ППР"
'
'ТО1ToolStripMenuItem
'
Me.ТО1ToolStripMenuItem.Name = "ТО1ToolStripMenuItem"
Me.ТО1ToolStripMenuItem.Size = New System.Drawing.Size(96, 22)
Me.ТО1ToolStripMenuItem.Text = "ТО1"
'
'ТО2ToolStripMenuItem
'
Me.ТО2ToolStripMenuItem.Name = "ТО2ToolStripMenuItem"
Me.ТО2ToolStripMenuItem.Size = New System.Drawing.Size(96, 22)
Me.ТО2ToolStripMenuItem.Text = "ТО2"
'
'ТО3ToolStripMenuItem
'
Me.ТО3ToolStripMenuItem.Name = "ТО3ToolStripMenuItem"
Me.ТО3ToolStripMenuItem.Size = New System.Drawing.Size(96, 22)
Me.ТО3ToolStripMenuItem.Text = "ТО3"
'
'ТО4ToolStripMenuItem
'
Me.ТО4ToolStripMenuItem.Name = "ТО4ToolStripMenuItem"
Me.ТО4ToolStripMenuItem.Size = New System.Drawing.Size(96, 22)
Me.ТО4ToolStripMenuItem.Text = "ТО4"
'
'ТО5ToolStripMenuItem
'
Me.ТО5ToolStripMenuItem.Name = "ТО5ToolStripMenuItem"
Me.ТО5ToolStripMenuItem.Size = New System.Drawing.Size(96, 22)
Me.ТО5ToolStripMenuItem.Text = "ТО5"
'
'ТО6ToolStripMenuItem
'
Me.ТО6ToolStripMenuItem.Name = "ТО6ToolStripMenuItem"
Me.ТО6ToolStripMenuItem.Size = New System.Drawing.Size(96, 22)
Me.ТО6ToolStripMenuItem.Text = "ТО6"
'
'PingToolStripMenuItem
'
Me.PingToolStripMenuItem.Name = "PingToolStripMenuItem"
Me.PingToolStripMenuItem.Size = New System.Drawing.Size(254, 22)
Me.PingToolStripMenuItem.Text = "Ping"
'
'cmBmenu
'
Me.cmBmenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuDeltoBranch, Me.addFoldertoBranch, Me.DeleteBranche, Me.RepAddBrToolStripMenuItem, Me.SoftInstallToolStripMenuItem, Me.ПаспортКомпьютераToolStripMenuItem, Me.MassRazdelPerf, Me.MassObedPerf, Me.MassUpdatetoINI})
Me.cmBmenu.Name = "cmMENU"
Me.cmBmenu.Size = New System.Drawing.Size(222, 202)
'
'mnuDeltoBranch
'
Me.mnuDeltoBranch.Name = "mnuDeltoBranch"
Me.mnuDeltoBranch.Size = New System.Drawing.Size(221, 22)
Me.mnuDeltoBranch.Text = "Удалить из..."
'
'addFoldertoBranch
'
Me.addFoldertoBranch.Name = "addFoldertoBranch"
Me.addFoldertoBranch.Size = New System.Drawing.Size(221, 22)
Me.addFoldertoBranch.Text = "Добавить папку в... (ini)"
'
'DeleteBranche
'
Me.DeleteBranche.Name = "DeleteBranche"
Me.DeleteBranche.Size = New System.Drawing.Size(221, 22)
Me.DeleteBranche.Text = "Удалить"
'
'RepAddBrToolStripMenuItem
'
Me.RepAddBrToolStripMenuItem.Name = "RepAddBrToolStripMenuItem"
Me.RepAddBrToolStripMenuItem.Size = New System.Drawing.Size(221, 22)
Me.RepAddBrToolStripMenuItem.Text = "Добавить заявку"
'
'SoftInstallToolStripMenuItem
'
Me.SoftInstallToolStripMenuItem.Name = "SoftInstallToolStripMenuItem"
Me.SoftInstallToolStripMenuItem.Size = New System.Drawing.Size(221, 22)
Me.SoftInstallToolStripMenuItem.Text = "Установленное П.О."
'
'ПаспортКомпьютераToolStripMenuItem
'
Me.ПаспортКомпьютераToolStripMenuItem.Name = "ПаспортКомпьютераToolStripMenuItem"
Me.ПаспортКомпьютераToolStripMenuItem.Size = New System.Drawing.Size(221, 22)
Me.ПаспортКомпьютераToolStripMenuItem.Text = "Паспорт компьютера"
'
'MassRazdelPerf
'
Me.MassRazdelPerf.Name = "MassRazdelPerf"
Me.MassRazdelPerf.Size = New System.Drawing.Size(221, 22)
Me.MassRazdelPerf.Text = "Отделить переферию"
'
'MassObedPerf
'
Me.MassObedPerf.Name = "MassObedPerf"
Me.MassObedPerf.Size = New System.Drawing.Size(221, 22)
Me.MassObedPerf.Text = "Присоеденить переферию"
'
'MassUpdatetoINI
'
Me.MassUpdatetoINI.Name = "MassUpdatetoINI"
Me.MassUpdatetoINI.Size = New System.Drawing.Size(221, 22)
Me.MassUpdatetoINI.Text = "Обновить из папки"
'
'TableLayoutPanel2
'
Me.TableLayoutPanel2.ColumnCount = 1
Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50!))
Me.TableLayoutPanel2.Controls.Add(Me.Button1, 0, 0)
Me.TableLayoutPanel2.Controls.Add(Me.Button2, 0, 1)
Me.TableLayoutPanel2.Location = New System.Drawing.Point(0, 0)
Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
Me.TableLayoutPanel2.RowCount = 3
Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20!))
Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20!))
Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20!))
Me.TableLayoutPanel2.Size = New System.Drawing.Size(200, 100)
Me.TableLayoutPanel2.TabIndex = 0
'
'Button1
'
Me.Button1.Location = New System.Drawing.Point(3, 3)
Me.Button1.Name = "Button1"
Me.Button1.Size = New System.Drawing.Size(93, 14)
Me.Button1.TabIndex = 38
Me.Button1.Text = "Расшифровать"
Me.Button1.UseVisualStyleBackColor = true
'
'Button2
'
Me.Button2.Location = New System.Drawing.Point(3, 23)
Me.Button2.Name = "Button2"
Me.Button2.Size = New System.Drawing.Size(93, 14)
Me.Button2.TabIndex = 37
Me.Button2.Text = "Удалить"
Me.Button2.UseVisualStyleBackColor = true
'
'Button3
'
Me.Button3.Location = New System.Drawing.Point(3, -10)
Me.Button3.Name = "Button3"
Me.Button3.Size = New System.Drawing.Size(93, 22)
Me.Button3.TabIndex = 36
Me.Button3.Text = "Добавить"
Me.Button3.UseVisualStyleBackColor = true
'
'cmDvig
'
Me.cmDvig.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DELTEdVIGToolStripMenuItem})
Me.cmDvig.Name = "cmDvig"
Me.cmDvig.Size = New System.Drawing.Size(119, 26)
'
'DELTEdVIGToolStripMenuItem
'
Me.DELTEdVIGToolStripMenuItem.Name = "DELTEdVIGToolStripMenuItem"
Me.DELTEdVIGToolStripMenuItem.Size = New System.Drawing.Size(118, 22)
Me.DELTEdVIGToolStripMenuItem.Text = "Удалить"
'
'CMServices
'
Me.CMServices.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EditService, Me.DeleteService, Me.MnuSendEmail, Me.addServiseWork, Me.ПечатьToolStripMenuItem})
Me.CMServices.Name = "CMServices"
Me.CMServices.Size = New System.Drawing.Size(175, 114)
'
'EditService
'
Me.EditService.Name = "EditService"
Me.EditService.Size = New System.Drawing.Size(174, 22)
Me.EditService.Text = "Редактировать"
'
'DeleteService
'
Me.DeleteService.Name = "DeleteService"
Me.DeleteService.Size = New System.Drawing.Size(174, 22)
Me.DeleteService.Text = "Удалить"
'
'MnuSendEmail
'
Me.MnuSendEmail.Name = "MnuSendEmail"
Me.MnuSendEmail.Size = New System.Drawing.Size(174, 22)
Me.MnuSendEmail.Text = "Отправить матеру"
'
'addServiseWork
'
Me.addServiseWork.Name = "addServiseWork"
Me.addServiseWork.Size = New System.Drawing.Size(174, 22)
Me.addServiseWork.Text = "Добавить работы"
'
'ПечатьToolStripMenuItem
'
Me.ПечатьToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnu_Z_to_Office, Me.РаспискаToolStripMenuItem, Me.НарядToolStripMenuItem, Me.МатериальныйПропускToolStripMenuItem, Me.БланкToolStripMenuItem})
Me.ПечатьToolStripMenuItem.Name = "ПечатьToolStripMenuItem"
Me.ПечатьToolStripMenuItem.Size = New System.Drawing.Size(174, 22)
Me.ПечатьToolStripMenuItem.Text = "Печать"
'
'mnu_Z_to_Office
'
Me.mnu_Z_to_Office.Name = "mnu_Z_to_Office"
Me.mnu_Z_to_Office.Size = New System.Drawing.Size(207, 22)
Me.mnu_Z_to_Office.Text = "Акт-Заявка"
'
'РаспискаToolStripMenuItem
'
Me.РаспискаToolStripMenuItem.Name = "РаспискаToolStripMenuItem"
Me.РаспискаToolStripMenuItem.Size = New System.Drawing.Size(207, 22)
Me.РаспискаToolStripMenuItem.Text = "Расписка"
'
'НарядToolStripMenuItem
'
Me.НарядToolStripMenuItem.Name = "НарядToolStripMenuItem"
Me.НарядToolStripMenuItem.Size = New System.Drawing.Size(207, 22)
Me.НарядToolStripMenuItem.Text = "Наряд"
'
'МатериальныйПропускToolStripMenuItem
'
Me.МатериальныйПропускToolStripMenuItem.Name = "МатериальныйПропускToolStripMenuItem"
Me.МатериальныйПропускToolStripMenuItem.Size = New System.Drawing.Size(207, 22)
Me.МатериальныйПропускToolStripMenuItem.Text = "Материальный пропуск"
'
'БланкToolStripMenuItem
'
Me.БланкToolStripMenuItem.Name = "БланкToolStripMenuItem"
Me.БланкToolStripMenuItem.Size = New System.Drawing.Size(207, 22)
Me.БланкToolStripMenuItem.Text = "Бланк"
'
'ilsCommands
'
Me.ilsCommands.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit
Me.ilsCommands.ImageSize = New System.Drawing.Size(24, 24)
Me.ilsCommands.TransparentColor = System.Drawing.Color.White
'
'frmComputers
'
Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
Me.ClientSize = New System.Drawing.Size(957, 646)
Me.Controls.Add(Me.spCont)
Me.DoubleBuffered = true
Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
Me.MinimumSize = New System.Drawing.Size(902, 601)
Me.Name = "frmComputers"
Me.Text = "Учёт оргтехники"
Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
Me.spCont.Panel1.ResumeLayout(false)
Me.spCont.Panel2.ResumeLayout(false)
CType(Me.spCont,System.ComponentModel.ISupportInitialize).EndInit
Me.spCont.ResumeLayout(false)
Me.TableLayoutPanel65.ResumeLayout(false)
Me.gbTree.ResumeLayout(false)
Me.TableLayoutPanel64.ResumeLayout(false)
Me.TableLayoutPanel64.PerformLayout
Me.ToolStrip7.ResumeLayout(false)
Me.ToolStrip7.PerformLayout
Me.sSTAB3.ResumeLayout(false)
Me.TabPage11.ResumeLayout(false)
Me.TableLayoutPanel22.ResumeLayout(false)
Me.TableLayoutPanel22.PerformLayout
Me.gbSNMP.ResumeLayout(false)
Me.TableLayoutPanel3.ResumeLayout(false)
Me.TableLayoutPanel3.PerformLayout
Me.gbOTh.ResumeLayout(false)
Me.gbOTh.PerformLayout
Me.TableLayoutPanel7.ResumeLayout(false)
Me.TableLayoutPanel7.PerformLayout
Me.TabPage22.ResumeLayout(false)
Me.TabPage12.ResumeLayout(false)
Me.TableLayoutPanel17.ResumeLayout(false)
Me.TableLayoutPanel17.PerformLayout
Me.gbOTHRemont.ResumeLayout(false)
Me.gbOTHNotes.ResumeLayout(false)
Me.TableLayoutPanel18.ResumeLayout(false)
Me.TableLayoutPanel18.PerformLayout
Me.ToolStrip6.ResumeLayout(false)
Me.ToolStrip6.PerformLayout
Me.TabPage18.ResumeLayout(false)
Me.TableLayoutPanel70.ResumeLayout(false)
Me.TableLayoutPanel70.PerformLayout
Me.gbPostOTH.ResumeLayout(false)
Me.TableLayoutPanel56.ResumeLayout(false)
Me.TableLayoutPanel56.PerformLayout
Me.gbSaleOTH.ResumeLayout(false)
Me.gbSaleOTH.PerformLayout
Me.TableLayoutPanel54.ResumeLayout(false)
Me.TableLayoutPanel54.PerformLayout
CType(Me.txtOTHSumm,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.txtOTHcash,System.ComponentModel.ISupportInitialize).EndInit
Me.sSTAB1.ResumeLayout(false)
Me.TabPage6.ResumeLayout(false)
Me.TableLayoutPanel20.ResumeLayout(false)
Me.TableLayoutPanel20.PerformLayout
Me.gbMovement.ResumeLayout(false)
Me.gbInNumber.ResumeLayout(false)
Me.gbInNumber.PerformLayout
Me.TableLayoutPanel47.ResumeLayout(false)
Me.TableLayoutPanel47.PerformLayout
Me.TabPage1.ResumeLayout(false)
Me.TableLayoutPanel63.ResumeLayout(false)
Me.TableLayoutPanel63.PerformLayout
Me.gbcpu.ResumeLayout(false)
Me.gbcpu.PerformLayout
Me.TableLayoutPanel24.ResumeLayout(false)
Me.TableLayoutPanel24.PerformLayout
Me.ToolStrip8.ResumeLayout(false)
Me.ToolStrip8.PerformLayout
Me.gbSOUND.ResumeLayout(false)
Me.gbSOUND.PerformLayout
Me.TableLayoutPanel28.ResumeLayout(false)
Me.TableLayoutPanel28.PerformLayout
Me.gbMB.ResumeLayout(false)
Me.gbMB.PerformLayout
Me.TableLayoutPanel29.ResumeLayout(false)
Me.TableLayoutPanel29.PerformLayout
Me.gbSVGA.ResumeLayout(false)
Me.gbSVGA.PerformLayout
Me.TableLayoutPanel27.ResumeLayout(false)
Me.TableLayoutPanel27.PerformLayout
Me.ToolStrip11.ResumeLayout(false)
Me.ToolStrip11.PerformLayout
Me.gbRAM.ResumeLayout(false)
Me.gbRAM.PerformLayout
Me.TableLayoutPanel25.ResumeLayout(false)
Me.TableLayoutPanel25.PerformLayout
Me.ToolStrip9.ResumeLayout(false)
Me.ToolStrip9.PerformLayout
Me.gbHDD.ResumeLayout(false)
Me.gbHDD.PerformLayout
Me.TableLayoutPanel26.ResumeLayout(false)
Me.TableLayoutPanel26.PerformLayout
Me.ToolStrip10.ResumeLayout(false)
Me.ToolStrip10.PerformLayout
Me.gbOptical.ResumeLayout(false)
Me.gbOptical.PerformLayout
Me.TableLayoutPanel30.ResumeLayout(false)
Me.TableLayoutPanel30.PerformLayout
Me.ToolStrip12.ResumeLayout(false)
Me.ToolStrip12.PerformLayout
Me.gbNetwork.ResumeLayout(false)
Me.gbNetwork.PerformLayout
Me.TableLayoutPanel31.ResumeLayout(false)
Me.TableLayoutPanel31.PerformLayout
Me.ToolStrip13.ResumeLayout(false)
Me.ToolStrip13.PerformLayout
Me.gbFDD.ResumeLayout(false)
Me.gbFDD.PerformLayout
Me.TableLayoutPanel32.ResumeLayout(false)
Me.TableLayoutPanel32.PerformLayout
Me.gbCreader.ResumeLayout(false)
Me.gbCreader.PerformLayout
Me.TableLayoutPanel33.ResumeLayout(false)
Me.TableLayoutPanel33.PerformLayout
Me.gbModem.ResumeLayout(false)
Me.gbModem.PerformLayout
Me.TableLayoutPanel34.ResumeLayout(false)
Me.TableLayoutPanel34.PerformLayout
Me.gbCase.ResumeLayout(false)
Me.gbCase.PerformLayout
Me.TableLayoutPanel35.ResumeLayout(false)
Me.TableLayoutPanel35.PerformLayout
Me.gbBP.ResumeLayout(false)
Me.gbBP.PerformLayout
Me.TableLayoutPanel36.ResumeLayout(false)
Me.TableLayoutPanel36.PerformLayout
Me.gbUSB.ResumeLayout(false)
Me.gbUSB.PerformLayout
Me.TableLayoutPanel37.ResumeLayout(false)
Me.TableLayoutPanel37.PerformLayout
Me.gbPCI.ResumeLayout(false)
Me.gbPCI.PerformLayout
Me.TableLayoutPanel38.ResumeLayout(false)
Me.TableLayoutPanel38.PerformLayout
Me.gbSBP.ResumeLayout(false)
Me.gbSBP.PerformLayout
Me.TableLayoutPanel39.ResumeLayout(false)
Me.TableLayoutPanel39.PerformLayout
Me.TabPage3.ResumeLayout(false)
Me.TableLayoutPanel61.ResumeLayout(false)
Me.TableLayoutPanel61.PerformLayout
Me.gbMonitor.ResumeLayout(false)
Me.gbMonitor.PerformLayout
Me.TableLayoutPanel40.ResumeLayout(false)
Me.TableLayoutPanel40.PerformLayout
Me.ToolStrip14.ResumeLayout(false)
Me.ToolStrip14.PerformLayout
Me.gbPrinters.ResumeLayout(false)
Me.gbPrinters.PerformLayout
Me.TableLayoutPanel41.ResumeLayout(false)
Me.TableLayoutPanel41.PerformLayout
Me.ToolStrip15.ResumeLayout(false)
Me.ToolStrip15.PerformLayout
Me.gbIBP.ResumeLayout(false)
Me.gbIBP.PerformLayout
Me.TableLayoutPanel46.ResumeLayout(false)
Me.TableLayoutPanel46.PerformLayout
Me.gbKeyboard.ResumeLayout(false)
Me.gbKeyboard.PerformLayout
Me.TableLayoutPanel42.ResumeLayout(false)
Me.TableLayoutPanel42.PerformLayout
Me.gbMouse.ResumeLayout(false)
Me.gbMouse.PerformLayout
Me.TableLayoutPanel43.ResumeLayout(false)
Me.TableLayoutPanel43.PerformLayout
Me.gbFilter.ResumeLayout(false)
Me.gbFilter.PerformLayout
Me.TableLayoutPanel45.ResumeLayout(false)
Me.TableLayoutPanel45.PerformLayout
Me.gbAsystem.ResumeLayout(false)
Me.gbAsystem.PerformLayout
Me.TableLayoutPanel44.ResumeLayout(false)
Me.TableLayoutPanel44.PerformLayout
Me.TabPage4.ResumeLayout(false)
Me.TableLayoutPanel10.ResumeLayout(false)
Me.gbSoftEd.ResumeLayout(false)
Me.TableLayoutPanel13.ResumeLayout(false)
Me.TableLayoutPanel13.PerformLayout
Me.ToolStrip16.ResumeLayout(false)
Me.ToolStrip16.PerformLayout
Me.TabPage5.ResumeLayout(false)
Me.TableLayoutPanel1.ResumeLayout(false)
Me.TableLayoutPanel1.PerformLayout
Me.TableLayoutPanel4.ResumeLayout(false)
Me.TableLayoutPanel4.PerformLayout
Me.ToolStrip1.ResumeLayout(false)
Me.ToolStrip1.PerformLayout
Me.TabPage7.ResumeLayout(false)
Me.TabPage7.PerformLayout
Me.TableLayoutPanel5.ResumeLayout(false)
Me.TableLayoutPanel5.PerformLayout
Me.gbRepair.ResumeLayout(false)
Me.gbNotes.ResumeLayout(false)
Me.gbNotes.PerformLayout
Me.TableLayoutPanel6.ResumeLayout(false)
Me.TableLayoutPanel6.PerformLayout
Me.ToolStrip2.ResumeLayout(false)
Me.ToolStrip2.PerformLayout
Me.TabPage8.ResumeLayout(false)
Me.TabPage8.PerformLayout
Me.TableLayoutPanel66.ResumeLayout(false)
Me.TableLayoutPanel66.PerformLayout
Me.gbGuarantee.ResumeLayout(false)
Me.gbGuarantee.PerformLayout
Me.TableLayoutPanel59.ResumeLayout(false)
Me.TableLayoutPanel59.PerformLayout
Me.gbSeller.ResumeLayout(false)
Me.TableLayoutPanel60.ResumeLayout(false)
Me.TableLayoutPanel60.PerformLayout
Me.gbSale.ResumeLayout(false)
Me.gbSale.PerformLayout
Me.TableLayoutPanel23.ResumeLayout(false)
Me.TableLayoutPanel23.PerformLayout
CType(Me.txtPCSumm,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.txtPCcash,System.ComponentModel.ISupportInitialize).EndInit
Me.sSTAB5.ResumeLayout(false)
Me.TabPage19.ResumeLayout(false)
Me.TableLayoutPanel71.ResumeLayout(false)
Me.TableLayoutPanel71.PerformLayout
Me.TabPage20.ResumeLayout(false)
Me.TableLayoutPanel8.ResumeLayout(false)
Me.gbBRRemont.ResumeLayout(false)
Me.gbBRNotes.ResumeLayout(false)
Me.TableLayoutPanel9.ResumeLayout(false)
Me.TableLayoutPanel9.PerformLayout
Me.ToolStrip3.ResumeLayout(false)
Me.ToolStrip3.PerformLayout
Me.TabPage21.ResumeLayout(false)
Me.TableLayoutPanel73.ResumeLayout(false)
Me.TableLayoutPanel73.PerformLayout
Me.sSTAB2.ResumeLayout(false)
Me.TabPage9.ResumeLayout(false)
Me.TableLayoutPanel21.ResumeLayout(false)
Me.TableLayoutPanel21.PerformLayout
Me.gbPRNCartr.ResumeLayout(false)
Me.gbPRN.ResumeLayout(false)
Me.TableLayoutPanel55.ResumeLayout(false)
Me.TableLayoutPanel55.PerformLayout
Me.gbPRN_USTR.ResumeLayout(false)
Me.TabPage23.ResumeLayout(false)
Me.TabPage10.ResumeLayout(false)
Me.TableLayoutPanel11.ResumeLayout(false)
Me.gbPRNRemont.ResumeLayout(false)
Me.gbPRNNotes.ResumeLayout(false)
Me.TableLayoutPanel12.ResumeLayout(false)
Me.TableLayoutPanel12.PerformLayout
Me.ToolStrip4.ResumeLayout(false)
Me.ToolStrip4.PerformLayout
Me.TabPage16.ResumeLayout(false)
Me.TableLayoutPanel67.ResumeLayout(false)
Me.gbPostPRN.ResumeLayout(false)
Me.TableLayoutPanel57.ResumeLayout(false)
Me.TableLayoutPanel57.PerformLayout
Me.gbSalePRN.ResumeLayout(false)
Me.TableLayoutPanel52.ResumeLayout(false)
Me.TableLayoutPanel52.PerformLayout
CType(Me.txtPRNSumm,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.txtPRNcash,System.ComponentModel.ISupportInitialize).EndInit
Me.sSTAB4.ResumeLayout(false)
Me.TabPage13.ResumeLayout(false)
Me.TableLayoutPanel69.ResumeLayout(false)
Me.TableLayoutPanel49.ResumeLayout(false)
Me.TableLayoutPanel49.PerformLayout
Me.gbNet.ResumeLayout(false)
Me.TableLayoutPanel51.ResumeLayout(false)
Me.gbExNet.ResumeLayout(false)
Me.TableLayoutPanel48.ResumeLayout(false)
Me.TableLayoutPanel48.PerformLayout
Me.TabPage14.ResumeLayout(false)
Me.gbNetPortMapping.ResumeLayout(false)
Me.TableLayoutPanel50.ResumeLayout(false)
Me.TableLayoutPanel50.PerformLayout
Me.TabPage24.ResumeLayout(false)
Me.TabPage15.ResumeLayout(false)
Me.TableLayoutPanel14.ResumeLayout(false)
Me.gbNETRemont.ResumeLayout(false)
Me.gbNETNotes.ResumeLayout(false)
Me.TableLayoutPanel15.ResumeLayout(false)
Me.TableLayoutPanel15.PerformLayout
Me.ToolStrip5.ResumeLayout(false)
Me.ToolStrip5.PerformLayout
Me.TabPage17.ResumeLayout(false)
Me.TableLayoutPanel68.ResumeLayout(false)
Me.gbPostNET.ResumeLayout(false)
Me.TableLayoutPanel58.ResumeLayout(false)
Me.TableLayoutPanel58.PerformLayout
Me.gbSaleNet.ResumeLayout(false)
Me.TableLayoutPanel53.ResumeLayout(false)
Me.TableLayoutPanel53.PerformLayout
CType(Me.txtNETSumm,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.txtNETcash,System.ComponentModel.ISupportInitialize).EndInit
Me.cmMENU.ResumeLayout(false)
Me.cmBmenu.ResumeLayout(false)
Me.TableLayoutPanel2.ResumeLayout(false)
Me.cmDvig.ResumeLayout(false)
Me.CMServices.ResumeLayout(false)
Me.ResumeLayout(false)

End Sub
    Friend WithEvents spCont As System.Windows.Forms.SplitContainer
    Friend WithEvents sSTAB2 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage9 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage10 As System.Windows.Forms.TabPage
    Friend WithEvents gbTree As System.Windows.Forms.GroupBox
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents sSTAB3 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage11 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage12 As System.Windows.Forms.TabPage
    Friend WithEvents cmMENU As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents addRemToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents sSTAB4 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage13 As System.Windows.Forms.TabPage
    Friend WithEvents gbExNet As System.Windows.Forms.GroupBox
    Friend WithEvents gbNet As System.Windows.Forms.GroupBox
    Friend WithEvents TabPage14 As System.Windows.Forms.TabPage
    Friend WithEvents gbNetPortMapping As System.Windows.Forms.GroupBox
    Friend WithEvents TabPage15 As System.Windows.Forms.TabPage
    Friend WithEvents CopyToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UpdateToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeleteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmBmenu As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents mnuDeltoBranch As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents addFoldertoBranch As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeleteBranche As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TabPage17 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage16 As System.Windows.Forms.TabPage
    Friend WithEvents gbPostPRN As System.Windows.Forms.GroupBox
    Friend WithEvents gbPostNET As System.Windows.Forms.GroupBox
    Friend WithEvents TabPage18 As System.Windows.Forms.TabPage
    Friend WithEvents gbPostOTH As System.Windows.Forms.GroupBox
    Friend WithEvents gbSalePRN As System.Windows.Forms.GroupBox
    Friend WithEvents gbSaleNet As System.Windows.Forms.GroupBox
    Friend WithEvents gbSaleOTH As System.Windows.Forms.GroupBox
    Friend WithEvents RepAddBrToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents sSTAB5 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage19 As System.Windows.Forms.TabPage
    Friend WithEvents txtBRMemo As System.Windows.Forms.TextBox
    Friend WithEvents Label67 As System.Windows.Forms.Label
    Friend WithEvents txtBRPhone As System.Windows.Forms.TextBox
    Friend WithEvents Label68 As System.Windows.Forms.Label
    Friend WithEvents txtBRBoss As System.Windows.Forms.TextBox
    Friend WithEvents Label69 As System.Windows.Forms.Label
    Friend WithEvents txtBRAddress As System.Windows.Forms.TextBox
    Friend WithEvents Label70 As System.Windows.Forms.Label
    Friend WithEvents TabPage20 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage21 As System.Windows.Forms.TabPage
    Friend WithEvents txtSpMebel As System.Windows.Forms.TextBox
    Friend WithEvents Label71 As System.Windows.Forms.Label
    Friend WithEvents txtSpWall As System.Windows.Forms.TextBox
    Friend WithEvents Label72 As System.Windows.Forms.Label
    Friend WithEvents cmbSpKanal As System.Windows.Forms.ComboBox
    Friend WithEvents Label73 As System.Windows.Forms.Label
    Friend WithEvents cmbSpTeplo As System.Windows.Forms.ComboBox
    Friend WithEvents Label74 As System.Windows.Forms.Label
    Friend WithEvents cmbSpWater As System.Windows.Forms.ComboBox
    Friend WithEvents Label75 As System.Windows.Forms.Label
    Friend WithEvents cmbSpVent As System.Windows.Forms.ComboBox
    Friend WithEvents Label76 As System.Windows.Forms.Label
    Friend WithEvents Label77 As System.Windows.Forms.Label
    Friend WithEvents cmbSpRemEVM As System.Windows.Forms.ComboBox
    Friend WithEvents Label78 As System.Windows.Forms.Label
    Friend WithEvents txtspObOneEVM As System.Windows.Forms.TextBox
    Friend WithEvents Label79 As System.Windows.Forms.Label
    Friend WithEvents txtspPloOneEVM As System.Windows.Forms.TextBox
    Friend WithEvents Label80 As System.Windows.Forms.Label
    Friend WithEvents txtspvis As System.Windows.Forms.TextBox
    Friend WithEvents Label81 As System.Windows.Forms.Label
    Friend WithEvents txtspplo As System.Windows.Forms.TextBox
    Friend WithEvents Label82 As System.Windows.Forms.Label
    Friend WithEvents btnOfficeSend As System.Windows.Forms.Button
    Friend WithEvents SoftInstallToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ПаспортКомпьютераToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ОтделитьПринтерыИМониторыToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents TableLayoutPanel8 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents gbBRRemont As System.Windows.Forms.GroupBox
    Friend WithEvents lvRepairBR As System.Windows.Forms.ListView
    Friend WithEvents gbBRNotes As System.Windows.Forms.GroupBox
    Friend WithEvents TableLayoutPanel9 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents lvNotesBR As System.Windows.Forms.ListView
    Friend WithEvents Notesbrtxt As System.Windows.Forms.TextBox
    Friend WithEvents cmbBRMaster As System.Windows.Forms.ComboBox
    Friend WithEvents Notesbrdate As System.Windows.Forms.DateTimePicker
    Friend WithEvents TableLayoutPanel11 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents gbPRNRemont As System.Windows.Forms.GroupBox
    Friend WithEvents lvRepairPRN As System.Windows.Forms.ListView
    Friend WithEvents gbPRNNotes As System.Windows.Forms.GroupBox
    Friend WithEvents TableLayoutPanel12 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents lvNotesPRN As System.Windows.Forms.ListView
    Friend WithEvents NotesPRNtxt As System.Windows.Forms.TextBox
    Friend WithEvents cmbNotesPRNMaster As System.Windows.Forms.ComboBox
    Friend WithEvents NotesPRNdate As System.Windows.Forms.DateTimePicker
    Friend WithEvents TableLayoutPanel14 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents gbNETRemont As System.Windows.Forms.GroupBox
    Friend WithEvents lvRepairNET As System.Windows.Forms.ListView
    Friend WithEvents gbNETNotes As System.Windows.Forms.GroupBox
    Friend WithEvents TableLayoutPanel15 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents lvNotesNET As System.Windows.Forms.ListView
    Friend WithEvents NotesNETtxt As System.Windows.Forms.TextBox
    Friend WithEvents cmbNotesNETMaster As System.Windows.Forms.ComboBox
    Friend WithEvents NotesNETdate As System.Windows.Forms.DateTimePicker
    Friend WithEvents TableLayoutPanel17 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents gbOTHRemont As System.Windows.Forms.GroupBox
    Friend WithEvents lvRepairOTH As System.Windows.Forms.ListView
    Friend WithEvents gbOTHNotes As System.Windows.Forms.GroupBox
    Friend WithEvents TableLayoutPanel18 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents lvNotesOTH As System.Windows.Forms.ListView
    Friend WithEvents txtNotesOTH As System.Windows.Forms.TextBox
    Friend WithEvents cmbNotesOTHMaster As System.Windows.Forms.ComboBox
    Friend WithEvents NotesOTHdate As System.Windows.Forms.DateTimePicker
    Friend WithEvents CartrAddToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TableLayoutPanel21 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents gbPRNCartr As System.Windows.Forms.GroupBox
    Friend WithEvents lvPRNCartr As System.Windows.Forms.ListView
    Friend WithEvents txtPrnIP As System.Windows.Forms.TextBox
    Friend WithEvents lblPrnIP As System.Windows.Forms.Label
    Friend WithEvents cmbPRNotv As System.Windows.Forms.ComboBox
    Friend WithEvents lblPRNotv As System.Windows.Forms.Label
    Friend WithEvents lblPRNPage As System.Windows.Forms.Label
    Friend WithEvents lblPRNprintPage As System.Windows.Forms.Label
    Friend WithEvents cmbPRNOffice As System.Windows.Forms.ComboBox
    Friend WithEvents lblPRNOffice As System.Windows.Forms.Label
    Friend WithEvents cmbModCartr As System.Windows.Forms.ComboBox
    Friend WithEvents lblModCartr As System.Windows.Forms.Label
    Friend WithEvents cmbPRNDepart As System.Windows.Forms.ComboBox
    Friend WithEvents lblPRNDepart As System.Windows.Forms.Label
    Friend WithEvents cmbTIPCartridg As System.Windows.Forms.ComboBox
    Friend WithEvents lblTIPCartridg As System.Windows.Forms.Label
    Friend WithEvents cmbPRNFil As System.Windows.Forms.ComboBox
    Friend WithEvents lblPRNFil As System.Windows.Forms.Label
    Friend WithEvents txtPRNinnumber As System.Windows.Forms.TextBox
    Friend WithEvents lblInNumber As System.Windows.Forms.Label
    Friend WithEvents cmbFormat As System.Windows.Forms.ComboBox
    Friend WithEvents gbPRN As System.Windows.Forms.GroupBox
    Friend WithEvents lblFormat As System.Windows.Forms.Label
    Friend WithEvents lblPRNphone As System.Windows.Forms.Label
    Friend WithEvents txtPRNphone As System.Windows.Forms.TextBox
    Friend WithEvents lblPrnMAC As System.Windows.Forms.Label
    Friend WithEvents txtPRNMAC As System.Windows.Forms.TextBox
    Friend WithEvents cmbPRNConnect As System.Windows.Forms.ComboBox
    Friend WithEvents lblPRNConnect As System.Windows.Forms.Label
    Friend WithEvents Label83 As System.Windows.Forms.Label
    Friend WithEvents cmbPCL As System.Windows.Forms.ComboBox
    Friend WithEvents TableLayoutPanel22 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents txtOTHmemo As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents gbOTh As System.Windows.Forms.GroupBox
    Friend WithEvents txtMonDum As System.Windows.Forms.TextBox
    Friend WithEvents PROiZV39 As System.Windows.Forms.ComboBox
    Friend WithEvents txtOTHSN As System.Windows.Forms.TextBox
    Friend WithEvents cmbOTH As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents cmbOTHFil As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents cmbOTHDepart As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cmbOTHOffice As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cmbOTHotv As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtOTHphone As System.Windows.Forms.TextBox
    Friend WithEvents lblTipOther As System.Windows.Forms.Label
    Friend WithEvents cmbOTHConnect As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtOTHinnumber As System.Windows.Forms.TextBox
    Friend WithEvents lblOTPCL As System.Windows.Forms.Label
    Friend WithEvents cmbOTHPCL As System.Windows.Forms.ComboBox
    Friend WithEvents lblOtIp As System.Windows.Forms.Label
    Friend WithEvents lblOTMac As System.Windows.Forms.Label
    Friend WithEvents txtOTHIP As System.Windows.Forms.TextBox
    Friend WithEvents txtOTHMAC As System.Windows.Forms.TextBox
    Friend WithEvents TabPage23 As System.Windows.Forms.TabPage
    Friend WithEvents lvMovementPRN As System.Windows.Forms.ListView
    Friend WithEvents TabPage24 As System.Windows.Forms.TabPage
    Friend WithEvents lvMovementNET As System.Windows.Forms.ListView
    Friend WithEvents TabPage22 As System.Windows.Forms.TabPage
    Friend WithEvents lvMovementOTH As System.Windows.Forms.ListView
    Friend WithEvents TableLayoutPanel48 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents cmbNetCable As System.Windows.Forms.ComboBox
    Friend WithEvents txtNetSN As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents txtNetIsp As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents txtNetIP As System.Windows.Forms.TextBox
    Friend WithEvents cmbNetVkl As System.Windows.Forms.ComboBox
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents txtNetNumberPorts As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtNetINN As System.Windows.Forms.TextBox
    Friend WithEvents txtNetCableCat As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtNetPort As System.Windows.Forms.TextBox
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents txtNetMac As System.Windows.Forms.TextBox
    Friend WithEvents TableLayoutPanel50 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents lvNetPort As System.Windows.Forms.ListView
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents txtNetPortMapping As System.Windows.Forms.TextBox
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents txtNetnumberPort As System.Windows.Forms.TextBox
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents btnNetPortAdd As System.Windows.Forms.Button
    Friend WithEvents txtNetPortMac As System.Windows.Forms.TextBox
    Friend WithEvents TableLayoutPanel51 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents PROiZV40 As System.Windows.Forms.ComboBox
    Friend WithEvents cmbDevNet As System.Windows.Forms.ComboBox
    Friend WithEvents cmbNetDev As System.Windows.Forms.ComboBox
    Friend WithEvents TableLayoutPanel52 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents chkPRNNNb As System.Windows.Forms.CheckBox
    Friend WithEvents txtPRNSumm As System.Windows.Forms.NumericUpDown
    Friend WithEvents dtPRNdataVvoda As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label54 As System.Windows.Forms.Label
    Friend WithEvents txtPRNZay As System.Windows.Forms.TextBox
    Friend WithEvents Label49 As System.Windows.Forms.Label
    Friend WithEvents Label53 As System.Windows.Forms.Label
    Friend WithEvents txtPRNcash As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label50 As System.Windows.Forms.Label
    Friend WithEvents Label52 As System.Windows.Forms.Label
    Friend WithEvents txtPRNSfN As System.Windows.Forms.TextBox
    Friend WithEvents Label51 As System.Windows.Forms.Label
    Friend WithEvents chkPRNspis As System.Windows.Forms.CheckBox
    Friend WithEvents dtPRNSFdate As System.Windows.Forms.DateTimePicker
    Friend WithEvents TableLayoutPanel53 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents chkNETNNb As System.Windows.Forms.CheckBox
    Friend WithEvents txtNETSumm As System.Windows.Forms.NumericUpDown
    Friend WithEvents dtNETdataVvoda As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label60 As System.Windows.Forms.Label
    Friend WithEvents txtNETZay As System.Windows.Forms.TextBox
    Friend WithEvents Label55 As System.Windows.Forms.Label
    Friend WithEvents dtNETSFdate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label59 As System.Windows.Forms.Label
    Friend WithEvents txtNETcash As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label56 As System.Windows.Forms.Label
    Friend WithEvents Label58 As System.Windows.Forms.Label
    Friend WithEvents txtNETSfN As System.Windows.Forms.TextBox
    Friend WithEvents chkNETspis As System.Windows.Forms.CheckBox
    Friend WithEvents Label57 As System.Windows.Forms.Label
    Friend WithEvents TableLayoutPanel54 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents chkOTHNNb As System.Windows.Forms.CheckBox
    Friend WithEvents txtOTHSumm As System.Windows.Forms.NumericUpDown
    Friend WithEvents dtOTHdataVvoda As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label66 As System.Windows.Forms.Label
    Friend WithEvents txtOTHZay As System.Windows.Forms.TextBox
    Friend WithEvents Label61 As System.Windows.Forms.Label
    Friend WithEvents dtOTHSFdate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label65 As System.Windows.Forms.Label
    Friend WithEvents txtOTHcash As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label62 As System.Windows.Forms.Label
    Friend WithEvents Label64 As System.Windows.Forms.Label
    Friend WithEvents txtOTHSfN As System.Windows.Forms.TextBox
    Friend WithEvents Label63 As System.Windows.Forms.Label
    Friend WithEvents chkOTHspis As System.Windows.Forms.CheckBox
    Friend WithEvents TableLayoutPanel55 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents PROiZV38 As System.Windows.Forms.ComboBox
    Friend WithEvents cmbPRN As System.Windows.Forms.ComboBox
    Friend WithEvents txtPRNSN As System.Windows.Forms.TextBox
    Friend WithEvents TableLayoutPanel56 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents dtGOTHok As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label42 As System.Windows.Forms.Label
    Friend WithEvents Label40 As System.Windows.Forms.Label
    Friend WithEvents cmbOTHPostav As System.Windows.Forms.ComboBox
    Friend WithEvents dtGOTHPr As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label41 As System.Windows.Forms.Label
    Friend WithEvents TableLayoutPanel57 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents dtGPRNok As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dtGPRNPr As System.Windows.Forms.DateTimePicker
    Friend WithEvents cmbPRNPostav As System.Windows.Forms.ComboBox
    Friend WithEvents TableLayoutPanel58 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents dtGNETok As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label39 As System.Windows.Forms.Label
    Friend WithEvents Label37 As System.Windows.Forms.Label
    Friend WithEvents cmbNETPostav As System.Windows.Forms.ComboBox
    Friend WithEvents dtGNETPr As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label38 As System.Windows.Forms.Label
    Friend WithEvents TableLayoutPanel64 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents TableLayoutPanel65 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents TableLayoutPanel67 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents TableLayoutPanel68 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents TableLayoutPanel69 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents TableLayoutPanel70 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents TableLayoutPanel71 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label85 As System.Windows.Forms.Label
    Friend WithEvents lblSidPRN As System.Windows.Forms.Label
    Friend WithEvents Label87 As System.Windows.Forms.Label
    Friend WithEvents lblsIDOTH As System.Windows.Forms.Label
    Friend WithEvents cmDvig As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents DELTEdVIGToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents treebranche As System.Windows.Forms.ComboBox
    Friend WithEvents MassRazdelPerf As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MassUpdatetoINI As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TableLayoutPanel49 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents cmbNETotv As System.Windows.Forms.ComboBox
    Friend WithEvents txtNETphone As System.Windows.Forms.TextBox
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents cmbNETBranch As System.Windows.Forms.ComboBox
    Friend WithEvents cmbNETOffice As System.Windows.Forms.ComboBox
    Friend WithEvents cmbNetDepart As System.Windows.Forms.ComboBox
    Friend WithEvents Label86 As System.Windows.Forms.Label
    Friend WithEvents lblSidNET As System.Windows.Forms.Label
    Friend WithEvents lblPCLNET As System.Windows.Forms.Label
    Friend WithEvents cmbCNTNet As System.Windows.Forms.ComboBox
    Friend WithEvents CMServices As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents EditService As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeleteService As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TableLayoutPanel73 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents chkVisibleSTR As System.Windows.Forms.CheckBox
    Friend WithEvents ВернутьПерефериюToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MnuSendEmail As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ilsCommands As System.Windows.Forms.ImageList
    Friend WithEvents MassObedPerf As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents addServiseWork As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ППРToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ТО1ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ТО2ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ТО3ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ТО4ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ТО5ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ТО6ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lstGroups As System.Windows.Forms.TreeView
    Friend WithEvents sSTAB1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage6 As System.Windows.Forms.TabPage
    Friend WithEvents TableLayoutPanel20 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents gbMovement As System.Windows.Forms.GroupBox
    Friend WithEvents lvMovement As System.Windows.Forms.ListView
    Friend WithEvents lblPseudonym As System.Windows.Forms.Label
    Friend WithEvents txtSNAME As System.Windows.Forms.TextBox
    Friend WithEvents lblNetName As System.Windows.Forms.Label
    Friend WithEvents txtPSEUDONIM As System.Windows.Forms.TextBox
    Friend WithEvents lblBranch As System.Windows.Forms.Label
    Friend WithEvents cmbBranch As System.Windows.Forms.ComboBox
    Friend WithEvents lblResponsible As System.Windows.Forms.Label
    Friend WithEvents cmbResponsible As System.Windows.Forms.ComboBox
    Friend WithEvents lblDepartment As System.Windows.Forms.Label
    Friend WithEvents cmbDepartment As System.Windows.Forms.ComboBox
    Friend WithEvents lblPhone As System.Windows.Forms.Label
    Friend WithEvents txtPHONE As System.Windows.Forms.TextBox
    Friend WithEvents lblOffice As System.Windows.Forms.Label
    Friend WithEvents cmbOffice As System.Windows.Forms.ComboBox
    Friend WithEvents lblAppointment As System.Windows.Forms.Label
    Friend WithEvents cmbAppointment As System.Windows.Forms.ComboBox
    Friend WithEvents gbInNumber As System.Windows.Forms.GroupBox
    Friend WithEvents TableLayoutPanel47 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents IN_PRN As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents IN_IBP As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents txtMSN As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txtSBSN As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label89 As System.Windows.Forms.Label
    Friend WithEvents lblNumberNET As System.Windows.Forms.Label
    Friend WithEvents Label84 As System.Windows.Forms.Label
    Friend WithEvents lblsID As System.Windows.Forms.Label
    Friend WithEvents Label88 As System.Windows.Forms.Label
    Friend WithEvents cmbPCLK As System.Windows.Forms.ComboBox
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TableLayoutPanel63 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents gbcpu As System.Windows.Forms.GroupBox
    Friend WithEvents TableLayoutPanel24 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents PROizV4 As System.Windows.Forms.ComboBox
    Public WithEvents PROizV2 As System.Windows.Forms.ComboBox
    Friend WithEvents PROizV3 As System.Windows.Forms.ComboBox
    Friend WithEvents cmbCPU1 As System.Windows.Forms.ComboBox
    Friend WithEvents txtSoc4 As System.Windows.Forms.TextBox
    Friend WithEvents cmbCPU2 As System.Windows.Forms.ComboBox
    Friend WithEvents PROizV1 As System.Windows.Forms.ComboBox
    Friend WithEvents cmbCPU3 As System.Windows.Forms.ComboBox
    Friend WithEvents txtSoc3 As System.Windows.Forms.TextBox
    Friend WithEvents txtMHZ4 As System.Windows.Forms.TextBox
    Friend WithEvents cmbCPU4 As System.Windows.Forms.ComboBox
    Friend WithEvents txtSoc2 As System.Windows.Forms.TextBox
    Friend WithEvents txtMHZ1 As System.Windows.Forms.TextBox
    Friend WithEvents txtSoc1 As System.Windows.Forms.TextBox
    Friend WithEvents txtMHZ2 As System.Windows.Forms.TextBox
    Friend WithEvents txtMHZ3 As System.Windows.Forms.TextBox
    Friend WithEvents gbSOUND As System.Windows.Forms.GroupBox
    Friend WithEvents TableLayoutPanel28 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents PROizV16 As System.Windows.Forms.ComboBox
    Friend WithEvents txtSoundS As System.Windows.Forms.TextBox
    Friend WithEvents cmbSound As System.Windows.Forms.ComboBox
    Friend WithEvents txtSoundB As System.Windows.Forms.TextBox
    Friend WithEvents gbMB As System.Windows.Forms.GroupBox
    Friend WithEvents TableLayoutPanel29 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents lblMBsn As System.Windows.Forms.Label
    Friend WithEvents txtSN_MB As System.Windows.Forms.TextBox
    Friend WithEvents txtChip As System.Windows.Forms.TextBox
    Friend WithEvents PROizV5 As System.Windows.Forms.ComboBox
    Friend WithEvents cmbMB As System.Windows.Forms.ComboBox
    Friend WithEvents gbSVGA As System.Windows.Forms.GroupBox
    Friend WithEvents TableLayoutPanel27 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents PROizV15 As System.Windows.Forms.ComboBox
    Friend WithEvents txtSVGAs2 As System.Windows.Forms.TextBox
    Friend WithEvents PROizV14 As System.Windows.Forms.ComboBox
    Friend WithEvents cmbSVGA1 As System.Windows.Forms.ComboBox
    Friend WithEvents cmbSVGA2 As System.Windows.Forms.ComboBox
    Friend WithEvents txtSVGAs1 As System.Windows.Forms.TextBox
    Friend WithEvents txtSVGAr2 As System.Windows.Forms.TextBox
    Friend WithEvents txtSVGAr1 As System.Windows.Forms.TextBox
    Friend WithEvents gbRAM As System.Windows.Forms.GroupBox
    Friend WithEvents TableLayoutPanel25 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents PROizV9 As System.Windows.Forms.ComboBox
    Friend WithEvents txtRamSN4 As System.Windows.Forms.TextBox
    Friend WithEvents PROizV8 As System.Windows.Forms.ComboBox
    Friend WithEvents cmbRAM1 As System.Windows.Forms.ComboBox
    Friend WithEvents PROizV7 As System.Windows.Forms.ComboBox
    Friend WithEvents cmbRAM2 As System.Windows.Forms.ComboBox
    Friend WithEvents PROizV6 As System.Windows.Forms.ComboBox
    Friend WithEvents txtRamSN3 As System.Windows.Forms.TextBox
    Friend WithEvents txtRamS4 As System.Windows.Forms.TextBox
    Friend WithEvents cmbRAM3 As System.Windows.Forms.ComboBox
    Friend WithEvents txtRamSN2 As System.Windows.Forms.TextBox
    Friend WithEvents cmbRAM4 As System.Windows.Forms.ComboBox
    Friend WithEvents txtRamS1 As System.Windows.Forms.TextBox
    Friend WithEvents txtRamSN1 As System.Windows.Forms.TextBox
    Friend WithEvents txtRamS3 As System.Windows.Forms.TextBox
    Friend WithEvents txtRamS2 As System.Windows.Forms.TextBox
    Friend WithEvents gbHDD As System.Windows.Forms.GroupBox
    Friend WithEvents TableLayoutPanel26 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents PROizV13 As System.Windows.Forms.ComboBox
    Friend WithEvents txtHDDsN4 As System.Windows.Forms.TextBox
    Friend WithEvents PROizV12 As System.Windows.Forms.ComboBox
    Friend WithEvents cmbHDD1 As System.Windows.Forms.ComboBox
    Friend WithEvents PROizV11 As System.Windows.Forms.ComboBox
    Friend WithEvents cmbHDD2 As System.Windows.Forms.ComboBox
    Friend WithEvents PROizV10 As System.Windows.Forms.ComboBox
    Friend WithEvents txtHDDsN3 As System.Windows.Forms.TextBox
    Friend WithEvents txtHDDo4 As System.Windows.Forms.TextBox
    Friend WithEvents cmbHDD3 As System.Windows.Forms.ComboBox
    Friend WithEvents cmbHDD4 As System.Windows.Forms.ComboBox
    Friend WithEvents txtHDDo1 As System.Windows.Forms.TextBox
    Friend WithEvents txtHDDsN1 As System.Windows.Forms.TextBox
    Friend WithEvents txtHDDo3 As System.Windows.Forms.TextBox
    Friend WithEvents txtHDDo2 As System.Windows.Forms.TextBox
    Friend WithEvents txtHDDsN2 As System.Windows.Forms.TextBox
    Friend WithEvents gbOptical As System.Windows.Forms.GroupBox
    Friend WithEvents TableLayoutPanel30 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents PROizV19 As System.Windows.Forms.ComboBox
    Friend WithEvents txtOPTICsn3 As System.Windows.Forms.TextBox
    Friend WithEvents PROizV18 As System.Windows.Forms.ComboBox
    Friend WithEvents cmbOPTIC1 As System.Windows.Forms.ComboBox
    Friend WithEvents PROizV17 As System.Windows.Forms.ComboBox
    Friend WithEvents cmbOPTIC2 As System.Windows.Forms.ComboBox
    Friend WithEvents txtOPTICsn2 As System.Windows.Forms.TextBox
    Friend WithEvents txtOPTICs3 As System.Windows.Forms.TextBox
    Friend WithEvents cmbOPTIC3 As System.Windows.Forms.ComboBox
    Friend WithEvents txtOPTICsn1 As System.Windows.Forms.TextBox
    Friend WithEvents txtOPTICs1 As System.Windows.Forms.TextBox
    Friend WithEvents txtOPTICs2 As System.Windows.Forms.TextBox
    Friend WithEvents gbNetwork As System.Windows.Forms.GroupBox
    Friend WithEvents TableLayoutPanel31 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents PROizV21 As System.Windows.Forms.ComboBox
    Friend WithEvents txtNETmac2 As System.Windows.Forms.TextBox
    Friend WithEvents PROizV20 As System.Windows.Forms.ComboBox
    Friend WithEvents cmbNET1 As System.Windows.Forms.ComboBox
    Friend WithEvents cmbNET2 As System.Windows.Forms.ComboBox
    Friend WithEvents txtNETmac1 As System.Windows.Forms.TextBox
    Friend WithEvents txtNETip2 As System.Windows.Forms.TextBox
    Friend WithEvents txtNETip1 As System.Windows.Forms.TextBox
    Friend WithEvents gbFDD As System.Windows.Forms.GroupBox
    Friend WithEvents TableLayoutPanel32 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents PROizV22 As System.Windows.Forms.ComboBox
    Friend WithEvents cmbFDD As System.Windows.Forms.ComboBox
    Friend WithEvents txtSN As System.Windows.Forms.TextBox
    Friend WithEvents gbCreader As System.Windows.Forms.GroupBox
    Friend WithEvents TableLayoutPanel33 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents PROizV23 As System.Windows.Forms.ComboBox
    Friend WithEvents cmbCreader As System.Windows.Forms.ComboBox
    Friend WithEvents txtCreader1 As System.Windows.Forms.TextBox
    Friend WithEvents gbModem As System.Windows.Forms.GroupBox
    Friend WithEvents TableLayoutPanel34 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents PROizV24 As System.Windows.Forms.ComboBox
    Friend WithEvents cmbModem As System.Windows.Forms.ComboBox
    Friend WithEvents txtModemSN As System.Windows.Forms.TextBox
    Friend WithEvents gbCase As System.Windows.Forms.GroupBox
    Friend WithEvents TableLayoutPanel35 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents cmbCase As System.Windows.Forms.ComboBox
    Friend WithEvents txtCase1 As System.Windows.Forms.TextBox
    Friend WithEvents PROizV25 As System.Windows.Forms.ComboBox
    Friend WithEvents gbBP As System.Windows.Forms.GroupBox
    Friend WithEvents TableLayoutPanel36 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents cmbBP As System.Windows.Forms.ComboBox
    Friend WithEvents txtBP1 As System.Windows.Forms.TextBox
    Friend WithEvents PROizV26 As System.Windows.Forms.ComboBox
    Friend WithEvents gbUSB As System.Windows.Forms.GroupBox
    Friend WithEvents TableLayoutPanel37 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents cmbUSB As System.Windows.Forms.ComboBox
    Friend WithEvents txtUSBSN As System.Windows.Forms.TextBox
    Friend WithEvents PROizV41 As System.Windows.Forms.ComboBox
    Friend WithEvents gbPCI As System.Windows.Forms.GroupBox
    Friend WithEvents TableLayoutPanel38 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents cmbPCI As System.Windows.Forms.ComboBox
    Friend WithEvents txtSNPCI As System.Windows.Forms.TextBox
    Friend WithEvents PROizV42 As System.Windows.Forms.ComboBox
    Friend WithEvents gbSBP As System.Windows.Forms.GroupBox
    Friend WithEvents TableLayoutPanel39 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents txtModSB As System.Windows.Forms.TextBox
    Friend WithEvents txtSNSB As System.Windows.Forms.TextBox
    Friend WithEvents PROizV27 As System.Windows.Forms.ComboBox
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents TableLayoutPanel61 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents gbMonitor As System.Windows.Forms.GroupBox
    Friend WithEvents TableLayoutPanel40 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents PROizV29 As System.Windows.Forms.ComboBox
    Friend WithEvents txtMon2SN As System.Windows.Forms.TextBox
    Friend WithEvents PROizV28 As System.Windows.Forms.ComboBox
    Friend WithEvents cmbMon1 As System.Windows.Forms.ComboBox
    Friend WithEvents cmbMon2 As System.Windows.Forms.ComboBox
    Friend WithEvents txtMon1SN As System.Windows.Forms.TextBox
    Friend WithEvents txtMon2Dum As System.Windows.Forms.TextBox
    Friend WithEvents txtMon1Dum As System.Windows.Forms.TextBox
    Friend WithEvents gbPrinters As System.Windows.Forms.GroupBox
    Friend WithEvents TableLayoutPanel41 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents cmbPrinters1 As System.Windows.Forms.ComboBox
    Friend WithEvents PROizV36 As System.Windows.Forms.ComboBox
    Friend WithEvents txtPrint3Port As System.Windows.Forms.TextBox
    Friend WithEvents PROizV35 As System.Windows.Forms.ComboBox
    Friend WithEvents cmbPrinters2 As System.Windows.Forms.ComboBox
    Friend WithEvents PROizV34 As System.Windows.Forms.ComboBox
    Friend WithEvents cmbPrinters3 As System.Windows.Forms.ComboBox
    Friend WithEvents txtPrint2Port As System.Windows.Forms.TextBox
    Friend WithEvents txtPrint3SN As System.Windows.Forms.TextBox
    Friend WithEvents txtPrint1SN As System.Windows.Forms.TextBox
    Friend WithEvents txtPrint1Port As System.Windows.Forms.TextBox
    Friend WithEvents txtPrint2SN As System.Windows.Forms.TextBox
    Friend WithEvents gbIBP As System.Windows.Forms.GroupBox
    Friend WithEvents TableLayoutPanel46 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents PROizV43 As System.Windows.Forms.ComboBox
    Friend WithEvents cmbIBP As System.Windows.Forms.ComboBox
    Friend WithEvents txtSNIBP As System.Windows.Forms.TextBox
    Friend WithEvents gbKeyboard As System.Windows.Forms.GroupBox
    Friend WithEvents TableLayoutPanel42 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents PROizV30 As System.Windows.Forms.ComboBox
    Friend WithEvents cmbKeyb As System.Windows.Forms.ComboBox
    Friend WithEvents txtKeybSN As System.Windows.Forms.TextBox
    Friend WithEvents gbMouse As System.Windows.Forms.GroupBox
    Friend WithEvents TableLayoutPanel43 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents txtMouseSN As System.Windows.Forms.TextBox
    Friend WithEvents cmbMouse As System.Windows.Forms.ComboBox
    Friend WithEvents PROizV31 As System.Windows.Forms.ComboBox
    Friend WithEvents gbFilter As System.Windows.Forms.GroupBox
    Friend WithEvents TableLayoutPanel45 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents PROizV33 As System.Windows.Forms.ComboBox
    Friend WithEvents cmbFilter As System.Windows.Forms.ComboBox
    Friend WithEvents txtFilterSN As System.Windows.Forms.TextBox
    Friend WithEvents gbAsystem As System.Windows.Forms.GroupBox
    Friend WithEvents TableLayoutPanel44 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents PROizV32 As System.Windows.Forms.ComboBox
    Friend WithEvents cmbAsist As System.Windows.Forms.ComboBox
    Friend WithEvents txtAsistSN As System.Windows.Forms.TextBox
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents lstSoftware As System.Windows.Forms.ListView
    Friend WithEvents TabPage5 As System.Windows.Forms.TabPage
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents cmdUserAdd As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmdUserDel As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmdUserPassEncript As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnUserCancel As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents TableLayoutPanel4 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents txtUMEMO As System.Windows.Forms.TextBox
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents txtUserEmailPwd As System.Windows.Forms.TextBox
    Friend WithEvents lblEmailPass As System.Windows.Forms.Label
    Friend WithEvents txtUserEmail As System.Windows.Forms.TextBox
    Friend WithEvents lblEMAIL As System.Windows.Forms.Label
    Friend WithEvents txtUserJab As System.Windows.Forms.TextBox
    Friend WithEvents lblJabber As System.Windows.Forms.Label
    Friend WithEvents txtUserIcq As System.Windows.Forms.TextBox
    Friend WithEvents lblICQ As System.Windows.Forms.Label
    Friend WithEvents lblSurname As System.Windows.Forms.Label
    Friend WithEvents txtUserPass As System.Windows.Forms.TextBox
    Friend WithEvents lbluserPassword As System.Windows.Forms.Label
    Friend WithEvents lblUsername As System.Windows.Forms.Label
    Friend WithEvents ChkPDC As System.Windows.Forms.CheckBox
    Friend WithEvents txtUserName As System.Windows.Forms.ComboBox
    Friend WithEvents txtUserFIO As System.Windows.Forms.ComboBox
    Friend WithEvents lstUsers As System.Windows.Forms.ListView
    Friend WithEvents TabPage7 As System.Windows.Forms.TabPage
    Friend WithEvents TableLayoutPanel5 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents gbRepair As System.Windows.Forms.GroupBox
    Friend WithEvents lvRepair As System.Windows.Forms.ListView
    Friend WithEvents gbNotes As System.Windows.Forms.GroupBox
    Friend WithEvents TableLayoutPanel6 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents lvNotes As System.Windows.Forms.ListView
    Friend WithEvents txtNotes As System.Windows.Forms.TextBox
    Friend WithEvents cmbNotesMaster As System.Windows.Forms.ComboBox
    Friend WithEvents dtDateNotes As System.Windows.Forms.DateTimePicker
    Friend WithEvents TabPage8 As System.Windows.Forms.TabPage
    Friend WithEvents TableLayoutPanel66 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents gbGuarantee As System.Windows.Forms.GroupBox
    Friend WithEvents TableLayoutPanel59 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents gbSeller As System.Windows.Forms.GroupBox
    Friend WithEvents TableLayoutPanel60 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents dtGok As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents cmbPostav As System.Windows.Forms.ComboBox
    Friend WithEvents dtGPr As System.Windows.Forms.DateTimePicker
    Friend WithEvents rbKompl As System.Windows.Forms.RadioButton
    Friend WithEvents rbSist As System.Windows.Forms.RadioButton
    Friend WithEvents gbSale As System.Windows.Forms.GroupBox
    Friend WithEvents TableLayoutPanel23 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents chkPCNNb As System.Windows.Forms.CheckBox
    Friend WithEvents txtPCSumm As System.Windows.Forms.NumericUpDown
    Friend WithEvents chkPCspis As System.Windows.Forms.CheckBox
    Friend WithEvents dtPCdataVvoda As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label43 As System.Windows.Forms.Label
    Friend WithEvents Label48 As System.Windows.Forms.Label
    Friend WithEvents txtPCSfN As System.Windows.Forms.TextBox
    Friend WithEvents txtPCcash As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label46 As System.Windows.Forms.Label
    Friend WithEvents txtPCZay As System.Windows.Forms.TextBox
    Friend WithEvents Label45 As System.Windows.Forms.Label
    Friend WithEvents dtPCSFdate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label47 As System.Windows.Forms.Label
    Friend WithEvents Label44 As System.Windows.Forms.Label
    Friend WithEvents ToolStrip2 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnNotesAdd As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnNotesDel As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnNotesCancel As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator7 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStrip3 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnBRNotesAdd As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator8 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnBRNotesDel As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator9 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnBRNotesCancel As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator10 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStrip4 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnPRNNotesAdd As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator11 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnPRNNotesDel As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator12 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnPRNNotesCancel As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator13 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStrip5 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnNETAdd As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator14 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnNETNotesDel As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator15 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnNETNotesCancel As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator16 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStrip6 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnOTHAdd As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator17 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnOTHNotesDel As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator18 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnOTHNotesCancel As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator19 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStrip7 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnSearch As System.Windows.Forms.ToolStripButton
    Friend WithEvents chkSNMP As System.Windows.Forms.CheckBox
    Friend WithEvents lblSNMP As System.Windows.Forms.Label
    Friend WithEvents txtSNMP As System.Windows.Forms.TextBox
    Friend WithEvents gbSNMP As System.Windows.Forms.GroupBox
    Friend WithEvents TableLayoutPanel3 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label90 As System.Windows.Forms.Label
    Friend WithEvents Label91 As System.Windows.Forms.Label
    Friend WithEvents Label92 As System.Windows.Forms.Label
    Friend WithEvents Label93 As System.Windows.Forms.Label
    Friend WithEvents Label94 As System.Windows.Forms.Label
    Friend WithEvents Label95 As System.Windows.Forms.Label
    Friend WithEvents Label96 As System.Windows.Forms.Label
    Friend WithEvents Label97 As System.Windows.Forms.Label
    Friend WithEvents Label98 As System.Windows.Forms.Label
    Friend WithEvents Label99 As System.Windows.Forms.Label
    Friend WithEvents Label100 As System.Windows.Forms.Label
    Friend WithEvents Label101 As System.Windows.Forms.Label
    Friend WithEvents Label102 As System.Windows.Forms.Label
    Friend WithEvents Label103 As System.Windows.Forms.Label
    Friend WithEvents Label104 As System.Windows.Forms.Label
    Friend WithEvents Label105 As System.Windows.Forms.Label
    Friend WithEvents Label106 As System.Windows.Forms.Label
    Friend WithEvents Label107 As System.Windows.Forms.Label
    Friend WithEvents Label108 As System.Windows.Forms.Label
    Friend WithEvents Label109 As System.Windows.Forms.Label
    Friend WithEvents Label110 As System.Windows.Forms.Label
    Friend WithEvents Label111 As System.Windows.Forms.Label
    Friend WithEvents Label112 As System.Windows.Forms.Label
    Friend WithEvents Label113 As System.Windows.Forms.Label
    Friend WithEvents ToolStrip8 As System.Windows.Forms.ToolStrip
    Friend WithEvents bCPUPlus As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStrip9 As System.Windows.Forms.ToolStrip
    Friend WithEvents bRamPlus As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStrip10 As System.Windows.Forms.ToolStrip
    Friend WithEvents bHddPlus As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStrip11 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStrip12 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStrip13 As System.Windows.Forms.ToolStrip
    Friend WithEvents bSVGAPlus As System.Windows.Forms.ToolStripButton
    Friend WithEvents bOpticalPlus As System.Windows.Forms.ToolStripButton
    Friend WithEvents bNetPlus As System.Windows.Forms.ToolStripButton
    Friend WithEvents PingToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lblSNMP_Ping As System.Windows.Forms.Label
    Friend WithEvents cmbRAM5 As System.Windows.Forms.ComboBox
    Friend WithEvents cmbRAM6 As System.Windows.Forms.ComboBox
    Friend WithEvents txtRamS5 As System.Windows.Forms.TextBox
    Friend WithEvents txtRamS6 As System.Windows.Forms.TextBox
    Friend WithEvents txtRamSN5 As System.Windows.Forms.TextBox
    Friend WithEvents txtRamSN6 As System.Windows.Forms.TextBox
    Friend WithEvents PROizV44 As System.Windows.Forms.ComboBox
    Friend WithEvents PROizV45 As System.Windows.Forms.ComboBox
    Friend WithEvents cmbRAM7 As System.Windows.Forms.ComboBox
    Friend WithEvents cmbRAM8 As System.Windows.Forms.ComboBox
    Friend WithEvents txtRamS7 As System.Windows.Forms.TextBox
    Friend WithEvents txtRamS8 As System.Windows.Forms.TextBox
    Friend WithEvents txtRamSN7 As System.Windows.Forms.TextBox
    Friend WithEvents txtRamSN8 As System.Windows.Forms.TextBox
    Friend WithEvents PROizV46 As System.Windows.Forms.ComboBox
    Friend WithEvents PROizV47 As System.Windows.Forms.ComboBox
    Friend WithEvents cmbHDD5 As System.Windows.Forms.ComboBox
    Friend WithEvents cmbHDD6 As System.Windows.Forms.ComboBox
    Friend WithEvents cmbHDD7 As System.Windows.Forms.ComboBox
    Friend WithEvents cmbHDD8 As System.Windows.Forms.ComboBox
    Friend WithEvents PROizV48 As System.Windows.Forms.ComboBox
    Friend WithEvents PROizV49 As System.Windows.Forms.ComboBox
    Friend WithEvents PROizV50 As System.Windows.Forms.ComboBox
    Friend WithEvents PROizV51 As System.Windows.Forms.ComboBox
    Friend WithEvents txtHDDo5 As System.Windows.Forms.TextBox
    Friend WithEvents txtHDDsN5 As System.Windows.Forms.TextBox
    Friend WithEvents txtHDDo6 As System.Windows.Forms.TextBox
    Friend WithEvents txtHDDsN6 As System.Windows.Forms.TextBox
    Friend WithEvents txtHDDo7 As System.Windows.Forms.TextBox
    Friend WithEvents txtHDDsN7 As System.Windows.Forms.TextBox
    Friend WithEvents txtHDDo8 As System.Windows.Forms.TextBox
    Friend WithEvents txtHDDsN8 As System.Windows.Forms.TextBox
    Friend WithEvents ПечатьToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnu_Z_to_Office As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents РаспискаToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents НарядToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents МатериальныйПропускToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents БланкToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents СостояниеУстройстваToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuSostOn As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuSostOff As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStrip14 As System.Windows.Forms.ToolStrip
    Friend WithEvents bMonitorPlus As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStrip15 As System.Windows.Forms.ToolStrip
    Friend WithEvents bPrinterPlus As System.Windows.Forms.ToolStripButton
    Friend WithEvents TableLayoutPanel7 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents dtSpisanie As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtOTHSpisanie As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtPRNSpisanie As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtNETSpisanie As System.Windows.Forms.DateTimePicker
    Friend WithEvents TableLayoutPanel10 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents gbSoftEd As System.Windows.Forms.GroupBox
    Friend WithEvents TableLayoutPanel13 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents cmbSoftware As System.Windows.Forms.ComboBox
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents Label114 As System.Windows.Forms.Label
    Friend WithEvents cmbTipLicense As System.Windows.Forms.ComboBox
    Friend WithEvents Label115 As System.Windows.Forms.Label
    Friend WithEvents cmbTipPo As System.Windows.Forms.ComboBox
    Friend WithEvents Label116 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtLicKey As System.Windows.Forms.TextBox
    Friend WithEvents DTInstall As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label117 As System.Windows.Forms.Label
    Friend WithEvents Label118 As System.Windows.Forms.Label
    Friend WithEvents cmbSoftPr As System.Windows.Forms.ComboBox
    Friend WithEvents Label119 As System.Windows.Forms.Label
    Friend WithEvents ToolStrip16 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnAdd As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator20 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnDelete As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator21 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnCancel As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator22 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator23 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents CheckBox2 As System.Windows.Forms.CheckBox
    Friend WithEvents gbPRN_USTR As System.Windows.Forms.GroupBox
    Friend WithEvents lvUSTR_PRINT As System.Windows.Forms.ListView

End Class
