Feature: Test Should Return Two Dates When The Info Category Has A Date Of The Seventh Of February
For this test to work the LogCategory should be Info,
SearchText should be null and the DateFrom should be 
2018, 2, 7.


Scenario: Assert that result is equal to 2 (this is not a Selenium test)
Given logCategory is set to 'Info'
And DateFrom is 2018-2-7
When i have filtered the LogCategory
Then the result should contain 2 items



Scenario: Assert that the result contains 2 log categories (This is a Selenium test)
Given When the page navigates to the LogViewer page
And LogCategory is set to 'Info'
And Search text is set to Info
When I press the filter button
Then the result should contain 2 log categories
