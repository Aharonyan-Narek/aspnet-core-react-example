﻿using AspnetCoreSPATemplate.Models;
using AspnetCoreSPATemplate.Services.Common;

namespace AspnetCoreSPATemplate.Services.Contacts
{
    public class ContactCreateResponse : ResponseBase
    {
        public ContactModel Contact { get; set; }
    }
}