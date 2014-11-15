function processRestaurantManagerCommands(commands) {
    'use strict';

    Object.prototype.extend = function (parent) {
        this.prototype = Object.create(parent.prototype);
        this.prototype.constructor = this;
    }

    String.prototype.isString = function () {
        return typeof(this) === 'string';
    }

    var RestaurantEngine = (function () {
        var _restaurants,
            _recipes,
            globalConstants;

        function initialize() {
            _restaurants = [];
            _recipes = [];
            globalConstants = {
                UNIT_MILLILITERS: 'ml',
                UNIT_GRAMS: 'g'
            };
        }

        var Restaurant = (function () {
            function Restaurant(name, location) {
                this.setName(name);
                this.setLocation(location);
                this._recipes = [];
            }

            Restaurant.prototype.getName = function () {
                return this._name;
            }

            Restaurant.prototype.setName = function (name) {
                if (!name) {
                    throw new Error('Name can not be null or empty string!')
                }
                this._name = name;
            }

            Restaurant.prototype.getLocation = function () {
                return this._location;
            }

            Restaurant.prototype.setLocation = function (location) {
                this._location = location;
            }

            Restaurant.prototype.addRecipe = function (recipe) {
                if (!(recipe instanceof Recipe)) {
                    throw new TypeError('Parameter should be instance of Recipe')
                }

                this._recipes.push(recipe);
            }

            Restaurant.prototype.removeRecipe = function (recipe) {
                var index = this._recipes.indexOf(recipe);
                this._recipes.splice(index, 1);
            }

            var formatRecipes = function () {
                var drinks,
                    salads,
                    mainCourses,
                    desserts;
                drinks = getRecipesByType.call(this, Drink);
                salads = getRecipesByType.call(this, Salad);
                mainCourses = getRecipesByType.call(this, MainCourse);
                desserts = getRecipesByType.call(this, Dessert);

                var result = '';
                if(drinks.length){
                    result += '~~~~~ DRINKS ~~~~~' + '\n';
                    drinks.forEach(function (drink){
                        result += drink.toString();
                    })
                }

                if(salads.length){
                    result += '~~~~~ SALADS ~~~~~' + '\n';
                    salads.forEach(function (salad){
                        result += salad.toString();
                    })
                }

                if(mainCourses.length){
                    result += '~~~~~ MAIN COURSES ~~~~~' + '\n';
                    mainCourses.forEach(function (mainCourse){
                        result += mainCourse.toString();
                    })
                }

                if(desserts.length){
                    result += '~~~~~ DESSERTS ~~~~~' + '\n';
                    desserts.forEach(function (dessert){
                        result += dessert.toString();
                    })
                }

                return result;
            }

            var getRecipesByType = function (type){
                return this._recipes.filter(function(recipe){
                    return recipe instanceof type;
                })
            };

            Restaurant.prototype.printRestaurantMenu = function () {
                var result = '***** ' + this.getName() + ' - ' + this.getLocation() + ' ******' + '\n';
                if (this._recipes.length <= 0) {
                    result += 'No recipes... yet'
                } else {
                    result += formatRecipes.call(this);
                }

                return result;
            }

            return Restaurant;
        }());

        var Recipe = (function () {
            function Recipe(name, price, calories, quantity, time, unit) {
                if (this.constructor === Recipe) {
                    throw new Error('Recipe can not have an instance')
                }

                this.setName(name);
                this.setPrice(price);
                this.setCalories(calories);
                this.setQuantity(quantity);
                this.setTime(time);
                this.setUnit(unit);
            }

            Recipe.prototype.getName = function () {
                return this._name;
            }

            Recipe.prototype.setName = function (name) {
                this._name = name;
            }

            Recipe.prototype.getPrice = function () {
                return this._price;
            }

            Recipe.prototype.setPrice = function (price) {
                this._price = price;
            }

            Recipe.prototype.getCalories = function () {
                return this._calories;
            }

            Recipe.prototype.setCalories = function (calories) {
                this._calories = calories;
            }

            Recipe.prototype.getQuantity = function () {
                return this._quantity;
            }

            Recipe.prototype.setQuantity = function (quantity) {
                this._quantity = quantity;
            }

            Recipe.prototype.getUnit = function () {
                return this._unit;
            }

            Recipe.prototype.setUnit = function (unit) {
                this._unit = unit;
            }

            Recipe.prototype.getTime = function () {
                return this._time;
            }

            Recipe.prototype.setTime = function (time) {
                this._time = time;
            }

            Recipe.prototype.toString = function (){
                var result = '==  ' + this.getName() + ' == $' + this.getPrice().toFixed(2) + '\n' +
                'Per serving: ' + this.getQuantity() + ' '+ this.getUnit() + ', ' + this.getCalories() + ' kcal' + '\n' +
                'Ready in ' + this.getTime() + ' minutes';

            }

            return Recipe
        }());

        var Drink = (function () {
            function Drink(name, price, calories, quantity, time, isCarbonated) {
                Recipe.call(this, name, price, calories, quantity, globalConstants.UNIT_MILLILITERS, time);
                this.set(isCarbonated);
            }

            Drink.extend(Recipe);

            Drink.prototype.setCalories = function (calories) {
                if (calories > 100) {
                    throw new Error('Calories must be 100 or less');
                }
                this._calories = calories;
            }

            Drink.prototype.getIsCarbonated = function () {
                return this._isCarbonated;
            }

            Drink.prototype.setIsCarbonated = function (isCarbonated) {
                this._isCarbonated = isCarbonated;
            }

            return Drink;
        }());

        var Meal = (function () {
            function Meal(name, price, calories, quantity, time, isVegan) {
                Recipe.call(this, name, price, calories, quantity, globalConstants.UNIT_GRAMS, time);
                this.set(isVegan);
            }

            Meal.extend(Recipe);

            Meal.prototype.getIsVegan = function () {
                return this._isVegan;
            }

            Meal.prototype.setIsVegan = function (isVegan) {
                this._isVegan = isVegan;
            }

            Meal.prototype.toggleVegan = function () {
                this._isVegan = !this._isVegan;
            }

            return Meal;
        }());

        var Dessert = (function () {

            function Dessert(name, price, calories, quantity, time, isVegan) {
                Meal.call(this, name, price, calories, quantity, time, isVegan);
                this._withSugar = true;
            }

            Dessert.extend(Meal);

            Dessert.prototype.toggleSugar = function () {
                this._withSugar = !this._withSugar;
            }

            return Dessert;
        }());

        var MainCourse = (function () {
            function MainCourse(name, price, calories, quantity, time, isVegan, type) {
                Meal.call(this, name, price, calories, quantity, time, isVegan);
                this.setType(type)
            }

            MainCourse.extend(Meal);

            MainCourse.prototype.getType = function () {
                return this._type;
            }

            MainCourse.prototype.setType = function (type) {
                this._type = type
            }

            return MainCourse;
        }());

        var Salad = (function () {
            function Salad(name, price, calories, quantity, time, containsPasta) {
                Meal.call(this, name, price, calories, quantity, time);
                this.setContainsPasta(containsPasta);
            }

            Salad.extend(Meal);

            Salad.prototype.getContainsPasta = function () {
                return this._containsPasta;
            }

            Salad.prototype.setContainsPasta = function (containsPasta) {
                this._containsPasta = containsPasta
            }

            return Salad;
        }());

        var Command = (function () {

            function Command(commandLine) {
                this._params = new Array();
                this.translateCommand(commandLine);
            }

            Command.prototype.translateCommand = function (commandLine) {
                var self, paramsBeginning, name, parametersKeysAndValues;
                self = this;
                paramsBeginning = commandLine.indexOf("(");

                this._name = commandLine.substring(0, paramsBeginning);
                name = commandLine.substring(0, paramsBeginning);
                parametersKeysAndValues = commandLine
                    .substring(paramsBeginning + 1, commandLine.length - 1)
                    .split(";")
                    .filter(function (e) {
                        return true
                    });

                parametersKeysAndValues.forEach(function (p) {
                    var split = p
                        .split("=")
                        .filter(function (e) {
                            return true;
                        });
                    self._params[split[0]] = split[1];
                });
            }

            return Command;
        }());

        function createRestaurant(name, location) {
            _restaurants[name] = new Restaurant(name, location);
            return "Restaurant " + name + " created\n";
        }

        function createDrink(name, price, calories, quantity, timeToPrepare, isCarbonated) {
            _recipes[name] = new Drink(name, price, calories, quantity, timeToPrepare, isCarbonated);
            return "Recipe " + name + " created\n";
        }

        function createSalad(name, price, calories, quantity, timeToPrepare, containsPasta) {
            _recipes[name] = new Salad(name, price, calories, quantity, timeToPrepare, containsPasta);
            return "Recipe " + name + " created\n";
        }

        function createMainCourse(name, price, calories, quantity, timeToPrepare, isVegan, type) {
            _recipes[name] = new MainCourse(name, price, calories, quantity, timeToPrepare, isVegan, type);
            return "Recipe " + name + " created\n";
        }

        function createDessert(name, price, calories, quantity, timeToPrepare, isVegan) {
            _recipes[name] = new Dessert(name, price, calories, quantity, timeToPrepare, isVegan);
            return "Recipe " + name + " created\n";
        }

        function toggleSugar(name) {
            var recipe;

            if (!_recipes.hasOwnProperty(name)) {
                throw new Error("The recipe " + name + " does not exist");
            }
            recipe = _recipes[name];

            if (recipe instanceof Dessert) {
                recipe.toggleSugar();
                return "Command ToggleSugar executed successfully. New value: " + recipe._withSugar.toString().toLowerCase() + "\n";
            } else {
                return "The command ToggleSugar is not applicable to recipe " + name + "\n";
            }
        }

        function toggleVegan(name) {
            var recipe;

            if (!_recipes.hasOwnProperty(name)) {
                throw new Error("The recipe " + name + " does not exist");
            }

            recipe = _recipes[name];
            if (recipe instanceof Meal) {
                recipe.toggleVegan();
                return "Command ToggleVegan executed successfully. New value: " +
                    recipe._isVegan.toString().toLowerCase() + "\n";
            } else {
                return "The command ToggleVegan is not applicable to recipe " + name + "\n";
            }
        }

        function printRestaurantMenu(name) {
            var restaurant;

            if (!_restaurants.hasOwnProperty(name)) {
                throw new Error("The restaurant " + name + " does not exist");
            }

            restaurant = _restaurants[name];
            return restaurant.printRestaurantMenu();
        }

        function addRecipeToRestaurant(restaurantName, recipeName) {
            var restaurant, recipe;

            if (!_restaurants.hasOwnProperty(restaurantName)) {
                throw new Error("The restaurant " + restaurantName + " does not exist");
            }
            if (!_recipes.hasOwnProperty(recipeName)) {
                throw new Error("The recipe " + recipeName + " does not exist");
            }

            restaurant = _restaurants[restaurantName];
            recipe = _recipes[recipeName];
            restaurant.addRecipe(recipe);
            return "Recipe " + recipeName + " successfully added to restaurant " + restaurantName + "\n";
        }

        function removeRecipeFromRestaurant(restaurantName, recipeName) {
            var restaurant, recipe;

            if (!_recipes.hasOwnProperty(recipeName)) {
                throw new Error("The recipe " + recipeName + " does not exist");
            }
            if (!_restaurants.hasOwnProperty(restaurantName)) {
                throw new Error("The restaurant " + restaurantName + " does not exist");
            }

            restaurant = _restaurants[restaurantName];
            recipe = _recipes[recipeName];
            restaurant.removeRecipe(recipe);
            return "Recipe " + recipeName + " successfully removed from restaurant " + restaurantName + "\n";
        }

        function executeCommand(commandLine) {
            var cmd, params, result;
            cmd = new Command(commandLine);
            params = cmd._params;

            switch (cmd._name) {
                case 'CreateRestaurant':
                    result = createRestaurant(params["name"], params["location"]);
                    break;
                case 'CreateDrink':
                    result = createDrink(params["name"], parseFloat(params["price"]), parseInt(params["calories"]),
                        parseInt(params["quantity"]), params["time"], parseBoolean(params["carbonated"]));
                    break;
                case 'CreateSalad':
                    result = createSalad(params["name"], parseFloat(params["price"]), parseInt(params["calories"]),
                        parseInt(params["quantity"]), params["time"], parseBoolean(params["pasta"]));
                    break;
                case "CreateMainCourse":
                    result = createMainCourse(params["name"], parseFloat(params["price"]), parseInt(params["calories"]),
                        parseInt(params["quantity"]), params["time"], parseBoolean(params["vegan"]), params["type"]);
                    break;
                case "CreateDessert":
                    result = createDessert(params["name"], parseFloat(params["price"]), parseInt(params["calories"]),
                        parseInt(params["quantity"]), params["time"], parseBoolean(params["vegan"]));
                    break;
                case "ToggleSugar":
                    result = toggleSugar(params["name"]);
                    break;
                case "ToggleVegan":
                    result = toggleVegan(params["name"]);
                    break;
                case "AddRecipeToRestaurant":
                    result = addRecipeToRestaurant(params["restaurant"], params["recipe"]);
                    break;
                case "RemoveRecipeFromRestaurant":
                    result = removeRecipeFromRestaurant(params["restaurant"], params["recipe"]);
                    break;
                case "PrintRestaurantMenu":
                    result = printRestaurantMenu(params["name"]);
                    break;
                default:
                    throw new Error('Invalid command name: ' + cmdName);
            }

            return result;
        }

        function parseBoolean(value) {
            switch (value) {
                case "yes":
                    return true;
                case "no":
                    return false;
                default:
                    throw new Error("Invalid boolean value: " + value);
            }
        }

        return {
            initialize: initialize,
            executeCommand: executeCommand
        };
    }());


    // Process the input commands and return the results
    var results = '';
    RestaurantEngine.initialize();
    commands.forEach(function (cmd) {
        if (cmd != "") {
            try {
                var cmdResult = RestaurantEngine.executeCommand(cmd);
                results += cmdResult;
            } catch (err) {
                results += err.message + "\n";
            }
        }
    });

    return results.trim();
}

// ------------------------------------------------------------
// Read the input from the console as array and process it
// Remove all below code before submitting to the judge system!
// ------------------------------------------------------------

(function () {
    var arr = [];
    if (typeof (require) == 'function') {
        // We are in node.js --> read the console input and process it
        require('readline').createInterface({
            input: process.stdin,
            output: process.stdout
        }).on('line', function (line) {
            arr.push(line);
        }).on('close', function () {
            console.log(processRestaurantManagerCommands(arr));
        });
    }
})()
