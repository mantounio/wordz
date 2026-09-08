using wordz.src.add_word;
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
                main_page main_page = new()
                {
                    Dock = DockStyle.Fill,
                    Name = "mainpage"
                };
                main_page.SendToBack();
                container.Controls.Add(main_page);
                Push_window(main_page);
                break;
            case ADDWORD:
                Add_word add_word = new()
                {
                    Dock = DockStyle.Fill,
                    Name = "addword"
                };
                add_word.SendToBack();
                container.Controls.Add(add_word);
                Push_window(add_word);

                break;
        }
    }
}

