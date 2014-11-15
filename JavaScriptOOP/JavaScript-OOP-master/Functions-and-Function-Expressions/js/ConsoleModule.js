var ConsoleModule = function ConsoleModule() {
    function getArrayWithNewKeys(arrayWithArguments) {
        var i,
            key,
            arrayWithNewKeys = new Array();

        for (i = 1; i < arrayWithArguments.length; i++) {
            key = '{' + (i - 1) + '}';
            arrayWithNewKeys[key] = getToStringOfObject(arrayWithArguments[i]);
        }

        return arrayWithNewKeys;
    }

    function replacePlaceholder(writeArguments) {
        var key,
            result = writeArguments[0],
            arrayWithNewKeys = getArrayWithNewKeys(writeArguments);

        for (key in arrayWithNewKeys) {
            result = result.replace(key, arrayWithNewKeys[key]);
        }

        return result;
    }

    function getToStringOfObject(obj) {
        if (typeof(obj) == "string") {
            return obj;
        } else {
            return obj.toString();
        }
    }

    function getPrintString(argumentsForPrint) {
        var arrayWithNewKeys,
            result = '';

        if (argumentsForPrint.length == 1) {
            result = argumentsForPrint[0];
        }

        if (argumentsForPrint.length > 1) {
            result = replacePlaceholder(argumentsForPrint);
        }

        return result;
    }

    function writeLine(){
        console.log(getPrintString(arguments));
    }

    function writeError(){
        console.error(getPrintString(arguments));
    }

    function writeWarning(){
        console.warn(getPrintString(arguments));
    }

    return {
        writeLine: writeLine,
        writeError: writeError,
        writeWarning: writeWarning
    }
}();

var array = ['one', 'two', 'tree'];

ConsoleModule.writeLine("Message: hello");
ConsoleModule.writeLine("array elements: {0}", array);
ConsoleModule.writeLine("{0}, {1}, {2}", true, "hello", 7);
ConsoleModule.writeError("Error: {0}", "A fatal error has occurred.");
ConsoleModule.writeWarning("Warning: {0}", "You are not allowed to do that!");
