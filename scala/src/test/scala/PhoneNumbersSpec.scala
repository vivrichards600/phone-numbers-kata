

class PhoneNumbersSpec extends UnitSpec {
  "validate" should {
    "check phone number begins with 9" in {
      assert(VALIDATE.phoneNumber("92345567871") equals VALID_TELEPHONE_NUMBER)
    }
  }

  val VALIDATE = new Validate
  val VALID_TELEPHONE_NUMBER = "92345567871"
}
