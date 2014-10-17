package Geometry3D;

import Geometry.Shape;
import Interfaces.AreaMeasurable;
import Interfaces.VolumeMeasurable;

public abstract class SpaceShape extends Shape implements VolumeMeasurable,
		AreaMeasurable {

	public SpaceShape(Vertex3D[] vertices) {
		super(vertices);
	}
}
