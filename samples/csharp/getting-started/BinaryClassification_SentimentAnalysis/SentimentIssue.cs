﻿using Microsoft.ML.Runtime.Api;

namespace BinaryClassification_SentimentAnalysis
{
    public class SentimentIssue
    {
        public bool label { get; set; }
        public string text { get; set; }
    }
}
