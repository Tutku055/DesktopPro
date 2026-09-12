import { CircleNotchIcon } from '@phosphor-icons/react';
import { useWorkspaces } from '../api/useWorkspaces';
import { WorkspaceItem } from './WorkspaceItem';

interface WorkspaceListProps {
  selectedId: string | null;
  onSelectWorkspace: (id: string) => void;
}

export const WorkspaceList = ({ selectedId, onSelectWorkspace }: WorkspaceListProps) => {
  const { data: workspaces, isLoading, isError} = useWorkspaces();

  // 1. Loading State
  if (isLoading) {
    return (
      <div className="flex flex-col items-center justify-center py-8 text-muted-foreground gap-2">
        <CircleNotchIcon size={18} className="animate-spin" />
        <span className="text-xs">Loading workspaces...</span>
      </div>
    );
  }

  // 2. Error State (RFC 7807)
  if (isError) {
    return (
      <div className="p-3 bg-destructive/10 border border-destructive/20 rounded-md text-destructive text-xs">
        Failed to load workspaces. Please ensure the backend is running.
      </div>
    );
  }

  // 3. Empty State
  if (!workspaces || workspaces.length === 0) {
    return (
      <div className="text-center py-6 text-xs text-muted-foreground">
        No workspaces found. Create one above.
      </div>
    );
  }

  // 4. Success / Data State
  return (
    <div className="space-y-0.5">
      {workspaces.map((workspace) => (
        <WorkspaceItem
          key={workspace.id}
          workspace={workspace}
          isSelected={workspace.id === selectedId}
          onSelect={onSelectWorkspace}
        />
      ))}
    </div>
  );
};