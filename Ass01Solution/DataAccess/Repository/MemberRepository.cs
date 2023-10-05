using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class MemberRepository : IMemberRepository
    {
        public void InsertMember(MemberObject member)
        {
            MemberDAO.Instance.AddMember(member);
        }

        public MemberObject GetMemberByEmail(string email)
        {
            return MemberDAO.Instance.GetMemberByEmail(email);
        }

        public MemberObject GetMemberByID(int id)
        {
            return MemberDAO.Instance.GetMemberById(id);
        }

        public IEnumerable<MemberObject> GetMemberList()
        {
            return MemberDAO.Instance.GetMemberList;
        }

        public void DeleteMember(int id)
        {
            MemberDAO.Instance.RemoveMember(id);
        }

        public void SearchById(string id)
        {
            throw new NotImplementedException();
        }

        public void SortMemberByName()
        {
            MemberDAO.Instance.SortByName();
        }

        public void SortMemberByID()
        {
            MemberDAO.Instance.SortById();
        }

        public void UpdateMember(MemberObject member)
        {
            MemberDAO.Instance.UpdateMember(member);
        }
    }
}
