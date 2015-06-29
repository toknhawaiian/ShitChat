using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShitChatCore
{
    public static class ShitChatSandbox
    {
        private static User _userOnDeck { get; set; }
        public static User UserOnDeck
        {
            get
            {
                var tmp = _userOnDeck;
                _userOnDeck = null;
                return tmp;
            }
            set { _userOnDeck = value; }
        }
        public static List<User> Users { get; private set; }
        public static BiDictionaryOneToOne<Guid, Guid> Pairs { get; private set; }


        static ShitChatSandbox()
        {
            Pairs = new BiDictionaryOneToOne<Guid, Guid>();
            Users = new List<User>();
        }

        public static void ClearMessages(Guid userId)
        {
            var user = Users.Where(x => x.UserId.Equals(userId));

            if (user.Any())
            {
                user.First().Inbox = new List<string>();
            }
        }

        public static void GetAvailableUser(Guid userId)
        {
            foreach (var user in Users.ToArray())
            {
                if (userId.Equals(user.UserId))
                    Users.Remove(user);

                Pairs.TryRemoveByFirst(userId);
                Pairs.TryRemoveBySecond(userId);
            }

            var userOnDeck = UserOnDeck;
            if ((userOnDeck != null) && (!userOnDeck.UserId.Equals(userId)))
            {
                Users.Add(userOnDeck);
                var userPair = new User(userId, new List<string>());
                Users.Add(userPair);

                Pairs.TryAdd(userOnDeck.UserId, userPair.UserId);
                SendMessage(userId, "Friend Found");
                SendMessage(userOnDeck.UserId, "Friend Found");
            }
            else
            {
                UserOnDeck = new User(userId, new List<string>());
            }

        }

        public static void SendMessage(Guid fromUserId, string message)
        {
            Guid toUserId;
            if (!Pairs.TryGetByFirst(fromUserId, out toUserId))
                Pairs.TryGetBySecond(fromUserId, out toUserId);

            var toUser = Users.FirstOrDefault(x => x.UserId.Equals(toUserId));

            if (toUser != null)
            {
                toUser.Inbox.Add(message);
            }
        }

        public static List<string> GetMessages(Guid userId)
        {
            var user = Users.FirstOrDefault(x => x.UserId.Equals(userId));

            if (user != null)
            {
                return user.Inbox;
            }
            else return new List<string>();
        }

    }
}
