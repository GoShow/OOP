Object.prototype.extends = function (parent) {
    if (!Object.create) {
        Object.prototype.create = function (proto) {
            function F() {
            };
            F.prototype = proto;
            return new F;
        };
    }

    this.prototype = Object.create(parent.prototype);
    this.prototype.constructor = this;
};

var Point2D = (function () {
    function Point2D(x, y) {
        this._x = x;
        this._y = y;
    }

    Point2D.prototype.getX = function () {
        return this._x;
    };

    Point2D.prototype.getY = function () {
        return this._y;
    };

    return Point2D;
})();

var Shape = (function () {
    function Shape(point, color) {
        this._point = point;
        this._color = color;
    }

    Shape.prototype.toString = function () {
        var result = this.constructor.name + ' - ' +
            'X: ' + this._point._x +
            ', Y: ' + this._point._y +
            ' Color: ' + this._color;



        return result;
    }

    Shape.prototype.getPoint = function () {
        return this._point;
    };

    Shape.prototype.getColor = function () {
        return this._color;
    };
    return Shape;
})();

var Point = (function () {
    function Point(point, color) {
        Shape.call(this, point, color);
    }

    Point.extends(Shape);

    Point.prototype.getX = function () {
        return this._point.getX();
    }

    Point.prototype.getY = function () {
        return this._point.getY();
    }

    return Point;
})();

var Triangle = (function () {
    function Triangle(point1, point2, point3, color) {
        Shape.call(this, point1, color);
        this._p2 = point2;
        this._p3 = point3;
    }

    Triangle.extends(Shape);

    Triangle.prototype.getPoints = function () {
        return new Array(this._point, this._p2, this._p3);
    }

    Triangle.prototype.toString = function () {
        var result = Shape.prototype.toString.call(this) +
            ', X2: ' + this._p2._x +
            ', Y2: ' + this._p2._y +
            ', X3: ' + this._p3._x +
            ', Y3: ' + this._p3._y;

        return result;
    };

    return Triangle;
})();

var Rectangle = (function () {
    function Rectangle(point, width, height, color) {
        Shape.call(this, point, color);
        this.setWidth(width);
        this._height = height;
    }

    Rectangle.extends(Shape);

    Rectangle.prototype.setWidth = function (width) {
        if(!width) { throw "Width should be positive number."};
        this._width = width;
    };

    Rectangle.prototype.getWidth = function () {
        return this._width;
    };

    Rectangle.prototype.getHeight = function () {
        return this._height;
    };

    Rectangle.prototype.toString = function () {
        var result = Shape.prototype.toString.call(this) +
            ', Width: ' + this._width +
            ', Height: ' + this._height;

        return result;
    };

    return Rectangle;
})();

var Circle = (function () {
    function Circle(point, radius, color) {
        Shape.call(this, point, color);
        this._radius = radius;
    }

    Circle.extends(Shape);

    Circle.prototype.getRadius = function () {
        return this._radius;
    };

    Circle.prototype.toString = function () {
        var result = Shape.prototype.toString.call(this) +
            ', Radius: ' + this._radius;

        return result;
    };

    return Circle;
})();

var Segment = (function () {
    function Segment(point1, point2, color) {
        Shape.call(this, point1, color);
        this._p2 = point2;
    }

    Segment.extends(Shape);

    Segment.prototype.getEndPoint = function () {
        return this._p2;
    }

    Segment.prototype.toString = function () {
        var result = Shape.prototype.toString.call(this) +
            ', X2: ' + this._p2._x +
            ', Y2: ' + this._p2._y;

        return result;
    };

    return Segment;
})();


var rec = new Rectangle(new Point2D(1,2), null, 1);