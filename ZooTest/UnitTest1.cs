using System;
using Xunit;
using Zoo;
namespace ZooTest
{
    public class UnitTest1
    {
        [Fact]
        public void SnakeHasYellowScalesAndHissSound()
        {
            Snake s = new Snake()
            {
                Name = "Kaa"
            };
            Assert.Equal("yellow", s.ScaleColor);
            Assert.Equal("Hisssss", s.MakeNoise());

        }
        [Fact]
        public void CrocodilesHasGreenScalesAndHissSound()
        {
            Crocodiles c = new Crocodiles()
            {
                Name = "Cuban"
            };
            Assert.Equal("Green", c.ScaleColor);
            Assert.Equal("Hisssss", c.MakeNoise());
        }
        [Fact]
        public void FalconHas390SpeedAnd2NumberOfEyesAndMigrates()
        {
            Falcon f = new Falcon()
            {
                Name = "Eleonora's"
            };
            Assert.Equal(390, f.Speed);
            Assert.True(f.Migrates);
            Assert.Equal(2, f.NumberOfEyes);
        }
        [Fact]
        public void BirdTurkey25SpeedAnd2NumberOfEyesAndNotMigrates()
        {
            BirdTurkey f = new BirdTurkey()
            {
                Name = "tom"
            };
            Assert.Equal(25, f.Speed);
            Assert.False(f.Migrates);
            Assert.Equal(2, f.NumberOfEyes);
        }
        [Fact]
        public void PlatypusIsNotPetAndDenseFurTypeAndProduceVenom()
        {
            Platypus p = new Platypus()
            {
                Name = "tom"
            };
            Assert.False(p.IsPet);
            Assert.Equal("dense", p.FurType);
            Assert.Equal("tom Name Produce Venom, but venom's effects are extremely painful but are not lethal to humans.!", p.ProduceVenom());
        }
        [Fact]
        public void ElephantMakeNoiseTrumpetCallAndTailSways()
        {
            Elephant e = new Elephant()
            {
                Name = "Dugongidae"
            };
            Assert.Equal("Trumpet call", e.MakeNoise());
            Assert.Equal("My tail sways.", e.HasTail());
        }
    } 
}

