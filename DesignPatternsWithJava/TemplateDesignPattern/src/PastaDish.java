
public abstract class PastaDish {

	public final void makeRecipe() {
		boilWater();
		addPasta();
		addProtein();
		addSouce();
				
	}
	
	private  void boilWater() {
		System.out.println("Boiling Water");//its same to all subclasses
	}
	
	protected abstract void addPasta();//this methods contents
	protected abstract void addProtein();// always changing 
	protected abstract void addSouce();//via subclasses
	}

