using DataAccess.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
         private readonly ICCQBHRepository _ccqbhRepository;
        private readonly ICQBHRepository _cqbhRepository;
        private readonly ICapSoRepository _capsoRepository;
        private readonly ICV_DiRepository _cv_diRepository;
        private readonly IDoKhanRepository _dokhanRepository;
        private readonly IDoMatRepository _domatRepository;
        private readonly IDVRepository _dvRepository;
      public UnitOfWork(ICCQBHRepository ccqbhRepository, ICQBHRepository cqbhRepository,ICapSoRepository capsoRepository,
             ICV_DiRepository cv_diRepository, IDoKhanRepository doKhanRepository, IDoMatRepository domatRepository,DVRepository dvRepository)
           {
            _ccqbhRepository = ccqbhRepository;
            _cqbhRepository = cqbhRepository;
            _capsoRepository = capsoRepository;
            _cv_diRepository = cv_diRepository;
            _dokhanRepository = doKhanRepository;
            _domatRepository = domatRepository;
            _dvRepository = dvRepository;
           }
           void IUnitOfWork.Complete()
           {
               throw new NotImplementedException();
           }
           public ICCQBHRepository CCQBHRepository
        {
               get
               {
                   return _ccqbhRepository;
               }
           }
        public ICQBHRepository CQBHRepository
        {
            get
            {
                return _cqbhRepository;
            }
        }
           public ICapSoRepository CapSoRepository
        {
            get
            {
                return _capsoRepository;
            }
        }
        public ICV_DiRepository CV_DiRepository
        {
            get
            {
                return _cv_diRepository;
            }
        }
        public IDoKhanRepository DoKhanRepository
        {
            get
            {
                return _dokhanRepository;
            }
        }
        public IDoMatRepository DoMatRepository
        {
            get
            {
                return _domatRepository;
            }
        }
        public IDVRepository DVRepository
        {
            get
            {
                return _dvRepository;
            }
        }
    }
}
