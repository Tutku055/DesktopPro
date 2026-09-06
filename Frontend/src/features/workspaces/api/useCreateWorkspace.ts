import { useMutation, useQueryClient } from '@tanstack/react-query';
import { apiClient } from '@/api/client';
import { workspaceKeys } from './useWorkspaces';
import type { CreateWorkspaceDto } from '../types/workspace.types';

export const useCreateWorkspace = () => {
  const queryClient = useQueryClient();

  return useMutation({
    mutationFn: async (payload: CreateWorkspaceDto) => {
      //Backend returns GUID
      const response = await apiClient.post<string>('/workspaces', payload);
      return response.data;
    },
    onSuccess: () => {
      //If CreateWorkspace is successful, invalidate the GET query cache and update UI immediately
      queryClient.invalidateQueries({ queryKey: workspaceKeys.all });
    },
  });
};