﻿using AspnetCoreSPATemplate.Common;
using AspnetCoreSPATemplate.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspnetCoreSPATemplate.Repositories
{
    public class TestContactRepository : IContactRepository
    {
        public async Task<IList<Contact>> GetAllContacts()
        {
            return await Task.Run(() =>
            {
                // Load test data
                return LoadContacts();
            });
        }

        public async Task<IList<Contact>> GetContacts(string filter)
        {
            return await Task.Run(() =>
            {
                // Load test data
                return LoadContacts()
                        .Where(c => c.First.Contains(filter)
                                 || c.Last.Contains(filter)
                                 || c.Email.Contains(filter)
                                 || c.Phone1.Contains(filter))
                        .ToList();
            });
        }

        private List<Contact> LoadContacts()
        {
            return new List<Contact>
            {
                new Contact
                {
                    Id = 1,
                    First = "MF1",
                    Last = "ML1",
                    Email = "ME1@abc.com",
                    Phone1 = "900000001"
                },
                new Contact
                {
                    Id = 2,
                    First = "MF2",
                    Last = "ML2",
                    Email = "ME2@abc.com",
                    Phone1 = "900000002"
                },
                new Contact
                {
                    Id = 3,
                    First = "MF3",
                    Last = "ML3",
                    Email = "ME3@abc.com",
                    Phone1 = "900000003"
                },
                new Contact
                {
                    Id = 4,
                    First = "MF4",
                    Last = "ML4",
                    Email = "ME4@abc.com",
                    Phone1 = "900000004"
                },
                new Contact
                {
                    Id = 5,
                    First = "MF5",
                    Last = "ML5",
                    Email = "ME5@abc.com",
                    Phone1 = "900000005"
                },
                new Contact
                {
                    Id = 6,
                    First = "MF6",
                    Last = "ML6",
                    Email = "ME6@abc.com",
                    Phone1 = "900000006"
                },
                new Contact
                {
                    Id = 7,
                    First = "MF7",
                    Last = "ML7",
                    Email = "ME7@abc.com",
                    Phone1 = "900000007"
                },
                new Contact
                {
                    Id = 8,
                    First = "MF8",
                    Last = "ML8",
                    Email = "ME8@abc.com",
                    Phone1 = "900000008"
                },
                new Contact
                {
                    Id = 9,
                    First = "MF9",
                    Last = "ML9",
                    Email = "ME9@abc.com",
                    Phone1 = "900000009"
                },
                new Contact
                {
                    Id = 10,
                    First = "MF10",
                    Last = "ML10",
                    Email = "ME10@abc.com",
                    Phone1 = "9000000010"
                },
                new Contact
                {
                    Id = 11,
                    First = "MF11",
                    Last = "ML11",
                    Email = "ME3@abc.com",
                    Phone1 = "9000000011"
                }
            };
        }
    }
}
