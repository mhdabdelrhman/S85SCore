# S85SCore
.Net Standard - Primitive Types Extensions.
S85S.Core is a standard .net library contains a useful collection of extensions for primitive types.


# Examples:
```c#
class Person
  {
    public string Name { get; set; }
    public int Age { get; set; }
  }
        
Person p = new Person { Name = "Lana", Age = 25 };
string json = p.ToJSON();
Person fromJson = json.FromJSON<Person>();
```
