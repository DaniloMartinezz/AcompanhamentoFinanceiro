using Fina.Core;
using Fina.Core.Requests;
using System;

public abstract class PagedRequest : Request
{
	public int PageSize { get; set; } = Configuration.DefaultPageSize;
	public int PageNumber { get; set; } = Configuration.DefaultPageNumber;
	
}
