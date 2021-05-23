﻿using Newtonsoft.Json;
using System.Collections.Generic;

namespace Notion.Client
{
    public class PaginationParameters
    {
        public string StartCursor { get; set; }
        public string PageSize { get; set; }
    }

    public class PaginatedList<T>
    {
        public const string Object = "List";

        public List<T> Results { get; set; }

        [JsonProperty("has_more")]
        public bool HasMore { get; set; }

        [JsonProperty("next_cursor")]
        public string NextCursor { get; set; }
    }
}
