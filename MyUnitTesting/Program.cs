namespace TestingUnit
{
   public class Program
    {
        public string  PrintHello(){
           return("Hello World");
        }
        public double ToCelcius(double farenheit){
            return (32*farenheit-32)*5/9;
        }
        static void Main(String[] args){
            Console.WriteLine("Hello! World");
        }
    }
}