using Models;
using NUnit.Framework;

namespace Tests.Models
{
    [TestFixture]
    public class HealthAndDamage_Tests
    {
        [Test]
        public void Apply_Damage_TO_Health()
        {
            Health health = new Health(100);
            Damage damage = new Damage(50);
            
            Assert.True(health.TryApplyDamage(damage));
            Assert.True(health.Value == 50);
        }
    }
}
