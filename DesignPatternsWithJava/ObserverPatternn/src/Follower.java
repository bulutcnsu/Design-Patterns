
public class Follower implements  Observer{
	private String followerName;

	public Follower(String followerName) {
		this.followerName = followerName;
	}
	public String getFollowerName() {
		return followerName;
	}
	public void setFollowerName(String followerName) {
		this.followerName = followerName;
	}
	
	@Override
	public void update(String status) {
	System.out.println(" Updated");
		
	}
	public void play() {
		System.out.println("  playing");
		
	}
}
