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
        private readonly IKhoLuuTruRepository _kholuutruRepository;
        private readonly ILoaiBQRepository _loaibqRepository;
        private readonly ILuuTruRepository _luutruRepository;
        private readonly ILVBRepository _lvbRepository;
        private readonly IMenuRepository _menuRepository;
        private readonly INBHRepository _nbhRepository;
        private readonly INNDRepository _nndRepository;
        private readonly INNVBRepository _nnvbRepository;
        private readonly IPhongRepository _phongRepository;
        private readonly ISVBRepository _svbRepository;
        private readonly ITDKRepository _tdkRepository;
        private readonly IUsersRepository _usersRepository;
      public UnitOfWork(ICCQBHRepository ccqbhRepository, ICQBHRepository cqbhRepository,ICapSoRepository capsoRepository,
             ICV_DiRepository cv_diRepository, IDoKhanRepository doKhanRepository, IDoMatRepository domatRepository,IDVRepository dvRepository,
             IKhoLuuTruRepository kholuutruRepository, ILoaiBQRepository loaibqRepository, ILuuTruRepository luutruRepository, ILVBRepository lvbRepository,
             IMenuRepository menuRepository,INBHRepository nbhRepository, INNDRepository nndRepository, INNVBRepository nnvbRepository, IPhongRepository phongRepository,
             ISVBRepository svbRepository, ITDKRepository tdkRepository, IUsersRepository usersRepository) 
           {
            _ccqbhRepository = ccqbhRepository;
            _cqbhRepository = cqbhRepository;
            _capsoRepository = capsoRepository;
            _cv_diRepository = cv_diRepository;
            _dokhanRepository = doKhanRepository;
            _domatRepository = domatRepository;
            _dvRepository = dvRepository;
            _kholuutruRepository = kholuutruRepository;
            _loaibqRepository = loaibqRepository;
            _luutruRepository = luutruRepository;
            _lvbRepository = lvbRepository;
            _menuRepository = menuRepository;
            _nbhRepository = nbhRepository;
            _nndRepository = nndRepository;
            _nnvbRepository = nnvbRepository;
            _phongRepository = phongRepository;
            _svbRepository = svbRepository;
            _tdkRepository = tdkRepository;
            _usersRepository = usersRepository;
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
        public IKhoLuuTruRepository KhoLuuTruRepository
        {
            get
            {
                return _kholuutruRepository;
            }
        }
        public ILoaiBQRepository LoaiBQRepository
        {
            get
            {
                return _loaibqRepository;
            }
        }
        public ILuuTruRepository LuuTruRepository
        {
            get
            {
                return _luutruRepository;
            }
        }
        public ILVBRepository LVBRepository
        {
            get
            {
                return _lvbRepository;
            }
        }
        public IMenuRepository MenuRepository
        {
            get
            {
                return _menuRepository;
            }
        }
        public INBHRepository NBHRepository
        {
            get
            {
                return _nbhRepository;
            }
        }
        public INNDRepository NNDRepository
        {
            get
            {
                return _nndRepository;
            }
        }
        public INNVBRepository NNVBRepository
        {
            get
            {
                return _nnvbRepository;
            }
        }
        public IPhongRepository PhongRepository
        {
            get
            {
                return _phongRepository;
            }
        }
        public ISVBRepository SVBRepository
        {
            get
            {
                return _svbRepository;
            }
        }
        public ITDKRepository TDKRepository
        {
            get
            {
                return _tdkRepository;
            }
        }
        public IUsersRepository UsersRepository
        {
            get
            {
                return _usersRepository;
            }
        }
    }
}
