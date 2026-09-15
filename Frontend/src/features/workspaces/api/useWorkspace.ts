import { useQuery } from '@tanstack/react-query';
import { apiClient } from '@/api/client';
import type { WorkspaceDetailDto } from '../types/workspace.types';

// Extended key for detail queries
export const workspaceDetailKey = (id: string) => ['workspaces', 'detail', id];

export const useWorkspace = (id: string | null) => {
  return useQuery({
    queryKey: workspaceDetailKey(id as string),
    queryFn: async () => {
      const response = await apiClient.get<WorkspaceDetailDto>(`/workspaces/${id}`);
      return response.data;
    },
    enabled: !!id,
  });
};