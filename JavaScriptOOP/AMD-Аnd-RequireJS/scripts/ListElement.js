define(function () {
    Object.prototype.extends = function (parent) {
        this.prototype = Object.create(parent.prototype);
        this.prototype.constructor = this;
    };

    var ListElement = (function () {
        function ListElement(title) {
            this._setTitle(title);
        }

        ListElement.prototype._setTitle = function (title) {
            if(!title){
                throw new  ReferenceError('The title should not be empty.');
            }

            this._title = title;
        };

        ListElement.prototype.getHtmlElement = function () {
            if (!this._htmlElement) {
                this._buildHtmlElement();
            }

            return this._htmlElement;
        }

        ListElement.prototype._buildHtmlElement = function () {
            this._htmlElement = null;
        };

        ListElement.prototype.addToDOM = function (parentHtmlElement) {
            if (!this._htmlElement) {
                this._buildHtmlElement();
            }

            parentHtmlElement.querySelector('div').appendChild(this._htmlElement);
        };

        return ListElement;
    })();

    return ListElement;
});