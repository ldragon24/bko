Imports System.IO
Imports Microsoft.Office.Interop.Word

Public Class frmAct_Treb
    Public dSID As Integer
    Private eDTI As Boolean

    Private Sub frmAct_Treb_Activated(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Activated

        frmMain.SaveInfTehButton.Enabled = False
        frmMain.ToolStripDropDownButton1.Enabled = False
    End Sub

    Private Sub frmAct_Treb_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load

        Call frmAct_treb_LANG()

        Call ACTOS3_LOAD()
        Call ACTVV_LOAD()
        Call TREB_LOAD()


        SendFonts(Me)

        TabControl1.Font = New Drawing.Font(FontN, fontS)
        SendFonts(TabControl1.TabPages(0))
        SendFonts(TabControl1.TabPages(1))
        SendFonts(TabControl1.TabPages(2))

    End Sub

    Public Sub ACTOS3_LOAD()

        lvACTSP.Items.Clear()

        Dim rs As Recordset
        Dim iCount As String
        rs = New Recordset
        rs.Open("SELECT count(*) as t_n FROM AKT_SP_OS3 where ID_COMP=" & frmComputers.sCOUNT, DB7,
                CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)

        With rs
            iCount = .Fields("t_n").Value
        End With

        rs.Close()
        rs = Nothing

        If iCount = 0 Then Exit Sub


        rs = New Recordset
        rs.Open("SELECT * FROM AKT_SP_OS3 where ID_COMP=" & frmComputers.sCOUNT, DB7, CursorTypeEnum.adOpenDynamic,
                LockTypeEnum.adLockOptimistic)

        Dim intCount As Decimal = 0

        lvACTSP.Items.Clear()

        With rs
            .MoveFirst()
            Do While Not .EOF

                If .Fields("ID_COMP").Value = frmComputers.sCOUNT Then

                    lvACTSP.Items.Add(.Fields("id").Value) 'col no. 1

                    If Not IsDBNull(.Fields("Nomer").Value) Then
                        lvACTSP.Items(CInt(intCount)).SubItems.Add(.Fields("Nomer").Value)
                    Else
                        lvACTSP.Items(CInt(intCount)).SubItems.Add("")
                    End If

                    If Not IsDBNull(.Fields("DATAV").Value) Then
                        lvACTSP.Items(CInt(intCount)).SubItems.Add(.Fields("DATAV").Value)
                    Else
                        lvACTSP.Items(CInt(intCount)).SubItems.Add("")
                    End If

                    If Not IsDBNull(.Fields("KOMPL").Value) Then
                        lvACTSP.Items(CInt(intCount)).SubItems.Add(.Fields("KOMPL").Value)
                    Else
                        lvACTSP.Items(CInt(intCount)).SubItems.Add("")
                    End If

                    If Not IsDBNull(.Fields("Model").Value) Then
                        lvACTSP.Items(CInt(intCount)).SubItems.Add(.Fields("Model").Value)
                    Else
                        lvACTSP.Items(CInt(intCount)).SubItems.Add("")
                    End If

                    If Not IsDBNull(.Fields("GODPR").Value) Then
                        lvACTSP.Items(CInt(intCount)).SubItems.Add(.Fields("GODPR").Value)
                    Else
                        lvACTSP.Items(CInt(intCount)).SubItems.Add("")
                    End If

                    If Not IsDBNull(.Fields("DATAPOST").Value) Then
                        lvACTSP.Items(CInt(intCount)).SubItems.Add(.Fields("DATAPOST").Value)
                    Else
                        lvACTSP.Items(CInt(intCount)).SubItems.Add("")
                    End If

                    If Not IsDBNull(.Fields("STOIM").Value) Then
                        lvACTSP.Items(CInt(intCount)).SubItems.Add(.Fields("STOIM").Value)
                    Else
                        lvACTSP.Items(CInt(intCount)).SubItems.Add("")
                    End If

                    If Not IsDBNull(.Fields("DATAPK").Value) Then
                        lvACTSP.Items(CInt(intCount)).SubItems.Add(.Fields("DATAPK").Value)
                    Else
                        lvACTSP.Items(CInt(intCount)).SubItems.Add("")
                    End If

                    intCount = intCount + 1

                Else
                End If
                .MoveNext()
            Loop
        End With
        rs.Close()
        rs = Nothing

        ResList(Me.lvACTSP)
    End Sub

    Public Sub ACTVV_LOAD()
        Dim rs As Recordset
        Dim iCount As String
        rs = New Recordset
        rs.Open("SELECT count(*) as t_n FROM ActOS where computer ='" & frmComputers.sCOUNT & "'", DB7,
                CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)

        With rs
            iCount = .Fields("t_n").Value
        End With

        rs.Close()
        rs = Nothing

        If iCount = 0 Then Exit Sub


        rs = New Recordset
        rs.Open("SELECT * FROM ActOS where computer='" & frmComputers.sCOUNT & "'", DB7, CursorTypeEnum.adOpenDynamic,
                LockTypeEnum.adLockOptimistic)

        Dim intCount As Decimal = 0

        lvACTVV.Items.Clear()

        With rs
            .MoveFirst()
            Do While Not .EOF

                lvACTVV.Items.Add(.Fields("id").Value) 'col no. 1

                If Not IsDBNull(.Fields("Nomer").Value) Then
                    lvACTVV.Items(CInt(intCount)).SubItems.Add(.Fields("Nomer").Value)
                Else
                    lvACTVV.Items(CInt(intCount)).SubItems.Add("")
                End If

                If Not IsDBNull(.Fields("modTexn").Value) Then
                    lvACTVV.Items(CInt(intCount)).SubItems.Add(.Fields("modTexn").Value)
                Else
                    lvACTVV.Items(CInt(intCount)).SubItems.Add("")
                End If

                If Not IsDBNull(.Fields("cena").Value) Then
                    lvACTVV.Items(CInt(intCount)).SubItems.Add(.Fields("cena").Value)
                Else
                    lvACTVV.Items(CInt(intCount)).SubItems.Add("")
                End If

                If Not IsDBNull(.Fields("datasost").Value) Then
                    lvACTVV.Items(CInt(intCount)).SubItems.Add(.Fields("datasost").Value)
                Else
                    lvACTVV.Items(CInt(intCount)).SubItems.Add("")
                End If

                If Not IsDBNull(.Fields("tiporgtex").Value) Then
                    lvACTVV.Items(CInt(intCount)).SubItems.Add(.Fields("tiporgtex").Value)
                Else
                    lvACTVV.Items(CInt(intCount)).SubItems.Add("")
                End If


                intCount = intCount + 1

                .MoveNext()
            Loop
        End With
        rs.Close()
        rs = Nothing

        ResList(Me.lvACTVV)
    End Sub

    Public Sub TREB_LOAD()
        Dim rs As Recordset
        Dim iCount As String
        rs = New Recordset
        rs.Open("SELECT count(*) as t_n FROM TrebOvanie where computer ='" & frmComputers.sCOUNT & "'", DB7,
                CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)

        With rs
            iCount = .Fields("t_n").Value
        End With

        rs.Close()
        rs = Nothing

        If iCount = 0 Then Exit Sub

        lvTREB.Items.Clear()

        rs = New Recordset
        rs.Open("SELECT * FROM TrebOvanie where computer='" & frmComputers.sCOUNT & "'", DB7,
                CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)

        Dim intCount As Decimal = 0

        With rs
            .MoveFirst()
            Do While Not .EOF

                lvTREB.Items.Add(.Fields("id").Value) 'col no. 1

                If Not IsDBNull(.Fields("Nomer").Value) Then
                    lvTREB.Items(CInt(intCount)).SubItems.Add(.Fields("Nomer").Value)
                Else
                    lvTREB.Items(CInt(intCount)).SubItems.Add("")
                End If

                If Not IsDBNull(.Fields("model").Value) Then
                    lvTREB.Items(CInt(intCount)).SubItems.Add(.Fields("model").Value)
                Else
                    lvTREB.Items(CInt(intCount)).SubItems.Add("")
                End If

                If Not IsDBNull(.Fields("cena").Value) Then
                    lvTREB.Items(CInt(intCount)).SubItems.Add(.Fields("cena").Value)
                Else
                    lvTREB.Items(CInt(intCount)).SubItems.Add("")
                End If

                If Not IsDBNull(.Fields("datasost").Value) Then
                    lvTREB.Items(CInt(intCount)).SubItems.Add(.Fields("datasost").Value)
                Else
                    lvTREB.Items(CInt(intCount)).SubItems.Add("")
                End If

                If Not IsDBNull(.Fields("tiporgtex").Value) Then
                    lvTREB.Items(CInt(intCount)).SubItems.Add(.Fields("tiporgtex").Value)
                Else
                    lvTREB.Items(CInt(intCount)).SubItems.Add("")
                End If


                intCount = intCount + 1

                .MoveNext()
            Loop
        End With
        rs.Close()
        rs = Nothing

        ResList(Me.lvTREB)
    End Sub

    Private Sub frmAct_Treb_Resize(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Resize
    End Sub

    Private Sub btnASPadd_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnASPadd.Click

        frm_os3.sEDT = False

        frm_os3.txtActNumber.Text = ""
        frm_os3.dtVip.Value = Date.Today
        frm_os3.cmbCPL.Text = ""
        frm_os3.cmbModCPL.Text = ""
        frm_os3.txtYearPubl.Text = ""
        frm_os3.dtPOST.Value = Date.Today
        frm_os3.txtBalCashe.Text = ""
        frm_os3.txtKolRem.Text = ""
        frm_os3.dtPosKapRem.Value = Date.Today
        frm_os3.txtDef.Text = ""

        frm_os3.ShowDialog(Me)
    End Sub

    Private Sub lvACTSP_Click(ByVal sender As Object, ByVal e As EventArgs) Handles lvACTSP.Click
        If lvACTSP.Items.Count = 0 Then Exit Sub

        Dim z As Integer

        For z = 0 To lvACTSP.SelectedItems.Count - 1
            dSID = (lvACTSP.SelectedItems(z).Text)
        Next
    End Sub

    Private Sub lvACTSP_DoubleClick(ByVal sender As Object, ByVal e As EventArgs) Handles lvACTSP.DoubleClick
        If lvACTSP.Items.Count = 0 Then Exit Sub

        frm_os3.sEDT = True

        Dim rs As Recordset
        rs = New Recordset
        rs.Open("SELECT * FROM AKT_SP_OS3 WHERE id =" & dSID, DB7, CursorTypeEnum.adOpenDynamic,
                LockTypeEnum.adLockOptimistic)

        With rs

            frm_os3.txtActNumber.Text = .Fields("Nomer").Value
            frm_os3.dtVip.Value = .Fields("DATAV").Value
            frm_os3.cmbCPL.Text = .Fields("KOMPL").Value
            frm_os3.cmbModCPL.Text = .Fields("Model").Value
            frm_os3.txtYearPubl.Text = .Fields("GODPR").Value
            frm_os3.dtPOST.Value = .Fields("DATAPOST").Value
            frm_os3.txtBalCashe.Text = .Fields("STOIM").Value
            frm_os3.txtKolRem.Text = .Fields("KolvoRem").Value
            frm_os3.dtPosKapRem.Value = .Fields("DATAPK").Value
            frm_os3.txtDef.Text = .Fields("opis").Value


        End With
        rs.Close()
        rs = Nothing


        frm_os3.ShowDialog(Me)
    End Sub

    Private Sub lvACTSP_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) _
        Handles lvACTSP.SelectedIndexChanged
    End Sub

    Private Sub btnASPdel_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnASPdel.Click

        Dim objIniFile As New IniFile(sLANGPATH)

        If lvACTSP.Items.Count = 0 Then Exit Sub
        If dSID = 0 Then Exit Sub


        If _
            MsgBox(objIniFile.GetString("frmAct_Treb", "MSG1", "Вы уверены что хотите удалить"), MsgBoxStyle.YesNo,
                   ProGramName) = MsgBoxResult.Yes Then
            Dim rs As Recordset
            rs = New Recordset
            rs.Open("DELETE FROM AKT_SP_OS3 WHERE id =" & dSID, DB7, CursorTypeEnum.adOpenDynamic,
                    LockTypeEnum.adLockOptimistic)
            rs = Nothing

            Call ACTOS3_LOAD()

        End If
    End Sub

    Private Sub btnASPofsend_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnASPofsend.Click
        If lvACTSP.Items.Count = 0 Then Exit Sub
        If dSID = 0 Then Exit Sub

        Dim rs As Recordset

        Dim ORG As String
        Dim u1, u2, u3, u4, u5, u6, u7, u8, u9, u10 As String


        rs = New Recordset
        rs.Open("SELECT * FROM CONFIGURE", DB7, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)

        With rs
            ORG = .Fields("org").Value
        End With
        rs.Close()
        rs = Nothing

        rs = New Recordset
        rs.Open("SELECT * FROM AKT_SP_OS3 WHERE id =" & dSID, DB7, CursorTypeEnum.adOpenDynamic,
                LockTypeEnum.adLockOptimistic)


        With rs

            u1$ = .Fields("DATAV").Value
            u2$ = .Fields("KOMPL").Value
            u3$ = .Fields("Model").Value
            u4$ = .Fields("GODPR").Value
            u5$ = .Fields("DATAPOST").Value
            u6$ = .Fields("STOIM").Value
            u7$ = .Fields("Nomer").Value
            u8$ = .Fields("KolvoRem").Value
            u9$ = .Fields("DATAPK").Value
            u10$ = .Fields("opis").Value


        End With
        rs.Close()
        rs = Nothing

        Dim tipot As String

        tipot = Directory.GetParent(System.Windows.Forms.Application.ExecutablePath).ToString & "\blanks\sp.dot"

        Select Case sOfficePACK

            Case "OpenOffice.org"

                Dim oSM                   'Root object for accessing OpenOffice FROM VB
                Dim oDesk, oDoc As Object 'First objects FROM the API
                Dim arg(- 1)                 'Ignore it for the moment !
                'Dim mmerge As Object
                'Instanciate OOo : this line is mandatory with VB for OOo API
                oSM = CreateObject("com.sun.star.ServiceManager")


                'Create the first and most important service
                oDesk = oSM.createInstance("com.sun.star.frame.Desktop")
                'Create a new doc
                oDoc = oDesk.loadComponentFROMURL("file:///" & tipot, "_blank", 0, arg)
                ' jon code
                Dim objText As Object, objCursor As Object
                objText = oDoc.GetText
                objCursor = objText.createTextCursor

                ' replace all
                Dim oSrch As Object
                oSrch = oDoc.createReplaceDescriptor
                oSrch.setSearchString("Hw")
                oSrch.setReplaceString(u2$)
                Debug.Print(oDoc.replaceAll(oSrch))

                oSrch.setSearchString("dataV")
                oSrch.setReplaceString(u1$)
                Debug.Print(oDoc.replaceAll(oSrch))

                oSrch.setSearchString("nmN")
                oSrch.setReplaceString(u3$)
                Debug.Print(oDoc.replaceAll(oSrch))

                oSrch.setSearchString("InM")
                oSrch.setReplaceString("")
                Debug.Print(oDoc.replaceAll(oSrch))

                oSrch.setSearchString("god")
                oSrch.setReplaceString(u4$)
                Debug.Print(oDoc.replaceAll(oSrch))

                oSrch.setSearchString("Dtu")
                oSrch.setReplaceString(u5$)
                Debug.Print(oDoc.replaceAll(oSrch))

                oSrch.setSearchString("Exp")
                oSrch.setReplaceString("")
                Debug.Print(oDoc.replaceAll(oSrch))

                oSrch.setSearchString("Cena")
                oSrch.setReplaceString(u6$)
                Debug.Print(oDoc.replaceAll(oSrch))

                oSrch.setSearchString("KolRem")
                oSrch.setReplaceString(u8$)
                Debug.Print(oDoc.replaceAll(oSrch))

                oSrch.setSearchString("DtPR")
                oSrch.setReplaceString(u9$)
                Debug.Print(oDoc.replaceAll(oSrch))

                oSrch.setSearchString("opis")
                oSrch.setReplaceString(u10$)
                Debug.Print(oDoc.replaceAll(oSrch))

                oSrch.setSearchString("nnm")
                oSrch.setReplaceString(u3$)
                Debug.Print(oDoc.replaceAll(oSrch))

            Case Else

                Dim Wrd As Application
                Dim WrdDc As Object
                Wrd = New Application

                WrdDc = Wrd.Documents.Open(tipot, , False)  'Application.
                WrdDc.Application.Visible = True

                Wrd.Selection.Find.ClearFormatting()
                Wrd.Selection.Find.Replacement.ClearFormatting()
                'Номер
                With Wrd.Selection.Find
                    .Text = "Hw"
                    .Replacement.Text = u2$
                    .Forward = True
                    .Wrap = WdFindWrap.wdFindContinue
                    .Format = False
                    .MatchCase = True
                    .MatchWholeWord = False
                    .MatchWildcards = False
                    ' .MatchSoundsLike = False
                    .MatchAllWordForms = False
                End With
                Wrd.Selection.Find.Execute(Replace:=WdReplace.wdReplaceAll)


                'Дата акта
                With Wrd.Selection.Find
                    .Text = "dataV"
                    .Replacement.Text = u1$
                    .Forward = True
                    .Wrap = WdFindWrap.wdFindContinue
                    .Format = False
                    .MatchCase = True
                    .MatchWholeWord = False
                    .MatchWildcards = False
                    ' .MatchSoundsLike = False
                    .MatchAllWordForms = False
                End With
                Wrd.Selection.Find.Execute(Replace:=WdReplace.wdReplaceAll)
                'Организация
                With Wrd.Selection.Find
                    .Text = "nmN"
                    .Replacement.Text = u3$ 'uname
                    .Forward = True
                    .Wrap = WdFindWrap.wdFindContinue
                    .Format = False
                    .MatchCase = True
                    .MatchWholeWord = False
                    .MatchWildcards = False
                    ' .MatchSoundsLike = False
                    .MatchAllWordForms = False
                End With
                Wrd.Selection.Find.Execute(Replace:=WdReplace.wdReplaceAll)
                'Номер акта

                With Wrd.Selection.Find
                    .Text = "InM"
                    .Replacement.Text = "" 'l$ 'Text3.Text
                    .Forward = True
                    .Wrap = WdFindWrap.wdFindContinue
                    .Format = False
                    .MatchCase = True
                    .MatchWholeWord = False
                    .MatchWildcards = False
                    ' .MatchSoundsLike = False
                    .MatchAllWordForms = False
                End With
                Wrd.Selection.Find.Execute(Replace:=WdReplace.wdReplaceAll)

                'Тип ОС
                With Wrd.Selection.Find
                    .Text = "god"
                    .Replacement.Text = u4$ 'ostip.Text
                    .Forward = True
                    .Wrap = WdFindWrap.wdFindContinue
                    .Format = False
                    .MatchCase = True
                    .MatchWholeWord = False
                    .MatchWildcards = False
                    ' .MatchSoundsLike = False
                    .MatchAllWordForms = False
                End With

                Wrd.Selection.Find.Execute(Replace:=WdReplace.wdReplaceAll)
                'Тип ОС
                With Wrd.Selection.Find
                    .Text = "Dtu"
                    .Replacement.Text = u5$ 'ostip.Text
                    .Forward = True
                    .Wrap = WdFindWrap.wdFindContinue
                    .Format = False
                    .MatchCase = True
                    .MatchWholeWord = False
                    .MatchWildcards = False
                    ' .MatchSoundsLike = False
                    .MatchAllWordForms = False
                End With

                Wrd.Selection.Find.Execute(Replace:=WdReplace.wdReplaceAll)

                'Год выпуска
                With Wrd.Selection.Find
                    .Text = "Exp"
                    .Replacement.Text = "" 'k$ 'Text6.Text
                    .Forward = True
                    .Wrap = WdFindWrap.wdFindContinue
                    .Format = False
                    .MatchCase = True
                    .MatchWholeWord = False
                    .MatchWildcards = False
                    ' .MatchSoundsLike = False
                    .MatchAllWordForms = False
                End With

                Wrd.Selection.Find.Execute(Replace:=WdReplace.wdReplaceAll)

                'Год выпуска
                With Wrd.Selection.Find
                    .Text = "Cena"
                    .Replacement.Text = u6$
                    .Forward = True
                    .Wrap = WdFindWrap.wdFindContinue
                    .Format = False
                    .MatchCase = True
                    .MatchWholeWord = False
                    .MatchWildcards = False
                    ' .MatchSoundsLike = False
                    .MatchAllWordForms = False
                End With

                Wrd.Selection.Find.Execute(Replace:=WdReplace.wdReplaceAll)

                'Цена
                With Wrd.Selection.Find
                    .Text = "KolRem"
                    .Replacement.Text = u8$
                    .Forward = True
                    .Wrap = WdFindWrap.wdFindContinue
                    .Format = False
                    .MatchCase = True
                    .MatchWholeWord = False
                    .MatchWildcards = False
                    ' .MatchSoundsLike = False
                    .MatchAllWordForms = False
                End With

                Wrd.Selection.Find.Execute(Replace:=WdReplace.wdReplaceAll)

                With Wrd.Selection.Find
                    .Text = "DtPR"
                    .Replacement.Text = u9$
                    .Forward = True
                    .Wrap = WdFindWrap.wdFindContinue
                    .Format = False
                    .MatchCase = True
                    .MatchWholeWord = False
                    .MatchWildcards = False
                    ' .MatchSoundsLike = False
                    .MatchAllWordForms = False
                End With

                Wrd.Selection.Find.Execute(Replace:=WdReplace.wdReplaceAll)

                With Wrd.Selection.Find
                    .Text = "opis"
                    .Replacement.Text = u10$
                    .Forward = True
                    .Wrap = WdFindWrap.wdFindContinue
                    .Format = False
                    .MatchCase = True
                    .MatchWholeWord = False
                    .MatchWildcards = False
                    ' .MatchSoundsLike = False
                    .MatchAllWordForms = False
                End With

                Wrd.Selection.Find.Execute(Replace:=WdReplace.wdReplaceAll)

                With Wrd.Selection.Find
                    .Text = "nnm"
                    .Replacement.Text = u3$
                    .Forward = True
                    .Wrap = WdFindWrap.wdFindContinue
                    .Format = False
                    .MatchCase = True
                    .MatchWholeWord = False
                    .MatchWildcards = False
                    ' .MatchSoundsLike = False
                    .MatchAllWordForms = False
                End With

                Wrd.Selection.Find.Execute(Replace:=WdReplace.wdReplaceAll)
                WrdDc = Nothing
                Wrd = Nothing


        End Select
    End Sub

    Private Sub btnAVOSofsend_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnAVOSofsend.Click

        If lvACTVV.Items.Count = 0 Then Exit Sub

        If dSID = 0 Then Exit Sub


        Dim ORG As String
        Dim u, l, k, t, c, dvv, u1, u2 As String


        Dim tipot As String

        'Call SaveActivityToLogDB("Акты ввода оснавных средств в офис " & frmContacts.nnet.Text)

        tipot = Directory.GetParent(System.Windows.Forms.Application.ExecutablePath).ToString & "\blanks\os.dot"


        Dim rs As Recordset
        rs = New Recordset

        rs.Open("SELECT * FROM CONFIGURE", DB7, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)

        With rs
            ORG = .Fields("org").Value
        End With
        rs.Close()
        rs = Nothing


        rs = New Recordset
        rs.Open("SELECT * FROM ActOS WHERE id =" & dSID, DB7, CursorTypeEnum.adOpenDynamic,
                LockTypeEnum.adLockOptimistic)


        With rs
            .MoveFirst()
            Do While Not .EOF
                If .Fields("computer").Value = frmComputers.sCOUNT Then
                    u$ = .Fields("Nomer").Value
                    l$ = .Fields("dataSost").Value
                    t$ = .Fields("dataprikaza").Value
                    k$ = .Fields("tiporgtex").Value & " - " & .Fields("modTexn").Value
                    c$ = .Fields("godVipuska").Value
                    dvv$ = .Fields("datasost").Value
                    u1 = .Fields("Filial").Value
                    u2 = .Fields("otdel").Value

                Else

                    Exit Sub

                End If
                .MoveNext()
            Loop

        End With
        rs.Close()
        rs = Nothing


        Select Case sOfficePACK

            Case "OpenOffice.Org"
                '#############################
                Dim oSM                   'Root object for accessing OpenOffice FROM VB
                Dim oDesk, oDoc As Object 'First objects FROM the API
                Dim arg(- 1)                 'Ignore it for the moment !
                'Dim mmerge As Object
                'Instanciate OOo : this line is mandatory with VB for OOo API
                oSM = CreateObject("com.sun.star.ServiceManager")


                'Create the first and most important service
                oDesk = oSM.createInstance("com.sun.star.frame.Desktop")
                'Create a new doc
                oDoc = oDesk.loadComponentFROMURL("file:///" & tipot, "_blank", 0, arg)
                ' jon code
                Dim objText As Object, objCursor As Object
                objText = oDoc.GetText
                objCursor = objText.createTextCursor

                ' replace all
                Dim oSrch As Object
                oSrch = oDoc.createReplaceDescriptor
                oSrch.setSearchString("nn")
                oSrch.setReplaceString(u$)
                Debug.Print(oDoc.replaceAll(oSrch))

                oSrch.setSearchString("D_T")
                oSrch.setReplaceString(Of Date)()
                Debug.Print(oDoc.replaceAll(oSrch))

                oSrch.setSearchString("org")
                oSrch.setReplaceString(ORG)
                Debug.Print(oDoc.replaceAll(oSrch))

                oSrch.setSearchString("datsost")
                oSrch.setReplaceString(l$)
                Debug.Print(oDoc.replaceAll(oSrch))

                oSrch.setSearchString("fil")
                oSrch.setReplaceString(u1 & "\" & u2)
                Debug.Print(oDoc.replaceAll(oSrch))

                oSrch.setSearchString("datprik")
                oSrch.setReplaceString(t$)
                Debug.Print(oDoc.replaceAll(oSrch))

                oSrch.setSearchString("Tip_tex")
                oSrch.setReplaceString(k$)
                Debug.Print(oDoc.replaceAll(oSrch))

                oSrch.setSearchString("gv")
                oSrch.setReplaceString(c$)
                Debug.Print(oDoc.replaceAll(oSrch))

                oSrch.setSearchString("dvv")
                oSrch.setReplaceString(dvv$)
                Debug.Print(oDoc.replaceAll(oSrch))

            Case Else

                Dim Wrd As Application
                Dim WrdDc As Object
                Wrd = New Application


                WrdDc = Wrd.Documents.Open(tipot, , False)  'Application.
                WrdDc.Application.Visible = True

                Wrd.Selection.Find.ClearFormatting()
                Wrd.Selection.Find.Replacement.ClearFormatting()
                'Номер

                With Wrd.Selection.Find
                    .Text = "nn"
                    .Replacement.Text = u$
                    .Forward = True
                    .Wrap = WdFindWrap.wdFindContinue
                    .Format = False
                    .MatchCase = True
                    .MatchWholeWord = False
                    .MatchWildcards = False
                    ' .MatchSoundsLike = False
                    .MatchAllWordForms = False
                End With
                Wrd.Selection.Find.Execute(Replace:=WdReplace.wdReplaceAll)


                'Дата акта
                With Wrd.Selection.Find
                    .Text = "D_T"
                    .Replacement.Text = Date.Today
                    .Forward = True
                    .Wrap = WdFindWrap.wdFindContinue
                    .Format = False
                    .MatchCase = True
                    .MatchWholeWord = False
                    .MatchWildcards = False
                    ' .MatchSoundsLike = False
                    .MatchAllWordForms = False
                End With
                Wrd.Selection.Find.Execute(Replace:=WdReplace.wdReplaceAll)
                'Организация

                With Wrd.Selection.Find
                    .Text = "org"
                    .Replacement.Text = ORG 'uname
                    .Forward = True
                    .Wrap = WdFindWrap.wdFindContinue
                    .Format = False
                    .MatchCase = True
                    .MatchWholeWord = False
                    .MatchWildcards = False
                    ' .MatchSoundsLike = False
                    .MatchAllWordForms = False
                End With
                Wrd.Selection.Find.Execute(Replace:=WdReplace.wdReplaceAll)


                With Wrd.Selection.Find
                    .Text = "datsost"
                    .Replacement.Text = l$ 'Text3.Text
                    .Forward = True
                    .Wrap = WdFindWrap.wdFindContinue
                    .Format = False
                    .MatchCase = True
                    .MatchWholeWord = False
                    .MatchWildcards = False
                    ' .MatchSoundsLike = False
                    .MatchAllWordForms = False
                End With
                Wrd.Selection.Find.Execute(Replace:=WdReplace.wdReplaceAll)

                'Тип ОС
                With Wrd.Selection.Find
                    .Text = "fil"
                    .Replacement.Text = u1 & "\" & u2
                    .Forward = True
                    .Wrap = WdFindWrap.wdFindContinue
                    .Format = False
                    .MatchCase = True
                    .MatchWholeWord = False
                    .MatchWildcards = False
                    ' .MatchSoundsLike = False
                    .MatchAllWordForms = False
                End With

                Wrd.Selection.Find.Execute(Replace:=WdReplace.wdReplaceAll)

                'Тип ОС
                With Wrd.Selection.Find
                    .Text = "datprik"
                    .Replacement.Text = t$ 'ostip.Text
                    .Forward = True
                    .Wrap = WdFindWrap.wdFindContinue
                    .Format = False
                    .MatchCase = True
                    .MatchWholeWord = False
                    .MatchWildcards = False
                    ' .MatchSoundsLike = False
                    .MatchAllWordForms = False
                End With

                Wrd.Selection.Find.Execute(Replace:=WdReplace.wdReplaceAll)

                'Год выпуска
                With Wrd.Selection.Find
                    .Text = "Tip_tex"
                    .Replacement.Text = k$ 'Text6.Text
                    .Forward = True
                    .Wrap = WdFindWrap.wdFindContinue
                    .Format = False
                    .MatchCase = True
                    .MatchWholeWord = False
                    .MatchWildcards = False
                    ' .MatchSoundsLike = False
                    .MatchAllWordForms = False
                End With

                Wrd.Selection.Find.Execute(Replace:=WdReplace.wdReplaceAll)

                'Год выпуска
                With Wrd.Selection.Find
                    .Text = "gv"
                    .Replacement.Text = c$
                    .Forward = True
                    .Wrap = WdFindWrap.wdFindContinue
                    .Format = False
                    .MatchCase = True
                    .MatchWholeWord = False
                    .MatchWildcards = False
                    ' .MatchSoundsLike = False
                    .MatchAllWordForms = False
                End With

                Wrd.Selection.Find.Execute(Replace:=WdReplace.wdReplaceAll)

                'Цена

                With Wrd.Selection.Find
                    .Text = "dvv"
                    .Replacement.Text = dvv$
                    .Forward = True
                    .Wrap = WdFindWrap.wdFindContinue
                    .Format = False
                    .MatchCase = True
                    .MatchWholeWord = False
                    .MatchWildcards = False
                    ' .MatchSoundsLike = False
                    .MatchAllWordForms = False
                End With

                Wrd.Selection.Find.Execute(Replace:=WdReplace.wdReplaceAll)

                WrdDc = Nothing
                Wrd = Nothing
                'Wrd.Selection.Find.Execute(Replace:=Word.WdReplace.wdReplaceAll)

        End Select
    End Sub

    Private Sub btnTRofSend_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnTRofSend.Click

        If lvTREB.Items.Count = 0 Then Exit Sub
        If dSID = 0 Then Exit Sub


        Dim tipot As String

        Dim rs As Recordset

        Dim ORG As String
        Dim u1, u2, u3, u4, u5, u6, u7 As String


        rs = New Recordset
        rs.Open("SELECT * FROM CONFIGURE", DB7, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)

        With rs
            ORG = .Fields("org").Value
        End With
        rs.Close()
        rs = Nothing

        rs = New Recordset
        rs.Open("SELECT * FROM TrebOvanie WHERE id =" & dSID, DB7, CursorTypeEnum.adOpenDynamic,
                LockTypeEnum.adLockOptimistic)

        With rs

            If .Fields("computer").Value = frmComputers.sCOUNT Then

                u1 = .Fields("dataSost").Value
                u2 = .Fields("cherezkogo").Value
                u3 = .Fields("zatreboval").Value
                u4 = .Fields("cena").Value
                u5 = .Fields("kolich").Value
                u6 = .Fields("tiporgtex").Value & " " & .Fields("model").Value
                u7 = .Fields("nomer").Value
            End If
        End With
        rs.Close()
        rs = Nothing

        tipot = Directory.GetParent(System.Windows.Forms.Application.ExecutablePath).ToString & "\blanks\tr.dot"


        Select Case sOfficePACK

            Case "OpenOffice.org"
                Dim oSM                   'Root object for accessing OpenOffice FROM VB
                Dim oDesk, oDoc As Object 'First objects FROM the API
                Dim arg(- 1)                 'Ignore it for the moment !
                'Dim mmerge As Object
                'Instanciate OOo : this line is mandatory with VB for OOo API
                oSM = CreateObject("com.sun.star.ServiceManager")


                'Create the first and most important service
                oDesk = oSM.createInstance("com.sun.star.frame.Desktop")
                'Create a new doc
                oDoc = oDesk.loadComponentFROMURL("file:///" & tipot, "_blank", 0, arg)
                ' jon code
                Dim objText As Object, objCursor As Object
                objText = oDoc.GetText
                objCursor = objText.createTextCursor

                ' replace all
                Dim oSrch As Object

                oSrch = oDoc.createReplaceDescriptor
                oSrch.setSearchString("nom")
                oSrch.setReplaceString(u7)
                Debug.Print(oDoc.replaceAll(oSrch))

                oSrch.setSearchString("dat")
                oSrch.setReplaceString(u1)
                Debug.Print(oDoc.replaceAll(oSrch))

                oSrch.setSearchString("org")
                oSrch.setReplaceString(ORG)
                Debug.Print(oDoc.replaceAll(oSrch))

                oSrch.setSearchString("Lich")
                oSrch.setReplaceString(u3)
                Debug.Print(oDoc.replaceAll(oSrch))

                oSrch.setSearchString("Luch2")
                oSrch.setReplaceString(u2)
                Debug.Print(oDoc.replaceAll(oSrch))

                oSrch.setSearchString("nam")
                oSrch.setReplaceString(u6)
                Debug.Print(oDoc.replaceAll(oSrch))

                oSrch.setSearchString("kol")
                oSrch.setReplaceString(u5)
                Debug.Print(oDoc.replaceAll(oSrch))

                oSrch.setSearchString("price")
                oSrch.setReplaceString(u4)
                Debug.Print(oDoc.replaceAll(oSrch))

                oSrch.setSearchString("cen")
                oSrch.setReplaceString(Fix((u4/1.18)*u5))
                Debug.Print(oDoc.replaceAll(oSrch))

            Case Else

                Dim Wrd As Application
                Dim WrdDc As Object
                Wrd = New Application

                WrdDc = Wrd.Documents.Open(tipot, , False)  'Application.
                WrdDc.Application.Visible = True

                Wrd.Selection.Find.ClearFormatting()
                Wrd.Selection.Find.Replacement.ClearFormatting()
                'Номер
                With Wrd.Selection.Find
                    .Text = "nom"
                    .Replacement.Text = u7
                    .Forward = True
                    .Wrap = WdFindWrap.wdFindContinue
                    .Format = False
                    .MatchCase = True
                    .MatchWholeWord = False
                    .MatchWildcards = False
                    ' .MatchSoundsLike = False
                    .MatchAllWordForms = False
                End With
                Wrd.Selection.Find.Execute(Replace := WdReplace.wdReplaceAll)

                With Wrd.Selection.Find
                    .Text = "dat"
                    .Replacement.Text = u1
                    .Forward = True
                    .Wrap = WdFindWrap.wdFindContinue
                    .Format = False
                    .MatchCase = True
                    .MatchWholeWord = False
                    .MatchWildcards = False
                    ' .MatchSoundsLike = False
                    .MatchAllWordForms = False
                End With
                Wrd.Selection.Find.Execute(Replace := WdReplace.wdReplaceAll)

                With Wrd.Selection.Find
                    .Text = "org"
                    .Replacement.Text = ORG
                    .Forward = True
                    .Wrap = WdFindWrap.wdFindContinue
                    .Format = False
                    .MatchCase = True
                    .MatchWholeWord = False
                    .MatchWildcards = False
                    ' .MatchSoundsLike = False
                    .MatchAllWordForms = False
                End With
                Wrd.Selection.Find.Execute(Replace := WdReplace.wdReplaceAll)

                With Wrd.Selection.Find
                    .Text = "Lich"
                    .Replacement.Text = u3
                    .Forward = True
                    .Wrap = WdFindWrap.wdFindContinue
                    .Format = False
                    .MatchCase = True
                    .MatchWholeWord = False
                    .MatchWildcards = False
                    ' .MatchSoundsLike = False
                    .MatchAllWordForms = False
                End With
                Wrd.Selection.Find.Execute(Replace := WdReplace.wdReplaceAll)

                With Wrd.Selection.Find
                    .Text = "Luch2"
                    .Replacement.Text = u2
                    .Forward = True
                    .Wrap = WdFindWrap.wdFindContinue
                    .Format = False
                    .MatchCase = True
                    .MatchWholeWord = False
                    .MatchWildcards = False
                    ' .MatchSoundsLike = False
                    .MatchAllWordForms = False
                End With
                Wrd.Selection.Find.Execute(Replace := WdReplace.wdReplaceAll)

                With Wrd.Selection.Find
                    .Text = "nam"
                    .Replacement.Text = u6
                    .Forward = True
                    .Wrap = WdFindWrap.wdFindContinue
                    .Format = False
                    .MatchCase = True
                    .MatchWholeWord = False
                    .MatchWildcards = False
                    ' .MatchSoundsLike = False
                    .MatchAllWordForms = False
                End With
                Wrd.Selection.Find.Execute(Replace := WdReplace.wdReplaceAll)

                With Wrd.Selection.Find
                    .Text = "kol"
                    .Replacement.Text = u5
                    .Forward = True
                    .Wrap = WdFindWrap.wdFindContinue
                    .Format = False
                    .MatchCase = True
                    .MatchWholeWord = False
                    .MatchWildcards = False
                    ' .MatchSoundsLike = False
                    .MatchAllWordForms = False
                End With
                Wrd.Selection.Find.Execute(Replace := WdReplace.wdReplaceAll)

                With Wrd.Selection.Find
                    .Text = "price"
                    .Replacement.Text = u4
                    .Forward = True
                    .Wrap = WdFindWrap.wdFindContinue
                    .Format = False
                    .MatchCase = True
                    .MatchWholeWord = False
                    .MatchWildcards = False
                    ' .MatchSoundsLike = False
                    .MatchAllWordForms = False
                End With
                Wrd.Selection.Find.Execute(Replace := WdReplace.wdReplaceAll)

                With Wrd.Selection.Find
                    .Text = "cen"
                    .Replacement.Text = Fix((u4/1.18)*u5)
                    .Forward = True
                    .Wrap = WdFindWrap.wdFindContinue
                    .Format = False
                    .MatchCase = True
                    .MatchWholeWord = False
                    .MatchWildcards = False
                    ' .MatchSoundsLike = False
                    .MatchAllWordForms = False
                End With
                Wrd.Selection.Find.Execute(Replace := WdReplace.wdReplaceAll)
                WrdDc = Nothing
                Wrd = Nothing

        End Select
    End Sub

    Private Sub btnTRadd_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnTRadd.Click


        frmTreb_Act_treb.EDTR = False

        frmTreb_Act_treb.txtNomer.Text = ""
        frmTreb_Act_treb.txtDate.Value = Date.Today
        frmTreb_Act_treb.cmbLich.Text = ""
        frmTreb_Act_treb.cmbLich2.Text = ""
        frmTreb_Act_treb.cmbTip.Text = ""
        frmTreb_Act_treb.txtPrice.Text = 0
        frmTreb_Act_treb.txtCokVo.Text = 0
        frmTreb_Act_treb.txtNodel.Text = ""

        frmTreb_Act_treb.ShowDialog(Me)
    End Sub

    Private Sub lvTREB_Click(ByVal sender As Object, ByVal e As EventArgs) Handles lvTREB.Click
        If lvTREB.Items.Count = 0 Then Exit Sub

        Dim z As Integer

        For z = 0 To lvTREB.SelectedItems.Count - 1
            dSID = (lvTREB.SelectedItems(z).Text)
        Next
    End Sub

    Private Sub lvTREB_DoubleClick(ByVal sender As Object, ByVal e As EventArgs) Handles lvTREB.DoubleClick
        If lvTREB.Items.Count = 0 Then Exit Sub

        frmTreb_Act_treb.EDTR = True

        frmTreb_Act_treb.sIDTR = dSID

        Dim rs As Recordset
        rs = New Recordset
        rs.Open("SELECT * FROM TrebOvanie WHERE id =" & dSID, DB7, CursorTypeEnum.adOpenDynamic,
                LockTypeEnum.adLockOptimistic)

        With rs

            frmTreb_Act_treb.txtNomer.Text = .Fields("Nomer").Value
            frmTreb_Act_treb.txtDate.Value = .Fields("dataSost").Value
            frmTreb_Act_treb.cmbLich.Text = .Fields("cherezkogo").Value
            frmTreb_Act_treb.cmbLich2.Text = .Fields("zatreboval").Value
            frmTreb_Act_treb.cmbTip.Text = .Fields("tiporgtex").Value
            frmTreb_Act_treb.txtPrice.Text = .Fields("cena").Value
            frmTreb_Act_treb.txtCokVo.Text = .Fields("kolich").Value
            frmTreb_Act_treb.txtNodel.Text = .Fields("model").Value

        End With
        rs.Close()
        rs = Nothing

        frmTreb_Act_treb.ShowDialog(Me)
    End Sub

    Private Sub lvTREB_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) _
        Handles lvTREB.SelectedIndexChanged
    End Sub

    Private Sub btnAVOSadd_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnAVOSadd.Click
        frmACT_OS_Act_treb.EDTR = False
        'frmACT_OS_Act_treb.EDTRs = 0
        Dim objIniFile As New IniFile(sLANGPATH)


        frmACT_OS_Act_treb.txt_akt_nomer.Text = ""
        frmACT_OS_Act_treb.txt_akt_tip.Text = ""
        frmACT_OS_Act_treb.txt_akt_cena.Text = ""
        frmACT_OS_Act_treb.txt_akt_nomer_prikaza.Text = ""
        frmACT_OS_Act_treb.txt_akt_data_prikaza.Value = Date.Today
        frmACT_OS_Act_treb.txt_akt_postavshik.Text = ""
        frmACT_OS_Act_treb.txt_akt_god_vipuska.Text = ""
        frmACT_OS_Act_treb.txt_akt_data_sostav.Value = Date.Today
        frmACT_OS_Act_treb.txt_akt_mod.Text = ""

        Call _
            SaveActivityToLogDB(
                objIniFile.GetString("frmAct_Treb", "MSG4", "Акты ввода основных средств - добавить") & " " &
                frmComputers.lstGroups.SelectedNode.Text)


        frmACT_OS_Act_treb.ShowDialog(Me)
    End Sub

    Private Sub lvACTVV_Click(ByVal sender As Object, ByVal e As EventArgs) Handles lvACTVV.Click
        If lvACTVV.Items.Count = 0 Then Exit Sub

        Dim z As Integer

        For z = 0 To lvACTVV.SelectedItems.Count - 1
            dSID = (lvACTVV.SelectedItems(z).Text)
        Next
    End Sub

    Private Sub lvACTVV_DoubleClick(ByVal sender As Object, ByVal e As EventArgs) Handles lvACTVV.DoubleClick
        If lvACTVV.Items.Count = 0 Then Exit Sub

        frmACT_OS_Act_treb.EDTR = True

        frmACT_OS_Act_treb.EDTRs = dSID

        Dim rs As Recordset
        rs = New Recordset
        rs.Open("SELECT * FROM ActOS WHERE id =" & dSID, DB7, CursorTypeEnum.adOpenDynamic,
                LockTypeEnum.adLockOptimistic)

        With rs

            frmACT_OS_Act_treb.txt_akt_nomer.Text = .Fields("Nomer").Value
            frmACT_OS_Act_treb.txt_akt_data_sostav.Value = .Fields("dataSost").Value
            frmACT_OS_Act_treb.txt_akt_tip.Text = .Fields("tiporgtex").Value
            frmACT_OS_Act_treb.txt_akt_cena.Text = .Fields("cena").Value
            frmACT_OS_Act_treb.txt_akt_nomer_prikaza.Text = .Fields("NomerPrikaza").Value
            frmACT_OS_Act_treb.txt_akt_data_prikaza.Value = .Fields("dataprikaza").Value
            frmACT_OS_Act_treb.txt_akt_postavshik.Text = .Fields("postavshik").Value
            frmACT_OS_Act_treb.txt_akt_god_vipuska.Text = .Fields("godVipuska").Value
            frmACT_OS_Act_treb.txt_akt_data_sostav.Value = .Fields("datasost").Value
            frmACT_OS_Act_treb.txt_akt_mod.Text = .Fields("modTexn").Value


        End With
        rs.Close()
        rs = Nothing

        frmACT_OS_Act_treb.ShowDialog(Me)
    End Sub

    Private Sub lvACTVV_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) _
        Handles lvACTVV.SelectedIndexChanged
    End Sub

    Private Sub TabPage2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles TabPage2.Click
    End Sub

    Private Sub btnAVOSdel_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnAVOSdel.Click
        If lvACTVV.Items.Count = 0 Then Exit Sub
        If dSID = 0 Then Exit Sub
        Dim objIniFile As New IniFile(sLANGPATH)

        If _
            MsgBox(objIniFile.GetString("frmAct_Treb", "MSG1", "Вы уверены что хотите удалить"), MsgBoxStyle.YesNo,
                   ProGramName) = MsgBoxResult.Yes Then
            Dim rs As Recordset
            rs = New Recordset
            rs.Open("DELETE FROM ActOS WHERE id =" & dSID, DB7, CursorTypeEnum.adOpenDynamic,
                    LockTypeEnum.adLockOptimistic)
            rs = Nothing

            Call ACTVV_LOAD()

        End If
    End Sub

    Private Sub btnTRdel_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnTRdel.Click
        If lvTREB.Items.Count = 0 Then Exit Sub
        If dSID = 0 Then Exit Sub
        Dim objIniFile As New IniFile(sLANGPATH)

        If _
            MsgBox(objIniFile.GetString("frmAct_Treb", "MSG1", "Вы уверены что хотите удалить"), MsgBoxStyle.YesNo,
                   ProGramName) = MsgBoxResult.Yes Then
            Dim rs As Recordset
            rs = New Recordset
            rs.Open("DELETE FROM TrebOvanie WHERE id =" & dSID, DB7, CursorTypeEnum.adOpenDynamic,
                    LockTypeEnum.adLockOptimistic)
            rs = Nothing

            Call TREB_LOAD()

        End If
    End Sub
End Class