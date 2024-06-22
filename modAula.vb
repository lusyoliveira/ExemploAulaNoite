Module modAula
    Public Function validadata(ByVal data As String) As Boolean
        If IsDate(data) = True Then
            Return True
        Else
            Return False
        End If
    End Function
End Module
