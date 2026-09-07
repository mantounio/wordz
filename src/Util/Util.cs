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
}

public static class Util
{
    private static Stack<UserControl> WINDPTR = new();
    public static Control control_container { get; set; }

    // methods
    public static void Push_window(UserControl usercontrol) => WINDPTR.Push(usercontrol);
    public static UserControl Get_window() => WINDPTR.Peek();
    public static void Page_BackWard()
    {
        WINDPTR.Pop();
        if (WINDPTR.Count() != 0)
        {
            Get_window().Show();
        }
    }
    public static void CreatePage(Page_OPT option,Control container)
    {
        /* if(container is Panel pnl)
         {
             foreach(Control controls in pnl.Controls)
             {
                 controls.Hide();
             }
             pnl.Controls["pnl_move_window"]!.Show(); // FIX!! :: why pnl_move_window is part of 'pnl_container's control!!!!!!!!
         }*/
        if(WINDPTR.Count() != 0)
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

