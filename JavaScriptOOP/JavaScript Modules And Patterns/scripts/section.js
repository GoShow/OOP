var Section = (function () {
    var items = [];

    function Section(name) {
        this.setName(name);
    }

    Section.prototype.getName = function () {
        return this._name;
    }

    Section.prototype.setName = function (name) {
        this._name = name;
    }

    Section.prototype.addItem = function (item) {
        items.push(item);
    }

    Section.prototype.addToDOM = function (sectionIdNumber) {
        var containerElement = document.getElementById('container');
        var sectionTitle = document.getElementById('sectionTitle');
        var newSection = document.createElement('section');
        var fieldset = document.getElementById('fieldset');
        newSection.className = 'innerSection';
        newSection.innerHTML =
            '<h2>' + sectionTitle.value + '</h2>' +
            '<fieldset id="addItem">' +
            '<input id="itemContent" type="text" placeholder="Add item..." />' +
            '<button id="addItemButton' + sectionIdNumber + '">+</button>' +
            '</fieldset>';

        containerElement.appendChild(newSection);
        containerElement.insertBefore(newSection, fieldset)
        sectionTitle.value = '';
    }

    return Section;
})()