package Geometry2D;


public class Reactangle extends PlaneShape {
	private double width;
	private double height;
	
	public Reactangle(Vertex2D[] vertices, double width, double height) {
		super(vertices);
		this.width = width;
		this.height = height;
	}

	public double getWidth() {
		return width;
	}

	public void setWidth(double width) {
		this.width = width;
	}

	public double getHeight() {
		return height;
	}

	public void setHeight(double height) {
		this.height = height;
	}

	@Override
	public double calculatePerimeter() {
		double perimeter = this.width * 2 + this.height * 2;
		return perimeter;
	}

	@Override
	public double calculateArea() {
		double area = this.height * this.width;
		return area;
	}
	
	@Override
	public String toString() { 
		double perimeter = this.calculatePerimeter();
		double area = this.calculateArea();
	    return "Reactangle: perimeter = " + perimeter + ", area = " + area;
	}

}
