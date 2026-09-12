export interface WorkspaceDto {
  id: string;
  name: string;
  iconName: string | null;
  isTemporal: boolean;
  expiresAtUtc: string | null;
  createdAt: string;
}

export interface CreateWorkspaceDto {
  name: string;
  isTemporal?: boolean;
  expiresAtUtc?: string | null;
  iconName?: string | null;
}