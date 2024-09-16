using AutoMapper;
using MocatiCar.Core.Domain.Identity;
using MocatiCar.Core.SeedWorks;
using MocatiCar.Core.Services;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoncatiCar.Data.Services
{
    public class FavoriteCarService : IFavoriteCarService
    {
        private readonly IRepositoryManager _repositoryManager;
        private readonly IMapper _mapper;
        private readonly UserManager<AppUser> _userManager;
        public FavoriteCarService(IRepositoryManager repositoryManager, IMapper mapper, UserManager<AppUser> userManager) {

            _repositoryManager = repositoryManager;
            _mapper = mapper;
            _userManager = userManager;
        }
    }
}
