---
trigger: always_on
description: MANDATORY graphify usage for all codebase investigation and research tasks.
---

# Graphify – Mandatory Usage Rules

> This project has a knowledge graph at `graphify-out/`.

## ⛔ NEVER

- Skip graphify before using `grep_search`, `list_dir`, or `view_file` for research → **FORBIDDEN**
- End a session after code changes without running `graphify update .` → **FORBIDDEN**

## ✅ ALWAYS

**Before any research** — finding files, understanding classes/modules, exploring architecture, locating features — run first:

```
graphify query "<question>"    # general question
graphify path "<A>" "<B>"      # relationship between two components
graphify explain "<concept>"   # focused concept lookup
```

- If `graphify-out/wiki/index.md` exists → use the wiki instead of raw files
- If `graphify-out/GRAPH_REPORT.md` exists → use it for broad architecture review

**After any code change** (create / edit / delete):

```
graphify update .
```
