package Shop;

import java.util.ArrayList;
import java.util.Comparator;
import java.util.Date;
import java.util.List;
import java.util.stream.Collectors;
import java.math.BigDecimal;
import java.security.InvalidParameterException;
import java.text.ParseException;

public class TestShop {

	public static class PurchaseManager {
		public static void processPurchase(Customer customer, Product product)
				throws ParseException {
			if (product.getQuantity() <= 0) {
				throw new IllegalArgumentException(
						"Quantity can't be zero or less");
			}

			if (product instanceof FoodProduct) {
				Date today = new Date();
				Date currentExpirationDate = ((FoodProduct) product)
						.getExpirationDate();
				if (today.getTime() > currentExpirationDate.getTime()) {
					throw new InvalidParameterException("Expired product");
				}
			}

			if (product.getPrice().doubleValue() > customer.getBalance()
					.doubleValue()) {
				throw new ArithmeticException("Customer balance is not enough");
			}

			if (customer.getAge() < 18
					&& product.getAgeRestriction().equals(AgeRestriction.ADULT)) {
				throw new IllegalStateException(
						"Customer doesn't have permissions for this product");
			}

			BigDecimal newBalance = customer.getBalance().subtract(
					product.getPrice());
			customer.setBalance(newBalance);
			int newQuantity = product.getQuantity() - 1;
			product.setQuantity(newQuantity);
		}
	}

	public static void main(String[] args) throws ParseException {
		FoodProduct bread = new FoodProduct("bread", 1.85, 20,
				AgeRestriction.NONE, "11/12/2014");
		Computer dell = new Computer("dell", 250, 6, AgeRestriction.NONE);
		Customer visilina = new Customer("Visilina", 12, 120.63);

		System.out.println("Before shoping");
		System.out.println(bread.getName() + " quantity: "
				+ bread.getQuantity());
		System.out.println(visilina.getName() + " balance is:"
				+ visilina.getBalance());

		try {
			PurchaseManager.processPurchase(visilina, bread);

		} catch (InvalidParameterException e) {
			System.out.println("Expired product");
		} catch (IllegalArgumentException e) {
			System.out.println("Quantity can't be zero or less");
		} catch (ArithmeticException e) {
			System.out.println("Customer balance is not enough");
		} catch (IllegalStateException e) {
			System.out
					.println("Customer doesn't have permissions for this product");
		}

		System.out.println("After shoping");
		System.out.println(bread.getName() + " quantity: "
				+ bread.getQuantity());
		System.out.println(visilina.getName() + " balance is:"
				+ visilina.getBalance());
		System.out.println();
		System.out.println("New shopping laptop dell");
		try {
			PurchaseManager.processPurchase(visilina, dell);

		} catch (InvalidParameterException e) {
			System.out.println("Expired product!");
		} catch (IllegalArgumentException e) {
			System.out.println("This product is no longer available!");
		} catch (ArithmeticException e) {
			System.out
					.println("You do not have enough money to buy this product!");
		} catch (IllegalStateException e) {
			System.out.println("You are too young to buy this product!");
		}
		System.out.println();

		Product cigaretes = new FoodProduct("Viceroy", 4.85, 20,
				AgeRestriction.ADULT, "11/12/2014");
		Product watch = new ElectronicsProduct("Rolex", 22111.85, 16,
				AgeRestriction.TEENAGER, 12);

		List<Product> products = new ArrayList<Product>();
		products.add(dell);
		products.add(bread);
		products.add(cigaretes);
		products.add(watch);

		Comparator<Product> byPrice = (p1, p2) -> p1.getPrice().compareTo(
				p2.getPrice());
		List<Product> ageRestrictedProducts = products.stream()
				.filter(p -> p.getAgeRestriction() != AgeRestriction.NONE)
				.sorted(byPrice).collect(Collectors.toList());
		
		System.out.println("Restricted products sorted by price: ");
		for (Product product : ageRestrictedProducts) {
			System.out.println(product);
		}
	}
}
