import spec.UnitSpec

class PhoneNumbersSpec extends UnitSpec {
  "validate" should {
    "check phone number begins with 9" in {
      assert(VALIDATE.phoneNumber("92345567871") equals VALID_TELEPHONE_NUMBER)
    }

    "return invalid error when phone number does not begin with 9" in {
      assert(VALIDATE.phoneNumber("82345567871") equals INVALID_ERROR)
    }
  }

  val VALIDATE = new Validate
  val VALID_TELEPHONE_NUMBER = "92345567871"
  val INVALID_ERROR = "invalid"
}