---
trigger: model_decision
description: >-
  Activate ONLY when creating or significantly restructuring frontend TypeScript/React
  files under Frontend/src/ — e.g. adding a new feature slice, hook, component,
  API client, or type definition. Do NOT activate for small quickfixes, CSS-only
  edits, renaming a class, editing a comment, or when the task is purely backend.
---

# Frontend Architecture & Development Rules

> **These rules are MANDATORY for all TypeScript/React code under `Frontend/src/`. No exceptions.**

## ⛔ NEVER

- `lucide-react` → use `@phosphor-icons/react` exclusively → **FORBIDDEN**
- `axios.create()` ad-hoc instances → always use `src/api/client.ts` → **FORBIDDEN**
- Direct `fetch` or `axios` calls inside components → always go through a `useXxx` hook → **FORBIDDEN**
- Raw Tailwind palette colors (`bg-white`, `text-gray-900`, `blue-500`) → **FORBIDDEN**
- Feature-specific code inside `src/components/` or `src/api/` → **FORBIDDEN**
- Cross-feature `../../` relative imports → always use `@/` alias → **FORBIDDEN**
- `import.meta.env.*` directly → always use `src/config/env.ts` → **FORBIDDEN**
- Default exports (except `App.tsx` and route-level pages) → **FORBIDDEN**

## ✅ ALWAYS

- All data fetching via TanStack Query `useQuery` / `useMutation` (explicit type generics)
- Mutation `onSuccess` → invalidate cache with `queryClient.invalidateQueries()`
- Export `{entity}Keys` query key const from the same file as the hook
- Every feature → `src/features/{FeatureName}/` vertical slice (`api/`, `components/`, `types/`, `utils/`)
- Use semantic token classes: `bg-background`, `text-foreground`, `bg-card`, `text-muted-foreground`, etc.
- Compose class names with `cn()` from `src/lib/utils.ts`
- Prefer shadcn/ui primitives — do not add new UI libraries
- Boolean state: `is`/`has` prefix; event handlers: `handleXxx`

## Stack

| Layer | Tool |
|---|---|
| Framework | React 19 + TypeScript + Vite |
| Styling | TailwindCSS v3, semantic tokens (`index.css @layer base`) |
| Components | shadcn/ui (`src/components/ui/`) |
| Icons | `@phosphor-icons/react` |
| Data | TanStack Query v5 |
| HTTP | `src/api/client.ts` (single Axios instance) |
| Env | `src/config/env.ts` (`ENV` object) |

## Theming

- All theme tokens in `src/index.css` under `@layer base`, scoped to `[data-theme="<name>"]`
- Adding a new theme: provide a complete token set and register it in `ThemeSelector.tsx`
