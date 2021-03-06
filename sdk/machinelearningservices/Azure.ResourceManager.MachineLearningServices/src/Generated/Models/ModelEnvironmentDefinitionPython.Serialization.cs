// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearningServices.Models
{
    public partial class ModelEnvironmentDefinitionPython : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(InterpreterPath))
            {
                writer.WritePropertyName("interpreterPath");
                writer.WriteStringValue(InterpreterPath);
            }
            if (Optional.IsDefined(UserManagedDependencies))
            {
                writer.WritePropertyName("userManagedDependencies");
                writer.WriteBooleanValue(UserManagedDependencies.Value);
            }
            if (Optional.IsDefined(CondaDependencies))
            {
                writer.WritePropertyName("condaDependencies");
                writer.WriteObjectValue(CondaDependencies);
            }
            if (Optional.IsDefined(BaseCondaEnvironment))
            {
                writer.WritePropertyName("baseCondaEnvironment");
                writer.WriteStringValue(BaseCondaEnvironment);
            }
            writer.WriteEndObject();
        }

        internal static ModelEnvironmentDefinitionPython DeserializeModelEnvironmentDefinitionPython(JsonElement element)
        {
            Optional<string> interpreterPath = default;
            Optional<bool> userManagedDependencies = default;
            Optional<object> condaDependencies = default;
            Optional<string> baseCondaEnvironment = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("interpreterPath"))
                {
                    interpreterPath = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("userManagedDependencies"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    userManagedDependencies = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("condaDependencies"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    condaDependencies = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("baseCondaEnvironment"))
                {
                    baseCondaEnvironment = property.Value.GetString();
                    continue;
                }
            }
            return new ModelEnvironmentDefinitionPython(interpreterPath.Value, Optional.ToNullable(userManagedDependencies), condaDependencies.Value, baseCondaEnvironment.Value);
        }
    }
}
