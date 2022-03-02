`dotnet run` in the file you want to run to see the console

`static`: is used to declare a method that can be called without creating an instance of the class.
    for example the Math. class, you dont have to do int x = new Math...
    isntead you can just call Math.something and thats because of the static keyword
    if the static keyword isnt used, you have to create an instance of the class before you can call the method

`abstract`: modifier that indicates missing compopents or incomplete classes
     this means that other classes can inherit from this class, but this class cannot be instantiated

`void`: doesnt return any value

`<String>`: needs to import `using System.Collections.Generic;`, this is for dynamic size object, unliked arrays that need to have a set size.