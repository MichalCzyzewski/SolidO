using System;
using System.Collections.Generic;
using System.Text;

namespace SolidO
{
    internal class TwitterPublisher : IPublisher
    {
        public void Publish(string text)
        {
            Console.WriteLine($"Publishing text : \"{text}\" on Twitter");
        }
    }
}
