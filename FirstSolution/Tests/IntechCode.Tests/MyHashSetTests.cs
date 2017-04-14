using FluentAssertions;
using IntechCode.IntechCollection;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace IntechCode.Tests
{
    [TestFixture]
    public class MyHashSetTests
    {
        [Fact]
        [Test]
        public void add_an_element_to_our_hashset()
        {
            MyHashSet<string> mhs = new MyHashSet<string>();
            mhs.Add( "Item1" );
            mhs.Count.Should().Be( 1 );
        }
    }
}
