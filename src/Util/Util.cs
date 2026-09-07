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
    public static UserControl Page_BackWard() => WINDPTR.Pop();

    /// <summary>
    /// 
    /// </summary>
    /// <param name="op">page option</param>
    /// <param name="container">container indicates which control(form | usercontrol)will contain the page</param>
    /*public static void CreatePage(Page_OPT op, Control container)
    {
        MessageBox.Show("shows the page");
        

        UserControl page = null;
        switch (op)
        {
            case TAKEQUIZ:
                // add TAKE QUIZ WINDOW LATER
                break;
            case ADDWORD:
                page = new Add_word()
                {
                    Name = "addword",
                    Dock = DockStyle.Fill,
                };

                Push_window(page);
                MessageBox.Show("Test");
                break;
            case WORDSLIST:
                // add WORDS LIST WINDOW LATER:
                break;
            case SETTING:
                // add SETTING WINDOW LATER
                break;
        }
      


        container.Controls.Add(page);
    }*/
    public static void CreatePage(Page_OPT option,Control container)
    {
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
                break;

        }
    }
}

