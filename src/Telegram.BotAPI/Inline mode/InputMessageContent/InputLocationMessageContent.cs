// Copyright (c) 2023 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Telegram.BotAPI.InlineMode
{
	/// <summary>Represents the content of a location message to be sent as the result of an inline query.</summary>
	[JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
	public sealed class InputLocationMessageContent : InputMessageContent, ILocation, IEquatable<InputLocationMessageContent>
	{
		/// <summary>
		/// Initialize a new instance of <see cref="InputLocationMessageContent"/>.
		/// </summary>
		/// <param name="longitude">Longitude as defined by sender.</param>
		/// <param name="latitude">Latitude as defined by sender.</param>
		public InputLocationMessageContent(float longitude, float latitude)
		{
			this.Longitude = longitude;
			this.Latitude = latitude;
		}

		/// <summary>
		/// Initialize a new instance of <see cref="InputLocationMessageContent"/>.
		/// </summary>
		/// <param name="location">Location.</param>
		public InputLocationMessageContent(ILocation location) : this(location.Longitude, location.Latitude)
		{
			if (location == null)
			{
				throw new ArgumentNullException(nameof(location));
			}

			this.HorizontalAccuracy = location.HorizontalAccuracy;
			this.LivePeriod = location.LivePeriod;
			this.Heading = location.Heading;
			this.ProximityAlertRadius = location.ProximityAlertRadius;
		}

		///<summary>Longitude as defined by sender.</summary>
		[JsonPropertyName(PropertyNames.Longitude)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public float Longitude { get; }
		///<summary>Latitude as defined by sender.</summary>
		[JsonPropertyName(PropertyNames.Latitude)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public float Latitude { get; }
		///<summary>Optional. The radius of uncertainty for the location, measured in meters; 0-1500.</summary>
		[JsonPropertyName(PropertyNames.HorizontalAccuracy)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public float? HorizontalAccuracy { get; set; }
		///<summary>Optional. Time relative to the message sending date, during which the location can be updated, in seconds. For active live locations only.</summary>
		[JsonPropertyName(PropertyNames.LivePeriod)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public uint? LivePeriod { get; set; }
		///<summary>Optional. The direction in which user is moving, in degrees; 1-360. For active live locations only.</summary>
		[JsonPropertyName(PropertyNames.Heading)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public ushort? Heading { get; set; }
		///<summary>Optional. Maximum distance for proximity alerts about approaching another chat member, in meters. For sent live locations only.</summary>
		[JsonPropertyName(PropertyNames.ProximityAlertRadius)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public uint? ProximityAlertRadius { get; set; }
		/// <inheritdoc/>
		public override bool Equals(object obj)
		{
			return this.Equals(obj as InputLocationMessageContent);
		}
		/// <inheritdoc/>
		public bool Equals(InputLocationMessageContent? other)
		{
			return other != null &&
				   this.Longitude == other.Longitude &&
				   this.Latitude == other.Latitude &&
				   this.HorizontalAccuracy == other.HorizontalAccuracy &&
				   this.LivePeriod == other.LivePeriod &&
				   this.Heading == other.Heading &&
				   this.ProximityAlertRadius == other.ProximityAlertRadius;
		}
		/// <inheritdoc/>
		public override int GetHashCode()
		{
			int hashCode = 1466495924;
			hashCode = hashCode * -1521134295 + this.Longitude.GetHashCode();
			hashCode = hashCode * -1521134295 + this.Latitude.GetHashCode();
			hashCode = hashCode * -1521134295 + this.HorizontalAccuracy.GetHashCode();
			hashCode = hashCode * -1521134295 + this.LivePeriod.GetHashCode();
			hashCode = hashCode * -1521134295 + this.Heading.GetHashCode();
			hashCode = hashCode * -1521134295 + this.ProximityAlertRadius.GetHashCode();
			return hashCode;
		}
		/// <inheritdoc/>
		public static bool operator ==(InputLocationMessageContent? left, InputLocationMessageContent? right)
		{
			return EqualityComparer<InputLocationMessageContent>.Default.Equals(left!, right!);
		}
		/// <inheritdoc/>
		public static bool operator !=(InputLocationMessageContent? left, InputLocationMessageContent? right)
		{
			return !(left == right);
		}

	}
}
