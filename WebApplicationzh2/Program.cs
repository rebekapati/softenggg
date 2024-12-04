var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();  //Az API Controllerekhez kell 
builder.Services.AddEndpointsApiExplorer();   //A Swaggerhez kell
builder.Services.AddSwaggerGen();             //A Swaggerhez kell

var app = builder.Build();

if (app.Environment.IsDevelopment()) //A Swagger éles környezetben nem indul
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();   //Ha http-vel nyitják az oldalt, átirányít https-re

app.UseDefaultFiles();       //Ha nincs semmi a domain után, akkor az index.html-t tölti
app.UseStaticFiles();        //A wwwroot mappa tartalmát elérhetővé teszi

app.MapControllers();        //Az API Controllereket elérhetővé teszi

app.Run();
