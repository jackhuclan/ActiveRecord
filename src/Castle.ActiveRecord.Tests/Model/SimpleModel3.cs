// Copyright 2004-2011 Castle Project - http://www.castleproject.org/
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

namespace Castle.ActiveRecord.Tests.Model
{
	using System;

	[ActiveRecord("TableNameHere")]
	public class SimpleModel3
	{
		private int _id;
		private String _name;

		[PrimaryKey(PrimaryKeyType.Guid, "t_id")]
		public int id
		{
			get { return _id; }
			set { _id = value; }
		}

		[PropertyAttribute("t_name", ColumnType="StringClob", NotNull=true, Length=20)]
		public String name
		{
			get { return _name; }
			set { _name = value; }
		}
	}
}