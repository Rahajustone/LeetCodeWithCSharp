namespace LeetCode.UnitTest;

[TestFixture]
public class MedianOfTwoSortedArraysSolutionTest
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void FindMedianSortedArraysWith_BothArrayIsNull_ThrowNewException()
    {
        Assert.That(() => MedianOfTwoSortedArraysSolutionWithPointers.FindMedianSortedArraysWithBruteForce(new int[] {}, new int[] { }),
            Throws.ArgumentNullException);
    }

    [Test]
    [TestCase(new int[] {1,2,3,4}, new int[] {4,5,6,7,8}, 4)]
    [TestCase(new int[] {1,2,3,4}, new int[] {5,6,7,8}, 4.5)]
    [TestCase(new int[] {0,0,0}, new int[] {-1}, 0)]
    public void FindMedianSortedArraysWith_WhenCompleted_RetursExpectedVal(int[] arr1, int[] arr2, double res)
    {
        var result = MedianOfTwoSortedArraysSolutionWithPointers.FindMedianSortedArraysWithBruteForce(arr1, arr2);

        Assert.That(result, Is.EqualTo(res));
    }
}
