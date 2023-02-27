using HRM.Interview.ApplicationCore.Contract.Respository;
using HRM.Interview.ApplicationCore.Contract.Service;
using HRM.Interview.Infrastructure.Data;
using HRM.Interview.Infrastructure.Repository;
using HRM.Interview.Infrastructure.Service;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<InterviewDbContext>(option =>
{
    option.UseSqlServer(builder.Configuration.GetConnectionString("InterviewApiDb"));
    //option.UseSqlServer(Environment.GetEnvironmentVariable("InterviewApiDb"));
});

//Dependency injection for repo
builder.Services.AddScoped<ISingleInterviewRepositoryAsync, SingleInterviewRepositoryAsync>();
builder.Services.AddScoped<IInterviewTypeRepositoryAsync, InterviewTypeRepositoryAsync>();
builder.Services.AddScoped<IInterviewerRepositoryAsync, InterviewerRepositoryAsync>();
builder.Services.AddScoped<IInterviewFeedbackRepositoryAsync, InterviewFeedbackRepositoryAsync>();
builder.Services.AddScoped<IRecruiterRepositoryAsync, RecruiterRepositoryAsync>();

//Dependency injection for service
builder.Services.AddScoped<ISingleInterviewServiceAsync, SingleInterviewServiceAsync>();
builder.Services.AddScoped<IInterviewTypeServiceAsync, InterviewTypeServiceAsync>();
builder.Services.AddScoped<IInterviewerServiceAsync, InterviewerServiceAsync>();
builder.Services.AddScoped<IInterviewFeedbackServiceAsync, InterviewFeedbackServiceAsync>();
builder.Services.AddScoped<IRecruiterServiceAsync, RecruiterServiceAsync>();

builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(policy =>
    {
        policy.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod();
    });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();

