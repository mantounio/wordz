using System.Runtime.InteropServices;
using wordz.src.Main_Page;
using static Page_OPT;


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
    private void change_colors(Color color, params Control[] controls)
    {
        foreach(var item in controls)
        {
            item.BackColor = color;
        }
    }
    public Control GetExistingControl(string name)
    {
        return Controls[name];
    }

    // form events
    public Form1()
    {
        InitializeComponent();
        Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 50, 50));
        Util.control_container = pnl_container;
    }

    private void btn_close_MouseEnter(object sender, EventArgs e) => change_picbox_btn_picture(btn_close, Properties.Resources.hov_red_24);
    private void btn_close_MouseLeave(object sender, EventArgs e) => change_picbox_btn_picture(btn_close, Properties.Resources.red_24);
    private void btn_minimize_MouseEnter(object sender, EventArgs e) => change_picbox_btn_picture(btn_minimize, Properties.Resources.hov_yellow_24);
    private void btn_minimize_MouseLeave(object sender, EventArgs e) => change_picbox_btn_picture(btn_minimize, Properties.Resources.yellow_24);
    private void btn_close_Click(object sender, EventArgs e) => Application.Exit();
    private void btn_minimize_Click(object sender, EventArgs e) => this.WindowState = FormWindowState.Minimized;

    private void Form1_Load(object sender, EventArgs e)
    {
        Util.control_container = pnl_container;
        Util.CreatePage(MAINWINDOW, pnl_container);
    }

    private void pnl_mov_window_MouseDown(object sender, MouseEventArgs e)
    {
        MOV_WIND_LOCATION = true;
        COORX = e.X;
        COORY = e.Y;
        pnl_move_window.BackColor = Color.FromArgb(113, 121, 126); // click to change the color 
        change_colors(Color.FromArgb(113, 121, 126), btn_close, btn_minimize);
        
    }

    private void pnl_mov_window_MouseUp(object sender, MouseEventArgs e) 
    {
        MOV_WIND_LOCATION = false; 
        pnl_move_window.BackColor = Color.FromArgb(211, 211, 211);
        change_colors(Color.FromArgb(211, 211, 211), btn_close, btn_minimize);
    }

    private void pnl_mov_window_MouseMove(object sender, MouseEventArgs e)
    {
        if (MOV_WIND_LOCATION)
            SetDesktopLocation(MousePosition.X - COORX, MousePosition.Y - COORY);
    }

    private void pnl_mov_window_MouseEnter(object sender, EventArgs e)
    {
        pnl_move_window.BackColor = Color.FromArgb(211, 211, 211);
        change_colors(Color.FromArgb(211, 211, 211), btn_close, btn_minimize);
    }

    private void pnl_mov_window_MouseLeave(object sender, EventArgs e)
    {
        pnl_move_window.BackColor = Color.FromName("control");
        change_colors(Color.FromName("control"), btn_close, btn_minimize);
    }
}

// group color change in buttons fix the hovering button color to prevent repetitive code
// consider : changing the color of clicking pnl_move_window
// consider : chaning the if it is essential to have a hover color for mouse entering pnl_move_window or just to have a change of color when 'mouse downing' the pnl_move_window