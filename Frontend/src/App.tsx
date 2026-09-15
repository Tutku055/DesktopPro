import { useState, useEffect } from 'react';
import { MainLayout } from '@/components/layout/MainLayout';
import { AppSidebar } from '@/components/layout/AppSidebar';
import { WorkspaceDetailView } from '@/features/workspaces/components/WorkspaceDetailView';
import { useWorkspaces } from '@/features/workspaces/api/useWorkspaces';

export default function App() {
  // Track currently active workspace ID across slices
  const [selectedWorkspaceId, setSelectedWorkspaceId] = useState<string | null>(null);
  const { data: workspaces } = useWorkspaces();

  // Automatically select the first workspace if none is currently selected
  useEffect(() => {
    if (!selectedWorkspaceId && workspaces && workspaces.length > 0) {
      setSelectedWorkspaceId(workspaces[0].id);
    }
  }, [workspaces, selectedWorkspaceId]);

  return (
    <MainLayout
      sidebar={
        <AppSidebar
          selectedWorkspaceId={selectedWorkspaceId}
          onSelectWorkspace={setSelectedWorkspaceId}
        />
      }
    >
      <WorkspaceDetailView workspaceId={selectedWorkspaceId} />
    </MainLayout>
  );
}