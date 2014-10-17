package Geometry3D;

public class SquarePyramid extends SpaceShape {
	private double baseWidth;
	private double pyramidHeight;

	public SquarePyramid(Vertex3D[] vertices, double baseWidth,
			double pyramidHeight) {
		super(vertices);
		this.baseWidth = baseWidth;
		this.pyramidHeight = pyramidHeight;
	}

	@Override
	public double calculateVolume() {
		double volume = this.baseWidth * this.baseWidth * this.pyramidHeight / 3;
		return volume;
	}

	@Override
	public double calculateArea() {
		double area = this.baseWidth * this.baseWidth + this.baseWidth * 
				Math.sqrt(this.baseWidth * this.baseWidth + 
						(2 * this.pyramidHeight) * (2 * this.pyramidHeight));
		return area;
	}
	
	@Override
	public String toString() { 
		double volume = this.calculateVolume();
		double area = this.calculateArea();
	    return "Square pyramid: volume = " + volume + ", area = " + area;
	}

}
