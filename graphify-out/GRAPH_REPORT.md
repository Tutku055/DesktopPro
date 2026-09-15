# Graph Report - DesktopPro  (2026-09-15)

## Corpus Check
- 93 files · ~87,124 words
- Verdict: corpus is large enough that graph structure adds value.

## Summary
- 604 nodes · 853 edges · 48 communities (39 shown, 7 thin omitted)
- Extraction: 99% EXTRACTED · 1% INFERRED · 0% AMBIGUOUS · INFERRED: 6 edges (avg confidence: 0.86)
- Token cost: 0 input · 0 output

## Graph Freshness
- Built from commit: `e4a15594`
- Run `git rev-parse HEAD` and compare to check if the graph is stale.
- Run `graphify update .` after code changes (no API cost).

## Community Hubs (Navigation)
- GetWorkspaceByIdQuery
- CreateWorkspaceDialog.tsx
- InitialCreate
- Workspace
- package.json
- ValidationBehavior
- VirtualFile
- WorkspaceDetailView.tsx
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
- SearchWorkspacesQuery
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
- VirtualFile
- .CreateWorkspaceAsync
- WorkspaceDetailDto
- DesktopPro.Application.Features.Workspaces.DTOs
- BaseEntity
- CreateWorkspaceCommand
- Frontend Architecture & Development Rules
- Backend Architecture & Development Rules

## God Nodes (most connected - your core abstractions)
1. `VirtualFile` - 28 edges
2. `IAppDbContext` - 21 edges
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

## Communities (48 total, 7 thin omitted)

### Community 0 - "GetWorkspaceByIdQuery"
Cohesion: 0.19
Nodes (9): Guid, GetWorkspaceByIdQuery, CancellationToken, Task, WorkspaceDetailDto, GetWorkspaceByIdQueryHandler, GetWorkspaceByIdQueryValidator, DesktopPro.Application.Features.Workspaces.Queries.GetWorkspaceById (+1 more)

### Community 1 - "CreateWorkspaceDialog.tsx"
Cohesion: 0.07
Nodes (38): App(), AppSidebar(), AppSidebarProps, useDebounce(), MainLayout(), MainLayoutProps, SidebarContext, SidebarContextValue (+30 more)

### Community 2 - "InitialCreate"
Cohesion: 0.18
Nodes (8): DateTime, Guid, MigrationBuilder, DateTime, Guid, ModelBuilder, InitialCreate, Migration

### Community 3 - "Workspace"
Cohesion: 0.14
Nodes (11): DateTime, Guid, ICollection, Workspace, AppUserId, ExpiresAtUtc, FileLinks, IconName (+3 more)

### Community 4 - "package.json"
Cohesion: 0.07
Nodes (32): name, private, scripts, build, dev, lint, preview, type (+24 more)

### Community 5 - "ValidationBehavior"
Cohesion: 0.06
Nodes (23): CancellationToken, Task, ValidationBehavior, IServiceCollection, DependencyInjection, IServiceCollection, DependencyInjection, CancellationToken (+15 more)

### Community 6 - "VirtualFile"
Cohesion: 0.07
Nodes (20): Guid, ICollection, VirtualFile, AppUserId, Extension, FileHash, FileName, FileSize (+12 more)

### Community 7 - "WorkspaceDetailView.tsx"
Cohesion: 0.11
Nodes (23): apiClient, RFC-7807, Tooltip(), TooltipContent(), TooltipTrigger(), ENV, useCreateWorkspace(), useWorkspace() (+15 more)

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
Cohesion: 0.19
Nodes (5): WorkspaceGroup, EntityTypeBuilder, WorkspaceGroupConfiguration, DesktopPro.Domain.Entities, DesktopPro.Persistence.Configurations

### Community 15 - "IAppDbContext"
Cohesion: 0.18
Nodes (10): CancellationToken, DbSet, Task, IAppDbContext, AiTriageSuggestions, AppUsers, FileWorkspaceLinks, VirtualFiles (+2 more)

### Community 16 - "AppDbContext"
Cohesion: 0.18
Nodes (10): DbSet, ModelBuilder, AppDbContext, AiTriageSuggestions, AppUsers, FileWorkspaceLinks, VirtualFiles, WorkspaceGroups (+2 more)

### Community 17 - "AppUser"
Cohesion: 0.18
Nodes (7): DateTime, AppUser, LastLoginDateUtc, PasswordHash, Username, EntityTypeBuilder, AppUserConfiguration

### Community 18 - "http"
Cohesion: 0.20
Nodes (9): ASPNETCORE_ENVIRONMENT, applicationUrl, commandName, dotnetRunMessages, environmentVariables, launchBrowser, profiles, http (+1 more)

### Community 19 - "AiTriageSuggestion"
Cohesion: 0.20
Nodes (9): Guid, AiTriageSuggestion, SuggestedName, SuggestedWorkspaceId, SuggestedWorkspaceName, VirtualFileId, EntityTypeBuilder, AiTriageSuggestionConfiguration (+1 more)

### Community 20 - "tsconfig.json"
Cohesion: 0.40
Nodes (4): compilerOptions, paths, files, references

### Community 21 - "SearchWorkspacesQuery"
Cohesion: 0.22
Nodes (9): Guid, IReadOnlyList, SearchWorkspacesQuery, CancellationToken, IReadOnlyList, Task, WorkspaceDto, SearchWorkspacesQueryHandler (+1 more)

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
Cohesion: 0.20
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

### Community 40 - "VirtualFile"
Cohesion: 0.67
Nodes (3): VirtualFile, EntityTypeBuilder, VirtualFileConfiguration

### Community 41 - ".CreateWorkspaceAsync"
Cohesion: 0.22
Nodes (12): DateTime, CreateWorkspaceDto, CancellationToken, Guid, Task, WorkspacesController, ControllerBase, HttpGet (+4 more)

### Community 42 - "WorkspaceDetailDto"
Cohesion: 0.20
Nodes (9): DateTime, Guid, WorkspaceDetailDto, CreatedAt, ExpiresAtUtc, IconName, Id, IsTemporal (+1 more)

### Community 43 - "DesktopPro.Application.Features.Workspaces.DTOs"
Cohesion: 0.24
Nodes (5): DesktopPro.Application.Common.Interfaces, DesktopPro.WebApi.Controllers, DesktopPro.Application.Features.Workspaces.Queries.GetWorkspaces, DesktopPro.Application.Features.Workspaces.DTOs, DesktopPro.Application.Features.Workspaces.Queries.SearchWorkspaces

### Community 44 - "BaseEntity"
Cohesion: 0.29
Nodes (6): DateTime, Guid, BaseEntity, CreatedAt, Id, UpdatedAt

### Community 45 - "CreateWorkspaceCommand"
Cohesion: 0.19
Nodes (10): AbstractValidator, Guid, CreateWorkspaceCommand, CancellationToken, Guid, Task, CreateWorkspaceCommandHandler, CreateWorkspaceCommandValidator (+2 more)

### Community 46 - "Frontend Architecture & Development Rules"
Cohesion: 0.33
Nodes (5): ✅ ALWAYS, Frontend Architecture & Development Rules, ⛔ NEVER, Stack, Theming

### Community 47 - "Backend Architecture & Development Rules"
Cohesion: 0.40
Nodes (4): ✅ ALWAYS, Backend Architecture & Development Rules, Layer Dependencies, ⛔ NEVER

## Knowledge Gaps
- **226 isolated node(s):** `AppUsers`, `VirtualFiles`, `Workspaces`, `WorkspaceGroups`, `FileWorkspaceLinks` (+221 more)
  These have ≤1 connection - possible missing edges or undocumented components. (Counts symbols only; 332 node(s) total have ≤1 connection when file, concept and rationale nodes are included.)
- **7 thin communities (<3 nodes) omitted from report** — run `graphify query` to explore isolated nodes.

## Suggested Questions
_Questions this graph is uniquely positioned to answer:_

- **Why does `DesktopPro.Persistence.Contexts` connect `DesktopPro.Persistence.Migrations` to `DesktopPro.Application.Features.Workspaces.DTOs`, `ValidationBehavior`?**
  _High betweenness centrality (0.110) - this node is a cross-community bridge._
- **Why does `IAppDbContext` connect `IAppDbContext` to `GetWorkspaceByIdQuery`, `FileWorkspaceLink`, `ValidationBehavior`, `VirtualFile`, `DesktopPro.Application.Features.Workspaces.DTOs`, `CreateWorkspaceCommand`, `DesktopPro.Domain.Entities`, `AppDbContext`, `AppUser`, `AiTriageSuggestion`, `SearchWorkspacesQuery`, `GetWorkspacesQuery`, `Workspace`?**
  _High betweenness centrality (0.090) - this node is a cross-community bridge._
- **Why does `AppDbContext` connect `AppDbContext` to `FileWorkspaceLink`, `ValidationBehavior`, `VirtualFile`, `DesktopPro.Application.Features.Workspaces.DTOs`, `DesktopPro.Domain.Entities`, `IAppDbContext`, `AppUser`, `AiTriageSuggestion`, `Workspace`?**
  _High betweenness centrality (0.069) - this node is a cross-community bridge._
- **What connects `AppUsers`, `VirtualFiles`, `Workspaces` to the rest of the system?**
  _226 weakly-connected nodes found - possible documentation gaps or missing edges._
- **Should `CreateWorkspaceDialog.tsx` be split into smaller, more focused modules?**
  _Cohesion score 0.07017543859649122 - nodes in this community are weakly interconnected._
- **Should `Workspace` be split into smaller, more focused modules?**
  _Cohesion score 0.14166666666666666 - nodes in this community are weakly interconnected._
- **Should `package.json` be split into smaller, more focused modules?**
  _Cohesion score 0.06554621848739496 - nodes in this community are weakly interconnected._