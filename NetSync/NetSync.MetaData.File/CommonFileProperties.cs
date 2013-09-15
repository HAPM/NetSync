﻿// <copyright file="ISynchronizable.cs" company="IrcShark Team">
// Copyright (C) 2009 IrcShark Team
// </copyright>
// <author>$Author$</author>
// <date>$LastChangedDate$</date>
// <summary>Place a summary here.</summary>

// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation, either version 3 of the License, or
// (at your option) any later version.
//
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
//
// You should have received a copy of the GNU General Public License
// along with this program.  If not, see <http://www.gnu.org/licenses/>.
namespace NetSync.MetaData.File
{
	using System;
	using System.Collections.Generic;

	using NetSync.Core;

	/// <summary>
	/// Description of MyClass.
	/// </summary>
	public abstract class CommonFileProperties : GenericPropertyCollection
	{		
		public CommonFileProperties(SynchronizableObject obj) : base(obj)
		{
		}
		
		public string Name { get; protected set; }
		public string Extension { get; protected set; }
		public long Length { get; protected set; }
	}
}