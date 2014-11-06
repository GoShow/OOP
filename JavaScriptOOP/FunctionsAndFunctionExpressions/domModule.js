var domModule = (function () {
    function appendChild() {
        var childElement = arguments[0];
        var parentElement = document.querySelector(arguments[1]);
        childElement.innerHTML = '<strong style="color: #0000ff;">Added from outside JavaScript</strong>';
        parentElement.appendChild(childElement);
    };

    function removeChild() {
        var parentElement = document.querySelector(arguments[0]);
        var childElement = parentElement.querySelector(arguments[1]);

        parentElement.removeChild(childElement);
    };

    function addHandler() {
        var elements = document.querySelectorAll(arguments[0]);
        var event = arguments[1];
        var eventFunction = arguments[2];

        for (i = 0; i < elements.length; i++) {
            elements[i].addEventListener(event, eventFunction);
        }
    };

    function retrieveElements() {
        var elements = document.querySelectorAll(arguments[0]);

        return elements;
    }

    return {
        appendChild: appendChild,
        removeChild: removeChild,
        addHandler: addHandler,
        retrieveElements: retrieveElements
    }
})();
var newLi = document.createElement('li');
domModule.appendChild(newLi, ".birds-list")
domModule.removeChild("ul.birds-list", "li:first-child");
domModule.addHandler("li.birds", 'click', function () {
    alert("I'm a bird!")
});
var elements = domModule.retrieveElements(".bird");
console.log(elements);


