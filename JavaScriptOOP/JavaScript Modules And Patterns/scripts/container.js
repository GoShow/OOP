var Container = (function () {
    var body = document.body;
    var sections = [];

    function Container(name) {
        this.setName(name)
    }

    Container.prototype.getName = function () {
        return this._name;
    }

    Container.prototype.setName = function (name) {
        this._name = name;
    }

    Container.prototype.addSection = function (section) {
        sections.push(section);
    }

    Container.prototype.addToDOM = function () {
        body.innerHTML =
            '<section id="container" class="border">' +
            '<h1>' + this.getName() + '</h1>' +
            '<fieldset id="fieldset">' +
            '<input id="sectionTitle" type="text" placeholder="Title" />' +
            '<button id="addSection">New Section</button>' +
            '</fieldset>';
    }

    return Container;
})();