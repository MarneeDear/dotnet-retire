﻿using System.Collections.Generic;

namespace dotnet_retire
{
    public class NugetReference
    {
        public NugetReference()
        {
            Dependencies = new List<NugetReference>();
        }
        public string Id { get; set; }
        public string Version { get; set; }

        public List<NugetReference> Dependencies { get; set; }

        public override string ToString()
        {
            return $"{Id}/{Version}";
        }
    }
}