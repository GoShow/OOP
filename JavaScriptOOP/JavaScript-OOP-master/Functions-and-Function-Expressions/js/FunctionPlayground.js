function getTypeOfVariable(){
    var result = '';

    if(arguments.length <= 0) {
        result = 'No arguments';
    }

    for(var i in arguments) {
        result += 'Argument of position ' + i + ' is of type ' + typeof arguments[i] + "\n";
    }

    console.log(result);
}

getTypeOfVariable(4, 'gdfg', 5.66);
getTypeOfVariable(4, true, 5.66);
getTypeOfVariable();
console.log();

function person(name){
    this.name = name;
    var personName = name;
    console.log('personName in function scope: ' + personName);
}

// name in global scope
person('Ханко от село Усеня');
console.log('personName in global scope: ' + name);

function PersonObj(name){
    var personName = 'This is private name: ' + name;
    this.name = name;

    this.getPersonName = function getName(){
        return  personName;
    }
}

var mira = new PersonObj('Object name: Mira');
// personName is private for PersonObj
console.log(mira.name);
console.log(mira.getPersonName());
console.log(name);
console.log();

var tosho = new PersonObj('Object name: Toshko');
var petarcho = new PersonObj('Petarcho');
PersonObj.call(tosho, 'Tosho already is Gosho');
console.log(tosho.getPersonName());
console.log(petarcho.getPersonName());
