Imports System
Imports System.Net
Imports System.IO
Imports System.String

Public Class Main_frm



    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        Dim ipentered As String = My.Settings.su_addr

        ' This is the IP address of the WeatherPi
        Dim sURL As String
        sURL = "http://" & ipentered & "/wthrdata.dat"

        Dim wrGETURL As WebRequest
        wrGETURL = WebRequest.Create(sURL)

        Dim objStream As Stream
        objStream = wrGETURL.GetResponse.GetResponseStream()

        Dim objReader As New StreamReader(objStream)
        Dim sLine As String = ""
        Dim webdata As String = ""
        Dim i As Integer = 0

        ' Sends a request to download the contents of "wthrdata.dat" from the WeatherPi web site 
        Do While Not sLine Is Nothing
            i += 1
            sLine = objReader.ReadLine
            If Not sLine Is Nothing Then
                Console.WriteLine("{0}:{1}", i, sLine)
                webdata = sLine
            End If
        Loop
        ' "webdata" now contains the contents of "wthrdata.dat"
        objReader.Close()
        wthrdata_txt.Text = webdata

        Dim hold As Integer
        ' Get Outdoor Temperature from the contents of "webdata" and display
        Dim ODtemp As String
        hold = Getcommas(0, webdata) ' The first piece of data is at "0" (The OutDoor Temperature)
        ODtemp = webdata.Substring((hold - 4), 4) ' Extract temperature from the data (Start index,length)
        ODtemp = (ODtemp * 1.8) + 32 ' Convert "C" to "F"
        ODtemp = FormatNumber(ODtemp, 1)
        temp_txt.Text = ODtemp + " F" ' Display in text box

        ' Get Humidity and display
        Dim humi As String
        hold = Getcommas(1, webdata) ' The Next piece of data is at "1" (Humidity)
        humi = webdata.Substring((hold - 4), 4) ' Extract wind speed from the data (starting index, length)
        humi_txt.Text = humi + " %" ' Display in text

        ' Get Indoor temperature and display
        Dim IDtemp As String
        hold = Getcommas(2, webdata) ' The Next piece of data is at "2" (The Indoor Temperature)
        IDtemp = webdata.Substring((hold - 4), 4) ' Extract temperature from the data (Start index,length)
        IDtemp = (IDtemp * 1.8) + 32 ' Convert "C" to "F"
        IDtemp = FormatNumber(IDtemp, 1)
        intemp_txt.Text = IDtemp + " F" ' Display in text box

        ' Get Humidity
        Dim press As String
        hold = Getcommas(3, webdata) ' The Next piece of data is at "3" (The barometric pressure)
        press = webdata.Substring((hold - 8), 8) ' Extract pressure from the data (starting index, length)
        press = (press / 33.863) / 100 ' Convert Hga to Inches
        press = FormatNumber(press, 2) ' Format pressure to display only 2 digits after the decimal point
        press_txt.Text = press + " In" ' Display in text

        ' Get wind speed 
        Dim wind As String
        hold = Getcommas(5, webdata) ' The Next piece of data is at "5" (The Wind Speed)
        wind = webdata.Substring((hold - 4), 4) ' Extract wind speed from the data (starting index, length)
        wind = wind * 0.62137119223733 ' Convert KPH to MPH
        wind = FormatNumber(wind, 1, TriState.False) ' Format wind speed to display 1 digit after the decimal point and eliminate the leading zero
        wind_txt.Text = wind + " Mph" ' Display in text

        ' Get wind gust
        Dim wg As String
        hold = Getcommas(6, webdata) ' The Next piece of data is at "6" (The Wind Gust Speed)
        wg = webdata.Substring((hold - 4), 4) ' Extract Wind Gust speed from the data (starting index, length)
        wg = wg * 0.62137119223733 ' Convert KPH to MPH
        wg = FormatNumber(wg, 1, TriState.False) ' Format Wind Gust speed to display 1 digit after the decimal point and eliminate the leading zero
        wg_txt.Text = wg + " Mph" ' Display in text

        ' Get wind direction
        Dim dir As String
        hold = Getcommas(7, webdata) ' The Next piece of data is at "7" (The Wind direction)
        dir = webdata.Substring((hold - 5), 5) ' Extract Wind direction from the data (starting index, length)
        dir = GetWdir(dir)  ' Take the number that represents the direction and turn it into a word (North, South etc)
        wdir_lbl.Text = dir ' Display in text

        ' Get time
        Dim tim As String
        hold = Getcommas(16, webdata) ' The Next piece of data is at "16" (The time)
        tim = webdata.Substring((hold - 8), 8) ' Extract time from the data (starting index, length)
        time_txt.Text = tim ' Display in text


    End Sub
    ' Returns an index number that represents the Nth comma in the "wtrhdata.dat" string
    Function Getcommas(ByVal x As Integer,
                   ByVal y As String)

        Dim rtnval As Integer = 0
        Dim nxtcmma As Integer = 0
        Dim cmmas As Integer = 0

        For cmmas = 0 To x
            nxtcmma = y.IndexOf(",", (rtnval + 1))
            nxtcmma = nxtcmma - rtnval
            rtnval = rtnval + nxtcmma
        Next
        Return rtnval
    End Function
    ' Take the number that represents the wind direction and return a word (North, South etc)
    Function GetWdir(ByVal zz As String)
        If zz >= 0 And zz < 22 Then
            Return ("North")

        ElseIf zz >= 22 And zz < 45 Then
            Return ("North North East")

        ElseIf zz >= 45 And zz < 67 Then
            Return ("North East")

        ElseIf zz >= 67 And zz < 90 Then
            Return ("East North East")

        ElseIf zz >= 90 And zz < 112 Then
            Return ("East")

        ElseIf zz >= 112 And zz < 135 Then
            Return ("East South East")

        ElseIf zz >= 135 And zz < 157 Then
            Return ("South East")

        ElseIf zz >= 157 And zz < 180 Then
            Return ("South South East")

        ElseIf zz >= 180 And zz < 202 Then
            Return ("South")

        ElseIf zz >= 202 And zz < 225 Then
            Return ("South South West")

        ElseIf zz >= 225 And zz < 247 Then
            Return ("South West")

        ElseIf zz >= 247 And zz < 270 Then
            Return ("West South West")

        ElseIf zz >= 270 And zz < 292 Then
            Return ("West")

        ElseIf zz >= 292 And zz < 315 Then
            Return ("West North West")

        ElseIf zz >= 315 And zz < 337 Then
            Return ("North West")

        ElseIf zz >= 337 And zz < 359 Then
            Return ("North North West")
        Else
            Return ("Unknown")
        End If

    End Function


    Private Sub Main_frm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        MessageBox.Show("WeatherClient Version 1.0" & vbCrLf & vbCrLf & "Copyright 2017 Bubbles" & vbCrLf & "all rights reserved", "About", MessageBoxButtons.OK)
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub SetupToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SetupToolStripMenuItem.Click
        Timer1.Stop()
        Dim setupbox = New Form2()
        setupbox.Show()
    End Sub
    ' When form 1 gets activated start timer
    Private Sub Form1_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        Timer1.Start()
    End Sub
End Class
