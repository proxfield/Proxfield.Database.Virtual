// See https://aka.ms/new-console-template for more information
using Proxfield.Database.Virtual;
using Proxfield.Database.Virtual.Sample.Models;

Console.WriteLine("Hello, World!");


var doc = new DocumentStore();

doc.AddItem(new User()
{
    Id= "10",
    Name = "Jose"
});

