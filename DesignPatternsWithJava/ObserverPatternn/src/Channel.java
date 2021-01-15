import java.util.ArrayList;
import java.util.List;

public class Channel implements Subject {
	
	private List<Observer> observerlist =new ArrayList<Observer>();
	private String channelName;
	private String status;
	
	public Channel(String cName, String status) {
		this.channelName =cName;
		this.status =status;
		
	}

	public String getChannelName() {
		return channelName;
	}


	public String getStatus() {
		return status;
	}

	public void setStatus(String status) {
		this.status = status;
		notifyObservers();
		
	}
	public void setChannelName(String cName) {
		this.channelName = cName;
				
	}

	@Override
	public void registerObserver(Observer observer) {
		observerlist.add(observer);
	}

	@Override
	public void removeObserver(Observer observer) {
		observerlist.remove(observer);
		
	}

	@Override
	public void notifyObservers() {
	  
		for (Observer obs : observerlist) 
		{ 
		    obs.update(this.status);
		}
		
	}

}
