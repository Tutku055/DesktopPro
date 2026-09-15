---
trigger: always_on
description: Backend Clean Architecture, CQRS (MediatR), Rich Domain Model, FluentValidation, and EF Core configuration rules.
---

# Backend Architecture & Development Rules

> **These rules are MANDATORY for all C# code under `Backend/src/`. No exceptions.**

## ⛔ NEVER

- Public setters on entities (`public string Name { get; set; }` → **FORBIDDEN**)
- Data Annotations (`[Required]`, `[MaxLength]`, etc.) → **FORBIDDEN**
- Handler, Command/Query, and Validator in the same file → **FORBIDDEN**
- Injecting concrete `DbContext` instead of `IAppDbContext` in controllers → **FORBIDDEN**
- Business logic inside controllers → **FORBIDDEN**
- Missing `[ProducesResponseType]` on any action method → **FORBIDDEN**
- EF Core configuration inside entity classes → **FORBIDDEN**

## ✅ ALWAYS

- Entities must inherit from `BaseEntity`
- All state mutations via domain methods (`Rename(...)`, `Update(...)`) — set `UpdatedAt = DateTime.UtcNow` inside
- Entity constructor: `protected` parameterless for EF + `public` parameterized enforcing domain invariants
- Command / Query / Handler / Validator → each in its **own file** under `Features/{Name}/Commands/{Action}{Entity}/`
- DTOs → `Features/{Name}/DTOs/`
- FluentValidation required for every command/query
- EF Core config via `IEntityTypeConfiguration<T>` → `Persistence/Configurations/`
- Controller: `sealed`, inject `ISender`, `Async` suffix, `CancellationToken` param, all status codes via `[ProducesResponseType]`
- File-scoped namespaces, prefer `sealed`, nullable reference types enabled

## Layer Dependencies

`Domain` ← `Application` ← `Persistence` / `Infrastructure` ← `WebApi`
