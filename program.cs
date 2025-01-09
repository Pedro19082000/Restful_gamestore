using GameStore.Api.Dtos;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();
List<GameDto> games=[
    new(1,
        "SF: II",
        "figthing",
        19.99M,
        new DateOnly(1992,7,15)),
    new(2,
        "FFXIV",
        "RPG",
        59.99M,
        new DateOnly(2010,9,30)),
    new(3,
    "FIFA 23",
    "sport",
    69.99M,
    new DateOnly(2022,9,27)),
];
app.MapGet("games", ()=> games);
app.MapGet("games/{id}", (int id) => games.Find(games => games.Id == id));
//app.MapGet("/", () => "Hello World!");

app.Run();
