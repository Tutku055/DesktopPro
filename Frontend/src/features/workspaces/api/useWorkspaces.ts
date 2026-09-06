import { useQuery } from "@tanstack/react-query";
import { apiClient } from "@/api/client";
import type { WorkspaceDto} from "../types/workspace.types";

export const workspaceKeys={
    all: ['workspaces'] as const,
};

export const useWorkspaces = () => {
  return useQuery<WorkspaceDto[]>({
    queryKey: workspaceKeys.all,
    queryFn: async () => {
      const response = await apiClient.get<WorkspaceDto[]>('/workspaces');
      return response.data;
    },
  });
};