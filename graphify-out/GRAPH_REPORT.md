# Graph Report - DesktopPro  (2026-09-12)

## Corpus Check
- 81 files · ~85,294 words
- Verdict: corpus is large enough that graph structure adds value.

## Summary
- 539 nodes · 723 edges · 41 communities (32 shown, 7 thin omitted)
- Extraction: 99% EXTRACTED · 1% INFERRED · 0% AMBIGUOUS · INFERRED: 4 edges (avg confidence: 0.86)
- Token cost: 0 input · 0 output

## Graph Freshness
- Built from commit: `50f114c6`
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
- VirtualFile
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

## God Nodes (most connected - your core abstractions)
1. `VirtualFile` - 28 edges
2. `IAppDbContext` - 19 edges
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

## Communities (41 total, 7 thin omitted)

### Community 0 - "CreateWorkspaceCommand"
Cohesion: 0.06
Nodes (38): AbstractValidator, CancellationToken, Task, Guid, CreateWorkspaceCommand, CancellationToken, Guid, Task (+30 more)

### Community 1 - "CreateWorkspaceDialog.tsx"
Cohesion: 0.09
Nodes (26): App(), AppSidebar(), AppSidebarProps, MainLayout(), MainLayoutProps, SidebarContext, SidebarContextValue, useSidebar() (+18 more)

### Community 2 - "InitialCreate"
Cohesion: 0.18
Nodes (8): DateTime, Guid, MigrationBuilder, DateTime, Guid, ModelBuilder, InitialCreate, Migration

### Community 3 - "Workspace"
Cohesion: 0.14
Nodes (11): DateTime, Guid, ICollection, Workspace, AppUserId, ExpiresAtUtc, FileLinks, IconName (+3 more)

### Community 4 - "package.json"
Cohesion: 0.06
Nodes (33): name, private, scripts, build, dev, lint, preview, type (+25 more)

### Community 5 - "ValidationBehavior"
Cohesion: 0.07
Nodes (21): CancellationToken, Task, ValidationBehavior, IServiceCollection, DependencyInjection, DependencyInjection, CancellationToken, GlobalExceptionHandler (+13 more)

### Community 6 - "VirtualFile"
Cohesion: 0.07
Nodes (20): Guid, ICollection, VirtualFile, AppUserId, Extension, FileHash, FileName, FileSize (+12 more)

### Community 7 - "client.ts"
Cohesion: 0.11
Nodes (23): apiClient, RFC-7807, ENV, useCreateWorkspace(), useWorkspaces(), workspaceKeys, WorkspaceItem(), WorkspaceItemProps (+15 more)

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
Cohesion: 0.21
Nodes (3): DesktopPro.Application.Common.Interfaces, DesktopPro.Domain.Entities, DesktopPro.Persistence.Configurations

### Community 15 - "IAppDbContext"
Cohesion: 0.18
Nodes (10): DbSet, IAppDbContext, AiTriageSuggestions, AppUsers, FileWorkspaceLinks, VirtualFiles, WorkspaceGroups, Workspaces (+2 more)

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
Cohesion: 0.18
Nodes (9): Guid, AiTriageSuggestion, SuggestedName, SuggestedWorkspaceId, SuggestedWorkspaceName, VirtualFileId, EntityTypeBuilder, AiTriageSuggestionConfiguration (+1 more)

### Community 20 - "tsconfig.json"
Cohesion: 0.40
Nodes (4): compilerOptions, paths, files, references

### Community 21 - "WorkspaceGroup"
Cohesion: 0.67
Nodes (3): WorkspaceGroup, EntityTypeBuilder, WorkspaceGroupConfiguration

### Community 22 - "VirtualFile"
Cohesion: 0.67
Nodes (3): VirtualFile, EntityTypeBuilder, VirtualFileConfiguration

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

## Knowledge Gaps
- **211 isolated node(s):** `AppUsers`, `VirtualFiles`, `Workspaces`, `WorkspaceGroups`, `FileWorkspaceLinks` (+206 more)
  These have ≤1 connection - possible missing edges or undocumented components. (Counts symbols only; 304 node(s) total have ≤1 connection when file, concept and rationale nodes are included.)
- **7 thin communities (<3 nodes) omitted from report** — run `graphify query` to explore isolated nodes.

## Suggested Questions
_Questions this graph is uniquely positioned to answer:_

- **Why does `DesktopPro.Persistence.Contexts` connect `DesktopPro.Persistence.Migrations` to `ValidationBehavior`, `DesktopPro.Domain.Entities`?**
  _High betweenness centrality (0.119) - this node is a cross-community bridge._
- **Why does `AppDbContext` connect `AppDbContext` to `FileWorkspaceLink`, `DesktopPro.Domain.Entities`, `IAppDbContext`, `AppUser`, `AiTriageSuggestion`, `WorkspaceGroup`, `VirtualFile`, `Workspace`?**
  _High betweenness centrality (0.079) - this node is a cross-community bridge._
- **Why does `IAppDbContext` connect `IAppDbContext` to `CreateWorkspaceCommand`, `FileWorkspaceLink`, `DesktopPro.Domain.Entities`, `AppDbContext`, `AppUser`, `AiTriageSuggestion`, `WorkspaceGroup`, `VirtualFile`, `Workspace`?**
  _High betweenness centrality (0.067) - this node is a cross-community bridge._
- **What connects `AppUsers`, `VirtualFiles`, `Workspaces` to the rest of the system?**
  _211 weakly-connected nodes found - possible documentation gaps or missing edges._
- **Should `CreateWorkspaceCommand` be split into smaller, more focused modules?**
  _Cohesion score 0.05725490196078432 - nodes in this community are weakly interconnected._
- **Should `CreateWorkspaceDialog.tsx` be split into smaller, more focused modules?**
  _Cohesion score 0.09302325581395349 - nodes in this community are weakly interconnected._
- **Should `Workspace` be split into smaller, more focused modules?**
  _Cohesion score 0.14166666666666666 - nodes in this community are weakly interconnected._