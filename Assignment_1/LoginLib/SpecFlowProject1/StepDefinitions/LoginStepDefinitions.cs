using LoginLib;

namespace SpecFlowProject1.StepDefinitions
{
    [Binding]
    public sealed class LoginStepDefinitions
    {
        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef
        private readonly Login _login;
        private string _result;
        private Exception _exception;

        public LoginStepDefinitions(Login login)
        {
            _login = login;
        }

        [Given("the username is \"(.*)\"")]
        public void GivenTheUserNameIs(string username)
        {
            try
            {
                _login.Username = username == "null" ? null : username;
            }
            catch(Exception ex)
            {
                _exception = ex;
            }
            
        }

        [Given("the password is \"(.*)\"")]
        public void GivenThePasswordIs(string password)
        {
            try
            {
                _login.Password = password == "null" ? null : password;
            }
            catch (Exception ex)
            {
                _exception = ex;
            }
            
        }

        [When("I try to login")]
        public void WhenITryToLogin()
        {
            try
            {
                _result = _login.LoginMethod();
            }
            catch (Exception ex)
            {
                _exception = ex;
            }
        }

        [Then("the message should be \"(.*)\"")]
        public void ThenTheMessageShouldBe(string result)
        {
            try
            {
                _result.Should().Be(result);
            }
            catch (Exception ex)
            {
                _exception = ex;
            }
        }
        [Then("an exception should be thrown")]
        public void ThenAnExceptionShouldBeThrown()
        {
            _exception.Should().NotBeNull();
        }
    }
}