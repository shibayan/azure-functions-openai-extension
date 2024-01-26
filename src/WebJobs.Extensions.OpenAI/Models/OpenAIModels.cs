﻿// Copyright (c) Microsoft Corporation.
// Licensed under the MIT License.

namespace Microsoft.Azure.WebJobs.Extensions.OpenAI.Models;

static class OpenAIModels
{
    // Reference - https://platform.openai.com/docs/models

    /// <summary>
    /// GPT 3 Turbo, refer to https://platform.openai.com/docs/models/continuous-model-upgrades for exact model being pointed to
    /// </summary>
    internal const string Gpt_35_Turbo = "gpt-3.5-turbo";

    /// <summary>
    /// The default embeddings model, currently pointing to text-embedding-ada-002
    /// </summary>
    internal const string DefaultEmbeddingsModel = "text-embedding-ada-002";
}