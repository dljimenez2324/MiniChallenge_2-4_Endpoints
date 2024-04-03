var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

// Sum Endpoint
app.MapGet("/sumOfTwo", (double a, double b) => {
    
    double sum = a + b;
   
    string result = "The sum of " + a + " and " + b + " is " + sum + ".";
    return result;
});

// Name & Awake time Endpoint
app.MapGet("/oneSentence", (string yourName, string timeYouAwoke) => {
    
    string result = "Hello " + yourName + "! I see you woke up at " + timeYouAwoke + ". I hope you are well rested! Go make that money!";
    return result;
});

// Greater than Less Than Statements Endpoint
app.MapGet("/greaterThanLessThanEqual", (double a, double b) => {
    
    // establish two results
    string resultOne = "";
    string resultTwo = "";

    // check for comparisons
    if (a > b){
        resultOne = a + " is greater than " + b + "!";
        resultTwo = b + " is less than " + a + "!";
    }

    else if (b > a){
        resultOne = b + " is greater than " + a + "!";
        resultTwo = a + " is less than " + b + "!";   
    }

    else {
        resultOne = b + " is equal to " + a + "!";
        resultTwo = a + " is equal to " + b + "!";
    }
    
    string statement = resultOne + "\n" + resultTwo;
    return statement;
});


app.Run();


