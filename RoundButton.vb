Imports System.Drawing.Drawing2D

Public Class RoundButton
    Inherits Button
    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        Dim grPath As New GraphicsPath()
        Dim menor As Single, mayor As Single

        grPath.StartFigure()
        If (ClientSize.Width > ClientSize.Height) Then
            mayor = ClientSize.Width : menor = ClientSize.Height
            grPath.AddArc(New Rectangle(0, 0, menor, menor), 90, 180)
            grPath.AddArc(New Rectangle(mayor - menor, 0, menor, menor), 270, 180)
        Else
            mayor = ClientSize.Height : menor = ClientSize.Width
            grPath.AddArc(New Rectangle(0, 0, menor, menor), 180, 180)
            grPath.AddArc(New Rectangle(0, mayor - menor, menor, menor), 0, 180)
        End If
        grPath.CloseFigure()
        Region = New Region(grPath)
        MyBase.OnPaint(e)
    End Sub
End Class
