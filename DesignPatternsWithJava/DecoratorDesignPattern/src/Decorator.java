
public abstract class Decorator implements IMail {
	
	 private IMail mail; //aggregation
     public Decorator(IMail mail)
     {
         this.mail = mail;
     }

    public void send() {
    	mail.send();
    }
}
