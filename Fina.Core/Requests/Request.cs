namespace Fina.Core.Requests;
using System;

public abstract class Request
{
    public string UserId { get; set; } = string.Empty;
}