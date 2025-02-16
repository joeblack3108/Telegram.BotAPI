﻿// Copyright (c) 2023 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using System.Text.Json;
using Telegram.BotAPI.AvailableTypes;

namespace Telegram.BotAPI.Converters
{
	/// <summary>
	/// Converts an <see cref="InputMedia"/> to or from JSON.
	/// </summary>
	public sealed class InputMediaConverter : JsonConverter<InputMedia>
	{
		/// <summary>
		/// Reads and converts the JSON to type <see cref="InputMedia"/>.
		/// </summary>
		/// <param name="reader">The reader.</param>
		/// <param name="typeToConvert">The type to convert.</param>
		/// <param name="options">An object that specifies serialization options to use.</param>
		/// <returns>The converted value.</returns>
		public override InputMedia? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			var jsonDoc = JsonSerializer.Deserialize<JsonDocument>(ref reader, options)!;
			var isValid = jsonDoc.RootElement.TryGetProperty(PropertyNames.Type, out JsonElement prop);
			var rawText = jsonDoc.RootElement.GetRawText();
			if (isValid)
			{
				if (prop.ValueKind != JsonValueKind.String)
					throw new JsonException($"Property type of {PropertyNames.Type} must be a String.");
				var type = prop.GetString();
				return type switch
				{
					InputMediaType.Animation => JsonSerializer.Deserialize<InputMediaAnimation>(rawText, options),
					InputMediaType.Audio => JsonSerializer.Deserialize<InputMediaAudio>(rawText, options),
					InputMediaType.Document => JsonSerializer.Deserialize<InputMediaDocument>(rawText, options),
					InputMediaType.Photo => JsonSerializer.Deserialize<InputMediaPhoto>(rawText, options),
					InputMediaType.Video => JsonSerializer.Deserialize<InputMediaVideo>(rawText, options),
					_ => throw new JsonException($"Json object is not a valid InputMedia."),
				};
			}
			else
			{
				throw new JsonException($"Missing required property: {PropertyNames.Type}");
			}
		}

		/// <summary>
		/// Writes a <see cref="InputMedia"/> object as JSON.
		/// </summary>
		/// <param name="writer">The writer to write to.</param>
		/// <param name="value">The value to convert to JSON.</param>
		/// <param name="options">An object that specifies serialization options to use.</param>
		public override void Write(Utf8JsonWriter writer, InputMedia value, JsonSerializerOptions options)
		{
			if (value == null)
			{
				throw new ArgumentNullException(nameof(value));
			}
			var type = value.GetType();
			JsonSerializer.Serialize(writer, value, type, options);
		}
	}
}
