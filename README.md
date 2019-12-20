# S85SCore
.Net Standard - Primitive Types Extensions.
S85S.Core is a standard .net library contains a useful collection of extensions for primitive types.


# Examples:
Json Extensions
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
Numbers Extensions

```c#     
int value = TextBox1.Text.ToInt();
// returns 0 if error
```

String Extension
```c#     
string str = TextBox1.Text;
bool isEmpty = str.IsEmpty(); 
// returns true if error or null or white space 
// Is Email() to check if it is matching email Regular Expression
```

Date time and Date time range
```c#     
DateTime d = DateTime.Now;
DateTime s = d.StartOfMonth();
DateTime e = d.EndOfMonth();
```

and more...
