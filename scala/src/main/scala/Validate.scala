import scala.annotation.tailrec

class Validate {

  def phoneNumber(telNo: String): String = {

    val invalidChars = Seq(" ", "-", "(", ")", ",")

    @tailrec
    def replaceInvalidChars(telNo: String, invalidChars: Seq[String]): String = {
      if (invalidChars.isEmpty) telNo
      else if (telNo contains invalidChars.head) {
        val n = telNo.replace(invalidChars.head, "")
        replaceInvalidChars(n, invalidChars.tail)
      }
      else replaceInvalidChars(telNo, invalidChars.tail)
    }

    val newTelNo = replaceInvalidChars(telNo, invalidChars)
    if (newTelNo.length == 11 && newTelNo.startsWith("9")) newTelNo
    else "invalid"
  }
}