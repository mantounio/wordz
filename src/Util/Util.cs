using wordz.src.add_word;
using wordz.src.dbContext;
using wordz.src.Error_page;
using wordz.src.Main_Page;
using static Page_OPT;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

public enum Page_OPT
{
    MAINWINDOW,
    TAKEQUIZ,
    ADDWORD,
    WORDSLIST,
    SETTING,
    ERROR,
}

public static class Util
{
    private static Stack<UserControl> WINDPTR = new();
    public static Control control_container { get; set; }
    public static string current_dir = Environment.CurrentDirectory;
    public static string table_name = "word.db";
    public static string fullpath = Path.Combine(current_dir, table_name);
    public static db db = new();
    public static bool isErrorPageVisible = false;
    public static Control[] arr_controls;


    // methods
    public static void Push_window(UserControl usercontrol) => WINDPTR.Push(usercontrol);
    public static UserControl Get_window() => WINDPTR.Peek();
    private static bool IS_WINDPTR_EMPTY()
    {
        if (WINDPTR.Count() == 0)
        {
            return true;
        }
        return false;
    }
    public static void Page_BackWard()
    {
        WINDPTR.Pop();
        if (!IS_WINDPTR_EMPTY())
        {
            Get_window().Show();
        }
    }
    public static void CreatePage(Page_OPT option,Control container)
    {
        if (!IS_WINDPTR_EMPTY())
        {
            Get_window().Hide();
        }
        switch (option)
        {
            case MAINWINDOW:
                main_page main_page= new()
                {
                    Dock = DockStyle.Fill,
                    Name = "mainpage"
                };
                Push_window(main_page);
                main_page.SendToBack();
                container.Controls.Add(main_page);
                break;
            case ADDWORD:
                Add_word add_word = new()
                {
                    Dock = DockStyle.Fill,
                    Name = "addpage"
                };
                Push_window(add_word);
                add_word.SendToBack();
                container.Controls.Add(add_word);
                break;
            case ERROR:
                ErrorPage error_page = new()
                {
                    Dock = DockStyle.Fill,
                    Name = "errorpage"
                };
                Push_window(error_page);
                error_page.SendToBack();
                container.Controls.Add(error_page);
                break;
        }
    }
    public static bool isTableCreated()
    {
        return File.Exists(fullpath);
    }

    public static void change_colors(Color color, params Control[] controls)
    {
        foreach (var item in controls)
        {
            item.BackColor = color;
        }
    }

}

