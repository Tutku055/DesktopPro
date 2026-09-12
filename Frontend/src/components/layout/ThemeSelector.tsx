import { useState, useEffect } from 'react';
import {
  ScrollIcon,
  MoonIcon,
  SparkleIcon,
  CompassIcon,
  TreeEvergreenIcon,
  FeatherIcon,
  SunIcon,
  CoffeeIcon,
} from '@phosphor-icons/react';
import { useSidebar } from './SidebarContext';

export type ThemeType =
  | 'parchment'
  | 'charcoal'
  | 'rose'
  | 'monaco'
  | 'emerald'
  | 'cashmere'
  | 'platinum'
  | 'espresso';

const THEMES: { id: ThemeType; label: string; icon: React.ReactNode }[] = [
  { id: 'parchment', label: 'Parchment', icon: <ScrollIcon size={14} /> },
  { id: 'charcoal', label: 'Charcoal', icon: <MoonIcon size={14} /> },
  { id: 'rose', label: 'Rose', icon: <SparkleIcon size={14} /> },
  { id: 'monaco', label: 'Monaco', icon: <CompassIcon size={14} /> },
  { id: 'emerald', label: 'Emerald', icon: <TreeEvergreenIcon size={14} /> },
  { id: 'cashmere', label: 'Cashmere', icon: <FeatherIcon size={14} /> },
  { id: 'platinum', label: 'Platinum', icon: <SunIcon size={14} /> },
  { id: 'espresso', label: 'Espresso', icon: <CoffeeIcon size={14} /> },
];

const DARK_THEMES: ThemeType[] = ['charcoal', 'monaco', 'emerald', 'cashmere', 'espresso'];

export const ThemeSelector = () => {
  const [theme, setTheme] = useState<ThemeType>(() => {
    return (localStorage.getItem('app-theme') as ThemeType) || 'parchment';
  });
  const [open, setOpen] = useState(false);
  const { isOpen } = useSidebar();

  useEffect(() => {
    const root = document.documentElement;
    root.setAttribute('data-theme', theme);
    if (DARK_THEMES.includes(theme)) {
      root.classList.add('dark');
    } else {
      root.classList.remove('dark');
    }
    localStorage.setItem('app-theme', theme);
  }, [theme]);

  const current = THEMES.find((t) => t.id === theme) || THEMES[0];

  return (
    <div className="relative">
      <button
        type="button"
        onClick={() => setOpen((prev) => !prev)}
        className={
          isOpen
            ? 'flex items-center gap-1.5 px-2 py-1 rounded-md text-[11px] font-medium text-sidebar-foreground/75 hover:bg-sidebar-hover hover:text-sidebar-hover-foreground transition-colors cursor-pointer'
            : 'h-8 w-8 flex items-center justify-center rounded-md text-sidebar-foreground/75 hover:bg-sidebar-hover hover:text-sidebar-hover-foreground transition-colors cursor-pointer'
        }
        title={`Theme: ${current.label}`}
      >
        <span className="shrink-0 text-sidebar-foreground/70">{current.icon}</span>
        {isOpen && <span>{current.label}</span>}
      </button>

      {open && (
        <>
          <div
            className="fixed inset-0 z-40"
            onClick={() => setOpen(false)}
          />
          {isOpen ? (
            /* Expanded mode: Menu with icon + text opening upwards */
            <div className="absolute bottom-full left-0 mb-2 w-36 rounded-md border border-border bg-popover text-popover-foreground shadow-xl z-50 p-1 space-y-0.5 animate-in fade-in zoom-in-95">
              {THEMES.map((t) => (
                <button
                  key={t.id}
                  type="button"
                  onClick={() => {
                    setTheme(t.id);
                    setOpen(false);
                  }}
                  className={`w-full flex items-center gap-2 px-2 py-1 rounded-sm text-xs font-medium text-left transition-colors cursor-pointer ${
                    theme === t.id
                      ? 'bg-sidebar-accent text-sidebar-accent-foreground font-semibold'
                      : 'text-foreground/80 hover:bg-muted hover:text-foreground'
                  }`}
                >
                  <span className="shrink-0">{t.icon}</span>
                  <span>{t.label}</span>
                </button>
              ))}
            </div>
          ) : (
            /* Collapsed mode: Fixed vertical single-column icon-only menu without any sliders */
            <div className="absolute bottom-full left-1/2 -translate-x-1/2 mb-2 w-8 rounded-md border border-border bg-popover text-popover-foreground shadow-xl z-50 p-0.5 flex flex-col items-center gap-0.5 animate-in fade-in zoom-in-95">
              {THEMES.map((t) => (
                <button
                  key={t.id}
                  type="button"
                  title={t.label}
                  onClick={() => {
                    setTheme(t.id);
                    setOpen(false);
                  }}
                  className={`h-7 w-7 flex items-center justify-center rounded-sm transition-colors cursor-pointer shrink-0 ${
                    theme === t.id
                      ? 'bg-sidebar-accent text-sidebar-accent-foreground'
                      : 'text-sidebar-foreground/70 hover:bg-sidebar-hover hover:text-sidebar-foreground'
                  }`}
                >
                  <span className="shrink-0">{t.icon}</span>
                </button>
              ))}
            </div>
          )}
        </>
      )}
    </div>
  );
};
