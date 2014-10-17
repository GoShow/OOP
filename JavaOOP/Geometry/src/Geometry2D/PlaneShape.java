package Geometry2D;

import Geometry.Shape;
import Interfaces.AreaMeasurable;
import Interfaces.PerimeterMeasurable;

public abstract class PlaneShape extends Shape implements PerimeterMeasurable, AreaMeasurable{

	public PlaneShape(Vertex2D[] vertices) {
		super(vertices);
	}

}
