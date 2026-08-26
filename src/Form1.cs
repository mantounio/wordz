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


    // helpers
    private void change_picbox_btn_picture(Control control, Image img) => ((PictureBox)control).Image = img;



    // form events
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

    private void btn_close_MouseEnter(object sender, EventArgs e) => change_picbox_btn_picture(btn_close, Properties.Resources.hov_red_24);
    private void btn_close_MouseLeave(object sender, EventArgs e) => change_picbox_btn_picture(btn_close, Properties.Resources.red_24);
    private void btn_minimize_MouseEnter(object sender, EventArgs e) => change_picbox_btn_picture(btn_minimize, Properties.Resources.hov_yellow_24);
    private void btn_minimize_MouseLeave(object sender, EventArgs e) => change_picbox_btn_picture(btn_minimize, Properties.Resources.yellow_24);
    private void btn_close_Click(object sender, EventArgs e) => Application.Exit();
    private void btn_minimize_Click(object sender, EventArgs e) => this.WindowState = FormWindowState.Minimized;

    
}
