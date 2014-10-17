package Geometry3D;

import Geometry.Vertex;

public class Vertex3D extends Vertex {
	private double z;

	public Vertex3D(double x, double y, double z) {
		super(x, y);
		this.z = z;
	}

}
