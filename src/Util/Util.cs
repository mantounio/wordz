using wordz.src.add_word;
using wordz.src.dbContext;
using wordz.src.Error_page;
using wordz.src.Main_Page;
using static Page_OPT;

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
    public static Label error_lbl;
    public static List<string> language_items // change this later to have languages and custom collection
    {
        get
        {
            return Enum.GetNames<Langs>().ToList();
        }
    }
    
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
    public static void WINDPTR_POP()
    {
        WINDPTR.Peek().Hide();
        WINDPTR.Pop();
    }

    public static void Page_BackWard()
    {
        WINDPTR_POP();
        if (!IS_WINDPTR_EMPTY())
        {
            Get_window().Show();
        }
    }
    public static void CreatePage(Page_OPT option,Control container)
    {
        // refactor this code later
        if (!IS_WINDPTR_EMPTY())
        {
            Get_window().Hide();
        }

        UserControl page = null;

        switch (option)
        {
            case MAINWINDOW:
                page = new main_page()
                {
                    Dock = DockStyle.Fill,
                    Name = "mainpage"
                };
                break;
            case ADDWORD:
                page = new Add_word()
                {
                    Dock = DockStyle.Fill,
                    Name = "addpage"
                };
                break;
            case ERROR:
                page = new ErrorPage()
                {
                    Dock = DockStyle.Fill,
                    Name = "errorpage"
                };
                break;
        }
        Push_window(page);
        page.SendToBack();
        container.Controls.Add(page);
    }
    public static bool isTableCreated() => File.Exists(fullpath);

    public static void change_colors(Color color, params Control[] controls)
    {
        foreach (var item in controls)
        {
            item.BackColor = color;
        }
    }

    public static Control get_control(string item_name) => arr_controls.Where(c => c.Name == item_name).First();

    public static void set_error(string message) => error_lbl.Text = message;
}

