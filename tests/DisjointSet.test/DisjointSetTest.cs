using FluentAssertions;
using System;
using Xunit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DisjointSet.test
{
    public class DisjointSetTest
    {

        [Fact]
        public void FindRoot_Of3_ThenReturn_0()
        {
            //Arrange
            var disjointSet = new DisjointSetObj();

            disjointSet.Union(0, 1);
            disjointSet.Union(0, 2);
            disjointSet.Union(1, 3);
            disjointSet.Union(4, 8);
            disjointSet.Union(5, 6);
            disjointSet.Union(5, 7);

            //Act
            var result = disjointSet.FindRoot(3);

            //Assert
            result.Should().Be(0);
        }


        [Fact]
        public void FindRoot_Of5_ThenReturn_0()
        {
            //Arrange
            var disjointSet = new DisjointSetObj();

            disjointSet.Union(0, 1);
            disjointSet.Union(0, 2);
            disjointSet.Union(1, 3);
            disjointSet.Union(4, 8);
            disjointSet.Union(5, 6);
            disjointSet.Union(5, 7);

            //Act
            var result = disjointSet.FindRoot(5);

            //Assert
            result.Should().Be(5);
        }

        [Fact]
        public void CheckIfConnected_0And3_ThenReturn_True()
        {
            //Arrange

            //Act

            //Assert


        }



    }
}
