using Poc.Net.Aot.Application.Interfaces.Services;
using Poc.Net.Aot.Domain.Models;
using Poc.Net.Aot.Domain.Serializers;
using Poc.Net.Aot.Infrastructure;

var builder = WebApplication.CreateSlimBuilder(args);
builder.Services.RegisterContainer(builder.Configuration)
                .ConfigureHttpJsonOptions(options =>
                {
                    options.SerializerOptions.TypeInfoResolverChain.Insert(0, EmployeeJsonSerializerContext.Default);
                });

var app = builder.Build();

var employee = app.MapGroup("api/employee");

employee.MapGet("/", async (IEmployeeService _service) =>
{
    var employees = await _service.GetAll();

    return Results.Ok(employees);
});

employee.MapPost("/", async (EmployeeDto employee, IEmployeeService _service) =>
{
    await _service.Insert(employee);
    return Results.Ok();
});

app.Run();
