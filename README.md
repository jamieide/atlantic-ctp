# atlantic-ctp
This is a simple client application for the [Atlantic COVID Tracking project](https://covidtracking.com/) written in .NET Core 3.1.

There are three projects in the solution:
- AtlanticCovidTracker.Client. This is an encapsulated C# client and C# model classes for the API. The best way to distribute the client is to upload it to an internal NuGet server so that other developers can easily include it in their solutions and keep up with changes. A design goal of the client library is that it should encapsulate all exceptions in the custom AtlanticCovidTrackerClientException to make handling easier. Uses System.Text.Json instead of Newtonsoft.Json.
- AtlanticCovidTracker.Client.Tests. Full integration test coverage.
- AtlanticCovidTracker.Web. A very basic web interface for displaying data retrieved from the API. Uses Bootstrap and NLog.
