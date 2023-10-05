using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{

    public class MemberDAO : IComparer<MemberObject>
    {
        #region initialize list of member
        private static List<MemberObject> MemberList = new List<MemberObject>()
        {
            new MemberObject{MemberID = 1,MemberName="Nguyen Duong Phu Trong"
                ,Email="trongndpce160324@fpt.edu.vn",Password="123456",City="Can Tho",Country="Vietnam"},
        };
        #endregion


        #region using Singleton parttern
        private static MemberDAO instance = null;
        private static readonly object instanceLock = new object();
        private MemberDAO() { }
        public static MemberDAO Instance
        {
            get 
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new MemberDAO();
                    }
                    return instance;
                }
            }
        }
        public List<MemberObject> GetMemberList => MemberList;
        #endregion


        #region Get member in list by ID
        public MemberObject GetMemberById(int ID)
        {
            MemberObject member = MemberList.SingleOrDefault(mem => mem.MemberID == ID); //using LINQ to object
            return member;
        }
        #endregion


        #region Get member in list by email
        public MemberObject GetMemberByEmail(string email)
        {
            MemberObject member = MemberList.SingleOrDefault(mem => mem.Email == email);
            return member;
        }
        #endregion

        #region Add new member
        public void AddMember(MemberObject member)
        {
            var getID = GetMemberById(member.MemberID);
            var getEmail = GetMemberByEmail(member.Email);

            if (getID == null || getEmail == null)
            {
                MemberList.Add(member);
            }
            else
            {
                throw new Exception("Member is already exists");
            }
        }
        #endregion


        #region Update member
        public void UpdateMember(MemberObject member)
        {
            var getID = GetMemberById(member.MemberID);
            var getEmail = GetMemberByEmail(member.Email);

            if (getID != null || getEmail != null)
            {
                var index = MemberList.IndexOf(getID);
                MemberList[index] = member;
            }
            else
            {
                throw new Exception("Member does not already exists");
            }
        }
        #endregion


        #region Remove member
        public void RemoveMember(int ID)
        {
            var getID = GetMemberById(ID);
            MemberObject member = getID;

            if(member != null)
            {
                MemberList.Remove(member);
            }
            else
            {
                throw new Exception("Member does not already exists");
            }
        }
        #endregion


        #region
        public void SortById()
        {
            MemberList.Sort(Compare);
        }
        #endregion


        #region
        public void SortByName()
        {
            MemberList.Sort(Compare1);
        }
        #endregion


        #region interface to compare object
        public int Compare(MemberObject x, MemberObject y)
        {
            return x.MemberID.CompareTo(y.MemberID);
        }

        public int Compare1(MemberObject x, MemberObject y)
        {
            return x.MemberName.CompareTo(y.MemberName);
        }
        #endregion
    }
}
