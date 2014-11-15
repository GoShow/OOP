var Item = (function () {
    function Item(content, status) {
        this.setContent(content);
        this.setStatus(status);
    }

    Item.prototype.getContent = function () {
        return this._content;
    }

    Item.prototype.setContent = function (content) {
        this._content = content;
    }

    Item.prototype.getStatus = function () {
        return this._status;
    }

    Item.prototype.setStatus = function (status) {
        this._status = status;
    }

    Item.prototype.addToDOM = function (parent) {
        var newItemDiv = document.createElement('div');
        newItemDiv.innerHTML =
            '<input id="check" type="checkbox" />' +
            '<label for="check">' + itemContent.value + '</label>';
        parent.appendChild(newItemDiv);
        itemContent.value = '';
        alert();
    }

    return Item;
})()