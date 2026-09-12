import type { Icon } from '@phosphor-icons/react';
import {
  FolderIcon,
  CodeIcon,
  TerminalWindowIcon,
  GameControllerIcon,
  AlienIcon,
  BriefcaseIcon,
  PaletteIcon,
  PaintBrushIcon,
  MusicNotesIcon,
  FilmStripIcon,
  BookOpenIcon,
  RocketLaunchIcon,
  DatabaseIcon,
  CameraIcon,
  CoffeeIcon,
  GlobeIcon,
  CpuIcon,
  ChartLineUpIcon,
  LockKeyIcon,
  ArchiveIcon,
} from '@phosphor-icons/react';

export interface WorkspaceIconOption {
  id: string;
  label: string;
  category: string;
  icon: Icon;
}

/**
 * 20 Curated desktop workspace icons across practical categories:
 * Default, Dev/Tech, Creative, Entertainment, Productivity, Security.
 */
export const WORKSPACE_ICONS: WorkspaceIconOption[] = [
  { id: 'folder', label: 'General Folder', category: 'Default', icon: FolderIcon },
  { id: 'code', label: 'Source Code', category: 'Dev', icon: CodeIcon },
  { id: 'terminal', label: 'Terminal / CLI', category: 'Dev', icon: TerminalWindowIcon },
  { id: 'cpu', label: 'AI & Systems', category: 'Tech', icon: CpuIcon },
  { id: 'database', label: 'Database & SQL', category: 'Tech', icon: DatabaseIcon },
  { id: 'globe', label: 'Web & Cloud', category: 'Network', icon: GlobeIcon },
  { id: 'briefcase', label: 'Office & Work', category: 'Productivity', icon: BriefcaseIcon },
  { id: 'chart', label: 'Finance & Analytics', category: 'Productivity', icon: ChartLineUpIcon },
  { id: 'book', label: 'Study & Docs', category: 'Knowledge', icon: BookOpenIcon },
  { id: 'coffee', label: 'Personal & Notes', category: 'Lifestyle', icon: CoffeeIcon },
  { id: 'palette', label: 'UI / UX Design', category: 'Creative', icon: PaletteIcon },
  { id: 'paint-brush', label: 'Art & Illustration', category: 'Creative', icon: PaintBrushIcon },
  { id: 'camera', label: 'Photography', category: 'Media', icon: CameraIcon },
  { id: 'music', label: 'Audio & Music', category: 'Media', icon: MusicNotesIcon },
  { id: 'film', label: 'Cinema & Video', category: 'Media', icon: FilmStripIcon },
  { id: 'game', label: 'Gaming', category: 'Entertainment', icon: GameControllerIcon },
  { id: 'alien', label: 'Indie & Experimental', category: 'Entertainment', icon: AlienIcon },
  { id: 'rocket', label: 'Launch & Startup', category: 'Projects', icon: RocketLaunchIcon },
  { id: 'lock', label: 'Vault & Privacy', category: 'Security', icon: LockKeyIcon },
  { id: 'archive', label: 'Backups & Storage', category: 'Storage', icon: ArchiveIcon },
];

export const DEFAULT_WORKSPACE_ICON = 'folder';

export const WORKSPACE_ICON_MAP: Record<string, Icon> = WORKSPACE_ICONS.reduce(
  (acc, curr) => {
    acc[curr.id] = curr.icon;
    return acc;
  },
  {} as Record<string, Icon>
);

/**
 * Returns the matching Phosphor Icon component for a given iconName identifier.
 * Defaults safely to FolderIcon if null, empty, or unmapped.
 */
export function getWorkspaceIcon(iconName: string | null | undefined): Icon {
  if (!iconName) return FolderIcon;
  return WORKSPACE_ICON_MAP[iconName] || FolderIcon;
}
