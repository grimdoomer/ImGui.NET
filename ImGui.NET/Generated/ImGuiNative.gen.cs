using System;
using SharpDX;
using System.Runtime.InteropServices;

namespace ImGuiNET
{
    public static unsafe partial class ImGuiNative
    {
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiPayload* igAcceptDragDropPayload(byte* type, ImGuiDragDropFlags flags);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igActivateItemByID(uint id);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igAddDrawListToDrawDataEx(ImDrawData* draw_data, ImVector* out_list, ImDrawList* draw_list);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igAddSettingsHandler(ImGuiSettingsHandler* handler);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igAlignTextToFramePadding();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igArrowButton(byte* str_id, ImGuiDir dir);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igArrowButtonEx(byte* str_id, ImGuiDir dir, Vector2 size_arg, ImGuiButtonFlags flags);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igBegin(byte* name, byte* p_open, ImGuiWindowFlags flags);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igBeginBoxSelect(ImRect scope_rect, ImGuiWindow* window, uint box_select_id, ImGuiMultiSelectFlags ms_flags);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igBeginChild_Str(byte* str_id, Vector2 size, ImGuiChildFlags child_flags, ImGuiWindowFlags window_flags);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igBeginChild_ID(uint id, Vector2 size, ImGuiChildFlags child_flags, ImGuiWindowFlags window_flags);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igBeginChildEx(byte* name, uint id, Vector2 size_arg, ImGuiChildFlags child_flags, ImGuiWindowFlags window_flags);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igBeginColumns(byte* str_id, int count, ImGuiOldColumnFlags flags);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igBeginCombo(byte* label, byte* preview_value, ImGuiComboFlags flags);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igBeginComboPopup(uint popup_id, ImRect bb, ImGuiComboFlags flags);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igBeginComboPreview();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igBeginDisabled(byte disabled);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igBeginDisabledOverrideReenable();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igBeginDockableDragDropSource(ImGuiWindow* window);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igBeginDockableDragDropTarget(ImGuiWindow* window);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igBeginDocked(ImGuiWindow* window, byte* p_open);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igBeginDragDropSource(ImGuiDragDropFlags flags);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igBeginDragDropTarget();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igBeginDragDropTargetCustom(ImRect bb, uint id);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igBeginErrorTooltip();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igBeginGroup();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igBeginItemTooltip();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igBeginListBox(byte* label, Vector2 size);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igBeginMainMenuBar();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igBeginMenu(byte* label, byte enabled);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igBeginMenuBar();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igBeginMenuEx(byte* label, byte* icon, byte enabled);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiMultiSelectIO* igBeginMultiSelect(ImGuiMultiSelectFlags flags, int selection_size, int items_count);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igBeginPopup(byte* str_id, ImGuiWindowFlags flags);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igBeginPopupContextItem(byte* str_id, ImGuiPopupFlags popup_flags);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igBeginPopupContextVoid(byte* str_id, ImGuiPopupFlags popup_flags);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igBeginPopupContextWindow(byte* str_id, ImGuiPopupFlags popup_flags);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igBeginPopupEx(uint id, ImGuiWindowFlags extra_window_flags);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igBeginPopupMenuEx(uint id, byte* label, ImGuiWindowFlags extra_window_flags);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igBeginPopupModal(byte* name, byte* p_open, ImGuiWindowFlags flags);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igBeginTabBar(byte* str_id, ImGuiTabBarFlags flags);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igBeginTabBarEx(ImGuiTabBar* tab_bar, ImRect bb, ImGuiTabBarFlags flags);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igBeginTabItem(byte* label, byte* p_open, ImGuiTabItemFlags flags);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igBeginTable(byte* str_id, int columns, ImGuiTableFlags flags, Vector2 outer_size, float inner_width);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igBeginTableEx(byte* name, uint id, int columns_count, ImGuiTableFlags flags, Vector2 outer_size, float inner_width);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igBeginTooltip();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igBeginTooltipEx(ImGuiTooltipFlags tooltip_flags, ImGuiWindowFlags extra_window_flags);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igBeginTooltipHidden();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igBeginViewportSideBar(byte* name, ImGuiViewport* viewport, ImGuiDir dir, float size, ImGuiWindowFlags window_flags);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igBringWindowToDisplayBack(ImGuiWindow* window);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igBringWindowToDisplayBehind(ImGuiWindow* window, ImGuiWindow* above_window);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igBringWindowToDisplayFront(ImGuiWindow* window);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igBringWindowToFocusFront(ImGuiWindow* window);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igBullet();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igBulletText(byte* fmt);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igButton(byte* label, Vector2 size);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igButtonBehavior(ImRect bb, uint id, byte* out_hovered, byte* out_held, ImGuiButtonFlags flags);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igButtonEx(byte* label, Vector2 size_arg, ImGuiButtonFlags flags);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igCalcClipRectVisibleItemsY(ImRect clip_rect, Vector2 pos, float items_height, int* out_visible_start, int* out_visible_end);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igCalcItemSize(Vector2* pOut, Vector2 size, float default_w, float default_h);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern float igCalcItemWidth();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImDrawFlags igCalcRoundingFlagsForRectInRect(ImRect r_in, ImRect r_outer, float threshold);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igCalcTextSize(Vector2* pOut, byte* text, byte* text_end, byte hide_text_after_double_hash, float wrap_width);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern int igCalcTypematicRepeatAmount(float t0, float t1, float repeat_delay, float repeat_rate);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igCalcWindowNextAutoFitSize(Vector2* pOut, ImGuiWindow* window);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern float igCalcWrapWidthForPos(Vector2 pos, float wrap_pos_x);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igCallContextHooks(IntPtr context, ImGuiContextHookType type);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igCheckbox(byte* label, byte* v);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igCheckboxFlags_IntPtr(byte* label, int* flags, int flags_value);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igCheckboxFlags_UintPtr(byte* label, uint* flags, uint flags_value);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igCheckboxFlags_S64Ptr(byte* label, long* flags, long flags_value);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igCheckboxFlags_U64Ptr(byte* label, ulong* flags, ulong flags_value);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igClearActiveID();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igClearDragDrop();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igClearIniSettings();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igClearWindowSettings(byte* name);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igCloseButton(uint id, Vector2 pos);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igCloseCurrentPopup();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igClosePopupsExceptModals();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igClosePopupsOverWindow(ImGuiWindow* ref_window, byte restore_focus_to_window_under_popup);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igClosePopupToLevel(int remaining, byte restore_focus_to_window_under_popup);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igCollapseButton(uint id, Vector2 pos, ImGuiDockNode* dock_node);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igCollapsingHeader_TreeNodeFlags(byte* label, ImGuiTreeNodeFlags flags);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igCollapsingHeader_BoolPtr(byte* label, byte* p_visible, ImGuiTreeNodeFlags flags);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igColorButton(byte* desc_id, Vector4 col, ImGuiColorEditFlags flags, Vector2 size);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern uint igColorConvertFloat4ToU32(Vector4 @in);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igColorConvertHSVtoRGB(float h, float s, float v, float* out_r, float* out_g, float* out_b);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igColorConvertRGBtoHSV(float r, float g, float b, float* out_h, float* out_s, float* out_v);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igColorConvertU32ToFloat4(Vector4* pOut, uint @in);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igColorEdit3(byte* label, Vector3* col, ImGuiColorEditFlags flags);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igColorEdit4(byte* label, Vector4* col, ImGuiColorEditFlags flags);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igColorEditOptionsPopup(float* col, ImGuiColorEditFlags flags);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igColorPicker3(byte* label, Vector3* col, ImGuiColorEditFlags flags);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igColorPicker4(byte* label, Vector4* col, ImGuiColorEditFlags flags, float* ref_col);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igColorPickerOptionsPopup(float* ref_col, ImGuiColorEditFlags flags);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igColorTooltip(byte* text, float* col, ImGuiColorEditFlags flags);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igColumns(int count, byte* id, byte borders);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igCombo_Str_arr(byte* label, int* current_item, byte** items, int items_count, int popup_max_height_in_items);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igCombo_Str(byte* label, int* current_item, byte* items_separated_by_zeros, int popup_max_height_in_items);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiKey igConvertSingleModFlagToKey(ImGuiKey key);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr igCreateContext(ImFontAtlas* shared_font_atlas);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiWindowSettings* igCreateNewWindowSettings(byte* name);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igDataTypeApplyFromText(byte* buf, ImGuiDataType data_type, void* p_data, byte* format, void* p_data_when_empty);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igDataTypeApplyOp(ImGuiDataType data_type, int op, void* output, void* arg_1, void* arg_2);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igDataTypeClamp(ImGuiDataType data_type, void* p_data, void* p_min, void* p_max);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern int igDataTypeCompare(ImGuiDataType data_type, void* arg_1, void* arg_2);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern int igDataTypeFormatString(byte* buf, int buf_size, ImGuiDataType data_type, void* p_data, byte* format);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiDataTypeInfo* igDataTypeGetInfo(ImGuiDataType data_type);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igDataTypeIsZero(ImGuiDataType data_type, void* p_data);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igDebugAllocHook(ImGuiDebugAllocInfo* info, int frame_count, void* ptr, uint size);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igDebugBreakButton(byte* label, byte* description_of_location);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igDebugBreakButtonTooltip(byte keyboard_only, byte* description_of_location);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igDebugBreakClearData();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igDebugCheckVersionAndDataLayout(byte* version_str, uint sz_io, uint sz_style, uint sz_vec2, uint sz_vec4, uint sz_drawvert, uint sz_drawidx);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igDebugDrawCursorPos(uint col);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igDebugDrawItemRect(uint col);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igDebugDrawLineExtents(uint col);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igDebugFlashStyleColor(ImGuiCol idx);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igDebugHookIdInfo(uint id, ImGuiDataType data_type, void* data_id, void* data_id_end);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igDebugLocateItem(uint target_id);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igDebugLocateItemOnHover(uint target_id);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igDebugLocateItemResolveWithLastItem();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igDebugLog(byte* fmt);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igDebugNodeColumns(ImGuiOldColumns* columns);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igDebugNodeDockNode(ImGuiDockNode* node, byte* label);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igDebugNodeDrawCmdShowMeshAndBoundingBox(ImDrawList* out_draw_list, ImDrawList* draw_list, ImDrawCmd* draw_cmd, byte show_mesh, byte show_aabb);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igDebugNodeDrawList(ImGuiWindow* window, ImGuiViewportP* viewport, ImDrawList* draw_list, byte* label);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igDebugNodeFont(ImFont* font);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igDebugNodeFontGlyph(ImFont* font, ImFontGlyph* glyph);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igDebugNodeFontGlyphesForSrcMask(ImFont* font, ImFontBaked* baked, int src_mask);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igDebugNodeInputTextState(ImGuiInputTextState* state);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igDebugNodeMultiSelectState(ImGuiMultiSelectState* state);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igDebugNodePlatformMonitor(ImGuiPlatformMonitor* monitor, byte* label, int idx);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igDebugNodeStorage(ImGuiStorage* storage, byte* label);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igDebugNodeTabBar(ImGuiTabBar* tab_bar, byte* label);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igDebugNodeTable(ImGuiTable* table);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igDebugNodeTableSettings(ImGuiTableSettings* settings);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igDebugNodeTexture(ImTextureData* tex, int int_id, ImFontAtlasRect* highlight_rect);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igDebugNodeTypingSelectState(ImGuiTypingSelectState* state);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igDebugNodeViewport(ImGuiViewportP* viewport);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igDebugNodeWindow(ImGuiWindow* window, byte* label);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igDebugNodeWindowSettings(ImGuiWindowSettings* settings);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igDebugNodeWindowsList(ImVector* windows, byte* label);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igDebugNodeWindowsListByBeginStackParent(ImGuiWindow** windows, int windows_size, ImGuiWindow* parent_in_begin_stack);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igDebugRenderKeyboardPreview(ImDrawList* draw_list);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igDebugRenderViewportThumbnail(ImDrawList* draw_list, ImGuiViewportP* viewport, ImRect bb);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igDebugStartItemPicker();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igDebugTextEncoding(byte* text);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igDebugTextUnformattedWithLocateItem(byte* line_begin, byte* line_end);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igDestroyContext(IntPtr ctx);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igDestroyPlatformWindow(ImGuiViewportP* viewport);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igDestroyPlatformWindows();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern uint igDockBuilderAddNode(uint node_id, ImGuiDockNodeFlags flags);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igDockBuilderCopyDockSpace(uint src_dockspace_id, uint dst_dockspace_id, ImVector* in_window_remap_pairs);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igDockBuilderCopyNode(uint src_node_id, uint dst_node_id, ImVector* out_node_remap_pairs);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igDockBuilderCopyWindowSettings(byte* src_name, byte* dst_name);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igDockBuilderDockWindow(byte* window_name, uint node_id);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igDockBuilderFinish(uint node_id);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiDockNode* igDockBuilderGetCentralNode(uint node_id);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiDockNode* igDockBuilderGetNode(uint node_id);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igDockBuilderRemoveNode(uint node_id);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igDockBuilderRemoveNodeChildNodes(uint node_id);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igDockBuilderRemoveNodeDockedWindows(uint node_id, byte clear_settings_refs);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igDockBuilderSetNodePos(uint node_id, Vector2 pos);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igDockBuilderSetNodeSize(uint node_id, Vector2 size);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern uint igDockBuilderSplitNode(uint node_id, ImGuiDir split_dir, float size_ratio_for_node_at_dir, uint* out_id_at_dir, uint* out_id_at_opposite_dir);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igDockContextCalcDropPosForDocking(ImGuiWindow* target, ImGuiDockNode* target_node, ImGuiWindow* payload_window, ImGuiDockNode* payload_node, ImGuiDir split_dir, byte split_outer, Vector2* out_pos);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igDockContextClearNodes(IntPtr ctx, uint root_id, byte clear_settings_refs);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igDockContextEndFrame(IntPtr ctx);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiDockNode* igDockContextFindNodeByID(IntPtr ctx, uint id);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern uint igDockContextGenNodeID(IntPtr ctx);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igDockContextInitialize(IntPtr ctx);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igDockContextNewFrameUpdateDocking(IntPtr ctx);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igDockContextNewFrameUpdateUndocking(IntPtr ctx);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igDockContextProcessUndockNode(IntPtr ctx, ImGuiDockNode* node);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igDockContextProcessUndockWindow(IntPtr ctx, ImGuiWindow* window, byte clear_persistent_docking_ref);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igDockContextQueueDock(IntPtr ctx, ImGuiWindow* target, ImGuiDockNode* target_node, ImGuiWindow* payload, ImGuiDir split_dir, float split_ratio, byte split_outer);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igDockContextQueueUndockNode(IntPtr ctx, ImGuiDockNode* node);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igDockContextQueueUndockWindow(IntPtr ctx, ImGuiWindow* window);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igDockContextRebuildNodes(IntPtr ctx);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igDockContextShutdown(IntPtr ctx);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igDockNodeBeginAmendTabBar(ImGuiDockNode* node);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igDockNodeEndAmendTabBar();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern int igDockNodeGetDepth(ImGuiDockNode* node);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiDockNode* igDockNodeGetRootNode(ImGuiDockNode* node);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern uint igDockNodeGetWindowMenuButtonId(ImGuiDockNode* node);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igDockNodeIsInHierarchyOf(ImGuiDockNode* node, ImGuiDockNode* parent);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igDockNodeWindowMenuHandler_Default(IntPtr ctx, ImGuiDockNode* node, ImGuiTabBar* tab_bar);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern uint igDockSpace(uint dockspace_id, Vector2 size, ImGuiDockNodeFlags flags, ImGuiWindowClass* window_class);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern uint igDockSpaceOverViewport(uint dockspace_id, ImGuiViewport* viewport, ImGuiDockNodeFlags flags, ImGuiWindowClass* window_class);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igDragBehavior(uint id, ImGuiDataType data_type, void* p_v, float v_speed, void* p_min, void* p_max, byte* format, ImGuiSliderFlags flags);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igDragFloat(byte* label, float* v, float v_speed, float v_min, float v_max, byte* format, ImGuiSliderFlags flags);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igDragFloat2(byte* label, Vector2* v, float v_speed, float v_min, float v_max, byte* format, ImGuiSliderFlags flags);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igDragFloat3(byte* label, Vector3* v, float v_speed, float v_min, float v_max, byte* format, ImGuiSliderFlags flags);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igDragFloat4(byte* label, Vector4* v, float v_speed, float v_min, float v_max, byte* format, ImGuiSliderFlags flags);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igDragFloatRange2(byte* label, float* v_current_min, float* v_current_max, float v_speed, float v_min, float v_max, byte* format, byte* format_max, ImGuiSliderFlags flags);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igDragInt(byte* label, int* v, float v_speed, int v_min, int v_max, byte* format, ImGuiSliderFlags flags);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igDragInt2(byte* label, int* v, float v_speed, int v_min, int v_max, byte* format, ImGuiSliderFlags flags);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igDragInt3(byte* label, int* v, float v_speed, int v_min, int v_max, byte* format, ImGuiSliderFlags flags);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igDragInt4(byte* label, int* v, float v_speed, int v_min, int v_max, byte* format, ImGuiSliderFlags flags);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igDragIntRange2(byte* label, int* v_current_min, int* v_current_max, float v_speed, int v_min, int v_max, byte* format, byte* format_max, ImGuiSliderFlags flags);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igDragScalar(byte* label, ImGuiDataType data_type, void* p_data, float v_speed, void* p_min, void* p_max, byte* format, ImGuiSliderFlags flags);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igDragScalarN(byte* label, ImGuiDataType data_type, void* p_data, int components, float v_speed, void* p_min, void* p_max, byte* format, ImGuiSliderFlags flags);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igDummy(Vector2 size);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igEnd();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igEndBoxSelect(ImRect scope_rect, ImGuiMultiSelectFlags ms_flags);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igEndChild();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igEndColumns();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igEndCombo();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igEndComboPreview();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igEndDisabled();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igEndDisabledOverrideReenable();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igEndDragDropSource();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igEndDragDropTarget();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igEndErrorTooltip();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igEndFrame();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igEndGroup();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igEndListBox();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igEndMainMenuBar();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igEndMenu();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igEndMenuBar();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiMultiSelectIO* igEndMultiSelect();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igEndPopup();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igEndTabBar();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igEndTabItem();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igEndTable();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igEndTooltip();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igErrorCheckEndFrameFinalizeErrorTooltip();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igErrorCheckUsingSetCursorPosToExtendParentBoundaries();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igErrorLog(byte* msg);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igErrorRecoveryStoreState(ImGuiErrorRecoveryState* state_out);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igErrorRecoveryTryToRecoverState(ImGuiErrorRecoveryState* state_in);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igErrorRecoveryTryToRecoverWindowState(ImGuiErrorRecoveryState* state_in);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igFindBestWindowPosForPopup(Vector2* pOut, ImGuiWindow* window);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiWindow* igFindBlockingModal(ImGuiWindow* window);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiWindow* igFindBottomMostVisibleWindowWithinBeginStack(ImGuiWindow* window);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiViewportP* igFindHoveredViewportFromPlatformWindowStack(Vector2 mouse_platform_pos);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igFindHoveredWindowEx(Vector2 pos, byte find_first_and_in_any_viewport, ImGuiWindow** out_hovered_window, ImGuiWindow** out_hovered_window_under_moving_window);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiOldColumns* igFindOrCreateColumns(ImGuiWindow* window, uint id);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte* igFindRenderedTextEnd(byte* text, byte* text_end);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiSettingsHandler* igFindSettingsHandler(byte* type_name);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiViewport* igFindViewportByID(uint id);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiViewport* igFindViewportByPlatformHandle(void* platform_handle);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiWindow* igFindWindowByID(uint id);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiWindow* igFindWindowByName(byte* name);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern int igFindWindowDisplayIndex(ImGuiWindow* window);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiWindowSettings* igFindWindowSettingsByID(uint id);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiWindowSettings* igFindWindowSettingsByWindow(ImGuiWindow* window);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern int igFixupKeyChord(int key_chord);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igFocusItem();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igFocusTopMostWindowUnderOne(ImGuiWindow* under_this_window, ImGuiWindow* ignore_window, ImGuiViewport* filter_viewport, ImGuiFocusRequestFlags flags);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igFocusWindow(ImGuiWindow* window, ImGuiFocusRequestFlags flags);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igGcAwakeTransientWindowBuffers(ImGuiWindow* window);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igGcCompactTransientMiscBuffers();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igGcCompactTransientWindowBuffers(ImGuiWindow* window);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern uint igGetActiveID();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igGetAllocatorFunctions(IntPtr* p_alloc_func, IntPtr* p_free_func, void** p_user_data);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImDrawList* igGetBackgroundDrawList(ImGuiViewport* viewport);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiBoxSelectState* igGetBoxSelectState(uint id);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte* igGetClipboardText();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern uint igGetColorU32_Col(ImGuiCol idx, float alpha_mul);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern uint igGetColorU32_Vec4(Vector4 col);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern uint igGetColorU32_U32(uint col, float alpha_mul);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern int igGetColumnIndex();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern float igGetColumnNormFromOffset(ImGuiOldColumns* columns, float offset);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern float igGetColumnOffset(int column_index);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern float igGetColumnOffsetFromNorm(ImGuiOldColumns* columns, float offset_norm);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern int igGetColumnsCount();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern uint igGetColumnsID(byte* str_id, int count);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern float igGetColumnWidth(int column_index);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igGetContentRegionAvail(Vector2* pOut);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr igGetCurrentContext();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern uint igGetCurrentFocusScope();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiTabBar* igGetCurrentTabBar();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiTable* igGetCurrentTable();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiWindow* igGetCurrentWindow();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiWindow* igGetCurrentWindowRead();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igGetCursorPos(Vector2* pOut);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern float igGetCursorPosX();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern float igGetCursorPosY();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igGetCursorScreenPos(Vector2* pOut);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igGetCursorStartPos(Vector2* pOut);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImFont* igGetDefaultFont();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiPayload* igGetDragDropPayload();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImDrawData* igGetDrawData();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImDrawListSharedData* igGetDrawListSharedData();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern uint igGetFocusID();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImFont* igGetFont();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImFontBaked* igGetFontBaked();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern float igGetFontRasterizerDensity();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern float igGetFontSize();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igGetFontTexUvWhitePixel(Vector2* pOut);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImDrawList* igGetForegroundDrawList_ViewportPtr(ImGuiViewport* viewport);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImDrawList* igGetForegroundDrawList_WindowPtr(ImGuiWindow* window);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern int igGetFrameCount();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern float igGetFrameHeight();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern float igGetFrameHeightWithSpacing();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern uint igGetHoveredID();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern uint igGetID_Str(byte* str_id);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern uint igGetID_StrStr(byte* str_id_begin, byte* str_id_end);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern uint igGetID_Ptr(void* ptr_id);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern uint igGetID_Int(int int_id);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern uint igGetIDWithSeed_Str(byte* str_id_begin, byte* str_id_end, uint seed);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern uint igGetIDWithSeed_Int(int n, uint seed);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiInputTextState* igGetInputTextState(uint id);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiIO* igGetIO_Nil();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiIO* igGetIO_ContextPtr(IntPtr ctx);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiItemFlags igGetItemFlags();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern uint igGetItemID();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igGetItemRectMax(Vector2* pOut);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igGetItemRectMin(Vector2* pOut);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igGetItemRectSize(Vector2* pOut);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiItemStatusFlags igGetItemStatusFlags();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte* igGetKeyChordName(int key_chord);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiKeyData* igGetKeyData_ContextPtr(IntPtr ctx, ImGuiKey key);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiKeyData* igGetKeyData_Key(ImGuiKey key);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igGetKeyMagnitude2d(Vector2* pOut, ImGuiKey key_left, ImGuiKey key_right, ImGuiKey key_up, ImGuiKey key_down);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte* igGetKeyName(ImGuiKey key);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern uint igGetKeyOwner(ImGuiKey key);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiKeyOwnerData* igGetKeyOwnerData(IntPtr ctx, ImGuiKey key);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern int igGetKeyPressedAmount(ImGuiKey key, float repeat_delay, float rate);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiViewport* igGetMainViewport();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern int igGetMouseClickedCount(ImGuiMouseButton button);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiMouseCursor igGetMouseCursor();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igGetMouseDragDelta(Vector2* pOut, ImGuiMouseButton button, float lock_threshold);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igGetMousePos(Vector2* pOut);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igGetMousePosOnOpeningCurrentPopup(Vector2* pOut);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiMultiSelectState* igGetMultiSelectState(uint id);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern float igGetNavTweakPressedAmount(ImGuiAxis axis);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiPlatformIO* igGetPlatformIO_Nil();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiPlatformIO* igGetPlatformIO_ContextPtr(IntPtr ctx);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igGetPopupAllowedExtentRect(ImRect* pOut, ImGuiWindow* window);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern float igGetRoundedFontSize(float size);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern float igGetScrollMaxX();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern float igGetScrollMaxY();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern float igGetScrollX();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern float igGetScrollY();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiKeyRoutingData* igGetShortcutRoutingData(int key_chord);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiStorage* igGetStateStorage();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiStyle* igGetStyle();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte* igGetStyleColorName(ImGuiCol idx);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern Vector4* igGetStyleColorVec4(ImGuiCol idx);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiStyleVarInfo* igGetStyleVarInfo(ImGuiStyleVar idx);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern float igGetTextLineHeight();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern float igGetTextLineHeightWithSpacing();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern double igGetTime();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiWindow* igGetTopMostAndVisiblePopupModal();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiWindow* igGetTopMostPopupModal();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern float igGetTreeNodeToLabelSpacing();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igGetTypematicRepeatRate(ImGuiInputFlags flags, float* repeat_delay, float* repeat_rate);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiTypingSelectRequest* igGetTypingSelectRequest(ImGuiTypingSelectFlags flags);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte* igGetVersion();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiPlatformMonitor* igGetViewportPlatformMonitor(ImGuiViewport* viewport);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igGetWindowAlwaysWantOwnTabBar(ImGuiWindow* window);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern uint igGetWindowDockID();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiDockNode* igGetWindowDockNode();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern float igGetWindowDpiScale();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImDrawList* igGetWindowDrawList();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern float igGetWindowHeight();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igGetWindowPos(Vector2* pOut);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern uint igGetWindowResizeBorderID(ImGuiWindow* window, ImGuiDir dir);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern uint igGetWindowResizeCornerID(ImGuiWindow* window, int n);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern uint igGetWindowScrollbarID(ImGuiWindow* window, ImGuiAxis axis);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igGetWindowScrollbarRect(ImRect* pOut, ImGuiWindow* window, ImGuiAxis axis);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igGetWindowSize(Vector2* pOut);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiViewport* igGetWindowViewport();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern float igGetWindowWidth();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern int igImAbs_Int(int x);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern float igImAbs_Float(float x);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern double igImAbs_double(double x);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igImage(ImTextureRef tex_ref, Vector2 image_size, Vector2 uv0, Vector2 uv1);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igImageButton(byte* str_id, ImTextureRef tex_ref, Vector2 image_size, Vector2 uv0, Vector2 uv1, Vector4 bg_col, Vector4 tint_col);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igImageButtonEx(uint id, ImTextureRef tex_ref, Vector2 image_size, Vector2 uv0, Vector2 uv1, Vector4 bg_col, Vector4 tint_col, ImGuiButtonFlags flags);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igImageWithBg(ImTextureRef tex_ref, Vector2 image_size, Vector2 uv0, Vector2 uv1, Vector4 bg_col, Vector4 tint_col);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern uint igImAlphaBlendColors(uint col_a, uint col_b);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igImBezierCubicCalc(Vector2* pOut, Vector2 p1, Vector2 p2, Vector2 p3, Vector2 p4, float t);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igImBezierCubicClosestPoint(Vector2* pOut, Vector2 p1, Vector2 p2, Vector2 p3, Vector2 p4, Vector2 p, int num_segments);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igImBezierCubicClosestPointCasteljau(Vector2* pOut, Vector2 p1, Vector2 p2, Vector2 p3, Vector2 p4, Vector2 p, float tess_tol);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igImBezierQuadraticCalc(Vector2* pOut, Vector2 p1, Vector2 p2, Vector2 p3, float t);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igImBitArrayClearAllBits(uint* arr, int bitcount);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igImBitArrayClearBit(uint* arr, int n);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern uint igImBitArrayGetStorageSizeInBytes(int bitcount);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igImBitArraySetBit(uint* arr, int n);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igImBitArraySetBitRange(uint* arr, int n, int n2);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igImBitArrayTestBit(uint* arr, int n);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igImCharIsBlankA(byte c);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igImCharIsBlankW(uint c);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igImCharIsXdigitA(byte c);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igImClamp(Vector2* pOut, Vector2 v, Vector2 mn, Vector2 mx);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern uint igImCountSetBits(uint v);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern float igImDot(Vector2 a, Vector2 b);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern float igImExponentialMovingAverage(float avg, float sample, int n);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igImFileClose(IntPtr file);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ulong igImFileGetSize(IntPtr file);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void* igImFileLoadToMemory(byte* filename, byte* mode, uint* out_file_size, int padding_bytes);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr igImFileOpen(byte* filename, byte* mode);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ulong igImFileRead(void* data, ulong size, ulong count, IntPtr file);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ulong igImFileWrite(void* data, ulong size, ulong count, IntPtr file);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern float igImFloor_Float(float f);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igImFloor_Vec2(Vector2* pOut, Vector2 v);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igImFontAtlasAddDrawListSharedData(ImFontAtlas* atlas, ImDrawListSharedData* data);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImFontBaked* igImFontAtlasBakedAdd(ImFontAtlas* atlas, ImFont* font, float font_size, float font_rasterizer_density, uint baked_id);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImFontGlyph* igImFontAtlasBakedAddFontGlyph(ImFontAtlas* atlas, ImFontBaked* baked, ImFontConfig* src, ImFontGlyph* in_glyph);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igImFontAtlasBakedAddFontGlyphAdvancedX(ImFontAtlas* atlas, ImFontBaked* baked, ImFontConfig* src, ushort codepoint, float advance_x);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igImFontAtlasBakedDiscard(ImFontAtlas* atlas, ImFont* font, ImFontBaked* baked);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igImFontAtlasBakedDiscardFontGlyph(ImFontAtlas* atlas, ImFont* font, ImFontBaked* baked, ImFontGlyph* glyph);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImFontBaked* igImFontAtlasBakedGetClosestMatch(ImFontAtlas* atlas, ImFont* font, float font_size, float font_rasterizer_density);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern uint igImFontAtlasBakedGetId(uint font_id, float baked_size, float rasterizer_density);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImFontBaked* igImFontAtlasBakedGetOrAdd(ImFontAtlas* atlas, ImFont* font, float font_size, float font_rasterizer_density);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igImFontAtlasBakedSetFontGlyphBitmap(ImFontAtlas* atlas, ImFontBaked* baked, ImFontConfig* src, ImFontGlyph* glyph, ImTextureRect* r, byte* src_pixels, ImTextureFormat src_fmt, int src_pitch);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igImFontAtlasBuildClear(ImFontAtlas* atlas);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igImFontAtlasBuildDestroy(ImFontAtlas* atlas);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igImFontAtlasBuildDiscardBakes(ImFontAtlas* atlas, int unused_frames);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igImFontAtlasBuildGetOversampleFactors(ImFontConfig* src, ImFontBaked* baked, int* out_oversample_h, int* out_oversample_v);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igImFontAtlasBuildInit(ImFontAtlas* atlas);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igImFontAtlasBuildLegacyPreloadAllGlyphRanges(ImFontAtlas* atlas);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igImFontAtlasBuildMain(ImFontAtlas* atlas);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igImFontAtlasBuildRenderBitmapFromString(ImFontAtlas* atlas, int x, int y, int w, int h, byte* in_str, byte in_marker_char);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igImFontAtlasBuildSetupFontLoader(ImFontAtlas* atlas, ImFontLoader* font_loader);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igImFontAtlasBuildSetupFontSpecialGlyphs(ImFontAtlas* atlas, ImFont* font, ImFontConfig* src);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igImFontAtlasBuildUpdatePointers(ImFontAtlas* atlas);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igImFontAtlasDebugLogTextureRequests(ImFontAtlas* atlas);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igImFontAtlasFontDestroyOutput(ImFontAtlas* atlas, ImFont* font);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igImFontAtlasFontDestroySourceData(ImFontAtlas* atlas, ImFontConfig* src);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igImFontAtlasFontDiscardBakes(ImFontAtlas* atlas, ImFont* font, int unused_frames);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igImFontAtlasFontInitOutput(ImFontAtlas* atlas, ImFont* font);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igImFontAtlasFontSourceAddToFont(ImFontAtlas* atlas, ImFont* font, ImFontConfig* src);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igImFontAtlasFontSourceInit(ImFontAtlas* atlas, ImFontConfig* src);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImFontLoader* igImFontAtlasGetFontLoaderForStbTruetype();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igImFontAtlasGetMouseCursorTexData(ImFontAtlas* atlas, ImGuiMouseCursor cursor_type, Vector2* out_offset, Vector2* out_size, Vector2* out_uv_border, Vector2* out_uv_fill);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern int igImFontAtlasPackAddRect(ImFontAtlas* atlas, int w, int h, ImFontAtlasRectEntry* overwrite_entry);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igImFontAtlasPackDiscardRect(ImFontAtlas* atlas, int id);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImTextureRect* igImFontAtlasPackGetRect(ImFontAtlas* atlas, int id);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImTextureRect* igImFontAtlasPackGetRectSafe(ImFontAtlas* atlas, int id);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igImFontAtlasPackInit(ImFontAtlas* atlas);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern uint igImFontAtlasRectId_GetGeneration(int id);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern int igImFontAtlasRectId_GetIndex(int id);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern int igImFontAtlasRectId_Make(int index_idx, int gen_idx);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igImFontAtlasRemoveDrawListSharedData(ImFontAtlas* atlas, ImDrawListSharedData* data);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImTextureData* igImFontAtlasTextureAdd(ImFontAtlas* atlas, int w, int h);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igImFontAtlasTextureBlockConvert(byte* src_pixels, ImTextureFormat src_fmt, int src_pitch, byte* dst_pixels, ImTextureFormat dst_fmt, int dst_pitch, int w, int h);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igImFontAtlasTextureBlockCopy(ImTextureData* src_tex, int src_x, int src_y, ImTextureData* dst_tex, int dst_x, int dst_y, int w, int h);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igImFontAtlasTextureBlockFill(ImTextureData* dst_tex, int dst_x, int dst_y, int w, int h, uint col);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igImFontAtlasTextureBlockPostProcess(ImFontAtlasPostProcessData* data);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igImFontAtlasTextureBlockPostProcessMultiply(ImFontAtlasPostProcessData* data, float multiply_factor);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igImFontAtlasTextureBlockQueueUpload(ImFontAtlas* atlas, ImTextureData* tex, int x, int y, int w, int h);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igImFontAtlasTextureCompact(ImFontAtlas* atlas);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igImFontAtlasTextureGetSizeEstimate(ImVec2i* pOut, ImFontAtlas* atlas);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igImFontAtlasTextureGrow(ImFontAtlas* atlas, int old_w, int old_h);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igImFontAtlasTextureMakeSpace(ImFontAtlas* atlas);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igImFontAtlasTextureRepack(ImFontAtlas* atlas, int w, int h);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igImFontAtlasUpdateDrawListsSharedData(ImFontAtlas* atlas);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igImFontAtlasUpdateDrawListsTextures(ImFontAtlas* atlas, ImTextureRef old_tex, ImTextureRef new_tex);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igImFontAtlasUpdateNewFrame(ImFontAtlas* atlas, int frame_count, byte renderer_has_textures);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igImFontCalcTextSizeEx(Vector2* pOut, ImFont* font, float size, float max_width, float wrap_width, byte* text_begin, byte* text_end_display, byte* text_end, byte** out_remaining, Vector2* out_offset, ImDrawTextFlags flags);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte* igImFontCalcWordWrapPositionEx(ImFont* font, float size, byte* text, byte* text_end, float wrap_width, ImDrawTextFlags flags);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern int igImFormatString(byte* buf, uint buf_size, byte* fmt);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igImFormatStringToTempBuffer(byte** out_buf, byte** out_buf_end, byte* fmt);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern uint igImHashData(void* data, uint data_size, uint seed);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte* igImHashSkipUncontributingPrefix(byte* label);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern uint igImHashStr(byte* data, uint data_size, uint seed);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern float igImInvLength(Vector2 lhs, float fail_value);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igImIsFloatAboveGuaranteedIntegerPrecision(float f);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igImIsPowerOfTwo_Int(int v);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igImIsPowerOfTwo_U64(ulong v);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern float igImLengthSqr_Vec2(Vector2 lhs);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern float igImLengthSqr_Vec4(Vector4 lhs);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igImLerp_Vec2Float(Vector2* pOut, Vector2 a, Vector2 b, float t);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igImLerp_Vec2Vec2(Vector2* pOut, Vector2 a, Vector2 b, Vector2 t);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igImLerp_Vec4(Vector4* pOut, Vector4 a, Vector4 b, float t);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern float igImLinearRemapClamp(float s0, float s1, float d0, float d1, float x);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern float igImLinearSweep(float current, float target, float speed);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igImLineClosestPoint(Vector2* pOut, Vector2 a, Vector2 b, Vector2 p);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern float igImLog_Float(float x);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern double igImLog_double(double x);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiStoragePair* igImLowerBound(ImGuiStoragePair* in_begin, ImGuiStoragePair* in_end, uint key);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igImMax(Vector2* pOut, Vector2 lhs, Vector2 rhs);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void* igImMemdup(void* src, uint size);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igImMin(Vector2* pOut, Vector2 lhs, Vector2 rhs);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern int igImModPositive(int a, int b);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igImMul(Vector2* pOut, Vector2 lhs, Vector2 rhs);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte* igImParseFormatFindEnd(byte* format);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte* igImParseFormatFindStart(byte* format);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern int igImParseFormatPrecision(byte* format, int default_value);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igImParseFormatSanitizeForPrinting(byte* fmt_in, byte* fmt_out, uint fmt_out_size);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte* igImParseFormatSanitizeForScanning(byte* fmt_in, byte* fmt_out, uint fmt_out_size);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte* igImParseFormatTrimDecorations(byte* format, byte* buf, uint buf_size);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern float igImPow_Float(float x, float y);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern double igImPow_double(double x, double y);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igImRotate(Vector2* pOut, Vector2 v, float cos_a, float sin_a);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern float igImRound64(float f);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern float igImRsqrt_Float(float x);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern double igImRsqrt_double(double x);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern float igImSaturate(float f);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern float igImSign_Float(float x);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern double igImSign_double(double x);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte* igImStrbol(byte* buf_mid_line, byte* buf_begin);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte* igImStrchrRange(byte* str_begin, byte* str_end, byte c);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte* igImStrdup(byte* str);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte* igImStrdupcpy(byte* dst, uint* p_dst_size, byte* str);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte* igImStreolRange(byte* str, byte* str_end);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern int igImStricmp(byte* str1, byte* str2);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte* igImStristr(byte* haystack, byte* haystack_end, byte* needle, byte* needle_end);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern int igImStrlenW(ushort* str);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igImStrncpy(byte* dst, byte* src, uint count);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern int igImStrnicmp(byte* str1, byte* str2, uint count);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte* igImStrSkipBlank(byte* str);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igImStrTrimBlanks(byte* str);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte* igImTextCalcWordWrapNextLineStart(byte* text, byte* text_end, ImDrawTextFlags flags);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern int igImTextCharFromUtf8(uint* out_char, byte* in_text, byte* in_text_end);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern int igImTextCountCharsFromUtf8(byte* in_text, byte* in_text_end);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern int igImTextCountLines(byte* in_text, byte* in_text_end);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern int igImTextCountUtf8BytesFromChar(byte* in_text, byte* in_text_end);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern int igImTextCountUtf8BytesFromStr(ushort* in_text, ushort* in_text_end);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte* igImTextFindPreviousUtf8Codepoint(byte* in_text_start, byte* in_text_curr);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern int igImTextStrFromUtf8(ushort* out_buf, int out_buf_size, byte* in_text, byte* in_text_end, byte** in_remaining);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern int igImTextStrToUtf8(byte* out_buf, int out_buf_size, ushort* in_text, ushort* in_text_end);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern int igImTextureDataGetFormatBytesPerPixel(ImTextureFormat format);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte* igImTextureDataGetFormatName(ImTextureFormat format);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte* igImTextureDataGetStatusName(ImTextureStatus status);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igImToUpper(byte c);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern float igImTriangleArea(Vector2 a, Vector2 b, Vector2 c);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igImTriangleBarycentricCoords(Vector2 a, Vector2 b, Vector2 c, Vector2 p, float* out_u, float* out_v, float* out_w);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igImTriangleClosestPoint(Vector2* pOut, Vector2 a, Vector2 b, Vector2 c, Vector2 p);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igImTriangleContainsPoint(Vector2 a, Vector2 b, Vector2 c, Vector2 p);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igImTriangleIsClockwise(Vector2 a, Vector2 b, Vector2 c);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern float igImTrunc_Float(float f);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igImTrunc_Vec2(Vector2* pOut, Vector2 v);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern float igImTrunc64(float f);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern int igImUpperPowerOfTwo(int v);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igIndent(float indent_w);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igInitialize();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igInputDouble(byte* label, double* v, double step, double step_fast, byte* format, ImGuiInputTextFlags flags);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igInputFloat(byte* label, float* v, float step, float step_fast, byte* format, ImGuiInputTextFlags flags);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igInputFloat2(byte* label, Vector2* v, byte* format, ImGuiInputTextFlags flags);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igInputFloat3(byte* label, Vector3* v, byte* format, ImGuiInputTextFlags flags);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igInputFloat4(byte* label, Vector4* v, byte* format, ImGuiInputTextFlags flags);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igInputInt(byte* label, int* v, int step, int step_fast, ImGuiInputTextFlags flags);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igInputInt2(byte* label, int* v, ImGuiInputTextFlags flags);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igInputInt3(byte* label, int* v, ImGuiInputTextFlags flags);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igInputInt4(byte* label, int* v, ImGuiInputTextFlags flags);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igInputScalar(byte* label, ImGuiDataType data_type, void* p_data, void* p_step, void* p_step_fast, byte* format, ImGuiInputTextFlags flags);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igInputScalarN(byte* label, ImGuiDataType data_type, void* p_data, int components, void* p_step, void* p_step_fast, byte* format, ImGuiInputTextFlags flags);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igInputText(byte* label, byte* buf, uint buf_size, ImGuiInputTextFlags flags, ImGuiInputTextCallback callback, void* user_data);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igInputTextDeactivateHook(uint id);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igInputTextEx(byte* label, byte* hint, byte* buf, int buf_size, Vector2 size_arg, ImGuiInputTextFlags flags, ImGuiInputTextCallback callback, void* user_data);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igInputTextMultiline(byte* label, byte* buf, uint buf_size, Vector2 size, ImGuiInputTextFlags flags, ImGuiInputTextCallback callback, void* user_data);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igInputTextWithHint(byte* label, byte* hint, byte* buf, uint buf_size, ImGuiInputTextFlags flags, ImGuiInputTextCallback callback, void* user_data);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igInvisibleButton(byte* str_id, Vector2 size, ImGuiButtonFlags flags);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igIsActiveIdUsingNavDir(ImGuiDir dir);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igIsAliasKey(ImGuiKey key);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igIsAnyItemActive();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igIsAnyItemFocused();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igIsAnyItemHovered();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igIsAnyMouseDown();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igIsClippedEx(ImRect bb, uint id);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igIsDragDropActive();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igIsDragDropPayloadBeingAccepted();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igIsGamepadKey(ImGuiKey key);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igIsItemActivated();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igIsItemActive();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igIsItemActiveAsInputText();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igIsItemClicked(ImGuiMouseButton mouse_button);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igIsItemDeactivated();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igIsItemDeactivatedAfterEdit();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igIsItemEdited();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igIsItemFocused();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igIsItemHovered(ImGuiHoveredFlags flags);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igIsItemToggledOpen();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igIsItemToggledSelection();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igIsItemVisible();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igIsKeyboardKey(ImGuiKey key);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igIsKeyChordPressed_Nil(int key_chord);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igIsKeyChordPressed_InputFlags(int key_chord, ImGuiInputFlags flags, uint owner_id);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igIsKeyDown_Nil(ImGuiKey key);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igIsKeyDown_ID(ImGuiKey key, uint owner_id);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igIsKeyPressed_Bool(ImGuiKey key, byte repeat);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igIsKeyPressed_InputFlags(ImGuiKey key, ImGuiInputFlags flags, uint owner_id);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igIsKeyReleased_Nil(ImGuiKey key);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igIsKeyReleased_ID(ImGuiKey key, uint owner_id);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igIsLegacyKey(ImGuiKey key);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igIsLRModKey(ImGuiKey key);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igIsMouseClicked_Bool(ImGuiMouseButton button, byte repeat);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igIsMouseClicked_InputFlags(ImGuiMouseButton button, ImGuiInputFlags flags, uint owner_id);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igIsMouseDoubleClicked_Nil(ImGuiMouseButton button);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igIsMouseDoubleClicked_ID(ImGuiMouseButton button, uint owner_id);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igIsMouseDown_Nil(ImGuiMouseButton button);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igIsMouseDown_ID(ImGuiMouseButton button, uint owner_id);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igIsMouseDragging(ImGuiMouseButton button, float lock_threshold);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igIsMouseDragPastThreshold(ImGuiMouseButton button, float lock_threshold);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igIsMouseHoveringRect(Vector2 r_min, Vector2 r_max, byte clip);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igIsMouseKey(ImGuiKey key);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igIsMousePosValid(Vector2* mouse_pos);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igIsMouseReleased_Nil(ImGuiMouseButton button);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igIsMouseReleased_ID(ImGuiMouseButton button, uint owner_id);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igIsMouseReleasedWithDelay(ImGuiMouseButton button, float delay);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igIsNamedKey(ImGuiKey key);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igIsNamedKeyOrMod(ImGuiKey key);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igIsPopupOpen_Str(byte* str_id, ImGuiPopupFlags flags);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igIsPopupOpen_ID(uint id, ImGuiPopupFlags popup_flags);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igIsRectVisible_Nil(Vector2 size);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igIsRectVisible_Vec2(Vector2 rect_min, Vector2 rect_max);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igIsWindowAbove(ImGuiWindow* potential_above, ImGuiWindow* potential_below);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igIsWindowAppearing();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igIsWindowChildOf(ImGuiWindow* window, ImGuiWindow* potential_parent, byte popup_hierarchy, byte dock_hierarchy);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igIsWindowCollapsed();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igIsWindowContentHoverable(ImGuiWindow* window, ImGuiHoveredFlags flags);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igIsWindowDocked();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igIsWindowFocused(ImGuiFocusedFlags flags);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igIsWindowHovered(ImGuiHoveredFlags flags);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igIsWindowNavFocusable(ImGuiWindow* window);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igIsWindowWithinBeginStackOf(ImGuiWindow* window, ImGuiWindow* potential_parent);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igItemAdd(ImRect bb, uint id, ImRect* nav_bb, ImGuiItemFlags extra_flags);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igItemHoverable(ImRect bb, uint id, ImGuiItemFlags item_flags);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igItemSize_Vec2(Vector2 size, float text_baseline_y);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igItemSize_Rect(ImRect bb, float text_baseline_y);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igKeepAliveID(uint id);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igLabelText(byte* label, byte* fmt);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igListBox_Str_arr(byte* label, int* current_item, byte** items, int items_count, int height_in_items);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igLoadIniSettingsFromDisk(byte* ini_filename);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igLoadIniSettingsFromMemory(byte* ini_data, uint ini_size);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte* igLocalizeGetMsg(ImGuiLocKey key);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igLocalizeRegisterEntries(ImGuiLocEntry* entries, int count);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igLogBegin(ImGuiLogFlags flags, int auto_open_depth);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igLogButtons();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igLogFinish();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igLogRenderedText(Vector2* ref_pos, byte* text, byte* text_end);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igLogSetNextTextDecoration(byte* prefix, byte* suffix);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igLogText(byte* fmt);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igLogToBuffer(int auto_open_depth);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igLogToClipboard(int auto_open_depth);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igLogToFile(int auto_open_depth, byte* filename);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igLogToTTY(int auto_open_depth);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igMarkIniSettingsDirty_Nil();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igMarkIniSettingsDirty_WindowPtr(ImGuiWindow* window);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igMarkItemEdited(uint id);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void* igMemAlloc(uint size);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igMemFree(void* ptr);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igMenuItem_Bool(byte* label, byte* shortcut, byte selected, byte enabled);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igMenuItem_BoolPtr(byte* label, byte* shortcut, byte* p_selected, byte enabled);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igMenuItemEx(byte* label, byte* icon, byte* shortcut, byte selected, byte enabled);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiKey igMouseButtonToKey(ImGuiMouseButton button);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igMultiSelectAddSetAll(ImGuiMultiSelectTempData* ms, byte selected);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igMultiSelectAddSetRange(ImGuiMultiSelectTempData* ms, byte selected, int range_dir, long first_item, long last_item);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igMultiSelectItemFooter(uint id, byte* p_selected, byte* p_pressed);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igMultiSelectItemHeader(uint id, byte* p_selected, ImGuiButtonFlags* p_button_flags);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igNavClearPreferredPosForAxis(ImGuiAxis axis);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igNavHighlightActivated(uint id);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igNavInitRequestApplyResult();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igNavInitWindow(ImGuiWindow* window, byte force_reinit);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igNavMoveRequestApplyResult();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igNavMoveRequestButNoResultYet();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igNavMoveRequestCancel();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igNavMoveRequestForward(ImGuiDir move_dir, ImGuiDir clip_dir, ImGuiNavMoveFlags move_flags, ImGuiScrollFlags scroll_flags);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igNavMoveRequestResolveWithPastTreeNode(ImGuiNavItemData* result, ImGuiTreeNodeStackData* tree_node_data);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igNavMoveRequestSubmit(ImGuiDir move_dir, ImGuiDir clip_dir, ImGuiNavMoveFlags move_flags, ImGuiScrollFlags scroll_flags);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igNavMoveRequestTryWrapping(ImGuiWindow* window, ImGuiNavMoveFlags move_flags);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igNavUpdateCurrentWindowIsScrollPushableX();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igNewFrame();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igNewLine();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igNextColumn();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igOpenPopup_Str(byte* str_id, ImGuiPopupFlags popup_flags);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igOpenPopup_ID(uint id, ImGuiPopupFlags popup_flags);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igOpenPopupEx(uint id, ImGuiPopupFlags popup_flags);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igOpenPopupOnItemClick(byte* str_id, ImGuiPopupFlags popup_flags);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igPlotHistogram_FloatPtr(byte* label, float* values, int values_count, int values_offset, byte* overlay_text, float scale_min, float scale_max, Vector2 graph_size, int stride);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igPlotLines_FloatPtr(byte* label, float* values, int values_count, int values_offset, byte* overlay_text, float scale_min, float scale_max, Vector2 graph_size, int stride);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igPopClipRect();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igPopColumnsBackground();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igPopFocusScope();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igPopFont();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igPopID();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igPopItemFlag();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igPopItemWidth();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igPopPasswordFont();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igPopStyleColor(int count);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igPopStyleVar(int count);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igPopTextWrapPos();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igProgressBar(float fraction, Vector2 size_arg, byte* overlay);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igPushClipRect(Vector2 clip_rect_min, Vector2 clip_rect_max, byte intersect_with_current_clip_rect);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igPushColumnClipRect(int column_index);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igPushColumnsBackground();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igPushFocusScope(uint id);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igPushFont(ImFont* font, float font_size_base_unscaled);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igPushID_Str(byte* str_id);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igPushID_StrStr(byte* str_id_begin, byte* str_id_end);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igPushID_Ptr(void* ptr_id);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igPushID_Int(int int_id);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igPushItemFlag(ImGuiItemFlags option, byte enabled);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igPushItemWidth(float item_width);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igPushMultiItemsWidths(int components, float width_full);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igPushOverrideID(uint id);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igPushPasswordFont();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igPushStyleColor_U32(ImGuiCol idx, uint col);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igPushStyleColor_Vec4(ImGuiCol idx, Vector4 col);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igPushStyleVar_Float(ImGuiStyleVar idx, float val);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igPushStyleVar_Vec2(ImGuiStyleVar idx, Vector2 val);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igPushStyleVarX(ImGuiStyleVar idx, float val_x);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igPushStyleVarY(ImGuiStyleVar idx, float val_y);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igPushTextWrapPos(float wrap_local_pos_x);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igRadioButton_Bool(byte* label, byte active);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igRadioButton_IntPtr(byte* label, int* v, int v_button);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igRegisterFontAtlas(ImFontAtlas* atlas);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igRegisterUserTexture(ImTextureData* tex);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igRemoveContextHook(IntPtr context, uint hook_to_remove);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igRemoveSettingsHandler(byte* type_name);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igRender();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igRenderArrow(ImDrawList* draw_list, Vector2 pos, uint col, ImGuiDir dir, float scale);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igRenderArrowDockMenu(ImDrawList* draw_list, Vector2 p_min, float sz, uint col);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igRenderArrowPointingAt(ImDrawList* draw_list, Vector2 pos, Vector2 half_sz, ImGuiDir direction, uint col);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igRenderBullet(ImDrawList* draw_list, Vector2 pos, uint col);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igRenderCheckMark(ImDrawList* draw_list, Vector2 pos, uint col, float sz);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igRenderColorRectWithAlphaCheckerboard(ImDrawList* draw_list, Vector2 p_min, Vector2 p_max, uint fill_col, float grid_step, Vector2 grid_off, float rounding, ImDrawFlags flags);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igRenderDragDropTargetRect(ImRect bb, ImRect item_clip_rect);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igRenderFrame(Vector2 p_min, Vector2 p_max, uint fill_col, byte borders, float rounding);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igRenderFrameBorder(Vector2 p_min, Vector2 p_max, float rounding);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igRenderMouseCursor(Vector2 pos, float scale, ImGuiMouseCursor mouse_cursor, uint col_fill, uint col_border, uint col_shadow);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igRenderNavCursor(ImRect bb, uint id, ImGuiNavRenderCursorFlags flags);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igRenderPlatformWindowsDefault(void* platform_render_arg, void* renderer_render_arg);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igRenderRectFilledRangeH(ImDrawList* draw_list, ImRect rect, uint col, float x_start_norm, float x_end_norm, float rounding);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igRenderRectFilledWithHole(ImDrawList* draw_list, ImRect outer, ImRect inner, uint col, float rounding);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igRenderText(Vector2 pos, byte* text, byte* text_end, byte hide_text_after_hash);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igRenderTextClipped(Vector2 pos_min, Vector2 pos_max, byte* text, byte* text_end, Vector2* text_size_if_known, Vector2 align, ImRect* clip_rect);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igRenderTextClippedEx(ImDrawList* draw_list, Vector2 pos_min, Vector2 pos_max, byte* text, byte* text_end, Vector2* text_size_if_known, Vector2 align, ImRect* clip_rect);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igRenderTextEllipsis(ImDrawList* draw_list, Vector2 pos_min, Vector2 pos_max, float ellipsis_max_x, byte* text, byte* text_end, Vector2* text_size_if_known);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igRenderTextWrapped(Vector2 pos, byte* text, byte* text_end, float wrap_width);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igResetMouseDragDelta(ImGuiMouseButton button);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igSameLine(float offset_from_start_x, float spacing);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igSaveIniSettingsToDisk(byte* ini_filename);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte* igSaveIniSettingsToMemory(uint* out_ini_size);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igScaleWindowsInViewport(ImGuiViewportP* viewport, float scale);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igScrollbar(ImGuiAxis axis);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igScrollbarEx(ImRect bb, uint id, ImGuiAxis axis, long* p_scroll_v, long avail_v, long contents_v, ImDrawFlags draw_rounding_flags);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igScrollToBringRectIntoView(ImGuiWindow* window, ImRect rect);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igScrollToItem(ImGuiScrollFlags flags);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igScrollToRect(ImGuiWindow* window, ImRect rect, ImGuiScrollFlags flags);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igScrollToRectEx(Vector2* pOut, ImGuiWindow* window, ImRect rect, ImGuiScrollFlags flags);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igSelectable_Bool(byte* label, byte selected, ImGuiSelectableFlags flags, Vector2 size);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igSelectable_BoolPtr(byte* label, byte* p_selected, ImGuiSelectableFlags flags, Vector2 size);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igSeparator();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igSeparatorEx(ImGuiSeparatorFlags flags, float thickness);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igSeparatorText(byte* label);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igSeparatorTextEx(uint id, byte* label, byte* label_end, float extra_width);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igSetActiveID(uint id, ImGuiWindow* window);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igSetActiveIdUsingAllKeyboardKeys();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igSetAllocatorFunctions(IntPtr alloc_func, IntPtr free_func, void* user_data);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igSetClipboardText(byte* text);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igSetColorEditOptions(ImGuiColorEditFlags flags);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igSetColumnOffset(int column_index, float offset_x);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igSetColumnWidth(int column_index, float width);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igSetCurrentContext(IntPtr ctx);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igSetCurrentFont(ImFont* font, float font_size_before_scaling, float font_size_after_scaling);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igSetCurrentViewport(ImGuiWindow* window, ImGuiViewportP* viewport);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igSetCursorPos(Vector2 local_pos);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igSetCursorPosX(float local_x);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igSetCursorPosY(float local_y);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igSetCursorScreenPos(Vector2 pos);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igSetDragDropPayload(byte* type, void* data, uint sz, ImGuiCond cond);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igSetFocusID(uint id, ImGuiWindow* window);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igSetFontRasterizerDensity(float rasterizer_density);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igSetHoveredID(uint id);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igSetItemDefaultFocus();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igSetItemKeyOwner_Nil(ImGuiKey key);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igSetItemKeyOwner_InputFlags(ImGuiKey key, ImGuiInputFlags flags);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igSetItemTooltip(byte* fmt);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igSetKeyboardFocusHere(int offset);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igSetKeyOwner(ImGuiKey key, uint owner_id, ImGuiInputFlags flags);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igSetKeyOwnersForKeyChord(int key, uint owner_id, ImGuiInputFlags flags);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igSetLastItemData(uint item_id, ImGuiItemFlags item_flags, ImGuiItemStatusFlags status_flags, ImRect item_rect);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igSetMouseCursor(ImGuiMouseCursor cursor_type);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igSetNavCursorVisible(byte visible);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igSetNavCursorVisibleAfterMove();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igSetNavFocusScope(uint focus_scope_id);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igSetNavID(uint id, ImGuiNavLayer nav_layer, uint focus_scope_id, ImRect rect_rel);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igSetNavWindow(ImGuiWindow* window);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igSetNextFrameWantCaptureKeyboard(byte want_capture_keyboard);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igSetNextFrameWantCaptureMouse(byte want_capture_mouse);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igSetNextItemAllowOverlap();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igSetNextItemOpen(byte is_open, ImGuiCond cond);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igSetNextItemRefVal(ImGuiDataType data_type, void* p_data);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igSetNextItemSelectionUserData(long selection_user_data);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igSetNextItemShortcut(int key_chord, ImGuiInputFlags flags);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igSetNextItemStorageID(uint storage_id);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igSetNextItemWidth(float item_width);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igSetNextWindowBgAlpha(float alpha);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igSetNextWindowClass(ImGuiWindowClass* window_class);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igSetNextWindowCollapsed(byte collapsed, ImGuiCond cond);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igSetNextWindowContentSize(Vector2 size);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igSetNextWindowDockID(uint dock_id, ImGuiCond cond);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igSetNextWindowFocus();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igSetNextWindowPos(Vector2 pos, ImGuiCond cond, Vector2 pivot);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igSetNextWindowRefreshPolicy(ImGuiWindowRefreshFlags flags);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igSetNextWindowScroll(Vector2 scroll);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igSetNextWindowSize(Vector2 size, ImGuiCond cond);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igSetNextWindowSizeConstraints(Vector2 size_min, Vector2 size_max, IntPtr custom_callback, void* custom_callback_data);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igSetNextWindowViewport(uint viewport_id);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igSetScrollFromPosX_Float(float local_x, float center_x_ratio);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igSetScrollFromPosX_WindowPtr(ImGuiWindow* window, float local_x, float center_x_ratio);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igSetScrollFromPosY_Float(float local_y, float center_y_ratio);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igSetScrollFromPosY_WindowPtr(ImGuiWindow* window, float local_y, float center_y_ratio);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igSetScrollHereX(float center_x_ratio);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igSetScrollHereY(float center_y_ratio);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igSetScrollX_Float(float scroll_x);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igSetScrollX_WindowPtr(ImGuiWindow* window, float scroll_x);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igSetScrollY_Float(float scroll_y);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igSetScrollY_WindowPtr(ImGuiWindow* window, float scroll_y);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igSetShortcutRouting(int key_chord, ImGuiInputFlags flags, uint owner_id);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igSetStateStorage(ImGuiStorage* storage);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igSetTabItemClosed(byte* tab_or_docked_window_label);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igSetTooltip(byte* fmt);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igSetWindowClipRectBeforeSetChannel(ImGuiWindow* window, ImRect clip_rect);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igSetWindowCollapsed_Bool(byte collapsed, ImGuiCond cond);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igSetWindowCollapsed_Str(byte* name, byte collapsed, ImGuiCond cond);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igSetWindowCollapsed_WindowPtr(ImGuiWindow* window, byte collapsed, ImGuiCond cond);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igSetWindowDock(ImGuiWindow* window, uint dock_id, ImGuiCond cond);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igSetWindowFocus_Nil();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igSetWindowFocus_Str(byte* name);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igSetWindowHiddenAndSkipItemsForCurrentFrame(ImGuiWindow* window);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igSetWindowHitTestHole(ImGuiWindow* window, Vector2 pos, Vector2 size);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igSetWindowParentWindowForFocusRoute(ImGuiWindow* window, ImGuiWindow* parent_window);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igSetWindowPos_Vec2(Vector2 pos, ImGuiCond cond);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igSetWindowPos_Str(byte* name, Vector2 pos, ImGuiCond cond);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igSetWindowPos_WindowPtr(ImGuiWindow* window, Vector2 pos, ImGuiCond cond);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igSetWindowSize_Vec2(Vector2 size, ImGuiCond cond);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igSetWindowSize_Str(byte* name, Vector2 size, ImGuiCond cond);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igSetWindowSize_WindowPtr(ImGuiWindow* window, Vector2 size, ImGuiCond cond);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igSetWindowViewport(ImGuiWindow* window, ImGuiViewportP* viewport);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igShadeVertsLinearColorGradientKeepAlpha(ImDrawList* draw_list, int vert_start_idx, int vert_end_idx, Vector2 gradient_p0, Vector2 gradient_p1, uint col0, uint col1);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igShadeVertsLinearUV(ImDrawList* draw_list, int vert_start_idx, int vert_end_idx, Vector2 a, Vector2 b, Vector2 uv_a, Vector2 uv_b, byte clamp);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igShadeVertsTransformPos(ImDrawList* draw_list, int vert_start_idx, int vert_end_idx, Vector2 pivot_in, float cos_a, float sin_a, Vector2 pivot_out);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igShortcut_Nil(int key_chord, ImGuiInputFlags flags);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igShortcut_ID(int key_chord, ImGuiInputFlags flags, uint owner_id);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igShowAboutWindow(byte* p_open);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igShowDebugLogWindow(byte* p_open);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igShowDemoWindow(byte* p_open);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igShowFontAtlas(ImFontAtlas* atlas);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igShowFontSelector(byte* label);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igShowIDStackToolWindow(byte* p_open);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igShowMetricsWindow(byte* p_open);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igShowStyleEditor(ImGuiStyle* @ref);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igShowStyleSelector(byte* label);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igShowUserGuide();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igShrinkWidths(ImGuiShrinkWidthItem* items, int count, float width_excess, float width_min);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igShutdown();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igSliderAngle(byte* label, float* v_rad, float v_degrees_min, float v_degrees_max, byte* format, ImGuiSliderFlags flags);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igSliderBehavior(ImRect bb, uint id, ImGuiDataType data_type, void* p_v, void* p_min, void* p_max, byte* format, ImGuiSliderFlags flags, ImRect* out_grab_bb);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igSliderFloat(byte* label, float* v, float v_min, float v_max, byte* format, ImGuiSliderFlags flags);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igSliderFloat2(byte* label, Vector2* v, float v_min, float v_max, byte* format, ImGuiSliderFlags flags);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igSliderFloat3(byte* label, Vector3* v, float v_min, float v_max, byte* format, ImGuiSliderFlags flags);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igSliderFloat4(byte* label, Vector4* v, float v_min, float v_max, byte* format, ImGuiSliderFlags flags);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igSliderInt(byte* label, int* v, int v_min, int v_max, byte* format, ImGuiSliderFlags flags);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igSliderInt2(byte* label, int* v, int v_min, int v_max, byte* format, ImGuiSliderFlags flags);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igSliderInt3(byte* label, int* v, int v_min, int v_max, byte* format, ImGuiSliderFlags flags);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igSliderInt4(byte* label, int* v, int v_min, int v_max, byte* format, ImGuiSliderFlags flags);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igSliderScalar(byte* label, ImGuiDataType data_type, void* p_data, void* p_min, void* p_max, byte* format, ImGuiSliderFlags flags);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igSliderScalarN(byte* label, ImGuiDataType data_type, void* p_data, int components, void* p_min, void* p_max, byte* format, ImGuiSliderFlags flags);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igSmallButton(byte* label);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igSpacing();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igSplitterBehavior(ImRect bb, uint id, ImGuiAxis axis, float* size1, float* size2, float min_size1, float min_size2, float hover_extend, float hover_visibility_delay, uint bg_col);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igStartMouseMovingWindow(ImGuiWindow* window);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igStartMouseMovingWindowOrNode(ImGuiWindow* window, ImGuiDockNode* node, byte undock);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igStopMouseMovingWindow();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igStyleColorsClassic(ImGuiStyle* dst);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igStyleColorsDark(ImGuiStyle* dst);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igStyleColorsLight(ImGuiStyle* dst);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igTabBarAddTab(ImGuiTabBar* tab_bar, ImGuiTabItemFlags tab_flags, ImGuiWindow* window);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igTabBarCloseTab(ImGuiTabBar* tab_bar, ImGuiTabItem* tab);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiTabBar* igTabBarFindByID(uint id);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiTabItem* igTabBarFindMostRecentlySelectedTabForActiveWindow(ImGuiTabBar* tab_bar);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiTabItem* igTabBarFindTabByID(ImGuiTabBar* tab_bar, uint tab_id);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiTabItem* igTabBarFindTabByOrder(ImGuiTabBar* tab_bar, int order);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiTabItem* igTabBarGetCurrentTab(ImGuiTabBar* tab_bar);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte* igTabBarGetTabName(ImGuiTabBar* tab_bar, ImGuiTabItem* tab);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern int igTabBarGetTabOrder(ImGuiTabBar* tab_bar, ImGuiTabItem* tab);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igTabBarProcessReorder(ImGuiTabBar* tab_bar);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igTabBarQueueFocus_TabItemPtr(ImGuiTabBar* tab_bar, ImGuiTabItem* tab);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igTabBarQueueFocus_Str(ImGuiTabBar* tab_bar, byte* tab_name);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igTabBarQueueReorder(ImGuiTabBar* tab_bar, ImGuiTabItem* tab, int offset);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igTabBarQueueReorderFromMousePos(ImGuiTabBar* tab_bar, ImGuiTabItem* tab, Vector2 mouse_pos);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igTabBarRemove(ImGuiTabBar* tab_bar);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igTabBarRemoveTab(ImGuiTabBar* tab_bar, uint tab_id);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igTabItemBackground(ImDrawList* draw_list, ImRect bb, ImGuiTabItemFlags flags, uint col);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igTabItemButton(byte* label, ImGuiTabItemFlags flags);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igTabItemCalcSize_Str(Vector2* pOut, byte* label, byte has_close_button_or_unsaved_marker);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igTabItemCalcSize_WindowPtr(Vector2* pOut, ImGuiWindow* window);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igTabItemEx(ImGuiTabBar* tab_bar, byte* label, byte* p_open, ImGuiTabItemFlags flags, ImGuiWindow* docked_window);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igTabItemLabelAndCloseButton(ImDrawList* draw_list, ImRect bb, ImGuiTabItemFlags flags, Vector2 frame_padding, byte* label, uint tab_id, uint close_button_id, byte is_contents_visible, byte* out_just_closed, byte* out_text_clipped);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igTabItemSpacing(byte* str_id, ImGuiTabItemFlags flags, float width);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igTableAngledHeadersRow();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igTableAngledHeadersRowEx(uint row_id, float angle, float max_label_width, ImGuiTableHeaderData* data, int data_count);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igTableBeginApplyRequests(ImGuiTable* table);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igTableBeginCell(ImGuiTable* table, int column_n);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igTableBeginContextMenuPopup(ImGuiTable* table);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igTableBeginInitMemory(ImGuiTable* table, int columns_count);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igTableBeginRow(ImGuiTable* table);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern float igTableCalcMaxColumnWidth(ImGuiTable* table, int column_n);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igTableDrawBorders(ImGuiTable* table);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igTableDrawDefaultContextMenu(ImGuiTable* table, ImGuiTableFlags flags_for_section_to_display);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igTableEndCell(ImGuiTable* table);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igTableEndRow(ImGuiTable* table);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiTable* igTableFindByID(uint id);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igTableFixColumnSortDirection(ImGuiTable* table, ImGuiTableColumn* column);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igTableGcCompactSettings();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igTableGcCompactTransientBuffers_TablePtr(ImGuiTable* table);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igTableGcCompactTransientBuffers_TableTempDataPtr(ImGuiTableTempData* table);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiTableSettings* igTableGetBoundSettings(ImGuiTable* table);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igTableGetCellBgRect(ImRect* pOut, ImGuiTable* table, int column_n);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern int igTableGetColumnCount();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiTableColumnFlags igTableGetColumnFlags(int column_n);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern int igTableGetColumnIndex();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte* igTableGetColumnName_Int(int column_n);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte* igTableGetColumnName_TablePtr(ImGuiTable* table, int column_n);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiSortDirection igTableGetColumnNextSortDirection(ImGuiTableColumn* column);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern uint igTableGetColumnResizeID(ImGuiTable* table, int column_n, int instance_no);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern float igTableGetColumnWidthAuto(ImGuiTable* table, ImGuiTableColumn* column);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern float igTableGetHeaderAngledMaxLabelWidth();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern float igTableGetHeaderRowHeight();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern int igTableGetHoveredColumn();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern int igTableGetHoveredRow();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiTableInstanceData* igTableGetInstanceData(ImGuiTable* table, int instance_no);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern uint igTableGetInstanceID(ImGuiTable* table, int instance_no);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern int igTableGetRowIndex();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiTableSortSpecs* igTableGetSortSpecs();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igTableHeader(byte* label);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igTableHeadersRow();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igTableLoadSettings(ImGuiTable* table);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igTableMergeDrawChannels(ImGuiTable* table);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igTableNextColumn();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igTableNextRow(ImGuiTableRowFlags row_flags, float min_row_height);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igTableOpenContextMenu(int column_n);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igTablePopBackgroundChannel();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igTablePopColumnChannel();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igTablePushBackgroundChannel();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igTablePushColumnChannel(int column_n);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igTableRemove(ImGuiTable* table);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igTableResetSettings(ImGuiTable* table);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igTableSaveSettings(ImGuiTable* table);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igTableSetBgColor(ImGuiTableBgTarget target, uint color, int column_n);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igTableSetColumnEnabled(int column_n, byte v);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igTableSetColumnIndex(int column_n);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igTableSetColumnSortDirection(int column_n, ImGuiSortDirection sort_direction, byte append_to_sort_specs);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igTableSetColumnWidth(int column_n, float width);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igTableSetColumnWidthAutoAll(ImGuiTable* table);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igTableSetColumnWidthAutoSingle(ImGuiTable* table, int column_n);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igTableSettingsAddSettingsHandler();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiTableSettings* igTableSettingsCreate(uint id, int columns_count);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiTableSettings* igTableSettingsFindByID(uint id);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igTableSetupColumn(byte* label, ImGuiTableColumnFlags flags, float init_width_or_weight, uint user_id);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igTableSetupDrawChannels(ImGuiTable* table);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igTableSetupScrollFreeze(int cols, int rows);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igTableSortSpecsBuild(ImGuiTable* table);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igTableSortSpecsSanitize(ImGuiTable* table);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igTableUpdateBorders(ImGuiTable* table);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igTableUpdateColumnsWeightFromWidth(ImGuiTable* table);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igTableUpdateLayout(ImGuiTable* table);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igTeleportMousePos(Vector2 pos);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igTempInputIsActive(uint id);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igTempInputScalar(ImRect bb, uint id, byte* label, ImGuiDataType data_type, void* p_data, byte* format, void* p_clamp_min, void* p_clamp_max);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igTempInputText(ImRect bb, uint id, byte* label, byte* buf, int buf_size, ImGuiInputTextFlags flags);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igTestKeyOwner(ImGuiKey key, uint owner_id);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igTestShortcutRouting(int key_chord, uint owner_id);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igText(byte* fmt);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igTextAligned(float align_x, float size_x, byte* fmt);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igTextColored(Vector4 col, byte* fmt);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igTextDisabled(byte* fmt);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igTextEx(byte* text, byte* text_end, ImGuiTextFlags flags);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igTextLink(byte* label);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igTextLinkOpenURL(byte* label, byte* url);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igTextUnformatted(byte* text, byte* text_end);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igTextWrapped(byte* fmt);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igTranslateWindowsInViewport(ImGuiViewportP* viewport, Vector2 old_pos, Vector2 new_pos, Vector2 old_size, Vector2 new_size);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igTreeNode_Str(byte* label);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igTreeNode_StrStr(byte* str_id, byte* fmt);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igTreeNode_Ptr(void* ptr_id, byte* fmt);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igTreeNodeBehavior(uint id, ImGuiTreeNodeFlags flags, byte* label, byte* label_end);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igTreeNodeDrawLineToChildNode(Vector2 target_pos);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igTreeNodeDrawLineToTreePop(ImGuiTreeNodeStackData* data);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igTreeNodeEx_Str(byte* label, ImGuiTreeNodeFlags flags);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igTreeNodeEx_StrStr(byte* str_id, ImGuiTreeNodeFlags flags, byte* fmt);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igTreeNodeEx_Ptr(void* ptr_id, ImGuiTreeNodeFlags flags, byte* fmt);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igTreeNodeGetOpen(uint storage_id);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igTreeNodeSetOpen(uint storage_id, byte open);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igTreeNodeUpdateNextOpen(uint storage_id, ImGuiTreeNodeFlags flags);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igTreePop();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igTreePush_Str(byte* str_id);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igTreePush_Ptr(void* ptr_id);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igTreePushOverrideID(uint id);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igUnindent(float indent_w);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igUnregisterFontAtlas(ImFontAtlas* atlas);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igUnregisterUserTexture(ImTextureData* tex);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igUpdateCurrentFontSize(float restore_font_size_after_scaling);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igUpdateHoveredWindowAndCaptureFlags(Vector2 mouse_pos);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igUpdateInputEvents(byte trickle_fast_inputs);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igUpdateMouseMovingWindowEndFrame();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igUpdateMouseMovingWindowNewFrame();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igUpdatePlatformWindows();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igUpdateWindowParentAndRootLinks(ImGuiWindow* window, ImGuiWindowFlags flags, ImGuiWindow* parent_window);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igUpdateWindowSkipRefresh(ImGuiWindow* window);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igValue_Bool(byte* prefix, byte b);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igValue_Int(byte* prefix, int v);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igValue_Uint(byte* prefix, uint v);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igValue_Float(byte* prefix, float v, byte* float_format);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igVSliderFloat(byte* label, Vector2 size, float* v, float v_min, float v_max, byte* format, ImGuiSliderFlags flags);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igVSliderInt(byte* label, Vector2 size, int* v, int v_min, int v_max, byte* format, ImGuiSliderFlags flags);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igVSliderScalar(byte* label, Vector2 size, ImGuiDataType data_type, void* p_data, void* p_min, void* p_max, byte* format, ImGuiSliderFlags flags);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igWindowPosAbsToRel(Vector2* pOut, ImGuiWindow* window, Vector2 p);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igWindowPosRelToAbs(Vector2* pOut, ImGuiWindow* window, Vector2 p);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igWindowRectAbsToRel(ImRect* pOut, ImGuiWindow* window, ImRect r);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igWindowRectRelToAbs(ImRect* pOut, ImGuiWindow* window, ImRect r);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImBitVector_Clear(ImBitVector* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImBitVector_ClearBit(ImBitVector* self, int n);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImBitVector_Create(ImBitVector* self, int sz);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImBitVector_SetBit(ImBitVector* self, int n);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImBitVector_TestBit(ImBitVector* self, int n);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImColor_destroy(ImColor* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImColor_HSV(ImColor* pOut, float h, float s, float v, float a);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImColor* ImColor_ImColor_Nil();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImColor* ImColor_ImColor_Float(float r, float g, float b, float a);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImColor* ImColor_ImColor_Vec4(Vector4 col);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImColor* ImColor_ImColor_Int(int r, int g, int b, int a);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImColor* ImColor_ImColor_U32(uint rgba);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImColor_SetHSV(ImColor* self, float h, float s, float v, float a);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawCmd_destroy(ImDrawCmd* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr ImDrawCmd_GetTexID(ImDrawCmd* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImDrawCmd* ImDrawCmd_ImDrawCmd();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawData_AddDrawList(ImDrawData* self, ImDrawList* draw_list);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawData_Clear(ImDrawData* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawData_DeIndexAllBuffers(ImDrawData* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawData_destroy(ImDrawData* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImDrawData* ImDrawData_ImDrawData();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawData_ScaleClipRects(ImDrawData* self, Vector2 fb_scale);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawDataBuilder_destroy(ImDrawDataBuilder* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImDrawDataBuilder* ImDrawDataBuilder_ImDrawDataBuilder();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern int ImDrawList__CalcCircleAutoSegmentCount(ImDrawList* self, float radius);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList__ClearFreeMemory(ImDrawList* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList__OnChangedClipRect(ImDrawList* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList__OnChangedTexture(ImDrawList* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList__OnChangedVtxOffset(ImDrawList* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList__PathArcToFastEx(ImDrawList* self, Vector2 center, float radius, int a_min_sample, int a_max_sample, int a_step);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList__PathArcToN(ImDrawList* self, Vector2 center, float radius, float a_min, float a_max, int num_segments);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList__PopUnusedDrawCmd(ImDrawList* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList__ResetForNewFrame(ImDrawList* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList__SetDrawListSharedData(ImDrawList* self, ImDrawListSharedData* data);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList__SetTexture(ImDrawList* self, ImTextureRef tex_ref);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList__TryMergeDrawCmds(ImDrawList* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList_AddBezierCubic(ImDrawList* self, Vector2 p1, Vector2 p2, Vector2 p3, Vector2 p4, uint col, float thickness, int num_segments);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList_AddBezierQuadratic(ImDrawList* self, Vector2 p1, Vector2 p2, Vector2 p3, uint col, float thickness, int num_segments);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList_AddCallback(ImDrawList* self, IntPtr callback, void* userdata, uint userdata_size);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList_AddCircle(ImDrawList* self, Vector2 center, float radius, uint col, int num_segments, float thickness);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList_AddCircleFilled(ImDrawList* self, Vector2 center, float radius, uint col, int num_segments);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList_AddConcavePolyFilled(ImDrawList* self, Vector2* points, int num_points, uint col);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList_AddConvexPolyFilled(ImDrawList* self, Vector2* points, int num_points, uint col);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList_AddDrawCmd(ImDrawList* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList_AddEllipse(ImDrawList* self, Vector2 center, Vector2 radius, uint col, float rot, int num_segments, float thickness);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList_AddEllipseFilled(ImDrawList* self, Vector2 center, Vector2 radius, uint col, float rot, int num_segments);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList_AddImage(ImDrawList* self, ImTextureRef tex_ref, Vector2 p_min, Vector2 p_max, Vector2 uv_min, Vector2 uv_max, uint col);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList_AddImageQuad(ImDrawList* self, ImTextureRef tex_ref, Vector2 p1, Vector2 p2, Vector2 p3, Vector2 p4, Vector2 uv1, Vector2 uv2, Vector2 uv3, Vector2 uv4, uint col);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList_AddImageRounded(ImDrawList* self, ImTextureRef tex_ref, Vector2 p_min, Vector2 p_max, Vector2 uv_min, Vector2 uv_max, uint col, float rounding, ImDrawFlags flags);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList_AddLine(ImDrawList* self, Vector2 p1, Vector2 p2, uint col, float thickness);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList_AddNgon(ImDrawList* self, Vector2 center, float radius, uint col, int num_segments, float thickness);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList_AddNgonFilled(ImDrawList* self, Vector2 center, float radius, uint col, int num_segments);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList_AddPolyline(ImDrawList* self, Vector2* points, int num_points, uint col, ImDrawFlags flags, float thickness);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList_AddQuad(ImDrawList* self, Vector2 p1, Vector2 p2, Vector2 p3, Vector2 p4, uint col, float thickness);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList_AddQuadFilled(ImDrawList* self, Vector2 p1, Vector2 p2, Vector2 p3, Vector2 p4, uint col);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList_AddRect(ImDrawList* self, Vector2 p_min, Vector2 p_max, uint col, float rounding, ImDrawFlags flags, float thickness);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList_AddRectFilled(ImDrawList* self, Vector2 p_min, Vector2 p_max, uint col, float rounding, ImDrawFlags flags);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList_AddRectFilledMultiColor(ImDrawList* self, Vector2 p_min, Vector2 p_max, uint col_upr_left, uint col_upr_right, uint col_bot_right, uint col_bot_left);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList_AddText_Vec2(ImDrawList* self, Vector2 pos, uint col, byte* text_begin, byte* text_end);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList_AddText_FontPtr(ImDrawList* self, ImFont* font, float font_size, Vector2 pos, uint col, byte* text_begin, byte* text_end, float wrap_width, Vector4* cpu_fine_clip_rect);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList_AddTriangle(ImDrawList* self, Vector2 p1, Vector2 p2, Vector2 p3, uint col, float thickness);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList_AddTriangleFilled(ImDrawList* self, Vector2 p1, Vector2 p2, Vector2 p3, uint col);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList_ChannelsMerge(ImDrawList* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList_ChannelsSetCurrent(ImDrawList* self, int n);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList_ChannelsSplit(ImDrawList* self, int count);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImDrawList* ImDrawList_CloneOutput(ImDrawList* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList_destroy(ImDrawList* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList_GetClipRectMax(Vector2* pOut, ImDrawList* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList_GetClipRectMin(Vector2* pOut, ImDrawList* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImDrawList* ImDrawList_ImDrawList(ImDrawListSharedData* shared_data);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList_PathArcTo(ImDrawList* self, Vector2 center, float radius, float a_min, float a_max, int num_segments);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList_PathArcToFast(ImDrawList* self, Vector2 center, float radius, int a_min_of_12, int a_max_of_12);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList_PathBezierCubicCurveTo(ImDrawList* self, Vector2 p2, Vector2 p3, Vector2 p4, int num_segments);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList_PathBezierQuadraticCurveTo(ImDrawList* self, Vector2 p2, Vector2 p3, int num_segments);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList_PathClear(ImDrawList* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList_PathEllipticalArcTo(ImDrawList* self, Vector2 center, Vector2 radius, float rot, float a_min, float a_max, int num_segments);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList_PathFillConcave(ImDrawList* self, uint col);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList_PathFillConvex(ImDrawList* self, uint col);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList_PathLineTo(ImDrawList* self, Vector2 pos);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList_PathLineToMergeDuplicate(ImDrawList* self, Vector2 pos);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList_PathRect(ImDrawList* self, Vector2 rect_min, Vector2 rect_max, float rounding, ImDrawFlags flags);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList_PathStroke(ImDrawList* self, uint col, ImDrawFlags flags, float thickness);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList_PopClipRect(ImDrawList* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList_PopTexture(ImDrawList* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList_PrimQuadUV(ImDrawList* self, Vector2 a, Vector2 b, Vector2 c, Vector2 d, Vector2 uv_a, Vector2 uv_b, Vector2 uv_c, Vector2 uv_d, uint col);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList_PrimRect(ImDrawList* self, Vector2 a, Vector2 b, uint col);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList_PrimRectUV(ImDrawList* self, Vector2 a, Vector2 b, Vector2 uv_a, Vector2 uv_b, uint col);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList_PrimReserve(ImDrawList* self, int idx_count, int vtx_count);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList_PrimUnreserve(ImDrawList* self, int idx_count, int vtx_count);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList_PrimVtx(ImDrawList* self, Vector2 pos, Vector2 uv, uint col);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList_PrimWriteIdx(ImDrawList* self, ushort idx);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList_PrimWriteVtx(ImDrawList* self, Vector2 pos, Vector2 uv, uint col);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList_PushClipRect(ImDrawList* self, Vector2 clip_rect_min, Vector2 clip_rect_max, byte intersect_with_current_clip_rect);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList_PushClipRectFullScreen(ImDrawList* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList_PushTexture(ImDrawList* self, ImTextureRef tex_ref);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawListSharedData_destroy(ImDrawListSharedData* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImDrawListSharedData* ImDrawListSharedData_ImDrawListSharedData();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawListSharedData_SetCircleTessellationMaxError(ImDrawListSharedData* self, float max_error);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawListSplitter_Clear(ImDrawListSplitter* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawListSplitter_ClearFreeMemory(ImDrawListSplitter* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawListSplitter_destroy(ImDrawListSplitter* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImDrawListSplitter* ImDrawListSplitter_ImDrawListSplitter();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawListSplitter_Merge(ImDrawListSplitter* self, ImDrawList* draw_list);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawListSplitter_SetCurrentChannel(ImDrawListSplitter* self, ImDrawList* draw_list, int channel_idx);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawListSplitter_Split(ImDrawListSplitter* self, ImDrawList* draw_list, int count);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImFont_AddRemapChar(ImFont* self, ushort from_codepoint, ushort to_codepoint);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImFont_CalcTextSizeA(Vector2* pOut, ImFont* self, float size, float max_width, float wrap_width, byte* text_begin, byte* text_end, byte** out_remaining);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte* ImFont_CalcWordWrapPosition(ImFont* self, float size, byte* text, byte* text_end, float wrap_width);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImFont_ClearOutputData(ImFont* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImFont_destroy(ImFont* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte* ImFont_GetDebugName(ImFont* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImFontBaked* ImFont_GetFontBaked(ImFont* self, float font_size, float density);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImFont* ImFont_ImFont();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImFont_IsGlyphInFont(ImFont* self, ushort c);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImFont_IsGlyphRangeUnused(ImFont* self, uint c_begin, uint c_last);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImFont_IsLoaded(ImFont* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImFont_RenderChar(ImFont* self, ImDrawList* draw_list, float size, Vector2 pos, uint col, ushort c, Vector4* cpu_fine_clip);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImFont_RenderText(ImFont* self, ImDrawList* draw_list, float size, Vector2 pos, uint col, Vector4 clip_rect, byte* text_begin, byte* text_end, float wrap_width, ImDrawTextFlags flags);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern int ImFontAtlas_AddCustomRect(ImFontAtlas* self, int width, int height, ImFontAtlasRect* out_r);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImFont* ImFontAtlas_AddFont(ImFontAtlas* self, ImFontConfig* font_cfg);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImFont* ImFontAtlas_AddFontDefault(ImFontAtlas* self, ImFontConfig* font_cfg);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImFont* ImFontAtlas_AddFontFromFileTTF(ImFontAtlas* self, byte* filename, float size_pixels, ImFontConfig* font_cfg, ushort* glyph_ranges);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImFont* ImFontAtlas_AddFontFromMemoryCompressedBase85TTF(ImFontAtlas* self, byte* compressed_font_data_base85, float size_pixels, ImFontConfig* font_cfg, ushort* glyph_ranges);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImFont* ImFontAtlas_AddFontFromMemoryCompressedTTF(ImFontAtlas* self, void* compressed_font_data, int compressed_font_data_size, float size_pixels, ImFontConfig* font_cfg, ushort* glyph_ranges);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImFont* ImFontAtlas_AddFontFromMemoryTTF(ImFontAtlas* self, void* font_data, int font_data_size, float size_pixels, ImFontConfig* font_cfg, ushort* glyph_ranges);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImFontAtlas_Clear(ImFontAtlas* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImFontAtlas_ClearFonts(ImFontAtlas* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImFontAtlas_ClearInputData(ImFontAtlas* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImFontAtlas_ClearTexData(ImFontAtlas* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImFontAtlas_CompactCache(ImFontAtlas* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImFontAtlas_destroy(ImFontAtlas* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImFontAtlas_GetCustomRect(ImFontAtlas* self, int id, ImFontAtlasRect* out_r);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ushort* ImFontAtlas_GetGlyphRangesDefault(ImFontAtlas* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImFontAtlas* ImFontAtlas_ImFontAtlas();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImFontAtlas_RemoveCustomRect(ImFontAtlas* self, int id);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImFontAtlas_RemoveFont(ImFontAtlas* self, ImFont* font);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImFontAtlas_SetFontLoader(ImFontAtlas* self, ImFontLoader* font_loader);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImFontAtlasBuilder_destroy(ImFontAtlasBuilder* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImFontAtlasBuilder* ImFontAtlasBuilder_ImFontAtlasBuilder();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImFontAtlasRect_destroy(ImFontAtlasRect* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImFontAtlasRect* ImFontAtlasRect_ImFontAtlasRect();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImFontBaked_ClearOutputData(ImFontBaked* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImFontBaked_destroy(ImFontBaked* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImFontGlyph* ImFontBaked_FindGlyph(ImFontBaked* self, ushort c);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImFontGlyph* ImFontBaked_FindGlyphNoFallback(ImFontBaked* self, ushort c);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern float ImFontBaked_GetCharAdvance(ImFontBaked* self, ushort c);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImFontBaked* ImFontBaked_ImFontBaked();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImFontBaked_IsGlyphLoaded(ImFontBaked* self, ushort c);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImFontConfig_destroy(ImFontConfig* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImFontConfig* ImFontConfig_ImFontConfig();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImFontGlyph_destroy(ImFontGlyph* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImFontGlyph* ImFontGlyph_ImFontGlyph();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImFontGlyphRangesBuilder_AddChar(ImFontGlyphRangesBuilder* self, ushort c);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImFontGlyphRangesBuilder_AddRanges(ImFontGlyphRangesBuilder* self, ushort* ranges);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImFontGlyphRangesBuilder_AddText(ImFontGlyphRangesBuilder* self, byte* text, byte* text_end);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImFontGlyphRangesBuilder_BuildRanges(ImFontGlyphRangesBuilder* self, ImVector* out_ranges);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImFontGlyphRangesBuilder_Clear(ImFontGlyphRangesBuilder* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImFontGlyphRangesBuilder_destroy(ImFontGlyphRangesBuilder* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImFontGlyphRangesBuilder_GetBit(ImFontGlyphRangesBuilder* self, uint n);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImFontGlyphRangesBuilder* ImFontGlyphRangesBuilder_ImFontGlyphRangesBuilder();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImFontGlyphRangesBuilder_SetBit(ImFontGlyphRangesBuilder* self, uint n);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImFontLoader_destroy(ImFontLoader* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImFontLoader* ImFontLoader_ImFontLoader();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiBoxSelectState_destroy(ImGuiBoxSelectState* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiBoxSelectState* ImGuiBoxSelectState_ImGuiBoxSelectState();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiComboPreviewData_destroy(ImGuiComboPreviewData* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiComboPreviewData* ImGuiComboPreviewData_ImGuiComboPreviewData();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiContext_destroy(IntPtr self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr ImGuiContext_ImGuiContext(ImFontAtlas* shared_font_atlas);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiDebugAllocInfo_destroy(ImGuiDebugAllocInfo* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiDebugAllocInfo* ImGuiDebugAllocInfo_ImGuiDebugAllocInfo();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiDockNode_destroy(ImGuiDockNode* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiDockNode* ImGuiDockNode_ImGuiDockNode(uint id);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImGuiDockNode_IsCentralNode(ImGuiDockNode* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImGuiDockNode_IsDockSpace(ImGuiDockNode* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImGuiDockNode_IsEmpty(ImGuiDockNode* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImGuiDockNode_IsFloatingNode(ImGuiDockNode* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImGuiDockNode_IsHiddenTabBar(ImGuiDockNode* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImGuiDockNode_IsLeafNode(ImGuiDockNode* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImGuiDockNode_IsNoTabBar(ImGuiDockNode* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImGuiDockNode_IsRootNode(ImGuiDockNode* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImGuiDockNode_IsSplitNode(ImGuiDockNode* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiDockNode_Rect(ImRect* pOut, ImGuiDockNode* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiDockNode_SetLocalFlags(ImGuiDockNode* self, ImGuiDockNodeFlags flags);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiDockNode_UpdateMergedFlags(ImGuiDockNode* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiErrorRecoveryState_destroy(ImGuiErrorRecoveryState* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiErrorRecoveryState* ImGuiErrorRecoveryState_ImGuiErrorRecoveryState();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImGuiFreeType_DebugEditFontLoaderFlags(ImGuiFreeTypeLoaderFlags* p_font_loader_flags);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImFontLoader* ImGuiFreeType_GetFontLoader();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiIDStackTool_destroy(ImGuiIDStackTool* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiIDStackTool* ImGuiIDStackTool_ImGuiIDStackTool();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiInputTextCallbackData_ClearSelection(ImGuiInputTextCallbackData* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiInputTextCallbackData_DeleteChars(ImGuiInputTextCallbackData* self, int pos, int bytes_count);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiInputTextCallbackData_destroy(ImGuiInputTextCallbackData* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImGuiInputTextCallbackData_HasSelection(ImGuiInputTextCallbackData* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiInputTextCallbackData* ImGuiInputTextCallbackData_ImGuiInputTextCallbackData();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiInputTextCallbackData_InsertChars(ImGuiInputTextCallbackData* self, int pos, byte* text, byte* text_end);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiInputTextCallbackData_SelectAll(ImGuiInputTextCallbackData* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiInputTextDeactivatedState_ClearFreeMemory(ImGuiInputTextDeactivatedState* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiInputTextDeactivatedState_destroy(ImGuiInputTextDeactivatedState* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiInputTextDeactivatedState* ImGuiInputTextDeactivatedState_ImGuiInputTextDeactivatedState();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiInputTextState_ClearFreeMemory(ImGuiInputTextState* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiInputTextState_ClearSelection(ImGuiInputTextState* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiInputTextState_ClearText(ImGuiInputTextState* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiInputTextState_CursorAnimReset(ImGuiInputTextState* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiInputTextState_CursorClamp(ImGuiInputTextState* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiInputTextState_destroy(ImGuiInputTextState* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern int ImGuiInputTextState_GetCursorPos(ImGuiInputTextState* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern float ImGuiInputTextState_GetPreferredOffsetX(ImGuiInputTextState* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern int ImGuiInputTextState_GetSelectionEnd(ImGuiInputTextState* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern int ImGuiInputTextState_GetSelectionStart(ImGuiInputTextState* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImGuiInputTextState_HasSelection(ImGuiInputTextState* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiInputTextState* ImGuiInputTextState_ImGuiInputTextState();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiInputTextState_OnCharPressed(ImGuiInputTextState* self, uint c);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiInputTextState_OnKeyPressed(ImGuiInputTextState* self, int key);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiInputTextState_ReloadUserBufAndKeepSelection(ImGuiInputTextState* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiInputTextState_ReloadUserBufAndMoveToEnd(ImGuiInputTextState* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiInputTextState_ReloadUserBufAndSelectAll(ImGuiInputTextState* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiInputTextState_SelectAll(ImGuiInputTextState* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiIO_AddFocusEvent(ImGuiIO* self, byte focused);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiIO_AddInputCharacter(ImGuiIO* self, uint c);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiIO_AddInputCharactersUTF8(ImGuiIO* self, byte* str);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiIO_AddInputCharacterUTF16(ImGuiIO* self, ushort c);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiIO_AddKeyAnalogEvent(ImGuiIO* self, ImGuiKey key, byte down, float v);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiIO_AddKeyEvent(ImGuiIO* self, ImGuiKey key, byte down);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiIO_AddMouseButtonEvent(ImGuiIO* self, int button, byte down);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiIO_AddMousePosEvent(ImGuiIO* self, float x, float y);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiIO_AddMouseSourceEvent(ImGuiIO* self, ImGuiMouseSource source);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiIO_AddMouseViewportEvent(ImGuiIO* self, uint id);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiIO_AddMouseWheelEvent(ImGuiIO* self, float wheel_x, float wheel_y);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiIO_ClearEventsQueue(ImGuiIO* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiIO_ClearInputKeys(ImGuiIO* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiIO_ClearInputMouse(ImGuiIO* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiIO_destroy(ImGuiIO* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiIO* ImGuiIO_ImGuiIO();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiIO_SetAppAcceptingEvents(ImGuiIO* self, byte accepting_events);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiIO_SetKeyEventNativeData(ImGuiIO* self, ImGuiKey key, int native_keycode, int native_scancode, int native_legacy_index);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiKeyOwnerData_destroy(ImGuiKeyOwnerData* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiKeyOwnerData* ImGuiKeyOwnerData_ImGuiKeyOwnerData();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiKeyRoutingData_destroy(ImGuiKeyRoutingData* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiKeyRoutingData* ImGuiKeyRoutingData_ImGuiKeyRoutingData();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiKeyRoutingTable_Clear(ImGuiKeyRoutingTable* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiKeyRoutingTable_destroy(ImGuiKeyRoutingTable* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiKeyRoutingTable* ImGuiKeyRoutingTable_ImGuiKeyRoutingTable();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiLastItemData_destroy(ImGuiLastItemData* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiLastItemData* ImGuiLastItemData_ImGuiLastItemData();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiListClipper_Begin(ImGuiListClipper* self, int items_count, float items_height);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiListClipper_destroy(ImGuiListClipper* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiListClipper_End(ImGuiListClipper* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiListClipper* ImGuiListClipper_ImGuiListClipper();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiListClipper_IncludeItemByIndex(ImGuiListClipper* self, int item_index);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiListClipper_IncludeItemsByIndex(ImGuiListClipper* self, int item_begin, int item_end);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiListClipper_SeekCursorForItem(ImGuiListClipper* self, int item_index);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImGuiListClipper_Step(ImGuiListClipper* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiListClipperData_destroy(ImGuiListClipperData* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiListClipperData* ImGuiListClipperData_ImGuiListClipperData();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiListClipperData_Reset(ImGuiListClipperData* self, ImGuiListClipper* clipper);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiListClipperRange ImGuiListClipperRange_FromIndices(int min, int max);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiListClipperRange ImGuiListClipperRange_FromPositions(float y1, float y2, int off_min, int off_max);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiMenuColumns_CalcNextTotalWidth(ImGuiMenuColumns* self, byte update_offsets);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern float ImGuiMenuColumns_DeclColumns(ImGuiMenuColumns* self, float w_icon, float w_label, float w_shortcut, float w_mark);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiMenuColumns_destroy(ImGuiMenuColumns* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiMenuColumns* ImGuiMenuColumns_ImGuiMenuColumns();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiMenuColumns_Update(ImGuiMenuColumns* self, float spacing, byte window_reappearing);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiMultiSelectState_destroy(ImGuiMultiSelectState* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiMultiSelectState* ImGuiMultiSelectState_ImGuiMultiSelectState();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiMultiSelectTempData_Clear(ImGuiMultiSelectTempData* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiMultiSelectTempData_ClearIO(ImGuiMultiSelectTempData* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiMultiSelectTempData_destroy(ImGuiMultiSelectTempData* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiMultiSelectTempData* ImGuiMultiSelectTempData_ImGuiMultiSelectTempData();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiNavItemData_Clear(ImGuiNavItemData* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiNavItemData_destroy(ImGuiNavItemData* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiNavItemData* ImGuiNavItemData_ImGuiNavItemData();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiNextItemData_ClearFlags(ImGuiNextItemData* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiNextItemData_destroy(ImGuiNextItemData* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiNextItemData* ImGuiNextItemData_ImGuiNextItemData();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiNextWindowData_ClearFlags(ImGuiNextWindowData* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiNextWindowData_destroy(ImGuiNextWindowData* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiNextWindowData* ImGuiNextWindowData_ImGuiNextWindowData();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiOldColumnData_destroy(ImGuiOldColumnData* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiOldColumnData* ImGuiOldColumnData_ImGuiOldColumnData();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiOldColumns_destroy(ImGuiOldColumns* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiOldColumns* ImGuiOldColumns_ImGuiOldColumns();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiOnceUponAFrame_destroy(ImGuiOnceUponAFrame* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiOnceUponAFrame* ImGuiOnceUponAFrame_ImGuiOnceUponAFrame();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiPayload_Clear(ImGuiPayload* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiPayload_destroy(ImGuiPayload* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiPayload* ImGuiPayload_ImGuiPayload();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImGuiPayload_IsDataType(ImGuiPayload* self, byte* type);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImGuiPayload_IsDelivery(ImGuiPayload* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImGuiPayload_IsPreview(ImGuiPayload* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiPlatformImeData_destroy(ImGuiPlatformImeData* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiPlatformImeData* ImGuiPlatformImeData_ImGuiPlatformImeData();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiPlatformIO_destroy(ImGuiPlatformIO* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiPlatformIO* ImGuiPlatformIO_ImGuiPlatformIO();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiPlatformMonitor_destroy(ImGuiPlatformMonitor* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiPlatformMonitor* ImGuiPlatformMonitor_ImGuiPlatformMonitor();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiPopupData_destroy(ImGuiPopupData* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiPopupData* ImGuiPopupData_ImGuiPopupData();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiPtrOrIndex_destroy(ImGuiPtrOrIndex* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiPtrOrIndex* ImGuiPtrOrIndex_ImGuiPtrOrIndex_Ptr(void* ptr);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiPtrOrIndex* ImGuiPtrOrIndex_ImGuiPtrOrIndex_Int(int index);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiSelectionBasicStorage_ApplyRequests(ImGuiSelectionBasicStorage* self, ImGuiMultiSelectIO* ms_io);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiSelectionBasicStorage_Clear(ImGuiSelectionBasicStorage* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImGuiSelectionBasicStorage_Contains(ImGuiSelectionBasicStorage* self, uint id);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiSelectionBasicStorage_destroy(ImGuiSelectionBasicStorage* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImGuiSelectionBasicStorage_GetNextSelectedItem(ImGuiSelectionBasicStorage* self, void** opaque_it, uint* out_id);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern uint ImGuiSelectionBasicStorage_GetStorageIdFromIndex(ImGuiSelectionBasicStorage* self, int idx);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiSelectionBasicStorage* ImGuiSelectionBasicStorage_ImGuiSelectionBasicStorage();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiSelectionBasicStorage_SetItemSelected(ImGuiSelectionBasicStorage* self, uint id, byte selected);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiSelectionBasicStorage_Swap(ImGuiSelectionBasicStorage* self, ImGuiSelectionBasicStorage* r);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiSelectionExternalStorage_ApplyRequests(ImGuiSelectionExternalStorage* self, ImGuiMultiSelectIO* ms_io);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiSelectionExternalStorage_destroy(ImGuiSelectionExternalStorage* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiSelectionExternalStorage* ImGuiSelectionExternalStorage_ImGuiSelectionExternalStorage();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiSettingsHandler_destroy(ImGuiSettingsHandler* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiSettingsHandler* ImGuiSettingsHandler_ImGuiSettingsHandler();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiStackLevelInfo_destroy(ImGuiStackLevelInfo* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiStackLevelInfo* ImGuiStackLevelInfo_ImGuiStackLevelInfo();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiStorage_BuildSortByKey(ImGuiStorage* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiStorage_Clear(ImGuiStorage* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImGuiStorage_GetBool(ImGuiStorage* self, uint key, byte default_val);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte* ImGuiStorage_GetBoolRef(ImGuiStorage* self, uint key, byte default_val);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern float ImGuiStorage_GetFloat(ImGuiStorage* self, uint key, float default_val);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern float* ImGuiStorage_GetFloatRef(ImGuiStorage* self, uint key, float default_val);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern int ImGuiStorage_GetInt(ImGuiStorage* self, uint key, int default_val);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern int* ImGuiStorage_GetIntRef(ImGuiStorage* self, uint key, int default_val);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void* ImGuiStorage_GetVoidPtr(ImGuiStorage* self, uint key);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void** ImGuiStorage_GetVoidPtrRef(ImGuiStorage* self, uint key, void* default_val);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiStorage_SetAllInt(ImGuiStorage* self, int val);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiStorage_SetBool(ImGuiStorage* self, uint key, byte val);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiStorage_SetFloat(ImGuiStorage* self, uint key, float val);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiStorage_SetInt(ImGuiStorage* self, uint key, int val);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiStorage_SetVoidPtr(ImGuiStorage* self, uint key, void* val);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiStoragePair_destroy(ImGuiStoragePair* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiStoragePair* ImGuiStoragePair_ImGuiStoragePair_Int(uint _key, int _val);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiStoragePair* ImGuiStoragePair_ImGuiStoragePair_Float(uint _key, float _val);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiStoragePair* ImGuiStoragePair_ImGuiStoragePair_Ptr(uint _key, void* _val);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiStyle_destroy(ImGuiStyle* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiStyle* ImGuiStyle_ImGuiStyle();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiStyle_ScaleAllSizes(ImGuiStyle* self, float scale_factor);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiStyleMod_destroy(ImGuiStyleMod* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiStyleMod* ImGuiStyleMod_ImGuiStyleMod_Int(ImGuiStyleVar idx, int v);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiStyleMod* ImGuiStyleMod_ImGuiStyleMod_Float(ImGuiStyleVar idx, float v);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiStyleMod* ImGuiStyleMod_ImGuiStyleMod_Vec2(ImGuiStyleVar idx, Vector2 v);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void* ImGuiStyleVarInfo_GetVarPtr(ImGuiStyleVarInfo* self, void* parent);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiTabBar_destroy(ImGuiTabBar* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiTabBar* ImGuiTabBar_ImGuiTabBar();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiTabItem_destroy(ImGuiTabItem* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiTabItem* ImGuiTabItem_ImGuiTabItem();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiTable_destroy(ImGuiTable* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiTable* ImGuiTable_ImGuiTable();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiTableColumn_destroy(ImGuiTableColumn* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiTableColumn* ImGuiTableColumn_ImGuiTableColumn();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiTableColumnSettings_destroy(ImGuiTableColumnSettings* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiTableColumnSettings* ImGuiTableColumnSettings_ImGuiTableColumnSettings();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiTableColumnSortSpecs_destroy(ImGuiTableColumnSortSpecs* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiTableColumnSortSpecs* ImGuiTableColumnSortSpecs_ImGuiTableColumnSortSpecs();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiTableInstanceData_destroy(ImGuiTableInstanceData* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiTableInstanceData* ImGuiTableInstanceData_ImGuiTableInstanceData();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiTableSettings_destroy(ImGuiTableSettings* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiTableColumnSettings* ImGuiTableSettings_GetColumnSettings(ImGuiTableSettings* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiTableSettings* ImGuiTableSettings_ImGuiTableSettings();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiTableSortSpecs_destroy(ImGuiTableSortSpecs* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiTableSortSpecs* ImGuiTableSortSpecs_ImGuiTableSortSpecs();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiTableTempData_destroy(ImGuiTableTempData* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiTableTempData* ImGuiTableTempData_ImGuiTableTempData();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiTextBuffer_append(ImGuiTextBuffer* self, byte* str, byte* str_end);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiTextBuffer_appendf(ImGuiTextBuffer* self, byte* fmt);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte* ImGuiTextBuffer_begin(ImGuiTextBuffer* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte* ImGuiTextBuffer_c_str(ImGuiTextBuffer* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiTextBuffer_clear(ImGuiTextBuffer* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiTextBuffer_destroy(ImGuiTextBuffer* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImGuiTextBuffer_empty(ImGuiTextBuffer* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte* ImGuiTextBuffer_end(ImGuiTextBuffer* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiTextBuffer* ImGuiTextBuffer_ImGuiTextBuffer();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiTextBuffer_reserve(ImGuiTextBuffer* self, int capacity);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiTextBuffer_resize(ImGuiTextBuffer* self, int size);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern int ImGuiTextBuffer_size(ImGuiTextBuffer* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiTextFilter_Build(ImGuiTextFilter* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiTextFilter_Clear(ImGuiTextFilter* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiTextFilter_destroy(ImGuiTextFilter* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImGuiTextFilter_Draw(ImGuiTextFilter* self, byte* label, float width);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiTextFilter* ImGuiTextFilter_ImGuiTextFilter(byte* default_filter);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImGuiTextFilter_IsActive(ImGuiTextFilter* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImGuiTextFilter_PassFilter(ImGuiTextFilter* self, byte* text, byte* text_end);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiTextIndex_append(ImGuiTextIndex* self, byte* @base, int old_size, int new_size);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiTextIndex_clear(ImGuiTextIndex* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte* ImGuiTextIndex_get_line_begin(ImGuiTextIndex* self, byte* @base, int n);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte* ImGuiTextIndex_get_line_end(ImGuiTextIndex* self, byte* @base, int n);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern int ImGuiTextIndex_size(ImGuiTextIndex* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiTextRange_destroy(ImGuiTextRange* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImGuiTextRange_empty(ImGuiTextRange* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiTextRange* ImGuiTextRange_ImGuiTextRange_Nil();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiTextRange* ImGuiTextRange_ImGuiTextRange_Str(byte* _b, byte* _e);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiTextRange_split(ImGuiTextRange* self, byte separator, ImVector* @out);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiTypingSelectState_Clear(ImGuiTypingSelectState* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiTypingSelectState_destroy(ImGuiTypingSelectState* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiTypingSelectState* ImGuiTypingSelectState_ImGuiTypingSelectState();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiViewport_destroy(ImGuiViewport* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiViewport_GetCenter(Vector2* pOut, ImGuiViewport* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiViewport_GetWorkCenter(Vector2* pOut, ImGuiViewport* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiViewport* ImGuiViewport_ImGuiViewport();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiViewportP_CalcWorkRectPos(Vector2* pOut, ImGuiViewportP* self, Vector2 inset_min);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiViewportP_CalcWorkRectSize(Vector2* pOut, ImGuiViewportP* self, Vector2 inset_min, Vector2 inset_max);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiViewportP_ClearRequestFlags(ImGuiViewportP* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiViewportP_destroy(ImGuiViewportP* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiViewportP_GetBuildWorkRect(ImRect* pOut, ImGuiViewportP* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiViewportP_GetMainRect(ImRect* pOut, ImGuiViewportP* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiViewportP_GetWorkRect(ImRect* pOut, ImGuiViewportP* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiViewportP* ImGuiViewportP_ImGuiViewportP();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiViewportP_UpdateWorkRect(ImGuiViewportP* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiWindow_destroy(ImGuiWindow* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern uint ImGuiWindow_GetID_Str(ImGuiWindow* self, byte* str, byte* str_end);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern uint ImGuiWindow_GetID_Ptr(ImGuiWindow* self, void* ptr);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern uint ImGuiWindow_GetID_Int(ImGuiWindow* self, int n);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern uint ImGuiWindow_GetIDFromPos(ImGuiWindow* self, Vector2 p_abs);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern uint ImGuiWindow_GetIDFromRectangle(ImGuiWindow* self, ImRect r_abs);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiWindow* ImGuiWindow_ImGuiWindow(IntPtr context, byte* name);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiWindow_MenuBarRect(ImRect* pOut, ImGuiWindow* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiWindow_Rect(ImRect* pOut, ImGuiWindow* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiWindow_TitleBarRect(ImRect* pOut, ImGuiWindow* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiWindowClass_destroy(ImGuiWindowClass* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiWindowClass* ImGuiWindowClass_ImGuiWindowClass();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiWindowSettings_destroy(ImGuiWindowSettings* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte* ImGuiWindowSettings_GetName(ImGuiWindowSettings* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiWindowSettings* ImGuiWindowSettings_ImGuiWindowSettings();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImRect_Add_Vec2(ImRect* self, Vector2 p);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImRect_Add_Rect(ImRect* self, ImRect r);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern Vector4* ImRect_AsVec4(ImRect* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImRect_ClipWith(ImRect* self, ImRect r);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImRect_ClipWithFull(ImRect* self, ImRect r);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImRect_Contains_Vec2(ImRect* self, Vector2 p);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImRect_Contains_Rect(ImRect* self, ImRect r);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImRect_ContainsWithPad(ImRect* self, Vector2 p, Vector2 pad);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImRect_destroy(ImRect* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImRect_Expand_Float(ImRect* self, float amount);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImRect_Expand_Vec2(ImRect* self, Vector2 amount);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImRect_Floor(ImRect* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern float ImRect_GetArea(ImRect* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImRect_GetBL(Vector2* pOut, ImRect* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImRect_GetBR(Vector2* pOut, ImRect* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImRect_GetCenter(Vector2* pOut, ImRect* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern float ImRect_GetHeight(ImRect* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImRect_GetSize(Vector2* pOut, ImRect* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImRect_GetTL(Vector2* pOut, ImRect* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImRect_GetTR(Vector2* pOut, ImRect* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern float ImRect_GetWidth(ImRect* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImRect* ImRect_ImRect_Nil();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImRect* ImRect_ImRect_Vec2(Vector2 min, Vector2 max);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImRect* ImRect_ImRect_Vec4(Vector4 v);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImRect* ImRect_ImRect_Float(float x1, float y1, float x2, float y2);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImRect_IsInverted(ImRect* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImRect_Overlaps(ImRect* self, ImRect r);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImRect_ToVec4(Vector4* pOut, ImRect* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImRect_Translate(ImRect* self, Vector2 d);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImRect_TranslateX(ImRect* self, float dx);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImRect_TranslateY(ImRect* self, float dy);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImTextureData_Create(ImTextureData* self, ImTextureFormat format, int w, int h);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImTextureData_destroy(ImTextureData* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImTextureData_DestroyPixels(ImTextureData* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern int ImTextureData_GetPitch(ImTextureData* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void* ImTextureData_GetPixels(ImTextureData* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void* ImTextureData_GetPixelsAt(ImTextureData* self, int x, int y);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern int ImTextureData_GetSizeInBytes(ImTextureData* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr ImTextureData_GetTexID(ImTextureData* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImTextureData_GetTexRef(ImTextureRef* pOut, ImTextureData* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImTextureData* ImTextureData_ImTextureData();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImTextureData_SetStatus(ImTextureData* self, ImTextureStatus status);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImTextureData_SetTexID(ImTextureData* self, IntPtr tex_id);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImTextureRef_destroy(ImTextureRef* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr ImTextureRef_GetTexID(ImTextureRef* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImTextureRef* ImTextureRef_ImTextureRef_Nil();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImTextureRef* ImTextureRef_ImTextureRef_TextureID(IntPtr tex_id);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImVec1_destroy(ImVec1* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImVec1* ImVec1_ImVec1_Nil();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImVec1* ImVec1_ImVec1_Float(float _x);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImVec2_destroy(Vector2* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern Vector2* ImVec2_ImVec2_Nil();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern Vector2* ImVec2_ImVec2_Float(float _x, float _y);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImVec2i_destroy(ImVec2i* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImVec2i* ImVec2i_ImVec2i_Nil();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImVec2i* ImVec2i_ImVec2i_Int(int _x, int _y);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImVec2ih_destroy(ImVec2ih* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImVec2ih* ImVec2ih_ImVec2ih_Nil();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImVec2ih* ImVec2ih_ImVec2ih_short(short _x, short _y);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImVec2ih* ImVec2ih_ImVec2ih_Vec2(Vector2 rhs);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImVec4_destroy(Vector4* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern Vector4* ImVec4_ImVec4_Nil();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern Vector4* ImVec4_ImVec4_Float(float _x, float _y, float _z, float _w);
    }
}
