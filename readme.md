[devcays case](https://devcays.com)

# Case overview
This project is designed to let you demonstrate your knowledge on .NET C# and ASP.NET Core but mostly focusing on your abilities to reason about design choices.

The case scenario is sourced from real-life project work, and the task presented here is common to green-field projects
and early contributors.

**Note: remember there's not a single, best way to solve this case. The most important aspect is your reasoning.**

### Requirements
This case requires you to have installed:

- A .NET C# capable editor or IDE, such as Visual Studio, Visual Studio Code, or JetBrains Rider.
- .NET6 SDK installed.

## The scenario
Imagine a client has requested a Proof-of-Concept for a headless questionnaire website.  
The website should have an endpoint to return all questionnaires, an endpoint to find a single questionnaire by id, and one to submit the questionnaire response.

A questionnaire is linked to a user that has an id and a username as its only properties.

The client is vague about how the questionnaire is structured and wants you to come up with your own models.

Also, the client doesn't have any code at all. You're starting a green-field project.

### Your task
Your task is simply to realize the client's ask. Create an ASP.NET Core website from scratch that exposes three endpoints as described in the scenario section.


## Additional information
Since this is a green-field, Proof-of-Concept, you decide yourself how the questionnaires and responses are stored, for instance in an in-memory database, MS-SQL database, or on disk as a file.

## LICENSE
See [license file](LICENSE).