Imports System.IO

Public NotInheritable Class frmAbout
    Private Sub frmAbout_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load


        SendFonts(Me)

        ' Установить заголовок формы.
        Dim ApplicationTitle As String
        If My.Application.Info.Title <> "" Then
            ApplicationTitle = My.Application.Info.ProductName
        Else
            ApplicationTitle = Path.GetFileNameWithoutExtension(My.Application.Info.AssemblyName)
        End If
        Me.Text = String.Format("О программе {0}", ApplicationTitle)
        ' Инициализировать текст, отображаемый в окне "О программе".
        ' TODO: настроить сведения о сборке приложения в области "Приложение" диалогового окна 
        '    свойств проекта (в меню "Проект").

        If unamDB = "MS Access" Then

            Me.LabelProductName.Text = My.Application.Info.ProductName & " - " & unamDB & " - " & Base_Name

        Else

            Me.LabelProductName.Text = My.Application.Info.ProductName & " - " & unamDB & " - " & DBtabl

        End If


        Me.LabelCopyright.Text = My.Application.Info.Copyright
        Me.LabelCompanyName.Text = "Squee&Dragon"


        Dim sStr As String
        Dim sStr2 As String

        If frmMain.FileMenu.Text <> "Настройки" Then

            Me.LabelVersion.Text = String.Format("Ver: {0}", My.Application.Info.Version.ToString)
            sStr = "Данная программа распространяется на условиях лицензии GNU GPL v2. " & vbNewLine & vbNewLine &
                "Dannaja programma sozdavalas' dlja oblegchenija truda sistemnyh administratorov munitsipal'nyh i bjudzhetnyh uchrezhdenij i organizatsij. Konechno ja prekrasno ponimaju, chto jeto ne shedevr, no ne sudite strogo, ja zanimajus' jetim ne professional'no - iskljuchitel'no v svobodnoe ot raboty vremja. V programme ne iskljucheny oshibki, no ja starajus' ispravljat' ih srazu zhe, kak tol'ko poluchaju Vashi soobshhenija o najdennyh oshibkah. Programma byla, est' i budet besplatnoj na protjazhenii vsej svoej zhizni, i esli kto-to Vam budet pytat'sja ee prodat', soobshhite mne ob jetom. S Uvazheniem Plotnikov Aleksej"
            sStr2 =
                "Penin Maksim Sergeevich, Vladimir Jur'evich aka VIP_Graff (Ufa), Aleksej Kiseljov, ServeRAID, Anton Belousov, Evgenij Panin, Evgen V Krukovich, Alik Trakhtman, DIMM, XXX, Romirez, Sergej Gorevoj, VAD, Kamenev V.A, Karpuhin Pavel, Matsishin Igor' Ivanovich, yuronnchik, Aleksej Kazakov, Aleksej Agapov, Konstantin (OK Dagomys), Vitaly A. Che, Pan'kov Aleksej Viktorovich (Bank Juniastrum), Jurij Fedotov, Vladislav aka VladokZzz, Sazanov Dmitrij (Rich), Vlad Sineok (quad), Klop, nick(Har'kov,Ukraina) . I drugim ljudjam kotorye vol'no ili ne vol'no prinimali uchastie v sozdanii programmy"

            Me.TextBoxDescription.Text = sStr & vbCrLf & vbCrLf & "Otdel'nye spasibby:" & vbCrLf & vbCrLf & sStr2
        Else


            Me.LabelVersion.Text = String.Format("Версия {0}", My.Application.Info.Version.ToString)
            sStr = "Данная программа распространяется на условиях лицензии GNU GPL v2." & vbNewLine & vbNewLine &
                "Данная программа создавалась для облегчения труда системных администраторов муниципальных и бюджетных учреждений и организаций. Конечно я прекрасно понимаю, что это не шедевр, но не судите строго, я занимаюсь этим не профессионально - исключительно в свободное от работы время. В программе не исключены ошибки, но я стараюсь исправлять их сразу же, как только получаю Ваши сообщения о найденных ошибках. Программа была, есть и будет бесплатной на протяжении всей своей жизни, и если кто-то Вам будет пытаться ее продать, сообщите мне об этом. С Уважением Плотников Алексей"
            sStr2 =
                "Пенин Максим Сергеевич, Владимир Юрьевич aka VIP_Graff (Уфа), Алексей Киселёв, ServeRAID, Антон Белоусов, Евгений Панин, Evgen V Krukovich, Alik Trakhtman, DIMM, XXX, Romirez, Сергей Горевой, VAD, Каменев В.А, Карпухин Павел, Мацишин Игорь Иванович, yuronnchik, Алексей Казаков, Алексей Агапов, Константин (ОК Дагомыс), Vitaly A. Che, Паньков Алексей Викторович (Банк Юниаструм), Юрий Федотов, Владислав aka VlаdоkZzz, Сазанов Дмитрий (Rich), Влад Синеок (quad), Klop, nick(Харьков,Украина) . И другим людям которые вольно или не вольно принимали участие в создании программы"


            Me.TextBoxDescription.Text = sStr & vbCrLf & vbCrLf & "Отдельные спасиббы:" & vbCrLf & vbCrLf & sStr2
        End If
    End Sub

    Private Sub OKButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles OKButton.Click
        Me.Close()
    End Sub

    Private Sub TextBoxDescription_TextChanged(ByVal sender As Object, ByVal e As EventArgs) _
        Handles TextBoxDescription.TextChanged
    End Sub
End Class
