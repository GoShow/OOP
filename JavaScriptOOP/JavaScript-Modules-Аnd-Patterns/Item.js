var Factory = Factory || {};
(function (Factory) {
    var number = 0;

    function Item(title) {
        number++;
        ListElement.call(this,title);
        this._id = 'item' + number;
    }

    Item.extends(ListElement);

    Item.prototype._buildHtmlElement = function () {
        var div = document.createElement("div");

        var input = document.createElement("input");
        input.type = "checkbox";
        input.id = this._id;

        var label = document.createElement("label");
        label.innerHTML = this._title;
        label.htmlFor = this._id;

        div.appendChild(input);
        div.appendChild(label);

        this._htmlElement = div;
    };

    Factory.getItem = function(title) {
        return new Item(title);
    };

})(Factory);

