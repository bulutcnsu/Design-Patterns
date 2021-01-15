

public class BoatFactory {
	
	public Boat getBoat(BoatTypes types, int which) { 
		BoatTypes  btypes = BoatTypes.values()[which];
		
		
		switch (btypes) {
		
		case FishingBoat:
			return new FishingBoat();
			
		case CargoBoat:
			return new CargoBoat();
			
		case  RacingBoat:
			return new RacingBoat();
			
			default:
				return null;
	}

}}
