using System;
using System.Collections.Generic;
using System.Text;

namespace ImGuiNET
{
    public enum ImGuiDockNodeFlagsPrivate
    {
        // [Internal]
        DockSpace                = 1 << 10,  // Local, Saved  // A dockspace is a node that occupy space within an existing user window. Otherwise the node is floating and create its own window.
        CentralNode              = 1 << 11,  // Local, Saved  // The central node has 2 main properties: stay visible when empty, only use "remaining" spaces from its neighbor.
        NoTabBar                 = 1 << 12,  // Local, Saved  // Tab bar is completely unavailable. No triangle in the corner to enable it back.
        HiddenTabBar             = 1 << 13,  // Local, Saved  // Tab bar is hidden, with a triangle in the corner to show it again (NB: actual tab-bar instance may be destroyed as this is only used for single-window tab bar)
        NoWindowMenuButton       = 1 << 14,  // Local, Saved  // Disable window/docking menu (that one that appears instead of the collapse button)
        NoCloseButton            = 1 << 15,  // Local, Saved  //
        NoDocking                = 1 << 16,  // Local, Saved  // Disable any form of docking in this dockspace or individual node. (On a whole dockspace, this pretty much defeat the purpose of using a dockspace at all). Note: when turned on, existing docked nodes will be preserved.
        NoDockingSplitMe         = 1 << 17,  // [EXPERIMENTAL] Prevent another window/node from splitting this node.
        NoDockingSplitOther      = 1 << 18,  // [EXPERIMENTAL] Prevent this node from splitting another window/node.
        NoDockingOverMe          = 1 << 19,  // [EXPERIMENTAL] Prevent another window/node to be docked over this node.
        NoDockingOverOther       = 1 << 20,  // [EXPERIMENTAL] Prevent this node to be docked over another window or non-empty node.
        NoDockingOverEmpty       = 1 << 21,  // [EXPERIMENTAL] Prevent this node to be docked over an empty node (e.g. DockSpace with no other windows)
        NoResizeX                = 1 << 22,  // [EXPERIMENTAL]
        NoResizeY                = 1 << 23,  // [EXPERIMENTAL]
        SharedFlagsInheritMask_  = ~0,
        NoResizeFlagsMask_       = ImGuiDockNodeFlags.NoResize | NoResizeX | NoResizeY,
        LocalFlagsMask_          = ImGuiDockNodeFlags.NoSplit | NoResizeFlagsMask_ | ImGuiDockNodeFlags.AutoHideTabBar | DockSpace | CentralNode | NoTabBar | HiddenTabBar | NoWindowMenuButton | NoCloseButton | NoDocking,
        LocalFlagsTransferMask_  = LocalFlagsMask_ & ~DockSpace,  // When splitting those flags are moved to the inheriting child, never duplicated
        SavedFlagsMask_          = NoResizeFlagsMask_ | DockSpace | CentralNode | NoTabBar | HiddenTabBar | NoWindowMenuButton | NoCloseButton | NoDocking
    }
}
