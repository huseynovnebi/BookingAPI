# BookingAPI

Git clone the application 
Execute BookingAPI.sln and click execute button in VS
After you can test it in Postman or directly in Web Browser
Example url is like https://localhost:7154/api/available-homes?startDate=2027-08-11&endDate=2027-08-12

In order to do integration test ,from menu test -> Test Explorer then build the app,finally run the available tests

##Architecture and Filtering
It is the Layered Architecture with UnitOfWork pattern and Generic Interfaces.
Note:Previous projects in my github you can find use of tokens,middlewares,DI and more within layered architecture.

App creates a big storage(1000 hotels each have 200 to 1000 available slots) to ConcurrentDictionary.
We have to work with the portion of data that user request every time so we cat that period with indexes then check count if all dates between date range exists in slot(if not it will be less count so some dates is missing-not available).In this case consider that collection is ordered also through doc examples but if not we could potentially do ParallelLinq to parse and then Sort it also another way could be use of HashSet-issubsetof or another method.

Finally, i did not use additional memory storage.



