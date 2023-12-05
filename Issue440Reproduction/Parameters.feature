Feature: Parameters

    Scenario: set parameters via one-row table
        When I go to the registration form
        And I enter my details
          | login   | password |
          | johndoe | qwerty   |
        Then the profile should be created