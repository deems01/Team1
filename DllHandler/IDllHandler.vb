Public Interface IDllHandler
    Function SaveDataToCsv(data As String(,), Optional delimiter As String = ":",
                                  Optional textQualifier As String = """",
                           Optional appendData As Boolean = False) As String
End Interface
