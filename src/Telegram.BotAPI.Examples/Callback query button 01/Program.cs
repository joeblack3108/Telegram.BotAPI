﻿// Copyright (c) 2023 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using System;
using System.Linq;
using Telegram.BotAPI;
using Telegram.BotAPI.AvailableMethods;
using Telegram.BotAPI.AvailableTypes;
using Telegram.BotAPI.GettingUpdates;
using Telegram.BotAPI.UpdatingMessages;

namespace CallbackQueryButton01
{
	class Program
	{
		static void Main()
		{
			Console.WriteLine("Start!");

			var bot = new BotClient("<your bot token>");
			bot.SetMyCommands(new BotCommand("callback", "new callback"));

			// Long Polling
			var updates = bot.GetUpdates();
			while (true)
			{
				if (updates.Length > 0)
				{
					foreach (var update in updates)
					{
						switch (update.Type)
						{
							case UpdateType.Message:
								var message = update.Message;
								if (message.Text.Contains("/callback"))
								{
									var replyMarkup = new InlineKeyboardMarkup
									{
										InlineKeyboard = new InlineKeyboardButton[][]{
										new InlineKeyboardButton[]{
											InlineKeyboardButton.SetCallbackData("Callback", "callback_data")
											}
										}
									};
									bot.SendMessage(message.Chat.Id, "Message with callback data", replyMarkup: replyMarkup);
								}
								break;
							case UpdateType.CallbackQuery:
								var query = update.CallbackQuery;
								bot.AnswerCallbackQuery(query.Id, "HELLO");
								bot.EditMessageText(new EditMessageTextArgs($"Click!\n\n{query.Data}")
								{
									ChatId = query.Message.Chat.Id,
									MessageId = query.Message.MessageId
								});
								break;
						}
					}
					updates = updates = bot.GetUpdates(offset: updates.Max(u => u.UpdateId) + 1);
				}
				else
				{
					updates = bot.GetUpdates();
				}
			}
		}
	}
}
