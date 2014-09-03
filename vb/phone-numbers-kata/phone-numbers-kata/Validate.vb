Public Class Validate

    Public Shared Function PhoneNumber(telephoneNumber As String) As String
        Dim numberToCheck = telephoneNumber

        numberToCheck = numberToCheck.Replace(" ", "").Replace("-", "").Replace("(", "").Replace(")", "").Replace(",", "")

        If Not Left(numberToCheck, 1) = "9" Then Throw New Exception("Phone number must start with a 9")
        If Not numberToCheck.Length > 1 Then Throw New Exception("Phone number must be greater than 1 numbers")
        If Not numberToCheck.Length > 10 Then Throw New Exception("Phone number must be greater than 10 numbers")
        If Not numberToCheck.Length < 12 Then Throw New Exception("Phone number must be less than 12 numbers")
        If Not IsNumeric(numberToCheck) Then Throw New Exception("Phone number must not contain alpha characters")

        Return numberToCheck

    End Function

End Class