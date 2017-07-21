using Newtonsoft.Json.Linq;
using System.Collections.Generic;

namespace StudentAPI.Models.API.Threads
{
    public class ThreadsGroup
    {
        private int _groupId;
        private List<Thread> _thread = new List<Threads.Thread>();

        public int GroupID
        {
            get => _groupId;
            set => _groupId = value;
        }
        public List<Thread> Thread
        {
            get => _thread;
            set => _thread = value;
        }


        public ThreadsGroup(JToken json)
        {
            if (int.TryParse(json.SelectToken("groupId")?.ToString(), out int groupId)) GroupID = groupId;

            foreach (var item in json.SelectToken("threads"))
            {
                Thread.Add(new Threads.Thread(item));
            }
        }

        public override string ToString()
        {
            string data = $"ID GRUPY: {GroupID}";
            foreach (var item in Thread)
            {
                data += $" Watek: {item }\n";
            }
            return data;
        }
    }
}
