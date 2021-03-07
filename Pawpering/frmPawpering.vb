' Project: Pawpering Vet Clinic CRM
' Author: David Oberlander
' Purpose: (CVTC) VB.NET Final Project: Develop your own.
' Date: 03/06/2021

Option Strict On
Option Explicit On
Public Class frmPawpering
    Private Sub mstNewCustomerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mstNewCustomerToolStripMenuItem.Click

        'Check if the form is created and open already
        If frmCustomer.IsHandleCreated Then
            'Focus on the already opened form
            frmCustomer.Focus()
        Else
            'Create and show the form
            frmCustomer.Show()
        End If
    End Sub

    Private Sub lnkEditCustomer_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkEditCustomer.LinkClicked

        'Check if the form is created and open already
        If frmCustomer.IsHandleCreated Then
            'Focus on the already opened form
            frmCustomer.Focus()
        Else
            'Create and show the form
            frmCustomer.Show()
        End If
    End Sub
End Class
