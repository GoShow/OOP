package Shop;

public class Computer extends ElectronicsProduct {
	private final static int GUARANTEE_PERIOD = 24;

	public Computer(String name, double price, int quantity,
			AgeRestriction ageRestriction) {
		super(name, price, quantity, ageRestriction, GUARANTEE_PERIOD);

	}
}
