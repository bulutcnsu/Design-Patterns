//Real Subject Class
import java.time.LocalDate;
import java.time.Month;


public class UniversityOtomation implements IUniversityOtomation{

	@Override
	public boolean  showWeeklySchedule() {
		LocalDate current = LocalDate.now();
		Month m=current.getMonth();
	
		if( (m== Month.JUNE) || (m== Month.JULY) || (m== Month.AUGUST)){
			return false;
			
		}else 
			
		return true;
		
	}

}
