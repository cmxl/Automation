﻿using McMaster.Extensions.CommandLineUtils;
using System.Threading.Tasks;

namespace NooBIT.ProjectInitializer
{
    public class Program
    {
        public static async Task<int> Main(string[] args)
            => await CommandLineApplication.ExecuteAsync<Initialize>(args);
    }
}
