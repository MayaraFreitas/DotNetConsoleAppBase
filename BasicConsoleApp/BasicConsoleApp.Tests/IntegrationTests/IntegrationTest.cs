using Moq;
using System.Text;

namespace BasicConsoleApp.Tests.IntegrationTests
{
    public class IntegrationTest
    {
        private StringBuilder _consoleOutput = new();
        private Mock<TextReader> _consoleInput = new();

        private void Setup()
        {
            _consoleOutput = new StringBuilder();
            _consoleInput = new Mock<TextReader>();
            Console.SetOut(new StringWriter(_consoleOutput));
            Console.SetIn(_consoleInput.Object);
        }

        private MockSequence SetupResponses(params string[] responses)
        {
            var sequence = new MockSequence();
            foreach (var response in responses)
            {
                _consoleInput.InSequence(sequence).Setup(x => x.ReadLine()).Returns(response);
            }
            _consoleInput.InSequence(sequence).Setup(x => x.ReadLine()).Returns("");
            return sequence;
        }

        private string[] RunMainAndGetConsoleOutput()
        {
            Program.Main(new string[] { });
            return _consoleOutput.ToString().Split(Environment.NewLine);
        }

        private string[] GetConsoleOutput()
        {
            var results = RunMainAndGetConsoleOutput();
            return results[1..(results.Length - 1)];
        }

        [Fact]
        public void Main_WhenGivenTestScenario_ProducesExpectedOutput()
        {
            // Arrange
            var texts = new string[] { "Hey, this is my text :)", "second text", "end" };
            Setup();
            SetupResponses(texts);

            // Act
            var jsonResult = GetConsoleOutput();

            // Assert
            Assert.All(jsonResult, (result, index) => Assert.Equal(texts[index], result));
        }
    }
}