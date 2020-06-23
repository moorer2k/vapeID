Namespace Classes
    Public Class Identity

        Public Property FirstName As String
        Public Property LastName As String
        Public Property DOB As String
        Public Property Expiration As String
        Public Property ID As String
        Public Property Age As String
        Public Property IsExpired As Boolean
        Public Property IsUnderAge As Boolean
        Public Property State As String


        Sub New(first As String, last As String, dob As String, expiry As String, id As String, age As String, expiredId As Boolean, underage As Boolean, state As String)
            Me.FirstName = first
            Me.LastName = last
            Me.DOB = dob
            Me.Expiration = expiry
            Me.ID = id
            Me.Age = age
            Me.IsExpired = expiredId
            Me.IsUnderAge = underage
            Me.State = state
        End Sub

    End Class

End Namespace