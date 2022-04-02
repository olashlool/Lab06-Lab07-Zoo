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
        public void SnakeLayEggs()
        {
            Snake s1 = new Snake()
            {
                Name = "Crocodiles"
            };
            Assert.Equal("dirt, compost, or loose and moist ground.", s1.LayEggs());
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
        public void CrocodilesLayEggs()
        {
            Crocodiles c1 = new Crocodiles()
            {
                Name = "Crocodiles"
            };
            Assert.Equal("holes or mound nests", c1.LayEggs());
        }

        [Fact]
        public void CrocodilesCanSwim()
        {
            Crocodiles c2 = new Crocodiles()
            {
                Name = "Crocodiles2"
            };
            Assert.Equal("When swimming, the crocodile places its legs back against the sides of the body and moves forward by means of lateral wavelike motions of the tail", c2.Swimming());
        }
        [Fact]
        public void FalconHas390SpeedAnd2NumberOfEyesAndMigratesAndSound()
        {
            Falcon f = new Falcon()
            {
                Name = "Eleonora's"
            };
            Assert.Equal(390, f.Speed);
            Assert.True(f.Migrates);
            Assert.Equal(2, f.NumberOfEyes);
            Assert.Equal("kack-kack-kack", f.MakeNoise());
        }
        [Fact]
        public void FalconLayEggs()
        {
            Falcon f1 = new Falcon()
            {
                Name = "Falcon"
            };
            Assert.Equal("sand or gravel", f1.LayEggs());
        }
        [Fact]
        public void BirdTurkey25SpeedAnd2NumberOfEyesAndNotMigrates()
        {
            BirdTurkey b = new BirdTurkey()
            {
                Name = "tom"
            };
            Assert.Equal(25, b.Speed);
            Assert.False(b.Migrates);
            Assert.Equal(2, b.NumberOfEyes);
        }
        [Fact]
        public void BirdTurkeyLayEggs()
        {
            BirdTurkey b1 = new BirdTurkey()
            {
                Name = "Turkey"
            };
            Assert.Equal("nest", b1.LayEggs());
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
        public void PlatypusLayEggs()
        {
            Platypus p1 = new Platypus()
            {
                Name = "Silvia Plat"
            };
            Assert.Equal("underground burrow", p1.LayEggs());
        }

        [Fact]
        public void PlatypusCanSwim()
        {
            Platypus p2 = new Platypus()
            {
                Name = "Don"
            };
            Assert.Equal("swim gracefully by paddling with their front webbed feet and steering with their hind feet and beaverlike tail.", p2.Swimming());
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

        [Fact]
        public void ElephantCanSwim()
        {
            Elephant e1 = new Elephant()
            {
                Name = "Don"
            };
            Assert.Equal("elephants are natural-born swimmers.", e1.Swimming());
        }

    } 
}

