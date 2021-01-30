
public class Singleton {

	private static Singleton instance = null;
    public String s;
   
   private Singleton() {
    	s="Hi, I'm part of Singleton class";
    }
    
    public static Singleton getInstance() {
    	if(instance == null ) {
    		instance = new Singleton();}
         return instance;
    }
	public static void main(String[] args) {
		Singleton object1 = Singleton.getInstance();
		
		Singleton object2 = Singleton.getInstance();
		
		Singleton object3 = Singleton.getInstance();
		
		System.out.println("String from object1 is " + object1.s); 
        System.out.println("String from object2 is " + object2.s); 
        System.out.println("String from object3 is " + object3.s); 
		

	}

}
