public class MyClass
{
    private int val = 1;
    public int InstRun()
    {
        return val;
    }

    public static int Run()
    {
        return 1;
    }
}

public class Client
{
        public void Test()
        {
            MyClass myClass = new MyClass();
            int i = myClass.InstRun();
        }

        public static void Testtwo()
        {
            int e = MyClass.Run();
        }
}

