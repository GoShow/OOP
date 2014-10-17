package Geometry2D;

public class Triangle extends PlaneShape {
	private double sideA;
	private double sideB;
	private double sideC;

	public Triangle(Vertex2D[] vertices) {
		super(vertices);
		this.sideA = Math.sqrt(squareDistanceBetweenCoordinates(
				vertices[0].getX(), vertices[1].getX())
				+ squareDistanceBetweenCoordinates(vertices[0].getY(),
						vertices[1].getY()));
		this.sideB = Math.sqrt(squareDistanceBetweenCoordinates(
				vertices[1].getX(), vertices[2].getX())
				+ squareDistanceBetweenCoordinates(vertices[1].getY(),
						vertices[2].getY()));
		this.sideC = Math.sqrt(squareDistanceBetweenCoordinates(
				vertices[2].getX(), vertices[0].getX())
				+ squareDistanceBetweenCoordinates(vertices[2].getY(),
						vertices[0].getY()));
	}

	@Override
	public double calculatePerimeter() {
		double perimeter = this.sideA + this.sideB + this.sideC;
		return perimeter;
	}

	@Override
	public double calculateArea() {
		double p = this.sideA + this.sideB + this.sideC;
		double perimeter = Math.sqrt(p * (p - this.sideA) * (p - this.sideB)
				* (p - this.sideC));
		return perimeter;
	}

	private double squareDistanceBetweenCoordinates(double x1, double x2) {
		double distance = (x1 - x2) * (x1 - x2);
		return distance;
	}
	
	@Override
	public String toString() { 
		double perimeter = this.calculatePerimeter();
		double area = this.calculateArea();
	    return "Triangle: perimeter = " + perimeter + ", area = " + area;
	}
}
