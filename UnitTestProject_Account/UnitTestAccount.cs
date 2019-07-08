using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using _4.Items;

namespace UnitTestProject_Account
{
    [TestClass]
    public class UnitTestAccount
    {
        [TestMethod]
        public void TestfncDeposit_inPaidAccount_Deposit_IncreaseBalance()
        {
            // ARRANGE
            double currentBalance = 2999.0;
            double deposit = 100.0;
            double expected = 3099.0;
            // Obj
            var account = new clsPaidAccount(currentBalance, "PA1PA1", "PaidAccount");

            // ACT
            account.fncDeposit(deposit);
            double actual = account.vBalance;

            // ASSERT
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestfncWithdrawal_inPaidAccount_Withdrawal_ReduceBalance()
        {
            // ARRANGE
            double currentBalance = 2999.0;
            double withdrawal = 100.0;
            double expected = 2899.0;
            // Obj
            var account = new clsPaidAccount(currentBalance, "PA1PA1", "PaidAccount");

            // ACT
            account.fncWithdrawal(withdrawal);
            double actual = account.vBalance;

            // ASSERT
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestfncDeposit_inUnPaidAccount_Deposit_IncreaseBalance()
        {
            // ARRANGE
            double currentBalance = 2300.0;
            double deposit = 100.0;
            double expected = 2400.0;
            // Obj
            var account = new clsUnpaidAccount(currentBalance, "UA1UA1", "UnpaidAccount");

            // ACT
            account.fncDeposit(deposit);
            double actual = account.vBalance;

            // ASSERT
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestfncWithdrawal_inUnPaidAccount_Withdrawal_ReduceBalance()
        {
            // ARRANGE
            double currentBalance = 2300.0;
            double withdrawal = 100.0;
            double expected = 2200.0;
            // Obj
            var account = new clsPaidAccount(currentBalance, "UA1UA1", "UnpaidAccount");

            // ACT
            account.fncWithdrawal(withdrawal);
            double actual = account.vBalance;

            // ASSERT
            Assert.AreEqual(expected, actual);
        }
    }   
}

