﻿using DSharpPlus.CommandsNext;
using DSharpPlus.CommandsNext.Attributes;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CocaBot.Commands
{
    public class ping : BaseCommandModule
    {
        [Command("ping")]
        public async Task Ping(CommandContext ctx)
        {
            await ctx.Channel.SendMessageAsync("Pong").ConfigureAwait(false);
        }

        [Command("version")]
        public async Task Version(CommandContext ctx)
        {
            await ctx.Channel.SendMessageAsync("This CocaBot is version 1.1").ConfigureAwait(false);
        }

    }
}
