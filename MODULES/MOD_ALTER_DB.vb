
Module MOD_ALTER_DB

    Public Sub ALTER_DB()

        Select Case sVERSIA


            Case "1.7"

                frmLogin.Invoke(New MethodInvoker(AddressOf ALTER_DB_17))

            Case "1.7.1"

                frmLogin.Invoke(New MethodInvoker(AddressOf ALTER_DB_171))

            Case "1.7.1.1"

                frmLogin.Invoke(New MethodInvoker(AddressOf ALTER_DB_1711))

            Case "1.7.2"

                frmLogin.Invoke(New MethodInvoker(AddressOf ALTER_DB_172))

            Case "1.7.3"

                frmLogin.Invoke(New MethodInvoker(AddressOf ALTER_DB_174))

            Case "1.7.4"

                frmLogin.Invoke(New MethodInvoker(AddressOf ALTER_DB_174))

            Case "1.7.3.4.1"

                frmLogin.Invoke(New MethodInvoker(AddressOf ALTER_DB_1735))

            Case "1.7.3.5"

                frmLogin.Invoke(New MethodInvoker(AddressOf ALTER_DB_17351))

            Case "1.7.3.5.1"

                frmLogin.Invoke(New MethodInvoker(AddressOf ALTER_DB_1736))

            Case "1.7.3.6"

                frmLogin.Invoke(New MethodInvoker(AddressOf ALTER_DB_1738))

            Case "1.7.3.7"


            Case "1.7.3.8"

                frmLogin.Invoke(New MethodInvoker(AddressOf ALTER_DB_1739))

            Case "1.7.3.9"

                frmLogin.Invoke(New MethodInvoker(AddressOf ALTER_DB_1751))

            Case "1.7.5.1"

                frmLogin.Invoke(New MethodInvoker(AddressOf ALTER_DB_1752))

            Case Else

                _DBALTER = True

        End Select

    End Sub

    Public Sub ALTER_DB_17351()

        On Error GoTo err_

        If _DBALTER = False Then Exit Sub

        Dim sSQL As String

        sSQL = "ALTER TABLE Remont ADD GARANT Date"

        Select Case DB_N

            Case "MS SQL 2008"

                sSQL = "ALTER TABLE " & DBtabl & ".dbo.Remont ADD GARANT datetime"

                DB7.Execute(sSQL)

            Case "MS SQL"

                sSQL = "ALTER TABLE " & DBtabl & ".dbo.Remont ADD GARANT datetime"

                DB7.Execute(sSQL)

            Case "MS Access"

                Call frmMain.COMPARE_DB()

                 DB7.Execute(sSQL)

            Case "MS Access 2007"

                Call frmMain.COMPARE_DB()

                 DB7.Execute(sSQL)

            Case "MySQL"

                sSQL = "ALTER TABLE Remont ADD COLUMN GARANT datetime"

                DB7.Execute(sSQL)


            Case "MySQL (MyODBC 5.1)"

                sSQL = "ALTER TABLE Remont ADD COLUMN GARANT datetime"

                DB7.Execute(sSQL)


            Case "PostgreSQL"

                sSQL = "ALTER TABLE Remont ADD COLUMN GARANT Date"

                DB7.Execute(sSQL)

            Case "SQLLite"


            Case "DSN"

                sSQL = "ALTER TABLE Remont ADD COLUMN GARANT Date"

                DB7.Execute(sSQL)

        End Select



        Call ALTER_DB_1736()

        Exit Sub
err_:
        MsgBox(Err.Description)

        _DBALTER = True
    End Sub

    Public Sub ALTER_DB_174()

        On Error GoTo err_

        If _DBALTER = False Then Exit Sub

        Dim sSQL As String

        sSQL = "alter table kompy ADD SNMP_COMMUNITY TEXT , SNMP logical"

        Select Case DB_N

            Case "MS SQL 2008"

                sSQL = "ALTER TABLE " & DBtabl & ".dbo.kompy ADD SNMP_COMMUNITY nvarchar(50) , SNMP bit"

                DB7.Execute(sSQL)

            Case "MS SQL"

                sSQL = "ALTER TABLE " & DBtabl & ".dbo.kompy ADD SNMP_COMMUNITY nvarchar(50) , SNMP bit"

                DB7.Execute(sSQL)

            Case "MS Access"
                Call frmMain.COMPARE_DB()

                DB7.Execute(sSQL)

            Case "MS Access 2007"
                Call frmMain.COMPARE_DB()

                DB7.Execute(sSQL)

            Case "MySQL"

                sSQL = "ALTER TABLE kompy ADD COLUMN SNMP_COMMUNITY VARCHAR(45) AFTER PCL, ADD COLUMN SNMP TINYINT AFTER SNMP_COMMUNITY;"

                DB7.Execute(sSQL)


            Case "MySQL (MyODBC 5.1)"

                sSQL = "ALTER TABLE kompy ADD COLUMN SNMP_COMMUNITY VARCHAR(45) AFTER PCL, ADD COLUMN SNMP TINYINT AFTER SNMP_COMMUNITY;"

                DB7.Execute(sSQL)


            Case "PostgreSQL"

                sSQL = "alter table kompy ADD COLUMN SNMP_COMMUNITY5 TEXT , ADD COLUMN SNMP5 boolean NOT NULL DEFAULT false"

                DB7.Execute(sSQL)

            Case "SQLLite"


            Case "DSN"

                sSQL = "alter table kompy ADD COLUMN SNMP_COMMUNITY5 TEXT , ADD COLUMN SNMP5 boolean NOT NULL DEFAULT false"

                DB7.Execute(sSQL)

        End Select

        sSQL = "CREATE TABLE TBL_DEV_OID (id counter NOT NULL, Device TEXT(50),Developer TEXT(50),Model TEXT(50),LOCATION_OID TEXT(50),NETNAME_OID TEXT(50),CONTACT_OID TEXT(50),MODEL_OID TEXT(50),SER_NUM_OID TEXT(50),TIME_BATTERY_OID TEXT(50),ZARIAD_BATTARY_OID TEXT(50),SOST_BATTARY_OID TEXT(50),ZAMENA_BATTARY_OID TEXT(50),UPTIME_OID TEXT(50),MAC_OID TEXT(50),IN_TOK_OID TEXT(50),OUT_TOK_OID TEXT(50),OUTPUT_FREQ_OID TEXT(50),OUTPUT_LOAD_OID TEXT(50),OUTPUT_STATUS_OID TEXT(50),SELFTEST_OID TEXT(50),SELFTEST_DAY_OID TEXT(50),TEMPERATURE_OID TEXT(50),TEMPERATURE2_OID TEXT(50))"

        Select Case DB_N

            Case "MS SQL 2008"

                sSQL = "CREATE TABLE dbo.TBL_DEV_OID (id int NOT NULL IDENTITY (1, 1), Device nvarchar(50) ,Developer nvarchar(50) ,Model nvarchar(50) ,LOCATION_OID nvarchar(50) ,NETNAME_OID nvarchar(50) ,CONTACT_OID nvarchar(50) ,MODEL_OID nvarchar(50) ,SER_NUM_OID nvarchar(50) ,TIME_BATTERY_OID nvarchar(50) ,ZARIAD_BATTARY_OID nvarchar(50) ,SOST_BATTARY_OID nvarchar(50) ,ZAMENA_BATTARY_OID nvarchar(50) ,UPTIME_OID nvarchar(50) ,MAC_OID nvarchar(50) ,IN_TOK_OID nvarchar(50) ,OUT_TOK_OID nvarchar(50) ,OUTPUT_FREQ_OID nvarchar(50) ,OUTPUT_LOAD_OID nvarchar(50) ,OUTPUT_STATUS_OID nvarchar(50) ,SELFTEST_OID nvarchar(50) ,SELFTEST_DAY_OID nvarchar(50) ,TEMPERATURE_OID nvarchar(50) ,TEMPERATURE2_OID char)"

                DB7.Execute(sSQL)

            Case "MS SQL"

                sSQL = "CREATE TABLE dbo.TBL_DEV_OID (id int NOT NULL IDENTITY (1, 1), Device nvarchar(50) ,Developer nvarchar(50) ,Model nvarchar(50) ,LOCATION_OID nvarchar(50) ,NETNAME_OID nvarchar(50) ,CONTACT_OID nvarchar(50) ,MODEL_OID nvarchar(50) ,SER_NUM_OID nvarchar(50) ,TIME_BATTERY_OID nvarchar(50) ,ZARIAD_BATTARY_OID nvarchar(50) ,SOST_BATTARY_OID nvarchar(50) ,ZAMENA_BATTARY_OID nvarchar(50) ,UPTIME_OID nvarchar(50) ,MAC_OID nvarchar(50) ,IN_TOK_OID nvarchar(50) ,OUT_TOK_OID nvarchar(50) ,OUTPUT_FREQ_OID nvarchar(50) ,OUTPUT_LOAD_OID nvarchar(50) ,OUTPUT_STATUS_OID nvarchar(50) ,SELFTEST_OID nvarchar(50) ,SELFTEST_DAY_OID nvarchar(50) ,TEMPERATURE_OID nvarchar(50) ,TEMPERATURE2_OID char)"

                DB7.Execute(sSQL)

            Case "MS Access"

                Call frmMain.COMPARE_DB()

                DB7.Execute(sSQL)

            Case "MS Access 2007"

                Call frmMain.COMPARE_DB()

                DB7.Execute(sSQL)

            Case "MySQL"

                sSQL = "CREATE TABLE TBL_DEV_OID (id int NOT NULL AUTO_INCREMENT, Device varchar(50) ,Developer varchar(50) ,Model varchar(50) ,LOCATION_OID varchar(50) ,NETNAME_OID varchar(50) ,CONTACT_OID varchar(50) ,MODEL_OID varchar(50) ,SER_NUM_OID varchar(50) ,TIME_BATTERY_OID varchar(50) ,ZARIAD_BATTARY_OID varchar(50) ,SOST_BATTARY_OID varchar(50) ,ZAMENA_BATTARY_OID varchar(50) ,UPTIME_OID varchar(50) ,MAC_OID varchar(50) ,IN_TOK_OID varchar(50) ,OUT_TOK_OID varchar(50) ,OUTPUT_FREQ_OID varchar(50) ,OUTPUT_LOAD_OID varchar(50) ,OUTPUT_STATUS_OID varchar(50) ,SELFTEST_OID varchar(50) ,SELFTEST_DAY_OID varchar(50) ,TEMPERATURE_OID varchar(50) ,TEMPERATURE2_OID VARCHAR(50))"

                DB7.Execute(sSQL)


            Case "MySQL (MyODBC 5.1)"

                sSQL = "CREATE TABLE TBL_DEV_OID (id int NOT NULL AUTO_INCREMENT, Device varchar(50) ,Developer varchar(50) ,Model varchar(50) ,LOCATION_OID varchar(50) ,NETNAME_OID varchar(50) ,CONTACT_OID varchar(50) ,MODEL_OID varchar(50) ,SER_NUM_OID varchar(50) ,TIME_BATTERY_OID varchar(50) ,ZARIAD_BATTARY_OID varchar(50) ,SOST_BATTARY_OID varchar(50) ,ZAMENA_BATTARY_OID varchar(50) ,UPTIME_OID varchar(50) ,MAC_OID varchar(50) ,IN_TOK_OID varchar(50) ,OUT_TOK_OID varchar(50) ,OUTPUT_FREQ_OID varchar(50) ,OUTPUT_LOAD_OID varchar(50) ,OUTPUT_STATUS_OID varchar(50) ,SELFTEST_OID varchar(50) ,SELFTEST_DAY_OID varchar(50) ,TEMPERATURE_OID varchar(50) ,TEMPERATURE2_OID VARCHAR(50))"

                DB7.Execute(sSQL)


            Case "PostgreSQL"

                sSQL = "CREATE TABLE tbl_dev_oid (id serial NOT NULL,device varchar(255) ,developer varchar(255) ,model varchar(255) ,location_oid varchar(255) ,netname_oid varchar(255) ,contact_oid varchar(255) ,model_oid varchar(255) ,ser_num_oid varchar(255) ,time_battery_oid varchar(255) ,zariad_battary_oid varchar(255) ,sost_battary_oid varchar(255) ,zamena_battary_oid varchar(255) ,uptime_oid varchar(255) ,mac_oid varchar(255) ,in_tok_oid varchar(255) ,out_tok_oid varchar(255) ,output_freq_oid varchar(255) ,output_load_oid varchar(255) ,output_status_oid varchar(255) ,selftest_oid varchar(255) ,selftest_day_oid varchar(255) ,temperature_oid varchar(255) ,temperature2_oid varchar(255))"

                DB7.Execute(sSQL)

            Case "SQLLite"


            Case "DSN"

                sSQL = "CREATE TABLE tbl_dev_oid (id serial NOT NULL,device varchar(255) ,developer varchar(255) ,model varchar(255) ,location_oid varchar(255) ,netname_oid varchar(255) ,contact_oid varchar(255) ,model_oid varchar(255) ,ser_num_oid varchar(255) ,time_battery_oid varchar(255) ,zariad_battary_oid varchar(255) ,sost_battary_oid varchar(255) ,zamena_battary_oid varchar(255) ,uptime_oid varchar(255) ,mac_oid varchar(255) ,in_tok_oid varchar(255) ,out_tok_oid varchar(255) ,output_freq_oid varchar(255) ,output_load_oid varchar(255) ,output_status_oid varchar(255) ,selftest_oid varchar(255) ,selftest_day_oid varchar(255) ,temperature_oid varchar(255) ,temperature2_oid varchar(255))"

                DB7.Execute(sSQL)

        End Select

        sSQL = "ALTER TABLE USER_COMP ADD jabber TEXT(255)"

        Select Case DB_N

            Case "MS SQL 2008"

                sSQL = "ALTER TABLE dbo.USER_COMP ADD jabber nvarchar(255)"

                DB7.Execute(sSQL)

            Case "MS SQL"

                sSQL = "ALTER TABLE dbo.USER_COMP ADD jabber nvarchar(255)"

                DB7.Execute(sSQL)

            Case "MS Access"

                Call frmMain.COMPARE_DB()

                DB7.Execute(sSQL)

            Case "MS Access 2007"

                Call frmMain.COMPARE_DB()

                DB7.Execute(sSQL)

            Case "MySQL"

                sSQL = "ALTER TABLE USER_COMP ADD COLUMN jabber varchar(255)"

                DB7.Execute(sSQL)


            Case "MySQL (MyODBC 5.1)"

                sSQL = "ALTER TABLE USER_COMP ADD COLUMN jabber varchar(255)"

                DB7.Execute(sSQL)


            Case "PostgreSQL"

                sSQL = "ALTER TABLE user_comp ADD COLUMN jabber varchar(50)"

                DB7.Execute(sSQL)

            Case "SQLLite"


            Case "DSN"

                sSQL = "ALTER TABLE user_comp ADD COLUMN jabber varchar(50)"

                DB7.Execute(sSQL)

        End Select

        Call ALTER_DB_17341()

        _DBALTER = False


        Exit Sub
err_:
        MsgBox(Err.Description)

        _DBALTER = True
    End Sub

    Public Sub ALTER_DB_17341()

        On Error GoTo err_

        If _DBALTER = False Then Exit Sub


        Dim sSQL As String

        sSQL = "alter table kompy ADD RAM_5 TEXT , RAM_SN_5 TEXT , RAM_speed_5 TEXT , RAM_PROIZV_5 TEXT , RAM_6 TEXT , RAM_SN_6 TEXT , RAM_speed_6 TEXT , RAM_PROIZV_6 TEXT , RAM_7 TEXT , RAM_SN_7 TEXT , RAM_speed_7 TEXT , RAM_PROIZV_7 TEXT , RAM_8 TEXT , RAM_SN_8 TEXT , RAM_speed_8 TEXT , RAM_PROIZV_8 TEXT , HDD_Name_5 TEXT , HDD_OB_5 TEXT ,HDD_SN_5 TEXT ,HDD_PROIZV_5 TEXT , HDD_Name_6 TEXT , HDD_OB_6 TEXT ,HDD_SN_6 TEXT ,HDD_PROIZV_6 TEXT , HDD_Name_7 TEXT , HDD_OB_7 TEXT ,HDD_SN_7 TEXT ,HDD_PROIZV_7 TEXT , HDD_Name_8 TEXT , HDD_OB_8 TEXT ,HDD_SN_8 TEXT ,HDD_PROIZV_8 TEXT"

        Select Case DB_N

            Case "MS SQL 2008"

                sSQL = "ALTER TABLE " & DBtabl & ".dbo.kompy ADD RAM_5 nvarchar(255) , RAM_SN_5 nvarchar(50) , RAM_speed_5 nvarchar(50) , RAM_PROIZV_5 nvarchar(50) , RAM_6 nvarchar(255) , RAM_SN_6 nvarchar(50) , RAM_speed_6 nvarchar(50) , RAM_PROIZV_6 nvarchar(50) , RAM_7 nvarchar(255) , RAM_SN_7 nvarchar(50) , RAM_speed_7 nvarchar(50) , RAM_PROIZV_7 nvarchar(50) , RAM_8 nvarchar(255) , RAM_SN_8 nvarchar(50) , RAM_speed_8 nvarchar(50) , RAM_PROIZV_8 nvarchar(50) , HDD_Name_5 nvarchar(255) , HDD_OB_5 nvarchar(50) ,HDD_SN_5 nvarchar(50) ,HDD_PROIZV_5 nvarchar(50) , HDD_Name_6 nvarchar(255) , HDD_OB_6 nvarchar(50) ,HDD_SN_6 nvarchar(50) ,HDD_PROIZV_6 nvarchar(50) , HDD_Name_7 nvarchar(255) , HDD_OB_7 nvarchar(50) ,HDD_SN_7 nvarchar(50) ,HDD_PROIZV_7 nvarchar(50) , HDD_Name_8 nvarchar(255) , HDD_OB_8 nvarchar(50) ,HDD_SN_8 nvarchar(50) ,HDD_PROIZV_8 nvarchar(50)"

                DB7.Execute(sSQL)

            Case "MS SQL"

                sSQL = "ALTER TABLE " & DBtabl & ".dbo.kompy ADD RAM_5 nvarchar(255) , RAM_SN_5 nvarchar(50) , RAM_speed_5 nvarchar(50) , RAM_PROIZV_5 nvarchar(50) , RAM_6 nvarchar(255) , RAM_SN_6 nvarchar(50) , RAM_speed_6 nvarchar(50) , RAM_PROIZV_6 nvarchar(50) , RAM_7 nvarchar(255) , RAM_SN_7 nvarchar(50) , RAM_speed_7 nvarchar(50) , RAM_PROIZV_7 nvarchar(50) , RAM_8 nvarchar(255) , RAM_SN_8 nvarchar(50) , RAM_speed_8 nvarchar(50) , RAM_PROIZV_8 nvarchar(50) , HDD_Name_5 nvarchar(255) , HDD_OB_5 nvarchar(50) ,HDD_SN_5 nvarchar(50) ,HDD_PROIZV_5 nvarchar(50) , HDD_Name_6 nvarchar(255) , HDD_OB_6 nvarchar(50) ,HDD_SN_6 nvarchar(50) ,HDD_PROIZV_6 nvarchar(50) , HDD_Name_7 nvarchar(255) , HDD_OB_7 nvarchar(50) ,HDD_SN_7 nvarchar(50) ,HDD_PROIZV_7 nvarchar(50) , HDD_Name_8 nvarchar(255) , HDD_OB_8 nvarchar(50) ,HDD_SN_8 nvarchar(50) ,HDD_PROIZV_8 nvarchar(50)"

                DB7.Execute(sSQL)

            Case "MS Access"
                Call frmMain.COMPARE_DB()

                DB7.Execute(sSQL)

            Case "MS Access 2007"
                Call frmMain.COMPARE_DB()

                DB7.Execute(sSQL)

            Case "MySQL"

                sSQL = "ALTER TABLE `kompy` ADD COLUMN `ram_5` text,`ram_sn_5` VARCHAR(255),`ram_speed_5` VARCHAR(255),`ram_proizv_5` VARCHAR(255),`ram_6` text,`ram_speed_6` VARCHAR(255),`ram_sn_6` VARCHAR(255),`ram_proizv_6` VARCHAR(255),`ram_7` text,`ram_speed_7` VARCHAR(255),`ram_sn_7` VARCHAR(255),`ram_proizv_7` VARCHAR(255),`ram_8` text,`ram_sn_8` VARCHAR(255),`ram_speed_8` VARCHAR(255),`ram_proizv_8` VARCHAR(255), `hdd_name_5` text,`hdd_ob_5` VARCHAR(255),`hdd_sn_5` VARCHAR(255),`hdd_proizv_5` VARCHAR(255),`hdd_name_6` text,`hdd_ob_6` VARCHAR(255),`hdd_sn_6` VARCHAR(255),`hdd_proizv_6` VARCHAR(255),`hdd_name_7` text,`hdd_ob_7` VARCHAR(255),`hdd_sn_7` VARCHAR(255),`hdd_proizv_7` VARCHAR(255),`hdd_name_8` text,`hdd_ob_8` VARCHAR(255),`hdd_sn_8` VARCHAR(255),`hdd_proizv_8` VARCHAR(255);"

                DB7.Execute(sSQL)


            Case "MySQL (MyODBC 5.1)"

                sSQL = "alter table kompy ADD COLUMN RAM_5 varchar(255) , RAM_SN_5 varchar(50) , RAM_speed_5 varchar(50) , RAM_PROIZV_5 varchar(50) , RAM_6 varchar(255) , RAM_SN_6 varchar(50) , RAM_speed_6 varchar(50) , RAM_PROIZV_6 varchar(50) , RAM_7 varchar(255) , RAM_SN_7 varchar(50) , RAM_speed_7 varchar(50) , RAM_PROIZV_7 varchar(50) , RAM_8 varchar(255) , RAM_SN_8 varchar(50) , RAM_speed_8 varchar(50) , RAM_PROIZV_8 varchar(50) , HDD_Name_5 varchar(255) , HDD_OB_5 varchar(50) ,HDD_SN_5 varchar(50) ,HDD_PROIZV_5 varchar(50) , HDD_Name_6 varchar(255) , HDD_OB_6 varchar(50) ,HDD_SN_6 varchar(50) ,HDD_PROIZV_6 varchar(50) , HDD_Name_7 varchar(255) , HDD_OB_7 varchar(50) ,HDD_SN_7 varchar(50) ,HDD_PROIZV_7 varchar(50) , HDD_Name_8 varchar(255) , HDD_OB_8 varchar(50) ,HDD_SN_8 varchar(50) ,HDD_PROIZV_8 varchar(50)"
                sSQL = "ALTER TABLE `kompy` ADD COLUMN `ram_5` text,`ram_sn_5` VARCHAR(255),`ram_speed_5` VARCHAR(255),`ram_proizv_5` VARCHAR(255),`ram_6` text,`ram_speed_6` VARCHAR(255),`ram_sn_6` VARCHAR(255),`ram_proizv_6` VARCHAR(255),`ram_7` text,`ram_speed_7` VARCHAR(255),`ram_sn_7` VARCHAR(255),`ram_proizv_7` VARCHAR(255),`ram_8` text,`ram_sn_8` VARCHAR(255),`ram_speed_8` VARCHAR(255),`ram_proizv_8` VARCHAR(255), `hdd_name_5` text,`hdd_ob_5` VARCHAR(255),`hdd_sn_5` VARCHAR(255),`hdd_proizv_5` VARCHAR(255),`hdd_name_6` text,`hdd_ob_6` VARCHAR(255),`hdd_sn_6` VARCHAR(255),`hdd_proizv_6` VARCHAR(255),`hdd_name_7` text,`hdd_ob_7` VARCHAR(255),`hdd_sn_7` VARCHAR(255),`hdd_proizv_7` VARCHAR(255),`hdd_name_8` text,`hdd_ob_8` VARCHAR(255),`hdd_sn_8` VARCHAR(255),`hdd_proizv_8` VARCHAR(255);"


                DB7.Execute(sSQL)


            Case "PostgreSQL"

                sSQL = "alter table kompy ADD COLUMN RAM_5 varchar(255) , ADD COLUMN  RAM_SN_5 varchar(255) , ADD COLUMN  RAM_speed_5 varchar(255) , ADD COLUMN  RAM_PROIZV_5 varchar(255) , ADD COLUMN  RAM_6 varchar(255) , ADD COLUMN  RAM_SN_6 varchar(255) , ADD COLUMN  RAM_speed_6 varchar(255) , ADD COLUMN  RAM_PROIZV_6 varchar(255) , ADD COLUMN  RAM_7 varchar(255) , ADD COLUMN  RAM_SN_7 varchar(255) , ADD COLUMN  RAM_speed_7 varchar(255) , ADD COLUMN  RAM_PROIZV_7 varchar(255) , ADD COLUMN  RAM_8 varchar(255) , ADD COLUMN  RAM_SN_8 varchar(255) , ADD COLUMN  RAM_speed_8 varchar(255) , ADD COLUMN  RAM_PROIZV_8 varchar(255) , ADD COLUMN  HDD_Name_5 varchar(255) , ADD COLUMN  HDD_OB_5 varchar(255)"

                DB7.Execute(sSQL)

            Case "SQLLite"


            Case "DSN"

                sSQL = "alter table kompy ADD COLUMN RAM_5 varchar(255) , ADD COLUMN  RAM_SN_5 varchar(255) , ADD COLUMN  RAM_speed_5 varchar(255) , ADD COLUMN  RAM_PROIZV_5 varchar(255) , ADD COLUMN  RAM_6 varchar(255) , ADD COLUMN  RAM_SN_6 varchar(255) , ADD COLUMN  RAM_speed_6 varchar(255) , ADD COLUMN  RAM_PROIZV_6 varchar(255) , ADD COLUMN  RAM_7 varchar(255) , ADD COLUMN  RAM_SN_7 varchar(255) , ADD COLUMN  RAM_speed_7 varchar(255) , ADD COLUMN  RAM_PROIZV_7 varchar(255) , ADD COLUMN  RAM_8 varchar(255) , ADD COLUMN  RAM_SN_8 varchar(255) , ADD COLUMN  RAM_speed_8 varchar(255) , ADD COLUMN  RAM_PROIZV_8 varchar(255) , ADD COLUMN  HDD_Name_5 varchar(255) , ADD COLUMN  HDD_OB_5 varchar(255)"

                DB7.Execute(sSQL)

        End Select


        DB7.Execute("UPDATE kompy SET RAM_5='', RAM_SN_5='', RAM_speed_5='', RAM_PROIZV_5='', RAM_6='', RAM_SN_6='', RAM_speed_6='', RAM_PROIZV_6='', RAM_7='', RAM_SN_7='', RAM_speed_7='', RAM_PROIZV_7='', RAM_8='', RAM_SN_8='', RAM_speed_8='', RAM_PROIZV_8='', HDD_Name_5='', HDD_OB_5='',HDD_SN_5='',HDD_PROIZV_5='', HDD_Name_6='', HDD_OB_6='',HDD_SN_6='',HDD_PROIZV_6='', HDD_Name_7='', HDD_OB_7='',HDD_SN_7='',HDD_PROIZV_7='', HDD_Name_8='', HDD_OB_8='',HDD_SN_8='',HDD_PROIZV_8 =''")

        Call ALTER_DB_1735()

        _DBALTER = False


        Exit Sub
err_:
        MsgBox(Err.Description)

        _DBALTER = True

    End Sub

    Public Sub ALTER_DB_1735()

        On Error GoTo err_

        If _DBALTER = False Then Exit Sub

        Dim sSQL As String

        sSQL = "UPDATE kompy SET NET_IP_1=PRINTER_NAME_2 WHERE TipTehn = 'NET' And PRINTER_NAME_2 <> '' And NET_IP_1 <>''"

        DB7.Execute(sSQL)

        sSQL = "UPDATE kompy SET PRINTER_NAME_2='' WHERE TipTehn = 'NET' And PRINTER_NAME_2 <>'' And NET_IP_1 <>''"

        DB7.Execute(sSQL)

        sSQL = "update kompy set Ser_N_SIS=MONITOR_SN Where tiptehn = 'MONITOR'"

        DB7.Execute(sSQL)

        sSQL = "update kompy set Ser_N_SIS=port_1 Where tiptehn ='NET'"

        DB7.Execute(sSQL)

        sSQL = "update kompy set Ser_N_SIS=PRINTER_SN_1 Where tiptehn = 'Printer'"

        DB7.Execute(sSQL)

        sSQL = "update kompy set Ser_N_SIS=PRINTER_SN_1 Where tiptehn = 'KOpir'"

        DB7.Execute(sSQL)

        sSQL = "update kompy set Ser_N_SIS=PRINTER_SN_1 Where tiptehn = 'MFU'"

        DB7.Execute(sSQL)
        sSQL = "update kompy set Ser_N_SIS=PRINTER_SN_1 Where tiptehn = 'PHONE'"

        DB7.Execute(sSQL)

        sSQL = "update kompy set Ser_N_SIS=PRINTER_SN_1 Where tiptehn = 'PHOTO'"

        DB7.Execute(sSQL)

        sSQL = "update kompy set Ser_N_SIS=PRINTER_SN_1 Where tiptehn = 'FAX'"

        DB7.Execute(sSQL)

        sSQL = "update kompy set Ser_N_SIS=PRINTER_SN_1 Where tiptehn = 'ZIP'"

        DB7.Execute(sSQL)

        sSQL = "update kompy set Ser_N_SIS=PRINTER_SN_1 Where tiptehn = 'OT'"

        DB7.Execute(sSQL)

        sSQL = "update kompy set Ser_N_SIS=PRINTER_SN_1 Where tiptehn = 'USB'"

        DB7.Execute(sSQL)

        sSQL = "update kompy set Ser_N_SIS=PRINTER_SN_1 Where tiptehn = 'SOUND'"

        DB7.Execute(sSQL)

        sSQL = "update kompy set Ser_N_SIS=PRINTER_SN_1 Where tiptehn = 'IBP'"

        DB7.Execute(sSQL)

        sSQL = "update kompy set Ser_N_SIS=PRINTER_SN_1 Where tiptehn = 'FS'"

        DB7.Execute(sSQL)

        sSQL = "update kompy set Ser_N_SIS=PRINTER_SN_1 Where tiptehn = 'KEYB'"

        DB7.Execute(sSQL)

        sSQL = "update kompy set Ser_N_SIS=PRINTER_SN_1 Where tiptehn = 'MOUSE'"

        DB7.Execute(sSQL)

        sSQL = "update kompy set Ser_N_SIS=PRINTER_SN_1 Where tiptehn = 'CNT'"

        DB7.Execute(sSQL)

        Call ALTER_DB_17351()

        Exit Sub
err_:
        MsgBox(Err.Description)

        _DBALTER = True

    End Sub

    Public Sub ALTER_DB_1736()

        On Error GoTo err_

        If _DBALTER = False Then Exit Sub


        Select Case DB_N

            Case "MS SQL 2008"

            Case "MS SQL"

            Case "MS Access"

                Call frmMain.COMPARE_DB()

            Case "MS Access 2007"

                Call frmMain.COMPARE_DB()

            Case "MySQL"

            Case "MySQL (MyODBC 5.1)"

            Case "PostgreSQL"

            Case "SQLLite"

            Case "DSN"

        End Select

        Dim rs As Recordset


        Call ALTER_DB_1738()

        Exit Sub
err_:
        MsgBox(Err.Description)

        _DBALTER = True
    End Sub

    Public Sub ALTER_DB_172()

        On Error GoTo err_

        If _DBALTER = False Then Exit Sub


        Dim sSQL As String

        sSQL = "CREATE TABLE TBL_PPR(id counter, ID_COMP int, TIP_TO TEXT(50), KVARTAL_TO TEXT(50),  YEAR_TO TEXT(50))"
        '  sSQL = "CREATE TABLE TBL_DEV_OID (id counter NOT NULL CONSTRAINT PrimaryKey PRIMARY KEY, Device TEXT(50),Developer TEXT(50),Model TEXT(50),LOCATION_OID TEXT(50),NETNAME_OID TEXT(50),CONTACT_OID TEXT(50),MODEL_OID TEXT(50),SER_NUM_OID TEXT(50),TIME_BATTERY_OID TEXT(50),ZARIAD_BATTARY_OID TEXT(50),SOST_BATTARY_OID TEXT(50),ZAMENA_BATTARY_OID TEXT(50),UPTIME_OID TEXT(50),MAC_OID TEXT(50),IN_TOK_OID TEXT(50),OUT_TOK_OID TEXT(50),OUTPUT_FREQ_OID TEXT(50),OUTPUT_LOAD_OID TEXT(50),OUTPUT_STATUS_OID TEXT(50),SELFTEST_OID TEXT(50),SELFTEST_DAY_OID TEXT(50),TEMPERATURE_OID TEXT(50),TEMPERATURE2_OID TEXT(50))"

        Select Case DB_N

            Case "MS SQL 2008"

                sSQL = "CREATE TABLE dbo.TBL_PPR (id int NOT NULL IDENTITY (1, 1), ID_COMP int,TIP_TO nvarchar(50) ,KVARTAL_TO nvarchar(50) ,YEAR_TO nvarchar(50))"

                DB7.Execute(sSQL)

            Case "MS SQL"

                sSQL = "CREATE TABLE dbo.TBL_PPR (id int NOT NULL IDENTITY (1, 1), ID_COMP int,TIP_TO nvarchar(50) ,KVARTAL_TO nvarchar(50) ,YEAR_TO nvarchar(50))"

                DB7.Execute(sSQL)


            Case "MS Access"

                Call frmMain.COMPARE_DB()

                DB7.Execute(sSQL)

            Case "MS Access 2007"

                Call frmMain.COMPARE_DB()

                DB7.Execute(sSQL)

            Case "MySQL"

                sSQL = "CREATE TABLE TBL_PPR (id integer NOT NULL AUTO_INCREMENT, ID_COMP integer,TIP_TO varchar(50) ,KVARTAL_TO varchar(50) ,YEAR_TO varchar(50))"

                DB7.Execute(sSQL)

            Case "MySQL (MyODBC 5.1)"

                sSQL = "CREATE TABLE TBL_PPR (id integer NOT NULL AUTO_INCREMENT, ID_COMP integer,TIP_TO varchar(50) ,KVARTAL_TO varchar(50) ,YEAR_TO varchar(50))"

                DB7.Execute(sSQL)

            Case "PostgreSQL"

                sSQL = "CREATE TABLE tbl_ppr(id serial NOT NULL,id_comp integer,tip_to varchar(255) ,kvartal_to varchar(255) ,year_to varchar(255))"

                DB7.Execute(sSQL)

            Case "SQLLite"


            Case "DSN"

                sSQL = "CREATE TABLE tbl_ppr(id serial NOT NULL,id_comp integer,tip_to varchar(255) ,kvartal_to varchar(255) ,year_to varchar(255))"

                DB7.Execute(sSQL)

        End Select


        '####################################################################
        Call ALTER_DB_174()

        Exit Sub
err_:
        MsgBox(Err.Description)

        _DBALTER = True

    End Sub

    Public Sub ALTER_DB_1711()

        On Error GoTo err_

        If _DBALTER = False Then Exit Sub

        Dim sSQL As String

        sSQL = "CREATE TABLE TBL_NET_MAG(id counter,id_line TEXT(255),tip_cab TEXT(255) ,dlin_cab int,tip_cab_line TEXT(255) ,svt int,net_port_svt TEXT(255) ,phone TEXT(255) ,svt_memo text ,commutator int,net_port_commutator TEXT(255) ,commutator_memo text ,pref TEXT(255) ,sid int)"

        Select Case DB_N

            Case "MS SQL 2008"

                sSQL = "CREATE TABLE dbo.tbl_net_mag(id int NOT NULL IDENTITY (1, 1),id_line nvarchar(255) ,tip_cab nvarchar(255) ,dlin_cab int,tip_cab_line nvarchar(255) ,svt int,net_port_svt nvarchar(255) ,phone nvarchar(255) ,svt_memo text ,commutator int,net_port_commutator nvarchar(255) ,commutator_memo text ,pref nvarchar(255) ,sid int)"

                DB7.Execute(sSQL)

            Case "MS SQL"

                sSQL = "CREATE TABLE dbo.tbl_net_mag(id int NOT NULL IDENTITY (1, 1),id_line nvarchar(255) ,tip_cab nvarchar(255) ,dlin_cab int,tip_cab_line nvarchar(255) ,svt int,net_port_svt nvarchar(255) ,phone nvarchar(255) ,svt_memo text ,commutator int,net_port_commutator nvarchar(255) ,commutator_memo text ,pref nvarchar(255) ,sid int)"

                DB7.Execute(sSQL)

            Case "MS Access"

                Call frmMain.COMPARE_DB()

                DB7.Execute(sSQL)

            Case "MS Access 2007"

                Call frmMain.COMPARE_DB()

                DB7.Execute(sSQL)

            Case "MySQL"

                sSQL = "CREATE TABLE tbl_net_mag(id int(11) NOT NULL AUTO_INCREMENT,id_line varchar(255) ,tip_cab varchar(255) ,dlin_cab integer DEFAULT 0,tip_cab_line varchar(255) ,svt integer DEFAULT 0,net_port_svt varchar(255) ,phone varchar(255) ,svt_memo TEXT ,commutator integer DEFAULT 0,net_port_commutator varchar(255) ,commutator_memo TEXT ,pref varchar(255) ,sid integer DEFAULT 0)"
                sSQL = "CREATE TABLE tbl_net_mag (id INTEGER UNSIGNED NOT NULL AUTO_INCREMENT,id_line VARCHAR(45),tip_cab VARCHAR(45),dlin_cab INTEGER UNSIGNED,tip_cab_line VARCHAR(45),svt VARCHAR(45),net_port_svt VARCHAR(45),phone VARCHAR(45),svt_memo TEXT,commutator INTEGER UNSIGNED,net_port_commutator VARCHAR(45),commutator_memo TEXT,pref VARCHAR(45),sid INTEGER UNSIGNED"

                DB7.Execute(sSQL)

            Case "MySQL (MyODBC 5.1)"

                sSQL = "CREATE TABLE tbl_net_mag (id INTEGER UNSIGNED NOT NULL AUTO_INCREMENT,id_line VARCHAR(45),tip_cab VARCHAR(45),dlin_cab INTEGER UNSIGNED,tip_cab_line VARCHAR(45),svt VARCHAR(45),net_port_svt VARCHAR(45),phone VARCHAR(45),svt_memo TEXT,commutator INTEGER UNSIGNED,net_port_commutator VARCHAR(45),commutator_memo TEXT,pref VARCHAR(45),sid INTEGER UNSIGNED"

                DB7.Execute(sSQL)

            Case "PostgreSQL"

                sSQL = "CREATE TABLE tbl_net_mag(id serial NOT NULL,id_line varchar(255) ,tip_cab varchar(255) ,dlin_cab integer DEFAULT 0,tip_cab_line varchar(255) ,svt integer DEFAULT 0,net_port_svt varchar(255) ,phone varchar(255) ,svt_memo TEXT ,commutator integer DEFAULT 0,net_port_commutator varchar(255) ,commutator_memo TEXT ,pref varchar(255) ,sid integer DEFAULT 0)"

                DB7.Execute(sSQL)

            Case "SQLLite"


            Case "DSN"

                sSQL = "CREATE TABLE tbl_net_mag(id int NOT NULL,id_line varchar(255) ,tip_cab varchar(255) ,dlin_cab integer DEFAULT 0,tip_cab_line varchar(255) ,svt integer DEFAULT 0,net_port_svt varchar(255) ,phone varchar(255) ,svt_memo TEXT ,commutator integer DEFAULT 0,net_port_commutator varchar(255) ,commutator_memo TEXT ,pref varchar(255) ,sid integer DEFAULT 0)"

                DB7.Execute(sSQL)

        End Select

        Call ALTER_DB_172()

        Exit Sub
err_:
        MsgBox(Err.Description)

        _DBALTER = True

    End Sub

    Public Sub ALTER_DB_171()

        On Error GoTo err_

        If _DBALTER = False Then Exit Sub

        Dim sSQL As String

        Select Case DB_N

            Case "MS SQL 2008"

                sSQL = "ALTER TABLE " & DBtabl & ".dbo.Remont ADD startdate datetime, starttime datetime, stopdate datetime, stoptime datetime"

                DB7.Execute(sSQL)

                sSQL = "CREATE TABLE dbo.SPR_USER(id int NOT NULL IDENTITY (1, 1), Name nvarchar(50) ,Proizv int,Prim varchar(255) ,A nvarchar(50) ,B nvarchar(50) ,C nvarchar(50))"

                DB7.Execute(sSQL)


            Case "MS SQL"

                sSQL = "ALTER TABLE " & DBtabl & ".dbo.Remont ADD startdate datetime, starttime datetime, stopdate datetime, stoptime datetime"
                DB7.Execute(sSQL)

                sSQL = "CREATE TABLE dbo.SPR_USER(id int NOT NULL IDENTITY (1, 1), Name nvarchar(50) ,Proizv int,Prim varchar(255) , A nvarchar(50) ,B nvarchar(50) ,C nvarchar(50))"

                DB7.Execute(sSQL)

            Case "MS Access"
                Call frmMain.COMPARE_DB()


                sSQL = "alter table Remont ADD startdate Date, starttime Date, stopdate Date, stoptime Date"
                DB7.Execute(sSQL)

                sSQL = "CREATE TABLE SPR_USER(id counter, Name TEXT(50), Proizv int, Prim MEMO,  A TEXT(50),  B TEXT(50),  C TEXT(50))"
                DB7.Execute(sSQL)

            Case "MS Access 2007"
                Call frmMain.COMPARE_DB()


                sSQL = "alter table Remont ADD startdate Date, starttime Date, stopdate Date, stoptime Date"
                DB7.Execute(sSQL)

                sSQL = "CREATE TABLE SPR_USER(id counter, Name TEXT(50), Proizv int, Prim MEMO,  A TEXT(50),  B TEXT(50),  C TEXT(50))"
                DB7.Execute(sSQL)

            Case "MySQL"

                sSQL = "alter table Remont ADD startdate datetime, starttime datetime, stopdate datetime, stoptime datetime"

                DB7.Execute(sSQL)

                sSQL = "CREATE TABLE SPR_USER(id integer NOT NULL AUTO_INCREMENT, Name varchar(50) , Proizv integer, Prim TEXT ,  A varchar(50) ,  B varchar(50) , C varchar(50))"

                DB7.Execute(sSQL)

            Case "MySQL (MyODBC 5.1)"

                sSQL = "CREATE TABLE SPR_USER(id integer NOT NULL AUTO_INCREMENT, Name varchar(50) , Proizv integer, Prim TEXT ,  A varchar(50) ,  B varchar(50) , C varchar(50))"

                DB7.Execute(sSQL)

                sSQL = "CREATE TABLE SPR_USER(id int(11) NOT NULL AUTO_INCREMENT, Name varchar(50) , Proizv int, Prim TEXT ,  A varchar(50) ,  B varchar(50) ,  C varchar(50))"

                DB7.Execute(sSQL)


            Case "PostgreSQL"

                sSQL = "alter table Remont ADD startdate Date, starttime Date, stopdate Date, stoptime Date"

                DB7.Execute(sSQL)

                sSQL = "CREATE TABLE SPR_USER(id serial NOT NULL,Proizv integer,Name varchar(255) ,Prim varchar(255) ,A varchar(50) ,  B varchar(50) ,  C varchar(50))"

                DB7.Execute(sSQL)

            Case "SQLLite"


            Case "DSN"

                sSQL = "alter table Remont ADD startdate Date, starttime Date, stopdate Date, stoptime Date"

                DB7.Execute(sSQL)

                sSQL = "CREATE TABLE SPR_USER(id serial NOT NULL,Proizv integer,Name varchar(255) ,Prim varchar(255) ,A varchar(50) ,  B varchar(50) ,  C varchar(50))"

                DB7.Execute(sSQL)

        End Select


        Call ALTER_DB_1711()

        _DBALTER = False


        Exit Sub
err_:
        MsgBox(Err.Description)

        _DBALTER = True

    End Sub

    Public Sub ALTER_DB_17()

        On Error GoTo err_

        If _DBALTER = False Then Exit Sub

        Dim sSQL As String

        Select Case DB_N

            Case "MS SQL 2008"

                sSQL = "ALTER TABLE " & DBtabl & ".dbo.kompy ADD SVGA2_NAME nvarchar(255) , SVGA2_OB_RAM nvarchar(50) , SVGA2_SN nvarchar(50) , SVGA2_PROIZV nvarchar(50) default NULL"

                DB7.Execute(sSQL)

            Case "MS SQL"

                sSQL = "ALTER TABLE " & DBtabl & ".dbo.kompy ADD SVGA2_NAME nvarchar(255) , SVGA2_OB_RAM nvarchar(50) , SVGA2_SN nvarchar(50) , SVGA2_PROIZV nvarchar(50) default NULL"

                DB7.Execute(sSQL)

            Case "MS Access"
                Call frmMain.COMPARE_DB()


                sSQL = "alter table kompy ADD SVGA2_NAME TEXT(50) , SVGA2_OB_RAM TEXT(50) , SVGA2_SN TEXT(50) , SVGA2_PROIZV TEXT(50) default NULL"

                DB7.Execute(sSQL)

            Case "MS Access 2007"
                Call frmMain.COMPARE_DB()


                sSQL = "alter table kompy ADD SVGA2_NAME TEXT(50) , SVGA2_OB_RAM TEXT(50) , SVGA2_SN TEXT(50) , SVGA2_PROIZV TEXT(50) default NULL"

                DB7.Execute(sSQL)

            Case "MySQL"

                sSQL = "alter table kompy ADD COLUMN SVGA2_NAME varchar(255) , SVGA2_OB_RAM varchar(50) , SVGA2_SN varchar(50) , SVGA2_PROIZV varchar(50)"

                DB7.Execute(sSQL)


            Case "MySQL (MyODBC 5.1)"

                sSQL = "alter table kompy ADD COLUMN SVGA2_NAME varchar(255) , SVGA2_OB_RAM varchar(50) , SVGA2_SN varchar(50) , SVGA2_PROIZV varchar(50)"

                DB7.Execute(sSQL)


            Case "PostgreSQL"

                sSQL = "alter table kompy ADD COLUMN SVGA2_NAME varchar(255) , ADD COLUMN  SVGA2_OB_RAM varchar(255) , ADD COLUMN  SVGA2_SN varchar(255) , ADD COLUMN  SVGA2_PROIZV varchar(255) default NULL"

                DB7.Execute(sSQL)

            Case "SQLLite"


            Case "DSN"

                sSQL = "alter table kompy ADD COLUMN SVGA2_NAME varchar(255) , ADD COLUMN  SVGA2_OB_RAM varchar(255) , ADD COLUMN  SVGA2_SN varchar(255) , ADD COLUMN  SVGA2_PROIZV varchar(255) default NULL"

                DB7.Execute(sSQL)

        End Select

        DB7.Execute("UPDATE kompy SET SVGA2_NAME ='', SVGA2_OB_RAM ='', SVGA2_SN ='', SVGA2_PROIZV =''")

        Call ALTER_DB_171()


        Exit Sub
err_:
        MsgBox(Err.Description)

        _DBALTER = True

    End Sub

    Public Sub ALTER_DB_1738()

        On Error GoTo err_

        If _DBALTER = False Then Exit Sub

        Dim sSQL As String

        Select Case DB_N

            Case "MS SQL 2008"

                sSQL = "ALTER TABLE " & DBtabl & ".dbo.kompy ADD MB_NAME varchar(255)"

                DB7.Execute(sSQL)

                sSQL = "UPDATE " & DBtabl & ".dbo.kompy SET MB_NAME=Mb"

                DB7.Execute(sSQL)

                sSQL = "ALTER TABLE " & DBtabl & ".dbo.kompy DROP Mb, nomerPC, TEXT_RED, EXCELL_RED, ACCESS_RED, VG, IG"

                DB7.Execute(sSQL)

            Case "MS SQL"

                sSQL = "ALTER TABLE " & DBtabl & ".dbo.kompy ADD MB_NAME varchar(255)"

                DB7.Execute(sSQL)

                sSQL = "UPDATE " & DBtabl & ".dbo.kompy SET MB_NAME=Mb"

                DB7.Execute(sSQL)

                sSQL = "ALTER TABLE " & DBtabl & ".dbo.kompy DROP Mb, nomerPC, TEXT_RED, EXCELL_RED, ACCESS_RED, VG, IG"

                DB7.Execute(sSQL)

            Case "MS Access"

                Call frmMain.COMPARE_DB()

                sSQL = "ALTER TABLE kompy ADD COLUMN MB_NAME Memo"

                DB7.Execute(sSQL)

                sSQL = "UPDATE kompy SET MB_NAME=Mb"

                DB7.Execute(sSQL)

                sSQL = "ALTER TABLE kompy DROP COLUMN Mb, nomerPC, TEXT_RED, EXCELL_RED, ACCESS_RED, VG, IG"

                DB7.Execute(sSQL)

                Call frmMain.COMPARE_DB()

            Case "MS Access 2007"

                Call frmMain.COMPARE_DB()

                sSQL = "ALTER TABLE kompy ADD COLUMN MB_NAME Memo"

                DB7.Execute(sSQL)

                sSQL = "UPDATE kompy SET MB_NAME=Mb"

                DB7.Execute(sSQL)

                sSQL = "ALTER TABLE kompy DROP COLUMN Mb, nomerPC, TEXT_RED, EXCELL_RED, ACCESS_RED, VG, IG"

                DB7.Execute(sSQL)

                Call frmMain.COMPARE_DB()

            Case "MySQL"

                sSQL = "ALTER TABLE kompy ADD COLUMN MB_NAME TEXT"

                DB7.Execute(sSQL)

                sSQL = "UPDATE kompy SET MB_NAME=Mb"

                DB7.Execute(sSQL)

                sSQL = "ALTER TABLE kompy DROP COLUMN Mb,DROP COLUMN nomerPC,DROP COLUMN TEXT_RED,DROP COLUMN EXCELL_RED,DROP COLUMN ACCESS_RED,DROP COLUMN VG,DROP COLUMN IG"

                DB7.Execute(sSQL)

            Case "MySQL (MyODBC 5.1)"

                sSQL = "ALTER TABLE kompy ADD COLUMN MB_NAME TEXT"

                DB7.Execute(sSQL)

                sSQL = "UPDATE kompy SET MB_NAME=Mb"

                DB7.Execute(sSQL)

                sSQL = "ALTER TABLE kompy DROP COLUMN Mb,DROP COLUMN nomerPC,DROP COLUMN TEXT_RED,DROP COLUMN EXCELL_RED,DROP COLUMN ACCESS_RED,DROP COLUMN VG,DROP COLUMN IG"

                DB7.Execute(sSQL)

            Case "PostgreSQL"

                sSQL = "ALTER TABLE kompy ADD COLUMN MB_NAME varchar(255)"

                DB7.Execute(sSQL)

                sSQL = "UPDATE kompy SET MB_NAME=Mb"

                DB7.Execute(sSQL)

                sSQL = "ALTER TABLE kompy DROP COLUMN Mb, nomerPC, TEXT_RED, EXCELL_RED, ACCESS_RED, VG, IG"

                DB7.Execute(sSQL)

            Case "SQLLite"

            Case "DSN"

                sSQL = "ALTER TABLE kompy ADD COLUMN MB_NAME varchar(255)"

                DB7.Execute(sSQL)

                sSQL = "UPDATE kompy SET MB_NAME=Mb"

                DB7.Execute(sSQL)

                sSQL = "ALTER TABLE kompy DROP COLUMN Mb, nomerPC, TEXT_RED, EXCELL_RED, ACCESS_RED, VG, IG"

                DB7.Execute(sSQL)

        End Select


        Call ALTER_DB_1739()
        '####################################################################
        '####################################################################
        '####################################################################

        Exit Sub
err_:
        MsgBox(Err.Description)

        _DBALTER = True
    End Sub

    Public Sub ALTER_DB_1739()

        On Error GoTo err_

        If _DBALTER = False Then Exit Sub

        Dim sSQL As String

        sSQL = "ALTER TABLE kompy ADD data_sp Date, D_T_nb Date"

        Select Case DB_N

            Case "MS SQL 2008"

                sSQL = "ALTER TABLE " & DBtabl & ".dbo.kompy ADD data_sp datetime, D_T_nb datetime"

                DB7.Execute(sSQL)

            Case "MS SQL"

                sSQL = "ALTER TABLE " & DBtabl & ".dbo.kompy ADD data_sp datetime, D_T_nb datetime"
                DB7.Execute(sSQL)

            Case "MS Access"

                Call frmMain.COMPARE_DB()

                DB7.Execute(sSQL)

            Case "MS Access 2007"

                Call frmMain.COMPARE_DB()

                DB7.Execute(sSQL)

            Case "MySQL"

                sSQL = "ALTER TABLE kompy ADD COLUMN data_sp datetime, D_T_nb datetime"

                DB7.Execute(sSQL)


            Case "MySQL (MyODBC 5.1)"

                sSQL = "ALTER TABLE kompy ADD COLUMN data_sp datetime, D_T_nb datetime"

                DB7.Execute(sSQL)


            Case "PostgreSQL"

                sSQL = "ALTER TABLE kompy ADD COLUMN data_sp Date,ADD COLUMN data_nb Date"

                DB7.Execute(sSQL)

            Case "SQLLite"

            Case "DSN"

                sSQL = "ALTER TABLE kompy ADD COLUMN data_sp Date,ADD COLUMN data_nb Date"

                DB7.Execute(sSQL)

        End Select

        Call ALTER_DB_1751()

        Exit Sub
err_:
        MsgBox(Err.Description)

        _DBALTER = True
    End Sub

    Public Sub ALTER_DB_1751()

        On Error GoTo err_

        If _DBALTER = False Then Exit Sub

        Dim sSQL As String


        Select Case DB_N

            Case "MS SQL 2008"

                sSQL = "ALTER TABLE " & DBtabl & ".dbo.CARTRIDG ADD D_T datetime"
                DB7.Execute(sSQL)
                sSQL = "UPDATE " & DBtabl & ".dbo.CARTRIDG SET D_T=DATA"
                DB7.Execute(sSQL)
                sSQL = "ALTER TABLE " & DBtabl & ".dbo.CARTRIDG DROP column  DATA"
                DB7.Execute(sSQL)
                '##########################################################################
                sSQL = "ALTER TABLE " & DBtabl & ".dbo.CARTRIDG_D ADD D_T datetime"
                DB7.Execute(sSQL)
                sSQL = "UPDATE " & DBtabl & ".dbo.CARTRIDG_D SET D_T=DATA"
                DB7.Execute(sSQL)
                sSQL = "ALTER TABLE " & DBtabl & ".dbo.CARTRIDG_D DROP column  DATA"
                DB7.Execute(sSQL)

                sSQL = "ALTER TABLE " & DBtabl & ".dbo.CARTRIDG_D ADD T_M datetime"
                DB7.Execute(sSQL)
                sSQL = "UPDATE " & DBtabl & ".dbo.CARTRIDG_D SET T_M=time"
                DB7.Execute(sSQL)
                sSQL = "ALTER TABLE " & DBtabl & ".dbo.CARTRIDG_D DROP column  time"
                DB7.Execute(sSQL)
                '##########################################################################
                sSQL = "ALTER TABLE " & DBtabl & ".dbo.dvig ADD D_T datetime"
                DB7.Execute(sSQL)
                sSQL = "UPDATE " & DBtabl & ".dbo.dvig SET D_T=DATA"
                DB7.Execute(sSQL)
                sSQL = "ALTER TABLE " & DBtabl & ".dbo.dvig DROP column  DATA"
                DB7.Execute(sSQL)

                sSQL = "ALTER TABLE " & DBtabl & ".dbo.dvig ADD T_M datetime"
                DB7.Execute(sSQL)
                sSQL = "UPDATE " & DBtabl & ".dbo.dvig SET T_M=time"
                DB7.Execute(sSQL)
                sSQL = "ALTER TABLE " & DBtabl & ".dbo.dvig DROP column  time"
                DB7.Execute(sSQL)
                '##########################################################################
                sSQL = "ALTER TABLE " & DBtabl & ".dbo.kompy ADD D_T datetime"
                DB7.Execute(sSQL)
                sSQL = "UPDATE " & DBtabl & ".dbo.kompy SET D_T=DATe"
                DB7.Execute(sSQL)
                sSQL = "ALTER TABLE " & DBtabl & ".dbo.kompy DROP column  [date]"
                DB7.Execute(sSQL)
                '##########################################################################
                sSQL = "ALTER TABLE " & DBtabl & ".dbo.Remont ADD D_T datetime"
                DB7.Execute(sSQL)
                sSQL = "UPDATE " & DBtabl & ".dbo.Remont SET D_T=DATe"
                DB7.Execute(sSQL)
                sSQL = "ALTER TABLE " & DBtabl & ".dbo.Remont DROP column  [date]"
                DB7.Execute(sSQL)

                sSQL = "ALTER TABLE " & DBtabl & ".dbo.Remont ADD PAMIATKA ntext"
                DB7.Execute(sSQL)
                sSQL = "UPDATE " & DBtabl & ".dbo.Remont SET PAMIATKA=MeMo"
                DB7.Execute(sSQL)
                sSQL = "ALTER TABLE " & DBtabl & ".dbo.Remont DROP column  [MeMo]"
                DB7.Execute(sSQL)

                sSQL = "ALTER TABLE " & DBtabl & ".dbo.Remont ADD CUMMA money"
                DB7.Execute(sSQL)
                sSQL = "UPDATE " & DBtabl & ".dbo.Remont SET CUMMA=Summ"
                DB7.Execute(sSQL)
                sSQL = "ALTER TABLE " & DBtabl & ".dbo.Remont DROP column  [Summ]"
                DB7.Execute(sSQL)

                sSQL = "ALTER TABLE " & DBtabl & ".dbo.Remont ADD User_Name nvarchar(255)"
                DB7.Execute(sSQL)
                sSQL = "UPDATE " & DBtabl & ".dbo.Remont SET User_Name=UserName"
                DB7.Execute(sSQL)
                sSQL = "ALTER TABLE " & DBtabl & ".dbo.Remont DROP column  [UserName]"
                DB7.Execute(sSQL)

                '##########################################################################
                sSQL = "ALTER TABLE " & DBtabl & ".dbo.remonty_plus ADD D_T datetime"
                DB7.Execute(sSQL)
                sSQL = "UPDATE " & DBtabl & ".dbo.remonty_plus SET D_T=DATA"
                DB7.Execute(sSQL)
                sSQL = "ALTER TABLE " & DBtabl & ".dbo.remonty_plus DROP column  data"
                DB7.Execute(sSQL)
                '##########################################################################
                sSQL = "ALTER TABLE " & DBtabl & ".dbo.Sheduler ADD D_T datetime"
                DB7.Execute(sSQL)
                sSQL = "UPDATE " & DBtabl & ".dbo.Sheduler SET D_T=DATA"
                DB7.Execute(sSQL)
                sSQL = "ALTER TABLE " & DBtabl & ".dbo.Sheduler DROP column  DATA"
                DB7.Execute(sSQL)
                '##########################################################################
                sSQL = "ALTER TABLE " & DBtabl & ".dbo.T_Log ADD D_T datetime"
                DB7.Execute(sSQL)
                sSQL = "UPDATE " & DBtabl & ".dbo.T_Log SET D_T=DATe"
                DB7.Execute(sSQL)
                sSQL = "ALTER TABLE " & DBtabl & ".dbo.T_Log DROP column  [date]"
                DB7.Execute(sSQL)

                sSQL = "ALTER TABLE " & DBtabl & ".dbo.T_Log ADD T_M datetime"
                DB7.Execute(sSQL)
                sSQL = "UPDATE " & DBtabl & ".dbo.T_Log SET T_M=time"
                DB7.Execute(sSQL)
                sSQL = "ALTER TABLE " & DBtabl & ".dbo.T_Log DROP column  Time"
                DB7.Execute(sSQL)
                '##########################################################################
                sSQL = "ALTER TABLE " & DBtabl & ".dbo.Update_Log ADD D_T datetime"
                DB7.Execute(sSQL)
                sSQL = "UPDATE " & DBtabl & ".dbo.Update_Log SET D_T=DATe"
                DB7.Execute(sSQL)
                sSQL = "ALTER TABLE " & DBtabl & ".dbo.Update_Log DROP column  [date]"
                DB7.Execute(sSQL)
                sSQL = "ALTER TABLE " & DBtabl & ".dbo.Update_Log ADD T_M datetime"
                DB7.Execute(sSQL)
                sSQL = "UPDATE " & DBtabl & ".dbo.Update_Log SET T_M=time"
                DB7.Execute(sSQL)
                sSQL = "ALTER TABLE " & DBtabl & ".dbo.Update_Log DROP column  Time"
                DB7.Execute(sSQL)
                '##########################################################################
                sSQL = "ALTER TABLE " & DBtabl & ".dbo.ZAM_OTD ADD D_T datetime"
                DB7.Execute(sSQL)
                sSQL = "UPDATE " & DBtabl & ".dbo.ZAM_OTD SET D_T=DATe"
                DB7.Execute(sSQL)
                sSQL = "ALTER TABLE " & DBtabl & ".dbo.ZAM_OTD DROP column  [date]"
                DB7.Execute(sSQL)
                '##########################################################################
                sSQL = "ALTER TABLE " & DBtabl & ".dbo.Zametki ADD D_T datetime"
                DB7.Execute(sSQL)
                sSQL = "UPDATE " & DBtabl & ".dbo.Zametki SET D_T=DATe"
                DB7.Execute(sSQL)
                sSQL = "ALTER TABLE " & DBtabl & ".dbo.Zametki DROP column [date]"
                DB7.Execute(sSQL)
                '##########################################################################
                sSQL = "ALTER TABLE " & DBtabl & ".dbo.Garantia_sis ADD DEN  varchar(50)"
                DB7.Execute(sSQL)
                sSQL = "UPDATE " & DBtabl & ".dbo.Garantia_sis SET DEN=Day"
                DB7.Execute(sSQL)
                sSQL = "ALTER TABLE " & DBtabl & ".dbo.Garantia_sis DROP column  Day"
                DB7.Execute(sSQL)

                sSQL = "ALTER TABLE " & DBtabl & ".dbo.Garantia_sis ADD Mesiac  varchar(50)"
                DB7.Execute(sSQL)
                sSQL = "UPDATE " & DBtabl & ".dbo.Garantia_sis SET Mesiac=Month"
                DB7.Execute(sSQL)
                sSQL = "ALTER TABLE " & DBtabl & ".dbo.Garantia_sis DROP column  Month"
                DB7.Execute(sSQL)

                sSQL = "ALTER TABLE " & DBtabl & ".dbo.Garantia_sis ADD GOD  varchar(50)"
                DB7.Execute(sSQL)
                sSQL = "UPDATE " & DBtabl & ".dbo.Garantia_sis SET GOD=Year"
                DB7.Execute(sSQL)
                sSQL = "ALTER TABLE " & DBtabl & ".dbo.Garantia_sis DROP column  Year"
                DB7.Execute(sSQL)
            Case "MS SQL"

                sSQL = "ALTER TABLE " & DBtabl & ".dbo.CARTRIDG ADD D_T datetime"
                DB7.Execute(sSQL)
                sSQL = "UPDATE " & DBtabl & ".dbo.CARTRIDG SET D_T=DATA"
                DB7.Execute(sSQL)
                sSQL = "ALTER TABLE " & DBtabl & ".dbo.CARTRIDG DROP column  DATA"
                DB7.Execute(sSQL)
                '##########################################################################
                sSQL = "ALTER TABLE " & DBtabl & ".dbo.CARTRIDG_D ADD D_T datetime"
                DB7.Execute(sSQL)
                sSQL = "UPDATE " & DBtabl & ".dbo.CARTRIDG_D SET D_T=DATA"
                DB7.Execute(sSQL)
                sSQL = "ALTER TABLE " & DBtabl & ".dbo.CARTRIDG_D DROP column  DATA"
                DB7.Execute(sSQL)

                sSQL = "ALTER TABLE " & DBtabl & ".dbo.CARTRIDG_D ADD T_M datetime"
                DB7.Execute(sSQL)
                sSQL = "UPDATE " & DBtabl & ".dbo.CARTRIDG_D SET T_M=time"
                DB7.Execute(sSQL)
                sSQL = "ALTER TABLE " & DBtabl & ".dbo.CARTRIDG_D DROP column  time"
                DB7.Execute(sSQL)
                '##########################################################################
                sSQL = "ALTER TABLE " & DBtabl & ".dbo.dvig ADD D_T datetime"
                DB7.Execute(sSQL)
                sSQL = "UPDATE " & DBtabl & ".dbo.dvig SET D_T=DATA"
                DB7.Execute(sSQL)
                sSQL = "ALTER TABLE " & DBtabl & ".dbo.dvig DROP column  DATA"
                DB7.Execute(sSQL)

                sSQL = "ALTER TABLE " & DBtabl & ".dbo.dvig ADD T_M datetime"
                DB7.Execute(sSQL)
                sSQL = "UPDATE " & DBtabl & ".dbo.dvig SET T_M=time"
                DB7.Execute(sSQL)
                sSQL = "ALTER TABLE " & DBtabl & ".dbo.dvig DROP column  time"
                DB7.Execute(sSQL)
                '##########################################################################
                sSQL = "ALTER TABLE " & DBtabl & ".dbo.kompy ADD D_T datetime"
                DB7.Execute(sSQL)
                sSQL = "UPDATE " & DBtabl & ".dbo.kompy SET D_T=DATe"
                DB7.Execute(sSQL)
                sSQL = "ALTER TABLE " & DBtabl & ".dbo.kompy DROP column  [date]"
                DB7.Execute(sSQL)
                '##########################################################################
                sSQL = "ALTER TABLE " & DBtabl & ".dbo.Remont ADD D_T datetime"
                DB7.Execute(sSQL)
                sSQL = "UPDATE " & DBtabl & ".dbo.Remont SET D_T=DATe"
                DB7.Execute(sSQL)
                sSQL = "ALTER TABLE " & DBtabl & ".dbo.Remont DROP column  [date]"
                DB7.Execute(sSQL)

                sSQL = "ALTER TABLE " & DBtabl & ".dbo.Remont ADD PAMIATKA ntext"
                DB7.Execute(sSQL)
                sSQL = "UPDATE " & DBtabl & ".dbo.Remont SET PAMIATKA=MeMo"
                DB7.Execute(sSQL)
                sSQL = "ALTER TABLE " & DBtabl & ".dbo.Remont DROP column  [MeMo]"
                DB7.Execute(sSQL)

                sSQL = "ALTER TABLE " & DBtabl & ".dbo.Remont ADD CUMMA money"
                DB7.Execute(sSQL)
                sSQL = "UPDATE " & DBtabl & ".dbo.Remont SET CUMMA=Summ"
                DB7.Execute(sSQL)
                sSQL = "ALTER TABLE " & DBtabl & ".dbo.Remont DROP column  [Summ]"
                DB7.Execute(sSQL)

                sSQL = "ALTER TABLE " & DBtabl & ".dbo.Remont ADD User_Name nvarchar(255)"
                DB7.Execute(sSQL)
                sSQL = "UPDATE " & DBtabl & ".dbo.Remont SET User_Name=UserName"
                DB7.Execute(sSQL)
                sSQL = "ALTER TABLE " & DBtabl & ".dbo.Remont DROP column  [UserName]"
                '##########################################################################
                sSQL = "ALTER TABLE " & DBtabl & ".dbo.remonty_plus ADD D_T datetime"
                DB7.Execute(sSQL)
                sSQL = "UPDATE " & DBtabl & ".dbo.remonty_plus SET D_T=DATA"
                DB7.Execute(sSQL)
                sSQL = "ALTER TABLE " & DBtabl & ".dbo.remonty_plus DROP column  data"
                DB7.Execute(sSQL)
                '##########################################################################
                sSQL = "ALTER TABLE " & DBtabl & ".dbo.Sheduler ADD D_T datetime"
                DB7.Execute(sSQL)
                sSQL = "UPDATE " & DBtabl & ".dbo.Sheduler SET D_T=DATA"
                DB7.Execute(sSQL)
                sSQL = "ALTER TABLE " & DBtabl & ".dbo.Sheduler DROP column  DATA"
                DB7.Execute(sSQL)
                '##########################################################################
                sSQL = "ALTER TABLE " & DBtabl & ".dbo.T_Log ADD D_T datetime"
                DB7.Execute(sSQL)
                sSQL = "UPDATE " & DBtabl & ".dbo.T_Log SET D_T=DATe"
                DB7.Execute(sSQL)
                sSQL = "ALTER TABLE " & DBtabl & ".dbo.T_Log DROP column  [date]"
                DB7.Execute(sSQL)

                sSQL = "ALTER TABLE " & DBtabl & ".dbo.T_Log ADD T_M datetime"
                DB7.Execute(sSQL)
                sSQL = "UPDATE " & DBtabl & ".dbo.T_Log SET T_M=time"
                DB7.Execute(sSQL)
                sSQL = "ALTER TABLE " & DBtabl & ".dbo.T_Log DROP column  Time"
                DB7.Execute(sSQL)
                '##########################################################################
                sSQL = "ALTER TABLE " & DBtabl & ".dbo.Update_Log ADD D_T datetime"
                DB7.Execute(sSQL)
                sSQL = "UPDATE " & DBtabl & ".dbo.Update_Log SET D_T=DATe"
                DB7.Execute(sSQL)
                sSQL = "ALTER TABLE " & DBtabl & ".dbo.Update_Log DROP column  [date]"
                DB7.Execute(sSQL)
                sSQL = "ALTER TABLE " & DBtabl & ".dbo.Update_Log ADD T_M datetime"
                DB7.Execute(sSQL)
                sSQL = "UPDATE " & DBtabl & ".dbo.Update_Log SET T_M=time"
                DB7.Execute(sSQL)
                sSQL = "ALTER TABLE " & DBtabl & ".dbo.Update_Log DROP column  Time"
                DB7.Execute(sSQL)
                '##########################################################################
                sSQL = "ALTER TABLE " & DBtabl & ".dbo.ZAM_OTD ADD D_T datetime"
                DB7.Execute(sSQL)
                sSQL = "UPDATE " & DBtabl & ".dbo.ZAM_OTD SET D_T=DATe"
                DB7.Execute(sSQL)
                sSQL = "ALTER TABLE " & DBtabl & ".dbo.ZAM_OTD DROP column  [date]"
                DB7.Execute(sSQL)
                '##########################################################################
                sSQL = "ALTER TABLE " & DBtabl & ".dbo.Zametki ADD D_T datetime"
                DB7.Execute(sSQL)
                sSQL = "UPDATE " & DBtabl & ".dbo.Zametki SET D_T=DATe"
                DB7.Execute(sSQL)
                sSQL = "ALTER TABLE " & DBtabl & ".dbo.Zametki DROP column  [date]"
                DB7.Execute(sSQL)
                '##########################################################################
                sSQL = "ALTER TABLE " & DBtabl & ".dbo.Garantia_sis ADD DEN varchar(50)"
                DB7.Execute(sSQL)
                sSQL = "UPDATE " & DBtabl & ".dbo.Garantia_sis SET DEN=Day"
                DB7.Execute(sSQL)
                sSQL = "ALTER TABLE " & DBtabl & ".dbo.Garantia_sis DROP column  Day"
                DB7.Execute(sSQL)

                sSQL = "ALTER TABLE " & DBtabl & ".dbo.Garantia_sis ADD Mesiac varchar(50)"
                DB7.Execute(sSQL)
                sSQL = "UPDATE " & DBtabl & ".dbo.Garantia_sis SET Mesiac=Month"
                DB7.Execute(sSQL)
                sSQL = "ALTER TABLE " & DBtabl & ".dbo.Garantia_sis DROP column  Month"
                DB7.Execute(sSQL)

                sSQL = "ALTER TABLE " & DBtabl & ".dbo.Garantia_sis ADD GOD  varchar(50)"
                DB7.Execute(sSQL)
                sSQL = "UPDATE " & DBtabl & ".dbo.Garantia_sis SET GOD=Year"
                DB7.Execute(sSQL)
                sSQL = "ALTER TABLE " & DBtabl & ".dbo.Garantia_sis DROP column  Year"
                DB7.Execute(sSQL)
                '##########################################################################
            Case "MS Access"

                Call frmMain.COMPARE_DB()

                sSQL = "ALTER TABLE CARTRIDG ADD D_T datetime"
                DB7.Execute(sSQL)
                sSQL = "UPDATE CARTRIDG SET D_T=DATA"
                DB7.Execute(sSQL)
                sSQL = "ALTER TABLE CARTRIDG DROP column  DATA"
                DB7.Execute(sSQL)
                '##########################################################################
                sSQL = "ALTER TABLE CARTRIDG_D ADD D_T datetime"
                DB7.Execute(sSQL)
                sSQL = "UPDATE CARTRIDG_D SET D_T=DATA"
                DB7.Execute(sSQL)
                sSQL = "ALTER TABLE CARTRIDG_D DROP column  DATA"
                DB7.Execute(sSQL)

                sSQL = "ALTER TABLE CARTRIDG_D ADD T_M datetime"
                DB7.Execute(sSQL)
                sSQL = "UPDATE CARTRIDG_D SET T_M=time"
                DB7.Execute(sSQL)
                sSQL = "ALTER TABLE CARTRIDG_D DROP column [time]"
                DB7.Execute(sSQL)
                '##########################################################################
                sSQL = "ALTER TABLE dvig ADD D_T datetime"
                DB7.Execute(sSQL)
                sSQL = "UPDATE dvig SET D_T=DATA"
                DB7.Execute(sSQL)
                sSQL = "ALTER TABLE dvig DROP column  DATA"
                DB7.Execute(sSQL)

                sSQL = "ALTER TABLE dvig ADD T_M datetime"
                DB7.Execute(sSQL)
                sSQL = "UPDATE dvig SET T_M=time"
                DB7.Execute(sSQL)
                sSQL = "ALTER TABLE dvig DROP column [time]"
                DB7.Execute(sSQL)
                '##########################################################################
                sSQL = "ALTER TABLE kompy ADD D_T datetime"
                DB7.Execute(sSQL)
                sSQL = "UPDATE kompy SET D_T=date"
                DB7.Execute(sSQL)
                sSQL = "ALTER TABLE kompy DROP column [date]"
                DB7.Execute(sSQL)
                '##########################################################################
                sSQL = "ALTER TABLE Remont ADD D_T datetime"
                DB7.Execute(sSQL)
                sSQL = "UPDATE Remont SET D_T=DATe"
                DB7.Execute(sSQL)
                sSQL = "ALTER TABLE Remont DROP column  [date]"
                DB7.Execute(sSQL)

                sSQL = "ALTER TABLE Remont ADD PAMIATKA memo"
                DB7.Execute(sSQL)
                sSQL = "UPDATE Remont SET PAMIATKA=MeMo"
                DB7.Execute(sSQL)
                sSQL = "ALTER TABLE Remont DROP column  [MeMo]"
                DB7.Execute(sSQL)

                sSQL = "ALTER TABLE Remont ADD CUMMA money"
                DB7.Execute(sSQL)
                sSQL = "UPDATE Remont SET CUMMA=Summ"
                DB7.Execute(sSQL)
                sSQL = "ALTER TABLE Remont DROP column  [Summ]"
                DB7.Execute(sSQL)

                sSQL = "ALTER TABLE Remont ADD User_Name nvarchar(255)"
                DB7.Execute(sSQL)
                sSQL = "UPDATE Remont SET User_Name=UserName"
                DB7.Execute(sSQL)
                sSQL = "ALTER TABLE Remont DROP column  [UserName]"
                DB7.Execute(sSQL)
                '##########################################################################
                sSQL = "ALTER TABLE remonty_plus ADD D_T datetime"
                DB7.Execute(sSQL)
                sSQL = "UPDATE remonty_plus SET D_T=DATA"
                DB7.Execute(sSQL)
                sSQL = "ALTER TABLE remonty_plus DROP column  data"
                DB7.Execute(sSQL)
                '##########################################################################
                sSQL = "ALTER TABLE Sheduler ADD D_T datetime"
                DB7.Execute(sSQL)
                sSQL = "UPDATE Sheduler SET D_T=DATA"
                DB7.Execute(sSQL)
                sSQL = "ALTER TABLE Sheduler DROP column  DATA"
                DB7.Execute(sSQL)
                '##########################################################################
                sSQL = "ALTER TABLE T_Log ADD D_T datetime"
                DB7.Execute(sSQL)
                sSQL = "UPDATE T_Log SET D_T=DATe"
                DB7.Execute(sSQL)
                sSQL = "ALTER TABLE T_Log DROP column  [date]"
                DB7.Execute(sSQL)

                sSQL = "ALTER TABLE T_Log ADD T_M datetime"
                DB7.Execute(sSQL)
                sSQL = "UPDATE T_Log SET T_M=time"
                DB7.Execute(sSQL)
                sSQL = "ALTER TABLE T_Log DROP column  [Time]"
                DB7.Execute(sSQL)
                '##########################################################################
                sSQL = "ALTER TABLE Update_Log ADD D_T datetime"
                DB7.Execute(sSQL)
                sSQL = "UPDATE Update_Log SET D_T=DATe"
                DB7.Execute(sSQL)
                sSQL = "ALTER TABLE Update_Log DROP column  [date]"
                DB7.Execute(sSQL)
                sSQL = "ALTER TABLE Update_Log ADD T_M datetime"
                DB7.Execute(sSQL)
                sSQL = "UPDATE Update_Log SET T_M=time"
                DB7.Execute(sSQL)
                sSQL = "ALTER TABLE Update_Log DROP column  [Time]"
                DB7.Execute(sSQL)
                '##########################################################################
                sSQL = "ALTER TABLE ZAM_OTD ADD D_T datetime"
                DB7.Execute(sSQL)
                sSQL = "UPDATE ZAM_OTD SET D_T=DATe"
                DB7.Execute(sSQL)
                sSQL = "ALTER TABLE ZAM_OTD DROP column  [date]"
                DB7.Execute(sSQL)
                '##########################################################################
                sSQL = "ALTER TABLE Zametki ADD D_T datetime"
                DB7.Execute(sSQL)
                sSQL = "UPDATE Zametki SET D_T=DATe"
                DB7.Execute(sSQL)
                sSQL = "ALTER TABLE Zametki DROP column  [date]"
                DB7.Execute(sSQL)
                '##########################################################################
                sSQL = "ALTER TABLE Garantia_sis ADD DEN  text(50)"
                DB7.Execute(sSQL)
                sSQL = "UPDATE Garantia_sis SET DEN=Day"
                DB7.Execute(sSQL)
                sSQL = "ALTER TABLE Garantia_sis DROP column  [Day]"
                DB7.Execute(sSQL)

                sSQL = "ALTER TABLE Garantia_sis ADD Mesiac text(50)"
                DB7.Execute(sSQL)
                sSQL = "UPDATE Garantia_sis SET Mesiac=Month"
                DB7.Execute(sSQL)
                sSQL = "ALTER TABLE Garantia_sis DROP column  [Month]"
                DB7.Execute(sSQL)

                sSQL = "ALTER TABLE Garantia_sis ADD GOD text(50)"
                DB7.Execute(sSQL)
                sSQL = "UPDATE Garantia_sis SET GOD=Year"
                DB7.Execute(sSQL)
                sSQL = "ALTER TABLE Garantia_sis DROP column  [Year]"
                DB7.Execute(sSQL)
                '##########################################################################
            Case "MS Access 2007"

                Call frmMain.COMPARE_DB()

                sSQL = "ALTER TABLE CARTRIDG ADD D_T datetime"
                DB7.Execute(sSQL)
                sSQL = "UPDATE CARTRIDG SET D_T=DATA"
                DB7.Execute(sSQL)
                sSQL = "ALTER TABLE CARTRIDG DROP column  DATA"
                DB7.Execute(sSQL)
                '##########################################################################
                sSQL = "ALTER TABLE CARTRIDG_D ADD D_T datetime"
                DB7.Execute(sSQL)
                sSQL = "UPDATE CARTRIDG_D SET D_T=DATA"
                DB7.Execute(sSQL)
                sSQL = "ALTER TABLE CARTRIDG_D DROP column  DATA"
                DB7.Execute(sSQL)

                sSQL = "ALTER TABLE CARTRIDG_D ADD T_M datetime"
                DB7.Execute(sSQL)
                sSQL = "UPDATE CARTRIDG_D SET T_M=time"
                DB7.Execute(sSQL)
                sSQL = "ALTER TABLE CARTRIDG_D DROP column  [time]"
                DB7.Execute(sSQL)
                '##########################################################################
                sSQL = "ALTER TABLE dvig ADD D_T datetime"
                DB7.Execute(sSQL)
                sSQL = "UPDATE dvig SET D_T=DATA"
                DB7.Execute(sSQL)
                sSQL = "ALTER TABLE dvig DROP column  DATA"
                DB7.Execute(sSQL)

                sSQL = "ALTER TABLE dvig ADD T_M datetime"
                DB7.Execute(sSQL)
                sSQL = "UPDATE dvig SET T_M=time"
                DB7.Execute(sSQL)
                sSQL = "ALTER TABLE dvig DROP column  [time]"
                DB7.Execute(sSQL)
                '##########################################################################
                sSQL = "ALTER TABLE kompy ADD D_T datetime"
                DB7.Execute(sSQL)
                sSQL = "UPDATE kompy SET D_T=DATe"
                DB7.Execute(sSQL)
                sSQL = "ALTER TABLE kompy DROP column  [date]"
                DB7.Execute(sSQL)
                '##########################################################################
                sSQL = "ALTER TABLE Remont ADD D_T datetime"
                DB7.Execute(sSQL)
                sSQL = "UPDATE Remont SET D_T=DATe"
                DB7.Execute(sSQL)
                sSQL = "ALTER TABLE Remont DROP column  [date]"
                DB7.Execute(sSQL)

                sSQL = "ALTER TABLE Remont ADD PAMIATKA memo"
                DB7.Execute(sSQL)
                sSQL = "UPDATE Remont SET PAMIATKA=MeMo"
                DB7.Execute(sSQL)
                sSQL = "ALTER TABLE Remont DROP column  [MeMo]"
                DB7.Execute(sSQL)

                sSQL = "ALTER TABLE Remont ADD CUMMA money"
                DB7.Execute(sSQL)
                sSQL = "UPDATE Remont SET CUMMA=Summ"
                DB7.Execute(sSQL)
                sSQL = "ALTER TABLE Remont DROP column  [Summ]"
                DB7.Execute(sSQL)

                sSQL = "ALTER TABLE Remont ADD User_Name nvarchar(255)"
                DB7.Execute(sSQL)
                sSQL = "UPDATE Remont SET User_Name=UserName"
                DB7.Execute(sSQL)
                sSQL = "ALTER TABLE Remont DROP column  [UserName]"
                DB7.Execute(sSQL)
                '##########################################################################
                sSQL = "ALTER TABLE remonty_plus ADD D_T datetime"
                DB7.Execute(sSQL)
                sSQL = "UPDATE remonty_plus SET D_T=DATA"
                DB7.Execute(sSQL)
                sSQL = "ALTER TABLE remonty_plus DROP column  data"
                DB7.Execute(sSQL)
                '##########################################################################
                sSQL = "ALTER TABLE Sheduler ADD D_T datetime"
                DB7.Execute(sSQL)
                sSQL = "UPDATE Sheduler SET D_T=DATA"
                DB7.Execute(sSQL)
                sSQL = "ALTER TABLE Sheduler DROP column  DATA"
                DB7.Execute(sSQL)
                '##########################################################################
                sSQL = "ALTER TABLE T_Log ADD D_T datetime"
                DB7.Execute(sSQL)
                sSQL = "UPDATE T_Log SET D_T=DATe"
                DB7.Execute(sSQL)
                sSQL = "ALTER TABLE T_Log DROP column  [date]"
                DB7.Execute(sSQL)

                sSQL = "ALTER TABLE T_Log ADD T_M datetime"
                DB7.Execute(sSQL)
                sSQL = "UPDATE T_Log SET T_M=time"
                DB7.Execute(sSQL)
                sSQL = "ALTER TABLE T_Log DROP column  [Time]"
                DB7.Execute(sSQL)
                '##########################################################################
                sSQL = "ALTER TABLE Update_Log ADD D_T datetime"
                DB7.Execute(sSQL)
                sSQL = "UPDATE Update_Log SET D_T=DATe"
                DB7.Execute(sSQL)
                sSQL = "ALTER TABLE Update_Log DROP column  [date]"
                DB7.Execute(sSQL)
                sSQL = "ALTER TABLE Update_Log ADD T_M datetime"
                DB7.Execute(sSQL)
                sSQL = "UPDATE Update_Log SET T_M=time"
                DB7.Execute(sSQL)
                sSQL = "ALTER TABLE Update_Log DROP column [Time]"
                DB7.Execute(sSQL)
                '##########################################################################
                sSQL = "ALTER TABLE ZAM_OTD ADD D_T datetime"
                DB7.Execute(sSQL)
                sSQL = "UPDATE ZAM_OTD SET D_T=DATe"
                DB7.Execute(sSQL)
                sSQL = "ALTER TABLE ZAM_OTD DROP column  [date]"
                DB7.Execute(sSQL)
                '##########################################################################
                sSQL = "ALTER TABLE Zametki ADD D_T datetime"
                DB7.Execute(sSQL)
                sSQL = "UPDATE Zametki SET D_T=DATe"
                DB7.Execute(sSQL)
                sSQL = "ALTER TABLE Zametki DROP column  [date]"
                DB7.Execute(sSQL)
                '##########################################################################
                sSQL = "ALTER TABLE Garantia_sis ADD DEN text(50)"
                DB7.Execute(sSQL)
                sSQL = "UPDATE Garantia_sis SET DEN=Day"
                DB7.Execute(sSQL)
                sSQL = "ALTER TABLE Garantia_sis DROP column [Day]"
                DB7.Execute(sSQL)

                sSQL = "ALTER TABLE Garantia_sis ADD Mesiac text(50)"
                DB7.Execute(sSQL)
                sSQL = "UPDATE Garantia_sis SET Mesiac=Month"
                DB7.Execute(sSQL)
                sSQL = "ALTER TABLE Garantia_sis DROP column [Month]"
                DB7.Execute(sSQL)

                sSQL = "ALTER TABLE Garantia_sis ADD GOD text(50)"
                DB7.Execute(sSQL)
                sSQL = "UPDATE Garantia_sis SET GOD=Year"
                DB7.Execute(sSQL)
                sSQL = "ALTER TABLE Garantia_sis DROP column [Year]"
                DB7.Execute(sSQL)
                '##########################################################################
            Case "MySQL"
                sSQL = "ALTER TABLE CARTRIDG ADD D_T datetime"
                DB7.Execute(sSQL)
                sSQL = "UPDATE CARTRIDG SET D_T=DATA"
                DB7.Execute(sSQL)
                sSQL = "ALTER TABLE CARTRIDG DROP column  DATA"
                DB7.Execute(sSQL)
                '##########################################################################
                sSQL = "ALTER TABLE CARTRIDG_D ADD D_T datetime"
                DB7.Execute(sSQL)
                sSQL = "UPDATE CARTRIDG_D SET D_T=DATA"
                DB7.Execute(sSQL)
                sSQL = "ALTER TABLE CARTRIDG_D DROP column  DATA"
                DB7.Execute(sSQL)

                sSQL = "ALTER TABLE CARTRIDG_D ADD T_M VARCHAR(50)"
                DB7.Execute(sSQL)
                sSQL = "UPDATE CARTRIDG_D SET T_M=time"
                DB7.Execute(sSQL)
                sSQL = "ALTER TABLE CARTRIDG_D DROP column  time"
                DB7.Execute(sSQL)
                '##########################################################################
                sSQL = "ALTER TABLE dvig ADD D_T datetime"
                DB7.Execute(sSQL)
                sSQL = "UPDATE dvig SET D_T=DATA"
                DB7.Execute(sSQL)
                sSQL = "ALTER TABLE dvig DROP column  DATA"
                DB7.Execute(sSQL)

                sSQL = "ALTER TABLE dvig ADD T_M VARCHAR(50)"
                DB7.Execute(sSQL)
                sSQL = "UPDATE dvig SET T_M=time"
                DB7.Execute(sSQL)
                sSQL = "ALTER TABLE dvig DROP column  time"
                DB7.Execute(sSQL)
                '##########################################################################
                sSQL = "ALTER TABLE kompy ADD D_T datetime"
                DB7.Execute(sSQL)
                sSQL = "UPDATE kompy SET D_T=DATe"
                DB7.Execute(sSQL)
                sSQL = "ALTER TABLE kompy DROP column  date"
                DB7.Execute(sSQL)
                '##########################################################################
                sSQL = "ALTER TABLE Remont ADD D_T datetime"
                DB7.Execute(sSQL)
                sSQL = "UPDATE Remont SET D_T=DATe"
                DB7.Execute(sSQL)
                sSQL = "ALTER TABLE Remont DROP column  date"
                DB7.Execute(sSQL)

                sSQL = "ALTER TABLE Remont ADD PAMIATKA TEXT"
                DB7.Execute(sSQL)
                sSQL = "UPDATE Remont SET PAMIATKA=MeMo"
                DB7.Execute(sSQL)
                sSQL = "ALTER TABLE Remont DROP column  MeMo"
                DB7.Execute(sSQL)

                sSQL = "ALTER TABLE Remont ADD CUMMA INTEGER"
                DB7.Execute(sSQL)
                sSQL = "UPDATE Remont SET CUMMA=Summ"
                DB7.Execute(sSQL)
                sSQL = "ALTER TABLE Remont DROP column  Summ"
                DB7.Execute(sSQL)

                sSQL = "ALTER TABLE Remont ADD User_Name varchar(255)"
                DB7.Execute(sSQL)
                sSQL = "UPDATE Remont SET User_Name=UserName"
                DB7.Execute(sSQL)
                sSQL = "ALTER TABLE Remont DROP column  UserName"
                DB7.Execute(sSQL)
                '##########################################################################
                sSQL = "ALTER TABLE remonty_plus ADD D_T datetime"
                DB7.Execute(sSQL)
                sSQL = "UPDATE remonty_plus SET D_T=DATA"
                DB7.Execute(sSQL)
                sSQL = "ALTER TABLE remonty_plus DROP column  data"
                DB7.Execute(sSQL)
                '##########################################################################
                sSQL = "ALTER TABLE Sheduler ADD D_T datetime"
                DB7.Execute(sSQL)
                sSQL = "UPDATE Sheduler SET D_T=DATA"
                DB7.Execute(sSQL)
                sSQL = "ALTER TABLE Sheduler DROP column  DATA"
                DB7.Execute(sSQL)
                '##########################################################################
                sSQL = "ALTER TABLE T_Log ADD D_T datetime"
                DB7.Execute(sSQL)
                sSQL = "UPDATE T_Log SET D_T=DATe"
                DB7.Execute(sSQL)
                sSQL = "ALTER TABLE T_Log DROP column  date"
                DB7.Execute(sSQL)

                sSQL = "ALTER TABLE T_Log ADD T_M VARCHAR(50)"
                DB7.Execute(sSQL)
                sSQL = "UPDATE T_Log SET T_M=time"
                DB7.Execute(sSQL)
                sSQL = "ALTER TABLE T_Log DROP column  Time"
                DB7.Execute(sSQL)
                '##########################################################################
                sSQL = "ALTER TABLE Update_Log ADD D_T datetime"
                DB7.Execute(sSQL)
                sSQL = "UPDATE Update_Log SET D_T=DATe"
                DB7.Execute(sSQL)
                sSQL = "ALTER TABLE Update_Log DROP column  date"
                DB7.Execute(sSQL)
                sSQL = "ALTER TABLE Update_Log ADD T_M varchar(50)"
                DB7.Execute(sSQL)
                sSQL = "UPDATE Update_Log SET T_M=time"
                DB7.Execute(sSQL)
                sSQL = "ALTER TABLE Update_Log DROP column  Time"
                DB7.Execute(sSQL)
                '##########################################################################
                sSQL = "ALTER TABLE ZAM_OTD ADD D_T datetime"
                DB7.Execute(sSQL)
                sSQL = "UPDATE ZAM_OTD SET D_T=DATe"
                DB7.Execute(sSQL)
                sSQL = "ALTER TABLE ZAM_OTD DROP column  date"
                DB7.Execute(sSQL)
                '##########################################################################
                sSQL = "ALTER TABLE Zametki ADD D_T datetime"
                DB7.Execute(sSQL)
                sSQL = "UPDATE Zametki SET D_T=DATe"
                DB7.Execute(sSQL)
                sSQL = "ALTER TABLE Zametki DROP column date"
                DB7.Execute(sSQL)
                '##########################################################################
                sSQL = "ALTER TABLE Garantia_sis ADD DEN varchar(50)"
                DB7.Execute(sSQL)
                sSQL = "UPDATE Garantia_sis SET DEN=Day"
                DB7.Execute(sSQL)
                sSQL = "ALTER TABLE Garantia_sis DROP column  Day"
                DB7.Execute(sSQL)

                sSQL = "ALTER TABLE Garantia_sis ADD Mesiac varchar(50)"
                DB7.Execute(sSQL)
                sSQL = "UPDATE Garantia_sis SET Mesiac=Month"
                DB7.Execute(sSQL)
                sSQL = "ALTER TABLE Garantia_sis DROP column  Month"
                DB7.Execute(sSQL)

                sSQL = "ALTER TABLE Garantia_sis ADD GOD varchar(50)"
                DB7.Execute(sSQL)
                sSQL = "UPDATE Garantia_sis SET GOD=Year"
                DB7.Execute(sSQL)
                sSQL = "ALTER TABLE Garantia_sis DROP column Year"
                DB7.Execute(sSQL)
                '##########################################################################
            Case "MySQL (MyODBC 5.1)"
                sSQL = "ALTER TABLE CARTRIDG ADD D_T datetime"
                DB7.Execute(sSQL)
                sSQL = "UPDATE CARTRIDG SET D_T=DATA"
                DB7.Execute(sSQL)
                sSQL = "ALTER TABLE CARTRIDG DROP column  DATA"
                DB7.Execute(sSQL)
                '##########################################################################
                sSQL = "ALTER TABLE CARTRIDG_D ADD D_T datetime"
                DB7.Execute(sSQL)
                sSQL = "UPDATE CARTRIDG_D SET D_T=DATA"
                DB7.Execute(sSQL)
                sSQL = "ALTER TABLE CARTRIDG_D DROP column  DATA"
                DB7.Execute(sSQL)

                sSQL = "ALTER TABLE CARTRIDG_D ADD T_M VARCHAR(50)"
                DB7.Execute(sSQL)
                sSQL = "UPDATE CARTRIDG_D SET T_M=time"
                DB7.Execute(sSQL)
                sSQL = "ALTER TABLE CARTRIDG_D DROP column  time"
                DB7.Execute(sSQL)
                '##########################################################################
                sSQL = "ALTER TABLE dvig ADD D_T datetime"
                DB7.Execute(sSQL)
                sSQL = "UPDATE dvig SET D_T=DATA"
                DB7.Execute(sSQL)
                sSQL = "ALTER TABLE dvig DROP column  DATA"
                DB7.Execute(sSQL)

                sSQL = "ALTER TABLE dvig ADD T_M VARCHAR(50)"
                DB7.Execute(sSQL)
                sSQL = "UPDATE dvig SET T_M=time"
                DB7.Execute(sSQL)
                sSQL = "ALTER TABLE dvig DROP column  time"
                DB7.Execute(sSQL)
                '##########################################################################
                sSQL = "ALTER TABLE kompy ADD D_T datetime"
                DB7.Execute(sSQL)
                sSQL = "UPDATE kompy SET D_T=DATe"
                DB7.Execute(sSQL)
                sSQL = "ALTER TABLE kompy DROP column  date"
                DB7.Execute(sSQL)
                '##########################################################################
                sSQL = "ALTER TABLE Remont ADD D_T datetime"
                DB7.Execute(sSQL)
                sSQL = "UPDATE Remont SET D_T=DATe"
                DB7.Execute(sSQL)
                sSQL = "ALTER TABLE Remont DROP column  date"
                DB7.Execute(sSQL)

                sSQL = "ALTER TABLE Remont ADD PAMIATKA TEXT"
                DB7.Execute(sSQL)
                sSQL = "UPDATE Remont SET PAMIATKA=MeMo"
                DB7.Execute(sSQL)
                sSQL = "ALTER TABLE Remont DROP column  MeMo"
                DB7.Execute(sSQL)

                sSQL = "ALTER TABLE Remont ADD CUMMA INTEGER"
                DB7.Execute(sSQL)
                sSQL = "UPDATE Remont SET CUMMA=Summ"
                DB7.Execute(sSQL)
                sSQL = "ALTER TABLE Remont DROP column  Summ"
                DB7.Execute(sSQL)

                sSQL = "ALTER TABLE Remont ADD User_Name varchar(255)"
                DB7.Execute(sSQL)
                sSQL = "UPDATE Remont SET User_Name=UserName"
                DB7.Execute(sSQL)
                sSQL = "ALTER TABLE Remont DROP column  UserName"
                DB7.Execute(sSQL)
                '##########################################################################
                sSQL = "ALTER TABLE remonty_plus ADD D_T datetime"
                DB7.Execute(sSQL)
                sSQL = "UPDATE remonty_plus SET D_T=DATA"
                DB7.Execute(sSQL)
                sSQL = "ALTER TABLE remonty_plus DROP column  data"
                DB7.Execute(sSQL)
                '##########################################################################
                sSQL = "ALTER TABLE Sheduler ADD D_T datetime"
                DB7.Execute(sSQL)
                sSQL = "UPDATE Sheduler SET D_T=DATA"
                DB7.Execute(sSQL)
                sSQL = "ALTER TABLE Sheduler DROP column  DATA"
                DB7.Execute(sSQL)
                '##########################################################################
                sSQL = "ALTER TABLE T_Log ADD D_T datetime"
                DB7.Execute(sSQL)
                sSQL = "UPDATE T_Log SET D_T=DATe"
                DB7.Execute(sSQL)
                sSQL = "ALTER TABLE T_Log DROP column  date"
                DB7.Execute(sSQL)

                sSQL = "ALTER TABLE T_Log ADD T_M VARCHAR(50)"
                DB7.Execute(sSQL)
                sSQL = "UPDATE T_Log SET T_M=time"
                DB7.Execute(sSQL)
                sSQL = "ALTER TABLE T_Log DROP column  Time"
                DB7.Execute(sSQL)
                '##########################################################################
                sSQL = "ALTER TABLE Update_Log ADD D_T datetime"
                DB7.Execute(sSQL)
                sSQL = "UPDATE Update_Log SET D_T=DATe"
                DB7.Execute(sSQL)
                sSQL = "ALTER TABLE Update_Log DROP column  date"
                DB7.Execute(sSQL)
                sSQL = "ALTER TABLE Update_Log ADD T_M varchar(50)"
                DB7.Execute(sSQL)
                sSQL = "UPDATE Update_Log SET T_M=time"
                DB7.Execute(sSQL)
                sSQL = "ALTER TABLE Update_Log DROP column  Time"
                DB7.Execute(sSQL)
                '##########################################################################
                sSQL = "ALTER TABLE ZAM_OTD ADD D_T datetime"
                DB7.Execute(sSQL)
                sSQL = "UPDATE ZAM_OTD SET D_T=DATe"
                DB7.Execute(sSQL)
                sSQL = "ALTER TABLE ZAM_OTD DROP column  date"
                DB7.Execute(sSQL)
                '##########################################################################
                sSQL = "ALTER TABLE Zametki ADD D_T datetime"
                DB7.Execute(sSQL)
                sSQL = "UPDATE Zametki SET D_T=DATe"
                DB7.Execute(sSQL)
                sSQL = "ALTER TABLE Zametki DROP column  date"
                DB7.Execute(sSQL)
                '##########################################################################
                sSQL = "ALTER TABLE Garantia_sis ADD DEN varchar(50)"
                DB7.Execute(sSQL)
                sSQL = "UPDATE Garantia_sis SET DEN=Day"
                DB7.Execute(sSQL)
                sSQL = "ALTER TABLE Garantia_sis DROP column  Day"
                DB7.Execute(sSQL)

                sSQL = "ALTER TABLE Garantia_sis ADD Mesiac varchar(50)"
                DB7.Execute(sSQL)
                sSQL = "UPDATE Garantia_sis SET Mesiac=Month"
                DB7.Execute(sSQL)
                sSQL = "ALTER TABLE Garantia_sis DROP column  Month"
                DB7.Execute(sSQL)

                sSQL = "ALTER TABLE Garantia_sis ADD GOD varchar(50)"
                DB7.Execute(sSQL)
                sSQL = "UPDATE Garantia_sis SET GOD=Year"
                DB7.Execute(sSQL)
                sSQL = "ALTER TABLE Garantia_sis DROP column Year"
                DB7.Execute(sSQL)
                '##########################################################################
            Case "PostgreSQL"
                sSQL = "ALTER TABLE CARTRIDG ADD D_T Date"
                DB7.Execute(sSQL)
                sSQL = "UPDATE CARTRIDG SET D_T=DATA"
                DB7.Execute(sSQL)
                sSQL = "ALTER TABLE CARTRIDG DROP column  DATA"
                DB7.Execute(sSQL)
                '##########################################################################
                sSQL = "ALTER TABLE CARTRIDG_D ADD D_T Date"
                DB7.Execute(sSQL)
                sSQL = "UPDATE CARTRIDG_D SET D_T=DATA"
                DB7.Execute(sSQL)
                sSQL = "ALTER TABLE CARTRIDG_D DROP column  DATA"
                DB7.Execute(sSQL)

                sSQL = "ALTER TABLE CARTRIDG_D ADD T_M varchar(50)"
                DB7.Execute(sSQL)
                sSQL = "UPDATE CARTRIDG_D SET T_M=time"
                DB7.Execute(sSQL)
                sSQL = "ALTER TABLE CARTRIDG_D DROP column  time"
                DB7.Execute(sSQL)
                '##########################################################################
                sSQL = "ALTER TABLE dvig ADD D_T Date"
                DB7.Execute(sSQL)
                sSQL = "UPDATE dvig SET D_T=DATA"
                DB7.Execute(sSQL)
                sSQL = "ALTER TABLE dvig DROP column  DATA"
                DB7.Execute(sSQL)

                sSQL = "ALTER TABLE dvig ADD T_M varchar(50)"
                DB7.Execute(sSQL)
                sSQL = "UPDATE dvig SET T_M=time"
                DB7.Execute(sSQL)
                sSQL = "ALTER TABLE dvig DROP column  time"
                DB7.Execute(sSQL)
                '##########################################################################
                sSQL = "ALTER TABLE kompy ADD D_T Date"
                DB7.Execute(sSQL)
                sSQL = "UPDATE kompy SET D_T=DATe"
                DB7.Execute(sSQL)
                sSQL = "ALTER TABLE kompy DROP column  date"
                DB7.Execute(sSQL)
                '##########################################################################
                sSQL = "ALTER TABLE Remont ADD D_T Date"
                DB7.Execute(sSQL)
                sSQL = "UPDATE Remont SET D_T=DATe"
                DB7.Execute(sSQL)
                sSQL = "ALTER TABLE Remont DROP column  date"
                DB7.Execute(sSQL)

                sSQL = "ALTER TABLE Remont ADD PAMIATKA text"
                DB7.Execute(sSQL)
                sSQL = "UPDATE Remont SET PAMIATKA=MeMo"
                DB7.Execute(sSQL)
                sSQL = "ALTER TABLE Remont DROP column  MeMo"
                DB7.Execute(sSQL)

                sSQL = "ALTER TABLE Remont ADD CUMMA numeric"
                DB7.Execute(sSQL)
                sSQL = "UPDATE Remont SET CUMMA=Summ"
                DB7.Execute(sSQL)
                sSQL = "ALTER TABLE Remont DROP column  Summ"
                DB7.Execute(sSQL)

                sSQL = "ALTER TABLE Remont ADD User_Name nvarchar(255)"
                DB7.Execute(sSQL)
                sSQL = "UPDATE Remont SET User_Name=UserName"
                DB7.Execute(sSQL)
                sSQL = "ALTER TABLE Remont DROP column  UserName"
                DB7.Execute(sSQL)
                '##########################################################################
                sSQL = "ALTER TABLE remonty_plus ADD D_T Date"
                DB7.Execute(sSQL)
                sSQL = "UPDATE remonty_plus SET D_T=DATA"
                DB7.Execute(sSQL)
                sSQL = "ALTER TABLE remonty_plus DROP column  data"
                DB7.Execute(sSQL)
                '##########################################################################
                sSQL = "ALTER TABLE Sheduler ADD D_T Date"
                DB7.Execute(sSQL)
                sSQL = "UPDATE Sheduler SET D_T=DATA"
                DB7.Execute(sSQL)
                sSQL = "ALTER TABLE Sheduler DROP column  DATA"
                DB7.Execute(sSQL)
                '##########################################################################
                sSQL = "ALTER TABLE T_Log ADD D_T Date"
                DB7.Execute(sSQL)
                sSQL = "UPDATE T_Log SET D_T=DATe"
                DB7.Execute(sSQL)
                sSQL = "ALTER TABLE T_Log DROP column  date"
                DB7.Execute(sSQL)

                sSQL = "ALTER TABLE T_Log ADD T_M varchar(50)"
                DB7.Execute(sSQL)
                sSQL = "UPDATE T_Log SET T_M=time"
                DB7.Execute(sSQL)
                sSQL = "ALTER TABLE T_Log DROP column  Time"
                DB7.Execute(sSQL)
                '##########################################################################
                sSQL = "ALTER TABLE Update_Log ADD D_T Date"
                DB7.Execute(sSQL)
                sSQL = "UPDATE Update_Log SET D_T=DATe"
                DB7.Execute(sSQL)
                sSQL = "ALTER TABLE Update_Log DROP column  date"
                DB7.Execute(sSQL)
                sSQL = "ALTER TABLE Update_Log ADD T_M varchar(50)"
                DB7.Execute(sSQL)
                sSQL = "UPDATE Update_Log SET T_M=time"
                DB7.Execute(sSQL)
                sSQL = "ALTER TABLE Update_Log DROP column  Time"
                DB7.Execute(sSQL)
                '##########################################################################
                sSQL = "ALTER TABLE ZAM_OTD ADD D_T Date"
                DB7.Execute(sSQL)
                sSQL = "UPDATE ZAM_OTD SET D_T=DATe"
                DB7.Execute(sSQL)
                sSQL = "ALTER TABLE ZAM_OTD DROP column  date"
                DB7.Execute(sSQL)
                '##########################################################################
                sSQL = "ALTER TABLE Zametki ADD D_T Date"
                DB7.Execute(sSQL)
                sSQL = "UPDATE Zametki SET D_T=DATe"
                DB7.Execute(sSQL)
                sSQL = "ALTER TABLE Zametki DROP column  date"
                DB7.Execute(sSQL)
                '##########################################################################
                sSQL = "ALTER TABLE Garantia_sis ADD DEN varchar(50)"
                DB7.Execute(sSQL)
                sSQL = "UPDATE Garantia_sis SET DEN=Day"
                DB7.Execute(sSQL)
                sSQL = "ALTER TABLE Garantia_sis DROP column  Day"
                DB7.Execute(sSQL)

                sSQL = "ALTER TABLE Garantia_sis ADD Mesiac varchar(50)"
                DB7.Execute(sSQL)
                sSQL = "UPDATE Garantia_sis SET Mesiac=Month"
                DB7.Execute(sSQL)
                sSQL = "ALTER TABLE Garantia_sis DROP column  Month"
                DB7.Execute(sSQL)

                sSQL = "ALTER TABLE Garantia_sis ADD GOD varchar(50)"
                DB7.Execute(sSQL)
                sSQL = "UPDATE Garantia_sis SET GOD=Year"
                DB7.Execute(sSQL)
                sSQL = "ALTER TABLE Garantia_sis DROP column  Year"
                DB7.Execute(sSQL)
                '##########################################################################
            Case "SQLLite"

            Case "DSN"
                sSQL = "ALTER TABLE CARTRIDG ADD D_T datetime"
                DB7.Execute(sSQL)
                sSQL = "UPDATE CARTRIDG SET D_T=DATA"
                DB7.Execute(sSQL)
                sSQL = "ALTER TABLE CARTRIDG DROP column  DATA"
                DB7.Execute(sSQL)
                '##########################################################################
                sSQL = "ALTER TABLE CARTRIDG_D ADD D_T datetime"
                DB7.Execute(sSQL)
                sSQL = "UPDATE CARTRIDG_D SET D_T=DATA"
                DB7.Execute(sSQL)
                sSQL = "ALTER TABLE CARTRIDG_D DROP column  DATA"
                DB7.Execute(sSQL)

                sSQL = "ALTER TABLE CARTRIDG_D ADD T_M varchar(50)"
                DB7.Execute(sSQL)
                sSQL = "UPDATE CARTRIDG_D SET T_M=time"
                DB7.Execute(sSQL)
                sSQL = "ALTER TABLE CARTRIDG_D DROP column  time"
                DB7.Execute(sSQL)
                '##########################################################################
                sSQL = "ALTER TABLE dvig ADD D_T datetime"
                DB7.Execute(sSQL)
                sSQL = "UPDATE dvig SET D_T=DATA"
                DB7.Execute(sSQL)
                sSQL = "ALTER TABLE dvig DROP column  DATA"
                DB7.Execute(sSQL)

                sSQL = "ALTER TABLE dvig ADD T_M varchar(50)"
                DB7.Execute(sSQL)
                sSQL = "UPDATE dvig SET T_M=time"
                DB7.Execute(sSQL)
                sSQL = "ALTER TABLE dvig DROP column  time"
                DB7.Execute(sSQL)
                '##########################################################################
                sSQL = "ALTER TABLE kompy ADD D_T datetime"
                DB7.Execute(sSQL)
                sSQL = "UPDATE kompy SET D_T=DATe"
                DB7.Execute(sSQL)
                sSQL = "ALTER TABLE kompy DROP column  date"
                DB7.Execute(sSQL)
                '##########################################################################
                sSQL = "ALTER TABLE Remont ADD D_T datetime"
                DB7.Execute(sSQL)
                sSQL = "UPDATE Remont SET D_T=DATe"
                DB7.Execute(sSQL)
                sSQL = "ALTER TABLE Remont DROP column  date"
                DB7.Execute(sSQL)

                sSQL = "ALTER TABLE Remont ADD PAMIATKA text"
                DB7.Execute(sSQL)
                sSQL = "UPDATE Remont SET PAMIATKA=MeMo"
                DB7.Execute(sSQL)
                sSQL = "ALTER TABLE Remont DROP column  MeMo"
                DB7.Execute(sSQL)

                sSQL = "ALTER TABLE Remont ADD CUMMA numeric"
                DB7.Execute(sSQL)
                sSQL = "UPDATE Remont SET CUMMA=Summ"
                DB7.Execute(sSQL)
                sSQL = "ALTER TABLE Remont DROP column  Summ"
                DB7.Execute(sSQL)

                sSQL = "ALTER TABLE Remont ADD User_Name varchar(255)"
                DB7.Execute(sSQL)
                sSQL = "UPDATE Remont SET User_Name=UserName"
                DB7.Execute(sSQL)
                sSQL = "ALTER TABLE Remont DROP column UserName"
                DB7.Execute(sSQL)
                '##########################################################################
                sSQL = "ALTER TABLE remonty_plus ADD D_T datetime"
                DB7.Execute(sSQL)
                sSQL = "UPDATE remonty_plus SET D_T=DATA"
                DB7.Execute(sSQL)
                sSQL = "ALTER TABLE remonty_plus DROP column  data"
                DB7.Execute(sSQL)
                '##########################################################################
                sSQL = "ALTER TABLE Sheduler ADD D_T datetime"
                DB7.Execute(sSQL)
                sSQL = "UPDATE Sheduler SET D_T=DATA"
                DB7.Execute(sSQL)
                sSQL = "ALTER TABLE Sheduler DROP column  DATA"
                DB7.Execute(sSQL)
                '##########################################################################
                sSQL = "ALTER TABLE T_Log ADD D_T datetime"
                DB7.Execute(sSQL)
                sSQL = "UPDATE T_Log SET D_T=DATe"
                DB7.Execute(sSQL)
                sSQL = "ALTER TABLE T_Log DROP column  date"
                DB7.Execute(sSQL)

                sSQL = "ALTER TABLE T_Log ADD T_M varchar(50)"
                DB7.Execute(sSQL)
                sSQL = "UPDATE T_Log SET T_M=time"
                DB7.Execute(sSQL)
                sSQL = "ALTER TABLE T_Log DROP column  Time"
                DB7.Execute(sSQL)
                '##########################################################################
                sSQL = "ALTER TABLE Update_Log ADD D_T datetime"
                DB7.Execute(sSQL)
                sSQL = "UPDATE Update_Log SET D_T=DATe"
                DB7.Execute(sSQL)
                sSQL = "ALTER TABLE Update_Log DROP column  date"
                DB7.Execute(sSQL)
                sSQL = "ALTER TABLE Update_Log ADD T_M varchar(50)"
                DB7.Execute(sSQL)
                sSQL = "UPDATE Update_Log SET T_M=time"
                DB7.Execute(sSQL)
                sSQL = "ALTER TABLE Update_Log DROP column  Time"
                DB7.Execute(sSQL)
                '##########################################################################
                sSQL = "ALTER TABLE ZAM_OTD ADD D_T datetime"
                DB7.Execute(sSQL)
                sSQL = "UPDATE ZAM_OTD SET D_T=DATe"
                DB7.Execute(sSQL)
                sSQL = "ALTER TABLE ZAM_OTD DROP column  date"
                DB7.Execute(sSQL)
                '##########################################################################
                sSQL = "ALTER TABLE Zametki ADD D_T datetime"
                DB7.Execute(sSQL)
                sSQL = "UPDATE Zametki SET D_T=DATe"
                DB7.Execute(sSQL)
                sSQL = "ALTER TABLE Zametki DROP column  date"
                DB7.Execute(sSQL)
                '##########################################################################
                sSQL = "ALTER TABLE Garantia_sis ADD DEN varchar(50)"
                DB7.Execute(sSQL)
                sSQL = "UPDATE Garantia_sis SET DEN=Day"
                DB7.Execute(sSQL)
                sSQL = "ALTER TABLE Garantia_sis DROP column  Day"
                DB7.Execute(sSQL)

                sSQL = "ALTER TABLE Garantia_sis ADD Mesiac varchar(50)"
                DB7.Execute(sSQL)
                sSQL = "UPDATE Garantia_sis SET Mesiac=Month"
                DB7.Execute(sSQL)
                sSQL = "ALTER TABLE Garantia_sis DROP column  Month"
                DB7.Execute(sSQL)

                sSQL = "ALTER TABLE Garantia_sis ADD GOD varchar(50)"
                DB7.Execute(sSQL)
                sSQL = "UPDATE Garantia_sis SET GOD=Year"
                DB7.Execute(sSQL)
                sSQL = "ALTER TABLE Garantia_sis DROP column  Year"
                DB7.Execute(sSQL)
                '##########################################################################

        End Select

        Call ALTER_DB_1752()

        Exit Sub
err_:


        _DBALTER = True
        MsgBox(Err.Description)
    End Sub

    Public Sub ALTER_DB_1752()

        On Error GoTo err_

        If _DBALTER = False Then Exit Sub

        Dim sSQL As String

        sSQL = "ALTER TABLE SOFT_INSTALL ADD VERS TEXT(50)"

        Select Case DB_N

            Case "MS SQL 2008"

                sSQL = "ALTER TABLE " & DBtabl & ".dbo.SOFT_INSTALL ADD VERS nvarchar(50)"

                DB7.Execute(sSQL)


            Case "MS SQL"

                sSQL = "ALTER TABLE " & DBtabl & ".dbo.SOFT_INSTALL ADD VERS nvarchar(50)"

                DB7.Execute(sSQL)

            Case "MS Access"

                Call frmMain.COMPARE_DB()

                DB7.Execute(sSQL)

            Case "MS Access 2007"

                Call frmMain.COMPARE_DB()

                DB7.Execute(sSQL)

            Case "MySQL"

                sSQL = "ALTER TABLE SOFT_INSTALL ADD COLUMN VERS varchar(50)"

                DB7.Execute(sSQL)


            Case "MySQL (MyODBC 5.1)"

                sSQL = "ALTER TABLE SOFT_INSTALL ADD COLUMN VERS varchar(50)"

                DB7.Execute(sSQL)


            Case "PostgreSQL"

                sSQL = "ALTER TABLE SOFT_INSTALL ADD COLUMN VERS varchar(50)"

                DB7.Execute(sSQL)

            Case "SQLLite"


            Case "DSN"

                sSQL = "ALTER TABLE SOFT_INSTALL ADD COLUMN VERS varchar(50)"

                DB7.Execute(sSQL)

        End Select


        DB7.Execute("Update CONFIGURE SET access='1.7.5.2' WHERE access<>'1.7.5.2'")
        _DBALTER = False

        '####################################################################
        '####################################################################
        '####################################################################
        ' Убираем поля с NULL

        On Error Resume Next

        Dim rs As Recordset
        rs = New Recordset
        rs.Open("select * from kompy", DB7, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)

        Dim uname As Integer

        If DB_N <> "MS Access" Or DB_N <> "MS Access 2007" Then uname = 2 Else uname = 1

        For lngCounter = 0 To rs.Fields.Count - uname

            If rs.Fields(lngCounter).Name = "id" Or rs.Fields(lngCounter).Name = "ID" Then

            Else

                DB7.Execute("UPDATE kompy SET " & rs.Fields(lngCounter).Name & "= WHERE " & rs.Fields(lngCounter).Name & " IS NULL")

            End If
        Next

        rs.Close()

        Exit Sub
err_:
        MsgBox(Err.Description)

        _DBALTER = True
    End Sub

End Module
