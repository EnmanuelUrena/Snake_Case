using System;
using Xunit;

namespace Snake_Case
{
    public class UnitTest1
    {
        [Fact]
        public void testString1()
        {
            string text = "Pedro picapiedra dice asi blablabla";
            string result = Program.convertSnakeCase(text);
            Assert.Equal("Pedro_picapiedra_dice_asi_blablabla", result);
        }
        [Fact]
        public void testString2()
        {
            string text = "912 54524 120   7672767";
            string result = Program.convertSnakeCase(text);
            Assert.Equal("912_54524_120___7672767", result);
        }
        [Fact]
        public void testStringNull()
        {
            string text = "";
            Assert.Throws<NullReferenceException>(() => Program.convertSnakeCase(text));
        }
        [Fact]
        public void testNotValidString()
        {
            string text = "asdasdadasdasds";
            Assert.Throws<ArgumentNullException>(() => Program.convertSnakeCase(text));
        }
    }
}
