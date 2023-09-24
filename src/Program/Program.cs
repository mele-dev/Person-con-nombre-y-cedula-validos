using Library;

namespace Program;

class Program
{
    static void Main(string[] args)
    {
        Person john = new Person("John Doe", "1.234.567-2");
        Person jane = new Person("Jane Doe", "8.765.432-7");
        Person juan = new Person("Juan Tanca", "asdasf");
        john.IntroduceYourself();
        jane.IntroduceYourself();
        juan.IntroduceYourself();
    }
}
