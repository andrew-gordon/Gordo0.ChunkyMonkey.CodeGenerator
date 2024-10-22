﻿using Gord0.ChunkMonkey.Attributes;
using System.Collections.ObjectModel;

namespace Gord0.ChunkyMonkey.CodeGenerator.UnitTests.TestClasses.WithChunkMemberAttributeOnProperty
{
    public partial class ChunkMember_ClassWithReadOnlyCollectionProperty
    {
        public string? Name { get; set; }

        public int? Age { get; set; }

        [ChunkMember]
        public ReadOnlyCollection<int>? Numbers { get; set; }
    }
}