// Copyright (c) 2021 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Telegram.BotAPI.AvailableTypes;

namespace Telegram.BotAPI.AvailableMethods
{
    public static partial class AvailableMethodsExtensions
    {
        /// <summary>Use this method to send general files. On success, the sent Message is returned.</summary>
        /// <param name="bot">BotClient</param>
        /// <param name="args">Parameters.</param>
        /// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
        /// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
        /// <returns>Message Object.</returns>
        public static Message SendDocument(this BotClient bot, SendDocumentArgs args)
        {
            if (bot == default)
            {
                throw new ArgumentNullException(nameof(bot));
            }

            if (args == default)
            {
                throw new ArgumentNullException(nameof(args));
            }

            return bot.RPCF<Message>(MethodNames.SendDocument, args);
        }

        /// <summary>Use this method to send general files. On success, the sent Message is returned.</summary>
        /// <param name="bot">BotClient</param>
        /// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
        /// <param name="document">File to send. Pass a file_id as String to send a file that exists on the Telegram servers (recommended), pass an HTTP URL as a String for Telegram to get a file from the Internet, or upload a new one using multipart/form-data.</param>
        /// <param name="thumb">Optional. InputFile or String. Thumbnail of the file sent. The thumbnail should be in JPEG format and less than 200 kB in size. A thumbnail�s width and height should not exceed 90. Ignored if the file is not uploaded using multipart/form-data.</param>
        /// <param name="caption">Document caption (may also be used when resending documents by file_id), 0-1024 characters after entities parsing.</param>
        /// <param name="parseMode">Mode for parsing entities in the document caption. See <a href="https://core.telegram.org/bots/api#formatting-options">formatting options</a> for more details.</param>
        /// <param name="captionEntities">List of special entities that appear in the caption, which can be specified instead of parse_mode</param>
        /// <param name="disableContentTypeDetection">Optional. Disables automatic server-side content type detection for files uploaded using multipart/form-data. Always true, if the document is sent as part of an album.</param>
        /// <param name="disableNotification">Optional. Sends the message <a href="https://telegram.org/blog/channels-2-0#silent-messages">silently</a>. Users will receive a notification with no sound.</param>
        /// <param name="replyToMessageId">If the message is a reply, ID of the original message.</param>
        /// <param name="allowSendingWithoutReply">Pass True, if the message should be sent even if the specified replied-to message is not found.</param>
        /// <param name="replyMarkup">Optional. Additional interface options. A JSON-serialized object for an inline keyboard, custom reply keyboard, instructions to remove reply keyboard or to force a reply from the user. <see cref="InlineKeyboardMarkup"/> or <see cref="ReplyKeyboardMarkup"/> or <see cref="ReplyKeyboardRemove"/> or <see cref="ForceReply"/></param>
        /// <param name="attachFiles">Attached files.</param>
        /// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
        /// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
        /// <returns>Message Object.</returns>
        public static Message SendDocument(this BotClient bot, long chatId, string document, [Optional] string thumb, [Optional] string caption, [Optional] string parseMode, [Optional] MessageEntity[] captionEntities, [Optional] bool? disableContentTypeDetection, [Optional] bool? disableNotification, [Optional] int? replyToMessageId, [Optional] bool? allowSendingWithoutReply, [Optional] ReplyMarkup replyMarkup, [Optional] List<AttachFile> attachFiles)
        {
            return bot.SendDocument(new SendDocumentArgs
            {
                ChatId = chatId,
                Document = document,
                Thumb = thumb,
                Caption = caption,
                ParseMode = parseMode,
                CaptionEntities = captionEntities,
                DisableContentTypeDetection = disableContentTypeDetection,
                DisableNotification = disableNotification,
                ReplyToMessageId = replyToMessageId,
                AllowSendingWithoutReply = allowSendingWithoutReply,
                ReplyMarkup = replyMarkup,
                AttachFiles = attachFiles
            });
        }

        /// <summary>Use this method to send general files. On success, the sent Message is returned.</summary>
        /// <param name="bot">BotClient</param>
        /// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
        /// <param name="document">File to send. Pass a file_id as String to send a file that exists on the Telegram servers (recommended), pass an HTTP URL as a String for Telegram to get a file from the Internet, or upload a new one using multipart/form-data.</param>
        /// <param name="thumb">Optional. InputFile or String. Thumbnail of the file sent. The thumbnail should be in JPEG format and less than 200 kB in size. A thumbnail�s width and height should not exceed 90. Ignored if the file is not uploaded using multipart/form-data.</param>
        /// <param name="caption">Document caption (may also be used when resending documents by file_id), 0-1024 characters after entities parsing.</param>
        /// <param name="parseMode">Mode for parsing entities in the document caption. See <a href="https://core.telegram.org/bots/api#formatting-options">formatting options</a> for more details.</param>
        /// <param name="captionEntities">List of special entities that appear in the caption, which can be specified instead of parse_mode</param>
        /// <param name="disableContentTypeDetection">Optional. Disables automatic server-side content type detection for files uploaded using multipart/form-data. Always true, if the document is sent as part of an album.</param>
        /// <param name="disableNotification">Optional. Sends the message <a href="https://telegram.org/blog/channels-2-0#silent-messages">silently</a>. Users will receive a notification with no sound.</param>
        /// <param name="replyToMessageId">If the message is a reply, ID of the original message.</param>
        /// <param name="allowSendingWithoutReply">Pass True, if the message should be sent even if the specified replied-to message is not found.</param>
        /// <param name="replyMarkup">Optional. Additional interface options. A JSON-serialized object for an inline keyboard, custom reply keyboard, instructions to remove reply keyboard or to force a reply from the user. <see cref="InlineKeyboardMarkup"/> or <see cref="ReplyKeyboardMarkup"/> or <see cref="ReplyKeyboardRemove"/> or <see cref="ForceReply"/></param>
        /// <param name="attachFiles">Attached files.</param>
        /// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
        /// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
        /// <returns>Message Object.</returns>
        public static Message SendDocument(this BotClient bot, string chatId, string document, [Optional] string thumb, [Optional] string caption, [Optional] string parseMode, [Optional] MessageEntity[] captionEntities, [Optional] bool? disableContentTypeDetection, [Optional] bool? disableNotification, [Optional] int? replyToMessageId, [Optional] bool? allowSendingWithoutReply, [Optional] ReplyMarkup replyMarkup, [Optional] List<AttachFile> attachFiles)
        {
            return bot.SendDocument(new SendDocumentArgs
            {
                ChatId = chatId,
                Document = document,
                Thumb = thumb,
                Caption = caption,
                ParseMode = parseMode,
                CaptionEntities = captionEntities,
                DisableContentTypeDetection = disableContentTypeDetection,
                DisableNotification = disableNotification,
                ReplyToMessageId = replyToMessageId,
                AllowSendingWithoutReply = allowSendingWithoutReply,
                ReplyMarkup = replyMarkup,
                AttachFiles = attachFiles
            });
        }

        /// <summary>Use this method to send general files. On success, the sent Message is returned.</summary>
        /// <param name="bot">BotClient</param>
        /// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
        /// <param name="document">File to send. Pass a file_id as String to send a file that exists on the Telegram servers (recommended), pass an HTTP URL as a String for Telegram to get a file from the Internet, or upload a new one using multipart/form-data.</param>
        /// <param name="thumb">Optional. InputFile or String. Thumbnail of the file sent. The thumbnail should be in JPEG format and less than 200 kB in size. A thumbnail�s width and height should not exceed 90. Ignored if the file is not uploaded using multipart/form-data.</param>
        /// <param name="caption">Document caption (may also be used when resending documents by file_id), 0-1024 characters after entities parsing.</param>
        /// <param name="parseMode">Mode for parsing entities in the document caption. See <a href="https://core.telegram.org/bots/api#formatting-options">formatting options</a> for more details.</param>
        /// <param name="captionEntities">List of special entities that appear in the caption, which can be specified instead of parse_mode</param>
        /// <param name="disableContentTypeDetection">Optional. Disables automatic server-side content type detection for files uploaded using multipart/form-data. Always true, if the document is sent as part of an album.</param>
        /// <param name="disableNotification">Optional. Sends the message <a href="https://telegram.org/blog/channels-2-0#silent-messages">silently</a>. Users will receive a notification with no sound.</param>
        /// <param name="replyToMessageId">If the message is a reply, ID of the original message.</param>
        /// <param name="allowSendingWithoutReply">Pass True, if the message should be sent even if the specified replied-to message is not found.</param>
        /// <param name="replyMarkup">Optional. Additional interface options. A JSON-serialized object for an inline keyboard, custom reply keyboard, instructions to remove reply keyboard or to force a reply from the user. <see cref="InlineKeyboardMarkup"/> or <see cref="ReplyKeyboardMarkup"/> or <see cref="ReplyKeyboardRemove"/> or <see cref="ForceReply"/></param>
        /// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
        /// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
        /// <returns>Message Object.</returns>
        public static Message SendDocument(this BotClient bot, long chatId, InputFile document, [Optional] InputFile thumb, [Optional] string caption, [Optional] string parseMode, [Optional] MessageEntity[] captionEntities, [Optional] bool? disableContentTypeDetection, [Optional] bool? disableNotification, [Optional] int? replyToMessageId, [Optional] bool? allowSendingWithoutReply, [Optional] ReplyMarkup replyMarkup)
        {
            return bot.SendDocument(new SendDocumentArgs
            {
                ChatId = chatId,
                Document = document,
                Thumb = thumb,
                Caption = caption,
                ParseMode = parseMode,
                CaptionEntities = captionEntities,
                DisableContentTypeDetection = disableContentTypeDetection,
                DisableNotification = disableNotification,
                ReplyToMessageId = replyToMessageId,
                AllowSendingWithoutReply = allowSendingWithoutReply,
                ReplyMarkup = replyMarkup
            });
        }

        /// <summary>Use this method to send general files. On success, the sent Message is returned.</summary>
        /// <param name="bot">BotClient</param>
        /// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
        /// <param name="document">File to send. Pass a file_id as String to send a file that exists on the Telegram servers (recommended), pass an HTTP URL as a String for Telegram to get a file from the Internet, or upload a new one using multipart/form-data.</param>
        /// <param name="thumb">Optional. InputFile or String. Thumbnail of the file sent. The thumbnail should be in JPEG format and less than 200 kB in size. A thumbnail�s width and height should not exceed 90. Ignored if the file is not uploaded using multipart/form-data.</param>
        /// <param name="caption">Document caption (may also be used when resending documents by file_id), 0-1024 characters after entities parsing.</param>
        /// <param name="parseMode">Mode for parsing entities in the document caption. See <a href="https://core.telegram.org/bots/api#formatting-options">formatting options</a> for more details.</param>
        /// <param name="captionEntities">List of special entities that appear in the caption, which can be specified instead of parse_mode</param>
        /// <param name="disableContentTypeDetection">Optional. Disables automatic server-side content type detection for files uploaded using multipart/form-data. Always true, if the document is sent as part of an album.</param>
        /// <param name="disableNotification">Optional. Sends the message <a href="https://telegram.org/blog/channels-2-0#silent-messages">silently</a>. Users will receive a notification with no sound.</param>
        /// <param name="replyToMessageId">If the message is a reply, ID of the original message.</param>
        /// <param name="allowSendingWithoutReply">Pass True, if the message should be sent even if the specified replied-to message is not found.</param>
        /// <param name="replyMarkup">Optional. Additional interface options. A JSON-serialized object for an inline keyboard, custom reply keyboard, instructions to remove reply keyboard or to force a reply from the user. <see cref="InlineKeyboardMarkup"/> or <see cref="ReplyKeyboardMarkup"/> or <see cref="ReplyKeyboardRemove"/> or <see cref="ForceReply"/></param>
        /// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
        /// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
        /// <returns>Message Object.</returns>
        public static Message SendDocument(this BotClient bot, string chatId, InputFile document, [Optional] InputFile thumb, [Optional] string caption, [Optional] string parseMode, [Optional] MessageEntity[] captionEntities, [Optional] bool? disableContentTypeDetection, [Optional] bool? disableNotification, [Optional] int? replyToMessageId, [Optional] bool? allowSendingWithoutReply, [Optional] ReplyMarkup replyMarkup)
        {
            return bot.SendDocument(new SendDocumentArgs
            {
                ChatId = chatId,
                Document = document,
                Thumb = thumb,
                Caption = caption,
                ParseMode = parseMode,
                CaptionEntities = captionEntities,
                DisableContentTypeDetection = disableContentTypeDetection,
                DisableNotification = disableNotification,
                ReplyToMessageId = replyToMessageId,
                AllowSendingWithoutReply = allowSendingWithoutReply,
                ReplyMarkup = replyMarkup
            });
        }

        /// <summary>Use this method to send general files. On success, the sent Message is returned.</summary>
        /// <param name="bot">BotClient</param>
        /// <param name="args">Parameters.</param>
        /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
        /// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
        /// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
        /// <returns>Message Object.</returns>
        public static async Task<Message> SendDocumentAsync(this BotClient bot, SendDocumentArgs args, [Optional] CancellationToken cancellationToken)
        {
            if (bot == default)
            {
                throw new ArgumentNullException(nameof(bot));
            }

            if (args == default)
            {
                throw new ArgumentNullException(nameof(args));
            }

            return await bot.RPCAF<Message>(MethodNames.SendDocument, args, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>Use this method to send general files. On success, the sent Message is returned.</summary>
        /// <param name="bot">BotClient</param>
        /// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
        /// <param name="document">File to send. Pass a file_id as String to send a file that exists on the Telegram servers (recommended), pass an HTTP URL as a String for Telegram to get a file from the Internet, or upload a new one using multipart/form-data.</param>
        /// <param name="thumb">Optional. InputFile or String. Thumbnail of the file sent. The thumbnail should be in JPEG format and less than 200 kB in size. A thumbnail�s width and height should not exceed 90. Ignored if the file is not uploaded using multipart/form-data.</param>
        /// <param name="caption">Document caption (may also be used when resending documents by file_id), 0-1024 characters after entities parsing.</param>
        /// <param name="parseMode">Mode for parsing entities in the document caption. See <a href="https://core.telegram.org/bots/api#formatting-options">formatting options</a> for more details.</param>
        /// <param name="captionEntities">List of special entities that appear in the caption, which can be specified instead of parse_mode</param>
        /// <param name="disableContentTypeDetection">Optional. Disables automatic server-side content type detection for files uploaded using multipart/form-data. Always true, if the document is sent as part of an album.</param>
        /// <param name="disableNotification">Optional. Sends the message <a href="https://telegram.org/blog/channels-2-0#silent-messages">silently</a>. Users will receive a notification with no sound.</param>
        /// <param name="replyToMessageId">If the message is a reply, ID of the original message.</param>
        /// <param name="allowSendingWithoutReply">Pass True, if the message should be sent even if the specified replied-to message is not found.</param>
        /// <param name="replyMarkup">Optional. Additional interface options. A JSON-serialized object for an inline keyboard, custom reply keyboard, instructions to remove reply keyboard or to force a reply from the user. <see cref="InlineKeyboardMarkup"/> or <see cref="ReplyKeyboardMarkup"/> or <see cref="ReplyKeyboardRemove"/> or <see cref="ForceReply"/></param>
        /// <param name="attachFiles">Attached files.</param>
        /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
        /// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
        /// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
        /// <returns>Message Object.</returns>
        public static async Task<Message> SendDocumentAsync(this BotClient bot, long chatId, string document, [Optional] string thumb, [Optional] string caption, [Optional] string parseMode, [Optional] MessageEntity[] captionEntities, [Optional] bool? disableContentTypeDetection, [Optional] bool? disableNotification, [Optional] int? replyToMessageId, [Optional] bool? allowSendingWithoutReply, [Optional] ReplyMarkup replyMarkup, [Optional] List<AttachFile> attachFiles, [Optional] CancellationToken cancellationToken)
        {
            return await bot.SendDocumentAsync(new SendDocumentArgs
            {
                ChatId = chatId,
                Document = document,
                Thumb = thumb,
                Caption = caption,
                ParseMode = parseMode,
                CaptionEntities = captionEntities,
                DisableContentTypeDetection = disableContentTypeDetection,
                DisableNotification = disableNotification,
                ReplyToMessageId = replyToMessageId,
                AllowSendingWithoutReply = allowSendingWithoutReply,
                ReplyMarkup = replyMarkup,
                AttachFiles = attachFiles
            }, cancellationToken);
        }

        /// <summary>Use this method to send general files. On success, the sent Message is returned.</summary>
        /// <param name="bot">BotClient</param>
        /// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
        /// <param name="document">File to send. Pass a file_id as String to send a file that exists on the Telegram servers (recommended), pass an HTTP URL as a String for Telegram to get a file from the Internet, or upload a new one using multipart/form-data.</param>
        /// <param name="thumb">Optional. InputFile or String. Thumbnail of the file sent. The thumbnail should be in JPEG format and less than 200 kB in size. A thumbnail�s width and height should not exceed 90. Ignored if the file is not uploaded using multipart/form-data.</param>
        /// <param name="caption">Document caption (may also be used when resending documents by file_id), 0-1024 characters after entities parsing.</param>
        /// <param name="parseMode">Mode for parsing entities in the document caption. See <a href="https://core.telegram.org/bots/api#formatting-options">formatting options</a> for more details.</param>
        /// <param name="captionEntities">List of special entities that appear in the caption, which can be specified instead of parse_mode</param>
        /// <param name="disableContentTypeDetection">Optional. Disables automatic server-side content type detection for files uploaded using multipart/form-data. Always true, if the document is sent as part of an album.</param>
        /// <param name="disableNotification">Optional. Sends the message <a href="https://telegram.org/blog/channels-2-0#silent-messages">silently</a>. Users will receive a notification with no sound.</param>
        /// <param name="replyToMessageId">If the message is a reply, ID of the original message.</param>
        /// <param name="allowSendingWithoutReply">Pass True, if the message should be sent even if the specified replied-to message is not found.</param>
        /// <param name="replyMarkup">Optional. Additional interface options. A JSON-serialized object for an inline keyboard, custom reply keyboard, instructions to remove reply keyboard or to force a reply from the user. <see cref="InlineKeyboardMarkup"/> or <see cref="ReplyKeyboardMarkup"/> or <see cref="ReplyKeyboardRemove"/> or <see cref="ForceReply"/></param>
        /// <param name="attachFiles">Attached files.</param>
        /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
        /// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
        /// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
        /// <returns>Message Object.</returns>
        public static async Task<Message> SendDocumentAsync(this BotClient bot, string chatId, string document, [Optional] string thumb, [Optional] string caption, [Optional] string parseMode, [Optional] MessageEntity[] captionEntities, [Optional] bool? disableContentTypeDetection, [Optional] bool? disableNotification, [Optional] int? replyToMessageId, [Optional] bool? allowSendingWithoutReply, [Optional] ReplyMarkup replyMarkup, [Optional] List<AttachFile> attachFiles, [Optional] CancellationToken cancellationToken)
        {
            return await bot.SendDocumentAsync(new SendDocumentArgs
            {
                ChatId = chatId,
                Document = document,
                Thumb = thumb,
                Caption = caption,
                ParseMode = parseMode,
                CaptionEntities = captionEntities,
                DisableContentTypeDetection = disableContentTypeDetection,
                DisableNotification = disableNotification,
                ReplyToMessageId = replyToMessageId,
                AllowSendingWithoutReply = allowSendingWithoutReply,
                ReplyMarkup = replyMarkup,
                AttachFiles = attachFiles
            }, cancellationToken);
        }

        /// <summary>Use this method to send general files. On success, the sent Message is returned.</summary>
        /// <param name="bot">BotClient</param>
        /// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
        /// <param name="document">File to send. Pass a file_id as String to send a file that exists on the Telegram servers (recommended), pass an HTTP URL as a String for Telegram to get a file from the Internet, or upload a new one using multipart/form-data.</param>
        /// <param name="thumb">Optional. InputFile or String. Thumbnail of the file sent. The thumbnail should be in JPEG format and less than 200 kB in size. A thumbnail�s width and height should not exceed 90. Ignored if the file is not uploaded using multipart/form-data.</param>
        /// <param name="caption">Document caption (may also be used when resending documents by file_id), 0-1024 characters after entities parsing.</param>
        /// <param name="parseMode">Mode for parsing entities in the document caption. See <a href="https://core.telegram.org/bots/api#formatting-options">formatting options</a> for more details.</param>
        /// <param name="captionEntities">List of special entities that appear in the caption, which can be specified instead of parse_mode</param>
        /// <param name="disableContentTypeDetection">Optional. Disables automatic server-side content type detection for files uploaded using multipart/form-data. Always true, if the document is sent as part of an album.</param>
        /// <param name="disableNotification">Optional. Sends the message <a href="https://telegram.org/blog/channels-2-0#silent-messages">silently</a>. Users will receive a notification with no sound.</param>
        /// <param name="replyToMessageId">If the message is a reply, ID of the original message.</param>
        /// <param name="allowSendingWithoutReply">Pass True, if the message should be sent even if the specified replied-to message is not found.</param>
        /// <param name="replyMarkup">Optional. Additional interface options. A JSON-serialized object for an inline keyboard, custom reply keyboard, instructions to remove reply keyboard or to force a reply from the user. <see cref="InlineKeyboardMarkup"/> or <see cref="ReplyKeyboardMarkup"/> or <see cref="ReplyKeyboardRemove"/> or <see cref="ForceReply"/></param>
        /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
        /// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
        /// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
        /// <returns>Message Object.</returns>
        public static async Task<Message> SendDocumentAsync(this BotClient bot, long chatId, InputFile document, [Optional] InputFile thumb, [Optional] string caption, [Optional] string parseMode, [Optional] MessageEntity[] captionEntities, [Optional] bool? disableContentTypeDetection, [Optional] bool? disableNotification, [Optional] int? replyToMessageId, [Optional] bool? allowSendingWithoutReply, [Optional] ReplyMarkup replyMarkup, [Optional] CancellationToken cancellationToken)
        {
            return await bot.SendDocumentAsync(new SendDocumentArgs
            {
                ChatId = chatId,
                Document = document,
                Thumb = thumb,
                Caption = caption,
                ParseMode = parseMode,
                CaptionEntities = captionEntities,
                DisableContentTypeDetection = disableContentTypeDetection,
                DisableNotification = disableNotification,
                ReplyToMessageId = replyToMessageId,
                AllowSendingWithoutReply = allowSendingWithoutReply,
                ReplyMarkup = replyMarkup
            }, cancellationToken);
        }

        /// <summary>Use this method to send general files. On success, the sent Message is returned.</summary>
        /// <param name="bot">BotClient</param>
        /// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
        /// <param name="document">File to send. Pass a file_id as String to send a file that exists on the Telegram servers (recommended), pass an HTTP URL as a String for Telegram to get a file from the Internet, or upload a new one using multipart/form-data.</param>
        /// <param name="thumb">Optional. InputFile or String. Thumbnail of the file sent. The thumbnail should be in JPEG format and less than 200 kB in size. A thumbnail�s width and height should not exceed 90. Ignored if the file is not uploaded using multipart/form-data.</param>
        /// <param name="caption">Document caption (may also be used when resending documents by file_id), 0-1024 characters after entities parsing.</param>
        /// <param name="parseMode">Mode for parsing entities in the document caption. See <a href="https://core.telegram.org/bots/api#formatting-options">formatting options</a> for more details.</param>
        /// <param name="captionEntities">List of special entities that appear in the caption, which can be specified instead of parse_mode</param>
        /// <param name="disableContentTypeDetection">Optional. Disables automatic server-side content type detection for files uploaded using multipart/form-data. Always true, if the document is sent as part of an album.</param>
        /// <param name="disableNotification">Optional. Sends the message <a href="https://telegram.org/blog/channels-2-0#silent-messages">silently</a>. Users will receive a notification with no sound.</param>
        /// <param name="replyToMessageId">If the message is a reply, ID of the original message.</param>
        /// <param name="allowSendingWithoutReply">Pass True, if the message should be sent even if the specified replied-to message is not found.</param>
        /// <param name="replyMarkup">Optional. Additional interface options. A JSON-serialized object for an inline keyboard, custom reply keyboard, instructions to remove reply keyboard or to force a reply from the user. <see cref="InlineKeyboardMarkup"/> or <see cref="ReplyKeyboardMarkup"/> or <see cref="ReplyKeyboardRemove"/> or <see cref="ForceReply"/></param>
        /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
        /// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
        /// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
        /// <returns>Message Object.</returns>
        public static async Task<Message> SendDocumentAsync(this BotClient bot, string chatId, InputFile document, [Optional] InputFile thumb, [Optional] string caption, [Optional] string parseMode, [Optional] MessageEntity[] captionEntities, [Optional] bool? disableContentTypeDetection, [Optional] bool? disableNotification, [Optional] int? replyToMessageId, [Optional] bool? allowSendingWithoutReply, [Optional] ReplyMarkup replyMarkup, [Optional] CancellationToken cancellationToken)
        {
            return await bot.SendDocumentAsync(new SendDocumentArgs
            {
                ChatId = chatId,
                Document = document,
                Thumb = thumb,
                Caption = caption,
                ParseMode = parseMode,
                CaptionEntities = captionEntities,
                DisableContentTypeDetection = disableContentTypeDetection,
                DisableNotification = disableNotification,
                ReplyToMessageId = replyToMessageId,
                AllowSendingWithoutReply = allowSendingWithoutReply,
                ReplyMarkup = replyMarkup
            }, cancellationToken);
        }
    }
}