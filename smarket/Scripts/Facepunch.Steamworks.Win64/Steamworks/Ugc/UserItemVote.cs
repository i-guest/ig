using Steamworks.Data;

namespace Steamworks.Ugc
{
	public struct UserItemVote
	{
		public bool VotedUp;

		public bool VotedDown;

		public bool VoteSkipped;

		internal static UserItemVote? From(GetUserItemVoteResult_t result)
		{
			return null;
		}
	}
}
