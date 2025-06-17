Feature: Searching



Scenario: Search RoundTrip
    Given I am on the delta.com landing page
    And I select the round trip button
    And I select my departing city
    And I select my arriving city
    And I select my departing and arriving dates 
    Then I should see My departing and arriving city in the top left div
    And I should see the words round trip in the items list for each flight grid item


