Public Class Main

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblOSInfo.Text = My.Computer.Info.OSFullName & " " & My.Computer.Info.OSVersion
    End Sub

    Dim ttlmemory, available, used, rate As Integer
    Dim cpu As Integer

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ttlmemory = My.Computer.Info.TotalPhysicalMemory / 1024 / 1024
        used = ttlmemory - (My.Computer.Info.AvailablePhysicalMemory / 1024 / 1024)
        lblUsed.Text = used & " MB"
        available = (My.Computer.Info.AvailablePhysicalMemory / 1024 / 1024)
        lblAvailable.Text = available & " MB"
        lblTotalMemory.Text = ttlmemory & " MB"
        cpu = PerformanceCounter1.NextValue
        lblProcessor.Text = cpu & " %"
        pgrsProcessor.Value = cpu
        rate = (used / ttlmemory) * 100
        lblMemory.Text = rate & " %"
        pgrMemory.Value = rate
        BunifuGauge1.Value = cpu
    End Sub
End Class
