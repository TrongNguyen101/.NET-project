using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public interface IMemberRepository
    {
        public MemberObject GetMemberByID(int id);
        public MemberObject GetMemberByEmail(string email);
        public IEnumerable<MemberObject> GetMemberList();
        public void InsertMember(MemberObject member);
        public void UpdateMember(MemberObject member);
        public void DeleteMember(int id);
        public void SortMemberByID();
        public void SortMemberByName();
        public void SearchById(string id);
    }
}
