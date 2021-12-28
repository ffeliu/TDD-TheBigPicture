namespace FizzBuzz.Library
{
    public class FizzBuzzService
    {
        public string Print(int n)
        {
            if(IsDisivibleForFive(n) && IsDisivibleForThree(n))
            {
                return "FizzBuzz";
            }
            else if(IsDisivibleForFive(n))
            {
                return "Buzz";
            }
            else if(IsDisivibleForThree(n))
            {
                return "Fizz";
            }
            else
            {
                return n.ToString();
            }
            
        }

        private bool IsDisivibleForThree(int n)
        {
            return n % 3 == 0;
        }

        private bool IsDisivibleForFive(int n)
        {
            return n % 5 == 0;
        }        
    }
}