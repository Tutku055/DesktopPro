import { useState } from 'react';
import { CircleNotchIcon } from '@phosphor-icons/react';
import { useDeleteWorkspace } from '../api/useDeleteWorkspace';
import {
  AlertDialog,
  AlertDialogAction,
  AlertDialogCancel,
  AlertDialogContent,
  AlertDialogDescription,
  AlertDialogFooter,
  AlertDialogHeader,
  AlertDialogTitle,
} from '@/components/ui/alert-dialog';
import type { WorkspaceDto } from '../types/workspace.types';

interface DeleteWorkspaceDialogProps {
  workspace: WorkspaceDto;
  open: boolean;
  onOpenChange: (open: boolean) => void;
}

export const DeleteWorkspaceDialog = ({
  workspace,
  open,
  onOpenChange,
}: DeleteWorkspaceDialogProps) => {
  const deleteMutation = useDeleteWorkspace();

  const handleDelete = async () => {
    try {
      await deleteMutation.mutateAsync(workspace.id);
      onOpenChange(false);
    } catch {
      // API errors handled centrally
    }
  };

  return (
    <AlertDialog open={open} onOpenChange={onOpenChange}>
      <AlertDialogContent className="sm:max-w-[425px]" onClick={(e) => e.stopPropagation()}>
        <AlertDialogHeader>
          <AlertDialogTitle className="font-heading font-semibold text-destructive">
            Delete Workspace
          </AlertDialogTitle>
          <AlertDialogDescription className="text-sm">
            Are you sure you want to delete the "{workspace.name}" workspace? This action cannot be undone.
          </AlertDialogDescription>
        </AlertDialogHeader>
        <AlertDialogFooter>
          <AlertDialogCancel disabled={deleteMutation.isPending} className="h-8 text-xs cursor-pointer">
            Cancel
          </AlertDialogCancel>
          <AlertDialogAction
            onClick={(e) => {
              e.preventDefault();
              handleDelete();
            }}
            disabled={deleteMutation.isPending}
            className="h-8 text-xs bg-destructive text-destructive-foreground hover:bg-destructive/90 cursor-pointer"
          >
            {deleteMutation.isPending ? (
              <CircleNotchIcon size={14} className="animate-spin mr-1.5" />
            ) : null}
            Delete
          </AlertDialogAction>
        </AlertDialogFooter>
      </AlertDialogContent>
    </AlertDialog>
  );
};
