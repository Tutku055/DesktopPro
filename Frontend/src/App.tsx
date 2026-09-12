import { useState } from 'react';
import { MainLayout } from '@/components/layout/MainLayout';
import { AppSidebar } from '@/components/layout/AppSidebar';

export default function App() {
  // Track currently active workspace ID across slices
  const [selectedWorkspaceId, setSelectedWorkspaceId] = useState<string | null>(null);

  return (
    <MainLayout
      sidebar={
        <AppSidebar
          selectedWorkspaceId={selectedWorkspaceId}
          onSelectWorkspace={setSelectedWorkspaceId}
        />
      }
    >
      {/* Main Workspace Viewport */}
      <div className="h-full flex items-center justify-center p-6">
        {selectedWorkspaceId ? (
          <div className="text-center space-y-2">
            <h1 className="text-2xl font-heading font-medium tracking-tight">
              Active Workspace
            </h1>
            <p className="text-xs text-muted-foreground font-mono">
              ID: {selectedWorkspaceId}
            </p>
          </div>
        ) : (
          <div className="text-center space-y-1.5">
            <h1 className="text-sm font-medium text-foreground">
              No workspace selected
            </h1>
            <p className="text-xs text-muted-foreground">
              Choose a workspace from the sidebar or create a new one to begin.
            </p>
          </div>
        )}
      </div>
    </MainLayout>
  );
}