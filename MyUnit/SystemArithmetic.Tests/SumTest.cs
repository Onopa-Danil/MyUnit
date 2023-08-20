using MyUnit;
using MyUnit.Attributes;

namespace SystemArithmetic.Tests
{
    public class SumTest
    {
        [MyFact]
        public void OnePlusOne_EqualsTwo()
        {
            MyAssert.True(1 + 1 == 2);
        }
        
        [MyFact]
        public void OnePlusOne_NotEqualsThree()
        {
            MyAssert.False(1 + 1 == 3);
        }
        [MyFact]
        public void OnePlusTwo_EqualsThree()
        {
            MyAssert.Equal(3, 1 + 2);
        }
        [MyFact]
        public void ArrayEqualsToList()
        {
            IList<int> list = new List<int>();
            list.Add(1);
            list.Add(2);
            IEnumerable<int> enumerable = list;
            var arr = new int[] { 1, 2 };
            MyAssert.Equal(enumerable, arr);
        }
        [MyFact]
        public void TestNull()
        {
            MyAssert.Null(null);
        }
        [MyFact]
        public void TestNotNull()
        {
            MyAssert.NotNull(new List<int>());
        }
        [MyFact]
        public void TestThrowsException()
        {
            MyAssert.Throws<MyAssertTestFailureException>(() => throw new MyAssertTestFailureException());
            //MyAssert.Throws<Exception>(() => throw new MyAssertTestFailureException());
        }
    }
}
