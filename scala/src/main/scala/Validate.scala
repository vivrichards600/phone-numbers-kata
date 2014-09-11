class Validate {

  def phoneNumber(telephoneNumber: String): String = {
    if (telephoneNumber.startsWith("9")) telephoneNumber
    else "invalid"
  }
}
