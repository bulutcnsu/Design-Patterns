
public class GeneralMail implements IMail {
	
	private String from;
	private String sentTo;
	
     public GeneralMail(String from, String sentTo) {
		this.from = from;
		this.sentTo = sentTo;
		
		
	}
	
	

	@Override
	public void send() {
		System.out.println("Mail goes from " +from +"  to "+sentTo);
		
	}

}
