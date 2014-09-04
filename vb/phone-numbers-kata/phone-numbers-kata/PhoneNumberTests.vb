Imports System.Text

<TestClass()>
Public Class PhoneNumberTests

    <TestMethod()>
    Public Sub Phone_Number_Must_Begin_With_9()
        Assert.IsTrue(Validate.PhoneNumber("92345567871") = VALID_TELEPHONE_NUMBER)
    End Sub

    <TestMethod()>
    Public Sub Invalid_Error_When_Phone_Number_Does_Not_Begin_With_9()
        Assert.IsTrue(Validate.PhoneNumber(INVALID_TELEPHONE_NUMBER) = INVALID_ERROR)
    End Sub

    <TestMethod()>
    Public Sub Phone_Number_Must_Be_More_Than_10_Digits_In_Length()
        Assert.IsTrue(Validate.PhoneNumber("9123456789") = INVALID_ERROR)
    End Sub

    <TestMethod()>
    Public Sub Phone_Number_Must_Be_Less_Than_12_Digits_In_Length()
        Assert.IsTrue(Validate.PhoneNumber("912345678909") = INVALID_ERROR)
    End Sub

    <TestMethod()>
    Public Sub Phone_Number_Must_Be_11_Digits_In_Length()
        Assert.IsTrue(Validate.PhoneNumber("92345567871") = VALID_TELEPHONE_NUMBER)
    End Sub

    <TestMethod()>
    Public Sub Phone_Number_Ignores_Spaces()
        Assert.IsTrue(Validate.PhoneNumber("923 4556 787 1") = VALID_TELEPHONE_NUMBER)
    End Sub

    <TestMethod()>
    Public Sub Phone_Number_Ignores_Hyphens()
        Assert.IsTrue(Validate.PhoneNumber("9-2(345)567,871") = VALID_TELEPHONE_NUMBER)
    End Sub

    <TestMethod()>
    Public Sub Phone_Number_Ignores_Open_Brackets()
        Assert.IsTrue(Validate.PhoneNumber("9-2(345)567,871") = VALID_TELEPHONE_NUMBER)
    End Sub

    <TestMethod()>
    Public Sub Phone_Number_Ignores_Closing_Brackets()
        Assert.IsTrue(Validate.PhoneNumber("9-2(345)567,871") = VALID_TELEPHONE_NUMBER)
    End Sub

    <TestMethod()>
    Public Sub Phone_Number_Ignores_Commas()
        Assert.IsTrue(Validate.PhoneNumber("9-2(345)567,871") = VALID_TELEPHONE_NUMBER)
    End Sub

    <TestMethod()>
    Public Sub Invalid_Error_When_Phone_Number_Contains_Alpha_Characters()
        Assert.IsTrue(Validate.PhoneNumber("9123456789A") = INVALID_ERROR)
    End Sub

    Private VALID_TELEPHONE_NUMBER = "92345567871"
    Private INVALID_TELEPHONE_NUMBER = "82345567871"
    Private INVALID_ERROR = "invalid"

End Class

