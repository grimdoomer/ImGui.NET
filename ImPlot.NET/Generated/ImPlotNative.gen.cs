using System;
using SharpDX;
using System.Runtime.InteropServices;
using ImGuiNET;

namespace ImPlotNET
{
    public static unsafe partial class ImPlotNative
    {
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImPlotColormap ImPlot_AddColormap_Vec4Ptr(byte* name, Vector4* cols, int size, byte qual);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImPlotColormap ImPlot_AddColormap_U32Ptr(byte* name, uint* cols, int size, byte qual);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_AddTextCentered(ImDrawList* DrawList, Vector2 top_center, uint col, byte* text_begin, byte* text_end);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_AddTextVertical(ImDrawList* DrawList, Vector2 pos, uint col, byte* text_begin, byte* text_end);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_AddTime(ImPlotTime* pOut, ImPlotTime t, ImPlotTimeUnit unit, int count);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImPlot_AllAxesInputLocked(ImPlotAxis* axes, int count);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_Annotation_Bool(double x, double y, Vector4 col, Vector2 pix_offset, byte clamp, byte round);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_Annotation_Str(double x, double y, Vector4 col, Vector2 pix_offset, byte clamp, byte* fmt);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImPlot_AnyAxesHeld(ImPlotAxis* axes, int count);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImPlot_AnyAxesHovered(ImPlotAxis* axes, int count);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImPlot_AnyAxesInputLocked(ImPlotAxis* axes, int count);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImPlot_BeginAlignedPlots(byte* group_id, byte vertical);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImPlot_BeginDragDropSourceAxis(ImAxis axis, ImGuiDragDropFlags flags);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImPlot_BeginDragDropSourceItem(byte* label_id, ImGuiDragDropFlags flags);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImPlot_BeginDragDropSourcePlot(ImGuiDragDropFlags flags);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImPlot_BeginDragDropTargetAxis(ImAxis axis);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImPlot_BeginDragDropTargetLegend();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImPlot_BeginDragDropTargetPlot();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImPlot_BeginItem(byte* label_id, ImPlotItemFlags flags, ImPlotCol recolor_from);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImPlot_BeginLegendPopup(byte* label_id, ImGuiMouseButton mouse_button);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImPlot_BeginPlot(byte* title_id, Vector2 size, ImPlotFlags flags);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImPlot_BeginSubplots(byte* title_id, int rows, int cols, Vector2 size, ImPlotSubplotFlags flags, float* row_ratios, float* col_ratios);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_BustColorCache(byte* plot_title_id);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_BustItemCache();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_BustPlotCache();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern uint ImPlot_CalcHoverColor(uint col);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_CalcLegendSize(Vector2* pOut, ImPlotItemGroup* items, Vector2 pad, Vector2 spacing, byte vertical);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern uint ImPlot_CalcTextColor_Vec4(Vector4 bg);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern uint ImPlot_CalcTextColor_U32(uint bg);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_CalcTextSizeVertical(Vector2* pOut, byte* text);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_CalculateBins_FloatPtr(float* values, int count, ImPlotBin meth, ImPlotRange range, int* bins_out, double* width_out);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_CalculateBins_doublePtr(double* values, int count, ImPlotBin meth, ImPlotRange range, int* bins_out, double* width_out);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_CalculateBins_S8Ptr(sbyte* values, int count, ImPlotBin meth, ImPlotRange range, int* bins_out, double* width_out);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_CalculateBins_U8Ptr(byte* values, int count, ImPlotBin meth, ImPlotRange range, int* bins_out, double* width_out);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_CalculateBins_S16Ptr(short* values, int count, ImPlotBin meth, ImPlotRange range, int* bins_out, double* width_out);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_CalculateBins_U16Ptr(ushort* values, int count, ImPlotBin meth, ImPlotRange range, int* bins_out, double* width_out);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_CalculateBins_S32Ptr(int* values, int count, ImPlotBin meth, ImPlotRange range, int* bins_out, double* width_out);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_CalculateBins_U32Ptr(uint* values, int count, ImPlotBin meth, ImPlotRange range, int* bins_out, double* width_out);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_CalculateBins_S64Ptr(long* values, int count, ImPlotBin meth, ImPlotRange range, int* bins_out, double* width_out);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_CalculateBins_U64Ptr(ulong* values, int count, ImPlotBin meth, ImPlotRange range, int* bins_out, double* width_out);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_CancelPlotSelection();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_CeilTime(ImPlotTime* pOut, ImPlotTime t, ImPlotTimeUnit unit);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_ClampLabelPos(Vector2* pOut, Vector2 pos, Vector2 size, Vector2 Min, Vector2 Max);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImPlot_ClampLegendRect(ImRect* legend_rect, ImRect outer_rect, Vector2 pad);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImPlot_ColormapButton(byte* label, Vector2 size, ImPlotColormap cmap);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_ColormapIcon(ImPlotColormap cmap);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_ColormapScale(byte* label, double scale_min, double scale_max, Vector2 size, byte* format, ImPlotColormapScaleFlags flags, ImPlotColormap cmap);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImPlot_ColormapSlider(byte* label, float* t, Vector4* @out, byte* format, ImPlotColormap cmap);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_CombineDateTime(ImPlotTime* pOut, ImPlotTime date_part, ImPlotTime time_part);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr ImPlot_CreateContext();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_DestroyContext(IntPtr ctx);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImPlot_DragLineX(int id, double* x, Vector4 col, float thickness, ImPlotDragToolFlags flags, byte* out_clicked, byte* out_hovered, byte* held);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImPlot_DragLineY(int id, double* y, Vector4 col, float thickness, ImPlotDragToolFlags flags, byte* out_clicked, byte* out_hovered, byte* held);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImPlot_DragPoint(int id, double* x, double* y, Vector4 col, float size, ImPlotDragToolFlags flags, byte* out_clicked, byte* out_hovered, byte* held);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImPlot_DragRect(int id, double* x1, double* y1, double* x2, double* y2, Vector4 col, ImPlotDragToolFlags flags, byte* out_clicked, byte* out_hovered, byte* held);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_EndAlignedPlots();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_EndDragDropSource();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_EndDragDropTarget();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_EndItem();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_EndLegendPopup();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_EndPlot();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_EndSubplots();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_FillRange_Vector_Float_Ptr(ImVector* buffer, int n, float vmin, float vmax);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_FillRange_Vector_double_Ptr(ImVector* buffer, int n, double vmin, double vmax);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_FillRange_Vector_S8_Ptr(ImVector* buffer, int n, sbyte vmin, sbyte vmax);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_FillRange_Vector_U8_Ptr(ImVector* buffer, int n, byte vmin, byte vmax);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_FillRange_Vector_S16_Ptr(ImVector* buffer, int n, short vmin, short vmax);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_FillRange_Vector_U16_Ptr(ImVector* buffer, int n, ushort vmin, ushort vmax);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_FillRange_Vector_S32_Ptr(ImVector* buffer, int n, int vmin, int vmax);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_FillRange_Vector_U32_Ptr(ImVector* buffer, int n, uint vmin, uint vmax);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_FillRange_Vector_S64_Ptr(ImVector* buffer, int n, long vmin, long vmax);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_FillRange_Vector_U64_Ptr(ImVector* buffer, int n, ulong vmin, ulong vmax);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_FitPoint(ImPlotPoint p);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_FitPointX(double x);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_FitPointY(double y);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImPlot_FitThisFrame();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_FloorTime(ImPlotTime* pOut, ImPlotTime t, ImPlotTimeUnit unit);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern int ImPlot_FormatDate(ImPlotTime t, byte* buffer, int size, ImPlotDateFmt fmt, byte use_iso_8601);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern int ImPlot_FormatDateTime(ImPlotTime t, byte* buffer, int size, ImPlotDateTimeSpec fmt);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern int ImPlot_Formatter_Default(double value, byte* buff, int size, void* data);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern int ImPlot_Formatter_Logit(double value, byte* buff, int size, void* noname1);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern int ImPlot_Formatter_Time(double noname1, byte* buff, int size, void* data);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern int ImPlot_FormatTime(ImPlotTime t, byte* buffer, int size, ImPlotTimeFmt fmt, byte use_24_hr_clk);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_GetAutoColor(Vector4* pOut, ImPlotCol idx);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_GetColormapColor(Vector4* pOut, int idx, ImPlotColormap cmap);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern uint ImPlot_GetColormapColorU32(int idx, ImPlotColormap cmap);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern int ImPlot_GetColormapCount();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImPlotColormap ImPlot_GetColormapIndex(byte* name);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte* ImPlot_GetColormapName(ImPlotColormap cmap);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern int ImPlot_GetColormapSize(ImPlotColormap cmap);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr ImPlot_GetCurrentContext();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImPlotItem* ImPlot_GetCurrentItem();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImPlotPlot* ImPlot_GetCurrentPlot();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern int ImPlot_GetDaysInMonth(int year, int month);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern Time* ImPlot_GetGmtTime(ImPlotTime t, Time* ptm);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImPlotInputMap* ImPlot_GetInputMap();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImPlotItem* ImPlot_GetItem(byte* label_id);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImPlotNextItemData* ImPlot_GetItemData();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_GetLastItemColor(Vector4* pOut);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_GetLocationPos(Vector2* pOut, ImRect outer_rect, Vector2 inner_size, ImPlotLocation location, Vector2 pad);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern Time* ImPlot_GetLocTime(ImPlotTime t, Time* ptm);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte* ImPlot_GetMarkerName(ImPlotMarker idx);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern int ImPlot_GetMonth(ImPlotTime t);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImPlotPlot* ImPlot_GetPlot(byte* title);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImDrawList* ImPlot_GetPlotDrawList();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_GetPlotLimits(ImPlotRect* pOut, ImAxis x_axis, ImAxis y_axis);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_GetPlotMousePos(ImPlotPoint* pOut, ImAxis x_axis, ImAxis y_axis);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_GetPlotPos(Vector2* pOut);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_GetPlotSelection(ImPlotRect* pOut, ImAxis x_axis, ImAxis y_axis);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_GetPlotSize(Vector2* pOut);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImPlotStyle* ImPlot_GetStyle();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte* ImPlot_GetStyleColorName(ImPlotCol idx);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern uint ImPlot_GetStyleColorU32(ImPlotCol idx);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_GetStyleColorVec4(Vector4* pOut, ImPlotCol idx);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern Time* ImPlot_GetTime(ImPlotTime t, Time* ptm);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern int ImPlot_GetYear(ImPlotTime t);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_HideNextItem(byte hidden, ImPlotCond cond);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImPlot_ImAlmostEqual(double v1, double v2, int ulp);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern uint ImPlot_ImAlphaU32(uint col, float alpha);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern float ImPlot_ImAsinh_Float(float x);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern double ImPlot_ImAsinh_double(double x);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern double ImPlot_ImConstrainInf(double val);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern double ImPlot_ImConstrainLog(double val);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern double ImPlot_ImConstrainNan(double val);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern double ImPlot_ImConstrainTime(double val);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern uint ImPlot_ImLerpU32(uint* colors, int size, float t);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern float ImPlot_ImLog10_Float(float x);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern double ImPlot_ImLog10_double(double x);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern float ImPlot_ImMaxArray_FloatPtr(float* values, int count);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern double ImPlot_ImMaxArray_doublePtr(double* values, int count);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern sbyte ImPlot_ImMaxArray_S8Ptr(sbyte* values, int count);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImPlot_ImMaxArray_U8Ptr(byte* values, int count);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern short ImPlot_ImMaxArray_S16Ptr(short* values, int count);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ushort ImPlot_ImMaxArray_U16Ptr(ushort* values, int count);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern int ImPlot_ImMaxArray_S32Ptr(int* values, int count);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern uint ImPlot_ImMaxArray_U32Ptr(uint* values, int count);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern long ImPlot_ImMaxArray_S64Ptr(long* values, int count);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ulong ImPlot_ImMaxArray_U64Ptr(ulong* values, int count);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern double ImPlot_ImMean_FloatPtr(float* values, int count);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern double ImPlot_ImMean_doublePtr(double* values, int count);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern double ImPlot_ImMean_S8Ptr(sbyte* values, int count);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern double ImPlot_ImMean_U8Ptr(byte* values, int count);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern double ImPlot_ImMean_S16Ptr(short* values, int count);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern double ImPlot_ImMean_U16Ptr(ushort* values, int count);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern double ImPlot_ImMean_S32Ptr(int* values, int count);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern double ImPlot_ImMean_U32Ptr(uint* values, int count);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern double ImPlot_ImMean_S64Ptr(long* values, int count);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern double ImPlot_ImMean_U64Ptr(ulong* values, int count);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern float ImPlot_ImMinArray_FloatPtr(float* values, int count);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern double ImPlot_ImMinArray_doublePtr(double* values, int count);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern sbyte ImPlot_ImMinArray_S8Ptr(sbyte* values, int count);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImPlot_ImMinArray_U8Ptr(byte* values, int count);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern short ImPlot_ImMinArray_S16Ptr(short* values, int count);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ushort ImPlot_ImMinArray_U16Ptr(ushort* values, int count);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern int ImPlot_ImMinArray_S32Ptr(int* values, int count);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern uint ImPlot_ImMinArray_U32Ptr(uint* values, int count);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern long ImPlot_ImMinArray_S64Ptr(long* values, int count);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ulong ImPlot_ImMinArray_U64Ptr(ulong* values, int count);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_ImMinMaxArray_FloatPtr(float* values, int count, float* min_out, float* max_out);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_ImMinMaxArray_doublePtr(double* values, int count, double* min_out, double* max_out);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_ImMinMaxArray_S8Ptr(sbyte* values, int count, sbyte* min_out, sbyte* max_out);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_ImMinMaxArray_U8Ptr(byte* values, int count, byte* min_out, byte* max_out);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_ImMinMaxArray_S16Ptr(short* values, int count, short* min_out, short* max_out);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_ImMinMaxArray_U16Ptr(ushort* values, int count, ushort* min_out, ushort* max_out);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_ImMinMaxArray_S32Ptr(int* values, int count, int* min_out, int* max_out);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_ImMinMaxArray_U32Ptr(uint* values, int count, uint* min_out, uint* max_out);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_ImMinMaxArray_S64Ptr(long* values, int count, long* min_out, long* max_out);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_ImMinMaxArray_U64Ptr(ulong* values, int count, ulong* min_out, ulong* max_out);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern uint ImPlot_ImMixU32(uint a, uint b, uint s);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImPlot_ImNan(double val);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImPlot_ImNanOrInf(double val);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImPlot_ImOverlaps_Float(float min_a, float max_a, float min_b, float max_b);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImPlot_ImOverlaps_double(double min_a, double max_a, double min_b, double max_b);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImPlot_ImOverlaps_S8(sbyte min_a, sbyte max_a, sbyte min_b, sbyte max_b);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImPlot_ImOverlaps_U8(byte min_a, byte max_a, byte min_b, byte max_b);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImPlot_ImOverlaps_S16(short min_a, short max_a, short min_b, short max_b);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImPlot_ImOverlaps_U16(ushort min_a, ushort max_a, ushort min_b, ushort max_b);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImPlot_ImOverlaps_S32(int min_a, int max_a, int min_b, int max_b);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImPlot_ImOverlaps_U32(uint min_a, uint max_a, uint min_b, uint max_b);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImPlot_ImOverlaps_S64(long min_a, long max_a, long min_b, long max_b);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImPlot_ImOverlaps_U64(ulong min_a, ulong max_a, ulong min_b, ulong max_b);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern int ImPlot_ImPosMod(int l, int r);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern float ImPlot_ImRemap_Float(float x, float x0, float x1, float y0, float y1);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern double ImPlot_ImRemap_double(double x, double x0, double x1, double y0, double y1);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern sbyte ImPlot_ImRemap_S8(sbyte x, sbyte x0, sbyte x1, sbyte y0, sbyte y1);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImPlot_ImRemap_U8(byte x, byte x0, byte x1, byte y0, byte y1);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern short ImPlot_ImRemap_S16(short x, short x0, short x1, short y0, short y1);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ushort ImPlot_ImRemap_U16(ushort x, ushort x0, ushort x1, ushort y0, ushort y1);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern int ImPlot_ImRemap_S32(int x, int x0, int x1, int y0, int y1);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern uint ImPlot_ImRemap_U32(uint x, uint x0, uint x1, uint y0, uint y1);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern long ImPlot_ImRemap_S64(long x, long x0, long x1, long y0, long y1);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ulong ImPlot_ImRemap_U64(ulong x, ulong x0, ulong x1, ulong y0, ulong y1);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern float ImPlot_ImRemap01_Float(float x, float x0, float x1);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern double ImPlot_ImRemap01_double(double x, double x0, double x1);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern sbyte ImPlot_ImRemap01_S8(sbyte x, sbyte x0, sbyte x1);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImPlot_ImRemap01_U8(byte x, byte x0, byte x1);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern short ImPlot_ImRemap01_S16(short x, short x0, short x1);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ushort ImPlot_ImRemap01_U16(ushort x, ushort x0, ushort x1);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern int ImPlot_ImRemap01_S32(int x, int x0, int x1);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern uint ImPlot_ImRemap01_U32(uint x, uint x0, uint x1);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern long ImPlot_ImRemap01_S64(long x, long x0, long x1);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ulong ImPlot_ImRemap01_U64(ulong x, ulong x0, ulong x1);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern float ImPlot_ImSinh_Float(float x);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern double ImPlot_ImSinh_double(double x);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern double ImPlot_ImStdDev_FloatPtr(float* values, int count);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern double ImPlot_ImStdDev_doublePtr(double* values, int count);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern double ImPlot_ImStdDev_S8Ptr(sbyte* values, int count);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern double ImPlot_ImStdDev_U8Ptr(byte* values, int count);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern double ImPlot_ImStdDev_S16Ptr(short* values, int count);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern double ImPlot_ImStdDev_U16Ptr(ushort* values, int count);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern double ImPlot_ImStdDev_S32Ptr(int* values, int count);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern double ImPlot_ImStdDev_U32Ptr(uint* values, int count);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern double ImPlot_ImStdDev_S64Ptr(long* values, int count);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern double ImPlot_ImStdDev_U64Ptr(ulong* values, int count);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern float ImPlot_ImSum_FloatPtr(float* values, int count);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern double ImPlot_ImSum_doublePtr(double* values, int count);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern sbyte ImPlot_ImSum_S8Ptr(sbyte* values, int count);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImPlot_ImSum_U8Ptr(byte* values, int count);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern short ImPlot_ImSum_S16Ptr(short* values, int count);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ushort ImPlot_ImSum_U16Ptr(ushort* values, int count);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern int ImPlot_ImSum_S32Ptr(int* values, int count);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern uint ImPlot_ImSum_U32Ptr(uint* values, int count);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern long ImPlot_ImSum_S64Ptr(long* values, int count);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ulong ImPlot_ImSum_U64Ptr(ulong* values, int count);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_Initialize(IntPtr ctx);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_Intersection(Vector2* pOut, Vector2 a1, Vector2 a2, Vector2 b1, Vector2 b2);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImPlot_IsAxisHovered(ImAxis axis);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImPlot_IsColorAuto_Vec4(Vector4 col);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImPlot_IsColorAuto_PlotCol(ImPlotCol idx);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImPlot_IsLeapYear(int year);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImPlot_IsLegendEntryHovered(byte* label_id);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImPlot_IsPlotHovered();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImPlot_IsPlotSelected();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImPlot_IsSubplotsHovered();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_ItemIcon_Vec4(Vector4 col);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_ItemIcon_U32(uint col);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_LabelAxisValue(ImPlotAxis axis, double value, byte* buff, int size, byte round);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_Locator_Default(ImPlotTicker* ticker, ImPlotRange range, float pixels, byte vertical, IntPtr formatter, void* formatter_data);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_Locator_Log10(ImPlotTicker* ticker, ImPlotRange range, float pixels, byte vertical, IntPtr formatter, void* formatter_data);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_Locator_SymLog(ImPlotTicker* ticker, ImPlotRange range, float pixels, byte vertical, IntPtr formatter, void* formatter_data);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_Locator_Time(ImPlotTicker* ticker, ImPlotRange range, float pixels, byte vertical, IntPtr formatter, void* formatter_data);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_MakeTime(ImPlotTime* pOut, int year, int month, int day, int hour, int min, int sec, int us);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_MapInputDefault(ImPlotInputMap* dst);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_MapInputReverse(ImPlotInputMap* dst);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_MkGmtTime(ImPlotTime* pOut, Time* ptm);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_MkLocTime(ImPlotTime* pOut, Time* ptm);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_MkTime(ImPlotTime* pOut, Time* ptm);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_NextColormapColor(Vector4* pOut);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern uint ImPlot_NextColormapColorU32();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern double ImPlot_NiceNum(double x, byte round);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_Now(ImPlotTime* pOut);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern int ImPlot_OrderOfMagnitude(double val);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern int ImPlot_OrderToPrecision(int order);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PixelsToPlot_Vec2(ImPlotPoint* pOut, Vector2 pix, ImAxis x_axis, ImAxis y_axis);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PixelsToPlot_Float(ImPlotPoint* pOut, float x, float y, ImAxis x_axis, ImAxis y_axis);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotBarGroups_FloatPtr(byte** label_ids, float* values, int item_count, int group_count, double group_size, double shift, ImPlotBarGroupsFlags flags);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotBarGroups_doublePtr(byte** label_ids, double* values, int item_count, int group_count, double group_size, double shift, ImPlotBarGroupsFlags flags);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotBarGroups_S8Ptr(byte** label_ids, sbyte* values, int item_count, int group_count, double group_size, double shift, ImPlotBarGroupsFlags flags);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotBarGroups_U8Ptr(byte** label_ids, byte* values, int item_count, int group_count, double group_size, double shift, ImPlotBarGroupsFlags flags);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotBarGroups_S16Ptr(byte** label_ids, short* values, int item_count, int group_count, double group_size, double shift, ImPlotBarGroupsFlags flags);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotBarGroups_U16Ptr(byte** label_ids, ushort* values, int item_count, int group_count, double group_size, double shift, ImPlotBarGroupsFlags flags);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotBarGroups_S32Ptr(byte** label_ids, int* values, int item_count, int group_count, double group_size, double shift, ImPlotBarGroupsFlags flags);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotBarGroups_U32Ptr(byte** label_ids, uint* values, int item_count, int group_count, double group_size, double shift, ImPlotBarGroupsFlags flags);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotBarGroups_S64Ptr(byte** label_ids, long* values, int item_count, int group_count, double group_size, double shift, ImPlotBarGroupsFlags flags);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotBarGroups_U64Ptr(byte** label_ids, ulong* values, int item_count, int group_count, double group_size, double shift, ImPlotBarGroupsFlags flags);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotBars_FloatPtrInt(byte* label_id, float* values, int count, double bar_size, double shift, ImPlotBarsFlags flags, int offset, int stride);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotBars_doublePtrInt(byte* label_id, double* values, int count, double bar_size, double shift, ImPlotBarsFlags flags, int offset, int stride);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotBars_S8PtrInt(byte* label_id, sbyte* values, int count, double bar_size, double shift, ImPlotBarsFlags flags, int offset, int stride);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotBars_U8PtrInt(byte* label_id, byte* values, int count, double bar_size, double shift, ImPlotBarsFlags flags, int offset, int stride);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotBars_S16PtrInt(byte* label_id, short* values, int count, double bar_size, double shift, ImPlotBarsFlags flags, int offset, int stride);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotBars_U16PtrInt(byte* label_id, ushort* values, int count, double bar_size, double shift, ImPlotBarsFlags flags, int offset, int stride);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotBars_S32PtrInt(byte* label_id, int* values, int count, double bar_size, double shift, ImPlotBarsFlags flags, int offset, int stride);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotBars_U32PtrInt(byte* label_id, uint* values, int count, double bar_size, double shift, ImPlotBarsFlags flags, int offset, int stride);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotBars_S64PtrInt(byte* label_id, long* values, int count, double bar_size, double shift, ImPlotBarsFlags flags, int offset, int stride);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotBars_U64PtrInt(byte* label_id, ulong* values, int count, double bar_size, double shift, ImPlotBarsFlags flags, int offset, int stride);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotBars_FloatPtrFloatPtr(byte* label_id, float* xs, float* ys, int count, double bar_size, ImPlotBarsFlags flags, int offset, int stride);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotBars_doublePtrdoublePtr(byte* label_id, double* xs, double* ys, int count, double bar_size, ImPlotBarsFlags flags, int offset, int stride);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotBars_S8PtrS8Ptr(byte* label_id, sbyte* xs, sbyte* ys, int count, double bar_size, ImPlotBarsFlags flags, int offset, int stride);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotBars_U8PtrU8Ptr(byte* label_id, byte* xs, byte* ys, int count, double bar_size, ImPlotBarsFlags flags, int offset, int stride);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotBars_S16PtrS16Ptr(byte* label_id, short* xs, short* ys, int count, double bar_size, ImPlotBarsFlags flags, int offset, int stride);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotBars_U16PtrU16Ptr(byte* label_id, ushort* xs, ushort* ys, int count, double bar_size, ImPlotBarsFlags flags, int offset, int stride);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotBars_S32PtrS32Ptr(byte* label_id, int* xs, int* ys, int count, double bar_size, ImPlotBarsFlags flags, int offset, int stride);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotBars_U32PtrU32Ptr(byte* label_id, uint* xs, uint* ys, int count, double bar_size, ImPlotBarsFlags flags, int offset, int stride);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotBars_S64PtrS64Ptr(byte* label_id, long* xs, long* ys, int count, double bar_size, ImPlotBarsFlags flags, int offset, int stride);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotBars_U64PtrU64Ptr(byte* label_id, ulong* xs, ulong* ys, int count, double bar_size, ImPlotBarsFlags flags, int offset, int stride);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotBarsG(byte* label_id, ImPlotGetter getter, void* data, int count, double bar_size, ImPlotBarsFlags flags);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotDigital_FloatPtr(byte* label_id, float* xs, float* ys, int count, ImPlotDigitalFlags flags, int offset, int stride);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotDigital_doublePtr(byte* label_id, double* xs, double* ys, int count, ImPlotDigitalFlags flags, int offset, int stride);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotDigital_S8Ptr(byte* label_id, sbyte* xs, sbyte* ys, int count, ImPlotDigitalFlags flags, int offset, int stride);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotDigital_U8Ptr(byte* label_id, byte* xs, byte* ys, int count, ImPlotDigitalFlags flags, int offset, int stride);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotDigital_S16Ptr(byte* label_id, short* xs, short* ys, int count, ImPlotDigitalFlags flags, int offset, int stride);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotDigital_U16Ptr(byte* label_id, ushort* xs, ushort* ys, int count, ImPlotDigitalFlags flags, int offset, int stride);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotDigital_S32Ptr(byte* label_id, int* xs, int* ys, int count, ImPlotDigitalFlags flags, int offset, int stride);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotDigital_U32Ptr(byte* label_id, uint* xs, uint* ys, int count, ImPlotDigitalFlags flags, int offset, int stride);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotDigital_S64Ptr(byte* label_id, long* xs, long* ys, int count, ImPlotDigitalFlags flags, int offset, int stride);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotDigital_U64Ptr(byte* label_id, ulong* xs, ulong* ys, int count, ImPlotDigitalFlags flags, int offset, int stride);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotDigitalG(byte* label_id, ImPlotGetter getter, void* data, int count, ImPlotDigitalFlags flags);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotDummy(byte* label_id, ImPlotDummyFlags flags);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotErrorBars_FloatPtrFloatPtrFloatPtrInt(byte* label_id, float* xs, float* ys, float* err, int count, ImPlotErrorBarsFlags flags, int offset, int stride);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotErrorBars_doublePtrdoublePtrdoublePtrInt(byte* label_id, double* xs, double* ys, double* err, int count, ImPlotErrorBarsFlags flags, int offset, int stride);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotErrorBars_S8PtrS8PtrS8PtrInt(byte* label_id, sbyte* xs, sbyte* ys, sbyte* err, int count, ImPlotErrorBarsFlags flags, int offset, int stride);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotErrorBars_U8PtrU8PtrU8PtrInt(byte* label_id, byte* xs, byte* ys, byte* err, int count, ImPlotErrorBarsFlags flags, int offset, int stride);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotErrorBars_S16PtrS16PtrS16PtrInt(byte* label_id, short* xs, short* ys, short* err, int count, ImPlotErrorBarsFlags flags, int offset, int stride);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotErrorBars_U16PtrU16PtrU16PtrInt(byte* label_id, ushort* xs, ushort* ys, ushort* err, int count, ImPlotErrorBarsFlags flags, int offset, int stride);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotErrorBars_S32PtrS32PtrS32PtrInt(byte* label_id, int* xs, int* ys, int* err, int count, ImPlotErrorBarsFlags flags, int offset, int stride);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotErrorBars_U32PtrU32PtrU32PtrInt(byte* label_id, uint* xs, uint* ys, uint* err, int count, ImPlotErrorBarsFlags flags, int offset, int stride);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotErrorBars_S64PtrS64PtrS64PtrInt(byte* label_id, long* xs, long* ys, long* err, int count, ImPlotErrorBarsFlags flags, int offset, int stride);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotErrorBars_U64PtrU64PtrU64PtrInt(byte* label_id, ulong* xs, ulong* ys, ulong* err, int count, ImPlotErrorBarsFlags flags, int offset, int stride);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotErrorBars_FloatPtrFloatPtrFloatPtrFloatPtr(byte* label_id, float* xs, float* ys, float* neg, float* pos, int count, ImPlotErrorBarsFlags flags, int offset, int stride);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotErrorBars_doublePtrdoublePtrdoublePtrdoublePtr(byte* label_id, double* xs, double* ys, double* neg, double* pos, int count, ImPlotErrorBarsFlags flags, int offset, int stride);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotErrorBars_S8PtrS8PtrS8PtrS8Ptr(byte* label_id, sbyte* xs, sbyte* ys, sbyte* neg, sbyte* pos, int count, ImPlotErrorBarsFlags flags, int offset, int stride);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotErrorBars_U8PtrU8PtrU8PtrU8Ptr(byte* label_id, byte* xs, byte* ys, byte* neg, byte* pos, int count, ImPlotErrorBarsFlags flags, int offset, int stride);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotErrorBars_S16PtrS16PtrS16PtrS16Ptr(byte* label_id, short* xs, short* ys, short* neg, short* pos, int count, ImPlotErrorBarsFlags flags, int offset, int stride);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotErrorBars_U16PtrU16PtrU16PtrU16Ptr(byte* label_id, ushort* xs, ushort* ys, ushort* neg, ushort* pos, int count, ImPlotErrorBarsFlags flags, int offset, int stride);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotErrorBars_S32PtrS32PtrS32PtrS32Ptr(byte* label_id, int* xs, int* ys, int* neg, int* pos, int count, ImPlotErrorBarsFlags flags, int offset, int stride);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotErrorBars_U32PtrU32PtrU32PtrU32Ptr(byte* label_id, uint* xs, uint* ys, uint* neg, uint* pos, int count, ImPlotErrorBarsFlags flags, int offset, int stride);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotErrorBars_S64PtrS64PtrS64PtrS64Ptr(byte* label_id, long* xs, long* ys, long* neg, long* pos, int count, ImPlotErrorBarsFlags flags, int offset, int stride);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotErrorBars_U64PtrU64PtrU64PtrU64Ptr(byte* label_id, ulong* xs, ulong* ys, ulong* neg, ulong* pos, int count, ImPlotErrorBarsFlags flags, int offset, int stride);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotHeatmap_FloatPtr(byte* label_id, float* values, int rows, int cols, double scale_min, double scale_max, byte* label_fmt, ImPlotPoint bounds_min, ImPlotPoint bounds_max, ImPlotHeatmapFlags flags);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotHeatmap_doublePtr(byte* label_id, double* values, int rows, int cols, double scale_min, double scale_max, byte* label_fmt, ImPlotPoint bounds_min, ImPlotPoint bounds_max, ImPlotHeatmapFlags flags);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotHeatmap_S8Ptr(byte* label_id, sbyte* values, int rows, int cols, double scale_min, double scale_max, byte* label_fmt, ImPlotPoint bounds_min, ImPlotPoint bounds_max, ImPlotHeatmapFlags flags);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotHeatmap_U8Ptr(byte* label_id, byte* values, int rows, int cols, double scale_min, double scale_max, byte* label_fmt, ImPlotPoint bounds_min, ImPlotPoint bounds_max, ImPlotHeatmapFlags flags);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotHeatmap_S16Ptr(byte* label_id, short* values, int rows, int cols, double scale_min, double scale_max, byte* label_fmt, ImPlotPoint bounds_min, ImPlotPoint bounds_max, ImPlotHeatmapFlags flags);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotHeatmap_U16Ptr(byte* label_id, ushort* values, int rows, int cols, double scale_min, double scale_max, byte* label_fmt, ImPlotPoint bounds_min, ImPlotPoint bounds_max, ImPlotHeatmapFlags flags);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotHeatmap_S32Ptr(byte* label_id, int* values, int rows, int cols, double scale_min, double scale_max, byte* label_fmt, ImPlotPoint bounds_min, ImPlotPoint bounds_max, ImPlotHeatmapFlags flags);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotHeatmap_U32Ptr(byte* label_id, uint* values, int rows, int cols, double scale_min, double scale_max, byte* label_fmt, ImPlotPoint bounds_min, ImPlotPoint bounds_max, ImPlotHeatmapFlags flags);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotHeatmap_S64Ptr(byte* label_id, long* values, int rows, int cols, double scale_min, double scale_max, byte* label_fmt, ImPlotPoint bounds_min, ImPlotPoint bounds_max, ImPlotHeatmapFlags flags);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotHeatmap_U64Ptr(byte* label_id, ulong* values, int rows, int cols, double scale_min, double scale_max, byte* label_fmt, ImPlotPoint bounds_min, ImPlotPoint bounds_max, ImPlotHeatmapFlags flags);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern double ImPlot_PlotHistogram_FloatPtr(byte* label_id, float* values, int count, int bins, double bar_scale, ImPlotRange range, ImPlotHistogramFlags flags);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern double ImPlot_PlotHistogram_doublePtr(byte* label_id, double* values, int count, int bins, double bar_scale, ImPlotRange range, ImPlotHistogramFlags flags);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern double ImPlot_PlotHistogram_S8Ptr(byte* label_id, sbyte* values, int count, int bins, double bar_scale, ImPlotRange range, ImPlotHistogramFlags flags);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern double ImPlot_PlotHistogram_U8Ptr(byte* label_id, byte* values, int count, int bins, double bar_scale, ImPlotRange range, ImPlotHistogramFlags flags);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern double ImPlot_PlotHistogram_S16Ptr(byte* label_id, short* values, int count, int bins, double bar_scale, ImPlotRange range, ImPlotHistogramFlags flags);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern double ImPlot_PlotHistogram_U16Ptr(byte* label_id, ushort* values, int count, int bins, double bar_scale, ImPlotRange range, ImPlotHistogramFlags flags);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern double ImPlot_PlotHistogram_S32Ptr(byte* label_id, int* values, int count, int bins, double bar_scale, ImPlotRange range, ImPlotHistogramFlags flags);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern double ImPlot_PlotHistogram_U32Ptr(byte* label_id, uint* values, int count, int bins, double bar_scale, ImPlotRange range, ImPlotHistogramFlags flags);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern double ImPlot_PlotHistogram_S64Ptr(byte* label_id, long* values, int count, int bins, double bar_scale, ImPlotRange range, ImPlotHistogramFlags flags);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern double ImPlot_PlotHistogram_U64Ptr(byte* label_id, ulong* values, int count, int bins, double bar_scale, ImPlotRange range, ImPlotHistogramFlags flags);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern double ImPlot_PlotHistogram2D_FloatPtr(byte* label_id, float* xs, float* ys, int count, int x_bins, int y_bins, ImPlotRect range, ImPlotHistogramFlags flags);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern double ImPlot_PlotHistogram2D_doublePtr(byte* label_id, double* xs, double* ys, int count, int x_bins, int y_bins, ImPlotRect range, ImPlotHistogramFlags flags);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern double ImPlot_PlotHistogram2D_S8Ptr(byte* label_id, sbyte* xs, sbyte* ys, int count, int x_bins, int y_bins, ImPlotRect range, ImPlotHistogramFlags flags);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern double ImPlot_PlotHistogram2D_U8Ptr(byte* label_id, byte* xs, byte* ys, int count, int x_bins, int y_bins, ImPlotRect range, ImPlotHistogramFlags flags);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern double ImPlot_PlotHistogram2D_S16Ptr(byte* label_id, short* xs, short* ys, int count, int x_bins, int y_bins, ImPlotRect range, ImPlotHistogramFlags flags);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern double ImPlot_PlotHistogram2D_U16Ptr(byte* label_id, ushort* xs, ushort* ys, int count, int x_bins, int y_bins, ImPlotRect range, ImPlotHistogramFlags flags);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern double ImPlot_PlotHistogram2D_S32Ptr(byte* label_id, int* xs, int* ys, int count, int x_bins, int y_bins, ImPlotRect range, ImPlotHistogramFlags flags);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern double ImPlot_PlotHistogram2D_U32Ptr(byte* label_id, uint* xs, uint* ys, int count, int x_bins, int y_bins, ImPlotRect range, ImPlotHistogramFlags flags);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern double ImPlot_PlotHistogram2D_S64Ptr(byte* label_id, long* xs, long* ys, int count, int x_bins, int y_bins, ImPlotRect range, ImPlotHistogramFlags flags);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern double ImPlot_PlotHistogram2D_U64Ptr(byte* label_id, ulong* xs, ulong* ys, int count, int x_bins, int y_bins, ImPlotRect range, ImPlotHistogramFlags flags);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotImage(byte* label_id, ImTextureRef tex_ref, ImPlotPoint bounds_min, ImPlotPoint bounds_max, Vector2 uv0, Vector2 uv1, Vector4 tint_col, ImPlotImageFlags flags);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotInfLines_FloatPtr(byte* label_id, float* values, int count, ImPlotInfLinesFlags flags, int offset, int stride);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotInfLines_doublePtr(byte* label_id, double* values, int count, ImPlotInfLinesFlags flags, int offset, int stride);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotInfLines_S8Ptr(byte* label_id, sbyte* values, int count, ImPlotInfLinesFlags flags, int offset, int stride);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotInfLines_U8Ptr(byte* label_id, byte* values, int count, ImPlotInfLinesFlags flags, int offset, int stride);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotInfLines_S16Ptr(byte* label_id, short* values, int count, ImPlotInfLinesFlags flags, int offset, int stride);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotInfLines_U16Ptr(byte* label_id, ushort* values, int count, ImPlotInfLinesFlags flags, int offset, int stride);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotInfLines_S32Ptr(byte* label_id, int* values, int count, ImPlotInfLinesFlags flags, int offset, int stride);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotInfLines_U32Ptr(byte* label_id, uint* values, int count, ImPlotInfLinesFlags flags, int offset, int stride);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotInfLines_S64Ptr(byte* label_id, long* values, int count, ImPlotInfLinesFlags flags, int offset, int stride);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotInfLines_U64Ptr(byte* label_id, ulong* values, int count, ImPlotInfLinesFlags flags, int offset, int stride);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotLine_FloatPtrInt(byte* label_id, float* values, int count, double xscale, double xstart, ImPlotLineFlags flags, int offset, int stride);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotLine_doublePtrInt(byte* label_id, double* values, int count, double xscale, double xstart, ImPlotLineFlags flags, int offset, int stride);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotLine_S8PtrInt(byte* label_id, sbyte* values, int count, double xscale, double xstart, ImPlotLineFlags flags, int offset, int stride);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotLine_U8PtrInt(byte* label_id, byte* values, int count, double xscale, double xstart, ImPlotLineFlags flags, int offset, int stride);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotLine_S16PtrInt(byte* label_id, short* values, int count, double xscale, double xstart, ImPlotLineFlags flags, int offset, int stride);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotLine_U16PtrInt(byte* label_id, ushort* values, int count, double xscale, double xstart, ImPlotLineFlags flags, int offset, int stride);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotLine_S32PtrInt(byte* label_id, int* values, int count, double xscale, double xstart, ImPlotLineFlags flags, int offset, int stride);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotLine_U32PtrInt(byte* label_id, uint* values, int count, double xscale, double xstart, ImPlotLineFlags flags, int offset, int stride);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotLine_S64PtrInt(byte* label_id, long* values, int count, double xscale, double xstart, ImPlotLineFlags flags, int offset, int stride);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotLine_U64PtrInt(byte* label_id, ulong* values, int count, double xscale, double xstart, ImPlotLineFlags flags, int offset, int stride);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotLine_FloatPtrFloatPtr(byte* label_id, float* xs, float* ys, int count, ImPlotLineFlags flags, int offset, int stride);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotLine_doublePtrdoublePtr(byte* label_id, double* xs, double* ys, int count, ImPlotLineFlags flags, int offset, int stride);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotLine_S8PtrS8Ptr(byte* label_id, sbyte* xs, sbyte* ys, int count, ImPlotLineFlags flags, int offset, int stride);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotLine_U8PtrU8Ptr(byte* label_id, byte* xs, byte* ys, int count, ImPlotLineFlags flags, int offset, int stride);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotLine_S16PtrS16Ptr(byte* label_id, short* xs, short* ys, int count, ImPlotLineFlags flags, int offset, int stride);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotLine_U16PtrU16Ptr(byte* label_id, ushort* xs, ushort* ys, int count, ImPlotLineFlags flags, int offset, int stride);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotLine_S32PtrS32Ptr(byte* label_id, int* xs, int* ys, int count, ImPlotLineFlags flags, int offset, int stride);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotLine_U32PtrU32Ptr(byte* label_id, uint* xs, uint* ys, int count, ImPlotLineFlags flags, int offset, int stride);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotLine_S64PtrS64Ptr(byte* label_id, long* xs, long* ys, int count, ImPlotLineFlags flags, int offset, int stride);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotLine_U64PtrU64Ptr(byte* label_id, ulong* xs, ulong* ys, int count, ImPlotLineFlags flags, int offset, int stride);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotLineG(byte* label_id, ImPlotGetter getter, void* data, int count, ImPlotLineFlags flags);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotPieChart_FloatPtrPlotFormatter(byte** label_ids, float* values, int count, double x, double y, double radius, IntPtr fmt, void* fmt_data, double angle0, ImPlotPieChartFlags flags);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotPieChart_doublePtrPlotFormatter(byte** label_ids, double* values, int count, double x, double y, double radius, IntPtr fmt, void* fmt_data, double angle0, ImPlotPieChartFlags flags);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotPieChart_S8PtrPlotFormatter(byte** label_ids, sbyte* values, int count, double x, double y, double radius, IntPtr fmt, void* fmt_data, double angle0, ImPlotPieChartFlags flags);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotPieChart_U8PtrPlotFormatter(byte** label_ids, byte* values, int count, double x, double y, double radius, IntPtr fmt, void* fmt_data, double angle0, ImPlotPieChartFlags flags);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotPieChart_S16PtrPlotFormatter(byte** label_ids, short* values, int count, double x, double y, double radius, IntPtr fmt, void* fmt_data, double angle0, ImPlotPieChartFlags flags);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotPieChart_U16PtrPlotFormatter(byte** label_ids, ushort* values, int count, double x, double y, double radius, IntPtr fmt, void* fmt_data, double angle0, ImPlotPieChartFlags flags);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotPieChart_S32PtrPlotFormatter(byte** label_ids, int* values, int count, double x, double y, double radius, IntPtr fmt, void* fmt_data, double angle0, ImPlotPieChartFlags flags);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotPieChart_U32PtrPlotFormatter(byte** label_ids, uint* values, int count, double x, double y, double radius, IntPtr fmt, void* fmt_data, double angle0, ImPlotPieChartFlags flags);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotPieChart_S64PtrPlotFormatter(byte** label_ids, long* values, int count, double x, double y, double radius, IntPtr fmt, void* fmt_data, double angle0, ImPlotPieChartFlags flags);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotPieChart_U64PtrPlotFormatter(byte** label_ids, ulong* values, int count, double x, double y, double radius, IntPtr fmt, void* fmt_data, double angle0, ImPlotPieChartFlags flags);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotPieChart_FloatPtrStr(byte** label_ids, float* values, int count, double x, double y, double radius, byte* label_fmt, double angle0, ImPlotPieChartFlags flags);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotPieChart_doublePtrStr(byte** label_ids, double* values, int count, double x, double y, double radius, byte* label_fmt, double angle0, ImPlotPieChartFlags flags);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotPieChart_S8PtrStr(byte** label_ids, sbyte* values, int count, double x, double y, double radius, byte* label_fmt, double angle0, ImPlotPieChartFlags flags);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotPieChart_U8PtrStr(byte** label_ids, byte* values, int count, double x, double y, double radius, byte* label_fmt, double angle0, ImPlotPieChartFlags flags);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotPieChart_S16PtrStr(byte** label_ids, short* values, int count, double x, double y, double radius, byte* label_fmt, double angle0, ImPlotPieChartFlags flags);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotPieChart_U16PtrStr(byte** label_ids, ushort* values, int count, double x, double y, double radius, byte* label_fmt, double angle0, ImPlotPieChartFlags flags);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotPieChart_S32PtrStr(byte** label_ids, int* values, int count, double x, double y, double radius, byte* label_fmt, double angle0, ImPlotPieChartFlags flags);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotPieChart_U32PtrStr(byte** label_ids, uint* values, int count, double x, double y, double radius, byte* label_fmt, double angle0, ImPlotPieChartFlags flags);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotPieChart_S64PtrStr(byte** label_ids, long* values, int count, double x, double y, double radius, byte* label_fmt, double angle0, ImPlotPieChartFlags flags);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotPieChart_U64PtrStr(byte** label_ids, ulong* values, int count, double x, double y, double radius, byte* label_fmt, double angle0, ImPlotPieChartFlags flags);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotScatter_FloatPtrInt(byte* label_id, float* values, int count, double xscale, double xstart, ImPlotScatterFlags flags, int offset, int stride);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotScatter_doublePtrInt(byte* label_id, double* values, int count, double xscale, double xstart, ImPlotScatterFlags flags, int offset, int stride);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotScatter_S8PtrInt(byte* label_id, sbyte* values, int count, double xscale, double xstart, ImPlotScatterFlags flags, int offset, int stride);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotScatter_U8PtrInt(byte* label_id, byte* values, int count, double xscale, double xstart, ImPlotScatterFlags flags, int offset, int stride);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotScatter_S16PtrInt(byte* label_id, short* values, int count, double xscale, double xstart, ImPlotScatterFlags flags, int offset, int stride);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotScatter_U16PtrInt(byte* label_id, ushort* values, int count, double xscale, double xstart, ImPlotScatterFlags flags, int offset, int stride);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotScatter_S32PtrInt(byte* label_id, int* values, int count, double xscale, double xstart, ImPlotScatterFlags flags, int offset, int stride);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotScatter_U32PtrInt(byte* label_id, uint* values, int count, double xscale, double xstart, ImPlotScatterFlags flags, int offset, int stride);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotScatter_S64PtrInt(byte* label_id, long* values, int count, double xscale, double xstart, ImPlotScatterFlags flags, int offset, int stride);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotScatter_U64PtrInt(byte* label_id, ulong* values, int count, double xscale, double xstart, ImPlotScatterFlags flags, int offset, int stride);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotScatter_FloatPtrFloatPtr(byte* label_id, float* xs, float* ys, int count, ImPlotScatterFlags flags, int offset, int stride);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotScatter_doublePtrdoublePtr(byte* label_id, double* xs, double* ys, int count, ImPlotScatterFlags flags, int offset, int stride);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotScatter_S8PtrS8Ptr(byte* label_id, sbyte* xs, sbyte* ys, int count, ImPlotScatterFlags flags, int offset, int stride);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotScatter_U8PtrU8Ptr(byte* label_id, byte* xs, byte* ys, int count, ImPlotScatterFlags flags, int offset, int stride);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotScatter_S16PtrS16Ptr(byte* label_id, short* xs, short* ys, int count, ImPlotScatterFlags flags, int offset, int stride);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotScatter_U16PtrU16Ptr(byte* label_id, ushort* xs, ushort* ys, int count, ImPlotScatterFlags flags, int offset, int stride);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotScatter_S32PtrS32Ptr(byte* label_id, int* xs, int* ys, int count, ImPlotScatterFlags flags, int offset, int stride);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotScatter_U32PtrU32Ptr(byte* label_id, uint* xs, uint* ys, int count, ImPlotScatterFlags flags, int offset, int stride);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotScatter_S64PtrS64Ptr(byte* label_id, long* xs, long* ys, int count, ImPlotScatterFlags flags, int offset, int stride);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotScatter_U64PtrU64Ptr(byte* label_id, ulong* xs, ulong* ys, int count, ImPlotScatterFlags flags, int offset, int stride);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotScatterG(byte* label_id, ImPlotGetter getter, void* data, int count, ImPlotScatterFlags flags);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotShaded_FloatPtrInt(byte* label_id, float* values, int count, double yref, double xscale, double xstart, ImPlotShadedFlags flags, int offset, int stride);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotShaded_doublePtrInt(byte* label_id, double* values, int count, double yref, double xscale, double xstart, ImPlotShadedFlags flags, int offset, int stride);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotShaded_S8PtrInt(byte* label_id, sbyte* values, int count, double yref, double xscale, double xstart, ImPlotShadedFlags flags, int offset, int stride);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotShaded_U8PtrInt(byte* label_id, byte* values, int count, double yref, double xscale, double xstart, ImPlotShadedFlags flags, int offset, int stride);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotShaded_S16PtrInt(byte* label_id, short* values, int count, double yref, double xscale, double xstart, ImPlotShadedFlags flags, int offset, int stride);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotShaded_U16PtrInt(byte* label_id, ushort* values, int count, double yref, double xscale, double xstart, ImPlotShadedFlags flags, int offset, int stride);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotShaded_S32PtrInt(byte* label_id, int* values, int count, double yref, double xscale, double xstart, ImPlotShadedFlags flags, int offset, int stride);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotShaded_U32PtrInt(byte* label_id, uint* values, int count, double yref, double xscale, double xstart, ImPlotShadedFlags flags, int offset, int stride);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotShaded_S64PtrInt(byte* label_id, long* values, int count, double yref, double xscale, double xstart, ImPlotShadedFlags flags, int offset, int stride);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotShaded_U64PtrInt(byte* label_id, ulong* values, int count, double yref, double xscale, double xstart, ImPlotShadedFlags flags, int offset, int stride);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotShaded_FloatPtrFloatPtrInt(byte* label_id, float* xs, float* ys, int count, double yref, ImPlotShadedFlags flags, int offset, int stride);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotShaded_doublePtrdoublePtrInt(byte* label_id, double* xs, double* ys, int count, double yref, ImPlotShadedFlags flags, int offset, int stride);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotShaded_S8PtrS8PtrInt(byte* label_id, sbyte* xs, sbyte* ys, int count, double yref, ImPlotShadedFlags flags, int offset, int stride);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotShaded_U8PtrU8PtrInt(byte* label_id, byte* xs, byte* ys, int count, double yref, ImPlotShadedFlags flags, int offset, int stride);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotShaded_S16PtrS16PtrInt(byte* label_id, short* xs, short* ys, int count, double yref, ImPlotShadedFlags flags, int offset, int stride);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotShaded_U16PtrU16PtrInt(byte* label_id, ushort* xs, ushort* ys, int count, double yref, ImPlotShadedFlags flags, int offset, int stride);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotShaded_S32PtrS32PtrInt(byte* label_id, int* xs, int* ys, int count, double yref, ImPlotShadedFlags flags, int offset, int stride);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotShaded_U32PtrU32PtrInt(byte* label_id, uint* xs, uint* ys, int count, double yref, ImPlotShadedFlags flags, int offset, int stride);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotShaded_S64PtrS64PtrInt(byte* label_id, long* xs, long* ys, int count, double yref, ImPlotShadedFlags flags, int offset, int stride);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotShaded_U64PtrU64PtrInt(byte* label_id, ulong* xs, ulong* ys, int count, double yref, ImPlotShadedFlags flags, int offset, int stride);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotShaded_FloatPtrFloatPtrFloatPtr(byte* label_id, float* xs, float* ys1, float* ys2, int count, ImPlotShadedFlags flags, int offset, int stride);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotShaded_doublePtrdoublePtrdoublePtr(byte* label_id, double* xs, double* ys1, double* ys2, int count, ImPlotShadedFlags flags, int offset, int stride);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotShaded_S8PtrS8PtrS8Ptr(byte* label_id, sbyte* xs, sbyte* ys1, sbyte* ys2, int count, ImPlotShadedFlags flags, int offset, int stride);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotShaded_U8PtrU8PtrU8Ptr(byte* label_id, byte* xs, byte* ys1, byte* ys2, int count, ImPlotShadedFlags flags, int offset, int stride);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotShaded_S16PtrS16PtrS16Ptr(byte* label_id, short* xs, short* ys1, short* ys2, int count, ImPlotShadedFlags flags, int offset, int stride);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotShaded_U16PtrU16PtrU16Ptr(byte* label_id, ushort* xs, ushort* ys1, ushort* ys2, int count, ImPlotShadedFlags flags, int offset, int stride);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotShaded_S32PtrS32PtrS32Ptr(byte* label_id, int* xs, int* ys1, int* ys2, int count, ImPlotShadedFlags flags, int offset, int stride);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotShaded_U32PtrU32PtrU32Ptr(byte* label_id, uint* xs, uint* ys1, uint* ys2, int count, ImPlotShadedFlags flags, int offset, int stride);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotShaded_S64PtrS64PtrS64Ptr(byte* label_id, long* xs, long* ys1, long* ys2, int count, ImPlotShadedFlags flags, int offset, int stride);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotShaded_U64PtrU64PtrU64Ptr(byte* label_id, ulong* xs, ulong* ys1, ulong* ys2, int count, ImPlotShadedFlags flags, int offset, int stride);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotShadedG(byte* label_id, ImPlotGetter getter1, void* data1, ImPlotGetter getter2, void* data2, int count, ImPlotShadedFlags flags);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotStairs_FloatPtrInt(byte* label_id, float* values, int count, double xscale, double xstart, ImPlotStairsFlags flags, int offset, int stride);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotStairs_doublePtrInt(byte* label_id, double* values, int count, double xscale, double xstart, ImPlotStairsFlags flags, int offset, int stride);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotStairs_S8PtrInt(byte* label_id, sbyte* values, int count, double xscale, double xstart, ImPlotStairsFlags flags, int offset, int stride);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotStairs_U8PtrInt(byte* label_id, byte* values, int count, double xscale, double xstart, ImPlotStairsFlags flags, int offset, int stride);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotStairs_S16PtrInt(byte* label_id, short* values, int count, double xscale, double xstart, ImPlotStairsFlags flags, int offset, int stride);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotStairs_U16PtrInt(byte* label_id, ushort* values, int count, double xscale, double xstart, ImPlotStairsFlags flags, int offset, int stride);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotStairs_S32PtrInt(byte* label_id, int* values, int count, double xscale, double xstart, ImPlotStairsFlags flags, int offset, int stride);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotStairs_U32PtrInt(byte* label_id, uint* values, int count, double xscale, double xstart, ImPlotStairsFlags flags, int offset, int stride);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotStairs_S64PtrInt(byte* label_id, long* values, int count, double xscale, double xstart, ImPlotStairsFlags flags, int offset, int stride);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotStairs_U64PtrInt(byte* label_id, ulong* values, int count, double xscale, double xstart, ImPlotStairsFlags flags, int offset, int stride);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotStairs_FloatPtrFloatPtr(byte* label_id, float* xs, float* ys, int count, ImPlotStairsFlags flags, int offset, int stride);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotStairs_doublePtrdoublePtr(byte* label_id, double* xs, double* ys, int count, ImPlotStairsFlags flags, int offset, int stride);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotStairs_S8PtrS8Ptr(byte* label_id, sbyte* xs, sbyte* ys, int count, ImPlotStairsFlags flags, int offset, int stride);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotStairs_U8PtrU8Ptr(byte* label_id, byte* xs, byte* ys, int count, ImPlotStairsFlags flags, int offset, int stride);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotStairs_S16PtrS16Ptr(byte* label_id, short* xs, short* ys, int count, ImPlotStairsFlags flags, int offset, int stride);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotStairs_U16PtrU16Ptr(byte* label_id, ushort* xs, ushort* ys, int count, ImPlotStairsFlags flags, int offset, int stride);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotStairs_S32PtrS32Ptr(byte* label_id, int* xs, int* ys, int count, ImPlotStairsFlags flags, int offset, int stride);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotStairs_U32PtrU32Ptr(byte* label_id, uint* xs, uint* ys, int count, ImPlotStairsFlags flags, int offset, int stride);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotStairs_S64PtrS64Ptr(byte* label_id, long* xs, long* ys, int count, ImPlotStairsFlags flags, int offset, int stride);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotStairs_U64PtrU64Ptr(byte* label_id, ulong* xs, ulong* ys, int count, ImPlotStairsFlags flags, int offset, int stride);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotStairsG(byte* label_id, ImPlotGetter getter, void* data, int count, ImPlotStairsFlags flags);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotStems_FloatPtrInt(byte* label_id, float* values, int count, double @ref, double scale, double start, ImPlotStemsFlags flags, int offset, int stride);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotStems_doublePtrInt(byte* label_id, double* values, int count, double @ref, double scale, double start, ImPlotStemsFlags flags, int offset, int stride);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotStems_S8PtrInt(byte* label_id, sbyte* values, int count, double @ref, double scale, double start, ImPlotStemsFlags flags, int offset, int stride);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotStems_U8PtrInt(byte* label_id, byte* values, int count, double @ref, double scale, double start, ImPlotStemsFlags flags, int offset, int stride);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotStems_S16PtrInt(byte* label_id, short* values, int count, double @ref, double scale, double start, ImPlotStemsFlags flags, int offset, int stride);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotStems_U16PtrInt(byte* label_id, ushort* values, int count, double @ref, double scale, double start, ImPlotStemsFlags flags, int offset, int stride);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotStems_S32PtrInt(byte* label_id, int* values, int count, double @ref, double scale, double start, ImPlotStemsFlags flags, int offset, int stride);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotStems_U32PtrInt(byte* label_id, uint* values, int count, double @ref, double scale, double start, ImPlotStemsFlags flags, int offset, int stride);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotStems_S64PtrInt(byte* label_id, long* values, int count, double @ref, double scale, double start, ImPlotStemsFlags flags, int offset, int stride);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotStems_U64PtrInt(byte* label_id, ulong* values, int count, double @ref, double scale, double start, ImPlotStemsFlags flags, int offset, int stride);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotStems_FloatPtrFloatPtr(byte* label_id, float* xs, float* ys, int count, double @ref, ImPlotStemsFlags flags, int offset, int stride);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotStems_doublePtrdoublePtr(byte* label_id, double* xs, double* ys, int count, double @ref, ImPlotStemsFlags flags, int offset, int stride);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotStems_S8PtrS8Ptr(byte* label_id, sbyte* xs, sbyte* ys, int count, double @ref, ImPlotStemsFlags flags, int offset, int stride);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotStems_U8PtrU8Ptr(byte* label_id, byte* xs, byte* ys, int count, double @ref, ImPlotStemsFlags flags, int offset, int stride);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotStems_S16PtrS16Ptr(byte* label_id, short* xs, short* ys, int count, double @ref, ImPlotStemsFlags flags, int offset, int stride);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotStems_U16PtrU16Ptr(byte* label_id, ushort* xs, ushort* ys, int count, double @ref, ImPlotStemsFlags flags, int offset, int stride);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotStems_S32PtrS32Ptr(byte* label_id, int* xs, int* ys, int count, double @ref, ImPlotStemsFlags flags, int offset, int stride);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotStems_U32PtrU32Ptr(byte* label_id, uint* xs, uint* ys, int count, double @ref, ImPlotStemsFlags flags, int offset, int stride);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotStems_S64PtrS64Ptr(byte* label_id, long* xs, long* ys, int count, double @ref, ImPlotStemsFlags flags, int offset, int stride);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotStems_U64PtrU64Ptr(byte* label_id, ulong* xs, ulong* ys, int count, double @ref, ImPlotStemsFlags flags, int offset, int stride);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotText(byte* text, double x, double y, Vector2 pix_offset, ImPlotTextFlags flags);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotToPixels_PlotPoInt(Vector2* pOut, ImPlotPoint plt, ImAxis x_axis, ImAxis y_axis);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PlotToPixels_double(Vector2* pOut, double x, double y, ImAxis x_axis, ImAxis y_axis);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PopColormap(int count);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PopPlotClipRect();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PopStyleColor(int count);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PopStyleVar(int count);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern int ImPlot_Precision(double val);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PushColormap_PlotColormap(ImPlotColormap cmap);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PushColormap_Str(byte* name);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PushPlotClipRect(float expand);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PushStyleColor_U32(ImPlotCol idx, uint col);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PushStyleColor_Vec4(ImPlotCol idx, Vector4 col);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PushStyleVar_Float(ImPlotStyleVar idx, float val);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PushStyleVar_Int(ImPlotStyleVar idx, int val);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_PushStyleVar_Vec2(ImPlotStyleVar idx, Vector2 val);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImPlot_RangesOverlap(ImPlotRange r1, ImPlotRange r2);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImPlotItem* ImPlot_RegisterOrGetItem(byte* label_id, ImPlotItemFlags flags, byte* just_created);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_RenderColorBar(uint* colors, int size, ImDrawList* DrawList, ImRect bounds, byte vert, byte reversed, byte continuous);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_ResetCtxForNextAlignedPlots(IntPtr ctx);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_ResetCtxForNextPlot(IntPtr ctx);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_ResetCtxForNextSubplot(IntPtr ctx);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_RoundTime(ImPlotTime* pOut, ImPlotTime t, ImPlotTimeUnit unit);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern double ImPlot_RoundTo(double val, int prec);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_SampleColormap(Vector4* pOut, float t, ImPlotColormap cmap);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern uint ImPlot_SampleColormapU32(float t, ImPlotColormap cmap);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_SetAxes(ImAxis x_axis, ImAxis y_axis);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_SetAxis(ImAxis axis);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_SetCurrentContext(IntPtr ctx);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_SetImGuiContext(IntPtr ctx);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_SetNextAxesLimits(double x_min, double x_max, double y_min, double y_max, ImPlotCond cond);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_SetNextAxesToFit();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_SetNextAxisLimits(ImAxis axis, double v_min, double v_max, ImPlotCond cond);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_SetNextAxisLinks(ImAxis axis, double* link_min, double* link_max);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_SetNextAxisToFit(ImAxis axis);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_SetNextErrorBarStyle(Vector4 col, float size, float weight);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_SetNextFillStyle(Vector4 col, float alpha_mod);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_SetNextLineStyle(Vector4 col, float weight);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_SetNextMarkerStyle(ImPlotMarker marker, float size, Vector4 fill, float weight, Vector4 outline);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_SetupAxes(byte* x_label, byte* y_label, ImPlotAxisFlags x_flags, ImPlotAxisFlags y_flags);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_SetupAxesLimits(double x_min, double x_max, double y_min, double y_max, ImPlotCond cond);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_SetupAxis(ImAxis axis, byte* label, ImPlotAxisFlags flags);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_SetupAxisFormat_Str(ImAxis axis, byte* fmt);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_SetupAxisFormat_PlotFormatter(ImAxis axis, IntPtr formatter, void* data);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_SetupAxisLimits(ImAxis axis, double v_min, double v_max, ImPlotCond cond);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_SetupAxisLimitsConstraints(ImAxis axis, double v_min, double v_max);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_SetupAxisLinks(ImAxis axis, double* link_min, double* link_max);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_SetupAxisScale_PlotScale(ImAxis axis, ImPlotScale scale);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_SetupAxisScale_PlotTransform(ImAxis axis, ImPlotTransform forward, ImPlotTransform inverse, void* data);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_SetupAxisTicks_doublePtr(ImAxis axis, double* values, int n_ticks, byte** labels, byte keep_default);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_SetupAxisTicks_double(ImAxis axis, double v_min, double v_max, int n_ticks, byte** labels, byte keep_default);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_SetupAxisZoomConstraints(ImAxis axis, double z_min, double z_max);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_SetupFinish();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_SetupLegend(ImPlotLocation location, ImPlotLegendFlags flags);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_SetupLock();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_SetupMouseText(ImPlotLocation location, ImPlotMouseTextFlags flags);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_ShowAltLegend(byte* title_id, byte vertical, Vector2 size, byte interactable);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_ShowAxisContextMenu(ImPlotAxis* axis, ImPlotAxis* equal_axis, byte time_allowed);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImPlot_ShowColormapSelector(byte* label);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImPlot_ShowDatePicker(byte* id, int* level, ImPlotTime* t, ImPlotTime* t1, ImPlotTime* t2);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_ShowDemoWindow(byte* p_open);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImPlot_ShowInputMapSelector(byte* label);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImPlot_ShowLegendContextMenu(ImPlotLegend* legend, byte visible);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImPlot_ShowLegendEntries(ImPlotItemGroup* items, ImRect legend_bb, byte interactable, Vector2 pad, Vector2 spacing, byte vertical, ImDrawList* DrawList);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_ShowMetricsWindow(byte* p_popen);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_ShowPlotContextMenu(ImPlotPlot* plot);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_ShowStyleEditor(ImPlotStyle* @ref);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImPlot_ShowStyleSelector(byte* label);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_ShowSubplotsContextMenu(ImPlotSubplot* subplot);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImPlot_ShowTimePicker(byte* id, ImPlotTime* t);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_ShowUserGuide();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_StyleColorsAuto(ImPlotStyle* dst);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_StyleColorsClassic(ImPlotStyle* dst);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_StyleColorsDark(ImPlotStyle* dst);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_StyleColorsLight(ImPlotStyle* dst);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_SubplotNextCell();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_TagX_Bool(double x, Vector4 col, byte round);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_TagX_Str(double x, Vector4 col, byte* fmt);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_TagY_Bool(double y, Vector4 col, byte round);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_TagY_Str(double y, Vector4 col, byte* fmt);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot_Today(ImPlotTime* pOut);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern double ImPlot_TransformForward_Log10(double v, void* noname1);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern double ImPlot_TransformForward_Logit(double v, void* noname1);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern double ImPlot_TransformForward_SymLog(double v, void* noname1);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern double ImPlot_TransformInverse_Log10(double v, void* noname1);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern double ImPlot_TransformInverse_Logit(double v, void* noname1);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern double ImPlot_TransformInverse_SymLog(double v, void* noname1);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlotAlignmentData_Begin(ImPlotAlignmentData* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlotAlignmentData_destroy(ImPlotAlignmentData* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlotAlignmentData_End(ImPlotAlignmentData* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImPlotAlignmentData* ImPlotAlignmentData_ImPlotAlignmentData();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlotAlignmentData_Reset(ImPlotAlignmentData* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlotAlignmentData_Update(ImPlotAlignmentData* self, float* pad_a, float* pad_b, float* delta_a, float* delta_b);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlotAnnotation_destroy(ImPlotAnnotation* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImPlotAnnotation* ImPlotAnnotation_ImPlotAnnotation();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlotAnnotationCollection_Append(ImPlotAnnotationCollection* self, Vector2 pos, Vector2 off, uint bg, uint fg, byte clamp, byte* fmt);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlotAnnotationCollection_destroy(ImPlotAnnotationCollection* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte* ImPlotAnnotationCollection_GetText(ImPlotAnnotationCollection* self, int idx);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImPlotAnnotationCollection* ImPlotAnnotationCollection_ImPlotAnnotationCollection();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlotAnnotationCollection_Reset(ImPlotAnnotationCollection* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlotAxis_ApplyFit(ImPlotAxis* self, float padding);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImPlotAxis_CanInitFit(ImPlotAxis* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlotAxis_Constrain(ImPlotAxis* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlotAxis_destroy(ImPlotAxis* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlotAxis_ExtendFit(ImPlotAxis* self, double v);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlotAxis_ExtendFitWith(ImPlotAxis* self, ImPlotAxis* alt, double v, double v_alt);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern double ImPlotAxis_GetAspect(ImPlotAxis* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImPlotAxis_HasGridLines(ImPlotAxis* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImPlotAxis_HasLabel(ImPlotAxis* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImPlotAxis_HasMenus(ImPlotAxis* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImPlotAxis_HasTickLabels(ImPlotAxis* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImPlotAxis_HasTickMarks(ImPlotAxis* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImPlotAxis* ImPlotAxis_ImPlotAxis();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImPlotAxis_IsAutoFitting(ImPlotAxis* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImPlotAxis_IsForeground(ImPlotAxis* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImPlotAxis_IsInputLocked(ImPlotAxis* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImPlotAxis_IsInputLockedMax(ImPlotAxis* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImPlotAxis_IsInputLockedMin(ImPlotAxis* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImPlotAxis_IsInverted(ImPlotAxis* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImPlotAxis_IsLocked(ImPlotAxis* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImPlotAxis_IsLockedMax(ImPlotAxis* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImPlotAxis_IsLockedMin(ImPlotAxis* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImPlotAxis_IsOpposite(ImPlotAxis* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImPlotAxis_IsPanLocked(ImPlotAxis* self, byte increasing);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImPlotAxis_IsRangeLocked(ImPlotAxis* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern float ImPlotAxis_PixelSize(ImPlotAxis* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern double ImPlotAxis_PixelsToPlot(ImPlotAxis* self, float pix);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern float ImPlotAxis_PlotToPixels(ImPlotAxis* self, double plt);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlotAxis_PullLinks(ImPlotAxis* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlotAxis_PushLinks(ImPlotAxis* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlotAxis_Reset(ImPlotAxis* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlotAxis_SetAspect(ImPlotAxis* self, double unit_per_pix);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImPlotAxis_SetMax(ImPlotAxis* self, double _max, byte force);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImPlotAxis_SetMin(ImPlotAxis* self, double _min, byte force);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlotAxis_SetRange_double(ImPlotAxis* self, double v1, double v2);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlotAxis_SetRange_PlotRange(ImPlotAxis* self, ImPlotRange range);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlotAxis_UpdateTransformCache(ImPlotAxis* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImPlotAxis_WillRender(ImPlotAxis* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlotColormapData__AppendTable(ImPlotColormapData* self, ImPlotColormap cmap);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern int ImPlotColormapData_Append(ImPlotColormapData* self, byte* name, uint* keys, int count, byte qual);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlotColormapData_destroy(ImPlotColormapData* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImPlotColormap ImPlotColormapData_GetIndex(ImPlotColormapData* self, byte* name);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern uint ImPlotColormapData_GetKeyColor(ImPlotColormapData* self, ImPlotColormap cmap, int idx);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern int ImPlotColormapData_GetKeyCount(ImPlotColormapData* self, ImPlotColormap cmap);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern uint* ImPlotColormapData_GetKeys(ImPlotColormapData* self, ImPlotColormap cmap);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte* ImPlotColormapData_GetName(ImPlotColormapData* self, ImPlotColormap cmap);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern uint* ImPlotColormapData_GetTable(ImPlotColormapData* self, ImPlotColormap cmap);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern uint ImPlotColormapData_GetTableColor(ImPlotColormapData* self, ImPlotColormap cmap, int idx);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern int ImPlotColormapData_GetTableSize(ImPlotColormapData* self, ImPlotColormap cmap);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImPlotColormapData* ImPlotColormapData_ImPlotColormapData();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImPlotColormapData_IsQual(ImPlotColormapData* self, ImPlotColormap cmap);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern uint ImPlotColormapData_LerpTable(ImPlotColormapData* self, ImPlotColormap cmap, float t);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlotColormapData_RebuildTables(ImPlotColormapData* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlotColormapData_SetKeyColor(ImPlotColormapData* self, ImPlotColormap cmap, int idx, uint value);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlotDateTimeSpec_destroy(ImPlotDateTimeSpec* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImPlotDateTimeSpec* ImPlotDateTimeSpec_ImPlotDateTimeSpec_Nil();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImPlotDateTimeSpec* ImPlotDateTimeSpec_ImPlotDateTimeSpec_PlotDateFmt(ImPlotDateFmt date_fmt, ImPlotTimeFmt time_fmt, byte use_24_hr_clk, byte use_iso_8601);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlotInputMap_destroy(ImPlotInputMap* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImPlotInputMap* ImPlotInputMap_ImPlotInputMap();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlotItem_destroy(ImPlotItem* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImPlotItem* ImPlotItem_ImPlotItem();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlotItemGroup_destroy(ImPlotItemGroup* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImPlotItem* ImPlotItemGroup_GetItem_ID(ImPlotItemGroup* self, uint id);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImPlotItem* ImPlotItemGroup_GetItem_Str(ImPlotItemGroup* self, byte* label_id);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImPlotItem* ImPlotItemGroup_GetItemByIndex(ImPlotItemGroup* self, int i);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern int ImPlotItemGroup_GetItemCount(ImPlotItemGroup* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern uint ImPlotItemGroup_GetItemID(ImPlotItemGroup* self, byte* label_id);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern int ImPlotItemGroup_GetItemIndex(ImPlotItemGroup* self, ImPlotItem* item);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern int ImPlotItemGroup_GetLegendCount(ImPlotItemGroup* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImPlotItem* ImPlotItemGroup_GetLegendItem(ImPlotItemGroup* self, int i);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte* ImPlotItemGroup_GetLegendLabel(ImPlotItemGroup* self, int i);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImPlotItem* ImPlotItemGroup_GetOrAddItem(ImPlotItemGroup* self, uint id);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImPlotItemGroup* ImPlotItemGroup_ImPlotItemGroup();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlotItemGroup_Reset(ImPlotItemGroup* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlotLegend_destroy(ImPlotLegend* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImPlotLegend* ImPlotLegend_ImPlotLegend();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlotLegend_Reset(ImPlotLegend* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlotNextItemData_destroy(ImPlotNextItemData* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImPlotNextItemData* ImPlotNextItemData_ImPlotNextItemData();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlotNextItemData_Reset(ImPlotNextItemData* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlotNextPlotData_destroy(ImPlotNextPlotData* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImPlotNextPlotData* ImPlotNextPlotData_ImPlotNextPlotData();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlotNextPlotData_Reset(ImPlotNextPlotData* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlotPlot_ClearTextBuffer(ImPlotPlot* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlotPlot_destroy(ImPlotPlot* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern int ImPlotPlot_EnabledAxesX(ImPlotPlot* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern int ImPlotPlot_EnabledAxesY(ImPlotPlot* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte* ImPlotPlot_GetAxisLabel(ImPlotPlot* self, ImPlotAxis axis);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte* ImPlotPlot_GetTitle(ImPlotPlot* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImPlotPlot_HasTitle(ImPlotPlot* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImPlotPlot* ImPlotPlot_ImPlotPlot();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImPlotPlot_IsInputLocked(ImPlotPlot* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlotPlot_SetAxisLabel(ImPlotPlot* self, ImPlotAxis* axis, byte* label);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlotPlot_SetTitle(ImPlotPlot* self, byte* title);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImPlotAxis* ImPlotPlot_XAxis_Nil(ImPlotPlot* self, int i);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImPlotAxis* ImPlotPlot_XAxis__const(ImPlotPlot* self, int i);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImPlotAxis* ImPlotPlot_YAxis_Nil(ImPlotPlot* self, int i);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImPlotAxis* ImPlotPlot_YAxis__const(ImPlotPlot* self, int i);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlotPoint_destroy(ImPlotPoint* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImPlotPoint* ImPlotPoint_ImPlotPoint_Nil();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImPlotPoint* ImPlotPoint_ImPlotPoint_double(double _x, double _y);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImPlotPoint* ImPlotPoint_ImPlotPoint_Vec2(Vector2 p);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlotPointError_destroy(ImPlotPointError* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImPlotPointError* ImPlotPointError_ImPlotPointError(double x, double y, double neg, double pos);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern double ImPlotRange_Clamp(ImPlotRange* self, double value);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImPlotRange_Contains(ImPlotRange* self, double value);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlotRange_destroy(ImPlotRange* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImPlotRange* ImPlotRange_ImPlotRange_Nil();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImPlotRange* ImPlotRange_ImPlotRange_double(double _min, double _max);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern double ImPlotRange_Size(ImPlotRange* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlotRect_Clamp_PlotPoInt(ImPlotPoint* pOut, ImPlotRect* self, ImPlotPoint p);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlotRect_Clamp_double(ImPlotPoint* pOut, ImPlotRect* self, double x, double y);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImPlotRect_Contains_PlotPoInt(ImPlotRect* self, ImPlotPoint p);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImPlotRect_Contains_double(ImPlotRect* self, double x, double y);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlotRect_destroy(ImPlotRect* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImPlotRect* ImPlotRect_ImPlotRect_Nil();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImPlotRect* ImPlotRect_ImPlotRect_double(double x_min, double x_max, double y_min, double y_max);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlotRect_Max(ImPlotPoint* pOut, ImPlotRect* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlotRect_Min(ImPlotPoint* pOut, ImPlotRect* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlotRect_Size(ImPlotPoint* pOut, ImPlotRect* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlotStyle_destroy(ImPlotStyle* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImPlotStyle* ImPlotStyle_ImPlotStyle();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlotSubplot_destroy(ImPlotSubplot* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImPlotSubplot* ImPlotSubplot_ImPlotSubplot();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlotTagCollection_Append(ImPlotTagCollection* self, ImAxis axis, double value, uint bg, uint fg, byte* fmt);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlotTagCollection_destroy(ImPlotTagCollection* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte* ImPlotTagCollection_GetText(ImPlotTagCollection* self, int idx);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImPlotTagCollection* ImPlotTagCollection_ImPlotTagCollection();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlotTagCollection_Reset(ImPlotTagCollection* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlotTick_destroy(ImPlotTick* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImPlotTick* ImPlotTick_ImPlotTick(double value, byte major, int level, byte show_label);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImPlotTick* ImPlotTicker_AddTick_doubleStr(ImPlotTicker* self, double value, byte major, int level, byte show_label, byte* label);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImPlotTick* ImPlotTicker_AddTick_doublePlotFormatter(ImPlotTicker* self, double value, byte major, int level, byte show_label, IntPtr formatter, void* data);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImPlotTick* ImPlotTicker_AddTick_PlotTick(ImPlotTicker* self, ImPlotTick tick);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlotTicker_destroy(ImPlotTicker* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte* ImPlotTicker_GetText_Int(ImPlotTicker* self, int idx);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte* ImPlotTicker_GetText_PlotTick(ImPlotTicker* self, ImPlotTick tick);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImPlotTicker* ImPlotTicker_ImPlotTicker();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlotTicker_OverrideSizeLate(ImPlotTicker* self, Vector2 size);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlotTicker_Reset(ImPlotTicker* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern int ImPlotTicker_TickCount(ImPlotTicker* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlotTime_destroy(ImPlotTime* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlotTime_FromDouble(ImPlotTime* pOut, double t);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImPlotTime* ImPlotTime_ImPlotTime_Nil();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImPlotTime* ImPlotTime_ImPlotTime_time_t(ulong s, int us);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlotTime_RollOver(ImPlotTime* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern double ImPlotTime_ToDouble(ImPlotTime* self);
    }
}
