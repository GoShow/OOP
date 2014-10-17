package Geometry;

public abstract class Shape {
	private Vertex[] vertices;

	
	public Shape(Vertex[] vertices) {
		this.vertices = vertices;
	}

	public Vertex[] getVertices() {
		return vertices;
	}

	public void setVertices(Vertex[] vertices) {
		this.vertices = vertices;
	}
}
