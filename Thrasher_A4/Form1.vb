Imports System.Security.Cryptography.X509Certificates
'Olivia Thrasher
'Assignment A4
'GUI Dev
Public Class Form1
    Public Sub FormBurger_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    'Turns on Select Button & Meat picture
    Public Sub ButtonMeat_Click(sender As Object, e As EventArgs) Handles ButtonMeat.Click
        PicMeat.Visible = True
        PicVeggie.Visible = False
        ButtonSelect.Enabled = True
    End Sub

    'Turns on Veggie Picture & turns off meat picture
    Public Sub ButtonVeggie_Click(sender As Object, e As EventArgs) Handles ButtonVeggie.Click
        PicVeggie.Visible = True
        PicMeat.Visible = False
        ButtonSelect.Enabled = True
    End Sub
    'Some text becomes visible, meat and veggie buttons are disabled
    Public Sub ButtonSelect_Click(sender As Object, e As EventArgs) Handles ButtonSelect.Click
        TextConfirm.Visible = True
        ButtonMeat.Enabled = False
        ButtonVeggie.Enabled = False
    End Sub

    'Closes Form
    Public Sub ButtonExit_Click(sender As Object, e As EventArgs) Handles ButtonExit.Click
        Close()
    End Sub
End Class