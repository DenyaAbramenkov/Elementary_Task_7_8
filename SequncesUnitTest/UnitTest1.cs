using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Elementary_Task_7_8;
using System.Collections.Generic;

namespace SequncesUnitTest
{
    [TestClass]
    public class SequncesTest
    {
        [TestMethod]
        [DataRow(1, 10, 1, 10)]
        [DataRow(5, 20, 5, 20)]
        public void FibonachiSequncesCorrectInitialize(int leftBorder, int rightBorder, int expectedLeftBorder, int expectedRightBorder)
        {
            //Arrange

            //Act
            FibonachiSequence sequence = FibonachiSequence.FibonachiInitialize(leftBorder, rightBorder);

            //Assert
            Assert.IsTrue((expectedLeftBorder == sequence.LeftBorder)
                && (expectedRightBorder == sequence.RightBorder));
        }

        [TestMethod]
        [DataRow(5, 1, 5)]
        [DataRow(50, 1, 50)]
        public void LessThanNSequncesCorrectInitialize(int rightBorder, int expectedLeftBorder, int expectedRightBorder)
        {
            //Arrange

            //Act
            LessThenNSquereSequences sequence = LessThenNSquereSequences.NSquereInitialize(rightBorder);
            
            //Assert
            Assert.IsTrue((expectedLeftBorder == sequence.LeftBorder)
            && (expectedRightBorder == sequence.RightBorder));
        }

        [TestMethod]
        [DataRow(-11)]
        [DataRow(0)]
        [ExpectedException(typeof(ArgumentException))]
        public void LessThanNSequncesInCorrectInitialize(int rightBorder)
        {
            //Arrange

            //Act
            LessThenNSquereSequences sequence = LessThenNSquereSequences.NSquereInitialize(rightBorder);

            //Assert
        }

        [TestMethod]
        [DataRow(-11, 5)]
        [DataRow(10, 5)]
        [ExpectedException(typeof(ArgumentException))]
        public void FibonachiSequncesInCorrectInitialize(int leftBorder, int rightBorder)
        {
            //Arrange

            //Act
            FibonachiSequence sequence = FibonachiSequence.FibonachiInitialize(leftBorder, rightBorder);

            //Assert
        }

        [TestMethod]
        [DataRow(1, 13, new int[] { 1, 1, 2, 3, 5, 8, 13 })]
        [DataRow(7, 21, new int[] { 8, 13, 21 })]
        [DataRow(5, 5, new int[] { 5 })]
        [DataRow(10, 10, new int[] { })]
        public void FibbonachiNumberRange_Correct(int leftBorder,
            int rightBorder, int[] expected)
        {
            //Arrange
            List<int> real = new List<int>();

            //Act
            FibonachiSequence sequence = FibonachiSequence.FibonachiInitialize(leftBorder, rightBorder);
            foreach (int item in sequence.GetSequence())
            {
                real.Add(item);
            }

            //Assert
            CollectionAssert.AreEqual(expected, real.ToArray());
        }

        [TestMethod]
        [DataRow(13, new int[] { 1, 2, 3 })]
        [DataRow(21, new int[] { 1, 2, 3, 4 })]
        [DataRow(5, new int[] { 1, 2 })]
        public void LessThanNNumberRange_Correct(int rightBorder, int[] expected)
        {
            //Arange
            List<int> real = new List<int>();
           
            //Act
            LessThenNSquereSequences sequence = LessThenNSquereSequences.NSquereInitialize(rightBorder);
            foreach (int item in sequence.GetSequence())
            {
                real.Add(item);
            }

            //Assert
            CollectionAssert.AreEqual(expected, real.ToArray());
        }


    }
}
