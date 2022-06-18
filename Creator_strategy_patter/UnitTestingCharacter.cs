using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace Creator_strategy_patter
{
    [TestClass]
    public class TestCreatorStrategyPattern
    {
        [TestMethod]
        public void Test_Melee_Attack()
        {
            // 1. Arrange
            var attacker = new Character(new MeleeAttackStrategy());
            var victim = new Character(new MeleeAttackStrategy());

            // 2. Act
            attacker.Attack(victim);
            var returnedHealthValue = victim.ShowCurrentHealth();

            // 3. Assert
            Assert.AreEqual(85, returnedHealthValue);
        }

        [TestMethod]
        public void Test_Magic_Attack()
        {
            // 1. Arrange
            var attacker = new Character(new MagicAttackStrategy());
            var victim = new Character(new MeleeAttackStrategy());

            // 2. Act
            attacker.Attack(victim);
            var returnedHealthValue = victim.ShowCurrentHealth();

            // 3. Assert
            Assert.AreEqual(50, returnedHealthValue);
        }

        [TestMethod]
        public void Test_Ranged_Attack()
        {
            // 1. Arrange
            var attacker = new Character(new RangeAttackStrategy());
            var victim = new Character(new MeleeAttackStrategy());

            // 2. Act
            attacker.Attack(victim);
            var returnedHealthValue = victim.ShowCurrentHealth();

            // 3. Assert
            Assert.AreEqual(70, returnedHealthValue);
        }


    }

}
