Object.prototype.extends = function (parent) {
    this.prototype = Object.create(parent.prototype);
    this.prototype.constructor = this;
}

var Shape = (function () {
    function Shape(x, y, color) {
        this.setX(x);
        this.setY(y);
        this.setColor(color);
    }

    Shape.prototype.getX = function () {
        return this._x;
    }

    Shape.prototype.setX = function (x) {
        this._x = x;
    }

    Shape.prototype.getY = function () {
        return this._y;
    }

    Shape.prototype.setY = function (y) {
        this._y = y;
    }

    Shape.prototype.getColor = function () {
        return this._color;
    }

    Shape.prototype.setColor = function (color) {
        this._color = color;
    }

    Shape.prototype.draw = function () {
    }

    Shape.prototype.toString = function () {
        return this.constructor.name + ' X: ' + this.getX() + ', Y: ' + this.getY() + ', Color: ' + this.getColor();
    }

    return Shape;
})();


var Circle = (function () {
    function Circle(x, y, color, radius) {
        Shape.call(this, x, y, color);
        this.setRadius(radius);
    }

    Circle.extends(Shape);

    Circle.prototype.getRadius = function () {
        return this._radius;
    }

    Circle.prototype.setRadius = function (radius) {
        this._radius = radius;
    }

    Circle.prototype.draw = function () {
        var canvas = document.getElementById("myCanvas");
        var ctx = canvas.getContext("2d");
        ctx.fillStyle = this.getColor();
        ctx.beginPath();
        ctx.arc(this.getX(), this.getY(), this.getRadius(), 0, Math.PI * 2, true);
        ctx.closePath();
        ctx.fill();
    }

    Circle.prototype.toString = function () {
        return Shape.prototype.toString.call(this) + ', Radius: ' + this.getRadius();
    }

    return Circle;
})();


var Rectangle = (function () {
    function Rectangle(x, y, color, width, height) {
        Shape.call(this, x, y, color);
        this.setWidth(width);
        this.setHeight(height);
    }

    Rectangle.extends(Shape);

    Rectangle.prototype.getWidth = function () {
        return this._width;
    }

    Rectangle.prototype.setWidth = function (width) {
        this._width = width;
    }

    Rectangle.prototype.getHeight = function () {
        return this._height;
    }

    Rectangle.prototype.setHeight = function (height) {
        this._height = height;
    }

    Rectangle.prototype.draw = function () {
        var canvas = document.getElementById("myCanvas");
        var ctx = canvas.getContext("2d");
        ctx.fillStyle = this.getColor();
        ctx.fillRect(this.getX(), this.getY(), this.getWidth(), this.getHeight());
    }

    Rectangle.prototype.toString = function () {
        return  Shape.prototype.toString.call(this) + ', Width: ' + this.getWidth() + ', Height: ' + this.getHeight();
    }

    return Rectangle;
})();


var Triangle = (function () {
    function Triangle(x, y, color, x2, y2, x3, y3) {
        Shape.call(this, x, y, color);
        this.setX2(x2);
        this.setY2(y2);
        this.setX3(x3);
        this.setY3(y3);
    }

    Triangle.extends(Shape);

    Triangle.prototype.getX2 = function () {
        return this._x2;
    }

    Triangle.prototype.setX2 = function (x2) {
        this._x2 = x2;
    }

    Triangle.prototype.getY2 = function () {
        return this._y2;
    }

    Triangle.prototype.setY2 = function (y2) {
        this._y2 = y2;
    }

    Triangle.prototype.getX3 = function () {
        return this._x3;
    }

    Triangle.prototype.setX3 = function (x3) {
        this._x3 = x3;
    }

    Triangle.prototype.getY3 = function () {
        return this._y3;
    }

    Triangle.prototype.setY3 = function (y3) {
        this._y3 = y3;
    }

    Triangle.prototype.draw = function () {
        var canvas = document.getElementById("myCanvas");
        var ctx = canvas.getContext("2d");
        ctx.fillStyle = this.getColor();
        ctx.beginPath(this.getX(), this.getY());
        ctx.lineTo(this.getX2(), this.getY2());
        ctx.lineTo(this.getX3(), this.getY3());
        ctx.lineTo(this.getX(), this.getY());
        ctx.fill();
    }

    Triangle.prototype.toString = function () {
        return  Shape.prototype.toString.call(this) +
            ", X2: " + this.getX2() + ", Y2: " + this.getY2() +
            ", X3: " + this.getX3() + ", Y3: " + this.getY3()
    }

    return Triangle;
})();


var Segment = (function () {
    function Segment(x, y, color, x2, y2) {
        Shape.call(this, x, y, color);
        this.setX2(x2);
        this.setY2(y2);
    }

    Segment.extends(Shape);

    Segment.prototype.getX2 = function () {
        return this._x2;
    }

    Segment.prototype.setX2 = function (x2) {
        this._x2 = x2;
    }

    Segment.prototype.getY2 = function () {
        return this._y2;
    }

    Segment.prototype.setY2 = function (y2) {
        this._y2 = y2;
    }

    Segment.prototype.draw = function (){
        var canvas = document.getElementById("myCanvas");
        var ctx = canvas.getContext("2d");
        ctx.beginPath();
        ctx.moveTo(this.getX(), this.getY());
        ctx.lineTo(this.getX2(), this.getY2());
        ctx.strokeStyle = this.getColor();
        ctx.stroke();
    }

    Segment.prototype.toString = function () {
        return  Shape.prototype.toString.call(this) +
            ", X2: " + this.getX2() + ", Y2: " + this.getY2();
    }

    return Segment;
})();


var Point = (function () {
    function Point(x, y, color) {
        Shape.call(this, x, y, color)
    }

    Point.extends(Shape);

    Point.prototype.draw = function () {
        var canvas = document.getElementById("myCanvas");
        var ctx = canvas.getContext("2d");
        ctx.fillStyle = this.getColor();
        ctx.fillRect(this.getX(), this.getY(), 1, 1);
    }
    return Point;
})();