Imports Microsoft.SqlServer.Server

Public Class main
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        hideSubmenu()
        Timer1.Enabled = True
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

    Private Sub Btn_sale_Click(sender As Object, e As EventArgs) Handles Btn_sale.Click
        showSubmenu(Panel_Sale)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Btn_detail.Click
        showSubmenu(Panel_Detail)
    End Sub

    'Sub switchPanel(panel As Form)
    '    Panel_ChidForm.Controls.Clear()
    '    panel.TopLevel = False
    '    Panel_ChidForm.Controls.Add(panel)
    '    panel.Show()


    'End Sub

    Private Sub Panel_ChidForm_Paint(sender As Object, e As PaintEventArgs)

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

    Private Sub Btn_import_Click(sender As Object, e As EventArgs) Handles Btn_import.Click
        openChidForm(New Form_import())

        hideSubmenu()
    End Sub

    Private Sub Btn_Product_Click(sender As Object, e As EventArgs) Handles Btn_Product.Click
        openChidForm(New Form_Product())

        hideSubmenu()
    End Sub

    Private Sub Btn_typeproduct_Click(sender As Object, e As EventArgs) Handles Btn_typeproduct.Click
        openChidForm(New Form_typeProduct())

        hideSubmenu()
    End Sub

    Private Sub Btn_Representative_Click(sender As Object, e As EventArgs) Handles Btn_Representative.Click
        openChidForm(New Form_Representative())

        hideSubmenu()
    End Sub

    Private Sub Btn_report_Click(sender As Object, e As EventArgs) Handles Btn_report.Click
        openChidForm(New Form_report())
    End Sub

    Private Sub Btn_miniSale_Click(sender As Object, e As EventArgs) Handles Btn_miniSale.Click
        openChidForm(New Form_miniSale())

        hideSubmenu()
    End Sub

    Private Sub Btn_wholeSale_Click(sender As Object, e As EventArgs) Handles Btn_wholeSale.Click
        openChidForm(New Form_wholesale())

        hideSubmenu()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label_Date.Text = Date.Now.ToString("dd MM yyy")
        Label_Time.Text = Date.Now.ToString("hh:mm:ss")

    End Sub


End Class