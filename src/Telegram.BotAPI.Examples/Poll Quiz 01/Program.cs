﻿// Copyright (c) 2023 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using System;
using System.Linq;
using Telegram.BotAPI;
using Telegram.BotAPI.AvailableMethods;
using Telegram.BotAPI.AvailableTypes;
using Telegram.BotAPI.GettingUpdates;

namespace Poll_Quiz_01
{
	class Program
	{
		static void Main()
		{
			Console.WriteLine("Start!");

			var bot = new BotClient("<BOT TOKEN>");
			bot.SetMyCommands(new BotCommand("quiz", "New quiz"));

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
								if (update.Message.Text.Contains("/quiz"))
								{
									bot.SendPoll(
										new SendPollArgs(
											update.Message.Chat.Id,
											"¿5 + 5?",
											new string[] { "56", "7", "10", "-4" })
										{
											Type = "quiz",
											CorrectOptionId = 2
										});
								}
								break;
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
