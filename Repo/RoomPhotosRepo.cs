using Core;
using Infra;
using Repo.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repo
{
    public class RoomPhotosRepo:GenRepo<RoomPhoto>, IRoomPhotosRepo
    {
        CompanyContext cc;

        public RoomPhotosRepo(CompanyContext cc):base(cc)
        {
            this.cc = cc;
        }

        public RepoResultVM Add(RoomPhoto rec)
        {
            RepoResultVM res = new RepoResultVM();
            try
            {
                this.cc.RoomPhotos.Add(rec);
                this.cc.SaveChanges();
                res.IsSuccess = true;
                res.Message = "Room Photo Added Successfully!";
            }
            catch (Exception ex)
            {
                res.IsSuccess = false;
                res.Message = ex.Message;
            }
            return res;
        }

        public RepoResultVM Delete(long id)
        {
            RepoResultVM res = new RepoResultVM();
            try
            {
                var rec = this.cc.RoomPhotos.Find(id);
                this.cc.RoomPhotos.Remove(rec);
                this.cc.SaveChanges();
                res.IsSuccess = true;
                res.Message = "Room Photo Deleted!";
            }
            catch (Exception ex)
            {
                res.IsSuccess = false;
                res.Message = ex.Message.ToString();
            }
            return res;
        }


        public List<RoomPhoto> GetAll()
        {
            return this.cc.RoomPhotos.ToList();
        }



        public RoomPhoto GetByID(long id)
        {
            return this.cc.RoomPhotos.Find(id);
        }

        public RepoResultVM Update(RoomPhoto rec)
        {
            RepoResultVM res = new RepoResultVM();
            try
            {
                this.cc.Entry(rec).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                this.cc.SaveChanges();
                res.IsSuccess = true;
                res.Message = "Room Photo Gallery Updated!";
            }
            catch (Exception ex)
            {
                res.IsSuccess = false;
                res.Message = ex.Message;
            }

            return res;
        }
    }
}
