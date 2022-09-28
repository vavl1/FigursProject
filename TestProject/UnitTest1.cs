using FigursProject;
using Xunit;

namespace TestProject
{
    public class UnitTest1
    {
        [Fact]
        public void HCircle()
        {
            double h = new Circle(2).H();
            Assert.Equal(12.566370614359172, h);
        }
        [Fact]
        public void HTriagle()
        {
            double h = new Triagle(1, 2, 3).H();
            Assert.Equal(3, h);
        }
        [Fact]
        public void IsRegtangular()
        {
            bool result = new Triagle(3, 4, 5).IsRegtangular();
            Assert.True(result);
            bool resultFalse = new Triagle(5, 4, 7).IsRegtangular();
            Assert.True(!resultFalse);
        }
        [Fact]
        public void HFigurs()
        {
            Figure[] figurs = new Figure[] { new Circle(2), new Triagle(1, 2, 3) };
            Assert.Equal(12.566370614359172, figurs[0].H());
            Assert.Equal(3, figurs[1].H());
        }
    }
}