Imports CSVExporterDNF
Public Class CDllHandler
    Implements IDllHandler
    ' Function to save data to a CSV file
    'Dim data As String(,) = {{"Name", "Age"}, {"John", "30"}, {"Alice", "25"}}
    'Dim rowsWritten As Integer = CSVExporterDNF.SaveDataToCsv(data, "C:\path\to\file.csv", ",", """", False)
    'If rowsWritten > 0 Then
    '    Console.WriteLine($"Data saved successfully. {rowsWritten} rows written.")
    'Else
    '    Console.WriteLine("Failed to save data to CSV.")
    'End If
    Public Function SaveDataToCsv(data As String(,), Optional delimiter As String = ":",
                                  Optional textQualifier As String = """", Optional appendData As Boolean = False, Optional file As Boolean = False) As String _
                                    Implements IDllHandler.SaveDataToCsv

        Dim exporter As IExporter = New CExporter()

        Try
            ' Set delimiter and text qualifier
            exporter.delimiter = delimiter
            exporter.textQualifier = textQualifier
            Dim filepaths As String = ""
            If file Then
                filepaths = exporter.setFileToSave()
                Dim rowsWritten As Integer = exporter.saveDataToCsv(data, appendData)
            Else
                filepaths = exporter.setFileToSave()
                Dim rowsWritten As Integer = exporter.saveDataToCsv(data, appendData)
            End If

            ' Return the filepath
            Return filepaths

        Catch ex As Exception
            ' Handle any exceptions that occur during the export process
            Console.WriteLine($"Error: {ex.Message}")
            Return "" ' Indicate failure
        End Try
    End Function
End Class
