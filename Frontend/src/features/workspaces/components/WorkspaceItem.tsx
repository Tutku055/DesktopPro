import { useState } from 'react';
import { ClockCountdown, DotsThreeVertical, PencilSimple, Trash } from '@phosphor-icons/react';
import type { WorkspaceDto } from '../types/workspace.types';
import { getWorkspaceIcon } from '../utils/workspaceIcons';
import { UpdateWorkspaceDialog } from './UpdateWorkspaceDialog';
import { DeleteWorkspaceDialog } from './DeleteWorkspaceDialog';
import {
  DropdownMenu,
  DropdownMenuContent,
  DropdownMenuItem,
  DropdownMenuTrigger,
} from '@/components/ui/dropdown-menu';

interface WorkspaceItemProps {
  workspace: WorkspaceDto;
  isSelected: boolean;
  onSelect: (id: string) => void;
}

export const WorkspaceItem = ({ workspace, isSelected, onSelect }: WorkspaceItemProps) => {
  const [updateOpen, setUpdateOpen] = useState(false);
  const [deleteOpen, setDeleteOpen] = useState(false);

  const displayName = workspace.name || (workspace as any).title || 'Untitled Workspace';
  const IconComponent = getWorkspaceIcon(workspace.iconName);

  const formattedExpiry = workspace.expiresAtUtc
    ? new Intl.DateTimeFormat('en-GB', {
        day: 'numeric',
        month: 'long',
        year: 'numeric',
        hour: '2-digit',
        minute: '2-digit',
      }).format(new Date(workspace.expiresAtUtc))
    : '';

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
            title={formattedExpiry ? `Expires: ${formattedExpiry}` : 'Temporal Workspace'}
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
        <DropdownMenu>
          <DropdownMenuTrigger asChild>
            <button 
              type="button" 
              title="Workspace Options"
              className="p-1 rounded text-sidebar-foreground/50 hover:bg-sidebar-hover hover:text-sidebar-foreground transition-colors cursor-pointer outline-none focus:outline-none focus-visible:outline-none ring-0 focus-visible:ring-0"
            >
              <DotsThreeVertical size={16} weight="bold" />
            </button>
          </DropdownMenuTrigger>
          <DropdownMenuContent align="end" className="w-36 outline-none focus:outline-none">
            <DropdownMenuItem 
              onClick={() => setUpdateOpen(true)}
              className="text-xs cursor-pointer gap-2 outline-none focus:outline-none"
            >
              <PencilSimple size={14} />
              Update
            </DropdownMenuItem>
            <DropdownMenuItem 
              onClick={() => setDeleteOpen(true)}
              variant="destructive"
              className="text-xs cursor-pointer gap-2 outline-none focus:outline-none"
            >
              <Trash size={14} />
              Delete
            </DropdownMenuItem>
          </DropdownMenuContent>
        </DropdownMenu>
      </div>

      <UpdateWorkspaceDialog 
        workspace={workspace} 
        open={updateOpen} 
        onOpenChange={setUpdateOpen} 
      />
      <DeleteWorkspaceDialog 
        workspace={workspace} 
        open={deleteOpen} 
        onOpenChange={setDeleteOpen} 
      />
    </div>
  );
};