using Practice.Course.Class;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Practice.Course.Assignments;

namespace PracticeTests.Course.Assignments
{
    public class ProblemsOnSortingTests
    {
        [Theory]
        [InlineData(new[] { 8, 4, 7, 3 }, 2, 7)]
        [InlineData(new[] { 3, 2, 1, 5, 6, 4 }, 2, 5)]
        [InlineData(new[] {3, 2, 3, 1, 2, 4, 5, 5, 6}, 4, 3)]
        [InlineData(new int[0], 1, -1)]
        [InlineData(new int[] {1, 2, 3, 1, 2, 3,}, 4, -1)]
        public void
            FindMaxKthElem_ShouldReturn_KthDistinctLargestNumber_For_AGivenArray(int[] input, int k, int expected)
        {
            var sut = new ProblemsOnSorting();
            var actual = sut.FindMaxKthElem(input, k);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(
            new[] { 1, 2, 3, 0, 0, 0 }, 3,
            new[] { 2, 5, 6 }, 3,
            new[] { 1, 2, 2, 3, 5, 6 })]
        [InlineData(
            new[] { 0, 2, 0, 0 }, 2,
            new[] { 0, 1 }, 2,
            new[] { 0, 0, 1, 2 })]
        [InlineData(
            new[] { 0, 0, 3, 0, 0, 0, 0, 0, 0 }, 3,
            new[] { -1, 1, 1, 1, 2, 3 }, 6,
            new[] { -1, 0, 0, 1, 1, 1, 2, 3, 3 })]
        [InlineData(
            new[] { 0, 0, 0, 0, 0 }, 0,
            new[] { 1, 2, 3, 4, 5 }, 5,
            new[] { 1, 2, 3, 4, 5 })]
        [InlineData(
            new[] { 0 }, 0,
            new[] { 1 }, 1,
            new[] { 1 })]
        [InlineData(
            new[] { 3 }, 1,
            new int[0], 0,
            new[] { 3 })]

        public void  MergeTwoArrays_ShouldReturn_MergedArrayAndKeepIndexItem_For_TwoAscendingOrderedArrays(
            int[] list1, int m, int[] list2, int n, int[] expected)
        {
            var sut = new ProblemsOnSorting();

            sut.MergeTwoArrays(list1, m, list2, n);

            Assert.Equal(expected, list1);
        }

        [Theory]
        [InlineData(new[] { 2, 0, 2, 1, 1, 0 }, new[] { 0, 0, 1, 1, 2, 2 })]
        [InlineData(new[] { 2, 0, 1 }, new[] { 0, 1, 2 })]
        [InlineData(new int[0], new int[0])]
        public void SortColors_ShouldReturn_SortedColorsInOrderRedWhiteBlue_For_AGivenListOfColors(
            int[] input, int[] expected)
        {
            var sut = new ProblemsOnSorting();

            sut.SortColors(input);

            Assert.Equal(expected, input);
        }

        [Theory]
        [InlineData("aaabbbcccd", 4)]
        [InlineData("aa", 0)]
        [InlineData("aab", 0)]
        [InlineData("aaaaabbbbbcccddd", 2)]
        public void CreateAGoodString_ShouldReturn_NumberOfCharThatMustBeDeletedToHaveAGoodString_For_AGivenString(
            string input, int expected)
        {
            var sut = new ProblemsOnSorting();

            var actual =sut.CreateAGoodString(input);

            Assert.Equal(expected, actual);
        }

        [Theory]
        [MemberData(nameof(IntervalsData))]
        public void CanAttendToMeetings_ShouldReturn_True_For_AGivenListOfIntervals(
            List<int[]> input, bool expected)
        {
            var sut = new ProblemsOnSorting();

            var actual =sut.CanAttendToMeetings(input);

            Assert.Equal(expected, actual);
        }

        public static IEnumerable<object[]> IntervalsData()
        {
            yield return new object[]
            {
                new List<int[]>
                {
                    new[] {0, 30},
                    new[] {15, 20},
                    new[] {5, 10},
                }, false
            };
            yield return new object[]
            {
                new List<int[]>
                {
                    new[] {7, 10},
                    new[] {2, 4},
                },
                true
            };
            yield return new object[]
            {
                new List<int[]>
                {
                    new[] {15, 18},
                    new[] {1, 4},
                    new[] {8, 12},
                    new[] {5, 8},
                }, true
            };
            yield return new object[]
            {
                new List<int[]>(), false
            };
        }

        [Theory]
        [MemberData(nameof(IntervalsConferenceData))]
        public void CalculateConferenceRooms_ShouldReturn_True_For_AGivenListOfIntervals(
            List<int[]> input, int expected)
        {
            var sut = new ProblemsOnSorting();

            var actual = sut.CalculateConferenceRooms(input);

            Assert.Equal(expected, actual);
        }

        public static IEnumerable<object[]> IntervalsConferenceData()
        {
            yield return new object[]
            {
                new List<int[]>
                {
                    new[] {0, 30},
                    new[] {15, 20},
                    new[] {5, 10},
                }, 2
            };
            yield return new object[]
            {
                new List<int[]>
                {
                    new[] {7, 10},
                    new[] {2, 4},
                },
                1
            };
            yield return new object[]
            {
                new List<int[]>
                {
                    new[] {15, 18},
                    new[] {1, 4},
                    new[] {8, 12},
                    new[] {5, 8},
                }, 1
            };
            yield return new object[]
            {
                new List<int[]>(), 0
            };
        }

        

        [Theory]
        [MemberData(nameof(RemoveIntervalData))]
        public void RemoveIntervals_ShouldReturn_True_For_AGivenListOfIntervals(
            List<int[]> input, int expected)
        {
            var sut = new ProblemsOnSorting();

            var actual = sut.RemoveIntervals(input);

            Assert.Equal(expected, actual);
        }

        public static IEnumerable<object[]> RemoveIntervalData()
        {
            yield return new object[]
            {
                new List<int[]>
                {
                    new[] {1, 2},
                    new[] {2, 3},
                    new[] {3, 4},
                    new[] {1, 3},
                }, 1
            };
            yield return new object[]
            {
                new List<int[]>
                {
                    new[] {1, 2},
                    new[] {1, 2},
                    new[] {1, 2},
                }, 2
            };
            yield return new object[]
            {
                new List<int[]>
                {
                    new[] {1, 100},
                    new[] {11, 22},
                    new[] {1, 11},
                    new[] {2, 12}
                }, 2
            };
            yield return new object[]
            {
                new List<int[]>(), 0
            };
            yield return new object[]
            {
                new List<int[]>
                {
                    new int[0]
                }, 0
            };
        }

        [Theory]
        [MemberData(nameof(MergeTestData))]
        public void MergeOverlapping_ShouldReturn_True_For_AGivenListOfIntervals(
            List<int[]> input, int[][] expected)
        {
            var sut = new ProblemsOnSorting();

            var actual = sut.MergeOverlapping(input);

            Assert.Equal(expected, actual);
        }

        public static IEnumerable<object[]> MergeTestData()
        {
            yield return new object[] {
                new List<int[]>
                {
                    new[] { 1, 3 },
                    new[] { 2, 6 },
                    new[] { 8, 10 },
                    new[] { 15, 18 }
                },
                new List<int[]>
                {
                    new[] { 1, 6 },
                    new[] { 8, 10 },
                    new[] { 15, 18 }
                }
            };
            yield return new object[] {
                new List<int[]>
                {
                    new[] { 1, 3 },
                    new[] { 2, 6 },
                    new[] { 8, 16 },
                    new[] { 15, 18 }
                },
                new List<int[]>
                {
                    new[] { 1, 6 },
                    new[] { 8, 18 }
                }
            };
            yield return new object[] {
                new List<int[]>
                {
                    new[] { 1, 4 },
                    new[] { 4, 5 }
                },
                new List<int[]>
                {
                    new[] { 1, 5 }
                }
            };
            yield return new object[] {
                new List<int[]>
                {
                    new[] { 1, 4 },
                    new[] { 5, 6 }
                },
                new List<int[]>
                {
                    new[] { 1, 4 },
                    new[] { 5, 6 }
                }
            };
            yield return new object[] {
                new List<int[]>
                {
                    new[] { 1, 4 },
                    new[] { 0, 5 }
                },
                new List<int[]>
                {
                    new[] { 0, 5 },
                }
            };
            yield return new object[] {
                new List<int[]>
                {
                    new[] { 1, 4 },
                    new[] { 0, 1 }
                },
                new List<int[]>
                {
                    new[] { 0, 4 },
                }
            };
            yield return new object[] {
                new List<int[]>
                {
                    new[] { 0, 4 },
                    new[] { 1, 5 }
                },
                new List<int[]>
                {
                    new[] { 0, 5 },
                }
            };
        }

    }
}
