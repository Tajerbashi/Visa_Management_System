using System;

public class ApiModel(string port,string controller,string action)
{
    public string GetApi()
    {
        return ($"{port}/{controller}/{action}");
    }
}