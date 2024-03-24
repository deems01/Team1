Module CategoryFunctions

    Private pickedCategory As String
    Private pickedGenre As String

    Public Sub setPickedCategory(category As String)
        pickedCategory = category
    End Sub

    Public Function getPickedCategory()
        Return pickedCategory
    End Function

    Public Sub setGenre(genre As String)
        pickedGenre = genre
    End Sub

    Public Function getGenre()
        Return pickedGenre
    End Function

End Module
