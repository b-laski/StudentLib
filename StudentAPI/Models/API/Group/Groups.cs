using Newtonsoft.Json.Linq;
using System.Collections.Generic;

namespace StudentAPI.Models.API.Group
{
    public class Groups
    {
        private int _memberId;
        private int _memberJoinTime;
        private List<string> _memberRoles;
        private int _groupId;
        private string _groupName;
        private string _groupType;
        private string _groupPhoto;

        public int MemberId
        {
            get => _memberId;
            set => _memberId = value;
        }
        public int MemberJoinTime
        {
            get => _memberJoinTime;
            set => _memberJoinTime = value;
        }
        public List<string> MemberRoles
        {
            get => _memberRoles;
            set => _memberRoles = value;
        }
        public int GroupId
        {
            get => _groupId;
            set => _groupId = value;
        }
        public string GroupName
        {
            get => _groupName;
            set => _groupName = value;
        }
        public string GroupType
        {
            get => _groupType;
            set => _groupType = value;
        }
        public string GroupPhoto
        {
            get => _groupPhoto;
            set => _groupPhoto = value;
        }

        public Groups(JToken json)
        {
            //INTIGERS!
            if (int.TryParse(json.SelectToken("memberId").ToString(), out int memberId)) MemberId = memberId;
            if (int.TryParse(json.SelectToken("memberJoinTime").ToString(), out int memberJoinTime)) MemberJoinTime = memberJoinTime;
            if (int.TryParse(json.SelectToken("groupId").ToString(), out int groupId)) GroupId = groupId;

            MemberRoles = new List<string>();
            foreach (var item in json.SelectToken("memberRoles"))
            {
                MemberRoles.Add(item?.ToString());
            }

            GroupName = json.SelectToken("groupName")?.ToString();
            GroupType = json.SelectToken("groupType")?.ToString();
            GroupPhoto = json.SelectToken("groupPhoto")?.ToString();
        }

        public override string ToString()
        {
            string data = $"{MemberId}, {GroupName}, {GroupType} || {GroupId} ";

            return data;
        }
    }
}
