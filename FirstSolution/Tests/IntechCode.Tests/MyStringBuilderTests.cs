using System;
using FluentAssertions;
using NUnit.Framework;
using IntechCode.IntechCollection;
using Xunit;

namespace IntechCode.Tests
{
    [TestFixture]
    public class MyStringBuilderTests
    {
        [Fact]
        [Test]
        public void stringbuilder_is_just_an_array_of_chars()
        {
            MyStringBuilder msb = new MyStringBuilder(5);
            msb.Length.Should().Be(0);
            msb.Append('a');
            msb.Length.Should().Be(1);
            msb.Append('b');
            msb.Length.Should().Be(2);
            msb[0].Should().Be('a');
        }

        [Fact]
        [Test]
        public void stringbuilder_has_a_capacity()
        {
            MyStringBuilder msb = new MyStringBuilder(3);
            msb[0] = '8';
            msb[0].Should().Be('8');
            Action a1 = () => { msb[5] = 'm'; };
            Action a2 = () => { msb[-1] = 'h'; };
            a1.ShouldThrow<IndexOutOfRangeException>();
            a2.ShouldThrow<IndexOutOfRangeException>();
        }

        [Fact]
        [Test]
        public void can_append_a_string_to_our_stringbuilder()
        {
            MyStringBuilder msb = new MyStringBuilder(5);
            msb.Length.Should().Be(0);
            msb.Append("hello");
            msb.Length.Should().Be(5);
            string appenedStr = msb.ToString();
            appenedStr.Should().Be("hello");
        }

        [Fact]
        [Test]
        public void instanciate_our_stringbuilder_with_string()
        {
            MyStringBuilder msb = new MyStringBuilder("moto");
            msb.Length.Should().Be(4);
            string s = msb.ToString();
            s.Should().Be("moto");
        }

        [Fact]
        [Test]
        public void clear_our_little_stringbuilder()
        {
            MyStringBuilder msb = new MyStringBuilder("Programming!");
            msb.Length.Should().Be(12);
            string s = msb.ToString();
            s.Should().Be("Programming!");
            msb.Clear();
            msb.Length.Should().Be(0);
            s = msb.ToString();
            s.Should().Be(String.Empty);
        }
    }
}
