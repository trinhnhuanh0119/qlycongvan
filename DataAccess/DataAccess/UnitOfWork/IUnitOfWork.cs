using DataAccess.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.UnitOfWork
{
    public interface IUnitOfWork
    {
        ICCQBHRepository CCQBHRepository { get; }
        ICQBHRepository CQBHRepository { get; }
        ICapSoRepository CapSoRepository { get; }
        ICV_DiRepository CV_DiRepository { get; }
        IDoKhanRepository DoKhanRepository { get; }
        IDoMatRepository DoMatRepository { get; }
        IDVRepository    DVRepository { get; }
        IKhoLuuTruRepository KhoLuuTruRepository { get; }
        ILoaiBQRepository LoaiBQRepository { get; }
        ILuuTruRepository LuuTruRepository { get; }
        ILVBRepository LVBRepository { get; }
        IMenuRepository MenuRepository { get; }
        INBHRepository NBHRepository { get; }
        INNDRepository NNDRepository { get; }
        INNVBRepository NNVBRepository { get; }
        IPhongRepository PhongRepository { get; }
        ISVBRepository SVBRepository { get; }
        ITDKRepository TDKRepository { get; }
        IUsersRepository UsersRepository { get; }
        void Complete();
    }
}
