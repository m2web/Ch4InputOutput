Option Strict On
'Program:	Demo Input, Processing, and Output
'Developer:	Mark McFadden
'Date:	    Today
'Purpose:	Class Demo

Public Class frmInProcOut
    Private Sub btnProcess_Click(sender As Object, e As EventArgs) Handles btnProcess.Click
        Dim strInput As String
        strInput = txtInput.Text
        Dim decInput As Decimal
        decInput = Convert.ToDecimal(strInput)
        Dim decResult As Decimal = decInput * 2
        lblOutputResult.Text = decResult.ToString("C")
    End Sub

    Private Sub frmInProcOut_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblOutputResult.Text = ""
    End Sub
End Class
