﻿using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Umbraco.Core.Models
{
    /// <summary>
    /// A model representing the value saved for the grid
    /// </summary>
    public class GridValue
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("sections")]
        public IEnumerable<GridSection> Sections { get; set; }

        public class GridSection
        {
            [JsonProperty("grid")]
            public string Grid { get; set; }

            [JsonProperty("rows")]
            public IEnumerable<GridRow> Rows { get; set; }
        }

        public class GridRow
        {
            [JsonProperty("name")]
            public string Name { get; set; }

            [JsonProperty("id")]
            public Guid Id { get; set; }

            [JsonProperty("areas")]
            public IEnumerable<GridArea> Areas { get; set; }

            [JsonProperty("styles")]
            public JToken Styles { get; set; } // FIXME: This property will become an`IPublishedElement`

            [JsonProperty("config")]
            public JToken Config { get; set; } // FIXME: This property will become an`IPublishedElement`
        }

        public class GridArea
        {
            [JsonProperty("grid")]
            public string Grid { get; set; }

            [JsonProperty("controls")]
            public IEnumerable<GridControl> Controls { get; set; }

            [JsonProperty("styles")]
            public JToken Styles { get; set; } // FIXME: This property will become an`IPublishedElement`

            [JsonProperty("config")]
            public JToken Config { get; set; } // FIXME: This property will become an`IPublishedElement`
        }

        public class GridControl
        {
            [JsonProperty("value")]
            public JToken Value { get; set; } // FIXME: This property will become an`IPublishedElement`

            [JsonProperty("editor")]
            public GridEditor Editor { get; set; }

            [JsonProperty("styles")]
            public JToken Styles { get; set; } // FIXME: This property will become an`IPublishedElement`

            [JsonProperty("config")]
            public JToken Config { get; set; } // FIXME: This property will become an`IPublishedElement`
        }

        public class GridEditor
        {
            [JsonProperty("name")]
            public string Name { get; set; }

            [JsonProperty("alias")]
            public string Alias { get; set; }

            [JsonProperty("view")]
            public string View { get; set; }

            [JsonProperty("render")]
            public string Render { get; set; }

            [JsonProperty("icon")]
            public string Icon { get; set; }

            [JsonProperty("config")]
            public IDictionary<string, object> Config { get; set; }
        }
    }
}
