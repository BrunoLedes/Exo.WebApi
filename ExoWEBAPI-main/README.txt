# CRUD de Usuários - Exo.WebApi

Arquivos para adicionar ao seu projeto existente Exo.WebApi:

- Coloque `UsuariosController.cs` em `Controllers/`
- Coloque `Usuario.cs` em `Models/`
- Coloque `UsuarioRepository.cs` em `Repositories/`

Depois, adicione no arquivo `ExoContext.cs`:
```csharp
public DbSet<Usuario> Usuarios { get; set; }
```

E no `Program.cs`, antes de `var app = builder.Build();`:
```csharp
builder.Services.AddTransient<UsuarioRepository, UsuarioRepository>();
```

Execute no terminal:
```
dotnet restore
dotnet build
dotnet run
```

Teste com:
- GET, POST, PUT, DELETE em `/api/usuarios`
