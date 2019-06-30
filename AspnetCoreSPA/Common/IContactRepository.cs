﻿using AspnetCoreSPATemplate.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspnetCoreSPATemplate.Common
{
    public interface IContactRepository
    {
        /// <summary>
        /// Get all contacts without filtering
        /// </summary>
        /// <returns></returns>
        Task<IList<Contact>> GetAllContacts();

        /// <summary>
        /// Gets list of contacts based on keyword typed in search bar
        /// </summary>
        /// <param name="filter">Search keyword</param>
        /// <returns></returns>
        Task<IList<Contact>> GetContacts(string filter);
    }
}
