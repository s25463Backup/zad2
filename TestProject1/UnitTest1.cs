using LegacyApp;

namespace TestProject1;

public class UnitTest1
{
    [Fact]
    public void AddUser_Should_Return_False_When_Email_Without_At_And_Dot()
    {
        //Arrange
        string firstName = "Jan";
        string lastName = "Kowalski";
        DateTime birthDate = new DateTime(2000, 1, 3);
        string email = "janKowalski";
        int clientId = 1;
        var userService = new UserService();

        //Act
        bool result = userService.AddUser(firstName, lastName, email, birthDate, clientId);
        
        //Assert
        Assert.False(result);
    }
    
    [Fact]
    public void AddUser_Should_Return_False_When_FirstName_Empty()
    {
        string firstName = "";
        string lastName = "Kowalski";
        DateTime birthDate = new DateTime(2000, 1, 3);
        string email = "janKowalski";
        int clientId = 1;
        var userService = new UserService();

        bool result = userService.AddUser(firstName, lastName, email, birthDate, clientId);
        
        Assert.False(result);
    }

    [Fact]
    public void AddUser_Should_Return_False_When_Age_Under_21()
    {
        string firstName = "Kamil";
        string lastName = "Kowalski";
        DateTime birthDate = new DateTime(2005, 1, 3);
        string email = "janKowalski";
        int clientId = 1;
        var userService = new UserService();

        bool result = userService.AddUser(firstName, lastName, email, birthDate, clientId);
        
        Assert.False(result);
    }
    
}