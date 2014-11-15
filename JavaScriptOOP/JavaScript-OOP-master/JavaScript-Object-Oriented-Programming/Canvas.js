var Canvas = (function () {
    function Canvas(canvasId, shapes) {
        this._canvas = document.getElementById(canvasId);
        this._ctx = this._canvas.getContext("2d");
        this._shapes = shapes;
    }

    function drawCircle(circle) {
        var x = circle.getPoint().getX(),
            y = circle.getPoint().getY(),
            radius = circle.getRadius(),
            color = circle.getColor();

        this._ctx.beginPath();
        this._ctx.fillStyle = color;
        this._ctx.arc(x, y, radius, 0, 2 * Math.PI);
        this._ctx.fill();
    };

    function drawPoint(point) {
        var x = point.getPoint().getX(),
            y = point.getPoint().getY(),
            radius = 5,
            color = point.getColor();

        this._ctx.beginPath();
        this._ctx.fillStyle = color;
        this._ctx.arc(x, y, radius, 0, 2 * Math.PI);
        this._ctx.fill();
    };

    function drawRectangle(rectangle) {
        var x = rectangle.getPoint().getX(),
            y = rectangle.getPoint().getY(),
            width = rectangle.getWidth(),
            height = rectangle.getHeight(),
            color = rectangle.getColor();

        this._ctx.beginPath();
        this._ctx.fillStyle = color;
        this._ctx.rect(x, y, width, height);
        this._ctx.fill();
    }

    function drawSegment(segment) {
        var startPointX = segment.getPoint().getX(),
            startPointY = segment.getPoint().getY(),
            endPointX = segment.getEndPoint().getX(),
            endPointY = segment.getEndPoint().getY(),
            color = segment.getColor();

        this._ctx.beginPath();
        this._ctx.fillStyle = color;
        this._ctx.moveTo(startPointX, startPointY);
        this._ctx.lineTo(endPointX, endPointY);
        this._ctx.stroke();
    }

    function drawTriangle(triangle) {
        var points = triangle.getPoints(),
            color = triangle.getColor();

        this._ctx.beginPath();
        this._ctx.fillStyle = color;
        this._ctx.moveTo(points[0].getX(), points[0].getY());
        this._ctx.lineTo(points[1].getX(), points[1].getY());
        this._ctx.lineTo(points[2].getX(), points[2].getY());
        this._ctx.fill();
    }

    Canvas.prototype.update = function () {
        var i,
            shape;

        this._ctx.clearRect(0, 0, this._canvas.width, this._canvas.height);
        for (i = 0; i < this._shapes.length; i++) {
            shape = this._shapes[i];
            if (shape instanceof Circle) {
                drawCircle.call(this, shape);
            }

            if (shape instanceof Point) {
                drawPoint.call(this, shape);
            }

            if (shape instanceof Rectangle) {
                drawRectangle.call(this, shape);
            }

            if (shape instanceof Segment) {
                drawSegment.call(this, shape);
            }

            if (shape instanceof Triangle) {
                drawTriangle.call(this, shape);
            }
        }
    };

    return Canvas;
})();
