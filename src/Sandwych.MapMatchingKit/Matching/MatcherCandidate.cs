﻿using Sandwych.MapMatchingKit.Markov;
using Sandwych.MapMatchingKit.Roads;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sandwych.MapMatchingKit.Matching
{
    public sealed class MatcherCandidate : AbstractStateCandidate<MatcherCandidate, MatcherTransition, MatcherSample>
    {
        private readonly RoadPoint _point;

        public ref readonly RoadPoint Point => ref _point;

        public MatcherCandidate(in MatcherSample sample, in RoadPoint point) : base(sample)
        {
            this._point = point;
        }

        public override int GetHashCode() => Point.GetHashCode();
    }
}
