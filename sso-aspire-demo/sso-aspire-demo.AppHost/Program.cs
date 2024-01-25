var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.APIDemo>("apidemo");

var weatherApi = builder.AddProject<Projects.AnotherAPIDemo>("weatherapi")
    .WithLaunchProfile("https");

builder.AddProject<Projects.sso_aspire_demo>("sso-aspire-demo")
    .WithReference(weatherApi)
    .WithLaunchProfile("https");

builder.Build().Run();
