
public class Main {

	public static void main(String[] args) {
		
		
		BoatFactory factory =new BoatFactory();
		Boat fishing = factory.getBoat(BoatTypes.FishingBoat,0);
		fishing.drive();
		

		Boat cargo = factory.getBoat(BoatTypes.CargoBoat,2);
		cargo.drive();
		
		Boat racing = factory.getBoat(BoatTypes.RacingBoat,1);
		racing.drive();
	}

}
