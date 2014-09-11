class Validate {

  def phoneNumber(telephoneNumber: String): String = {
    val number = telephoneNumber.replace(" ", "").replace("-", "").replace("(", "").replace(")", "").replace(",", "")

    if (number.startsWith("9") & number.length == 11 & number.forall(_.isDigit)) number
    else "invalid"
  }
}