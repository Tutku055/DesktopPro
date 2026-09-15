---
trigger: always_on
description: MANDATORY graphify usage for all codebase investigation and research tasks. No exceptions.
---

# Graphify – Mandatory Usage Rules

> This project has a knowledge graph at `graphify-out/`.

## 🛑 HARD STOP — Read before touching any file tool

**Before calling `grep_search`, `list_dir`, or `view_file` for any research purpose:**

> Have you run `graphify query` first?
> If not — **STOP. Run it now. Then proceed.**
> Skipping this step is a direct violation of project rules. No exceptions.

This applies to: finding files, locating classes/functions, understanding architecture,
exploring features, tracing dependencies — any investigation task whatsoever.

## ⛔ NEVER

- Call `grep_search`, `list_dir`, or `view_file` for research without a prior `graphify query` → **VIOLATION**
- End a session after code changes without running `graphify update .` → **VIOLATION**
- Convince yourself "this is too simple to need graphify" → **VIOLATION**

## ✅ ALWAYS

**Step 1 — Before any research**, run one of:

```
graphify query "<question>"    # general question — use this first
graphify path "<A>" "<B>"      # relationship between two components
graphify explain "<concept>"   # focused concept lookup
```

- If `graphify-out/wiki/index.md` exists → read the wiki instead of running a query
- If `graphify-out/GRAPH_REPORT.md` exists → use it for broad architecture review

**Step 2 — After any code change** (create / edit / delete):

```
graphify update .
```
