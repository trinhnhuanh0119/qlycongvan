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
        void Complete();
    }
}
