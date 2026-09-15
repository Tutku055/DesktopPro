import { ClockCountdown, DotsThreeVertical } from '@phosphor-icons/react';
import type { WorkspaceDto } from '../types/workspace.types';
import { getWorkspaceIcon } from '../utils/workspaceIcons';
import { UpdateWorkspaceDialog } from './UpdateWorkspaceDialog';

interface WorkspaceItemProps {
  workspace: WorkspaceDto;
  isSelected: boolean;
  onSelect: (id: string) => void;
}

export const WorkspaceItem = ({ workspace, isSelected, onSelect }: WorkspaceItemProps) => {
  const displayName = workspace.name || (workspace as any).title || 'Untitled Workspace';
  const IconComponent = getWorkspaceIcon(workspace.iconName);

  return (
    <div className="relative group flex items-center w-full">
      <button
        type="button"
        onClick={() => onSelect(workspace.id)}
        className={`w-full flex items-center px-2.5 py-1.5 rounded-md text-xs font-medium transition-all duration-150 text-left truncate cursor-pointer select-none pr-8 ${
          isSelected
            ? 'bg-sidebar-accent text-sidebar-accent-foreground font-semibold shadow-2xs'
            : 'text-sidebar-foreground/75 hover:bg-sidebar-hover hover:text-sidebar-hover-foreground'
        }`}
      >
      <div className="flex items-center gap-1.5 truncate min-w-0">
        <IconComponent
          size={15}
          weight={isSelected ? 'fill' : 'regular'}
          className={`shrink-0 transition-colors ${
            isSelected
              ? 'text-sidebar-primary'
              : 'text-sidebar-foreground/50 group-hover:text-sidebar-foreground/80'
          }`}
        />
        <span className="truncate">{displayName}</span>

        {workspace.isTemporal && (
          <span
            title="Temporal Workspace"
            className={`shrink-0 transition-colors ${
              isSelected
                ? 'text-sidebar-primary'
                : 'text-sidebar-foreground/50 group-hover:text-sidebar-foreground/80'
            }`}
          >
            <ClockCountdown size={13} weight="bold" />
          </span>
        )}
      </div>
    </button>

      {/* Action Button */}
      <div 
        className="absolute right-1 top-1/2 -translate-y-1/2 opacity-0 group-hover:opacity-100 focus-within:opacity-100 transition-opacity"
        onClick={(e) => e.stopPropagation()}
      >
        <UpdateWorkspaceDialog workspace={workspace}>
          <button 
            type="button" 
            title="Update Workspace"
            className="p-1 rounded text-sidebar-foreground/50 hover:bg-sidebar-hover hover:text-sidebar-foreground transition-colors cursor-pointer"
          >
            <DotsThreeVertical size={16} weight="bold" />
          </button>
        </UpdateWorkspaceDialog>
      </div>
    </div>
  );
};