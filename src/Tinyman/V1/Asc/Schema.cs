﻿using Newtonsoft.Json;

namespace Tinyman.V1.Asc {

	internal class Schema {

		[JsonProperty("num_uints")]
		public int NumUints { get; set; }

		[JsonProperty("num_byte_slices")]
		public int NumByteSlices { get; set; }

	}

}
