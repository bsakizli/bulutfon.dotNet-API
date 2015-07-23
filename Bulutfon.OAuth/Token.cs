﻿using System;

namespace Bulutfon.OAuth {

    /// <summary>
    /// Access Token ve Refresh Token
    /// </summary>
    public class Token {

        public const string Key = "_tokens_";

        public Token(string accesToken, string refreshToken) {
            AccessToken = accesToken;
            RefreshToken = refreshToken;
        }

        public event TokenExpiredEvent TokenExpired;

        public void SetAccessToken(string token) {
            AccessToken = token;
        }

        public string AccessToken { get; private set; }

        public string RefreshToken { get; private set; }

        public void RefreshAccessToken() {
            if (TokenExpired != null) {
                var e = new TokenExpiredEventArgs();
                e.RefreshToken = RefreshToken;
                TokenExpired(this, e);
            }
        }
    }
}