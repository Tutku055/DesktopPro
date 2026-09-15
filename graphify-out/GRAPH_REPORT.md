# Graph Report - DesktopPro  (2026-09-15)

## Corpus Check
- 107 files · ~89,712 words
- Verdict: corpus is large enough that graph structure adds value.

## Summary
- 687 nodes · 1044 edges · 52 communities (43 shown, 7 thin omitted)
- Extraction: 99% EXTRACTED · 1% INFERRED · 0% AMBIGUOUS · INFERRED: 11 edges (avg confidence: 0.85)
- Token cost: 0 input · 0 output

## Graph Freshness
- Built from commit: `a99322d1`
- Run `git rev-parse HEAD` and compare to check if the graph is stale.
- Run `graphify update .` after code changes (no API cost).

## Community Hubs (Navigation)
- AuditableEntityInterceptor
- CreateWorkspaceDialog.tsx
- .Up
- Workspace
- package.json
- ValidationBehavior
- VirtualFile
- alert-dialog.tsx
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
- dropdown-menu.tsx
- react
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
- CreateWorkspaceCommand
- UpdateWorkspaceCommand
- WorkspaceDto
- WorkspaceDetailDto
- DesktopPro.Application.Features.Workspaces.DTOs
- BaseEntity
- DeleteWorkspaceCommand
- Frontend Architecture & Development Rules
- Backend Architecture & Development Rules
- WorkspaceDetailView.tsx
- AbstractValidator
- WorkspaceGroup
- .BuildTargetModel

## God Nodes (most connected - your core abstractions)
1. `VirtualFile` - 28 edges
2. `IAppDbContext` - 23 edges
3. `Workspace` - 20 edges
4. `compilerOptions` - 19 edges
5. `DesktopPro.Domain.Entities` - 18 edges
6. `FileWorkspaceLink` - 18 edges
7. `AppDbContext` - 18 edges
8. `react` - 18 edges
9. `AppUser` - 15 edges
10. `WorkspaceGroup` - 15 edges

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

## Communities (52 total, 7 thin omitted)

### Community 0 - "AuditableEntityInterceptor"
Cohesion: 0.19
Nodes (9): DependencyInjection, CancellationToken, DbContext, ValueTask, AuditableEntityInterceptor, DesktopPro.Persistence.Interceptors, DbContextEventData, InterceptionResult (+1 more)

### Community 1 - "CreateWorkspaceDialog.tsx"
Cohesion: 0.12
Nodes (21): Button(), buttonVariants, Dialog(), DialogContent(), DialogHeader(), DialogTitle(), DialogTrigger(), Input() (+13 more)

### Community 2 - ".Up"
Cohesion: 0.40
Nodes (3): DateTime, Guid, MigrationBuilder

### Community 3 - "Workspace"
Cohesion: 0.13
Nodes (11): DateTime, Guid, ICollection, Workspace, AppUserId, ExpiresAtUtc, FileLinks, IconName (+3 more)

### Community 4 - "package.json"
Cohesion: 0.06
Nodes (33): name, private, scripts, build, dev, lint, preview, type (+25 more)

### Community 5 - "ValidationBehavior"
Cohesion: 0.08
Nodes (19): CancellationToken, Task, ValidationBehavior, IServiceCollection, DependencyInjection, CancellationToken, ValueTask, GlobalExceptionHandler (+11 more)

### Community 6 - "VirtualFile"
Cohesion: 0.07
Nodes (20): Guid, ICollection, VirtualFile, AppUserId, Extension, FileHash, FileName, FileSize (+12 more)

### Community 7 - "alert-dialog.tsx"
Cohesion: 0.10
Nodes (26): apiClient, RFC-7807, AlertDialog(), AlertDialogAction(), AlertDialogCancel(), AlertDialogContent(), AlertDialogDescription(), AlertDialogFooter() (+18 more)

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

### Community 15 - "IAppDbContext"
Cohesion: 0.18
Nodes (10): DbSet, IAppDbContext, AiTriageSuggestions, AppUsers, FileWorkspaceLinks, VirtualFiles, WorkspaceGroups, Workspaces (+2 more)

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
Cohesion: 0.22
Nodes (8): Guid, AiTriageSuggestion, SuggestedName, SuggestedWorkspaceId, SuggestedWorkspaceName, VirtualFileId, EntityTypeBuilder, AiTriageSuggestionConfiguration

### Community 20 - "tsconfig.json"
Cohesion: 0.40
Nodes (4): compilerOptions, paths, files, references

### Community 21 - "dropdown-menu.tsx"
Cohesion: 0.11
Nodes (9): DropdownMenu(), DropdownMenuContent(), DropdownMenuItem(), DropdownMenuTrigger(), WorkspaceItem(), RFC-7807, WorkspaceList(), WorkspaceListProps (+1 more)

### Community 22 - "react"
Cohesion: 0.17
Nodes (16): App(), AppSidebar(), AppSidebarProps, useDebounce(), MainLayout(), MainLayoutProps, SidebarContext, SidebarContextValue (+8 more)

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
Cohesion: 0.22
Nodes (5): MigrationBuilder, DateTime, Guid, ModelBuilder, RemoveIconPathAndAddWorkspaceIconName

### Community 35 - "AddOriginalPathToVirtualFile"
Cohesion: 0.22
Nodes (6): MigrationBuilder, DateTime, Guid, ModelBuilder, AddOriginalPathToVirtualFile, Migration

### Community 36 - "DesktopPro.Persistence.Migrations"
Cohesion: 0.38
Nodes (3): InitialCreate, DesktopPro.Persistence.Migrations, DesktopPro.Persistence.Contexts

### Community 37 - "IsolatedVaultArchitecture"
Cohesion: 0.20
Nodes (7): DateTime, Guid, MigrationBuilder, DateTime, Guid, ModelBuilder, IsolatedVaultArchitecture

### Community 38 - ".BuildModel"
Cohesion: 0.29
Nodes (5): DateTime, Guid, ModelBuilder, AppDbContextModelSnapshot, ModelSnapshot

### Community 39 - "CreateWorkspaceCommand"
Cohesion: 0.14
Nodes (12): CancellationToken, Task, Guid, CreateWorkspaceCommand, CancellationToken, Guid, Task, CreateWorkspaceCommandHandler (+4 more)

### Community 40 - "UpdateWorkspaceCommand"
Cohesion: 0.16
Nodes (10): Guid, UpdateWorkspaceCommand, CancellationToken, Task, UpdateWorkspaceCommandHandler, UpdateWorkspaceCommandValidator, DateTime, UpdateWorkspaceDto (+2 more)

### Community 41 - "WorkspaceDto"
Cohesion: 0.09
Nodes (31): DateTime, Guid, WorkspaceDto, Guid, IReadOnlyList, GetWorkspacesQuery, CancellationToken, IReadOnlyList (+23 more)

### Community 42 - "WorkspaceDetailDto"
Cohesion: 0.12
Nodes (17): DateTime, Guid, WorkspaceDetailDto, CreatedAt, ExpiresAtUtc, IconName, Id, IsTemporal (+9 more)

### Community 43 - "DesktopPro.Application.Features.Workspaces.DTOs"
Cohesion: 0.23
Nodes (6): DesktopPro.Application.Common.Interfaces, DesktopPro.WebApi.Controllers, DesktopPro.Application.Features.Workspaces.Queries.GetWorkspaces, DesktopPro.Application.Features.Workspaces.DTOs, DesktopPro.Application.Features.Workspaces.Queries.GetWorkspaceById, DesktopPro.Application.Features.Workspaces.Queries.SearchWorkspaces

### Community 44 - "BaseEntity"
Cohesion: 0.29
Nodes (6): DateTime, Guid, BaseEntity, CreatedAt, Id, UpdatedAt

### Community 45 - "DeleteWorkspaceCommand"
Cohesion: 0.21
Nodes (8): Guid, DeleteWorkspaceCommand, CancellationToken, Task, DeleteWorkspaceCommandHandler, DeleteWorkspaceCommandValidator, DesktopPro.Application.Features.Workspaces.Commands.DeleteWorkspace, IRequest

### Community 46 - "Frontend Architecture & Development Rules"
Cohesion: 0.33
Nodes (5): ✅ ALWAYS, Frontend Architecture & Development Rules, ⛔ NEVER, Stack, Theming

### Community 47 - "Backend Architecture & Development Rules"
Cohesion: 0.40
Nodes (4): ✅ ALWAYS, Backend Architecture & Development Rules, Layer Dependencies, ⛔ NEVER

### Community 48 - "WorkspaceDetailView.tsx"
Cohesion: 0.31
Nodes (7): Tooltip(), TooltipContent(), TooltipTrigger(), formatExpirationDate(), WorkspaceDetailView(), WorkspaceDetailViewProps, getWorkspaceIcon()

### Community 49 - "AbstractValidator"
Cohesion: 0.40
Nodes (3): AbstractValidator, GetWorkspaceByIdQueryValidator, SearchWorkspacesQueryValidator

### Community 50 - "WorkspaceGroup"
Cohesion: 0.67
Nodes (3): WorkspaceGroup, EntityTypeBuilder, WorkspaceGroupConfiguration

### Community 51 - ".BuildTargetModel"
Cohesion: 0.50
Nodes (3): DateTime, Guid, ModelBuilder

## Knowledge Gaps
- **227 isolated node(s):** `AppUsers`, `VirtualFiles`, `Workspaces`, `WorkspaceGroups`, `FileWorkspaceLinks` (+222 more)
  These have ≤1 connection - possible missing edges or undocumented components. (Counts symbols only; 359 node(s) total have ≤1 connection when file, concept and rationale nodes are included.)
- **7 thin communities (<3 nodes) omitted from report** — run `graphify query` to explore isolated nodes.

## Suggested Questions
_Questions this graph is uniquely positioned to answer:_

- **Why does `IAppDbContext` connect `IAppDbContext` to `FileWorkspaceLink`, `CreateWorkspaceCommand`, `UpdateWorkspaceCommand`, `WorkspaceDto`, `WorkspaceDetailDto`, `DesktopPro.Application.Features.Workspaces.DTOs`, `DeleteWorkspaceCommand`, `AppDbContext`, `AppUser`, `WorkspaceGroup`, `AiTriageSuggestion`, `Workspace`?**
  _High betweenness centrality (0.099) - this node is a cross-community bridge._
- **Why does `DesktopPro.Persistence.Contexts` connect `DesktopPro.Persistence.Migrations` to `AuditableEntityInterceptor`, `RemoveIconPathAndAddWorkspaceIconName`, `ValidationBehavior`, `IsolatedVaultArchitecture`, `.BuildModel`?**
  _High betweenness centrality (0.090) - this node is a cross-community bridge._
- **Why does `FileWorkspaceLink` connect `FileWorkspaceLink` to `WorkspaceGroup`, `Workspace`, `VirtualFile`, `BaseEntity`, `DesktopPro.Domain.Entities`, `IAppDbContext`, `AppDbContext`, `AppUser`, `WorkspaceGroup`, `Workspace`?**
  _High betweenness centrality (0.057) - this node is a cross-community bridge._
- **What connects `AppUsers`, `VirtualFiles`, `Workspaces` to the rest of the system?**
  _227 weakly-connected nodes found - possible documentation gaps or missing edges._
- **Should `CreateWorkspaceDialog.tsx` be split into smaller, more focused modules?**
  _Cohesion score 0.11942959001782531 - nodes in this community are weakly interconnected._
- **Should `Workspace` be split into smaller, more focused modules?**
  _Cohesion score 0.13071895424836602 - nodes in this community are weakly interconnected._
- **Should `package.json` be split into smaller, more focused modules?**
  _Cohesion score 0.06349206349206349 - nodes in this community are weakly interconnected._