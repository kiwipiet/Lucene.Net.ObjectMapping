﻿using System;

namespace Lucene.Net.ObjectMapping.Tests.Model
{
    public sealed class TestObject
    {
        public Guid Guid { get; set; }
        public int Number { get; set; }
        public bool Boolean { get; set; }
        public float Float { get; set; }
        public DateTime TimestampLocal { get; set; }
        public DateTime TimestampUtc { get; set; }
        public object Null { get; set; }
        public string String { get; set; }
        public TimeSpan TimeSpan { get; set; }
        public Uri Uri { get; set; }
    }
}