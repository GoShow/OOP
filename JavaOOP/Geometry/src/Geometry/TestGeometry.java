package Geometry;

import java.util.Arrays;
import java.util.Comparator;
import java.util.List;
import java.util.stream.Collectors;
import Geometry2D.Circle;
import Geometry2D.PlaneShape;
import Geometry2D.Reactangle;
import Geometry2D.Triangle;
import Geometry2D.Vertex2D;
import Geometry3D.Cuboid;
import Geometry3D.Sphere;
import Geometry3D.SquarePyramid;
import Geometry3D.Vertex3D;
import Interfaces.PerimeterMeasurable;
import Interfaces.VolumeMeasurable;

public class TestGeometry {

	public static void main(String[] args) {
		Vertex2D top = new Vertex2D(10, 10);
		Vertex2D left = new Vertex2D(0, 0);
		Vertex2D right = new Vertex2D(20, 0);
		Circle circle = new Circle(new Vertex2D[] { top }, 5);
		Triangle triangle = new Triangle(new Vertex2D[] { top, left, right });
		Reactangle rectangle = new Reactangle(new Vertex2D[] { left }, 10.5,
				8.2);

		Vertex3D baseCenter = new Vertex3D(2, 8, -4.6);
		Cuboid cuboid = new Cuboid(new Vertex3D[] { baseCenter }, 3.1, 5.1, 2.4);
		Sphere sphere = new Sphere(new Vertex3D[] { baseCenter }, 2.34);
		SquarePyramid squarePyramid = new SquarePyramid(
				new Vertex3D[] { baseCenter }, 6.33, 8.11);

		Shape[] shapes = new Shape[] { circle, triangle, rectangle, cuboid,
				sphere, squarePyramid };

		List<Shape> shapesVolumeList = Arrays.asList(shapes).stream()
				.filter(s -> s instanceof VolumeMeasurable)
				.filter(s -> ((VolumeMeasurable) s).calculateVolume() > 40)
				.collect(Collectors.toList());

		System.out.println("Shapes with volume > 40");
		for (Shape shape : shapesVolumeList) {
			System.out.println(shape);
		}

		Comparator<Shape> byPerimeter = (s1, s2) -> {
			PerimeterMeasurable Shape1 = (PerimeterMeasurable) s1;
			PerimeterMeasurable Shape2 = (PerimeterMeasurable) s2;
			double perimeterShape1 = Shape1.calculatePerimeter();
			double perimeterShape2 = Shape2.calculatePerimeter();
			return perimeterShape1 < perimeterShape2 ? -1
					: perimeterShape1 > perimeterShape2 ? 1 : 0;
		};

		System.out.println();
		System.out.println("Sorted by perimeter: ");
		List<Shape> planeShapesByPerimeter = Arrays.asList(shapes).stream()
				.filter(p -> p instanceof PlaneShape).sorted(byPerimeter)
				.collect(Collectors.toList());
		for (Shape shape : planeShapesByPerimeter) {
			System.out.println(shape);
		}

	}
}
