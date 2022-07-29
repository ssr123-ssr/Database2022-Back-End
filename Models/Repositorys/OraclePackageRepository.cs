using ExpressSystem;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Back_End_wlf_01.Models
{
    public class OraclePackageRepository : IPackageRepository
    {
        private readonly OracleDBContext context;

        public OraclePackageRepository(OracleDBContext context)
        {
            this.context = context;
        }

        public string Edit(string id)
        {
            if (this.context.PACKAGE.Find(id) == null)
            {
                return "数据为空";
            }
            else
            {
                this.context.PACKAGE.Find(id).STATE = "已揽收";
                return "揽收成功";
            }
            //if (package.PACK_ID is null)
            //{
            //    //this.context.Database.
            //    //    ExecuteSqlInterpolated($@"insert into PACKAGE values('{package.PACK_ID}','{package.STATE}','{package.SENDER_ID}','{package.RECIPIENT_ID}',{package.WEIGHT},'{package.ITEMS}',{package.COST},'{package.COUR_ID}','{package.COMP_ID}','{package.POST_ID}','{package.CENTER_ID}','{package.TRANS_ID}') ");
            //    //return "添加成功";

            //    //'SENDER_ID={package.SENDER_ID}',RECIPIENT_ID='{package.RECIPIENT_ID}',WEIGHT={package.WEIGHT},ITEMS='{package.ITEMS}',COST={package.COST},COUR_ID='{package.COUR_ID}',COMP_ID='{package.COMP_ID}',POST_ID='{package.POST_ID}',CENTER_ID='{package.CENTER_ID}',TRANS_ID='{package.TRANS_ID}'
            //    this.context.Database.
            //       ExecuteSqlInterpolated($@"update PACKAGE set STATE ='{package.STATE}'where PACK_ID = '{package.PACK_ID}'");
            //    return "修改成功";
            //}
            //else
            //    return "修改成功";
            //else
            //{
            //    this.context.Database.
            //       ExecuteSqlInterpolated($@"update PACKAGE set STATE ='{package.STATE}','SENDER_ID={package.SENDER_ID}',RECIPIENT_ID='{package.RECIPIENT_ID}',WEIGHT='{package.WEIGHT}',ITEMS='{package.ITEMS}',COUR_ID='{package.COUR_ID}',COMP_ID='{package.COMP_ID}',POST_ID='{package.POST_ID}',CENTER_ID='{package.CENTER_ID}',TRANS_ID='{package.TRANS_ID}'where PACK_ID = '{package.PACK_ID}' ");
            //    return "修改成功";
            //}
        }

        public string Delete(string id)
        {
            try
            {
                this.context.Database.ExecuteSqlRaw($@"Delete from PACKAGE where PACK_ID= '{id}'");
                this.context.SaveChanges();
                return "删除成功";
            }
            catch(Exception ex)
            {
                return ex.Message;
            }

        }

        public IEnumerable<Package> GetAllPackage()
        {

            //var package_dsd = from Package p in context.PACKAGE
            //                  join Recipient r in context.RECIPIENT
            //                  on p.RECIPIENT_ID equals r.ID
            //                  where p.STATE == "等待揽收"
            //                  select new
            //                  {
            //                      ID = p.PACK_ID,
            //                      address = r.ACCEPT_ADDRESS,
            //                      state = p.STATE,
            //                      recipient_id = p.RECIPIENT_ID
            //                  };


            //var package_dsd = context.PACKAGE.Where<Package>(p => p.STATE == "等待揽收");

            return this.context.PACKAGE.FromSqlRaw("select * from package");

            //return (IEnumerable<Package>)package_dsd;
        }

        public Package GetPackage(string id)
        {
            return this.context.PACKAGE.Find(id);
        }
    }
}
