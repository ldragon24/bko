Const NetOut = 0  ' 0 - ini пишетя рядом, 1 - на сервер
Const Idle = 0  ' 0 - сообщение об окончании сбора данных

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

	objCommentFile.Write "[Суммарная информация]"

	objCommentFile.Write VbCrLf

	objCommentFile.Write VbCrLf

	objCommentFile.Write "Компьютер|Имя компьютера= " & strComputer & VbCrLf

on error resume next

Set colItems = objWMIService.ExecQuery("SELECT TotalVisibleMemorySize FROM Win32_OperatingSystem")

If Err Then ShowError

	For Each objItem in colItems

		objCommentFile.Write "Системная плата|Системная память= " & round((((objItem.TotalVisibleMemorySize +1023) / 1024) / 1024),0) & " ГБ"  & VbCrLf

	Next

on error resume next

Set colItems = objWMIService.ExecQuery("SELECT Name FROM Win32_Keyboard")

	For Each objItem in colItems

		objCommentFile.Write "Ввод|Клавиатура= " & objItem.Name & VbCrLf

	Next

on error resume next

Set colMice = objWMIService.ExecQuery _
    ("Select * from Win32_PointingDevice")

	For Each objMouse in colMice

		objCommentFile.Write "Ввод|Мышь= " & objMouse.HardwareType & VbCrLf
	
	Next

on error resume next

Set colItems = objWMIService.ExecQuery("SELECT Description, Manufacturer FROM Win32_SoundDevice")

i=1

	For Each objItem in colItems

		objCommentFile.Write "Мультимедиа|Звуковой адаптер" & i & "=" & ltrim(objItem.Description) & VbCrLf

		 i=i+1

	Next

on error resume next

Set colItems = objWMIService.ExecQuery("SELECT Product, OtherIdentifyingInfo, SerialNumber, Manufacturer FROM Win32_BaseBoard")

	For Each objItem in colItems

		objCommentFile.Write "DMI|DMI серийный номер системной платы= " & ltrim(objItem.SerialNumber) & VbCrLf

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

		objCommentFile.Write "Процессоры" & i & "|Свойства процессора|Производитель= " & ltrim(objItem.Manufacturer) & VbCrLf

		objCommentFile.Write "Процессоры" & i & "|Свойства процессора|Версия= " & ltrim(objItem.Name) & VbCrLf

		objCommentFile.Write "Процессоры" & i & "|Свойства процессора|Тип разъёма= " & ltrim(objItem.SocketDesignation) & VbCrLf

		objCommentFile.Write "Процессоры" & i & "|Свойства процессора|Текущая частота= " & ltrim(objItem.CurrentClockSpeed) & VbCrLf
		i=i+1
	
	Next

objCommentFile.Write VbCrLf

objCommentFile.Write VbCrLf

objCommentFile.Write "[Системная плата]"

objCommentFile.Write VbCrLf

objCommentFile.Write VbCrLf

on error resume next

Set colItems = objWMIService.ExecQuery("SELECT Product, OtherIdentifyingInfo, SerialNumber, Manufacturer FROM Win32_BaseBoard")


	For Each objItem in colItems

		objCommentFile.Write "Производитель системной платы|Фирма= " & ltrim(objItem.Manufacturer) & VbCrLf

		objCommentFile.Write "Свойства системной платы|Системная плата= " & ltrim(objItem.Product) & VbCrLf

		objCommentFile.Write "DMI|DMI серийный номер системной платы= " & ltrim(objItem.SerialNumber) & VbCrLf
	
	Next

objCommentFile.Write VbCrLf

objCommentFile.Write VbCrLf

objCommentFile.Write "[Видео Windows]"

objCommentFile.Write VbCrLf

objCommentFile.Write VbCrLf

on error resume next

Set colItems = objWMIService.ExecQuery ("SELECT Name, AdapterRAM FROM Win32_VideoController")

i=1

	For Each objItem in colItems

		objCommentFile.Write "Видео Windows" & i & "|Свойства видеоадаптера|Объем видеоОЗУ= " & round((((objItem.AdapterRAM) / 1024) / 1024),0) & " Мб."  & VbCrLf

		objCommentFile.Write "Видео Windows" & i & "|Свойства видеоадаптера|Описание устройства= " & ltrim(objItem.Name)  & VbCrLf

		i=i+1
	
	Next

objCommentFile.Write VbCrLf

objCommentFile.Write VbCrLf

objCommentFile.Write "[Монитор]"

objCommentFile.Write VbCrLf

objCommentFile.Write VbCrLf

on error resume next

Set colItems = objWMIService.ExecQuery("SELECT * FROM Win32_DesktopMonitor")

i=1

	For Each objItem in colItems

		objCommentFile.Write "Монитор" & i & "|Свойства монитора|Имя монитора= " & ltrim(objItem.Name)  & VbCrLf

		objCommentFile.Write "Монитор" & i & "|Свойства монитора|ID монитора= " & ltrim(objItem.DeviceID)  & VbCrLf

		objCommentFile.Write "Монитор" & i & "|Производитель монитора|Фирма= " & ltrim(objItem.MonitorManufacturer)  & VbCrLf

		objCommentFile.Write "Монитор" & i & "|Свойства монитора|Тип монитора= " & ltrim(objItem.DisplayType)  & VbCrLf

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

		objCommentFile.Write "ATA" & i & "|Производитель ATA-устройства|Фирма= " & ltrim(objDiskDrive.Manufacturer)  & VbCrLf

		objCommentFile.Write "ATA" & i & "|Свойства устройства ATA|ID модели= " & ltrim(objDiskDrive.Model)  & VbCrLf

		objCommentFile.Write "ATA" & i & "|Физические данные устройства ATA|Форматированная ёмкость= " & round(((objDiskDrive.Size /1024)/1024)/1024,0)  & " ГБ"  & VbCrLf  

		Set colDiskDrivesL = objWMIService.ExecQuery ("SELECT * FROM Win32_PhysicalMedia")
		j=1
		For each objDisk in colDiskDrivesL
		if i=j then
				objCommentFile.Write "ATA" & j & "|Свойства устройства ATA|Серийный номер= " & ltrim(objDisk.SerialNumber)  & VbCrLf
			end if
			j=j+1
		Next

		i=i+1

	Next
 
'Set colDiskDrives = objWMIService.ExecQuery ("SELECT * FROM Win32_PhysicalMedia")

'i=1

'	For each objDiskDrive in colDiskDrives
'		objCommentFile.Write "ATA" & i & "|Свойства устройства ATA|Серийный номер= " & ltrim(objDiskDrive.SerialNumber)  & VbCrLf
'		i=i+1
'	Next

objCommentFile.Write VbCrLf
objCommentFile.Write VbCrLf
objCommentFile.Write "[Оптические накопители]"
objCommentFile.Write VbCrLf
objCommentFile.Write VbCrLf

on error resume next

Set colItems = objWMIService.ExecQuery("Select * from Win32_CDROMDrive")

i=1

	For Each objItem in colItems

		objCommentFile.Write "Оптические накопители" & i & "|Свойства оптического накопителя|Производитель= " & ltrim(objItem.Manufacturer)  & VbCrLf

		objCommentFile.Write "Оптические накопители" & i & "|Свойства оптического накопителя|Описание устройства= " & ltrim(objItem.Name)  & VbCrLf

		i=i+1

	Next

objCommentFile.Write VbCrLf

objCommentFile.Write VbCrLf

objCommentFile.Write "[Принтеры]"

objCommentFile.Write VbCrLf

objCommentFile.Write VbCrLf

on error resume next

Set colInstalledPrinters =  objWMIService.ExecQuery ("SELECT Name FROM Win32_Printer")

i=1

	For each objPrinter in colInstalledPrinters

	if (objPrinter.Name = "Fax") or (objPrinter.Name = "Microsoft XPS Document Writer") or objPrinter.name = "Отправить в OneNote 2010" then
		'If (clpSTR Like "*'*") And Not (tagSTR Like "*apos*") Then 

	else
		objCommentFile.Write "Принтеры" & i & "|Свойства принтера|Имя принтера= " & ltrim(objPrinter.Name)   & VbCrLf
		i=i+1

	end if

	Next

objCommentFile.Write VbCrLf

objCommentFile.Write VbCrLf

objCommentFile.Write "[Сеть Windows]"

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

			objCommentFile.Write  "Сеть Windows" & i & "|Адреса сетевого адаптера|Маска IP / Подсети= " & ltrim(objItem.IPAddress(z))  & VbCrLf

			i=i+1

			Next

		End If

			i=1

			objCommentFile.Write  "Сеть Windows" & i & "|Свойства сетевого адаптера|Аппаратный адрес= " & ltrim(objItem.MACAddress)  & VbCrLf

			objCommentFile.Write  "Сеть Windows" & i & "|Свойства сетевого адаптера|Сетевой адаптер= " & ltrim(objItem.Description)  & VbCrLf

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

objCommentFile.Write "[Операционная система]"

objCommentFile.Write VbCrLf

objCommentFile.Write VbCrLf

on error resume next

Set objWMIService = GetObject("winmgmts:" & "{impersonationLevel=impersonate}!\\" & strComputer & "\root\cimv2")

Set colOperatingSystems = objWMIService.ExecQuery ("Select * from Win32_OperatingSystem")

	For Each objOperatingSystem in colOperatingSystems

		objCommentFile.Write "Свойства операционной системы|Название ОС= " & ltrim(objOperatingSystem.Caption) & VbCrLf

		objCommentFile.Write "Лицензионная информация|Ключ продукта= " & ltrim(Win8ProductKey) & VbCrLf

		objCommentFile.Write "Свойства операционной системы|Версия ОС= " & ltrim(objOperatingSystem.Version) & VbCrLf

	Next

objCommentFile.Write VbCrLf

objCommentFile.Write VbCrLf

objCommentFile.Write "[Установленные программы]"

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
			objCommentFile.Write "Установленные программы" & i & "= " & OutDisplayName.sValue & VbCrLf
			objCommentFile.Write OutDisplayName.sValue & "|Publisher=" & OutPublisher.sValue & VbCrLf
			objCommentFile.Write OutDisplayName.sValue & "|Дата=" & Mid(strValue,1,4) & "-" & Mid(strValue,5,2) & "-" & Mid(strValue,7,7) & VbCrLf
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
	MsgBox "Отчет сохранен в файл", vbInformation, "Инвентаризация компьютеров"
End If

objCommentFile.Close