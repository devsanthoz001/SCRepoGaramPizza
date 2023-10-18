namespace RegistrationTests;

public class RegistrationTest
{
  [Fact]
  public void TestNameisNotNull()
  {

    // Arrange
    Register check = new Register();
    // Act
    check.Name = "santhosh";
    // Assert
    Assert.NotEmpty(check.Name);
  }
  [Fact]
  public void TestMobileNumberisNotNull()
  {

    // Arrange
    Register check = new Register();
    // Act
    check.MobileNumber = "9876543210";
    // Assert
    Assert.NotEmpty(check.MobileNumber);
  }
  [Fact]
  public void TestAddressisNotNull()
  {

    // Arrange
    Register check = new Register();
    // Act
    check.Address = "128 north street";

    // Assert
    Assert.NotEmpty(check.Address);
  }
}
