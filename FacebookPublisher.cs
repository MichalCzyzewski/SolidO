using System;
using System.Collections.Generic;
using System.Text;

namespace SolidO
{
    internal class FacebookPublisher : IPublisher
    {
        public void Publish(string text)
        {
            Console.WriteLine($"Publishing text : \"{text}\" on Facebook");
        }
    }
}
