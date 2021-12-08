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

bool CheckIfWorkingOrWeekendDay(string dayName)
{
    bool dayWorking = true;
    if(dayName.ToLower() == "Saturday".ToLower() || dayName.ToLower() == "Sunday".ToLower())
    {
        dayWorking = false;
    }

    return dayWorking;

}

// return full week
app.MapGet("/week", () => workingDays);

// return specific day of the week
app.MapGet("/week/{index:int}", (int index) => WorkingNotWorkingDayCheck(index));

// add day to week
app.MapPost("/week/addday/{dayName}", (string dayName) => workingDays.Add(dayName));

// check if the day is a working or nonworking day
app.MapGet("week/checkday/{dayName}", (string dayName) => CheckIfWorkingOrWeekendDay(dayName));

app.Run();

