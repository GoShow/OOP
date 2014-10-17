package Shop;

import java.math.BigDecimal;

public abstract class Product implements Buyable {
	private String name;
	private BigDecimal price;
	private int quantity;
	private AgeRestriction ageRestriction;

	public Product(String name, double price, int quantity,
			AgeRestriction ageRestriction) {
		super();
		this.name = name;
		this.price = new BigDecimal(price);
		this.quantity = quantity;
		this.ageRestriction = ageRestriction;
	}

	public String getName() {
		return name;
	}

	public void setName(String name) {
		this.name = name;
	}

	public BigDecimal getPrice() {
		return price;
	}

	public void setPrice(BigDecimal price) {
		this.price = price;
	}

	public int getQuantity() {
		return quantity;
	}

	public void setQuantity(int quantity) {
		this.quantity = quantity;
	}

	public AgeRestriction getAgeRestriction() {
		return ageRestriction;
	}

	public void setAgeRestriction(AgeRestriction ageRestriction) {
		this.ageRestriction = ageRestriction;
	}
}
