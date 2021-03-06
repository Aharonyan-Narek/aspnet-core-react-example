﻿using System.Threading.Tasks;

namespace AspnetCoreSPATemplate.Utils
{
    public interface IFileHandler
    {
        Task<string> LoadFileAsync();

        Task AddLineAsync(string value);
    }
}