
public class EncryptDecorator  extends Decorator{

	public EncryptDecorator(IMail mail) {
		super(mail);
		// TODO Auto-generated constructor stub
	}
	 public void send() {
	    	super.send();
	    	System.out.println("it is encrypted");
	    }
}
