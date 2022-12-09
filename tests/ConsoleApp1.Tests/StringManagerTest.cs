namespace ConsoleApp1.Tests
{
    public class UnitTest1
    {
        private const string PHRASE = "The Force is strong with you!";

        [Fact]
        public void Option1ToString_Test()
        {
            var sm = new StringManager();
            
            var prefix = sm._prefix;
            var result = sm.Option1ToString();
            var expected = $"{prefix}{PHRASE}";

            Assert.Equal(expected, result);
        }


        [Fact]
        public void Option2CopyTo_Test()
        {
            var sm = new StringManager();

            var prefix = sm._prefix;
            var result = sm.Option2CopyTo();
            var expected = $"{prefix}{PHRASE}";

            Assert.Equal(expected, result);
        }


        [Fact]
        public void Option3ReadOnlyMemoryCharGetChunks_Test()
        {
            var sm = new StringManager();

            var prefix = sm._prefix;
            var result = sm.Option3ReadOnlyMemoryCharGetChunks();
            var expected = $"{prefix}{PHRASE}";

            Assert.Equal(expected, result.ToString());
        }
    }
}