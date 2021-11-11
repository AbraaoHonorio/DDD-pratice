using System;
using Xunit;

namespace AH.Pratice.Domain.Test
{
    public class People : Entity<Guid>
    {
        public People(Guid guid)
        {
            Id = guid;
        }
    }

    public class EntityTest
    {
        [Fact]
        public void ShoulEqual()
        {
            var p = new People(Guid.NewGuid());
            var pp = new People(p.Id);
            Assert.Equal(p,pp);
        }

        [Fact]
        public void ShouldNotEqual()
        {
            var p = new People(Guid.NewGuid());
            var pp = new People(Guid.NewGuid());
            Assert.NotEqual(p, pp);
        }
    }
}
