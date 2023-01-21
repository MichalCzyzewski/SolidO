using System;
using System.Collections.Generic;
using System.Text;

namespace SolidO
{
    internal class EmailPublisher : IPublisher
    {
        public void Publish(string text)
        {
Console.WriteLine($"Publishing text : \"{text}\" via e-Email");        }
    }
}
