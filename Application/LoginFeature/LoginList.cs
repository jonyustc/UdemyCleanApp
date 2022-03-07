using Application.Interfaces;
using Domain;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.LoginFeature
{
    public class LoginList
    {
        public class LoginRequestQuery : IRequest<IReadOnlyList<BM_SecUser>>
        {

        }

        public class LoginRequestHandler : IRequestHandler<LoginRequestQuery, IReadOnlyList<BM_SecUser>>
        {
            private readonly IReposotory<BM_SecUser> _listRepo;

            public LoginRequestHandler(IReposotory<BM_SecUser> listRepo)
            {
                _listRepo = listRepo;
            }

            public async Task<IReadOnlyList<BM_SecUser>> Handle(LoginRequestQuery request, CancellationToken cancellationToken)
            {
                return await _listRepo.GetListAsync();
            }
        }
    }
}
