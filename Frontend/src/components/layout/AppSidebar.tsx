import { WorkspaceList } from '@/features/workspaces/components/WorkspaceList';
import { CreateWorkspaceDialog } from '@/features/workspaces/components/CreateWorkspaceDialog';
import { ThemeSelector } from './ThemeSelector';
import { useSidebar } from './SidebarContext';

interface AppSidebarProps {
  selectedWorkspaceId: string | null;
  onSelectWorkspace: (id: string) => void;
}

export const AppSidebar = ({
  selectedWorkspaceId,
  onSelectWorkspace,
}: AppSidebarProps) => {
  const { isOpen } = useSidebar();

  return (
    <div className={`h-full flex flex-col select-none ${isOpen ? 'w-full' : 'items-center'}`}>
      {/* 1. New Workspace Action (Icon-only when collapsed, full button when open) */}
      <div className={isOpen ? 'mb-2' : 'mb-2 w-full flex justify-center'}>
        <CreateWorkspaceDialog />
      </div>

      {/* 2. Workspace List (Completely hidden when collapsed) */}
      {isOpen && (
        <div className="flex-1 overflow-y-auto min-h-0 pr-0.5">
          <div className="px-1 py-1 text-[11px] font-semibold text-muted-foreground/60 uppercase tracking-wider mb-1">
            Workspaces
          </div>
          <WorkspaceList
            selectedId={selectedWorkspaceId}
            onSelectWorkspace={onSelectWorkspace}
          />
        </div>
      )}

      {/* 3. Footer: Theme Switcher & Status */}
      <div
        className={`pt-2 mt-auto border-t border-sidebar-border/50 w-full flex items-center ${
          isOpen ? 'px-1 justify-between text-[11px]' : 'justify-center py-1'
        } text-muted-foreground`}
      >
        <ThemeSelector />
        {isOpen && (
          <div className="flex items-center gap-1.5 pr-1">
            <span>Ready</span>
            <span className="h-1.5 w-1.5 rounded-full bg-emerald-500" />
          </div>
        )}
      </div>
    </div>
  );
};