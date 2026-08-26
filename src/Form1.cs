using System.Runtime.InteropServices;

namespace wordz.src;

public partial class Form1 : Form
{
    [DllImport("gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
    static extern IntPtr CreateRoundRectRgn(int x1, int y1, int x2, int y2,
    int cx, int cy);

    int COORX;
    int COORY;
    bool MOV_WIND_LOCATION;
    
    
    public Form1()
    {
        InitializeComponent();
        Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 50, 50));
    }

    private void Form1_MouseMove(object sender, MouseEventArgs e)
    {
        if (MOV_WIND_LOCATION)
            SetDesktopLocation(MousePosition.X - COORX, MousePosition.Y - COORY);
    }

    private void Form1_MouseUp(object sender, MouseEventArgs e)
    {
        MOV_WIND_LOCATION = false;
    }

    private void Form1_MouseDown(object sender, MouseEventArgs e)
    {
        MOV_WIND_LOCATION = true;
        COORX = e.X;
        COORY = e.Y;
    }
}
