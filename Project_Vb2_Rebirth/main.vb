Imports Microsoft.SqlServer.Server

Public Class main
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        hideSubmenu()
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

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'switchPanel(Form_miniSale)
        openChidForm(New Form_miniSale())

        hideSubmenu()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        openChidForm(New Form_wholesale())

        hideSubmenu()
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
End Class