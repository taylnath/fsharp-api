namespace ClassLibrary1

    module Library =
        open ListTools
        
        let greeting = "hello"
        let pizzas = [
            "pineapple"
            "cheese"
            "pepperoni"
            "supreme"
            "barbeque Chicken"
            "mushroom"
            "buffalo Chicken"
            "margherita"
            "chicken Alfredo"
            "pesto"
            "veggie"
            "sausage"
        ]
        
        let suggestions = [
            "What about a"
            "Have you tried a"
            "Wouldn't you love some"
            "Why not get a"
            "Would you like a"
            "Can we get some"
        ]
        
        let meals = [
            "breakfast"
            "lunch"
            "dinner"
            "brunch"
            "a snack"
            "a midnight snack"
        ]
        
        let descriptors = [
            "delicious"
            "scrumptious"
            "marvelous"
            "amazing"
            "savory"
            "delectable"
        ]
        
        let randomPizza () =
            randomEltOrDefault pizzas "cheese"
            
        let randomSuggestion () =
            randomEltOrDefault suggestions "Would you like a"
        
        let randomMeal () =
            randomEltOrDefault meals "dinner"
            
        let randomDescriptor () =
            randomEltOrDefault descriptors "delicious"
            
        let getPizza () =
            $"{randomSuggestion()} {randomDescriptor()} {randomPizza()} pizza for {randomMeal()}?"
            