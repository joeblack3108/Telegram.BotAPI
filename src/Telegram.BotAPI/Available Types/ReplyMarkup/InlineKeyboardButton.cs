// Copyright (c) 2023 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using Telegram.BotAPI.Games;


namespace Telegram.BotAPI.AvailableTypes
{
	/// <summary>This object represents one button of an inline keyboard. You must use exactly one of the optional fields.</summary>
	[JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
	public sealed class InlineKeyboardButton : IEquatable<InlineKeyboardButton?>
	{
		/// <summary>
		/// Initialize a new instance of <see cref="InlineKeyboardButton"/>.
		/// </summary>
		public InlineKeyboardButton()
		{
		}

		/// <summary>
		/// Initialize a new instance of <see cref="InlineKeyboardButton"/>.
		/// </summary>
		/// <param name="text">Label text on the button.</param>
		/// <exception cref="ArgumentNullException"></exception>
		public InlineKeyboardButton(string text)
		{
			this.Text = text ?? throw new ArgumentNullException(nameof(text));
		}

		///<summary>Label text on the button.</summary>
		[JsonPropertyName(PropertyNames.Text)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public string Text { get; set; }
		///<summary>Optional. HTTP or tg:// url to be opened when button is pressed.</summary>
		[JsonPropertyName(PropertyNames.Url)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public string? Url { get; set; }
		///<summary>Optional. An HTTPS URL used to automatically authorize the user. Can be used as a replacement for the Telegram Login Widget.</summary>
		[JsonPropertyName(PropertyNames.LoginUrl)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public LoginUrl? LoginUrl { get; set; }
		///<summary>Optional. Data to be sent in a callback query to the bot when button is pressed, 1-64 bytes.</summary>
		[JsonPropertyName(PropertyNames.CallbackData)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public string? CallbackData { get; set; }
		/// <summary>
		/// Optional. Description of the Web App that will be launched when the user presses the button. The Web App will be able to send an arbitrary message on behalf of the user using the method answerWebAppQuery. Available only in private chats between a user and the bot.
		/// </summary>
		[JsonPropertyName(PropertyNames.WebApp)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public WebAppInfo? WebApp { get; set; }
		///<summary>
		///Optional. If set, pressing the button will prompt the user to select one of their chats, open that chat and insert the bot‘s username and the specified inline query in the input field. Can be empty, in which case just the bot’s username will be inserted.<para>Note: This offers an easy way for users to start using your bot in inline mode when they are currently in a private chat with it. Especially useful when combined with switch_pm… actions – in this case the user will be automatically returned to the chat they switched from, skipping the chat selection screen.</para>
		///</summary>
		[JsonPropertyName(PropertyNames.SwitchInlineQuery)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public string? SwitchInlineQuery { get; set; }
		///<summary>Optional. If set, pressing the button will insert the bot‘s username and the specified inline query in the current chat's input field. Can be empty, in which case only the bot’s username will be inserted.</summary>
		[JsonPropertyName(PropertyNames.SwitchInlineQueryCurrentChat)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public string? SwitchInlineQueryCurrentChat { get; set; }
		///<summary>Optional. Description of the game that will be launched when the user presses the button.<para>NOTE: This type of button must always be the first button in the first row.</para></summary>
		[JsonPropertyName(PropertyNames.CallbackGame)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public CallbackGame? CallbackGame { get; set; }
		///<summary>Optional. Specify True, to send a Pay button.<para>NOTE: This type of button must always be the first button in the first row.</para></summary>
		[JsonPropertyName(PropertyNames.Pay)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public bool? Pay { get; set; }
		///<summary>Button Type.</summary>
		[System.Text.Json.Serialization.JsonIgnore]
		[Newtonsoft.Json.JsonIgnore]
		public InlineKeyboardButtonType Type
		{
			get
			{
				if (this.Url != default)
				{
					return InlineKeyboardButtonType.Url;
				}

				if (this.LoginUrl != default)
				{
					return InlineKeyboardButtonType.LoginUrl;
				}

				if (this.CallbackData != default)
				{
					return InlineKeyboardButtonType.CallbackData;
				}

				if (this.SwitchInlineQuery != default)
				{
					return InlineKeyboardButtonType.SwitchInlineQuery;
				}

				if (this.SwitchInlineQueryCurrentChat != default)
				{
					return InlineKeyboardButtonType.SwitchInlineQueryCurrentChat;
				}

				if (this.CallbackGame != default)
				{
					return InlineKeyboardButtonType.CallbackGame;
				}

				if (this.Pay != default)
				{
					return InlineKeyboardButtonType.Pay;
				}

				return InlineKeyboardButtonType.Unknown;
			}
		}

		/// <summary>Create a new <see cref="InlineKeyboardButton"/> with a url.</summary>
		/// <param name="text">Button text.</param>
		/// <param name="url">Url.</param>
		/// <returns><see cref="InlineKeyboardButton"/></returns>
		public static InlineKeyboardButton SetUrl(string text, string url)
		{
			return new InlineKeyboardButton(text) { Url = url };
		}

		/// <summary>Create a new <see cref="InlineKeyboardButton"/> with a <see cref="LoginUrl"/>.</summary>
		/// <param name="text">Button text.</param>
		/// <param name="loginUrl">A <see cref="LoginUrl"/></param>
		/// <returns><see cref="InlineKeyboardButton"/></returns>
		public static InlineKeyboardButton SetLoginUrl(string text, LoginUrl loginUrl)
		{
			return new InlineKeyboardButton(text) { LoginUrl = loginUrl };
		}

		/// <summary>Create a new <see cref="InlineKeyboardButton"/> with a Callback data.</summary>
		/// <param name="text">Button text.</param>
		/// <param name="callbackData">Callback data.</param>
		/// <returns><see cref="InlineKeyboardButton"/></returns>
		public static InlineKeyboardButton SetCallbackData(string text, string callbackData)
		{
			return new InlineKeyboardButton(text) { CallbackData = callbackData };
		}

		/// <summary>Create a new <see cref="InlineKeyboardButton"/> with a inline query.</summary>
		/// <param name="text">Button text.</param>
		/// <param name="switchInlineQuery">Inline query.</param>
		/// <returns><see cref="InlineKeyboardButton"/></returns>
		public static InlineKeyboardButton SetSwitchInlineQuery(string text, string switchInlineQuery)
		{
			return new InlineKeyboardButton(text) { SwitchInlineQuery = switchInlineQuery };
		}

		/// <summary>Create a new <see cref="InlineKeyboardButton"/> with a inline query for the current chat.</summary>
		/// <param name="text">Button text.</param>
		/// <param name="switchInlineQueryCurrentChat">Inline query.</param>
		/// <returns><see cref="InlineKeyboardButton"/></returns>
		public static InlineKeyboardButton SetSwitchInlineQueryCurrentChat(string text, string switchInlineQueryCurrentChat)
		{
			return new InlineKeyboardButton(text) { SwitchInlineQueryCurrentChat = switchInlineQueryCurrentChat };
		}

		/// <summary>Create a new <see cref="InlineKeyboardButton"/> with a callback game.</summary>
		/// <param name="text">Button text.</param>
		/// <param name="callbackGame">Callback game.</param>
		/// <returns><see cref="InlineKeyboardButton"/></returns>
		public static InlineKeyboardButton SetCallbackGame(string text, CallbackGame callbackGame)
		{
			return new InlineKeyboardButton(text) { CallbackGame = callbackGame };
		}

		/// <summary>Create a new <see cref="InlineKeyboardButton"/> for pay.</summary>
		/// <param name="text">Button text.</param>
		/// <returns><see cref="InlineKeyboardButton"/></returns>
		public static InlineKeyboardButton SetPay(string text)
		{
			return new InlineKeyboardButton(text) { Pay = true };
		}

		/// <summary>Create a new <see cref="InlineKeyboardButton"/> for pay.</summary>
		/// <param name="text">Button text.</param>
		/// <param name="webApp">Description of the Web App that will be launched when the user presses the button. The Web App will be able to send an arbitrary message on behalf of the user using the method answerWebAppQuery. Available only in private chats between a user and the bot.</param>
		/// <returns><see cref="InlineKeyboardButton"/></returns>
		public static InlineKeyboardButton SetWebApp(string text, WebAppInfo webApp)
		{
			return new InlineKeyboardButton(text) { WebApp = webApp };
		}
		/// <inheritdoc/>
		public override bool Equals(object? obj)
		{
			return this.Equals(obj as InlineKeyboardButton);
		}
		/// <inheritdoc/>
		public bool Equals(InlineKeyboardButton? other)
		{
			return other != null &&
				   this.Text == other.Text &&
				   this.Url == other.Url &&
				   EqualityComparer<LoginUrl?>.Default.Equals(this.LoginUrl, other.LoginUrl) &&
				   this.CallbackData == other.CallbackData &&
				   this.SwitchInlineQuery == other.SwitchInlineQuery &&
				   this.SwitchInlineQueryCurrentChat == other.SwitchInlineQueryCurrentChat &&
				   EqualityComparer<CallbackGame?>.Default.Equals(this.CallbackGame, other.CallbackGame) &&
				   this.Pay == other.Pay &&
				   this.Type == other.Type;
		}
		/// <inheritdoc/>
		public override int GetHashCode()
		{
			int hashCode = -980269886;
			hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.Text);
			hashCode = hashCode * -1521134295 + EqualityComparer<string?>.Default.GetHashCode(this.Url);
			hashCode = hashCode * -1521134295 + EqualityComparer<LoginUrl?>.Default.GetHashCode(this.LoginUrl);
			hashCode = hashCode * -1521134295 + EqualityComparer<string?>.Default.GetHashCode(this.CallbackData);
			hashCode = hashCode * -1521134295 + EqualityComparer<string?>.Default.GetHashCode(this.SwitchInlineQuery);
			hashCode = hashCode * -1521134295 + EqualityComparer<string?>.Default.GetHashCode(this.SwitchInlineQueryCurrentChat);
			hashCode = hashCode * -1521134295 + EqualityComparer<CallbackGame?>.Default.GetHashCode(this.CallbackGame);
			hashCode = hashCode * -1521134295 + this.Pay.GetHashCode();
			hashCode = hashCode * -1521134295 + this.Type.GetHashCode();
			return hashCode;
		}
		/// <inheritdoc/>
		public static bool operator ==(InlineKeyboardButton? left, InlineKeyboardButton? right)
		{
#pragma warning disable CS8604 // Possible null reference argument.
			return EqualityComparer<InlineKeyboardButton>.Default.Equals(left!, right!);
#pragma warning restore CS8604 // Possible null reference argument.
		}
		/// <inheritdoc/>
		public static bool operator !=(InlineKeyboardButton? left, InlineKeyboardButton? right)
		{
			return !(left == right);
		}

	}
}
