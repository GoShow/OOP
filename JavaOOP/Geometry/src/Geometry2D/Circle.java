package Geometry2D;


public class Circle extends PlaneShape {
	private double radius;
	public Circle(Vertex2D[] vertices, double radius) {
		super(vertices);
		this.radius = radius;
	}

	@Override
	public double calculatePerimeter() {
		double perimeter =  2 * Math.PI * this.radius;
		return perimeter;
	}

	@Override
	public double calculateArea() {
		double area = Math.PI * this.radius * this.radius;
		return area;
	}
	
	@Override
	public String toString() { 
		double perimeter = this.calculatePerimeter();
		double area = this.calculateArea();
	    return "Circle: perimeter = " + perimeter + ", area = " + area;
	}
}
