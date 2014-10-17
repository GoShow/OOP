package Shop;

import java.text.DateFormat;
import java.text.ParseException;
import java.text.SimpleDateFormat;
import java.util.Date;

public class FoodProduct extends Product implements Expirable {
	private String expirationDateString;

	public FoodProduct(String name, double price, int quantity,
			AgeRestriction ageRestriction, String expirationDateString) {
		super(name, price, quantity, ageRestriction);
		this.expirationDateString = expirationDateString;
	}

	@Override
	public Date getExpirationDate() throws ParseException {
		DateFormat formatter = new SimpleDateFormat("dd/MM/yyyy");
		Date expirationDate = formatter.parse(this.expirationDateString);
		return expirationDate;
	}

	@Override
	public String toString() {
		return "Food product: " + this.getName() + ", price: "
				+ this.getPrice().doubleValue() + ", age restriction: "
				+ this.getAgeRestriction().toString().toLowerCase();
	}
}
