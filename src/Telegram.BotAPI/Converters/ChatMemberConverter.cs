﻿// Copyright (c) 2023 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using System.Text.Json;
using Telegram.BotAPI.AvailableTypes;

namespace Telegram.BotAPI.Converters
{
	/// <summary>Converts an <see cref="ChatMember"/> to or from JSON.</summary>
	public sealed class ChatMemberConverter : JsonConverter<ChatMember>
	{
		/// <summary>
		/// Reads and converts the JSON to type <see cref="ChatMember"/>.
		/// </summary>
		/// <param name="reader">The reader.</param>
		/// <param name="typeToConvert">The type to convert.</param>
		/// <param name="options">An object that specifies serialization options to use.</param>
		/// <returns>The converted value.</returns>
		public override ChatMember? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			var jsonDoc = JsonSerializer.Deserialize<JsonDocument>(ref reader, options)!;
			var isValid = jsonDoc.RootElement.TryGetProperty(PropertyNames.Status, out JsonElement prop);
			var rawText = jsonDoc.RootElement.GetRawText();
			if (isValid)
			{
				if (prop.ValueKind != JsonValueKind.String)
					throw new JsonException($"Property type of {PropertyNames.Status} must be a String.");
				var status = prop.GetString();
				return status switch
				{
					ChatMemberStatus.Creator => JsonSerializer.Deserialize<ChatMemberOwner>(rawText, options),
					ChatMemberStatus.Administrator => JsonSerializer.Deserialize<ChatMemberAdministrator>(rawText, options),
					ChatMemberStatus.Member => JsonSerializer.Deserialize<ChatMemberMember>(rawText, options),
					ChatMemberStatus.Restricted => JsonSerializer.Deserialize<ChatMemberRestricted>(rawText, options),
					ChatMemberStatus.Left => JsonSerializer.Deserialize<ChatMemberLeft>(rawText, options),
					ChatMemberStatus.Kicked => JsonSerializer.Deserialize<ChatMemberBanned>(rawText, options),
					_ => throw new JsonException($"Json object is not a valid chat member."),
				};
			}
			else
			{
				throw new JsonException($"Missing required property: {PropertyNames.Status}");
			}
		}

		/// <summary>
		/// Writes a <see cref="ChatMember"/> object as JSON.
		/// </summary>
		/// <param name="writer">The writer to write to.</param>
		/// <param name="value">The value to convert to JSON.</param>
		/// <param name="options">An object that specifies serialization options to use.</param>
		public override void Write(Utf8JsonWriter writer, ChatMember value, JsonSerializerOptions options)
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
