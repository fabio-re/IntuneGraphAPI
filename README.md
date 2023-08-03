# INTUNE GRAPH API

## Introduction

This repository was created to help people like me who had to fight to get the necessary info from Microsoft Intune :-P

I use a app registration with appropriate authorizations to MS Intune (https://learn.microsoft.com/en-us/graph/api/resources/intune-graph-overview?view=graph-rest-1.0).
With app registration, I generate a token to make graph api call with a HttpClient or use directly the GraphApiClient

## Updates & Feedback

[AGO-2023] : I want to optain a user's device information reading this https://learn.microsoft.com/en-us/graph/api/intune-devices-manageddevice-get?view=graph-rest-1.0&tabs=http
so i make an api callable with the user principal id's.

The First problem that I had to deal with was that physicalMemoryInBytes returned always 0

## Contributing

If you want to contribute by inserting your API you are welcome
