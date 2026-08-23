using System.Runtime.InteropServices;

namespace wordz.src;

public partial class Form1 : Form
{
    [DllImport("gdi32.dll", EntryPoint = "CreateRoundRectRgn"),]
    static extern IntPtr CreateRoundRectRgn(int x1, int y1, int x2, int y2,
    int cx, int cy);



    public Form1()
    {
        InitializeComponent();
        Region = Region.FromHrgn(CreateRoundRectRgn(0,0,Width,Height,50,50));
    }
}
