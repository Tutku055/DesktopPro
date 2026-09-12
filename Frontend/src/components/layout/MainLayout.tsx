import { type ReactNode, useState, useEffect } from 'react';
import { SidebarSimpleIcon } from '@phosphor-icons/react';
import { Button } from '@/components/ui/button';
import { SidebarContext } from './SidebarContext';
import desktopProLogo from '@/assets/images/DesktopPro_Icon.png';

interface MainLayoutProps {
  /** Slot for vertical slice navigation (e.g. WorkspaceList, QuickActions) */
  sidebar: ReactNode;
  /** Optional bottom slot for user profile or settings */
  sidebarFooter?: ReactNode;
  /** Main viewport content */
  children: ReactNode;
}

export const MainLayout = ({ sidebar, sidebarFooter, children }: MainLayoutProps) => {
  const [isSidebarOpen, setIsSidebarOpen] = useState(true);

  // Global desktop shortcut: Ctrl + B or Cmd + B to toggle sidebar
  useEffect(() => {
    const handleKeyDown = (event: KeyboardEvent) => {
      if ((event.ctrlKey || event.metaKey) && event.key.toLowerCase() === 'b') {
        event.preventDefault();
        setIsSidebarOpen((prev) => !prev);
      }
    };

    window.addEventListener('keydown', handleKeyDown);
    return () => window.removeEventListener('keydown', handleKeyDown);
  }, []);

  return (
    <SidebarContext.Provider
      value={{
        isOpen: isSidebarOpen,
        setIsOpen: setIsSidebarOpen,
        toggleSidebar: () => setIsSidebarOpen((prev) => !prev),
      }}
    >
      <div className="flex h-screen w-screen bg-background text-foreground overflow-hidden select-none font-sans antialiased">
        {/* 
          Collapsible Sidebar Container:
          Replaced harsh solid border with a soft micro-shadow partition.
        */}
        <aside
          className={`h-full bg-sidebar text-sidebar-foreground flex flex-col shrink-0 border-r border-sidebar-border transition-all duration-200 ease-in-out z-20 ${
            isSidebarOpen ? 'w-64' : 'w-14'
          }`}
        >
          {/* Top Header: Dynamic layout depending on collapse state */}
          <div
            className={`h-14 flex items-center shrink-0 ${
              isSidebarOpen ? 'justify-between px-3.5' : 'justify-center px-0'
            }`}
          >
            {isSidebarOpen ? (
              <>
                {/* Expanded State: Logo + Program Title */}
                <div className="flex items-center gap-2.5 overflow-hidden">
                  <img
                    src={desktopProLogo}
                    alt="Desktop Pro"
                    className="h-7 w-7 shrink-0 object-contain sidebar-logo"
                  />
                  <span className="font-heading font-medium text-base tracking-tight truncate">
                    Desktop Pro
                  </span>
                </div>

                {/* Collapse Button */}
                <Button
                  variant="ghost"
                  size="icon"
                  onClick={() => setIsSidebarOpen(false)}
                  className="h-8 w-8 text-sidebar-foreground/60 hover:text-sidebar-foreground hover:bg-sidebar-hover shrink-0 rounded-md"
                  title="Collapse sidebar (Ctrl+B)"
                >
                  <SidebarSimpleIcon size={18} />
                </Button>
              </>
            ) : (
              /* 
                Collapsed State: Centered in rail.
                Shows logo by default; swaps to expand icon on hover.
              */
              <button
                type="button"
                onClick={() => setIsSidebarOpen(true)}
                className="group relative flex h-8 w-8 items-center justify-center rounded-md hover:bg-sidebar-hover transition-colors cursor-pointer"
                title="Expand sidebar (Ctrl+B)"
              >
                {/* Default Logo view (fades out on hover) */}
                <img
                  src={desktopProLogo}
                  alt="Desktop Pro"
                  className="h-7 w-7 shrink-0 object-contain sidebar-logo transition-opacity duration-150 group-hover:opacity-0"
                />

                {/* Hover Expand Icon view (fades in on hover) */}
                <div className="absolute inset-0 flex items-center justify-center text-sidebar-foreground/70 group-hover:text-sidebar-foreground opacity-0 transition-opacity duration-150 group-hover:opacity-100">
                  <SidebarSimpleIcon size={18} />
                </div>
              </button>
            )}
          </div>

          {/* Dynamic Workspace Slot: Vertical slice components render here */}
          <div
            className={`flex-1 overflow-y-auto space-y-1 overflow-x-hidden ${
              isSidebarOpen ? 'px-2.5 py-1' : 'px-1.5 py-1 flex flex-col items-center'
            }`}
          >
            {sidebar}
          </div>

          {/* Optional Footer Slot */}
          {sidebarFooter && (
            <div className="p-2 shadow-[0_-1px_0_0_rgba(0,0,0,0.04)] dark:shadow-[0_-1px_0_0_rgba(255,255,255,0.05)] shrink-0">
              {sidebarFooter}
            </div>
          )}
        </aside>

        {/* Main Viewport Content Area */}
        <div className="flex-1 flex flex-col h-full min-w-0 overflow-hidden bg-background">
          <main className="flex-1 h-full flex flex-col min-h-0 overflow-hidden">
            {children}
          </main>
        </div>
      </div>
    </SidebarContext.Provider>
  );
};