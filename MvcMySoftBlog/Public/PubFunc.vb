Namespace PublicFunc
    Module PubFunc
        ''' <summary>
        ''' 获取短标题
        ''' </summary>
        ''' <param name="Title">标题</param>
        ''' <param name="length">长度</param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function GetShortTitle(ByVal Title As String, ByVal length As String) As String
            If Title.Length > length Then
                If length > 3 Then
                    Return Mid(Title, 1, length - 3) & "..."
                Else
                    Return Mid(Title, 1, 1) & "..."
                End If
            Else
                Return Title
            End If
        End Function
    End Module
End Namespace
