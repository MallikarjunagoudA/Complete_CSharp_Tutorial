

namespace CsharpIntro
{
    public class MethodHiding
    {
        public void show()
        {
            Console.WriteLine( " this is from parent method ");
        }
    }

    public class ChildClass : MethodHiding
    {
        public new void show()
        {
            Console.WriteLine(" this is from child method ");
        }
    }
}
