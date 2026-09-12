import { useState } from 'react';
import { PlusIcon, CircleNotchIcon } from '@phosphor-icons/react';
import { useCreateWorkspace } from '../api/useCreateWorkspace';
import { Button } from '@/components/ui/button';
import { useSidebar } from '@/components/layout/SidebarContext';
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

export const CreateWorkspaceDialog = () => {
  const [open, setOpen] = useState(false);
  const [name, setName] = useState('');
  const [selectedIcon, setSelectedIcon] = useState<string>(DEFAULT_WORKSPACE_ICON);
  const createMutation = useCreateWorkspace();
  const { isOpen } = useSidebar();

  const handleSubmit = async (e: React.FormEvent<HTMLFormElement>) => {
    e.preventDefault();
    const trimmed = name.trim();
    if (!trimmed || createMutation.isPending) return;

    try {
      await createMutation.mutateAsync({
        name: trimmed,
        isTemporal: false,
        iconName: selectedIcon,
      });
      setName('');
      setSelectedIcon(DEFAULT_WORKSPACE_ICON);
      setOpen(false);
    } catch {
      // API errors are handled centrally by apiClient interceptor
    }
  };

  const handleOpenChange = (nextOpen: boolean) => {
    setOpen(nextOpen);
    if (!nextOpen) {
      setName('');
      setSelectedIcon(DEFAULT_WORKSPACE_ICON);
    }
  };

  return (
    <Dialog open={open} onOpenChange={handleOpenChange}>
      <DialogTrigger asChild>
        {isOpen ? (
          <Button
            variant="outline"
            size="sm"
            className="w-full justify-start gap-2 h-8 text-xs font-medium rounded-md border-sidebar-border bg-sidebar-hover/30 hover:bg-sidebar-hover hover:text-sidebar-hover-foreground text-sidebar-foreground cursor-pointer transition-colors shadow-2xs"
          >
            <PlusIcon size={14} weight="bold" className="shrink-0" />
            <span>New Workspace</span>
          </Button>
        ) : (
          <Button
            variant="outline"
            size="icon"
            title="New Workspace"
            className="h-8 w-8 rounded-md border-sidebar-border bg-sidebar-hover/30 hover:bg-sidebar-hover hover:text-sidebar-hover-foreground text-sidebar-foreground cursor-pointer transition-colors shadow-2xs"
          >
            <PlusIcon size={16} weight="bold" className="shrink-0" />
          </Button>
        )}
      </DialogTrigger>

      <DialogContent className="sm:max-w-[380px]">
        <DialogHeader>
          <DialogTitle className="text-sm font-heading font-semibold">Create Workspace</DialogTitle>
        </DialogHeader>

        <form onSubmit={handleSubmit} className="space-y-4 pt-1">
          {/* Workspace Name Input */}
          <div className="space-y-1.5">
            <Label htmlFor="workspace-name" className="text-xs text-muted-foreground font-medium">
              Name
            </Label>
            <Input
              id="workspace-name"
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

          {/* Action Buttons */}
          <div className="flex justify-end gap-2 pt-2">
            <Button
              type="button"
              variant="ghost"
              size="sm"
              onClick={() => handleOpenChange(false)}
              className="h-8 text-xs rounded-md cursor-pointer text-muted-foreground hover:text-foreground"
            >
              Cancel
            </Button>
            <Button
              type="submit"
              size="sm"
              disabled={!name.trim() || createMutation.isPending}
              className="h-8 text-xs rounded-md cursor-pointer font-medium"
            >
              {createMutation.isPending ? (
                <CircleNotchIcon size={14} className="animate-spin" />
              ) : (
                'Create'
              )}
            </Button>
          </div>
        </form>
      </DialogContent>
    </Dialog>
  );
};