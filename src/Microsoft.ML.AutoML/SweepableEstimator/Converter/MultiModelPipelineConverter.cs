﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace Microsoft.ML.AutoML
{
    internal class MultiModelPipelineConverter : JsonConverter<MultiModelPipeline>
    {
        public override MultiModelPipeline Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var jValue = JsonValue.Parse(ref reader);
            var schema = jValue["schema"].GetValue<string>();
            var estimators = jValue["estimator"].GetValue<Dictionary<string, SweepableEstimator>>();

            return new MultiModelPipeline(estimators, Entity.FromExpression(schema));
        }

        public override void Write(Utf8JsonWriter writer, MultiModelPipeline value, JsonSerializerOptions options)
        {
            var jsonObject = JsonNode.Parse("{}");
            jsonObject["schema"] = value.Schema.ToString();
            jsonObject["estimators"] = JsonValue.Create(value.Estimators);

            jsonObject.WriteTo(writer, options);
        }
    }
}
