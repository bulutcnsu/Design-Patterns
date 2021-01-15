import java.util.Scanner;

public class Main {

	public static void main(String[] args) {
		
		String userName = "", Password = "";
		Scanner s=new Scanner(System.in);
       
		while (true)
        {
            System.out.print("Please enter your username :");
            userName = s.next();
 
            System.out.print("Please enter your password :");
            Password = s.next();
 
         
            IUniversityOtomation otomation = new ProxyUniversityOtomation(userName, Password);
             otomation.showWeeklySchedule();
 
             System.out.println("******************");
        }

	}

}
