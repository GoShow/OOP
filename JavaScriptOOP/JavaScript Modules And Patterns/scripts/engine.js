window.onload = function () {
    var sectionId = 1,
        itemId = 1,
        container = new Container('Tuesday TODO List'),
        itemStatus = false,
        checked = true,
        currentSection,
        itemContent,
        sectionTitle,
        addSectionButton,
        section,
        item,
        addItemButton;
    container.addToDOM();
    sectionTitle = document.getElementById('sectionTitle');
    addSectionButton = document.getElementById('addSection');

    addSectionButton.addEventListener('click', function () {
        if (sectionTitle.value != '') {
            section = new Section(sectionTitle.value);

            section.addToDOM(sectionId);
            container.addSection(section);

            addItemButton = document.getElementById('addItem' + sectionId);
            currentSection = addItemButton.parentElement.parentElement;
            itemContent = document.getElementById('itemContent' + sectionId);

            addItemButton.addEventListener('click', function () {
                if (itemContent.value != '') {
                    item = new Item(itemContent.value, itemStatus);
                    item.addToDOM(currentSection, itemContent, itemId);
                    section.addItem(item);
                    var checkButton = document.getElementById('check' + itemId);
                    var checkLabel = document.getElementById('label' + itemId);
                    checkButton.addEventListener('change', function () {
                        if (checked) {
                            checkLabel.className = 'green';
                        } else {
                            checkLabel.className = '';
                        }

                        checked = !checked;
                    });

                    itemId++;
                }
            });


            sectionId++;
        }

    })

};