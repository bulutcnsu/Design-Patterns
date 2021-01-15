
public class CoffeeTouchScreenAdapter implements CoffeMachineInterface {

	OldCoffeeMachine ocm;
	
	 public CoffeeTouchScreenAdapter(OldCoffeeMachine ocm) {
		this.ocm= ocm;
		
	}
	
	
	@Override
	public void chooseFirstSelection() {
	
		ocm.selectA();
	}

	@Override
	public void chooseSecondSelection() {
		ocm.selectB();
		
	}

}
