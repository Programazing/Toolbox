using FluentAssertions;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Tests.EnumTests
{
    [TestFixture]
    public class GetEnumFromNameTests
    {
        [Test]
        public void GetEnumFromName_WillReturnAnEnum_WhenGiven_AnExistingKey()
        {
            var sut = Enums.GetEnumFromName<Colors>("Blue");
            
            sut.Should().Be(Colors.Blue);
        }

        [Test]
        public void GetEnumFromName_WillThrowArgumentException_WhenGiven_AnNonExistingKey()
        {
            Action sut = () => Enums.GetEnumFromName<Colors>("car");

            sut.Should().Throw<ArgumentException>();
        }

        [Test]
        public void GetEnumFromName_WillThrowArgumentException_WhenGiven_AnExistingKey_WithIncorrectCasing()
        {
            Action sut = () => Enums.GetEnumFromName<Colors>("blue");

            sut.Should().Throw<ArgumentException>();
        }

        [Test]
        public void GetEnumFromName_WillReturnAnEnum_WhenGiven_AnExistingKey_WithIncorrectCasing()
        {
            var sut = Enums.GetEnumFromName<Colors>("blue", ignoreCase: true);

            sut.Should().Be(Colors.Blue);
        }

        private enum Colors
        {
            Blue = 1
        }
    }
}
