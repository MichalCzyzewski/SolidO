﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SolidO
{
    internal class NewsAgency
    {

        private IPublisher _publisher;
        private String _newMessage;

        public NewsAgency(string message, IPublisher publisher)
        {
            _publisher = publisher;
            _newMessage = message;
            // kod zostal z komentarzem od nowa
            // jeszczce jeden komentarz
        }

        public void PublicNewMessage()
        {
            _publisher.Publish(_newMessage);
        }

    }
}
