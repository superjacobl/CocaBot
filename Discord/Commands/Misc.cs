﻿using DSharpPlus.CommandsNext;
using DSharpPlus.CommandsNext.Attributes;
using System;
using System.Threading.Tasks;
using static Shared.Commands.Privacy;
using static Shared.Commands.Code;
using System.Diagnostics;
using Humanizer;

namespace Discord.Commands;
public class Misc : BaseCommandModule
{
    [Command("code"), Aliases("opensource")]
    [Description("Gives link for linking your SV account to your discord account")]
    public async Task Code(CommandContext ctx) => await ctx.RespondAsync(CodeMessage).ConfigureAwait(false);

    [Command("privacy")]
    [Description("Gives link for your privacy")]
    public async Task Privacy(CommandContext ctx) => await ctx.RespondAsync(PrivacyMessage).ConfigureAwait(false);

    [Command("website")]
    public async Task Website(CommandContext ctx) => await ctx.RespondAsync("https://cocabot.cf");

    [Command("kill"), Hidden()]
    [Description("Kills the bot incase of a emergency. Coca only command for obiovus reasons!")]
    public async Task Kill(CommandContext ctx)
    {
        if (ctx.User.Id == 388454632835514380) Environment.Exit(666);
    }

    [Command("ping")]
    [Description("pong!")]
    public async Task Ping(CommandContext ctx)
    {
        await ctx.RespondAsync(ctx.Client.Ping.ToString() + " ms");
    }

    [Command("uptime")]
    [Description("existence")]
    public async Task Uptime(CommandContext ctx)
    {
        TimeSpan time = DateTime.Now - Process.GetCurrentProcess().StartTime;
        await ctx.RespondAsync("Uptime: " + time.Humanize(2));
    }
}