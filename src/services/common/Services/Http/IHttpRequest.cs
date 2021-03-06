// <copyright file="IHttpRequest.cs" company="3M">
// Copyright (c) 3M. All rights reserved.
// </copyright>

using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;

namespace Mmm.Iot.Common.Services.Http
{
    public interface IHttpRequest
    {
        Uri Uri { get; set; }

        HttpHeaders Headers { get; }

        MediaTypeHeaderValue ContentType { get; }

        HttpRequestOptions Options { get; }

        HttpContent Content { get; }

        void AddHeader(string name, string value);

        void SetUriFromString(string uri);

        void SetContent(string content);

        void SetContent(string content, Encoding encoding);

        void SetContent(string content, Encoding encoding, string mediaType);

        void SetContent(string content, Encoding encoding, MediaTypeHeaderValue mediaType);

        void SetContent(StringContent stringContent);

        void SetContent<T>(T sourceObject);

        void SetContent<T>(T sourceObject, Encoding encoding);

        void SetContent<T>(T sourceObject, Encoding encoding, string mediaType);

        void SetContent<T>(T sourceObject, Encoding encoding, MediaTypeHeaderValue mediaType);
    }
}