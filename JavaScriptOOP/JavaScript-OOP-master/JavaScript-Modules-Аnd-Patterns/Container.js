var Factory = Factory || {};
(function(Factory){
    function Container(title){
        ListElement.call(this,title);
    }

    Container.extends(ListElement);

    Container.prototype._buildHtmlElement = function () {
        var header = document.createElement("h1");
        header.innerHTML = this._title;

        var div = document.createElement("div");
        div.appendChild(header);

        var input = document.createElement("input");
        input.type = "text";
        input.placeholder = 'Title';
        input.name = 'sectionTitle';

        var button = document.createElement("button");
        button.innerHTML = 'New Section';
        button.name = 'addSectionButton';

        var errorMessage = document.createElement("div");
        errorMessage.setAttribute("name", "errorContainer");
        errorMessage.className = "hideError";
        errorMessage.innerHTML = "Enter section title.";

        var container = document.createElement("section");

        container.appendChild(header);
        container.appendChild(div);
        container.appendChild(input);
        container.appendChild(button);
        container.appendChild(errorMessage);
        this._htmlElement = container;
    };

    Factory.getContainer = function(title){
        return new Container(title)
    };

})(Factory);

