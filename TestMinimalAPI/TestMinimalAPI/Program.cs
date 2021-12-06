var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

var listOfStudents = new List<string>();


var message = "Hello Djole";

app.MapGet("/", () => "This is the homepage");  

app.MapGet("/hello", (string name) => $"Hello {name}!");

app.MapGet("/message", ()=> message);

app.MapGet("/student/{index:int}", (int index) => $"Searched student is: {listOfStudents[index]}");

app.MapPost("/student", (string name) => listOfStudents.Add(name));

app.Run();

