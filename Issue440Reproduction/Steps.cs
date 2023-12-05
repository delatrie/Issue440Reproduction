using TechTalk.SpecFlow;

namespace Issue440Reproduction;

[Binding]
public class Steps
{
    [When("I go to the registration form")]
    public void Navigate()
    {
    }

    [When("I enter my details")]
    public void Enter(Table _)
    {

    }

    [Then("the profile should be created")]
    public void CheckProfile()
    {
        Assert.Pass();
    }
}