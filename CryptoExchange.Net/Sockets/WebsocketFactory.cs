﻿using System;
using System.Collections.Generic;
using CryptoExchange.Net.Interfaces;
using CryptoExchange.Net.Logging;

namespace CryptoExchange.Net.Sockets
{
    /// <summary>
    /// Default websocket factory implementation
    /// </summary>
    public class WebsocketFactory : IWebsocketFactory
    {
        /// <inheritdoc />
        public IWebsocket CreateWebsocket(Log log, string url)
        {
            return new CryptoExchangeWebSocketClient(log, new Uri(url));
        }

        /// <inheritdoc />
        public IWebsocket CreateWebsocket(Log log, string url, IDictionary<string, string> cookies, IDictionary<string, string> headers)
        {
            return new CryptoExchangeWebSocketClient(log, new Uri(url), cookies, headers);
        }
    }
}
