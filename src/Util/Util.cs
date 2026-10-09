using wordz.src;
using wordz.src.add_word;
using wordz.src.dbContext;
using wordz.src.Error_page;
using wordz.src.Main_Page;
using wordz.src.Repository;
using wordz.src.words;
using wordz.src.WordService;
using wordz.src.WordsList;
using static Page_OPT;

public enum Page_OPT
{
    MAINWINDOW,
    TAKEQUIZ,
    ADDWORD,
    WORDSLIST,
    SETTING,
    CHOOSE_LANG,
    ERROR,
}

public static class Util
{
    private static Stack<UserControl> WINDPTR = new();
    public static Control control_container { get; set; }
    public static string current_dir = Environment.CurrentDirectory;
    public static string table_name = "word.db";
    public static string fullpath = Path.Combine(current_dir, table_name);
    public static db db = new(); // change it later to use dbcontextfactory for the optimizing the lifetime
    public static bool isErrorPageVisible = false;
    public static Control[] arr_controls;
    public static Label error_lbl;
    public static Label redirection_lbl;
    public static bool show_label;
    public static Queue<Word> word_queue = new();

    #region remove_this_later(refactor this with dbcontextfacotry) later

    internal static IRepository repo = new WordsRepository(db);
    public static WordService service = new(repo);

    #endregion

   /* static Util() put the initilizers in the static ctor
    {

    }*/
    
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
            case WORDSLIST:
                page = new WordsList()
                {
                    Dock = DockStyle.Fill,
                    Name = "wordslist"
                };
                break;
            case CHOOSE_LANG:
                page = new ChooseLanguage()
                {
                    Dock = DockStyle.Fill,
                    Name = "chooselanguage"
                };
                break;
            case TAKEQUIZ:
                page = new TakeQuizPage()
                {
                    Dock = DockStyle.Fill,
                    Name = "takequiz"
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
        foreach(var item in controls)
        {
            item.BackColor = color;
        }
    }
    public static Control get_control(string item_name) => arr_controls.Where(c => c.Name == item_name).First();

    public static void set_error(string message) => error_lbl.Text = message;

    public static void show_error(string msg,bool show_redirection_lbl)
    {
        foreach (var control in arr_controls)
        {
            control.BackColor = Color.FromArgb(230, 0, 0);
        }

        isErrorPageVisible = true;

        CreatePage(ERROR, control_container);
       
        set_error(msg);
        redirection_lbl.Visible = show_redirection_lbl;
    }

    internal static void gen_quiz_queue(WordService service,string lang)
    {
        for (int i = 0; i < 10; ++i)
        {
            word_queue.Enqueue(get_random_entity(service,lang));
        }
    }
    internal static Word get_random_entity(WordService service,string lang)
    {
        Random random = new();

        int rand_id = random.Next(1, service.count());

        MessageBox.Show(rand_id.ToString());

        return db.words.Where(i => i.Id == rand_id).First(); //service.GetWordById(rand_id);
    }

    internal static void next_word(WordService service,string lang)
    {
        word_queue.Dequeue();

        if (word_queue.Count == 0)
        {
            MessageBox.Show("Test");
            gen_quiz_queue(service, lang);
        } 
    }
}

