# SingleFileApi (single-file C# minimal API)

This repository contains a small, single-file ASP.NET Core minimal API implemented in `SingleFileApi.cs`. The source uses a file-level SDK directive and C# top-level statements so you can run the API directly from the source file with a compatible .NET SDK (no `.csproj` required when the SDK supports projectless runs).

What this example demonstrates
- **Minimal APIs**: concise route handlers and simple endpoint definitions using ASP.NET Core's minimal API programming model.
- **Top-level statements & file SDK directive**: showing how a single C# file can host a runnable web app.
- **Simple HTTP endpoints**: examples of GET and POST handlers and how to bind route and body values.

Requirements
- **.NET SDK**: an SDK that supports running C# source files projectlessly (for example, modern .NET SDKs such as .NET 10+). If your SDK doesn't support this, create a simple SDK-style project (`.csproj`) and run with `dotnet run --project <path-to-csproj>`.

Useful Microsoft documentation
- `dotnet run` (official docs): https://learn.microsoft.com/dotnet/core/tools/dotnet-run
- C# top-level statements: https://learn.microsoft.com/dotnet/csharp/fundamentals/program-structure/top-level-statements
- ASP.NET Core Minimal APIs: https://learn.microsoft.com/aspnet/core/fundamentals/minimal-apis

Run
- From the repository root (recommended):

```powershell
dotnet run .\SingleFileApi.cs
```

- Or from the folder containing the file:

```powershell
dotnet run SingleFileApi.cs
```

If running projectlessly fails with your installed SDK, create a minimal `SingleFileApi.csproj` and run via `dotnet run --project SingleFileApi.csproj`.

What it contains
- `GET /` — returns a short greeting message (e.g. "Hello from .NET 10 on a single file!").
- `GET /time` — returns the server's current time as a formatted string.
- `GET /greet/{name}` — route parameter binding; returns a personalized greeting.
- `POST /echo` — echoes the posted message body back in the response.

Examples
- Get the greeting:

```powershell
curl http://localhost:5000/
```

- Get server time:

```powershell
curl http://localhost:5000/time
```

- Greet someone:

```powershell
curl http://localhost:5000/greet/Alice
```

- Echo a message (text/plain body):

```powershell
curl -X POST http://localhost:5000/echo -H "Content-Type: text/plain" --data "Hello from curl"
```

Or with PowerShell `Invoke-RestMethod`:

```powershell
Invoke-RestMethod -Method Post -Uri http://localhost:5000/echo -Body "Hello from PowerShell" -ContentType "text/plain"
```

Notes
- The example is intentionally tiny and stateless — it does not persist data.
- The file includes a file-scoped SDK directive (e.g. `#:sdk Microsoft.NET.Sdk.Web`) and top-level statements. If your environment doesn't support running a single C# source file directly, add a `.csproj` as noted above.