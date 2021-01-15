
public class Main {

	public static void main(String[] args) {
		
		Channel channel1 = new Channel("Matlab","active");;
	
		
		
		Follower follower1 = new Follower("joseph");
		Follower follower2 = new Follower("phobe");
		Follower follower3 = new Follower("jane");
		
		channel1.registerObserver(follower1);
		channel1.registerObserver(follower2);
		channel1.registerObserver(follower3);
		channel1.setStatus("passive");
		
		follower1.play();
		
	}

}
