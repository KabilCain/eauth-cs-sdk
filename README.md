What is Eauth?
==============

https://eauth.us.to/ - Your #1 software login and authentication system, providing you with the most secure, flexible, and easy-to-use solutions.

Functions
-------------

```cs
bool InitRequest();
```
```cs
bool LoginRequest(string username, string password, string key);
```
```cs
bool RegisterRequest(string username, string email, string password, string key);
```
```cs
bool downloadRequest(std::string fileid, const std::string& filename, const std::string& path);
```
```cs
bool ResetPasswordRequest(string email);
```
```cs
bool UpgradeRequest(string username, string key);
```
```cs
bool authMonitor();
```

Configuration
-------------

Navigate to `Eauth.cs`, and fill these lines of code:

```cs
/* Required configuration */
private string applicationToken = ""; // Your application token goes here
private string applicationSecret = ""; // Your application secret goes here
private string applicationVersion = "1.0"; // Your application version goes here
```
