namespace IncludesSpace;
public delegate void Func(string text); 
public class MyClass 
{
    public void Space(string text) 
    {
        for(int i = 0; i < text.Length; i++) 
        {
            Console.Write(text[i]);
            if (i < text.Length - 1)
                Console.Write('_');
        }
        Console.WriteLine();
    }
    public void Reverse(string text) 
    {
        for(int i = text.Length - 1; i >= 0; i--) 
            Console.Write(text[i]);
    }
}
public class Run 
{
    public void runFunc(Func func, string text) 
    {
        func(text);
    }
}