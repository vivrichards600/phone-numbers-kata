Imports System.Text

<TestClass()>
Public Class PhoneNumberTests

    <TestMethod()>
    <ExpectedException(GetType(System.Exception))> _
    Public Sub Phone_Number_Must_Be_More_Than_1_Digit()
        Validate.PhoneNumber("1")
    End Sub

    <TestMethod()>
      <ExpectedException(GetType(System.Exception))> _
    Public Sub Phone_Number_Must_Be_More_Than_10_Digits()
        Validate.PhoneNumber("9123456789")
    End Sub

    <TestMethod()>
    <ExpectedException(GetType(System.Exception))> _
    Public Sub Phone_Number_Must_Be_Less_Than_12_Digits()
        Validate.PhoneNumber("912345678909")
    End Sub

    <TestMethod()>
    Public Sub Phone_Number_Must_Be_11_Digits()
        Assert.IsTrue(Validate.PhoneNumber("92345567871") = VALID_TELEPHONE_NUMBER)
    End Sub

    <TestMethod()>
    Public Sub Phone_Number_Must_Begin_With_9()
        Assert.IsTrue(Validate.PhoneNumber("92345567871") = VALID_TELEPHONE_NUMBER)
    End Sub

    <TestMethod()>
    <ExpectedException(GetType(System.Exception))> _
    Public Sub Fail_When_Phone_Number_Does_Not_Begin_With_9()
        Validate.PhoneNumber(INVALID_TELEPHONE_NUMBER)
    End Sub

    <TestMethod()>
    Public Sub Phone_Number_Must_Remove_Spaces()
        Assert.IsTrue(Validate.PhoneNumber("923 4556 787 1") = VALID_TELEPHONE_NUMBER)
    End Sub

    <TestMethod()>
    Public Sub Phone_Number_Must_Remove_Special_Characters()
        Assert.IsTrue(Validate.PhoneNumber("9-2(345)567,871") = VALID_TELEPHONE_NUMBER)
    End Sub

    <TestMethod()>
    <ExpectedException(GetType(System.Exception))> _
    Public Sub Fail_When_Phone_Number_Contains_Alpha_Characters()
        Validate.PhoneNumber("9123456789A")
    End Sub

    Private ExpectedResult = String.Empty
    Private ActualResult = String.Empty
    Private VALID_TELEPHONE_NUMBER = "92345567871"
    Private INVALID_TELEPHONE_NUMBER = "82345567871"
    Private TELEPHONE_NUMBER = String.Empty

End Class

