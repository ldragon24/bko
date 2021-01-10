Const NetOut = 0  ' 0 - ini ������ �����, 1 - �� ������
Const Idle = 0  ' 0 - ��������� �� ��������� ����� ������

Const ForReading = 1

Const ForWriting = 2

If (NetOut <> 0) Then
	Const OutFold = "\\192.168.0.1\hwr\" 
End If


strComputer = "10.252.245.15"

 'Set objComputer = CreateObject("Shell.LocalMachine")

Set objWMIService = GetObject( "winmgmts://./root/cimv2" )

                Set colItems = objWMIService.ExecQuery( "Select * from Win32_ComputerSystem", "WQL", 48 )

                For Each objItem in colItems

                               strComputer = objItem.Name

                Next

Set objFSO = CreateObject("Scripting.FileSystemObject")

If (NetOut = 0) Then
	Set objCommentFile = objFSO.OpenTextFile(strComputer & ".ini",  ForWriting, TRUE)
else
	Set objCommentFile = objFSO.OpenTextFile(OutFold & strComputer & ".ini",  ForWriting, TRUE)
End If

on error resume next

	objCommentFile.Write "[��������� ����������]"

	objCommentFile.Write VbCrLf

	objCommentFile.Write VbCrLf

	objCommentFile.Write "���������|��� ����������= " & strComputer & VbCrLf

on error resume next

Set colItems = objWMIService.ExecQuery("SELECT TotalVisibleMemorySize FROM Win32_OperatingSystem")

If Err Then ShowError

	For Each objItem in colItems

		objCommentFile.Write "��������� �����|��������� ������= " & round((((objItem.TotalVisibleMemorySize +1023) / 1024) / 1024),0) & " ��"  & VbCrLf

	Next

on error resume next

Set colItems = objWMIService.ExecQuery("SELECT Name FROM Win32_Keyboard")

	For Each objItem in colItems

		objCommentFile.Write "����|����������= " & objItem.Name & VbCrLf

	Next

on error resume next

Set colMice = objWMIService.ExecQuery _
    ("Select * from Win32_PointingDevice")

	For Each objMouse in colMice

		objCommentFile.Write "����|����= " & objMouse.HardwareType & VbCrLf
	
	Next

on error resume next

Set colItems = objWMIService.ExecQuery("SELECT Description, Manufacturer FROM Win32_SoundDevice")

i=1

	For Each objItem in colItems

		objCommentFile.Write "�����������|�������� �������" & i & "=" & ltrim(objItem.Description) & VbCrLf

		 i=i+1

	Next

on error resume next

Set colItems = objWMIService.ExecQuery("SELECT Product, OtherIdentifyingInfo, SerialNumber, Manufacturer FROM Win32_BaseBoard")

	For Each objItem in colItems

		objCommentFile.Write "DMI|DMI �������� ����� ��������� �����= " & ltrim(objItem.SerialNumber) & VbCrLf

	Next

	objCommentFile.Write VbCrLf

	objCommentFile.Write VbCrLf

	objCommentFile.Write "[DMI]"

	objCommentFile.Write VbCrLf

	objCommentFile.Write VbCrLf

on error resume next

Set objWMIService = GetObject("winmgmts:" & "{impersonationLevel=impersonate}!\\" & strComputer & "\root\cimv2")
 
Set colItems = objWMIService.ExecQuery("SELECT Name, CurrentClockSpeed, SocketDesignation, Manufacturer FROM Win32_Processor")

i=1

	For Each objItem in colItems

		objCommentFile.Write "����������" & i & "|�������� ����������|�������������= " & ltrim(objItem.Manufacturer) & VbCrLf

		objCommentFile.Write "����������" & i & "|�������� ����������|������= " & ltrim(objItem.Name) & VbCrLf

		objCommentFile.Write "����������" & i & "|�������� ����������|��� �������= " & ltrim(objItem.SocketDesignation) & VbCrLf

		objCommentFile.Write "����������" & i & "|�������� ����������|������� �������= " & ltrim(objItem.CurrentClockSpeed) & VbCrLf
		i=i+1
	
	Next

objCommentFile.Write VbCrLf

objCommentFile.Write VbCrLf

objCommentFile.Write "[��������� �����]"

objCommentFile.Write VbCrLf

objCommentFile.Write VbCrLf

on error resume next

Set colItems = objWMIService.ExecQuery("SELECT Product, OtherIdentifyingInfo, SerialNumber, Manufacturer FROM Win32_BaseBoard")


	For Each objItem in colItems

		objCommentFile.Write "������������� ��������� �����|�����= " & ltrim(objItem.Manufacturer) & VbCrLf

		objCommentFile.Write "�������� ��������� �����|��������� �����= " & ltrim(objItem.Product) & VbCrLf

		objCommentFile.Write "DMI|DMI �������� ����� ��������� �����= " & ltrim(objItem.SerialNumber) & VbCrLf
	
	Next

objCommentFile.Write VbCrLf

objCommentFile.Write VbCrLf

objCommentFile.Write "[����� Windows]"

objCommentFile.Write VbCrLf

objCommentFile.Write VbCrLf

on error resume next

Set colItems = objWMIService.ExecQuery ("SELECT Name, AdapterRAM FROM Win32_VideoController")

i=1

	For Each objItem in colItems

		objCommentFile.Write "����� Windows" & i & "|�������� �������������|����� ��������= " & round((((objItem.AdapterRAM) / 1024) / 1024),0) & " ��."  & VbCrLf

		objCommentFile.Write "����� Windows" & i & "|�������� �������������|�������� ����������= " & ltrim(objItem.Name)  & VbCrLf

		i=i+1
	
	Next

objCommentFile.Write VbCrLf

objCommentFile.Write VbCrLf

objCommentFile.Write "[�������]"

objCommentFile.Write VbCrLf

objCommentFile.Write VbCrLf

on error resume next

Set colItems = objWMIService.ExecQuery("SELECT * FROM Win32_DesktopMonitor")

i=1

	For Each objItem in colItems

		objCommentFile.Write "�������" & i & "|�������� ��������|��� ��������= " & ltrim(objItem.Name)  & VbCrLf

		objCommentFile.Write "�������" & i & "|�������� ��������|ID ��������= " & ltrim(objItem.DeviceID)  & VbCrLf

		objCommentFile.Write "�������" & i & "|������������� ��������|�����= " & ltrim(objItem.MonitorManufacturer)  & VbCrLf

		objCommentFile.Write "�������" & i & "|�������� ��������|��� ��������= " & ltrim(objItem.DisplayType)  & VbCrLf

i=i+1

Next

objCommentFile.Write VbCrLf

objCommentFile.Write VbCrLf

objCommentFile.Write "[ATA]"

objCommentFile.Write VbCrLf

objCommentFile.Write VbCrLf

on error resume next

Set colDiskDrives = objWMIService.ExecQuery ("SELECT Model, size, Manufacturer FROM Win32_DiskDrive WHERE InterfaceType <> 'USB'")

i=1

	For each objDiskDrive in colDiskDrives

		objCommentFile.Write "ATA" & i & "|������������� ATA-����������|�����= " & ltrim(objDiskDrive.Manufacturer)  & VbCrLf

		objCommentFile.Write "ATA" & i & "|�������� ���������� ATA|ID ������= " & ltrim(objDiskDrive.Model)  & VbCrLf

		objCommentFile.Write "ATA" & i & "|���������� ������ ���������� ATA|��������������� �������= " & round(((objDiskDrive.Size /1024)/1024)/1024,0)  & " ��"  & VbCrLf  

		Set colDiskDrivesL = objWMIService.ExecQuery ("SELECT * FROM Win32_PhysicalMedia")
		j=1
		For each objDisk in colDiskDrivesL
		if i=j then
				objCommentFile.Write "ATA" & j & "|�������� ���������� ATA|�������� �����= " & ltrim(objDisk.SerialNumber)  & VbCrLf
			end if
			j=j+1
		Next

		i=i+1

	Next
 
'Set colDiskDrives = objWMIService.ExecQuery ("SELECT * FROM Win32_PhysicalMedia")

'i=1

'	For each objDiskDrive in colDiskDrives
'		objCommentFile.Write "ATA" & i & "|�������� ���������� ATA|�������� �����= " & ltrim(objDiskDrive.SerialNumber)  & VbCrLf
'		i=i+1
'	Next

objCommentFile.Write VbCrLf
objCommentFile.Write VbCrLf
objCommentFile.Write "[���������� ����������]"
objCommentFile.Write VbCrLf
objCommentFile.Write VbCrLf

on error resume next

Set colItems = objWMIService.ExecQuery("Select * from Win32_CDROMDrive")

i=1

	For Each objItem in colItems

		objCommentFile.Write "���������� ����������" & i & "|�������� ����������� ����������|�������������= " & ltrim(objItem.Manufacturer)  & VbCrLf

		objCommentFile.Write "���������� ����������" & i & "|�������� ����������� ����������|�������� ����������= " & ltrim(objItem.Name)  & VbCrLf

		i=i+1

	Next

objCommentFile.Write VbCrLf

objCommentFile.Write VbCrLf

objCommentFile.Write "[��������]"

objCommentFile.Write VbCrLf

objCommentFile.Write VbCrLf

on error resume next

Set colInstalledPrinters =  objWMIService.ExecQuery ("SELECT Name FROM Win32_Printer")

i=1

	For each objPrinter in colInstalledPrinters

	if (objPrinter.Name = "Fax") or (objPrinter.Name = "Microsoft XPS Document Writer") or objPrinter.name = "��������� � OneNote 2010" then
		'If (clpSTR Like "*'*") And Not (tagSTR Like "*apos*") Then 

	else
		objCommentFile.Write "��������" & i & "|�������� ��������|��� ��������= " & ltrim(objPrinter.Name)   & VbCrLf
		i=i+1

	end if

	Next

objCommentFile.Write VbCrLf

objCommentFile.Write VbCrLf

objCommentFile.Write "[���� Windows]"

objCommentFile.Write VbCrLf

objCommentFile.Write VbCrLf

'######################################################################################################

on error resume next

Set colItems = objWMIService.ExecQuery _
    ("SELECT * FROM Win32_NetworkAdapterConfiguration WHERE IPEnabled = True")

On Error Resume Next

i=1

	For Each objItem in colItems

		For Each arrValue In arrIPAddress

		If Not IsNull(objItem.IPAddress) Then

			For z = 0 To UBound(objItem.IPAddress)

			objCommentFile.Write  "���� Windows" & i & "|������ �������� ��������|����� IP / �������= " & ltrim(objItem.IPAddress(z))  & VbCrLf

			i=i+1

			Next

		End If

			i=1

			objCommentFile.Write  "���� Windows" & i & "|�������� �������� ��������|���������� �����= " & ltrim(objItem.MACAddress)  & VbCrLf

			objCommentFile.Write  "���� Windows" & i & "|�������� �������� ��������|������� �������= " & ltrim(objItem.Description)  & VbCrLf

			i=i+1

		Next
	
	Next

'#######################################################################################################

Set WshShell = CreateObject("WScript.Shell")
regKey = "HKLM\SOFTWARE\Microsoft\Windows NT\CurrentVersion\"
DigitalProductId = WshShell.RegRead(regKey & "DigitalProductId")
 
Win8ProductName = "Windows Product Name: " & WshShell.RegRead(regKey & "ProductName") & vbNewLine
Win8ProductID = "Windows Product ID: " & WshShell.RegRead(regKey & "ProductID") & vbNewLine
Win8ProductKey = ConvertToKey(DigitalProductId)
strProductKey ="Windows 8 Key: " & Win8ProductKey 
Win8ProductID = Win8ProductName & Win8ProductID & strProductKey 
 
objCommentFile.Write VbCrLf

objCommentFile.Write VbCrLf

objCommentFile.Write "[������������ �������]"

objCommentFile.Write VbCrLf

objCommentFile.Write VbCrLf

on error resume next

Set objWMIService = GetObject("winmgmts:" & "{impersonationLevel=impersonate}!\\" & strComputer & "\root\cimv2")

Set colOperatingSystems = objWMIService.ExecQuery ("Select * from Win32_OperatingSystem")

	For Each objOperatingSystem in colOperatingSystems

		objCommentFile.Write "�������� ������������ �������|�������� ��= " & ltrim(objOperatingSystem.Caption) & VbCrLf

		objCommentFile.Write "������������ ����������|���� ��������= " & ltrim(Win8ProductKey) & VbCrLf

		objCommentFile.Write "�������� ������������ �������|������ ��= " & ltrim(objOperatingSystem.Version) & VbCrLf

	Next

objCommentFile.Write VbCrLf

objCommentFile.Write VbCrLf

objCommentFile.Write "[������������� ���������]"

objCommentFile.Write VbCrLf

objCommentFile.Write VbCrLf

on error resume next   


'*******************************
uninstall_string="SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall\"
HKLM=&H80000002
Set objWMI = GetObject("winmgmts:\\.\root\CIMV2")
Set objCtx = CreateObject("WbemScripting.SWbemNamedValueSet")

i = 1
objCtx.Add "__ProviderArchitecture", 32
PO()

Set colItems = objWMI.ExecQuery("SELECT * FROM Win32_OperatingSystem")
For Each objItem In colItems
	OsArch=Left(objItem.OSArchitecture,2)
Next
If OsArch="64" Then
	objCtx.Add "__ProviderArchitecture", 64
	PO()
End If


Sub PO()
	Set objLocator = CreateObject("Wbemscripting.SWbemLocator")
	Set objServices = objLocator.ConnectServer("","root\default","","",,,,objCtx)
	Set objStdRegProv = objServices.Get("StdRegProv")

	Set InParams = objStdRegProv.Methods_("EnumKey").InParameters
	Inparams.Hdefkey = HKLM
	Inparams.sSubKeyName = uninstall_string

	Set Outparams = objStdRegProv.ExecMethod_("EnumKey", Inparams,,objCtx)
	For Each strSubKey In Outparams.sNames
		Set InParam = objStdRegProv.Methods_("GetStringValue").InParameters
		Inparam.sSubKeyName=uninstall_string &"\"& strSubKey
		Inparam.Hdefkey = HKLM

		Inparam.sValueName="DisplayName"
		Set OutDisplayName = objStdRegProv.ExecMethod_("GetStringValue", Inparam,,objCtx)

		Inparam.sValueName="UninstallString"
		Set OutUninstallString = objStdRegProv.ExecMethod_("GetStringValue", Inparam,,objCtx)

		Inparam.sValueName="Publisher"
		Set OutPublisher = objStdRegProv.ExecMethod_("GetStringValue", Inparam,,objCtx)

		Inparam.sValueName="InstallDate"
		Set OutInstallDate = objStdRegProv.ExecMethod_("GetStringValue", Inparam,,objCtx)
		strValue = OutInstallDate.sValue

		If (StrComp(OutUninstallString.sValue,"") <> 0) Then
			objCommentFile.Write "������������� ���������" & i & "= " & OutDisplayName.sValue & VbCrLf
			objCommentFile.Write OutDisplayName.sValue & "|Publisher=" & OutPublisher.sValue & VbCrLf
			objCommentFile.Write OutDisplayName.sValue & "|����=" & Mid(strValue,1,4) & "-" & Mid(strValue,5,2) & "-" & Mid(strValue,7,7) & VbCrLf
			i = i + 1
		End If
		Set InParam = Nothing
	Next
End Sub
'*******************************

Sub ShowError()

                strMsg = vbCrLf & "Error # " & Err.Number & vbCrLf & _
                         Err.Description & vbCrLf & vbCrLf

                Syntax

End Sub

Function ConvertToKey(regKey)
    Const KeyOffset = 52
    isWin8 = (regKey(66) \ 6) And 1
    regKey(66) = (regKey(66) And &HF7) Or ((isWin8 And 2) * 4)
    j = 24
    Chars = "BCDFGHJKMPQRTVWXY2346789"
    Do
        Cur = 0
        y = 14
        Do
            Cur = Cur * 256
            Cur = regKey(y + KeyOffset) + Cur
            regKey(y + KeyOffset) = (Cur \ 24)
            Cur = Cur Mod 24
            y = y -1
        Loop While y >= 0
        j = j -1
        winKeyOutput = Mid(Chars, Cur + 1, 1) & winKeyOutput
        Last = Cur
    Loop While j >= 0
    If (isWin8 = 1) Then
        keypart1 = Mid(winKeyOutput, 2, Last)
        insert = "N"
        winKeyOutput = Replace(winKeyOutput, keypart1, keypart1 & insert, 2, 1, 0)
        If Last = 0 Then winKeyOutput = insert & winKeyOutput
    End If
    a = Mid(winKeyOutput, 1, 5)
    b = Mid(winKeyOutput, 6, 5)
    c = Mid(winKeyOutput, 11, 5)
    d = Mid(winKeyOutput, 16, 5)
    e = Mid(winKeyOutput, 21, 5)
    ConvertToKey = a & "-" & b & "-" & c & "-" & d & "-" & e
End Function

If (Idle = 0) Then
	MsgBox "����� �������� � ����", vbInformation, "�������������� �����������"
End If

objCommentFile.Close