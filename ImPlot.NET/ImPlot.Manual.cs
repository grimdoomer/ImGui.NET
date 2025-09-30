using System;
using System.Collections.Generic;
using System.Text;

namespace ImPlotNET
{
    public unsafe delegate int ImPlotFormatter(double value, char* buff, int size, IntPtr user_data);

    public delegate ImPlotPoint ImPlotGetter(int idx, IntPtr user_data);

    public delegate double ImPlotTransform(double value, IntPtr user_data);

    public unsafe delegate void ImPlotLocator(ImPlotTicker* ticker, ImPlotRange* range, float pixels, bool vertical, ImPlotFormatter formatter, IntPtr formatter_data);

    public partial class ImPlot
    {
    }
}
