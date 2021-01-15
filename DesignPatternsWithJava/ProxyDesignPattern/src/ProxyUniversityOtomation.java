
public class ProxyUniversityOtomation implements IUniversityOtomation{
	UniversityOtomation otomation;
	boolean login;
	String userName,password;
	
	public ProxyUniversityOtomation(String userName,String password) {
		this.userName=userName;
		this.password=password;
	
	}
	public boolean Login() {
		if (userName.equals("Cansu") && password.equals("1234"))
        {
            otomation = new UniversityOtomation();
            login = true;
            System.out.println("It has been provided  entry to system");
            return true;
        }
        else
        	 System.out.println("Login attempt  failed ");
 
        login = false;
        return false;
		
	}
	

	@Override
	public boolean showWeeklySchedule() {
		Login();
		
		if(!login) {
			System.out.println("Not showing weekly schedule because of not access to login to system");
			return false;
		}
		else 
			System.out.println("Showing all weekly schedules ");
			return true;
	}

}
