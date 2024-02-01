using Xunit;

namespace testing
{
    public class Person
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
}

    public class PersonTests
    {
        [Fact]
        public void AddingFirstNameAndLastNameShouldWork()
        {
            // Arrange
            Person person = new Person();

            // Act
            person.FirstName = "John";
            person.LastName = "Doe";

            // Assert
            Assert.Equal("John", person.FirstName);
            Assert.Equal("Doe", person.LastName);
        }
    }
}
