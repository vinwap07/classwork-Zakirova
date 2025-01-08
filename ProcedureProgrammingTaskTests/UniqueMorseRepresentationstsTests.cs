using ProcedureTestTasks;

namespace ProcedureProgrammingTasksTests
{
    public class UniqueMorseRepresentationstsTests
    {
        [Fact]
        public void Send_Array_Of_One_Word_Return_Array_Length()
        {
            string[] words = ["..-.-"];
            var expectedCount = words.Length;

            //Act
            var result = TaskExecutor.UniqueMorseRepresentations(words);

            //Assert
            Assert.Equal(expectedCount, result);
        }

        
    }
}