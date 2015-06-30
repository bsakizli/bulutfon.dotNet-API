﻿using System.Collections.Generic;

namespace Bulutfon.Model.Models.ResponseObjects {

    /// <summary>
    /// Santralde kullanılan telefon numaraları hakkında bilgiler
    /// GET /dids.json
    /// </summary>
    public class DidsResponse 
    {

        public List<Did> dids { get; set; }

        public static List<Did> Get(string token) 
        {
            return null; //BulutfonClient.GetObject<DidsResponse>("https://api.bulutfon.com/dids", token).dids;
        }
    }
}