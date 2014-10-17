package Geometry3D;

public class Cuboid extends SpaceShape {
	private double width;
	private double height;
	private double depth;

	public Cuboid(Vertex3D[] vertices, double width, double height, double depth) {
		super(vertices);
		this.width = width;
		this.height = height;
		this.depth = depth;
	}

	@Override
	public double calculateVolume() {
		double volume = this.width * this.height * this.depth;
		return volume;
	}

	@Override
	public double calculateArea() {
		double area = 
				this.width * this.height * 2 +
				this.width * this.depth * 2 +
				this.height * this.depth * 2;				
		return area;
	}
	
	@Override
	public String toString() { 
		double volume = this.calculateVolume();
		double area = this.calculateArea();
	    return "Cuboid: volume = " + volume + ", area = " + area;
	}

}
