using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using RestEgBoligHeldinTest.Models;

namespace RestEgBoligHeldinTest.Controllers
{
    public class EgBoligController : ApiController
    {
        // GET: api/EgBolig
        public IEnumerable<Member> Get()
        {
            EgBoligService.Service10540Client svc = new EgBoligService.Service10540Client();

            var memberList = new List<Member>();
            for(int i = 0; i < 10; i++)
            {
                Member member = new Member();
                EgBoligService.Member tst = svc.MemberGet(01, i+1);

                member.Name = tst.Name;
                member.Address = tst.Address;
                member.PostalCodeCity = tst.PostalCodeCity;
                member.Country = tst.Country;
                member.CprNo = tst.CprNo;
                member.Email = tst.Email;
                member.HomePhone = tst.HomePhone;
                member.MobilePhone = tst.MobilePhone;
                member.Children = tst.Children;

                memberList.Add(member);
            }
            return memberList;
        }
    }
}
