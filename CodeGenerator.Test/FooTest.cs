namespace CodeGenerator.Test
{
    using Code;
    using Xunit;

    public class FooTest
    {
        [Fact]
        public void SimpleGenerationWorks()
        {
            var foo = new Foo();
            var fooA = new FooA();
        }
    }
}