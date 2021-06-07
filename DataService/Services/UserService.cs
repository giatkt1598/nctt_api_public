using DataService.Commons;
using DataService.Models.Entities;
using DataService.Models.RequestModels;
using DataService.Models.ResponseModels;
using System.Linq;
using System.Threading.Tasks;
using DataService.Models.ViewModels;
using Microsoft.Extensions.Configuration;
using AutoMapper;
using DataService.BaseConnect;
using DataService.Repositories;

namespace DataService.Services
{
    public partial interface IUserService
    {
        public Task<AuthenticateResponse> Authenticate(AuthenticateRequest model);
        public Task<AuthenticateResponse> RefreshToken(string token);
    }
    public partial class UserService
    {
        private readonly IUserRoleRepository _userRoleRepository;
        public UserService(IUnitOfWork unitOfWork, IUserRepository repository,
            IConfiguration configuration, IMapper mapper, 
            IUserRoleRepository userRepository) : base(unitOfWork, repository)
        {
            ConnectionString = configuration.GetConnectionString("Default");
            this.Mapper = mapper;
            _userRoleRepository = userRepository;
        }
        public async Task<AuthenticateResponse> Authenticate(AuthenticateRequest model)
        {
            User user = await FirstOrDefaultAsync(x => x.UserName == model.UserName
                && x.Actived == true);
            if (user == null || !AccessTokenManager
                .VerifyHashedPassword(user.PasswordHash, model.Password))
                return null;
            string[] roles = _userRoleRepository.Get(x => x.UserId == user.Id)
                .Select(x => x.RoleId.ToString()).ToArray();
            string accessToken = AccessTokenManager
                .GenerateJwtToken(user.UserName, roles, user.Id);
            string refreshToken = AccessTokenManager.GenerateJwtRefreshToken(user.Id);
            return new AuthenticateResponse
            {
                User = Mapper.Map<UserViewModel>(user),
                AccessToken = accessToken,
                RefreshToken = refreshToken
            };
        }

        public async Task<AuthenticateResponse> RefreshToken(string token)
        {
            int? id = AccessTokenManager.VerifyRefreshToken(token);
            if (id == null)
            {
                return null;
            }
            User user = await FirstOrDefaultAsync(x => x.Id == id.Value && x.Actived == true);
            if (user == null)
            {
                return null;
            }
            string[] roles = _userRoleRepository.Get(x => x.UserId == user.Id)
                .Select(x => x.RoleId.ToString()).ToArray();
            string accessToken = AccessTokenManager
                .GenerateJwtToken(user.UserName, roles, user.Id);
            string refreshToken = AccessTokenManager.GenerateJwtRefreshToken(user.Id);
            return new AuthenticateResponse
            {
                User = Mapper.Map<UserViewModel>(user),
                AccessToken = accessToken,
                RefreshToken = refreshToken
            };
        }
    }
}
