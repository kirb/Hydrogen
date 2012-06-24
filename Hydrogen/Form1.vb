Imports Hydrogen.Dwm
Imports Hydrogen.WinApi
'Imports Hydrogen.NcRender
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports System.Runtime.InteropServices
Imports System.Diagnostics
Imports System.Drawing.Drawing2D

Public Class formMain
#Region "Macros"
    Public Shared Function LoWord(ByVal dwValue As Integer) As Integer
        Return dwValue And &HFFFF
    End Function
    Public Shared Function HiWord(ByVal dwValue As Integer) As Integer
        Return (dwValue >> 16) And &HFFFF
    End Function
#End Region
#Region "Aero"
    Dim dwmMargins As MARGINS
    Dim marginOk As Boolean = False

    'adapted from http://codeproject.com/script/Articles/ListAlternatives.aspx?aid=44235
    'Protected Overloads Overrides Sub WndProc(ByRef m As Message)
    '    If hasAero() Then
    '        Dim WM_NCCALCSIZE As Integer = &H83
    '        Dim WM_NCHITTEST As Integer = &H84
    '        Dim result As IntPtr

    '        Dim dwmHandled As Integer = Dwm.DwmDefWindowProc(m.HWnd, m.Msg, _
    '                                    m.WParam, m.LParam, result)

    '        If dwmHandled = 1 Then
    '            m.Result = result
    '            Exit Sub
    '        End If

    '        If m.Msg = WM_NCCALCSIZE AndAlso CInt(m.WParam) = 1 Then
    '            Dim nccsp As NCCALCSIZE_PARAMS = _
    '              DirectCast(Marshal.PtrToStructure(m.LParam, _
    '              GetType(NCCALCSIZE_PARAMS)), NCCALCSIZE_PARAMS)

    '            ' Adjust (shrink) the client rectangle to accommodate the border:
    '            nccsp.rect0.Top += 0
    '            nccsp.rect0.Bottom += 0
    '            nccsp.rect0.Left += 0
    '            nccsp.rect0.Right += 0

    '            If Not marginOk Then
    '                'Set what client area would be for passing to DwmExtendIntoClientArea
    '                dwmMargins.cyTopHeight = nccsp.rect2.Top - nccsp.rect1.Top
    '                dwmMargins.cxLeftWidth = nccsp.rect2.Left - nccsp.rect1.Left
    '                dwmMargins.cyBottomHeight = nccsp.rect1.Bottom - nccsp.rect2.Bottom
    '                dwmMargins.cxRightWidth = nccsp.rect1.Right - nccsp.rect2.Right
    '                marginOk = True
    '            End If

    '            Marshal.StructureToPtr(nccsp, m.LParam, False)

    '            m.Result = IntPtr.Zero
    '        ElseIf m.Msg = WM_NCHITTEST AndAlso CInt(m.Result) = 0 Then
    '            m.Result = HitTestNCA(m.HWnd, m.WParam, m.LParam)
    '        Else
    '            MyBase.WndProc(m)
    '        End If
    '    End If
    'End Sub

    'Private Function HitTestNCA(ByVal hwnd As IntPtr, ByVal wparam _
    '                                  As IntPtr, ByVal lparam As IntPtr) As IntPtr
    '    Dim HTNOWHERE As Integer = 0
    '    Dim HTCLIENT As Integer = 1
    '    Dim HTCAPTION As Integer = 2
    '    Dim HTGROWBOX As Integer = 4
    '    Dim HTSIZE As Integer = HTGROWBOX
    '    Dim HTMINBUTTON As Integer = 8
    '    Dim HTMAXBUTTON As Integer = 9
    '    Dim HTLEFT As Integer = 42 '10
    '    Dim HTRIGHT As Integer = 11
    '    Dim HTTOP As Integer = 12
    '    Dim HTTOPLEFT As Integer = 13
    '    Dim HTTOPRIGHT As Integer = 14
    '    Dim HTBOTTOM As Integer = 15
    '    Dim HTBOTTOMLEFT As Integer = 16
    '    Dim HTBOTTOMRIGHT As Integer = 17
    '    Dim HTREDUCE As Integer = HTMINBUTTON
    '    Dim HTZOOM As Integer = HTMAXBUTTON
    '    Dim HTSIZEFIRST As Integer = HTLEFT
    '    Dim HTSIZELAST As Integer = HTBOTTOMRIGHT

    '    Dim p As New Point(LoWord(CInt(lparam)), HiWord(CInt(lparam)))

    '    Dim topleft As Rectangle = RectangleToScreen(New Rectangle(0, 0, _
    '                               dwmMargins.cxLeftWidth, dwmMargins.cxLeftWidth))

    '    If topleft.Contains(p) Then
    '        Return New IntPtr(HTTOPLEFT)
    '    End If

    '    Dim topright As Rectangle = _
    '      RectangleToScreen(New Rectangle(Width - dwmMargins.cxRightWidth, 0, _
    '      dwmMargins.cxRightWidth, dwmMargins.cxRightWidth))

    '    If topright.Contains(p) Then
    '        Return New IntPtr(HTTOPRIGHT)
    '    End If

    '    Dim botleft As Rectangle = _
    '       RectangleToScreen(New Rectangle(0, Height - dwmMargins.cyBottomHeight, _
    '       dwmMargins.cxLeftWidth, dwmMargins.cyBottomHeight))

    '    If botleft.Contains(p) Then
    '        Return New IntPtr(HTBOTTOMLEFT)
    '    End If

    '    Dim botright As Rectangle = _
    '        RectangleToScreen(New Rectangle(Width - dwmMargins.cxRightWidth, _
    '        Height - dwmMargins.cyBottomHeight, _
    '        dwmMargins.cxRightWidth, dwmMargins.cyBottomHeight))

    '    If botright.Contains(p) Then
    '        Return New IntPtr(HTBOTTOMRIGHT)
    '    End If

    '    Dim top As Rectangle = _
    '        RectangleToScreen(New Rectangle(0, 0, Width, dwmMargins.cxLeftWidth))

    '    If top.Contains(p) Then
    '        Return New IntPtr(HTTOP)
    '    End If

    '    Dim cap As Rectangle = _
    '        RectangleToScreen(New Rectangle(0, dwmMargins.cxLeftWidth, _
    '        Width, dwmMargins.cyTopHeight - dwmMargins.cxLeftWidth))

    '    If cap.Contains(p) Then
    '        Return New IntPtr(HTCAPTION)
    '    End If

    '    Dim left As Rectangle = _
    '        RectangleToScreen(New Rectangle(0, 0, dwmMargins.cxLeftWidth, Height))

    '    If left.Contains(p) Then
    '        Return New IntPtr(HTLEFT)
    '    End If

    '    Dim right As Rectangle = _
    '        RectangleToScreen(New Rectangle(Width - dwmMargins.cxRightWidth, _
    '        0, dwmMargins.cxRightWidth, Height))

    '    If right.Contains(p) Then
    '        Return New IntPtr(HTRIGHT)
    '    End If

    '    Dim bottom As Rectangle = _
    '        RectangleToScreen(New Rectangle(0, Height - dwmMargins.cyBottomHeight, _
    '        Width, dwmMargins.cyBottomHeight))

    '    If bottom.Contains(p) Then
    '        Return New IntPtr(HTBOTTOM)
    '    End If

    '    Return New IntPtr(HTCLIENT)
    'End Function

    Public Sub New()
        SetStyle(ControlStyles.ResizeRedraw, True)
        dwmMargins.cyTopHeight = 26 '32
        dwmMargins.cyBottomHeight = 20
        dwmMargins.cxLeftWidth = 0 '24
        dwmMargins.cxRightWidth = 0
        InitializeComponent()
    End Sub

    'from http://pinvoke.net/default.aspx/dwmapi/DwmIsCompositionEnabled.html
    Private Function hasAero() As Boolean
        If Environment.OSVersion.Version.Major < 6 Then Return False
        hasAero = False
        Dwm.DwmIsCompositionEnabled(hasAero)
    End Function

    Private Sub formMain_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
        'textboxAddress.BackColor = Color.Transparent
        tableToolbar.SetColumnSpan(textboxAddress, 2)
        If hasAero() Then
            Dwm.DwmExtendFrameIntoClientArea(Me.Handle, dwmMargins)
            e.Graphics.Clear(Color.Transparent)
            Me.BackColor = Color.Magenta
            tableToolbar.BackColor = Color.Magenta
            progressStatus.BackColor = Color.Magenta
            panelStatus.BackColor = Color.Magenta
            Me.TransparencyKey = Color.Magenta
            'Dim blur As DWM_BLURBEHIND
            'blur.fEnable = True
            'blur.dwFlags = DWM_BB_ENABLE
            'blur.fEnable = True
            'blur.hRgnBlur = Nothing
            'Dwm.DwmEnableBlurBehindWindow(Me.Handle, blur)
        Else
            'tableToolbar.SetColumnSpan(textboxAddress, 2)
            e.Graphics.Clear(Color.FromArgb(&HC2, &HD9, &HF7))
            'labelName.Visible = False
        End If
    End Sub
#End Region

    Private Sub formMain_Load() Handles MyBase.Load
        Me.Top = My.Settings.LastY
        Me.Left = My.Settings.LastX
        Me.Width = My.Settings.LastW
        Me.Height = My.Settings.LastH
        If My.Application.CommandLineArgs.Count > 0 Then
            Go(My.Application.CommandLineArgs(0))
        End If
        webkitBrowser.Focus()
        webkitBrowser.UserAgent &= " Safari/533+ Hydrogen/0.1"
    End Sub

    Private Sub formMain_Move() Handles Me.Move
        My.Settings.LastY = Me.Top
        My.Settings.LastX = Me.Left
        My.Settings.LastW = Me.Width
        My.Settings.LastH = Me.Height
    End Sub

    Private Sub formMain_Resize() Handles Me.Resize
        formMain_Move()
    End Sub

    Private Sub Go(ByVal url As String)
        If url.IndexOf("http://") <> 0 And url.IndexOf("https://") <> 0 And url.IndexOf("javascript:") <> 0 And url.IndexOf("file://") <> 0 And url.IndexOf(":") <> 1 Then
            url = "http://" & url
        End If
        webkitBrowser.Navigate(url)
    End Sub

    Private Sub textboxAddress_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles textboxAddress.KeyPress
        If e.KeyChar = vbCr Or e.KeyChar = vbLf Or e.KeyChar = vbCrLf Then
            Go(textboxAddress.Text)
            webkitBrowser.Focus()
        End If
    End Sub

    Private Sub webkitBrowser_Navigating() Handles webkitBrowser.Navigating
        webkitbrowser_LocationChanged()
        progressStatus.Visible = True
    End Sub

    Private Sub webkitBrowser_Navigated() Handles webkitBrowser.Navigated
        webkitBrowser_LocationChanged()
        progressStatus.Visible = False
    End Sub

    Private Sub webkitBrowser_LocationChanged() Handles webkitBrowser.LocationChanged
        Try
            textboxAddress.Text = webkitBrowser.Url.ToString()
        Catch
        End Try
    End Sub

    Private Sub webkitBrowser_DocumentCompleted() Handles webkitBrowser.DocumentCompleted
        webkitBrowser_LocationChanged()
    End Sub

    Private Sub textboxAddress_Enter() Handles textboxAddress.Enter
        textboxAddress.SelectAll()
    End Sub

    'Private Sub webkitBrowser_NewWindow(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles webkitBrowser.NewWindow
    '    Dim info As ProcessStartInfo = New ProcessStartInfo
    '    info.FileName = Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase
    '    info.Arguments = webkitBrowser.Url.ToString() 'XXX: WTF, I can't get the link just clicked? Need to work that out.
    '    Process.Start(info)
    '    e.Cancel = True
    'End Sub
End Class
