﻿/*
 * QUANTCONNECT.COM - Democratizing Finance, Empowering Individuals.
 * Lean Algorithmic Trading Engine v2.0. Copyright 2014 QuantConnect Corporation.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License"); 
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at http://www.apache.org/licenses/LICENSE-2.0
 * 
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 *
*/

/**********************************************************
* USING NAMESPACES
**********************************************************/

using System;
using System.Collections.Generic;
using QuantConnect.Data;
using QuantConnect.Interfaces;
using QuantConnect.Packets;

namespace QuantConnect.Lean.Engine.DataFeeds
{
    /// <summary>
    /// IQFeed DataFeed By 
    /// </summary>
    public class IQFeedDataFeed : BaseDataFeed
    {
        /******************************************************** 
        * CLASS VARIABLES
        *********************************************************/
        // Set types in public area to speed up:
        private IAlgorithm _algorithm;
        private BacktestNodePacket _job;

        /******************************************************** 
        * CLASS PROPERTIES
        *********************************************************/


        /******************************************************** 
        * CLASS CONSTRUCTOR
        *********************************************************/
        /// <summary>
        /// Create and connect to IQFeed.
        /// </summary>
        public IQFeedDataFeed(IAlgorithm algorithm, BacktestNodePacket job) 
            : base(algorithm, job)
        {
            _algorithm = algorithm;
            _job = job;
        }

        public override List<BaseData> GetData(SubscriptionDataConfig subscription)
        {
            throw new NotImplementedException();
        }
    }
}
