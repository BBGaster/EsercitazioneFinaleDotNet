using Microsoft.EntityFrameworkCore;
using Universita.BLL.Services;
using Universita.BLL.Services.Interfaces;
using Universita.DAL;
using Universita.DAL.Repository;
using Universita.DAL.Repository.Interfaces;
using Universita.PL.Configuration;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<UniversityDbContext>(options => {
    options.UseSqlServer(builder.Configuration.GetConnectionString("UniversityDbConnection"));
});


builder.Services.AddAutoMapper(typeof(AutoMapperConfiguration));
builder.Services.AddScoped<IAulaRepository, AulaRepository>();//chiamata per interfaccia per avere la firma dei metodi 
builder.Services.AddScoped<ICorsoRepository, CorsoRepository>();
builder.Services.AddScoped<IDocenteRepository, DocenteRepository>();
builder.Services.AddScoped<IIscrittiRepository, IscrittiRepository>();
builder.Services.AddScoped<ILezioneRepository, LezioneRepository>();
builder.Services.AddScoped<IStudenteRepository, StudenteRepository>();
builder.Services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
builder.Services.AddScoped<IAulaService, AulaService>();
builder.Services.AddScoped<ICorsoServices, CorsoService>();
builder.Services.AddScoped<IDocenteService, DocenteService>();
builder.Services.AddScoped<IIscrittiService, IscrittiService>();
builder.Services.AddScoped<ILezioneServices, LezioneService>();
builder.Services.AddScoped<IStudenteService, StudenteService>();
builder.Services.AddControllers();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
