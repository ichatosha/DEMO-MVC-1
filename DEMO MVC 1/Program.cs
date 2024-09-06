var builder = WebApplication.CreateBuilder(args);

// add any services you need to the container before build

builder.Services.AddControllers();          // register the built in apis services in the container 
builder.Services.AddControllersWithViews(); // register the built in MVC services in the container 
//builder.Services.AddRazorPages();         // register the built in Razor services in the container 
//builder.Services.AddMvc();                // register the built in all web services in the container 

var app = builder.Build();

//app.MapGet("/", () => "Hello World!");
app.MapGet("/hesham", () => "Hello Hesham!");
app.MapGet("/signIn", SignIn);

// manage the route :
app.MapControllerRoute
    (
    name: "Default",
    pattern: "/{controller=Home}/{action=Index}/{id?}"
    );

app.Run();

static string SignIn()
{
    return "Sign In Please";
}