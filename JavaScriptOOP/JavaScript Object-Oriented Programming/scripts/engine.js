(function () {

    var selectShape = document.getElementById('selectShape'),
        displayDescription = document.getElementById('displayDescription'),
        shapeParameters = document.getElementById('shapeParameters'),
        currentShape,
        addShapeInHTML,
        x,
        xValue,
        y,
        yValue,
        color,
        colorValue,
        shapeToCreate,
        x2,
        x2Value,
        y2,
        y2Value,
        x3,
        x3Value,
        y3,
        y3Value,
        radius,
        radiusValue,
        width,
        widthValue,
        height,
        heightValue,
        rectangle,
        circle,
        triangle,
        segment,
        point;

    selectShape.addEventListener('change', addProperInputType, false);


    function addProperInputType() {
        currentShape = selectShape.value;
        switch (currentShape) {
            case 'rectangle':
                shapeParameters.innerHTML =
                    '<label for="width">Width:</label>' +
                    '<input id="width" type="number" value="0"/>' +
                    '<label for="height">Height:</label>' +
                    '<input id="height" type="number" value="0"/>';
                break;
            case 'triangle':
                shapeParameters.innerHTML =
                    '<fieldset>' +
                    '<label for="x2">X2:</label>' +
                    '<input id="x2" type="number" value="0"/>' +
                    '<label for="y2">Y2:</label>' +
                    '<input id="y2" type="number" value="0"/>' +
                    //'<br />' +
                    '<label for="x3">X3:</label>' +
                    '<input id="x3" type="number" value="0"/>' +
                    '<label for="y3">Y3:</label>' +
                    '<input id="y3" type="number" value="0"/>' +
                    '</fieldset>';
                break;
            case 'circle':
                shapeParameters.innerHTML =
                    '<fieldset>' +
                    '<label for="radius">Radius:</label>' +
                    '<input id="radius" type="number" value="0"/>' +
                    '</fieldset>';
                break;
            case 'segment':
                shapeParameters.innerHTML =
                    '<fieldset>' +
                    '<label for="x2">X2:</label>' +
                    '<input id="x2" type="number" value="0"/>' +
                    '<label for="y2">Y2:</label>' +
                    '<input id="y2" type="number" value="0"/>' +
                    '</fieldset>';
                break;
            case 'point':
                shapeParameters.innerHTML =
                    '<p>Point has only default x, y, and color.</p>' +
                    '<p>You can enter them on top of this section.</p>';
                break;
        }
    }

    addShapeInHTML = document.getElementById('submitButton');
    addShapeInHTML.addEventListener('click', addShape, false);

    function addShape() {
        x = document.getElementById('x');
        xValue = x.value;
        y = document.getElementById('y');
        yValue = y.value;
        color = document.getElementById('color');
        colorValue = color.value;
        shapeToCreate = selectShape.value;
        switch (shapeToCreate) {
            case 'rectangle':
                addRectangle(xValue, yValue, colorValue);
                break;
            case 'triangle':
                addTriangle(xValue, yValue, colorValue);
                break;
            case 'circle':
                addCircle(xValue, yValue, colorValue);
                break;
            case 'segment':
                addSegment(xValue, yValue, colorValue);
                break;
            case 'point':
                addPoint(xValue, yValue, colorValue);
                break;
        }
    }

    function addRectangle(xValue, yValue, colorValue) {
        height = document.getElementById('height');
        heightValue = height.value;
        width = document.getElementById('width');
        widthValue = width.value;
        rectangle = new Rectangle(xValue, yValue, colorValue, widthValue, heightValue);
        displayDescription.innerHTML += '<p>' + rectangle.toString() + '</p>';
        rectangle.draw();
    }

    function addTriangle(xValue, yValue, colorValue) {
        x2 = document.getElementById('x2');
        x2Value = x2.value;
        y2 = document.getElementById('y2');
        y2Value = y2.value;
        x3 = document.getElementById('x3');
        x3Value = x3.value;
        y3 = document.getElementById('y3');
        y3Value = y3.value;
        triangle = new Triangle(xValue, yValue, colorValue, x2Value, y2Value, x3Value, y3Value);
        displayDescription.innerHTML += '<p>' + triangle.toString() + '</p>';
        triangle.draw();
    }

    function addCircle(xValue, yValue, colorValue) {
        radius = document.getElementById('radius');
        radiusValue = radius.value;
        circle = new Circle(xValue, yValue, colorValue, radiusValue);
        displayDescription.innerHTML += '<p>' + circle.toString() + '</p>';
        circle.draw();
    }

    function addSegment(xValue, yValue, colorValue) {
        x2 = document.getElementById('x2');
        x2Value = x2.value;
        y2 = document.getElementById('y2');
        y2Value = y2.value;
        segment = new Segment(xValue, yValue, colorValue, x2Value, y2Value);
        displayDescription.innerHTML += '<p>' + segment.toString() + '</p>';
        segment.draw();
    }

    function addPoint(xValue, yValue, colorValue) {
        point = new Point(xValue, yValue, colorValue);
        displayDescription.innerHTML += '<p>' + point.toString() + '</p>';
        point.draw();
    }
})();