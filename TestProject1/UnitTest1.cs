using System;
using Xunit;
using ATM;

namespace TestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void Prevent_Withdraw_More_Than_Balance()
        {
            decimal balance = ATM.ATM.BALANCE = 200;
            decimal input = 300;
            Assert.Equal(balance, ATM.ATM.Withdraw(input));
            ATM.ATM.BALANCE = 0;
        }

        [Fact]
        public void Prevent_Withdraw_Minus_Value()
        {
            decimal input = -300;
            Assert.Equal(ATM.ATM.BALANCE, ATM.ATM.Withdraw(input));
        }

        [Fact]
        public void Prevent_Deposit_Minus_Value()
        {
            decimal input = -300;
            Assert.Equal(ATM.ATM.BALANCE, ATM.ATM.Deposit(input));
        }

        [Fact]
        public void Prevent_Deposit_Zero()
        {
            decimal input = 0;
            Assert.Equal(ATM.ATM.BALANCE, ATM.ATM.Deposit(input));
        }

    }
}
