﻿// Copyright (c) 2023 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using System;
using System.Linq;
using Telegram.BotAPI;
using Telegram.BotAPI.AvailableMethods;
using Telegram.BotAPI.GettingUpdates;

namespace HelloWorld
{
	class Program
	{
		static void Main()
		{
			Console.WriteLine("Start!");

			var bot = new BotClient("<your bot token>");

			// Long POlling
			var updates = bot.GetUpdates();
			while (true)
			{
				if (updates.Length > 0)
				{
					foreach (var update in updates)
					{
						if (update.Type == UpdateType.Message)
						{
							var message = update.Message;
							//bot.SendChatAction(message.Chat.Id, ChatAction.Typing);
							bot.SendMessage(message.Chat.Id, "Hello World!");
						}
					}
					updates = bot.GetUpdates(offset: updates.Max(u => u.UpdateId) + 1);
				}
				else
				{
					updates = bot.GetUpdates();
				}
			}
		}
	}
}
