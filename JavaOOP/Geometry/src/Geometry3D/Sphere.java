package Geometry3D;

public class Sphere extends SpaceShape {
	private double radius;

	public Sphere(Vertex3D[] vertices, double radius) {
		super(vertices);
		this.radius = radius;
	}

	@Override
	public double calculateVolume() {
		double volume = 4 * Math.PI * this.radius * this.radius * this.radius / 3;
		return volume;
	}

	@Override
	public double calculateArea() {
		double area = 4 * Math.PI * this.radius * this.radius;
		return area;
	}
	
	@Override
	public String toString() { 
		double volume = this.calculateVolume();
		double area = this.calculateArea();
	    return "Sphere: volume = " + volume + ", area = " + area;
	}

}
