# Graph Report - DesktopPro  (2026-09-12)

## Corpus Check
- 88 files · ~86,337 words
- Verdict: corpus is large enough that graph structure adds value.

## Summary
- 577 nodes · 803 edges · 47 communities (37 shown, 8 thin omitted)
- Extraction: 99% EXTRACTED · 1% INFERRED · 0% AMBIGUOUS · INFERRED: 5 edges (avg confidence: 0.86)
- Token cost: 0 input · 0 output

## Graph Freshness
- Built from commit: `4fd892dc`
- Run `git rev-parse HEAD` and compare to check if the graph is stale.
- Run `graphify update .` after code changes (no API cost).

## Community Hubs (Navigation)
- CreateWorkspaceCommand
- CreateWorkspaceDialog.tsx
- InitialCreate
- Workspace
- package.json
- ValidationBehavior
- VirtualFile
- client.ts
- DesktopPro.Application.csproj
- compilerOptions
- components.json
- compilerOptions
- dependencies
- devDependencies
- DesktopPro.Domain.Entities
- IAppDbContext
- AppDbContext
- AppUser
- http
- AiTriageSuggestion
- tsconfig.json
- WorkspaceGroup
- GetWorkspacesQuery
- Workspace
- vite-env.d.ts
- Graphify Knowledge Graph Rule
- Desktop Pro HTML Entry
- App Vector Icons
- Vite React Template Documentation
- DesktopPro Application Icon
- WorkspaceGroup
- FileWorkspaceLink
- RemoveIconPathAndAddWorkspaceIconName
- AddOriginalPathToVirtualFile
- DesktopPro.Persistence.Migrations
- IsolatedVaultArchitecture
- .BuildModel
- .BuildTargetModel
- BaseEntity
- .CreateWorkspaceAsync
- WorkspaceDetailDto
- DesktopPro.Application.Features.Workspaces.DTOs
- GetWorkspaceByIdQuery
- CreateWorkspaceCommandValidator
- CreateWorkspaceDto

## God Nodes (most connected - your core abstractions)
1. `VirtualFile` - 28 edges
2. `IAppDbContext` - 20 edges
3. `Workspace` - 19 edges
4. `compilerOptions` - 19 edges
5. `FileWorkspaceLink` - 18 edges
6. `AppDbContext` - 18 edges
7. `DesktopPro.Domain.Entities` - 16 edges
8. `AppUser` - 15 edges
9. `WorkspaceGroup` - 15 edges
10. `compilerOptions` - 15 edges

## Surprising Connections (you probably didn't know these)
- `Desktop Pro HTML Entry` --references--> `Favicon Vector Asset`  [EXTRACTED]
  Frontend/index.html → Frontend/public/favicon.svg
- `IAppDbContext` --references--> `AiTriageSuggestion`  [EXTRACTED]
  Backend/src/Core/DesktopPro.Application/Common/Interfaces/IAppDbContext.cs → Backend/src/Core/DesktopPro.Domain/Entities/AiTriageSuggestion.cs
- `IAppDbContext` --references--> `VirtualFile`  [EXTRACTED]
  Backend/src/Core/DesktopPro.Application/Common/Interfaces/IAppDbContext.cs → Backend/src/Core/DesktopPro.Domain/Entities/AiTriageSuggestion.cs
- `IAppDbContext` --references--> `AppUser`  [EXTRACTED]
  Backend/src/Core/DesktopPro.Application/Common/Interfaces/IAppDbContext.cs → Backend/src/Core/DesktopPro.Domain/Entities/AppUser.cs
- `IAppDbContext` --references--> `FileWorkspaceLink`  [EXTRACTED]
  Backend/src/Core/DesktopPro.Application/Common/Interfaces/IAppDbContext.cs → Backend/src/Core/DesktopPro.Domain/Entities/FileWorkspaceLink.cs

## Import Cycles
- None detected.

## Communities (47 total, 8 thin omitted)

### Community 0 - "CreateWorkspaceCommand"
Cohesion: 0.18
Nodes (10): CancellationToken, Task, Guid, CreateWorkspaceCommand, CancellationToken, Guid, Task, CreateWorkspaceCommandHandler (+2 more)

### Community 1 - "CreateWorkspaceDialog.tsx"
Cohesion: 0.06
Nodes (45): App(), AppSidebar(), AppSidebarProps, MainLayout(), MainLayoutProps, SidebarContext, SidebarContextValue, useSidebar() (+37 more)

### Community 2 - "InitialCreate"
Cohesion: 0.18
Nodes (8): DateTime, Guid, MigrationBuilder, DateTime, Guid, ModelBuilder, InitialCreate, Migration

### Community 3 - "Workspace"
Cohesion: 0.13
Nodes (11): DateTime, Guid, ICollection, Workspace, AppUserId, ExpiresAtUtc, FileLinks, IconName (+3 more)

### Community 4 - "package.json"
Cohesion: 0.06
Nodes (33): name, private, scripts, build, dev, lint, preview, type (+25 more)

### Community 5 - "ValidationBehavior"
Cohesion: 0.07
Nodes (20): CancellationToken, Task, ValidationBehavior, IServiceCollection, DependencyInjection, CancellationToken, GlobalExceptionHandler, DesktopPro.Persistence (+12 more)

### Community 6 - "VirtualFile"
Cohesion: 0.07
Nodes (20): Guid, ICollection, VirtualFile, AppUserId, Extension, FileHash, FileName, FileSize (+12 more)

### Community 7 - "client.ts"
Cohesion: 0.17
Nodes (14): apiClient, RFC-7807, ENV, useWorkspace(), workspaceDetailKey(), workspaceKeys, WorkspaceItemProps, CreateWorkspaceDto (+6 more)

### Community 8 - "DesktopPro.Application.csproj"
Cohesion: 0.11
Nodes (19): net10.0, Microsoft.NET.Sdk, net10.0, Microsoft.NET.Sdk, net10.0, Microsoft.NET.Sdk, net10.0, Microsoft.EntityFrameworkCore.Tools (10.0.11) (+11 more)

### Community 9 - "compilerOptions"
Cohesion: 0.10
Nodes (20): compilerOptions, allowArbitraryExtensions, allowImportingTsExtensions, erasableSyntaxOnly, jsx, lib, module, moduleDetection (+12 more)

### Community 10 - "components.json"
Cohesion: 0.09
Nodes (21): aliases, components, hooks, lib, ui, utils, iconLibrary, menuAccent (+13 more)

### Community 11 - "compilerOptions"
Cohesion: 0.12
Nodes (16): compilerOptions, allowImportingTsExtensions, erasableSyntaxOnly, lib, module, moduleDetection, noEmit, noFallthroughCasesInSwitch (+8 more)

### Community 12 - "dependencies"
Cohesion: 0.12
Nodes (16): dependencies, axios, class-variance-authority, clsx, cn, @fontsource-variable/geist, @fontsource-variable/newsreader, lucide-react (+8 more)

### Community 13 - "devDependencies"
Cohesion: 0.12
Nodes (16): devDependencies, autoprefixer, eslint, @eslint/js, eslint-plugin-react-hooks, eslint-plugin-react-refresh, globals, postcss (+8 more)

### Community 14 - "DesktopPro.Domain.Entities"
Cohesion: 0.24
Nodes (3): DesktopPro.Application.Common.Interfaces, DesktopPro.Domain.Entities, DesktopPro.Persistence.Configurations

### Community 15 - "IAppDbContext"
Cohesion: 0.15
Nodes (11): DbSet, IAppDbContext, AiTriageSuggestions, AppUsers, FileWorkspaceLinks, VirtualFiles, WorkspaceGroups, Workspaces (+3 more)

### Community 16 - "AppDbContext"
Cohesion: 0.18
Nodes (10): DbSet, ModelBuilder, AppDbContext, AiTriageSuggestions, AppUsers, FileWorkspaceLinks, VirtualFiles, WorkspaceGroups (+2 more)

### Community 17 - "AppUser"
Cohesion: 0.14
Nodes (11): VirtualFile, DateTime, AppUser, LastLoginDateUtc, PasswordHash, Username, EntityTypeBuilder, AppUserConfiguration (+3 more)

### Community 18 - "http"
Cohesion: 0.20
Nodes (9): ASPNETCORE_ENVIRONMENT, applicationUrl, commandName, dotnetRunMessages, environmentVariables, launchBrowser, profiles, http (+1 more)

### Community 19 - "AiTriageSuggestion"
Cohesion: 0.20
Nodes (8): Guid, AiTriageSuggestion, SuggestedName, SuggestedWorkspaceId, SuggestedWorkspaceName, VirtualFileId, EntityTypeBuilder, AiTriageSuggestionConfiguration

### Community 20 - "tsconfig.json"
Cohesion: 0.40
Nodes (4): compilerOptions, paths, files, references

### Community 21 - "WorkspaceGroup"
Cohesion: 0.67
Nodes (3): WorkspaceGroup, EntityTypeBuilder, WorkspaceGroupConfiguration

### Community 22 - "GetWorkspacesQuery"
Cohesion: 0.21
Nodes (11): DateTime, Guid, WorkspaceDto, Guid, IReadOnlyList, GetWorkspacesQuery, CancellationToken, IReadOnlyList (+3 more)

### Community 23 - "Workspace"
Cohesion: 0.67
Nodes (3): Workspace, EntityTypeBuilder, WorkspaceConfiguration

### Community 32 - "WorkspaceGroup"
Cohesion: 0.18
Nodes (10): Guid, ICollection, WorkspaceGroup, FileLinks, Name, ParentGroup, ParentGroupId, SubGroups (+2 more)

### Community 33 - "FileWorkspaceLink"
Cohesion: 0.22
Nodes (8): Guid, FileWorkspaceLink, VirtualFile, VirtualFileId, WorkspaceGroupId, WorkspaceId, EntityTypeBuilder, FileWorkspaceLinkConfiguration

### Community 34 - "RemoveIconPathAndAddWorkspaceIconName"
Cohesion: 0.25
Nodes (5): MigrationBuilder, DateTime, Guid, ModelBuilder, RemoveIconPathAndAddWorkspaceIconName

### Community 35 - "AddOriginalPathToVirtualFile"
Cohesion: 0.25
Nodes (5): MigrationBuilder, DateTime, Guid, ModelBuilder, AddOriginalPathToVirtualFile

### Community 37 - "IsolatedVaultArchitecture"
Cohesion: 0.38
Nodes (4): DateTime, Guid, MigrationBuilder, IsolatedVaultArchitecture

### Community 38 - ".BuildModel"
Cohesion: 0.33
Nodes (5): DateTime, Guid, ModelBuilder, AppDbContextModelSnapshot, ModelSnapshot

### Community 39 - ".BuildTargetModel"
Cohesion: 0.50
Nodes (3): DateTime, Guid, ModelBuilder

### Community 40 - "BaseEntity"
Cohesion: 0.29
Nodes (6): DateTime, Guid, BaseEntity, CreatedAt, Id, UpdatedAt

### Community 41 - ".CreateWorkspaceAsync"
Cohesion: 0.27
Nodes (10): CancellationToken, Guid, Task, WorkspacesController, ControllerBase, HttpGet, HttpPost, IActionResult (+2 more)

### Community 42 - "WorkspaceDetailDto"
Cohesion: 0.20
Nodes (9): DateTime, Guid, WorkspaceDetailDto, CreatedAt, ExpiresAtUtc, IconName, Id, IsTemporal (+1 more)

### Community 43 - "DesktopPro.Application.Features.Workspaces.DTOs"
Cohesion: 0.33
Nodes (4): DesktopPro.WebApi.Controllers, DesktopPro.Application.Features.Workspaces.Queries.GetWorkspaces, DesktopPro.Application.Features.Workspaces.DTOs, DesktopPro.Application.Features.Workspaces.Queries.GetWorkspaceById

### Community 44 - "GetWorkspaceByIdQuery"
Cohesion: 0.29
Nodes (7): CancellationToken, Task, WorkspaceDetailDto, GetWorkspaceByIdQueryHandler, Guid, GetWorkspaceByIdQuery, IRequestHandler

### Community 45 - "CreateWorkspaceCommandValidator"
Cohesion: 0.40
Nodes (3): AbstractValidator, CreateWorkspaceCommandValidator, GetWorkspaceByIdQueryValidator

## Knowledge Gaps
- **219 isolated node(s):** `AppUsers`, `VirtualFiles`, `Workspaces`, `WorkspaceGroups`, `FileWorkspaceLinks` (+214 more)
  These have ≤1 connection - possible missing edges or undocumented components. (Counts symbols only; 318 node(s) total have ≤1 connection when file, concept and rationale nodes are included.)
- **8 thin communities (<3 nodes) omitted from report** — run `graphify query` to explore isolated nodes.

## Suggested Questions
_Questions this graph is uniquely positioned to answer:_

- **Why does `DesktopPro.Persistence.Contexts` connect `DesktopPro.Persistence.Migrations` to `ValidationBehavior`, `DesktopPro.Domain.Entities`, `IAppDbContext`?**
  _High betweenness centrality (0.114) - this node is a cross-community bridge._
- **Why does `IAppDbContext` connect `IAppDbContext` to `CreateWorkspaceCommand`, `FileWorkspaceLink`, `GetWorkspaceByIdQuery`, `DesktopPro.Domain.Entities`, `AppDbContext`, `AppUser`, `AiTriageSuggestion`, `WorkspaceGroup`, `GetWorkspacesQuery`, `Workspace`?**
  _High betweenness centrality (0.083) - this node is a cross-community bridge._
- **Why does `AppDbContext` connect `AppDbContext` to `FileWorkspaceLink`, `DesktopPro.Domain.Entities`, `IAppDbContext`, `AppUser`, `AiTriageSuggestion`, `WorkspaceGroup`, `Workspace`?**
  _High betweenness centrality (0.073) - this node is a cross-community bridge._
- **What connects `AppUsers`, `VirtualFiles`, `Workspaces` to the rest of the system?**
  _219 weakly-connected nodes found - possible documentation gaps or missing edges._
- **Should `CreateWorkspaceDialog.tsx` be split into smaller, more focused modules?**
  _Cohesion score 0.05970149253731343 - nodes in this community are weakly interconnected._
- **Should `Workspace` be split into smaller, more focused modules?**
  _Cohesion score 0.1323529411764706 - nodes in this community are weakly interconnected._
- **Should `package.json` be split into smaller, more focused modules?**
  _Cohesion score 0.06349206349206349 - nodes in this community are weakly interconnected._