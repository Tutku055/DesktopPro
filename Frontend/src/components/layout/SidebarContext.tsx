import { createContext, useContext } from 'react';

interface SidebarContextValue {
  isOpen: boolean;
  setIsOpen: (open: boolean | ((prev: boolean) => boolean)) => void;
  toggleSidebar: () => void;
}

export const SidebarContext = createContext<SidebarContextValue>({
  isOpen: true,
  setIsOpen: () => {},
  toggleSidebar: () => {},
});

export const useSidebar = () => useContext(SidebarContext);
