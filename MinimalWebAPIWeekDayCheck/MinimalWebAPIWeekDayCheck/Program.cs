var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

var workingDays = new List<string> { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday" };

string ReturnDayName(int dayNumber)
{
    int untilFriday = 4;
    string specificDay = "";
    if (dayNumber <= untilFriday)
    {
        specificDay = workingDays[dayNumber];
    }
    else
    {
        specificDay = "You have chosen an incorrect value.";
    };

    return specificDay;
}

bool CheckDayType(string checkDay)
{
    bool dayWorking = true;
    if(checkDay.ToLower() == "Saturday".ToLower() || checkDay.ToLower() == "Sunday".ToLower())
    {
        dayWorking = false;
    }

    return dayWorking;

}

// return full week
app.MapGet("/week", () => workingDays);

// return specific day of the week
app.MapGet("/week/{index:int}", (int index) => ReturnDayName(index));

// add day to week
app.MapPost("/week/addday/{dayName}", (string dayName) => workingDays.Add(dayName));

// check if the day is a working or nonworking day
app.MapGet("week/checkday/{dayName}", (string dayName) => CheckDayType(dayName));

app.Run();

