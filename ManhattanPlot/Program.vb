﻿Imports Microsoft.VisualBasic.DocumentFormat.Csv
Imports Microsoft.VisualBasic.Imaging

Module Program

    Sub New()
        Dim template As String = App.HOME & "/Template.csv"

        If Not template.FileExists Then
            Call {New SNP}.SaveTo(template)
        End If
    End Sub

    Public Function Main() As Integer
        Dim data = "C:\Users\xieguigang\Desktop\8.23\Manhattan_Plots.csv".LoadCsv(Of SNP)
        Dim img = data.Plot
        Call img.SaveAs("C:\Users\xieguigang\Desktop\8.23\Manhattan_Plots.png", ImageFormats.Png)

        Return GetType(Program).RunCLI(App.CommandLine)
    End Function
End Module