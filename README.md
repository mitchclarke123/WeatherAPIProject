# WeatherAPIProject

1.Instructions on how to create unit tests using my api request testing framework.
First to use this framework you would need to get an api key from https://home.openweathermap.org/ 
and then using Postman, request the relevant weather data for a location. insert the api key into the
app.config and the api link, then we  nearly begin creating tests.
to create a unit test using this framework make sure that you have the following NuGet Packages -

NUnit, NUnit3TestAdapter, RestSharp, Newtonsoft.Json, MSTest.Framework, MSTest.TestAdapter.

now you have everything you need to create some unit tests using this framework, an easy one to try 
to make sure that everything you have is working as intended is a Location/Country is correct test where 
you would use an Assert.AreEqual to compare your expected string e.g (London) to what has been received via
the Api Request and stored in the model.

2. If you are continuing this project i would recommend you create a number of tests that test for api error codes.
i would also look into testing live values in a variable instead of testing for tempreture being 
correct by comparing the live value to a realistic boundry.

3. During this project i have learned a number of things about api testing and testing frameworks.
I have learned a couple of techniques for testing for correct data from API's that before this week i would not
have known about. i have also developed a further understanding of postman and what to look for in a data request.
next time i would have a better fundamental understanding of a project like this one and could spend less time 
on aspects that i would now consider basic. this would allow me to explore different kinds of tests for different
parts of the request and create more methods for specific situations.

