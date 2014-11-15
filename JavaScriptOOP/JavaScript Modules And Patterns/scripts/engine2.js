(function () {
    var container = new Container('Tuesday TODO List'),
        itemStatus = true,
        sectionIdNumber = 1,
        itemId = 1,
        section,
        sectionTitle,
        itemContent,
        item,
        itemParent;
    container.addToDOM();
    document.addEventListener('click', function (e) {
        var currentId = e.target.id;
        createElement(currentId);
    });

    function createElement(currentId) {
        if(currentId.indexOf('addItemButton') >-1 ){
            var switcher = 'addItemButton'
        } else{
            switcher =  currentId;
        }
        switch (switcher) {
            case 'addSection':
                sectionTitle = document.getElementById('sectionTitle');
                if (sectionTitle.value != '') {
                    section = new Section(sectionTitle.value);
                    section.addToDOM(sectionIdNumber);
                    container.addSection();
                    sectionIdNumber++;
                }
                break;

            case 'addItemButton':
                itemContent = document.getElementById('itemContent');
                if (itemContent.value != '') {
                    item = new Item(itemContent.value, itemStatus);
                    itemParent = document.getElementById(currentId).parentNode.parentNode;
                    item.addToDOM(itemParent);
                }

                break;
        }
    }
})();
