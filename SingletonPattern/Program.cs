// See https://aka.ms/new-console-template for more information
using SingletonPattern;

var singleton1 = Singleton.Instance;
singleton1.Property = "first val";
var singleton2 = Singleton.Instance;
singleton2.Property = "second val";

var singleton3 = Singleton.Instance;
Console.WriteLine(singleton3.Property);