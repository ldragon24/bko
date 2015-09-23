Public Class frmCartr
    Public rCOUNT As Decimal
    Public zCOUNT As Decimal


    Private Sub RESIZER()

        If SplitContainer1.SplitterDistance > 700 Then SplitContainer1.SplitterDistance = 700
        If SplitContainer1.SplitterDistance < 600 Then SplitContainer1.SplitterDistance = 600


        LVCart.Height = SplitContainer1.Panel1.Height - 100
        LVCart.Width = SplitContainer1.Panel1.Width '- 10

        lvCartZAP.Height = SplitContainer1.Panel2.Height - 100
        lvCartZAP.Width = SplitContainer1.Panel2.Width '- 10
        'lvCartZAP

        btnCartAdd.Top = SplitContainer1.Panel1.Height - 50
        btnCartDel.Top = SplitContainer1.Panel1.Height - 50

        btnZapAdd.Top = SplitContainer1.Panel2.Height - 50
        btnZapDel.Top = SplitContainer1.Panel2.Height - 50
        btnZapReport.Top = SplitContainer1.Panel2.Height - 50

        txtMonth.Top = SplitContainer1.Panel2.Height - 52
        lblSum.Top = SplitContainer1.Panel2.Height - 52
        lblSum2.Top = SplitContainer1.Panel2.Height - 52

    End Sub

    Public Sub Zap_load()

        Dim zCOUNT As Integer

        Dim sSQL1 As String
        Dim sSQL As String

        On Error GoTo Error_
        Dim uname As Long
        lvCartZAP.Items.Clear()

        If LVCart.Items.Count = 0 Then Exit Sub

        Dim z As Integer
        ' Dim rCOUNT As Integer
        For z = 0 To LVCart.SelectedItems.Count - 1
            rCOUNT = (LVCart.SelectedItems(z).Text)
        Next




        Dim rs1 As ADODB.Recordset
        sSQL1 = "SELECT * FROM CARTRIDG WHERE ID=" & rCOUNT
        rs1 = New ADODB.Recordset
        rs1.Open(sSQL1, DB7, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)

        With rs1
            If .Fields("Spisan").Value = False Or .Fields("Spisan").Value = 0 Then
                'A.Icon = 20
                'A.SmallIcon = 20
                btnZapAdd.Enabled = True
                btnZapDel.Enabled = True
            Else
                'A.Icon = 22
                'A.SmallIcon = 22
                btnZapAdd.Enabled = False
                btnZapDel.Enabled = False
            End If

        End With
        rs1.Close()
        rs1 = Nothing

        Dim rs As ADODB.Recordset
        sSQL = "SELECT COUNT(*) AS total_number FROM CARTRIDG_Z"
        rs = New ADODB.Recordset
        rs.Open(sSQL, DB7, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)

        With rs
            zCOUNT = .Fields("total_number").Value
        End With
        rs.Close()
        rs = Nothing

        If zCOUNT > 0 Then

            rs = New ADODB.Recordset
            rs.Open("SELECT * FROM CARTRIDG_Z WHERE ID_C=" & rCOUNT & " ORDER BY DATAZAP DESC", DB7, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)

            Dim intCount As Decimal = 0

            With rs
                .MoveFirst()
                Do While Not .EOF

                    If .Fields("ID_C").Value = rCOUNT Then

                        lvCartZAP.Items.Add(.Fields("id").Value) 'col no. 1

                        If Not IsDBNull(.Fields("Z_N").Value) Then
                            lvCartZAP.Items(CInt(intCount)).SubItems.Add(.Fields("Z_N").Value)
                        Else
                            lvCartZAP.Items(CInt(intCount)).SubItems.Add("")
                        End If

                        If Not IsDBNull(.Fields("datazap").Value) Then
                            lvCartZAP.Items(CInt(intCount)).SubItems.Add(.Fields("datazap").Value)
                        Else
                            lvCartZAP.Items(CInt(intCount)).SubItems.Add("")
                        End If

                        If Not IsDBNull(.Fields("VOST").Value) Then

                            If .Fields("VOST").Value = False Then
                                lvCartZAP.Items(CInt(intCount)).SubItems.Add("Заправлен")
                            Else
                                lvCartZAP.Items(CInt(intCount)).SubItems.Add("Востановлен")
                            End If

                        Else

                            lvCartZAP.Items(CInt(intCount)).SubItems.Add("")

                        End If

                        If Not IsDBNull(.Fields("STOIM").Value) Then
                            lvCartZAP.Items(CInt(intCount)).SubItems.Add(.Fields("STOIM").Value)
                        Else
                            lvCartZAP.Items(CInt(intCount)).SubItems.Add("")
                        End If

                        intCount = intCount + 1

                        
                    End If
                    .MoveNext()
                    'DoEvents
                Loop

            End With





            rs.Close()
            rs = Nothing


        End If


        ResList(Me.lvCartZAP)
        'CARTRIDG_Z.Close
        Exit Sub
Error_:
        Debug.Print(Err.Description)
    End Sub

    Public Sub Load_C()

        On Error GoTo Error_

        LVCart.Items.Clear()

        Dim CARTRIDG As ADODB.Recordset
        CARTRIDG = New ADODB.Recordset
        CARTRIDG.Open("SELECT * FROM CARTRIDG", DB7, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)

        'Dim CARTRIDG_Z As ADODB.Recordset
        'CARTRIDG_Z = New ADODB.Recordset
        'CARTRIDG_Z.Open("SELECT * FROM CARTRIDG_Z", DB7, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)

        'Dim PROYZV As ADODB.Recordset
        'PROYZV = New ADODB.Recordset
        'PROYZV.Open("SELECT * FROM SPR_PROIZV", DB7, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)

        Dim intCount As Decimal = 0

        With CARTRIDG
            If .RecordCount <> 0 Then
                .MoveFirst()
                Do While Not .EOF


                    LVCart.Items.Add(.Fields("id").Value) 'col no. 1
                    Dim unam1 As Long

                    If Not IsDBNull(.Fields("Model").Value) Then unam1 = .Fields("Model").Value

                    If Len(unam1) = 0 Then unam1 = 1

                    Dim CARTR As ADODB.Recordset
                    CARTR = New ADODB.Recordset
                    CARTR.Open("SELECT * FROM spr_cart where id =" & unam1, DB7, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)

                    With CARTR
                        .MoveFirst()
                        Do While Not .EOF
                            If unam1 = .Fields("ID").Value Then

                                If Not IsDBNull(.Fields("name").Value) Then
                                    LVCart.Items(CInt(intCount)).SubItems.Add(.Fields("name").Value)
                                Else
                                    LVCart.Items(CInt(intCount)).SubItems.Add("")
                                End If

                            End If
                            .MoveNext()

                        Loop
                    End With

                    CARTR.Close()
                    CARTR = Nothing

                    If Not IsDBNull(.Fields("SN").Value) Then
                        LVCart.Items(CInt(intCount)).SubItems.Add(.Fields("SN").Value)
                    Else
                        LVCart.Items(CInt(intCount)).SubItems.Add("")
                    End If

                    If Not IsDBNull(.Fields("data").Value) Then
                        LVCart.Items(CInt(intCount)).SubItems.Add(.Fields("data").Value)
                    Else
                        LVCart.Items(CInt(intCount)).SubItems.Add("")
                    End If

                    Dim uname As String
                    If Not IsDBNull(.Fields("USTR").Value) Then uname = .Fields("USTR").Value


                    Dim rs As ADODB.Recordset
                    rs = New ADODB.Recordset
                    rs.Open("SELECT * FROM kompy where id =" & uname, DB7, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)

                    With rs
                        If uname = "0" Then
                        Else
                            .MoveFirst()
                            Do While Not .EOF
                                If uname = .Fields("ID").Value Then

                                    If Not IsDBNull(.Fields("printer_name_1").Value) Then
                                        LVCart.Items(CInt(intCount)).SubItems.Add(.Fields("printer_name_1").Value)
                                    Else
                                        LVCart.Items(CInt(intCount)).SubItems.Add("")
                                    End If

                                    If Not IsDBNull(.Fields("filial").Value) Then
                                        LVCart.Items(CInt(intCount)).SubItems.Add(.Fields("filial").Value)
                                    Else
                                        LVCart.Items(CInt(intCount)).SubItems.Add("")
                                    End If

                                    If Not IsDBNull(.Fields("mesto").Value) Then
                                        LVCart.Items(CInt(intCount)).SubItems.Add(.Fields("mesto").Value)
                                    Else
                                        LVCart.Items(CInt(intCount)).SubItems.Add("")
                                    End If

                                    If Not IsDBNull(.Fields("OTvetstvennyj").Value) Then
                                        LVCart.Items(CInt(intCount)).SubItems.Add(.Fields("OTvetstvennyj").Value)
                                    Else
                                        LVCart.Items(CInt(intCount)).SubItems.Add("")
                                    End If


                                End If
                                .MoveNext()
                                'DoEvents
                            Loop

                        End If
                    End With
                    rs.Close()
                    rs = Nothing

                    If Not IsDBNull(.Fields("prim").Value) Then
                        LVCart.Items(CInt(intCount)).SubItems.Add(.Fields("prim").Value)
                    Else
                        LVCart.Items(CInt(intCount)).SubItems.Add("")
                    End If


                    intCount = intCount + 1

                    'Spisan
                    'If .Fields("Spisan").Value = False Or .Fields("Spisan").Value = 0 Then
                    'A.Icon = 19
                    'A.SmallIcon = 19
                    ''XPbuscar1.Enabled = True
                    ''XPbuscar2.Enabled = True
                    'Else
                    'A.Icon = 20
                    'A.SmallIcon = 20
                    ''XPbuscar1.Enabled = False
                    ''XPbuscar2.Enabled = False
                    'End If

                    .MoveNext()
                    'DoEvents
                Loop
            End If
        End With

        CARTRIDG.Close()
        CARTRIDG = Nothing
        ResList(Me.LVCart)
        'ListViewRavn frmCart.LVCart, frmCart




        Exit Sub
Error_:
        Debug.Print(Err.Description)
    End Sub

    Private Sub frmCartr_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        frmMain.SaveInfTehButton.Enabled = False
        frmMain.ToolStripDropDownButton1.Enabled = False
    End Sub

    Private Sub frmCartr_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Call frmCartr_Lang()

        Call Load_C()

    End Sub

    Private Sub SplitContainer1_Move(ByVal sender As Object, ByVal e As System.EventArgs) Handles SplitContainer1.Move
        Call RESIZER()
    End Sub

    Private Sub SplitContainer1_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles SplitContainer1.Resize
        Call RESIZER()
    End Sub

    Private Sub SplitContainer1_SplitterMoved(ByVal sender As Object, ByVal e As System.Windows.Forms.SplitterEventArgs) Handles SplitContainer1.SplitterMoved
        Call RESIZER()
    End Sub

    Private Sub frmCartr_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        Call RESIZER()
    End Sub

    Private Sub LVCart_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles LVCart.Click
        Call Zap_load()
    End Sub


    Private Sub btnZapReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnZapReport.Click
        Dim rs As ADODB.Recordset
        rs = New ADODB.Recordset

        Dim Coun1 As Long

        Dim rscount As ADODB.Recordset 'Объявляем рекордсет
        rscount = New ADODB.Recordset
        rscount.Open("SELECT COUNT(*) AS total_number FROM CARTRIDG_Z", DB7, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)

        With rscount
            Coun1 = .Fields("total_number").Value
        End With

        rscount.Close()
        rscount = Nothing


        If Coun1 > 0 Then

            Dim objServiceManager, objDesktop As Object 'root objects from OOo API 
            Dim objCoreReflection, objDocument As Object ' objects from OOo API 
            Dim objText, objCursor As Object ' objects from OOo API 
            Dim objTable As Object ' objects from OOo API 
            Dim objRows, objRow As Object ' objects from OOo API 
            ' Dim objTextFrame, objSize As Object ' objects from OOo API 
            ' Dim objFrameText, objFrameTextCursor As Object ' objects from OOo API 

            objServiceManager = CreateObject("com.sun.star.ServiceManager")
            'Create the CoreReflection service that is later used to create structs 
            objCoreReflection = objServiceManager.createInstance("com.sun.star.reflection.CoreReflection")
            'Create the Desktop 
            objDesktop = objServiceManager.createInstance("com.sun.star.frame.Desktop")
            'Open a new empty writer document 
            Dim args(-1) As Object '<-- initializing the array with a -1 
            'Dim args(4) As Object 'a Visual Basic array 
            'args(0) = MakePropertyValue("ReadOnly", True) 
            ''args(1) = MakePropertyValue("Password", "secret") 
            'args(1) = MakePropertyValue("hidden", False) 
            'args(2) = MakePropertyValue("Buttons", False) 
            'args(3) = MakePropertyValue("Overwrite", False) 
            objDocument = objDesktop.loadComponentFromURL("private:factory/swriter", "_blank", 0, args)

            objText = objDocument.getText
            objCursor = objText.createTextCursor


            ' replace all

            objText.insertControlCharacter(objCursor, 0, False)
            objText.insertString(objCursor, "Заправка картриджей" & vbLf, False)

            objTable = objDocument.createInstance("com.sun.star.text.TextTable")
            objTable.Initialize(Coun1 + 1, 5)


            'Insert the table
            objText.insertControlCharacter(objCursor, 0, False)
            objText.insertTextContent(objCursor, objTable, False)

            'Get first row
            objRows = objTable.GetRows
            objRow = objRows.getByIndex(0)

            'Set the table background color
            objTable.setPropertyValue("BackTransparent", True)
            objTable.setPropertyValue("BackColor", 16777215)

            'Формируем заголовок
            insertIntoCell("A1", "Порядковый номер", objTable)
            insertIntoCell("B1", "Дата заправки", objTable)
            insertIntoCell("C1", "Модель картриджа", objTable)
            insertIntoCell("D1", "Восстановлен", objTable)
            insertIntoCell("E1", "Место установки", objTable)


            rscount = New ADODB.Recordset
            rscount.Open("SELECT * FROM CARTRIDG_Z", DB7, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)

            Dim intj As Decimal

            Dim A, b, c, d, e1 As String
            intj = 2
            With rscount
                .MoveFirst()
                Do While Not .EOF = True

                    A = "A" & intj
                    insertIntoCell(A, .Fields("id"), objTable)
                    B = "B" & intj
                    insertIntoCell(B, .Fields("DATAZAP"), objTable)
                    c = "C" & intj

                    Dim uname As Long
                    Dim uname1 As String
                    Dim uname2 As Long
                    Dim FF As String
                    Dim mm As String

                    uname = .Fields("ID_C").Value


                    'Dim rs As ADODB.Recordset 'Объявляем рекордсет
                    rs = New ADODB.Recordset
                    rs.Open("SELECT model, ustr FROM CARTRIDG WHERE id =" & uname, DB7, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
                    With rs
                        uname = .Fields("model").Value
                        uname2 = .Fields("ustr").Value

                    End With
                    rs.Close()
                    rs = Nothing

                    rs = New ADODB.Recordset
                    rs.Open("SELECT name FROM spr_cart WHERE id =" & uname, DB7, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
                    With rs
                        uname1 = .Fields("name").Value
                    End With
                    rs.Close()
                    rs = Nothing

                    insertIntoCell(c, uname1, objTable)
                    d = "D" & intj


                    If .Fields("VOST").Value = False Or .Fields("VOST").Value = 0 Then
                        uname1 = "Нет"
                    Else
                        uname1 = "Да"
                    End If
                    insertIntoCell(d, uname1, objTable)

                    If uname2 = 0 Or Len(uname2) = 0 Then

                    Else
                        rs = New ADODB.Recordset
                        rs.Open("SELECT filial, mesto FROM kompy WHERE id =" & uname2, DB7, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
                        With rs
                            FF = .Fields("filial").Value
                            mm = .Fields("mesto").Value
                        End With
                        rs.Close()
                        rs = Nothing

                    End If


                    e1 = "E" & intj
                    insertIntoCell(e1, FF & "/" & mm, objTable)
                    FF = ""
                    mm = ""


                    intj = intj + 1

                    .MoveNext()
                Loop
            End With
            rscount.Close()
            rscount = Nothing


            objText.insertControlCharacter(objCursor, 0, False)

        End If



    End Sub

    Private Sub LVCart_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles LVCart.DoubleClick
        Dim z As Integer

        'Dim rCOUNT As String

        For z = 0 To LVCart.SelectedItems.Count - 1
            rCOUNT = (LVCart.SelectedItems(z).Text)
        Next

        LOAD_CRR(rCOUNT)
    End Sub

    Public Sub LOAD_CRR(ByVal sSId As String)

        Dim uname As String
        'Dim sSId As String

        'On Error GoTo Error_
        On Error Resume Next

        Dim CARTRIDG As ADODB.Recordset
        CARTRIDG = New ADODB.Recordset
        CARTRIDG.Open("SELECT * FROM CARTRIDG WHERE id =" & sSId, DB7, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)

        With CARTRIDG

            frmCartr_ADD.EDTRCART = True
            frmCartr_ADD.lblRealNumber.Text = .Fields("id").Value
            If Not IsDBNull(.Fields("SN").Value) Then frmCartr_ADD.txtSerNumb.Text = .Fields("SN").Value
            uname = .Fields("Proizv").Value

            Dim PROYZV As ADODB.Recordset
            PROYZV = New ADODB.Recordset
            PROYZV.Open("SELECT * FROM SPR_PROIZV WHERE id=" & uname, DB7, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
            With PROYZV
                frmCartr_ADD.cmbProizv.Text = .Fields("Proizv").Value
            End With
            PROYZV.Close()
            PROYZV = Nothing


            If Not IsDBNull(.Fields("TIP").Value) Then frmCartr_ADD.cmbTipC.Text = .Fields("TIP").Value
            Dim zaname As Long

            zaname = .Fields("Model").Value

            Dim CARTR As ADODB.Recordset
            CARTR = New ADODB.Recordset
            CARTR.Open("SELECT * FROM spr_cart WHERE id=" & zaname, DB7, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)

            With CARTR
                frmCartr_ADD.cmbModC.Text = .Fields("name").Value
            End With

            CARTR.Close()
            CARTR = Nothing

            If Not IsDBNull(.Fields("USTR").Value) Then uname = .Fields("USTR").Value

            If uname = 0 Then
            Else
                Dim rs As ADODB.Recordset
                rs = New ADODB.Recordset
                rs.Open("SELECT * FROM kompy WHERE id=" & uname, DB7, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)

                With rs
                    frmCartr_ADD.cmbSostUstr.Text = .Fields("PRINTER_NAME_1").Value & " (" & .Fields("filial").Value & "/" & .Fields("mesto").Value & ")" & " № " & .Fields("id").Value
                End With

                rs.Close()
                rs = Nothing

            End If

            uname = 0
            If Not IsDBNull(.Fields("PROD")) Then uname = .Fields("PROD").Value

            If uname = 0 Then
            Else
                Dim Postav As ADODB.Recordset
                Postav = New ADODB.Recordset
                Postav.Open("SELECT * FROM SPR_Postav WHERE id=" & uname, DB7, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)

                With Postav
                    If Not IsDBNull(.Fields("Name").Value) Then
                        frmCartr_ADD.cmbSaler.Text = .Fields("Name").Value
                    Else
                        frmCartr_ADD.cmbSaler.Text = ""

                    End If

                End With

                Postav.Close()
                Postav = Nothing

            End If

            frmCartr_ADD.txtSaleNumb.Text = .Fields("SCHET").Value
            frmCartr_ADD.txtCashe.Text = .Fields("Cena").Value
            frmCartr_ADD.dtSale.Text = .Fields("data").Value

            Select Case .Fields("NZap").Value

                Case True
                    frmCartr_ADD.chkNezap.Checked = 1
                Case False
                    frmCartr_ADD.chkNezap.Checked = 0

                Case 1
                    frmCartr_ADD.chkNezap.Checked = 1
                Case 0
                    frmCartr_ADD.chkNezap.Checked = 0
            End Select


            Select Case .Fields("NeZap").Value

                Case True
                    frmCartr_ADD.chkNZ.Checked = 1
                Case False
                    frmCartr_ADD.chkNZ.Checked = 0

                Case 1
                    frmCartr_ADD.chkNZ.Checked = 1
                Case 0
                    frmCartr_ADD.chkNZ.Checked = 0
            End Select


            Select Case .Fields("Iznos").Value

                Case True
                    frmCartr_ADD.chkIznos.Checked = 1
                Case False
                    frmCartr_ADD.chkIznos.Checked = 0

                Case 1
                    frmCartr_ADD.chkIznos.Checked = 1
                Case 0
                    frmCartr_ADD.chkIznos.Checked = 0
            End Select

            Select Case .Fields("Spisan").Value

                Case True
                    frmCartr_ADD.chkSPS.Checked = 1
                Case False
                    frmCartr_ADD.chkSPS.Checked = 0

                Case 1
                    frmCartr_ADD.chkSPS.Checked = 1
                Case 0
                    frmCartr_ADD.chkSPS.Checked = 0
            End Select

            Select Case .Fields("NaSpisanie").Value

                Case True
                    frmCartr_ADD.chkNaSP.Checked = 1
                Case False
                    frmCartr_ADD.chkNaSP.Checked = 0

                Case 1
                    frmCartr_ADD.chkNaSP.Checked = 1
                Case 0
                    frmCartr_ADD.chkNaSP.Checked = 0
            End Select

            If Not IsDBNull(.Fields("PRIM").Value) Then frmCartr_ADD.txtMemo.Text = .Fields("PRIM").Value
            frmCartr_ADD.EDTIDTr = .Fields("id").Value

        End With

        frmCartr_ADD.ShowDialog(Me)

        Exit Sub
Error_:
        'frmCartr_ADD.Show(vbModal)
        MsgBox(Err.Description)
    End Sub

    Private Sub LVCart_MouseWheel(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles LVCart.MouseWheel

    End Sub

    Private Sub LVCart_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LVCart.SelectedIndexChanged

    End Sub

    Private Sub btnCartAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCartAdd.Click
        frmCartr_ADD.EDTRCART = False
        frmCartr_ADD.chkNaSP.Checked = 0
        frmCartr_ADD.chkSPS.Checked = 0
        frmCartr_ADD.chkIznos.Checked = 0
        frmCartr_ADD.chkNZ.Checked = 0
        frmCartr_ADD.chkNezap.Checked = 0
        frmCartr_ADD.txtCashe.Text = ""
        frmCartr_ADD.txtSaleNumb.Text = ""
        frmCartr_ADD.cmbSaler.Text = ""
        frmCartr_ADD.cmbSostUstr.Text = ""
        frmCartr_ADD.cmbModC.Text = ""
        frmCartr_ADD.cmbTipC.Text = ""
        frmCartr_ADD.cmbProizv.Text = ""
        frmCartr_ADD.txtSerNumb.Text = ""
        frmCartr_ADD.lblRealNumber.Text = ""
        frmCartr_ADD.txtMemo.Text = ""
        frmCartr_ADD.dtSale.Value = Date.Today

        frmCartr_ADD.ShowDialog(Me)
    End Sub

    Private Sub DateTimePicker1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub txtMonth_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtMonth.ValueChanged

        Dim uname As Long
        Dim uname1 As String
        Dim umonth As String
        Dim smonth As String
        Dim syear As String

        uname = 0
        Dim rs As ADODB.Recordset
        rs = New ADODB.Recordset
        rs.Open("UPDATE CARTRIDG_Z SET STOIM='0' WHERE STOIM=' '", DB7, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
        rs = Nothing


        umonth = txtMonth.Value

        If Len(umonth) = 1 Then umonth = "0" & umonth
        Dim strAnimals As String
        Dim iCounter As Integer
        Dim arrAnimals() As String


        On Error GoTo Error_
        Dim rs1 As ADODB.Recordset
        rs1 = New ADODB.Recordset
        rs1.Open("SELECT STOIM, DATAZAP FROM CARTRIDG_Z", DB7, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)

        With rs1
            .MoveFirst()
            Do While Not .EOF

                strAnimals = .Fields("DATAZAP").Value
                arrAnimals = Split(strAnimals, ".")

                For iCounter = LBound(arrAnimals) To UBound(arrAnimals)
                    smonth = arrAnimals(1)
                    syear = arrAnimals(2)
                Next

                If smonth = umonth And syear = Date.Today.Year Then

                    uname1 = .Fields("STOIM").Value

                    If Len(uname1) <> 0 Then

                        uname = (uname + Val(uname1))

                    End If
                End If

                .MoveNext()
            Loop
        End With

        rs1.Close()
        rs1 = Nothing

        'FilePathName
        lblSum.Text = "Потрачено на заправку в"
        lblSum2.Text = "месяце" & ": " & uname & " " & "руб."

        Exit Sub
Error_:
        lblSum.Text = "Потрачено на заправку в"
        lblSum2.Text = "месяце" & ": " & uname & " " & "руб."
        'MsgBox(Err.Description)
    End Sub

    Private Sub btnZapAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnZapAdd.Click
        If LVCart.Items.Count = 0 Then Exit Sub

        Dim z As Integer
        'Dim rCOUNT As Integer

        For z = 0 To LVCart.SelectedItems.Count - 1
            rCOUNT = (LVCart.SelectedItems(z).Text)
        Next

        If rCOUNT = 0 Then Exit Sub

        Dim C As Control

        For Each C In frmCartr_Add_Zap.Controls
            If TypeOf C Is TextBox Then C.Text = ""
            If TypeOf C Is ComboBox Then C.Text = ""
        Next C

        C = Nothing

        frmCartr_Add_Zap.EDTRCARTZ = False
        frmCartr_Add_Zap.ShowDialog(Me)



    End Sub

    Private Sub lvCartZAP_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lvCartZAP.DoubleClick
        If lvCartZAP.Items.Count = 0 Then Exit Sub

        Dim z As Integer

        For z = 0 To lvCartZAP.SelectedItems.Count - 1
            zCOUNT = (lvCartZAP.SelectedItems(z).Text)
        Next

        frmCartr_Add_Zap.EDTRCARTZ = True

        Dim rs As ADODB.Recordset
        rs = New ADODB.Recordset

        rs.Open("SELECT * FROM CARTRIDG_Z where id=" & zCOUNT, DB7, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)


        With rs
            frmCartr_Add_Zap.lblRealNumber.Text = .Fields("Z_N").Value
            'frmCartr_Add_Zap.cmbPost.Text = .Fields("Z_N").Value
            frmCartr_Add_Zap.txtAvR.Text = .Fields("AKTVR").Value
            frmCartr_Add_Zap.txtCashe.Text = .Fields("STOIM").Value
            frmCartr_Add_Zap.txtPage.Text = .Fields("Paper").Value
            frmCartr_Add_Zap.chkRef.Checked = .Fields("VOST").Value
            frmCartr_Add_Zap.dtAvR.Value = .Fields("DATAAKT").Value
            frmCartr_Add_Zap.dtDateZ.Value = .Fields("DATAZAP").Value
            Dim rs1 As ADODB.Recordset
            rs1 = New ADODB.Recordset
            rs1.Open("SELECT * FROM SPR_Postav WHERE ID=" & .Fields("SC").Value, DB7, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
            With rs1
                frmCartr_Add_Zap.cmbPost.Text = .Fields("Name").Value
            End With
            rs1.Close()
            rs1 = Nothing

        End With

        rs.Close()
        rs = Nothing

        frmCartr_Add_Zap.ShowDialog(Me)

    End Sub

    Private Sub lvCartZAP_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lvCartZAP.SelectedIndexChanged
       
    End Sub

    Private Sub LVCart_SizeChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles LVCart.SizeChanged

    End Sub
End Class