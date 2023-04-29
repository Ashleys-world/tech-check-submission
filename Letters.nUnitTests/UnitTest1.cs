using Letters_Code;
namespace Letters.nUnitTests
{
    public class Tests
    {
        private Program _program ;

        [SetUp]
        public void Setup()
        {
           BaseLetters _program  = new Program() ;
        }

        [Test]
        public void Test1()
        {
            //Test to check if the correct number of unique vowels is returned
            //Object Instance
            BaseLetters theInstance = new Program();
            //Assign
            string input = "i like eating apples";
            //Act
            var run = theInstance.VowelChecker(input);
            //Assert
            Assert.That(run, Is.EqualTo(3));
            //Assert.Pass();
        }

        [Test]
        public void Test2()
        {
            //Test to check if the text has more non vowels or vowels is correct
            //Object Instance
            BaseLetters theInstance = new Program();
            //Assign
            string input = "i like eating apples";
            //Act
            var run = theInstance.VowelsOrNonVowels(input);
            //Assert
            Assert.That(run, Is.EqualTo("The text has more non vowels than vowels"));
            //Assert.Pass();
        }

        [Test]
        public void Test3()
        {
            //Test to check if the correct duplicates are returned
            //Object Instance
            BaseLetters theInstance = new Program();
            //Assign
            string input = "i like eating apples";
            string inputTrimmed = input.Replace(" ", "");
            //Act
            var run = theInstance.DuplicateCheck(inputTrimmed);
            //Assert
            Assert.That(run, Is.EqualTo("i,l,e,a,p"));
            //Assert.Pass();
        }
    }
}