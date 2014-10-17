package Shop;

import java.math.BigDecimal;

public class Appliance extends ElectronicsProduct {
	private final static int GUARANTEE_PERIOD = 6;
	
	public Appliance(String name, double price, int quantity,
			AgeRestriction ageRestriction) {
		super(name, price, quantity, ageRestriction, GUARANTEE_PERIOD);
	}

}
