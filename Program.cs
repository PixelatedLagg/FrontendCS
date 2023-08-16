using FrontendCS;

class Program
{
    public static void Main()
    {

    }
}

[DocumentName("index.html")]
class TestPage : BaseDocument
{
    public TestPage() : base()
    {
        OnLoad += Loaded;
    }

    public void Loaded()
    {

    }
}