﻿using Microsoft.DataTransfer.ServiceModel.Entities;
using System;
using System.Collections.Generic;

namespace Microsoft.DataTransfer.TestsCommon.Mocks
{
    public sealed class DummyTransferStatisticsMock : ITransferStatistics, ITransferStatisticsSnapshot
    {
        public TimeSpan ElapsedTime
        {
            get { return TimeSpan.Zero; }
        }

        public int Transferred
        {
            get { return 0; }
        }

        public void Start() { }
        public void Stop() { }

        public void AddTransferred() { }
        public void AddError(string dataItemId, Exception error) { }

        public ITransferStatisticsSnapshot GetSnapshot()
        {
            return this;
        }

        public IReadOnlyCollection<KeyValuePair<string, Exception>> GetErrors()
        {
            return new KeyValuePair<string, Exception>[0];
        }
    }
}
