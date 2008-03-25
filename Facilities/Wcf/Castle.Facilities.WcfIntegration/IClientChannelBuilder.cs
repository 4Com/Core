﻿// Copyright 2004-2008 Castle Project - http://www.castleproject.org/
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// 
//     http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

namespace Castle.Facilities.WcfIntegration
{
	using System;

	/// <summary>
	/// Delegate for creating channels.
	/// </summary>
	public delegate object ChannelCreator();

	/// <summary>
	/// Contract for building channel factories.
	/// </summary>
	public interface IClientChannelBuilder
	{
		/// <summary>
		/// Get a delegate capable of creating channels.
		/// </summary>
		/// <param name="endpoint">The endpoint.</param>
		/// <returns>The <see cref="ChannelCreator"/></returns>
		ChannelCreator GetChannelCreator(IWcfEndpoint endpoint);

		/// <summary>
		/// Get a delegate capable of creating channels.
		/// </summary>
		/// <param name="endpoint">The endpoint.</param>
		/// <param name="contract">The contract override.</param>
		/// <returns>The <see cref="ChannelCreator"/></returns>
		ChannelCreator GetChannelCreator(IWcfEndpoint endpoint, Type contract);
	}
}