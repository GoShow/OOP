var shapes = [],
    canvas = new Canvas('canvas', shapes);

function getShape() {
    function getPoint() {
        var x, y, color, point;

        x = document.getElementById('x').value;
        y = document.getElementById('y').value;
        color = document.getElementById('color').value;
        point = new Point(new Point2D(x, y), color);

        return point;
    }

    function getSegment() {
        var x, y,
            x2, y2,
            color, segment;

        x = document.getElementById('x').value;
        y = document.getElementById('y').value;
        x2 = document.getElementById('x2').value;
        y2 = document.getElementById('y2').value;
        color = document.getElementById('color').value;
        segment = new Segment(new Point2D(x, y), new Point2D(x2, y2), color);

        return segment;
    }

    function getTriangle() {
        var x, y,
            x2, y2,
            x3, y3,
            color, triangle;

        x = document.getElementById('x').value;
        y = document.getElementById('y').value;
        x2 = document.getElementById('x2').value;
        y2 = document.getElementById('y2').value;
        x3 = document.getElementById('x3').value;
        y3 = document.getElementById('y3').value;
        color = document.getElementById('color').value;
        triangle = new Triangle(new Point2D(x, y), new Point2D(x2, y2), new Point2D(x3, y3), color);

        return triangle;
    }

    function getRectangle() {
        var x, y,
            width, height,
            color,
            rectangle;

        x = document.getElementById('x').value;
        y = document.getElementById('y').value;
        width = document.getElementById('width').value;
        height = document.getElementById('height').value;
        color = document.getElementById('color').value;
        rectangle = new Rectangle(new Point2D(x, y), width, height, color);

        return rectangle;
    }

    function getCircle() {
        var x, y,
            radius,
            color,
            circle;

        x = document.getElementById('x').value;
        y = document.getElementById('y').value;
        radius = document.getElementById('radius').value;
        color = document.getElementById('color').value;
        circle = new Circle(new Point2D(x, y), radius, color);

        return circle;
    }

    var shape,
        select = document.getElementById('shape'),
        selectedOption = select.options[select.selectedIndex].value;

    switch (selectedOption) {
        case '0':
            shape = getPoint();
            break;
        case '1':
            shape = getTriangle();
            break;
        case '2':
            shape = getRectangle();
            break;
        case '3':
            shape = getCircle();
            break;
        case '4':
            shape = getSegment();
            break;
    }

    return shape;
}

function changeSelectShape(e) {
    var target = e.currentTarget;
    var selectedValue = target.options[target.selectedIndex].value;
    document.getElementById('secondPoint').style.display = 'none';
    document.getElementById('thirdPoint').style.display = 'none';
    document.getElementById('rectangle').style.display = 'none';
    document.getElementById('circle').style.display = 'none';
    switch (selectedValue) {
        case '1':
            document.getElementById('secondPoint').style.display = 'block';
            document.getElementById('thirdPoint').style.display = 'block';
            break;
        case '2':
            document.getElementById('rectangle').style.display = 'block';
            break;
        case '3':
            document.getElementById('circle').style.display = 'block';
            break;
        case '4':
            document.getElementById('secondPoint').style.display = 'block';
            break;
    }
}

function addShape() {
    var shape,
        select,
        option;

    shape = getShape();
    select = document.getElementById('shapes');
    option = document.createElement("option");
    option.text = shape.toString();
    shapes.push(shape);
    option.value = shapes.length - 1;
    select.add(option);
    canvas.update();
}

function upShape() {
    var select,
        options,
        selectedIndex,
        currentShape;

    select = document.getElementById('shapes');
    selectedIndex = select.selectedIndex;
    if (selectedIndex <= 0) {
        return;
    }

    currentShape = shapes[selectedIndex];
    shapes[selectedIndex] = shapes[selectedIndex - 1];
    shapes[selectedIndex - 1] = currentShape;

    options = select.options;
    options[selectedIndex].text = options[selectedIndex - 1].text;
    options[selectedIndex - 1].text = currentShape.toString();
    select.selectedIndex = selectedIndex - 1;
    canvas.update();
}

function downShape() {
    var select,
        options,
        selectedIndex,
        currentShape;

    select = document.getElementById('shapes');
    selectedIndex = select.selectedIndex;
    if (selectedIndex >= shapes.length) {
        return;
    }

    currentShape = shapes[selectedIndex];
    shapes[selectedIndex] = shapes[selectedIndex + 1];
    shapes[selectedIndex + 1] = currentShape;

    options = select.options;
    options[selectedIndex].text = options[selectedIndex + 1].text;
    options[selectedIndex + 1].text = currentShape.toString();
    select.selectedIndex = selectedIndex + 1;
    canvas.update();
}

function removeShape() {
    var select,
        selectedIndex;

    select = document.getElementById('shapes');
    selectedIndex = select.selectedIndex;
    shapes.splice(selectedIndex, 1);
    select.remove(selectedIndex);
    if (selectedIndex > 0) {
        select.selectedIndex = selectedIndex - 1;
    }

    canvas.update();
}


document.getElementById('addButton').addEventListener('click', addShape);
document.getElementById('shape').addEventListener('change', changeSelectShape);
document.getElementById('up').addEventListener('click', upShape);
document.getElementById('down').addEventListener('click', downShape);
document.getElementById('remove').addEventListener('click', removeShape);
