import { useQuery } from "@tanstack/react-query";
import { apiClient } from "@/api/client";
import type { WorkspaceDto} from "../types/workspace.types";

export const workspaceKeys={
    all: ['workspaces'] as const,
    search: (q: string) => [...workspaceKeys.all, { search: q }] as const,
};

export const useWorkspaces = (searchQuery?: string) => {
  return useQuery<WorkspaceDto[]>({
    queryKey: searchQuery ? workspaceKeys.search(searchQuery) : workspaceKeys.all,
    queryFn: async () => {
      const endpoint = searchQuery && searchQuery.trim() !== ''
        ? `/workspaces/search?q=${encodeURIComponent(searchQuery.trim())}`
        : '/workspaces';
      const response = await apiClient.get<WorkspaceDto[]>(endpoint);
      return response.data;
    },
  });
};