import spec.UnitSpec

class PhoneNumbersSpec extends UnitSpec {
  "validate" should {
    "check phone number begins with 9" in {
      assert(VALIDATE.phoneNumber("92345567871") equals VALID_TELEPHONE_NUMBER)
    }

    "return invalid error when phone number does not begin with 9" in {
      assert(VALIDATE.phoneNumber("82345567871") equals INVALID_ERROR)
    }

    "return invalid error when phone number is less than 11 digits in length" in {
      assert(VALIDATE.phoneNumber("9234556787") equals INVALID_ERROR)
    }

    "return invalid error when phone number is more than 11 digits in length" in {
      assert(VALIDATE.phoneNumber("912345678909") equals INVALID_ERROR)
    }

    "return a phone number when it is valid" in {
      assert(VALIDATE.phoneNumber("92345567871") equals VALID_TELEPHONE_NUMBER)
    }

    "ignore spaces" in {
      assert(VALIDATE.phoneNumber("923 4556 787 1") equals VALID_TELEPHONE_NUMBER)
    }

    "ignore hyphens" in {
      assert(VALIDATE.phoneNumber("9-2--345567-871") equals VALID_TELEPHONE_NUMBER)
    }

    "ignore opening brackets" in {
      assert(VALIDATE.phoneNumber("92(345567((871") equals VALID_TELEPHONE_NUMBER)
    }

    "ignore closing brackets" in {
      assert(VALIDATE.phoneNumber("9)2345)567871") equals VALID_TELEPHONE_NUMBER)
    }

    "ignore commas" in {
      assert(VALIDATE.phoneNumber("92,345567,871") equals VALID_TELEPHONE_NUMBER)
    }

    "return invalid error when phone number contains alpha characters" in {
      assert(VALIDATE.phoneNumber("923455678A71") equals INVALID_ERROR)
    }
  }

  val VALIDATE = new Validate
  val VALID_TELEPHONE_NUMBER = "92345567871"
  val INVALID_ERROR = "invalid"
}