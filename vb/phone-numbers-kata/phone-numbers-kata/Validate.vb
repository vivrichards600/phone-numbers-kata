Public Class Validate

    Public Shared Function PhoneNumber(telephoneNumber As String) As String
        Dim numberToCheck = telephoneNumber
        numberToCheck = numberToCheck.Replace(" ", "").Replace("-", "").Replace("(", "").Replace(")", "").Replace(",", "")

        If Not numberToCheck.StartsWith("9") = True Then Return "invalid"
        If Not numberToCheck.Length > 10 Then Return "invalid"
        If Not numberToCheck.Length < 12 Then Return "invalid"
        If Not IsNumeric(numberToCheck) Then Return "invalid"

        Return numberToCheck

    End Function

End Class