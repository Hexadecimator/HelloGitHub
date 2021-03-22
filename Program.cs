using System;
using GitHubNamespace1;

namespace HelloGitHub
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello GitHub!");

            GitHubClass1 GHClass1 = new GitHubClass1();

            GHClass1.TestClass1();
        }
    }
}
