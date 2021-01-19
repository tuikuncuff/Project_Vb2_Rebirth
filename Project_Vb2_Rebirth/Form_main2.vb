Public Class Form_main2
    Private Sub Btn_wholeSale2_Click(sender As Object, e As EventArgs) Handles Btn_wholeSale2.Click
        openChidForm(New Form_wholesale())

        hideSubmenu()
    End Sub

    Private Sub Btn_miniSale2_Click(sender As Object, e As EventArgs) Handles Btn_miniSale2.Click
        openChidForm(New Form_miniSale())

        hideSubmenu()
    End Sub

    Private currentForm As Form = Nothing
    Private Sub openChidForm(chidForm As Form)
        If currentForm IsNot Nothing Then currentForm.Close()
        currentForm = chidForm
        chidForm.TopLevel = False
        chidForm.FormBorderStyle = FormBorderStyle.None
        chidForm.Dock = DockStyle.Fill
        Panel_ChidForm.Controls.Add(chidForm)
        Panel_ChidForm.Tag = chidForm
        chidForm.BringToFront()
        chidForm.Show()
    End Sub

    Private Sub hideSubmenu()
        Panel_Sale.Visible = False
        Panel_Detail.Visible = False
    End Sub
    Private Sub showSubmenu(submenu As Panel)
        If submenu.Visible = False Then
            hideSubmenu()
            submenu.Visible = True
        Else
            submenu.Visible = False
        End If
    End Sub

    Private Sub Form_main2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        hideSubmenu()
        Timer1.Enabled = True

    End Sub

    Private Sub Btn_sale_Click(sender As Object, e As EventArgs) Handles Btn_sale.Click
        showSubmenu(Panel_Sale())
    End Sub

    Private Sub Btn_report_Click(sender As Object, e As EventArgs) Handles Btn_report.Click
        openChidForm(New Form_report())
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label_Date.Text = Date.Now.ToString("dd MM yyy")
        Label_Time.Text = Date.Now.ToString("hh:mm:ss")
    End Sub
End Class