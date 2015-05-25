Imports System.IO
Imports Microsoft.Office.Interop.Word

Public Class frmSclad_treb
    Private Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnVipiska.Click


        On Error GoTo Error_
        Dim uname As String
        Dim slength As Long
        Dim Q As String
        Dim dmy As Date
        Dim oragn As String
        Dim tipot As String
        'On Error Resume Next

        tipot = Directory.GetParent(System.Windows.Forms.Application.ExecutablePath).ToString & "/blanks/tr2.dot"

        Dim CONFIGURE As Recordset
        CONFIGURE = New Recordset
        CONFIGURE.Open("SELECT * FROM CONFIGURE", DB7, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)

        With CONFIGURE
            oragn = .Fields("org").Value
        End With

        CONFIGURE.Close()
        CONFIGURE = Nothing


        Dim rscount As Recordset 'Объявляем рекордсет
        rscount = New Recordset
        rscount.Open("SELECT COUNT(*) AS total_number FROM TrebOvanie", DB7, CursorTypeEnum.adOpenDynamic,
                     LockTypeEnum.adLockOptimistic)

        Dim nNumb As String
        With rscount
            nNumb = .Fields("total_number").Value
        End With

        rscount.Close()
        rscount = Nothing


        If nNumb = 0 Then nNumb = "1"

        If Len(txtNom.Text) = 0 Then txtNom.Text = nNumb + 101

        uname = Me.Combo1.Text

        If Len(Me.Combo1.Text) = 0 Then
            uname = 0
        Else


            Dim BASECOMP As Recordset
            BASECOMP = New Recordset
            BASECOMP.Open("SELECT NET_NAME,filial,mesto,id FROM kompy", DB7, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)


            With BASECOMP
                .MoveFirst()
                Do While Not .EOF
                    If _
                        uname =
                        .Fields("NET_NAME").Value & " (" & .Fields("filial").Value & "/" & .Fields("mesto").Value & ")" &
                        " № " & .Fields("id").Value Then
                        uname = .Fields("id").Value
                    End If
                    .MoveNext()
                    'DoEvents
                Loop

            End With
            BASECOMP.Close()
            BASECOMP = Nothing


            Dim rs As Recordset
            rs = New Recordset
            rs.Open("SELECT * FROM TrebOvanie", DB7, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)

            With rs
                .AddNew()
                .Fields("Nomer").Value = txtNom.Text
                .Fields("dataSost").Value = Date.Today
                .Fields("otdel").Value = Combo3.Text
                .Fields("computer").Value = uname
                .Fields("cherezkogo").Value = cmbLich.Text
                .Fields("zatreboval").Value = cmbLich2.Text
                .Fields("tiporgtex").Value = frmSclad.MOD1
                .Fields("cena").Value = frmSclad.cf1
                .Fields("kolich").Value = txtkol.Text
                .Fields("model").Value = frmSclad.MOD2
                .Fields("Filial").Value = Combo2.Text
                .Update()
            End With

            rs.Close()
            rs = Nothing

        End If


        Select sOfficePACK

            Case "OpenOffice.org"

                'В опенОфис
                '########################

                Dim oSM As Object                 'Root object for accessing OpenOffice FROM VB
                Dim oDesk, oDoc As Object 'First objects FROM the API
                Dim arg(- 1) As Object                 'Ignore it for the moment !
                Dim mmerge As Object
                Dim objCoreReflection As Object ' objects from OOo API 

                'Instanciate OOo : this line is mandatory with VB for OOo API
                oSM = CreateObject("com.sun.star.ServiceManager")
                'Create the first and most important service
                objCoreReflection = oSM.createInstance("com.sun.star.reflection.CoreReflection")

                oDesk = oSM.createInstance("com.sun.star.frame.Desktop")
                'Create a new doc

                oDoc = oDesk.loadComponentFromURL("file:///" & tipot, "_blank", 0, arg)

                ' jon code
                Dim objText As Object, objCursor As Object
                objText = oDoc.GetText
                objCursor = objText.createTextCursor

                ' replace all
                Dim oSrch As Object
                'Set oSrch = oDoc.createSearchDescriptor
                oSrch = oDoc.createReplaceDescriptor
                oSrch.setSearchString("nom")
                oSrch.setReplaceString(Me.txtNom.Text)
                Debug.Print(oDoc.replaceAll(oSrch))

                oSrch.setSearchString("datsost")
                oSrch.setReplaceString(Date.Today)
                Debug.Print(oDoc.replaceAll(oSrch))

                oSrch.setSearchString("org")
                oSrch.setReplaceString(oragn)
                Debug.Print(oDoc.replaceAll(oSrch))

                oSrch.setSearchString("Lic1")
                oSrch.setReplaceString(Me.cmbLich.Text)
                Debug.Print(oDoc.replaceAll(oSrch))

                oSrch.setSearchString("Lic2")
                oSrch.setReplaceString(Me.cmbLich2.Text)
                Debug.Print(oDoc.replaceAll(oSrch))

                oSrch.setSearchString("kol")
                oSrch.setReplaceString(Me.txtkol.Text)
                Debug.Print(oDoc.replaceAll(oSrch))

                oSrch.setSearchString("pol")
                oSrch.setReplaceString(Me.Combo3.Text)
                Debug.Print(oDoc.replaceAll(oSrch))

                oSrch.setSearchString("otpr")
                oSrch.setReplaceString(frmSclad.otd1)
                Debug.Print(oDoc.replaceAll(oSrch))

                oSrch.setSearchString("otp")
                oSrch.setReplaceString(Me.txtkol.Text)
                Debug.Print(oDoc.replaceAll(oSrch))

                oSrch.setSearchString("ot1p")
                oSrch.setReplaceString(Me.Text1.Text)
                Debug.Print(oDoc.replaceAll(oSrch))

                oSrch.setSearchString("po1l")
                oSrch.setReplaceString(Me.Text2.Text)
                Debug.Print(oDoc.replaceAll(oSrch))


                Dim ASD As String
                oSrch.setSearchString("price")
                If Len(frmSclad.cf1) <> 0 Then
                    ASD = Fix(frmSclad.cf1*1.18)
                    oSrch.setReplaceString(ASD)
                Else
                    oSrch.setReplaceString("")
                End If
                Debug.Print(oDoc.replaceAll(oSrch))

                oSrch.setSearchString("Cen_free")
                oSrch.setReplaceString(frmSclad.cf1*Me.txtkol.Text)
                Debug.Print(oDoc.replaceAll(oSrch))

                oSrch.setSearchString("Lic3")
                oSrch.setReplaceString(frmSclad.nam1 & "-" & frmSclad.MOD2)
                Debug.Print(oDoc.replaceAll(oSrch))

                '########################################################################

            Case Else

                Dim Wrd As Application
                Dim WrdDc As Document
                Wrd = New Application

                Dim oDoc As Document
                Dim oTable As Table
                Dim oPara1 As Paragraph, oPara2 As Paragraph
                Dim oPara3 As Paragraph, oPara4 As Paragraph
                Dim oRng As Range
                Dim oShape As InlineShape
                Dim oChart As Object
                Dim Pos As Double

                WrdDc = Wrd.Documents.Open(tipot, , False)  'Application.
                WrdDc.Application.Visible = True

                Wrd.Selection.Find.ClearFormatting()
                Wrd.Selection.Find.Replacement.ClearFormatting()

                With Wrd.Selection.Find
                    .Text = "nom"
                    .Replacement.Text = Me.txtNom.Text
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
                    .Text = "datsost"
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
                Wrd.Selection.Find.Execute(Replace := WdReplace.wdReplaceAll)

                With Wrd.Selection.Find
                    .Text = "org"
                    .Replacement.Text = oragn
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
                    .Text = "Lic1"
                    .Replacement.Text = Me.cmbLich.Text
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
                    .Text = "Lic2"
                    .Replacement.Text = Me.cmbLich2.Text
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
                    .Replacement.Text = Me.txtkol.Text
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
                    .Text = "pol"
                    .Replacement.Text = Me.Combo3.Text
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
                    .Text = "otpr"
                    .Replacement.Text = frmSclad.otd1
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
                    .Text = "otp"
                    .Replacement.Text = Me.txtkol.Text
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
                    .Text = "ot1p"
                    .Replacement.Text = Me.Text1.Text
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
                    .Text = "po1l"
                    .Replacement.Text = Me.Text2.Text
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

        End Select


        Dim Sclad As Recordset
        Sclad = New Recordset
        Sclad.Open("SELECT * FROM Sclad where number =" & frmSclad.scCOUNT, DB7, CursorTypeEnum.adOpenDynamic,
                   LockTypeEnum.adLockOptimistic)

        With Sclad
            '.Edit
            .Fields("ostalos").Value = frmSclad.KOL - Me.txtkol.Text
            .Update()
        End With

        Sclad.Close()
        Sclad = Nothing

        Call frmSclad.Load_SCLAD3()

        Me.Close()

        Exit Sub
        Error_:
        MsgBox(Err.Description)
    End Sub

    Private Sub Button2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub frmSclad_treb_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load

        SendFonts(Me)

        Call LANG_frmSclad_treb()

        FillComboNET(Me.cmbLich, "Name", "SPR_OTV", "", False, True)
        FillComboNET(Me.cmbLich2, "Name", "SPR_OTV", "", False, True)
        FillComboNET(Me.cmbLich3, "Name", "SPR_OTV", "", False, True)

        Dim rs As Recordset
        rs = New Recordset
        rs.Open("SELECT TipTehn,NET_NAME,filial,mesto,id FROM kompy", DB7, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)

        FillComboNET(Me.Combo2, "filial", "SPR_FILIAL", "", False, True)

        Combo1.Items.Clear()

        With rs
            .MoveFirst()
            Do While Not .EOF
                If _
                    .Fields("TipTehn").Value = "Printer" Or .Fields("TipTehn").Value = "PC" Or
                    .Fields("TipTehn").Value = "KOpir" Or .Fields("TipTehn").Value = "MFU" Then
                    Combo1.Items.Add(
                        .Fields("NET_NAME").Value & " (" & .Fields("filial").Value & "/" & .Fields("mesto").Value & ")" &
                        " № " & .Fields("id").Value)
                Else
                End If
                .MoveNext()
                'DoEvents
            Loop
        End With
        rs.Close()
        rs = Nothing
    End Sub

    Private Sub Combo2_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) _
        Handles Combo2.SelectedIndexChanged
        Dim rs As New Recordset 'Объявляем рекордсет
        Dim sSQL As String 'Переменная, где будет размещён SQL запрос

        sSQL = "SELECT * FROM SPR_OTD_FILIAL WHERE Filial='" & Combo2.Text & "' ORDER BY N_Otd"
        rs.Open(sSQL, DB7, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)

        On Error GoTo Error_
        Combo3.Items.Clear()

        With rs
            .MoveFirst()
            Do While Not .EOF

                Combo3.Items.Add(.Fields("N_Otd").Value)

                .MoveNext()
                'DoEvents
            Loop

        End With

        rs.Close()
        rs = Nothing

        Error_:
    End Sub
End Class