﻿using StockMaster.Domain.Security.Tokens;

namespace StockMaster.Api.Token;

public class HttpContextTokenValue : ITokenProvider
{
    private readonly IHttpContextAccessor _contextAccessor;
    public HttpContextTokenValue(IHttpContextAccessor httpContextAccessor)
    {
        _contextAccessor = httpContextAccessor;
    }
    public string TokenOnRequest()
    {
       var authorization =  _contextAccessor.HttpContext!.Request.Headers.Authorization.ToString();

        //Bearer 123234hfsufugh
        return authorization["Bearer ".Length..].Trim();
    }
}
