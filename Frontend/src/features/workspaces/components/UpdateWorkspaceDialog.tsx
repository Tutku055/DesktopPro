import { useState, useEffect } from 'react';
import { CircleNotchIcon } from '@phosphor-icons/react';
import { useUpdateWorkspace } from '../api/useUpdateWorkspace';
import { Button } from '@/components/ui/button';
import {
  Dialog,
  DialogContent,
  DialogHeader,
  DialogTitle,
  DialogTrigger,
} from '@/components/ui/dialog';
import { Input } from '@/components/ui/input';
import { Label } from '@/components/ui/label';
import { WORKSPACE_ICONS, DEFAULT_WORKSPACE_ICON } from '../utils/workspaceIcons';
import type { WorkspaceDto } from '../types/workspace.types';

interface UpdateWorkspaceDialogProps {
  workspace: WorkspaceDto;
  children: React.ReactNode;
}

export const UpdateWorkspaceDialog = ({ workspace, children }: UpdateWorkspaceDialogProps) => {
  const [open, setOpen] = useState(false);
  const [name, setName] = useState(workspace.name);
  const [selectedIcon, setSelectedIcon] = useState<string>(workspace.iconName || DEFAULT_WORKSPACE_ICON);
  const [isTemporal, setIsTemporal] = useState(workspace.isTemporal);
  const [temporalHours, setTemporalHours] = useState(24);
  const updateMutation = useUpdateWorkspace(workspace.id);

  useEffect(() => {
    if (open) {
      setName(workspace.name);
      setSelectedIcon(workspace.iconName || DEFAULT_WORKSPACE_ICON);
      setIsTemporal(workspace.isTemporal);
      
      if (workspace.isTemporal && workspace.expiresAtUtc) {
        const diff = new Date(workspace.expiresAtUtc).getTime() - Date.now();
        const hours = Math.max(1, Math.round(diff / (1000 * 60 * 60)));
        const allowed = [1, 6, 24, 72, 168];
        const closest = allowed.reduce((prev, curr) => Math.abs(curr - hours) < Math.abs(prev - hours) ? curr : prev);
        setTemporalHours(closest);
      } else {
        setTemporalHours(24);
      }
    }
  }, [open, workspace]);

  const handleSubmit = async (e: React.FormEvent<HTMLFormElement>) => {
    e.preventDefault();
    const trimmed = name.trim();
    if (!trimmed || updateMutation.isPending) return;

    try {
      const expiresAtUtc = isTemporal
        ? new Date(Date.now() + temporalHours * 60 * 60 * 1000).toISOString()
        : null;

      await updateMutation.mutateAsync({
        name: trimmed,
        isTemporal,
        expiresAtUtc,
        iconName: selectedIcon,
      });

      setOpen(false);
    } catch {
      // API errors are handled centrally
    }
  };

  const formattedDate = workspace.updatedAt
    ? new Intl.DateTimeFormat('en-GB', {
        day: 'numeric',
        month: 'long',
        year: 'numeric',
        hour: '2-digit',
        minute: '2-digit',
      }).format(new Date(workspace.updatedAt))
    : 'N/A';

  return (
    <Dialog open={open} onOpenChange={setOpen}>
      <DialogTrigger asChild>
        {children}
      </DialogTrigger>

      <DialogContent className="sm:max-w-[380px]" onClick={(e) => e.stopPropagation()}>
        <DialogHeader>
          <DialogTitle className="text-sm font-heading font-semibold">Update Workspace</DialogTitle>
        </DialogHeader>

        <form onSubmit={handleSubmit} className="space-y-4 pt-1">
          {/* Workspace Name Input */}
          <div className="space-y-1.5">
            <Label htmlFor={`update-workspace-name-${workspace.id}`} className="text-xs text-muted-foreground font-medium">
              Name
            </Label>
            <Input
              id={`update-workspace-name-${workspace.id}`}
              value={name}
              onChange={(e) => setName(e.target.value)}
              placeholder="e.g. Core Architecture"
              autoFocus
              className="h-8 text-xs"
            />
          </div>

          {/* Optional Icon Selector Grid */}
          <div className="space-y-1.5">
            <div className="flex items-center justify-between">
              <Label className="text-xs text-muted-foreground font-medium">
                Workspace Icon
              </Label>
              <span className="text-[11px] text-muted-foreground/80 font-medium">
                {WORKSPACE_ICONS.find((i) => i.id === selectedIcon)?.label}
              </span>
            </div>

            <div className="grid grid-cols-5 gap-1.5 p-2 rounded-md border border-input bg-card/40 max-h-36 overflow-y-auto">
              {WORKSPACE_ICONS.map(({ id, label, icon: IconComponent }) => {
                const isSelected = selectedIcon === id;
                return (
                  <button
                    key={id}
                    type="button"
                    onClick={() => setSelectedIcon(id)}
                    title={label}
                    className={`h-8 w-8 flex items-center justify-center rounded-md text-sm transition-all cursor-pointer ${
                      isSelected
                        ? 'bg-primary text-primary-foreground shadow-xs ring-1 ring-primary'
                        : 'text-muted-foreground hover:text-foreground hover:bg-muted/60'
                    }`}
                  >
                    <IconComponent size={16} weight={isSelected ? 'fill' : 'regular'} />
                  </button>
                );
              })}
            </div>
          </div>

          {/* Temporal Workspace Option */}
          <div className="p-2.5 rounded-md border border-border/50 bg-muted/20 space-y-2">
            <label className="flex items-center gap-2 cursor-pointer text-xs font-medium text-foreground select-none">
              <input
                type="checkbox"
                checked={isTemporal}
                onChange={(e) => setIsTemporal(e.target.checked)}
                className="h-3.5 w-3.5 rounded border-input text-primary accent-primary cursor-pointer"
              />
              <span>Temporal Workspace</span>
            </label>

            {isTemporal && (
              <div className="flex items-center gap-2 text-[11px] text-muted-foreground pl-5">
                <span>Expires in:</span>
                <select
                  value={temporalHours}
                  onChange={(e) => setTemporalHours(Number(e.target.value))}
                  className="h-6 rounded border border-input bg-card text-foreground px-1.5 text-xs outline-none"
                >
                  <option value={1}>1 hour</option>
                  <option value={6}>6 hours</option>
                  <option value={24}>24 hours (1 day)</option>
                  <option value={72}>3 days</option>
                  <option value={168}>7 days</option>
                </select>
              </div>
            )}
          </div>

          {/* Action Buttons & Info */}
          <div className="flex items-center justify-between pt-2">
            <span className="text-[10px] text-muted-foreground font-medium">
              Last updated: {formattedDate}
            </span>
            <div className="flex justify-end gap-2">
              <Button
                type="button"
                variant="ghost"
                size="sm"
                onClick={() => setOpen(false)}
                className="h-8 text-xs rounded-md cursor-pointer text-muted-foreground hover:text-foreground"
              >
                Cancel
              </Button>
              <Button
                type="submit"
                size="sm"
                disabled={!name.trim() || updateMutation.isPending}
                className="h-8 text-xs rounded-md cursor-pointer font-medium"
              >
                {updateMutation.isPending ? (
                  <CircleNotchIcon size={14} className="animate-spin" />
                ) : (
                  'Save'
                )}
              </Button>
            </div>
          </div>
        </form>
      </DialogContent>
    </Dialog>
  );
};
