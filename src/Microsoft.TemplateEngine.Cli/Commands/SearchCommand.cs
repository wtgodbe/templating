﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

#nullable enable

using System.CommandLine;
using Microsoft.TemplateEngine.Abstractions;

namespace Microsoft.TemplateEngine.Cli.Commands
{
    internal class SearchCommand : BaseCommand<SearchCommandArgs>
    {
        internal SearchCommand(ITemplateEngineHost host, ITelemetryLogger logger, New3Callbacks callbacks) : base(host, logger, callbacks) { }

        public override Command CreateCommand() => throw new NotImplementedException();

        protected override Task<int> ExecuteAsync(SearchCommandArgs args, CancellationToken cancellationToken = default) => throw new NotImplementedException();
    }

    internal class SearchCommandArgs : GlobalArgs
    {
    }
}