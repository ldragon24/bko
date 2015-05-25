Const ForReading = 1

Const ForWriting = 2

 

strComputer = "."

 

 

 

'Set objComputer = CreateObject("Shell.LocalMachine")

 

Set objWMIService = GetObject( "winmgmts://./root/cimv2" )

               

                Set colItems = objWMIService.ExecQuery( "Select * from Win32_ComputerSystem", "WQL", 48 )

               

                For Each objItem in colItems

                               strComputer = objItem.Name

                Next

 

Set objFSO = CreateObject("Scripting.FileSystemObject")

 

Set objCommentFile = objFSO.OpenTextFile(strComputer & ".ini",  ForWriting, TRUE)

 

 

on error resume next

 

objCommentFile.Write "[Суммарная информация]"

objCommentFile.Write VbCrLf

objCommentFile.Write VbCrLf

 

 

               

objCommentFile.Write "Компьютер|Имя компьютера= " & strComputer & VbCrLf

 

on error resume next

Set colItems = objWMIService.ExecQuery("SELECT TotalVisibleMemorySize FROM Win32_OperatingSystem")

If Err Then ShowError

 

For Each objItem in colItems

     objCommentFile.Write "Системная плата|Системная память= " & (((objItem.TotalVisibleMemorySize +1023) / 1024) / 1024) & " ГБ"  & VbCrLf

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

    objCommentFile.Write "Мультимедиа|Звуковой адаптер" & i & "=" & objItem.Description & VbCrLf

    i=i+1

Next

on error resume next

Set colItems = objWMIService.ExecQuery("SELECT Product, OtherIdentifyingInfo, SerialNumber, Manufacturer FROM Win32_BaseBoard")

 

For Each objItem in colItems

 

objCommentFile.Write "DMI|DMI серийный номер системной платы= " & objItem.SerialNumber & VbCrLf

 

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

   objCommentFile.Write "Процессоры" & i & "|Свойства процессора|Производитель= " & objItem.Manufacturer & VbCrLf

   objCommentFile.Write "Процессоры" & i & "|Свойства процессора|Версия= " & objItem.Name & VbCrLf

   objCommentFile.Write "Процессоры" & i & "|Свойства процессора|Тип разъёма= " & objItem.SocketDesignation & VbCrLf

   objCommentFile.Write "Процессоры" & i & "|Свойства процессора|Текущая частота= " & objItem.CurrentClockSpeed & VbCrLf

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

 

 

objCommentFile.Write "Производитель системной платы|Фирма= " & objItem.Manufacturer & VbCrLf

objCommentFile.Write "Свойства системной платы|Системная плата= " & objItem.Product & VbCrLf

objCommentFile.Write "DMI|DMI серийный номер системной платы= " & objItem.SerialNumber & VbCrLf

 

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

    objCommentFile.Write "Видео Windows" & i & "|Свойства видеоадаптера|Объем видеоОЗУ= " & (((objItem.AdapterRAM) / 1024) / 1024) & " Мб."  & VbCrLf

    objCommentFile.Write "Видео Windows" & i & "|Свойства видеоадаптера|Описание устройства= " & objItem.Name  & VbCrLf

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

   

objCommentFile.Write "Монитор" & i & "|Свойства монитора|Имя монитора= " & objItem.Name  & VbCrLf

objCommentFile.Write "Монитор" & i & "|Свойства монитора|ID монитора= " & objItem.DeviceID  & VbCrLf

objCommentFile.Write "Монитор" & i & "|Производитель монитора|Фирма= " & objItem.MonitorManufacturer  & VbCrLf

objCommentFile.Write "Монитор" & i & "|Свойства монитора|Тип монитора= " & objItem.DisplayType  & VbCrLf

i=i+1

Next

 

 

objCommentFile.Write VbCrLf

objCommentFile.Write VbCrLf

 

objCommentFile.Write "[ATA]"

 

objCommentFile.Write VbCrLf

objCommentFile.Write VbCrLf

 

on error resume next

Set colDiskDrives = objWMIService.ExecQuery ("SELECT Model, size, Manufacturer FROM Win32_DiskDrive")

 

i=1

For each objDiskDrive in colDiskDrives

 

   objCommentFile.Write "ATA" & i & "|Производитель ATA-устройства|Фирма= " & objDiskDrive.Manufacturer  & VbCrLf

   objCommentFile.Write "ATA" & i & "|Свойства устройства ATA|ID модели= " & objDiskDrive.Model  & VbCrLf

   objCommentFile.Write "ATA" & i & "|Физические данные устройства ATA|Форматированная ёмкость= " & ((objDiskDrive.Size /1024)/1024)/1024  & VbCrLf     

    

    i=i+1

Next

 

objCommentFile.Write VbCrLf

objCommentFile.Write VbCrLf

 

objCommentFile.Write "[Оптические накопители]"

 

objCommentFile.Write VbCrLf

objCommentFile.Write VbCrLf

 

on error resume next

Set colItems = objWMIService.ExecQuery("Select * from Win32_CDROMDrive")

i=1

For Each objItem in colItems

 

    objCommentFile.Write "Оптические накопители" & i & "|Свойства оптического накопителя|Производитель= " & objItem.Manufacturer  & VbCrLf

    objCommentFile.Write "Оптические накопители" & i & "|Свойства оптического накопителя|Описание устройства= " & objItem.Name  & VbCrLf

   

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

 

if objPrinter.Name = "Fax" or objPrinter.Name = "Microsoft XPS Document Writer" then

 

else

    objCommentFile.Write "Принтеры" & i & "|Свойства принтера|Имя принтера= " & objPrinter.Name   & VbCrLf

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

        objCommentFile.Write  "Сеть Windows" & i & "|Адреса сетевого адаптера|Маска IP / Подсети= " & objItem.IPAddress(z)  & VbCrLf

      i=i+1

Next

   End If

 

i=1

objCommentFile.Write  "Сеть Windows" & i & "|Свойства сетевого адаптера|Аппаратный адрес= " & objItem.MACAddress  & VbCrLf

objCommentFile.Write  "Сеть Windows" & i & "|Свойства сетевого адаптера|Сетевой адаптер= " & objItem.Description  & VbCrLf

i=i+1

Next

 

 

 

Next

 

 

 

'#######################################################################################################

 

 

objCommentFile.Write VbCrLf

objCommentFile.Write VbCrLf

 

objCommentFile.Write "[Операционная система]"

 

objCommentFile.Write VbCrLf

objCommentFile.Write VbCrLf

 

on error resume next

Set objWMIService = GetObject("winmgmts:" & "{impersonationLevel=impersonate}!\\" & strComputer & "\root\cimv2")

 

Set colOperatingSystems = objWMIService.ExecQuery ("Select * from Win32_OperatingSystem")

 

For Each objOperatingSystem in colOperatingSystems

    objCommentFile.Write "Свойства операционной системы|Название ОС= " & objOperatingSystem.Caption & VbCrLf

    objCommentFile.Write "Лицензионная информация|Ключ продукта= " & objOperatingSystem.SerialNumber & VbCrLf

    objCommentFile.Write "Свойства операционной системы|Версия ОС= " & objOperatingSystem.Version & VbCrLf

Next

 

objCommentFile.Write VbCrLf

objCommentFile.Write VbCrLf

 

objCommentFile.Write "[Установленные программы]"

 

objCommentFile.Write VbCrLf

objCommentFile.Write VbCrLf

 

on error resume next   

Set objWMIService = GetObject("winmgmts:" & "{impersonationLevel=impersonate}!\\" & strComputer & "\root\cimv2")

Set colSoftware = objWMIService.ExecQuery("SELECT Name, Vendor FROM Win32_Product")

 

i=1

For Each objSoftware in colSoftware

   objCommentFile.Write "Установленные программы" & i & "= " & objSoftware.Name & VbCrLf

   objCommentFile.Write objSoftware.Name & "|Publisher=" & objSoftware.Vendor & VbCrLf

      i=i+1

Next

 

 

Sub ShowError()

                strMsg = vbCrLf & "Error # " & Err.Number & vbCrLf & _
                         Err.Description & vbCrLf & vbCrLf

                Syntax

End Sub

 

 

objCommentFile.Close