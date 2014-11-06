var specialConsole = (function () {
    function writeLine() {
        if (arguments.length > 1) {
            textWithFormatting(arguments);
        }
        else {
            textWithoutFormatting(arguments);
        }
    }

    return {
        writeLine: writeLine,
        writeError: writeLine,
        writeWarning: writeLine
    }

    function textWithFormatting(arguments) {
        var i,
            pattern = /{[0-9]+}/g,
            placeHolder = arguments[0],
            matches = placeHolder.match(pattern);

        if(arguments.length - 1 != matches.length) {
            throw "Parameters and placeholders cannot be different count";
        }
        for (i = 0; i < matches.length; i++) {
            var currentMatch = matches[i];
            var currentArgument = arguments[i + 1];
            placeHolder = placeHolder.replace(currentMatch, currentArgument)
        }

        console.log(placeHolder);
    }


    function textWithoutFormatting(arguments) {
        var result = arguments[0];
        console.log(result);
    }
})();

specialConsole.writeLine("Message: hello");
specialConsole.writeLine("Message: {0}", "hello");
specialConsole.writeError("Error: {0}", "A fatal error has occurred.");
specialConsole.writeError("Error: {0}, {1}....{2}", "A fatal error has occurred.", "I don't know what", "Fuck it!");
specialConsole.writeWarning("Warning: {0}", "You are not allowed to do that!");

// Next should throw exception "Parameters and placeholders cannot be different count"
// specialConsole.writeError("Error: {0}, {1}", "A fatal error has occurred.", "I don't know what", "Fuck it!");
