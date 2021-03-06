﻿using SharedLibraryCore.Interfaces;
using SharedLibraryCore.RCon;
using System.Collections.Generic;
using System.Globalization;

namespace IW4MAdmin.Application.RconParsers
{
    /// <summary>
    /// generic implementation of the IRConParserConfiguration
    /// allows script plugins to generate dynamic RCon configurations
    /// </summary>
    public class DynamicRConParserConfiguration : IRConParserConfiguration
    {
        public CommandPrefix CommandPrefixes { get; set; }
        public ParserRegex Status { get; set; }
        public ParserRegex MapStatus { get; set; }
        public ParserRegex Dvar { get; set; }
        public ParserRegex StatusHeader { get; set; }
        public string ServerNotRunningResponse { get; set; }
        public bool WaitForResponse { get; set; } = true;
        public NumberStyles GuidNumberStyle { get; set; } = NumberStyles.HexNumber;
        public IDictionary<string, string> OverrideDvarNameMapping { get; set; } = new Dictionary<string, string>();
        public IDictionary<string, string> DefaultDvarValues { get; set; } = new Dictionary<string, string>();

        public DynamicRConParserConfiguration(IParserRegexFactory parserRegexFactory)
        {
            Status = parserRegexFactory.CreateParserRegex();
            MapStatus = parserRegexFactory.CreateParserRegex();
            Dvar = parserRegexFactory.CreateParserRegex();
            StatusHeader = parserRegexFactory.CreateParserRegex();
        }
    }
}
