var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

var workingDays = new List<string> { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday" };

string WorkingNotWorkingDayCheck(int indexNumber)
{
    string dayInfo = "";
    if (indexNumber <= 4)
    {
        dayInfo = workingDays[indexNumber];
    }
    else
    {
        dayInfo = "You have chosen an incorrect value.";
    };

    return dayInfo;
}


app.MapGet("/week", () => workingDays);

app.MapGet("/week{index:int}", (int index) => WorkingNotWorkingDayCheck(index));

app.MapPost("/week/", (string dayName) => workingDays.Add(dayName));
//app.MapPost("/student", (string name) => listOfStudents.Add(name));
app.Run();

