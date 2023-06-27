﻿namespace Massive.Tests.Sqlite.TableClasses
{
	public class Playlist : DynamicModel
	{
		public Playlist()
			: this(includeSchema: false)
		{
		}


		public Playlist(bool includeSchema) :
			base(TestConstants.ReadWriteTestConnectionStringName, includeSchema ? "Playlist" : "Playlist", "PlaylistId", string.Empty, "last_insert_rowid()")
		{
		}
	}
}
