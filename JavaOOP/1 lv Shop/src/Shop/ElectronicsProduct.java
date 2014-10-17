package Shop;

public class ElectronicsProduct extends Product {
	private int guaranteePeriod;

	public ElectronicsProduct(String name, double price, int quantity,
			AgeRestriction ageRestriction, int guaranteePeriod) {
		super(name, price, quantity, ageRestriction);
		this.guaranteePeriod = guaranteePeriod;
	}

	public int getGuaranteePeriod() {
		return guaranteePeriod;
	}

	public void setGuaranteePeriod(int guaranteePeriod) {
		this.guaranteePeriod = guaranteePeriod;
	}
	
	public String toString() {
		return "Electronics product: " + this.getName() + ", price: " + this.getPrice().doubleValue()
				+ ", age restriction: " + this.getAgeRestriction().toString().toLowerCase();
	}

}
