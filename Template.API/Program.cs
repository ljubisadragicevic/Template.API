using Autofac;
using Autofac.Extensions.DependencyInjection;
using AutoMapper;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using Template.Dependency;
using Template.Logic;
using Template.Logic.Interface;
using Template.Mapper;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

builder.Host.UseServiceProviderFactory(new AutofacServiceProviderFactory());

builder.Services.AddAutoMapper(typeof(AutoMapperProfile));

builder.Host.ConfigureContainer<ContainerBuilder>(containerBuilder =>
{
    DependencyInjectionConfig.ConfigureContainer(containerBuilder);
});

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

