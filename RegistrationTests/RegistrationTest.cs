namespace RegistrationTests;

public class RegistrationTest
{
  [Fact]
  public void NameisNotNullTest()
  {
    // Arrange
    Register customerRegistration = new Register();
    // Act
    customerRegistration.Name = "santhosh";
    // Assert
    Assert.NotEmpty(customerRegistration.Name);
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
