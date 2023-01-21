using System;

namespace SolidO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var publisher = new TwitterPublisher();
            var newAagency = new NewsAgency("This is a new message", publisher);
            newAagency.PublicNewMessage();
        }
    }
}
