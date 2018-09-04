using System;
namespace AdapterPattern.Adaptee
{
    // Does some shit
    public class AdapteeClass
    {
        public AdapteeClass()
        {
        }

        public void SpecificRequest()
        {
            Console.WriteLine("Adaptee: SpecificRequest() of AdapteeClass called!");
        }

        // Will be changed to (int n, string s) in a future release.
        public void SpecificRequestWithArgs(string s, int n)
        {
            Console.WriteLine(String.Format(
                "Adaptee: SpecificRequestWithArgs({0},{1}) of AdapteeClass called!",s,n));
        }
    }
}
