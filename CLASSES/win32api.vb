Module Win32Api

    Declare Auto Function SendMessage Lib "user32.dll" (ByVal hWnd As IntPtr, ByVal msg As Integer, ByVal wParam As IntPtr, ByVal lParam As IntPtr) As IntPtr
    Declare Auto Function SendMessage Lib "user32.dll" (ByVal hWnd As IntPtr, ByVal msg As Integer, ByVal wParam As Integer, ByVal lParam As Integer) As IntPtr
    Declare Auto Function SendMessage Lib "user32.dll" (ByVal hWnd As IntPtr, ByVal msg As Integer, ByVal wParam As IntPtr, ByVal lParam As String) As IntPtr
    Declare Auto Function SendMessage Lib "user32.dll" (ByVal hWnd As IntPtr, ByVal msg As Integer, ByVal wParam As Boolean, ByVal lParam As String) As IntPtr
    Declare Auto Function SendMessage Lib "user32.dll" (ByVal hWnd As Long, ByVal msg As Integer, ByVal wParam As Boolean, ByVal lParam As String) As IntPtr

End Module