import { ClockCountdownIcon, CircleNotchIcon, FolderOpenIcon } from '@phosphor-icons/react';
import { useWorkspace } from '../api/useWorkspace';
import { getWorkspaceIcon } from '../utils/workspaceIcons';
import { Tooltip, TooltipTrigger, TooltipContent } from '@/components/ui/tooltip';

interface WorkspaceDetailViewProps {
  workspaceId: string | null;
}

/**
 * Formats an ISO expiration date string into human-readable local and UTC formats.
 */
function formatExpirationDate(dateStr?: string | null): string {
  if (!dateStr) return 'No expiration date specified';
  try {
    const d = new Date(dateStr);
    if (isNaN(d.getTime())) return dateStr;
    return d.toLocaleString(undefined, {
      year: 'numeric',
      month: 'short',
      day: 'numeric',
      hour: '2-digit',
      minute: '2-digit',
    });
  } catch {
    return dateStr;
  }
}

export const WorkspaceDetailView = ({ workspaceId }: WorkspaceDetailViewProps) => {
  const { data: workspace, isLoading, isError, refetch } = useWorkspace(workspaceId);

  // 1. No Workspace Selected State
  if (!workspaceId) {
    return (
      <div className="h-full flex flex-col items-center justify-center p-8 select-none text-center">
        <div className="h-12 w-12 flex items-center justify-center text-muted-foreground/40 mb-3">
          <FolderOpenIcon size={36} weight="light" />
        </div>
        <h2 className="text-base font-heading font-medium tracking-tight text-foreground mb-1">
          No Workspace Selected
        </h2>
        <p className="text-xs text-muted-foreground max-w-sm leading-relaxed">
          Select an existing workspace from the sidebar or create a new one to begin.
        </p>
      </div>
    );
  }

  // 2. Loading State
  if (isLoading) {
    return (
      <div className="h-full flex flex-col items-center justify-center p-8 gap-3 text-muted-foreground">
        <CircleNotchIcon size={22} className="animate-spin text-primary" />
        <span className="text-xs font-medium tracking-wide">Loading workspace...</span>
      </div>
    );
  }

  // 3. Error State
  if (isError || !workspace) {
    return (
      <div className="h-full flex flex-col items-center justify-center p-8 text-center max-w-md mx-auto">
        <p className="text-xs font-medium text-destructive mb-1.5">Failed to load workspace details.</p>
        <button
          type="button"
          onClick={() => refetch()}
          className="text-xs underline text-muted-foreground hover:text-foreground cursor-pointer"
        >
          Retry
        </button>
      </div>
    );
  }

  const displayName = workspace.name || 'Untitled Workspace';
  const IconComponent = getWorkspaceIcon(workspace.iconName);
  const isTemporal = workspace.isTemporal;
  const expirationDate = workspace.expiresAtUtc || (workspace as any).expiredAtUtc;

  return (
    <div className="h-full w-full bg-background overflow-y-auto select-none px-8 py-5">
      {/* 
        Top Seamless Header Line:
        - Exactly where workspace/{isim} was, flat, large, and continuous with the background.
        - No container, no cards, no borders, no rounded corners.
        - Workspace icon + name + temporal dashed clock with tooltip.
      */}
      <div className="flex items-center gap-4 flex-wrap">
        {/* Workspace Icon */}
        <IconComponent
          size={28}
          weight="regular"
          className="shrink-0 text-foreground/85"
        />

        {/* Workspace Name (Large, flat, seamless) */}
        <h1 className="text-2xl font-heading font-medium tracking-tight text-foreground select-text">
          {displayName}
        </h1>

        {/* Temporal Workspace Indicator: Dashed Clock Icon + Tooltip */}
        {isTemporal && (
          <Tooltip>
            <TooltipTrigger asChild>
              <button
                type="button"
                aria-label="Temporal Workspace Information"
                className="flex items-center justify-center text-muted-foreground/80 hover:text-foreground focus:outline-none transition-colors cursor-help shrink-0"
              >
                {/* Kesikli saat simgesi (Phosphor Icons ClockCountdownIcon) */}
                <ClockCountdownIcon size={21} weight="bold" />
              </button>
            </TooltipTrigger>
            <TooltipContent
              side="bottom"
              align="start"
              className="px-3 py-2 text-xs shadow-lg border border-border bg-popover text-popover-foreground max-w-xs"
            >
              <div className="space-y-1">
                <div className="flex items-center gap-1.5 font-semibold text-foreground">
                  <ClockCountdownIcon size={15} weight="bold" className="text-foreground/80" />
                  <span>Temporal</span>
                </div>
                <div className="text-[11px] text-muted-foreground">
                  <span className="font-medium text-foreground">Expires: </span>
                  <span>{formatExpirationDate(expirationDate)}</span>
                </div>
              </div>
            </TooltipContent>
          </Tooltip>
        )}
      </div>
    </div>
  );
};
