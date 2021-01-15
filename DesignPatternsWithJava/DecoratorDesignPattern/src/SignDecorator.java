
public class SignDecorator  extends Decorator{
	private String sign;
	
	public SignDecorator(IMail mail, String sign) {
		super(mail);
		this.sign = sign;
		
	}
	  public void send() {
	    	super.send();
	    	System.out.println("Signed with +" +sign);
	    }
	

}
