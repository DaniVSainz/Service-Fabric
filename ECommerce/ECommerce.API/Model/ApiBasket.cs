using ECommerce.API.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerce.ProductCatalog.Model
{
    public class ApiBasket
    {
        [JsonProperty("userId")]
        public string UserId { get; set; }

        [JsonProperty("item")]
        public ApiBasketItem[] Items { get; set; }

    }
}
