
public class Main {

	public static void main(String[] args) {
		
		String from="Cansu Bulut";
		String sentTo ="Google Inc";
		IMail std = new GeneralMail(from, sentTo);
		IMail signed = new SignDecorator(std, "Cansu Bulut");
		IMail encrypted = new EncryptDecorator(signed);
		encrypted.send();
		
	}

}
