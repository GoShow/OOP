function person() {
    var argumentString = "arguments",
        result,
        type;

    if (arguments.length == 1) {
        argumentString = 'argument';
    }

    result = 'Person invoked with ' + arguments.length + ' ' + argumentString + '.';
    console.log(result);
    for (var argument in arguments) {
        type = typeof arguments[argument];
        console.log("Argument: " + arguments[argument] + " is " + type)
    }

    console.log('The "this" object: ' + this + '\n');
}

person("Ivan");
person("Ivan", 25)


function outer() {
    // Only for showing this object from inside functional scope
    this.getTheThisObject = function() {
        console.log('The "this" object from inside functional scope and over object: ' + this + '\n');
    };
}

var outerObj = new outer();
outerObj.getTheThisObject();

person.call({name: "Fred", age: 25}, ".call", 5);
person.apply({name: "Barin"}, [".apply", 23, 12, 5])