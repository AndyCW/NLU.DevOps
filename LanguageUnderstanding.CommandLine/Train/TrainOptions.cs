﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

namespace LanguageUnderstanding.CommandLine.Train
{
    using global::CommandLine;

    [Verb("train", HelpText = "Trains the NLU service.")]
    internal class TrainOptions : BaseOptions
    {
        [Option('u', "utterances", HelpText = "Path to utterances.", Required = true)]
        public string UtterancesPath { get; set; }

        [Option('e', "entity-types", HelpText = "Path to entity type configuration.", Required = true)]
        public string EntityTypesPath { get; set; }

        [Option('o', "write-config", HelpText = "Flag to write configuration to standard output.", Required = false)]
        public bool WriteConfig { get; set; }
    }
}