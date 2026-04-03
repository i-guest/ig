using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace Steamworks.Data
{
	public struct ServerInfo : IEquatable<ServerInfo>
	{
		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CQueryRulesAsync_003Ed__85 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<Dictionary<string, string>> _003C_003Et__builder;

			public ServerInfo _003C_003E4__this;

			private TaskAwaiter<Dictionary<string, string>> _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		private string[] _tags;

		internal const uint k_unFavoriteFlagNone = 0u;

		internal const uint k_unFavoriteFlagFavorite = 1u;

		internal const uint k_unFavoriteFlagHistory = 2u;

		public string Name { get; set; }

		public int Ping { get; set; }

		public string GameDir { get; set; }

		public string Map { get; set; }

		public string Description { get; set; }

		public uint AppId { get; set; }

		public int Players { get; set; }

		public int MaxPlayers { get; set; }

		public int BotPlayers { get; set; }

		public bool Passworded { get; set; }

		public bool Secure { get; set; }

		public uint LastTimePlayed { get; set; }

		public int Version { get; set; }

		public string TagString { get; set; }

		public ulong SteamId { get; set; }

		public uint AddressRaw { get; set; }

		public IPAddress Address { get; set; }

		public int ConnectionPort { get; set; }

		public int QueryPort { get; set; }

		public string[] Tags => null;

		internal static ServerInfo From(gameserveritem_t item)
		{
			return default(ServerInfo);
		}

		public ServerInfo(uint ip, ushort cport, ushort qport, uint timeplayed)
		{
			Name = null;
			Ping = 0;
			GameDir = null;
			Map = null;
			Description = null;
			AppId = 0u;
			Players = 0;
			MaxPlayers = 0;
			BotPlayers = 0;
			Passworded = false;
			Secure = false;
			LastTimePlayed = 0u;
			Version = 0;
			TagString = null;
			SteamId = 0uL;
			AddressRaw = 0u;
			Address = null;
			ConnectionPort = 0;
			QueryPort = 0;
			_tags = null;
		}

		public void AddToHistory()
		{
		}

		[AsyncStateMachine(typeof(_003CQueryRulesAsync_003Ed__85))]
		public Task<Dictionary<string, string>> QueryRulesAsync()
		{
			return null;
		}

		public void RemoveFromHistory()
		{
		}

		public void AddToFavourites()
		{
		}

		public void RemoveFromFavourites()
		{
		}

		public bool Equals(ServerInfo other)
		{
			return false;
		}

		public override int GetHashCode()
		{
			return 0;
		}
	}
}
