

public static class Util 
{
    
    private static Stack<UserControl> WINDPTR = new();

    // methods
    public static void Push_window(UserControl usercontrol) => WINDPTR.Push(usercontrol);
    public static UserControl Get_window() => WINDPTR.Peek();
    public static UserControl Page_BackWard() => WINDPTR.Pop();


}
