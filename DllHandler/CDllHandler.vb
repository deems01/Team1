﻿Imports CSVExporterDNF
Public Class CDllHandler
    Implements IDllHandler
    ' Function to save data to a CSV file
    'Dim data As String(,) = {{"Name", "Age"}, {"John", "30"}, {"Alice", "25"}}
    'Dim rowsWritten As Integer = CSVExportHelper.SaveDataToCsv(data, "C:\path\to\file.csv", ",", """", False)
    'If rowsWritten > 0 Then
    '    Console.WriteLine($"Data saved successfully. {rowsWritten} rows written.")
    'Else
    '    Console.WriteLine("Failed to save data to CSV.")
    'End If
    Public Function SaveDataToCsv(data As String(,), Optional filePath As String = "", Optional delimiter As String = ":",
                                  Optional textQualifier As String = """", Optional appendData As Boolean = False) As Integer _
                                    Implements IDllHandler.SaveDataToCsv

        Dim exporter As IExporter = New CExporter()

        Try
            ' Set delimiter and text qualifier
            exporter.delimiter = delimiter
            exporter.textQualifier = textQualifier

            ' If filePath is empty, set file interactively
            If String.IsNullOrEmpty(filePath) Then
                filePath = exporter.setFileToSave()
            End If

            ' Save the data to the CSV file
            Dim rowsWritten As Integer = exporter.saveDataToCsv(data, appendData)

            ' Return the number of rows written
            Return rowsWritten
        Catch ex As Exception
            ' Handle any exceptions that occur during the export process
            Console.WriteLine($"Error: {ex.Message}")
            Return -1 ' Indicate failure
        End Try
    End Function
End Class
