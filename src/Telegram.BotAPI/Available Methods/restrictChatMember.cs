// Copyright (c) 2023 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using System.Threading;
using System.Threading.Tasks;
using Telegram.BotAPI.AvailableTypes;

namespace Telegram.BotAPI.AvailableMethods
{
	public static partial class AvailableMethodsExtensions
	{
		/// <summary>Use this method to restrict a user in a supergroup. The bot must be an administrator in the supergroup for this to work and must have the appropriate admin rights. Pass True for all boolean parameters to lift restrictions from a user. Returns True on success.</summary>
		/// <param name="bot">BotClient</param>
		/// <param name="args">Parameters</param>
		/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
		/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
		public static bool RestrictChatMember(this BotClient? bot, RestrictChatMemberArgs args)
		{
			if (bot == default)
			{
				throw new ArgumentNullException(nameof(bot));
			}

			if (args == default)
			{
				throw new ArgumentNullException(nameof(args));
			}

			return bot.RPC<bool>(MethodNames.RestrictChatMember, args);
		}

		/// <summary>Use this method to restrict a user in a supergroup. The bot must be an administrator in the supergroup for this to work and must have the appropriate administrator rights. Pass True for all permissions to lift restrictions from a user. Returns True on success.</summary>
		/// <param name="bot">BotClient</param>
		/// <param name="chatId">Unique identifier for the target chat or username of the target supergroup (in the format @supergroupusername)</param>
		/// <param name="userId">Unique identifier of the target user</param>
		/// <param name="permissions">A JSON-serialized object for new user permissions</param>
		/// <param name="untilDate">Date when restrictions will be lifted for the user, unix time. If user is restricted for more than 366 days or less than 30 seconds from the current time, they are considered to be restricted forever</param>
		/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
		/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
		public static bool RestrictChatMember(this BotClient? bot, long chatId, long userId, ChatPermissions permissions, [Optional] uint? untilDate)
		{
			if (bot == null)
			{
				throw new NullReferenceException(nameof(bot));
			}
			var args = new RestrictChatMemberArgs(chatId, userId, permissions)
			{
				UntilDate = untilDate
			};

			return bot.RPC<bool>(MethodNames.RestrictChatMember, args);
		}

		/// <summary>Use this method to restrict a user in a supergroup. The bot must be an administrator in the supergroup for this to work and must have the appropriate administrator rights. Pass True for all permissions to lift restrictions from a user. Returns True on success.</summary>
		/// <param name="bot">BotClient</param>
		/// <param name="chatId">Unique identifier for the target chat or username of the target supergroup (in the format @supergroupusername)</param>
		/// <param name="userId">Unique identifier of the target user</param>
		/// <param name="permissions">A JSON-serialized object for new user permissions</param>
		/// <param name="untilDate">Date when restrictions will be lifted for the user, unix time. If user is restricted for more than 366 days or less than 30 seconds from the current time, they are considered to be restricted forever</param>
		/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
		/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
		public static bool RestrictChatMember(this BotClient? bot, string chatId, long userId, ChatPermissions permissions, [Optional] uint? untilDate)
		{
			if (bot == null)
			{
				throw new NullReferenceException(nameof(bot));
			}
			var args = new RestrictChatMemberArgs(chatId, userId, permissions)
			{
				UntilDate = untilDate
			};

			return bot.RPC<bool>(MethodNames.RestrictChatMember, args);
		}

		/// <summary>Use this method to restrict a user in a supergroup. The bot must be an administrator in the supergroup for this to work and must have the appropriate admin rights. Pass True for all boolean parameters to lift restrictions from a user. Returns True on success.</summary>
		/// <param name="bot">BotClient</param>
		/// <param name="args">Parameters</param>
		/// <param name="cancellationToken">The cancellation token to cancel operation.</param>
		/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
		/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
		public static async Task<bool> RestrictChatMemberAsync(this BotClient? bot, RestrictChatMemberArgs args, [Optional] CancellationToken cancellationToken)
		{
			if (bot == default)
			{
				throw new ArgumentNullException(nameof(bot));
			}

			if (args == default)
			{
				throw new ArgumentNullException(nameof(args));
			}

			return await bot.RPCA<bool>(MethodNames.RestrictChatMember, args, cancellationToken: cancellationToken).ConfigureAwait(false);
		}

		/// <summary>Use this method to restrict a user in a supergroup. The bot must be an administrator in the supergroup for this to work and must have the appropriate administrator rights. Pass True for all permissions to lift restrictions from a user. Returns True on success.</summary>
		/// <param name="bot">BotClient</param>
		/// <param name="chatId">Unique identifier for the target chat or username of the target supergroup (in the format @supergroupusername)</param>
		/// <param name="userId">Unique identifier of the target user</param>
		/// <param name="permissions">A JSON-serialized object for new user permissions</param>
		/// <param name="untilDate">Date when restrictions will be lifted for the user, unix time. If user is restricted for more than 366 days or less than 30 seconds from the current time, they are considered to be restricted forever</param>
		/// <param name="cancellationToken">The cancellation token to cancel operation.</param>
		/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
		/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
		public static async Task<bool> RestrictChatMemberAsync(this BotClient? bot, long chatId, long userId, ChatPermissions permissions, [Optional] uint? untilDate, [Optional] CancellationToken cancellationToken)
		{
			if (bot == default)
			{
				throw new ArgumentNullException(nameof(bot));
			}

			var args = new RestrictChatMemberArgs(chatId, userId, permissions)
			{
				UntilDate = untilDate
			};

			return await bot.RPCA<bool>(MethodNames.RestrictChatMember, args, cancellationToken: cancellationToken).ConfigureAwait(false);
		}
		/// <summary>Use this method to restrict a user in a supergroup. The bot must be an administrator in the supergroup for this to work and must have the appropriate administrator rights. Pass True for all permissions to lift restrictions from a user. Returns True on success.</summary>
		/// <param name="bot">BotClient</param>
		/// <param name="chatId">Unique identifier for the target chat or username of the target supergroup (in the format @supergroupusername)</param>
		/// <param name="userId">Unique identifier of the target user</param>
		/// <param name="permissions">A JSON-serialized object for new user permissions</param>
		/// <param name="untilDate">Date when restrictions will be lifted for the user, unix time. If user is restricted for more than 366 days or less than 30 seconds from the current time, they are considered to be restricted forever</param>
		/// <param name="cancellationToken">The cancellation token to cancel operation.</param>
		/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
		/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
		public static async Task<bool> RestrictChatMemberAsync(this BotClient? bot, string chatId, long userId, ChatPermissions permissions, [Optional] uint? untilDate, [Optional] CancellationToken cancellationToken)
		{
			if (bot == default)
			{
				throw new ArgumentNullException(nameof(bot));
			}

			var args = new RestrictChatMemberArgs(chatId, userId, permissions)
			{
				UntilDate = untilDate
			};

			return await bot.RPCA<bool>(MethodNames.RestrictChatMember, args, cancellationToken: cancellationToken).ConfigureAwait(false);
		}
	}
}
