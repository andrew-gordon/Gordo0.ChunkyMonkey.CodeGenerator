﻿using Gord0.ChunkMonkey.Attributes;
using System.Collections.ObjectModel;

namespace Gord0.ChunkyMonkey.CodeGenerator.UnitTests.TestClasses.WithChunkAttributeOnClass
{
    [Chunk]
    public partial class Chunk_ClassWithCollectionProperty
    {
        public string? Name { get; set; }
        public int? Age { get; set; }
        public Collection<int>? Numbers { get; set; }
    }
}