using System.Runtime.InteropServices;

namespace wordz.src;

public partial class Form1 : Form
{
    [DllImport("gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
    static extern IntPtr CreateRoundRectRgn(int x1, int y1, int x2, int y2,
    int cx, int cy);

    int down_num = 0;
    int up_num = 0;

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
        label1.Text = $"x = {e.X} : y = {e.Y} of mouse coordination (mouse moving event)";

        if (MOV_WIND_LOCATION)
            SetDesktopLocation(MousePosition.X - COORX, MousePosition.Y - COORY);

    }

    private void Form1_MouseUp(object sender, MouseEventArgs e)
    {
        lbl_mouseUP_info.Text = $"mouse is upped (mouse UP event) | {up_num}";
        up_num++;

        MOV_WIND_LOCATION = false;
    }

    private void Form1_MouseDown(object sender, MouseEventArgs e)
    {
        MOV_WIND_LOCATION = true;
        COORX = e.X;
        COORY = e.Y;

        lbl_mouseDOWN_info.Text = $"mouse is down (mouse down event) | {down_num}";
        down_num++;
    }
}
