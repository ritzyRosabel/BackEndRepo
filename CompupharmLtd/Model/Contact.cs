﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CompupharmLtd.Model
{
    public class Contact
    {
        public string Name { get; set; }
        public string Message { get; set; }
        public string ticketID { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; } 
        public string Response { get; set; } 
        public string Responder { get; set; } 
        public DateTime DateCreated { get; set; } 
    }
    public class ContactRequest
    {
        public string Name { get; set; }
        public string Message { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
    }
    public class ContactResponse
    {
        public string Name { get; set; }
        public string Message { get; set; }
        public string MessageID { get; set; }
        }
}
