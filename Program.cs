var builder = WebApplication.CreateBuilder(args);



//add services to the controller
builder.Services.AddControllers();

// Add services to the container.
var app = builder.Build();

// Configure the HTTP request pipeline.

//all statements started with use is used to add middleware pipelines
app.UseHttpsRedirection();


//app.UseRouting();
//app.UseAuthentication();
//app.UseAuthorization();
//app.UseHttpsRedirection();


//Routing
//api with controller
app.MapControllers();

//minimal APi routing
//getting without id: GET method
//app.MapGet("/shirt", () =>
//{
//    return "Getting All the shirst";
//});

////getting with id : GET method using id
//app.MapGet("/shirt/{id}", (int id) =>
//{
//    return $"Inserting a shirt: { id}";
//});

////creating : POST method
//app.MapPost("/shirt/", () =>
//{
//    return "Creating a shirt";
//});

////PUT method: Updating
//app.MapPut("/shirt/{id}", (int id) =>
//{
//    return $"Updating a shirt: {id}";
//});

////DELETE method
//app.MapDelete("/shirt/{id}", (int id) =>
//{
//    return $"Deleting a shirt:{id}";
//});

app.Run();