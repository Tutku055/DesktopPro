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

export interface WorkspaceDetailDto {
  id: string;
  name: string;
  isTemporal: boolean;
  iconName?: string;
  expiresAtUtc?: string;
  createdAt: string;
}