Imports System.Windows.Forms

Public Class WaterMark

    Private Const EM_SETCUEBANNER As Integer = &H1501
    Private Const CB_SETCUEBANNER As Integer = &H1703

#Region "ComboBox_SetCueBannerText"

    ''' <summary>
    ''' Sets the cue banner text that is displayed for the edit control of a combo box.
    ''' </summary>
    ''' <param name="oComboBox">ComboBox control.</param>
    ''' <param name="szText">Cue banner text.</param>
    Public Shared Sub ComboBox_SetCueBannerText(ByVal oComboBox As ComboBox, _
                                                ByVal szText As String)

        SendMessage(oComboBox.Handle, CB_SETCUEBANNER, True, szText)

    End Sub

    ''' <summary>
    ''' Sets the cue banner text that is displayed for the edit control of a combo box.
    ''' </summary>
    ''' <param name="hWndComboBox">hWnd of ComboBox control.</param>
    ''' <param name="szText">Cue banner text.</param>
    Public Shared Sub ComboBox_SetCueBannerText(ByVal hWndComboBox As Long, _
                                                ByVal szText As String)

        SendMessage(hWndComboBox, CB_SETCUEBANNER, True, szText)

    End Sub

    ''' <summary>
    ''' Sets the cue banner text that is displayed for the edit control of a combo box.
    ''' </summary>
    ''' <param name="ptrComboBox">Handle of ComboBox control.</param>
    ''' <param name="szText">Cue banner text.</param>
    Public Shared Sub ComboBox_SetCueBannerText(ByVal ptrComboBox As IntPtr, _
                                                ByVal szText As String)

        SendMessage(ptrComboBox, CB_SETCUEBANNER, True, szText)

    End Sub

#End Region

    ''' <summary>
    '''  Sets the text that is displayed as the textual cue for an edit control.
    ''' </summary>
    ''' <param name="oTextBox">TextBox control.</param>
    ''' <param name="fHideOnKeyOnly">If true, the cue banner text hides only on first key down on edit.</param>
    ''' <param name="szText">Cue banner text.</param>
    Public Shared Sub Edit_SetCueBannerTextFocused(ByVal oTextBox As TextBox, _
                                                   ByVal fHideOnKeyOnly As Boolean, _
                                                   ByVal szText As String)

        SendMessage(oTextBox.Handle, EM_SETCUEBANNER, fHideOnKeyOnly, szText)

    End Sub

    ''' <summary>
    '''  Sets the text that is displayed as the textual cue for an edit control.
    ''' </summary>
    ''' <param name="hWndTextBox">hWnd of TextBox control.</param>
    ''' <param name="fHideOnKeyOnly">If true, the cue banner text hides only on first key down on edit.</param>
    ''' <param name="szText">Cue banner text.</param>
    Public Shared Sub Edit_SetCueBannerTextFocused(ByVal hWndTextBox As Long, _
                                                   ByVal fHideOnKeyOnly As Boolean, _
                                                   ByVal szText As String)

        SendMessage(hWndTextBox, EM_SETCUEBANNER, fHideOnKeyOnly, szText)

    End Sub

    ''' <summary>
    '''  Sets the text that is displayed as the textual cue for an edit control.
    ''' </summary>
    ''' <param name="ptrTextBox">Handle of TextBox control.</param>
    ''' <param name="fHideOnKeyOnly">If true, the cue banner text hides only on first key down on edit.</param>
    ''' <param name="szText">Cue banner text.</param>
    Public Shared Sub Edit_SetCueBannerTextFocused(ByVal ptrTextBox As IntPtr, _
                                                   ByVal fHideOnKeyOnly As Boolean, _
                                                   ByVal szText As String)

        SendMessage(ptrTextBox, EM_SETCUEBANNER, fHideOnKeyOnly, szText)

    End Sub

End Class
