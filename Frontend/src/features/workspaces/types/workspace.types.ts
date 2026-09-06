export interface WorkspaceDto {
  id: string;
  name: string;
  iconPath: string | null;
  isTemporal: boolean;
  expiresAtUtc: string | null;
  createdAt: string;
}

export interface CreateWorkspaceDto {
  name: string;
  isTemporal?: boolean;
  expiresAtUtc?: string | null;
  iconPath?: string | null;
}