using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using static Desafio.TwoSum.Program;

namespace TestProject
{
    public class SolutionTest
    {
        [Fact]
        public void TwoSum_Test1()
        {
            var solution = new Solution();
            var numbers = new int[] { 2, 7, 11, 15 };
            var target = 9;

            var result = solution.TwoSum(numbers, target);

            Assert.Equal(0, result[0]);
            Assert.Equal(1, result[1]);
        }

        [Fact]
        public void TwoSum_Test2()
        {
            var solution = new Solution();
            var numbers = new int[] { 3, 2, 4 };
            var target = 6;

            var result = solution.TwoSum(numbers, target);

            Assert.Equal(1, result[0]);
            Assert.Equal(2, result[1]);
        }

        [Fact]
        public void TwoSum_Test3()
        {
            var solution = new Solution();
            var numbers = new int[] { 3, 3 };
            var target = 6;

            var result = solution.TwoSum(numbers, target);

            Assert.Equal(0, result[0]);
            Assert.Equal(1, result[1]);
        }

        //There was an error here, it was taking the values ​​[1, 1], but the index cannot be repeated
        [Fact]
        public void TwoSum_IfNotResult_ThrowsException()
        {
            var solution = new Solution();
            var numbers = new int[] { 1, 3, 5 }; 
            var target = 10;

            var exception = Assert.Throws<System.Exception>(() => solution.TwoSum(numbers, target));

            Assert.Equal("No solution found", exception.Message);
        }

    }
}
