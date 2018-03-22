
Imports TELib
Imports System.Windows.Forms
Imports VB = Microsoft.VisualBasic
Imports ListControls
Imports System.Math
Imports System.Threading
Imports System
Imports System.IO
Imports LdzCStation
Imports System.Net.Sockets
Imports System.Net
Imports System.Text
Imports System.Data.OleDb  'Therrasim Librarite e OLEDB
Imports ADODB
Public Class Form1
    Private Declare Function CreateCompatibleDC Lib "GDI32" (ByVal hDC As Integer) As Integer
    Private Declare Function csdsdsd Lib "GDI32" () As Integer

    Private Declare Function CreateCompatibleBitmap Lib "GDI32" (ByVal hDC As Integer, ByVal nWidth As Integer, ByVal nHeight As Integer) As Integer
    Private Declare Function SelectObject Lib "GDI32" (ByVal hDC As Integer, ByVal hObject As Integer) As Integer
    Private Declare Function BitBlt Lib "GDI32" (ByVal srchDC As Integer, ByVal srcX As Integer, ByVal srcY As Integer, ByVal srcW As Integer, ByVal srcH As Integer, ByVal desthDC As Integer, ByVal destX As Integer, ByVal destY As Integer, ByVal op As Integer) As Integer
    Private Declare Function DeleteDC Lib "GDI32" (ByVal hDC As Integer) As Integer
    Private Declare Function DeleteObject Lib "GDI32" (ByVal hObj As Integer) As Integer
    Declare Function GetDC Lib "user32" Alias "GetDC" (ByVal hwnd As Integer) As Integer
    Const SRCCOPY As Integer = &HCC0020

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim hDC, hMDC As Integer
        Dim hBMP, hBMPOld As Integer
        Dim sw, sh As Integer


        hDC = GetDC(0) '获取当前屏幕句柄
        hMDC = CreateCompatibleDC(hDC) '创建与屏幕兼容的内存

        sw = Screen.PrimaryScreen.Bounds.Width
        sh = Screen.PrimaryScreen.Bounds.Height


        hBMP = CreateCompatibleBitmap(hDC, sw, sh) '//下面建立一个与屏幕显示兼容的位图，


        hBMPOld = SelectObject(hMDC, hBMP) '//只有选入了位图的内存显示设备才有地方绘图，画到指定的位图上
        BitBlt(hMDC, 0, 0, sw, sh, hDC, 0, 0, SRCCOPY) ' 把图画进hMDC

        hBMP = SelectObject(hMDC, hBMPOld)  '双缓冲技术  

        PictureBox1.Image = Image.FromHbitmap(New IntPtr(hBMP)) 'hBMP位最后图像   hBMPOld为中间图像
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
