package Shop;

import java.math.BigDecimal;

public class Customer {
	private String name;
	private int age;
	private BigDecimal balance;

	public Customer(String name, int age, double balance) {
		super();
		this.name = name;
		this.age = age;
		this.balance = new BigDecimal(balance);
	}

	public String getName() {
		return name;
	}

	public void setName(String name) {
		this.name = name;
	}

	public int getAge() {
		return age;
	}

	public void setAge(int age) {
		this.age = age;
	}

	public BigDecimal getBalance() {
		return balance;
	}

	public void setBalance(BigDecimal balance) {
		this.balance = balance;
	}
}
